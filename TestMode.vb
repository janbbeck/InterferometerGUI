﻿Imports System.Windows.Forms

Public Class TestMode

    Dim FrequencyMultiplier As Double = 1
    Dim AmplitudeMultiplier As Double = 1
    Dim OffsetMultiplier As Double = 0

    Private Sub TMClose_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMClose_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button_Constant_Click(sender As Object, e As EventArgs) Handles Button_Constant.Click
        Button_Constant.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Button_Square.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Triangle.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Ramp.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Sine.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Square.UseVisualStyleBackColor = True
        Button_Triangle.UseVisualStyleBackColor = True
        Button_Ramp.UseVisualStyleBackColor = True
        Button_Sine.UseVisualStyleBackColor = True
        My.Settings.Save()
    End Sub

    Private Sub Button_Square_Click(sender As Object, e As EventArgs) Handles Button_Square.Click
        Button_Constant.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Square.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Button_Triangle.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Ramp.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Sine.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Constant.UseVisualStyleBackColor = True
        Button_Triangle.UseVisualStyleBackColor = True
        Button_Ramp.UseVisualStyleBackColor = True
        Button_Sine.UseVisualStyleBackColor = True
        My.Settings.Save()
    End Sub

    Private Sub Button_Triangle_Click(sender As Object, e As EventArgs) Handles Button_Triangle.Click
        Button_Constant.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Square.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Triangle.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Button_Ramp.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Sine.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Constant.UseVisualStyleBackColor = True
        Button_Square.UseVisualStyleBackColor = True
        Button_Ramp.UseVisualStyleBackColor = True
        Button_Sine.UseVisualStyleBackColor = True
        My.Settings.Save()
    End Sub

    Private Sub Button_Ramp_Click(sender As Object, e As EventArgs) Handles Button_Ramp.Click
        Button_Constant.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Square.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Triangle.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Ramp.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Button_Sine.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Constant.UseVisualStyleBackColor = True
        Button_Square.UseVisualStyleBackColor = True
        Button_Triangle.UseVisualStyleBackColor = True
        Button_Sine.UseVisualStyleBackColor = True
        My.Settings.Save()
    End Sub

    Private Sub Button_Sine_Click(sender As Object, e As EventArgs) Handles Button_Sine.Click
        Button_Constant.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Square.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Triangle.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Ramp.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button_Sine.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        Button_Constant.UseVisualStyleBackColor = True
        Button_Square.UseVisualStyleBackColor = True
        Button_Triangle.UseVisualStyleBackColor = True
        Button_Ramp.UseVisualStyleBackColor = True
        My.Settings.Save()
    End Sub

    Private Sub FGOff_Button_Click(sender As Object, e As EventArgs) Handles FGOff_Button.Click
        FGOff_Button.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        FGOn_Button.BackColor = Color.FromKnownColor(KnownColor.Control)
        FGOn_Button.UseVisualStyleBackColor = True
        My.Settings.Save()
    End Sub

    Private Sub FGOn_Button_Click(sender As Object, e As EventArgs) Handles FGOn_Button.Click
        FGOff_Button.BackColor = Color.FromKnownColor(KnownColor.Control)
        FGOn_Button.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        FGOff_Button.UseVisualStyleBackColor = True
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

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Frequency.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_Offset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Offset.SelectedIndexChanged

    End Sub

    Private Sub ComboBox_Amplitude_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Amplitude.SelectedIndexChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class