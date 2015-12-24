Public Class information

    Private Sub Form1Close_Button_Click(sender As Object, e As EventArgs) Handles TMClose_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("http://repairfaq.cis.upenn.edu/Misc/uMD1/uMD1.htm")
    End Sub
End Class