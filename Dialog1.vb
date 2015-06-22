Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1x_Click_1(sender As Object, e As EventArgs) Handles Button1x.Click
        Button1x.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Button2x.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button4x.BackColor = Color.FromKnownColor(KnownColor.Control)
        MainForm.multiplier = 1
        My.Settings.Multiplier = 1
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub

    Private Sub Button2x_Click_1(sender As Object, e As EventArgs) Handles Button2x.Click
        Button1x.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button2x.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Button4x.BackColor = Color.FromKnownColor(KnownColor.Control)
        MainForm.multiplier = 2
        My.Settings.Multiplier = 2
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub

    Private Sub Button4x_Click_1(sender As Object, e As EventArgs) Handles Button4x.Click
        Button1x.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button2x.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button4x.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        MainForm.multiplier = 4
        My.Settings.Multiplier = 4
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub


    Private Sub Buttonnm_Click(sender As Object, e As EventArgs) Handles Buttonnm.Click
        Buttonnm.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        MainForm.UnitLabel.Text = "nm"
        MainForm.unitCorrectionFactor = 1.0
        My.Settings.unitCorrectionFactor = 1.0
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub

    Private Sub Buttonum_Click(sender As Object, e As EventArgs) Handles Buttonum.Click
        Buttonnm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonum.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        MainForm.UnitLabel.Text = "um"
        MainForm.unitCorrectionFactor = 0.001
        My.Settings.UnitCorrectionFactor = 0.001
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub

    Private Sub Buttonmm_Click(sender As Object, e As EventArgs) Handles Buttonmm.Click
        Buttonnm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonmm.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        MainForm.UnitLabel.Text = "mm"
        MainForm.unitCorrectionFactor = 0.000001
        My.Settings.UnitCorrectionFactor = 0.000001
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub

    Private Sub Buttoncm_Click(sender As Object, e As EventArgs) Handles Buttoncm.Click
        Buttonnm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttoncm.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        MainForm.UnitLabel.Text = "cm"
        MainForm.unitCorrectionFactor = 0.0000001
        My.Settings.UnitCorrectionFactor = 0.0000001
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub

    Private Sub Buttonm_Click(sender As Object, e As EventArgs) Handles Buttonm.Click
        Buttonnm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonm.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        MainForm.UnitLabel.Text = "m"
        MainForm.unitCorrectionFactor = 0.000000001
        My.Settings.UnitCorrectionFactor = 0.000000001
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub
End Class
