<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuration))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2x = New System.Windows.Forms.Button()
        Me.Button4x = New System.Windows.Forms.Button()
        Me.Button1x = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buttonnm = New System.Windows.Forms.Button()
        Me.Buttonum = New System.Windows.Forms.Button()
        Me.Buttonmm = New System.Windows.Forms.Button()
        Me.Buttoncm = New System.Windows.Forms.Button()
        Me.Buttonm = New System.Windows.Forms.Button()
        Me.Buttonin = New System.Windows.Forms.Button()
        Me.Buttonft = New System.Windows.Forms.Button()
        Me.Buttonarcsec = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Buttonarcmin = New System.Windows.Forms.Button()
        Me.Buttondegree = New System.Windows.Forms.Button()
        Me.NumericUpDown_ARS = New System.Windows.Forms.NumericUpDown()
        Me.AngleSpacingl = New System.Windows.Forms.TextBox()
        Me.NumericUpDown_SL_Coefficient = New System.Windows.Forms.NumericUpDown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown_SS_Coefficient = New System.Windows.Forms.NumericUpDown()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDown_ARS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_SL_Coefficient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_SS_Coefficient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.68493!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.31507!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(179, 341)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackgroundImage = CType(resources.GetObject("OK_Button.BackgroundImage"), System.Drawing.Image)
        Me.OK_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OK_Button.ForeColor = System.Drawing.Color.Black
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "DONE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(313, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Interferometer Type (affects Displaement and Velocity resolution):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button2x
        '
        Me.Button2x.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Button2x.AccessibleName = "Send AT Command Button"
        Me.Button2x.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2x.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.ActiveButton6
        Me.Button2x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2x.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2x.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2x.Location = New System.Drawing.Point(133, 49)
        Me.Button2x.Name = "Button2x"
        Me.Button2x.Size = New System.Drawing.Size(106, 23)
        Me.Button2x.TabIndex = 50
        Me.Button2x.Text = "PMI (2X)"
        Me.Button2x.UseVisualStyleBackColor = False
        '
        'Button4x
        '
        Me.Button4x.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Button4x.AccessibleName = "Send AT Command Button"
        Me.Button4x.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.Button4x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4x.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4x.ForeColor = System.Drawing.Color.Black
        Me.Button4x.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4x.Location = New System.Drawing.Point(245, 49)
        Me.Button4x.Name = "Button4x"
        Me.Button4x.Size = New System.Drawing.Size(106, 23)
        Me.Button4x.TabIndex = 49
        Me.Button4x.Text = "HR PMI (4X)"
        '
        'Button1x
        '
        Me.Button1x.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Button1x.AccessibleName = "Send AT Command Button"
        Me.Button1x.BackColor = System.Drawing.SystemColors.Control
        Me.Button1x.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.Button1x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1x.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1x.ForeColor = System.Drawing.Color.Black
        Me.Button1x.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1x.Location = New System.Drawing.Point(21, 49)
        Me.Button1x.Name = "Button1x"
        Me.Button1x.Size = New System.Drawing.Size(106, 23)
        Me.Button1x.TabIndex = 48
        Me.Button1x.Text = "LI / Other  (1X)"
        Me.Button1x.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Displacement / Velocity / Straightness  Units:"
        '
        'Buttonnm
        '
        Me.Buttonnm.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonnm.AccessibleName = "Send AT Command Button"
        Me.Buttonnm.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.Buttonnm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttonnm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttonnm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonnm.Location = New System.Drawing.Point(21, 114)
        Me.Buttonnm.Name = "Buttonnm"
        Me.Buttonnm.Size = New System.Drawing.Size(50, 23)
        Me.Buttonnm.TabIndex = 54
        Me.Buttonnm.Text = "nm"
        '
        'Buttonum
        '
        Me.Buttonum.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonum.AccessibleName = "Send AT Command Button"
        Me.Buttonum.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.Buttonum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttonum.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttonum.ForeColor = System.Drawing.Color.Black
        Me.Buttonum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonum.Location = New System.Drawing.Point(77, 114)
        Me.Buttonum.Name = "Buttonum"
        Me.Buttonum.Size = New System.Drawing.Size(50, 23)
        Me.Buttonum.TabIndex = 57
        Me.Buttonum.Text = "um"
        '
        'Buttonmm
        '
        Me.Buttonmm.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonmm.AccessibleName = "Send AT Command Button"
        Me.Buttonmm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Buttonmm.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.ActiveButton6
        Me.Buttonmm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttonmm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttonmm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Buttonmm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonmm.Location = New System.Drawing.Point(133, 114)
        Me.Buttonmm.Name = "Buttonmm"
        Me.Buttonmm.Size = New System.Drawing.Size(50, 23)
        Me.Buttonmm.TabIndex = 58
        Me.Buttonmm.Text = "mm"
        Me.Buttonmm.UseVisualStyleBackColor = False
        '
        'Buttoncm
        '
        Me.Buttoncm.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttoncm.AccessibleName = "Send AT Command Button"
        Me.Buttoncm.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.Buttoncm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttoncm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttoncm.ForeColor = System.Drawing.Color.Black
        Me.Buttoncm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttoncm.Location = New System.Drawing.Point(189, 114)
        Me.Buttoncm.Name = "Buttoncm"
        Me.Buttoncm.Size = New System.Drawing.Size(50, 23)
        Me.Buttoncm.TabIndex = 59
        Me.Buttoncm.Text = "cm"
        '
        'Buttonm
        '
        Me.Buttonm.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonm.AccessibleName = "Send AT Command Button"
        Me.Buttonm.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.Buttonm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttonm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttonm.ForeColor = System.Drawing.Color.Black
        Me.Buttonm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonm.Location = New System.Drawing.Point(245, 114)
        Me.Buttonm.Name = "Buttonm"
        Me.Buttonm.Size = New System.Drawing.Size(50, 23)
        Me.Buttonm.TabIndex = 60
        Me.Buttonm.Text = "m"
        '
        'Buttonin
        '
        Me.Buttonin.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonin.AccessibleName = "Send AT Command Button"
        Me.Buttonin.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.Buttonin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttonin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttonin.ForeColor = System.Drawing.Color.Black
        Me.Buttonin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonin.Location = New System.Drawing.Point(301, 114)
        Me.Buttonin.Name = "Buttonin"
        Me.Buttonin.Size = New System.Drawing.Size(50, 23)
        Me.Buttonin.TabIndex = 61
        Me.Buttonin.Text = "in"
        '
        'Buttonft
        '
        Me.Buttonft.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonft.AccessibleName = "Send AT Command Button"
        Me.Buttonft.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.Buttonft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttonft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttonft.ForeColor = System.Drawing.Color.Black
        Me.Buttonft.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonft.Location = New System.Drawing.Point(357, 114)
        Me.Buttonft.Name = "Buttonft"
        Me.Buttonft.Size = New System.Drawing.Size(50, 23)
        Me.Buttonft.TabIndex = 62
        Me.Buttonft.Text = "ft"
        '
        'Buttonarcsec
        '
        Me.Buttonarcsec.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonarcsec.AccessibleName = "Send AT Command Button"
        Me.Buttonarcsec.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Buttonarcsec.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.ActiveButton6
        Me.Buttonarcsec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttonarcsec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttonarcsec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Buttonarcsec.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonarcsec.Location = New System.Drawing.Point(21, 182)
        Me.Buttonarcsec.Name = "Buttonarcsec"
        Me.Buttonarcsec.Size = New System.Drawing.Size(50, 23)
        Me.Buttonarcsec.TabIndex = 63
        Me.Buttonarcsec.Text = " arcsec"
        Me.Buttonarcsec.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Angle Units:"
        '
        'Buttonarcmin
        '
        Me.Buttonarcmin.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonarcmin.AccessibleName = "Send AT Command Button"
        Me.Buttonarcmin.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.Buttonarcmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttonarcmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttonarcmin.ForeColor = System.Drawing.Color.Black
        Me.Buttonarcmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonarcmin.Location = New System.Drawing.Point(77, 182)
        Me.Buttonarcmin.Name = "Buttonarcmin"
        Me.Buttonarcmin.Size = New System.Drawing.Size(50, 23)
        Me.Buttonarcmin.TabIndex = 65
        Me.Buttonarcmin.Text = "arcmin"
        '
        'Buttondegree
        '
        Me.Buttondegree.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttondegree.AccessibleName = "Send AT Command Button"
        Me.Buttondegree.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.Buttondegree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttondegree.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttondegree.ForeColor = System.Drawing.Color.Black
        Me.Buttondegree.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttondegree.Location = New System.Drawing.Point(133, 182)
        Me.Buttondegree.Name = "Buttondegree"
        Me.Buttondegree.Size = New System.Drawing.Size(50, 23)
        Me.Buttondegree.TabIndex = 66
        Me.Buttondegree.Text = "degrees"
        '
        'NumericUpDown_ARS
        '
        Me.NumericUpDown_ARS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown_ARS.DecimalPlaces = 3
        Me.NumericUpDown_ARS.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.NumericUpDown_ARS.Location = New System.Drawing.Point(250, 233)
        Me.NumericUpDown_ARS.Minimum = New Decimal(New Integer() {2, 0, 0, 65536})
        Me.NumericUpDown_ARS.Name = "NumericUpDown_ARS"
        Me.NumericUpDown_ARS.Size = New System.Drawing.Size(62, 20)
        Me.NumericUpDown_ARS.TabIndex = 76
        Me.NumericUpDown_ARS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_ARS.Value = New Decimal(New Integer() {32610, 0, 0, 196608})
        '
        'AngleSpacingl
        '
        Me.AngleSpacingl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AngleSpacingl.BackColor = System.Drawing.SystemColors.Menu
        Me.AngleSpacingl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AngleSpacingl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AngleSpacingl.Location = New System.Drawing.Point(102, 235)
        Me.AngleSpacingl.Name = "AngleSpacingl"
        Me.AngleSpacingl.ReadOnly = True
        Me.AngleSpacingl.Size = New System.Drawing.Size(144, 13)
        Me.AngleSpacingl.TabIndex = 74
        Me.AngleSpacingl.Text = " Angle Reflector Spacing:"
        '
        'NumericUpDown_SL_Coefficient
        '
        Me.NumericUpDown_SL_Coefficient.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown_SL_Coefficient.DecimalPlaces = 2
        Me.NumericUpDown_SL_Coefficient.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDown_SL_Coefficient.Location = New System.Drawing.Point(252, 263)
        Me.NumericUpDown_SL_Coefficient.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_SL_Coefficient.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown_SL_Coefficient.Name = "NumericUpDown_SL_Coefficient"
        Me.NumericUpDown_SL_Coefficient.Size = New System.Drawing.Size(62, 20)
        Me.NumericUpDown_SL_Coefficient.TabIndex = 78
        Me.NumericUpDown_SL_Coefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_SL_Coefficient.Value = New Decimal(New Integer() {360, 0, 0, 0})
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(103, 265)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(148, 13)
        Me.TextBox1.TabIndex = 77
        Me.TextBox1.Text = "Straightness Long Coefficient:"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(103, 295)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(148, 13)
        Me.TextBox2.TabIndex = 79
        Me.TextBox2.Text = "Straightness Short Coefficient:"
        '
        'NumericUpDown_SS_Coefficient
        '
        Me.NumericUpDown_SS_Coefficient.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown_SS_Coefficient.DecimalPlaces = 3
        Me.NumericUpDown_SS_Coefficient.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.NumericUpDown_SS_Coefficient.Location = New System.Drawing.Point(252, 294)
        Me.NumericUpDown_SS_Coefficient.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_SS_Coefficient.Name = "NumericUpDown_SS_Coefficient"
        Me.NumericUpDown_SS_Coefficient.Size = New System.Drawing.Size(62, 20)
        Me.NumericUpDown_SS_Coefficient.TabIndex = 80
        Me.NumericUpDown_SS_Coefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_SS_Coefficient.Value = New Decimal(New Integer() {3600, 0, 0, 131072})
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(318, 235)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(20, 13)
        Me.TextBox3.TabIndex = 81
        Me.TextBox3.Text = "mm"
        '
        'Configuration11
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 393)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.NumericUpDown_SS_Coefficient)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.NumericUpDown_SL_Coefficient)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.NumericUpDown_ARS)
        Me.Controls.Add(Me.AngleSpacingl)
        Me.Controls.Add(Me.Buttondegree)
        Me.Controls.Add(Me.Buttonarcmin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Buttonarcsec)
        Me.Controls.Add(Me.Buttonft)
        Me.Controls.Add(Me.Buttonin)
        Me.Controls.Add(Me.Buttonm)
        Me.Controls.Add(Me.Buttoncm)
        Me.Controls.Add(Me.Buttonmm)
        Me.Controls.Add(Me.Buttonum)
        Me.Controls.Add(Me.Buttonnm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2x)
        Me.Controls.Add(Me.Button4x)
        Me.Controls.Add(Me.Button1x)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Configuration11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuration"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.NumericUpDown_ARS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_SL_Coefficient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_SS_Coefficient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2x As System.Windows.Forms.Button
    Friend WithEvents Button4x As System.Windows.Forms.Button
    Friend WithEvents Button1x As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Buttonnm As System.Windows.Forms.Button
    Friend WithEvents Buttonum As System.Windows.Forms.Button
    Friend WithEvents Buttonmm As System.Windows.Forms.Button
    Friend WithEvents Buttoncm As System.Windows.Forms.Button
    Friend WithEvents Buttonm As System.Windows.Forms.Button
    Friend WithEvents Buttonin As System.Windows.Forms.Button
    Friend WithEvents Buttonft As System.Windows.Forms.Button
    Friend WithEvents Buttonarcsec As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Buttonarcmin As System.Windows.Forms.Button
    Friend WithEvents Buttondegree As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown_ARS As System.Windows.Forms.NumericUpDown
    Friend WithEvents AngleSpacingl As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown_SL_Coefficient As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown_SS_Coefficient As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
