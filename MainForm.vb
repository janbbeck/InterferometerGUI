' some important sources for techniques used here:
'https://eshkay.wordpress.com/2013/03/25/vb-net-serial-port-communication-with-datareceived-event/
'https://msdn.microsoft.com/en-us/library/ms171728.aspx


Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Text.RegularExpressions
Imports System.IO.Ports
Imports System.ComponentModel


Public Class MainForm
    Public positionSeries As New Series
    Public velocitySeries As New Series
    Public fftSeries As New Series
    Public chartcounter As UInt64
    'defining the menu items for the main menu bar
    Dim menuItems As New List(Of MenuItem)
    Dim myMenuItemComPort As New MenuItem("&Com Port")
    Dim myMenuItemCofiguration As New MenuItem("Configuration")
    'defining the main menu bar
    Dim mnuBar As New MainMenu()
    ' buffer for serial port object
    Dim spDrLine As String = ""
    Dim spBuffer As String = ""
    Dim zeroAdjustment As Double = 0.0  ' this is what we need to set the data back to zero
    Public unitCorrectionFactor As Double = 1.0 ' 1.0 = nm 0.001 = um etc
    Public multiplier As Integer = 1    ' needed for interferometer type 1x 2x 4x
    Public straightnessMultiplier As Integer = 1 ' needed for straightness measurements
    Dim currentValue As Double = 0.0
    Dim previousValue As Double = 0.0
    Dim velocityValue As Double = 0.0
    Dim averagingValue As Double = 0.0
    Dim displayValue As Double
    Dim RealPartOfDFT(512) As Double
    Dim ImaginaryPartOfDFT(512) As Double



    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'SerialPort1.Close() ' this hangs the program. known MS bug https://social.msdn.microsoft.com/Forums/en-US/ce8ce1a3-64ed-4f26-b9ad-e2ff1d3be0a5/serial-port-hangs-whilst-closing?forum=Vsexpressvcs
        'End
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dialog1.Button1x.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
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
            positionSeries.Points.AddXY(chartcounter, Math.Sin(chartcounter / 10))
        Next
        velocitySeries.ChartType = SeriesChartType.FastLine
        Chart1.Series.Add(positionSeries)
        For chartcounter = 0 To 1023
            velocitySeries.Points.AddXY(chartcounter, Math.Sin(chartcounter / 10))
        Next
        fftSeries.ChartType = SeriesChartType.FastLine



        Dim myMenuItemNew As New MenuItem("&New")
        Dim myMenuItemConfigure As New MenuItem("&Configure")
        menuItems.Add(myMenuItemNew)    ' need a list to be able to delete/change them at runtime
        myMenuItemComPort.MenuItems.Add(myMenuItemNew)
        AddHandler myMenuItemConfigure.Click, AddressOf Me.myMenuItemCofiguration_Click
        myMenuItemCofiguration.MenuItems.Add(myMenuItemConfigure)
        ' Add functionality to the menu items using the Click event.  
        AddHandler myMenuItemComPort.Popup, AddressOf Me.myMenuItemFile1_Click
        'adding the menu items to the main menu bar
        mnuBar.MenuItems.Add(myMenuItemCofiguration)
        mnuBar.MenuItems.Add(myMenuItemComPort)
        'add the main menu to the form
        Me.Menu = mnuBar
        ' load user settings
        multiplier = My.Settings.Multiplier
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
        averagingValue = My.Settings.AveragingValue
        TrackBar1.Value = CInt(averagingValue)
        AverageLabel.Text = "Display=Display*" + (0 + TrackBar1.Value / 100).ToString("F") + "+NewData*" + (1.0 - TrackBar1.Value / 100).ToString("F")
        Timer1.Start()
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
    End Sub
    Private Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            If SerialPort1.IsOpen Then
                spDrLine = spDrLine & SerialPort1.ReadExisting() 'important
                If InStr(1, spDrLine, vbCr) > 0 _
                  Or InStr(1, spDrLine, vbLf) > 0 Then
                    spBuffer = spDrLine
                    spDrLine = ""
                    'Me.Invoke(New EventHandler(AddressOf doProcess)) 'important
                    'process spBuffer
                    Try
                        Me.SetText(spBuffer)
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
        If (chartcounter Mod 2) = 0 Then    ' only have about 500 pixels to show 1000 points
            DFT()
        End If

        If Me.Chart1.InvokeRequired Then    'what is good for chart1 is also good for chart2
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Try
                ' first split data into sets
                Dim k As Integer
                Dim sets() As String = spBuffer.Split(vbCrLf.ToCharArray)
                For k = 0 To sets.Length - 1
                    Dim values() As String = sets(k).Split(" ".ToCharArray)
                    'make sure the current set has exactly 10 fields
                    If values.Length.Equals(10) Then
                        Console.Write(values(3) + vbCrLf)
                        currentValue = Convert.ToDouble(values(3)) * 632.816759
                        previousValue = Convert.ToDouble(values(6)) * 632.816759
                        velocityValue = (previousValue - currentValue) * 610.35 ' 610.35 Hz update rate in PIC timer
                        If VelocityButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption) Then ' velocity mode
                            displayValue = unitCorrectionFactor * velocityValue / multiplier
                        Else
                            Dim averagingFromPrevious As Double = (0 + TrackBar1.Value / 100) * displayValue
                            Dim averagingFromCurrent As Double = (1.0 - TrackBar1.Value / 100) * straightnessMultiplier * unitCorrectionFactor * (currentValue - zeroAdjustment) / multiplier
                            displayValue = averagingFromPrevious + averagingFromCurrent
                        End If

                        If unitCorrectionFactor = 1 Then
                            ValueDisplay.Text = displayValue.ToString("###,###,###,##0.000") 'nm
                        ElseIf unitCorrectionFactor = 0.001 Then
                            ValueDisplay.Text = displayValue.ToString("###,###,##0.000,000") 'um
                        ElseIf unitCorrectionFactor = 0.000001 Then
                            ValueDisplay.Text = displayValue.ToString("###,##0.000,000,000") 'mm
                        ElseIf unitCorrectionFactor = 0.0000001 Then
                            ValueDisplay.Text = displayValue.ToString("###,##0.000,000,0000") 'cm
                        ElseIf unitCorrectionFactor = 0.000000001 Then
                            ValueDisplay.Text = displayValue.ToString("##0.000,000,000,000") 'm
                        ElseIf unitCorrectionFactor = 0.00000003937 Then
                            ValueDisplay.Text = displayValue.ToString("###,##0.000,000,0000") 'in
                        ElseIf unitCorrectionFactor = 0.0000000032808 Then
                            ValueDisplay.Text = displayValue.ToString("##0.000,000,000,000") 'ft
                        End If
                        If GraphControl.Text.Equals("Disable Graph") Then
                            positionSeries.Points.AddXY(chartcounter, straightnessMultiplier * unitCorrectionFactor * (currentValue - zeroAdjustment) / multiplier)
                            positionSeries.Points.RemoveAt(0)
                            velocitySeries.Points.AddXY(chartcounter, unitCorrectionFactor * velocityValue / multiplier)
                            velocitySeries.Points.RemoveAt(0)
                            chartcounter = CULng(chartcounter + 1)
                        End If
                    End If
                Next
                Chart1.ResetAutoValues()
                Dim counter As Integer
                If Color.FromKnownColor(KnownColor.ActiveCaption) = FrequencyButton.BackColor Then    ' only have about 500 pixels to show 1000 points
                    fftSeries.Points.Clear()
                    For counter = 0 To 255
                        fftSeries.Points.AddXY(counter, (ImaginaryPartOfDFT(counter) * ImaginaryPartOfDFT(counter)) + (RealPartOfDFT(counter) * RealPartOfDFT(counter)))
                    Next
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
    Private Sub myMenuItemCofiguration_Click(sender As Object, e As EventArgs)
        ' pop up configuration window
        If multiplier.Equals(1) Then
            Dialog1.Button1x.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            Dialog1.Button2x.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Button4x.BackColor = Color.FromKnownColor(KnownColor.Control)
        ElseIf multiplier.Equals(2) Then
            Dialog1.Button1x.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Button2x.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            Dialog1.Button4x.BackColor = Color.FromKnownColor(KnownColor.Control)
        Else
            Dialog1.Button1x.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Button2x.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Button4x.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        End If
        If unitCorrectionFactor = 1.0 Then
            Dialog1.Buttonnm.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            Dialog1.Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        ElseIf unitCorrectionFactor = 0.001 Then
            Dialog1.Buttonnm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonum.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            Dialog1.Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        ElseIf unitCorrectionFactor = 0.000001 Then
            Dialog1.Buttonnm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonmm.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            Dialog1.Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        ElseIf unitCorrectionFactor = 0.0000001 Then
            Dialog1.Buttonnm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttoncm.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            Dialog1.Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        ElseIf unitCorrectionFactor = 0.000000001 Then
            Dialog1.Buttonnm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonm.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            Dialog1.Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        ElseIf unitCorrectionFactor = 0.00000003937 Then
            Dialog1.Buttonnm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonin.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            Dialog1.Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        ElseIf unitCorrectionFactor = 0.0000000032808 Then
            Dialog1.Buttonnm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
            Dialog1.Buttonft.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        End If
        Dialog1.ShowDialog()
    End Sub

    Private Sub ZeroButton_Click(sender As Object, e As EventArgs) Handles ZeroButton.Click
        zeroAdjustment = currentValue
        For chartcounter = 0 To 1023
            positionSeries.Points.AddXY(chartcounter, 0.0)
            positionSeries.Points.RemoveAt(0)
            velocitySeries.Points.AddXY(chartcounter, 0.0)
            velocitySeries.Points.RemoveAt(0)
        Next
        displayValue = 0
    End Sub



    Private Sub DFT()
        ' not the fastest, but easy to implement
        ' https://en.wikipedia.org/wiki/Discrete_Fourier_transform
        Dim Dimension As Integer = 1024
        Dim outerLoopCounter, innerLoopCounter As Integer
        If velocitySeries.Points.Count = 1024 Then
            Try
                For outerLoopCounter = 0 To 512
                    RealPartOfDFT(outerLoopCounter) = 0 'probably redundant. will be removed at some point
                    ImaginaryPartOfDFT(outerLoopCounter) = 0 'probably redundant. will be removed at some point
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
        DisplacementButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        VelocityButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        FrequencyButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        StraightnessLongButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        StraightnessShortButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        Chart1.Series.Clear()
        Chart1.Series.Add(positionSeries)
        TimeLabel.Visible = False
        straightnessMultiplier = 1
    End Sub
    Private Sub VelocityButton_Click(sender As Object, e As EventArgs) Handles VelocityButton.Click

        DisplacementButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        VelocityButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        FrequencyButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        StraightnessLongButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        StraightnessShortButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        Chart1.Series.Clear()
        Chart1.Series.Add(velocitySeries)
        TimeLabel.Visible = True
    End Sub

    Private Sub FrequencyButton_Click(sender As Object, e As EventArgs) Handles FrequencyButton.Click
        DisplacementButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        VelocityButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        FrequencyButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        StraightnessLongButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        StraightnessShortButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        Chart1.Series.Clear()
        Chart1.Series.Add(fftSeries)
        TimeLabel.Visible = False
        straightnessMultiplier = 1
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        averagingValue = TrackBar1.Value
        AverageLabel.Text = "Display=Display*" + (0 + TrackBar1.Value / 100).ToString("F") + "+NewData*" + (1.0 - TrackBar1.Value / 100).ToString("F")
        My.Settings.AveragingValue = averagingValue
        My.Settings.Save()
    End Sub

    Private Sub AverageLabel_Click(sender As Object, e As EventArgs) Handles AverageLabel.Click

    End Sub

    Private Sub StraightnessLongButton_Click(sender As Object, e As EventArgs) Handles StraightnessLongButton.Click
        DisplacementButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        VelocityButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        FrequencyButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        StraightnessLongButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        StraightnessShortButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        Chart1.Series.Clear()
        Chart1.Series.Add(positionSeries)
        TimeLabel.Visible = False
        straightnessMultiplier = 360
    End Sub

    Private Sub StraightnessShortButton_Click(sender As Object, e As EventArgs) Handles StraightnessShortButton.Click
        DisplacementButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        VelocityButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        FrequencyButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        StraightnessLongButton.BackColor = Color.FromKnownColor(KnownColor.Control)
        StraightnessShortButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Chart1.Series.Clear()
        Chart1.Series.Add(positionSeries)
        TimeLabel.Visible = False
        straightnessMultiplier = 36
    End Sub

    Private Sub GraphControl_Click(sender As Object, e As EventArgs) Handles GraphControl.Click
        If GraphControl.Text.Equals("Disable Graph") Then
            GraphControl.Text = "Enable Graph"
            Chart1.Hide()
        Else
            GraphControl.Text = "Disable Graph"
            Chart1.Show()
        End If
    End Sub
End Class
