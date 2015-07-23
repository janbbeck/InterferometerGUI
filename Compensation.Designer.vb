<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compensation
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox_TempUnits = New System.Windows.Forms.ComboBox()
        Me.TextBox_ECValue = New System.Windows.Forms.TextBox()
        Me.TextBox_Pressure = New System.Windows.Forms.TextBox()
        Me.NumericUpDown_Humidity = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Pressure = New System.Windows.Forms.NumericUpDown()
        Me.TextBox_HumiFactor = New System.Windows.Forms.TextBox()
        Me.TextBox_PresFactor = New System.Windows.Forms.TextBox()
        Me.TextBox_ECParameter = New System.Windows.Forms.TextBox()
        Me.TextBox_ECFactor = New System.Windows.Forms.TextBox()
        Me.ComboBox_Pressure_Units = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Humidity_Units = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown_Temperature = New System.Windows.Forms.NumericUpDown()
        Me.TextBox_Temperature = New System.Windows.Forms.TextBox()
        Me.TextBox_Humidity = New System.Windows.Forms.TextBox()
        Me.Textbox_ECUnits = New System.Windows.Forms.TextBox()
        Me.TextBox_TempFactor = New System.Windows.Forms.TextBox()
        Me.WL_Label = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown_Wavelength = New System.Windows.Forms.NumericUpDown()
        Me.CMPDone_Button = New System.Windows.Forms.Button()
        Me.ECOff_Button = New System.Windows.Forms.Button()
        Me.ECOn_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDown_Humidity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Pressure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Temperature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Wavelength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AccessibleName = ""
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_TempUnits, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_ECValue, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Pressure, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown_Humidity, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown_Pressure, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_HumiFactor, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_PresFactor, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_ECParameter, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_ECFactor, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_Pressure_Units, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_Humidity_Units, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown_Temperature, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Temperature, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Humidity, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Textbox_ECUnits, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_TempFactor, 3, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(32, 29)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.93939!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.06061!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(344, 122)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'ComboBox_TempUnits
        '
        Me.ComboBox_TempUnits.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox_TempUnits.FormattingEnabled = True
        Me.ComboBox_TempUnits.Items.AddRange(New Object() {"Degrees C", "Degrees F", "Degrees K"})
        Me.ComboBox_TempUnits.Location = New System.Drawing.Point(167, 32)
        Me.ComboBox_TempUnits.Name = "ComboBox_TempUnits"
        Me.ComboBox_TempUnits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_TempUnits.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox_TempUnits.TabIndex = 35
        Me.ComboBox_TempUnits.Text = "Degrees C"
        '
        'TextBox_ECValue
        '
        Me.TextBox_ECValue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_ECValue.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_ECValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ECValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ECValue.Location = New System.Drawing.Point(100, 6)
        Me.TextBox_ECValue.Name = "TextBox_ECValue"
        Me.TextBox_ECValue.ReadOnly = True
        Me.TextBox_ECValue.Size = New System.Drawing.Size(41, 14)
        Me.TextBox_ECValue.TabIndex = 14
        Me.TextBox_ECValue.Text = "Value"
        Me.TextBox_ECValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Pressure
        '
        Me.TextBox_Pressure.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Pressure.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Pressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Pressure.Location = New System.Drawing.Point(12, 67)
        Me.TextBox_Pressure.Name = "TextBox_Pressure"
        Me.TextBox_Pressure.ReadOnly = True
        Me.TextBox_Pressure.Size = New System.Drawing.Size(62, 13)
        Me.TextBox_Pressure.TabIndex = 4
        Me.TextBox_Pressure.Text = "Pressure"
        Me.TextBox_Pressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown_Humidity
        '
        Me.NumericUpDown_Humidity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown_Humidity.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_Humidity.Location = New System.Drawing.Point(95, 95)
        Me.NumericUpDown_Humidity.Name = "NumericUpDown_Humidity"
        Me.NumericUpDown_Humidity.Size = New System.Drawing.Size(51, 20)
        Me.NumericUpDown_Humidity.TabIndex = 5
        Me.NumericUpDown_Humidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_Humidity.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumericUpDown_Pressure
        '
        Me.NumericUpDown_Pressure.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown_Pressure.Location = New System.Drawing.Point(95, 64)
        Me.NumericUpDown_Pressure.Maximum = New Decimal(New Integer() {1520, 0, 0, 0})
        Me.NumericUpDown_Pressure.Minimum = New Decimal(New Integer() {380, 0, 0, 0})
        Me.NumericUpDown_Pressure.Name = "NumericUpDown_Pressure"
        Me.NumericUpDown_Pressure.Size = New System.Drawing.Size(51, 20)
        Me.NumericUpDown_Pressure.TabIndex = 6
        Me.NumericUpDown_Pressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_Pressure.Value = New Decimal(New Integer() {760, 0, 0, 0})
        '
        'TextBox_HumiFactor
        '
        Me.TextBox_HumiFactor.Location = New System.Drawing.Point(255, 93)
        Me.TextBox_HumiFactor.Name = "TextBox_HumiFactor"
        Me.TextBox_HumiFactor.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_HumiFactor.TabIndex = 10
        Me.TextBox_HumiFactor.Text = "1.000000000"
        '
        'TextBox_PresFactor
        '
        Me.TextBox_PresFactor.Location = New System.Drawing.Point(255, 62)
        Me.TextBox_PresFactor.Name = "TextBox_PresFactor"
        Me.TextBox_PresFactor.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_PresFactor.TabIndex = 9
        Me.TextBox_PresFactor.Text = "1.000000000"
        '
        'TextBox_ECParameter
        '
        Me.TextBox_ECParameter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_ECParameter.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_ECParameter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ECParameter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ECParameter.Location = New System.Drawing.Point(5, 6)
        Me.TextBox_ECParameter.Name = "TextBox_ECParameter"
        Me.TextBox_ECParameter.ReadOnly = True
        Me.TextBox_ECParameter.Size = New System.Drawing.Size(76, 14)
        Me.TextBox_ECParameter.TabIndex = 13
        Me.TextBox_ECParameter.Text = "Parameter"
        Me.TextBox_ECParameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_ECFactor
        '
        Me.TextBox_ECFactor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_ECFactor.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_ECFactor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ECFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ECFactor.Location = New System.Drawing.Point(272, 6)
        Me.TextBox_ECFactor.Name = "TextBox_ECFactor"
        Me.TextBox_ECFactor.ReadOnly = True
        Me.TextBox_ECFactor.Size = New System.Drawing.Size(51, 14)
        Me.TextBox_ECFactor.TabIndex = 15
        Me.TextBox_ECFactor.Text = "Factor"
        Me.TextBox_ECFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox_Pressure_Units
        '
        Me.ComboBox_Pressure_Units.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox_Pressure_Units.FormattingEnabled = True
        Me.ComboBox_Pressure_Units.Items.AddRange(New Object() {"mm/Hg", "mBar"})
        Me.ComboBox_Pressure_Units.Location = New System.Drawing.Point(167, 63)
        Me.ComboBox_Pressure_Units.Name = "ComboBox_Pressure_Units"
        Me.ComboBox_Pressure_Units.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_Pressure_Units.Size = New System.Drawing.Size(71, 21)
        Me.ComboBox_Pressure_Units.TabIndex = 36
        Me.ComboBox_Pressure_Units.Text = "mm/Hg"
        '
        'ComboBox_Humidity_Units
        '
        Me.ComboBox_Humidity_Units.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox_Humidity_Units.FormattingEnabled = True
        Me.ComboBox_Humidity_Units.Items.AddRange(New Object() {"Rel %"})
        Me.ComboBox_Humidity_Units.Location = New System.Drawing.Point(167, 95)
        Me.ComboBox_Humidity_Units.Name = "ComboBox_Humidity_Units"
        Me.ComboBox_Humidity_Units.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_Humidity_Units.Size = New System.Drawing.Size(71, 21)
        Me.ComboBox_Humidity_Units.TabIndex = 37
        Me.ComboBox_Humidity_Units.Text = "Rel %"
        '
        'NumericUpDown_Temperature
        '
        Me.NumericUpDown_Temperature.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown_Temperature.Location = New System.Drawing.Point(93, 32)
        Me.NumericUpDown_Temperature.Maximum = New Decimal(New Integer() {70, 0, 0, 0})
        Me.NumericUpDown_Temperature.Name = "NumericUpDown_Temperature"
        Me.NumericUpDown_Temperature.Size = New System.Drawing.Size(55, 20)
        Me.NumericUpDown_Temperature.TabIndex = 2
        Me.NumericUpDown_Temperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_Temperature.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'TextBox_Temperature
        '
        Me.TextBox_Temperature.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Temperature.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Temperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Temperature.Location = New System.Drawing.Point(12, 36)
        Me.TextBox_Temperature.Name = "TextBox_Temperature"
        Me.TextBox_Temperature.ReadOnly = True
        Me.TextBox_Temperature.Size = New System.Drawing.Size(62, 13)
        Me.TextBox_Temperature.TabIndex = 1
        Me.TextBox_Temperature.Text = "Temperature"
        Me.TextBox_Temperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Humidity
        '
        Me.TextBox_Humidity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Humidity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Humidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Humidity.Location = New System.Drawing.Point(12, 99)
        Me.TextBox_Humidity.Name = "TextBox_Humidity"
        Me.TextBox_Humidity.ReadOnly = True
        Me.TextBox_Humidity.Size = New System.Drawing.Size(62, 13)
        Me.TextBox_Humidity.TabIndex = 11
        Me.TextBox_Humidity.Text = "Humidity"
        Me.TextBox_Humidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Textbox_ECUnits
        '
        Me.Textbox_ECUnits.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Textbox_ECUnits.BackColor = System.Drawing.SystemColors.Control
        Me.Textbox_ECUnits.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Textbox_ECUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox_ECUnits.Location = New System.Drawing.Point(164, 6)
        Me.Textbox_ECUnits.Name = "Textbox_ECUnits"
        Me.Textbox_ECUnits.Size = New System.Drawing.Size(77, 14)
        Me.Textbox_ECUnits.TabIndex = 16
        Me.Textbox_ECUnits.Text = "Units Select"
        Me.Textbox_ECUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_TempFactor
        '
        Me.TextBox_TempFactor.Location = New System.Drawing.Point(255, 30)
        Me.TextBox_TempFactor.Name = "TextBox_TempFactor"
        Me.TextBox_TempFactor.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_TempFactor.TabIndex = 3
        Me.TextBox_TempFactor.Text = "1.000000000"
        '
        'WL_Label
        '
        Me.WL_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WL_Label.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WL_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WL_Label.Location = New System.Drawing.Point(267, 178)
        Me.WL_Label.Name = "WL_Label"
        Me.WL_Label.ReadOnly = True
        Me.WL_Label.Size = New System.Drawing.Size(104, 13)
        Me.WL_Label.TabIndex = 40
        Me.WL_Label.Text = "Vacuum Wavelength"
        Me.WL_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(59, 175)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(139, 13)
        Me.TextBox3.TabIndex = 41
        Me.TextBox3.Text = "Wavelength Correction"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown_Wavelength
        '
        Me.NumericUpDown_Wavelength.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown_Wavelength.DecimalPlaces = 6
        Me.NumericUpDown_Wavelength.Increment = New Decimal(New Integer() {1, 0, 0, 393216})
        Me.NumericUpDown_Wavelength.Location = New System.Drawing.Point(279, 203)
        Me.NumericUpDown_Wavelength.Maximum = New Decimal(New Integer() {633000000, 0, 0, 393216})
        Me.NumericUpDown_Wavelength.Minimum = New Decimal(New Integer() {632000000, 0, 0, 393216})
        Me.NumericUpDown_Wavelength.Name = "NumericUpDown_Wavelength"
        Me.NumericUpDown_Wavelength.Size = New System.Drawing.Size(80, 20)
        Me.NumericUpDown_Wavelength.TabIndex = 42
        Me.NumericUpDown_Wavelength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_Wavelength.Value = New Decimal(New Integer() {632991372, 0, 0, 393216})
        '
        'CMPDone_Button
        '
        Me.CMPDone_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMPDone_Button.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.CMPDone_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMPDone_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMPDone_Button.ForeColor = System.Drawing.Color.Black
        Me.CMPDone_Button.Location = New System.Drawing.Point(188, 253)
        Me.CMPDone_Button.Name = "CMPDone_Button"
        Me.CMPDone_Button.Size = New System.Drawing.Size(67, 23)
        Me.CMPDone_Button.TabIndex = 1
        Me.CMPDone_Button.Text = "DONE"
        '
        'ECOff_Button
        '
        Me.ECOff_Button.BackColor = System.Drawing.SystemColors.Control
        Me.ECOff_Button.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.ActiveButton6
        Me.ECOff_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ECOff_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ECOff_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ECOff_Button.Location = New System.Drawing.Point(56, 201)
        Me.ECOff_Button.Name = "ECOff_Button"
        Me.ECOff_Button.Size = New System.Drawing.Size(47, 24)
        Me.ECOff_Button.TabIndex = 38
        Me.ECOff_Button.Text = "OFF"
        Me.ECOff_Button.UseVisualStyleBackColor = False
        '
        'ECOn_Button
        '
        Me.ECOn_Button.BackgroundImage = Global.InterferometerGUI.My.Resources.Resources.InActiveButton4
        Me.ECOn_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ECOn_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ECOn_Button.ForeColor = System.Drawing.Color.Black
        Me.ECOn_Button.Location = New System.Drawing.Point(128, 201)
        Me.ECOn_Button.Name = "ECOn_Button"
        Me.ECOn_Button.Size = New System.Drawing.Size(55, 24)
        Me.ECOn_Button.TabIndex = 37
        Me.ECOn_Button.Text = "ON"
        Me.ECOn_Button.UseVisualStyleBackColor = True
        '
        'Compensation
        '
        Me.AcceptButton = Me.CMPDone_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 305)
        Me.Controls.Add(Me.NumericUpDown_Wavelength)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.WL_Label)
        Me.Controls.Add(Me.ECOff_Button)
        Me.Controls.Add(Me.ECOn_Button)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.CMPDone_Button)
        Me.MaximizeBox = False
        Me.Name = "Compensation"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Environmental Compensation "
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.NumericUpDown_Humidity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Pressure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Temperature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Wavelength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMPDone_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBox_Humidity As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_TempFactor As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown_Temperature As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBox_Pressure As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown_Pressure As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_Humidity As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBox_PresFactor As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_HumiFactor As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Temperature As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ECValue As System.Windows.Forms.TextBox
    Friend WithEvents Textbox_ECUnits As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ECParameter As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ECFactor As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_TempUnits As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Pressure_Units As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Humidity_Units As System.Windows.Forms.ComboBox
    Friend WithEvents ECOff_Button As System.Windows.Forms.Button
    Friend WithEvents ECOn_Button As System.Windows.Forms.Button
    Friend WithEvents WL_Label As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown_Wavelength As System.Windows.Forms.NumericUpDown
End Class
