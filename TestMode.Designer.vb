<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestMode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestMode))
        Me.ComboBox_Frequency = New System.Windows.Forms.ComboBox()
        Me.Trackbar_Frequency = New System.Windows.Forms.TrackBar()
        Me.TextBox_Offset = New System.Windows.Forms.TextBox()
        Me.TextBox_Amplitude = New System.Windows.Forms.TextBox()
        Me.TextBox_Offset_Label = New System.Windows.Forms.TextBox()
        Me.TextBox_Frequency_Label = New System.Windows.Forms.TextBox()
        Me.TextBox_Amplitude_Label = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TrackBar_Amplitude = New System.Windows.Forms.TrackBar()
        Me.TrackBar_Offset = New System.Windows.Forms.TrackBar()
        Me.Textbox_Frequency = New System.Windows.Forms.TextBox()
        Me.ComboBox_Amplitude = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Offset = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox_Units = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox_Units_Caution = New System.Windows.Forms.TextBox()
        Me.FGREFLabel = New System.Windows.Forms.TextBox()
        Me.FGREFMHz = New System.Windows.Forms.TextBox()
        Me.NumericUpDown_FGREF_Value = New System.Windows.Forms.NumericUpDown()
        Me.Error_Detection_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Diagnostic_Enable_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Multiple_Axes_Enable_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Axis1_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Axis2_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Axis3_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Axis_Select_Label = New System.Windows.Forms.TextBox()
        Me.TMClose_Button = New System.Windows.Forms.Button()
        Me.ZeroButton = New System.Windows.Forms.Button()
        Me.FGOff_Button = New System.Windows.Forms.Button()
        Me.FGOn_Button = New System.Windows.Forms.Button()
        Me.Button_Constant = New System.Windows.Forms.Button()
        Me.Button_Triangle = New System.Windows.Forms.Button()
        Me.Button_Sine = New System.Windows.Forms.Button()
        Me.Button_Ramp = New System.Windows.Forms.Button()
        CType(Me.Trackbar_Frequency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_Amplitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_Offset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_FGREF_Value, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox_Frequency
        '
        Me.ComboBox_Frequency.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox_Frequency.FormattingEnabled = True
        Me.ComboBox_Frequency.Items.AddRange(New Object() {"0 to 0.1 Hz", "0 to 1 Hz", "0 to 10 Hz", "0 to 100 Hz", "0 to 1 kHz"})
        Me.ComboBox_Frequency.Location = New System.Drawing.Point(145, 112)
        Me.ComboBox_Frequency.Name = "ComboBox_Frequency"
        Me.ComboBox_Frequency.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_Frequency.Size = New System.Drawing.Size(83, 21)
        Me.ComboBox_Frequency.TabIndex = 7
        Me.ComboBox_Frequency.Text = "0 to 10 Hz"
        '
        'Trackbar_Frequency
        '
        Me.Trackbar_Frequency.AccessibleDescription = "Extent of movement"
        Me.Trackbar_Frequency.LargeChange = 1
        Me.Trackbar_Frequency.Location = New System.Drawing.Point(162, 142)
        Me.Trackbar_Frequency.Maximum = 100
        Me.Trackbar_Frequency.Name = "Trackbar_Frequency"
        Me.Trackbar_Frequency.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Trackbar_Frequency.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Trackbar_Frequency.RightToLeftLayout = True
        Me.Trackbar_Frequency.Size = New System.Drawing.Size(45, 122)
        Me.Trackbar_Frequency.TabIndex = 8
        Me.Trackbar_Frequency.TickFrequency = 10
        Me.Trackbar_Frequency.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.Trackbar_Frequency.Value = 10
        '
        'TextBox_Offset
        '
        Me.TextBox_Offset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Offset.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox_Offset.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Offset.Location = New System.Drawing.Point(334, 264)
        Me.TextBox_Offset.Name = "TextBox_Offset"
        Me.TextBox_Offset.ReadOnly = True
        Me.TextBox_Offset.Size = New System.Drawing.Size(91, 13)
        Me.TextBox_Offset.TabIndex = 25
        Me.TextBox_Offset.Text = "0..00"
        Me.TextBox_Offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Amplitude
        '
        Me.TextBox_Amplitude.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Amplitude.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox_Amplitude.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Amplitude.Location = New System.Drawing.Point(265, 264)
        Me.TextBox_Amplitude.MaximumSize = New System.Drawing.Size(100, 0)
        Me.TextBox_Amplitude.Name = "TextBox_Amplitude"
        Me.TextBox_Amplitude.ReadOnly = True
        Me.TextBox_Amplitude.Size = New System.Drawing.Size(48, 13)
        Me.TextBox_Amplitude.TabIndex = 24
        Me.TextBox_Amplitude.Text = "0.5000"
        '
        'TextBox_Offset_Label
        '
        Me.TextBox_Offset_Label.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_Offset_Label.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Offset_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Offset_Label.Location = New System.Drawing.Point(358, 81)
        Me.TextBox_Offset_Label.Name = "TextBox_Offset_Label"
        Me.TextBox_Offset_Label.ReadOnly = True
        Me.TextBox_Offset_Label.Size = New System.Drawing.Size(50, 14)
        Me.TextBox_Offset_Label.TabIndex = 15
        Me.TextBox_Offset_Label.Text = "Offset"
        Me.TextBox_Offset_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Frequency_Label
        '
        Me.TextBox_Frequency_Label.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_Frequency_Label.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Frequency_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.4!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Frequency_Label.Location = New System.Drawing.Point(145, 81)
        Me.TextBox_Frequency_Label.Name = "TextBox_Frequency_Label"
        Me.TextBox_Frequency_Label.ReadOnly = True
        Me.TextBox_Frequency_Label.Size = New System.Drawing.Size(83, 15)
        Me.TextBox_Frequency_Label.TabIndex = 16
        Me.TextBox_Frequency_Label.Text = "Frequency"
        Me.TextBox_Frequency_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Amplitude_Label
        '
        Me.TextBox_Amplitude_Label.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_Amplitude_Label.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Amplitude_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.4!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Amplitude_Label.Location = New System.Drawing.Point(247, 81)
        Me.TextBox_Amplitude_Label.Name = "TextBox_Amplitude_Label"
        Me.TextBox_Amplitude_Label.ReadOnly = True
        Me.TextBox_Amplitude_Label.Size = New System.Drawing.Size(78, 15)
        Me.TextBox_Amplitude_Label.TabIndex = 14
        Me.TextBox_Amplitude_Label.Text = "Ampiltude"
        Me.TextBox_Amplitude_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.4!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(41, 113)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(78, 15)
        Me.TextBox8.TabIndex = 13
        Me.TextBox8.Text = "Waveform"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TrackBar_Amplitude
        '
        Me.TrackBar_Amplitude.AccessibleDescription = "Extent of movement"
        Me.TrackBar_Amplitude.LargeChange = 1
        Me.TrackBar_Amplitude.Location = New System.Drawing.Point(265, 141)
        Me.TrackBar_Amplitude.Maximum = 100
        Me.TrackBar_Amplitude.Name = "TrackBar_Amplitude"
        Me.TrackBar_Amplitude.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar_Amplitude.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrackBar_Amplitude.RightToLeftLayout = True
        Me.TrackBar_Amplitude.Size = New System.Drawing.Size(45, 123)
        Me.TrackBar_Amplitude.TabIndex = 26
        Me.TrackBar_Amplitude.TickFrequency = 10
        Me.TrackBar_Amplitude.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBar_Amplitude.Value = 50
        '
        'TrackBar_Offset
        '
        Me.TrackBar_Offset.AccessibleDescription = "Extent of movement"
        Me.TrackBar_Offset.LargeChange = 1
        Me.TrackBar_Offset.Location = New System.Drawing.Point(363, 141)
        Me.TrackBar_Offset.Maximum = 100
        Me.TrackBar_Offset.Minimum = -100
        Me.TrackBar_Offset.Name = "TrackBar_Offset"
        Me.TrackBar_Offset.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar_Offset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrackBar_Offset.RightToLeftLayout = True
        Me.TrackBar_Offset.Size = New System.Drawing.Size(45, 123)
        Me.TrackBar_Offset.TabIndex = 27
        Me.TrackBar_Offset.TickFrequency = 10
        Me.TrackBar_Offset.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'Textbox_Frequency
        '
        Me.Textbox_Frequency.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Textbox_Frequency.BackColor = System.Drawing.SystemColors.Menu
        Me.Textbox_Frequency.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Textbox_Frequency.Location = New System.Drawing.Point(142, 264)
        Me.Textbox_Frequency.Name = "Textbox_Frequency"
        Me.Textbox_Frequency.ReadOnly = True
        Me.Textbox_Frequency.Size = New System.Drawing.Size(77, 13)
        Me.Textbox_Frequency.TabIndex = 28
        Me.Textbox_Frequency.Text = "1.00"
        Me.Textbox_Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox_Amplitude
        '
        Me.ComboBox_Amplitude.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox_Amplitude.FormattingEnabled = True
        Me.ComboBox_Amplitude.Items.AddRange(New Object() {"0 to 0.01", "0 to 0.1", "0 to 1"})
        Me.ComboBox_Amplitude.Location = New System.Drawing.Point(250, 111)
        Me.ComboBox_Amplitude.Name = "ComboBox_Amplitude"
        Me.ComboBox_Amplitude.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_Amplitude.Size = New System.Drawing.Size(69, 21)
        Me.ComboBox_Amplitude.TabIndex = 29
        Me.ComboBox_Amplitude.Text = "0 to 1"
        '
        'ComboBox_Offset
        '
        Me.ComboBox_Offset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox_Offset.AutoCompleteCustomSource.AddRange(New String() {"-100 to +100", "-10 to +10", "-1 to +1"})
        Me.ComboBox_Offset.FormattingEnabled = True
        Me.ComboBox_Offset.Items.AddRange(New Object() {"-1 to +1", "-10 to +10", "-100 to +100"})
        Me.ComboBox_Offset.Location = New System.Drawing.Point(340, 111)
        Me.ComboBox_Offset.Name = "ComboBox_Offset"
        Me.ComboBox_Offset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_Offset.Size = New System.Drawing.Size(85, 21)
        Me.ComboBox_Offset.TabIndex = 30
        Me.ComboBox_Offset.Tag = ""
        Me.ComboBox_Offset.Text = "-100 to +100"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(38, 31)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(145, 22)
        Me.TextBox4.TabIndex = 31
        Me.TextBox4.Text = "Simulated Data"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox_Units
        '
        Me.ComboBox_Units.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox_Units.FormattingEnabled = True
        Me.ComboBox_Units.Items.AddRange(New Object() {"μm", "mm", "cm", "m", "in", "ft"})
        Me.ComboBox_Units.Location = New System.Drawing.Point(339, 321)
        Me.ComboBox_Units.Name = "ComboBox_Units"
        Me.ComboBox_Units.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_Units.Size = New System.Drawing.Size(39, 21)
        Me.ComboBox_Units.TabIndex = 34
        Me.ComboBox_Units.Text = "mm"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(282, 322)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(56, 15)
        Me.TextBox5.TabIndex = 35
        Me.TextBox5.Text = " Units"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Units_Caution
        '
        Me.TextBox_Units_Caution.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Units_Caution.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox_Units_Caution.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Units_Caution.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox_Units_Caution.Location = New System.Drawing.Point(275, 303)
        Me.TextBox_Units_Caution.MaximumSize = New System.Drawing.Size(200, 0)
        Me.TextBox_Units_Caution.MinimumSize = New System.Drawing.Size(100, 0)
        Me.TextBox_Units_Caution.Name = "TextBox_Units_Caution"
        Me.TextBox_Units_Caution.ReadOnly = True
        Me.TextBox_Units_Caution.Size = New System.Drawing.Size(125, 13)
        Me.TextBox_Units_Caution.TabIndex = 40
        Me.TextBox_Units_Caution.Text = "Slew (Rate) Error Possible"
        Me.TextBox_Units_Caution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox_Units_Caution.Visible = False
        '
        'FGREFLabel
        '
        Me.FGREFLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FGREFLabel.BackColor = System.Drawing.SystemColors.Menu
        Me.FGREFLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FGREFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FGREFLabel.Location = New System.Drawing.Point(89, 322)
        Me.FGREFLabel.Name = "FGREFLabel"
        Me.FGREFLabel.ReadOnly = True
        Me.FGREFLabel.Size = New System.Drawing.Size(46, 15)
        Me.FGREFLabel.TabIndex = 42
        Me.FGREFLabel.Text = " REF:"
        Me.FGREFLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FGREFMHz
        '
        Me.FGREFMHz.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FGREFMHz.BackColor = System.Drawing.SystemColors.Menu
        Me.FGREFMHz.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FGREFMHz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FGREFMHz.Location = New System.Drawing.Point(182, 322)
        Me.FGREFMHz.Name = "FGREFMHz"
        Me.FGREFMHz.ReadOnly = True
        Me.FGREFMHz.Size = New System.Drawing.Size(46, 15)
        Me.FGREFMHz.TabIndex = 72
        Me.FGREFMHz.Text = " MHz"
        Me.FGREFMHz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown_FGREF_Value
        '
        Me.NumericUpDown_FGREF_Value.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown_FGREF_Value.DecimalPlaces = 2
        Me.NumericUpDown_FGREF_Value.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDown_FGREF_Value.Location = New System.Drawing.Point(136, 322)
        Me.NumericUpDown_FGREF_Value.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown_FGREF_Value.Minimum = New Decimal(New Integer() {2, 0, 0, 65536})
        Me.NumericUpDown_FGREF_Value.Name = "NumericUpDown_FGREF_Value"
        Me.NumericUpDown_FGREF_Value.Size = New System.Drawing.Size(51, 20)
        Me.NumericUpDown_FGREF_Value.TabIndex = 73
        Me.NumericUpDown_FGREF_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_FGREF_Value.Value = New Decimal(New Integer() {3750, 0, 0, 196608})
        '
        'Error_Detection_CheckBox
        '
        Me.Error_Detection_CheckBox.AutoSize = True
        Me.Error_Detection_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Error_Detection_CheckBox.Checked = True
        Me.Error_Detection_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Error_Detection_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Error_Detection_CheckBox.Location = New System.Drawing.Point(283, 406)
        Me.Error_Detection_CheckBox.Name = "Error_Detection_CheckBox"
        Me.Error_Detection_CheckBox.Size = New System.Drawing.Size(123, 21)
        Me.Error_Detection_CheckBox.TabIndex = 109
        Me.Error_Detection_CheckBox.Text = "Error Detection"
        Me.Error_Detection_CheckBox.UseVisualStyleBackColor = True
        '
        'Diagnostic_Enable_CheckBox
        '
        Me.Diagnostic_Enable_CheckBox.AutoSize = True
        Me.Diagnostic_Enable_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Diagnostic_Enable_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Diagnostic_Enable_CheckBox.Location = New System.Drawing.Point(248, 427)
        Me.Diagnostic_Enable_CheckBox.Name = "Diagnostic_Enable_CheckBox"
        Me.Diagnostic_Enable_CheckBox.Size = New System.Drawing.Size(158, 21)
        Me.Diagnostic_Enable_CheckBox.TabIndex = 110
        Me.Diagnostic_Enable_CheckBox.Text = "Diagnostic Readouts"
        Me.Diagnostic_Enable_CheckBox.UseVisualStyleBackColor = True
        '
        'Multiple_Axes_Enable_CheckBox
        '
        Me.Multiple_Axes_Enable_CheckBox.AutoSize = True
        Me.Multiple_Axes_Enable_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Multiple_Axes_Enable_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiple_Axes_Enable_CheckBox.Location = New System.Drawing.Point(263, 354)
        Me.Multiple_Axes_Enable_CheckBox.Name = "Multiple_Axes_Enable_CheckBox"
        Me.Multiple_Axes_Enable_CheckBox.Size = New System.Drawing.Size(143, 21)
        Me.Multiple_Axes_Enable_CheckBox.TabIndex = 111
        Me.Multiple_Axes_Enable_CheckBox.Text = "Multiple Axis Mode"
        Me.Multiple_Axes_Enable_CheckBox.UseVisualStyleBackColor = True
        '
        'Axis1_CheckBox
        '
        Me.Axis1_CheckBox.AutoSize = True
        Me.Axis1_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Axis1_CheckBox.Checked = True
        Me.Axis1_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Axis1_CheckBox.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis1_CheckBox.Location = New System.Drawing.Point(285, 375)
        Me.Axis1_CheckBox.Name = "Axis1_CheckBox"
        Me.Axis1_CheckBox.Size = New System.Drawing.Size(36, 19)
        Me.Axis1_CheckBox.TabIndex = 112
        Me.Axis1_CheckBox.Text = " 1"
        Me.Axis1_CheckBox.UseVisualStyleBackColor = True
        Me.Axis1_CheckBox.Visible = False
        '
        'Axis2_Checkbox
        '
        Me.Axis2_Checkbox.AutoSize = True
        Me.Axis2_Checkbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Axis2_Checkbox.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis2_Checkbox.Location = New System.Drawing.Point(324, 375)
        Me.Axis2_Checkbox.Name = "Axis2_Checkbox"
        Me.Axis2_Checkbox.Size = New System.Drawing.Size(36, 19)
        Me.Axis2_Checkbox.TabIndex = 113
        Me.Axis2_Checkbox.Text = " 2"
        Me.Axis2_Checkbox.UseVisualStyleBackColor = True
        Me.Axis2_Checkbox.Visible = False
        '
        'Axis3_CheckBox
        '
        Me.Axis3_CheckBox.AutoSize = True
        Me.Axis3_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Axis3_CheckBox.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Axis3_CheckBox.Location = New System.Drawing.Point(363, 375)
        Me.Axis3_CheckBox.Name = "Axis3_CheckBox"
        Me.Axis3_CheckBox.Size = New System.Drawing.Size(36, 19)
        Me.Axis3_CheckBox.TabIndex = 114
        Me.Axis3_CheckBox.Text = " 3"
        Me.Axis3_CheckBox.UseVisualStyleBackColor = True
        Me.Axis3_CheckBox.Visible = False
        '
        'Axis_Select_Label
        '
        Me.Axis_Select_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Axis_Select_Label.BackColor = System.Drawing.SystemColors.Menu
        Me.Axis_Select_Label.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Axis_Select_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Axis_Select_Label.Location = New System.Drawing.Point(247, 375)
        Me.Axis_Select_Label.Name = "Axis_Select_Label"
        Me.Axis_Select_Label.ReadOnly = True
        Me.Axis_Select_Label.Size = New System.Drawing.Size(46, 14)
        Me.Axis_Select_Label.TabIndex = 115
        Me.Axis_Select_Label.Text = " Axis:"
        Me.Axis_Select_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Axis_Select_Label.Visible = False
        '
        'TMClose_Button
        '
        Me.TMClose_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TMClose_Button.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.TMClose_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TMClose_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TMClose_Button.Location = New System.Drawing.Point(198, 476)
        Me.TMClose_Button.Name = "TMClose_Button"
        Me.TMClose_Button.Size = New System.Drawing.Size(67, 23)
        Me.TMClose_Button.TabIndex = 1
        Me.TMClose_Button.Text = "CLOSE"
        '
        'ZeroButton
        '
        Me.ZeroButton.AccessibleDescription = ""
        Me.ZeroButton.AccessibleName = ""
        Me.ZeroButton.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.ZeroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ZeroButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ZeroButton.Location = New System.Drawing.Point(59, 370)
        Me.ZeroButton.Name = "ZeroButton"
        Me.ZeroButton.Size = New System.Drawing.Size(105, 23)
        Me.ZeroButton.TabIndex = 41
        Me.ZeroButton.Text = "Reset Display"
        '
        'FGOff_Button
        '
        Me.FGOff_Button.BackColor = System.Drawing.SystemColors.Control
        Me.FGOff_Button.BackgroundImage = Global.uMDGUI.My.Resources.Resources.ActiveButton6
        Me.FGOff_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FGOff_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FGOff_Button.Location = New System.Drawing.Point(207, 31)
        Me.FGOff_Button.Name = "FGOff_Button"
        Me.FGOff_Button.Size = New System.Drawing.Size(47, 24)
        Me.FGOff_Button.TabIndex = 36
        Me.FGOff_Button.Text = "OFF"
        Me.FGOff_Button.UseVisualStyleBackColor = False
        '
        'FGOn_Button
        '
        Me.FGOn_Button.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.FGOn_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FGOn_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FGOn_Button.Location = New System.Drawing.Point(283, 31)
        Me.FGOn_Button.Name = "FGOn_Button"
        Me.FGOn_Button.Size = New System.Drawing.Size(55, 24)
        Me.FGOn_Button.TabIndex = 33
        Me.FGOn_Button.Text = "ON"
        Me.FGOn_Button.UseVisualStyleBackColor = True
        '
        'Button_Constant
        '
        Me.Button_Constant.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.Button_Constant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Constant.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Constant.Location = New System.Drawing.Point(39, 145)
        Me.Button_Constant.Name = "Button_Constant"
        Me.Button_Constant.Size = New System.Drawing.Size(81, 25)
        Me.Button_Constant.TabIndex = 32
        Me.Button_Constant.Text = "Constant"
        Me.Button_Constant.UseVisualStyleBackColor = True
        '
        'Button_Triangle
        '
        Me.Button_Triangle.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Triangle.BackgroundImage = Global.uMDGUI.My.Resources.Resources.ActiveButton6
        Me.Button_Triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Triangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Triangle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Triangle.Location = New System.Drawing.Point(39, 216)
        Me.Button_Triangle.Name = "Button_Triangle"
        Me.Button_Triangle.Size = New System.Drawing.Size(81, 25)
        Me.Button_Triangle.TabIndex = 18
        Me.Button_Triangle.Text = "Triangle"
        Me.Button_Triangle.UseVisualStyleBackColor = False
        '
        'Button_Sine
        '
        Me.Button_Sine.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.Button_Sine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Sine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Sine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Sine.Location = New System.Drawing.Point(39, 252)
        Me.Button_Sine.Name = "Button_Sine"
        Me.Button_Sine.Size = New System.Drawing.Size(81, 24)
        Me.Button_Sine.TabIndex = 6
        Me.Button_Sine.Text = "Sine"
        Me.Button_Sine.UseVisualStyleBackColor = True
        '
        'Button_Ramp
        '
        Me.Button_Ramp.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.Button_Ramp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Ramp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Ramp.Location = New System.Drawing.Point(38, 181)
        Me.Button_Ramp.Name = "Button_Ramp"
        Me.Button_Ramp.Size = New System.Drawing.Size(81, 25)
        Me.Button_Ramp.TabIndex = 12
        Me.Button_Ramp.Text = "Ramp"
        Me.Button_Ramp.UseVisualStyleBackColor = True
        '
        'TestMode
        '
        Me.AcceptButton = Me.TMClose_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 531)
        Me.Controls.Add(Me.Axis_Select_Label)
        Me.Controls.Add(Me.Axis3_CheckBox)
        Me.Controls.Add(Me.Axis2_Checkbox)
        Me.Controls.Add(Me.Axis1_CheckBox)
        Me.Controls.Add(Me.Multiple_Axes_Enable_CheckBox)
        Me.Controls.Add(Me.Diagnostic_Enable_CheckBox)
        Me.Controls.Add(Me.Error_Detection_CheckBox)
        Me.Controls.Add(Me.NumericUpDown_FGREF_Value)
        Me.Controls.Add(Me.FGREFMHz)
        Me.Controls.Add(Me.FGREFLabel)
        Me.Controls.Add(Me.ZeroButton)
        Me.Controls.Add(Me.TextBox_Units_Caution)
        Me.Controls.Add(Me.FGOff_Button)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.ComboBox_Units)
        Me.Controls.Add(Me.FGOn_Button)
        Me.Controls.Add(Me.Button_Constant)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ComboBox_Offset)
        Me.Controls.Add(Me.ComboBox_Amplitude)
        Me.Controls.Add(Me.Textbox_Frequency)
        Me.Controls.Add(Me.TrackBar_Offset)
        Me.Controls.Add(Me.TrackBar_Amplitude)
        Me.Controls.Add(Me.TextBox_Amplitude_Label)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Button_Triangle)
        Me.Controls.Add(Me.TextBox_Offset)
        Me.Controls.Add(Me.TextBox_Amplitude)
        Me.Controls.Add(Me.TextBox_Offset_Label)
        Me.Controls.Add(Me.Button_Sine)
        Me.Controls.Add(Me.Button_Ramp)
        Me.Controls.Add(Me.TextBox_Frequency_Label)
        Me.Controls.Add(Me.Trackbar_Frequency)
        Me.Controls.Add(Me.ComboBox_Frequency)
        Me.Controls.Add(Me.TMClose_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(50, 400)
        Me.MaximizeBox = False
        Me.Name = "TestMode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Micro Measurement Display Test Mode Parameters"
        CType(Me.Trackbar_Frequency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_Amplitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_Offset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_FGREF_Value, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TMClose_Button As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Frequency As System.Windows.Forms.ComboBox
    Friend WithEvents Trackbar_Frequency As System.Windows.Forms.TrackBar
    Friend WithEvents TextBox_Offset As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Amplitude As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Offset_Label As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Frequency_Label As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Amplitude_Label As System.Windows.Forms.TextBox
    Friend WithEvents Button_Ramp As System.Windows.Forms.Button
    Friend WithEvents Button_Sine As System.Windows.Forms.Button
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Button_Triangle As System.Windows.Forms.Button
    Friend WithEvents TrackBar_Amplitude As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar_Offset As System.Windows.Forms.TrackBar
    Friend WithEvents Textbox_Frequency As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_Amplitude As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Offset As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button_Constant As System.Windows.Forms.Button
    Friend WithEvents FGOn_Button As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Units As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents FGOff_Button As System.Windows.Forms.Button
    Friend WithEvents TextBox_Units_Caution As System.Windows.Forms.TextBox
    Friend WithEvents ZeroButton As System.Windows.Forms.Button
    Friend WithEvents FGREFLabel As System.Windows.Forms.TextBox
    Friend WithEvents FGREFMHz As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown_FGREF_Value As System.Windows.Forms.NumericUpDown
    Friend WithEvents Error_Detection_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Diagnostic_Enable_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Multiple_Axes_Enable_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Axis1_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Axis2_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Axis3_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Axis_Select_Label As System.Windows.Forms.TextBox
End Class
