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
        'For MainForm.chartcounter = 0 To 1023
        ' MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        'Next
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
        '   For MainForm.chartcounter = 0 To 1023
        ' MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        'Next
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
        'For MainForm.chartcounter = 0 To 1023
        ' MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        ' Next
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
        'MainForm.ComboBox_Range_UnitsD.Text = "nm"
        MainForm.unitCorrectionFactor = 0.000001
        My.Settings.UnitCorrectionFactor = 0.000001
        My.Settings.Save()
        '   For MainForm.chartcounter = 0 To 1023
        'MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        ' Next
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
        'MainForm.ComboBox_Range_UnitsD.Text = "um"
        MainForm.unitCorrectionFactor = 0.001
        My.Settings.UnitCorrectionFactor = 0.001
        My.Settings.Save()
        'For MainForm.chartcounter = 0 To 1023
        ' MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        ' Next
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
        'MainForm.ComboBox_Range_UnitsD.Text = "mm"
        MainForm.unitCorrectionFactor = 1
        My.Settings.UnitCorrectionFactor = 1
        My.Settings.Save()
        ' For MainForm.chartcounter = 0 To 1023
        ' MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        ' Next
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
        'MainForm.ComboBox_Range_UnitsD.Text = "cm"
        MainForm.unitCorrectionFactor = 10
        My.Settings.UnitCorrectionFactor = 10
        My.Settings.Save()
        'For MainForm.chartcounter = 0 To 1023
        ' MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        ' Next
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
        'MainForm.ComboBox_Range_UnitsD.Text = "m"
        MainForm.unitCorrectionFactor = 1000
        My.Settings.UnitCorrectionFactor = 1000
        My.Settings.Save()
        ' For MainForm.chartcounter = 0 To 1023
        ' MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        ' Next
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
        'MainForm.ComboBox_Range_UnitsD.Text = "in"
        MainForm.unitCorrectionFactor = 25.4
        My.Settings.UnitCorrectionFactor = 25.4
        My.Settings.Save()
        'For MainForm.chartcounter = 0 To 1023
        ' MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        ' Next
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
        'MainForm.ComboBox_Range_UnitsD.Text = "ft"
        MainForm.unitCorrectionFactor = 304.8
        My.Settings.UnitCorrectionFactor = 304.8
        My.Settings.Save()
        'For MainForm.chartcounter = 0 To 1023
        ' MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        ' Next
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
        'MainForm.ComboBox_Range_UnitsA.Text = "arcsec"
        My.Settings.Save()
        'For MainForm.chartcounter = 0 To 1023
        ' MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        ' Next
    End Sub

    Private Sub Buttonarcmin_Click(sender As Object, e As EventArgs) Handles Buttonarcmin.Click
        Buttonarcsec.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonarcmin.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Buttondegree.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        MainForm.AngleLabel.Text = "arcmin"
        'MainForm.ComboBox_Range_UnitsA.Text = "arcmin"
        MainForm.angleCorrectionFactor = 60.0
        My.Settings.AngleCorrectionFactor = 60.0
        My.Settings.Save()
        ' For MainForm.chartcounter = 0 To 1023
        ' MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        'Next
    End Sub

    Private Sub Buttondegree_Click(sender As Object, e As EventArgs) Handles Buttondegree.Click
        Buttonarcsec.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonarcmin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttondegree.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        MainForm.AngleLabel.Text = "degree"
        'MainForm.ComboBox_Range_UnitsA.Text = "degree"
        MainForm.angleCorrectionFactor = 1.0
        My.Settings.AngleCorrectionFactor = 1.0
        My.Settings.Save()
        'For MainForm.chartcounter = 0 To 1023
        ' MainForm.positionSeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.positionSeries.Points.RemoveAt(0)
        ' MainForm.velocitySeries.Points.AddXY(MainForm.chartcounter, 0.0)
        ' MainForm.velocitySeries.Points.RemoveAt(0)
        ' Next
    End Sub

    Private Sub NumericUpDown_ARS_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_ARS.ValueChanged
        MainForm.Angle_Reflector_Spacing = NumericUpDown_ARS.Value
        My.Settings.Angle_Reflector_Spacing = NumericUpDown_ARS.Value
        My.Settings.Save()
    End Sub

    Private Sub NumericUpDown_SL_Coefficient_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_SL_Coefficient.ValueChanged
        MainForm.SLCoefficient = NumericUpDown_SL_Coefficient.Value
        MainForm.straightnessMultiplier = NumericUpDown_SL_Coefficient.Value
        My.Settings.SLCoefficient = NumericUpDown_SL_Coefficient.Value
        My.Settings.Save()
    End Sub

    Private Sub NumericUpDown_SS_Coefficient_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_SS_Coefficient.ValueChanged
        MainForm.SSCoefficient = NumericUpDown_SS_Coefficient.Value
        MainForm.straightnessMultiplier = NumericUpDown_SS_Coefficient.Value
        My.Settings.SSCoefficient = NumericUpDown_SL_Coefficient.Value
        My.Settings.Save()
    End Sub
End Class
