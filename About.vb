Public Class About

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TMClose_Button_Click(sender As Object, e As EventArgs) Handles TMClose_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Jan_Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Jan_Link.LinkClicked
        Me.Jan_Link.LinkVisited = True
        System.Diagnostics.Process.Start("https://sites.google.com/site/janbeck/")
    End Sub

    Private Sub Sam_Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Sam_Link.LinkClicked
        Me.Sam_Link.LinkVisited = True
        System.Diagnostics.Process.Start("http://www.repairfaq.org/sam/")
    End Sub
End Class