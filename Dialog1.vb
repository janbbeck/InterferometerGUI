Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button1x_Click_1(sender As Object, e As EventArgs) Handles Button1x.Click

        Button1x.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Button2x.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button2x.UseVisualStyleBackColor = True
        Button4x.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button4x.UseVisualStyleBackColor = True

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
        Button1x.UseVisualStyleBackColor = True
        Button2x.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Button4x.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button4x.UseVisualStyleBackColor = True
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
        Button1x.UseVisualStyleBackColor = True
        Button2x.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button2x.UseVisualStyleBackColor = True
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
        Buttonum.UseVisualStyleBackColor = True
        Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonmm.UseVisualStyleBackColor = True
        Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttoncm.UseVisualStyleBackColor = True
        Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonm.UseVisualStyleBackColor = True
        Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonin.UseVisualStyleBackColor = True
        Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonft.UseVisualStyleBackColor = True
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
        Buttonnm.UseVisualStyleBackColor = True
        Buttonum.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonmm.UseVisualStyleBackColor = True
        Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttoncm.UseVisualStyleBackColor = True
        Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonm.UseVisualStyleBackColor = True
        Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonin.UseVisualStyleBackColor = True
        Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonft.UseVisualStyleBackColor = True
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
        Buttonnm.UseVisualStyleBackColor = True
        Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonum.UseVisualStyleBackColor = True
        Buttonmm.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttoncm.UseVisualStyleBackColor = True
        Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonm.UseVisualStyleBackColor = True
        Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonin.UseVisualStyleBackColor = True
        Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonft.UseVisualStyleBackColor = True
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
        Buttonnm.UseVisualStyleBackColor = True
        Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonum.UseVisualStyleBackColor = True
        Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonmm.UseVisualStyleBackColor = True
        Buttoncm.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonm.UseVisualStyleBackColor = True
        Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonin.UseVisualStyleBackColor = True
        Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonft.UseVisualStyleBackColor = True
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
        Buttonnm.UseVisualStyleBackColor = True
        Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonum.UseVisualStyleBackColor = True
        Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonmm.UseVisualStyleBackColor = True
        Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttoncm.UseVisualStyleBackColor = True
        Buttonm.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonin.UseVisualStyleBackColor = True
        Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonft.UseVisualStyleBackColor = True
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

    Private Sub Buttonin_Click(sender As Object, e As EventArgs) Handles Buttonin.Click
        Buttonnm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonnm.UseVisualStyleBackColor = True
        Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonum.UseVisualStyleBackColor = True
        Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonmm.UseVisualStyleBackColor = True
        Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttoncm.UseVisualStyleBackColor = True
        Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonm.UseVisualStyleBackColor = True
        Buttonin.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Buttonft.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonft.UseVisualStyleBackColor = True
        MainForm.UnitLabel.Text = "in"
        MainForm.unitCorrectionFactor = 0.00000003937
        My.Settings.UnitCorrectionFactor = 0.00000003937
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub

    Private Sub Buttonft_Click(sender As Object, e As EventArgs) Handles Buttonft.Click
        Buttonnm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonnm.UseVisualStyleBackColor = True
        Buttonum.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonum.UseVisualStyleBackColor = True
        Buttonmm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonmm.UseVisualStyleBackColor = True
        Buttoncm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttoncm.UseVisualStyleBackColor = True
        Buttonm.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonm.UseVisualStyleBackColor = True
        Buttonin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonin.UseVisualStyleBackColor = True
        Buttonft.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        MainForm.UnitLabel.Text = "ft"
        MainForm.unitCorrectionFactor = 0.0000000032808
        My.Settings.UnitCorrectionFactor = 0.0000000032808
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub

    Private Sub Buttonarcsec_Click(sender As Object, e As EventArgs) Handles Buttonarcsec.Click
        Buttonarcsec.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Buttonarcmin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonarcmin.UseVisualStyleBackColor = True
        Buttondegree.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttondegree.UseVisualStyleBackColor = True
        MainForm.angleCorrectionFactor = 3600.0
        My.Settings.AngleCorrectionFactor = 3600.0
        MainForm.AngleLabel.Text = "arcsec"
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub

    Private Sub Buttonarcmin_Click(sender As Object, e As EventArgs) Handles Buttonarcmin.Click
        Buttonarcsec.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonarcsec.UseVisualStyleBackColor = True
        Buttonarcmin.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Buttondegree.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttondegree.UseVisualStyleBackColor = True
        MainForm.AngleLabel.Text = "arcmin"
        MainForm.angleCorrectionFactor = 60.0
        My.Settings.AngleCorrectionFactor = 60.0
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub

    Private Sub Buttondegree_Click(sender As Object, e As EventArgs) Handles Buttondegree.Click
        Buttonarcsec.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonarcsec.UseVisualStyleBackColor = True
        Buttonarcmin.BackColor = Color.FromKnownColor(KnownColor.Control)
        Buttonarcmin.UseVisualStyleBackColor = True
        Buttondegree.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        MainForm.angleCorrectionFactor = 1.0
        My.Settings.AngleCorrectionFactor = 1.0
        MainForm.AngleLabel.Text = "degree"
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub

    Private Sub Test_Button_On_Click(sender As Object, e As EventArgs) Handles Test_Button_On.Click
        Test_Button_On.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Test_Button_Off.BackColor = Color.FromKnownColor(KnownColor.Control)
        Test_Button_Off.UseVisualStyleBackColor = True
        MainForm.TestmodeFlag = 1

    End Sub

    Private Sub Test_Button_Off_Click(sender As Object, e As EventArgs) Handles Test_Button_Off.Click
        Test_Button_On.BackColor = Color.FromKnownColor(KnownColor.Control)
        Test_Button_On.UseVisualStyleBackColor = True
        Test_Button_Off.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        MainForm.TestmodeFlag = 0
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
