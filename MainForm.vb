' some important sources for techniques used here:
'https://eshkay.wordpress.com/2013/03/25/vb-net-serial-port-communication-with-datareceived-event/
'https://msdn.microsoft.com/en-us/library/ms171728.aspx

Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Text.RegularExpressions
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Threading

Public Class MainForm
    Dim captureFile As System.IO.StreamWriter ' this is the log file to capture data
    Dim captureFileName As String = "" ' this is the name of the log file to capture data
    Public positionSeries As New Series
    Public velocitySeries As New Series
    Public fftSeries As New Series
    Public fftSeries2 As New Series
    Public chartcounter As UInt64
    Dim FFTdone As Boolean = True
    ' Creates and initializes a new Queue.
    Public displacementQueuex As New Queue()
    Public displacementQueuey As New Queue()
    Dim velocityQueuex As New Queue()
    Dim velocityQueuey As New Queue()
    'defining the menu items for the main menu bar
    Dim menuItems As New List(Of MenuItem)
    Dim myMenuItemConfiguration As New MenuItem("&Configuration")
    Dim myMenuItemLogFile As New MenuItem("&Select Log File")
    Dim myMenuItemCompensation As New MenuItem("&Environmental Compensation")
    Dim myMenuItemTestMode As New MenuItem("&Test Mode")
    Dim myMenuItemUSBPort As New MenuItem("&USB Port")
    Dim myMenuItemHelp As New MenuItem("&Help")
    Dim myMenuItemUSBSubMenuCOMPorts As New MenuItem("&DummyText")

    'defining the main menu bar
    Dim mnuBar As New MainMenu()
    ' buffer for serial port object
    Dim spDrLine As String = ""
    Dim spBuffer As String = ""
    Public zeroAdjustment As Double = 0  ' this is what we need to set the data back to zero
    Public unitCorrectionFactor As Double = 1.0 ' 1.0 = nm 0.001 = um etc
    Public angleCorrectionFactor As Double = 3600.0 ' 3600 = arcsec 60 = arcmin 1 = degree
    Public multiplier As Integer = 2    ' needed for interferometer type 1x 2x 4x
    Public straightnessMultiplier As Integer = 1 ' needed for straightness measurements
    Public currentValue As Double = 0
    Public previousValue As Double = 0
    Dim velocityValue As Double = 0
    Dim angleValue As Double = 0
    Dim averagingValue As Double = 0
    Public displayValue As Double = 0
    Dim velocityValueList As New List(Of Double)
    Dim averagingFromPrevious As Double = 0
    Public average As Double = 0
    Public TestmodeFlag As Integer = 0
    Public Dimension As Integer = 1024     ' this value determines both the size of the plot graphs and the number of data points in the DFT
    Dim RealPartOfDFT(CInt(Dimension / 2)) As Double
    Dim averagingFromCurrent As Double = 0
    Dim ImaginaryPartOfDFT(CInt(Dimension / 2)) As Double
    Public needsInitialZero As Integer = 0
    Dim outerLoopCounter, innerLoopCounter As Integer
    Public DifferenceValue As Double = 0
    Dim CurrentREFCount As UInt64 = 0
    Dim PreviousREFCount As UInt64 = 0
    Dim CurrentMEASCount As UInt64 = 0
    Dim PreviousMEASCount As UInt64 = 0
    Public ErrorFlag As Integer = 0
    Public SuspendFlag As Integer = 0
    Dim MeasCountCorrection As UInt64 = 0
    Public CurrentValueCorrection As Double = 0
    Dim SuspenREFCount As UInt64 = 0
    Dim SuspendMEASCount As UInt64 = 0
    Dim graphCount As UInt64 = CULng(Dimension)
    Dim plotCount As UInt64 = CULng(Dimension)
    Public SuspendCurrentValue As Double = 0
    Public REFFrequency As Double = 0
    Public MEASFrequency As Double = 0
    Public DIFFFrequency As Double = 0
    Dim previousREFFrequency As Double = 0
    Dim previousMEASFrequency As Double = 0
    Dim currentREFFrequency As Double = 0
    Dim currentMEASFrequency As Double = 0
    Dim previousDIFFFrequency As Double = 0
    Dim currentDIFFFrequency As Double = 0
    Public previousserialnumber As UInt64 = 0
    Dim serialnumberdifference As UInt64 = 0
    Public Temperature As Double = 20
    Public Pressure As Double = 1000
    Public Humidity As Double = 50
    Public TemperatureC As Double = 20
    Public PressureATM As Double = 1000
    Public HumidityRel As Double = 50
    Public TCorrection As Double = 1
    Public PCorrection As Double = 1
    Public HCorrection As Double = 1
    Public Wavelength As Double = 632.991372
    Public ECFactor As Double = 1
    Public simulationDistance As Int64 = 0
    Public previousSimulationDistance As Int64 = 0
    Public waveform As Double = 0
    Public simulationVelocity As Int64 = 0
    Public previoussimulationVelocity As Int64 = 0
    Public previoussimREFCount As Int64 = 0
    Public previoussimMEASCount As Int64 = 0
    Public simulationSerial As UInt64 = 0
    Public bangbang As Double = 1
    'Public outerloop As Integer = 0
    'Public count As Long = 0
    Public counter As Double = 0
    Dim simulatedData As String
    Public simrefcount As Int64 = 0
    Public simmeascount As Int64 = 0
    Public simcount As Double = 0
    Public TMUnitsFactor As Double = 0
    Public TMFreqMult As Double = 1
    Public TMAmpMult As Double = 1
    Public TMOfsMult As Double = 1
    Public TMFreqValue As Double = 1
    Public TMAmpValue As Double = 1
    Public TMOfsValue As Double = 1
    Public EDEnabled As Integer = 1
    Dim TimeScale As Integer = 5
    'Dim DFTThread As New Thread(AddressOf DFT)
    Private DFTThread As New System.ComponentModel.BackgroundWorker 'set new backgroundworker
    Dim resetEvent As ManualResetEvent = New ManualResetEvent(False)
    Public IgnoreCount As Integer = 0
    Public phase As Double = 0

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'SerialPort1.Close() ' this hangs the program. known MS bug https://social.msdn.microsoft.com/Forums/en-US/ce8ce1a3-64ed-4f26-b9ad-e2ff1d3be0a5/serial-port-hangs-whilst-closing?forum=Vsexpressvcs
        'End
        captureFile.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler DFTThread.DoWork, AddressOf DFT

        DisplacementButton_Click(sender, e)
        Chart1.Series.Clear()
        Chart1.ChartAreas(0).AxisX.LabelStyle.Enabled = False
        Chart1.ChartAreas(0).AxisX.MajorTickMark.Enabled = False
        Chart1.ChartAreas(0).AxisY.MajorTickMark.Enabled = False
        Chart1.ChartAreas(0).AxisX.MinorTickMark.Enabled = False
        Chart1.ChartAreas(0).AxisY.MinorTickMark.Enabled = False
        Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "e2" 'https://msdn.microsoft.com/en-us/library/dwhawy9k.aspx
        Chart1.ChartAreas(0).AxisY.LabelAutoFitStyle = LabelAutoFitStyles.None
        Chart1.ChartAreas(0).AxisX.LabelStyle.Font = New System.Drawing.Font("Trebuchet MS", 2.25F, System.Drawing.FontStyle.Bold)
        positionSeries.ChartType = SeriesChartType.FastLine
        For chartcounter = 0 To CULng(Dimension - 1)
            positionSeries.Points.AddXY(chartcounter, 0.5 * Math.Sin(chartcounter / 40))
        Next
        velocitySeries.ChartType = SeriesChartType.FastLine
        Chart1.Series.Add(positionSeries)
        For chartcounter = 0 To CULng(Dimension - 1)
            velocitySeries.Points.AddXY(chartcounter, 0.5 * Math.Cos(chartcounter / 40))
            velocityValueList.Add(0.0)  ' make sure the list is not empty
        Next
        DFTThread.RunWorkerAsync()
        fftSeries.ChartType = SeriesChartType.FastLine
        'first lets create an empty submenu for the com port list under the USB top menu
        menuItems.Add(myMenuItemUSBSubMenuCOMPorts)    ' need an empty list to be able to delete/change them at runtime
        'Next, attach that list to the USB top menu
        myMenuItemUSBPort.MenuItems.Add(myMenuItemUSBSubMenuCOMPorts)
        ' Next attach all the top menus to the menu bar.
        mnuBar.MenuItems.Add(myMenuItemLogFile)
        mnuBar.MenuItems.Add(myMenuItemConfiguration)
        mnuBar.MenuItems.Add(myMenuItemCompensation)
        mnuBar.MenuItems.Add(myMenuItemTestMode)
        mnuBar.MenuItems.Add(myMenuItemHelp)
        mnuBar.MenuItems.Add(myMenuItemUSBPort)
        ' Next replace the application with the menu bar we just crafted
        Me.Menu = mnuBar
        ' Finally, add the handlers to the menu items so that they can respond to clicks
        AddHandler myMenuItemLogFile.Click, AddressOf Me.myMenuItemLogFile_Click
        AddHandler myMenuItemConfiguration.Click, AddressOf Me.myMenuItemConfiguration_Click
        AddHandler myMenuItemCompensation.Click, AddressOf Me.myMenuItemCompensation_Click
        AddHandler myMenuItemTestMode.Click, AddressOf Me.myMenuItemTestMode_Click
        AddHandler myMenuItemUSBPort.Popup, AddressOf Me.myMenuItemUSBPort_Click
        AddHandler myMenuItemHelp.Click, AddressOf Me.myMenuItemhelp_Click

        ' load user settings
        'multiplier = My.Settings.Multiplier
        unitCorrectionFactor = My.Settings.UnitCorrectionFactor
        If unitCorrectionFactor = 1.0 Then
            UnitLabel.Text = "nm"
        ElseIf unitCorrectionFactor = 0.001 Then
            UnitLabel.Text = "um"
        ElseIf unitCorrectionFactor = 0.000001 Then
            UnitLabel.Text = "mm"
        ElseIf unitCorrectionFactor = 0.0000001 Then
            UnitLabel.Text = "cm"
        ElseIf unitCorrectionFactor = 0.000000001 Then
            UnitLabel.Text = "m"
        ElseIf unitCorrectionFactor = 0.00000003937 Then
            UnitLabel.Text = "in"
        ElseIf unitCorrectionFactor = 0.0000000032808 Then
            UnitLabel.Text = "ft"
        End If
        angleCorrectionFactor = My.Settings.AngleCorrectionFactor
        If angleCorrectionFactor = 1.0 Then
            AngleLabel.Text = "degree"
        ElseIf angleCorrectionFactor = 60.0 Then
            AngleLabel.Text = "arcmin"
        ElseIf angleCorrectionFactor = 3600.0 Then
            AngleLabel.Text = "arcsec"
        End If
        averagingValue = My.Settings.AveragingValue
        TrackBar1.Value = CInt(averagingValue)
        AverageLabel.Text = (0 + TrackBar1.Value / 100).ToString("F")
        Label_Range_s.Visible = False
        Timer1.Start()

    End Sub

    Private Sub Comport_Click(sender As Object, e As EventArgs)
        ' extract COM port name
        Dim comportstrting As String = sender.ToString
        Dim a() As String = Regex.Split(comportstrting, "Text: ")
        'MsgBox(a(1))
        ' open COM port
        If SerialPort1.IsOpen = False Then
            Try
                SerialPort1.Close()
            Catch ex As Exception
                ' nothing
            End Try
            SerialPort1.PortName = a(1)
            SerialPort1.BaudRate = 115200
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.DataBits = 8
            SerialPort1.Handshake = Handshake.None
            SerialPort1.NewLine = vbCr
            SerialPort1.DtrEnable = True 'important
            SerialPort1.RtsEnable = True 'important
            Try
                SerialPort1.Open()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            zeroAdjustment = currentValue
            previousValue = currentValue
            SuspendCurrentValue = 0
            simcount = 0
            'count = 0
            counter = 0
            needsInitialZero = 1 ' make sure to zero out the reference system
        End If
    End Sub

    Private Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            If SerialPort1.IsOpen Then
                Dim incomingData As String = SerialPort1.ReadExisting()
                If Not (captureFile Is Nothing) Then
                    captureFile.Write(incomingData)
                End If
                spDrLine = spDrLine & incomingData 'important
                If InStr(1, spDrLine, vbLf) > 0 Then
                    spBuffer = spDrLine.Substring(0, spDrLine.LastIndexOf(vbLf)) ' pull in the buffer up to the last line feed
                    spDrLine = spDrLine.Substring(spDrLine.LastIndexOf(vbLf) + 1) 'stuff the rest back into the incoming buffer
                    'If Not (captureFile Is Nothing) Then
                    'captureFile.WriteLine(spDrLine)
                    'End If
                    'process spBuffer
                    Try
                        If False = SimulationTimer.Enabled Then
                            Me.SetText(spBuffer)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SetText(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the 
        ' calling thread to the thread ID of the creating thread. 
        ' If these threads are different, it returns true. 
        Dim k As Integer
        If Me.Chart1.InvokeRequired Then    'what is good for chart1 is also good for chart2
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Try
                ' first split data into sets
                Dim sets() As String = [text].Split(vbLf.ToCharArray)
                For k = 0 To sets.Length - 1
                    Dim values() As String = sets(k).Split(" ".ToCharArray)
                    'make sure the current set has exactly 10 fields
                    If values.Length.Equals(10) Then
                        'Console.Write(values(3) + vbCrLf)

                        currentValue = Convert.ToDouble(values(3)) * Wavelength / 2 * ECFactor - CurrentValueCorrection ' Difference in nm; 1/2 wavelength, because path traveled at least twice
                        previousValue = Convert.ToDouble(values(6)) * Wavelength / 2 * ECFactor - CurrentValueCorrection

                        If IgnoreCount = 0 Then
                            If needsInitialZero = 1 Then
                                zeroAdjustment = currentValue
                                SuspendCurrentValue = 0
                                'previousValue = currentValue
                                If Suspend.Text.Equals("Resume") Then  ' Force exit from Suspend mode
                                    Suspend.Text = "Suspend"
                                    Suspend.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
                                    Suspend.ForeColor = Color.FromKnownColor(KnownColor.Black)
                                    'CurrentValueCorrection = 0
                                    SuspendFlag = 0
                                    ErrorFlag = 0
                                End If
                                'simcount = 0
                                'count = 0
                                'counter = 0
                                needsInitialZero = 0 ' make sure to zero out the reference system only once
                            End If
                        End If

                        PreviousREFCount = CurrentREFCount ' Keep track of raw REF and MEAS counts
                        CurrentREFCount = Convert.ToUInt64(values(1))

                        PreviousMEASCount = CurrentMEASCount
                        CurrentMEASCount = Convert.ToUInt64(values(0))

                        Try
                            serialnumberdifference = Convert.ToUInt64(values(9)) - previousserialnumber
                        Catch
                        End Try

                        If 1 = serialnumberdifference Then
                            REFFrequency = (CurrentREFCount - PreviousREFCount) / 1638
                            MEASFrequency = (CurrentMEASCount - PreviousMEASCount) / 1638
                            DIFFFrequency = MEASFrequency - REFFrequency

                            If SuspendFlag = 0 Then
                                If IgnoreCount = 0 Then
                                    ' If ErrorFlag = 0 Then
                                    If EDEnabled = 1 Then
                                        If CurrentREFCount - PreviousREFCount = 0 Then
                                            ErrorFlag = ErrorFlag Or 1 ' REF is dead => REF (Head) Error
                                        End If
                                        If CurrentMEASCount - PreviousMEASCount = 0 Then  ' MEAS is dead => MEAS (Path) Error
                                            ErrorFlag = ErrorFlag Or 2 ' MEAS is dead = > MEAS (Path) Error
                                        End If
                                        If MEASFrequency > ((2 * REFFrequency) - 0.1) Then
                                            ErrorFlag = ErrorFlag Or 4 ' Excessive stage speed positive => Slew (Rate) error
                                        End If
                                        If MEASFrequency < 0.1 Then
                                            ErrorFlag = ErrorFlag Or 8 ' Excessive stage speed negative => Slew (Rate) error
                                        End If
                                        'End If
                                    End If
                                    ' Else : IgnoreCount = IgnoreCount - 1


                                End If
                            End If

                            velocityValue = (previousValue - currentValue) * 610.35 ' 610.35 Hz update rate in PIC timer
                            'Console.Write(" sample duplicate" + vbCrLf)
                            If TestmodeFlag = 1 Then
                                velocityValue = velocityValue / 3.0425
                            End If

                            If SuspendFlag = 0 Then

                                If VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then ' velocity mode, no averaging
                                    average = velocityValue / multiplier
                                Else
                                    averagingFromPrevious = (0 + TrackBar1.Value / 100) * average ' nm
                                    averagingFromCurrent = (1.0 - TrackBar1.Value / 100) * straightnessMultiplier * (currentValue - zeroAdjustment) / multiplier
                                    average = averagingFromPrevious + averagingFromCurrent
                                End If
                                If AngleButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then ' angle mode
                                    displayValue = Math.Asin(average / 32.61 / 1000000) * angleCorrectionFactor * 57.296 ' arcsin(Dmm / 32.61) and Radians to arcsecs
                                Else
                                    displayValue = average * unitCorrectionFactor
                                End If
                                If GraphControl.Text.Equals("Disable Graph") And IgnoreCount = 0 Then
                                    displacementQueuex.Enqueue(chartcounter)
                                    displacementQueuey.Enqueue(straightnessMultiplier * unitCorrectionFactor * (currentValue - zeroAdjustment) / multiplier)
                                    velocityQueuex.Enqueue(chartcounter)
                                    velocityQueuey.Enqueue(unitCorrectionFactor * velocityValue / multiplier)
                                    chartcounter = CULng(chartcounter + 1)
                                End If

                            End If

                        ElseIf 0 = serialnumberdifference Then
                            Console.Write(" sample duplicate" + vbCrLf)
                        Else
                            Console.Write((Convert.ToUInt64(values(9)) - previousserialnumber - 1).ToString + " sample(s) number skipped" + vbCrLf)
                        End If
                    Else 'values.length incorrect
                        Console.Write("values.length incorrect " + values.Length.ToString + vbCrLf)
                    End If
                    Try
                        previousserialnumber = Convert.ToUInt64(values(9))
                    Catch
                    End Try
                Next
            Catch ex As Exception
                'MsgBox(ex.ToString)
            End Try
        End If
        If IgnoreCount > 0 Then
            IgnoreCount = IgnoreCount - 1
        Else : IgnoreCount = 0
        End If

    End Sub

    Delegate Sub SetTextCallback([text] As String)

    Private Sub myMenuItemUSBPort_Click(sender As Object, e As EventArgs)
        ' Add functionality to the menu items using the Click event.  

        ' clear menu first
        Dim currentMenu As MenuItem
        Dim i As Integer
        For i = menuItems.Count - 1 To 0 Step -1
            currentMenu = menuItems(i)
            myMenuItemUSBPort.MenuItems.Remove(currentMenu)
        Next
        menuItems.Clear()
        ' populate new items
        For Each sp As String In My.Computer.Ports.SerialPortNames
            Dim myMenuItemOpen As New MenuItem(sp)
            myMenuItemUSBPort.MenuItems.Add(myMenuItemOpen)
            menuItems.Add(myMenuItemOpen)
            AddHandler myMenuItemOpen.Click, AddressOf Me.Comport_Click
            mnuBar.MenuItems.Add(myMenuItemUSBPort)
        Next
    End Sub

    Private Sub myMenuItemhelp_Click(sender As Object, e As EventArgs)
        Help.ShowDialog()
    End Sub
    Private Sub myMenuItemLogFile_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()
        captureFileName = OpenFileDialog1.FileName.ToString()
        captureFile = My.Computer.FileSystem.OpenTextFileWriter(captureFileName, False)
    End Sub

    Private Sub myMenuItemConfiguration_Click(sender As Object, e As EventArgs)
        ' pop up configuration window
        Configuration11.Button1x.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Configuration11.Button2x.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Configuration11.Button4x.ForeColor = Color.FromKnownColor(KnownColor.Black)
        If multiplier.Equals(1) Then
            Configuration11.Button1x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf multiplier.Equals(2) Then
            Configuration11.Button2x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Else
            Configuration11.Button4x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        End If
        Configuration11.Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Configuration11.Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Configuration11.Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Configuration11.Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Configuration11.Buttonm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Configuration11.Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Configuration11.Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
        If unitCorrectionFactor = 1.0 Then
            Configuration11.Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf unitCorrectionFactor = 0.001 Then
            Configuration11.Buttonum.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf unitCorrectionFactor = 0.000001 Then
            Configuration11.Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf unitCorrectionFactor = 0.0000001 Then
            Configuration11.Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf unitCorrectionFactor = 0.000000001 Then
            Configuration11.Buttonm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf unitCorrectionFactor = 0.00000003937 Then
            Configuration11.Buttonin.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf unitCorrectionFactor = 0.0000000032808 Then
            Configuration11.Buttonft.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        End If
        Configuration11.Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Configuration11.Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Configuration11.Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.Black)
        If angleCorrectionFactor = 3600.0 Then
            Configuration11.Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf angleCorrectionFactor = 60.0 Then
            Configuration11.Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf angleCorrectionFactor = 1.0 Then
            Configuration11.Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        End If

        Configuration11.ShowDialog()
    End Sub

    Private Sub myMenuItemCompensation_Click(sender As Object, e As EventArgs)
        ' pop up compensation window
        Compensation.ShowDialog()
    End Sub

    Private Sub myMenuItemTestMode_Click(sender As Object, e As EventArgs)
        ' pop up Test Mode window
        TestMode.ShowDialog()
    End Sub

    Private Sub ZeroButton_Click(sender As Object, e As EventArgs) Handles ZeroButton.Click
        ErrorFlag = 0
        needsInitialZero = 1
        IgnoreCount = 0
    End Sub

    Private Sub DFT(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        ' not the fastest, but easy to implement
        ' https://en.wikipedia.org/wiki/Discrete_Fourier_transform

        Dim progresscount As Integer = 0
        Thread.CurrentThread.Priority = ThreadPriority.BelowNormal
        Do
            Try
                resetEvent.WaitOne()
                resetEvent.Reset()
                For outerLoopCounter = 0 To CInt(((Dimension / 2) - 1))
                    RealPartOfDFT(outerLoopCounter) = 0
                    ImaginaryPartOfDFT(outerLoopCounter) = 0
                Next outerLoopCounter
                For outerLoopCounter = 0 To CInt(((Dimension / 2) - 1))
                    For innerLoopCounter = 0 To (Dimension - 1)
                        RealPartOfDFT(outerLoopCounter) = RealPartOfDFT(outerLoopCounter) + velocityValueList(innerLoopCounter) * Math.Cos(2 * Math.PI * outerLoopCounter * innerLoopCounter / Dimension)
                        ImaginaryPartOfDFT(outerLoopCounter) = ImaginaryPartOfDFT(outerLoopCounter) - velocityValueList(innerLoopCounter) * Math.Sin(2 * Math.PI * outerLoopCounter * innerLoopCounter / Dimension)
                    Next innerLoopCounter
                Next outerLoopCounter
                FFTdone = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Loop
    End Sub

    Private Sub DisplacementButton_Click(sender As Object, e As EventArgs) Handles DisplacementButton.Click
        DisplacementButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        DisplacementButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        VelocityButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        If TestmodeFlag = 0 Then
            AngleButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            AngleButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            StraightnessLongButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            StraightnessLongButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            StraightnessShortButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            StraightnessShortButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        End If
        FrequencyButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Chart1.Series.Clear()
        Chart1.Series.Add(positionSeries)
        UnitLabel.Visible = True
        TimeLabel.Visible = False
        Graph_Label.Text = "Displacement"
        If GraphControl.Text.Equals("Enable Graph") Then
            Label_Range.Visible = False
            ComboBox_Range_UnitsD.Visible = False
        Else
            Label_Range.Visible = True
            ComboBox_Range_UnitsD.Visible = True
        End If
        Label_Range_s.Visible = False
        Compression_Label.Text = "Time Compression"
        Label_Range.Text = "Displacement Range"
        ComboBox_Range_UnitsA.Visible = False
        Graph_Label.Text = "Displacement"
        AngleLabel.Visible = False
        straightnessMultiplier = 1
    End Sub

    Private Sub VelocityButton_Click(sender As Object, e As EventArgs) Handles VelocityButton.Click
        DisplacementButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        DisplacementButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        VelocityButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        If TestmodeFlag = 0 Then
            AngleButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            AngleButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            StraightnessLongButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            StraightnessLongButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            StraightnessShortButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            StraightnessShortButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        End If
        FrequencyButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Chart1.Series.Clear()
        Chart1.Series.Add(velocitySeries)
        UnitLabel.Visible = True
        TimeLabel.Visible = True
        AngleLabel.Visible = False
        If GraphControl.Text.Equals("Enable Graph") Then
            Label_Range.Visible = False
            ComboBox_Range_UnitsD.Visible = False
            Label_Range_s.Visible = False
        Else
            Label_Range.Visible = True
            ComboBox_Range_UnitsD.Visible = True
            Label_Range_s.Visible = True
        End If
        Compression_Label.Text = "Time Compression"
        Label_Range.Text = "Velociy Range"
        ComboBox_Range_UnitsA.Visible = False
        Graph_Label.Text = "Velocity"
    End Sub

    Private Sub AngleButton_Click(sender As Object, e As EventArgs) Handles AngleButton.Click
        If TestmodeFlag = 0 Then
            DisplacementButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            DisplacementButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            VelocityButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            AngleButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            AngleButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            StraightnessLongButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            StraightnessLongButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            StraightnessShortButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            StraightnessShortButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            FrequencyButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Chart1.Series.Clear()
            Chart1.Series.Add(positionSeries)
            UnitLabel.Visible = False
            TimeLabel.Visible = False
            AngleLabel.Visible = True
            straightnessMultiplier = 1
            If GraphControl.Text.Equals("Enable Graph") Then
                Label_Range.Visible = False
                ComboBox_Range_UnitsA.Visible = False
            Else
                Label_Range.Visible = True
                ComboBox_Range_UnitsA.Visible = True
            End If
            Label_Range_s.Visible = False
            Compression_Label.Text = "Time Compression"
            Label_Range.Text = "Angle Range"
            ComboBox_Range_UnitsD.Visible = False
            Graph_Label.Text = "    Angle    "
            AngleLabel.Visible = True
        End If
    End Sub

    Private Sub StraightnessLongButton_Click(sender As Object, e As EventArgs) Handles StraightnessLongButton.Click
        If TestmodeFlag = 0 Then
            DisplacementButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            DisplacementButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            VelocityButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            AngleButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            AngleButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            StraightnessLongButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            StraightnessLongButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            StraightnessShortButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            StraightnessShortButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            FrequencyButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Chart1.Series.Clear()
            Chart1.Series.Add(positionSeries)
            UnitLabel.Visible = True
            TimeLabel.Visible = False
            AngleLabel.Visible = False
            straightnessMultiplier = 360
            If GraphControl.Text.Equals("Enable Graph") Then
                Label_Range.Visible = False
                ComboBox_Range_UnitsD.Visible = False
            Else
                Label_Range.Visible = True
                ComboBox_Range_UnitsD.Visible = True
            End If
            Label_Range_s.Visible = False
            Compression_Label.Text = "Time Compression"
            Label_Range.Text = "Straightness Long Range"
            ComboBox_Range_UnitsA.Visible = False
            Graph_Label.Text = "Straightness Long"
            AngleLabel.Visible = False
            ComboBox_Range_UnitsA.Visible = False
        End If
    End Sub

    Private Sub StraightnessShortButton_Click(sender As Object, e As EventArgs) Handles StraightnessShortButton.Click
        If TestmodeFlag = 0 Then
            DisplacementButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            DisplacementButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            VelocityButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            AngleButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            AngleButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            StraightnessLongButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            StraightnessLongButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            StraightnessShortButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            StraightnessShortButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            FrequencyButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Chart1.Series.Clear()
            Chart1.Series.Add(positionSeries)
            UnitLabel.Visible = True
            TimeLabel.Visible = False
            AngleLabel.Visible = False
            straightnessMultiplier = 36
            If GraphControl.Text.Equals("Enable Graph") Then
                Label_Range.Visible = False
                ComboBox_Range_UnitsD.Visible = False
            Else
                Label_Range.Visible = True
                ComboBox_Range_UnitsD.Visible = True
            End If
            Label_Range_s.Visible = False
            Compression_Label.Text = "Time Compression"
            Label_Range.Text = "Straightness Short Range"
            ComboBox_Range_UnitsA.Visible = False
            Graph_Label.Text = "Straightness Short"
            AngleLabel.Visible = False
            ComboBox_Range_UnitsA.Visible = False
        End If
    End Sub

    Private Sub FrequencyButton_Click(sender As Object, e As EventArgs) Handles FrequencyButton.Click
        ComboBox_Range_UnitsD.Visible = False
        ComboBox_Range_UnitsA.Visible = False
        DisplacementButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        DisplacementButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        VelocityButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        If TestmodeFlag = 0 Then
            AngleButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            AngleButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            StraightnessLongButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            StraightnessLongButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
            StraightnessShortButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            StraightnessShortButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        End If
        FrequencyButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Chart1.Series.Clear()
        Chart1.Series.Add(fftSeries)
        UnitLabel.Visible = True
        TimeLabel.Visible = False
        AngleLabel.Visible = False
        straightnessMultiplier = 1
        If GraphControl.Text.Equals("Enable Graph") Then
            Label_Range.Visible = False
            ComboBox_Range_UnitsD.Visible = False
        Else
            Label_Range.Visible = True
            ComboBox_Range_UnitsD.Visible = True
        End If
        Label_Range_s.Visible = False
        Compression_Label.Text = "Time Compression"
        Label_Range.Text = "DFT Amplitude Range"
        ComboBox_Range_UnitsA.Visible = False
        AngleLabel.Visible = False
        ComboBox_Range_UnitsA.Visible = False
        Graph_Label.Text = "Frequency"
        Label_Range_s.Visible = False
        Compression_Label.Text = "Frequency Range"
        ComboBox_Range_UnitsD.Visible = False
        ComboBox_Range_UnitsA.Visible = False
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        averagingValue = TrackBar1.Value
        AverageLabel.Text = (0 + TrackBar1.Value / 100).ToString("F")
        My.Settings.AveragingValue = averagingValue
        My.Settings.Save()
    End Sub

    Private Sub GraphControl_Click(sender As Object, e As EventArgs) Handles GraphControl.Click
        If GraphControl.Text.Equals("Disable Graph") Then ' Turn graph off
            GraphControl.Text = "Enable Graph"
            Chart1.Hide()
            Me.Height = 298
            Graph_Label.Visible = False
            Compression_Label.Visible = False
            NumericUpDown_Scale.Visible = False
            ComboBox_Range.Visible = False
            ComboBox_Range_UnitsD.Visible = False
            Label_Range.Visible = False
            Label_Range_s.Visible = False
        Else
            GraphControl.Text = "Disable Graph" ' Turn graph on
            Chart1.Show()
            Me.Height = 600
            Graph_Label.Visible = True
            Compression_Label.Visible = True
            NumericUpDown_Scale.Visible = True
            ComboBox_Range.Visible = True
            ComboBox_Range_UnitsD.Visible = True
            Label_Range.Visible = True
            If VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                Label_Range_s.Visible = True
            End If
            If FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                ComboBox_Range_UnitsD.Visible = False
            End If
        End If
    End Sub

    Private Sub NumericUpDown_Scale_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Scale.ValueChanged
        TimeScale = CInt(NumericUpDown_Scale.Value)
    End Sub

    Private Sub Suspend_Click(sender As Object, e As EventArgs) Handles Suspend.Click
        If Suspend.Text.Equals("Suspend") Then  ' Enter Suspend mode
            Suspend.Text = "Resume"
            Suspend.BackgroundImage = InterferometerGUI.My.Resources.Resources.YellowButton1
            Suspend.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            SuspendCurrentValue = currentValue
            SuspendFlag = 1

        Else                                     ' Exit Suspend mode
            Suspend.Text = "Suspend"
            Suspend.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Suspend.ForeColor = Color.FromKnownColor(KnownColor.Black)
            CurrentValueCorrection = CurrentValueCorrection + currentValue - SuspendCurrentValue
            SuspendFlag = 0
            ErrorFlag = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' limit the update rate of the value to about 10 Hz
        Dim ScrollRate As Integer = CInt(NumericUpDown_Scale.Value)
        If IgnoreCount = 0 Then
            If REFFrequency > 0 Then
                REF.Text = REFFrequency.ToString("0.000")
                REF.Visible = True
            Else
                REF.Visible = False
            End If

            If MEASFrequency > 0 Then
                MEAS.Text = MEASFrequency.ToString("0.000")
                MEAS.Visible = True
            Else
                MEAS.Visible = False
            End If

            If REFFrequency > 0 And MEASFrequency > 0 Then
                DIFF.Text = (DIFFFrequency * 1000).ToString("#,##0.00")
                DIFF.Visible = True
            Else
                DIFF.Visible = False
            End If

            If IgnoreCount = 0 Then

                If SuspendFlag = 1 Then
                    ValueDisplay.Text = "Suspend   "

                ElseIf EDEnabled = 1 And ErrorFlag > 0 Then
                    If (ErrorFlag And 3) = 3 Then
                        ValueDisplay.Text = "No Signals Error  "
                    ElseIf (ErrorFlag And 3) = 1 Then
                        ValueDisplay.Text = "REF (Head) Error  "
                    ElseIf (ErrorFlag And 3) = 2 Then
                        ValueDisplay.Text = "MEAS (Path) Error  "
                    ElseIf (ErrorFlag And 4) = 4 Then
                        ValueDisplay.Text = "SLEW (Rate+) Error "
                    ElseIf (ErrorFlag And 8) = 8 Then
                        ValueDisplay.Text = "SLEW (Rate-) Error "
                    End If

                ElseIf AngleButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then ' angle mode
                    If angleCorrectionFactor = 3600.0 Then
                        ValueDisplay.Text = displayValue.ToString("##,###,###,###,##0.0") 'arcsec
                    ElseIf angleCorrectionFactor = 60.0 Then
                        ValueDisplay.Text = displayValue.ToString("###,###,###,##0.000") 'arcmin
                    ElseIf angleCorrectionFactor = 1.0 Then
                        ValueDisplay.Text = displayValue.ToString("##,###,###,##0.000,0") 'degree
                    End If
                Else
                    If unitCorrectionFactor = 1 Then
                        ValueDisplay.Text = displayValue.ToString("#,###,###,###,##0.0") 'nm
                    ElseIf unitCorrectionFactor = 0.001 Then
                        ValueDisplay.Text = displayValue.ToString("#,###,###,###,##0.0") 'um
                    ElseIf unitCorrectionFactor = 0.000001 Then
                        ValueDisplay.Text = displayValue.ToString("#,###,###,##0.000,0") 'mm
                    ElseIf unitCorrectionFactor = 0.0000001 Then
                        ValueDisplay.Text = displayValue.ToString("###,###,##0.000,00") 'cm
                    ElseIf unitCorrectionFactor = 0.000000001 Then
                        ValueDisplay.Text = displayValue.ToString("###,###,##0.000,000") 'm
                    ElseIf unitCorrectionFactor = 0.00000003937 Then
                        ValueDisplay.Text = displayValue.ToString("###,###,##0.000,00") 'in
                    ElseIf unitCorrectionFactor = 0.0000000032808 Then
                        ValueDisplay.Text = displayValue.ToString("###,###,##0.000,000") 'ft
                    End If
                End If
            End If
        End If

        If GraphControl.Text.Equals("Disable Graph") Then   ' are we graphing?
            Dim x1 As Double
            Dim y1 As Double
            Dim x2 As Double
            Dim y2 As Double
            While displacementQueuex.Count > 0
                x1 = CDbl(displacementQueuex.Dequeue())
                y1 = CDbl(displacementQueuey.Dequeue())
                x2 = CDbl(velocityQueuex.Dequeue())
                y2 = CDbl(velocityQueuey.Dequeue())
                graphCount = graphCount + CULng(1)
                If 0 = (graphCount Mod ScrollRate) Then
                    plotCount = plotCount + CULng(1)
                    positionSeries.Points.AddXY(plotCount, y1)
                    positionSeries.Points.RemoveAt(0)
                    velocitySeries.Points.AddXY(plotCount, y2)
                    velocitySeries.Points.RemoveAt(0)
                    velocityValueList.Add(y2)
                    velocityValueList.RemoveAt(0)
                End If
            End While
            ' DFT related
            Dim counter As Integer
            If FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then  ' are we doing dft?
                If True = FFTdone Then   ' make sure we are not still busy with the previous calculation
                    FFTdone = False
                    fftSeries.Points.Clear()
                    For counter = 0 To (CInt(((Dimension / 2) - 1)))
                        fftSeries.Points.AddXY(counter, (ImaginaryPartOfDFT(counter) * ImaginaryPartOfDFT(counter)) + (RealPartOfDFT(counter) * RealPartOfDFT(counter)))
                    Next
                    resetEvent.Set()
                End If
            End If
            'now update graphDIFF

            Dim thevalue As Int32
            Dim theresult As Boolean = Int32.TryParse(ComboBox_Range.Text, thevalue)
            If theresult Then   ' the field is numeric
                Chart1.ChartAreas(0).AxisY.Maximum = 3000
                Chart1.ChartAreas(0).AxisY.Minimum = -3300
                Chart1.ChartAreas(0).RecalculateAxesScale()
            Else    ' the field says auto
                Chart1.ChartAreas(0).AxisY.Maximum = 6000
                Chart1.ChartAreas(0).AxisY.Minimum = -6000
                Chart1.ChartAreas(0).RecalculateAxesScale()
            End If
            Compression_Label.Visible = True
            NumericUpDown_Scale.Visible = True
        End If
    End Sub

    Private Sub SimulationTimer_Tick(sender As Object, e As EventArgs) Handles SimulationTimer.Tick

        ' here we are simulating data of the form of (not all fields are parsed by SetText:

        ' 0 MEAS Count
        ' 1 REF Count
        ' 2 Difference
        ' 3 SIMDistance
        ' 4 "Previous
        ' 5 Difference
        ' 6 799668005
        ' 7 "overflow
        ' 8 counter: "
        ' 9 23442624:

        ' ignored     ignored     ignored     distance  ignored  ignored     velocity  ignored  ignored  serialcounter
        ' simulatedData = "46838240776 4767908780 Difference: " + simulationDistance.ToString + " Previous Difference: " + simulationDistance.ToString + " overflow counter: " + simulationSerial.ToString

        Dim counter As Integer

        For counter = 0 To 5
            simrefcount = simrefcount + CLng(TestMode.NumericUpDown_FGREF_Value.Value * 1638)
            simmeascount = simrefcount + CLng(simulationDistance * 0.162)

            If SuspendFlag = 0 Then
                If (simmeascount - previoussimMEASCount) > (2 * (simrefcount - previoussimREFCount) - 0.1) Then
                    simmeascount = previoussimMEASCount + CLng(2 * (simrefcount - previoussimREFCount) - 0.1)
                    IgnoreCount = 2
                End If

                If (simmeascount - previoussimMEASCount) < 0.1 Then
                    simmeascount = previoussimMEASCount + CLng(0.1)
                    IgnoreCount = 2
                End If

                If IgnoreCount = 0 Then
                    If TestMode.Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                        simulationDistance = CLng(12638 * (TMUnitsFactor * ((waveform + TestMode.TrackBar_Offset.Value) * 0.01 * TMAmpValue) * multiplier / 2))
                        waveform = 0

                    ElseIf TestMode.Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                        waveform = waveform + (0.00001 * TMFreqValue * TestMode.TrackBar_Offset.Value)
                        simulationDistance = CLng(12638 * TMUnitsFactor * (waveform * TMAmpMult) * multiplier / 2)

                    ElseIf TestMode.Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                        waveform = waveform + ((0.002 * TMFreqValue) * bangbang)
                        simulationDistance = CLng(12638 * TMUnitsFactor * ((waveform + TestMode.TrackBar_Offset.Value) * 0.01 * TMAmpValue * multiplier / 2))
                        If waveform > 1 Then
                            bangbang = -1
                        End If

                        If waveform < -1 Then
                            bangbang = 1
                        End If

                    ElseIf TestMode.Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                        waveform = waveform + Math.Cos(simcount * TMFreqValue * Math.PI / 1000 + phase) * TMFreqValue * Math.PI / 1000
                        simulationDistance = CLng(12638 * TMUnitsFactor * ((waveform + TestMode.TrackBar_Offset.Value) * 0.01 * TMAmpValue * multiplier / 2))
                    End If
                End If

                simcount = simcount + 1
            End If
            simulationVelocity = simulationDistance - previousSimulationDistance
            simulatedData = simmeascount.ToString("########### ") + simrefcount.ToString("########### ") + "Difference: " +
                simulationDistance.ToString + " Previous Difference " + previousSimulationDistance.ToString +
                " overflow counter: " + simulationSerial.ToString
            simulationSerial = simulationSerial + CULng(1)
            previousSimulationDistance = simulationDistance
            previoussimulationVelocity = simulationVelocity
            previoussimREFCount = simrefcount
            previoussimMEASCount = simmeascount
            Me.SetText(simulatedData)
        Next

    End Sub

    Private Sub REF_Click(sender As Object, e As EventArgs) Handles REF.Click
        ErrorFlag = ErrorFlag Or 1
    End Sub

    Private Sub MEAS_Click(sender As Object, e As EventArgs) Handles MEAS.Click
        ErrorFlag = ErrorFlag Or 2
    End Sub

    Private Sub DIFF_Click(sender As Object, e As EventArgs) Handles DIFF.Click
        If currentValue > previousValue Then ErrorFlag = 4 Else ErrorFlag = 8
    End Sub

    

    Private Sub Capture_Button_Click(sender As Object, e As EventArgs) Handles Capture_Button.Click
        If Capture_Button.Text.Equals("Enable Capture") Then ' Turn capture on
            Capture_Button.Text = "Disable Capture"
            Capture_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.GreenButton1
            Capture_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Else : Capture_Button.Text = "Enable Capture"
            Capture_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Capture_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        End If
    End Sub

End Class
