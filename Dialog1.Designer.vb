<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(175, 146)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "(affected by interferometer setup)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Resolution multiplier:"
        '
        'Button2x
        '
        Me.Button2x.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Button2x.AccessibleName = "Send AT Command Button"
        Me.Button2x.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2x.Location = New System.Drawing.Point(74, 44)
        Me.Button2x.Name = "Button2x"
        Me.Button2x.Size = New System.Drawing.Size(50, 23)
        Me.Button2x.TabIndex = 50
        Me.Button2x.Text = "2X"
        '
        'Button4x
        '
        Me.Button4x.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Button4x.AccessibleName = "Send AT Command Button"
        Me.Button4x.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4x.Location = New System.Drawing.Point(130, 44)
        Me.Button4x.Name = "Button4x"
        Me.Button4x.Size = New System.Drawing.Size(50, 23)
        Me.Button4x.TabIndex = 49
        Me.Button4x.Text = "4X"
        '
        'Button1x
        '
        Me.Button1x.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Button1x.AccessibleName = "Send AT Command Button"
        Me.Button1x.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1x.Location = New System.Drawing.Point(18, 44)
        Me.Button1x.Name = "Button1x"
        Me.Button1x.Size = New System.Drawing.Size(50, 23)
        Me.Button1x.TabIndex = 48
        Me.Button1x.Text = "1X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Distance Unit"
        '
        'Buttonnm
        '
        Me.Buttonnm.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonnm.AccessibleName = "Send AT Command Button"
        Me.Buttonnm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonnm.Location = New System.Drawing.Point(18, 109)
        Me.Buttonnm.Name = "Buttonnm"
        Me.Buttonnm.Size = New System.Drawing.Size(50, 23)
        Me.Buttonnm.TabIndex = 54
        Me.Buttonnm.Text = "nm"
        '
        'Buttonum
        '
        Me.Buttonum.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonum.AccessibleName = "Send AT Command Button"
        Me.Buttonum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonum.Location = New System.Drawing.Point(74, 109)
        Me.Buttonum.Name = "Buttonum"
        Me.Buttonum.Size = New System.Drawing.Size(50, 23)
        Me.Buttonum.TabIndex = 57
        Me.Buttonum.Text = "um"
        '
        'Buttonmm
        '
        Me.Buttonmm.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonmm.AccessibleName = "Send AT Command Button"
        Me.Buttonmm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonmm.Location = New System.Drawing.Point(130, 109)
        Me.Buttonmm.Name = "Buttonmm"
        Me.Buttonmm.Size = New System.Drawing.Size(50, 23)
        Me.Buttonmm.TabIndex = 58
        Me.Buttonmm.Text = "mm"
        '
        'Buttoncm
        '
        Me.Buttoncm.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttoncm.AccessibleName = "Send AT Command Button"
        Me.Buttoncm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttoncm.Location = New System.Drawing.Point(186, 109)
        Me.Buttoncm.Name = "Buttoncm"
        Me.Buttoncm.Size = New System.Drawing.Size(50, 23)
        Me.Buttoncm.TabIndex = 59
        Me.Buttoncm.Text = "cm"
        '
        'Buttonm
        '
        Me.Buttonm.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonm.AccessibleName = "Send AT Command Button"
        Me.Buttonm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonm.Location = New System.Drawing.Point(242, 109)
        Me.Buttonm.Name = "Buttonm"
        Me.Buttonm.Size = New System.Drawing.Size(50, 23)
        Me.Buttonm.TabIndex = 60
        Me.Buttonm.Text = "m"
        '
        'Buttonin
        '
        Me.Buttonin.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonin.AccessibleName = "Send AT Command Button"
        Me.Buttonin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonin.Location = New System.Drawing.Point(298, 109)
        Me.Buttonin.Name = "Buttonin"
        Me.Buttonin.Size = New System.Drawing.Size(50, 23)
        Me.Buttonin.TabIndex = 61
        Me.Buttonin.Text = "in"
        '
        'Buttonft
        '
        Me.Buttonft.AccessibleDescription = "Button to send an AT command to the modem."
        Me.Buttonft.AccessibleName = "Send AT Command Button"
        Me.Buttonft.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buttonft.Location = New System.Drawing.Point(354, 109)
        Me.Buttonft.Name = "Buttonft"
        Me.Buttonft.Size = New System.Drawing.Size(50, 23)
        Me.Buttonft.TabIndex = 62
        Me.Buttonft.Text = "ft"
        '
        'Dialog1
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 187)
        Me.Controls.Add(Me.Buttonft)
        Me.Controls.Add(Me.Buttonin)
        Me.Controls.Add(Me.Buttonm)
        Me.Controls.Add(Me.Buttoncm)
        Me.Controls.Add(Me.Buttonmm)
        Me.Controls.Add(Me.Buttonum)
        Me.Controls.Add(Me.Buttonnm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2x)
        Me.Controls.Add(Me.Button4x)
        Me.Controls.Add(Me.Button1x)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuration"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
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

End Class
