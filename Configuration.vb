Imports System.Windows.Forms

Public Class Configuration

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If MainForm.UnitLabel.Visible Then
            MainForm.RangeUnits.Text = MainForm.UnitLabel.Text
        Else
            MainForm.RangeUnits.Text = MainForm.AngleLabel.Text
        End If
        My.Settings.Angle_Reflector_Spacing = NumericUpDown_ARS.Value
        My.Settings.SLCoefficient = NumericUpDown_SL_Coefficient.Value
        My.Settings.SSCoefficient = NumericUpDown_SS_Coefficient.Value
        My.Settings.Save()
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
        MainForm.RangeUnits.Text = "nm"
        MainForm.Axis_UnitsD.Text = "nm"
        MainForm.Axis1_Units_Label.Text = "nm"
        MainForm.Axis2_Units_Label.Text = "nm"
        MainForm.Axis3_Units_Label.Text = "nm"
        MainForm.unitCorrectionFactor = 0.000001
        My.Settings.UnitCorrectionFactor = 0.000001
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
        MainForm.UnitLabel.Text = "μm"
        MainForm.RangeUnits.Text = "μm"
        MainForm.Axis_UnitsD.Text = "μm"
        MainForm.Axis1_Units_Label.Text = "μm"
        MainForm.Axis2_Units_Label.Text = "μm"
        MainForm.Axis3_Units_Label.Text = "μm"
        MainForm.unitCorrectionFactor = 0.001
        My.Settings.UnitCorrectionFactor = 0.001
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
        MainForm.RangeUnits.Text = "mm"
        MainForm.Axis_UnitsD.Text = "mm"
        MainForm.unitCorrectionFactor = 1
        My.Settings.UnitCorrectionFactor = 1
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
        MainForm.RangeUnits.Text = "cm"
        MainForm.Axis_UnitsD.Text = "cm"
        MainForm.Axis1_Units_Label.Text = "cm"
        MainForm.Axis2_Units_Label.Text = "cm"
        MainForm.Axis3_Units_Label.Text = "cm"
        MainForm.unitCorrectionFactor = 10
        My.Settings.UnitCorrectionFactor = 10
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
        MainForm.RangeUnits.Text = "m"
        MainForm.Axis_UnitsD.Text = "m"
        MainForm.Axis1_Units_Label.Text = "m"
        MainForm.Axis2_Units_Label.Text = "m"
        MainForm.Axis3_Units_Label.Text = "m"
        MainForm.unitCorrectionFactor = 1000
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
        MainForm.RangeUnits.Text = "in"
        MainForm.Axis_UnitsD.Text = "in"
        MainForm.Axis1_Units_Label.Text = "in"
        MainForm.Axis2_Units_Label.Text = "in"
        MainForm.Axis3_Units_Label.Text = "in"
        MainForm.unitCorrectionFactor = 25.4
        My.Settings.UnitCorrectionFactor = 25.4
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
        MainForm.RangeUnits.Text = "ft"
        MainForm.Axis_UnitsD.Text = "ft"
        MainForm.Axis1_Units_Label.Text = "ft"
        MainForm.Axis2_Units_Label.Text = "ft"
        MainForm.Axis3_Units_Label.Text = "ft"
        MainForm.unitCorrectionFactor = 304.8
        My.Settings.UnitCorrectionFactor = 304.8
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
        MainForm.RangeUnits.Text = "arcsec"
        MainForm.Axis_UnitsA.Text = "arcsec"
        MainForm.Axis1_Angle_Label.Text = "arcsec"
        MainForm.Axis2_Angle_Label.Text = "arcsec"
        MainForm.Axis3_Angle_Label.Text = "arcsec"
    End Sub

    Private Sub Buttonarcmin_Click(sender As Object, e As EventArgs) Handles Buttonarcmin.Click
        Buttonarcsec.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonarcmin.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Buttondegree.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        MainForm.AngleLabel.Text = "arcmin"
        MainForm.RangeUnits.Text = "arcmin"
        MainForm.Axis_UnitsA.Text = "arcmin"
        MainForm.Axis1_Angle_Label.Text = "arcmin"
        MainForm.Axis2_Angle_Label.Text = "arcmin"
        MainForm.Axis3_Angle_Label.Text = "arcmin"
        MainForm.angleCorrectionFactor = 60.0
        My.Settings.AngleCorrectionFactor = 60.0
    End Sub

    Private Sub Buttondegree_Click(sender As Object, e As EventArgs) Handles Buttondegree.Click
        Buttonarcsec.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonarcsec.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttonarcmin.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Buttonarcmin.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Buttondegree.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Buttondegree.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        MainForm.AngleLabel.Text = "degree"
        MainForm.RangeUnits.Text = "degree"
        MainForm.Axis_UnitsA.Text = "degree"
        MainForm.Axis1_Angle_Label.Text = "degree"
        MainForm.Axis2_Angle_Label.Text = "degree"
        MainForm.Axis3_Angle_Label.Text = "degree"
        MainForm.angleCorrectionFactor = 1.0
        My.Settings.AngleCorrectionFactor = 1.0
    End Sub

End Class
