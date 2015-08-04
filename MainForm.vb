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
    ' Dim file As System.IO.StreamWriter

    Dim captureFile As System.IO.StreamWriter ' this is the log file to capture data
    Dim captureFileName As String = "" ' this is the name of the log file to capture data

    Public positionSeries As New Series
    Public velocitySeries As New Series
    Public angleseries As New Series
    Public fftSeries As New Series
    Public fftSeries2 As New Series
    Public chartcounter As UInt64
    Dim FFTdone As Boolean = True
    ' Creates and initializes a new Queue.
    Public displacementQueuex As New Queue()
    Public displacementQueuey As New Queue()
    Dim velocityQueuex As New Queue()
    Dim velocityQueuey As New Queue()
    Dim angleQueuex As New Queue()
    Dim angleQueuey As New Queue()
    'defining the menu items for the main menu bar
    Dim menuItems As New List(Of MenuItem)
    Dim myMenuItemLogFile As New MenuItem("&Select Log File")
    Dim myMenuItemConfiguration As New MenuItem("&Configuration")
    Dim myMenuItemCompensation As New MenuItem("&Environmental Compensation")
    Dim myMenuItemTestMode As New MenuItem("&Test Mode")
    Dim myMenuItemUSBPort As New MenuItem("&USB Port")
    Dim myMenuItemHelp As New MenuItem("&Help")
    Dim myMenuItemNew As New MenuItem("&New")
    Dim myMenuItemUSBSubMenuCOMPorts As New MenuItem("&DummyText")

    'defining the main menu bar
    Dim mnuBar As New MainMenu()
    ' buffer for serial port object
    Dim spDrLine As String = ""
    Dim spBuffer As String = ""
    Public zeroAdjustment As Double = 0  ' this is what we need to set the data back to zero
    Public unitCorrectionFactor As Double = 1.0 ' 1.0 = nm 0.001 = um etc
    Public unitCorrectmm As Double = 1.0 ' 1.0 = mm 0.001 = um etc
    Public angleCorrectionFactor As Double = 3600.0 ' 3600 = arcsec 60 = arcmin 1 = degree
    Public angleCorrectdegree As Double = 1
    Public Angle_Reflector_Spacing As Double = 32.61
    Public multiplier As Integer = 2    ' needed for interferometer type 1x 2x 4x
    Public straightnessMultiplier As Double = 1 ' needed for straightness measurements
    Public SLCoefficient As Double = 360
    Public SSCoefficient As Double = 36
    Public currentValue As Double = 0
    Public previousValue As Double = 0
    Dim velocityValue As Double = 0
    Dim angleValue As Double = 0
    Dim averagingValue As Double = 0
    Public displayValue As Double = 0
    Dim velocityValueList As New List(Of Double)
    Dim angleValueList As New List(Of Double)
    Dim averagingFromPrevious As Double = 0
    Public average As Double = 0
    Public TestmodeFlag As Integer = 0
    Public Dimension As Integer = 1024     ' this value determines both the size of the plot graphs and the number of data points in the DFT
    Dim RealPartOfDFT(CInt(Dimension / 2)) As Double
    Dim averagingFromCurrent As Double = 0
    Dim ImaginaryPartOfDFT(CInt(Dimension / 2)) As Double
    Dim DFTMax As Double = 0
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
    Public Temperature As Double
    Public Pressure As Double
    Public Humidity As Double
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
    Dim incomingData As String
    Dim Capture_Flag As Integer = 0

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'SerialPort1.Close() ' this hangs the program. known MS bug https://social.msdn.microsoft.com/Forums/en-US/ce8ce1a3-64ed-4f26-b9ad-e2ff1d3be0a5/serial-port-hangs-whilst-closing?forum=Vsexpressvcs
        'End
        'file.Close()
        If Not (captureFile Is Nothing) Then
            captureFile.Close()
        End If
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
        Chart1.Series.Add(positionSeries)

        velocitySeries.ChartType = SeriesChartType.FastLine
        For chartcounter = 0 To CULng(Dimension - 1)
            velocitySeries.Points.AddXY(chartcounter, 0.5 * Math.Cos(chartcounter / 40))
            velocityValueList.Add(0.0)  ' make sure the list is not empty
        Next

        angleseries.ChartType = SeriesChartType.FastLine
        For chartcounter = 0 To CULng(Dimension - 1)
            angleseries.Points.AddXY(chartcounter, 0.25 * Math.Asin(Math.Sin(chartcounter / 40)))
            angleValueList.Add(0.0)  ' make sure the list is not empty
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
        multiplier = My.Settings.Multiplier
        If multiplier = 1 Then
            Configuration.Button1x.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Button1x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            Configuration.Button2x.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Button2x.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Button4x.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Button4x.ForeColor = Color.FromKnownColor(KnownColor.Black)
        ElseIf multiplier = 2 Then
            Configuration.Button1x.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Button1x.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Button2x.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Button2x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            Configuration.Button4x.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Button4x.ForeColor = Color.FromKnownColor(KnownColor.Black)
        ElseIf multiplier = 4 Then
            Configuration.Button1x.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Button1x.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Button2x.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Button2x.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Button4x.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Button4x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        End If

        unitCorrectionFactor = My.Settings.UnitCorrectionFactor
        If unitCorrectionFactor = 0.000001 Then
            Configuration.Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            Configuration.Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
            UnitLabel.Text = "nm"
        ElseIf unitCorrectionFactor = 0.001 Then
            Configuration.Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Buttonum.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            Configuration.Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
            UnitLabel.Text = "um"
        ElseIf unitCorrectionFactor = 1 Then
            Configuration.Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            Configuration.Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
            UnitLabel.Text = "mm"
        ElseIf unitCorrectionFactor = 10 Then
            Configuration.Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            Configuration.Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
            UnitLabel.Text = "cm"
        ElseIf unitCorrectionFactor = 1000 Then
            Configuration.Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Buttonm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            Configuration.Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
            UnitLabel.Text = "m"
        ElseIf unitCorrectionFactor = 25.4 Then
            Configuration.Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Buttonin.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            Configuration.Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
            UnitLabel.Text = "in"
        ElseIf unitCorrectionFactor = 304.8 Then
            Configuration.Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonm.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Buttonft.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            UnitLabel.Text = "ft"
        End If
        RangeUnits.Text = UnitLabel.Text
        angleCorrectionFactor = My.Settings.AngleCorrectionFactor

        If angleCorrectionFactor = 1 / 3600.0 Then
            Configuration.Buttonarcsec.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            Configuration.Buttonarcmin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttondegree.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.Black)
            AngleLabel.Text = "arcsec"
        ElseIf angleCorrectionFactor = 1 / 60.0 Then
            Configuration.Buttonarcsec.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            Configuration.Buttonarcmin.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttondegree.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.Black)
            AngleLabel.Text = "arcmin"
        ElseIf angleCorrectionFactor = 1.0 Then
            Configuration.Buttonarcsec.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttonarcmin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Configuration.Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.Black)
            Configuration.Buttondegree.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
            Configuration.Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            AngleLabel.Text = "degree"
        End If


        Compensation.NumericUpDown_Temperature.Value = CDec(My.Settings.Temperature)
        Temperature = CDec(My.Settings.Temperature)
        'Compensation.NumericUpDown_Pressure.Value = CDec(My.Settings.Pressure)
        'Compensation.NumericUpDown_Humidity.Value = My.Settings.Humidity
        'Compensation.ComboBox_TempUnits.Text = My.Settings.TempUnits
        'Compensation.ComboBox_Pressure_Units.Text = My.Settings.PressureUnits

        TCorrection = 1 / (1 + (0.000271375 * 293 / (273 + My.Settings.Temperature)))
        Compensation.TextBox_TempFactor.Text = TCorrection.ToString("#0.000000000")
        PCorrection = 1 / (1 + (0.000271375 * My.Settings.Pressure / 1013))
        Compensation.TextBox_PresFactor.Text = PCorrection.ToString("#0.000000000")
        HumidityRel = My.Settings.Humidity
        If HumidityRel = 0 Then HCorrection = 1.000271375 / 1.000271799
        If HumidityRel = 10 Then HCorrection = 1.000271375 / 1.000271714
        If HumidityRel = 20 Then HCorrection = 1.000271375 / 1.000271629
        If HumidityRel = 30 Then HCorrection = 1.000271375 / 1.000271544
        If HumidityRel = 40 Then HCorrection = 1.000271375 / 1.000271459
        If HumidityRel = 50 Then HCorrection = 1
        If HumidityRel = 60 Then HCorrection = 1.000271375 / 1.00027129
        If HumidityRel = 70 Then HCorrection = 1.000271375 / 1.000271205
        If HumidityRel = 80 Then HCorrection = 1.000271375 / 1.00027112
        If HumidityRel = 90 Then HCorrection = 1.000271375 / 1.000271035
        If HumidityRel = 100 Then HCorrection = 1.000271375 / 1.00027095

        '    Compensation.TextBox_HumiFactor.Text = HCorrection.ToString("#0.000000000")
        '    If Compensation.ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
        '        Wavelength = Compensation.NumericUpDown_Wavelength.Value * TCorrection * PCorrection * HCorrection
        '    Else
        '        Wavelength = Compensation.NumericUpDown_Wavelength.Value
        '    End If
        '    WLText.Text = (Wavelength * ECFactor).ToString("000.000000")
        '    HCorrection = 1
        '    Compensation.TextBox_HumiFactor.Text = HCorrection.ToString("#0.000000000")
        '    WLText.Text = (Wavelength * ECFactor).ToString("000.000000")
        '    averagingValue = My.Settings.AveragingValue

        TrackBar1.Value = CInt(averagingValue)
        AverageLabel.Text = (0 + TrackBar1.Value / 100).ToString("F")
        Timer1.Start()
        ' file = My.Computer.FileSystem.OpenTextFileWriter("data.txt", True)

        ' Initialize graph

        TestModeLabel.Visible = False
        EDOff_Label.Visible = False
        straightnessMultiplier = 1
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
            'zeroAdjustment = currentValue
            'previousValue = currentValue
            'SuspendCurrentValue = 0
            ' simcount = 0
            'count = 0
            ' counter = 0
            If TestmodeFlag = 0 Then
                needsInitialZero = 1 ' make sure to zero out the reference system
            End If
        End If
    End Sub

    Private Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            If SerialPort1.IsOpen Then
                'Dim incomingData As String
                incomingData = SerialPort1.ReadExisting()
                'If Not (captureFile Is Nothing) Then
                ' captureFile.Write(incomingData)
                'End If
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
                        If Not (captureFile Is Nothing) And Capture_Flag = 1 And IgnoreCount = 0 Then
                            captureFile.Write("D:" + values(3) + " N:" + values(9) + vbCrLf)
                        End If
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
                                    Suspend_Label.Visible = False
                                    SuspendFlag = 0
                                    ErrorFlag = 0
                                End If
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
                                    End If
                                End If
                            End If

                            velocityValue = (previousValue - currentValue) * 610.35 ' 610.35 Hz update rate in PIC timer
                            'Console.Write(" sample duplicate" + vbCrLf)
                            If TestmodeFlag = 1 Then
                                velocityValue = velocityValue / 3.0425
                            End If

                            unitCorrectmm = 1 / unitCorrectionFactor / 1000000
                            angleCorrectdegree = 1 / angleCorrectionFactor

                            If SuspendFlag = 0 Then

                                If VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then ' velocity mode, no averaging
                                    average = velocityValue / multiplier
                                Else
                                    averagingFromPrevious = (0 + TrackBar1.Value / 100) * average ' nm
                                    averagingFromCurrent = (1.0 - TrackBar1.Value / 100) * straightnessMultiplier * (currentValue - zeroAdjustment) / multiplier
                                    average = averagingFromPrevious + averagingFromCurrent
                                End If

                                If AngleButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then ' angle mode
                                    displayValue = Math.Asin(average / Angle_Reflector_Spacing / 1000000) * angleCorrectionFactor * 57.296 ' arcsin(Dmm / 32.61) and Radians to arcsecs
                                Else
                                    displayValue = average * unitCorrectmm
                                End If

                                If GraphControl.Text.Equals("Disable Graph") Then
                                    If IgnoreCount = 0 Then
                                        displacementQueuex.Enqueue(chartcounter)
                                        displacementQueuey.Enqueue(straightnessMultiplier * unitCorrectmm * (currentValue - zeroAdjustment) / multiplier)
                                        velocityQueuex.Enqueue(chartcounter)
                                        velocityQueuey.Enqueue(unitCorrectmm * velocityValue / multiplier)
                                        angleQueuex.Enqueue(chartcounter)
                                        angleQueuey.Enqueue(Math.Asin(average / 32.61 / 1000000) * angleCorrectdegree * 57.296)
                                        chartcounter = CULng(chartcounter + 1)
                                    End If
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
        Else
            IgnoreCount = 0
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
        If Not (captureFile Is Nothing) Then
            captureFile.Close()
        End If
        OpenFileDialog1.ShowDialog()
        captureFileName = OpenFileDialog1.FileName.ToString()
        captureFile = My.Computer.FileSystem.OpenTextFileWriter(captureFileName, False)
    End Sub

    Private Sub myMenuItemConfiguration_Click(sender As Object, e As EventArgs)
        Configuration.ShowDialog()
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
        '   If TestmodeFlag = 0 Then
        AngleButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        AngleButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        StraightnessLongButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        StraightnessLongButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        StraightnessShortButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        StraightnessShortButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        'End If
        FrequencyButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Chart1.Series.Clear()
        Chart1.Series.Add(positionSeries)
        UnitLabel.Visible = True
        RangeUnits.Text = UnitLabel.Text
        TimeLabel.Visible = False
        Graph_Label.Text = "Displacement"
        ComboBox_Range.Visible = True
        If GraphControl.Text.Equals("Enable Graph") Then
            Label_Range.Visible = False
        Else
            Label_Range.Visible = True
            Axis_mm.Visible = True
            Axis_S.Visible = False
            Axis_degree.Visible = False
        End If
        Compression_Label.Text = "Time Compression"
        Label_Range.Text = "Displacement Range"
        Graph_Label.Text = "Displacement"
        AngleLabel.Visible = False
        straightnessMultiplier = 1
    End Sub

    Private Sub VelocityButton_Click(sender As Object, e As EventArgs) Handles VelocityButton.Click
        DisplacementButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        DisplacementButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        VelocityButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        'If TestmodeFlag = 0 Then
        AngleButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        AngleButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        StraightnessLongButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        StraightnessLongButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        StraightnessShortButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        StraightnessShortButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        'End If
        FrequencyButton.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Chart1.Series.Clear()
        Chart1.Series.Add(velocitySeries)
        UnitLabel.Visible = True
        RangeUnits.Text = UnitLabel.Text
        TimeLabel.Visible = True
        AngleLabel.Visible = False
        ComboBox_Range.Visible = True
        If GraphControl.Text.Equals("Enable Graph") Then
            Label_Range.Visible = False
        Else
            Label_Range.Visible = True
            Axis_mm.Visible = True
            Axis_S.Visible = True
            Axis_degree.Visible = False
        End If
        Compression_Label.Text = "Time Compression"
        Label_Range.Text = "Velociy Range"
        Graph_Label.Text = "Velocity"
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
        Chart1.Series.Add(angleseries)
        UnitLabel.Visible = False
        TimeLabel.Visible = False
        AngleLabel.Visible = True
        RangeUnits.Text = AngleLabel.Text
        straightnessMultiplier = 1
        ComboBox_Range.Visible = True

        If GraphControl.Text.Equals("Enable Graph") Then
            Label_Range.Visible = False
        Else
            Label_Range.Visible = True
            Axis_degree.Visible = True
        End If
        Compression_Label.Text = "Time Compression"
        Label_Range.Text = "Angle Range"
        Graph_Label.Text = "    Angle    "
        Axis_mm.Visible = False
        Axis_S.Visible = False
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
        RangeUnits.Text = UnitLabel.Text
        TimeLabel.Visible = False
        AngleLabel.Visible = False
        ComboBox_Range.Visible = True
        straightnessMultiplier = SLCoefficient
        If GraphControl.Text.Equals("Enable Graph") Then
            Label_Range.Visible = False
        Else
            Label_Range.Visible = True
            Axis_mm.Visible = True
            Axis_S.Visible = False
            Axis_degree.Visible = False
        End If
        Compression_Label.Text = "Time Compression"
        Label_Range.Text = "Straightness Long Range"
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
        RangeUnits.Text = UnitLabel.Text
        TimeLabel.Visible = False
        AngleLabel.Visible = False
        ComboBox_Range.Visible = True
        straightnessMultiplier = SSCoefficient
        If GraphControl.Text.Equals("Enable Graph") Then
            Label_Range.Visible = False
        Else
            Label_Range.Visible = True
            Axis_mm.Visible = True
            Axis_S.Visible = False
            Axis_degree.Visible = False
        End If
        Compression_Label.Text = "Time Compression"
        Label_Range.Text = "Straightness Short Range"
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
        RangeUnits.Text = UnitLabel.Text
        TimeLabel.Visible = False
        AngleLabel.Visible = False
        straightnessMultiplier = 1
        Label_Range.Visible = False
        ComboBox_Range.Visible = False
        Axis_mm.Visible = False
        Axis_S.Visible = False
        Axis_degree.Visible = False
        Graph_Label.Text = "Frequency"
        Compression_Label.Text = "Frequency Range"
        DFTMax = 0
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
            Label_Range.Visible = False
            Axis_mm.Visible = False
            Axis_S.Visible = False
        Else
            GraphControl.Text = "Disable Graph" ' Turn graph on
            Chart1.Show()
            Me.Height = 600
            Graph_Label.Visible = True
            Compression_Label.Visible = True
            NumericUpDown_Scale.Visible = True
            ComboBox_Range.Visible = True
            Label_Range.Visible = True
            Axis_mm.Visible = False
            Axis_S.Visible = False
            Axis_degree.Visible = False
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
            Suspend_Label.Visible = True
            SuspendFlag = 1
        Else                                     ' Exit Suspend mode
            Suspend.Text = "Suspend"
            Suspend.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Suspend.ForeColor = Color.FromKnownColor(KnownColor.Black)
            CurrentValueCorrection = CurrentValueCorrection + currentValue - SuspendCurrentValue
            Suspend_Label.Visible = False
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
            'Kludge to prevent momentary flashes of large value when turning on Test Mode FG
            If IgnoreCount = 0 And Math.Abs(currentValue - previousValue) < 100000000 Then
                If SuspendFlag = 1 Then
                    ' ValueDisplay.Text = "Suspend   "
                    Suspend_Label.Visible = True

                ElseIf EDEnabled = 1 And ErrorFlag > 0 Then
                    UnitLabel.Visible = False
                    TimeLabel.Visible = False
                    AngleLabel.Visible = False
                    If (ErrorFlag And 3) = 3 Then
                        ValueDisplay.Text = "  No Signals Error"
                    ElseIf (ErrorFlag And 3) = 1 Then
                        ValueDisplay.Text = "  REF (Head) Error"
                    ElseIf (ErrorFlag And 3) = 2 Then
                        ValueDisplay.Text = " MEAS (Path) Error"
                    ElseIf (ErrorFlag And 4) = 4 Then
                        ValueDisplay.Text = "SLEW (Rate+) Error"
                    ElseIf (ErrorFlag And 8) = 8 Then
                        ValueDisplay.Text = "SLEW (Rate-) Error"
                    End If

                ElseIf AngleButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then ' angle mode
                    AngleLabel.Visible = True
                    If angleCorrectionFactor = 1 / 3600 Then
                        ValueDisplay.Text = displayValue.ToString("##,###,###,###,##0.0") 'arcsec
                    ElseIf angleCorrectionFactor = 1 / 60 Then
                        ValueDisplay.Text = displayValue.ToString("###,###,###,##0.000") 'arcmin
                    ElseIf angleCorrectionFactor = 1.0 Then
                        ValueDisplay.Text = displayValue.ToString("##,###,###,##0.000,0") 'degree
                    End If
                Else
                    UnitLabel.Visible = True
                    If unitCorrectionFactor = 0.000001 Then
                        ValueDisplay.Text = displayValue.ToString("#,###,###,###,##0.0") 'nm
                    ElseIf unitCorrectionFactor = 0.001 Then
                        ValueDisplay.Text = displayValue.ToString("#,###,###,###,##0.0") 'um
                    ElseIf unitCorrectionFactor = 1 Then
                        ValueDisplay.Text = displayValue.ToString("#,###,###,##0.000,0") 'mm
                    ElseIf unitCorrectionFactor = 10 Then
                        ValueDisplay.Text = displayValue.ToString("###,###,##0.000,00") 'cm
                    ElseIf unitCorrectionFactor = 1000 Then
                        ValueDisplay.Text = displayValue.ToString("###,###,##0.000,000") 'm
                    ElseIf unitCorrectionFactor = 25.4 Then
                        ValueDisplay.Text = displayValue.ToString("###,###,##0.000,00") 'in
                    ElseIf unitCorrectionFactor = 304.8 Then
                        ValueDisplay.Text = displayValue.ToString("###,###,##0.000,000") 'ft
                    End If
                End If

                If VelocityButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                    TimeLabel.Visible = True
                End If
            End If
        End If

        If GraphControl.Text.Equals("Disable Graph") Then   ' are we graphing?
            Dim x1 As Double
            Dim y1 As Double
            Dim x2 As Double
            Dim y2 As Double
            Dim x3 As Double
            Dim y3 As Double
            While displacementQueuex.Count > 0
                x1 = CDbl(displacementQueuex.Dequeue())
                y1 = CDbl(displacementQueuey.Dequeue())
                x2 = CDbl(velocityQueuex.Dequeue())
                y2 = CDbl(velocityQueuey.Dequeue())
                x3 = CDbl(angleQueuex.Dequeue())
                y3 = CDbl(angleQueuey.Dequeue())
                graphCount = graphCount + CULng(1)
                If 0 = (graphCount Mod ScrollRate) Then
                    plotCount = plotCount + CULng(1)
                    positionSeries.Points.AddXY(plotCount, y1)
                    positionSeries.Points.RemoveAt(0)
                    velocitySeries.Points.AddXY(plotCount, y2)
                    velocitySeries.Points.RemoveAt(0)
                    angleseries.Points.AddXY(plotCount, y3)
                    angleseries.Points.RemoveAt(0)
                    velocityValueList.Add(y2)
                    velocityValueList.RemoveAt(0)
                End If
            End While
            ' DFT related

            Dim counter As Integer
            'DFTMax = 0
            If FrequencyButton.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then  ' are we doing dft?

                ' If (SerialPort1.IsOpen And (TestmodeFlag = 0)) Or TestmodeFlag = 1 Then ' skip if nothing happening
                If True = FFTdone Then   ' make sure we are not still busy with the previous calculation
                    FFTdone = False
                    fftSeries.Points.Clear()
                    For counter = 0 To (CInt(((Dimension / 2) - 1)))
                        fftSeries.Points.AddXY(counter, (ImaginaryPartOfDFT(counter) * ImaginaryPartOfDFT(counter)) + (RealPartOfDFT(counter) * RealPartOfDFT(counter)))
                        If (ImaginaryPartOfDFT(counter) * ImaginaryPartOfDFT(counter)) + (RealPartOfDFT(counter) * RealPartOfDFT(counter)) > DFTMax Then

                            DFTMax = 1 * (ImaginaryPartOfDFT(counter) * ImaginaryPartOfDFT(counter)) + (RealPartOfDFT(counter) * RealPartOfDFT(counter))

                        End If
                    Next
                    resetEvent.Set()
                End If
                'now update graphDIFF
            End If
            Chart1.ResetAutoValues()
        End If
        'Chart1.ResetAutoValues()
        'Chart1.ChartAreas(0).RecalculateAxesScale()
        ' Compression_Label.Visible = True
        ' NumericUpDown_Scale.Visible = True
    End Sub

    Private Sub SimulationTimer_Tick(sender As Object, e As EventArgs) Handles SimulationTimer.Tick

        ' here we are simulating data of the form of (not all fields are parsed by SetText:

        ' 0 MEAS Count
        ' 1 REF Count
        ' 2 "Difference: "  (ignored)
        ' 3 SIMDistance
        ' 4 " Previous      (ignored)
        ' 5 Difference "    (ignored)
        ' 6 PrevSIMDistance
        ' 7 " overflow      (ignored)
        ' 8 counter: "      (ignored)
        ' 9 SIMSerialNum

        ' ignored     ignored     ignored     distance  ignored  ignored     velocity  ignored  ignored  serialcounter
        ' simulatedData = "46838240776 4767908780 Difference: " + simulationDistance.ToString + " Previous Difference: " + simulationDistance.ToString + " overflow counter: " + simulationSerial.ToString

        Dim counter As Integer

        For counter = 0 To 5
            simrefcount = simrefcount + CLng(TestMode.NumericUpDown_FGREF_Value.Value * 1638)
            simmeascount = simrefcount + CLng(simulationDistance * 0.162)

            If SuspendFlag = 0 Then
                '               If (simmeascount - previoussimMEASCount) > (2 * (simrefcount - previoussimREFCount) - 0) Then
                'simmeascount = previoussimMEASCount + CLng(2 * (simrefcount - previoussimREFCount) - 1)
                'IgnoreCount = 0
                'End If

                '    If (simmeascount - previoussimMEASCount) < 0 Then
                'simmeascount = previoussimMEASCount + CLng(1)
                'IgnoreCount = 0
                ' End If

                ' If IgnoreCount = 0 Then
                If TestMode.Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                    simulationDistance = CLng(12638 * (TMUnitsFactor * (TestMode.TrackBar_Offset.Value * 0.01 * TMAmpValue) * multiplier / 2))
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
                    'waveform = waveform + Math.Cos(simcount * TMFreqValue * Math.PI / 1000 + phase) * TMFreqValue * Math.PI / 1000
                    waveform = Math.Sin(simcount * TMFreqValue * Math.PI / 1000 + phase)
                    simulationDistance = CLng(12638 * TMUnitsFactor * ((waveform + TestMode.TrackBar_Offset.Value) * 0.01 * TMAmpValue * multiplier / 2))
                    'End If
                    simcount = simcount + 1
                End If
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
        ErrorFlag = ErrorFlag Or 1  ' reset the REF part of the error variable
    End Sub

    Private Sub MEAS_Click(sender As Object, e As EventArgs) Handles MEAS.Click
        ErrorFlag = ErrorFlag Or 2 ' reset the MEAS part of the error variable
    End Sub

    Private Sub DIFF_Click(sender As Object, e As EventArgs) Handles DIFF.Click
        If currentValue > previousValue Then ErrorFlag = 4 Else ErrorFlag = 8
    End Sub



    Private Sub ComboBox_Range_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Range.SelectedIndexChanged
        Dim range As Double = 0
        If Not Double.TryParse(ComboBox_Range.Text, range) Then     ' Boolean true if Auto
            Chart1.ChartAreas(0).AxisY.Minimum = Double.NaN
            Chart1.ChartAreas(0).AxisY.Maximum = Double.NaN
        Else
            Chart1.ChartAreas(0).AxisY.Maximum = range
            Chart1.ChartAreas(0).AxisY.Minimum = -range
        End If
        Chart1.ResetAutoValues()
        Chart1.ChartAreas(0).RecalculateAxesScale()
        If UnitLabel.Visible Then
            RangeUnits.Text = UnitLabel.Text
        Else
            RangeUnits.Text = AngleLabel.Text
        End If
    End Sub

    Private Sub Capture_Button_Click(sender As Object, e As EventArgs) Handles Capture_Button.Click
        If Capture_Button.Text.Equals("Enable Capture") And
              Not (captureFile Is Nothing) Then
            ' Turn capture on
            Capture_Button.Text = "Disable Capture"
            Capture_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.GreenButton1
            Capture_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            Capture_Flag = 1
        Else
            Capture_Button.Text = "Enable Capture"
            Capture_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
            Capture_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
            captureFile.Write("Gap" + vbCrLf)
            Capture_Flag = 0
        End If
    End Sub
End Class
