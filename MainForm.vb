' some important sources for techniques used here:
'https://eshkay.wordpress.com/2013/03/25/vb-net-serial-port-communication-with-datareceived-event/
'https://msdn.microsoft.com/en-us/library/ms171728.aspx

Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Text.RegularExpressions
Imports System.IO.Ports
Imports System.ComponentModel

Public Class MainForm
    ' Dim file As System.IO.StreamWriter

    Public positionSeries As New Series
    Public velocitySeries As New Series
    Public fftSeries As New Series
    Public chartcounter As UInt64
    ' Creates and initializes a new Queue.
    Dim displacementQueuex As New Queue()
    Dim displacementQueuey As New Queue()
    Dim velocityQueuex As New Queue()
    Dim velocityQueuey As New Queue()
    'defining the menu items for the main menu bar
    Dim menuItems As New List(Of MenuItem)
    Dim myMenuItemComPort As New MenuItem("&Com Port")
    Dim myMenuItemOptions As New MenuItem("&Options")
    Dim myMenuItemCompensation As New MenuItem("&Environmental Compensation")
    Dim myMenuItemTestMode As New MenuItem("&TestMode")
    Dim myMenuItemNew As New MenuItem("&New")
    Dim myMenuItemConfiguration As New MenuItem("&Configuration")
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
    Dim currentValue As Double = 0
    Dim previousValue As Double = 0
    Dim velocityValue As Double = 0
    Dim angleValue As Double = 0
    Dim averagingValue As Double = 0
    Dim displayValue As Double = 0
    Dim RealPartOfDFT(512) As Double
    Dim averagingFromCurrent As Double = 0
    Dim ImaginaryPartOfDFT(512) As Double
    Dim averagingFromPrevious As Double = 0
    Dim average As Double = 0
    Public TestmodeFlag As Integer = 0
    Dim Dimension As Integer = 1024
    Dim needsInitialZero As Integer = 0
    Dim outerLoopCounter, innerLoopCounter As Integer
    Dim DifferenceValue As Double = 0
    Dim CurrentREFCount As UInt64 = 0
    Dim PreviousREFCount As UInt64 = 0
    Dim CurrentMEASCount As UInt64 = 0
    Dim PreviousMEASCount As UInt64 = 0
    Dim ErrorFlag As Integer = 0
    Dim SuspendFlag As Integer = 0
    Dim MeasCountCorrection As UInt64 = 0
    Dim CurrentValueCorrection As Double = 0
    Dim SuspenREFCount As UInt64 = 0
    Dim SuspendMEASCount As UInt64 = 0
    Dim SuspendCurrentValue As Double = 0
    Dim REFFrequency As Double = 0
    Dim MEASFrequency As Double = 0
    Dim DIFFFrequency As Double = 0
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
    Public simulationSerial As UInt64 = 0
    Dim bangbang As Double = 1
    Public outerloop As Integer = 0
    Public count As Long = 0
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


    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'SerialPort1.Close() ' this hangs the program. known MS bug https://social.msdn.microsoft.com/Forums/en-US/ce8ce1a3-64ed-4f26-b9ad-e2ff1d3be0a5/serial-port-hangs-whilst-closing?forum=Vsexpressvcs
        'End
        'file.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        System.Windows.Forms.Application.EnableVisualStyles()

        DisplacementButton_Click(sender, e)
        'Dialog1.Button1x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)

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

        For chartcounter = 0 To 1023
            positionSeries.Points.AddXY(chartcounter, 0.5 * Math.Sin(chartcounter / 40))
        Next
        velocitySeries.ChartType = SeriesChartType.FastLine
        Chart1.Series.Add(positionSeries)
        For chartcounter = 0 To 1023
            velocitySeries.Points.AddXY(chartcounter, 0.5 * Math.Cos(chartcounter / 40))
        Next
        fftSeries.ChartType = SeriesChartType.FastLine

        menuItems.Add(myMenuItemNew)    ' need a list to be able to delete/change them at runtime

        ' Add functionality to the menu items using the Click event.

        'adding the menu items to the main menu bar

        myMenuItemOptions.MenuItems.Add(myMenuItemNew)
        mnuBar.MenuItems.Add(myMenuItemOptions)
        AddHandler myMenuItemOptions.Popup, AddressOf Me.myMenuItemFile1_Click

        AddHandler myMenuItemConfiguration.Click, AddressOf Me.myMenuItemOptions_Click
        myMenuItemOptions.MenuItems.Add(myMenuItemConfiguration)

        AddHandler myMenuItemCompensation.Click, AddressOf Me.myMenuItemCompensation_Click
        myMenuItemOptions.MenuItems.Add(myMenuItemCompensation)

        AddHandler myMenuItemTestMode.Click, AddressOf Me.myMenuItemTestMode_Click
        myMenuItemOptions.MenuItems.Add(myMenuItemTestMode)

        myMenuItemComPort.MenuItems.Add(myMenuItemNew)
        mnuBar.MenuItems.Add(myMenuItemComPort)
        AddHandler myMenuItemComPort.Popup, AddressOf Me.myMenuItemFile1_Click

        Me.Menu = mnuBar
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
        Timer1.Start()

        ' file = My.Computer.FileSystem.OpenTextFileWriter("data.txt", True)
    End Sub



    Private Sub menuItem2_Click(sender As Object, e As EventArgs)
        ' extract COM port name
        Dim comportstrting As String = sender.ToString
        Dim a() As String = Regex.Split(comportstrting, "Text: ")
        'MsgBox(a(1))
        ' open COM port
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
        needsInitialZero = 1 ' make sure to zero out the reference system
    End Sub

    Private Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            If SerialPort1.IsOpen Then
                Dim incomingData As String = SerialPort1.ReadExisting()
                'file.Write(incomingData)
                spDrLine = spDrLine & incomingData 'important
                If InStr(1, spDrLine, vbLf) > 0 Then
                    spBuffer = spDrLine.Substring(0, spDrLine.LastIndexOf(vbLf)) ' pull in the buffer up to the last line feed
                    spDrLine = spDrLine.Substring(spDrLine.LastIndexOf(vbLf) + 1) 'stuff the rest back into the incoming buffer
                    'file.WriteLine(spDrLine)
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
        If Me.Chart1.InvokeRequired Then    'what is good for chart1 is also good for chart2
            Dim d As New SetTextCallback(AddressOf SetText)
            If GraphControl.Text.Equals("Disable Graph") Then   ' are we graphing?
                If FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then  ' are we doing dft?
                    If (chartcounter Mod 2) = 0 Then    ' calculate every 2 values
                        DFT()
                    End If
                End If
            End If
            Me.Invoke(d, New Object() {[text]})
        Else
            Try
                ' first split data into sets
                Dim k As Integer
                Dim sets() As String = [text].Split(vbLf.ToCharArray)
                For k = 0 To sets.Length - 1
                    Dim values() As String = sets(k).Split(" ".ToCharArray)
                    'make sure the current set has exactly 10 fields
                    If values.Length.Equals(10) Then
                        'Console.Write(values(3) + vbCrLf)
                        currentValue = Convert.ToDouble(values(3)) * Wavelength / 2 * ECFactor - CurrentValueCorrection ' Difference in nm; 1/2 wavelength, because path traveled at least twice
                        previousValue = Convert.ToDouble(values(6)) * Wavelength / 2 * ECFactor - CurrentValueCorrection
                        PreviousREFCount = CurrentREFCount ' Keep track of raw REF and MEAS counts
                        CurrentREFCount = Convert.ToUInt64(values(1))
                        PreviousMEASCount = CurrentMEASCount
                        CurrentMEASCount = Convert.ToUInt64(values(0))
                        Try
                            serialnumberdifference = Convert.ToUInt64(values(9)) - previousserialnumber
                        Catch
                        End Try
                        If 1 = serialnumberdifference Then
                            previousREFFrequency = REFFrequency
                            currentREFFrequency = (CurrentREFCount - PreviousREFCount) / 1638 ' / serialnumberdifference
                            REFFrequency = (currentREFFrequency) ' / 60) + (59 / 60 * previousREFFrequency) ' Moving average to get finer resolution
                            previousMEASFrequency = MEASFrequency
                            currentMEASFrequency = (CurrentMEASCount - PreviousMEASCount) / 1638 ' / serialnumberdifference
                            MEASFrequency = (currentMEASFrequency) ' / 60) + (59 / 60 * previousMEASFrequency)
                            previousDIFFFrequency = DIFFFrequency
                            currentDIFFFrequency = MEASFrequency - REFFrequency
                            DIFFFrequency = (currentDIFFFrequency) ' / 60) + (59 / 60 * previousDIFFFrequency)
                            If SuspendFlag = 0 Then
                                If ErrorFlag = 0 Then
                                    If TestmodeFlag = 0 Then
                                        If CurrentREFCount - PreviousREFCount < 100 Then  ' REF is dead => Head Error
                                            ErrorFlag = 1
                                        End If
                                        If CurrentMEASCount - PreviousMEASCount < 100 Then  ' MEAS is dead => Path Error
                                            ErrorFlag = ErrorFlag Or 2 ' Both => Loss of Signals (LOS) Error
                                        End If
                                    End If
                                End If

                                If needsInitialZero = 1 Then
                                    zeroAdjustment = currentValue
                                    simcount = 0
                                    count = 0
                                    counter = 0
                                    needsInitialZero = 0 ' make sure to zero out the reference system only once
                                End If
                            End If

                            velocityValue = (previousValue - currentValue) * 610.35 ' 610.35 Hz update rate in PIC timer

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
                                If GraphControl.Text.Equals("Disable Graph") Then
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
                If GraphControl.Text.Equals("Disable Graph") Then   ' are we graphing?
                    Dim counter As Integer
                    If Color.FromKnownColor(KnownColor.ActiveCaptionText) = FrequencyButton.ForeColor Then    ' only have about 500 pixels to show 1000 points
                        fftSeries.Points.Clear()
                        For counter = 0 To 255
                            fftSeries.Points.AddXY(counter, (ImaginaryPartOfDFT(counter) * ImaginaryPartOfDFT(counter)) + (RealPartOfDFT(counter) * RealPartOfDFT(counter)))
                        Next
                    End If
                End If
            Catch ex As Exception
                'MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Delegate Sub SetTextCallback([text] As String)

    Private Sub myMenuItemFile1_Click(sender As Object, e As EventArgs)
        ' Add functionality to the menu items using the Click event.  

        ' clear menu first
        Dim currentMenu As MenuItem
        Dim i As Integer
        For i = menuItems.Count - 1 To 0 Step -1
            currentMenu = menuItems(i)
            myMenuItemComPort.MenuItems.Remove(currentMenu)
        Next
        menuItems.Clear()
        ' populate new items
        For Each sp As String In My.Computer.Ports.SerialPortNames
            Dim myMenuItemOpen As New MenuItem(sp)
            myMenuItemComPort.MenuItems.Add(myMenuItemOpen)
            menuItems.Add(myMenuItemOpen)
            AddHandler myMenuItemOpen.Click, AddressOf Me.menuItem2_Click
            mnuBar.MenuItems.Add(myMenuItemComPort)
        Next
    End Sub

    Private Sub myMenuItemOptions_Click(sender As Object, e As EventArgs)
        ' pop up configuration window

        Dialog1.Button1x.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Dialog1.Button2x.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Dialog1.Button4x.ForeColor = Color.FromKnownColor(KnownColor.Black)

        If multiplier.Equals(1) Then
            Dialog1.Button1x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf multiplier.Equals(2) Then
            Dialog1.Button2x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Else
            Dialog1.Button4x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        End If

        Dialog1.Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Dialog1.Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Dialog1.Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Dialog1.Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Dialog1.Buttonm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Dialog1.Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Dialog1.Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)

        If unitCorrectionFactor = 1.0 Then
            Dialog1.Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf unitCorrectionFactor = 0.001 Then
            Dialog1.Buttonum.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf unitCorrectionFactor = 0.000001 Then
            Dialog1.Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf unitCorrectionFactor = 0.0000001 Then
            Dialog1.Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf unitCorrectionFactor = 0.000000001 Then
            Dialog1.Buttonm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf unitCorrectionFactor = 0.00000003937 Then
            Dialog1.Buttonin.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf unitCorrectionFactor = 0.0000000032808 Then
            Dialog1.Buttonft.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        End If

        Dialog1.Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Dialog1.Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Dialog1.Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.Black)

        If angleCorrectionFactor = 3600.0 Then
            Dialog1.Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf angleCorrectionFactor = 60.0 Then
            Dialog1.Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ElseIf angleCorrectionFactor = 1.0 Then
            Dialog1.Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        End If

        Dialog1.Test_Button_Off.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Dialog1.Test_Button_On.ForeColor = Color.FromKnownColor(KnownColor.Black)

        If TestmodeFlag = 0 Then
            Dialog1.Test_Button_Off.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Else
            Dialog1.Test_Button_Off.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Dialog1.Test_Button_On.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        End If

        Dialog1.ShowDialog()

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
        zeroAdjustment = currentValue
        ErrorFlag = 0
        DifferenceValue = 0
        For chartcounter = 0 To 1023
            positionSeries.Points.AddXY(chartcounter, 0.0)
            positionSeries.Points.RemoveAt(0)
            velocitySeries.Points.AddXY(chartcounter, 0.0)
            velocitySeries.Points.RemoveAt(0)
        Next
        'clear queues
        displacementQueuex.Clear()
        displacementQueuey.Clear()
        displayValue = 0
        average = 0
    End Sub

    Private Sub DFT()
        ' not the fastest, but easy to implement
        ' https://en.wikipedia.org/wiki/Discrete_Fourier_transform

        If velocitySeries.Points.Count = 1024 Then
            Try
                For outerLoopCounter = 0 To 512
                    RealPartOfDFT(outerLoopCounter) = 0
                    ImaginaryPartOfDFT(outerLoopCounter) = 0
                Next outerLoopCounter
                For outerLoopCounter = 0 To 512
                    For innerLoopCounter = 0 To 1023
                        RealPartOfDFT(outerLoopCounter) = RealPartOfDFT(outerLoopCounter) + velocitySeries.Points(innerLoopCounter).YValues(0) * Math.Cos(2 * Math.PI * outerLoopCounter * innerLoopCounter / Dimension)
                        ImaginaryPartOfDFT(outerLoopCounter) = ImaginaryPartOfDFT(outerLoopCounter) - velocitySeries.Points(innerLoopCounter).YValues(0) * Math.Sin(2 * Math.PI * outerLoopCounter * innerLoopCounter / Dimension)
                    Next innerLoopCounter
                Next outerLoopCounter
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub DisplacementButton_Click(sender As Object, e As EventArgs) Handles DisplacementButton.Click
        DisplacementButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        DisplacementButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        VelocityButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        AngleButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        AngleButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        StraightnessLongButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        StraightnessLongButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        StraightnessShortButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        StraightnessShortButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        FrequencyButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Chart1.Series.Clear()
        Chart1.Series.Add(positionSeries)
        UnitLabel.Visible = True
        TimeLabel.Visible = False
        AngleLabel.Visible = False
        straightnessMultiplier = 1
        Graph_Label.Text = "Displacement"
    End Sub

    Private Sub VelocityButton_Click(sender As Object, e As EventArgs) Handles VelocityButton.Click
        DisplacementButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        DisplacementButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        VelocityButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        AngleButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        AngleButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        StraightnessLongButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        StraightnessLongButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        StraightnessShortButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        StraightnessShortButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        FrequencyButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Chart1.Series.Clear()
        Chart1.Series.Add(velocitySeries)
        UnitLabel.Visible = True
        TimeLabel.Visible = True
        AngleLabel.Visible = False
        Graph_Label.Text = "   Velocity   "
    End Sub

    Private Sub AngleButton_Click(sender As Object, e As EventArgs) Handles AngleButton.Click
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
        Graph_Label.Text = "    Angle    "
    End Sub

    Private Sub StraightnessLongButton_Click(sender As Object, e As EventArgs) Handles StraightnessLongButton.Click
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
        Graph_Label.Text = "Straightness Long"
    End Sub

    Private Sub StraightnessShortButton_Click(sender As Object, e As EventArgs) Handles StraightnessShortButton.Click
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
        Graph_Label.Text = "Straightness Short"
    End Sub

    Private Sub FrequencyButton_Click(sender As Object, e As EventArgs) Handles FrequencyButton.Click
        DisplacementButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        DisplacementButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        VelocityButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        AngleButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        AngleButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        StraightnessLongButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        StraightnessLongButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        StraightnessShortButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        StraightnessShortButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        FrequencyButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Chart1.Series.Clear()
        Chart1.Series.Add(fftSeries)
        UnitLabel.Visible = True
        TimeLabel.Visible = False
        AngleLabel.Visible = False
        straightnessMultiplier = 1
        Graph_Label.Text = "Frequency"
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        averagingValue = TrackBar1.Value
        AverageLabel.Text = (0 + TrackBar1.Value / 100).ToString("F")
        My.Settings.AveragingValue = averagingValue
        My.Settings.Save()
    End Sub



    Private Sub GraphControl_Click(sender As Object, e As EventArgs) Handles GraphControl.Click
        If GraphControl.Text.Equals("Disable Graph") Then
            GraphControl.Text = "Enable Graph"
            Chart1.Hide()
            Me.Height = 300
            Graph_Label.Visible = False
        Else
            GraphControl.Text = "Disable Graph"
            Chart1.Show()
            Me.Height = 600
            Graph_Label.Visible = True
        End If
    End Sub

    Private Sub Suspend_Click(sender As Object, e As EventArgs) Handles Suspend.Click
        If Suspend.Text.Equals("Suspend") Then  ' Enter Suspend mode
            Suspend.Text = "Resume"
            Suspend.BackgroundImage = InterferometerGUI.My.Resources.Resources.YelllowButton11
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

    Private Sub ValueDisplay_Click(sender As Object, e As EventArgs) Handles ValueDisplay.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' limit the update rate of the value to about 60 Hz

        MEAS.Text = MEASFrequency.ToString("0.000")
        REF.Text = REFFrequency.ToString("0.000")
        DIFF.Text = (DIFFFrequency * 1000).ToString("#,##0.00")

        If SuspendFlag = 1 Then
            ValueDisplay.Text = "Suspend   "
        ElseIf ErrorFlag = 3 Then
            ValueDisplay.Text = "LOS Error   "
        ElseIf ErrorFlag = 1 Then
            ValueDisplay.Text = "REF Error   "
        ElseIf ErrorFlag = 2 Then
            ValueDisplay.Text = "MEAS Error   "

        Else
            If AngleButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then ' angle mode
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

        If GraphControl.Text.Equals("Disable Graph") Then   ' are we graphing?
            Dim x As Double
            Dim y As Double
            While displacementQueuex.Count > 0
                x = CDbl(displacementQueuex.Dequeue())
                y = CDbl(displacementQueuey.Dequeue())
                positionSeries.Points.AddXY(x, y)
                positionSeries.Points.RemoveAt(0)
                x = CDbl(velocityQueuex.Dequeue())
                y = CDbl(velocityQueuey.Dequeue())
                velocitySeries.Points.AddXY(x, y)
                velocitySeries.Points.RemoveAt(0)
            End While
            Chart1.ResetAutoValues()
        End If
    End Sub

    Private Sub SimulationTimer_Tick(sender As Object, e As EventArgs) Handles SimulationTimer.Tick
        ' here we are simulating data of the form of (not all fields are parsed by SetText:
        ' 46838240776 47637908780 Difference: 799668004 Previous Difference: 799668005 overflow counter: 23442624
        ' ignored     ignored     ignored     distance  ignored  ignored     velocity  ignored  ignored  serialcounter
        ' simulatedData = "46838240776 4767908780 Difference: " + simulationDistance.ToString + " Previous Difference: " + simulationDistance.ToString + " overflow counter: " + simulationSerial.ToString

        If SuspendFlag = 0 Then
            'calculate the DFT once per timer if frequency display is selected.
            If GraphControl.Text.Equals("Disable Graph") Then   ' are we graphing?
                If FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then  ' are we doing dft?
                    If (chartcounter Mod 2) = 0 Then    ' calculate every 2 values
                        DFT()
                    End If
                End If
            End If

            For counter = 0 To 10

                simrefcount = simrefcount + 10 * 1638
                simmeascount = simrefcount + CLng((simulationDistance / 10) * 2 * 0.81)
                simcount = simcount + 1

                If TestMode.Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                    simulationDistance = CLng(12638 * (TMUnitsFactor * ((waveform + TestMode.TrackBar_Offset.Value) * 0.01 * TMAmpValue) * multiplier / 2))
                    waveform = 0

                ElseIf TestMode.Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                    waveform = waveform + (0.00001 * TMFreqValue * TestMode.TrackBar_Offset.Value)
                    simulationDistance = CLng(12638 * TMUnitsFactor * (waveform * TMAmpMult) * multiplier / 2)

                ElseIf TestMode.Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                    waveform = waveform + (0.002 * TMFreqValue * bangbang)
                    simulationDistance = CLng(12638 * TMUnitsFactor * ((waveform + TestMode.TrackBar_Offset.Value) * 0.01 * TMAmpValue * multiplier / 2))
                    If Math.Abs(waveform) > 1 Or Math.Abs(waveform) = 1 Then bangbang = -bangbang

                ElseIf TestMode.Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                    waveform = Math.Sin(simcount * TMFreqValue * Math.PI / 1000)
                    simulationDistance = CLng(12638 * TMUnitsFactor * ((waveform + TestMode.TrackBar_Offset.Value) * 0.01 * TMAmpValue) * multiplier / 2)

                Else

                End If

                simulationVelocity = simulationDistance - previousSimulationDistance

                simulatedData = simmeascount.ToString("########### ") + simrefcount.ToString("########### ") + "Difference: " +
                    simulationDistance.ToString + " Previous Difference " + previousSimulationDistance.ToString + " overflow counter: " + simulationSerial.ToString
                simulationSerial = simulationSerial + CULng(1)
                previousSimulationDistance = simulationDistance
                previoussimulationVelocity = simulationVelocity
                Me.SetText(simulatedData)

            Next

            If outerloop > 8 Then
                outerloop = 0
            End If

            outerloop = outerloop + 1
        End If

    End Sub
End Class
