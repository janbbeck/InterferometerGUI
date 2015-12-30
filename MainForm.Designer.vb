' Copyright (c) Microsoft Corporation. All rights reserved.
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ValueDisplay = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Averaging_Label = New System.Windows.Forms.Label()
        Me.AverageLabel = New System.Windows.Forms.Label()
        Me.UnitLabel = New System.Windows.Forms.Label()
        Me.DIFF = New System.Windows.Forms.Label()
        Me.DIFFKHzLabel = New System.Windows.Forms.Label()
        Me.DIFFLabel = New System.Windows.Forms.Label()
        Me.MEASMHzLabel = New System.Windows.Forms.Label()
        Me.REFMHzLabel = New System.Windows.Forms.Label()
        Me.MEAS = New System.Windows.Forms.Label()
        Me.REF = New System.Windows.Forms.Label()
        Me.MEASLabel = New System.Windows.Forms.Label()
        Me.REFLabel = New System.Windows.Forms.Label()
        Me.WLUnits = New System.Windows.Forms.Label()
        Me.WLText = New System.Windows.Forms.Label()
        Me.WLlabel = New System.Windows.Forms.Label()
        Me.SimulationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TestModeLabel = New System.Windows.Forms.Label()
        Me.Graph_Label = New System.Windows.Forms.Label()
        Me.Compression_Label = New System.Windows.Forms.Label()
        Me.NumericUpDown_Scale = New System.Windows.Forms.NumericUpDown()
        Me.EDOff_Label = New System.Windows.Forms.Label()
        Me.ComboBox_Range = New System.Windows.Forms.ComboBox()
        Me.Label_Range = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Axis_UnitsD = New System.Windows.Forms.Label()
        Me.Axis_S = New System.Windows.Forms.Label()
        Me.Axis_UnitsA = New System.Windows.Forms.Label()
        Me.Suspend_Label = New System.Windows.Forms.Label()
        Me.AngleLabel = New System.Windows.Forms.Label()
        Me.Frequency_Axis = New System.Windows.Forms.Label()
        Me.ComboBox_DFT_Range = New System.Windows.Forms.ComboBox()
        Me.DFT_Hz = New System.Windows.Forms.Label()
        Me.Logfile_Text = New System.Windows.Forms.Label()
        Me.Logfile_Label = New System.Windows.Forms.Label()
        Me.RangeUnits = New System.Windows.Forms.Label()
        Me.Label_RangeTime = New System.Windows.Forms.Label()
        Me.Phase_Value = New System.Windows.Forms.Label()
        Me.Phase_Label = New System.Windows.Forms.Label()
        Me.Graph_Averaging_CheckBox = New System.Windows.Forms.CheckBox()
        Me.PORTB_Label = New System.Windows.Forms.Label()
        Me.PBA_RM_Value = New System.Windows.Forms.Label()
        Me.REFMEAS_Label = New System.Windows.Forms.Label()
        Me.RMA_RM_Value = New System.Windows.Forms.Label()
        Me.Phase_Error_Label = New System.Windows.Forms.Label()
        Me.Phase_Error_Value = New System.Windows.Forms.Label()
        Me.PBA_RP_Value = New System.Windows.Forms.Label()
        Me.RMA_RP__Value = New System.Windows.Forms.Label()
        Me.Axis1_Value = New System.Windows.Forms.Label()
        Me.Axis1_Label = New System.Windows.Forms.Label()
        Me.Axis2_Label = New System.Windows.Forms.Label()
        Me.Axis2_Value = New System.Windows.Forms.Label()
        Me.Axis3_Label = New System.Windows.Forms.Label()
        Me.Axis3_Value = New System.Windows.Forms.Label()
        Me.Axis1_Angle_Label = New System.Windows.Forms.Label()
        Me.Axis1_Units_Label = New System.Windows.Forms.Label()
        Me.Axis1_Time_Label = New System.Windows.Forms.Label()
        Me.Axis2_Time_Label = New System.Windows.Forms.Label()
        Me.Axis2_Units_Label = New System.Windows.Forms.Label()
        Me.Axis2_Angle_Label = New System.Windows.Forms.Label()
        Me.Axis3_Time_Label = New System.Windows.Forms.Label()
        Me.Axis3_Units_Label = New System.Windows.Forms.Label()
        Me.Axis3_Angle_Label = New System.Windows.Forms.Label()
        Me.Capture_Button = New System.Windows.Forms.Button()
        Me.StraightnessLongButton = New System.Windows.Forms.Button()
        Me.GraphControl = New System.Windows.Forms.Button()
        Me.Suspend = New System.Windows.Forms.Button()
        Me.FrequencyButton = New System.Windows.Forms.Button()
        Me.StraightnessShortButton = New System.Windows.Forms.Button()
        Me.AngleButton = New System.Windows.Forms.Button()
        Me.DisplacementButton = New System.Windows.Forms.Button()
        Me.ZeroButton = New System.Windows.Forms.Button()
        Me.VelocityButton = New System.Windows.Forms.Button()
        Me.DP32_Percent_Label = New System.Windows.Forms.Label()
        Me.DP32_Percent_Value = New System.Windows.Forms.Label()
        Me.Sample_Frequency_Label = New System.Windows.Forms.Label()
        Me.Sample_Frequency_Value = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Scale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ValueDisplay
        '
        Me.ValueDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueDisplay.Location = New System.Drawing.Point(193, 62)
        Me.ValueDisplay.Name = "ValueDisplay"
        Me.ValueDisplay.Size = New System.Drawing.Size(485, 61)
        Me.ValueDisplay.TabIndex = 34
        Me.ValueDisplay.Text = "0.000000"
        Me.ValueDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(7, 269)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(150, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))}
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(850, 228)
        Me.Chart1.TabIndex = 36
        Me.Chart1.Text = " "
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 16
        '
        'TimeLabel
        '
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(755, 62)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(96, 48)
        Me.TimeLabel.TabIndex = 44
        Me.TimeLabel.Text = "/s"
        Me.TimeLabel.Visible = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(375, 137)
        Me.TrackBar1.Maximum = 999
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(141, 45)
        Me.TrackBar1.TabIndex = 46
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Averaging_Label
        '
        Me.Averaging_Label.AutoSize = True
        Me.Averaging_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Averaging_Label.Location = New System.Drawing.Point(296, 136)
        Me.Averaging_Label.Name = "Averaging_Label"
        Me.Averaging_Label.Size = New System.Drawing.Size(84, 20)
        Me.Averaging_Label.TabIndex = 47
        Me.Averaging_Label.Text = "Averaging:"
        '
        'AverageLabel
        '
        Me.AverageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AverageLabel.Location = New System.Drawing.Point(509, 137)
        Me.AverageLabel.Name = "AverageLabel"
        Me.AverageLabel.Size = New System.Drawing.Size(52, 20)
        Me.AverageLabel.TabIndex = 48
        Me.AverageLabel.Text = " 000"
        '
        'UnitLabel
        '
        Me.UnitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitLabel.Location = New System.Drawing.Point(666, 62)
        Me.UnitLabel.Name = "UnitLabel"
        Me.UnitLabel.Size = New System.Drawing.Size(104, 48)
        Me.UnitLabel.TabIndex = 35
        Me.UnitLabel.Text = "nm"
        Me.UnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DIFF
        '
        Me.DIFF.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIFF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DIFF.Location = New System.Drawing.Point(702, 22)
        Me.DIFF.Name = "DIFF"
        Me.DIFF.Size = New System.Drawing.Size(82, 24)
        Me.DIFF.TabIndex = 76
        Me.DIFF.Text = " 0.000"
        Me.DIFF.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DIFFKHzLabel
        '
        Me.DIFFKHzLabel.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIFFKHzLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DIFFKHzLabel.Location = New System.Drawing.Point(781, 22)
        Me.DIFFKHzLabel.Name = "DIFFKHzLabel"
        Me.DIFFKHzLabel.Size = New System.Drawing.Size(57, 24)
        Me.DIFFKHzLabel.TabIndex = 75
        Me.DIFFKHzLabel.Text = "kHz"
        '
        'DIFFLabel
        '
        Me.DIFFLabel.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIFFLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DIFFLabel.Location = New System.Drawing.Point(656, 22)
        Me.DIFFLabel.Name = "DIFFLabel"
        Me.DIFFLabel.Size = New System.Drawing.Size(63, 24)
        Me.DIFFLabel.TabIndex = 74
        Me.DIFFLabel.Text = "DIFF: "
        '
        'MEASMHzLabel
        '
        Me.MEASMHzLabel.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEASMHzLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MEASMHzLabel.Location = New System.Drawing.Point(569, 22)
        Me.MEASMHzLabel.Name = "MEASMHzLabel"
        Me.MEASMHzLabel.Size = New System.Drawing.Size(64, 26)
        Me.MEASMHzLabel.TabIndex = 73
        Me.MEASMHzLabel.Text = "MHz"
        '
        'REFMHzLabel
        '
        Me.REFMHzLabel.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFMHzLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.REFMHzLabel.Location = New System.Drawing.Point(363, 22)
        Me.REFMHzLabel.Name = "REFMHzLabel"
        Me.REFMHzLabel.Size = New System.Drawing.Size(58, 26)
        Me.REFMHzLabel.TabIndex = 72
        Me.REFMHzLabel.Text = "MHz"
        '
        'MEAS
        '
        Me.MEAS.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEAS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MEAS.Location = New System.Drawing.Point(510, 22)
        Me.MEAS.Name = "MEAS"
        Me.MEAS.Size = New System.Drawing.Size(62, 26)
        Me.MEAS.TabIndex = 71
        Me.MEAS.Text = "0.000"
        Me.MEAS.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'REF
        '
        Me.REF.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.REF.Location = New System.Drawing.Point(304, 22)
        Me.REF.Name = "REF"
        Me.REF.Size = New System.Drawing.Size(62, 24)
        Me.REF.TabIndex = 70
        Me.REF.Text = "0.000"
        Me.REF.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MEASLabel
        '
        Me.MEASLabel.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEASLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MEASLabel.Location = New System.Drawing.Point(454, 22)
        Me.MEASLabel.Name = "MEASLabel"
        Me.MEASLabel.Size = New System.Drawing.Size(70, 26)
        Me.MEASLabel.TabIndex = 69
        Me.MEASLabel.Text = "MEAS: "
        '
        'REFLabel
        '
        Me.REFLabel.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.REFLabel.Location = New System.Drawing.Point(261, 22)
        Me.REFLabel.Name = "REFLabel"
        Me.REFLabel.Size = New System.Drawing.Size(57, 24)
        Me.REFLabel.TabIndex = 68
        Me.REFLabel.Text = "REF: "
        '
        'WLUnits
        '
        Me.WLUnits.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WLUnits.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.WLUnits.Location = New System.Drawing.Point(172, 22)
        Me.WLUnits.Name = "WLUnits"
        Me.WLUnits.Size = New System.Drawing.Size(58, 26)
        Me.WLUnits.TabIndex = 79
        Me.WLUnits.Text = "nm"
        '
        'WLText
        '
        Me.WLText.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WLText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WLText.Location = New System.Drawing.Point(81, 22)
        Me.WLText.Name = "WLText"
        Me.WLText.Size = New System.Drawing.Size(108, 24)
        Me.WLText.TabIndex = 78
        Me.WLText.Text = "632.991372"
        '
        'WLlabel
        '
        Me.WLlabel.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WLlabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.WLlabel.Location = New System.Drawing.Point(41, 22)
        Me.WLlabel.Name = "WLlabel"
        Me.WLlabel.Size = New System.Drawing.Size(57, 24)
        Me.WLlabel.TabIndex = 77
        Me.WLlabel.Text = "WL: "
        '
        'SimulationTimer
        '
        Me.SimulationTimer.Interval = 25
        '
        'TestModeLabel
        '
        Me.TestModeLabel.AutoSize = True
        Me.TestModeLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestModeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TestModeLabel.Location = New System.Drawing.Point(30, 70)
        Me.TestModeLabel.Name = "TestModeLabel"
        Me.TestModeLabel.Size = New System.Drawing.Size(114, 18)
        Me.TestModeLabel.TabIndex = 80
        Me.TestModeLabel.Text = "Simulated Data"
        '
        'Graph_Label
        '
        Me.Graph_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Graph_Label.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graph_Label.Location = New System.Drawing.Point(357, 513)
        Me.Graph_Label.Name = "Graph_Label"
        Me.Graph_Label.Size = New System.Drawing.Size(217, 33)
        Me.Graph_Label.TabIndex = 81
        Me.Graph_Label.Text = "Displacement"
        Me.Graph_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Compression_Label
        '
        Me.Compression_Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compression_Label.Location = New System.Drawing.Point(321, 237)
        Me.Compression_Label.Name = "Compression_Label"
        Me.Compression_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Compression_Label.Size = New System.Drawing.Size(179, 31)
        Me.Compression_Label.TabIndex = 82
        Me.Compression_Label.Text = "Time Compression"
        Me.Compression_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_Scale
        '
        Me.NumericUpDown_Scale.Location = New System.Drawing.Point(501, 245)
        Me.NumericUpDown_Scale.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.NumericUpDown_Scale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Scale.Name = "NumericUpDown_Scale"
        Me.NumericUpDown_Scale.Size = New System.Drawing.Size(38, 20)
        Me.NumericUpDown_Scale.TabIndex = 84
        Me.NumericUpDown_Scale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_Scale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'EDOff_Label
        '
        Me.EDOff_Label.AutoSize = True
        Me.EDOff_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDOff_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EDOff_Label.Location = New System.Drawing.Point(31, 86)
        Me.EDOff_Label.Name = "EDOff_Label"
        Me.EDOff_Label.Size = New System.Drawing.Size(144, 18)
        Me.EDOff_Label.TabIndex = 85
        Me.EDOff_Label.Text = "Error Detection Off"
        '
        'ComboBox_Range
        '
        Me.ComboBox_Range.FormattingEnabled = True
        Me.ComboBox_Range.Items.AddRange(New Object() {"Auto", "0.01", "0.02", "0.05", "0.1", "0.2", "0.5", "1", "2", "5", "10", "20", "50", "100", "200", "500", "1000"})
        Me.ComboBox_Range.Location = New System.Drawing.Point(763, 244)
        Me.ComboBox_Range.MaximumSize = New System.Drawing.Size(55, 0)
        Me.ComboBox_Range.Name = "ComboBox_Range"
        Me.ComboBox_Range.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox_Range.Size = New System.Drawing.Size(48, 21)
        Me.ComboBox_Range.TabIndex = 86
        Me.ComboBox_Range.Text = "Auto"
        '
        'Label_Range
        '
        Me.Label_Range.AutoSize = True
        Me.Label_Range.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Range.Location = New System.Drawing.Point(536, 243)
        Me.Label_Range.MaximumSize = New System.Drawing.Size(100, 20)
        Me.Label_Range.MinimumSize = New System.Drawing.Size(225, 20)
        Me.Label_Range.Name = "Label_Range"
        Me.Label_Range.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_Range.Size = New System.Drawing.Size(225, 20)
        Me.Label_Range.TabIndex = 88
        Me.Label_Range.Text = "Displacement Range"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.CheckFileExists = False
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        Me.OpenFileDialog1.Title = "Please enter the name for the log file"
        '
        'Axis_UnitsD
        '
        Me.Axis_UnitsD.BackColor = System.Drawing.SystemColors.Control
        Me.Axis_UnitsD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis_UnitsD.Location = New System.Drawing.Point(50, 493)
        Me.Axis_UnitsD.MaximumSize = New System.Drawing.Size(160, 20)
        Me.Axis_UnitsD.MinimumSize = New System.Drawing.Size(10, 20)
        Me.Axis_UnitsD.Name = "Axis_UnitsD"
        Me.Axis_UnitsD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Axis_UnitsD.Size = New System.Drawing.Size(44, 20)
        Me.Axis_UnitsD.TabIndex = 92
        Me.Axis_UnitsD.Text = "mm"
        '
        'Axis_S
        '
        Me.Axis_S.BackColor = System.Drawing.SystemColors.Control
        Me.Axis_S.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis_S.Location = New System.Drawing.Point(88, 493)
        Me.Axis_S.Name = "Axis_S"
        Me.Axis_S.Size = New System.Drawing.Size(28, 24)
        Me.Axis_S.TabIndex = 93
        Me.Axis_S.Text = "/s"
        Me.Axis_S.Visible = False
        '
        'Axis_UnitsA
        '
        Me.Axis_UnitsA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis_UnitsA.Location = New System.Drawing.Point(50, 493)
        Me.Axis_UnitsA.MaximumSize = New System.Drawing.Size(160, 20)
        Me.Axis_UnitsA.MinimumSize = New System.Drawing.Size(10, 20)
        Me.Axis_UnitsA.Name = "Axis_UnitsA"
        Me.Axis_UnitsA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Axis_UnitsA.Size = New System.Drawing.Size(60, 20)
        Me.Axis_UnitsA.TabIndex = 94
        Me.Axis_UnitsA.Text = "degree"
        '
        'Suspend_Label
        '
        Me.Suspend_Label.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Suspend_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Suspend_Label.Location = New System.Drawing.Point(736, 45)
        Me.Suspend_Label.Name = "Suspend_Label"
        Me.Suspend_Label.Size = New System.Drawing.Size(106, 26)
        Me.Suspend_Label.TabIndex = 95
        Me.Suspend_Label.Text = "Suspended"
        Me.Suspend_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Suspend_Label.Visible = False
        '
        'AngleLabel
        '
        Me.AngleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AngleLabel.Location = New System.Drawing.Point(668, 56)
        Me.AngleLabel.Name = "AngleLabel"
        Me.AngleLabel.Size = New System.Drawing.Size(177, 67)
        Me.AngleLabel.TabIndex = 44
        Me.AngleLabel.Text = "arcsec"
        Me.AngleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frequency_Axis
        '
        Me.Frequency_Axis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Frequency_Axis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frequency_Axis.Location = New System.Drawing.Point(110, 500)
        Me.Frequency_Axis.Name = "Frequency_Axis"
        Me.Frequency_Axis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frequency_Axis.Size = New System.Drawing.Size(745, 14)
        Me.Frequency_Axis.TabIndex = 98
        Me.Frequency_Axis.Text = "1 2  5      10              20              30              40              50   " & _
    "           60             70              80              90            100"
        Me.Frequency_Axis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_DFT_Range
        '
        Me.ComboBox_DFT_Range.FormattingEnabled = True
        Me.ComboBox_DFT_Range.Items.AddRange(New Object() {"10", "30", "100", "300"})
        Me.ComboBox_DFT_Range.Location = New System.Drawing.Point(501, 244)
        Me.ComboBox_DFT_Range.MaximumSize = New System.Drawing.Size(100, 0)
        Me.ComboBox_DFT_Range.Name = "ComboBox_DFT_Range"
        Me.ComboBox_DFT_Range.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox_DFT_Range.Size = New System.Drawing.Size(42, 21)
        Me.ComboBox_DFT_Range.TabIndex = 99
        Me.ComboBox_DFT_Range.Text = "100"
        Me.ComboBox_DFT_Range.Visible = False
        '
        'DFT_Hz
        '
        Me.DFT_Hz.AutoSize = True
        Me.DFT_Hz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFT_Hz.Location = New System.Drawing.Point(545, 245)
        Me.DFT_Hz.Name = "DFT_Hz"
        Me.DFT_Hz.Size = New System.Drawing.Size(22, 15)
        Me.DFT_Hz.TabIndex = 100
        Me.DFT_Hz.Text = "Hz"
        Me.DFT_Hz.Visible = False
        '
        'Logfile_Text
        '
        Me.Logfile_Text.AutoSize = True
        Me.Logfile_Text.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logfile_Text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Logfile_Text.Location = New System.Drawing.Point(108, 102)
        Me.Logfile_Text.MaximumSize = New System.Drawing.Size(200, 0)
        Me.Logfile_Text.Name = "Logfile_Text"
        Me.Logfile_Text.Size = New System.Drawing.Size(79, 18)
        Me.Logfile_Text.TabIndex = 101
        Me.Logfile_Text.Text = "Logfile.txt"
        '
        'Logfile_Label
        '
        Me.Logfile_Label.AutoSize = True
        Me.Logfile_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logfile_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Logfile_Label.Location = New System.Drawing.Point(31, 102)
        Me.Logfile_Label.MaximumSize = New System.Drawing.Size(200, 0)
        Me.Logfile_Label.Name = "Logfile_Label"
        Me.Logfile_Label.Size = New System.Drawing.Size(81, 18)
        Me.Logfile_Label.TabIndex = 102
        Me.Logfile_Label.Text = "Log File is"
        '
        'RangeUnits
        '
        Me.RangeUnits.AutoSize = True
        Me.RangeUnits.BackColor = System.Drawing.SystemColors.Control
        Me.RangeUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RangeUnits.Location = New System.Drawing.Point(814, 244)
        Me.RangeUnits.MaximumSize = New System.Drawing.Size(160, 20)
        Me.RangeUnits.MinimumSize = New System.Drawing.Size(10, 20)
        Me.RangeUnits.Name = "RangeUnits"
        Me.RangeUnits.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RangeUnits.Size = New System.Drawing.Size(30, 20)
        Me.RangeUnits.TabIndex = 103
        Me.RangeUnits.Text = "mm"
        '
        'Label_RangeTime
        '
        Me.Label_RangeTime.BackColor = System.Drawing.SystemColors.Control
        Me.Label_RangeTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RangeTime.Location = New System.Drawing.Point(827, 244)
        Me.Label_RangeTime.Name = "Label_RangeTime"
        Me.Label_RangeTime.Size = New System.Drawing.Size(38, 24)
        Me.Label_RangeTime.TabIndex = 104
        Me.Label_RangeTime.Text = "/s"
        Me.Label_RangeTime.Visible = False
        '
        'Phase_Value
        '
        Me.Phase_Value.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phase_Value.ForeColor = System.Drawing.Color.Blue
        Me.Phase_Value.Location = New System.Drawing.Point(136, 4)
        Me.Phase_Value.Name = "Phase_Value"
        Me.Phase_Value.Size = New System.Drawing.Size(52, 18)
        Me.Phase_Value.TabIndex = 105
        Me.Phase_Value.Text = " 0000"
        Me.Phase_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Phase_Label
        '
        Me.Phase_Label.AutoSize = True
        Me.Phase_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phase_Label.ForeColor = System.Drawing.Color.Blue
        Me.Phase_Label.Location = New System.Drawing.Point(93, 4)
        Me.Phase_Label.Name = "Phase_Label"
        Me.Phase_Label.Size = New System.Drawing.Size(56, 18)
        Me.Phase_Label.TabIndex = 106
        Me.Phase_Label.Text = "Phase:"
        '
        'Graph_Averaging_CheckBox
        '
        Me.Graph_Averaging_CheckBox.AutoSize = True
        Me.Graph_Averaging_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Graph_Averaging_CheckBox.Checked = True
        Me.Graph_Averaging_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Graph_Averaging_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graph_Averaging_CheckBox.Location = New System.Drawing.Point(118, 240)
        Me.Graph_Averaging_CheckBox.Name = "Graph_Averaging_CheckBox"
        Me.Graph_Averaging_CheckBox.Size = New System.Drawing.Size(177, 24)
        Me.Graph_Averaging_CheckBox.TabIndex = 107
        Me.Graph_Averaging_CheckBox.Text = " Graph Averaging On"
        Me.Graph_Averaging_CheckBox.UseVisualStyleBackColor = True
        '
        'PORTB_Label
        '
        Me.PORTB_Label.AutoSize = True
        Me.PORTB_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PORTB_Label.ForeColor = System.Drawing.Color.Blue
        Me.PORTB_Label.Location = New System.Drawing.Point(194, 4)
        Me.PORTB_Label.Name = "PORTB_Label"
        Me.PORTB_Label.Size = New System.Drawing.Size(94, 18)
        Me.PORTB_Label.TabIndex = 109
        Me.PORTB_Label.Text = "PBA RM RP:"
        '
        'PBA_RM_Value
        '
        Me.PBA_RM_Value.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PBA_RM_Value.ForeColor = System.Drawing.Color.Blue
        Me.PBA_RM_Value.Location = New System.Drawing.Point(285, 4)
        Me.PBA_RM_Value.Name = "PBA_RM_Value"
        Me.PBA_RM_Value.Size = New System.Drawing.Size(35, 18)
        Me.PBA_RM_Value.TabIndex = 108
        Me.PBA_RM_Value.Text = " -00"
        Me.PBA_RM_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'REFMEAS_Label
        '
        Me.REFMEAS_Label.AutoSize = True
        Me.REFMEAS_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFMEAS_Label.ForeColor = System.Drawing.Color.Blue
        Me.REFMEAS_Label.Location = New System.Drawing.Point(350, 4)
        Me.REFMEAS_Label.Name = "REFMEAS_Label"
        Me.REFMEAS_Label.Size = New System.Drawing.Size(97, 18)
        Me.REFMEAS_Label.TabIndex = 111
        Me.REFMEAS_Label.Text = "RMA RM RP:"
        '
        'RMA_RM_Value
        '
        Me.RMA_RM_Value.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RMA_RM_Value.ForeColor = System.Drawing.Color.Blue
        Me.RMA_RM_Value.Location = New System.Drawing.Point(444, 4)
        Me.RMA_RM_Value.Name = "RMA_RM_Value"
        Me.RMA_RM_Value.Size = New System.Drawing.Size(34, 18)
        Me.RMA_RM_Value.TabIndex = 110
        Me.RMA_RM_Value.Text = " 00"
        Me.RMA_RM_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Phase_Error_Label
        '
        Me.Phase_Error_Label.AutoSize = True
        Me.Phase_Error_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phase_Error_Label.ForeColor = System.Drawing.Color.Blue
        Me.Phase_Error_Label.Location = New System.Drawing.Point(505, 4)
        Me.Phase_Error_Label.Name = "Phase_Error_Label"
        Me.Phase_Error_Label.Size = New System.Drawing.Size(36, 18)
        Me.Phase_Error_Label.TabIndex = 113
        Me.Phase_Error_Label.Text = " PE:"
        '
        'Phase_Error_Value
        '
        Me.Phase_Error_Value.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phase_Error_Value.ForeColor = System.Drawing.Color.Blue
        Me.Phase_Error_Value.Location = New System.Drawing.Point(538, 4)
        Me.Phase_Error_Value.Name = "Phase_Error_Value"
        Me.Phase_Error_Value.Size = New System.Drawing.Size(44, 18)
        Me.Phase_Error_Value.TabIndex = 112
        Me.Phase_Error_Value.Text = " 0000"
        Me.Phase_Error_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PBA_RP_Value
        '
        Me.PBA_RP_Value.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PBA_RP_Value.ForeColor = System.Drawing.Color.Blue
        Me.PBA_RP_Value.Location = New System.Drawing.Point(316, 4)
        Me.PBA_RP_Value.Name = "PBA_RP_Value"
        Me.PBA_RP_Value.Size = New System.Drawing.Size(28, 18)
        Me.PBA_RP_Value.TabIndex = 114
        Me.PBA_RP_Value.Text = " 00"
        Me.PBA_RP_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RMA_RP__Value
        '
        Me.RMA_RP__Value.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RMA_RP__Value.ForeColor = System.Drawing.Color.Blue
        Me.RMA_RP__Value.Location = New System.Drawing.Point(474, 4)
        Me.RMA_RP__Value.Name = "RMA_RP__Value"
        Me.RMA_RP__Value.Size = New System.Drawing.Size(28, 18)
        Me.RMA_RP__Value.TabIndex = 115
        Me.RMA_RP__Value.Text = " 00"
        Me.RMA_RP__Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Axis1_Value
        '
        Me.Axis1_Value.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis1_Value.Location = New System.Drawing.Point(98, 49)
        Me.Axis1_Value.Name = "Axis1_Value"
        Me.Axis1_Value.Size = New System.Drawing.Size(118, 22)
        Me.Axis1_Value.TabIndex = 116
        Me.Axis1_Value.Text = "0.000000"
        Me.Axis1_Value.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Axis1_Value.Visible = False
        '
        'Axis1_Label
        '
        Me.Axis1_Label.AutoSize = True
        Me.Axis1_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis1_Label.ForeColor = System.Drawing.Color.BlueViolet
        Me.Axis1_Label.Location = New System.Drawing.Point(41, 49)
        Me.Axis1_Label.Name = "Axis1_Label"
        Me.Axis1_Label.Size = New System.Drawing.Size(53, 18)
        Me.Axis1_Label.TabIndex = 117
        Me.Axis1_Label.Text = "Axis 1:"
        Me.Axis1_Label.Visible = False
        '
        'Axis2_Label
        '
        Me.Axis2_Label.AutoSize = True
        Me.Axis2_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis2_Label.ForeColor = System.Drawing.Color.Black
        Me.Axis2_Label.Location = New System.Drawing.Point(282, 49)
        Me.Axis2_Label.Name = "Axis2_Label"
        Me.Axis2_Label.Size = New System.Drawing.Size(53, 18)
        Me.Axis2_Label.TabIndex = 119
        Me.Axis2_Label.Text = "Axis 2:"
        Me.Axis2_Label.Visible = False
        '
        'Axis2_Value
        '
        Me.Axis2_Value.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis2_Value.Location = New System.Drawing.Point(340, 49)
        Me.Axis2_Value.Name = "Axis2_Value"
        Me.Axis2_Value.Size = New System.Drawing.Size(115, 22)
        Me.Axis2_Value.TabIndex = 118
        Me.Axis2_Value.Text = "0.000000"
        Me.Axis2_Value.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Axis2_Value.Visible = False
        '
        'Axis3_Label
        '
        Me.Axis3_Label.AutoSize = True
        Me.Axis3_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis3_Label.ForeColor = System.Drawing.Color.Black
        Me.Axis3_Label.Location = New System.Drawing.Point(515, 49)
        Me.Axis3_Label.Name = "Axis3_Label"
        Me.Axis3_Label.Size = New System.Drawing.Size(53, 18)
        Me.Axis3_Label.TabIndex = 121
        Me.Axis3_Label.Text = "Axis 3:"
        Me.Axis3_Label.Visible = False
        '
        'Axis3_Value
        '
        Me.Axis3_Value.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis3_Value.Location = New System.Drawing.Point(573, 49)
        Me.Axis3_Value.Name = "Axis3_Value"
        Me.Axis3_Value.Size = New System.Drawing.Size(119, 22)
        Me.Axis3_Value.TabIndex = 120
        Me.Axis3_Value.Text = "0.000000"
        Me.Axis3_Value.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Axis3_Value.Visible = False
        '
        'Axis1_Angle_Label
        '
        Me.Axis1_Angle_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis1_Angle_Label.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Axis1_Angle_Label.Location = New System.Drawing.Point(214, 49)
        Me.Axis1_Angle_Label.Name = "Axis1_Angle_Label"
        Me.Axis1_Angle_Label.Size = New System.Drawing.Size(56, 18)
        Me.Axis1_Angle_Label.TabIndex = 122
        Me.Axis1_Angle_Label.Text = "arcsec"
        Me.Axis1_Angle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Axis1_Angle_Label.Visible = False
        '
        'Axis1_Units_Label
        '
        Me.Axis1_Units_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis1_Units_Label.Location = New System.Drawing.Point(214, 47)
        Me.Axis1_Units_Label.Name = "Axis1_Units_Label"
        Me.Axis1_Units_Label.Size = New System.Drawing.Size(32, 22)
        Me.Axis1_Units_Label.TabIndex = 123
        Me.Axis1_Units_Label.Text = "nm"
        Me.Axis1_Units_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Axis1_Units_Label.Visible = False
        '
        'Axis1_Time_Label
        '
        Me.Axis1_Time_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis1_Time_Label.Location = New System.Drawing.Point(242, 49)
        Me.Axis1_Time_Label.Name = "Axis1_Time_Label"
        Me.Axis1_Time_Label.Size = New System.Drawing.Size(28, 19)
        Me.Axis1_Time_Label.TabIndex = 124
        Me.Axis1_Time_Label.Text = "/s"
        Me.Axis1_Time_Label.Visible = False
        '
        'Axis2_Time_Label
        '
        Me.Axis2_Time_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis2_Time_Label.Location = New System.Drawing.Point(481, 49)
        Me.Axis2_Time_Label.Name = "Axis2_Time_Label"
        Me.Axis2_Time_Label.Size = New System.Drawing.Size(28, 19)
        Me.Axis2_Time_Label.TabIndex = 127
        Me.Axis2_Time_Label.Text = "/s"
        Me.Axis2_Time_Label.Visible = False
        '
        'Axis2_Units_Label
        '
        Me.Axis2_Units_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis2_Units_Label.Location = New System.Drawing.Point(453, 47)
        Me.Axis2_Units_Label.Name = "Axis2_Units_Label"
        Me.Axis2_Units_Label.Size = New System.Drawing.Size(32, 22)
        Me.Axis2_Units_Label.TabIndex = 126
        Me.Axis2_Units_Label.Text = "nm"
        Me.Axis2_Units_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Axis2_Units_Label.Visible = False
        '
        'Axis2_Angle_Label
        '
        Me.Axis2_Angle_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis2_Angle_Label.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Axis2_Angle_Label.Location = New System.Drawing.Point(453, 49)
        Me.Axis2_Angle_Label.Name = "Axis2_Angle_Label"
        Me.Axis2_Angle_Label.Size = New System.Drawing.Size(56, 18)
        Me.Axis2_Angle_Label.TabIndex = 125
        Me.Axis2_Angle_Label.Text = "arcsec"
        Me.Axis2_Angle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Axis2_Angle_Label.Visible = False
        '
        'Axis3_Time_Label
        '
        Me.Axis3_Time_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis3_Time_Label.Location = New System.Drawing.Point(718, 49)
        Me.Axis3_Time_Label.Name = "Axis3_Time_Label"
        Me.Axis3_Time_Label.Size = New System.Drawing.Size(28, 19)
        Me.Axis3_Time_Label.TabIndex = 130
        Me.Axis3_Time_Label.Text = "/s"
        Me.Axis3_Time_Label.Visible = False
        '
        'Axis3_Units_Label
        '
        Me.Axis3_Units_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis3_Units_Label.Location = New System.Drawing.Point(690, 47)
        Me.Axis3_Units_Label.Name = "Axis3_Units_Label"
        Me.Axis3_Units_Label.Size = New System.Drawing.Size(32, 22)
        Me.Axis3_Units_Label.TabIndex = 129
        Me.Axis3_Units_Label.Text = "nm"
        Me.Axis3_Units_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Axis3_Units_Label.Visible = False
        '
        'Axis3_Angle_Label
        '
        Me.Axis3_Angle_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis3_Angle_Label.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Axis3_Angle_Label.Location = New System.Drawing.Point(690, 49)
        Me.Axis3_Angle_Label.Name = "Axis3_Angle_Label"
        Me.Axis3_Angle_Label.Size = New System.Drawing.Size(56, 18)
        Me.Axis3_Angle_Label.TabIndex = 128
        Me.Axis3_Angle_Label.Text = "arcsec"
        Me.Axis3_Angle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Axis3_Angle_Label.Visible = False
        '
        'Capture_Button
        '
        Me.Capture_Button.AccessibleDescription = ""
        Me.Capture_Button.AccessibleName = ""
        Me.Capture_Button.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.Capture_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Capture_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Capture_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Capture_Button.Location = New System.Drawing.Point(158, 135)
        Me.Capture_Button.Name = "Capture_Button"
        Me.Capture_Button.Size = New System.Drawing.Size(100, 23)
        Me.Capture_Button.TabIndex = 91
        Me.Capture_Button.Text = "Enable Capture"
        '
        'StraightnessLongButton
        '
        Me.StraightnessLongButton.AccessibleDescription = ""
        Me.StraightnessLongButton.AccessibleName = ""
        Me.StraightnessLongButton.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.StraightnessLongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StraightnessLongButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StraightnessLongButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StraightnessLongButton.Location = New System.Drawing.Point(442, 185)
        Me.StraightnessLongButton.Name = "StraightnessLongButton"
        Me.StraightnessLongButton.Size = New System.Drawing.Size(114, 23)
        Me.StraightnessLongButton.TabIndex = 42
        Me.StraightnessLongButton.Text = "Straightness Long"
        '
        'GraphControl
        '
        Me.GraphControl.AccessibleDescription = ""
        Me.GraphControl.AccessibleName = ""
        Me.GraphControl.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.GraphControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GraphControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GraphControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GraphControl.Location = New System.Drawing.Point(35, 135)
        Me.GraphControl.Name = "GraphControl"
        Me.GraphControl.Size = New System.Drawing.Size(100, 23)
        Me.GraphControl.TabIndex = 1
        Me.GraphControl.Text = "Disable Graph"
        '
        'Suspend
        '
        Me.Suspend.AccessibleDescription = ""
        Me.Suspend.AccessibleName = ""
        Me.Suspend.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.Suspend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Suspend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Suspend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Suspend.Location = New System.Drawing.Point(746, 135)
        Me.Suspend.Name = "Suspend"
        Me.Suspend.Size = New System.Drawing.Size(100, 23)
        Me.Suspend.TabIndex = 51
        Me.Suspend.Text = "Suspend"
        '
        'FrequencyButton
        '
        Me.FrequencyButton.AccessibleDescription = ""
        Me.FrequencyButton.AccessibleName = ""
        Me.FrequencyButton.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.FrequencyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FrequencyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FrequencyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FrequencyButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FrequencyButton.Location = New System.Drawing.Point(732, 185)
        Me.FrequencyButton.Name = "FrequencyButton"
        Me.FrequencyButton.Size = New System.Drawing.Size(114, 23)
        Me.FrequencyButton.TabIndex = 45
        Me.FrequencyButton.Text = "Frequency"
        '
        'StraightnessShortButton
        '
        Me.StraightnessShortButton.AccessibleDescription = ""
        Me.StraightnessShortButton.AccessibleName = ""
        Me.StraightnessShortButton.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.StraightnessShortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StraightnessShortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StraightnessShortButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StraightnessShortButton.Location = New System.Drawing.Point(578, 185)
        Me.StraightnessShortButton.Name = "StraightnessShortButton"
        Me.StraightnessShortButton.Size = New System.Drawing.Size(114, 23)
        Me.StraightnessShortButton.TabIndex = 43
        Me.StraightnessShortButton.Text = "Straightness Short"
        '
        'AngleButton
        '
        Me.AngleButton.AccessibleDescription = ""
        Me.AngleButton.AccessibleName = ""
        Me.AngleButton.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.AngleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AngleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AngleButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AngleButton.Location = New System.Drawing.Point(306, 185)
        Me.AngleButton.Name = "AngleButton"
        Me.AngleButton.Size = New System.Drawing.Size(114, 23)
        Me.AngleButton.TabIndex = 41
        Me.AngleButton.Text = "Angle"
        '
        'DisplacementButton
        '
        Me.DisplacementButton.AccessibleDescription = ""
        Me.DisplacementButton.AccessibleName = ""
        Me.DisplacementButton.BackColor = System.Drawing.SystemColors.Control
        Me.DisplacementButton.BackgroundImage = Global.uMDGUI.My.Resources.Resources.ActiveButton6
        Me.DisplacementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DisplacementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DisplacementButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DisplacementButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DisplacementButton.Location = New System.Drawing.Point(35, 185)
        Me.DisplacementButton.Name = "DisplacementButton"
        Me.DisplacementButton.Size = New System.Drawing.Size(114, 23)
        Me.DisplacementButton.TabIndex = 40
        Me.DisplacementButton.Text = "Displacement"
        Me.DisplacementButton.UseVisualStyleBackColor = False
        '
        'ZeroButton
        '
        Me.ZeroButton.AccessibleDescription = ""
        Me.ZeroButton.AccessibleName = ""
        Me.ZeroButton.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.ZeroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ZeroButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ZeroButton.Location = New System.Drawing.Point(581, 135)
        Me.ZeroButton.Name = "ZeroButton"
        Me.ZeroButton.Size = New System.Drawing.Size(145, 23)
        Me.ZeroButton.TabIndex = 33
        Me.ZeroButton.Text = "Reset Display"
        '
        'VelocityButton
        '
        Me.VelocityButton.AccessibleDescription = ""
        Me.VelocityButton.AccessibleName = ""
        Me.VelocityButton.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.VelocityButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VelocityButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.VelocityButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.VelocityButton.Location = New System.Drawing.Point(171, 185)
        Me.VelocityButton.Name = "VelocityButton"
        Me.VelocityButton.Size = New System.Drawing.Size(114, 23)
        Me.VelocityButton.TabIndex = 32
        Me.VelocityButton.Text = "Velocity"
        '
        'DP32_Percent_Label
        '
        Me.DP32_Percent_Label.AutoSize = True
        Me.DP32_Percent_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DP32_Percent_Label.ForeColor = System.Drawing.Color.Blue
        Me.DP32_Percent_Label.Location = New System.Drawing.Point(703, 4)
        Me.DP32_Percent_Label.Name = "DP32_Percent_Label"
        Me.DP32_Percent_Label.Size = New System.Drawing.Size(66, 18)
        Me.DP32_Percent_Label.TabIndex = 132
        Me.DP32_Percent_Label.Text = "DP32 %:"
        '
        'DP32_Percent_Value
        '
        Me.DP32_Percent_Value.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DP32_Percent_Value.ForeColor = System.Drawing.Color.Blue
        Me.DP32_Percent_Value.Location = New System.Drawing.Point(766, 4)
        Me.DP32_Percent_Value.Name = "DP32_Percent_Value"
        Me.DP32_Percent_Value.Size = New System.Drawing.Size(52, 18)
        Me.DP32_Percent_Value.TabIndex = 131
        Me.DP32_Percent_Value.Text = " 0000"
        Me.DP32_Percent_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sample_Frequency_Label
        '
        Me.Sample_Frequency_Label.AutoSize = True
        Me.Sample_Frequency_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sample_Frequency_Label.ForeColor = System.Drawing.Color.Blue
        Me.Sample_Frequency_Label.Location = New System.Drawing.Point(588, 4)
        Me.Sample_Frequency_Label.Name = "Sample_Frequency_Label"
        Me.Sample_Frequency_Label.Size = New System.Drawing.Size(54, 18)
        Me.Sample_Frequency_Label.TabIndex = 134
        Me.Sample_Frequency_Label.Text = "SF Hz:"
        '
        'Sample_Frequency_Value
        '
        Me.Sample_Frequency_Value.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sample_Frequency_Value.ForeColor = System.Drawing.Color.Blue
        Me.Sample_Frequency_Value.Location = New System.Drawing.Point(642, 4)
        Me.Sample_Frequency_Value.Name = "Sample_Frequency_Value"
        Me.Sample_Frequency_Value.Size = New System.Drawing.Size(58, 18)
        Me.Sample_Frequency_Value.TabIndex = 133
        Me.Sample_Frequency_Value.Text = " 000.00"
        Me.Sample_Frequency_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainForm
        '
        Me.ClientSize = New System.Drawing.Size(880, 572)
        Me.Controls.Add(Me.Sample_Frequency_Label)
        Me.Controls.Add(Me.Sample_Frequency_Value)
        Me.Controls.Add(Me.DP32_Percent_Label)
        Me.Controls.Add(Me.DP32_Percent_Value)
        Me.Controls.Add(Me.Axis3_Time_Label)
        Me.Controls.Add(Me.Axis3_Units_Label)
        Me.Controls.Add(Me.Axis3_Angle_Label)
        Me.Controls.Add(Me.Axis2_Time_Label)
        Me.Controls.Add(Me.Axis2_Units_Label)
        Me.Controls.Add(Me.Axis2_Angle_Label)
        Me.Controls.Add(Me.Axis1_Time_Label)
        Me.Controls.Add(Me.Axis1_Units_Label)
        Me.Controls.Add(Me.Axis1_Angle_Label)
        Me.Controls.Add(Me.Axis3_Label)
        Me.Controls.Add(Me.Axis3_Value)
        Me.Controls.Add(Me.Axis2_Label)
        Me.Controls.Add(Me.Axis2_Value)
        Me.Controls.Add(Me.Axis1_Label)
        Me.Controls.Add(Me.Axis1_Value)
        Me.Controls.Add(Me.RMA_RP__Value)
        Me.Controls.Add(Me.PBA_RP_Value)
        Me.Controls.Add(Me.Phase_Error_Label)
        Me.Controls.Add(Me.Phase_Error_Value)
        Me.Controls.Add(Me.REFMEAS_Label)
        Me.Controls.Add(Me.RMA_RM_Value)
        Me.Controls.Add(Me.PORTB_Label)
        Me.Controls.Add(Me.PBA_RM_Value)
        Me.Controls.Add(Me.Graph_Averaging_CheckBox)
        Me.Controls.Add(Me.Phase_Label)
        Me.Controls.Add(Me.Phase_Value)
        Me.Controls.Add(Me.Label_RangeTime)
        Me.Controls.Add(Me.RangeUnits)
        Me.Controls.Add(Me.Logfile_Label)
        Me.Controls.Add(Me.Logfile_Text)
        Me.Controls.Add(Me.DFT_Hz)
        Me.Controls.Add(Me.ComboBox_DFT_Range)
        Me.Controls.Add(Me.Frequency_Axis)
        Me.Controls.Add(Me.Suspend_Label)
        Me.Controls.Add(Me.Axis_UnitsA)
        Me.Controls.Add(Me.Axis_S)
        Me.Controls.Add(Me.Axis_UnitsD)
        Me.Controls.Add(Me.Capture_Button)
        Me.Controls.Add(Me.StraightnessLongButton)
        Me.Controls.Add(Me.Label_Range)
        Me.Controls.Add(Me.ComboBox_Range)
        Me.Controls.Add(Me.EDOff_Label)
        Me.Controls.Add(Me.NumericUpDown_Scale)
        Me.Controls.Add(Me.Compression_Label)
        Me.Controls.Add(Me.Graph_Label)
        Me.Controls.Add(Me.TestModeLabel)
        Me.Controls.Add(Me.WLUnits)
        Me.Controls.Add(Me.WLText)
        Me.Controls.Add(Me.WLlabel)
        Me.Controls.Add(Me.DIFF)
        Me.Controls.Add(Me.DIFFKHzLabel)
        Me.Controls.Add(Me.DIFFLabel)
        Me.Controls.Add(Me.MEASMHzLabel)
        Me.Controls.Add(Me.REFMHzLabel)
        Me.Controls.Add(Me.MEAS)
        Me.Controls.Add(Me.REF)
        Me.Controls.Add(Me.MEASLabel)
        Me.Controls.Add(Me.REFLabel)
        Me.Controls.Add(Me.GraphControl)
        Me.Controls.Add(Me.Suspend)
        Me.Controls.Add(Me.AverageLabel)
        Me.Controls.Add(Me.Averaging_Label)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.FrequencyButton)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.AngleLabel)
        Me.Controls.Add(Me.StraightnessShortButton)
        Me.Controls.Add(Me.AngleButton)
        Me.Controls.Add(Me.DisplacementButton)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.UnitLabel)
        Me.Controls.Add(Me.ValueDisplay)
        Me.Controls.Add(Me.ZeroButton)
        Me.Controls.Add(Me.VelocityButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Micro Measurement Display"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Scale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VelocityButton As System.Windows.Forms.Button
    Friend WithEvents ZeroButton As System.Windows.Forms.Button
    Friend WithEvents ValueDisplay As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents DisplacementButton As System.Windows.Forms.Button
    Friend WithEvents AngleButton As System.Windows.Forms.Button
    Friend WithEvents StraightnessLongButton As System.Windows.Forms.Button
    Friend WithEvents StraightnessShortButton As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents FrequencyButton As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Averaging_Label As System.Windows.Forms.Label
    Friend WithEvents GraphControl As System.Windows.Forms.Button
    Friend WithEvents AverageLabel As System.Windows.Forms.Label
    Friend WithEvents UnitLabel As System.Windows.Forms.Label
    Friend WithEvents Suspend As System.Windows.Forms.Button
    Friend WithEvents DIFF As System.Windows.Forms.Label
    Friend WithEvents DIFFKHzLabel As System.Windows.Forms.Label
    Friend WithEvents DIFFLabel As System.Windows.Forms.Label
    Friend WithEvents MEASMHzLabel As System.Windows.Forms.Label
    Friend WithEvents REFMHzLabel As System.Windows.Forms.Label
    Friend WithEvents MEAS As System.Windows.Forms.Label
    Friend WithEvents REF As System.Windows.Forms.Label
    Friend WithEvents MEASLabel As System.Windows.Forms.Label
    Friend WithEvents REFLabel As System.Windows.Forms.Label
    Friend WithEvents WLUnits As System.Windows.Forms.Label
    Friend WithEvents WLText As System.Windows.Forms.Label
    Friend WithEvents WLlabel As System.Windows.Forms.Label
    Friend WithEvents SimulationTimer As System.Windows.Forms.Timer
    Friend WithEvents TestModeLabel As System.Windows.Forms.Label
    Friend WithEvents Graph_Label As System.Windows.Forms.Label
    Friend WithEvents Compression_Label As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_Scale As System.Windows.Forms.NumericUpDown
    Friend WithEvents EDOff_Label As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Range As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Range As System.Windows.Forms.Label
    Friend WithEvents Capture_Button As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Axis_UnitsD As System.Windows.Forms.Label
    Friend WithEvents Axis_S As System.Windows.Forms.Label
    Friend WithEvents Axis_UnitsA As System.Windows.Forms.Label
    Friend WithEvents Suspend_Label As System.Windows.Forms.Label
    Friend WithEvents AngleLabel As System.Windows.Forms.Label
    Friend WithEvents Frequency_Axis As System.Windows.Forms.Label
    Friend WithEvents ComboBox_DFT_Range As System.Windows.Forms.ComboBox
    Friend WithEvents DFT_Hz As System.Windows.Forms.Label
    Friend WithEvents Logfile_Text As System.Windows.Forms.Label
    Friend WithEvents Logfile_Label As System.Windows.Forms.Label
    Friend WithEvents RangeUnits As System.Windows.Forms.Label
    Friend WithEvents Label_RangeTime As System.Windows.Forms.Label
    Friend WithEvents Phase_Value As System.Windows.Forms.Label
    Friend WithEvents Phase_Label As System.Windows.Forms.Label
    Friend WithEvents Graph_Averaging_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PORTB_Label As System.Windows.Forms.Label
    Friend WithEvents PBA_RM_Value As System.Windows.Forms.Label
    Friend WithEvents REFMEAS_Label As System.Windows.Forms.Label
    Friend WithEvents RMA_RM_Value As System.Windows.Forms.Label
    Friend WithEvents Phase_Error_Label As System.Windows.Forms.Label
    Friend WithEvents Phase_Error_Value As System.Windows.Forms.Label
    Friend WithEvents PBA_RP_Value As System.Windows.Forms.Label
    Friend WithEvents RMA_RP__Value As System.Windows.Forms.Label
    Friend WithEvents Axis1_Value As System.Windows.Forms.Label
    Friend WithEvents Axis1_Label As System.Windows.Forms.Label
    Friend WithEvents Axis2_Label As System.Windows.Forms.Label
    Friend WithEvents Axis2_Value As System.Windows.Forms.Label
    Friend WithEvents Axis3_Label As System.Windows.Forms.Label
    Friend WithEvents Axis3_Value As System.Windows.Forms.Label
    Friend WithEvents Axis1_Angle_Label As System.Windows.Forms.Label
    Friend WithEvents Axis1_Units_Label As System.Windows.Forms.Label
    Friend WithEvents Axis1_Time_Label As System.Windows.Forms.Label
    Friend WithEvents Axis2_Time_Label As System.Windows.Forms.Label
    Friend WithEvents Axis2_Units_Label As System.Windows.Forms.Label
    Friend WithEvents Axis2_Angle_Label As System.Windows.Forms.Label
    Friend WithEvents Axis3_Time_Label As System.Windows.Forms.Label
    Friend WithEvents Axis3_Units_Label As System.Windows.Forms.Label
    Friend WithEvents Axis3_Angle_Label As System.Windows.Forms.Label
    Friend WithEvents DP32_Percent_Label As System.Windows.Forms.Label
    Friend WithEvents DP32_Percent_Value As System.Windows.Forms.Label
    Friend WithEvents Sample_Frequency_Label As System.Windows.Forms.Label
    Friend WithEvents Sample_Frequency_Value As System.Windows.Forms.Label
End Class
