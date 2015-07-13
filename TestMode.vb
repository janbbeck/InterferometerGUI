Imports System.Windows.Forms

Public Class TestMode

    Dim FrequencyMultiplier As Double = 1
    Dim AmplitudeMultiplier As Double = 1
    Dim OffsetMultiplier As Double = 0

    Private Sub TMClose_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMClose_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button_Constant_Click(sender As Object, e As EventArgs) Handles Button_Constant.Click
        Button_Constant.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Square.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Square.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Triangle.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Ramp.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Sine.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.Black)
        My.Settings.Save()
    End Sub

    Private Sub Button_Square_Click(sender As Object, e As EventArgs) Handles Button_Square.Click
        Button_Constant.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Square.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Button_Square.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Triangle.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Ramp.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Sine.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.Black)
        My.Settings.Save()
    End Sub

    Private Sub Button_Triangle_Click(sender As Object, e As EventArgs) Handles Button_Triangle.Click
        Button_Constant.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Square.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Square.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Triangle.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Ramp.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Sine.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.Black)
        My.Settings.Save()
    End Sub

    Private Sub Button_Ramp_Click(sender As Object, e As EventArgs) Handles Button_Ramp.Click
        Button_Constant.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Square.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Square.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Triangle.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Ramp.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Sine.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.Black)
        My.Settings.Save()
    End Sub

    Private Sub Button_Sine_Click(sender As Object, e As EventArgs) Handles Button_Sine.Click
        Button_Constant.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Square.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Square.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Triangle.BackgroundImage = InterferometerGUI.My.Resources.Resources.inActiveButton4
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Ramp.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Sine.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.Black)
        My.Settings.Save()
    End Sub

    Private Sub FGOff_Button_Click(sender As Object, e As EventArgs) Handles FGOff_Button.Click
        FGOff_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        FGOff_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        FGOn_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        FGOn_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        My.Settings.Save()
    End Sub

    Private Sub FGOn_Button_Click(sender As Object, e As EventArgs) Handles FGOn_Button.Click
        FGOff_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        FGOff_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        FGOn_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        FGOn_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        My.Settings.Save()
    End Sub

    Private Sub Track_Frequency_Scroll(sender As Object, e As EventArgs) Handles Trackbar_Frequency.Scroll
        Textbox_Frequency.Text = Trackbar_Frequency.Value.ToString("F")
        FrequencyMultiplier = Trackbar_Frequency.Value
        My.Settings.Save()
    End Sub

    Private Sub Track_Amplitude_Scroll(sender As Object, e As EventArgs) Handles TrackBar_Amplitude.Scroll
        TextBox_Amplitude.Text = TrackBar_Amplitude.Value.ToString("F")
        AmplitudeMultiplier = TrackBar_Amplitude.Value
        My.Settings.Save()
    End Sub

    Private Sub Track_Offset_Scroll(sender As Object, e As EventArgs) Handles TrackBar_Offset.Scroll
        TextBox_Offset.Text = TrackBar_Offset.Value.ToString("F")
        OffsetMultiplier = TrackBar_Offset.Value
        My.Settings.Save()
    End Sub

    Private Sub TestMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class