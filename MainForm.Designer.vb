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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.ValueDisplay = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.AngleLabel = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AverageLabel = New System.Windows.Forms.Label()
        Me.UnitLabel = New System.Windows.Forms.Label()
        Me.GraphControl = New System.Windows.Forms.Button()
        Me.Suspend = New System.Windows.Forms.Button()
        Me.FrequencyButton = New System.Windows.Forms.Button()
        Me.StraightnessShortButton = New System.Windows.Forms.Button()
        Me.StraightnessLongButton = New System.Windows.Forms.Button()
        Me.AngleButton = New System.Windows.Forms.Button()
        Me.DisplacementButton = New System.Windows.Forms.Button()
        Me.ZeroButton = New System.Windows.Forms.Button()
        Me.VelocityButton = New System.Windows.Forms.Button()
        Me.REFLABEL = New System.Windows.Forms.Label()
        Me.MEASLABEL = New System.Windows.Forms.Label()
        Me.REF = New System.Windows.Forms.Label()
        Me.MEAS = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ValueDisplay
        '
        Me.ValueDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueDisplay.Location = New System.Drawing.Point(156, 18)
        Me.ValueDisplay.Name = "ValueDisplay"
        Me.ValueDisplay.Size = New System.Drawing.Size(503, 70)
        Me.ValueDisplay.TabIndex = 34
        Me.ValueDisplay.Text = "0.000"
        Me.ValueDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Me.Chart1.Location = New System.Drawing.Point(145, 195)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(627, 283)
        Me.Chart1.TabIndex = 36
        Me.Chart1.Text = "Chart1"
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Title1"
        Title3.Text = "Position"
        Me.Chart1.Titles.Add(Title3)
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 17
        '
        'TimeLabel
        '
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(754, 26)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(96, 48)
        Me.TimeLabel.TabIndex = 44
        Me.TimeLabel.Text = "/s"
        Me.TimeLabel.Visible = False
        '
        'AngleLabel
        '
        Me.AngleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AngleLabel.Location = New System.Drawing.Point(665, 26)
        Me.AngleLabel.Name = "AngleLabel"
        Me.AngleLabel.Size = New System.Drawing.Size(177, 67)
        Me.AngleLabel.TabIndex = 44
        Me.AngleLabel.Text = "arcsec"
        Me.AngleLabel.Visible = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(309, 96)
        Me.TrackBar1.Maximum = 99
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(252, 45)
        Me.TrackBar1.TabIndex = 46
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Averaging:"
        '
        'AverageLabel
        '
        Me.AverageLabel.AutoSize = True
        Me.AverageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageLabel.Location = New System.Drawing.Point(571, 96)
        Me.AverageLabel.Name = "AverageLabel"
        Me.AverageLabel.Size = New System.Drawing.Size(18, 20)
        Me.AverageLabel.TabIndex = 48
        Me.AverageLabel.Text = "0"
        '
        'UnitLabel
        '
        Me.UnitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitLabel.Location = New System.Drawing.Point(665, 26)
        Me.UnitLabel.Name = "UnitLabel"
        Me.UnitLabel.Size = New System.Drawing.Size(104, 48)
        Me.UnitLabel.TabIndex = 35
        Me.UnitLabel.Text = "nm"
        '
        'GraphControl
        '
        Me.GraphControl.AccessibleDescription = ""
        Me.GraphControl.AccessibleName = ""
        Me.GraphControl.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.GraphControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GraphControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GraphControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GraphControl.Location = New System.Drawing.Point(34, 96)
        Me.GraphControl.Name = "GraphControl"
        Me.GraphControl.Size = New System.Drawing.Size(114, 23)
        Me.GraphControl.TabIndex = 1
        Me.GraphControl.Text = "Disable Graph"
        '
        'Suspend
        '
        Me.Suspend.AccessibleDescription = ""
        Me.Suspend.AccessibleName = ""
        Me.Suspend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Suspend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Suspend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Suspend.Location = New System.Drawing.Point(764, 96)
        Me.Suspend.Name = "Suspend"
        Me.Suspend.Size = New System.Drawing.Size(81, 23)
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
        Me.FrequencyButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FrequencyButton.Location = New System.Drawing.Point(731, 145)
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
        Me.StraightnessShortButton.Location = New System.Drawing.Point(575, 145)
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
        Me.StraightnessLongButton.Location = New System.Drawing.Point(439, 145)
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
        Me.AngleButton.Location = New System.Drawing.Point(303, 145)
        Me.AngleButton.Name = "AngleButton"
        Me.AngleButton.Size = New System.Drawing.Size(114, 23)
        Me.AngleButton.TabIndex = 41
        Me.AngleButton.Text = "Angle"
        '
        'DisplacementButton
        '
        Me.DisplacementButton.AccessibleDescription = ""
        Me.DisplacementButton.AccessibleName = ""
        Me.DisplacementButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DisplacementButton.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.ActiveButton6
        Me.DisplacementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DisplacementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DisplacementButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DisplacementButton.Location = New System.Drawing.Point(34, 145)
        Me.DisplacementButton.Name = "DisplacementButton"
        Me.DisplacementButton.Size = New System.Drawing.Size(114, 23)
        Me.DisplacementButton.TabIndex = 40
        Me.DisplacementButton.Text = "Displacement"
        Me.DisplacementButton.UseVisualStyleBackColor = True
        '
        'ZeroButton
        '
        Me.ZeroButton.AccessibleDescription = ""
        Me.ZeroButton.AccessibleName = ""
        Me.ZeroButton.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.ZeroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ZeroButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ZeroButton.Location = New System.Drawing.Point(633, 96)
        Me.ZeroButton.Name = "ZeroButton"
        Me.ZeroButton.Size = New System.Drawing.Size(105, 23)
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
        Me.VelocityButton.Location = New System.Drawing.Point(167, 145)
        Me.VelocityButton.Name = "VelocityButton"
        Me.VelocityButton.Size = New System.Drawing.Size(114, 23)
        Me.VelocityButton.TabIndex = 32
        Me.VelocityButton.Text = "Velocity"
        '
        'REFLABEL
        '
        Me.REFLABEL.AutoSize = True
        Me.REFLABEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFLABEL.Location = New System.Drawing.Point(43, 34)
        Me.REFLABEL.Name = "REFLABEL"
        Me.REFLABEL.Size = New System.Drawing.Size(50, 20)
        Me.REFLABEL.TabIndex = 52
        Me.REFLABEL.Text = "REF: "
        '
        'MEASLABEL
        '
        Me.MEASLABEL.AutoSize = True
        Me.MEASLABEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEASLABEL.Location = New System.Drawing.Point(30, 54)
        Me.MEASLABEL.Name = "MEASLABEL"
        Me.MEASLABEL.Size = New System.Drawing.Size(63, 20)
        Me.MEASLABEL.TabIndex = 53
        Me.MEASLABEL.Text = "MEAS: "
        '
        'REF
        '
        Me.REF.AutoSize = True
        Me.REF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REF.Location = New System.Drawing.Point(85, 34)
        Me.REF.Name = "REF"
        Me.REF.Size = New System.Drawing.Size(49, 20)
        Me.REF.TabIndex = 54
        Me.REF.Text = "0.000"
        '
        'MEAS
        '
        Me.MEAS.AutoSize = True
        Me.MEAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEAS.Location = New System.Drawing.Point(85, 54)
        Me.MEAS.Name = "MEAS"
        Me.MEAS.Size = New System.Drawing.Size(49, 20)
        Me.MEAS.TabIndex = 55
        Me.MEAS.Text = "0.000"
        '
        'MainForm
        '
        Me.ClientSize = New System.Drawing.Size(880, 536)
        Me.Controls.Add(Me.MEAS)
        Me.Controls.Add(Me.REF)
        Me.Controls.Add(Me.MEASLABEL)
        Me.Controls.Add(Me.REFLABEL)
        Me.Controls.Add(Me.GraphControl)
        Me.Controls.Add(Me.Suspend)
        Me.Controls.Add(Me.AverageLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.FrequencyButton)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.AngleLabel)
        Me.Controls.Add(Me.StraightnessShortButton)
        Me.Controls.Add(Me.StraightnessLongButton)
        Me.Controls.Add(Me.AngleButton)
        Me.Controls.Add(Me.DisplacementButton)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.UnitLabel)
        Me.Controls.Add(Me.ValueDisplay)
        Me.Controls.Add(Me.ZeroButton)
        Me.Controls.Add(Me.VelocityButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.Text = "Interferometer GUI"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents AngleLabel As System.Windows.Forms.Label
    Friend WithEvents FrequencyButton As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GraphControl As System.Windows.Forms.Button
    Friend WithEvents AverageLabel As System.Windows.Forms.Label
    Friend WithEvents UnitLabel As System.Windows.Forms.Label
    Friend WithEvents Suspend As System.Windows.Forms.Button
    Friend WithEvents REFLABEL As System.Windows.Forms.Label
    Friend WithEvents MEASLABEL As System.Windows.Forms.Label
    Friend WithEvents REF As System.Windows.Forms.Label
    Friend WithEvents MEAS As System.Windows.Forms.Label

End Class
