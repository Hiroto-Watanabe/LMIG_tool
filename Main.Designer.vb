﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cPortSel = New System.Windows.Forms.ComboBox()
        Me.bPortClose = New System.Windows.Forms.Button()
        Me.bPortOpen = New System.Windows.Forms.Button()
        Me.bInitialize = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.TBoxErrCont = New System.Windows.Forms.TextBox()
        Me.bSend = New System.Windows.Forms.Button()
        Me.tbSend = New System.Windows.Forms.TextBox()
        Me.tbShowRawSend = New System.Windows.Forms.TextBox()
        Me.tbShowRawReceive = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.bShutDown = New System.Windows.Forms.Button()
        Me.bSystem = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.myRS232 = New System.IO.Ports.SerialPort(Me.components)
        Me.txt_BeamGain = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_BeamOffset = New System.Windows.Forms.TextBox()
        Me.btn_BeamGain_Set = New System.Windows.Forms.Button()
        Me.btn_BeamOffset_Set = New System.Windows.Forms.Button()
        Me.txt_BeamGain_R = New System.Windows.Forms.TextBox()
        Me.btn_BeamGain_Read = New System.Windows.Forms.Button()
        Me.btn_BeamOffset_Read = New System.Windows.Forms.Button()
        Me.txt_BeamOffset_R = New System.Windows.Forms.TextBox()
        Me.btn_Lens1pOffset_Read = New System.Windows.Forms.Button()
        Me.txt_L1pOffset_R = New System.Windows.Forms.TextBox()
        Me.btn_Lens1pGain_Read = New System.Windows.Forms.Button()
        Me.txt_L1pGain_R = New System.Windows.Forms.TextBox()
        Me.btn_Lens1pOffset_Set = New System.Windows.Forms.Button()
        Me.btn_Lens1pGain_Set = New System.Windows.Forms.Button()
        Me.txt_L1pOffset = New System.Windows.Forms.TextBox()
        Me.txt_L1pGain = New System.Windows.Forms.TextBox()
        Me.btn_Lens1nOffset_Read = New System.Windows.Forms.Button()
        Me.txt_L1nOffset_R = New System.Windows.Forms.TextBox()
        Me.btn_Lens1nGain_Read = New System.Windows.Forms.Button()
        Me.txt_L1nGain_R = New System.Windows.Forms.TextBox()
        Me.btn_Lens1nOffset_Set = New System.Windows.Forms.Button()
        Me.btn_Lens1nGain_Set = New System.Windows.Forms.Button()
        Me.txt_L1nOffset = New System.Windows.Forms.TextBox()
        Me.txt_L1nGain = New System.Windows.Forms.TextBox()
        Me.btn_Lens2Offset_Read = New System.Windows.Forms.Button()
        Me.txt_L2Offset_R = New System.Windows.Forms.TextBox()
        Me.btn_Lens2Gain_Read = New System.Windows.Forms.Button()
        Me.txt_L2Gain_R = New System.Windows.Forms.TextBox()
        Me.btn_Lens2Offset_Set = New System.Windows.Forms.Button()
        Me.btn_Lens2Gain_Set = New System.Windows.Forms.Button()
        Me.txt_L2Offset = New System.Windows.Forms.TextBox()
        Me.txt_L2Gain = New System.Windows.Forms.TextBox()
        Me.btn_SupOffset_Read = New System.Windows.Forms.Button()
        Me.txt_SupOffset_R = New System.Windows.Forms.TextBox()
        Me.btn_SupGain_Read = New System.Windows.Forms.Button()
        Me.txt_SupGain_R = New System.Windows.Forms.TextBox()
        Me.btn_SupOffset_Set = New System.Windows.Forms.Button()
        Me.btn_SupGain_Set = New System.Windows.Forms.Button()
        Me.txt_SupOffset = New System.Windows.Forms.TextBox()
        Me.txt_SupGain = New System.Windows.Forms.TextBox()
        Me.btn_ExtOffset_Read = New System.Windows.Forms.Button()
        Me.txt_ExtOffset_R = New System.Windows.Forms.TextBox()
        Me.btn_ExtGain_Read = New System.Windows.Forms.Button()
        Me.txt_ExtGain_R = New System.Windows.Forms.TextBox()
        Me.btn_ExtOffset_Set = New System.Windows.Forms.Button()
        Me.btn_ExtGain_Set = New System.Windows.Forms.Button()
        Me.txt_ExtOffset = New System.Windows.Forms.TextBox()
        Me.txt_ExtGain = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_HeaterOffset_Read = New System.Windows.Forms.Button()
        Me.txt_HtrOffset_R = New System.Windows.Forms.TextBox()
        Me.btn_HeaterGain_Read = New System.Windows.Forms.Button()
        Me.txt_HtrGain_R = New System.Windows.Forms.TextBox()
        Me.btn_HeaterOffset_Set = New System.Windows.Forms.Button()
        Me.btn_HeaterGain_Set = New System.Windows.Forms.Button()
        Me.txt_HtrOffset = New System.Windows.Forms.TextBox()
        Me.txt_HtrGain = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_PWM_Duty_Read = New System.Windows.Forms.Button()
        Me.txt_PWM_Duty_R = New System.Windows.Forms.TextBox()
        Me.btn_PWM_Freq_Read = New System.Windows.Forms.Button()
        Me.txt_PWM_Freq_R = New System.Windows.Forms.TextBox()
        Me.btn_PWM_Duty_Set = New System.Windows.Forms.Button()
        Me.btn_PWM_Freq_Set = New System.Windows.Forms.Button()
        Me.txt_PWM_Duty = New System.Windows.Forms.TextBox()
        Me.txt_PWM_Freq = New System.Windows.Forms.TextBox()
        Me.btn_PWM_DT_Read = New System.Windows.Forms.Button()
        Me.txt_PWM_DeadTime_R = New System.Windows.Forms.TextBox()
        Me.btn_PWM_DT_Set = New System.Windows.Forms.Button()
        Me.txt_PWM_DeadTime = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_EmiOffset_R = New System.Windows.Forms.Button()
        Me.txt_EmiOffset_R = New System.Windows.Forms.TextBox()
        Me.btn_EmiGain_R = New System.Windows.Forms.Button()
        Me.txt_EmiGain_R = New System.Windows.Forms.TextBox()
        Me.btn_EmiOffset_Set = New System.Windows.Forms.Button()
        Me.btn_EmiGain_Set = New System.Windows.Forms.Button()
        Me.txt_EmiOffset = New System.Windows.Forms.TextBox()
        Me.txt_EmiGain = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.btn_Get_Ver = New System.Windows.Forms.Button()
        Me.txt_FirmVer = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_ParamReadAll = New System.Windows.Forms.Button()
        Me.BtnSupCAL = New System.Windows.Forms.Button()
        Me.BtnCalStop = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BtnExtrCAL = New System.Windows.Forms.Button()
        Me.Set_Value_Enable = New System.Windows.Forms.CheckBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Hearter_VMoni = New System.Windows.Forms.TextBox()
        Me.Extractor_VMoni = New System.Windows.Forms.TextBox()
        Me.Suppressor_VMoni = New System.Windows.Forms.TextBox()
        Me.Lens2_VMoni = New System.Windows.Forms.TextBox()
        Me.Lens1n_VMoni = New System.Windows.Forms.TextBox()
        Me.Lens1p_VMoni = New System.Windows.Forms.TextBox()
        Me.Beam_VMoni = New System.Windows.Forms.TextBox()
        Me.txt_ExtVGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_ExtVOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_SupVOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_SupVGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_ExtVGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_ExtVOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_SupVOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_SupVGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_HtrVGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_L2VOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_HtrVOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_L2VGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_HtrVGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_L2VOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_HtrVOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_L2VGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_L1nVOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_L1nVGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_L1nVOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_L1nVGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_L1pVOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_L1pVGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_L1pVOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_L1pVGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_BeamVOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_BeamVGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_BeamVOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_BeamVGain_ADC = New System.Windows.Forms.TextBox()
        Me.btn_HeaterVOffset_Read = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btn_SupVOffset_Read = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btn_ExtVGain_Set = New System.Windows.Forms.Button()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.btn_SupVGain_Read = New System.Windows.Forms.Button()
        Me.btn_ExtVOffset_Set = New System.Windows.Forms.Button()
        Me.btn_SupVOffset_Set = New System.Windows.Forms.Button()
        Me.btn_ExtVGain_Read = New System.Windows.Forms.Button()
        Me.btn_SupVGain_Set = New System.Windows.Forms.Button()
        Me.btn_ExtVOffset_Read = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btn_Lens2VOffset_Read = New System.Windows.Forms.Button()
        Me.btn_Lens2VGain_Read = New System.Windows.Forms.Button()
        Me.btn_HeaterVGain_Set = New System.Windows.Forms.Button()
        Me.btn_HeaterVOffset_Set = New System.Windows.Forms.Button()
        Me.btn_Lens2VOffset_Set = New System.Windows.Forms.Button()
        Me.btn_Lens2VGain_Set = New System.Windows.Forms.Button()
        Me.btn_HeaterVGain_Read = New System.Windows.Forms.Button()
        Me.btn_Lens1nVOffset_Read = New System.Windows.Forms.Button()
        Me.btn_Lens1nVGain_Read = New System.Windows.Forms.Button()
        Me.btn_Lens1nVOffset_Set = New System.Windows.Forms.Button()
        Me.btn_Lens1nVGain_Set = New System.Windows.Forms.Button()
        Me.btn_Lens1pVOffset_Read = New System.Windows.Forms.Button()
        Me.btn_Lens1pVGain_Read = New System.Windows.Forms.Button()
        Me.btn_Lens1pVGain_Set = New System.Windows.Forms.Button()
        Me.btn_BeamVOffset_Read = New System.Windows.Forms.Button()
        Me.btn_BeamVGain_Read = New System.Windows.Forms.Button()
        Me.btn_BeamVOffset_Set = New System.Windows.Forms.Button()
        Me.btn_BeamVGain_Set = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btn_Lens1pVOffset_Set = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Hearter_IMoni = New System.Windows.Forms.TextBox()
        Me.Extractor_IMoni = New System.Windows.Forms.TextBox()
        Me.Suppressor_IMoni = New System.Windows.Forms.TextBox()
        Me.Lens2_IMoni = New System.Windows.Forms.TextBox()
        Me.Lens1n_IMoni = New System.Windows.Forms.TextBox()
        Me.Lens1p_IMoni = New System.Windows.Forms.TextBox()
        Me.Beam_IMoni = New System.Windows.Forms.TextBox()
        Me.txt_ExtIGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_ExtIOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_SupIOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_BeamIGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_SupIGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_ExtIGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_BeamIOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_ExtIOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_SupIOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_BeamIGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_SupIGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_BeamIOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_HtrIGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_L1pIGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_L2IOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_L1pIOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_HtrIOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_L1pIGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_L2IGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_L1pIOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_L1nIGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_HtrIGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_L1nIOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_L2IOffset_ADC = New System.Windows.Forms.TextBox()
        Me.txt_L1nIGain_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_HtrIOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.txt_L2IGain_ADC = New System.Windows.Forms.TextBox()
        Me.txt_L1nIOffset_ADC_R = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.btn_SupIOffset_Read = New System.Windows.Forms.Button()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.btn_ExtIGain_Set = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.btn_SupIGain_Read = New System.Windows.Forms.Button()
        Me.btn_Lens1pIOffset_Set = New System.Windows.Forms.Button()
        Me.btn_ExtIOffset_Set = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btn_SupIOffset_Set = New System.Windows.Forms.Button()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.btn_ExtIGain_Read = New System.Windows.Forms.Button()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.btn_SupIGain_Set = New System.Windows.Forms.Button()
        Me.btn_BeamIGain_Set = New System.Windows.Forms.Button()
        Me.btn_BeamIOffset_Set = New System.Windows.Forms.Button()
        Me.btn_ExtIOffset_Read = New System.Windows.Forms.Button()
        Me.btn_BeamIGain_Read = New System.Windows.Forms.Button()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.btn_Lens2IOffset_Read = New System.Windows.Forms.Button()
        Me.btn_BeamIOffset_Read = New System.Windows.Forms.Button()
        Me.btn_Lens1pIGain_Set = New System.Windows.Forms.Button()
        Me.btn_Lens2IGain_Read = New System.Windows.Forms.Button()
        Me.btn_HeaterIGain_Set = New System.Windows.Forms.Button()
        Me.btn_Lens1pIGain_Read = New System.Windows.Forms.Button()
        Me.btn_HeaterIOffset_Set = New System.Windows.Forms.Button()
        Me.btn_Lens1pIOffset_Read = New System.Windows.Forms.Button()
        Me.btn_Lens2IOffset_Set = New System.Windows.Forms.Button()
        Me.btn_Lens2IGain_Set = New System.Windows.Forms.Button()
        Me.btn_Lens1nIGain_Set = New System.Windows.Forms.Button()
        Me.btn_HeaterIGain_Read = New System.Windows.Forms.Button()
        Me.btn_Lens1nIOffset_Set = New System.Windows.Forms.Button()
        Me.btn_Lens1nIGain_Read = New System.Windows.Forms.Button()
        Me.btn_HeaterIOffset_Read = New System.Windows.Forms.Button()
        Me.btn_Lens1nIOffset_Read = New System.Windows.Forms.Button()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.Btn_ECLim = New System.Windows.Forms.Button()
        Me.NuExtCurrentLim = New System.Windows.Forms.NumericUpDown()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbEmissionControl = New System.Windows.Forms.CheckBox()
        Me.nuEmissionControl = New System.Windows.Forms.NumericUpDown()
        Me.rbOn = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbLog = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox0 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.cbReadBack = New System.Windows.Forms.CheckBox()
        Me.bReadBack = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox0 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nuSuppressor = New System.Windows.Forms.NumericUpDown()
        Me.nuLens1 = New System.Windows.Forms.NumericUpDown()
        Me.nuLens2 = New System.Windows.Forms.NumericUpDown()
        Me.nuFilamentHeater = New System.Windows.Forms.NumericUpDown()
        Me.nuExtractor = New System.Windows.Forms.NumericUpDown()
        Me.nuBeamEnergy = New System.Windows.Forms.NumericUpDown()
        Me.nuWobble = New System.Windows.Forms.NumericUpDown()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Btn_EMS = New System.Windows.Forms.Button()
        Me.btn_DG406_Set = New System.Windows.Forms.Button()
        Me.btn_DG406_Read = New System.Windows.Forms.Button()
        Me.txt_DG406_R = New System.Windows.Forms.TextBox()
        Me.DG406_Sel = New System.Windows.Forms.ComboBox()
        Me.txt_DG406 = New System.Windows.Forms.TextBox()
        Me.txt_DG406_R2 = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txt_DG406_Speed = New System.Windows.Forms.TextBox()
        Me.DG406_Speed_Sel = New System.Windows.Forms.ComboBox()
        Me.btn_DG406_Speed = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBoxLogFile = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txt_DG406_SPEED_R2 = New System.Windows.Forms.TextBox()
        Me.txt_DG406_SPEED_R = New System.Windows.Forms.TextBox()
        Me.btn_DG406_Speed_Read = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtTestMsg = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.tbCheckExtr = New System.Windows.Forms.TextBox()
        Me.tbCheckSup = New System.Windows.Forms.TextBox()
        Me.tbCheckHeat = New System.Windows.Forms.TextBox()
        Me.btPass10 = New System.Windows.Forms.Button()
        Me.btPass9 = New System.Windows.Forms.Button()
        Me.btPass8 = New System.Windows.Forms.Button()
        Me.btPass7 = New System.Windows.Forms.Button()
        Me.btPass6 = New System.Windows.Forms.Button()
        Me.btPass5 = New System.Windows.Forms.Button()
        Me.btPass4 = New System.Windows.Forms.Button()
        Me.btPass3 = New System.Windows.Forms.Button()
        Me.btPass2 = New System.Windows.Forms.Button()
        Me.btPass1 = New System.Windows.Forms.Button()
        Me.rbFinal = New System.Windows.Forms.RadioButton()
        Me.rbPrePotting = New System.Windows.Forms.RadioButton()
        Me.btnTestRun = New System.Windows.Forms.Button()
        Me.btnTestAll = New System.Windows.Forms.Button()
        Me.cbTest10 = New System.Windows.Forms.CheckBox()
        Me.cbTest9 = New System.Windows.Forms.CheckBox()
        Me.cbTest6 = New System.Windows.Forms.CheckBox()
        Me.cbTest8 = New System.Windows.Forms.CheckBox()
        Me.cbTest7 = New System.Windows.Forms.CheckBox()
        Me.cbTest5 = New System.Windows.Forms.CheckBox()
        Me.cbTest4 = New System.Windows.Forms.CheckBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.tbSirialNum = New System.Windows.Forms.TextBox()
        Me.cbTest1 = New System.Windows.Forms.CheckBox()
        Me.cbTest3 = New System.Windows.Forms.CheckBox()
        Me.cbTest2 = New System.Windows.Forms.CheckBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.BtnVisaOpen = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.BtnReadDmm = New System.Windows.Forms.Button()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.BtnReadDmm8 = New System.Windows.Forms.Button()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.TextBoxReadDmm = New System.Windows.Forms.TextBox()
        Me.TextBoxProofreading = New System.Windows.Forms.TextBox()
        Me.TextBoxDCV = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.BtnVisaClose = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.TextBoxHV40k = New System.Windows.Forms.TextBox()
        Me.TextBoxHV30k = New System.Windows.Forms.TextBox()
        Me.TextBoxHV20k = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.TextBoxHV10k = New System.Windows.Forms.TextBox()
        Me.TextBoxVisaAdr = New System.Windows.Forms.TextBox()
        Me.BtnVisaSearch = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.BTAgingRunAgain = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.Label137 = New System.Windows.Forms.Label()
        Me.TBagingL2Ip = New System.Windows.Forms.TextBox()
        Me.TBagingL2Vp = New System.Windows.Forms.TextBox()
        Me.TBagingL1Ip = New System.Windows.Forms.TextBox()
        Me.TBagingL1Vp = New System.Windows.Forms.TextBox()
        Me.TBagingHVp = New System.Windows.Forms.TextBox()
        Me.TBagingHIp = New System.Windows.Forms.TextBox()
        Me.TBagingEIp = New System.Windows.Forms.TextBox()
        Me.TBagingEVp = New System.Windows.Forms.TextBox()
        Me.TBagingSIp = New System.Windows.Forms.TextBox()
        Me.TBagingSVp = New System.Windows.Forms.TextBox()
        Me.TBagingBIp = New System.Windows.Forms.TextBox()
        Me.TBagingBVp = New System.Windows.Forms.TextBox()
        Me.TBkeika = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RBPrepotAging = New System.Windows.Forms.RadioButton()
        Me.RBFinalAging = New System.Windows.Forms.RadioButton()
        Me.TBagingBeam = New System.Windows.Forms.TextBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.TBagingSup = New System.Windows.Forms.TextBox()
        Me.TBagingExt = New System.Windows.Forms.TextBox()
        Me.TBagingHeat = New System.Windows.Forms.TextBox()
        Me.TBagingL1 = New System.Windows.Forms.TextBox()
        Me.TBagingL2 = New System.Windows.Forms.TextBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.TBagingL2I = New System.Windows.Forms.TextBox()
        Me.TBagingL2I1 = New System.Windows.Forms.TextBox()
        Me.TBagingL1I = New System.Windows.Forms.TextBox()
        Me.TBagingL1I1 = New System.Windows.Forms.TextBox()
        Me.TBagingHV = New System.Windows.Forms.TextBox()
        Me.TBagingHV1 = New System.Windows.Forms.TextBox()
        Me.TBagingEI = New System.Windows.Forms.TextBox()
        Me.TBagingEI1 = New System.Windows.Forms.TextBox()
        Me.TBagingSI = New System.Windows.Forms.TextBox()
        Me.TBagingSI1 = New System.Windows.Forms.TextBox()
        Me.TBagingBI = New System.Windows.Forms.TextBox()
        Me.TBagingBI1 = New System.Windows.Forms.TextBox()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.TBagingL2V = New System.Windows.Forms.TextBox()
        Me.TBagingL1V = New System.Windows.Forms.TextBox()
        Me.TBagingHI = New System.Windows.Forms.TextBox()
        Me.TBagingEV = New System.Windows.Forms.TextBox()
        Me.TBagingSV = New System.Windows.Forms.TextBox()
        Me.TBagingBV = New System.Windows.Forms.TextBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.TBagingL2V1 = New System.Windows.Forms.TextBox()
        Me.TBagingL1V1 = New System.Windows.Forms.TextBox()
        Me.TBagingHI1 = New System.Windows.Forms.TextBox()
        Me.TBagingEV1 = New System.Windows.Forms.TextBox()
        Me.TBagingSV1 = New System.Windows.Forms.TextBox()
        Me.TBagingBV1 = New System.Windows.Forms.TextBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.TB_date2 = New System.Windows.Forms.TextBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.TB_date = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.TBagingTime = New System.Windows.Forms.TextBox()
        Me.BTagingRun = New System.Windows.Forms.Button()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.tbSerialNum2 = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.TB_dmm = New System.Windows.Forms.TextBox()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.BtnTEMP = New System.Windows.Forms.Button()
        Me.tbAmbTemp = New System.Windows.Forms.TextBox()
        Me.arRS232 = New System.IO.Ports.SerialPort(Me.components)
        Me.tbAmbHumidity = New System.Windows.Forms.TextBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.NuExtCurrentLim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuEmissionControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuSuppressor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuLens1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuLens2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuFilamentHeater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuExtractor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuBeamEnergy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuWobble, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'cPortSel
        '
        Me.cPortSel.FormattingEnabled = True
        Me.cPortSel.Location = New System.Drawing.Point(119, 1)
        Me.cPortSel.Name = "cPortSel"
        Me.cPortSel.Size = New System.Drawing.Size(89, 21)
        Me.cPortSel.TabIndex = 8
        '
        'bPortClose
        '
        Me.bPortClose.Enabled = False
        Me.bPortClose.Location = New System.Drawing.Point(220, 29)
        Me.bPortClose.Name = "bPortClose"
        Me.bPortClose.Size = New System.Drawing.Size(108, 21)
        Me.bPortClose.TabIndex = 6
        Me.bPortClose.Text = "PORT CLOSE"
        Me.bPortClose.UseVisualStyleBackColor = True
        '
        'bPortOpen
        '
        Me.bPortOpen.Location = New System.Drawing.Point(220, 1)
        Me.bPortOpen.Name = "bPortOpen"
        Me.bPortOpen.Size = New System.Drawing.Size(108, 21)
        Me.bPortOpen.TabIndex = 7
        Me.bPortOpen.Text = "PORT OPEN"
        Me.bPortOpen.UseVisualStyleBackColor = True
        '
        'bInitialize
        '
        Me.bInitialize.Enabled = False
        Me.bInitialize.Location = New System.Drawing.Point(346, 1)
        Me.bInitialize.Name = "bInitialize"
        Me.bInitialize.Size = New System.Drawing.Size(104, 21)
        Me.bInitialize.TabIndex = 11
        Me.bInitialize.Text = "Initialize"
        Me.bInitialize.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label86)
        Me.GroupBox10.Controls.Add(Me.TBoxErrCont)
        Me.GroupBox10.Controls.Add(Me.bSend)
        Me.GroupBox10.Controls.Add(Me.tbSend)
        Me.GroupBox10.Controls.Add(Me.tbShowRawSend)
        Me.GroupBox10.Controls.Add(Me.tbShowRawReceive)
        Me.GroupBox10.Controls.Add(Me.Label28)
        Me.GroupBox10.Controls.Add(Me.Label27)
        Me.GroupBox10.Location = New System.Drawing.Point(19, 382)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(614, 79)
        Me.GroupBox10.TabIndex = 162
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Direct Command"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(63, 51)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(107, 13)
        Me.Label86.TabIndex = 20
        Me.Label86.Text = "COM Err Counter"
        '
        'TBoxErrCont
        '
        Me.TBoxErrCont.Location = New System.Drawing.Point(182, 48)
        Me.TBoxErrCont.Name = "TBoxErrCont"
        Me.TBoxErrCont.Size = New System.Drawing.Size(67, 20)
        Me.TBoxErrCont.TabIndex = 19
        Me.TBoxErrCont.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bSend
        '
        Me.bSend.Enabled = False
        Me.bSend.Location = New System.Drawing.Point(255, 22)
        Me.bSend.Name = "bSend"
        Me.bSend.Size = New System.Drawing.Size(70, 21)
        Me.bSend.TabIndex = 16
        Me.bSend.Text = "Send TX RawData"
        Me.bSend.UseVisualStyleBackColor = True
        '
        'tbSend
        '
        Me.tbSend.Location = New System.Drawing.Point(44, 22)
        Me.tbSend.Name = "tbSend"
        Me.tbSend.Size = New System.Drawing.Size(205, 20)
        Me.tbSend.TabIndex = 15
        '
        'tbShowRawSend
        '
        Me.tbShowRawSend.Location = New System.Drawing.Point(383, 16)
        Me.tbShowRawSend.Name = "tbShowRawSend"
        Me.tbShowRawSend.ReadOnly = True
        Me.tbShowRawSend.Size = New System.Drawing.Size(201, 20)
        Me.tbShowRawSend.TabIndex = 13
        '
        'tbShowRawReceive
        '
        Me.tbShowRawReceive.Location = New System.Drawing.Point(383, 40)
        Me.tbShowRawReceive.Name = "tbShowRawReceive"
        Me.tbShowRawReceive.ReadOnly = True
        Me.tbShowRawReceive.Size = New System.Drawing.Size(201, 20)
        Me.tbShowRawReceive.TabIndex = 14
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(352, 44)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(23, 13)
        Me.Label28.TabIndex = 18
        Me.Label28.Text = "RX"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(353, 20)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(23, 13)
        Me.Label27.TabIndex = 17
        Me.Label27.Text = "TX"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(33, 7)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(72, 13)
        Me.Label46.TabIndex = 19
        Me.Label46.Text = "COM PORT"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(22, 33)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(91, 13)
        Me.Label47.TabIndex = 20
        Me.Label47.Text = "Ambient Temp."
        '
        'bShutDown
        '
        Me.bShutDown.Location = New System.Drawing.Point(464, 1)
        Me.bShutDown.Name = "bShutDown"
        Me.bShutDown.Size = New System.Drawing.Size(157, 38)
        Me.bShutDown.TabIndex = 21
        Me.bShutDown.Text = "Shut Down"
        Me.bShutDown.UseVisualStyleBackColor = True
        '
        'bSystem
        '
        Me.bSystem.Enabled = False
        Me.bSystem.Location = New System.Drawing.Point(346, 28)
        Me.bSystem.Name = "bSystem"
        Me.bSystem.Size = New System.Drawing.Size(104, 22)
        Me.bSystem.TabIndex = 183
        Me.bSystem.Text = "System"
        Me.bSystem.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'myRS232
        '
        Me.myRS232.ReadTimeout = 50
        Me.myRS232.WriteBufferSize = 4096
        Me.myRS232.WriteTimeout = 50
        '
        'txt_BeamGain
        '
        Me.txt_BeamGain.Location = New System.Drawing.Point(73, 96)
        Me.txt_BeamGain.Name = "txt_BeamGain"
        Me.txt_BeamGain.Size = New System.Drawing.Size(52, 20)
        Me.txt_BeamGain.TabIndex = 184
        Me.txt_BeamGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 185
        Me.Label8.Text = "BeamPS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 187
        Me.Label9.Text = "Lens1PS +"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(86, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 39)
        Me.Label11.TabIndex = 188
        Me.Label11.Text = "Gain α" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9000～11000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10000=1.0000"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(209, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 26)
        Me.Label12.TabIndex = 189
        Me.Label12.Text = "Offset β" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-1000～1000"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1, 230)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 190
        Me.Label13.Text = "Lens1PS -"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 287)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 191
        Me.Label14.Text = "Lens2PS"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 342)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 192
        Me.Label15.Text = "SupPS"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 399)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 13)
        Me.Label16.TabIndex = 193
        Me.Label16.Text = "ExtPS"
        '
        'txt_BeamOffset
        '
        Me.txt_BeamOffset.Location = New System.Drawing.Point(199, 96)
        Me.txt_BeamOffset.Name = "txt_BeamOffset"
        Me.txt_BeamOffset.Size = New System.Drawing.Size(52, 20)
        Me.txt_BeamOffset.TabIndex = 194
        Me.txt_BeamOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_BeamGain_Set
        '
        Me.btn_BeamGain_Set.Location = New System.Drawing.Point(132, 96)
        Me.btn_BeamGain_Set.Name = "btn_BeamGain_Set"
        Me.btn_BeamGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_BeamGain_Set.TabIndex = 195
        Me.btn_BeamGain_Set.Text = "Set"
        Me.btn_BeamGain_Set.UseVisualStyleBackColor = True
        '
        'btn_BeamOffset_Set
        '
        Me.btn_BeamOffset_Set.Location = New System.Drawing.Point(258, 96)
        Me.btn_BeamOffset_Set.Name = "btn_BeamOffset_Set"
        Me.btn_BeamOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_BeamOffset_Set.TabIndex = 196
        Me.btn_BeamOffset_Set.Text = "Set"
        Me.btn_BeamOffset_Set.UseVisualStyleBackColor = True
        '
        'txt_BeamGain_R
        '
        Me.txt_BeamGain_R.Enabled = False
        Me.txt_BeamGain_R.Location = New System.Drawing.Point(73, 119)
        Me.txt_BeamGain_R.Name = "txt_BeamGain_R"
        Me.txt_BeamGain_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_BeamGain_R.TabIndex = 197
        Me.txt_BeamGain_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_BeamGain_Read
        '
        Me.btn_BeamGain_Read.Location = New System.Drawing.Point(132, 120)
        Me.btn_BeamGain_Read.Name = "btn_BeamGain_Read"
        Me.btn_BeamGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_BeamGain_Read.TabIndex = 198
        Me.btn_BeamGain_Read.Text = "Read"
        Me.btn_BeamGain_Read.UseVisualStyleBackColor = True
        '
        'btn_BeamOffset_Read
        '
        Me.btn_BeamOffset_Read.Location = New System.Drawing.Point(258, 120)
        Me.btn_BeamOffset_Read.Name = "btn_BeamOffset_Read"
        Me.btn_BeamOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_BeamOffset_Read.TabIndex = 200
        Me.btn_BeamOffset_Read.Text = "Read"
        Me.btn_BeamOffset_Read.UseVisualStyleBackColor = True
        '
        'txt_BeamOffset_R
        '
        Me.txt_BeamOffset_R.Enabled = False
        Me.txt_BeamOffset_R.Location = New System.Drawing.Point(199, 119)
        Me.txt_BeamOffset_R.Name = "txt_BeamOffset_R"
        Me.txt_BeamOffset_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_BeamOffset_R.TabIndex = 199
        Me.txt_BeamOffset_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Lens1pOffset_Read
        '
        Me.btn_Lens1pOffset_Read.Location = New System.Drawing.Point(258, 178)
        Me.btn_Lens1pOffset_Read.Name = "btn_Lens1pOffset_Read"
        Me.btn_Lens1pOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1pOffset_Read.TabIndex = 208
        Me.btn_Lens1pOffset_Read.Text = "Read"
        Me.btn_Lens1pOffset_Read.UseVisualStyleBackColor = True
        '
        'txt_L1pOffset_R
        '
        Me.txt_L1pOffset_R.Enabled = False
        Me.txt_L1pOffset_R.Location = New System.Drawing.Point(199, 177)
        Me.txt_L1pOffset_R.Name = "txt_L1pOffset_R"
        Me.txt_L1pOffset_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1pOffset_R.TabIndex = 207
        Me.txt_L1pOffset_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Lens1pGain_Read
        '
        Me.btn_Lens1pGain_Read.Location = New System.Drawing.Point(132, 178)
        Me.btn_Lens1pGain_Read.Name = "btn_Lens1pGain_Read"
        Me.btn_Lens1pGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1pGain_Read.TabIndex = 206
        Me.btn_Lens1pGain_Read.Text = "Read"
        Me.btn_Lens1pGain_Read.UseVisualStyleBackColor = True
        '
        'txt_L1pGain_R
        '
        Me.txt_L1pGain_R.Enabled = False
        Me.txt_L1pGain_R.Location = New System.Drawing.Point(73, 177)
        Me.txt_L1pGain_R.Name = "txt_L1pGain_R"
        Me.txt_L1pGain_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1pGain_R.TabIndex = 205
        Me.txt_L1pGain_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Lens1pOffset_Set
        '
        Me.btn_Lens1pOffset_Set.Location = New System.Drawing.Point(259, 151)
        Me.btn_Lens1pOffset_Set.Name = "btn_Lens1pOffset_Set"
        Me.btn_Lens1pOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1pOffset_Set.TabIndex = 204
        Me.btn_Lens1pOffset_Set.Text = "Set"
        Me.btn_Lens1pOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens1pGain_Set
        '
        Me.btn_Lens1pGain_Set.Location = New System.Drawing.Point(132, 154)
        Me.btn_Lens1pGain_Set.Name = "btn_Lens1pGain_Set"
        Me.btn_Lens1pGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1pGain_Set.TabIndex = 203
        Me.btn_Lens1pGain_Set.Text = "Set"
        Me.btn_Lens1pGain_Set.UseVisualStyleBackColor = True
        '
        'txt_L1pOffset
        '
        Me.txt_L1pOffset.Location = New System.Drawing.Point(199, 155)
        Me.txt_L1pOffset.Name = "txt_L1pOffset"
        Me.txt_L1pOffset.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1pOffset.TabIndex = 202
        Me.txt_L1pOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1pGain
        '
        Me.txt_L1pGain.Location = New System.Drawing.Point(73, 154)
        Me.txt_L1pGain.Name = "txt_L1pGain"
        Me.txt_L1pGain.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1pGain.TabIndex = 201
        Me.txt_L1pGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Lens1nOffset_Read
        '
        Me.btn_Lens1nOffset_Read.Location = New System.Drawing.Point(258, 237)
        Me.btn_Lens1nOffset_Read.Name = "btn_Lens1nOffset_Read"
        Me.btn_Lens1nOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1nOffset_Read.TabIndex = 216
        Me.btn_Lens1nOffset_Read.Text = "Read"
        Me.btn_Lens1nOffset_Read.UseVisualStyleBackColor = True
        '
        'txt_L1nOffset_R
        '
        Me.txt_L1nOffset_R.Enabled = False
        Me.txt_L1nOffset_R.Location = New System.Drawing.Point(199, 236)
        Me.txt_L1nOffset_R.Name = "txt_L1nOffset_R"
        Me.txt_L1nOffset_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1nOffset_R.TabIndex = 215
        Me.txt_L1nOffset_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Lens1nGain_Read
        '
        Me.btn_Lens1nGain_Read.Location = New System.Drawing.Point(132, 237)
        Me.btn_Lens1nGain_Read.Name = "btn_Lens1nGain_Read"
        Me.btn_Lens1nGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1nGain_Read.TabIndex = 214
        Me.btn_Lens1nGain_Read.Text = "Read"
        Me.btn_Lens1nGain_Read.UseVisualStyleBackColor = True
        '
        'txt_L1nGain_R
        '
        Me.txt_L1nGain_R.Enabled = False
        Me.txt_L1nGain_R.Location = New System.Drawing.Point(73, 236)
        Me.txt_L1nGain_R.Name = "txt_L1nGain_R"
        Me.txt_L1nGain_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1nGain_R.TabIndex = 213
        Me.txt_L1nGain_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Lens1nOffset_Set
        '
        Me.btn_Lens1nOffset_Set.Location = New System.Drawing.Point(258, 213)
        Me.btn_Lens1nOffset_Set.Name = "btn_Lens1nOffset_Set"
        Me.btn_Lens1nOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1nOffset_Set.TabIndex = 212
        Me.btn_Lens1nOffset_Set.Text = "Set"
        Me.btn_Lens1nOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens1nGain_Set
        '
        Me.btn_Lens1nGain_Set.Location = New System.Drawing.Point(132, 213)
        Me.btn_Lens1nGain_Set.Name = "btn_Lens1nGain_Set"
        Me.btn_Lens1nGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1nGain_Set.TabIndex = 211
        Me.btn_Lens1nGain_Set.Text = "Set"
        Me.btn_Lens1nGain_Set.UseVisualStyleBackColor = True
        '
        'txt_L1nOffset
        '
        Me.txt_L1nOffset.Location = New System.Drawing.Point(199, 215)
        Me.txt_L1nOffset.Name = "txt_L1nOffset"
        Me.txt_L1nOffset.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1nOffset.TabIndex = 210
        Me.txt_L1nOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1nGain
        '
        Me.txt_L1nGain.Location = New System.Drawing.Point(73, 213)
        Me.txt_L1nGain.Name = "txt_L1nGain"
        Me.txt_L1nGain.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1nGain.TabIndex = 209
        Me.txt_L1nGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Lens2Offset_Read
        '
        Me.btn_Lens2Offset_Read.Location = New System.Drawing.Point(258, 295)
        Me.btn_Lens2Offset_Read.Name = "btn_Lens2Offset_Read"
        Me.btn_Lens2Offset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens2Offset_Read.TabIndex = 224
        Me.btn_Lens2Offset_Read.Text = "Read"
        Me.btn_Lens2Offset_Read.UseVisualStyleBackColor = True
        '
        'txt_L2Offset_R
        '
        Me.txt_L2Offset_R.Enabled = False
        Me.txt_L2Offset_R.Location = New System.Drawing.Point(199, 294)
        Me.txt_L2Offset_R.Name = "txt_L2Offset_R"
        Me.txt_L2Offset_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L2Offset_R.TabIndex = 223
        Me.txt_L2Offset_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Lens2Gain_Read
        '
        Me.btn_Lens2Gain_Read.Location = New System.Drawing.Point(132, 295)
        Me.btn_Lens2Gain_Read.Name = "btn_Lens2Gain_Read"
        Me.btn_Lens2Gain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens2Gain_Read.TabIndex = 222
        Me.btn_Lens2Gain_Read.Text = "Read"
        Me.btn_Lens2Gain_Read.UseVisualStyleBackColor = True
        '
        'txt_L2Gain_R
        '
        Me.txt_L2Gain_R.Enabled = False
        Me.txt_L2Gain_R.Location = New System.Drawing.Point(73, 294)
        Me.txt_L2Gain_R.Name = "txt_L2Gain_R"
        Me.txt_L2Gain_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L2Gain_R.TabIndex = 221
        Me.txt_L2Gain_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Lens2Offset_Set
        '
        Me.btn_Lens2Offset_Set.Location = New System.Drawing.Point(258, 271)
        Me.btn_Lens2Offset_Set.Name = "btn_Lens2Offset_Set"
        Me.btn_Lens2Offset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens2Offset_Set.TabIndex = 220
        Me.btn_Lens2Offset_Set.Text = "Set"
        Me.btn_Lens2Offset_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens2Gain_Set
        '
        Me.btn_Lens2Gain_Set.Location = New System.Drawing.Point(132, 271)
        Me.btn_Lens2Gain_Set.Name = "btn_Lens2Gain_Set"
        Me.btn_Lens2Gain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens2Gain_Set.TabIndex = 219
        Me.btn_Lens2Gain_Set.Text = "Set"
        Me.btn_Lens2Gain_Set.UseVisualStyleBackColor = True
        '
        'txt_L2Offset
        '
        Me.txt_L2Offset.Location = New System.Drawing.Point(199, 272)
        Me.txt_L2Offset.Name = "txt_L2Offset"
        Me.txt_L2Offset.Size = New System.Drawing.Size(52, 20)
        Me.txt_L2Offset.TabIndex = 218
        Me.txt_L2Offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L2Gain
        '
        Me.txt_L2Gain.Location = New System.Drawing.Point(73, 271)
        Me.txt_L2Gain.Name = "txt_L2Gain"
        Me.txt_L2Gain.Size = New System.Drawing.Size(52, 20)
        Me.txt_L2Gain.TabIndex = 217
        Me.txt_L2Gain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_SupOffset_Read
        '
        Me.btn_SupOffset_Read.Location = New System.Drawing.Point(258, 350)
        Me.btn_SupOffset_Read.Name = "btn_SupOffset_Read"
        Me.btn_SupOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_SupOffset_Read.TabIndex = 232
        Me.btn_SupOffset_Read.Text = "Read"
        Me.btn_SupOffset_Read.UseVisualStyleBackColor = True
        '
        'txt_SupOffset_R
        '
        Me.txt_SupOffset_R.Enabled = False
        Me.txt_SupOffset_R.Location = New System.Drawing.Point(199, 349)
        Me.txt_SupOffset_R.Name = "txt_SupOffset_R"
        Me.txt_SupOffset_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_SupOffset_R.TabIndex = 231
        Me.txt_SupOffset_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_SupGain_Read
        '
        Me.btn_SupGain_Read.Location = New System.Drawing.Point(132, 350)
        Me.btn_SupGain_Read.Name = "btn_SupGain_Read"
        Me.btn_SupGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_SupGain_Read.TabIndex = 230
        Me.btn_SupGain_Read.Text = "Read"
        Me.btn_SupGain_Read.UseVisualStyleBackColor = True
        '
        'txt_SupGain_R
        '
        Me.txt_SupGain_R.Enabled = False
        Me.txt_SupGain_R.Location = New System.Drawing.Point(73, 349)
        Me.txt_SupGain_R.Name = "txt_SupGain_R"
        Me.txt_SupGain_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_SupGain_R.TabIndex = 229
        Me.txt_SupGain_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_SupOffset_Set
        '
        Me.btn_SupOffset_Set.Location = New System.Drawing.Point(258, 326)
        Me.btn_SupOffset_Set.Name = "btn_SupOffset_Set"
        Me.btn_SupOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_SupOffset_Set.TabIndex = 228
        Me.btn_SupOffset_Set.Text = "Set"
        Me.btn_SupOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_SupGain_Set
        '
        Me.btn_SupGain_Set.Location = New System.Drawing.Point(132, 326)
        Me.btn_SupGain_Set.Name = "btn_SupGain_Set"
        Me.btn_SupGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_SupGain_Set.TabIndex = 227
        Me.btn_SupGain_Set.Text = "Set"
        Me.btn_SupGain_Set.UseVisualStyleBackColor = True
        '
        'txt_SupOffset
        '
        Me.txt_SupOffset.Location = New System.Drawing.Point(199, 327)
        Me.txt_SupOffset.Name = "txt_SupOffset"
        Me.txt_SupOffset.Size = New System.Drawing.Size(52, 20)
        Me.txt_SupOffset.TabIndex = 226
        Me.txt_SupOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SupGain
        '
        Me.txt_SupGain.Location = New System.Drawing.Point(73, 326)
        Me.txt_SupGain.Name = "txt_SupGain"
        Me.txt_SupGain.Size = New System.Drawing.Size(52, 20)
        Me.txt_SupGain.TabIndex = 225
        Me.txt_SupGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_ExtOffset_Read
        '
        Me.btn_ExtOffset_Read.Location = New System.Drawing.Point(258, 407)
        Me.btn_ExtOffset_Read.Name = "btn_ExtOffset_Read"
        Me.btn_ExtOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_ExtOffset_Read.TabIndex = 240
        Me.btn_ExtOffset_Read.Text = "Read"
        Me.btn_ExtOffset_Read.UseVisualStyleBackColor = True
        '
        'txt_ExtOffset_R
        '
        Me.txt_ExtOffset_R.Enabled = False
        Me.txt_ExtOffset_R.Location = New System.Drawing.Point(199, 406)
        Me.txt_ExtOffset_R.Name = "txt_ExtOffset_R"
        Me.txt_ExtOffset_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_ExtOffset_R.TabIndex = 239
        Me.txt_ExtOffset_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_ExtGain_Read
        '
        Me.btn_ExtGain_Read.Location = New System.Drawing.Point(132, 407)
        Me.btn_ExtGain_Read.Name = "btn_ExtGain_Read"
        Me.btn_ExtGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_ExtGain_Read.TabIndex = 238
        Me.btn_ExtGain_Read.Text = "Read"
        Me.btn_ExtGain_Read.UseVisualStyleBackColor = True
        '
        'txt_ExtGain_R
        '
        Me.txt_ExtGain_R.Enabled = False
        Me.txt_ExtGain_R.Location = New System.Drawing.Point(73, 406)
        Me.txt_ExtGain_R.Name = "txt_ExtGain_R"
        Me.txt_ExtGain_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_ExtGain_R.TabIndex = 237
        Me.txt_ExtGain_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_ExtOffset_Set
        '
        Me.btn_ExtOffset_Set.Location = New System.Drawing.Point(258, 384)
        Me.btn_ExtOffset_Set.Name = "btn_ExtOffset_Set"
        Me.btn_ExtOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_ExtOffset_Set.TabIndex = 236
        Me.btn_ExtOffset_Set.Text = "Set"
        Me.btn_ExtOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_ExtGain_Set
        '
        Me.btn_ExtGain_Set.Location = New System.Drawing.Point(132, 384)
        Me.btn_ExtGain_Set.Name = "btn_ExtGain_Set"
        Me.btn_ExtGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_ExtGain_Set.TabIndex = 235
        Me.btn_ExtGain_Set.Text = "Set"
        Me.btn_ExtGain_Set.UseVisualStyleBackColor = True
        '
        'txt_ExtOffset
        '
        Me.txt_ExtOffset.Location = New System.Drawing.Point(199, 385)
        Me.txt_ExtOffset.Name = "txt_ExtOffset"
        Me.txt_ExtOffset.Size = New System.Drawing.Size(52, 20)
        Me.txt_ExtOffset.TabIndex = 234
        Me.txt_ExtOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ExtGain
        '
        Me.txt_ExtGain.Location = New System.Drawing.Point(73, 384)
        Me.txt_ExtGain.Name = "txt_ExtGain"
        Me.txt_ExtGain.Size = New System.Drawing.Size(52, 20)
        Me.txt_ExtGain.TabIndex = 233
        Me.txt_ExtGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 455)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 13)
        Me.Label17.TabIndex = 241
        Me.Label17.Text = "HeaterPS"
        '
        'btn_HeaterOffset_Read
        '
        Me.btn_HeaterOffset_Read.Location = New System.Drawing.Point(258, 465)
        Me.btn_HeaterOffset_Read.Name = "btn_HeaterOffset_Read"
        Me.btn_HeaterOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_HeaterOffset_Read.TabIndex = 249
        Me.btn_HeaterOffset_Read.Text = "Read"
        Me.btn_HeaterOffset_Read.UseVisualStyleBackColor = True
        '
        'txt_HtrOffset_R
        '
        Me.txt_HtrOffset_R.Enabled = False
        Me.txt_HtrOffset_R.Location = New System.Drawing.Point(199, 464)
        Me.txt_HtrOffset_R.Name = "txt_HtrOffset_R"
        Me.txt_HtrOffset_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_HtrOffset_R.TabIndex = 248
        Me.txt_HtrOffset_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_HeaterGain_Read
        '
        Me.btn_HeaterGain_Read.Location = New System.Drawing.Point(132, 465)
        Me.btn_HeaterGain_Read.Name = "btn_HeaterGain_Read"
        Me.btn_HeaterGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_HeaterGain_Read.TabIndex = 247
        Me.btn_HeaterGain_Read.Text = "Read"
        Me.btn_HeaterGain_Read.UseVisualStyleBackColor = True
        '
        'txt_HtrGain_R
        '
        Me.txt_HtrGain_R.Enabled = False
        Me.txt_HtrGain_R.Location = New System.Drawing.Point(73, 464)
        Me.txt_HtrGain_R.Name = "txt_HtrGain_R"
        Me.txt_HtrGain_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_HtrGain_R.TabIndex = 246
        Me.txt_HtrGain_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_HeaterOffset_Set
        '
        Me.btn_HeaterOffset_Set.Location = New System.Drawing.Point(258, 441)
        Me.btn_HeaterOffset_Set.Name = "btn_HeaterOffset_Set"
        Me.btn_HeaterOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_HeaterOffset_Set.TabIndex = 245
        Me.btn_HeaterOffset_Set.Text = "Set"
        Me.btn_HeaterOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_HeaterGain_Set
        '
        Me.btn_HeaterGain_Set.Location = New System.Drawing.Point(132, 441)
        Me.btn_HeaterGain_Set.Name = "btn_HeaterGain_Set"
        Me.btn_HeaterGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_HeaterGain_Set.TabIndex = 244
        Me.btn_HeaterGain_Set.Text = "Set"
        Me.btn_HeaterGain_Set.UseVisualStyleBackColor = True
        '
        'txt_HtrOffset
        '
        Me.txt_HtrOffset.Location = New System.Drawing.Point(199, 442)
        Me.txt_HtrOffset.Name = "txt_HtrOffset"
        Me.txt_HtrOffset.Size = New System.Drawing.Size(52, 20)
        Me.txt_HtrOffset.TabIndex = 243
        Me.txt_HtrOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_HtrGain
        '
        Me.txt_HtrGain.Location = New System.Drawing.Point(73, 441)
        Me.txt_HtrGain.Name = "txt_HtrGain"
        Me.txt_HtrGain.Size = New System.Drawing.Size(52, 20)
        Me.txt_HtrGain.TabIndex = 242
        Me.txt_HtrGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(35, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 250
        Me.Label18.Text = "PWM"
        '
        'btn_PWM_Duty_Read
        '
        Me.btn_PWM_Duty_Read.Location = New System.Drawing.Point(215, 106)
        Me.btn_PWM_Duty_Read.Name = "btn_PWM_Duty_Read"
        Me.btn_PWM_Duty_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_PWM_Duty_Read.TabIndex = 258
        Me.btn_PWM_Duty_Read.Text = "Read"
        Me.btn_PWM_Duty_Read.UseVisualStyleBackColor = True
        '
        'txt_PWM_Duty_R
        '
        Me.txt_PWM_Duty_R.Enabled = False
        Me.txt_PWM_Duty_R.Location = New System.Drawing.Point(126, 105)
        Me.txt_PWM_Duty_R.Name = "txt_PWM_Duty_R"
        Me.txt_PWM_Duty_R.Size = New System.Drawing.Size(81, 20)
        Me.txt_PWM_Duty_R.TabIndex = 257
        Me.txt_PWM_Duty_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_PWM_Freq_Read
        '
        Me.btn_PWM_Freq_Read.Location = New System.Drawing.Point(215, 48)
        Me.btn_PWM_Freq_Read.Name = "btn_PWM_Freq_Read"
        Me.btn_PWM_Freq_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_PWM_Freq_Read.TabIndex = 256
        Me.btn_PWM_Freq_Read.Text = "Read"
        Me.btn_PWM_Freq_Read.UseVisualStyleBackColor = True
        '
        'txt_PWM_Freq_R
        '
        Me.txt_PWM_Freq_R.Enabled = False
        Me.txt_PWM_Freq_R.Location = New System.Drawing.Point(126, 47)
        Me.txt_PWM_Freq_R.Name = "txt_PWM_Freq_R"
        Me.txt_PWM_Freq_R.Size = New System.Drawing.Size(81, 20)
        Me.txt_PWM_Freq_R.TabIndex = 255
        Me.txt_PWM_Freq_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_PWM_Duty_Set
        '
        Me.btn_PWM_Duty_Set.Location = New System.Drawing.Point(215, 82)
        Me.btn_PWM_Duty_Set.Name = "btn_PWM_Duty_Set"
        Me.btn_PWM_Duty_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_PWM_Duty_Set.TabIndex = 254
        Me.btn_PWM_Duty_Set.Text = "Set"
        Me.btn_PWM_Duty_Set.UseVisualStyleBackColor = True
        '
        'btn_PWM_Freq_Set
        '
        Me.btn_PWM_Freq_Set.Location = New System.Drawing.Point(215, 24)
        Me.btn_PWM_Freq_Set.Name = "btn_PWM_Freq_Set"
        Me.btn_PWM_Freq_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_PWM_Freq_Set.TabIndex = 253
        Me.btn_PWM_Freq_Set.Text = "Set"
        Me.btn_PWM_Freq_Set.UseVisualStyleBackColor = True
        '
        'txt_PWM_Duty
        '
        Me.txt_PWM_Duty.Location = New System.Drawing.Point(126, 83)
        Me.txt_PWM_Duty.Name = "txt_PWM_Duty"
        Me.txt_PWM_Duty.Size = New System.Drawing.Size(81, 20)
        Me.txt_PWM_Duty.TabIndex = 252
        Me.txt_PWM_Duty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_PWM_Freq
        '
        Me.txt_PWM_Freq.Location = New System.Drawing.Point(126, 24)
        Me.txt_PWM_Freq.Name = "txt_PWM_Freq"
        Me.txt_PWM_Freq.Size = New System.Drawing.Size(81, 20)
        Me.txt_PWM_Freq.TabIndex = 251
        Me.txt_PWM_Freq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_PWM_DT_Read
        '
        Me.btn_PWM_DT_Read.Location = New System.Drawing.Point(215, 163)
        Me.btn_PWM_DT_Read.Name = "btn_PWM_DT_Read"
        Me.btn_PWM_DT_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_PWM_DT_Read.TabIndex = 262
        Me.btn_PWM_DT_Read.Text = "Read"
        Me.btn_PWM_DT_Read.UseVisualStyleBackColor = True
        '
        'txt_PWM_DeadTime_R
        '
        Me.txt_PWM_DeadTime_R.Enabled = False
        Me.txt_PWM_DeadTime_R.Location = New System.Drawing.Point(126, 161)
        Me.txt_PWM_DeadTime_R.Name = "txt_PWM_DeadTime_R"
        Me.txt_PWM_DeadTime_R.Size = New System.Drawing.Size(81, 20)
        Me.txt_PWM_DeadTime_R.TabIndex = 261
        Me.txt_PWM_DeadTime_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_PWM_DT_Set
        '
        Me.btn_PWM_DT_Set.Location = New System.Drawing.Point(215, 139)
        Me.btn_PWM_DT_Set.Name = "btn_PWM_DT_Set"
        Me.btn_PWM_DT_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_PWM_DT_Set.TabIndex = 260
        Me.btn_PWM_DT_Set.Text = "Set"
        Me.btn_PWM_DT_Set.UseVisualStyleBackColor = True
        '
        'txt_PWM_DeadTime
        '
        Me.txt_PWM_DeadTime.Location = New System.Drawing.Point(126, 140)
        Me.txt_PWM_DeadTime.Name = "txt_PWM_DeadTime"
        Me.txt_PWM_DeadTime.Size = New System.Drawing.Size(81, 20)
        Me.txt_PWM_DeadTime.TabIndex = 259
        Me.txt_PWM_DeadTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(21, 49)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 263
        Me.Label19.Text = "Freq [kHz]"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(30, 105)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 13)
        Me.Label20.TabIndex = 264
        Me.Label20.Text = "Duty [%]"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 153)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 13)
        Me.Label21.TabIndex = 265
        Me.Label21.Text = "DeadTime [nsec]"
        '
        'btn_EmiOffset_R
        '
        Me.btn_EmiOffset_R.Location = New System.Drawing.Point(338, 530)
        Me.btn_EmiOffset_R.Name = "btn_EmiOffset_R"
        Me.btn_EmiOffset_R.Size = New System.Drawing.Size(50, 21)
        Me.btn_EmiOffset_R.TabIndex = 341
        Me.btn_EmiOffset_R.Text = "Read"
        Me.btn_EmiOffset_R.UseVisualStyleBackColor = True
        '
        'txt_EmiOffset_R
        '
        Me.txt_EmiOffset_R.Enabled = False
        Me.txt_EmiOffset_R.Location = New System.Drawing.Point(250, 529)
        Me.txt_EmiOffset_R.Name = "txt_EmiOffset_R"
        Me.txt_EmiOffset_R.Size = New System.Drawing.Size(81, 20)
        Me.txt_EmiOffset_R.TabIndex = 340
        Me.txt_EmiOffset_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_EmiGain_R
        '
        Me.btn_EmiGain_R.Location = New System.Drawing.Point(190, 530)
        Me.btn_EmiGain_R.Name = "btn_EmiGain_R"
        Me.btn_EmiGain_R.Size = New System.Drawing.Size(50, 21)
        Me.btn_EmiGain_R.TabIndex = 339
        Me.btn_EmiGain_R.Text = "Read"
        Me.btn_EmiGain_R.UseVisualStyleBackColor = True
        '
        'txt_EmiGain_R
        '
        Me.txt_EmiGain_R.Enabled = False
        Me.txt_EmiGain_R.Location = New System.Drawing.Point(101, 529)
        Me.txt_EmiGain_R.Name = "txt_EmiGain_R"
        Me.txt_EmiGain_R.Size = New System.Drawing.Size(81, 20)
        Me.txt_EmiGain_R.TabIndex = 338
        Me.txt_EmiGain_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_EmiOffset_Set
        '
        Me.btn_EmiOffset_Set.Location = New System.Drawing.Point(338, 506)
        Me.btn_EmiOffset_Set.Name = "btn_EmiOffset_Set"
        Me.btn_EmiOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_EmiOffset_Set.TabIndex = 337
        Me.btn_EmiOffset_Set.Text = "Set"
        Me.btn_EmiOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_EmiGain_Set
        '
        Me.btn_EmiGain_Set.Location = New System.Drawing.Point(190, 506)
        Me.btn_EmiGain_Set.Name = "btn_EmiGain_Set"
        Me.btn_EmiGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_EmiGain_Set.TabIndex = 336
        Me.btn_EmiGain_Set.Text = "Set"
        Me.btn_EmiGain_Set.UseVisualStyleBackColor = True
        '
        'txt_EmiOffset
        '
        Me.txt_EmiOffset.Location = New System.Drawing.Point(250, 507)
        Me.txt_EmiOffset.Name = "txt_EmiOffset"
        Me.txt_EmiOffset.Size = New System.Drawing.Size(81, 20)
        Me.txt_EmiOffset.TabIndex = 335
        Me.txt_EmiOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_EmiGain
        '
        Me.txt_EmiGain.Location = New System.Drawing.Point(101, 506)
        Me.txt_EmiGain.Name = "txt_EmiGain"
        Me.txt_EmiGain.Size = New System.Drawing.Size(81, 20)
        Me.txt_EmiGain.TabIndex = 334
        Me.txt_EmiGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(31, 520)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(60, 13)
        Me.Label35.TabIndex = 333
        Me.Label35.Text = "Emmision"
        '
        'btn_Get_Ver
        '
        Me.btn_Get_Ver.Enabled = False
        Me.btn_Get_Ver.Location = New System.Drawing.Point(724, 16)
        Me.btn_Get_Ver.Name = "btn_Get_Ver"
        Me.btn_Get_Ver.Size = New System.Drawing.Size(64, 21)
        Me.btn_Get_Ver.TabIndex = 343
        Me.btn_Get_Ver.Text = "Get"
        Me.btn_Get_Ver.UseVisualStyleBackColor = True
        '
        'txt_FirmVer
        '
        Me.txt_FirmVer.Location = New System.Drawing.Point(638, 16)
        Me.txt_FirmVer.Name = "txt_FirmVer"
        Me.txt_FirmVer.Size = New System.Drawing.Size(61, 20)
        Me.txt_FirmVer.TabIndex = 344
        Me.txt_FirmVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(656, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 13)
        Me.Label23.TabIndex = 345
        Me.Label23.Text = "Firmware Version"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_ParamReadAll)
        Me.GroupBox1.Controls.Add(Me.BtnSupCAL)
        Me.GroupBox1.Controls.Add(Me.BtnCalStop)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.BtnExtrCAL)
        Me.GroupBox1.Controls.Add(Me.Set_Value_Enable)
        Me.GroupBox1.Controls.Add(Me.TabControl)
        Me.GroupBox1.Controls.Add(Me.Label50)
        Me.GroupBox1.Controls.Add(Me.btn_Lens1pOffset_Set)
        Me.GroupBox1.Controls.Add(Me.btn_EmiGain_Set)
        Me.GroupBox1.Controls.Add(Me.txt_BeamGain)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.btn_EmiOffset_R)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_EmiOffset_R)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btn_EmiGain_R)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_EmiGain_R)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.btn_EmiOffset_Set)
        Me.GroupBox1.Controls.Add(Me.txt_BeamOffset)
        Me.GroupBox1.Controls.Add(Me.btn_BeamGain_Set)
        Me.GroupBox1.Controls.Add(Me.txt_EmiOffset)
        Me.GroupBox1.Controls.Add(Me.btn_BeamOffset_Set)
        Me.GroupBox1.Controls.Add(Me.txt_EmiGain)
        Me.GroupBox1.Controls.Add(Me.txt_BeamGain_R)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.btn_BeamGain_Read)
        Me.GroupBox1.Controls.Add(Me.txt_BeamOffset_R)
        Me.GroupBox1.Controls.Add(Me.btn_BeamOffset_Read)
        Me.GroupBox1.Controls.Add(Me.txt_L1pGain)
        Me.GroupBox1.Controls.Add(Me.txt_L1pOffset)
        Me.GroupBox1.Controls.Add(Me.btn_Lens1pGain_Set)
        Me.GroupBox1.Controls.Add(Me.txt_L1pGain_R)
        Me.GroupBox1.Controls.Add(Me.btn_Lens1pGain_Read)
        Me.GroupBox1.Controls.Add(Me.txt_L1pOffset_R)
        Me.GroupBox1.Controls.Add(Me.btn_Lens1pOffset_Read)
        Me.GroupBox1.Controls.Add(Me.txt_L1nGain)
        Me.GroupBox1.Controls.Add(Me.txt_L1nOffset)
        Me.GroupBox1.Controls.Add(Me.btn_Lens1nGain_Set)
        Me.GroupBox1.Controls.Add(Me.btn_Lens1nOffset_Set)
        Me.GroupBox1.Controls.Add(Me.txt_L1nGain_R)
        Me.GroupBox1.Controls.Add(Me.btn_Lens1nGain_Read)
        Me.GroupBox1.Controls.Add(Me.txt_L1nOffset_R)
        Me.GroupBox1.Controls.Add(Me.btn_Lens1nOffset_Read)
        Me.GroupBox1.Controls.Add(Me.btn_HeaterOffset_Read)
        Me.GroupBox1.Controls.Add(Me.txt_L2Gain)
        Me.GroupBox1.Controls.Add(Me.txt_HtrOffset_R)
        Me.GroupBox1.Controls.Add(Me.txt_L2Offset)
        Me.GroupBox1.Controls.Add(Me.btn_HeaterGain_Read)
        Me.GroupBox1.Controls.Add(Me.btn_Lens2Gain_Set)
        Me.GroupBox1.Controls.Add(Me.txt_HtrGain_R)
        Me.GroupBox1.Controls.Add(Me.btn_Lens2Offset_Set)
        Me.GroupBox1.Controls.Add(Me.btn_HeaterOffset_Set)
        Me.GroupBox1.Controls.Add(Me.txt_L2Gain_R)
        Me.GroupBox1.Controls.Add(Me.btn_HeaterGain_Set)
        Me.GroupBox1.Controls.Add(Me.btn_Lens2Gain_Read)
        Me.GroupBox1.Controls.Add(Me.txt_HtrOffset)
        Me.GroupBox1.Controls.Add(Me.txt_L2Offset_R)
        Me.GroupBox1.Controls.Add(Me.txt_HtrGain)
        Me.GroupBox1.Controls.Add(Me.btn_Lens2Offset_Read)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txt_SupGain)
        Me.GroupBox1.Controls.Add(Me.btn_ExtOffset_Read)
        Me.GroupBox1.Controls.Add(Me.txt_SupOffset)
        Me.GroupBox1.Controls.Add(Me.txt_ExtOffset_R)
        Me.GroupBox1.Controls.Add(Me.btn_SupGain_Set)
        Me.GroupBox1.Controls.Add(Me.btn_ExtGain_Read)
        Me.GroupBox1.Controls.Add(Me.btn_SupOffset_Set)
        Me.GroupBox1.Controls.Add(Me.txt_ExtGain_R)
        Me.GroupBox1.Controls.Add(Me.txt_SupGain_R)
        Me.GroupBox1.Controls.Add(Me.btn_ExtOffset_Set)
        Me.GroupBox1.Controls.Add(Me.btn_SupGain_Read)
        Me.GroupBox1.Controls.Add(Me.btn_ExtGain_Set)
        Me.GroupBox1.Controls.Add(Me.txt_SupOffset_R)
        Me.GroupBox1.Controls.Add(Me.txt_ExtOffset)
        Me.GroupBox1.Controls.Add(Me.btn_SupOffset_Read)
        Me.GroupBox1.Controls.Add(Me.txt_ExtGain)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(967, 567)
        Me.GroupBox1.TabIndex = 346
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calibration"
        '
        'btn_ParamReadAll
        '
        Me.btn_ParamReadAll.Location = New System.Drawing.Point(7, 22)
        Me.btn_ParamReadAll.Name = "btn_ParamReadAll"
        Me.btn_ParamReadAll.Size = New System.Drawing.Size(85, 29)
        Me.btn_ParamReadAll.TabIndex = 499
        Me.btn_ParamReadAll.Text = "Read All"
        Me.btn_ParamReadAll.UseVisualStyleBackColor = True
        '
        'BtnSupCAL
        '
        Me.BtnSupCAL.BackColor = System.Drawing.Color.Transparent
        Me.BtnSupCAL.Enabled = False
        Me.BtnSupCAL.Location = New System.Drawing.Point(339, 327)
        Me.BtnSupCAL.Name = "BtnSupCAL"
        Me.BtnSupCAL.Size = New System.Drawing.Size(50, 21)
        Me.BtnSupCAL.TabIndex = 486
        Me.BtnSupCAL.Text = "Set"
        Me.BtnSupCAL.UseVisualStyleBackColor = False
        '
        'BtnCalStop
        '
        Me.BtnCalStop.BackColor = System.Drawing.Color.Transparent
        Me.BtnCalStop.Enabled = False
        Me.BtnCalStop.Location = New System.Drawing.Point(416, 525)
        Me.BtnCalStop.Name = "BtnCalStop"
        Me.BtnCalStop.Size = New System.Drawing.Size(110, 26)
        Me.BtnCalStop.TabIndex = 498
        Me.BtnCalStop.Text = "CAL STOP"
        Me.BtnCalStop.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(547, 525)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(413, 24)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 497
        '
        'BtnExtrCAL
        '
        Me.BtnExtrCAL.BackColor = System.Drawing.Color.Transparent
        Me.BtnExtrCAL.Enabled = False
        Me.BtnExtrCAL.Location = New System.Drawing.Point(339, 385)
        Me.BtnExtrCAL.Name = "BtnExtrCAL"
        Me.BtnExtrCAL.Size = New System.Drawing.Size(50, 21)
        Me.BtnExtrCAL.TabIndex = 485
        Me.BtnExtrCAL.Text = "CAL"
        Me.BtnExtrCAL.UseVisualStyleBackColor = False
        '
        'Set_Value_Enable
        '
        Me.Set_Value_Enable.AutoSize = True
        Me.Set_Value_Enable.Location = New System.Drawing.Point(271, 28)
        Me.Set_Value_Enable.Name = "Set_Value_Enable"
        Me.Set_Value_Enable.Size = New System.Drawing.Size(121, 17)
        Me.Set_Value_Enable.TabIndex = 484
        Me.Set_Value_Enable.Text = "Set Value Enable"
        Me.Set_Value_Enable.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.ItemSize = New System.Drawing.Size(80, 18)
        Me.TabControl.Location = New System.Drawing.Point(412, 13)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(552, 502)
        Me.TabControl.TabIndex = 483
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label53)
        Me.TabPage1.Controls.Add(Me.Hearter_VMoni)
        Me.TabPage1.Controls.Add(Me.Extractor_VMoni)
        Me.TabPage1.Controls.Add(Me.Suppressor_VMoni)
        Me.TabPage1.Controls.Add(Me.Lens2_VMoni)
        Me.TabPage1.Controls.Add(Me.Lens1n_VMoni)
        Me.TabPage1.Controls.Add(Me.Lens1p_VMoni)
        Me.TabPage1.Controls.Add(Me.Beam_VMoni)
        Me.TabPage1.Controls.Add(Me.txt_ExtVGain_ADC)
        Me.TabPage1.Controls.Add(Me.txt_ExtVOffset_ADC)
        Me.TabPage1.Controls.Add(Me.txt_SupVOffset_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_SupVGain_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_ExtVGain_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_ExtVOffset_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_SupVOffset_ADC)
        Me.TabPage1.Controls.Add(Me.txt_SupVGain_ADC)
        Me.TabPage1.Controls.Add(Me.txt_HtrVGain_ADC)
        Me.TabPage1.Controls.Add(Me.txt_L2VOffset_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_HtrVOffset_ADC)
        Me.TabPage1.Controls.Add(Me.txt_L2VGain_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_HtrVGain_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_L2VOffset_ADC)
        Me.TabPage1.Controls.Add(Me.txt_HtrVOffset_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_L2VGain_ADC)
        Me.TabPage1.Controls.Add(Me.txt_L1nVOffset_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_L1nVGain_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_L1nVOffset_ADC)
        Me.TabPage1.Controls.Add(Me.txt_L1nVGain_ADC)
        Me.TabPage1.Controls.Add(Me.txt_L1pVOffset_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_L1pVGain_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_L1pVOffset_ADC)
        Me.TabPage1.Controls.Add(Me.txt_L1pVGain_ADC)
        Me.TabPage1.Controls.Add(Me.txt_BeamVOffset_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_BeamVGain_ADC_R)
        Me.TabPage1.Controls.Add(Me.txt_BeamVOffset_ADC)
        Me.TabPage1.Controls.Add(Me.txt_BeamVGain_ADC)
        Me.TabPage1.Controls.Add(Me.btn_HeaterVOffset_Read)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.btn_SupVOffset_Read)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.btn_ExtVGain_Set)
        Me.TabPage1.Controls.Add(Me.Label51)
        Me.TabPage1.Controls.Add(Me.btn_SupVGain_Read)
        Me.TabPage1.Controls.Add(Me.btn_ExtVOffset_Set)
        Me.TabPage1.Controls.Add(Me.btn_SupVOffset_Set)
        Me.TabPage1.Controls.Add(Me.btn_ExtVGain_Read)
        Me.TabPage1.Controls.Add(Me.btn_SupVGain_Set)
        Me.TabPage1.Controls.Add(Me.btn_ExtVOffset_Read)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.btn_Lens2VOffset_Read)
        Me.TabPage1.Controls.Add(Me.btn_Lens2VGain_Read)
        Me.TabPage1.Controls.Add(Me.btn_HeaterVGain_Set)
        Me.TabPage1.Controls.Add(Me.btn_HeaterVOffset_Set)
        Me.TabPage1.Controls.Add(Me.btn_Lens2VOffset_Set)
        Me.TabPage1.Controls.Add(Me.btn_Lens2VGain_Set)
        Me.TabPage1.Controls.Add(Me.btn_HeaterVGain_Read)
        Me.TabPage1.Controls.Add(Me.btn_Lens1nVOffset_Read)
        Me.TabPage1.Controls.Add(Me.btn_Lens1nVGain_Read)
        Me.TabPage1.Controls.Add(Me.btn_Lens1nVOffset_Set)
        Me.TabPage1.Controls.Add(Me.btn_Lens1nVGain_Set)
        Me.TabPage1.Controls.Add(Me.btn_Lens1pVOffset_Read)
        Me.TabPage1.Controls.Add(Me.btn_Lens1pVGain_Read)
        Me.TabPage1.Controls.Add(Me.btn_Lens1pVGain_Set)
        Me.TabPage1.Controls.Add(Me.btn_BeamVOffset_Read)
        Me.TabPage1.Controls.Add(Me.btn_BeamVGain_Read)
        Me.TabPage1.Controls.Add(Me.btn_BeamVOffset_Set)
        Me.TabPage1.Controls.Add(Me.btn_BeamVGain_Set)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.btn_Lens1pVOffset_Set)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(544, 476)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Volt ADC"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Label53.Location = New System.Drawing.Point(393, 40)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(80, 22)
        Me.Label53.TabIndex = 489
        Me.Label53.Text = "Monitor"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Hearter_VMoni
        '
        Me.Hearter_VMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Hearter_VMoni.Location = New System.Drawing.Point(355, 419)
        Me.Hearter_VMoni.Name = "Hearter_VMoni"
        Me.Hearter_VMoni.Size = New System.Drawing.Size(172, 30)
        Me.Hearter_VMoni.TabIndex = 488
        Me.Hearter_VMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Extractor_VMoni
        '
        Me.Extractor_VMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Extractor_VMoni.Location = New System.Drawing.Point(355, 363)
        Me.Extractor_VMoni.Name = "Extractor_VMoni"
        Me.Extractor_VMoni.Size = New System.Drawing.Size(172, 30)
        Me.Extractor_VMoni.TabIndex = 487
        Me.Extractor_VMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Suppressor_VMoni
        '
        Me.Suppressor_VMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Suppressor_VMoni.Location = New System.Drawing.Point(355, 307)
        Me.Suppressor_VMoni.Name = "Suppressor_VMoni"
        Me.Suppressor_VMoni.Size = New System.Drawing.Size(172, 30)
        Me.Suppressor_VMoni.TabIndex = 486
        Me.Suppressor_VMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lens2_VMoni
        '
        Me.Lens2_VMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Lens2_VMoni.Location = New System.Drawing.Point(355, 257)
        Me.Lens2_VMoni.Name = "Lens2_VMoni"
        Me.Lens2_VMoni.Size = New System.Drawing.Size(172, 30)
        Me.Lens2_VMoni.TabIndex = 485
        Me.Lens2_VMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lens1n_VMoni
        '
        Me.Lens1n_VMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Lens1n_VMoni.Location = New System.Drawing.Point(355, 199)
        Me.Lens1n_VMoni.Name = "Lens1n_VMoni"
        Me.Lens1n_VMoni.Size = New System.Drawing.Size(172, 30)
        Me.Lens1n_VMoni.TabIndex = 484
        Me.Lens1n_VMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lens1p_VMoni
        '
        Me.Lens1p_VMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Lens1p_VMoni.Location = New System.Drawing.Point(355, 134)
        Me.Lens1p_VMoni.Name = "Lens1p_VMoni"
        Me.Lens1p_VMoni.Size = New System.Drawing.Size(172, 30)
        Me.Lens1p_VMoni.TabIndex = 483
        Me.Lens1p_VMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Beam_VMoni
        '
        Me.Beam_VMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Beam_VMoni.Location = New System.Drawing.Point(355, 81)
        Me.Beam_VMoni.Name = "Beam_VMoni"
        Me.Beam_VMoni.Size = New System.Drawing.Size(172, 30)
        Me.Beam_VMoni.TabIndex = 482
        Me.Beam_VMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ExtVGain_ADC
        '
        Me.txt_ExtVGain_ADC.Location = New System.Drawing.Point(91, 361)
        Me.txt_ExtVGain_ADC.Name = "txt_ExtVGain_ADC"
        Me.txt_ExtVGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_ExtVGain_ADC.TabIndex = 390
        Me.txt_ExtVGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ExtVOffset_ADC
        '
        Me.txt_ExtVOffset_ADC.Location = New System.Drawing.Point(217, 362)
        Me.txt_ExtVOffset_ADC.Name = "txt_ExtVOffset_ADC"
        Me.txt_ExtVOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_ExtVOffset_ADC.TabIndex = 391
        Me.txt_ExtVOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SupVOffset_ADC_R
        '
        Me.txt_SupVOffset_ADC_R.Enabled = False
        Me.txt_SupVOffset_ADC_R.Location = New System.Drawing.Point(217, 326)
        Me.txt_SupVOffset_ADC_R.Name = "txt_SupVOffset_ADC_R"
        Me.txt_SupVOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_SupVOffset_ADC_R.TabIndex = 388
        Me.txt_SupVOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SupVGain_ADC_R
        '
        Me.txt_SupVGain_ADC_R.Enabled = False
        Me.txt_SupVGain_ADC_R.Location = New System.Drawing.Point(91, 326)
        Me.txt_SupVGain_ADC_R.Name = "txt_SupVGain_ADC_R"
        Me.txt_SupVGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_SupVGain_ADC_R.TabIndex = 386
        Me.txt_SupVGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ExtVGain_ADC_R
        '
        Me.txt_ExtVGain_ADC_R.Enabled = False
        Me.txt_ExtVGain_ADC_R.Location = New System.Drawing.Point(91, 384)
        Me.txt_ExtVGain_ADC_R.Name = "txt_ExtVGain_ADC_R"
        Me.txt_ExtVGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_ExtVGain_ADC_R.TabIndex = 394
        Me.txt_ExtVGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ExtVOffset_ADC_R
        '
        Me.txt_ExtVOffset_ADC_R.Enabled = False
        Me.txt_ExtVOffset_ADC_R.Location = New System.Drawing.Point(217, 384)
        Me.txt_ExtVOffset_ADC_R.Name = "txt_ExtVOffset_ADC_R"
        Me.txt_ExtVOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_ExtVOffset_ADC_R.TabIndex = 396
        Me.txt_ExtVOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SupVOffset_ADC
        '
        Me.txt_SupVOffset_ADC.Location = New System.Drawing.Point(217, 304)
        Me.txt_SupVOffset_ADC.Name = "txt_SupVOffset_ADC"
        Me.txt_SupVOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_SupVOffset_ADC.TabIndex = 383
        Me.txt_SupVOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SupVGain_ADC
        '
        Me.txt_SupVGain_ADC.Location = New System.Drawing.Point(91, 303)
        Me.txt_SupVGain_ADC.Name = "txt_SupVGain_ADC"
        Me.txt_SupVGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_SupVGain_ADC.TabIndex = 382
        Me.txt_SupVGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_HtrVGain_ADC
        '
        Me.txt_HtrVGain_ADC.Location = New System.Drawing.Point(91, 418)
        Me.txt_HtrVGain_ADC.Name = "txt_HtrVGain_ADC"
        Me.txt_HtrVGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_HtrVGain_ADC.TabIndex = 399
        Me.txt_HtrVGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L2VOffset_ADC_R
        '
        Me.txt_L2VOffset_ADC_R.Enabled = False
        Me.txt_L2VOffset_ADC_R.Location = New System.Drawing.Point(217, 271)
        Me.txt_L2VOffset_ADC_R.Name = "txt_L2VOffset_ADC_R"
        Me.txt_L2VOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L2VOffset_ADC_R.TabIndex = 380
        Me.txt_L2VOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_HtrVOffset_ADC
        '
        Me.txt_HtrVOffset_ADC.Location = New System.Drawing.Point(217, 419)
        Me.txt_HtrVOffset_ADC.Name = "txt_HtrVOffset_ADC"
        Me.txt_HtrVOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_HtrVOffset_ADC.TabIndex = 400
        Me.txt_HtrVOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L2VGain_ADC_R
        '
        Me.txt_L2VGain_ADC_R.Enabled = False
        Me.txt_L2VGain_ADC_R.Location = New System.Drawing.Point(91, 271)
        Me.txt_L2VGain_ADC_R.Name = "txt_L2VGain_ADC_R"
        Me.txt_L2VGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L2VGain_ADC_R.TabIndex = 378
        Me.txt_L2VGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_HtrVGain_ADC_R
        '
        Me.txt_HtrVGain_ADC_R.Enabled = False
        Me.txt_HtrVGain_ADC_R.Location = New System.Drawing.Point(91, 441)
        Me.txt_HtrVGain_ADC_R.Name = "txt_HtrVGain_ADC_R"
        Me.txt_HtrVGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_HtrVGain_ADC_R.TabIndex = 403
        Me.txt_HtrVGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L2VOffset_ADC
        '
        Me.txt_L2VOffset_ADC.Location = New System.Drawing.Point(217, 249)
        Me.txt_L2VOffset_ADC.Name = "txt_L2VOffset_ADC"
        Me.txt_L2VOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_L2VOffset_ADC.TabIndex = 375
        Me.txt_L2VOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_HtrVOffset_ADC_R
        '
        Me.txt_HtrVOffset_ADC_R.Enabled = False
        Me.txt_HtrVOffset_ADC_R.Location = New System.Drawing.Point(217, 441)
        Me.txt_HtrVOffset_ADC_R.Name = "txt_HtrVOffset_ADC_R"
        Me.txt_HtrVOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_HtrVOffset_ADC_R.TabIndex = 405
        Me.txt_HtrVOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L2VGain_ADC
        '
        Me.txt_L2VGain_ADC.Location = New System.Drawing.Point(91, 248)
        Me.txt_L2VGain_ADC.Name = "txt_L2VGain_ADC"
        Me.txt_L2VGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_L2VGain_ADC.TabIndex = 374
        Me.txt_L2VGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1nVOffset_ADC_R
        '
        Me.txt_L1nVOffset_ADC_R.Enabled = False
        Me.txt_L1nVOffset_ADC_R.Location = New System.Drawing.Point(217, 213)
        Me.txt_L1nVOffset_ADC_R.Name = "txt_L1nVOffset_ADC_R"
        Me.txt_L1nVOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1nVOffset_ADC_R.TabIndex = 372
        Me.txt_L1nVOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1nVGain_ADC_R
        '
        Me.txt_L1nVGain_ADC_R.Enabled = False
        Me.txt_L1nVGain_ADC_R.Location = New System.Drawing.Point(91, 213)
        Me.txt_L1nVGain_ADC_R.Name = "txt_L1nVGain_ADC_R"
        Me.txt_L1nVGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1nVGain_ADC_R.TabIndex = 370
        Me.txt_L1nVGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1nVOffset_ADC
        '
        Me.txt_L1nVOffset_ADC.Location = New System.Drawing.Point(217, 192)
        Me.txt_L1nVOffset_ADC.Name = "txt_L1nVOffset_ADC"
        Me.txt_L1nVOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1nVOffset_ADC.TabIndex = 367
        Me.txt_L1nVOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1nVGain_ADC
        '
        Me.txt_L1nVGain_ADC.Location = New System.Drawing.Point(91, 191)
        Me.txt_L1nVGain_ADC.Name = "txt_L1nVGain_ADC"
        Me.txt_L1nVGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1nVGain_ADC.TabIndex = 366
        Me.txt_L1nVGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1pVOffset_ADC_R
        '
        Me.txt_L1pVOffset_ADC_R.Enabled = False
        Me.txt_L1pVOffset_ADC_R.Location = New System.Drawing.Point(217, 154)
        Me.txt_L1pVOffset_ADC_R.Name = "txt_L1pVOffset_ADC_R"
        Me.txt_L1pVOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1pVOffset_ADC_R.TabIndex = 364
        Me.txt_L1pVOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1pVGain_ADC_R
        '
        Me.txt_L1pVGain_ADC_R.Enabled = False
        Me.txt_L1pVGain_ADC_R.Location = New System.Drawing.Point(91, 154)
        Me.txt_L1pVGain_ADC_R.Name = "txt_L1pVGain_ADC_R"
        Me.txt_L1pVGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1pVGain_ADC_R.TabIndex = 362
        Me.txt_L1pVGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1pVOffset_ADC
        '
        Me.txt_L1pVOffset_ADC.Location = New System.Drawing.Point(217, 132)
        Me.txt_L1pVOffset_ADC.Name = "txt_L1pVOffset_ADC"
        Me.txt_L1pVOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1pVOffset_ADC.TabIndex = 359
        Me.txt_L1pVOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1pVGain_ADC
        '
        Me.txt_L1pVGain_ADC.Location = New System.Drawing.Point(91, 131)
        Me.txt_L1pVGain_ADC.Name = "txt_L1pVGain_ADC"
        Me.txt_L1pVGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1pVGain_ADC.TabIndex = 358
        Me.txt_L1pVGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_BeamVOffset_ADC_R
        '
        Me.txt_BeamVOffset_ADC_R.Enabled = False
        Me.txt_BeamVOffset_ADC_R.Location = New System.Drawing.Point(217, 96)
        Me.txt_BeamVOffset_ADC_R.Name = "txt_BeamVOffset_ADC_R"
        Me.txt_BeamVOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_BeamVOffset_ADC_R.TabIndex = 356
        Me.txt_BeamVOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_BeamVGain_ADC_R
        '
        Me.txt_BeamVGain_ADC_R.Enabled = False
        Me.txt_BeamVGain_ADC_R.Location = New System.Drawing.Point(91, 96)
        Me.txt_BeamVGain_ADC_R.Name = "txt_BeamVGain_ADC_R"
        Me.txt_BeamVGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_BeamVGain_ADC_R.TabIndex = 354
        Me.txt_BeamVGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_BeamVOffset_ADC
        '
        Me.txt_BeamVOffset_ADC.Location = New System.Drawing.Point(217, 75)
        Me.txt_BeamVOffset_ADC.Name = "txt_BeamVOffset_ADC"
        Me.txt_BeamVOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_BeamVOffset_ADC.TabIndex = 351
        Me.txt_BeamVOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_BeamVGain_ADC
        '
        Me.txt_BeamVGain_ADC.Location = New System.Drawing.Point(91, 74)
        Me.txt_BeamVGain_ADC.Name = "txt_BeamVGain_ADC"
        Me.txt_BeamVGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_BeamVGain_ADC.TabIndex = 342
        Me.txt_BeamVGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_HeaterVOffset_Read
        '
        Me.btn_HeaterVOffset_Read.Location = New System.Drawing.Point(275, 442)
        Me.btn_HeaterVOffset_Read.Name = "btn_HeaterVOffset_Read"
        Me.btn_HeaterVOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_HeaterVOffset_Read.TabIndex = 406
        Me.btn_HeaterVOffset_Read.Text = "Read"
        Me.btn_HeaterVOffset_Read.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(104, 26)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 39)
        Me.Label26.TabIndex = 481
        Me.Label26.Text = "Gain α" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9000～11000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10000=1.0000"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_SupVOffset_Read
        '
        Me.btn_SupVOffset_Read.Location = New System.Drawing.Point(275, 327)
        Me.btn_SupVOffset_Read.Name = "btn_SupVOffset_Read"
        Me.btn_SupVOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_SupVOffset_Read.TabIndex = 389
        Me.btn_SupVOffset_Read.Text = "Read"
        Me.btn_SupVOffset_Read.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(229, 36)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(83, 26)
        Me.Label29.TabIndex = 478
        Me.Label29.Text = "Offset β" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-1000～1000"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_ExtVGain_Set
        '
        Me.btn_ExtVGain_Set.Location = New System.Drawing.Point(149, 361)
        Me.btn_ExtVGain_Set.Name = "btn_ExtVGain_Set"
        Me.btn_ExtVGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_ExtVGain_Set.TabIndex = 392
        Me.btn_ExtVGain_Set.Text = "Set"
        Me.btn_ExtVGain_Set.UseVisualStyleBackColor = True
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Label51.Location = New System.Drawing.Point(212, 3)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(125, 22)
        Me.Label51.TabIndex = 475
        Me.Label51.Text = "Volt Monitor"
        '
        'btn_SupVGain_Read
        '
        Me.btn_SupVGain_Read.Location = New System.Drawing.Point(149, 327)
        Me.btn_SupVGain_Read.Name = "btn_SupVGain_Read"
        Me.btn_SupVGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_SupVGain_Read.TabIndex = 387
        Me.btn_SupVGain_Read.Text = "Read"
        Me.btn_SupVGain_Read.UseVisualStyleBackColor = True
        '
        'btn_ExtVOffset_Set
        '
        Me.btn_ExtVOffset_Set.Location = New System.Drawing.Point(275, 361)
        Me.btn_ExtVOffset_Set.Name = "btn_ExtVOffset_Set"
        Me.btn_ExtVOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_ExtVOffset_Set.TabIndex = 393
        Me.btn_ExtVOffset_Set.Text = "Set"
        Me.btn_ExtVOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_SupVOffset_Set
        '
        Me.btn_SupVOffset_Set.Location = New System.Drawing.Point(275, 303)
        Me.btn_SupVOffset_Set.Name = "btn_SupVOffset_Set"
        Me.btn_SupVOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_SupVOffset_Set.TabIndex = 385
        Me.btn_SupVOffset_Set.Text = "Set"
        Me.btn_SupVOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_ExtVGain_Read
        '
        Me.btn_ExtVGain_Read.Location = New System.Drawing.Point(149, 385)
        Me.btn_ExtVGain_Read.Name = "btn_ExtVGain_Read"
        Me.btn_ExtVGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_ExtVGain_Read.TabIndex = 395
        Me.btn_ExtVGain_Read.Text = "Read"
        Me.btn_ExtVGain_Read.UseVisualStyleBackColor = True
        '
        'btn_SupVGain_Set
        '
        Me.btn_SupVGain_Set.Location = New System.Drawing.Point(149, 303)
        Me.btn_SupVGain_Set.Name = "btn_SupVGain_Set"
        Me.btn_SupVGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_SupVGain_Set.TabIndex = 384
        Me.btn_SupVGain_Set.Text = "Set"
        Me.btn_SupVGain_Set.UseVisualStyleBackColor = True
        '
        'btn_ExtVOffset_Read
        '
        Me.btn_ExtVOffset_Read.Location = New System.Drawing.Point(275, 385)
        Me.btn_ExtVOffset_Read.Name = "btn_ExtVOffset_Read"
        Me.btn_ExtVOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_ExtVOffset_Read.TabIndex = 397
        Me.btn_ExtVOffset_Read.Text = "Read"
        Me.btn_ExtVOffset_Read.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(21, 432)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(61, 13)
        Me.Label34.TabIndex = 398
        Me.Label34.Text = "HeaterPS"
        '
        'btn_Lens2VOffset_Read
        '
        Me.btn_Lens2VOffset_Read.Location = New System.Drawing.Point(275, 272)
        Me.btn_Lens2VOffset_Read.Name = "btn_Lens2VOffset_Read"
        Me.btn_Lens2VOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens2VOffset_Read.TabIndex = 381
        Me.btn_Lens2VOffset_Read.Text = "Read"
        Me.btn_Lens2VOffset_Read.UseVisualStyleBackColor = True
        '
        'btn_Lens2VGain_Read
        '
        Me.btn_Lens2VGain_Read.Location = New System.Drawing.Point(149, 272)
        Me.btn_Lens2VGain_Read.Name = "btn_Lens2VGain_Read"
        Me.btn_Lens2VGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens2VGain_Read.TabIndex = 379
        Me.btn_Lens2VGain_Read.Text = "Read"
        Me.btn_Lens2VGain_Read.UseVisualStyleBackColor = True
        '
        'btn_HeaterVGain_Set
        '
        Me.btn_HeaterVGain_Set.Location = New System.Drawing.Point(149, 418)
        Me.btn_HeaterVGain_Set.Name = "btn_HeaterVGain_Set"
        Me.btn_HeaterVGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_HeaterVGain_Set.TabIndex = 401
        Me.btn_HeaterVGain_Set.Text = "Set"
        Me.btn_HeaterVGain_Set.UseVisualStyleBackColor = True
        '
        'btn_HeaterVOffset_Set
        '
        Me.btn_HeaterVOffset_Set.Location = New System.Drawing.Point(275, 418)
        Me.btn_HeaterVOffset_Set.Name = "btn_HeaterVOffset_Set"
        Me.btn_HeaterVOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_HeaterVOffset_Set.TabIndex = 402
        Me.btn_HeaterVOffset_Set.Text = "Set"
        Me.btn_HeaterVOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens2VOffset_Set
        '
        Me.btn_Lens2VOffset_Set.Location = New System.Drawing.Point(275, 248)
        Me.btn_Lens2VOffset_Set.Name = "btn_Lens2VOffset_Set"
        Me.btn_Lens2VOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens2VOffset_Set.TabIndex = 377
        Me.btn_Lens2VOffset_Set.Text = "Set"
        Me.btn_Lens2VOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens2VGain_Set
        '
        Me.btn_Lens2VGain_Set.Location = New System.Drawing.Point(149, 248)
        Me.btn_Lens2VGain_Set.Name = "btn_Lens2VGain_Set"
        Me.btn_Lens2VGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens2VGain_Set.TabIndex = 376
        Me.btn_Lens2VGain_Set.Text = "Set"
        Me.btn_Lens2VGain_Set.UseVisualStyleBackColor = True
        '
        'btn_HeaterVGain_Read
        '
        Me.btn_HeaterVGain_Read.Location = New System.Drawing.Point(149, 442)
        Me.btn_HeaterVGain_Read.Name = "btn_HeaterVGain_Read"
        Me.btn_HeaterVGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_HeaterVGain_Read.TabIndex = 404
        Me.btn_HeaterVGain_Read.Text = "Read"
        Me.btn_HeaterVGain_Read.UseVisualStyleBackColor = True
        '
        'btn_Lens1nVOffset_Read
        '
        Me.btn_Lens1nVOffset_Read.Location = New System.Drawing.Point(275, 215)
        Me.btn_Lens1nVOffset_Read.Name = "btn_Lens1nVOffset_Read"
        Me.btn_Lens1nVOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1nVOffset_Read.TabIndex = 373
        Me.btn_Lens1nVOffset_Read.Text = "Read"
        Me.btn_Lens1nVOffset_Read.UseVisualStyleBackColor = True
        '
        'btn_Lens1nVGain_Read
        '
        Me.btn_Lens1nVGain_Read.Location = New System.Drawing.Point(149, 215)
        Me.btn_Lens1nVGain_Read.Name = "btn_Lens1nVGain_Read"
        Me.btn_Lens1nVGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1nVGain_Read.TabIndex = 371
        Me.btn_Lens1nVGain_Read.Text = "Read"
        Me.btn_Lens1nVGain_Read.UseVisualStyleBackColor = True
        '
        'btn_Lens1nVOffset_Set
        '
        Me.btn_Lens1nVOffset_Set.Location = New System.Drawing.Point(275, 191)
        Me.btn_Lens1nVOffset_Set.Name = "btn_Lens1nVOffset_Set"
        Me.btn_Lens1nVOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1nVOffset_Set.TabIndex = 369
        Me.btn_Lens1nVOffset_Set.Text = "Set"
        Me.btn_Lens1nVOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens1nVGain_Set
        '
        Me.btn_Lens1nVGain_Set.Location = New System.Drawing.Point(149, 191)
        Me.btn_Lens1nVGain_Set.Name = "btn_Lens1nVGain_Set"
        Me.btn_Lens1nVGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1nVGain_Set.TabIndex = 368
        Me.btn_Lens1nVGain_Set.Text = "Set"
        Me.btn_Lens1nVGain_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens1pVOffset_Read
        '
        Me.btn_Lens1pVOffset_Read.Location = New System.Drawing.Point(275, 155)
        Me.btn_Lens1pVOffset_Read.Name = "btn_Lens1pVOffset_Read"
        Me.btn_Lens1pVOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1pVOffset_Read.TabIndex = 365
        Me.btn_Lens1pVOffset_Read.Text = "Read"
        Me.btn_Lens1pVOffset_Read.UseVisualStyleBackColor = True
        '
        'btn_Lens1pVGain_Read
        '
        Me.btn_Lens1pVGain_Read.Location = New System.Drawing.Point(149, 155)
        Me.btn_Lens1pVGain_Read.Name = "btn_Lens1pVGain_Read"
        Me.btn_Lens1pVGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1pVGain_Read.TabIndex = 363
        Me.btn_Lens1pVGain_Read.Text = "Read"
        Me.btn_Lens1pVGain_Read.UseVisualStyleBackColor = True
        '
        'btn_Lens1pVGain_Set
        '
        Me.btn_Lens1pVGain_Set.Location = New System.Drawing.Point(149, 131)
        Me.btn_Lens1pVGain_Set.Name = "btn_Lens1pVGain_Set"
        Me.btn_Lens1pVGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1pVGain_Set.TabIndex = 360
        Me.btn_Lens1pVGain_Set.Text = "Set"
        Me.btn_Lens1pVGain_Set.UseVisualStyleBackColor = True
        '
        'btn_BeamVOffset_Read
        '
        Me.btn_BeamVOffset_Read.Location = New System.Drawing.Point(275, 98)
        Me.btn_BeamVOffset_Read.Name = "btn_BeamVOffset_Read"
        Me.btn_BeamVOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_BeamVOffset_Read.TabIndex = 357
        Me.btn_BeamVOffset_Read.Text = "Read"
        Me.btn_BeamVOffset_Read.UseVisualStyleBackColor = True
        '
        'btn_BeamVGain_Read
        '
        Me.btn_BeamVGain_Read.Location = New System.Drawing.Point(149, 98)
        Me.btn_BeamVGain_Read.Name = "btn_BeamVGain_Read"
        Me.btn_BeamVGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_BeamVGain_Read.TabIndex = 355
        Me.btn_BeamVGain_Read.Text = "Read"
        Me.btn_BeamVGain_Read.UseVisualStyleBackColor = True
        '
        'btn_BeamVOffset_Set
        '
        Me.btn_BeamVOffset_Set.Location = New System.Drawing.Point(275, 74)
        Me.btn_BeamVOffset_Set.Name = "btn_BeamVOffset_Set"
        Me.btn_BeamVOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_BeamVOffset_Set.TabIndex = 353
        Me.btn_BeamVOffset_Set.Text = "Set"
        Me.btn_BeamVOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_BeamVGain_Set
        '
        Me.btn_BeamVGain_Set.Location = New System.Drawing.Point(149, 74)
        Me.btn_BeamVGain_Set.Name = "btn_BeamVGain_Set"
        Me.btn_BeamVGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_BeamVGain_Set.TabIndex = 352
        Me.btn_BeamVGain_Set.Text = "Set"
        Me.btn_BeamVGain_Set.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(22, 376)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(41, 13)
        Me.Label33.TabIndex = 350
        Me.Label33.Text = "ExtPS"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(21, 320)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(44, 13)
        Me.Label32.TabIndex = 349
        Me.Label32.Text = "SupPS"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(19, 264)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(57, 13)
        Me.Label31.TabIndex = 348
        Me.Label31.Text = "Lens2PS"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(19, 207)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(68, 13)
        Me.Label30.TabIndex = 347
        Me.Label30.Text = "Lens1PS -"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(17, 147)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(68, 13)
        Me.Label25.TabIndex = 344
        Me.Label25.Text = "Lens1PS +"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(19, 89)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 13)
        Me.Label22.TabIndex = 343
        Me.Label22.Text = "BeamPS"
        '
        'btn_Lens1pVOffset_Set
        '
        Me.btn_Lens1pVOffset_Set.Location = New System.Drawing.Point(276, 128)
        Me.btn_Lens1pVOffset_Set.Name = "btn_Lens1pVOffset_Set"
        Me.btn_Lens1pVOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1pVOffset_Set.TabIndex = 361
        Me.btn_Lens1pVOffset_Set.Text = "Set"
        Me.btn_Lens1pVOffset_Set.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label54)
        Me.TabPage2.Controls.Add(Me.Hearter_IMoni)
        Me.TabPage2.Controls.Add(Me.Extractor_IMoni)
        Me.TabPage2.Controls.Add(Me.Suppressor_IMoni)
        Me.TabPage2.Controls.Add(Me.Lens2_IMoni)
        Me.TabPage2.Controls.Add(Me.Lens1n_IMoni)
        Me.TabPage2.Controls.Add(Me.Lens1p_IMoni)
        Me.TabPage2.Controls.Add(Me.Beam_IMoni)
        Me.TabPage2.Controls.Add(Me.txt_ExtIGain_ADC)
        Me.TabPage2.Controls.Add(Me.txt_ExtIOffset_ADC)
        Me.TabPage2.Controls.Add(Me.txt_SupIOffset_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_BeamIGain_ADC)
        Me.TabPage2.Controls.Add(Me.txt_SupIGain_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_ExtIGain_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_BeamIOffset_ADC)
        Me.TabPage2.Controls.Add(Me.txt_ExtIOffset_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_SupIOffset_ADC)
        Me.TabPage2.Controls.Add(Me.txt_BeamIGain_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_SupIGain_ADC)
        Me.TabPage2.Controls.Add(Me.txt_BeamIOffset_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_HtrIGain_ADC)
        Me.TabPage2.Controls.Add(Me.txt_L1pIGain_ADC)
        Me.TabPage2.Controls.Add(Me.txt_L2IOffset_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_L1pIOffset_ADC)
        Me.TabPage2.Controls.Add(Me.txt_HtrIOffset_ADC)
        Me.TabPage2.Controls.Add(Me.txt_L1pIGain_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_L2IGain_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_L1pIOffset_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_L1nIGain_ADC)
        Me.TabPage2.Controls.Add(Me.txt_HtrIGain_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_L1nIOffset_ADC)
        Me.TabPage2.Controls.Add(Me.txt_L2IOffset_ADC)
        Me.TabPage2.Controls.Add(Me.txt_L1nIGain_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_HtrIOffset_ADC_R)
        Me.TabPage2.Controls.Add(Me.txt_L2IGain_ADC)
        Me.TabPage2.Controls.Add(Me.txt_L1nIOffset_ADC_R)
        Me.TabPage2.Controls.Add(Me.Label41)
        Me.TabPage2.Controls.Add(Me.Label42)
        Me.TabPage2.Controls.Add(Me.btn_SupIOffset_Read)
        Me.TabPage2.Controls.Add(Me.Label52)
        Me.TabPage2.Controls.Add(Me.Label39)
        Me.TabPage2.Controls.Add(Me.btn_ExtIGain_Set)
        Me.TabPage2.Controls.Add(Me.Label40)
        Me.TabPage2.Controls.Add(Me.btn_SupIGain_Read)
        Me.TabPage2.Controls.Add(Me.btn_Lens1pIOffset_Set)
        Me.TabPage2.Controls.Add(Me.btn_ExtIOffset_Set)
        Me.TabPage2.Controls.Add(Me.Label43)
        Me.TabPage2.Controls.Add(Me.Label44)
        Me.TabPage2.Controls.Add(Me.btn_SupIOffset_Set)
        Me.TabPage2.Controls.Add(Me.Label45)
        Me.TabPage2.Controls.Add(Me.btn_ExtIGain_Read)
        Me.TabPage2.Controls.Add(Me.Label48)
        Me.TabPage2.Controls.Add(Me.btn_SupIGain_Set)
        Me.TabPage2.Controls.Add(Me.btn_BeamIGain_Set)
        Me.TabPage2.Controls.Add(Me.btn_BeamIOffset_Set)
        Me.TabPage2.Controls.Add(Me.btn_ExtIOffset_Read)
        Me.TabPage2.Controls.Add(Me.btn_BeamIGain_Read)
        Me.TabPage2.Controls.Add(Me.Label49)
        Me.TabPage2.Controls.Add(Me.btn_Lens2IOffset_Read)
        Me.TabPage2.Controls.Add(Me.btn_BeamIOffset_Read)
        Me.TabPage2.Controls.Add(Me.btn_Lens1pIGain_Set)
        Me.TabPage2.Controls.Add(Me.btn_Lens2IGain_Read)
        Me.TabPage2.Controls.Add(Me.btn_HeaterIGain_Set)
        Me.TabPage2.Controls.Add(Me.btn_Lens1pIGain_Read)
        Me.TabPage2.Controls.Add(Me.btn_HeaterIOffset_Set)
        Me.TabPage2.Controls.Add(Me.btn_Lens1pIOffset_Read)
        Me.TabPage2.Controls.Add(Me.btn_Lens2IOffset_Set)
        Me.TabPage2.Controls.Add(Me.btn_Lens2IGain_Set)
        Me.TabPage2.Controls.Add(Me.btn_Lens1nIGain_Set)
        Me.TabPage2.Controls.Add(Me.btn_HeaterIGain_Read)
        Me.TabPage2.Controls.Add(Me.btn_Lens1nIOffset_Set)
        Me.TabPage2.Controls.Add(Me.btn_Lens1nIGain_Read)
        Me.TabPage2.Controls.Add(Me.btn_HeaterIOffset_Read)
        Me.TabPage2.Controls.Add(Me.btn_Lens1nIOffset_Read)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(544, 476)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Current ADC"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Label54.Location = New System.Drawing.Point(402, 42)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(80, 22)
        Me.Label54.TabIndex = 496
        Me.Label54.Text = "Monitor"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Hearter_IMoni
        '
        Me.Hearter_IMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Hearter_IMoni.Location = New System.Drawing.Point(355, 418)
        Me.Hearter_IMoni.Name = "Hearter_IMoni"
        Me.Hearter_IMoni.Size = New System.Drawing.Size(180, 30)
        Me.Hearter_IMoni.TabIndex = 495
        Me.Hearter_IMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Extractor_IMoni
        '
        Me.Extractor_IMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Extractor_IMoni.Location = New System.Drawing.Point(355, 362)
        Me.Extractor_IMoni.Name = "Extractor_IMoni"
        Me.Extractor_IMoni.Size = New System.Drawing.Size(180, 30)
        Me.Extractor_IMoni.TabIndex = 494
        Me.Extractor_IMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Suppressor_IMoni
        '
        Me.Suppressor_IMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Suppressor_IMoni.Location = New System.Drawing.Point(355, 306)
        Me.Suppressor_IMoni.Name = "Suppressor_IMoni"
        Me.Suppressor_IMoni.Size = New System.Drawing.Size(180, 30)
        Me.Suppressor_IMoni.TabIndex = 493
        Me.Suppressor_IMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lens2_IMoni
        '
        Me.Lens2_IMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Lens2_IMoni.Location = New System.Drawing.Point(355, 256)
        Me.Lens2_IMoni.Name = "Lens2_IMoni"
        Me.Lens2_IMoni.Size = New System.Drawing.Size(180, 30)
        Me.Lens2_IMoni.TabIndex = 492
        Me.Lens2_IMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lens1n_IMoni
        '
        Me.Lens1n_IMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Lens1n_IMoni.Location = New System.Drawing.Point(355, 198)
        Me.Lens1n_IMoni.Name = "Lens1n_IMoni"
        Me.Lens1n_IMoni.Size = New System.Drawing.Size(180, 30)
        Me.Lens1n_IMoni.TabIndex = 491
        Me.Lens1n_IMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lens1p_IMoni
        '
        Me.Lens1p_IMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Lens1p_IMoni.Location = New System.Drawing.Point(355, 133)
        Me.Lens1p_IMoni.Name = "Lens1p_IMoni"
        Me.Lens1p_IMoni.Size = New System.Drawing.Size(180, 30)
        Me.Lens1p_IMoni.TabIndex = 490
        Me.Lens1p_IMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Beam_IMoni
        '
        Me.Beam_IMoni.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Beam_IMoni.Location = New System.Drawing.Point(355, 80)
        Me.Beam_IMoni.Name = "Beam_IMoni"
        Me.Beam_IMoni.Size = New System.Drawing.Size(180, 30)
        Me.Beam_IMoni.TabIndex = 489
        Me.Beam_IMoni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ExtIGain_ADC
        '
        Me.txt_ExtIGain_ADC.Location = New System.Drawing.Point(91, 360)
        Me.txt_ExtIGain_ADC.Name = "txt_ExtIGain_ADC"
        Me.txt_ExtIGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_ExtIGain_ADC.TabIndex = 455
        Me.txt_ExtIGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ExtIOffset_ADC
        '
        Me.txt_ExtIOffset_ADC.Location = New System.Drawing.Point(217, 361)
        Me.txt_ExtIOffset_ADC.Name = "txt_ExtIOffset_ADC"
        Me.txt_ExtIOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_ExtIOffset_ADC.TabIndex = 456
        Me.txt_ExtIOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SupIOffset_ADC_R
        '
        Me.txt_SupIOffset_ADC_R.Enabled = False
        Me.txt_SupIOffset_ADC_R.Location = New System.Drawing.Point(217, 325)
        Me.txt_SupIOffset_ADC_R.Name = "txt_SupIOffset_ADC_R"
        Me.txt_SupIOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_SupIOffset_ADC_R.TabIndex = 453
        Me.txt_SupIOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_BeamIGain_ADC
        '
        Me.txt_BeamIGain_ADC.Location = New System.Drawing.Point(91, 73)
        Me.txt_BeamIGain_ADC.Name = "txt_BeamIGain_ADC"
        Me.txt_BeamIGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_BeamIGain_ADC.TabIndex = 407
        Me.txt_BeamIGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SupIGain_ADC_R
        '
        Me.txt_SupIGain_ADC_R.Enabled = False
        Me.txt_SupIGain_ADC_R.Location = New System.Drawing.Point(91, 325)
        Me.txt_SupIGain_ADC_R.Name = "txt_SupIGain_ADC_R"
        Me.txt_SupIGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_SupIGain_ADC_R.TabIndex = 451
        Me.txt_SupIGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ExtIGain_ADC_R
        '
        Me.txt_ExtIGain_ADC_R.Enabled = False
        Me.txt_ExtIGain_ADC_R.Location = New System.Drawing.Point(91, 382)
        Me.txt_ExtIGain_ADC_R.Name = "txt_ExtIGain_ADC_R"
        Me.txt_ExtIGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_ExtIGain_ADC_R.TabIndex = 459
        Me.txt_ExtIGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_BeamIOffset_ADC
        '
        Me.txt_BeamIOffset_ADC.Location = New System.Drawing.Point(217, 74)
        Me.txt_BeamIOffset_ADC.Name = "txt_BeamIOffset_ADC"
        Me.txt_BeamIOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_BeamIOffset_ADC.TabIndex = 416
        Me.txt_BeamIOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ExtIOffset_ADC_R
        '
        Me.txt_ExtIOffset_ADC_R.Enabled = False
        Me.txt_ExtIOffset_ADC_R.Location = New System.Drawing.Point(217, 382)
        Me.txt_ExtIOffset_ADC_R.Name = "txt_ExtIOffset_ADC_R"
        Me.txt_ExtIOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_ExtIOffset_ADC_R.TabIndex = 461
        Me.txt_ExtIOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SupIOffset_ADC
        '
        Me.txt_SupIOffset_ADC.Location = New System.Drawing.Point(217, 303)
        Me.txt_SupIOffset_ADC.Name = "txt_SupIOffset_ADC"
        Me.txt_SupIOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_SupIOffset_ADC.TabIndex = 448
        Me.txt_SupIOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_BeamIGain_ADC_R
        '
        Me.txt_BeamIGain_ADC_R.Enabled = False
        Me.txt_BeamIGain_ADC_R.Location = New System.Drawing.Point(91, 95)
        Me.txt_BeamIGain_ADC_R.Name = "txt_BeamIGain_ADC_R"
        Me.txt_BeamIGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_BeamIGain_ADC_R.TabIndex = 419
        Me.txt_BeamIGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SupIGain_ADC
        '
        Me.txt_SupIGain_ADC.Location = New System.Drawing.Point(91, 302)
        Me.txt_SupIGain_ADC.Name = "txt_SupIGain_ADC"
        Me.txt_SupIGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_SupIGain_ADC.TabIndex = 447
        Me.txt_SupIGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_BeamIOffset_ADC_R
        '
        Me.txt_BeamIOffset_ADC_R.Enabled = False
        Me.txt_BeamIOffset_ADC_R.Location = New System.Drawing.Point(217, 95)
        Me.txt_BeamIOffset_ADC_R.Name = "txt_BeamIOffset_ADC_R"
        Me.txt_BeamIOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_BeamIOffset_ADC_R.TabIndex = 421
        Me.txt_BeamIOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_HtrIGain_ADC
        '
        Me.txt_HtrIGain_ADC.Location = New System.Drawing.Point(91, 417)
        Me.txt_HtrIGain_ADC.Name = "txt_HtrIGain_ADC"
        Me.txt_HtrIGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_HtrIGain_ADC.TabIndex = 464
        Me.txt_HtrIGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1pIGain_ADC
        '
        Me.txt_L1pIGain_ADC.Location = New System.Drawing.Point(91, 130)
        Me.txt_L1pIGain_ADC.Name = "txt_L1pIGain_ADC"
        Me.txt_L1pIGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1pIGain_ADC.TabIndex = 423
        Me.txt_L1pIGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L2IOffset_ADC_R
        '
        Me.txt_L2IOffset_ADC_R.Enabled = False
        Me.txt_L2IOffset_ADC_R.Location = New System.Drawing.Point(217, 270)
        Me.txt_L2IOffset_ADC_R.Name = "txt_L2IOffset_ADC_R"
        Me.txt_L2IOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L2IOffset_ADC_R.TabIndex = 445
        Me.txt_L2IOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1pIOffset_ADC
        '
        Me.txt_L1pIOffset_ADC.Location = New System.Drawing.Point(217, 131)
        Me.txt_L1pIOffset_ADC.Name = "txt_L1pIOffset_ADC"
        Me.txt_L1pIOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1pIOffset_ADC.TabIndex = 424
        Me.txt_L1pIOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_HtrIOffset_ADC
        '
        Me.txt_HtrIOffset_ADC.Location = New System.Drawing.Point(217, 418)
        Me.txt_HtrIOffset_ADC.Name = "txt_HtrIOffset_ADC"
        Me.txt_HtrIOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_HtrIOffset_ADC.TabIndex = 465
        Me.txt_HtrIOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1pIGain_ADC_R
        '
        Me.txt_L1pIGain_ADC_R.Enabled = False
        Me.txt_L1pIGain_ADC_R.Location = New System.Drawing.Point(91, 153)
        Me.txt_L1pIGain_ADC_R.Name = "txt_L1pIGain_ADC_R"
        Me.txt_L1pIGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1pIGain_ADC_R.TabIndex = 427
        Me.txt_L1pIGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L2IGain_ADC_R
        '
        Me.txt_L2IGain_ADC_R.Enabled = False
        Me.txt_L2IGain_ADC_R.Location = New System.Drawing.Point(91, 270)
        Me.txt_L2IGain_ADC_R.Name = "txt_L2IGain_ADC_R"
        Me.txt_L2IGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L2IGain_ADC_R.TabIndex = 443
        Me.txt_L2IGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1pIOffset_ADC_R
        '
        Me.txt_L1pIOffset_ADC_R.Enabled = False
        Me.txt_L1pIOffset_ADC_R.Location = New System.Drawing.Point(217, 153)
        Me.txt_L1pIOffset_ADC_R.Name = "txt_L1pIOffset_ADC_R"
        Me.txt_L1pIOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1pIOffset_ADC_R.TabIndex = 429
        Me.txt_L1pIOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1nIGain_ADC
        '
        Me.txt_L1nIGain_ADC.Location = New System.Drawing.Point(91, 190)
        Me.txt_L1nIGain_ADC.Name = "txt_L1nIGain_ADC"
        Me.txt_L1nIGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1nIGain_ADC.TabIndex = 431
        Me.txt_L1nIGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_HtrIGain_ADC_R
        '
        Me.txt_HtrIGain_ADC_R.Enabled = False
        Me.txt_HtrIGain_ADC_R.Location = New System.Drawing.Point(91, 440)
        Me.txt_HtrIGain_ADC_R.Name = "txt_HtrIGain_ADC_R"
        Me.txt_HtrIGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_HtrIGain_ADC_R.TabIndex = 468
        Me.txt_HtrIGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1nIOffset_ADC
        '
        Me.txt_L1nIOffset_ADC.Location = New System.Drawing.Point(217, 191)
        Me.txt_L1nIOffset_ADC.Name = "txt_L1nIOffset_ADC"
        Me.txt_L1nIOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1nIOffset_ADC.TabIndex = 432
        Me.txt_L1nIOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L2IOffset_ADC
        '
        Me.txt_L2IOffset_ADC.Location = New System.Drawing.Point(217, 248)
        Me.txt_L2IOffset_ADC.Name = "txt_L2IOffset_ADC"
        Me.txt_L2IOffset_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_L2IOffset_ADC.TabIndex = 440
        Me.txt_L2IOffset_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1nIGain_ADC_R
        '
        Me.txt_L1nIGain_ADC_R.Enabled = False
        Me.txt_L1nIGain_ADC_R.Location = New System.Drawing.Point(91, 212)
        Me.txt_L1nIGain_ADC_R.Name = "txt_L1nIGain_ADC_R"
        Me.txt_L1nIGain_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1nIGain_ADC_R.TabIndex = 435
        Me.txt_L1nIGain_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_HtrIOffset_ADC_R
        '
        Me.txt_HtrIOffset_ADC_R.Enabled = False
        Me.txt_HtrIOffset_ADC_R.Location = New System.Drawing.Point(217, 440)
        Me.txt_HtrIOffset_ADC_R.Name = "txt_HtrIOffset_ADC_R"
        Me.txt_HtrIOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_HtrIOffset_ADC_R.TabIndex = 470
        Me.txt_HtrIOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L2IGain_ADC
        '
        Me.txt_L2IGain_ADC.Location = New System.Drawing.Point(91, 247)
        Me.txt_L2IGain_ADC.Name = "txt_L2IGain_ADC"
        Me.txt_L2IGain_ADC.Size = New System.Drawing.Size(52, 20)
        Me.txt_L2IGain_ADC.TabIndex = 439
        Me.txt_L2IGain_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_L1nIOffset_ADC_R
        '
        Me.txt_L1nIOffset_ADC_R.Enabled = False
        Me.txt_L1nIOffset_ADC_R.Location = New System.Drawing.Point(217, 212)
        Me.txt_L1nIOffset_ADC_R.Name = "txt_L1nIOffset_ADC_R"
        Me.txt_L1nIOffset_ADC_R.Size = New System.Drawing.Size(52, 20)
        Me.txt_L1nIOffset_ADC_R.TabIndex = 437
        Me.txt_L1nIOffset_ADC_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(104, 25)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(87, 39)
        Me.Label41.TabIndex = 482
        Me.Label41.Text = "Gain α" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9000～11000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10000=1.0000"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(229, 35)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(83, 26)
        Me.Label42.TabIndex = 480
        Me.Label42.Text = "Offset β" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-1000～1000"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_SupIOffset_Read
        '
        Me.btn_SupIOffset_Read.Location = New System.Drawing.Point(275, 326)
        Me.btn_SupIOffset_Read.Name = "btn_SupIOffset_Read"
        Me.btn_SupIOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_SupIOffset_Read.TabIndex = 454
        Me.btn_SupIOffset_Read.Text = "Read"
        Me.btn_SupIOffset_Read.UseVisualStyleBackColor = True
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Label52.Location = New System.Drawing.Point(199, 7)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(159, 22)
        Me.Label52.TabIndex = 476
        Me.Label52.Text = "Current Monitor"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(19, 88)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(54, 13)
        Me.Label39.TabIndex = 472
        Me.Label39.Text = "BeamPS"
        '
        'btn_ExtIGain_Set
        '
        Me.btn_ExtIGain_Set.Location = New System.Drawing.Point(149, 360)
        Me.btn_ExtIGain_Set.Name = "btn_ExtIGain_Set"
        Me.btn_ExtIGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_ExtIGain_Set.TabIndex = 457
        Me.btn_ExtIGain_Set.Text = "Set"
        Me.btn_ExtIGain_Set.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(17, 146)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(68, 13)
        Me.Label40.TabIndex = 473
        Me.Label40.Text = "Lens1PS +"
        '
        'btn_SupIGain_Read
        '
        Me.btn_SupIGain_Read.Location = New System.Drawing.Point(149, 326)
        Me.btn_SupIGain_Read.Name = "btn_SupIGain_Read"
        Me.btn_SupIGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_SupIGain_Read.TabIndex = 452
        Me.btn_SupIGain_Read.Text = "Read"
        Me.btn_SupIGain_Read.UseVisualStyleBackColor = True
        '
        'btn_Lens1pIOffset_Set
        '
        Me.btn_Lens1pIOffset_Set.Location = New System.Drawing.Point(276, 127)
        Me.btn_Lens1pIOffset_Set.Name = "btn_Lens1pIOffset_Set"
        Me.btn_Lens1pIOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1pIOffset_Set.TabIndex = 426
        Me.btn_Lens1pIOffset_Set.Text = "Set"
        Me.btn_Lens1pIOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_ExtIOffset_Set
        '
        Me.btn_ExtIOffset_Set.Location = New System.Drawing.Point(275, 360)
        Me.btn_ExtIOffset_Set.Name = "btn_ExtIOffset_Set"
        Me.btn_ExtIOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_ExtIOffset_Set.TabIndex = 458
        Me.btn_ExtIOffset_Set.Text = "Set"
        Me.btn_ExtIOffset_Set.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(19, 206)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(68, 13)
        Me.Label43.TabIndex = 412
        Me.Label43.Text = "Lens1PS -"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(19, 263)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(57, 13)
        Me.Label44.TabIndex = 413
        Me.Label44.Text = "Lens2PS"
        '
        'btn_SupIOffset_Set
        '
        Me.btn_SupIOffset_Set.Location = New System.Drawing.Point(275, 302)
        Me.btn_SupIOffset_Set.Name = "btn_SupIOffset_Set"
        Me.btn_SupIOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_SupIOffset_Set.TabIndex = 450
        Me.btn_SupIOffset_Set.Text = "Set"
        Me.btn_SupIOffset_Set.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(21, 319)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(44, 13)
        Me.Label45.TabIndex = 414
        Me.Label45.Text = "SupPS"
        '
        'btn_ExtIGain_Read
        '
        Me.btn_ExtIGain_Read.Location = New System.Drawing.Point(149, 384)
        Me.btn_ExtIGain_Read.Name = "btn_ExtIGain_Read"
        Me.btn_ExtIGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_ExtIGain_Read.TabIndex = 460
        Me.btn_ExtIGain_Read.Text = "Read"
        Me.btn_ExtIGain_Read.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(22, 375)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(41, 13)
        Me.Label48.TabIndex = 415
        Me.Label48.Text = "ExtPS"
        '
        'btn_SupIGain_Set
        '
        Me.btn_SupIGain_Set.Location = New System.Drawing.Point(149, 302)
        Me.btn_SupIGain_Set.Name = "btn_SupIGain_Set"
        Me.btn_SupIGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_SupIGain_Set.TabIndex = 449
        Me.btn_SupIGain_Set.Text = "Set"
        Me.btn_SupIGain_Set.UseVisualStyleBackColor = True
        '
        'btn_BeamIGain_Set
        '
        Me.btn_BeamIGain_Set.Location = New System.Drawing.Point(149, 73)
        Me.btn_BeamIGain_Set.Name = "btn_BeamIGain_Set"
        Me.btn_BeamIGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_BeamIGain_Set.TabIndex = 417
        Me.btn_BeamIGain_Set.Text = "Set"
        Me.btn_BeamIGain_Set.UseVisualStyleBackColor = True
        '
        'btn_BeamIOffset_Set
        '
        Me.btn_BeamIOffset_Set.Location = New System.Drawing.Point(275, 73)
        Me.btn_BeamIOffset_Set.Name = "btn_BeamIOffset_Set"
        Me.btn_BeamIOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_BeamIOffset_Set.TabIndex = 418
        Me.btn_BeamIOffset_Set.Text = "Set"
        Me.btn_BeamIOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_ExtIOffset_Read
        '
        Me.btn_ExtIOffset_Read.Location = New System.Drawing.Point(275, 384)
        Me.btn_ExtIOffset_Read.Name = "btn_ExtIOffset_Read"
        Me.btn_ExtIOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_ExtIOffset_Read.TabIndex = 462
        Me.btn_ExtIOffset_Read.Text = "Read"
        Me.btn_ExtIOffset_Read.UseVisualStyleBackColor = True
        '
        'btn_BeamIGain_Read
        '
        Me.btn_BeamIGain_Read.Location = New System.Drawing.Point(149, 96)
        Me.btn_BeamIGain_Read.Name = "btn_BeamIGain_Read"
        Me.btn_BeamIGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_BeamIGain_Read.TabIndex = 420
        Me.btn_BeamIGain_Read.Text = "Read"
        Me.btn_BeamIGain_Read.UseVisualStyleBackColor = True
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(21, 431)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(61, 13)
        Me.Label49.TabIndex = 463
        Me.Label49.Text = "HeaterPS"
        '
        'btn_Lens2IOffset_Read
        '
        Me.btn_Lens2IOffset_Read.Location = New System.Drawing.Point(275, 271)
        Me.btn_Lens2IOffset_Read.Name = "btn_Lens2IOffset_Read"
        Me.btn_Lens2IOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens2IOffset_Read.TabIndex = 446
        Me.btn_Lens2IOffset_Read.Text = "Read"
        Me.btn_Lens2IOffset_Read.UseVisualStyleBackColor = True
        '
        'btn_BeamIOffset_Read
        '
        Me.btn_BeamIOffset_Read.Location = New System.Drawing.Point(275, 96)
        Me.btn_BeamIOffset_Read.Name = "btn_BeamIOffset_Read"
        Me.btn_BeamIOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_BeamIOffset_Read.TabIndex = 422
        Me.btn_BeamIOffset_Read.Text = "Read"
        Me.btn_BeamIOffset_Read.UseVisualStyleBackColor = True
        '
        'btn_Lens1pIGain_Set
        '
        Me.btn_Lens1pIGain_Set.Location = New System.Drawing.Point(149, 130)
        Me.btn_Lens1pIGain_Set.Name = "btn_Lens1pIGain_Set"
        Me.btn_Lens1pIGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1pIGain_Set.TabIndex = 425
        Me.btn_Lens1pIGain_Set.Text = "Set"
        Me.btn_Lens1pIGain_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens2IGain_Read
        '
        Me.btn_Lens2IGain_Read.Location = New System.Drawing.Point(149, 271)
        Me.btn_Lens2IGain_Read.Name = "btn_Lens2IGain_Read"
        Me.btn_Lens2IGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens2IGain_Read.TabIndex = 444
        Me.btn_Lens2IGain_Read.Text = "Read"
        Me.btn_Lens2IGain_Read.UseVisualStyleBackColor = True
        '
        'btn_HeaterIGain_Set
        '
        Me.btn_HeaterIGain_Set.Location = New System.Drawing.Point(149, 417)
        Me.btn_HeaterIGain_Set.Name = "btn_HeaterIGain_Set"
        Me.btn_HeaterIGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_HeaterIGain_Set.TabIndex = 466
        Me.btn_HeaterIGain_Set.Text = "Set"
        Me.btn_HeaterIGain_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens1pIGain_Read
        '
        Me.btn_Lens1pIGain_Read.Location = New System.Drawing.Point(149, 154)
        Me.btn_Lens1pIGain_Read.Name = "btn_Lens1pIGain_Read"
        Me.btn_Lens1pIGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1pIGain_Read.TabIndex = 428
        Me.btn_Lens1pIGain_Read.Text = "Read"
        Me.btn_Lens1pIGain_Read.UseVisualStyleBackColor = True
        '
        'btn_HeaterIOffset_Set
        '
        Me.btn_HeaterIOffset_Set.Location = New System.Drawing.Point(275, 417)
        Me.btn_HeaterIOffset_Set.Name = "btn_HeaterIOffset_Set"
        Me.btn_HeaterIOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_HeaterIOffset_Set.TabIndex = 467
        Me.btn_HeaterIOffset_Set.Text = "Set"
        Me.btn_HeaterIOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens1pIOffset_Read
        '
        Me.btn_Lens1pIOffset_Read.Location = New System.Drawing.Point(275, 154)
        Me.btn_Lens1pIOffset_Read.Name = "btn_Lens1pIOffset_Read"
        Me.btn_Lens1pIOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1pIOffset_Read.TabIndex = 430
        Me.btn_Lens1pIOffset_Read.Text = "Read"
        Me.btn_Lens1pIOffset_Read.UseVisualStyleBackColor = True
        '
        'btn_Lens2IOffset_Set
        '
        Me.btn_Lens2IOffset_Set.Location = New System.Drawing.Point(275, 247)
        Me.btn_Lens2IOffset_Set.Name = "btn_Lens2IOffset_Set"
        Me.btn_Lens2IOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens2IOffset_Set.TabIndex = 442
        Me.btn_Lens2IOffset_Set.Text = "Set"
        Me.btn_Lens2IOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens2IGain_Set
        '
        Me.btn_Lens2IGain_Set.Location = New System.Drawing.Point(149, 247)
        Me.btn_Lens2IGain_Set.Name = "btn_Lens2IGain_Set"
        Me.btn_Lens2IGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens2IGain_Set.TabIndex = 441
        Me.btn_Lens2IGain_Set.Text = "Set"
        Me.btn_Lens2IGain_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens1nIGain_Set
        '
        Me.btn_Lens1nIGain_Set.Location = New System.Drawing.Point(149, 190)
        Me.btn_Lens1nIGain_Set.Name = "btn_Lens1nIGain_Set"
        Me.btn_Lens1nIGain_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1nIGain_Set.TabIndex = 433
        Me.btn_Lens1nIGain_Set.Text = "Set"
        Me.btn_Lens1nIGain_Set.UseVisualStyleBackColor = True
        '
        'btn_HeaterIGain_Read
        '
        Me.btn_HeaterIGain_Read.Location = New System.Drawing.Point(149, 441)
        Me.btn_HeaterIGain_Read.Name = "btn_HeaterIGain_Read"
        Me.btn_HeaterIGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_HeaterIGain_Read.TabIndex = 469
        Me.btn_HeaterIGain_Read.Text = "Read"
        Me.btn_HeaterIGain_Read.UseVisualStyleBackColor = True
        '
        'btn_Lens1nIOffset_Set
        '
        Me.btn_Lens1nIOffset_Set.Location = New System.Drawing.Point(275, 190)
        Me.btn_Lens1nIOffset_Set.Name = "btn_Lens1nIOffset_Set"
        Me.btn_Lens1nIOffset_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1nIOffset_Set.TabIndex = 434
        Me.btn_Lens1nIOffset_Set.Text = "Set"
        Me.btn_Lens1nIOffset_Set.UseVisualStyleBackColor = True
        '
        'btn_Lens1nIGain_Read
        '
        Me.btn_Lens1nIGain_Read.Location = New System.Drawing.Point(149, 213)
        Me.btn_Lens1nIGain_Read.Name = "btn_Lens1nIGain_Read"
        Me.btn_Lens1nIGain_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1nIGain_Read.TabIndex = 436
        Me.btn_Lens1nIGain_Read.Text = "Read"
        Me.btn_Lens1nIGain_Read.UseVisualStyleBackColor = True
        '
        'btn_HeaterIOffset_Read
        '
        Me.btn_HeaterIOffset_Read.Location = New System.Drawing.Point(275, 441)
        Me.btn_HeaterIOffset_Read.Name = "btn_HeaterIOffset_Read"
        Me.btn_HeaterIOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_HeaterIOffset_Read.TabIndex = 471
        Me.btn_HeaterIOffset_Read.Text = "Read"
        Me.btn_HeaterIOffset_Read.UseVisualStyleBackColor = True
        '
        'btn_Lens1nIOffset_Read
        '
        Me.btn_Lens1nIOffset_Read.Location = New System.Drawing.Point(275, 213)
        Me.btn_Lens1nIOffset_Read.Name = "btn_Lens1nIOffset_Read"
        Me.btn_Lens1nIOffset_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_Lens1nIOffset_Read.TabIndex = 438
        Me.btn_Lens1nIOffset_Read.Text = "Read"
        Me.btn_Lens1nIOffset_Read.UseVisualStyleBackColor = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Label50.Location = New System.Drawing.Point(127, 22)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(100, 22)
        Me.Label50.TabIndex = 474
        Me.Label50.Text = "Set Value"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(456, 316)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(34, 13)
        Me.Label38.TabIndex = 193
        Me.Label38.Text = "Read"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(386, 317)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(27, 13)
        Me.Label37.TabIndex = 192
        Me.Label37.Text = "Set"
        '
        'TextBox42
        '
        Me.TextBox42.Location = New System.Drawing.Point(443, 333)
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(58, 20)
        Me.TextBox42.TabIndex = 191
        '
        'TextBox41
        '
        Me.TextBox41.Location = New System.Drawing.Point(369, 333)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(58, 20)
        Me.TextBox41.TabIndex = 190
        '
        'Btn_ECLim
        '
        Me.Btn_ECLim.Location = New System.Drawing.Point(512, 334)
        Me.Btn_ECLim.Name = "Btn_ECLim"
        Me.Btn_ECLim.Size = New System.Drawing.Size(50, 20)
        Me.Btn_ECLim.TabIndex = 189
        Me.Btn_ECLim.Text = "Read"
        Me.Btn_ECLim.UseVisualStyleBackColor = True
        '
        'NuExtCurrentLim
        '
        Me.NuExtCurrentLim.DecimalPlaces = 1
        Me.NuExtCurrentLim.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NuExtCurrentLim.Location = New System.Drawing.Point(223, 330)
        Me.NuExtCurrentLim.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.NuExtCurrentLim.Name = "NuExtCurrentLim"
        Me.NuExtCurrentLim.Size = New System.Drawing.Size(87, 20)
        Me.NuExtCurrentLim.TabIndex = 188
        Me.NuExtCurrentLim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(45, 334)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(168, 13)
        Me.Label36.TabIndex = 187
        Me.Label36.Text = "Extractor Current Limit (uA)"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(566, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 13)
        Me.Label24.TabIndex = 186
        Me.Label24.Text = "USE"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Off", "L1", "L2"})
        Me.ComboBox1.Location = New System.Drawing.Point(225, 252)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(61, 21)
        Me.ComboBox1.TabIndex = 183
        '
        'cbEmissionControl
        '
        Me.cbEmissionControl.AutoSize = True
        Me.cbEmissionControl.Location = New System.Drawing.Point(203, 223)
        Me.cbEmissionControl.Name = "cbEmissionControl"
        Me.cbEmissionControl.Size = New System.Drawing.Size(15, 14)
        Me.cbEmissionControl.TabIndex = 182
        Me.cbEmissionControl.UseVisualStyleBackColor = True
        '
        'nuEmissionControl
        '
        Me.nuEmissionControl.DecimalPlaces = 3
        Me.nuEmissionControl.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nuEmissionControl.Location = New System.Drawing.Point(225, 221)
        Me.nuEmissionControl.Name = "nuEmissionControl"
        Me.nuEmissionControl.Size = New System.Drawing.Size(87, 20)
        Me.nuEmissionControl.TabIndex = 181
        Me.nuEmissionControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rbOn
        '
        Me.rbOn.AutoSize = True
        Me.rbOn.Location = New System.Drawing.Point(35, 23)
        Me.rbOn.Name = "rbOn"
        Me.rbOn.Size = New System.Drawing.Size(69, 17)
        Me.rbOn.TabIndex = 180
        Me.rbOn.Text = "Control"
        Me.rbOn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(513, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 24)
        Me.Button2.TabIndex = 179
        Me.Button2.Text = "Graph"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbLog
        '
        Me.cbLog.AutoSize = True
        Me.cbLog.Location = New System.Drawing.Point(429, 288)
        Me.cbLog.Name = "cbLog"
        Me.cbLog.Size = New System.Drawing.Size(46, 17)
        Me.cbLog.TabIndex = 175
        Me.cbLog.Text = "Log"
        Me.cbLog.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.Location = New System.Drawing.Point(574, 226)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox6.TabIndex = 174
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.Location = New System.Drawing.Point(574, 187)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox5.TabIndex = 174
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Location = New System.Drawing.Point(574, 159)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 174
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Location = New System.Drawing.Point(574, 130)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 174
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(574, 101)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 174
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox0
        '
        Me.CheckBox0.AutoSize = True
        Me.CheckBox0.Checked = True
        Me.CheckBox0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox0.Location = New System.Drawing.Point(574, 44)
        Me.CheckBox0.Name = "CheckBox0"
        Me.CheckBox0.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox0.TabIndex = 174
        Me.CheckBox0.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(574, 73)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 174
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(229, 289)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(83, 20)
        Me.NumericUpDown1.TabIndex = 173
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'cbReadBack
        '
        Me.cbReadBack.AutoSize = True
        Me.cbReadBack.Location = New System.Drawing.Point(337, 288)
        Me.cbReadBack.Name = "cbReadBack"
        Me.cbReadBack.Size = New System.Drawing.Size(80, 17)
        Me.cbReadBack.TabIndex = 171
        Me.cbReadBack.Text = "ReadBack"
        Me.cbReadBack.UseVisualStyleBackColor = True
        '
        'bReadBack
        '
        Me.bReadBack.Location = New System.Drawing.Point(112, 288)
        Me.bReadBack.Name = "bReadBack"
        Me.bReadBack.Size = New System.Drawing.Size(101, 24)
        Me.bReadBack.TabIndex = 170
        Me.bReadBack.Text = "Read"
        Me.bReadBack.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(454, 69)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(94, 20)
        Me.TextBox3.TabIndex = 169
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox12
        '
        Me.TextBox12.Enabled = False
        Me.TextBox12.Location = New System.Drawing.Point(330, 222)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(101, 20)
        Me.TextBox12.TabIndex = 169
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(454, 184)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(94, 20)
        Me.TextBox11.TabIndex = 169
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(330, 184)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(101, 20)
        Me.TextBox10.TabIndex = 169
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(454, 155)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(94, 20)
        Me.TextBox9.TabIndex = 169
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(330, 155)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(101, 20)
        Me.TextBox8.TabIndex = 169
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(454, 126)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(94, 20)
        Me.TextBox7.TabIndex = 169
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(330, 126)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(101, 20)
        Me.TextBox6.TabIndex = 169
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(454, 98)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(94, 20)
        Me.TextBox5.TabIndex = 169
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(330, 98)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(101, 20)
        Me.TextBox4.TabIndex = 169
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(330, 69)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(101, 20)
        Me.TextBox2.TabIndex = 169
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(454, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(94, 20)
        Me.TextBox1.TabIndex = 169
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox0
        '
        Me.TextBox0.Enabled = False
        Me.TextBox0.Location = New System.Drawing.Point(330, 42)
        Me.TextBox0.Name = "TextBox0"
        Me.TextBox0.Size = New System.Drawing.Size(101, 20)
        Me.TextBox0.TabIndex = 169
        Me.TextBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(126, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Suppressor (V)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "Lens1 (V)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 13)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "Emission Current (mA)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Lens2 (V)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Heater (A)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Extractor (V)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(113, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "Beam Energy (V)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Wobble"
        '
        'nuSuppressor
        '
        Me.nuSuppressor.DecimalPlaces = 1
        Me.nuSuppressor.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nuSuppressor.Location = New System.Drawing.Point(225, 70)
        Me.nuSuppressor.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nuSuppressor.Minimum = New Decimal(New Integer() {2500, 0, 0, -2147483648})
        Me.nuSuppressor.Name = "nuSuppressor"
        Me.nuSuppressor.Size = New System.Drawing.Size(87, 20)
        Me.nuSuppressor.TabIndex = 164
        Me.nuSuppressor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nuLens1
        '
        Me.nuLens1.DecimalPlaces = 1
        Me.nuLens1.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nuLens1.Location = New System.Drawing.Point(225, 153)
        Me.nuLens1.Maximum = New Decimal(New Integer() {30000, 0, 0, 0})
        Me.nuLens1.Minimum = New Decimal(New Integer() {30000, 0, 0, -2147483648})
        Me.nuLens1.Name = "nuLens1"
        Me.nuLens1.Size = New System.Drawing.Size(87, 20)
        Me.nuLens1.TabIndex = 164
        Me.nuLens1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nuLens2
        '
        Me.nuLens2.DecimalPlaces = 1
        Me.nuLens2.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nuLens2.Location = New System.Drawing.Point(225, 180)
        Me.nuLens2.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
        Me.nuLens2.Name = "nuLens2"
        Me.nuLens2.Size = New System.Drawing.Size(87, 20)
        Me.nuLens2.TabIndex = 164
        Me.nuLens2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nuFilamentHeater
        '
        Me.nuFilamentHeater.DecimalPlaces = 3
        Me.nuFilamentHeater.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nuFilamentHeater.Location = New System.Drawing.Point(225, 126)
        Me.nuFilamentHeater.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nuFilamentHeater.Name = "nuFilamentHeater"
        Me.nuFilamentHeater.Size = New System.Drawing.Size(87, 20)
        Me.nuFilamentHeater.TabIndex = 164
        Me.nuFilamentHeater.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nuExtractor
        '
        Me.nuExtractor.DecimalPlaces = 1
        Me.nuExtractor.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nuExtractor.Location = New System.Drawing.Point(225, 98)
        Me.nuExtractor.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nuExtractor.Minimum = New Decimal(New Integer() {15000, 0, 0, -2147483648})
        Me.nuExtractor.Name = "nuExtractor"
        Me.nuExtractor.Size = New System.Drawing.Size(87, 20)
        Me.nuExtractor.TabIndex = 164
        Me.nuExtractor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nuBeamEnergy
        '
        Me.nuBeamEnergy.DecimalPlaces = 1
        Me.nuBeamEnergy.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nuBeamEnergy.Location = New System.Drawing.Point(225, 43)
        Me.nuBeamEnergy.Maximum = New Decimal(New Integer() {35000, 0, 0, 0})
        Me.nuBeamEnergy.Name = "nuBeamEnergy"
        Me.nuBeamEnergy.Size = New System.Drawing.Size(87, 20)
        Me.nuBeamEnergy.TabIndex = 164
        Me.nuBeamEnergy.Tag = ""
        Me.nuBeamEnergy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nuWobble
        '
        Me.nuWobble.DecimalPlaces = 1
        Me.nuWobble.Location = New System.Drawing.Point(294, 252)
        Me.nuWobble.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nuWobble.Name = "nuWobble"
        Me.nuWobble.Size = New System.Drawing.Size(71, 20)
        Me.nuWobble.TabIndex = 164
        Me.nuWobble.Tag = ""
        Me.nuWobble.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label85.Location = New System.Drawing.Point(433, 228)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(25, 13)
        Me.Label85.TabIndex = 376
        Me.Label85.Text = "mA"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label84.Location = New System.Drawing.Point(549, 189)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(22, 13)
        Me.Label84.TabIndex = 375
        Me.Label84.Text = "uA"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label83.Location = New System.Drawing.Point(551, 159)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(22, 13)
        Me.Label83.TabIndex = 374
        Me.Label83.Text = "uA"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label82.Location = New System.Drawing.Point(549, 102)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(22, 13)
        Me.Label82.TabIndex = 373
        Me.Label82.Text = "uA"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label81.Location = New System.Drawing.Point(549, 74)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(22, 13)
        Me.Label81.TabIndex = 372
        Me.Label81.Text = "uA"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label80.Location = New System.Drawing.Point(549, 47)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(22, 13)
        Me.Label80.TabIndex = 371
        Me.Label80.Text = "uA"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label79.Location = New System.Drawing.Point(551, 131)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(15, 13)
        Me.Label79.TabIndex = 370
        Me.Label79.Text = "V"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label78.Location = New System.Drawing.Point(432, 131)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(15, 13)
        Me.Label78.TabIndex = 369
        Me.Label78.Text = "A"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label77.Location = New System.Drawing.Point(432, 189)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(15, 13)
        Me.Label77.TabIndex = 368
        Me.Label77.Text = "V"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label76.Location = New System.Drawing.Point(432, 160)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(15, 13)
        Me.Label76.TabIndex = 367
        Me.Label76.Text = "V"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label75.Location = New System.Drawing.Point(432, 103)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(15, 13)
        Me.Label75.TabIndex = 366
        Me.Label75.Text = "V"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label74.Location = New System.Drawing.Point(432, 73)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(15, 13)
        Me.Label74.TabIndex = 365
        Me.Label74.Text = "V"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label73.Location = New System.Drawing.Point(432, 46)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(15, 13)
        Me.Label73.TabIndex = 364
        Me.Label73.Text = "V"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label62.Location = New System.Drawing.Point(35, 183)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(68, 13)
        Me.Label62.TabIndex = 199
        Me.Label62.Text = "max +20kV"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label61.Location = New System.Drawing.Point(35, 157)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(74, 13)
        Me.Label61.TabIndex = 198
        Me.Label61.Text = "max ±30kV"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label60.Location = New System.Drawing.Point(35, 130)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(58, 13)
        Me.Label60.TabIndex = 197
        Me.Label60.Text = "max 4.0A"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label59.Location = New System.Drawing.Point(35, 75)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(71, 13)
        Me.Label59.TabIndex = 196
        Me.Label59.Text = "max -2.5kV"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label58.Location = New System.Drawing.Point(35, 47)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(68, 13)
        Me.Label58.TabIndex = 195
        Me.Label58.Text = "max +35kV"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label57.Location = New System.Drawing.Point(35, 102)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(68, 13)
        Me.Label57.TabIndex = 194
        Me.Label57.Text = "max -15kV"
        '
        'Btn_EMS
        '
        Me.Btn_EMS.BackColor = System.Drawing.Color.Red
        Me.Btn_EMS.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Btn_EMS.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn_EMS.Location = New System.Drawing.Point(811, 0)
        Me.Btn_EMS.Name = "Btn_EMS"
        Me.Btn_EMS.Size = New System.Drawing.Size(183, 70)
        Me.Btn_EMS.TabIndex = 349
        Me.Btn_EMS.Text = "EMERGENCY STOP"
        Me.Btn_EMS.UseVisualStyleBackColor = False
        '
        'btn_DG406_Set
        '
        Me.btn_DG406_Set.Location = New System.Drawing.Point(512, 34)
        Me.btn_DG406_Set.Name = "btn_DG406_Set"
        Me.btn_DG406_Set.Size = New System.Drawing.Size(50, 21)
        Me.btn_DG406_Set.TabIndex = 350
        Me.btn_DG406_Set.Text = "Set"
        Me.btn_DG406_Set.UseVisualStyleBackColor = True
        '
        'btn_DG406_Read
        '
        Me.btn_DG406_Read.Location = New System.Drawing.Point(512, 62)
        Me.btn_DG406_Read.Name = "btn_DG406_Read"
        Me.btn_DG406_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_DG406_Read.TabIndex = 352
        Me.btn_DG406_Read.Text = "Read"
        Me.btn_DG406_Read.UseVisualStyleBackColor = True
        '
        'txt_DG406_R
        '
        Me.txt_DG406_R.Location = New System.Drawing.Point(352, 62)
        Me.txt_DG406_R.Name = "txt_DG406_R"
        Me.txt_DG406_R.Size = New System.Drawing.Size(59, 20)
        Me.txt_DG406_R.TabIndex = 353
        Me.txt_DG406_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DG406_Sel
        '
        Me.DG406_Sel.FormattingEnabled = True
        Me.DG406_Sel.Items.AddRange(New Object() {"00 L1_Lev", "01 L2_Lev", "02 BEAM_Lev", "03 BEAM_V", "04 BEAM_I", "05 L1_V", "06 L1_I", "07 L2_V", "08 L2_I", "09 BUS_V", "0A BEAM_24V", "0B L2_24V", "0C L1_24V", "0D 10V_REF", "0E GND_REF", "FF NORMAL"})
        Me.DG406_Sel.Location = New System.Drawing.Point(352, 33)
        Me.DG406_Sel.Name = "DG406_Sel"
        Me.DG406_Sel.Size = New System.Drawing.Size(110, 21)
        Me.DG406_Sel.TabIndex = 354
        '
        'txt_DG406
        '
        Me.txt_DG406.Location = New System.Drawing.Point(472, 33)
        Me.txt_DG406.Name = "txt_DG406"
        Me.txt_DG406.Size = New System.Drawing.Size(32, 20)
        Me.txt_DG406.TabIndex = 355
        Me.txt_DG406.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_DG406_R2
        '
        Me.txt_DG406_R2.Location = New System.Drawing.Point(427, 62)
        Me.txt_DG406_R2.Name = "txt_DG406_R2"
        Me.txt_DG406_R2.Size = New System.Drawing.Size(77, 20)
        Me.txt_DG406_R2.TabIndex = 356
        Me.txt_DG406_R2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(350, 15)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(168, 13)
        Me.Label55.TabIndex = 357
        Me.Label55.Text = "検査モード(マルチプレクサ選択)"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(146, 22)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(101, 13)
        Me.Label56.TabIndex = 358
        Me.Label56.Text = "DG406_応答速度"
        '
        'txt_DG406_Speed
        '
        Me.txt_DG406_Speed.Location = New System.Drawing.Point(220, 43)
        Me.txt_DG406_Speed.Name = "txt_DG406_Speed"
        Me.txt_DG406_Speed.Size = New System.Drawing.Size(32, 20)
        Me.txt_DG406_Speed.TabIndex = 361
        Me.txt_DG406_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DG406_Speed_Sel
        '
        Me.DG406_Speed_Sel.FormattingEnabled = True
        Me.DG406_Speed_Sel.Items.AddRange(New Object() {"00 HSpeed_LReso", "01", "02", "03", "04", "05", "06", "07", "08", "09", "0A LSpeed_HReso"})
        Me.DG406_Speed_Sel.Location = New System.Drawing.Point(146, 43)
        Me.DG406_Speed_Sel.Name = "DG406_Speed_Sel"
        Me.DG406_Speed_Sel.Size = New System.Drawing.Size(65, 21)
        Me.DG406_Speed_Sel.TabIndex = 360
        '
        'btn_DG406_Speed
        '
        Me.btn_DG406_Speed.Location = New System.Drawing.Point(260, 44)
        Me.btn_DG406_Speed.Name = "btn_DG406_Speed"
        Me.btn_DG406_Speed.Size = New System.Drawing.Size(50, 21)
        Me.btn_DG406_Speed.TabIndex = 359
        Me.btn_DG406_Speed.Text = "Set"
        Me.btn_DG406_Speed.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(870, 46)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 25)
        Me.Button3.TabIndex = 362
        Me.Button3.Text = "FileSelect"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBoxLogFile
        '
        Me.TextBoxLogFile.Location = New System.Drawing.Point(673, 48)
        Me.TextBoxLogFile.Name = "TextBoxLogFile"
        Me.TextBoxLogFile.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxLogFile.TabIndex = 363
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Location = New System.Drawing.Point(10, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(993, 596)
        Me.TabControl1.TabIndex = 487
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label88)
        Me.TabPage3.Controls.Add(Me.GroupBox8)
        Me.TabPage3.Controls.Add(Me.TextBoxLogFile)
        Me.TabPage3.Controls.Add(Me.GroupBox7)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox10)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(985, 569)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "CONTROL"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(713, 30)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(107, 13)
        Me.Label88.TabIndex = 365
        Me.Label88.Text = "Readback Log File"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label91)
        Me.GroupBox8.Controls.Add(Me.btn_PWM_Freq_Set)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.txt_PWM_Freq)
        Me.GroupBox8.Controls.Add(Me.txt_PWM_Freq_R)
        Me.GroupBox8.Controls.Add(Me.btn_PWM_Freq_Read)
        Me.GroupBox8.Controls.Add(Me.Label19)
        Me.GroupBox8.Controls.Add(Me.btn_PWM_Duty_Set)
        Me.GroupBox8.Controls.Add(Me.Label21)
        Me.GroupBox8.Controls.Add(Me.txt_PWM_Duty)
        Me.GroupBox8.Controls.Add(Me.btn_PWM_DT_Read)
        Me.GroupBox8.Controls.Add(Me.Label20)
        Me.GroupBox8.Controls.Add(Me.txt_PWM_DeadTime_R)
        Me.GroupBox8.Controls.Add(Me.txt_PWM_Duty_R)
        Me.GroupBox8.Controls.Add(Me.btn_PWM_DT_Set)
        Me.GroupBox8.Controls.Add(Me.txt_PWM_DeadTime)
        Me.GroupBox8.Controls.Add(Me.btn_PWM_Duty_Read)
        Me.GroupBox8.Location = New System.Drawing.Point(656, 364)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(294, 193)
        Me.GroupBox8.TabIndex = 364
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Float 24V PS Setting"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Location = New System.Drawing.Point(35, 89)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(35, 13)
        Me.Label91.TabIndex = 266
        Me.Label91.Text = "PWM"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txt_DG406_SPEED_R2)
        Me.GroupBox7.Controls.Add(Me.txt_DG406_SPEED_R)
        Me.GroupBox7.Controls.Add(Me.btn_DG406_Speed_Read)
        Me.GroupBox7.Controls.Add(Me.Label56)
        Me.GroupBox7.Controls.Add(Me.btn_DG406_Speed)
        Me.GroupBox7.Controls.Add(Me.DG406_Speed_Sel)
        Me.GroupBox7.Controls.Add(Me.btn_DG406_Set)
        Me.GroupBox7.Controls.Add(Me.txt_DG406_Speed)
        Me.GroupBox7.Controls.Add(Me.btn_DG406_Read)
        Me.GroupBox7.Controls.Add(Me.Label55)
        Me.GroupBox7.Controls.Add(Me.txt_DG406_R)
        Me.GroupBox7.Controls.Add(Me.txt_DG406_R2)
        Me.GroupBox7.Controls.Add(Me.DG406_Sel)
        Me.GroupBox7.Controls.Add(Me.txt_DG406)
        Me.GroupBox7.Location = New System.Drawing.Point(19, 466)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(614, 91)
        Me.GroupBox7.TabIndex = 363
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "DG406"
        '
        'txt_DG406_SPEED_R2
        '
        Me.txt_DG406_SPEED_R2.BackColor = System.Drawing.SystemColors.Control
        Me.txt_DG406_SPEED_R2.Location = New System.Drawing.Point(182, 69)
        Me.txt_DG406_SPEED_R2.Name = "txt_DG406_SPEED_R2"
        Me.txt_DG406_SPEED_R2.Size = New System.Drawing.Size(72, 20)
        Me.txt_DG406_SPEED_R2.TabIndex = 364
        '
        'txt_DG406_SPEED_R
        '
        Me.txt_DG406_SPEED_R.BackColor = System.Drawing.SystemColors.Control
        Me.txt_DG406_SPEED_R.Location = New System.Drawing.Point(146, 69)
        Me.txt_DG406_SPEED_R.Name = "txt_DG406_SPEED_R"
        Me.txt_DG406_SPEED_R.Size = New System.Drawing.Size(32, 20)
        Me.txt_DG406_SPEED_R.TabIndex = 363
        '
        'btn_DG406_Speed_Read
        '
        Me.btn_DG406_Speed_Read.Location = New System.Drawing.Point(262, 69)
        Me.btn_DG406_Speed_Read.Name = "btn_DG406_Speed_Read"
        Me.btn_DG406_Speed_Read.Size = New System.Drawing.Size(50, 21)
        Me.btn_DG406_Speed_Read.TabIndex = 362
        Me.btn_DG406_Speed_Read.Text = "Read"
        Me.btn_DG406_Speed_Read.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label85)
        Me.GroupBox6.Controls.Add(Me.rbOn)
        Me.GroupBox6.Controls.Add(Me.Label84)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Label83)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label82)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label81)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label80)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label79)
        Me.GroupBox6.Controls.Add(Me.nuEmissionControl)
        Me.GroupBox6.Controls.Add(Me.Label78)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label77)
        Me.GroupBox6.Controls.Add(Me.cbEmissionControl)
        Me.GroupBox6.Controls.Add(Me.Label76)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label75)
        Me.GroupBox6.Controls.Add(Me.ComboBox1)
        Me.GroupBox6.Controls.Add(Me.Label74)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.Label73)
        Me.GroupBox6.Controls.Add(Me.nuSuppressor)
        Me.GroupBox6.Controls.Add(Me.Label38)
        Me.GroupBox6.Controls.Add(Me.Label62)
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.nuLens1)
        Me.GroupBox6.Controls.Add(Me.Label37)
        Me.GroupBox6.Controls.Add(Me.Label61)
        Me.GroupBox6.Controls.Add(Me.TextBox42)
        Me.GroupBox6.Controls.Add(Me.nuLens2)
        Me.GroupBox6.Controls.Add(Me.TextBox41)
        Me.GroupBox6.Controls.Add(Me.Label60)
        Me.GroupBox6.Controls.Add(Me.Btn_ECLim)
        Me.GroupBox6.Controls.Add(Me.nuFilamentHeater)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.NuExtCurrentLim)
        Me.GroupBox6.Controls.Add(Me.cbLog)
        Me.GroupBox6.Controls.Add(Me.Label59)
        Me.GroupBox6.Controls.Add(Me.CheckBox6)
        Me.GroupBox6.Controls.Add(Me.Label36)
        Me.GroupBox6.Controls.Add(Me.CheckBox5)
        Me.GroupBox6.Controls.Add(Me.nuExtractor)
        Me.GroupBox6.Controls.Add(Me.TextBox0)
        Me.GroupBox6.Controls.Add(Me.CheckBox4)
        Me.GroupBox6.Controls.Add(Me.Label58)
        Me.GroupBox6.Controls.Add(Me.TextBox1)
        Me.GroupBox6.Controls.Add(Me.nuBeamEnergy)
        Me.GroupBox6.Controls.Add(Me.CheckBox3)
        Me.GroupBox6.Controls.Add(Me.Label57)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.nuWobble)
        Me.GroupBox6.Controls.Add(Me.CheckBox2)
        Me.GroupBox6.Controls.Add(Me.bReadBack)
        Me.GroupBox6.Controls.Add(Me.TextBox4)
        Me.GroupBox6.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox6.Controls.Add(Me.CheckBox0)
        Me.GroupBox6.Controls.Add(Me.TextBox11)
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.Controls.Add(Me.TextBox12)
        Me.GroupBox6.Controls.Add(Me.CheckBox1)
        Me.GroupBox6.Controls.Add(Me.TextBox10)
        Me.GroupBox6.Controls.Add(Me.TextBox6)
        Me.GroupBox6.Controls.Add(Me.TextBox3)
        Me.GroupBox6.Controls.Add(Me.TextBox7)
        Me.GroupBox6.Controls.Add(Me.TextBox9)
        Me.GroupBox6.Controls.Add(Me.cbReadBack)
        Me.GroupBox6.Controls.Add(Me.TextBox8)
        Me.GroupBox6.Location = New System.Drawing.Point(19, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(614, 368)
        Me.GroupBox6.TabIndex = 362
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Manual Cntrol"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtTestMsg)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(985, 569)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "TEST"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtTestMsg
        '
        Me.txtTestMsg.Location = New System.Drawing.Point(440, 35)
        Me.txtTestMsg.Multiline = True
        Me.txtTestMsg.Name = "txtTestMsg"
        Me.txtTestMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTestMsg.Size = New System.Drawing.Size(514, 522)
        Me.txtTestMsg.TabIndex = 494
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label94)
        Me.GroupBox5.Controls.Add(Me.Label93)
        Me.GroupBox5.Controls.Add(Me.tbCheckExtr)
        Me.GroupBox5.Controls.Add(Me.tbCheckSup)
        Me.GroupBox5.Controls.Add(Me.tbCheckHeat)
        Me.GroupBox5.Controls.Add(Me.btPass10)
        Me.GroupBox5.Controls.Add(Me.btPass9)
        Me.GroupBox5.Controls.Add(Me.btPass8)
        Me.GroupBox5.Controls.Add(Me.btPass7)
        Me.GroupBox5.Controls.Add(Me.btPass6)
        Me.GroupBox5.Controls.Add(Me.btPass5)
        Me.GroupBox5.Controls.Add(Me.btPass4)
        Me.GroupBox5.Controls.Add(Me.btPass3)
        Me.GroupBox5.Controls.Add(Me.btPass2)
        Me.GroupBox5.Controls.Add(Me.btPass1)
        Me.GroupBox5.Controls.Add(Me.rbFinal)
        Me.GroupBox5.Controls.Add(Me.rbPrePotting)
        Me.GroupBox5.Controls.Add(Me.btnTestRun)
        Me.GroupBox5.Controls.Add(Me.btnTestAll)
        Me.GroupBox5.Controls.Add(Me.cbTest10)
        Me.GroupBox5.Controls.Add(Me.cbTest9)
        Me.GroupBox5.Controls.Add(Me.cbTest6)
        Me.GroupBox5.Controls.Add(Me.cbTest8)
        Me.GroupBox5.Controls.Add(Me.cbTest7)
        Me.GroupBox5.Controls.Add(Me.cbTest5)
        Me.GroupBox5.Controls.Add(Me.cbTest4)
        Me.GroupBox5.Controls.Add(Me.Label87)
        Me.GroupBox5.Controls.Add(Me.tbSirialNum)
        Me.GroupBox5.Controls.Add(Me.cbTest1)
        Me.GroupBox5.Controls.Add(Me.cbTest3)
        Me.GroupBox5.Controls.Add(Me.cbTest2)
        Me.GroupBox5.Location = New System.Drawing.Point(26, 28)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(384, 430)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TEST "
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Location = New System.Drawing.Point(253, 137)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(69, 13)
        Me.Label94.TabIndex = 389
        Me.Label94.Text = "Number of "
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Location = New System.Drawing.Point(260, 153)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(49, 13)
        Me.Label93.TabIndex = 388
        Me.Label93.Text = "Checks"
        '
        'tbCheckExtr
        '
        Me.tbCheckExtr.Location = New System.Drawing.Point(268, 319)
        Me.tbCheckExtr.Name = "tbCheckExtr"
        Me.tbCheckExtr.ReadOnly = True
        Me.tbCheckExtr.Size = New System.Drawing.Size(35, 20)
        Me.tbCheckExtr.TabIndex = 387
        Me.tbCheckExtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCheckSup
        '
        Me.tbCheckSup.Location = New System.Drawing.Point(268, 294)
        Me.tbCheckSup.Name = "tbCheckSup"
        Me.tbCheckSup.ReadOnly = True
        Me.tbCheckSup.Size = New System.Drawing.Size(35, 20)
        Me.tbCheckSup.TabIndex = 386
        Me.tbCheckSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCheckHeat
        '
        Me.tbCheckHeat.Location = New System.Drawing.Point(268, 269)
        Me.tbCheckHeat.Name = "tbCheckHeat"
        Me.tbCheckHeat.ReadOnly = True
        Me.tbCheckHeat.Size = New System.Drawing.Size(35, 20)
        Me.tbCheckHeat.TabIndex = 385
        Me.tbCheckHeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btPass10
        '
        Me.btPass10.BackColor = System.Drawing.Color.Transparent
        Me.btPass10.Enabled = False
        Me.btPass10.Location = New System.Drawing.Point(169, 388)
        Me.btPass10.Name = "btPass10"
        Me.btPass10.Size = New System.Drawing.Size(62, 21)
        Me.btPass10.TabIndex = 384
        Me.btPass10.Text = "PASS"
        Me.btPass10.UseVisualStyleBackColor = False
        '
        'btPass9
        '
        Me.btPass9.BackColor = System.Drawing.Color.Transparent
        Me.btPass9.Enabled = False
        Me.btPass9.Location = New System.Drawing.Point(169, 364)
        Me.btPass9.Name = "btPass9"
        Me.btPass9.Size = New System.Drawing.Size(62, 21)
        Me.btPass9.TabIndex = 383
        Me.btPass9.Text = "PASS"
        Me.btPass9.UseVisualStyleBackColor = False
        '
        'btPass8
        '
        Me.btPass8.BackColor = System.Drawing.Color.Transparent
        Me.btPass8.Enabled = False
        Me.btPass8.Location = New System.Drawing.Point(169, 341)
        Me.btPass8.Name = "btPass8"
        Me.btPass8.Size = New System.Drawing.Size(62, 21)
        Me.btPass8.TabIndex = 382
        Me.btPass8.Text = "PASS"
        Me.btPass8.UseVisualStyleBackColor = False
        '
        'btPass7
        '
        Me.btPass7.BackColor = System.Drawing.Color.Transparent
        Me.btPass7.Enabled = False
        Me.btPass7.Location = New System.Drawing.Point(169, 317)
        Me.btPass7.Name = "btPass7"
        Me.btPass7.Size = New System.Drawing.Size(62, 21)
        Me.btPass7.TabIndex = 381
        Me.btPass7.Text = "PASS"
        Me.btPass7.UseVisualStyleBackColor = False
        '
        'btPass6
        '
        Me.btPass6.BackColor = System.Drawing.Color.Transparent
        Me.btPass6.Enabled = False
        Me.btPass6.Location = New System.Drawing.Point(169, 294)
        Me.btPass6.Name = "btPass6"
        Me.btPass6.Size = New System.Drawing.Size(62, 21)
        Me.btPass6.TabIndex = 380
        Me.btPass6.Text = "PASS"
        Me.btPass6.UseVisualStyleBackColor = False
        '
        'btPass5
        '
        Me.btPass5.BackColor = System.Drawing.Color.Transparent
        Me.btPass5.Enabled = False
        Me.btPass5.Location = New System.Drawing.Point(169, 270)
        Me.btPass5.Name = "btPass5"
        Me.btPass5.Size = New System.Drawing.Size(62, 21)
        Me.btPass5.TabIndex = 379
        Me.btPass5.Text = "PASS"
        Me.btPass5.UseVisualStyleBackColor = False
        '
        'btPass4
        '
        Me.btPass4.BackColor = System.Drawing.Color.Transparent
        Me.btPass4.Enabled = False
        Me.btPass4.Location = New System.Drawing.Point(169, 245)
        Me.btPass4.Name = "btPass4"
        Me.btPass4.Size = New System.Drawing.Size(62, 21)
        Me.btPass4.TabIndex = 378
        Me.btPass4.Text = "PASS"
        Me.btPass4.UseVisualStyleBackColor = False
        '
        'btPass3
        '
        Me.btPass3.BackColor = System.Drawing.Color.Transparent
        Me.btPass3.Enabled = False
        Me.btPass3.Location = New System.Drawing.Point(169, 221)
        Me.btPass3.Name = "btPass3"
        Me.btPass3.Size = New System.Drawing.Size(62, 21)
        Me.btPass3.TabIndex = 377
        Me.btPass3.Text = "PASS"
        Me.btPass3.UseVisualStyleBackColor = False
        '
        'btPass2
        '
        Me.btPass2.BackColor = System.Drawing.Color.Transparent
        Me.btPass2.Enabled = False
        Me.btPass2.Location = New System.Drawing.Point(169, 197)
        Me.btPass2.Name = "btPass2"
        Me.btPass2.Size = New System.Drawing.Size(62, 21)
        Me.btPass2.TabIndex = 376
        Me.btPass2.Text = "PASS"
        Me.btPass2.UseVisualStyleBackColor = False
        '
        'btPass1
        '
        Me.btPass1.BackColor = System.Drawing.Color.Transparent
        Me.btPass1.Enabled = False
        Me.btPass1.Location = New System.Drawing.Point(169, 173)
        Me.btPass1.Name = "btPass1"
        Me.btPass1.Size = New System.Drawing.Size(62, 21)
        Me.btPass1.TabIndex = 375
        Me.btPass1.Text = "PASS"
        Me.btPass1.UseVisualStyleBackColor = False
        '
        'rbFinal
        '
        Me.rbFinal.AutoSize = True
        Me.rbFinal.Location = New System.Drawing.Point(22, 93)
        Me.rbFinal.Name = "rbFinal"
        Me.rbFinal.Size = New System.Drawing.Size(86, 17)
        Me.rbFinal.TabIndex = 374
        Me.rbFinal.Text = "Final TEST"
        Me.rbFinal.UseVisualStyleBackColor = True
        '
        'rbPrePotting
        '
        Me.rbPrePotting.AutoSize = True
        Me.rbPrePotting.Checked = True
        Me.rbPrePotting.Location = New System.Drawing.Point(22, 70)
        Me.rbPrePotting.Name = "rbPrePotting"
        Me.rbPrePotting.Size = New System.Drawing.Size(128, 17)
        Me.rbPrePotting.TabIndex = 373
        Me.rbPrePotting.TabStop = True
        Me.rbPrePotting.Text = "Pre-Potting TEST"
        Me.rbPrePotting.UseVisualStyleBackColor = True
        '
        'btnTestRun
        '
        Me.btnTestRun.Location = New System.Drawing.Point(255, 27)
        Me.btnTestRun.Name = "btnTestRun"
        Me.btnTestRun.Size = New System.Drawing.Size(110, 40)
        Me.btnTestRun.TabIndex = 255
        Me.btnTestRun.Text = "RUN"
        Me.btnTestRun.UseVisualStyleBackColor = True
        '
        'btnTestAll
        '
        Me.btnTestAll.Location = New System.Drawing.Point(40, 133)
        Me.btnTestAll.Name = "btnTestAll"
        Me.btnTestAll.Size = New System.Drawing.Size(119, 31)
        Me.btnTestAll.TabIndex = 254
        Me.btnTestAll.Text = "Deselect ALL"
        Me.btnTestAll.UseVisualStyleBackColor = True
        '
        'cbTest10
        '
        Me.cbTest10.AutoSize = True
        Me.cbTest10.Checked = True
        Me.cbTest10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTest10.Location = New System.Drawing.Point(43, 390)
        Me.cbTest10.Name = "cbTest10"
        Me.cbTest10.Size = New System.Drawing.Size(61, 17)
        Me.cbTest10.TabIndex = 372
        Me.cbTest10.Text = "10. L2"
        Me.cbTest10.UseVisualStyleBackColor = True
        '
        'cbTest9
        '
        Me.cbTest9.AutoSize = True
        Me.cbTest9.Checked = True
        Me.cbTest9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTest9.Location = New System.Drawing.Point(43, 366)
        Me.cbTest9.Name = "cbTest9"
        Me.cbTest9.Size = New System.Drawing.Size(54, 17)
        Me.cbTest9.TabIndex = 371
        Me.cbTest9.Text = "9. L1"
        Me.cbTest9.UseVisualStyleBackColor = True
        '
        'cbTest6
        '
        Me.cbTest6.AutoSize = True
        Me.cbTest6.Checked = True
        Me.cbTest6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTest6.Location = New System.Drawing.Point(43, 295)
        Me.cbTest6.Name = "cbTest6"
        Me.cbTest6.Size = New System.Drawing.Size(103, 17)
        Me.cbTest6.TabIndex = 368
        Me.cbTest6.Text = "6. Suppressor"
        Me.cbTest6.UseVisualStyleBackColor = True
        '
        'cbTest8
        '
        Me.cbTest8.AutoSize = True
        Me.cbTest8.Checked = True
        Me.cbTest8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTest8.Location = New System.Drawing.Point(43, 342)
        Me.cbTest8.Name = "cbTest8"
        Me.cbTest8.Size = New System.Drawing.Size(83, 17)
        Me.cbTest8.TabIndex = 370
        Me.cbTest8.Text = "8. Beam V"
        Me.cbTest8.UseVisualStyleBackColor = True
        '
        'cbTest7
        '
        Me.cbTest7.AutoSize = True
        Me.cbTest7.Checked = True
        Me.cbTest7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTest7.Location = New System.Drawing.Point(43, 319)
        Me.cbTest7.Name = "cbTest7"
        Me.cbTest7.Size = New System.Drawing.Size(93, 17)
        Me.cbTest7.TabIndex = 369
        Me.cbTest7.Text = "7. Extractor"
        Me.cbTest7.UseVisualStyleBackColor = True
        '
        'cbTest5
        '
        Me.cbTest5.AutoSize = True
        Me.cbTest5.Checked = True
        Me.cbTest5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTest5.Location = New System.Drawing.Point(43, 271)
        Me.cbTest5.Name = "cbTest5"
        Me.cbTest5.Size = New System.Drawing.Size(98, 17)
        Me.cbTest5.TabIndex = 367
        Me.cbTest5.Text = "5. Heater PS"
        Me.cbTest5.UseVisualStyleBackColor = True
        '
        'cbTest4
        '
        Me.cbTest4.AutoSize = True
        Me.cbTest4.Checked = True
        Me.cbTest4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTest4.Location = New System.Drawing.Point(43, 246)
        Me.cbTest4.Name = "cbTest4"
        Me.cbTest4.Size = New System.Drawing.Size(94, 17)
        Me.cbTest4.TabIndex = 366
        Me.cbTest4.Text = "4. 15V Float"
        Me.cbTest4.UseVisualStyleBackColor = True
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(21, 39)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(74, 13)
        Me.Label87.TabIndex = 365
        Me.Label87.Text = "SERIAL  No."
        '
        'tbSirialNum
        '
        Me.tbSirialNum.Location = New System.Drawing.Point(108, 35)
        Me.tbSirialNum.Name = "tbSirialNum"
        Me.tbSirialNum.Size = New System.Drawing.Size(139, 20)
        Me.tbSirialNum.TabIndex = 364
        '
        'cbTest1
        '
        Me.cbTest1.AutoSize = True
        Me.cbTest1.Checked = True
        Me.cbTest1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTest1.Location = New System.Drawing.Point(43, 174)
        Me.cbTest1.Name = "cbTest1"
        Me.cbTest1.Size = New System.Drawing.Size(113, 17)
        Me.cbTest1.TabIndex = 0
        Me.cbTest1.Text = "1. Status Tests"
        Me.cbTest1.UseVisualStyleBackColor = True
        '
        'cbTest3
        '
        Me.cbTest3.AutoSize = True
        Me.cbTest3.Checked = True
        Me.cbTest3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTest3.Location = New System.Drawing.Point(43, 222)
        Me.cbTest3.Name = "cbTest3"
        Me.cbTest3.Size = New System.Drawing.Size(94, 17)
        Me.cbTest3.TabIndex = 2
        Me.cbTest3.Text = "3. 25V Float"
        Me.cbTest3.UseVisualStyleBackColor = True
        '
        'cbTest2
        '
        Me.cbTest2.AutoSize = True
        Me.cbTest2.Checked = True
        Me.cbTest2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTest2.Location = New System.Drawing.Point(43, 198)
        Me.cbTest2.Name = "cbTest2"
        Me.cbTest2.Size = New System.Drawing.Size(112, 17)
        Me.cbTest2.TabIndex = 1
        Me.cbTest2.Text = "2. 24V Supplies"
        Me.cbTest2.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(985, 569)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "CALIBRATION"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox4)
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(985, 569)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "VISA COM"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label63)
        Me.GroupBox4.Controls.Add(Me.Label64)
        Me.GroupBox4.Controls.Add(Me.BtnVisaOpen)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.BtnVisaClose)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.TextBoxVisaAdr)
        Me.GroupBox4.Controls.Add(Me.BtnVisaSearch)
        Me.GroupBox4.Controls.Add(Me.txtMessage)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(596, 549)
        Me.GroupBox4.TabIndex = 499
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "VISA COM"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label63.Location = New System.Drawing.Point(171, 23)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(213, 16)
        Me.Label63.TabIndex = 488
        Me.Label63.Text = "KEYSIGHT 34461A DMM COM"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label64.Location = New System.Drawing.Point(131, 49)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(82, 13)
        Me.Label64.TabIndex = 491
        Me.Label64.Text = "VISA Address"
        '
        'BtnVisaOpen
        '
        Me.BtnVisaOpen.Location = New System.Drawing.Point(484, 15)
        Me.BtnVisaOpen.Name = "BtnVisaOpen"
        Me.BtnVisaOpen.Size = New System.Drawing.Size(93, 33)
        Me.BtnVisaOpen.TabIndex = 490
        Me.BtnVisaOpen.Text = "OPEN"
        Me.BtnVisaOpen.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label90)
        Me.GroupBox3.Controls.Add(Me.Label89)
        Me.GroupBox3.Controls.Add(Me.BtnReadDmm)
        Me.GroupBox3.Controls.Add(Me.Label72)
        Me.GroupBox3.Controls.Add(Me.BtnReadDmm8)
        Me.GroupBox3.Controls.Add(Me.Label65)
        Me.GroupBox3.Controls.Add(Me.Label71)
        Me.GroupBox3.Controls.Add(Me.TextBoxReadDmm)
        Me.GroupBox3.Controls.Add(Me.TextBoxProofreading)
        Me.GroupBox3.Controls.Add(Me.TextBoxDCV)
        Me.GroupBox3.Controls.Add(Me.Label66)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 460)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(574, 78)
        Me.GroupBox3.TabIndex = 496
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DMM DATA"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label90.Location = New System.Drawing.Point(89, 18)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(53, 13)
        Me.Label90.TabIndex = 380
        Me.Label90.Text = "8回平均"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label89.Location = New System.Drawing.Point(198, 18)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(73, 13)
        Me.Label89.TabIndex = 379
        Me.Label89.Text = "読出しデータ"
        '
        'BtnReadDmm
        '
        Me.BtnReadDmm.Enabled = False
        Me.BtnReadDmm.Location = New System.Drawing.Point(14, 35)
        Me.BtnReadDmm.Name = "BtnReadDmm"
        Me.BtnReadDmm.Size = New System.Drawing.Size(68, 28)
        Me.BtnReadDmm.TabIndex = 368
        Me.BtnReadDmm.Text = "Read"
        Me.BtnReadDmm.UseVisualStyleBackColor = True
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label72.Location = New System.Drawing.Point(461, 18)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(59, 13)
        Me.Label72.TabIndex = 377
        Me.Label72.Text = "校正電圧"
        '
        'BtnReadDmm8
        '
        Me.BtnReadDmm8.Enabled = False
        Me.BtnReadDmm8.Location = New System.Drawing.Point(85, 35)
        Me.BtnReadDmm8.Name = "BtnReadDmm8"
        Me.BtnReadDmm8.Size = New System.Drawing.Size(64, 28)
        Me.BtnReadDmm8.TabIndex = 378
        Me.BtnReadDmm8.Text = "Read8"
        Me.BtnReadDmm8.UseVisualStyleBackColor = True
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label65.Location = New System.Drawing.Point(549, 40)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(18, 16)
        Me.Label65.TabIndex = 370
        Me.Label65.Text = "V"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label71.Location = New System.Drawing.Point(416, 40)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(18, 16)
        Me.Label71.TabIndex = 376
        Me.Label71.Text = "V"
        '
        'TextBoxReadDmm
        '
        Me.TextBoxReadDmm.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxReadDmm.Location = New System.Drawing.Point(161, 38)
        Me.TextBoxReadDmm.Name = "TextBoxReadDmm"
        Me.TextBoxReadDmm.Size = New System.Drawing.Size(149, 21)
        Me.TextBoxReadDmm.TabIndex = 364
        Me.TextBoxReadDmm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxProofreading
        '
        Me.TextBoxProofreading.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxProofreading.Location = New System.Drawing.Point(443, 38)
        Me.TextBoxProofreading.Name = "TextBoxProofreading"
        Me.TextBoxProofreading.Size = New System.Drawing.Size(103, 21)
        Me.TextBoxProofreading.TabIndex = 375
        Me.TextBoxProofreading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxDCV
        '
        Me.TextBoxDCV.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxDCV.Location = New System.Drawing.Point(317, 38)
        Me.TextBoxDCV.Name = "TextBoxDCV"
        Me.TextBoxDCV.Size = New System.Drawing.Size(96, 21)
        Me.TextBoxDCV.TabIndex = 369
        Me.TextBoxDCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label66.Location = New System.Drawing.Point(315, 17)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(102, 13)
        Me.Label66.TabIndex = 371
        Me.Label66.Text = "1000:1 HV Probe"
        '
        'BtnVisaClose
        '
        Me.BtnVisaClose.Enabled = False
        Me.BtnVisaClose.Location = New System.Drawing.Point(484, 55)
        Me.BtnVisaClose.Name = "BtnVisaClose"
        Me.BtnVisaClose.Size = New System.Drawing.Size(93, 33)
        Me.BtnVisaClose.TabIndex = 492
        Me.BtnVisaClose.Text = "CLOSE"
        Me.BtnVisaClose.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label70)
        Me.GroupBox2.Controls.Add(Me.Label69)
        Me.GroupBox2.Controls.Add(Me.Label68)
        Me.GroupBox2.Controls.Add(Me.TextBoxHV40k)
        Me.GroupBox2.Controls.Add(Me.TextBoxHV30k)
        Me.GroupBox2.Controls.Add(Me.TextBoxHV20k)
        Me.GroupBox2.Controls.Add(Me.Label67)
        Me.GroupBox2.Controls.Add(Me.TextBoxHV10k)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 384)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 64)
        Me.GroupBox2.TabIndex = 495
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "HVプローブ校正データ"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label70.Location = New System.Drawing.Point(460, 16)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(35, 13)
        Me.Label70.TabIndex = 381
        Me.Label70.Text = "40kV"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label69.Location = New System.Drawing.Point(329, 16)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(35, 13)
        Me.Label69.TabIndex = 380
        Me.Label69.Text = "30kV"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label68.Location = New System.Drawing.Point(197, 16)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(35, 13)
        Me.Label68.TabIndex = 379
        Me.Label68.Text = "20kV"
        '
        'TextBoxHV40k
        '
        Me.TextBoxHV40k.Enabled = False
        Me.TextBoxHV40k.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxHV40k.Location = New System.Drawing.Point(430, 31)
        Me.TextBoxHV40k.Name = "TextBoxHV40k"
        Me.TextBoxHV40k.Size = New System.Drawing.Size(97, 21)
        Me.TextBoxHV40k.TabIndex = 378
        Me.TextBoxHV40k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxHV30k
        '
        Me.TextBoxHV30k.Enabled = False
        Me.TextBoxHV30k.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxHV30k.Location = New System.Drawing.Point(297, 31)
        Me.TextBoxHV30k.Name = "TextBoxHV30k"
        Me.TextBoxHV30k.Size = New System.Drawing.Size(97, 21)
        Me.TextBoxHV30k.TabIndex = 377
        Me.TextBoxHV30k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxHV20k
        '
        Me.TextBoxHV20k.Enabled = False
        Me.TextBoxHV20k.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxHV20k.Location = New System.Drawing.Point(169, 33)
        Me.TextBoxHV20k.Name = "TextBoxHV20k"
        Me.TextBoxHV20k.Size = New System.Drawing.Size(97, 21)
        Me.TextBoxHV20k.TabIndex = 376
        Me.TextBoxHV20k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label67.Location = New System.Drawing.Point(71, 16)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(35, 13)
        Me.Label67.TabIndex = 375
        Me.Label67.Text = "10kV"
        '
        'TextBoxHV10k
        '
        Me.TextBoxHV10k.Enabled = False
        Me.TextBoxHV10k.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxHV10k.Location = New System.Drawing.Point(40, 33)
        Me.TextBoxHV10k.Name = "TextBoxHV10k"
        Me.TextBoxHV10k.Size = New System.Drawing.Size(96, 21)
        Me.TextBoxHV10k.TabIndex = 256
        Me.TextBoxHV10k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxVisaAdr
        '
        Me.TextBoxVisaAdr.Location = New System.Drawing.Point(17, 65)
        Me.TextBoxVisaAdr.Name = "TextBoxVisaAdr"
        Me.TextBoxVisaAdr.Size = New System.Drawing.Size(307, 20)
        Me.TextBoxVisaAdr.TabIndex = 489
        '
        'BtnVisaSearch
        '
        Me.BtnVisaSearch.Location = New System.Drawing.Point(332, 55)
        Me.BtnVisaSearch.Name = "BtnVisaSearch"
        Me.BtnVisaSearch.Size = New System.Drawing.Size(145, 33)
        Me.BtnVisaSearch.TabIndex = 494
        Me.BtnVisaSearch.Text = "VISA Device Search"
        Me.BtnVisaSearch.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(10, 94)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(571, 282)
        Me.txtMessage.TabIndex = 493
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Label140)
        Me.TabPage7.Controls.Add(Me.Label139)
        Me.TabPage7.Controls.Add(Me.BTAgingRunAgain)
        Me.TabPage7.Controls.Add(Me.ProgressBar2)
        Me.TabPage7.Controls.Add(Me.Label138)
        Me.TabPage7.Controls.Add(Me.Label137)
        Me.TabPage7.Controls.Add(Me.TBagingL2Ip)
        Me.TabPage7.Controls.Add(Me.TBagingL2Vp)
        Me.TabPage7.Controls.Add(Me.TBagingL1Ip)
        Me.TabPage7.Controls.Add(Me.TBagingL1Vp)
        Me.TabPage7.Controls.Add(Me.TBagingHVp)
        Me.TabPage7.Controls.Add(Me.TBagingHIp)
        Me.TabPage7.Controls.Add(Me.TBagingEIp)
        Me.TabPage7.Controls.Add(Me.TBagingEVp)
        Me.TabPage7.Controls.Add(Me.TBagingSIp)
        Me.TabPage7.Controls.Add(Me.TBagingSVp)
        Me.TabPage7.Controls.Add(Me.TBagingBIp)
        Me.TabPage7.Controls.Add(Me.TBagingBVp)
        Me.TabPage7.Controls.Add(Me.TBkeika)
        Me.TabPage7.Controls.Add(Me.Panel1)
        Me.TabPage7.Controls.Add(Me.Label136)
        Me.TabPage7.Controls.Add(Me.Label134)
        Me.TabPage7.Controls.Add(Me.Label135)
        Me.TabPage7.Controls.Add(Me.Label132)
        Me.TabPage7.Controls.Add(Me.Label133)
        Me.TabPage7.Controls.Add(Me.Label130)
        Me.TabPage7.Controls.Add(Me.Label131)
        Me.TabPage7.Controls.Add(Me.Label128)
        Me.TabPage7.Controls.Add(Me.Label129)
        Me.TabPage7.Controls.Add(Me.Label126)
        Me.TabPage7.Controls.Add(Me.Label127)
        Me.TabPage7.Controls.Add(Me.Label124)
        Me.TabPage7.Controls.Add(Me.Label125)
        Me.TabPage7.Controls.Add(Me.Label122)
        Me.TabPage7.Controls.Add(Me.Label123)
        Me.TabPage7.Controls.Add(Me.Label120)
        Me.TabPage7.Controls.Add(Me.Label121)
        Me.TabPage7.Controls.Add(Me.Label118)
        Me.TabPage7.Controls.Add(Me.Label119)
        Me.TabPage7.Controls.Add(Me.Label116)
        Me.TabPage7.Controls.Add(Me.Label117)
        Me.TabPage7.Controls.Add(Me.Label115)
        Me.TabPage7.Controls.Add(Me.Label114)
        Me.TabPage7.Controls.Add(Me.Label113)
        Me.TabPage7.Controls.Add(Me.Label112)
        Me.TabPage7.Controls.Add(Me.TBagingL2I)
        Me.TabPage7.Controls.Add(Me.TBagingL2I1)
        Me.TabPage7.Controls.Add(Me.TBagingL1I)
        Me.TabPage7.Controls.Add(Me.TBagingL1I1)
        Me.TabPage7.Controls.Add(Me.TBagingHV)
        Me.TabPage7.Controls.Add(Me.TBagingHV1)
        Me.TabPage7.Controls.Add(Me.TBagingEI)
        Me.TabPage7.Controls.Add(Me.TBagingEI1)
        Me.TabPage7.Controls.Add(Me.TBagingSI)
        Me.TabPage7.Controls.Add(Me.TBagingSI1)
        Me.TabPage7.Controls.Add(Me.TBagingBI)
        Me.TabPage7.Controls.Add(Me.TBagingBI1)
        Me.TabPage7.Controls.Add(Me.Label111)
        Me.TabPage7.Controls.Add(Me.Label110)
        Me.TabPage7.Controls.Add(Me.Label109)
        Me.TabPage7.Controls.Add(Me.Label108)
        Me.TabPage7.Controls.Add(Me.TBagingL2V)
        Me.TabPage7.Controls.Add(Me.TBagingL1V)
        Me.TabPage7.Controls.Add(Me.TBagingHI)
        Me.TabPage7.Controls.Add(Me.TBagingEV)
        Me.TabPage7.Controls.Add(Me.TBagingSV)
        Me.TabPage7.Controls.Add(Me.TBagingBV)
        Me.TabPage7.Controls.Add(Me.Label107)
        Me.TabPage7.Controls.Add(Me.TBagingL2V1)
        Me.TabPage7.Controls.Add(Me.TBagingL1V1)
        Me.TabPage7.Controls.Add(Me.TBagingHI1)
        Me.TabPage7.Controls.Add(Me.TBagingEV1)
        Me.TabPage7.Controls.Add(Me.TBagingSV1)
        Me.TabPage7.Controls.Add(Me.TBagingBV1)
        Me.TabPage7.Controls.Add(Me.Label105)
        Me.TabPage7.Controls.Add(Me.TB_date2)
        Me.TabPage7.Controls.Add(Me.Label104)
        Me.TabPage7.Controls.Add(Me.TB_date)
        Me.TabPage7.Controls.Add(Me.Label103)
        Me.TabPage7.Controls.Add(Me.TBagingTime)
        Me.TabPage7.Controls.Add(Me.BTagingRun)
        Me.TabPage7.Controls.Add(Me.Label92)
        Me.TabPage7.Controls.Add(Me.tbSerialNum2)
        Me.TabPage7.Location = New System.Drawing.Point(4, 23)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(985, 569)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "Burn-in"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Label140
        '
        Me.Label140.AutoSize = True
        Me.Label140.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label140.Location = New System.Drawing.Point(607, 276)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(277, 17)
        Me.Label140.TabIndex = 476
        Me.Label140.Text = "「Run Again」で再開することができます。"
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label139.Location = New System.Drawing.Point(607, 250)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(326, 17)
        Me.Label139.TabIndex = 475
        Me.Label139.Text = "PCがスリープしたり、アプリが異常終了した時は、"
        '
        'BTAgingRunAgain
        '
        Me.BTAgingRunAgain.Enabled = False
        Me.BTAgingRunAgain.Location = New System.Drawing.Point(475, 40)
        Me.BTAgingRunAgain.Name = "BTAgingRunAgain"
        Me.BTAgingRunAgain.Size = New System.Drawing.Size(89, 42)
        Me.BTAgingRunAgain.TabIndex = 474
        Me.BTAgingRunAgain.Text = "Run Again"
        Me.BTAgingRunAgain.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(28, 9)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(918, 5)
        Me.ProgressBar2.TabIndex = 473
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Location = New System.Drawing.Point(492, 138)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(46, 13)
        Me.Label138.TabIndex = 472
        Me.Label138.Text = "変動率"
        '
        'Label137
        '
        Me.Label137.AutoSize = True
        Me.Label137.Location = New System.Drawing.Point(490, 154)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(51, 13)
        Me.Label137.TabIndex = 471
        Me.Label137.Text = "5% 以下"
        '
        'TBagingL2Ip
        '
        Me.TBagingL2Ip.Location = New System.Drawing.Point(490, 459)
        Me.TBagingL2Ip.Name = "TBagingL2Ip"
        Me.TBagingL2Ip.Size = New System.Drawing.Size(56, 20)
        Me.TBagingL2Ip.TabIndex = 470
        Me.TBagingL2Ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingL2Vp
        '
        Me.TBagingL2Vp.Location = New System.Drawing.Point(490, 433)
        Me.TBagingL2Vp.Name = "TBagingL2Vp"
        Me.TBagingL2Vp.Size = New System.Drawing.Size(56, 20)
        Me.TBagingL2Vp.TabIndex = 469
        Me.TBagingL2Vp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingL1Ip
        '
        Me.TBagingL1Ip.Location = New System.Drawing.Point(490, 406)
        Me.TBagingL1Ip.Name = "TBagingL1Ip"
        Me.TBagingL1Ip.Size = New System.Drawing.Size(56, 20)
        Me.TBagingL1Ip.TabIndex = 468
        Me.TBagingL1Ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingL1Vp
        '
        Me.TBagingL1Vp.Location = New System.Drawing.Point(490, 380)
        Me.TBagingL1Vp.Name = "TBagingL1Vp"
        Me.TBagingL1Vp.Size = New System.Drawing.Size(56, 20)
        Me.TBagingL1Vp.TabIndex = 467
        Me.TBagingL1Vp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingHVp
        '
        Me.TBagingHVp.Location = New System.Drawing.Point(490, 354)
        Me.TBagingHVp.Name = "TBagingHVp"
        Me.TBagingHVp.Size = New System.Drawing.Size(56, 20)
        Me.TBagingHVp.TabIndex = 466
        Me.TBagingHVp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingHIp
        '
        Me.TBagingHIp.Location = New System.Drawing.Point(490, 328)
        Me.TBagingHIp.Name = "TBagingHIp"
        Me.TBagingHIp.Size = New System.Drawing.Size(56, 20)
        Me.TBagingHIp.TabIndex = 465
        Me.TBagingHIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingEIp
        '
        Me.TBagingEIp.Location = New System.Drawing.Point(490, 303)
        Me.TBagingEIp.Name = "TBagingEIp"
        Me.TBagingEIp.Size = New System.Drawing.Size(56, 20)
        Me.TBagingEIp.TabIndex = 464
        Me.TBagingEIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingEVp
        '
        Me.TBagingEVp.Location = New System.Drawing.Point(490, 276)
        Me.TBagingEVp.Name = "TBagingEVp"
        Me.TBagingEVp.Size = New System.Drawing.Size(56, 20)
        Me.TBagingEVp.TabIndex = 463
        Me.TBagingEVp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingSIp
        '
        Me.TBagingSIp.Location = New System.Drawing.Point(490, 251)
        Me.TBagingSIp.Name = "TBagingSIp"
        Me.TBagingSIp.Size = New System.Drawing.Size(56, 20)
        Me.TBagingSIp.TabIndex = 462
        Me.TBagingSIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingSVp
        '
        Me.TBagingSVp.Location = New System.Drawing.Point(490, 225)
        Me.TBagingSVp.Name = "TBagingSVp"
        Me.TBagingSVp.Size = New System.Drawing.Size(56, 20)
        Me.TBagingSVp.TabIndex = 461
        Me.TBagingSVp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingBIp
        '
        Me.TBagingBIp.Location = New System.Drawing.Point(490, 199)
        Me.TBagingBIp.Name = "TBagingBIp"
        Me.TBagingBIp.Size = New System.Drawing.Size(56, 20)
        Me.TBagingBIp.TabIndex = 460
        Me.TBagingBIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingBVp
        '
        Me.TBagingBVp.Location = New System.Drawing.Point(490, 173)
        Me.TBagingBVp.Name = "TBagingBVp"
        Me.TBagingBVp.Size = New System.Drawing.Size(56, 20)
        Me.TBagingBVp.TabIndex = 459
        Me.TBagingBVp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBkeika
        '
        Me.TBkeika.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TBkeika.Location = New System.Drawing.Point(850, 49)
        Me.TBkeika.Name = "TBkeika"
        Me.TBkeika.Size = New System.Drawing.Size(96, 27)
        Me.TBkeika.TabIndex = 458
        Me.TBkeika.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RBPrepotAging)
        Me.Panel1.Controls.Add(Me.RBFinalAging)
        Me.Panel1.Controls.Add(Me.TBagingBeam)
        Me.Panel1.Controls.Add(Me.Label102)
        Me.Panel1.Controls.Add(Me.Label101)
        Me.Panel1.Controls.Add(Me.Label100)
        Me.Panel1.Controls.Add(Me.Label99)
        Me.Panel1.Controls.Add(Me.Label98)
        Me.Panel1.Controls.Add(Me.Label97)
        Me.Panel1.Controls.Add(Me.TBagingSup)
        Me.Panel1.Controls.Add(Me.TBagingExt)
        Me.Panel1.Controls.Add(Me.TBagingHeat)
        Me.Panel1.Controls.Add(Me.TBagingL1)
        Me.Panel1.Controls.Add(Me.TBagingL2)
        Me.Panel1.Controls.Add(Me.Label106)
        Me.Panel1.Location = New System.Drawing.Point(16, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 400)
        Me.Panel1.TabIndex = 457
        '
        'RBPrepotAging
        '
        Me.RBPrepotAging.AutoSize = True
        Me.RBPrepotAging.Checked = True
        Me.RBPrepotAging.Location = New System.Drawing.Point(45, 13)
        Me.RBPrepotAging.Name = "RBPrepotAging"
        Me.RBPrepotAging.Size = New System.Drawing.Size(93, 17)
        Me.RBPrepotAging.TabIndex = 378
        Me.RBPrepotAging.TabStop = True
        Me.RBPrepotAging.Text = "Pre-Potting"
        Me.RBPrepotAging.UseVisualStyleBackColor = True
        '
        'RBFinalAging
        '
        Me.RBFinalAging.AutoSize = True
        Me.RBFinalAging.Location = New System.Drawing.Point(45, 39)
        Me.RBFinalAging.Name = "RBFinalAging"
        Me.RBFinalAging.Size = New System.Drawing.Size(51, 17)
        Me.RBFinalAging.TabIndex = 379
        Me.RBFinalAging.Text = "Final"
        Me.RBFinalAging.UseVisualStyleBackColor = True
        '
        'TBagingBeam
        '
        Me.TBagingBeam.Location = New System.Drawing.Point(132, 98)
        Me.TBagingBeam.Name = "TBagingBeam"
        Me.TBagingBeam.Size = New System.Drawing.Size(72, 20)
        Me.TBagingBeam.TabIndex = 382
        Me.TBagingBeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Location = New System.Drawing.Point(19, 102)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(100, 13)
        Me.Label102.TabIndex = 388
        Me.Label102.Text = "Beam Energy (V)"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Location = New System.Drawing.Point(43, 204)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(80, 13)
        Me.Label101.TabIndex = 387
        Me.Label101.Text = "Extractor (V)"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Location = New System.Drawing.Point(58, 256)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(65, 13)
        Me.Label100.TabIndex = 386
        Me.Label100.Text = "Heater (A)"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Location = New System.Drawing.Point(63, 362)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(61, 13)
        Me.Label99.TabIndex = 385
        Me.Label99.Text = "Lens2 (V)"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Location = New System.Drawing.Point(64, 308)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(61, 13)
        Me.Label98.TabIndex = 384
        Me.Label98.Text = "Lens1 (V)"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Location = New System.Drawing.Point(31, 154)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(90, 13)
        Me.Label97.TabIndex = 383
        Me.Label97.Text = "Suppressor (V)"
        '
        'TBagingSup
        '
        Me.TBagingSup.Location = New System.Drawing.Point(132, 150)
        Me.TBagingSup.Name = "TBagingSup"
        Me.TBagingSup.Size = New System.Drawing.Size(72, 20)
        Me.TBagingSup.TabIndex = 389
        Me.TBagingSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingExt
        '
        Me.TBagingExt.Location = New System.Drawing.Point(132, 202)
        Me.TBagingExt.Name = "TBagingExt"
        Me.TBagingExt.Size = New System.Drawing.Size(72, 20)
        Me.TBagingExt.TabIndex = 390
        Me.TBagingExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingHeat
        '
        Me.TBagingHeat.Location = New System.Drawing.Point(132, 254)
        Me.TBagingHeat.Name = "TBagingHeat"
        Me.TBagingHeat.Size = New System.Drawing.Size(72, 20)
        Me.TBagingHeat.TabIndex = 391
        Me.TBagingHeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingL1
        '
        Me.TBagingL1.Location = New System.Drawing.Point(132, 304)
        Me.TBagingL1.Name = "TBagingL1"
        Me.TBagingL1.Size = New System.Drawing.Size(72, 20)
        Me.TBagingL1.TabIndex = 392
        Me.TBagingL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingL2
        '
        Me.TBagingL2.Location = New System.Drawing.Point(132, 358)
        Me.TBagingL2.Name = "TBagingL2"
        Me.TBagingL2.Size = New System.Drawing.Size(72, 20)
        Me.TBagingL2.TabIndex = 393
        Me.TBagingL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Location = New System.Drawing.Point(134, 77)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(65, 13)
        Me.Label106.TabIndex = 402
        Me.Label106.Text = "SET Value"
        '
        'Label136
        '
        Me.Label136.AutoSize = True
        Me.Label136.Location = New System.Drawing.Point(380, 137)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(53, 13)
        Me.Label136.TabIndex = 456
        Me.Label136.Text = "1分更新"
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Location = New System.Drawing.Point(330, 334)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(15, 13)
        Me.Label134.TabIndex = 455
        Me.Label134.Text = "A"
        '
        'Label135
        '
        Me.Label135.AutoSize = True
        Me.Label135.Location = New System.Drawing.Point(330, 358)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(15, 13)
        Me.Label135.TabIndex = 454
        Me.Label135.Text = "V"
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Location = New System.Drawing.Point(449, 335)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(15, 13)
        Me.Label132.TabIndex = 453
        Me.Label132.Text = "A"
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.Location = New System.Drawing.Point(449, 359)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(15, 13)
        Me.Label133.TabIndex = 452
        Me.Label133.Text = "V"
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Location = New System.Drawing.Point(449, 464)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(22, 13)
        Me.Label130.TabIndex = 451
        Me.Label130.Text = "uA"
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Location = New System.Drawing.Point(450, 438)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(15, 13)
        Me.Label131.TabIndex = 450
        Me.Label131.Text = "V"
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Location = New System.Drawing.Point(329, 464)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(22, 13)
        Me.Label128.TabIndex = 449
        Me.Label128.Text = "uA"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Location = New System.Drawing.Point(330, 438)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(15, 13)
        Me.Label129.TabIndex = 448
        Me.Label129.Text = "V"
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Location = New System.Drawing.Point(449, 412)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(22, 13)
        Me.Label126.TabIndex = 447
        Me.Label126.Text = "uA"
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Location = New System.Drawing.Point(450, 386)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(15, 13)
        Me.Label127.TabIndex = 446
        Me.Label127.Text = "V"
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Location = New System.Drawing.Point(329, 411)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(22, 13)
        Me.Label124.TabIndex = 445
        Me.Label124.Text = "uA"
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Location = New System.Drawing.Point(330, 385)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(15, 13)
        Me.Label125.TabIndex = 444
        Me.Label125.Text = "V"
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Location = New System.Drawing.Point(447, 308)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(22, 13)
        Me.Label122.TabIndex = 443
        Me.Label122.Text = "uA"
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Location = New System.Drawing.Point(448, 282)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(15, 13)
        Me.Label123.TabIndex = 442
        Me.Label123.Text = "V"
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Location = New System.Drawing.Point(329, 308)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(22, 13)
        Me.Label120.TabIndex = 441
        Me.Label120.Text = "uA"
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Location = New System.Drawing.Point(330, 282)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(15, 13)
        Me.Label121.TabIndex = 440
        Me.Label121.Text = "V"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Location = New System.Drawing.Point(447, 256)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(22, 13)
        Me.Label118.TabIndex = 439
        Me.Label118.Text = "uA"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Location = New System.Drawing.Point(448, 230)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(15, 13)
        Me.Label119.TabIndex = 438
        Me.Label119.Text = "V"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Location = New System.Drawing.Point(329, 256)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(22, 13)
        Me.Label116.TabIndex = 437
        Me.Label116.Text = "uA"
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Location = New System.Drawing.Point(330, 230)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(15, 13)
        Me.Label117.TabIndex = 436
        Me.Label117.Text = "V"
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Location = New System.Drawing.Point(448, 204)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(22, 13)
        Me.Label115.TabIndex = 435
        Me.Label115.Text = "uA"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Location = New System.Drawing.Point(328, 204)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(22, 13)
        Me.Label114.TabIndex = 434
        Me.Label114.Text = "uA"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Location = New System.Drawing.Point(449, 178)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(15, 13)
        Me.Label113.TabIndex = 433
        Me.Label113.Text = "V"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Location = New System.Drawing.Point(330, 178)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(15, 13)
        Me.Label112.TabIndex = 432
        Me.Label112.Text = "V"
        '
        'TBagingL2I
        '
        Me.TBagingL2I.Location = New System.Drawing.Point(365, 459)
        Me.TBagingL2I.Name = "TBagingL2I"
        Me.TBagingL2I.Size = New System.Drawing.Size(81, 20)
        Me.TBagingL2I.TabIndex = 431
        Me.TBagingL2I.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingL2I1
        '
        Me.TBagingL2I1.Location = New System.Drawing.Point(246, 459)
        Me.TBagingL2I1.Name = "TBagingL2I1"
        Me.TBagingL2I1.Size = New System.Drawing.Size(81, 20)
        Me.TBagingL2I1.TabIndex = 430
        Me.TBagingL2I1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingL1I
        '
        Me.TBagingL1I.Location = New System.Drawing.Point(365, 406)
        Me.TBagingL1I.Name = "TBagingL1I"
        Me.TBagingL1I.Size = New System.Drawing.Size(81, 20)
        Me.TBagingL1I.TabIndex = 429
        Me.TBagingL1I.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingL1I1
        '
        Me.TBagingL1I1.Location = New System.Drawing.Point(246, 406)
        Me.TBagingL1I1.Name = "TBagingL1I1"
        Me.TBagingL1I1.Size = New System.Drawing.Size(81, 20)
        Me.TBagingL1I1.TabIndex = 428
        Me.TBagingL1I1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingHV
        '
        Me.TBagingHV.Location = New System.Drawing.Point(365, 354)
        Me.TBagingHV.Name = "TBagingHV"
        Me.TBagingHV.Size = New System.Drawing.Size(81, 20)
        Me.TBagingHV.TabIndex = 427
        Me.TBagingHV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingHV1
        '
        Me.TBagingHV1.Location = New System.Drawing.Point(246, 354)
        Me.TBagingHV1.Name = "TBagingHV1"
        Me.TBagingHV1.Size = New System.Drawing.Size(81, 20)
        Me.TBagingHV1.TabIndex = 426
        Me.TBagingHV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingEI
        '
        Me.TBagingEI.Location = New System.Drawing.Point(365, 303)
        Me.TBagingEI.Name = "TBagingEI"
        Me.TBagingEI.Size = New System.Drawing.Size(81, 20)
        Me.TBagingEI.TabIndex = 425
        Me.TBagingEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingEI1
        '
        Me.TBagingEI1.Location = New System.Drawing.Point(246, 303)
        Me.TBagingEI1.Name = "TBagingEI1"
        Me.TBagingEI1.Size = New System.Drawing.Size(81, 20)
        Me.TBagingEI1.TabIndex = 424
        Me.TBagingEI1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingSI
        '
        Me.TBagingSI.Location = New System.Drawing.Point(365, 251)
        Me.TBagingSI.Name = "TBagingSI"
        Me.TBagingSI.Size = New System.Drawing.Size(81, 20)
        Me.TBagingSI.TabIndex = 423
        Me.TBagingSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingSI1
        '
        Me.TBagingSI1.Location = New System.Drawing.Point(246, 251)
        Me.TBagingSI1.Name = "TBagingSI1"
        Me.TBagingSI1.Size = New System.Drawing.Size(81, 20)
        Me.TBagingSI1.TabIndex = 422
        Me.TBagingSI1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingBI
        '
        Me.TBagingBI.Location = New System.Drawing.Point(365, 199)
        Me.TBagingBI.Name = "TBagingBI"
        Me.TBagingBI.Size = New System.Drawing.Size(81, 20)
        Me.TBagingBI.TabIndex = 421
        Me.TBagingBI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingBI1
        '
        Me.TBagingBI1.Location = New System.Drawing.Point(246, 199)
        Me.TBagingBI1.Name = "TBagingBI1"
        Me.TBagingBI1.Size = New System.Drawing.Size(81, 20)
        Me.TBagingBI1.TabIndex = 420
        Me.TBagingBI1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Location = New System.Drawing.Point(266, 135)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(53, 13)
        Me.Label111.TabIndex = 419
        Me.Label111.Text = "開始から"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label110.Location = New System.Drawing.Point(607, 205)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(323, 17)
        Me.Label110.TabIndex = 418
        Me.Label110.Text = "END TIME を過ぎていたらエージング完了です。"
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label109.Location = New System.Drawing.Point(682, 179)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(164, 17)
        Me.Label109.TabIndex = 417
        Me.Label109.Text = "自動では止まりません。"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Location = New System.Drawing.Point(385, 154)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(46, 13)
        Me.Label108.TabIndex = 416
        Me.Label108.Text = "現在値"
        '
        'TBagingL2V
        '
        Me.TBagingL2V.Location = New System.Drawing.Point(365, 433)
        Me.TBagingL2V.Name = "TBagingL2V"
        Me.TBagingL2V.Size = New System.Drawing.Size(81, 20)
        Me.TBagingL2V.TabIndex = 415
        Me.TBagingL2V.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingL1V
        '
        Me.TBagingL1V.Location = New System.Drawing.Point(365, 380)
        Me.TBagingL1V.Name = "TBagingL1V"
        Me.TBagingL1V.Size = New System.Drawing.Size(81, 20)
        Me.TBagingL1V.TabIndex = 414
        Me.TBagingL1V.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingHI
        '
        Me.TBagingHI.Location = New System.Drawing.Point(365, 329)
        Me.TBagingHI.Name = "TBagingHI"
        Me.TBagingHI.Size = New System.Drawing.Size(81, 20)
        Me.TBagingHI.TabIndex = 413
        Me.TBagingHI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingEV
        '
        Me.TBagingEV.Location = New System.Drawing.Point(365, 277)
        Me.TBagingEV.Name = "TBagingEV"
        Me.TBagingEV.Size = New System.Drawing.Size(81, 20)
        Me.TBagingEV.TabIndex = 412
        Me.TBagingEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingSV
        '
        Me.TBagingSV.Location = New System.Drawing.Point(365, 225)
        Me.TBagingSV.Name = "TBagingSV"
        Me.TBagingSV.Size = New System.Drawing.Size(81, 20)
        Me.TBagingSV.TabIndex = 411
        Me.TBagingSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingBV
        '
        Me.TBagingBV.Location = New System.Drawing.Point(365, 173)
        Me.TBagingBV.Name = "TBagingBV"
        Me.TBagingBV.Size = New System.Drawing.Size(81, 20)
        Me.TBagingBV.TabIndex = 410
        Me.TBagingBV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Location = New System.Drawing.Point(258, 153)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(66, 13)
        Me.Label107.TabIndex = 409
        Me.Label107.Text = "1分経過時"
        '
        'TBagingL2V1
        '
        Me.TBagingL2V1.Location = New System.Drawing.Point(246, 433)
        Me.TBagingL2V1.Name = "TBagingL2V1"
        Me.TBagingL2V1.Size = New System.Drawing.Size(81, 20)
        Me.TBagingL2V1.TabIndex = 408
        Me.TBagingL2V1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingL1V1
        '
        Me.TBagingL1V1.Location = New System.Drawing.Point(246, 380)
        Me.TBagingL1V1.Name = "TBagingL1V1"
        Me.TBagingL1V1.Size = New System.Drawing.Size(81, 20)
        Me.TBagingL1V1.TabIndex = 407
        Me.TBagingL1V1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingHI1
        '
        Me.TBagingHI1.Location = New System.Drawing.Point(246, 329)
        Me.TBagingHI1.Name = "TBagingHI1"
        Me.TBagingHI1.Size = New System.Drawing.Size(81, 20)
        Me.TBagingHI1.TabIndex = 406
        Me.TBagingHI1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingEV1
        '
        Me.TBagingEV1.Location = New System.Drawing.Point(246, 277)
        Me.TBagingEV1.Name = "TBagingEV1"
        Me.TBagingEV1.Size = New System.Drawing.Size(81, 20)
        Me.TBagingEV1.TabIndex = 405
        Me.TBagingEV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingSV1
        '
        Me.TBagingSV1.Location = New System.Drawing.Point(246, 225)
        Me.TBagingSV1.Name = "TBagingSV1"
        Me.TBagingSV1.Size = New System.Drawing.Size(81, 20)
        Me.TBagingSV1.TabIndex = 404
        Me.TBagingSV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBagingBV1
        '
        Me.TBagingBV1.Location = New System.Drawing.Point(246, 173)
        Me.TBagingBV1.Name = "TBagingBV1"
        Me.TBagingBV1.Size = New System.Drawing.Size(81, 20)
        Me.TBagingBV1.TabIndex = 403
        Me.TBagingBV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label105.Location = New System.Drawing.Point(604, 140)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(82, 17)
        Me.Label105.TabIndex = 400
        Me.Label105.Text = "END TIME"
        '
        'TB_date2
        '
        Me.TB_date2.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TB_date2.Location = New System.Drawing.Point(710, 133)
        Me.TB_date2.Name = "TB_date2"
        Me.TB_date2.Size = New System.Drawing.Size(236, 30)
        Me.TB_date2.TabIndex = 399
        Me.TB_date2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label104.Location = New System.Drawing.Point(593, 96)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(102, 17)
        Me.Label104.TabIndex = 398
        Me.Label104.Text = "START TIME"
        '
        'TB_date
        '
        Me.TB_date.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TB_date.Location = New System.Drawing.Point(710, 90)
        Me.TB_date.Name = "TB_date"
        Me.TB_date.Size = New System.Drawing.Size(236, 30)
        Me.TB_date.TabIndex = 397
        Me.TB_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label103.Location = New System.Drawing.Point(588, 54)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(155, 17)
        Me.Label103.TabIndex = 396
        Me.Label103.Text = "Burn-in Time (Hour)"
        '
        'TBagingTime
        '
        Me.TBagingTime.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TBagingTime.Location = New System.Drawing.Point(758, 49)
        Me.TBagingTime.Name = "TBagingTime"
        Me.TBagingTime.Size = New System.Drawing.Size(69, 27)
        Me.TBagingTime.TabIndex = 395
        Me.TBagingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BTagingRun
        '
        Me.BTagingRun.Location = New System.Drawing.Point(328, 40)
        Me.BTagingRun.Name = "BTagingRun"
        Me.BTagingRun.Size = New System.Drawing.Size(139, 42)
        Me.BTagingRun.TabIndex = 375
        Me.BTagingRun.Text = "RUN"
        Me.BTagingRun.UseVisualStyleBackColor = True
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(47, 54)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(74, 13)
        Me.Label92.TabIndex = 377
        Me.Label92.Text = "SERIAL  No."
        '
        'tbSerialNum2
        '
        Me.tbSerialNum2.Location = New System.Drawing.Point(134, 50)
        Me.tbSerialNum2.Name = "tbSerialNum2"
        Me.tbSerialNum2.Size = New System.Drawing.Size(132, 20)
        Me.tbSerialNum2.TabIndex = 376
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label142)
        Me.GroupBox9.Controls.Add(Me.Label141)
        Me.GroupBox9.Controls.Add(Me.TB_dmm)
        Me.GroupBox9.Location = New System.Drawing.Point(703, 658)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(294, 53)
        Me.GroupBox9.TabIndex = 368
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "DMM VISA"
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label142.Location = New System.Drawing.Point(262, 24)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(18, 16)
        Me.Label142.TabIndex = 368
        Me.Label142.Text = "V"
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Location = New System.Drawing.Point(23, 25)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(66, 13)
        Me.Label141.TabIndex = 367
        Me.Label141.Text = "DMM Read"
        '
        'TB_dmm
        '
        Me.TB_dmm.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TB_dmm.Location = New System.Drawing.Point(107, 16)
        Me.TB_dmm.Name = "TB_dmm"
        Me.TB_dmm.Size = New System.Drawing.Size(147, 27)
        Me.TB_dmm.TabIndex = 366
        Me.TB_dmm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(465, 42)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(155, 5)
        Me.ProgressBar3.TabIndex = 477
        '
        'BtnTEMP
        '
        Me.BtnTEMP.Location = New System.Drawing.Point(119, 29)
        Me.BtnTEMP.Name = "BtnTEMP"
        Me.BtnTEMP.Size = New System.Drawing.Size(90, 21)
        Me.BtnTEMP.TabIndex = 488
        Me.BtnTEMP.Text = "CONNECT"
        Me.BtnTEMP.UseVisualStyleBackColor = True
        '
        'tbAmbTemp
        '
        Me.tbAmbTemp.Location = New System.Drawing.Point(638, 43)
        Me.tbAmbTemp.Name = "tbAmbTemp"
        Me.tbAmbTemp.Size = New System.Drawing.Size(61, 20)
        Me.tbAmbTemp.TabIndex = 489
        Me.tbAmbTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'arRS232
        '
        Me.arRS232.BaudRate = 115200
        Me.arRS232.ReadTimeout = 50
        Me.arRS232.WriteBufferSize = 4096
        Me.arRS232.WriteTimeout = 50
        '
        'tbAmbHumidity
        '
        Me.tbAmbHumidity.Location = New System.Drawing.Point(727, 43)
        Me.tbAmbHumidity.Name = "tbAmbHumidity"
        Me.tbAmbHumidity.Size = New System.Drawing.Size(61, 20)
        Me.tbAmbHumidity.TabIndex = 490
        Me.tbAmbHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(702, 49)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(20, 13)
        Me.Label95.TabIndex = 491
        Me.Label95.Text = "℃"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(792, 48)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(20, 13)
        Me.Label96.TabIndex = 492
        Me.Label96.Text = "％"
        '
        'Main1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1014, 715)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.Label96)
        Me.Controls.Add(Me.Label95)
        Me.Controls.Add(Me.tbAmbHumidity)
        Me.Controls.Add(Me.tbAmbTemp)
        Me.Controls.Add(Me.BtnTEMP)
        Me.Controls.Add(Me.Btn_EMS)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txt_FirmVer)
        Me.Controls.Add(Me.btn_Get_Ver)
        Me.Controls.Add(Me.bSystem)
        Me.Controls.Add(Me.bShutDown)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.bInitialize)
        Me.Controls.Add(Me.cPortSel)
        Me.Controls.Add(Me.bPortClose)
        Me.Controls.Add(Me.bPortOpen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(1030, 755)
        Me.MinimumSize = New System.Drawing.Size(791, 647)
        Me.Name = "Main1"
        Me.Text = "20-750"
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NuExtCurrentLim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuEmissionControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuSuppressor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuLens1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuLens2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuFilamentHeater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuExtractor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuBeamEnergy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuWobble, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cPortSel As System.Windows.Forms.ComboBox
    Friend WithEvents bPortClose As System.Windows.Forms.Button
    Friend WithEvents bPortOpen As System.Windows.Forms.Button
    Friend WithEvents bInitialize As System.Windows.Forms.Button
    Friend WithEvents bSend As System.Windows.Forms.Button
    Friend WithEvents tbSend As System.Windows.Forms.TextBox
    Friend WithEvents tbShowRawReceive As System.Windows.Forms.TextBox
    Friend WithEvents tbShowRawSend As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents bShutDown As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bSystem As System.Windows.Forms.Button
    Friend WithEvents myRS232 As IO.Ports.SerialPort
    Friend WithEvents txt_BeamGain As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_BeamOffset As System.Windows.Forms.TextBox
    Friend WithEvents btn_BeamGain_Set As System.Windows.Forms.Button
    Friend WithEvents btn_BeamOffset_Set As System.Windows.Forms.Button
    Friend WithEvents txt_BeamGain_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_BeamGain_Read As System.Windows.Forms.Button
    Friend WithEvents btn_BeamOffset_Read As System.Windows.Forms.Button
    Friend WithEvents txt_BeamOffset_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_Lens1pOffset_Read As System.Windows.Forms.Button
    Friend WithEvents txt_L1pOffset_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_Lens1pGain_Read As System.Windows.Forms.Button
    Friend WithEvents txt_L1pGain_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_Lens1pOffset_Set As System.Windows.Forms.Button
    Friend WithEvents btn_Lens1pGain_Set As System.Windows.Forms.Button
    Friend WithEvents txt_L1pOffset As System.Windows.Forms.TextBox
    Friend WithEvents txt_L1pGain As System.Windows.Forms.TextBox
    Friend WithEvents btn_Lens1nOffset_Read As System.Windows.Forms.Button
    Friend WithEvents txt_L1nOffset_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_Lens1nGain_Read As System.Windows.Forms.Button
    Friend WithEvents txt_L1nGain_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_Lens1nOffset_Set As System.Windows.Forms.Button
    Friend WithEvents btn_Lens1nGain_Set As System.Windows.Forms.Button
    Friend WithEvents txt_L1nOffset As System.Windows.Forms.TextBox
    Friend WithEvents txt_L1nGain As System.Windows.Forms.TextBox
    Friend WithEvents btn_Lens2Offset_Read As System.Windows.Forms.Button
    Friend WithEvents txt_L2Offset_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_Lens2Gain_Read As System.Windows.Forms.Button
    Friend WithEvents txt_L2Gain_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_Lens2Offset_Set As System.Windows.Forms.Button
    Friend WithEvents btn_Lens2Gain_Set As System.Windows.Forms.Button
    Friend WithEvents txt_L2Offset As System.Windows.Forms.TextBox
    Friend WithEvents txt_L2Gain As System.Windows.Forms.TextBox
    Friend WithEvents btn_SupOffset_Read As System.Windows.Forms.Button
    Friend WithEvents txt_SupOffset_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_SupGain_Read As System.Windows.Forms.Button
    Friend WithEvents txt_SupGain_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_SupOffset_Set As System.Windows.Forms.Button
    Friend WithEvents btn_SupGain_Set As System.Windows.Forms.Button
    Friend WithEvents txt_SupOffset As System.Windows.Forms.TextBox
    Friend WithEvents txt_SupGain As System.Windows.Forms.TextBox
    Friend WithEvents btn_ExtOffset_Read As System.Windows.Forms.Button
    Friend WithEvents txt_ExtOffset_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_ExtGain_Read As System.Windows.Forms.Button
    Friend WithEvents txt_ExtGain_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_ExtOffset_Set As System.Windows.Forms.Button
    Friend WithEvents btn_ExtGain_Set As System.Windows.Forms.Button
    Friend WithEvents txt_ExtOffset As System.Windows.Forms.TextBox
    Friend WithEvents txt_ExtGain As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_HeaterOffset_Read As System.Windows.Forms.Button
    Friend WithEvents txt_HtrOffset_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_HeaterGain_Read As System.Windows.Forms.Button
    Friend WithEvents txt_HtrGain_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_HeaterOffset_Set As System.Windows.Forms.Button
    Friend WithEvents btn_HeaterGain_Set As System.Windows.Forms.Button
    Friend WithEvents txt_HtrOffset As System.Windows.Forms.TextBox
    Friend WithEvents txt_HtrGain As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btn_PWM_Duty_Read As System.Windows.Forms.Button
    Friend WithEvents txt_PWM_Duty_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_PWM_Freq_Read As System.Windows.Forms.Button
    Friend WithEvents txt_PWM_Freq_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_PWM_Duty_Set As System.Windows.Forms.Button
    Friend WithEvents btn_PWM_Freq_Set As System.Windows.Forms.Button
    Friend WithEvents txt_PWM_Duty As System.Windows.Forms.TextBox
    Friend WithEvents txt_PWM_Freq As System.Windows.Forms.TextBox
    Friend WithEvents btn_PWM_DT_Read As System.Windows.Forms.Button
    Friend WithEvents txt_PWM_DeadTime_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_PWM_DT_Set As System.Windows.Forms.Button
    Friend WithEvents txt_PWM_DeadTime As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btn_EmiOffset_R As System.Windows.Forms.Button
    Friend WithEvents txt_EmiOffset_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_EmiGain_R As System.Windows.Forms.Button
    Friend WithEvents txt_EmiGain_R As System.Windows.Forms.TextBox
    Friend WithEvents btn_EmiOffset_Set As System.Windows.Forms.Button
    Friend WithEvents btn_EmiGain_Set As System.Windows.Forms.Button
    Friend WithEvents txt_EmiOffset As System.Windows.Forms.TextBox
    Friend WithEvents txt_EmiGain As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents btn_Get_Ver As System.Windows.Forms.Button
    Friend WithEvents txt_FirmVer As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbEmissionControl As System.Windows.Forms.CheckBox
    Friend WithEvents nuEmissionControl As System.Windows.Forms.NumericUpDown
    Friend WithEvents rbOn As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cbLog As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox0 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbReadBack As System.Windows.Forms.CheckBox
    Friend WithEvents bReadBack As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nuSuppressor As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuLens1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuLens2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuFilamentHeater As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuExtractor As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuBeamEnergy As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuWobble As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents NuExtCurrentLim As System.Windows.Forms.NumericUpDown
    Friend WithEvents Btn_ECLim As System.Windows.Forms.Button
    Friend WithEvents TextBox42 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox41 As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Set_Value_Enable As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_EMS As System.Windows.Forms.Button
    Friend WithEvents btn_DG406_Set As Button
    Friend WithEvents btn_DG406_Read As Button
    Friend WithEvents txt_DG406_R As TextBox
    Friend WithEvents DG406_Sel As ComboBox
    Friend WithEvents txt_DG406 As TextBox
    Friend WithEvents txt_DG406_R2 As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents txt_DG406_Speed As TextBox
    Friend WithEvents DG406_Speed_Sel As ComboBox
    Friend WithEvents btn_DG406_Speed As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBoxLogFile As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents BtnExtrCAL As Button
    Friend WithEvents BtnSupCAL As Button
    Friend WithEvents Label85 As Label
    Friend WithEvents Label84 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents TBoxErrCont As TextBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label53 As Label
    Friend WithEvents Hearter_VMoni As TextBox
    Friend WithEvents Extractor_VMoni As TextBox
    Friend WithEvents Suppressor_VMoni As TextBox
    Friend WithEvents Lens2_VMoni As TextBox
    Friend WithEvents Lens1n_VMoni As TextBox
    Friend WithEvents Lens1p_VMoni As TextBox
    Friend WithEvents Beam_VMoni As TextBox
    Friend WithEvents txt_ExtVGain_ADC As TextBox
    Friend WithEvents txt_ExtVOffset_ADC As TextBox
    Friend WithEvents txt_SupVOffset_ADC_R As TextBox
    Friend WithEvents txt_SupVGain_ADC_R As TextBox
    Friend WithEvents txt_ExtVGain_ADC_R As TextBox
    Friend WithEvents txt_ExtVOffset_ADC_R As TextBox
    Friend WithEvents txt_SupVOffset_ADC As TextBox
    Friend WithEvents txt_SupVGain_ADC As TextBox
    Friend WithEvents txt_HtrVGain_ADC As TextBox
    Friend WithEvents txt_L2VOffset_ADC_R As TextBox
    Friend WithEvents txt_HtrVOffset_ADC As TextBox
    Friend WithEvents txt_L2VGain_ADC_R As TextBox
    Friend WithEvents txt_HtrVGain_ADC_R As TextBox
    Friend WithEvents txt_L2VOffset_ADC As TextBox
    Friend WithEvents txt_HtrVOffset_ADC_R As TextBox
    Friend WithEvents txt_L2VGain_ADC As TextBox
    Friend WithEvents txt_L1nVOffset_ADC_R As TextBox
    Friend WithEvents txt_L1nVGain_ADC_R As TextBox
    Friend WithEvents txt_L1nVOffset_ADC As TextBox
    Friend WithEvents txt_L1nVGain_ADC As TextBox
    Friend WithEvents txt_L1pVOffset_ADC_R As TextBox
    Friend WithEvents txt_L1pVGain_ADC_R As TextBox
    Friend WithEvents txt_L1pVOffset_ADC As TextBox
    Friend WithEvents txt_L1pVGain_ADC As TextBox
    Friend WithEvents txt_BeamVOffset_ADC_R As TextBox
    Friend WithEvents txt_BeamVGain_ADC_R As TextBox
    Friend WithEvents txt_BeamVOffset_ADC As TextBox
    Friend WithEvents txt_BeamVGain_ADC As TextBox
    Friend WithEvents btn_HeaterVOffset_Read As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents btn_SupVOffset_Read As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents btn_ExtVGain_Set As Button
    Friend WithEvents Label51 As Label
    Friend WithEvents btn_SupVGain_Read As Button
    Friend WithEvents btn_ExtVOffset_Set As Button
    Friend WithEvents btn_SupVOffset_Set As Button
    Friend WithEvents btn_ExtVGain_Read As Button
    Friend WithEvents btn_SupVGain_Set As Button
    Friend WithEvents btn_ExtVOffset_Read As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents btn_Lens2VOffset_Read As Button
    Friend WithEvents btn_Lens2VGain_Read As Button
    Friend WithEvents btn_HeaterVGain_Set As Button
    Friend WithEvents btn_HeaterVOffset_Set As Button
    Friend WithEvents btn_Lens2VOffset_Set As Button
    Friend WithEvents btn_Lens2VGain_Set As Button
    Friend WithEvents btn_HeaterVGain_Read As Button
    Friend WithEvents btn_Lens1nVOffset_Read As Button
    Friend WithEvents btn_Lens1nVGain_Read As Button
    Friend WithEvents btn_Lens1nVOffset_Set As Button
    Friend WithEvents btn_Lens1nVGain_Set As Button
    Friend WithEvents btn_Lens1pVOffset_Read As Button
    Friend WithEvents btn_Lens1pVGain_Read As Button
    Friend WithEvents btn_Lens1pVGain_Set As Button
    Friend WithEvents btn_BeamVOffset_Read As Button
    Friend WithEvents btn_BeamVGain_Read As Button
    Friend WithEvents btn_BeamVOffset_Set As Button
    Friend WithEvents btn_BeamVGain_Set As Button
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btn_Lens1pVOffset_Set As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label54 As Label
    Friend WithEvents Hearter_IMoni As TextBox
    Friend WithEvents Extractor_IMoni As TextBox
    Friend WithEvents Suppressor_IMoni As TextBox
    Friend WithEvents Lens2_IMoni As TextBox
    Friend WithEvents Lens1n_IMoni As TextBox
    Friend WithEvents Lens1p_IMoni As TextBox
    Friend WithEvents Beam_IMoni As TextBox
    Friend WithEvents txt_ExtIGain_ADC As TextBox
    Friend WithEvents txt_ExtIOffset_ADC As TextBox
    Friend WithEvents txt_SupIOffset_ADC_R As TextBox
    Friend WithEvents txt_BeamIGain_ADC As TextBox
    Friend WithEvents txt_SupIGain_ADC_R As TextBox
    Friend WithEvents txt_ExtIGain_ADC_R As TextBox
    Friend WithEvents txt_BeamIOffset_ADC As TextBox
    Friend WithEvents txt_ExtIOffset_ADC_R As TextBox
    Friend WithEvents txt_SupIOffset_ADC As TextBox
    Friend WithEvents txt_BeamIGain_ADC_R As TextBox
    Friend WithEvents txt_SupIGain_ADC As TextBox
    Friend WithEvents txt_BeamIOffset_ADC_R As TextBox
    Friend WithEvents txt_HtrIGain_ADC As TextBox
    Friend WithEvents txt_L1pIGain_ADC As TextBox
    Friend WithEvents txt_L2IOffset_ADC_R As TextBox
    Friend WithEvents txt_L1pIOffset_ADC As TextBox
    Friend WithEvents txt_HtrIOffset_ADC As TextBox
    Friend WithEvents txt_L1pIGain_ADC_R As TextBox
    Friend WithEvents txt_L2IGain_ADC_R As TextBox
    Friend WithEvents txt_L1pIOffset_ADC_R As TextBox
    Friend WithEvents txt_L1nIGain_ADC As TextBox
    Friend WithEvents txt_HtrIGain_ADC_R As TextBox
    Friend WithEvents txt_L1nIOffset_ADC As TextBox
    Friend WithEvents txt_L2IOffset_ADC As TextBox
    Friend WithEvents txt_L1nIGain_ADC_R As TextBox
    Friend WithEvents txt_HtrIOffset_ADC_R As TextBox
    Friend WithEvents txt_L2IGain_ADC As TextBox
    Friend WithEvents txt_L1nIOffset_ADC_R As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents btn_SupIOffset_Read As Button
    Friend WithEvents Label52 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents btn_ExtIGain_Set As Button
    Friend WithEvents Label40 As Label
    Friend WithEvents btn_SupIGain_Read As Button
    Friend WithEvents btn_Lens1pIOffset_Set As Button
    Friend WithEvents btn_ExtIOffset_Set As Button
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents btn_SupIOffset_Set As Button
    Friend WithEvents Label45 As Label
    Friend WithEvents btn_ExtIGain_Read As Button
    Friend WithEvents Label48 As Label
    Friend WithEvents btn_SupIGain_Set As Button
    Friend WithEvents btn_BeamIGain_Set As Button
    Friend WithEvents btn_BeamIOffset_Set As Button
    Friend WithEvents btn_ExtIOffset_Read As Button
    Friend WithEvents btn_BeamIGain_Read As Button
    Friend WithEvents Label49 As Label
    Friend WithEvents btn_Lens2IOffset_Read As Button
    Friend WithEvents btn_BeamIOffset_Read As Button
    Friend WithEvents btn_Lens1pIGain_Set As Button
    Friend WithEvents btn_Lens2IGain_Read As Button
    Friend WithEvents btn_HeaterIGain_Set As Button
    Friend WithEvents btn_Lens1pIGain_Read As Button
    Friend WithEvents btn_HeaterIOffset_Set As Button
    Friend WithEvents btn_Lens1pIOffset_Read As Button
    Friend WithEvents btn_Lens2IOffset_Set As Button
    Friend WithEvents btn_Lens2IGain_Set As Button
    Friend WithEvents btn_Lens1nIGain_Set As Button
    Friend WithEvents btn_HeaterIGain_Read As Button
    Friend WithEvents btn_Lens1nIOffset_Set As Button
    Friend WithEvents btn_Lens1nIGain_Read As Button
    Friend WithEvents btn_HeaterIOffset_Read As Button
    Friend WithEvents btn_Lens1nIOffset_Read As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents BtnCalStop As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnReadDmm As Button
    Friend WithEvents Label72 As Label
    Friend WithEvents BtnReadDmm8 As Button
    Friend WithEvents Label65 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents TextBoxReadDmm As TextBox
    Friend WithEvents TextBoxProofreading As TextBox
    Friend WithEvents TextBoxDCV As TextBox
    Friend WithEvents Label66 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label70 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents TextBoxHV40k As TextBox
    Friend WithEvents TextBoxHV30k As TextBox
    Friend WithEvents TextBoxHV20k As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents TextBoxHV10k As TextBox
    Friend WithEvents BtnVisaSearch As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents TextBoxVisaAdr As TextBox
    Friend WithEvents BtnVisaClose As Button
    Friend WithEvents BtnVisaOpen As Button
    Friend WithEvents Label64 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label87 As Label
    Friend WithEvents tbSirialNum As TextBox
    Friend WithEvents cbTest1 As CheckBox
    Friend WithEvents cbTest3 As CheckBox
    Friend WithEvents cbTest2 As CheckBox
    Friend WithEvents cbTest10 As CheckBox
    Friend WithEvents cbTest9 As CheckBox
    Friend WithEvents cbTest6 As CheckBox
    Friend WithEvents cbTest8 As CheckBox
    Friend WithEvents cbTest7 As CheckBox
    Friend WithEvents cbTest5 As CheckBox
    Friend WithEvents cbTest4 As CheckBox
    Friend WithEvents rbFinal As RadioButton
    Friend WithEvents rbPrePotting As RadioButton
    Friend WithEvents btnTestRun As Button
    Friend WithEvents btnTestAll As Button
    Friend WithEvents txtTestMsg As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label88 As Label
    Friend WithEvents BtnTEMP As Button
    Friend WithEvents Label90 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents btPass1 As Button
    Friend WithEvents btPass10 As Button
    Friend WithEvents btPass9 As Button
    Friend WithEvents btPass8 As Button
    Friend WithEvents btPass7 As Button
    Friend WithEvents btPass6 As Button
    Friend WithEvents btPass5 As Button
    Friend WithEvents btPass4 As Button
    Friend WithEvents btPass3 As Button
    Friend WithEvents btPass2 As Button
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents RBFinalAging As RadioButton
    Friend WithEvents RBPrepotAging As RadioButton
    Friend WithEvents BTagingRun As Button
    Friend WithEvents Label92 As Label
    Friend WithEvents tbSerialNum2 As TextBox
    Friend WithEvents tbCheckExtr As TextBox
    Friend WithEvents tbCheckSup As TextBox
    Friend WithEvents tbCheckHeat As TextBox
    Friend WithEvents Label94 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents tbAmbTemp As TextBox
    Friend WithEvents arRS232 As IO.Ports.SerialPort
    Friend WithEvents tbAmbHumidity As TextBox
    Friend WithEvents Label95 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents TBagingL2 As TextBox
    Friend WithEvents TBagingL1 As TextBox
    Friend WithEvents TBagingHeat As TextBox
    Friend WithEvents TBagingExt As TextBox
    Friend WithEvents TBagingSup As TextBox
    Friend WithEvents Label97 As Label
    Friend WithEvents Label98 As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents TBagingBeam As TextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents TBagingTime As TextBox
    Friend WithEvents TB_date As TextBox
    Friend WithEvents Label104 As Label
    Friend WithEvents Label105 As Label
    Friend WithEvents TB_date2 As TextBox
    Friend WithEvents Label110 As Label
    Friend WithEvents Label109 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents TBagingL2V As TextBox
    Friend WithEvents TBagingL1V As TextBox
    Friend WithEvents TBagingHI As TextBox
    Friend WithEvents TBagingEV As TextBox
    Friend WithEvents TBagingSV As TextBox
    Friend WithEvents TBagingBV As TextBox
    Friend WithEvents Label107 As Label
    Friend WithEvents TBagingL2V1 As TextBox
    Friend WithEvents TBagingL1V1 As TextBox
    Friend WithEvents TBagingHI1 As TextBox
    Friend WithEvents TBagingEV1 As TextBox
    Friend WithEvents TBagingSV1 As TextBox
    Friend WithEvents TBagingBV1 As TextBox
    Friend WithEvents Label106 As Label
    Friend WithEvents Label111 As Label
    Friend WithEvents Label136 As Label
    Friend WithEvents Label134 As Label
    Friend WithEvents Label135 As Label
    Friend WithEvents Label132 As Label
    Friend WithEvents Label133 As Label
    Friend WithEvents Label130 As Label
    Friend WithEvents Label131 As Label
    Friend WithEvents Label128 As Label
    Friend WithEvents Label129 As Label
    Friend WithEvents Label126 As Label
    Friend WithEvents Label127 As Label
    Friend WithEvents Label124 As Label
    Friend WithEvents Label125 As Label
    Friend WithEvents Label122 As Label
    Friend WithEvents Label123 As Label
    Friend WithEvents Label120 As Label
    Friend WithEvents Label121 As Label
    Friend WithEvents Label118 As Label
    Friend WithEvents Label119 As Label
    Friend WithEvents Label116 As Label
    Friend WithEvents Label117 As Label
    Friend WithEvents Label115 As Label
    Friend WithEvents Label114 As Label
    Friend WithEvents Label113 As Label
    Friend WithEvents Label112 As Label
    Friend WithEvents TBagingL2I As TextBox
    Friend WithEvents TBagingL2I1 As TextBox
    Friend WithEvents TBagingL1I As TextBox
    Friend WithEvents TBagingL1I1 As TextBox
    Friend WithEvents TBagingHV As TextBox
    Friend WithEvents TBagingHV1 As TextBox
    Friend WithEvents TBagingEI As TextBox
    Friend WithEvents TBagingEI1 As TextBox
    Friend WithEvents TBagingSI As TextBox
    Friend WithEvents TBagingSI1 As TextBox
    Friend WithEvents TBagingBI As TextBox
    Friend WithEvents TBagingBI1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TBkeika As TextBox
    Friend WithEvents TBagingBVp As TextBox
    Friend WithEvents Label138 As Label
    Friend WithEvents Label137 As Label
    Friend WithEvents TBagingL2Ip As TextBox
    Friend WithEvents TBagingL2Vp As TextBox
    Friend WithEvents TBagingL1Ip As TextBox
    Friend WithEvents TBagingL1Vp As TextBox
    Friend WithEvents TBagingHVp As TextBox
    Friend WithEvents TBagingHIp As TextBox
    Friend WithEvents TBagingEIp As TextBox
    Friend WithEvents TBagingEVp As TextBox
    Friend WithEvents TBagingSIp As TextBox
    Friend WithEvents TBagingSVp As TextBox
    Friend WithEvents TBagingBIp As TextBox
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents BTAgingRunAgain As Button
    Friend WithEvents Label140 As Label
    Friend WithEvents Label139 As Label
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label142 As Label
    Friend WithEvents Label141 As Label
    Friend WithEvents TB_dmm As TextBox
    Friend WithEvents btn_ParamReadAll As Button
    Friend WithEvents btn_DG406_Speed_Read As Button
    Friend WithEvents txt_DG406_SPEED_R2 As TextBox
    Friend WithEvents txt_DG406_SPEED_R As TextBox
End Class