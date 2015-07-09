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
        Me.CMPDone_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox_TempUnits = New System.Windows.Forms.ComboBox()
        Me.TextBox_ECValue = New System.Windows.Forms.TextBox()
        Me.TextBox_Pressure = New System.Windows.Forms.TextBox()
        Me.NumericUpDown_Humidity = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Pressure = New System.Windows.Forms.NumericUpDown()
        Me.TextBox_HumiFactor = New System.Windows.Forms.TextBox()
        Me.TextBox_PresFactor = New System.Windows.Forms.TextBox()
        Me.TextBox_TempFactor = New System.Windows.Forms.TextBox()
        Me.TextBox_ECParameter = New System.Windows.Forms.TextBox()
        Me.TextBox_ECFactor = New System.Windows.Forms.TextBox()
        Me.ComboBox_Pressure_Units = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Humidity_Units = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1_Temperature = New System.Windows.Forms.NumericUpDown()
        Me.TextBox_Temperature = New System.Windows.Forms.TextBox()
        Me.TextBox_Humidity = New System.Windows.Forms.TextBox()
        Me.Textbox_ECUnits = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDown_Humidity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Pressure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1_Temperature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMPDone_Button
        '
        Me.CMPDone_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMPDone_Button.Location = New System.Drawing.Point(147, 168)
        Me.CMPDone_Button.Name = "CMPDone_Button"
        Me.CMPDone_Button.Size = New System.Drawing.Size(67, 23)
        Me.CMPDone_Button.TabIndex = 1
        Me.CMPDone_Button.Text = "DONE"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AccessibleName = ""
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.18367!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.81633!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_TempUnits, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_ECValue, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Pressure, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown_Humidity, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown_Pressure, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_HumiFactor, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_PresFactor, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_TempFactor, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_ECParameter, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_ECFactor, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_Pressure_Units, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_Humidity_Units, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown1_Temperature, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Temperature, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Humidity, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Textbox_ECUnits, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(27, 32)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(301, 109)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'ComboBox_TempUnits
        '
        Me.ComboBox_TempUnits.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox_TempUnits.FormattingEnabled = True
        Me.ComboBox_TempUnits.Items.AddRange(New Object() {"Degrees C", "Degrees F", "Degrees K"})
        Me.ComboBox_TempUnits.Location = New System.Drawing.Point(155, 30)
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
        Me.TextBox_ECValue.Location = New System.Drawing.Point(87, 6)
        Me.TextBox_ECValue.Name = "TextBox_ECValue"
        Me.TextBox_ECValue.ReadOnly = True
        Me.TextBox_ECValue.Size = New System.Drawing.Size(51, 14)
        Me.TextBox_ECValue.TabIndex = 14
        Me.TextBox_ECValue.Text = "Value"
        Me.TextBox_ECValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Pressure
        '
        Me.TextBox_Pressure.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Pressure.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Pressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Pressure.Location = New System.Drawing.Point(4, 61)
        Me.TextBox_Pressure.Name = "TextBox_Pressure"
        Me.TextBox_Pressure.ReadOnly = True
        Me.TextBox_Pressure.Size = New System.Drawing.Size(76, 13)
        Me.TextBox_Pressure.TabIndex = 4
        Me.TextBox_Pressure.Text = "Pressure"
        Me.TextBox_Pressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown_Humidity
        '
        Me.NumericUpDown_Humidity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown_Humidity.Location = New System.Drawing.Point(90, 86)
        Me.NumericUpDown_Humidity.Name = "NumericUpDown_Humidity"
        Me.NumericUpDown_Humidity.Size = New System.Drawing.Size(44, 20)
        Me.NumericUpDown_Humidity.TabIndex = 5
        Me.NumericUpDown_Humidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_Humidity.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumericUpDown_Pressure
        '
        Me.NumericUpDown_Pressure.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown_Pressure.Location = New System.Drawing.Point(90, 58)
        Me.NumericUpDown_Pressure.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_Pressure.Name = "NumericUpDown_Pressure"
        Me.NumericUpDown_Pressure.Size = New System.Drawing.Size(45, 20)
        Me.NumericUpDown_Pressure.TabIndex = 6
        Me.NumericUpDown_Pressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_Pressure.Value = New Decimal(New Integer() {760, 0, 0, 0})
        '
        'TextBox_HumiFactor
        '
        Me.TextBox_HumiFactor.Location = New System.Drawing.Point(244, 86)
        Me.TextBox_HumiFactor.Name = "TextBox_HumiFactor"
        Me.TextBox_HumiFactor.Size = New System.Drawing.Size(51, 20)
        Me.TextBox_HumiFactor.TabIndex = 10
        Me.TextBox_HumiFactor.Text = "1.000"
        '
        'TextBox_PresFactor
        '
        Me.TextBox_PresFactor.Location = New System.Drawing.Point(244, 57)
        Me.TextBox_PresFactor.Name = "TextBox_PresFactor"
        Me.TextBox_PresFactor.Size = New System.Drawing.Size(51, 20)
        Me.TextBox_PresFactor.TabIndex = 9
        Me.TextBox_PresFactor.Text = "1.000"
        '
        'TextBox_TempFactor
        '
        Me.TextBox_TempFactor.Location = New System.Drawing.Point(244, 30)
        Me.TextBox_TempFactor.Name = "TextBox_TempFactor"
        Me.TextBox_TempFactor.Size = New System.Drawing.Size(51, 20)
        Me.TextBox_TempFactor.TabIndex = 3
        Me.TextBox_TempFactor.Text = "1.000"
        '
        'TextBox_ECParameter
        '
        Me.TextBox_ECParameter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_ECParameter.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_ECParameter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ECParameter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ECParameter.Location = New System.Drawing.Point(4, 6)
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
        Me.TextBox_ECFactor.Location = New System.Drawing.Point(245, 6)
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
        Me.ComboBox_Pressure_Units.Location = New System.Drawing.Point(155, 57)
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
        Me.ComboBox_Humidity_Units.Items.AddRange(New Object() {"Rel %", "Abs %"})
        Me.ComboBox_Humidity_Units.Location = New System.Drawing.Point(155, 86)
        Me.ComboBox_Humidity_Units.Name = "ComboBox_Humidity_Units"
        Me.ComboBox_Humidity_Units.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox_Humidity_Units.Size = New System.Drawing.Size(71, 21)
        Me.ComboBox_Humidity_Units.TabIndex = 37
        Me.ComboBox_Humidity_Units.Text = "Rel %"
        '
        'NumericUpDown1_Temperature
        '
        Me.NumericUpDown1_Temperature.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUpDown1_Temperature.Location = New System.Drawing.Point(90, 30)
        Me.NumericUpDown1_Temperature.Name = "NumericUpDown1_Temperature"
        Me.NumericUpDown1_Temperature.Size = New System.Drawing.Size(45, 20)
        Me.NumericUpDown1_Temperature.TabIndex = 2
        Me.NumericUpDown1_Temperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown1_Temperature.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'TextBox_Temperature
        '
        Me.TextBox_Temperature.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Temperature.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Temperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Temperature.Location = New System.Drawing.Point(4, 33)
        Me.TextBox_Temperature.Name = "TextBox_Temperature"
        Me.TextBox_Temperature.ReadOnly = True
        Me.TextBox_Temperature.Size = New System.Drawing.Size(76, 13)
        Me.TextBox_Temperature.TabIndex = 1
        Me.TextBox_Temperature.Text = "Temperature"
        Me.TextBox_Temperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Humidity
        '
        Me.TextBox_Humidity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Humidity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Humidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Humidity.Location = New System.Drawing.Point(4, 89)
        Me.TextBox_Humidity.Name = "TextBox_Humidity"
        Me.TextBox_Humidity.ReadOnly = True
        Me.TextBox_Humidity.Size = New System.Drawing.Size(76, 13)
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
        Me.Textbox_ECUnits.Location = New System.Drawing.Point(152, 6)
        Me.Textbox_ECUnits.Name = "Textbox_ECUnits"
        Me.Textbox_ECUnits.Size = New System.Drawing.Size(77, 14)
        Me.Textbox_ECUnits.TabIndex = 16
        Me.Textbox_ECUnits.Text = "Units Select"
        Me.Textbox_ECUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Compensation
        '
        Me.AcceptButton = Me.CMPDone_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 212)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.CMPDone_Button)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Compensation"
        Me.ShowIcon = False
        Me.Text = "Environmental Compensation "
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.NumericUpDown_Humidity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Pressure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1_Temperature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMPDone_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBox_Humidity As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_TempFactor As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1_Temperature As System.Windows.Forms.NumericUpDown
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
End Class
