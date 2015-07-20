Imports System.Windows.Forms

Public Class TestMode

    Dim FrequencyMultiplier As Double = 1
    Dim AmplitudeMultiplier As Double = 1
    Dim OffsetMultiplier As Double = 0
    Dim oldZeroAdjustment As Double = 0

    Private Sub TestMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBox_Units.Text.Equals("um") Then
            MainForm.TMUnitsFactor = 0.001
        ElseIf ComboBox_Units.Text.Equals("mm") Then
            MainForm.TMUnitsFactor = 1
        ElseIf ComboBox_Units.Text.Equals("cm") Then
            MainForm.TMUnitsFactor = 10
        ElseIf ComboBox_Units.Text.Equals("in") Then
            MainForm.TMUnitsFactor = 25.4
        End If

        MainForm.TMFreqValue = Trackbar_Frequency.Value * 10 * MainForm.TMFreqMult
        Textbox_Frequency.Text = (MainForm.TMFreqValue / 10).ToString("0.000")
        MainForm.TMAmpValue = TrackBar_Amplitude.Value * MainForm.TMAmpMult / 2
        TextBox_Amplitude.Text = (MainForm.TMAmpValue / 50).ToString("0.0000")
        MainForm.TMOfsValue = TrackBar_Offset.Value * MainForm.TMOfsMult
        TextBox_Offset.Text = (MainForm.TMOfsValue / 10).ToString("0.00")
    End Sub

    Private Sub TMClose_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMClose_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button_Constant_Click(sender As Object, e As EventArgs) Handles Button_Constant.Click
        Button_Constant.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Button_Triangle.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Ramp.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Sine.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.Black)

    End Sub

    Private Sub Button_Square_Click(sender As Object, e As EventArgs)
        Button_Constant.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Triangle.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Ramp.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Sine.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.Black)
    End Sub

    Private Sub Button_Ramp_Click(sender As Object, e As EventArgs) Handles Button_Ramp.Click
        Button_Constant.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Triangle.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Ramp.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Button_Sine.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.Black)
    End Sub

    Private Sub Button_Triangle_Click(sender As Object, e As EventArgs) Handles Button_Triangle.Click
        Button_Constant.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Triangle.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Button_Ramp.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Sine.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.Black)
    End Sub

    Private Sub Button_Sine_Click(sender As Object, e As EventArgs) Handles Button_Sine.Click
        Button_Constant.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Triangle.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Ramp.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Sine.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
    End Sub

    Private Sub ComboBox_Frequency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Frequency.SelectedIndexChanged
        If ComboBox_Frequency.Text.Equals("0 to 0.1 Hz") Then
            MainForm.TMFreqMult = 0.001
        ElseIf ComboBox_Frequency.Text.Equals("0 to 1 Hz") Then
            MainForm.TMFreqMult = 0.01
        ElseIf ComboBox_Frequency.Text.Equals("0 to 10 Hz") Then
            MainForm.TMFreqMult = 0.1
        End If
        MainForm.TMFreqValue = Trackbar_Frequency.Value * 10 * MainForm.TMFreqMult
        Textbox_Frequency.Text = (MainForm.TMFreqValue / 10).ToString("0.000")
    End Sub

    Private Sub Track_Frequency_Scroll(sender As Object, e As EventArgs) Handles Trackbar_Frequency.Scroll
        MainForm.TMFreqValue = Trackbar_Frequency.Value * 10 * MainForm.TMFreqMult
        Textbox_Frequency.Text = (MainForm.TMFreqValue / 10).ToString("0.000")
    End Sub

    Private Sub ComboBox_amplitude_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Amplitude.SelectedIndexChanged
        If ComboBox_Amplitude.Text.Equals("0 to 0.01") Then
            MainForm.TMAmpMult = 0.01
        ElseIf ComboBox_Amplitude.Text.Equals("0 to 0.1") Then
            MainForm.TMAmpMult = 0.1
        ElseIf ComboBox_Amplitude.Text.Equals("0 to 1") Then
            MainForm.TMAmpMult = 1
        End If
        MainForm.TMAmpValue = TrackBar_Amplitude.Value * MainForm.TMAmpMult / 2
        TextBox_Amplitude.Text = (MainForm.TMAmpValue / 50).ToString("0.0000")
    End Sub

    Private Sub Track_Amplitude_Scroll(sender As Object, e As EventArgs) Handles TrackBar_Amplitude.Scroll
        MainForm.TMAmpValue = TrackBar_Amplitude.Value * MainForm.TMAmpMult / 2
        TextBox_Amplitude.Text = (MainForm.TMAmpValue / 50).ToString("0.0000")
    End Sub

    Private Sub ComboBox_Offset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Offset.SelectedIndexChanged
        If ComboBox_Offset.Text.Equals("-1 to +1") Then
            MainForm.TMOfsMult = 0.1
        ElseIf ComboBox_Offset.Text.Equals("-10 to +10") Then
            MainForm.TMOfsMult = 1
        ElseIf ComboBox_Offset.Text.Equals("-100 to +100") Then
            MainForm.TMOfsMult = 10
        End If
        MainForm.TMOfsValue = TrackBar_Offset.Value * MainForm.TMOfsMult
        TextBox_Offset.Text = (MainForm.TMOfsValue / 10).ToString("0.00")
    End Sub

    Private Sub Track_Offset_Scroll(sender As Object, e As EventArgs) Handles TrackBar_Offset.Scroll
        MainForm.TMOfsValue = TrackBar_Offset.Value * MainForm.TMOfsMult
        TextBox_Offset.Text = (MainForm.TMOfsValue / 10).ToString("0.00")
        'TextBox_Offset.Text = (TrackBar_Offset.Value * MainForm.TMOfsMult).ToString("F")
        'OffsetMultiplier = TrackBar_Offset.Value
    End Sub

    Private Sub ComboBox_Units_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Units.SelectedIndexChanged
        If ComboBox_Units.Text.Equals("um") Then
            MainForm.TMUnitsFactor = 0.001
        ElseIf ComboBox_Units.Text.Equals("mm") Then
            MainForm.TMUnitsFactor = 1
        ElseIf ComboBox_Units.Text.Equals("cm") Then
            MainForm.TMUnitsFactor = 10
        ElseIf ComboBox_Units.Text.Equals("in") Then
            MainForm.TMUnitsFactor = 25.4
        End If
    End Sub

    Private Sub FGOn_Button_Click(sender As Object, e As EventArgs) Handles FGOn_Button.Click
        FGOff_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        FGOff_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        FGOn_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        FGOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        oldZeroAdjustment = MainForm.zeroAdjustment
        MainForm.zeroAdjustment = 0
        MainForm.SimulationTimer.Enabled = True
        MainForm.TestmodeFlag = 1
        MainForm.TestModeLabel.Text = "Simulated Data"
        MainForm.simcount = 0
        MainForm.count = 0
        MainForm.counter = 0
    End Sub

    Private Sub FGOff_Button_Click(sender As Object, e As EventArgs) Handles FGOff_Button.Click
        FGOff_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        FGOff_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        FGOn_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        FGOn_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        MainForm.zeroAdjustment = oldZeroAdjustment
        MainForm.SimulationTimer.Enabled = False
        MainForm.TestmodeFlag = 0
        MainForm.TestModeLabel.Text = ""
    End Sub

    Private Sub ComboBox_Frequency_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox_Frequency.SelectedIndexChanged

    End Sub

    Private Sub ED_On_Button_Click(sender As Object, e As EventArgs) Handles EDOn_Button.Click
        EDOn_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        EDOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        EDOff_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        EDOff_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        MainForm.EDOff_Label.Text = "     "
        MainForm.ErrorFlag = 0
        MainForm.EDEnabled = 1
    End Sub

    Private Sub ED_Off_Button_Click(sender As Object, e As EventArgs) Handles EDOff_Button.Click
        EDOff_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        EDOff_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        EDOn_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        EDOn_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        MainForm.EDOff_Label.Text = "Error Detection Off"
        MainForm.ErrorFlag = 0
        MainForm.EDEnabled = 0
    End Sub

End Class