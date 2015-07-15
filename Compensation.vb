Imports System.Windows.Forms

Public Class Compensation

    Private Sub CMPDone_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMPDone_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Compensation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainForm.TCorrection = 1 / (1 + (0.000271375 * 293 / (273 + MainForm.TemperatureC)))
        TextBox_TempFactor.Text = MainForm.TCorrection.ToString("#0.000000000")
        MainForm.PCorrection = 1 / (1 + (0.000271375 * MainForm.PressureATM / 1013))
        TextBox_PresFactor.Text = MainForm.PCorrection.ToString("#0.000000000")
        MainForm.HCorrection = 1
        TextBox_HumiFactor.Text = MainForm.HCorrection.ToString("#0.000000000")
        MainForm.WLText.Text = (MainForm.Wavelength * MainForm.ECFactor).ToString("000.000000")
    End Sub

    Private Sub NumericUpDown_Temperature_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Temperature.ValueChanged
        MainForm.Temperature = NumericUpDown_Temperature.Value
        If ComboBox_TempUnits.Text.Equals("Degrees C") Then
            MainForm.TemperatureC = MainForm.Temperature
        ElseIf ComboBox_TempUnits.Text.Equals("Degrees F") Then
            MainForm.TemperatureC = (5 / 9) * (MainForm.Temperature - 32)
        Else
            MainForm.TemperatureC = MainForm.Temperature - 273
            'TextBox_TempFactor.Text = MainForm.Temperature.ToString("#0000.000000")
        End If
        MainForm.TCorrection = 1 / (1 + (0.000271375 * 293 / (273 + MainForm.TemperatureC)))
        TextBox_TempFactor.Text = MainForm.TCorrection.ToString("#0.000000000")
        If ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
            MainForm.Wavelength = NumericUpDown_Wavelength.Value * MainForm.TCorrection * MainForm.PCorrection * MainForm.HCorrection
        Else
            MainForm.Wavelength = NumericUpDown_Wavelength.Value
        End If
        MainForm.WLText.Text = (MainForm.Wavelength * MainForm.ECFactor).ToString("000.000000")
    End Sub

    Private Sub ComboBox_TempUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_TempUnits.SelectedIndexChanged
        MainForm.Temperature = NumericUpDown_Temperature.Value
        If ComboBox_TempUnits.Text.Equals("Degrees C") Then
            NumericUpDown_Temperature.Minimum = 0
            NumericUpDown_Temperature.Maximum = 70
            NumericUpDown_Temperature.Value = 20
            MainForm.TemperatureC = 20
        ElseIf ComboBox_TempUnits.Text.Equals("Degrees F") Then
            NumericUpDown_Temperature.Minimum = 32
            NumericUpDown_Temperature.Maximum = 158
            NumericUpDown_Temperature.Value = 68
            MainForm.TemperatureC = (5 / 9) * (MainForm.Temperature - 32)
        Else
            NumericUpDown_Temperature.Minimum = 273
            NumericUpDown_Temperature.Maximum = 343
            NumericUpDown_Temperature.Value = 293
            MainForm.TemperatureC = MainForm.Temperature - 273
        End If
        MainForm.TCorrection = 1 / (1 + (0.000271375 * 293 / (273 + MainForm.TemperatureC)))
        TextBox_TempFactor.Text = MainForm.TCorrection.ToString("#0.000000000")
        MainForm.WLText.Text = (MainForm.Wavelength * MainForm.ECFactor).ToString("000.000000")
    End Sub

    Private Sub NumericUpDown_Pressure_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Pressure.ValueChanged
        MainForm.Pressure = NumericUpDown_Pressure.Value
        If ComboBox_Pressure_Units.Text.Equals("mm/Hg") Then
            MainForm.PressureATM = MainForm.Pressure / 0.76
        Else
            MainForm.PressureATM = (MainForm.Pressure)
        End If

        MainForm.PCorrection = 1 / (1 + (0.000271375 * MainForm.PressureATM / 1013))
        TextBox_PresFactor.Text = MainForm.PCorrection.ToString("#0.000000000")
        If ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
            MainForm.Wavelength = NumericUpDown_Wavelength.Value * MainForm.TCorrection * MainForm.PCorrection * MainForm.HCorrection
        Else
            MainForm.Wavelength = NumericUpDown_Wavelength.Value
        End If
        MainForm.WLText.Text = (MainForm.Wavelength * MainForm.ECFactor).ToString("000.000000")
    End Sub

    Private Sub ComboBox_Pressure_Units_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Pressure_Units.SelectedIndexChanged
        MainForm.Pressure = NumericUpDown_Pressure.Value
        If ComboBox_Pressure_Units.Text.Equals("mm/Hg") Then
            NumericUpDown_Pressure.Minimum = 380
            NumericUpDown_Pressure.Maximum = 1520
            NumericUpDown_Pressure.Value = 760
            MainForm.Pressure = 760
            MainForm.PressureATM = 1000
        Else
            ComboBox_Pressure_Units.Text.Equals("mBar")
            NumericUpDown_Pressure.Value = 1000
            NumericUpDown_Pressure.Minimum = 500
            NumericUpDown_Pressure.Maximum = 2000
            MainForm.PressureATM = MainForm.Pressure
        End If
        MainForm.WLText.Text = (MainForm.Wavelength * MainForm.ECFactor).ToString("000.000000")
        MainForm.PCorrection = 1 / (1 + (0.000271375 * MainForm.PressureATM / 1013))
        TextBox_PresFactor.Text = MainForm.PCorrection.ToString("#0.000000000")
    End Sub

    Private Sub NumericUpDown_Humidity_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Humidity.ValueChanged
        Dim humidityreference As Double = 1.000271375
        If NumericUpDown_Humidity.Value = 0 Then MainForm.HCorrection = 1.000271375 / 1.000271799
        If NumericUpDown_Humidity.Value = 10 Then MainForm.HCorrection = 1.000271375 / 1.000271714
        If NumericUpDown_Humidity.Value = 20 Then MainForm.HCorrection = 1.000271375 / 1.000271629
        If NumericUpDown_Humidity.Value = 30 Then MainForm.HCorrection = 1.000271375 / 1.000271544
        If NumericUpDown_Humidity.Value = 40 Then MainForm.HCorrection = 1.000271375 / 1.000271459
        If NumericUpDown_Humidity.Value = 50 Then MainForm.HCorrection = 1
        If NumericUpDown_Humidity.Value = 60 Then MainForm.HCorrection = 1.000271375 / 1.00027129
        If NumericUpDown_Humidity.Value = 70 Then MainForm.HCorrection = 1.000271375 / 1.000271205
        If NumericUpDown_Humidity.Value = 80 Then MainForm.HCorrection = 1.000271375 / 1.00027112
        If NumericUpDown_Humidity.Value = 90 Then MainForm.HCorrection = 1.000271375 / 1.000271035
        If NumericUpDown_Humidity.Value = 100 Then MainForm.HCorrection = 1.000271375 / 1.00027095

        TextBox_HumiFactor.Text = MainForm.HCorrection.ToString("#0.000000000")
        If ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
            MainForm.Wavelength = NumericUpDown_Wavelength.Value * MainForm.TCorrection * MainForm.PCorrection * MainForm.HCorrection
        Else
            MainForm.Wavelength = NumericUpDown_Wavelength.Value
        End If
        MainForm.WLText.Text = (MainForm.Wavelength * MainForm.ECFactor).ToString("000.000000")
    End Sub

    Private Sub ECOff_Button_Click(sender As Object, e As EventArgs) Handles ECOff_Button.Click
        ECOff_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        ECOff_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ECOn_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        MainForm.Wavelength = NumericUpDown_Wavelength.Value    ' should this not be a default value when we press off??
        MainForm.ECFactor = 1.0
        MainForm.WLText.Text = (MainForm.Wavelength * MainForm.ECFactor).ToString("000.000000")


    End Sub

    Private Sub FGOn_Button_Click(sender As Object, e As EventArgs) Handles ECOn_Button.Click
        ECOff_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        ECOff_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        ECOn_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        MainForm.Wavelength = NumericUpDown_Wavelength.Value * MainForm.TCorrection * MainForm.PCorrection * MainForm.HCorrection
        MainForm.WLText.Text = (MainForm.Wavelength * MainForm.ECFactor).ToString("000.000000")

    End Sub

    Private Sub NumericUpDown_Wavelength_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Wavelength.ValueChanged
        MainForm.Wavelength = NumericUpDown_Wavelength.Value
        MainForm.WLText.Text = (MainForm.Wavelength * MainForm.ECFactor).ToString("000.000000")
    End Sub

    Private Sub TextBox_HumiFactor_TextChanged(sender As Object, e As EventArgs) Handles TextBox_HumiFactor.TextChanged

    End Sub
End Class