Imports System.Windows.Forms

Public Class Compensation

    Private Sub CMPDone_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMPDone_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Compensation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class