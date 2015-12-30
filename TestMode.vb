Imports System.Windows.Forms

Public Class TestMode

    Dim FrequencyMultiplier As Double = 1
    Dim AmplitudeMultiplier As Double = 1
    Dim OffsetMultiplier As Double = 0
    Dim oldZeroAdjustment As Double = 0
    Dim PreviousTMFreqValue As Double = 1

    Private Sub TestMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MainForm.TMWaveformFlag = My.Settings.TMWaveformFlag
        MainForm.TMUnitsFactor = My.Settings.TMUnitsFactor
        NumericUpDown_FGREF_Value.Value = CDec(My.Settings.TMREFFrequency)

        If MainForm.TMUnitsFactor = 0.001 Then
            ComboBox_Units.Text = "μm"
        ElseIf MainForm.TMUnitsFactor = 1 Then
            ComboBox_Units.Text = "mm"
        ElseIf MainForm.TMUnitsFactor = 10 Then
            ComboBox_Units.Text = "cm"
        ElseIf MainForm.TMUnitsFactor = 1000 Then
            ComboBox_Units.Text = "m"
        ElseIf MainForm.TMUnitsFactor = 25.4 Then
            ComboBox_Units.Text = "in"
        ElseIf MainForm.TMUnitsFactor = 304.8 Then
            ComboBox_Units.Text = "ft"
        End If

        MainForm.TMFreqValue = Trackbar_Frequency.Value * 10 * MainForm.TMFreqMult
        Textbox_Frequency.Text = (MainForm.TMFreqValue / 10).ToString("0.000")
        MainForm.TMAmpValue = TrackBar_Amplitude.Value * MainForm.TMAmpMult / 2
        TextBox_Amplitude.Text = (MainForm.TMAmpValue / 50).ToString("0.0000")
        MainForm.TMOfsValue = TrackBar_Offset.Value * MainForm.TMOfsMult
        TextBox_Offset.Text = (MainForm.TMOfsValue / 10).ToString("0.00")

        TextBox_Units_Caution.Visible = False
        If Not Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
            If (Math.PI * 12.65 * MainForm.TMUnitsFactor) * MainForm.TMFreqMult * MainForm.TMAmpValue > ((NumericUpDown_FGREF_Value.Value - 0.1) * 100) Then
                TextBox_Units_Caution.Visible = True
            End If
        End If
        If Multiple_Axes_Enable_CheckBox.Checked = True Then
            Axis_Select_Label.Visible = True
            Axis1_CheckBox.Visible = True
            Axis2_Checkbox.Visible = True
            Axis3_CheckBox.Visible = True
        End If
    End Sub

    Private Sub TMClose_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMClose_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        My.Settings.TMREFFrequency = NumericUpDown_FGREF_Value.Value
        My.Settings.TMWaveformFlag = MainForm.TMWaveformFlag
        My.Settings.TMUnitsFactor = MainForm.TMUnitsFactor
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Button_Constant_Click(sender As Object, e As EventArgs) Handles Button_Constant.Click
        Button_Constant.BackgroundImage = uMDGUI.My.Resources.Resources.ActiveButton6
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Button_Ramp.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Triangle.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Sine.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.Black)

        TextBox_Units_Caution.Visible = False

        MainForm.IgnoreCount = 2
        MainForm.counter = 0
        MainForm.waveform = 0
        MainForm.TMWaveformFlag = 1
    End Sub

    Private Sub Button_Ramp_Click(sender As Object, e As EventArgs) Handles Button_Ramp.Click
        Button_Constant.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Ramp.BackgroundImage = uMDGUI.My.Resources.Resources.ActiveButton6
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Button_Triangle.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Sine.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.Black)

        TextBox_Units_Caution.Visible = False
        If Not Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
            If (Math.PI * 12.65 * MainForm.TMUnitsFactor) * MainForm.TMFreqMult * MainForm.TMAmpValue > ((NumericUpDown_FGREF_Value.Value - 0.1) * 100) Then
                TextBox_Units_Caution.Visible = True
            End If
        End If

        MainForm.IgnoreCount = 2
        MainForm.simcount = 0
        MainForm.waveform = MainForm.IgnoreCount * -(0.00001 * MainForm.TMFreqValue * TrackBar_Offset.Value)
        MainForm.TMWaveformFlag = 2
    End Sub

    Private Sub Button_Triangle_Click(sender As Object, e As EventArgs) Handles Button_Triangle.Click
        Button_Constant.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Ramp.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Triangle.BackgroundImage = uMDGUI.My.Resources.Resources.ActiveButton6
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
        Button_Sine.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.Black)

        TextBox_Units_Caution.Visible = False
        If Not Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
            If (Math.PI * 12.65 * MainForm.TMUnitsFactor) * MainForm.TMFreqMult * MainForm.TMAmpValue > ((NumericUpDown_FGREF_Value.Value - 0.1) * 100) Then
                TextBox_Units_Caution.Visible = True
            End If
        End If

        MainForm.IgnoreCount = 2
        MainForm.counter = 0
        MainForm.waveform = MainForm.IgnoreCount * -(0.002 * MainForm.TMFreqValue)
        MainForm.bangbang = 1
        MainForm.TMWaveformFlag = 4
    End Sub

    Private Sub Button_Sine_Click(sender As Object, e As EventArgs) Handles Button_Sine.Click
        Button_Constant.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
        Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Ramp.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
        Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Triangle.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
        Button_Triangle.ForeColor = Color.FromKnownColor(KnownColor.Black)
        Button_Sine.BackgroundImage = uMDGUI.My.Resources.Resources.ActiveButton6
        Button_Sine.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)

        TextBox_Units_Caution.Visible = False
        If Not Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
            If (Math.PI * 12.65 * MainForm.TMUnitsFactor) * MainForm.TMFreqMult * MainForm.TMAmpValue > ((NumericUpDown_FGREF_Value.Value - 0.1) * 100) Then
                TextBox_Units_Caution.Visible = True
            End If
        End If

        MainForm.IgnoreCount = 2
        MainForm.simcount = -MainForm.IgnoreCount
        MainForm.counter = 0
        MainForm.waveform = MainForm.IgnoreCount * -(0.002 * MainForm.TMFreqValue)
        MainForm.phase = 0
        MainForm.TMWaveformFlag = 8
    End Sub

    Private Sub ComboBox_Frequency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Frequency.SelectedIndexChanged
        If ComboBox_Frequency.Text.Equals("0 to 0.1 Hz") Then
            MainForm.TMFreqMult = 0.001
        ElseIf ComboBox_Frequency.Text.Equals("0 to 1 Hz") Then
            MainForm.TMFreqMult = 0.01
        ElseIf ComboBox_Frequency.Text.Equals("0 to 10 Hz") Then
            MainForm.TMFreqMult = 0.1
        ElseIf ComboBox_Frequency.Text.Equals("0 to 100 Hz") Then
            MainForm.TMFreqMult = 1
        ElseIf ComboBox_Frequency.Text.Equals("0 to 1 kHz") Then
            MainForm.TMFreqMult = 10
        End If

        PreviousTMFreqValue = MainForm.simcount * MainForm.TMFreqValue * Math.PI / 1000 * 0.000655 / 0.002 + MainForm.phase
        MainForm.TMFreqValue = Trackbar_Frequency.Value * 10 * MainForm.TMFreqMult
        MainForm.phase = PreviousTMFreqValue - MainForm.simcount * MainForm.TMFreqValue * Math.PI / 1000 * 0.000655 / 0.002

        TextBox_Units_Caution.Visible = False
        If Not Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
            If (Math.PI * 12.65 * MainForm.TMUnitsFactor) * MainForm.TMFreqMult * MainForm.TMAmpValue > ((NumericUpDown_FGREF_Value.Value - 0.1) * 100) Then
                TextBox_Units_Caution.Visible = True
            End If
        End If

        Textbox_Frequency.Text = (MainForm.TMFreqValue / 10).ToString("0.000")
        MainForm.IgnoreCount = 1
    End Sub

    Private Sub Track_Frequency_Scroll(sender As Object, e As EventArgs) Handles Trackbar_Frequency.Scroll
        PreviousTMFreqValue = MainForm.simcount * MainForm.TMFreqValue * Math.PI / 1000 * 0.000655 / 0.002 + MainForm.phase
        MainForm.TMFreqValue = Trackbar_Frequency.Value * 10 * MainForm.TMFreqMult
        MainForm.phase = PreviousTMFreqValue - MainForm.simcount * MainForm.TMFreqValue * Math.PI / 1000 * 0.000655 / 0.002
        Textbox_Frequency.Text = (MainForm.TMFreqValue / 10).ToString("0.000")
        MainForm.IgnoreCount = 1
    End Sub

    Private Sub ComboBox_amplitude_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Amplitude.SelectedIndexChanged
        If ComboBox_Amplitude.Text.Equals("0 to 0.01") Then
            MainForm.TMAmpMult = 0.01
        ElseIf ComboBox_Amplitude.Text.Equals("0 to 0.1") Then
            MainForm.TMAmpMult = 0.1
        ElseIf ComboBox_Amplitude.Text.Equals("0 to 1") Then
            MainForm.TMAmpMult = 1
        ElseIf ComboBox_Amplitude.Text.Equals("0 to 10") Then
            MainForm.TMAmpMult = 10
        ElseIf ComboBox_Amplitude.Text.Equals("0 to 100") Then
            MainForm.TMAmpMult = 100
        End If

        TextBox_Units_Caution.Visible = False
        If Not Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
            If (Math.PI * 12.65 * MainForm.TMUnitsFactor) * MainForm.TMFreqMult * MainForm.TMAmpValue > ((NumericUpDown_FGREF_Value.Value - 0.1) * 100) Then
                TextBox_Units_Caution.Visible = True
            End If
        End If

        MainForm.TMAmpValue = TrackBar_Amplitude.Value * MainForm.TMAmpMult / 2
        TextBox_Amplitude.Text = (MainForm.TMAmpValue / 50).ToString("0.0000")
        MainForm.IgnoreCount = 2
    End Sub

    Private Sub Track_Amplitude_Scroll(sender As Object, e As EventArgs) Handles TrackBar_Amplitude.Scroll
        MainForm.TMAmpValue = TrackBar_Amplitude.Value * MainForm.TMAmpMult / 2
        TextBox_Amplitude.Text = (MainForm.TMAmpValue / 50).ToString("0.0000")
        MainForm.IgnoreCount = 2
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
        MainForm.IgnoreCount = 2
    End Sub

    Private Sub Track_Offset_Scroll(sender As Object, e As EventArgs) Handles TrackBar_Offset.Scroll
        MainForm.TMOfsValue = TrackBar_Offset.Value * MainForm.TMOfsMult
        TextBox_Offset.Text = (MainForm.TMOfsValue / 10).ToString("0.00")
        MainForm.IgnoreCount = 2
    End Sub

    Private Sub ComboBox_Units_Selectedindexchanged(sender As Object, e As EventArgs) Handles ComboBox_Units.SelectedIndexChanged
        If MainForm.MFLoaded = 1 Then
            If ComboBox_Units.Text.Equals("μm") Then
                MainForm.TMUnitsFactor = 0.001
            ElseIf ComboBox_Units.Text.Equals("mm") Then
                MainForm.TMUnitsFactor = 1
            ElseIf ComboBox_Units.Text.Equals("cm") Then
                MainForm.TMUnitsFactor = 10
            ElseIf ComboBox_Units.Text.Equals("m") Then
                MainForm.TMUnitsFactor = 1000
            ElseIf ComboBox_Units.Text.Equals("in") Then
                MainForm.TMUnitsFactor = 25.4
            ElseIf ComboBox_Units.Text.Equals("ft") Then
                MainForm.TMUnitsFactor = 304.8
            End If

            TextBox_Units_Caution.Visible = False
            If Not Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                If (Math.PI * 12.65 * MainForm.TMUnitsFactor) * MainForm.TMFreqMult * MainForm.TMAmpValue > ((NumericUpDown_FGREF_Value.Value - 0.1) * 100) Then
                    TextBox_Units_Caution.Visible = True
                End If
            End If

            MainForm.IgnoreCount = 2
        End If
    End Sub

    Private Sub FGOn_Button_Click(sender As Object, e As EventArgs) Handles FGOn_Button.Click
        If MainForm.TestmodeFlag = 0 Then
            FGOff_Button.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
            FGOff_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)
            FGOn_Button.BackgroundImage = uMDGUI.My.Resources.Resources.ActiveButton6
            FGOn_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)

            MainForm.TestmodeFlag = 1
            MainForm.TestModeLabel.Visible = True
            MainForm.REF.Visible = True
            MainForm.MEAS.Visible = True
            MainForm.DIFF.Visible = True

            MainForm.IgnoreCount = 0
            MainForm.ErrorFlag = 0

            If MainForm.SerialPort1.IsOpen = True Then
                MainForm.needsInitialZero = 1
                MainForm.IgnoreCount = 40
                MainForm.simulationDistance = 0
                MainForm.previousSimulationDistance = 0
                MainForm.simcount = -MainForm.IgnoreCount + 2
                MainForm.counter = 0
                MainForm.waveform = (MainForm.IgnoreCount - 2) * -(0.002 * MainForm.TMFreqValue)
                If Button_Ramp.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                    MainForm.waveform = MainForm.IgnoreCount * -(0.00001 * MainForm.TMFreqValue * TrackBar_Offset.Value)
                End If
                MainForm.bangbang = 1
                MainForm.phase = 0
            End If

            MainForm.SimulationTimer.Enabled = True
        End If
    End Sub

    Private Sub FGOff_Button_Click(sender As Object, e As EventArgs) Handles FGOff_Button.Click
        If MainForm.TestmodeFlag = 1 Then
            FGOff_Button.BackgroundImage = uMDGUI.My.Resources.Resources.ActiveButton6
            FGOff_Button.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText)
            FGOn_Button.BackgroundImage = uMDGUI.My.Resources.Resources.InActiveButton4
            FGOn_Button.ForeColor = Color.FromKnownColor(KnownColor.Black)

            MainForm.TestmodeFlag = 0
            MainForm.TestModeLabel.Visible = False
            MainForm.REFFrequency = 0
            MainForm.REF.Visible = True
            MainForm.MEASFrequency = 0
            MainForm.MEAS.Visible = True
            MainForm.DIFFFrequency = 0
            MainForm.DIFF.Visible = True

            MainForm.IgnoreCount = 0
            MainForm.ErrorFlag = 0

            If MainForm.SerialPort1.IsOpen = True Then
                MainForm.needsInitialZero = 1
                MainForm.IgnoreCount = 40
                MainForm.SuspendFlag = 0
            End If


            '      MainForm.MultipleAxesFlag = 1
            '      MainForm.TMMultipleAxesFlag = 1
            'Axis_Select_Label.Visible = False
            'Axis1_CheckBox.Visible = False
            'Axis2_Checkbox.Visible = False
            'Axis3_CheckBox.Visible = False
            'MainForm.Axis1_Label.Visible = False
            'MainForm.Axis1_Value.Visible = False
            'MainForm.Axis1_Units_Label.Visible = False
            'MainForm.Axis1_Time_Label.Visible = False
            'MainForm.Axis1_Angle_Label.Visible = False
            'MainForm.Axis2_Label.Visible = False
            'MainForm.Axis2_Value.Visible = False
            'MainForm.Axis2_Units_Label.Visible = False
            'MainForm.Axis2_Time_Label.Visible = False
            'MainForm.Axis2_Angle_Label.Visible = False
            'MainForm.Axis3_Label.Visible = False
            'MainForm.Axis3_Value.Visible = False
            'MainForm.Axis3_Units_Label.Visible = False
            'MainForm.Axis3_Time_Label.Visible = False
            'MainForm.Axis3_Angle_Label.Visible = False

            MainForm.SimulationTimer.Enabled = False
        End If
    End Sub

    Private Sub Error_Detection_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Error_Detection_CheckBox.CheckedChanged
        If Error_Detection_CheckBox.Checked = True Then
            MainForm.EDOff_Label.Visible = False
            MainForm.ErrorFlag = 0
            MainForm.EDEnabled = 1
        Else
            MainForm.EDOff_Label.Visible = True
            MainForm.ErrorFlag = 0
            MainForm.EDEnabled = 0
        End If
    End Sub

    Private Sub Diagnostic_Enable_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Error_Detection_CheckBox.CheckedChanged
        If Diagnostic_Enable_CheckBox.Checked = False Then
            MainForm.Phase_Value.Visible = False
            MainForm.PBA_RM_Value.Visible = False
            MainForm.PBA_RP_Value.Visible = False
            MainForm.RMA_RM_Value.Visible = False
            MainForm.RMA_RP__Value.Visible = False
            MainForm.Phase_Error_Value.Visible = False
            MainForm.Phase_Label.Visible = False
            MainForm.PORTB_Label.Visible = False
            MainForm.REFMEAS_Label.Visible = False
            MainForm.Phase_Error_Label.Visible = False
        End If
    End Sub

    Private Sub ZeroButton_Click(sender As Object, e As EventArgs) Handles ZeroButton.Click
        MainForm.needsInitialZero = 1
        MainForm.zeroAdjustment = MainForm.currentValue
        MainForm.ErrorFlag = 0
        MainForm.DifferenceValue = 0
        MainForm.displacementQueuex.Clear()
        MainForm.displacementQueuey.Clear()
        MainForm.displayValue = 0
        MainForm.average = 0
        MainForm.IgnoreCount = 2
        MainForm.ErrorFlag = 0
        MainForm.SuspendFlag = 0
        MainForm.CurrentValueCorrection = MainForm.CurrentValueCorrection + MainForm.currentValue - MainForm.SuspendCurrentValue
        MainForm.needsInitialZero = 1
    End Sub

    Private Sub NumericUpDown_FGREF_Value_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles NumericUpDown_FGREF_Value.ValueChanged
        If MainForm.MFLoaded = 1 Then

            TextBox_Units_Caution.Visible = False
            If Not Button_Constant.ForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText) Then
                If (Math.PI * 12.65 * MainForm.TMUnitsFactor) * MainForm.TMFreqMult * MainForm.TMAmpValue > ((NumericUpDown_FGREF_Value.Value - 0.1) * 100) Then
                    TextBox_Units_Caution.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Multiple_Axes_Enable_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Multiple_Axes_Enable_CheckBox.CheckedChanged
        If MainForm.MFLoaded = 1 Then
            If Multiple_Axes_Enable_CheckBox.Checked = True Then
                MainForm.MultipleAxesFlag = &H8
                MainForm.TMMultipleAxesFlag = &H8
                Axis_Select_Label.Visible = True
                Axis1_CheckBox.Visible = True
                Axis2_Checkbox.Visible = True
                Axis3_CheckBox.Visible = True
                If Axis1_CheckBox.Checked = True Then
                    MainForm.MultipleAxesFlag = MainForm.MultipleAxesFlag Or &H1
                    MainForm.TMMultipleAxesFlag = MainForm.TMMultipleAxesFlag Or &H1
                    MainForm.Axis1_Label.Visible = True
                    MainForm.Axis1_Value.Visible = True
                End If
                If Axis2_Checkbox.Checked = True Then
                    MainForm.MultipleAxesFlag = MainForm.MultipleAxesFlag Or &H2
                    MainForm.TMMultipleAxesFlag = MainForm.TMMultipleAxesFlag Or &H2
                    MainForm.Axis2_Label.Visible = True
                    MainForm.Axis2_Value.Visible = True
                End If
                If Axis3_CheckBox.Checked = True Then
                    MainForm.MultipleAxesFlag = MainForm.MultipleAxesFlag Or &H4
                    MainForm.TMMultipleAxesFlag = MainForm.TMMultipleAxesFlag Or &H4
                    MainForm.Axis3_Label.Visible = True
                    MainForm.Axis3_Value.Visible = True
                End If
            Else
                MainForm.MultipleAxesFlag = 1
                MainForm.TMMultipleAxesFlag = 1
                Axis_Select_Label.Visible = False
                Axis1_CheckBox.Visible = False
                Axis2_Checkbox.Visible = False
                Axis3_CheckBox.Visible = False
                MainForm.Axis1_Label.Visible = False
                MainForm.Axis1_Value.Visible = False
                MainForm.Axis1_Units_Label.Visible = False
                MainForm.Axis1_Time_Label.Visible = False
                MainForm.Axis1_Angle_Label.Visible = False
                MainForm.Axis2_Label.Visible = False
                MainForm.Axis2_Value.Visible = False
                MainForm.Axis2_Units_Label.Visible = False
                MainForm.Axis2_Time_Label.Visible = False
                MainForm.Axis2_Angle_Label.Visible = False
                MainForm.Axis3_Label.Visible = False
                MainForm.Axis3_Value.Visible = False
                MainForm.Axis3_Units_Label.Visible = False
                MainForm.Axis3_Time_Label.Visible = False
                MainForm.Axis3_Angle_Label.Visible = False
            End If
        End If
    End Sub

    Private Sub Axis1_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Axis1_CheckBox.CheckedChanged
        If MainForm.MFLoaded = 1 Then
            If Axis1_CheckBox.Checked = True Then
                MainForm.MultipleAxesFlag = MainForm.MultipleAxesFlag Or &H1
                MainForm.TMMultipleAxesFlag = MainForm.TMMultipleAxesFlag Or &H1
                MainForm.Axis1_Label.Visible = True
                MainForm.Axis1_Value.Visible = True
            Else
                MainForm.MultipleAxesFlag = MainForm.MultipleAxesFlag And &HFFFE
                MainForm.TMMultipleAxesFlag = MainForm.TMMultipleAxesFlag And &HFFFE
                MainForm.Axis1_Label.Visible = False
                MainForm.Axis1_Value.Visible = False
                MainForm.Axis1_Units_Label.Visible = False
                MainForm.Axis1_Time_Label.Visible = False
                MainForm.Axis1_Angle_Label.Visible = False
            End If
        End If
    End Sub

    Private Sub Axis2_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Axis2_Checkbox.CheckedChanged
        If MainForm.MFLoaded = 1 Then
            If Axis2_Checkbox.Checked = True Then
                MainForm.MultipleAxesFlag = MainForm.MultipleAxesFlag Or &H2
                MainForm.TMMultipleAxesFlag = MainForm.TMMultipleAxesFlag Or &H2
                MainForm.Axis2_Label.Visible = True
                MainForm.Axis2_Value.Visible = True
            Else
                MainForm.MultipleAxesFlag = MainForm.MultipleAxesFlag And &HFFFD
                MainForm.TMMultipleAxesFlag = MainForm.TMMultipleAxesFlag And &HFFFD
                MainForm.Axis2_Label.Visible = False
                MainForm.Axis2_Value.Visible = False
                MainForm.Axis2_Units_Label.Visible = False
                MainForm.Axis2_Time_Label.Visible = False
                MainForm.Axis2_Angle_Label.Visible = False
            End If
        End If
    End Sub

    Private Sub Axis3_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Axis3_CheckBox.CheckedChanged
        If MainForm.MFLoaded = 1 Then
            If Axis3_CheckBox.Checked = True Then
                MainForm.TMMultipleAxesFlag = MainForm.TMMultipleAxesFlag Or &H4
                MainForm.MultipleAxesFlag = MainForm.TMMultipleAxesFlag Or &H4
                MainForm.Axis3_Label.Visible = True
                MainForm.Axis3_Value.Visible = True
            Else
                MainForm.MultipleAxesFlag = MainForm.MultipleAxesFlag And &HFFFB
                MainForm.TMMultipleAxesFlag = MainForm.TMMultipleAxesFlag And &HFFFB
                MainForm.Axis3_Label.Visible = False
                MainForm.Axis3_Label.Visible = False
                MainForm.Axis3_Value.Visible = False
                MainForm.Axis3_Units_Label.Visible = False
                MainForm.Axis3_Time_Label.Visible = False
                MainForm.Axis3_Angle_Label.Visible = False
            End If
        End If
    End Sub
End Class