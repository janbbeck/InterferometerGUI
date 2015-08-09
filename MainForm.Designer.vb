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
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.Capture_Button = New System.Windows.Forms.Button()
        Me.GraphControl = New System.Windows.Forms.Button()
        Me.Suspend = New System.Windows.Forms.Button()
        Me.FrequencyButton = New System.Windows.Forms.Button()
        Me.StraightnessShortButton = New System.Windows.Forms.Button()
        Me.StraightnessLongButton = New System.Windows.Forms.Button()
        Me.AngleButton = New System.Windows.Forms.Button()
        Me.DisplacementButton = New System.Windows.Forms.Button()
        Me.ZeroButton = New System.Windows.Forms.Button()
        Me.VelocityButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Axis_UnitsD = New System.Windows.Forms.Label()
        Me.Axis_S = New System.Windows.Forms.Label()
        Me.Axis_UnitsA = New System.Windows.Forms.Label()
        Me.Suspend_Label = New System.Windows.Forms.Label()
        Me.RangeUnits = New System.Windows.Forms.Label()
        Me.AngleLabel = New System.Windows.Forms.Label()
        Me.Label_RangeTime = New System.Windows.Forms.Label()
        Me.Frequency_Axis = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Scale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ValueDisplay
        '
        Me.ValueDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueDisplay.Location = New System.Drawing.Point(188, 62)
        Me.ValueDisplay.Name = "ValueDisplay"
        Me.ValueDisplay.Size = New System.Drawing.Size(472, 67)
        Me.ValueDisplay.TabIndex = 34
        Me.ValueDisplay.Text = "0.000"
        Me.ValueDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea7.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea7)
        Me.Chart1.Location = New System.Drawing.Point(12, 269)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(150, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))}
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Series1"
        Me.Chart1.Series.Add(Series7)
        Me.Chart1.Size = New System.Drawing.Size(851, 228)
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
        Me.TrackBar1.Location = New System.Drawing.Point(391, 137)
        Me.TrackBar1.Maximum = 99
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(133, 45)
        Me.TrackBar1.TabIndex = 46
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Averaging_Label
        '
        Me.Averaging_Label.AutoSize = True
        Me.Averaging_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Averaging_Label.Location = New System.Drawing.Point(312, 136)
        Me.Averaging_Label.Name = "Averaging_Label"
        Me.Averaging_Label.Size = New System.Drawing.Size(84, 20)
        Me.Averaging_Label.TabIndex = 47
        Me.Averaging_Label.Text = "Averaging:"
        '
        'AverageLabel
        '
        Me.AverageLabel.AutoSize = True
        Me.AverageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageLabel.Location = New System.Drawing.Point(517, 137)
        Me.AverageLabel.Name = "AverageLabel"
        Me.AverageLabel.Size = New System.Drawing.Size(18, 20)
        Me.AverageLabel.TabIndex = 48
        Me.AverageLabel.Text = "0"
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
        Me.DIFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIFF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DIFF.Location = New System.Drawing.Point(706, 22)
        Me.DIFF.Name = "DIFF"
        Me.DIFF.Size = New System.Drawing.Size(86, 24)
        Me.DIFF.TabIndex = 76
        Me.DIFF.Text = "0.00"
        Me.DIFF.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DIFFKHzLabel
        '
        Me.DIFFKHzLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIFFKHzLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DIFFKHzLabel.Location = New System.Drawing.Point(790, 22)
        Me.DIFFKHzLabel.Name = "DIFFKHzLabel"
        Me.DIFFKHzLabel.Size = New System.Drawing.Size(57, 24)
        Me.DIFFKHzLabel.TabIndex = 75
        Me.DIFFKHzLabel.Text = "kHz"
        '
        'DIFFLabel
        '
        Me.DIFFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIFFLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DIFFLabel.Location = New System.Drawing.Point(656, 22)
        Me.DIFFLabel.Name = "DIFFLabel"
        Me.DIFFLabel.Size = New System.Drawing.Size(63, 24)
        Me.DIFFLabel.TabIndex = 74
        Me.DIFFLabel.Text = "DIFF: "
        '
        'MEASMHzLabel
        '
        Me.MEASMHzLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEASMHzLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MEASMHzLabel.Location = New System.Drawing.Point(577, 22)
        Me.MEASMHzLabel.Name = "MEASMHzLabel"
        Me.MEASMHzLabel.Size = New System.Drawing.Size(64, 26)
        Me.MEASMHzLabel.TabIndex = 73
        Me.MEASMHzLabel.Text = "MHz"
        '
        'REFMHzLabel
        '
        Me.REFMHzLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFMHzLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.REFMHzLabel.Location = New System.Drawing.Point(369, 22)
        Me.REFMHzLabel.Name = "REFMHzLabel"
        Me.REFMHzLabel.Size = New System.Drawing.Size(58, 26)
        Me.REFMHzLabel.TabIndex = 72
        Me.REFMHzLabel.Text = "MHz"
        '
        'MEAS
        '
        Me.MEAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEAS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MEAS.Location = New System.Drawing.Point(514, 20)
        Me.MEAS.Name = "MEAS"
        Me.MEAS.Size = New System.Drawing.Size(66, 26)
        Me.MEAS.TabIndex = 71
        Me.MEAS.Text = "0.000"
        Me.MEAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'REF
        '
        Me.REF.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.REF.Location = New System.Drawing.Point(304, 21)
        Me.REF.Name = "REF"
        Me.REF.Size = New System.Drawing.Size(67, 24)
        Me.REF.TabIndex = 70
        Me.REF.Text = "0.000"
        Me.REF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MEASLabel
        '
        Me.MEASLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEASLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MEASLabel.Location = New System.Drawing.Point(457, 22)
        Me.MEASLabel.Name = "MEASLabel"
        Me.MEASLabel.Size = New System.Drawing.Size(70, 26)
        Me.MEASLabel.TabIndex = 69
        Me.MEASLabel.Text = "MEAS: "
        '
        'REFLabel
        '
        Me.REFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.REFLabel.Location = New System.Drawing.Point(261, 22)
        Me.REFLabel.Name = "REFLabel"
        Me.REFLabel.Size = New System.Drawing.Size(57, 24)
        Me.REFLabel.TabIndex = 68
        Me.REFLabel.Text = "REF: "
        '
        'WLUnits
        '
        Me.WLUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WLUnits.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.WLUnits.Location = New System.Drawing.Point(184, 22)
        Me.WLUnits.Name = "WLUnits"
        Me.WLUnits.Size = New System.Drawing.Size(58, 26)
        Me.WLUnits.TabIndex = 79
        Me.WLUnits.Text = "nm"
        '
        'WLText
        '
        Me.WLText.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WLText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WLText.Location = New System.Drawing.Point(81, 22)
        Me.WLText.Name = "WLText"
        Me.WLText.Size = New System.Drawing.Size(108, 24)
        Me.WLText.TabIndex = 78
        Me.WLText.Text = "632.991372"
        '
        'WLlabel
        '
        Me.WLlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.TestModeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestModeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TestModeLabel.Location = New System.Drawing.Point(30, 59)
        Me.TestModeLabel.Name = "TestModeLabel"
        Me.TestModeLabel.Size = New System.Drawing.Size(132, 22)
        Me.TestModeLabel.TabIndex = 80
        Me.TestModeLabel.Text = "Simulated Data"
        '
        'Graph_Label
        '
        Me.Graph_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Graph_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graph_Label.Location = New System.Drawing.Point(357, 505)
        Me.Graph_Label.Name = "Graph_Label"
        Me.Graph_Label.Size = New System.Drawing.Size(217, 33)
        Me.Graph_Label.TabIndex = 81
        Me.Graph_Label.Text = "Displacement"
        Me.Graph_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Compression_Label
        '
        Me.Compression_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compression_Label.Location = New System.Drawing.Point(164, 237)
        Me.Compression_Label.Name = "Compression_Label"
        Me.Compression_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Compression_Label.Size = New System.Drawing.Size(179, 31)
        Me.Compression_Label.TabIndex = 82
        Me.Compression_Label.Text = "Time Compression"
        Me.Compression_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown_Scale
        '
        Me.NumericUpDown_Scale.Location = New System.Drawing.Point(344, 245)
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
        Me.EDOff_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDOff_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EDOff_Label.Location = New System.Drawing.Point(30, 86)
        Me.EDOff_Label.Name = "EDOff_Label"
        Me.EDOff_Label.Size = New System.Drawing.Size(160, 22)
        Me.EDOff_Label.TabIndex = 85
        Me.EDOff_Label.Text = "Error Detection Off"
        '
        'ComboBox_Range
        '
        Me.ComboBox_Range.FormattingEnabled = True
        Me.ComboBox_Range.Items.AddRange(New Object() {"Auto", "Grow", "0.01", "0.02", "0.05", "0.1", "0.2", "0.5", "1", "2", "5", "10", "20", "50", "100", "200", "500", "1000", "Auto"})
        Me.ComboBox_Range.Location = New System.Drawing.Point(654, 244)
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
        Me.Label_Range.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Range.Location = New System.Drawing.Point(426, 242)
        Me.Label_Range.MaximumSize = New System.Drawing.Size(100, 20)
        Me.Label_Range.MinimumSize = New System.Drawing.Size(225, 20)
        Me.Label_Range.Name = "Label_Range"
        Me.Label_Range.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label_Range.Size = New System.Drawing.Size(225, 20)
        Me.Label_Range.TabIndex = 88
        Me.Label_Range.Text = "Displacement Range"
        '
        'Capture_Button
        '
        Me.Capture_Button.AccessibleDescription = ""
        Me.Capture_Button.AccessibleName = ""
        Me.Capture_Button.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.Capture_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Capture_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Capture_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Capture_Button.Location = New System.Drawing.Point(158, 135)
        Me.Capture_Button.Name = "Capture_Button"
        Me.Capture_Button.Size = New System.Drawing.Size(100, 23)
        Me.Capture_Button.TabIndex = 91
        Me.Capture_Button.Text = "Enable Capture"
        '
        'GraphControl
        '
        Me.GraphControl.AccessibleDescription = ""
        Me.GraphControl.AccessibleName = ""
        Me.GraphControl.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
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
        Me.Suspend.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
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
        Me.FrequencyButton.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
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
        Me.StraightnessShortButton.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.StraightnessShortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StraightnessShortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StraightnessShortButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StraightnessShortButton.Location = New System.Drawing.Point(578, 185)
        Me.StraightnessShortButton.Name = "StraightnessShortButton"
        Me.StraightnessShortButton.Size = New System.Drawing.Size(114, 23)
        Me.StraightnessShortButton.TabIndex = 43
        Me.StraightnessShortButton.Text = "Straightness Short"
        '
        'StraightnessLongButton
        '
        Me.StraightnessLongButton.AccessibleDescription = ""
        Me.StraightnessLongButton.AccessibleName = ""
        Me.StraightnessLongButton.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.StraightnessLongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StraightnessLongButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StraightnessLongButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StraightnessLongButton.Location = New System.Drawing.Point(442, 185)
        Me.StraightnessLongButton.Name = "StraightnessLongButton"
        Me.StraightnessLongButton.Size = New System.Drawing.Size(114, 23)
        Me.StraightnessLongButton.TabIndex = 42
        Me.StraightnessLongButton.Text = "Straightness Long"
        '
        'AngleButton
        '
        Me.AngleButton.AccessibleDescription = ""
        Me.AngleButton.AccessibleName = ""
        Me.AngleButton.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
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
        Me.DisplacementButton.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.ActiveButton6
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
        Me.ZeroButton.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
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
        Me.VelocityButton.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.VelocityButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VelocityButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.VelocityButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.VelocityButton.Location = New System.Drawing.Point(171, 185)
        Me.VelocityButton.Name = "VelocityButton"
        Me.VelocityButton.Size = New System.Drawing.Size(114, 23)
        Me.VelocityButton.TabIndex = 32
        Me.VelocityButton.Text = "Velocity"
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
        Me.Suspend_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Suspend_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Suspend_Label.Location = New System.Drawing.Point(700, 49)
        Me.Suspend_Label.Name = "Suspend_Label"
        Me.Suspend_Label.Size = New System.Drawing.Size(106, 26)
        Me.Suspend_Label.TabIndex = 95
        Me.Suspend_Label.Text = "Suspended"
        Me.Suspend_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Suspend_Label.Visible = False
        '
        'RangeUnits
        '
        Me.RangeUnits.AutoSize = True
        Me.RangeUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RangeUnits.Location = New System.Drawing.Point(703, 245)
        Me.RangeUnits.Name = "RangeUnits"
        Me.RangeUnits.Size = New System.Drawing.Size(25, 15)
        Me.RangeUnits.TabIndex = 96
        Me.RangeUnits.Text = "nm"
        '
        'AngleLabel
        '
        Me.AngleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AngleLabel.Location = New System.Drawing.Point(666, 56)
        Me.AngleLabel.Name = "AngleLabel"
        Me.AngleLabel.Size = New System.Drawing.Size(177, 67)
        Me.AngleLabel.TabIndex = 44
        Me.AngleLabel.Text = "arcsec"
        Me.AngleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AngleLabel.Visible = False
        '
        'Label_RangeTime
        '
        Me.Label_RangeTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RangeTime.Location = New System.Drawing.Point(729, 245)
        Me.Label_RangeTime.Name = "Label_RangeTime"
        Me.Label_RangeTime.Size = New System.Drawing.Size(20, 18)
        Me.Label_RangeTime.TabIndex = 97
        Me.Label_RangeTime.Text = "/s"
        '
        'Frequency_Axis
        '
        Me.Frequency_Axis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Frequency_Axis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frequency_Axis.Location = New System.Drawing.Point(110, 494)
        Me.Frequency_Axis.Name = "Frequency_Axis"
        Me.Frequency_Axis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frequency_Axis.Size = New System.Drawing.Size(745, 14)
        Me.Frequency_Axis.TabIndex = 98
        Me.Frequency_Axis.Text = "1 2  5      10              20              30              40              50   " & _
    "           60             70              80              90            100"
        Me.Frequency_Axis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainForm
        '
        Me.ClientSize = New System.Drawing.Size(880, 572)
        Me.Controls.Add(Me.Frequency_Axis)
        Me.Controls.Add(Me.Label_RangeTime)
        Me.Controls.Add(Me.RangeUnits)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interferometer GUI"
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
    Friend WithEvents RangeUnits As System.Windows.Forms.Label
    Friend WithEvents AngleLabel As System.Windows.Forms.Label
    Friend WithEvents Label_RangeTime As System.Windows.Forms.Label
    Friend WithEvents Frequency_Axis As System.Windows.Forms.Label
End Class
