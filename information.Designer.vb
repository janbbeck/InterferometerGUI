<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class information
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(information))
        Me.TMClose_Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Help_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TMClose_Button
        '
        Me.TMClose_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TMClose_Button.BackgroundImage = Global.uMDGUI.My.Resources.Resources.InActiveButton4
        Me.TMClose_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TMClose_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TMClose_Button.Location = New System.Drawing.Point(136, 222)
        Me.TMClose_Button.Name = "TMClose_Button"
        Me.TMClose_Button.Size = New System.Drawing.Size(67, 23)
        Me.TMClose_Button.TabIndex = 2
        Me.TMClose_Button.Text = "CLOSE"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackgroundImage = Global.uMDGUI.My.Resources.Resources.Smiley3
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(118, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 102)
        Me.Button1.TabIndex = 3
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(38, 50)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(277, 22)
        Me.LinkLabel1.TabIndex = 44
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Installation and Operation Manual"
        '
        'Help_Label
        '
        Me.Help_Label.AutoSize = True
        Me.Help_Label.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Help_Label.ForeColor = System.Drawing.Color.Black
        Me.Help_Label.Location = New System.Drawing.Point(99, 24)
        Me.Help_Label.Name = "Help_Label"
        Me.Help_Label.Size = New System.Drawing.Size(146, 26)
        Me.Help_Label.TabIndex = 105
        Me.Help_Label.Text = "Please Read!"
        '
        'information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 272)
        Me.Controls.Add(Me.Help_Label)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TMClose_Button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "information"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Micro Measurement Display Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TMClose_Button As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Help_Label As System.Windows.Forms.Label
End Class
