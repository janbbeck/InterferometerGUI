Imports System.Windows.Forms

Public Class Configuration

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button1x_Click_1(sender As Object, e As EventArgs) Handles Button1x.Click
        Button1x.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Button1x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Button2x.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button2x.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button4x.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button4x.ForeColor = Color.FromKnownColor(KnownColor.Black)
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
        Button1x.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button1x.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button2x.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Button2x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Button4x.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button4x.ForeColor = Color.FromKnownColor(KnownColor.Black)
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
        Button1x.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button1x.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button2x.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button2x.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button4x.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Button4x.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
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
        Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
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
        Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttonum.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
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
        Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
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
        Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
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
        Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttonm.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
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
        Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttonin.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonft.ForeColor = Color.FromKnownColor(KnownColor.Black)
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
        Buttonnm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonnm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonum.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonum.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonmm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonmm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttoncm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttoncm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonm.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonm.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonft.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttonft.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
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
        Buttonarcsec.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Buttonarcmin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttondegree.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.Black)
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
        Buttonarcsec.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonarcmin.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Buttondegree.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
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
        Buttonarcsec.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonarcmin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttondegree.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        MainForm.AngleLabel.Text = "degree"
        MainForm.angleCorrectionFactor = 1.0
        My.Settings.AngleCorrectionFactor = 1.0
        My.Settings.Save()
        For MainForm.chartcounter = 0 To 1023
            MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.positionSeries.Points.RemoveAt(0)
            MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
            MainForm.velocitySeries.Points.RemoveAt(0)
        Next
    End Sub

    Private Sub Test_Button_On_Click(sender As Object, e As EventArgs) Handles Test_Button_On.Click
        Test_Button_Off.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Test_Button_Off.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Test_Button_On.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Test_Button_On.ForeColor = Color.FromKnownColor(KnownColor.Black)
        MainForm.TestmodeFlag = 1
    End Sub

    Private Sub Test_Button_Off_Click(sender As Object, e As EventArgs) Handles Test_Button_Off.Click
        Test_Button_Off.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Test_Button_Off.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Test_Button_On.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Test_Button_On.ForeColor = Color.FromKnownColor(KnownColor.Black)
        MainForm.TestmodeFlag = 0
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    ' End Sub
End Class
