Imports System.Windows.Forms

Public Class Compensation

    Public Temperature As Double
    Public Pressure As Double
    Public Humidity As Double
    Public TemperatureC As Double = 20
    Public PressureATM As Double = 1000
    Public HumidityRel As Double = 50
    Public TCorrection As Double = 1
    Public PCorrection As Double = 1
    Public HCorrection As Double = 1

    Public ECFactor As Double = 1

    Private Sub CMPDone_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMPDone_Button.Click
        My.Settings.Temperature = NumericUpDown_Temperature.Value
        My.Settings.TempUnits = ComboBox_TempUnits.Text
        My.Settings.Pressure = NumericUpDown_Pressure.Value
        My.Settings.PressureUnits = ComboBox_Pressure_Units.Text
        My.Settings.Humidity = NumericUpDown_Humidity.Value
        My.Settings.TempFactor = TextBox_TempFactor.Text
        My.Settings.PresFactor = TextBox_PresFactor.Text
        My.Settings.HumiFactor = TextBox_HumiFactor.Text
        My.Settings.TFactor = TCorrection
        My.Settings.PFactor = PCorrection
        My.Settings.HFactor = HCorrection
        My.Settings.ECFactor = ECFactor
        My.Settings.Save()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Compensation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NumericUpDown_Temperature_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Temperature.ValueChanged
        If MainForm.MFLoaded = 1 Then
            Temperature = NumericUpDown_Temperature.Value
            If ComboBox_TempUnits.Text.Equals("Degrees C") Then
                TemperatureC = Temperature
            ElseIf ComboBox_TempUnits.Text.Equals("Degrees F") Then
                TemperatureC = (5 / 9) * (Temperature - 32)
            Else
                TemperatureC = Temperature - 273
                'TextBox_TempFactor.Text = MainForm.Temperature.ToString("#0000.000000")
            End If

            TCorrection = 1 / (1 + (0.000271375 * 293 / (273 + TemperatureC)))
            TextBox_TempFactor.Text = TCorrection.ToString("#0.000000000")

            If ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                ECFactor = TCorrection * PCorrection * HCorrection
                MainForm.Wavelength = NumericUpDown_Wavelength.Value * ECFactor
                MainForm.WLText.Text = MainForm.Wavelength.ToString("000.000000")
            End If
        End If
    End Sub

    Private Sub ComboBox_TempUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_TempUnits.SelectedIndexChanged

        If MainForm.MFLoaded = 1 Then
            Temperature = NumericUpDown_Temperature.Value
            If ComboBox_TempUnits.Text.Equals("Degrees C") Then
                NumericUpDown_Temperature.Minimum = 0
                NumericUpDown_Temperature.Maximum = 70
                NumericUpDown_Temperature.Value = 20
                TemperatureC = 20
            ElseIf ComboBox_TempUnits.Text.Equals("Degrees F") Then
                NumericUpDown_Temperature.Minimum = 32
                NumericUpDown_Temperature.Maximum = 158
                NumericUpDown_Temperature.Value = 68
                TemperatureC = (5 / 9) * (Temperature - 32)
            Else
                NumericUpDown_Temperature.Minimum = 273
                NumericUpDown_Temperature.Maximum = 343
                NumericUpDown_Temperature.Value = 293
                TemperatureC = Temperature - 273
            End If

            TCorrection = 1 / (1 + (0.000271375 * 293 / (273 + TemperatureC)))
            TextBox_TempFactor.Text = TCorrection.ToString("#0.000000000")

            If ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                ECFactor = TCorrection * PCorrection * HCorrection
                MainForm.Wavelength = NumericUpDown_Wavelength.Value * ECFactor
                MainForm.WLText.Text = MainForm.Wavelength.ToString("000.000000")
            End If
        End If
    End Sub

    Private Sub NumericUpDown_Pressure_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Pressure.ValueChanged
        If MainForm.MFLoaded = 1 Then
            Pressure = NumericUpDown_Pressure.Value
            If ComboBox_Pressure_Units.Text.Equals("mm/Hg") Then
                PressureATM = Pressure / 0.76
            Else
                PressureATM = (Pressure)
            End If

            PCorrection = 1 / (1 + (0.000271375 * PressureATM / 1013))
            TextBox_PresFactor.Text = PCorrection.ToString("#0.000000000")

            If ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                ECFactor = TCorrection * PCorrection * HCorrection
                MainForm.Wavelength = NumericUpDown_Wavelength.Value * ECFactor
                MainForm.WLText.Text = MainForm.Wavelength.ToString("000.000000")
            End If
        End If
    End Sub

    Private Sub ComboBox_Pressure_Units_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Pressure_Units.SelectedIndexChanged
        If MainForm.MFLoaded = 1 Then
            Pressure = NumericUpDown_Pressure.Value
            If ComboBox_Pressure_Units.Text.Equals("mm/Hg") Then
                NumericUpDown_Pressure.Minimum = 380
                NumericUpDown_Pressure.Maximum = 1520
                NumericUpDown_Pressure.Value = 760
                Pressure = 760
                PressureATM = 1000
            Else
                ComboBox_Pressure_Units.Text.Equals("mBar")
                NumericUpDown_Pressure.Value = 1000
                NumericUpDown_Pressure.Minimum = 500
                NumericUpDown_Pressure.Maximum = 2000
                PressureATM = Pressure
            End If

            PCorrection = 1 / (1 + (0.000271375 * PressureATM / 1013))
            TextBox_PresFactor.Text = PCorrection.ToString("#0.000000000")

            If ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                ECFactor = TCorrection * PCorrection * HCorrection
                MainForm.Wavelength = NumericUpDown_Wavelength.Value * ECFactor
                MainForm.WLText.Text = (MainForm.Wavelength * ECFactor).ToString("000.000000")
            End If
        End If
    End Sub

    Private Sub NumericUpDown_Humidity_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Humidity.ValueChanged
        If MainForm.MFLoaded = 1 Then
            Dim humidityreference As Double = 1.000271375
            HumidityRel = NumericUpDown_Humidity.Value
            If HumidityRel = 0 Then HCorrection = 1.000271375 / 1.000271799
            If HumidityRel = 10 Then HCorrection = 1.000271375 / 1.000271714
            If HumidityRel = 20 Then HCorrection = 1.000271375 / 1.000271629
            If HumidityRel = 30 Then HCorrection = 1.000271375 / 1.000271544
            If HumidityRel = 40 Then HCorrection = 1.000271375 / 1.000271459
            If HumidityRel = 50 Then HCorrection = 1
            If HumidityRel = 60 Then HCorrection = 1.000271375 / 1.00027129
            If HumidityRel = 70 Then HCorrection = 1.000271375 / 1.000271205
            If HumidityRel = 80 Then HCorrection = 1.000271375 / 1.00027112
            If HumidityRel = 90 Then HCorrection = 1.000271375 / 1.000271035
            If HumidityRel = 100 Then HCorrection = 1.000271375 / 1.00027095

            TextBox_HumiFactor.Text = HCorrection.ToString("#0.000000000")

            If ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                ECFactor = TCorrection * PCorrection * HCorrection
                MainForm.Wavelength = NumericUpDown_Wavelength.Value * ECFactor
                MainForm.WLText.Text = MainForm.Wavelength.ToString("000.000000")
            End If
        End If
    End Sub

    Private Sub ECOn_Button_Click(sender As Object, e As EventArgs) Handles ECOn_Button.Click
        ECOff_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        ECOff_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        ECOn_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ECFactor = TCorrection * PCorrection * HCorrection
        MainForm.Wavelength = NumericUpDown_Wavelength.Value * ECFactor
        MainForm.WLText.Text = MainForm.Wavelength.ToString("000.000000")
    End Sub

    Private Sub ECOff_Button_Click(sender As Object, e As EventArgs) Handles ECOff_Button.Click
        ECOff_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.ActiveButton6
        ECOff_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        ECOn_Button.BackgroundImage = InterferometerGUI.My.Resources.Resources.InActiveButton4
        ECOn_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
        MainForm.Wavelength = NumericUpDown_Wavelength.Value    ' should this not be a default value when we press off??
        ECFactor = 1.0
        MainForm.WLText.Text = MainForm.Wavelength.ToString("000.000000")
    End Sub

    Private Sub NumericUpDown_Wavelength_valueChangeCommitted(sender As Object, e As EventArgs) Handles NumericUpDown_Wavelength.ValueChanged
        If MainForm.MFLoaded = 1 Then
            MainForm.Wavelength = NumericUpDown_Wavelength.Value * ECFactor
            MainForm.WLText.Text = MainForm.Wavelength.ToString("000.000000")
        End If
    End Sub
End Class