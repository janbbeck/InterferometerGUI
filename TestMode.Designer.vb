﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TMClose_Button = New System.Windows.Forms.Button()
        Me.ComboBox_Frequency = New System.Windows.Forms.ComboBox()
        Me.Trackbar_Frequency = New System.Windows.Forms.TrackBar()
        Me.TextBox_Offset = New System.Windows.Forms.TextBox()
        Me.TextBox_Amplitude = New System.Windows.Forms.TextBox()
        Me.TextBox_Offset_Label = New System.Windows.Forms.TextBox()
        Me.TextBox_Frequency_Label = New System.Windows.Forms.TextBox()
        Me.TextBox_Amplitude_Label = New System.Windows.Forms.TextBox()
        Me.Button_Ramp = New System.Windows.Forms.Button()
        Me.Button_Square = New System.Windows.Forms.Button()
        Me.Button_Sine = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button_Triangle = New System.Windows.Forms.Button()
        Me.TrackBar_Amplitude = New System.Windows.Forms.TrackBar()
        Me.TrackBar_Offset = New System.Windows.Forms.TrackBar()
        Me.Textbox_Frequency = New System.Windows.Forms.TextBox()
        Me.ComboBox_Amplitude = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Offset = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button_Constant = New System.Windows.Forms.Button()
        Me.FGOn_Button = New System.Windows.Forms.Button()
        Me.ComboBox_Units = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.FGOff_Button = New System.Windows.Forms.Button()
        CType(Me.Trackbar_Frequency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_Amplitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_Offset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TMClose_Button
        '
        Me.TMClose_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TMClose_Button.Location = New System.Drawing.Point(211, 340)
        Me.TMClose_Button.Name = "TMClose_Button"
        Me.TMClose_Button.Size = New System.Drawing.Size(67, 23)
        Me.TMClose_Button.TabIndex = 1
        Me.TMClose_Button.Text = "CLOSE"
        '
        'ComboBox_Frequency
        '
        Me.ComboBox_Frequency.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox_Frequency.FormattingEnabled = True
        Me.ComboBox_Frequency.Items.AddRange(New Object() {"0 to 0.1 Hz", "0 to 1 Hz", "0 to 10 Hz", "0 to 100 Hz"})
        Me.ComboBox_Frequency.Location = New System.Drawing.Point(149, 106)
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
        Me.Trackbar_Frequency.Location = New System.Drawing.Point(166, 137)
        Me.Trackbar_Frequency.Maximum = 100
        Me.Trackbar_Frequency.Name = "Trackbar_Frequency"
        Me.Trackbar_Frequency.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Trackbar_Frequency.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Trackbar_Frequency.RightToLeftLayout = True
        Me.Trackbar_Frequency.Size = New System.Drawing.Size(45, 117)
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
        Me.TextBox_Offset.Location = New System.Drawing.Point(337, 260)
        Me.TextBox_Offset.Name = "TextBox_Offset"
        Me.TextBox_Offset.ReadOnly = True
        Me.TextBox_Offset.Size = New System.Drawing.Size(91, 13)
        Me.TextBox_Offset.TabIndex = 25
        Me.TextBox_Offset.Text = "0..000"
        Me.TextBox_Offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Amplitude
        '
        Me.TextBox_Amplitude.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Amplitude.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox_Amplitude.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Amplitude.Location = New System.Drawing.Point(242, 260)
        Me.TextBox_Amplitude.Name = "TextBox_Amplitude"
        Me.TextBox_Amplitude.ReadOnly = True
        Me.TextBox_Amplitude.Size = New System.Drawing.Size(89, 13)
        Me.TextBox_Amplitude.TabIndex = 24
        Me.TextBox_Amplitude.Text = "1.00"
        Me.TextBox_Amplitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Offset_Label
        '
        Me.TextBox_Offset_Label.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_Offset_Label.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Offset_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Offset_Label.Location = New System.Drawing.Point(366, 74)
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
        Me.TextBox_Frequency_Label.Location = New System.Drawing.Point(149, 72)
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
        Me.TextBox_Amplitude_Label.Location = New System.Drawing.Point(251, 73)
        Me.TextBox_Amplitude_Label.Name = "TextBox_Amplitude_Label"
        Me.TextBox_Amplitude_Label.ReadOnly = True
        Me.TextBox_Amplitude_Label.Size = New System.Drawing.Size(78, 15)
        Me.TextBox_Amplitude_Label.TabIndex = 14
        Me.TextBox_Amplitude_Label.Text = "Ampiltude"
        Me.TextBox_Amplitude_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_Ramp
        '
        Me.Button_Ramp.Location = New System.Drawing.Point(39, 199)
        Me.Button_Ramp.Name = "Button_Ramp"
        Me.Button_Ramp.Size = New System.Drawing.Size(81, 25)
        Me.Button_Ramp.TabIndex = 12
        Me.Button_Ramp.Text = "Ramp"
        Me.Button_Ramp.UseVisualStyleBackColor = True
        '
        'Button_Square
        '
        Me.Button_Square.Location = New System.Drawing.Point(39, 137)
        Me.Button_Square.Name = "Button_Square"
        Me.Button_Square.Size = New System.Drawing.Size(81, 25)
        Me.Button_Square.TabIndex = 6
        Me.Button_Square.Text = "Square"
        Me.Button_Square.UseVisualStyleBackColor = True
        '
        'Button_Sine
        '
        Me.Button_Sine.Location = New System.Drawing.Point(39, 230)
        Me.Button_Sine.Name = "Button_Sine"
        Me.Button_Sine.Size = New System.Drawing.Size(81, 24)
        Me.Button_Sine.TabIndex = 6
        Me.Button_Sine.Text = "Sine"
        Me.Button_Sine.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.4!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(39, 72)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(78, 15)
        Me.TextBox8.TabIndex = 13
        Me.TextBox8.Text = "Waveform"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_Triangle
        '
        Me.Button_Triangle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button_Triangle.Location = New System.Drawing.Point(39, 168)
        Me.Button_Triangle.Name = "Button_Triangle"
        Me.Button_Triangle.Size = New System.Drawing.Size(81, 25)
        Me.Button_Triangle.TabIndex = 18
        Me.Button_Triangle.Text = "Triangle"
        Me.Button_Triangle.UseVisualStyleBackColor = False
        '
        'TrackBar_Amplitude
        '
        Me.TrackBar_Amplitude.AccessibleDescription = "Extent of movement"
        Me.TrackBar_Amplitude.LargeChange = 1
        Me.TrackBar_Amplitude.Location = New System.Drawing.Point(268, 137)
        Me.TrackBar_Amplitude.Maximum = 100
        Me.TrackBar_Amplitude.Name = "TrackBar_Amplitude"
        Me.TrackBar_Amplitude.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar_Amplitude.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrackBar_Amplitude.RightToLeftLayout = True
        Me.TrackBar_Amplitude.Size = New System.Drawing.Size(45, 117)
        Me.TrackBar_Amplitude.TabIndex = 26
        Me.TrackBar_Amplitude.TickFrequency = 10
        Me.TrackBar_Amplitude.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBar_Amplitude.Value = 10
        '
        'TrackBar_Offset
        '
        Me.TrackBar_Offset.AccessibleDescription = "Extent of movement"
        Me.TrackBar_Offset.LargeChange = 1
        Me.TrackBar_Offset.Location = New System.Drawing.Point(371, 137)
        Me.TrackBar_Offset.Maximum = 100
        Me.TrackBar_Offset.Minimum = -100
        Me.TrackBar_Offset.Name = "TrackBar_Offset"
        Me.TrackBar_Offset.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar_Offset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrackBar_Offset.RightToLeftLayout = True
        Me.TrackBar_Offset.Size = New System.Drawing.Size(45, 117)
        Me.TrackBar_Offset.TabIndex = 27
        Me.TrackBar_Offset.TickFrequency = 10
        Me.TrackBar_Offset.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'Textbox_Frequency
        '
        Me.Textbox_Frequency.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Textbox_Frequency.BackColor = System.Drawing.SystemColors.Menu
        Me.Textbox_Frequency.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Textbox_Frequency.Location = New System.Drawing.Point(149, 260)
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
        Me.ComboBox_Amplitude.Items.AddRange(New Object() {"0 to 0.1", "0 to 1", "0 to 10", "0 to 100"})
        Me.ComboBox_Amplitude.Location = New System.Drawing.Point(255, 107)
        Me.ComboBox_Amplitude.Name = "ComboBox_Amplitude"
        Me.ComboBox_Amplitude.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_Amplitude.Size = New System.Drawing.Size(69, 21)
        Me.ComboBox_Amplitude.TabIndex = 29
        Me.ComboBox_Amplitude.Text = "0 to 10"
        '
        'ComboBox_Offset
        '
        Me.ComboBox_Offset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox_Offset.FormattingEnabled = True
        Me.ComboBox_Offset.Items.AddRange(New Object() {"-0.1 to +0.1", "-1 to +1", "-10 to +10", "-100 to +100"})
        Me.ComboBox_Offset.Location = New System.Drawing.Point(352, 106)
        Me.ComboBox_Offset.Name = "ComboBox_Offset"
        Me.ComboBox_Offset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_Offset.Size = New System.Drawing.Size(85, 21)
        Me.ComboBox_Offset.TabIndex = 30
        Me.ComboBox_Offset.Tag = ""
        Me.ComboBox_Offset.Text = "-10 to +10"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(115, 32)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(244, 20)
        Me.TextBox4.TabIndex = 31
        Me.TextBox4.Text = "Function Generator"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_Constant
        '
        Me.Button_Constant.Location = New System.Drawing.Point(39, 103)
        Me.Button_Constant.Name = "Button_Constant"
        Me.Button_Constant.Size = New System.Drawing.Size(81, 25)
        Me.Button_Constant.TabIndex = 32
        Me.Button_Constant.Text = "Constant"
        Me.Button_Constant.UseVisualStyleBackColor = True
        '
        'FGOn_Button
        '
        Me.FGOn_Button.Location = New System.Drawing.Point(115, 296)
        Me.FGOn_Button.Name = "FGOn_Button"
        Me.FGOn_Button.Size = New System.Drawing.Size(55, 24)
        Me.FGOn_Button.TabIndex = 33
        Me.FGOn_Button.Text = "ON"
        Me.FGOn_Button.UseVisualStyleBackColor = True
        '
        'ComboBox_Units
        '
        Me.ComboBox_Units.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox_Units.FormattingEnabled = True
        Me.ComboBox_Units.Items.AddRange(New Object() {"um", "mm", "cm", "m", "in", "ft"})
        Me.ComboBox_Units.Location = New System.Drawing.Point(328, 293)
        Me.ComboBox_Units.Name = "ComboBox_Units"
        Me.ComboBox_Units.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_Units.Size = New System.Drawing.Size(71, 21)
        Me.ComboBox_Units.TabIndex = 34
        Me.ComboBox_Units.Text = "mm"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(266, 294)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(56, 15)
        Me.TextBox5.TabIndex = 35
        Me.TextBox5.Text = " Units"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FGOff_Button
        '
        Me.FGOff_Button.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FGOff_Button.Location = New System.Drawing.Point(39, 296)
        Me.FGOff_Button.Name = "FGOff_Button"
        Me.FGOff_Button.Size = New System.Drawing.Size(47, 24)
        Me.FGOff_Button.TabIndex = 36
        Me.FGOff_Button.Text = "OFF"
        Me.FGOff_Button.UseVisualStyleBackColor = False
        '
        'TestMode
        '
        Me.AcceptButton = Me.TMClose_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 385)
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
        Me.Controls.Add(Me.Button_Square)
        Me.Controls.Add(Me.ComboBox_Frequency)
        Me.Controls.Add(Me.TMClose_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TestMode"
        Me.Text = "Test Mode Parameters"
        CType(Me.Trackbar_Frequency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_Amplitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_Offset, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button_Square As System.Windows.Forms.Button
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
End Class
