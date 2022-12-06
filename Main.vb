Imports System.IO
Imports System.Text
Imports System.Xml.Serialization
Imports System.Runtime.Serialization.Json
'Imports System.Xml
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Diagnostics


Public Class Main1

    Const xmlHVprobe As String = ".\HVProbe.xml"
    Const xmlPrePotting As String = ".\PrePotting.xml"
    Const xmlAging As String = ".\AgingTest.xml"
    Const JsonPrePotting As String = ".\PrePotting.json"
    Const Js As String = ".\PrePotting.json"


    Const cBeamVset As String = "~ 00 64 "          ' Beam V set
    Const cBeamVread As String = "~ 00 78 14"       ' Beam V Read
    Const cBeamIread As String = "~ 00 78 15"       ' Beam I Read

    Const cSupVset As String = "~ 00 66 "           ' Suppressor V set
    Const cSupVread As String = "~ 00 78 16"        ' Suppresor V Read
    Const cSupIread As String = "~ 00 78 17"        ' Suppresor I Read

    Const cHeaterIset As String = "~ 00 69 "        ' Heater I set
    Const cHeaterIread As String = "~ 00 78 18"     ' Heater I Read
    Const cHeaterVread As String = "~ 00 78 19"     ' Heater V Read

    Const cExtrVset As String = "~ 00 65 "          ' Extractor V set
    Const cExtrCurLim As String = "~ 00 72 "        ' ExtCurrentLim I set
    Const cExtrVread As String = "~ 00 78 1E"       ' Extractor V Read
    Const cExtrIread As String = "~ 00 78 1F"       ' Extractor I Read

    Const cLens1Vset As String = "~ 00 67 "         ' Lens1 V set
    Const cLens1Vread As String = "~ 00 78 10"      ' Lens1 V Read
    Const cLens1Iread As String = "~ 00 78 11"      ' Lens1 I Read

    Const cLens2Vset As String = "~ 00 68 "         ' Lens2 V set
    Const cLens2Vread As String = "~ 00 78 12"      ' Lens2 V Read
    Const cLens2Iread As String = "~ 00 78 13"      ' Lens2 I Read

    Const cEmiIread As String = "~ 00 78 80"        ' Emission I Read

    Const cStatusGet As String = "~ 00 82"          ' Status Read
    Const cStatusClear As String = "~ 00 83"        ' Status clear
    Const cFanSpeedGet As String = "~ 00 84"        ' FAN Speed Read

    Const cBeam24VGet As String = "~ 00 78 56"      ' Beam 24V Read
    Const cL1_24VGet As String = "~ 00 78 57"       ' Lens1 24V Read
    Const cL2_24VGet As String = "~ 00 78 58"       ' Lens2 24V Read
    Const cF25VGet As String = "~ 00 78 81"         ' 25V Float Read



    Dim Testlogfile As String = ""   ' TEST LOG file name
    Dim Aginglogfile As String = ""   ' Aging LOG file name


    Dim Rs232cErr As Integer = 0

    Dim previous_gun_state As Integer = 0

    Dim cycles As Integer = 0
    Dim sputtertime As Integer = 0
    Dim standbyinterval As Integer = 0
    Dim Ccycles As Integer = 0
    Dim Csputtertime As Integer = 0
    Dim Cstandbyinterval As Integer = 0
    Dim Recv_Data As String = ""

    Dim MinVal_Gain As Integer = 9000
    Dim MaxVal_Gain As Integer = 11000

    Dim MinVal_Offset As Integer = -1000
    Dim MaxVal_Offset As Integer = 1000

    Dim ReadBackStatus As Integer = 0

    Dim SelectedLogFile As String = ""

    Dim RM As Ivi.Visa.Interop.ResourceManager ' VISA COM リソースマネージャ
    Dim DMM As Ivi.Visa.Interop.FormattedIO488 ' VISA COM フォーマッテッドIO

    Dim DmmOpen As Boolean = False
    Dim Proofread As Boolean = False

    Dim CalCancel As Boolean = False
    Dim AgingCancel As Boolean = False
    Dim UsageCancel As Boolean = False

    Dim DEBUG_ENABLE As Boolean = True
    'CAL値の現在値。LMIGから0x06コマンドでCAL値を求めて以下に保存。0x05コマンドで設定した時も。
    Dim DacGainCalValues(DacGainItems.MAX_OF_DAC_GAIN_ITEMS) As Integer
    Dim DacOfstCalValues(DacOfstItems.MAX_OF_DAC_OFST_ITEMS) As Integer
    Dim AdcGainCalValues(AdcGainItems.MAX_OF_ADC_GAIN_ITEMS) As Integer
    Dim AdcOfstCalValues(AdcOfstItems.MAX_OF_ADC_OFST_ITEMS) As Integer

    Dim ReceivedData As String = " "                '受信データ用変数
    'Private Delegate Sub AsyncMethodCaller(ByRef str As String)


    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt_BeamGain.Text = "10000"
        txt_BeamOffset.Text = "0000"
        txt_L1pGain.Text = "10000"
        txt_L1pOffset.Text = "0000"
        txt_L1nGain.Text = "10000"
        txt_L1nOffset.Text = "0000"
        txt_L2Gain.Text = "10000"
        txt_L2Offset.Text = "0000"
        txt_SupGain.Text = "10000"
        txt_SupOffset.Text = "0000"
        txt_ExtGain.Text = "10000"
        txt_ExtOffset.Text = "0000"
        txt_HtrGain.Text = "10000"
        txt_HtrOffset.Text = "0000"

        txt_BeamVGain_ADC.Text = "10000"
        txt_BeamVOffset_ADC.Text = "0000"
        txt_L1pVGain_ADC.Text = "10000"
        txt_L1pVOffset_ADC.Text = "0000"
        txt_L1nVGain_ADC.Text = "10000"
        txt_L1nVOffset_ADC.Text = "0000"
        txt_L2VGain_ADC.Text = "10000"
        txt_L2VOffset_ADC.Text = "0000"
        txt_SupVGain_ADC.Text = "10000"
        txt_SupVOffset_ADC.Text = "0000"
        txt_ExtVGain_ADC.Text = "10000"
        txt_ExtVOffset_ADC.Text = "0000"
        txt_HtrVGain_ADC.Text = "10000"
        txt_HtrVOffset_ADC.Text = "0000"

        txt_BeamIGain_ADC.Text = "10000"
        txt_BeamIOffset_ADC.Text = "0000"
        txt_L1pIGain_ADC.Text = "10000"
        txt_L1pIOffset_ADC.Text = "0000"
        txt_L1nIGain_ADC.Text = "10000"
        txt_L1nIOffset_ADC.Text = "0000"
        txt_L2IGain_ADC.Text = "10000"
        txt_L2IOffset_ADC.Text = "0000"
        txt_SupIGain_ADC.Text = "10000"
        txt_SupIOffset_ADC.Text = "0000"
        txt_ExtIGain_ADC.Text = "10000"
        txt_ExtIOffset_ADC.Text = "0000"
        txt_HtrIGain_ADC.Text = "10000"
        txt_HtrIOffset_ADC.Text = "0000"

        txt_PWM_Freq.Text = "400"
        txt_PWM_Duty.Text = "70"
        txt_PWM_DeadTime.Text = "100"

        TBoxErrCont.Text = Rs232cErr.ToString

        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False


        ' 作業用のtestフォルダの有無の確認。 無ければ作る。＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
        Dim LocalPCpath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        Dim folder As String = LocalPCpath + "\test"

        If System.IO.Directory.Exists(folder) Then
            'MessageBox.Show("testフォルダは存在します")
        Else
            MessageBox.Show("testフォルダが存在しません。" + vbCrLf + "作成します。")
            My.Computer.FileSystem.CreateDirectory(folder)
        End If
        ' ＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝


        'エージング中にアプリが落ちた時のリカバリ＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
        Dim AgingRun As String = GetSetting("20_750", "Operation_Value", "Aging_status")
        Dim AgingStatus As String = GetSetting("20_750", "Operation_Value", "Aging_mode")

        If AgingRun = "RUN" Then

            If AgingStatus = "PrepotAging" Then
                RBPrepotAging.Checked = True
                RBFinalAging.Checked = False
            Else
                RBPrepotAging.Checked = False
                RBFinalAging.Checked = True
            End If

            TB_date.Text = GetSetting("20_750", "Operation_Value", "Aging_date")
            TB_date2.Text = GetSetting("20_750", "Operation_Value", "Aging_date2")
            tbSerialNum2.Text = GetSetting("20_750", "Operation_Value", "Aging_Serial")
            'Aginglogfile = GetSetting("20_750", "Operation_Value", "Aging_logfile")

            BTAgingRunAgain.Enabled = Enabled   'この変数使われていない？ D_TEST

        End If



        ' ＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

        PortOpen()


    End Sub

    Private Sub Main1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CpuProgress()
    End Sub

    Private Sub Main1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        'Dialog1.Show()
        'ShutDown_Dialog()


        CalCancel = True
        AgingCancel = True
        UsageCancel = True

        Application.DoEvents()

    End Sub

    Public Function Send_RS232(ByVal pkt_string As String, Optional ByVal full_string As Boolean = False)
        pkt_string += " "
        Dim checksum As UInt16 = 0
        Dim i As Integer = 0

        myRS232.ReadTimeout = 500

        For i = 1 To pkt_string.Length - 1
            checksum += Asc(pkt_string(i))
        Next
        Dim CkA As Byte = Math.Truncate((checksum / 2 ^ 4)) And &HF
        Dim CkB As Byte = checksum And &HF
        pkt_string += CkA.ToString("X") + CkB.ToString("X") + vbCr

        System.Threading.Thread.Sleep(10)

        'Dim threadId As Integer

        Dim get_string As String = String.Empty
        Try
            If Not pkt_string = "" Then
                tbShowRawSend.Text = pkt_string
                myRS232.Write(pkt_string)

                System.Threading.Thread.Sleep(20)
                get_string = myRS232.ReadTo(vbCr)

            End If
            tbShowRawReceive.Text = get_string
            Recv_Data = get_string
        Catch ex As TimeoutException
            Rs232cErr = Rs232cErr + 1
            TBoxErrCont.Text = Rs232cErr.ToString

            If (Rs232cErr Mod 10) = 0 Then  ' タイムアウト10回発生ごとにReadbackを止める。フリーズを防ぐため。
                cbReadBack.Checked = False
            End If
            Return "RS232ERROR"

        Catch ex As Exception
            Rs232cErr = Rs232cErr + 1
            TBoxErrCont.Text = Rs232cErr.ToString
            'MsgBox("RS232 Comm error")

        End Try

        If full_string Then
            Return (get_string)
        Else
            Dim temp_array() As String = Split(get_string)
            If temp_array.Length > 2 Then
                Return (temp_array(3))
            Else
                Return ""
            End If

        End If

    End Function

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click

        cPortSel.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            cPortSel.Items.Add(sp)
        Next

        If cPortSel.Items.Count >= 1 Then
            Try
                cPortSel.SelectedItem = cPortSel.Items(0).ToString
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub PortOpen()
        '===========================================
        ' 起動時に自動接続する関数
        '===========================================

        Dim portselect As String = GetSetting("20_750", "Operation_Value", "RS232port")

        If portselect = "" Then   'レジストリ入っていなかったら portserchして抜ける。
            GoTo portserch
        End If

        Try
            With myRS232
                .PortName = portselect
                .BaudRate = 9600
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Parity = IO.Ports.Parity.None
                .ReadTimeout = 500    ' 500ms
            End With
            myRS232.Open()
            'myRS232.DtrEnable = True
            'cPortSel.Enabled = False

        Catch ex As Exception
            Rs232cErr = Rs232cErr + 1
            TBoxErrCont.Text = Rs232cErr.ToString
            'SaveSetting("20_750", "Operation_Value", "RS232port", "")   'レジストリ削除する
            'MessageBox.Show(ex.Message, "RS232 Connection Error", MessageBoxButtons.OK)
        Finally
            bPortClose.Enabled = myRS232.IsOpen
            bPortOpen.Enabled = Not myRS232.IsOpen

            If myRS232.IsOpen Then
                myRS232.DtrEnable = True
                'cPortSel.Enabled = False

                ' SaveSetting("20_750", "Operation_Value", "RS232port", portselect)

                bSystem.Enabled = True
                bInitialize.Enabled = True
                bSend.Enabled = True
                cbReadBack.Enabled = True
                bReadBack.Enabled = True
                btn_Get_Ver.Enabled = True
                GroupBox8.Enabled = True
                TabPage3.Enabled = True
                TabPage4.Enabled = True
                TabPage5.Enabled = True

            End If
        End Try


        portselect = GetSetting("20_750", "Operation_Value", "ar232port")

        If portselect = "" Then   'レジストリ入っていなかったら portserchして抜ける。
            GoTo portserch
        End If


        Try
            With arRS232
                .PortName = portselect
                .BaudRate = 115200
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Parity = IO.Ports.Parity.None
                .ReadTimeout = 500    ' 500ms
            End With
            arRS232.Open()

        Catch ex As Exception
            Rs232cErr = Rs232cErr + 1
            TBoxErrCont.Text = Rs232cErr.ToString
            'SaveSetting("20_750", "Operation_Value", "ar232port", "") 'レジストリ削除する
        Finally
            If arRS232.IsOpen Then
                arRS232.DtrEnable = True
                BtnTEMP.Text = "CLOSE"
            End If
        End Try


portserch:
        '------------------ PORT一覧を列挙しておく----------------------------
        cPortSel.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            cPortSel.Items.Add(sp)
        Next

        If cPortSel.Items.Count >= 1 Then
            Try
                cPortSel.SelectedItem = cPortSel.Items(0).ToString
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub bPortOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPortOpen.Click

        'Dim portselect As String = GetSetting("20_750", "Operation_Value", "RS232port")

        'If portselect = "" Then   'レジストリ入っていなかったら SelectedItemを使用する。
        '    portselect = cPortSel.SelectedItem
        'ElseIf portselect = cPortSel.SelectedItem Then
        'Else
        '    portselect = cPortSel.SelectedItem
        'End If

        Try
            With myRS232
                .PortName = cPortSel.SelectedItem
                .BaudRate = 9600
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Parity = IO.Ports.Parity.None
                .ReadTimeout = 500    ' 500ms
            End With
            myRS232.Open()
            'myRS232.DtrEnable = True
            'cPortSel.Enabled = False

        Catch ex As Exception
            Rs232cErr = Rs232cErr + 1
            TBoxErrCont.Text = Rs232cErr.ToString
            SaveSetting("20_750", "Operation_Value", "RS232port", "")   'レジストリ削除する
            'MessageBox.Show(ex.Message, "RS232 Connection Error", MessageBoxButtons.OK)
        Finally
            bPortClose.Enabled = myRS232.IsOpen
            bPortOpen.Enabled = Not myRS232.IsOpen

            If myRS232.IsOpen Then

                SaveSetting("20_750", "Operation_Value", "RS232port", cPortSel.SelectedItem) '自動接続用にレジストリ登録

                myRS232.DtrEnable = True
                'cPortSel.Enabled = False

                bSystem.Enabled = True
                bInitialize.Enabled = True
                bSend.Enabled = True
                cbReadBack.Enabled = True
                bReadBack.Enabled = True
                btn_Get_Ver.Enabled = True
                GroupBox8.Enabled = True
                TabPage3.Enabled = True
                TabPage4.Enabled = True
                TabPage5.Enabled = True

            End If
        End Try
    End Sub

    Private Sub BtnTEMP_Click(sender As Object, e As EventArgs) Handles BtnTEMP.Click
        ' 温度センサー読み取り　Arduinoから定期的にデータが送られてくる 終端文字 LFのみ \n

        If arRS232.IsOpen Then
            arRS232.Close()
            BtnTEMP.Text = "CONNECT"
            tbAmbTemp.Text = ""
            tbAmbHumidity.Text = ""
            Exit Sub
        End If


        Try
            With arRS232
                .PortName = cPortSel.SelectedItem
                .BaudRate = 115200
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Parity = IO.Ports.Parity.None
                .ReadTimeout = 500    ' 500ms
            End With
            arRS232.Open()


        Catch ex As Exception
            Rs232cErr = Rs232cErr + 1
            TBoxErrCont.Text = Rs232cErr.ToString
            SaveSetting("20_750", "Operation_Value", "ar232port", "") 'レジストリ削除する
            'MessageBox.Show(ex.Message, "RS232 Connection Error", MessageBoxButtons.OK)
        Finally
            If arRS232.IsOpen Then
                arRS232.DtrEnable = True
                BtnTEMP.Text = "CLOSE"
                SaveSetting("20_750", "Operation_Value", "ar232port", cPortSel.SelectedItem) '自動接続用にレジストリ登録

            End If
        End Try

    End Sub

    Delegate Sub DataDelegate(ByVal sdata As String)

    Private Sub PrintData(ByVal sdata As String)
        Dim arr1() As String = sdata.Split(" ")
        tbAmbTemp.Text = arr1(1)
        tbAmbHumidity.Text = arr1(3)

    End Sub

    Private Sub arRS232_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles arRS232.DataReceived

        '受信データ格納変数
        Dim mRecvData As String = arRS232.ReadLine()
        Dim arr1() As String = mRecvData.Split(" ") 'この変数いらない？  D_TEST
        'tbAmbTemp.Text = "aaaa" スレッドが違うからアクセスできない。

        Dim adre As New DataDelegate(AddressOf PrintData)
        Me.Invoke(adre, mRecvData)

        'Console.WriteLine(mRecvData)
        'If arr1.Length > 2 Then
        '    Me.Invoke(adre, arr1(1))
        '    '    tbAmbTemp.Text = arr1(1)
        'End If

    End Sub


    Private Sub bPortClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPortClose.Click
        myRS232.Close()
        bPortClose.Enabled = myRS232.IsOpen
        bPortOpen.Enabled = Not myRS232.IsOpen
        bInitialize.Enabled = False
        bSystem.Enabled = False
        cPortSel.Enabled = True
        'cbReadBack.Checked = False
        'cbReadBack.Enabled = False
        'bReadBack.Enabled = False
        'btn_Get_Ver.Enabled = False
        'GroupBox8.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        TabPage5.Enabled = False
    End Sub

    Private Sub bInitialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bInitialize.Click
        Dim RevData As String
        RevData = Send_RS232("~ 00 82")
        'If Mid(RevData, 1, 2) = "00" And Mid(RevData, 4, 2) = "OK" Then
        If Mid(Recv_Data, 1, 2) = "00" And Mid(Recv_Data, 4, 2) = "OK" Then
            'Panel1.Enabled = True
        Else
            Rs232cErr = Rs232cErr + 1
            TBoxErrCont.Text = Rs232cErr.ToString
            'MsgBox("20-750 error")
            'Panel1.Enabled = True
        End If

    End Sub

    Private Sub bSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSend.Click
        Send_RS232(tbSend.Text)
    End Sub

    Private Sub frmDemographics_KeyDown(ByVal sender As Object,
    ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.F5
                'bReadAmpVol.PerformClick()
        End Select

    End Sub

    Public Function Setallzero()
        Dim ret As String = ""

        ret = Send_RS232("~ 00 64 0") ' Beam V set

        If ret = "RS232ERROR" Then
            Return False
        End If
        Send_RS232("~ 00 65 0")         ' Extractor V set
        Send_RS232("~ 00 66 0")         ' Suppressor V set
        Send_RS232("~ 00 67 0")         ' Lens1 V set
        Send_RS232("~ 00 68 0")         ' Lens2 V set
        Send_RS232("~ 00 69 0")         ' Heater I set
        Send_RS232(cExtrCurLim + "0")   ' Extrctor current limit

        Return True
    End Function


    Private Sub nuBeamEnargy_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuBeamEnergy.ValueChanged
        If rbOn.Checked Then
            'Send_RS232(cBeamVset + Convert.ToString(nuBeamEnergy.Value))
            Send_RS232(cBeamVset + nuBeamEnergy.Value.ToString("0"))
        End If
        SaveSetting("20_750", "Operation_Value", "BeamEnergy", nuBeamEnergy.Value)
    End Sub

    Private Sub nuExtractor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuExtractor.ValueChanged
        If rbOn.Checked Then
            'Send_RS232("~ 00 65 " + Convert.ToString(nuExtractor.Value))
            Send_RS232(cExtrVset + nuExtractor.Value.ToString("0"))
        End If
        SaveSetting("20_750", "Operation_Value", "Extractor", nuExtractor.Value)
    End Sub

    Private Sub nuSuppressor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuSuppressor.ValueChanged
        If rbOn.Checked Then
            'Send_RS232("~ 00 66 " + Convert.ToString(nuSuppressor.Value))
            Send_RS232(cSupVset + nuSuppressor.Value.ToString("0"))
        End If
        SaveSetting("20_750", "Operation_Value", "Suppressor", nuSuppressor.Value)
    End Sub

    Private Sub nuLens1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuLens1.ValueChanged
        If rbOn.Checked Then
            'Send_RS232("~ 00 67 " + Convert.ToString(nuLens1.Value))
            Send_RS232(cLens1Vset + nuLens1.Value.ToString("0"))
        End If
        SaveSetting("20_750", "Operation_Value", "Lens1", nuLens1.Value)
    End Sub

    Private Sub nuLens2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuLens2.ValueChanged
        If rbOn.Checked Then
            'Send_RS232("~ 00 68 " + Convert.ToString(nuLens2.Value))
            Send_RS232(cLens2Vset + nuLens2.Value.ToString("0"))
        End If
        SaveSetting("20_750", "Operation_Value", "Lens2", nuLens2.Value)
    End Sub

    Private Sub nuFilamentHeater_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuFilamentHeater.ValueChanged
        If rbOn.Checked Then
            Send_RS232(cHeaterIset + Convert.ToString(nuFilamentHeater.Value))
        End If
        SaveSetting("20_750", "Operation_Value", "FilamentHeater", nuFilamentHeater.Value)
    End Sub

    Private Sub NuExtCurrentLim_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuExtCurrentLim.ValueChanged

        Send_RS232("~ 00 72 " + Convert.ToString(NuExtCurrentLim.Value))
        SaveSetting("20_750", "Operation_Value", "NuExtCurrentLim", NuExtCurrentLim.Value)

    End Sub


    Private Sub ShutDown_Dialog()
        'If Panel1.Enabled Then

        Dim result As DialogResult = MessageBox.Show("出力を停止しますか？" + vbCrLf + vbCrLf + "いいえ(N)：出力したままシャットダウンします。", "シャットダウン", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If result = DialogResult.Cancel Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            Timer1.Enabled = False
            cbReadBack.Checked = False

            Setallzero()
            BTagingRun.Text = "RUN"     ' エージング途中停止
            SaveSetting("20_750", "Operation_Value", "Aging_status", "STOP")  'レジストを RUNからSTOPに
            CalCancel = True            ' キャリブレーション途中停止
            UsageCancel = True

        ElseIf result = DialogResult.No Then
            ' 何もしないでシャットダウン
        End If

        Me.Close()

    End Sub



    Private Sub bShutDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bShutDown.Click

        ShutDown_Dialog()

        'Dim result As DialogResult = MessageBox.Show("出力を停止しますか？" + vbCrLf + vbCrLf + "いいえ(N)：出力したままシャットダウンします。", "シャットダウン", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        'If result = DialogResult.Cancel Then
        '    Exit Sub
        'ElseIf result = DialogResult.Yes Then
        '    Setallzero()
        '    BTagingRun.Text = "RUN"     ' エージング途中停止
        '    SaveSetting("20_750", "Operation_Value", "Aging_status", "STOP")  'レジストを RUNからSTOPに
        '    CalCancel = True            ' キャリブレーション途中停止
        '    UsageCancel = True

        'ElseIf result = DialogResult.No Then
        '    ' 何もしないでシャットダウン
        'End If

        'Me.Close()

    End Sub

    Private Sub ReadBackAll()
        '====================================================
        '  Read All 連続読み取り
        '====================================================
        Dim CheckdCount As Integer = 0
        Dim strResp As String = "" ' DMMからの応答を受け取る変数

        'ダミーロード検査用の計算変数
        Dim L1dummy As Double
        Dim L2dummy As Double


        If DmmOpen Then 'VISA COM DMM Read
            'DMM.WriteString("CONF:VOLT:DC AUTO")  ' 電圧測定 autoレンジ
            'DMM.WriteString("SYST:ERR?")  ' エラー有無の確認
            'strResp = DMM.ReadString()
            DMM.WriteString("INIT")  ' Ext トリガーをかける。　あとで「FETC?」して読む
        End If

        If CheckBox0.Checked Then
            CheckdCount = CheckdCount + 1
        End If
        If CheckBox1.Checked Then
            CheckdCount = CheckdCount + 1
        End If
        If CheckBox2.Checked Then
            CheckdCount = CheckdCount + 1
        End If
        If CheckBox3.Checked Then
            CheckdCount = CheckdCount + 1
        End If
        If CheckBox4.Checked Then
            CheckdCount = CheckdCount + 1
        End If
        If CheckBox5.Checked Then
            CheckdCount = CheckdCount + 1
        End If
        If CheckBox6.Checked Then
            CheckdCount = CheckdCount + 1
        End If

        If rbOn.Checked Then
            CheckdCount = CheckdCount * 250     'Control Onでは1命令250ms空ける
        Else
            CheckdCount = CheckdCount * 200     '1命令200ms空ける
        End If

        If NumericUpDown1.Value < CheckdCount Then
            Timer1.Interval = CheckdCount
        End If

        bReadBack.Enabled = False
        Me.ALL_Read()
        bReadBack.Enabled = True

        If DmmOpen Then 'VISA COM DMM Read

            DMM.WriteString("FETC?")  ' READ
            strResp = DMM.ReadString()
            TextBoxReadDmm.Text = strResp
            Dim DCV As Double = 0
            DCV = Double.Parse(TextBoxReadDmm.Text)
            DCV = DCV * 1000    ' 1000:1 プローブ
            'DCV = DCV * 4000    ' 1000:1 プローブ　　検証用で10kVを40kV表示に

            TextBoxDCV.Text = DCV.ToString("0.00")

            Proofreading(DCV)
        End If


        If cbLog.Checked Then

            If SelectedLogFile Is "" Then
                'LOGファイルを指定してなかったら標準のファイルを使う。
                'ただしフォルダ/ファイル名が見つからなかったら残らないと思う。
                'Console.WriteLine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal))
                Dim LocalPCpath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
                TextBoxLogFile.Text = LocalPCpath + "\test\Log_" + Format(Now, "yyyyMMdd_hhmmss") + ".txt"
                SelectedLogFile = TextBoxLogFile.Text
            Else
                TextBoxLogFile.Text = SelectedLogFile
            End If

            My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, ControlChars.NewLine, True)
            My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, TimeValue(Now), True)

            'My.Computer.FileSystem.WriteAllText("C:\Users\uj37981\Documents\20_750_log.txt", TimeValue(Now), True)

            If CheckBox0.Checked Then 'Beam Energy V and I

                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "BeamEnergyV" + vbTab + TextBox0.Text, True)
                'My.Computer.FileSystem.WriteAllText("20_750_log.txt", vbTab + "BeamEnergyI" + vbTab + TextBox1.Text, True)
                ' Dialog3.Chart1.Series("BeamEnergyV").Points.AddY(TextBox0.Text)
            End If

            If CheckBox1.Checked Then 'Suppresor V and I
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "SuppressorV" + vbTab + TextBox2.Text, True)
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "SuppressorI" + vbTab + TextBox3.Text, True)
                'My.Computer.FileSystem.WriteAllText("20_750_log.txt",vbTab + "SuppressorI" + vbTab + TextBox3.Text, True)
                'Dialog3.Chart1.Series("SuppressorV").Points.AddY(-TextBox2.Text)
            End If

            If CheckBox2.Checked Then 'Extractor V and I
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "ExtractorV" + vbTab + TextBox4.Text, True)
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "ExtractorI" + vbTab + TextBox5.Text, True)
                'My.Computer.FileSystem.WriteAllText("20_750_log.txt", vbTab + "ExtractorI" + vbTab + TextBox5.Text, True)
                'Dialog3.Chart1.Series("ExtractorV").Points.AddY(-TextBox4.Text)
            End If

            If CheckBox3.Checked Then 'Heater I and V
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "HeaterI" + vbTab + TextBox6.Text, True)
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "HeaterV" + vbTab + TextBox7.Text, True)
                'My.Computer.FileSystem.WriteAllText("20_750_log.txt", vbTab + "HeaterV" + vbTab + TextBox7.Text, True)
                'Dialog2.Chart1.Series("HeaterI").Points.AddY(TextBox6.Text)
            End If

            If CheckBox4.Checked Then 'Lens1 V and I
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "L1V" + vbTab + TextBox8.Text, True)
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "L1I" + vbTab + TextBox9.Text, True)

                If IsNumeric(TextBox8.Text) And IsNumeric(TextBox9.Text) Then
                    L1dummy = Single.Parse(TextBox8.Text) / Single.Parse(TextBox9.Text)
                End If

                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "L1Load" + vbTab + L1dummy.ToString("#.###"), True)

                'Dialog3.Chart1.Series("Lens1V").Points.AddY(TextBox8.Text)
            End If

            If CheckBox5.Checked Then 'Lens2 V and I
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "L2V" + vbTab + TextBox10.Text, True)
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "L2I" + vbTab + TextBox11.Text, True)

                If IsNumeric(TextBox10.Text) And IsNumeric(TextBox11.Text) Then
                    L2dummy = Single.Parse(TextBox10.Text) / Single.Parse(TextBox11.Text)
                End If

                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "L2Load" + vbTab + L2dummy.ToString("#.###"), True)
                'Dialog3.Chart1.Series("Lens2V").Points.AddY(TextBox10.Text)
            End If

            If CheckBox6.Checked Then 'Emission Current I
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "EmissionI" + vbTab + TextBox12.Text, True)
                'Dialog2.Chart1.Series("EmissionI").Points.AddY(TextBox12.Text)
            End If

            If DmmOpen Then 'VISA COM DMM Read
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "DMM" + vbTab + TextBoxDCV.Text, True)
            End If

            If Proofread Then 'HVProbe校正Enable
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "Proofread" + vbTab + TextBoxProofreading.Text, True)
            End If

            Dim txtTemp As String = Mid(Send_RS232("~ 00 78 82"), 1)
            My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "FTemp" + vbTab + txtTemp, True)
            ' 周囲温度取り込み
            If tbAmbTemp.Text IsNot "" Then
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "ATemp" + vbTab + tbAmbTemp.Text, True)
                My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, vbTab + "AHumi" + vbTab + tbAmbHumidity.Text, True)
            End If


        End If

        If cbEmissionControl.Checked Then
            If Convert.ToDecimal(TextBox12.Text) < nuEmissionControl.Value - 0.1 Then
                nuSuppressor.Value -= 0.5
            ElseIf Convert.ToDecimal(TextBox12.Text) > nuEmissionControl.Value + 0.1 Then
                nuSuppressor.Value += 0.5
            End If
        End If

    End Sub

    Private Sub bReadBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bReadBack.Click
        bReadBack.Enabled = False   'FalseにしてTrueにしている。。。。D_TEST
        Me.ALL_Read()
        bReadBack.Enabled = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If cbReadBack.Checked Then
            ReadBackAll()
        Else
            ReadBackStatus = 0
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbReadBack.CheckedChanged
        If cbReadBack.Checked Then
            ReadBackStatus = 0
            Timer1.Enabled = True
            bReadBack.Enabled = False
        Else
            Timer1.Enabled = False
            bReadBack.Enabled = True
        End If
    End Sub

    'Readボタン横のNumericUpDown値(Timerの割り込み時間) この間隔で　Timer1_Tick()が呼ばれる D_TEST
    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Timer1.Interval = NumericUpDown1.Value
    End Sub

    Private Sub CheckBox_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox0.CheckedChanged, CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged, CheckBox6.CheckedChanged
        'NumericUpDown1.Minimum = 200 * (Convert.ToInt16(CheckBox0.Checked) + Convert.ToInt16(CheckBox1.Checked) + Convert.ToInt16(CheckBox2.Checked) + Convert.ToInt16(CheckBox3.Checked) + Convert.ToInt16(CheckBox4.Checked) + Convert.ToInt16(CheckBox5.Checked) + Convert.ToInt16(CheckBox6.Checked) + Convert.ToInt16(CheckBox7.Checked) + Convert.ToInt16(CheckBox8.Checked))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dialog2.Show()
        Dialog3.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSystem.Click
        Dialog4.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Send_RS232("~ 00 6A 0 0")
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Send_RS232("~ 00 6A 1 " + Convert.ToString(nuWobble.Value))
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Send_RS232("~ 00 6A 2 " + Convert.ToString(nuWobble.Value))
        End If
    End Sub

    Private Sub nuWobble_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuWobble.ValueChanged
        If ComboBox1.SelectedIndex = 1 Then
            Send_RS232("~ 00 6A 1 " + Convert.ToString(nuWobble.Value))
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Send_RS232("~ 00 6A 2 " + Convert.ToString(nuWobble.Value))
        End If
    End Sub
    '//ExtCurrentLimit Read Botton
    Private Sub Btn_ECLim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_ECLim.Click

        TextBox42.Text = Mid(Send_RS232("~ 00 78 84"), 1) + " uA"
        TextBox41.Text = Mid(Send_RS232("~ 00 73"), 1) + " uA"

    End Sub


    '//キャリブレーション部

    '//BeamGain Set Botton
    Private Sub btn_BeamGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BeamGain_Set.Click

        Dim Set_Valtp As Integer = txt_BeamGain.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 01 " + txt_BeamGain.Text)

        End If

    End Sub


    '//BeamOffset Set Botton
    Private Sub btn_BeamOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BeamOffset_Set.Click

        Dim Set_Valtp As Integer = txt_BeamOffset.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 02 " + txt_BeamOffset.Text)

        End If

    End Sub

    '//Lens1+Gain Set Botton
    Private Sub btn_Lens1pGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1pGain_Set.Click

        Dim Set_Valtp As Integer = txt_L1pGain.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 03 " + txt_L1pGain.Text)

        End If
    End Sub

    '//Lens1pOffset Set Botton
    Private Sub btn_Lens1pOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1pOffset_Set.Click

        Dim Set_Valtp As Integer = txt_L1pOffset.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 04 " + txt_L1pOffset.Text)

        End If
    End Sub

    '//Lens1-Gain Set Botton
    Private Sub btn_Lens1nGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1nGain_Set.Click

        Dim Set_Valtp As Integer = txt_L1nGain.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 05 " + txt_L1nGain.Text)

        End If
    End Sub

    '//Lens1-Offset Set Botton
    Private Sub btn_Lens1nOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1nOffset_Set.Click

        Dim Set_Valtp As Integer = txt_L1nOffset.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 06 " + txt_L1nOffset.Text)

        End If
    End Sub
    '//Lens2PS Gain Set Botton
    Private Sub btn_Lens2Gain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens2Gain_Set.Click
        Dim Set_Valtp As Integer = txt_L2Gain.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 07 " + txt_L2Gain.Text)

        End If
    End Sub
    '//Lens2PS Offset Set Botton
    Private Sub btn_Lens2Offset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens2Offset_Set.Click
        Dim Set_Valtp As Integer = txt_L2Offset.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 08 " + txt_L2Offset.Text)

        End If
    End Sub
    '//SupPS Gain Set Botton
    Private Sub btn_SupGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SupGain_Set.Click
        Dim Set_Valtp As Integer = txt_SupGain.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 09 " + txt_SupGain.Text)

        End If
    End Sub
    '//SupPS Offset Set Botton
    Private Sub btn_SupOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SupOffset_Set.Click
        Dim Set_Valtp As Integer = txt_SupOffset.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 0A " + txt_SupOffset.Text)

        End If
    End Sub
    '//ExtPS Gain Set Botton
    Private Sub btn_ExtGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtGain_Set.Click
        Dim Set_Valtp As Integer = txt_ExtGain.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 0B " + txt_ExtGain.Text)

        End If
    End Sub
    '//ExtOffset Set Botton
    Private Sub btn_ExtOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtOffset_Set.Click
        Dim Set_Valtp As Integer = txt_ExtOffset.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 0C " + txt_ExtOffset.Text)

        End If
    End Sub
    '//HeaterPS Gain Set Botton
    Private Sub btn_HeaterGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HeaterGain_Set.Click
        Dim Set_Valtp As Integer = txt_HtrGain.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 0D " + txt_HtrGain.Text)

        End If
    End Sub
    '//HeaterPS Offset Set Botton
    Private Sub btn_HeaterOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HeaterOffset_Set.Click
        Dim Set_Valtp As Integer = txt_HtrOffset.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        If Set_Value_Enable.Checked = True Then
            Send_RS232("~ 00 05 0E " + txt_HtrOffset.Text)

        End If
    End Sub
    '//Emission Gain Set Botton
    Private Sub btn_EmiGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EmiGain_Set.Click
        Dim Set_Valtp As Integer = txt_EmiGain.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 2C " + txt_EmiGain.Text)

    End Sub
    '//Emission Offset Set Botton
    Private Sub btn_EmiOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EmiOffset_Set.Click
        Dim Set_Valtp As Integer = txt_EmiOffset.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 2D " + txt_EmiOffset.Text)

    End Sub

    '//PWM Frequency Set Botton
    Private Sub btn_PWM_Freq_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PWM_Freq_Set.Click
        Dim Set_Valtp As Integer = txt_PWM_Freq.Text
        If ((Set_Valtp > 1000) Or (Set_Valtp < 100)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 07 01 " + txt_PWM_Freq.Text)
        txt_PWM_Freq.Text = Set_Valtp '//小数点の場合もあるため

    End Sub
    '//PWM Duty Set Botton
    Private Sub btn_PWM_Duty_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PWM_Duty_Set.Click
        Dim Set_Valtp As Integer = txt_PWM_Duty.Text
        If ((Set_Valtp > 100) Or (Set_Valtp < 1)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 07 02 " + txt_PWM_Duty.Text)
        txt_PWM_Duty.Text = Set_Valtp '//小数点の場合もあるため
    End Sub

    Private Sub btn_PWM_DT_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PWM_DT_Set.Click
        Dim Set_Valtp As Integer = txt_PWM_DeadTime.Text
        If ((Set_Valtp > 1000) Or (Set_Valtp < 10)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 07 03 " + txt_PWM_DeadTime.Text)
        txt_PWM_DeadTime.Text = Set_Valtp '//小数点の場合もあるため
    End Sub

    '//PWM Frequency Read Botton
    Private Sub btn_PWM_Freq_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PWM_Freq_Read.Click
        Dim Arr As String()

        Recv_Data = ""
        Send_RS232("~ 00 08 01")

        Arr = Split(Recv_Data, )

        If Arr.Length > 2 Then
            If (Arr(1) = "OK") Then
                txt_PWM_Freq_R.Text = Arr(3)
            Else
                txt_PWM_Freq_R.Text = "NG"
            End If
        End If
    End Sub
    '//PWM Duty Read Botton
    Private Sub btn_PWM_Duty_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PWM_Duty_Read.Click
        Dim Arr As String()

        Recv_Data = ""
        Send_RS232("~ 00 08 02")

        Arr = Split(Recv_Data, )

        If Arr.Length > 2 Then
            If (Arr(1) = "OK") Then
                txt_PWM_Duty_R.Text = Arr(3)
            Else
                txt_PWM_Duty_R.Text = "NG"
            End If
        End If
    End Sub
    '//PWM DT Read Botton
    Private Sub btn_PWM_DT_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PWM_DT_Read.Click
        Dim Arr As String()

        Recv_Data = ""
        Send_RS232("~ 00 08 03")

        Arr = Split(Recv_Data, )

        If Arr.Length > 2 Then
            If (Arr(1) = "OK") Then
                txt_PWM_DeadTime_R.Text = Arr(3)
            Else
                txt_PWM_DeadTime_R.Text = "NG"
            End If
        End If
    End Sub

    '------------------------------------------------------------------------------------------
    '//BeamPS Gain Read Botton
    Private Sub btn_BeamGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BeamGain_Read.Click
        BeamGain_Read()
    End Sub
    Private Sub BeamGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_BeamGain_R.Text = ""

        Send_RS232("~ 00 06 01")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_BeamGain_R.Text = Arr(3)
        End If
    End Sub


    '//BeamPS Offset Read Botton
    Private Sub btn_BeamOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BeamOffset_Read.Click
        BeamOffset_Read()
    End Sub
    Private Sub BeamOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_BeamOffset_R.Text = ""

        Send_RS232("~ 00 06 02")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_BeamOffset_R.Text = Arr(3)
        End If
    End Sub

    '//L1PS plus-side Gain Read Botton
    Private Sub btn_Lens1pGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1pGain_Read.Click
        Lens1pGain_Read()
    End Sub
    Private Sub Lens1pGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L1pGain_R.Text = ""

        Send_RS232("~ 00 06 03")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L1pGain_R.Text = Arr(3)
        End If
    End Sub

    '//L1PS plus-side Offset Read Botton
    Private Sub btn_Lens1pOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1pOffset_Read.Click
        Lens1pOffset_Read()
    End Sub
    Private Sub Lens1pOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L1pOffset_R.Text = ""

        Send_RS232("~ 00 06 04")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L1pOffset_R.Text = Arr(3)
        End If
    End Sub

    '//L1PS minus-side Gain Read Botton
    Private Sub btn_Lens1nGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1nGain_Read.Click
        Lens1nGain_Read()
    End Sub
    Private Sub Lens1nGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L1nGain_R.Text = ""

        Send_RS232("~ 00 06 05")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L1nGain_R.Text = Arr(3)
        End If
    End Sub

    '//L1PS minus-side Offset Read Botton
    Private Sub btn_Lens1nOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1nOffset_Read.Click
        Lens1nOffset_Read()
    End Sub
    Private Sub Lens1nOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L1nOffset_R.Text = ""

        Send_RS232("~ 00 06 06")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L1nOffset_R.Text = Arr(3)
        End If
    End Sub

    '//L2PS Gain Read Botton
    Private Sub btn_Lens2Gain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens2Gain_Read.Click
        Lens2Gain_Read()
    End Sub
    Private Sub Lens2Gain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L2Gain_R.Text = ""

        Send_RS232("~ 00 06 07")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L2Gain_R.Text = Arr(3)
        End If
    End Sub

    '//L2PS Offset Read Botton
    Private Sub btn_Lens2Offset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens2Offset_Read.Click
        Lens2Offset_Read()
    End Sub
    Private Sub Lens2Offset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L2Offset_R.Text = ""

        Send_RS232("~ 00 06 08")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L2Offset_R.Text = Arr(3)
        End If
    End Sub

    '//SupPS Gain Read Botton
    Private Sub btn_SupGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SupGain_Read.Click
        SupGain_Read()
    End Sub
    Private Sub SupGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_SupGain_R.Text = ""

        Send_RS232("~ 00 06 09")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_SupGain_R.Text = Arr(3)
        End If
    End Sub

    '//SupPS Offset Read Botton
    Private Sub btn_SupOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SupOffset_Read.Click
        SupOffset_Read()
    End Sub
    Private Sub SupOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_SupOffset_R.Text = ""

        Send_RS232("~ 00 06 0A")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_SupOffset_R.Text = Arr(3)
        End If
    End Sub

    '//ExtPS Gain Read Botton
    Private Sub btn_ExtGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtGain_Read.Click
        ExtGain_Read()
    End Sub
    Private Sub ExtGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_ExtGain_R.Text = ""

        Send_RS232("~ 00 06 0B")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_ExtGain_R.Text = Arr(3)
        End If
    End Sub

    '//ExtPS Offset Read Botton
    Private Sub btn_ExtOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtOffset_Read.Click
        ExtOffset_Read()
    End Sub
    Private Sub ExtOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_ExtOffset_R.Text = ""

        Send_RS232("~ 00 06 0C")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_ExtOffset_R.Text = Arr(3)
        End If
    End Sub

    '//HeaterPS Gain Read Botton
    Private Sub btn_HeaterGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HeaterGain_Read.Click
        HeaterGain_Read()
    End Sub
    Private Sub HeaterGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_HtrGain_R.Text = ""

        Send_RS232("~ 00 06 0D")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_HtrGain_R.Text = Arr(3)
        End If
    End Sub

    '//HeaterPS Offset Read Botton
    Private Sub btn_HeaterOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HeaterOffset_Read.Click
        HeaterOffset_Read()
    End Sub
    Private Sub HeaterOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_HtrOffset_R.Text = ""

        Send_RS232("~ 00 06 0E")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_HtrOffset_R.Text = Arr(3)
        End If
    End Sub

    '//Emission Gain Read Botton
    Private Sub btn_EmiGain_R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EmiGain_R.Click
        EmiGain_R()
    End Sub
    Private Sub EmiGain_R()
        Dim Arr As String()
        Recv_Data = ""
        txt_EmiGain_R.Text = ""

        Send_RS232("~ 00 06 2C")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_EmiGain_R.Text = Arr(3)
        End If
    End Sub

    '//Emission Offset Read Botton
    Private Sub btn_EmiOffset_R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EmiOffset_R.Click
        EmiOffset_R()
    End Sub
    Private Sub EmiOffset_R()
        Dim Arr As String()
        Recv_Data = ""
        txt_EmiOffset_R.Text = ""

        Send_RS232("~ 00 06 2D")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_EmiOffset_R.Text = Arr(3)
        End If
    End Sub

    Private Sub btn_Get_Ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Get_Ver.Click
        Get_Ver()
    End Sub
    Private Sub Get_Ver()
        Dim Arr As String()
        Recv_Data = ""
        txt_FirmVer.Text = ""

        Send_RS232("~ 00 AF")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_FirmVer.Text = Arr(3)
        End If
    End Sub


    '// Calibration VMoni
    '------------------------------------------------------------------------------------------
    '//BeamVGain Set Botton
    Private Sub btn_BeamVGain_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_BeamVGain_Set.Click
        Dim Set_Valtp As Integer = txt_BeamVGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 10 " + txt_BeamVGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Beam_VMoni.Text = Mid(Send_RS232("~ 00 78 14"), 1) + " V"

    End Sub

    '//BeamVOffset Set Botton
    Private Sub btn_BeamVOffset_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_BeamVOffset_Set.Click
        Dim Set_Valtp As Integer = txt_BeamVOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 11 " + txt_BeamVOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Beam_VMoni.Text = Mid(Send_RS232("~ 00 78 14"), 1) + " V"

    End Sub

    '//Lens1+VGain Set Botton
    Private Sub btn_Lens1pVGain_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Lens1pVGain_Set.Click
        Dim Set_Valtp As Integer = txt_L1pVGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 14 " + txt_L1pVGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Lens1p_VMoni.Text = Mid(Send_RS232("~ 00 78 10"), 1) + " V"

    End Sub
    '//Lens1+VOffset Set Botton
    Private Sub btn_Lens1pVOffset_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Lens1pVOffset_Set.Click
        Dim Set_Valtp As Integer = txt_L1pVOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 15 " + txt_L1pVOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Lens1p_VMoni.Text = Mid(Send_RS232("~ 00 78 10"), 1) + " V"

    End Sub

    '//Lens1-VGain Set Botton
    Private Sub btn_Lens1nVGain_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Lens1nVGain_Set.Click
        Dim Set_Valtp As Integer = txt_L1nVGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 16 " + txt_L1nVGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Lens1n_VMoni.Text = Mid(Send_RS232("~ 00 78 10"), 1) + " V"

    End Sub

    '//Lens1-VOffset Set Botton
    Private Sub btn_Lens1nVOffset_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Lens1nVOffset_Set.Click
        Dim Set_Valtp As Integer = txt_L1nVOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 17 " + txt_L1nVOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Lens1n_VMoni.Text = Mid(Send_RS232("~ 00 78 10"), 1) + " V"

    End Sub

    '//Lens2PS VGain Set Botton
    Private Sub btn_Lens2VGain_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Lens2VGain_Set.Click
        Dim Set_Valtp As Integer = txt_L2VGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 1C " + txt_L2VGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Lens2_VMoni.Text = Mid(Send_RS232("~ 00 78 12"), 1) + " V"

    End Sub

    '//Lens2PS VOffset Set Botton

    Private Sub btn_Lens2VOffset_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Lens2VOffset_Set.Click
        Dim Set_Valtp As Integer = txt_L2VOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 1D " + txt_L2VOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Lens2_VMoni.Text = Mid(Send_RS232("~ 00 78 12"), 1) + " V"

    End Sub

    '//SupPS VGain Set Botton

    Private Sub btn_SupVGain_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_SupVGain_Set.Click
        Dim Set_Valtp As Integer = txt_SupVGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 20 " + txt_SupVGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Suppressor_VMoni.Text = Mid(Send_RS232("~ 00 78 16"), 1) + " V"

    End Sub

    '//SupPS VOffset Set Botton


    Private Sub btn_SupVOffset_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_SupVOffset_Set.Click
        Dim Set_Valtp As Integer = txt_SupVOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 21 " + txt_SupVOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Suppressor_VMoni.Text = Mid(Send_RS232("~ 00 78 16"), 1) + " V"

    End Sub

    '//ExtPS VGain Set Botton

    Private Sub btn_ExtVGain_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ExtVGain_Set.Click
        Dim Set_Valtp As Integer = txt_ExtVGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 24 " + txt_ExtVGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Extractor_VMoni.Text = Mid(Send_RS232("~ 00 78 1E"), 1) + " V"

    End Sub

    '//ExtVOffset Set Botton
    Private Sub btn_ExtVOffset_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ExtVOffset_Set.Click
        Dim Set_Valtp As Integer = txt_ExtVOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 25 " + txt_ExtVOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Extractor_VMoni.Text = Mid(Send_RS232("~ 00 78 1E"), 1) + " V"

    End Sub

    '//HeaterPS VGain Set Botton
    Private Sub btn_HeaterVGain_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_HeaterVGain_Set.Click
        Dim Set_Valtp As Integer = txt_HtrVGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 28 " + txt_HtrVGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Hearter_VMoni.Text = Mid(Send_RS232("~ 00 78 19"), 1) + " V"

    End Sub

    '//HeaterPS VOffset Set Botton
    Private Sub btn_HeaterVOffset_Set_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_HeaterVOffset_Set.Click
        Dim Set_Valtp As Integer = txt_HtrVOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 29 " + txt_HtrVOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Hearter_VMoni.Text = Mid(Send_RS232("~ 00 78 19"), 1) + " V"

    End Sub

    '------------------------------------------------------------------------------------------
    '//BeamPS VGain Read Botton
    Private Sub btn_BeamVGain_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_BeamVGain_Read.Click
        BeamVGain_Read()
    End Sub
    Private Sub BeamVGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_BeamVGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 10")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_BeamVGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//BeamPS VOffset Read Botton
    Private Sub btn_BeamVOffset_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_BeamVOffset_Read.Click
        BeamVOffset_Read()
    End Sub
    Private Sub BeamVOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_BeamVOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 11")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_BeamVOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//L1PS plus-side VGain Read Botton
    Private Sub btn_Lens1pVGain_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Lens1pVGain_Read.Click
        Lens1pVGain_Read()
    End Sub
    Private Sub Lens1pVGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L1pVGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 14")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L1pVGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//L1PS plus-side VOffset Read Botton
    Private Sub btn_Lens1pVOffset_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Lens1pVOffset_Read.Click
        Lens1pVOffset_Read()
    End Sub
    Private Sub Lens1pVOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L1pVOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 15")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L1pVOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//L1PS minus-side VGain Read Botton
    Private Sub btn_Lens1nVGain_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Lens1nVGain_Read.Click
        Lens1nVGain_Read()
    End Sub
    Private Sub Lens1nVGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L1nVGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 16")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L1nVGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//L1PS minus-side VOffset Read Botton
    Private Sub btn_Lens1nVOffset_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Lens1nVOffset_Read.Click
        Lens1nVOffset_Read()
    End Sub
    Private Sub Lens1nVOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L1nVOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 17")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L1nVOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//L2PS VGain Read Botton
    Private Sub btn_Lens2VGain_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Lens2VGain_Read.Click
        Lens2VGain_Read()
    End Sub
    Private Sub Lens2VGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L2VGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 1C")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L2VGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//L2PS VOffset Read Botton
    Private Sub btn_Lens2VOffset_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Lens2VOffset_Read.Click
        Lens2VOffset_Read()
    End Sub
    Private Sub Lens2VOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L2VOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 1D")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L2VOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//SupPS VGain Read Botton
    Private Sub btn_SupVGain_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_SupVGain_Read.Click
        SupVGain_Read()
    End Sub
    Private Sub SupVGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_SupVGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 20")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_SupVGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//SupPS VOffset Read Botton
    Private Sub btn_SupVOffset_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_SupVOffset_Read.Click
        SupVOffset_Read()
    End Sub
    Private Sub SupVOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_SupVOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 21")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_SupVOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//ExtPS VGain Read Botton
    Private Sub btn_ExtVGain_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ExtVGain_Read.Click
        ExtVGain_Read()
    End Sub
    Private Sub ExtVGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_ExtVGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 24")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_ExtVGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//ExtPS VOffset Read Botton
    Private Sub btn_ExtVOffset_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ExtVOffset_Read.Click
        ExtVOffset_Read()
    End Sub
    Private Sub ExtVOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_ExtVOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 25")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_ExtVOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//HeaterPS VGain Read Botton
    Private Sub btn_HeaterVGain_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_HeaterVGain_Read.Click
        HeaterVGain_Read()
    End Sub
    Private Sub HeaterVGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_HtrVGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 28")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_HtrVGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//HeaterPS VOffset Read Botton
    Private Sub btn_HeaterVOffset_Read_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_HeaterVOffset_Read.Click
        HeaterVOffset_Read()
    End Sub
    Private Sub HeaterVOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_HtrVOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 29")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_HtrVOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '// Calibration IMoni


    '//BeamIGain Set Botton
    Private Sub btn_BeamIGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BeamIGain_Set.Click

        Dim Set_Valtp As Integer = txt_BeamIGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 12 " + txt_BeamIGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Beam_IMoni.Text = Mid(Send_RS232("~ 00 78 15"), 1) + " uA"

    End Sub


    '//BeamIOffset Set Botton
    Private Sub btn_BeamIOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BeamIOffset_Set.Click

        Dim Set_Valtp As Integer = txt_BeamIOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 13 " + txt_BeamIOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Beam_IMoni.Text = Mid(Send_RS232("~ 00 78 15"), 1) + " uA"

    End Sub

    '//Lens1+IGain Set Botton
    Private Sub btn_Lens1pIGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1pIGain_Set.Click

        Dim Set_Valtp As Integer = txt_L1pIGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 18 " + txt_L1pIGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Lens1p_IMoni.Text = Mid(Send_RS232("~ 00 78 11"), 1) + " uA"

    End Sub

    '//Lens1pIOffset Set Botton
    Private Sub btn_Lens1pIOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1pIOffset_Set.Click

        Dim Set_Valtp As Integer = txt_L1pIOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        'Send_RS232("~ 00 05 13 " + txt_L1pIOffset_ADC.Text) ' 間違え
        Send_RS232("~ 00 05 19 " + txt_L1pIOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Lens1p_IMoni.Text = Mid(Send_RS232("~ 00 78 11"), 1) + " uA"

    End Sub

    '//Lens1-IGain Set Botton
    Private Sub btn_Lens1nIGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1nIGain_Set.Click

        Dim Set_Valtp As Integer = txt_L1nIGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 1A " + txt_L1nIGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Lens1n_IMoni.Text = Mid(Send_RS232("~ 00 78 11"), 1) + " uA"

    End Sub

    '//Lens1-IOffset Set Botton
    Private Sub btn_Lens1nIOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1nIOffset_Set.Click

        Dim Set_Valtp As Integer = txt_L1nIOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 1B " + txt_L1nIOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Lens1n_IMoni.Text = Mid(Send_RS232("~ 00 78 11"), 1) + " uA"

    End Sub

    '//Lens2PS IGain Set Botton
    Private Sub btn_Lens2IGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens2IGain_Set.Click
        Dim Set_Valtp As Integer = txt_L2IGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 1E " + txt_L2IGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Lens2_IMoni.Text = Mid(Send_RS232("~ 00 78 13"), 1) + " uA"

    End Sub

    '//Lens2PS IOffset Set Botton
    Private Sub btn_Lens2IOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens2IOffset_Set.Click
        Dim Set_Valtp As Integer = txt_L2IOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 1F " + txt_L2IOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Lens2_IMoni.Text = Mid(Send_RS232("~ 00 78 13"), 1) + " uA"

    End Sub
    '//SupPS IGain Set Botton
    Private Sub btn_SupIGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SupIGain_Set.Click
        Dim Set_Valtp As Integer = txt_SupIGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 22 " + txt_SupIGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Suppressor_IMoni.Text = Mid(Send_RS232("~ 00 78 17"), 1) + " uA"

    End Sub

    '//SupPS IOffset Set Botton
    Private Sub btn_SupIOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SupIOffset_Set.Click
        Dim Set_Valtp As Integer = txt_SupIOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 23 " + txt_SupIOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Suppressor_IMoni.Text = Mid(Send_RS232("~ 00 78 17"), 1) + " uA"

    End Sub

    '//ExtPS IGain Set Botton
    Private Sub btn_ExtIGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtIGain_Set.Click
        Dim Set_Valtp As Integer = txt_ExtIGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 26 " + txt_ExtIGain_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Extractor_IMoni.Text = Mid(Send_RS232("~ 00 78 1F"), 1) + " uA"

    End Sub

    '//ExtIOffset Set Botton
    Private Sub btn_ExtIOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtIOffset_Set.Click
        Dim Set_Valtp As Integer = txt_ExtIOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 27 " + txt_ExtIOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Extractor_IMoni.Text = Mid(Send_RS232("~ 00 78 1F"), 1) + " uA"

    End Sub

    '//HeaterPS IGain Set Botton
    Private Sub btn_HeaterIGain_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HeaterIGain_Set.Click
        Dim Set_Valtp As Integer = txt_HtrIGain_ADC.Text
        If ((Set_Valtp > MaxVal_Gain) Or (Set_Valtp < MinVal_Gain)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 2A " + txt_HtrIGain_ADC.Text)

        System.Threading.Thread.Sleep(1000)
        Hearter_IMoni.Text = Mid(Send_RS232("~ 00 78 18"), 1) + " A"

    End Sub
    '//HeaterPS IOffset Set Botton
    Private Sub btn_HeaterIOffset_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HeaterIOffset_Set.Click
        Dim Set_Valtp As Integer = txt_HtrIOffset_ADC.Text
        If ((Set_Valtp > MaxVal_Offset) Or (Set_Valtp < MinVal_Offset)) Then
            MsgBox("値が設定範囲ではありません！！")
            Exit Sub
        End If

        Send_RS232("~ 00 05 2B " + txt_HtrIOffset_ADC.Text)
        System.Threading.Thread.Sleep(1000)
        Hearter_IMoni.Text = Mid(Send_RS232("~ 00 78 18"), 1) + " A"

    End Sub


    '----------------------------------------------------------------------------------------------------
    '//BeamPS IGain Read Botton
    Private Sub btn_BeamIGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BeamIGain_Read.Click
        BeamIGain_Read()
    End Sub
    Private Sub BeamIGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_BeamIGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 12")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_BeamIGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//BeamPS IOffset Read Botton
    Private Sub btn_BeamIOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BeamIOffset_Read.Click
        BeamIOffset_Read()
    End Sub
    Private Sub BeamIOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_BeamIOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 13")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_BeamIOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//L1PS plus-side IGain Read Botton
    Private Sub btn_Lens1pIGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1pIGain_Read.Click
        Lens1pIGain_Read()
    End Sub
    Private Sub Lens1pIGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L1pIGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 18")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L1pIGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//L1PS plus-side IOffset Read Botton
    Private Sub btn_Lens1pIOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1pIOffset_Read.Click
        Lens1pIOffset_Read()
    End Sub
    Private Sub Lens1pIOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L1pIOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 19")    ' 0が返ってくる

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L1pIOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//L1PS minus-side IGain Read Botton
    Private Sub btn_Lens1nIGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1nIGain_Read.Click
        Lens1nIGain_Read()
    End Sub
    Private Sub Lens1nIGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L1nIGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 1A")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L1nIGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//L1PS minus-side IOffset Read Botton
    Private Sub btn_Lens1nIOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens1nIOffset_Read.Click
        Lens1nIOffset_Read()
    End Sub
    Private Sub Lens1nIOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L1nIOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 1B")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L1nIOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//L2PS IGain Read Botton
    Private Sub btn_Lens2IGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens2IGain_Read.Click
        Lens2IGain_Read()
    End Sub
    Private Sub Lens2IGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L2IGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 1E")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L2IGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//L2PS Offset IRead Botton
    Private Sub btn_Lens2IOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lens2IOffset_Read.Click
        Lens2IOffset_Read()
    End Sub
    Private Sub Lens2IOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_L2IOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 1F")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_L2IOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//SupPS IGain Read Botton
    Private Sub btn_SupIGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SupIGain_Read.Click
        SupIGain_Read()
    End Sub
    Private Sub SupIGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_SupIGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 22")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_SupIGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//SupPS IOffset Read Botton
    Private Sub btn_SupIOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SupIOffset_Read.Click
        SupIOffset_Read()
    End Sub
    Private Sub SupIOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_SupIOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 23")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_SupIOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//ExtPS IGain Read Botton
    Private Sub btn_ExtIGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtIGain_Read.Click
        ExtIGain_Read()
    End Sub
    Private Sub ExtIGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_ExtIGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 26")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_ExtIGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//ExtPS IOffset Read Botton
    Private Sub btn_ExtIOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtIOffset_Read.Click
        ExtIOffset_Read()
    End Sub
    Private Sub ExtIOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_ExtIOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 27")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_ExtIOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//HeaterPS IGain Read Botton
    Private Sub btn_HeaterIGain_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HeaterIGain_Read.Click
        HeaterIGain_Read()
    End Sub
    Private Sub HeaterIGain_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_HtrIGain_ADC_R.Text = ""

        Send_RS232("~ 00 06 2A")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_HtrIGain_ADC_R.Text = Arr(3)
        End If
    End Sub

    '//HeaterPS IOffset Read Botton
    Private Sub btn_HeaterIOffset_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HeaterIOffset_Read.Click
        HeaterIOffset_Read()
    End Sub
    Private Sub HeaterIOffset_Read()
        Dim Arr As String()
        Recv_Data = ""
        txt_HtrIOffset_ADC_R.Text = ""

        Send_RS232("~ 00 06 2B")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_HtrIOffset_ADC_R.Text = Arr(3)
        End If
    End Sub

    Private Sub btn_ParamReadAll_Click(sender As Object, e As EventArgs) Handles btn_ParamReadAll.Click
        GetCalValues()
        CpuBoardParamCHECK()
    End Sub


    '----------------------------------------------------------------------------
    Private Sub Btn_EMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EMS.Click
        Dim setting As Boolean = cbReadBack.Checked

        cbReadBack.Checked = False  ' 一旦、ReadBackを止める

        Me.Setallzero()

        BTagingRun.Text = "RUN"     ' エージング途中停止
        SaveSetting("20_750", "Operation_Value", "Aging_status", "STOP")  'レジストを RUNからSTOPに
        CalCancel = True            ' キャリブレーション途中停止
        UsageCancel = True


        nuBeamEnergy.Value = 0
        nuSuppressor.Value = 0
        nuExtractor.Value = 0
        nuFilamentHeater.Value = 0
        nuLens1.Value = 0
        nuLens2.Value = 0
        nuEmissionControl.Value = 0

        cbReadBack.Checked = setting    ' ReadBack状態書き戻し


        MsgBox("EMS DONE!!!!")
        Me.ALL_Read()

    End Sub

    Private Sub ALL_Read()
        'bReadBack.Enabled = False

        If CheckBox0.Checked Then 'Beam Energy V and I
            TextBox0.Text = Mid(Send_RS232(cBeamVread), 1) '+ " V"
            TextBox1.Text = Mid(Send_RS232(cBeamIread), 1) '+ " uA"
        End If
        Application.DoEvents()

        If CheckBox1.Checked Then 'Suppresor V and I
            TextBox2.Text = Mid(Send_RS232(cSupVread), 1) '+ " V"
            TextBox3.Text = Mid(Send_RS232(cSupIread), 1) '+ " uA"
        End If
        Application.DoEvents()

        If CheckBox2.Checked Then 'Extractor V and I
            TextBox4.Text = Mid(Send_RS232(cExtrVread), 1) '+ " V"
            TextBox5.Text = Mid(Send_RS232(cExtrIread), 1) '+ " uA"
        End If
        Application.DoEvents()

        If CheckBox3.Checked Then 'Heater I and V
            TextBox6.Text = Mid(Send_RS232(cHeaterIread), 1) '+ " A"
            TextBox7.Text = Mid(Send_RS232(cHeaterVread), 1) '+ " V"
        End If
        Application.DoEvents()

        If CheckBox4.Checked Then 'Lens1 V and I
            TextBox8.Text = Mid(Send_RS232(cLens1Vread), 1) '+ " V"
            TextBox9.Text = Mid(Send_RS232(cLens1Iread), 1) '+ " uA"
        End If
        Application.DoEvents()

        If CheckBox5.Checked Then 'Lens2 V and I
            TextBox10.Text = Mid(Send_RS232(cLens2Vread), 1) '+ " V"
            TextBox11.Text = Mid(Send_RS232(cLens2Iread), 1) '+ " uA"
        End If
        Application.DoEvents()

        If CheckBox6.Checked Then 'Emission Current I
            TextBox12.Text = Mid(Send_RS232(cEmiIread), 1) '+ " mA"
        End If
        Application.DoEvents()

        'bReadBack.Enabled = True
    End Sub

    Private Sub btn_DG406_Set_Click(sender As Object, e As EventArgs) Handles btn_DG406_Set.Click

        Send_RS232("~ 00 09 " + txt_DG406.Text)

    End Sub

    Private Sub btn_DG406_Read_Click(sender As Object, e As EventArgs) Handles btn_DG406_Read.Click

        Dim Arr As String()
        Recv_Data = ""
        txt_DG406_R.Text = ""

        Send_RS232("~ 00 0A")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_DG406_R.Text = Arr(3)
        End If
    End Sub

    Private Sub DG406_Sel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DG406_Sel.SelectedIndexChanged

        If DG406_Sel.Text = "00 L1_Lev" Then
            txt_DG406.Text = "00"
        ElseIf DG406_Sel.Text = "01 L2_Lev" Then
            txt_DG406.Text = "01"
        ElseIf DG406_Sel.Text = "02 BEAM_Lev" Then
            txt_DG406.Text = "02"
        ElseIf DG406_Sel.Text = "03 BEAM_V" Then
            txt_DG406.Text = "03"
        ElseIf DG406_Sel.Text = "04 BEAM_I" Then
            txt_DG406.Text = "04"
        ElseIf DG406_Sel.Text = "05 L1_V" Then
            txt_DG406.Text = "05"
        ElseIf DG406_Sel.Text = "06 L1_I" Then
            txt_DG406.Text = "06"
        ElseIf DG406_Sel.Text = "07 L2_V" Then
            txt_DG406.Text = "07"
        ElseIf DG406_Sel.Text = "08 L2_I" Then
            txt_DG406.Text = "08"
        ElseIf DG406_Sel.Text = "09 BUS_V" Then
            txt_DG406.Text = "09"
        ElseIf DG406_Sel.Text = "0A BEAM_24V" Then
            txt_DG406.Text = "0A"
        ElseIf DG406_Sel.Text = "0B L2_24V" Then
            txt_DG406.Text = "0B"
        ElseIf DG406_Sel.Text = "0C L1_24V" Then
            txt_DG406.Text = "0C"
        ElseIf DG406_Sel.Text = "0D 10V_REF" Then
            txt_DG406.Text = "0D"
        ElseIf DG406_Sel.Text = "0E GND_REF" Then
            txt_DG406.Text = "0E"
        ElseIf DG406_Sel.Text = "FF NORMAL" Then
            txt_DG406.Text = "FF"
        End If
    End Sub

    Private Sub txt_DG406_R_TextChanged(sender As Object, e As EventArgs) Handles txt_DG406_R.TextChanged

        If txt_DG406_R.Text = "00" Then
            txt_DG406_R2.Text = "L1_Lev"
        ElseIf txt_DG406_R.Text = "01" Then
            txt_DG406_R2.Text = "L2_Lev"
        ElseIf txt_DG406_R.Text = "02" Then
            txt_DG406_R2.Text = "BEAM_Lev"
        ElseIf txt_DG406_R.Text = "03" Then
            txt_DG406_R2.Text = "BEAM_V"
        ElseIf txt_DG406_R.Text = "04" Then
            txt_DG406_R2.Text = "BEAM_I"
        ElseIf txt_DG406_R.Text = "05" Then
            txt_DG406_R2.Text = "L1_V"
        ElseIf txt_DG406_R.Text = "06" Then
            txt_DG406_R2.Text = "L1_I"
        ElseIf txt_DG406_R.Text = "07" Then
            txt_DG406_R2.Text = "L2_V"
        ElseIf txt_DG406_R.Text = "08" Then
            txt_DG406_R2.Text = "L2_I"
        ElseIf txt_DG406_R.Text = "09" Then
            txt_DG406_R2.Text = "BUS_V"
        ElseIf txt_DG406_R.Text = "0A" Then
            txt_DG406_R2.Text = "BEAM_24V"
        ElseIf txt_DG406_R.Text = "0B" Then
            txt_DG406_R2.Text = "L2_24V"
        ElseIf txt_DG406_R.Text = "0C" Then
            txt_DG406_R2.Text = "L1_24V"
        ElseIf txt_DG406_R.Text = "0D" Then
            txt_DG406_R2.Text = "10V_REF"
        ElseIf txt_DG406_R.Text = "0E" Then
            txt_DG406_R2.Text = "GND_REF"
        ElseIf txt_DG406_R.Text = "FF" Then
            txt_DG406_R2.Text = "NORMAL"
        End If
    End Sub

    Private Sub btn_DG406_Speed_Click(sender As Object, e As EventArgs) Handles btn_DG406_Speed.Click

        Send_RS232("~ 00 0B " + txt_DG406_Speed.Text)

    End Sub

    Private Sub btn_DG406_Speed_Read_Click(sender As Object, e As EventArgs) Handles btn_DG406_Speed_Read.Click
        Dim Arr As String()
        Recv_Data = ""
        txt_DG406_SPEED_R.Text = ""

        Send_RS232("~ 00 0C")

        Arr = Split(Recv_Data, )
        If Arr.Length > 2 Then
            txt_DG406_SPEED_R.Text = Arr(3)
        End If
    End Sub

    Private Sub DG406_Speed_Sel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DG406_Speed_Sel.SelectedIndexChanged
        If DG406_Speed_Sel.Text = "00 HSpeed_LReso" Then
            txt_DG406_Speed.Text = "00"
        ElseIf DG406_Speed_Sel.Text = "01" Then
            txt_DG406_Speed.Text = "01"
        ElseIf DG406_Speed_Sel.Text = "02" Then
            txt_DG406_Speed.Text = "02"
        ElseIf DG406_Speed_Sel.Text = "03" Then
            txt_DG406_Speed.Text = "03"
        ElseIf DG406_Speed_Sel.Text = "04" Then
            txt_DG406_Speed.Text = "04"
        ElseIf DG406_Speed_Sel.Text = "05" Then
            txt_DG406_Speed.Text = "05"
        ElseIf DG406_Speed_Sel.Text = "06" Then
            txt_DG406_Speed.Text = "06"
        ElseIf DG406_Speed_Sel.Text = "07" Then
            txt_DG406_Speed.Text = "07"
        ElseIf DG406_Speed_Sel.Text = "08" Then
            txt_DG406_Speed.Text = "08"
        ElseIf DG406_Speed_Sel.Text = "09" Then
            txt_DG406_Speed.Text = "09"
        ElseIf DG406_Speed_Sel.Text = "0A LSpeed_HReso" Then
            txt_DG406_Speed.Text = "0A"
        End If
    End Sub

    Private Sub txt_DG406_SPEED_R_TextChanged(sender As Object, e As EventArgs) Handles txt_DG406_SPEED_R.TextChanged

        If txt_DG406_SPEED_R.Text = "00" Then
            txt_DG406_SPEED_R2.Text = "HSpeed_LReso"
        ElseIf txt_DG406_SPEED_R.Text = "01" Then
            txt_DG406_SPEED_R2.Text = "01"
        ElseIf txt_DG406_SPEED_R.Text = "02" Then
            txt_DG406_SPEED_R2.Text = "02"
        ElseIf txt_DG406_SPEED_R.Text = "03" Then
            txt_DG406_SPEED_R2.Text = "03"
        ElseIf txt_DG406_SPEED_R.Text = "04" Then
            txt_DG406_SPEED_R2.Text = "04"
        ElseIf txt_DG406_SPEED_R.Text = "05" Then
            txt_DG406_SPEED_R2.Text = "05"
        ElseIf txt_DG406_SPEED_R.Text = "06" Then
            txt_DG406_SPEED_R2.Text = "06"
        ElseIf txt_DG406_SPEED_R.Text = "07" Then
            txt_DG406_SPEED_R2.Text = "07"
        ElseIf txt_DG406_SPEED_R.Text = "08" Then
            txt_DG406_SPEED_R.Text = "08"
        ElseIf txt_DG406_SPEED_R.Text = "09" Then
            txt_DG406_SPEED_R.Text = "09"
        ElseIf txt_DG406_SPEED_R.Text = "0A" Then
            txt_DG406_SPEED_R.Text = "LSpeed_HReso"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ofd As New OpenFileDialog()
        ofd.FileName = "logFile.txt"
        ofd.Title = "LOGファイルを選択してください"
        ofd.RestoreDirectory = True
        ofd.CheckFileExists = True
        ofd.CheckPathExists = True
        If ofd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            'Console.WriteLine(ofd.FileName)
            SelectedLogFile = ofd.FileName
            TextBoxLogFile.Text = SelectedLogFile
        End If
    End Sub

    Private Sub addMessage(str As String)
        '****************************************
        ' メッセージを残すサブルーチン
        '****************************************
        txtMessage.Text = txtMessage.Text & str & vbCrLf
        txtMessage.SelectionStart = txtMessage.TextLength  ' TextBoxオブジェクトの最後の行を表示
        txtMessage.ScrollToCaret()
    End Sub

    Private Sub waitaddMessage(wait_a As Integer)
        '****************************************
        ' ...を表示しながらwaitするサブルーチン 引数の単位 sec
        '****************************************
        Dim wait500 As Integer
        For wait500 = 1 To (wait_a * 3)
            txtMessage.Text = txtMessage.Text & "."
            txtMessage.SelectionStart = txtMessage.TextLength  ' TextBoxオブジェクトの最後の行を表示
            txtMessage.ScrollToCaret()
            ReadDmm(1000)
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)      ' ReadDmmで200msくらい喰うので1周500msにするにはこのくらい。
            'Dim task1 As Task = Task.Run(
            '    Sub()
            '        System.Threading.Thread.Sleep(300)      ' ReadDmmで200msくらい喰うので1周500msにするにはこのくらい。
            '    End Sub
            ')
            'task1.Wait()
        Next
    End Sub

    Private Sub BtnVisaOpen_Click(sender As Object, e As EventArgs) Handles BtnVisaOpen.Click
        '==============================================
        ' VISA OPEN  DMM 34461A とりあえず決め打ちで  出来ればPC接続機器をサーチするようにする
        '==============================================

        If TextBoxVisaAdr.Text Is "" Then
            addMessage("VISA Address をサーチしてください。")
            Exit Sub
        End If

        Dim VISAAddress = TextBoxVisaAdr.Text
        Try
            RM = New Ivi.Visa.Interop.ResourceManager
            DMM = New Ivi.Visa.Interop.FormattedIO488
            DMM.IO = RM.Open(VISAAddress)  ' 測定機をオープン
            ' Dev.IO.Timeout = 10000  ' VISA タイムアウト 10秒に設定
            ' Dev.IO.TerminationCharacterEnabled = True  ' TCPソケットで接続する場合
        Catch ex As Exception

            addMessage("VISA COM オブジェクト作成失敗。 " & ex.Message)

            Exit Sub

        End Try

        '接続OK
        addMessage("VISA COM OPEN " & VISAAddress & " 成功")
        BtnVisaClose.Enabled = True
        BtnVisaOpen.Enabled = False

        visa_btn_enable()

        ' Probe校正データ読み出し
        xml_HVProofread()


        Dim strResp As String = "" ' DMMからの応答を受け取る変数
        DMM.WriteString("*RST;*CLS")  ' リセット、クリアステイタス

        'DMM.WriteString("CONF:VOLT:DC 20,0.0001")  ' 電圧測定 autoレンジ -> 10Vレンジ 0.0001V分解能
        DMM.WriteString("CONF:VOLT:DC AUTO")  ' 電圧測定 autoレンジ
        DMM.WriteString("SYST:ERR?")  ' エラー有無の確認
        strResp = DMM.ReadString()

        If Integer.Parse(strResp.Substring(0, strResp.IndexOf(","))) <> 0 Then  ' エラーが発生したら
            addMessage("DMM初期化エラー : " & strResp)
            ' リソースのクローズ
            DMM.IO.Close()
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(DMM)
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(RM)

            BtnVisaOpen.Enabled = True
            BtnVisaClose.Enabled = False

            visa_btn_disable()

            Exit Sub  ' 接続ボタンの処理を抜ける。

        End If

        addMessage("DMM受信 " & strResp)
        DMM.WriteString("*IDN?")  ' ID 確認
        strResp = DMM.ReadString()
        addMessage("ID=" & strResp)
        DmmOpen = True
        DMM.WriteString("DISP:VIEW MET")  '

    End Sub

    Private Sub BtnVisaClose_Click(sender As Object, e As EventArgs) Handles BtnVisaClose.Click
        BtnVisaOpen.Enabled = True
        BtnVisaClose.Enabled = False

        visa_btn_disable()

        DMM.WriteString("DISP:VIEW NUM")    'D_TEST

        ' リソースのクローズ
        'DMM.WriteString("*GTL") ' Errorでる　REMOTEからLOCALに戻したいけど、どうやるの？
        DMM.WriteString("SYSTem:LOCal")     'D_TEST

        DMM.IO.Close()
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(DMM)
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(RM)
        addMessage("VISA COM CLOSE")
        DmmOpen = False
        Proofread = False

    End Sub


    Private Sub BtnVisaSearch_Click(sender As Object, e As EventArgs) Handles BtnVisaSearch.Click
        Dim adrsList() As String

        RM = New Ivi.Visa.Interop.ResourceManager
        DMM = New Ivi.Visa.Interop.FormattedIO488

        Try
            'adrsList = RM.FindRsrc("USB?*::0x2A8D::0x1401?*::INSTR")
            'adrsList = RM.FindRsrc("USB?::0x2A8D::0x1401?*::?::INSTR")
            adrsList = RM.FindRsrc("USB?*::?::INSTR")
        Catch ex As Exception
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(RM)
            Exit Sub
        End Try

        Dim ListNum As Integer
        Dim i As Integer
        Dim ans1 As Short = 0
        Dim ans2 As String = "Integer"
        ListNum = adrsList.Length

        TextBoxVisaAdr.Text = ""

        If ListNum Then
            For i = 0 To (ListNum - 1)
                Try
                    DMM.IO = RM.Open(adrsList(i))
                Catch ex As Exception
                    GoTo NextLoop
                End Try
                addMessage("Found " & adrsList(i))
                TextBoxVisaAdr.Text = adrsList(i)
NextLoop:
            Next i

        End If
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(RM)
    End Sub


    'Button4はない？。。Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    'BtnVisaOpen_Click()から呼ばれる  D_TEST
    Private Sub xml_HVProofread()

        ' xmlファイル デシリアライズ
        Dim xmlSerializer = New XmlSerializer(GetType(HVProbe))
        Dim result As HVProbe
        Dim xmlSettings = New System.Xml.XmlReaderSettings() _
            With {
                .CheckCharacters = False ' 不正な文字をチェックしない
            }

        Try
            '読み込むファイルを開く    D_TEST
            Using streamReader = New StreamReader(xmlHVprobe, Encoding.UTF8)
                Using xmlReader = System.Xml.XmlReader.Create(streamReader, xmlSettings)
                    'Try
                    result = CType(xmlSerializer.Deserialize(xmlReader), HVProbe) ' （3）
                End Using
            End Using
        Catch ex As Exception
            addMessage("HVProbe校正データ読み出し[\HVProbe.xml] ====== 失敗 =====")
            Exit Sub
        End Try
        addMessage("HVProbe校正データ読み出し[\HVProbe.xml] ====== 成功 =====")

        Proofread = True

        TextBoxHV10k.Text = Format(result.HV10kV, "#,#.00")
        TextBoxHV20k.Text = Format(result.HV20kV, "#,#.00")
        TextBoxHV30k.Text = Format(result.HV30kV, "#,#.00")
        TextBoxHV40k.Text = Format(result.HV40kV, "#,#.00")

    End Sub


    Private Function dmm_stable(ScanCount As Integer, ScanWait As Integer, diffVolt As Double, ByRef dmmdata As Double)
        '****************************************
        ' DMMの値が安定しているか確かめるサブルーチン
        ' ScanCount 取得データー数
        ' ScanWait  1回目と2回目の間隔 msec
        ' diffVolt  GO/NG判定電圧
        ' dmmdata   平均したデータ（2回目のみ）を返す 生データ
        ' return値  GO/NG判定
        '****************************************
        Dim GoNg As Boolean = False

        Dim strResp As String  ' データロガーからの応答を受け取る変数
        Dim strScanCount As String = Integer.Parse(ScanCount)

        If DEBUG_ENABLE = True Then     'D_TEST
            Return GoNg 'D_TEST
        End If

        DMM.WriteString("TRIG:COUN " & strScanCount)  ' スキャンは10回    D_TEST 8回だと思われる。。。。。
        'DMM.WriteString("READ?")  ' READ
        DMM.WriteString("SYST:ERR?")  ' エラー有無の確認

        strResp = DMM.ReadString()
        'D_TEST　No Errorの時は "+0, No Error" が返る  strResp.Contains("No error") でも良い。
        If Integer.Parse(strResp.Substring(0, strResp.IndexOf(","))) <> 0 Then  ' エラーが発生したら
            addMessage("スキャン設定エラー : " & strResp)
            Return GoNg ' 繰り返しスキャンの処理を抜ける。
        End If

        ' 繰り返しスキャンの開始と測定値の取得
        DMM.WriteString("INIT")                     'D_TEST INITでTRIG待機状態となる
        'addMessage("スキャン開始1回目")

        ' ループで使用する変数宣言
        Dim intDataPoint As Integer
        Dim intActualScan As Integer

        'intScanCount = Integer.Parse(ScanCount) ' スキャン回数の取得
        intActualScan = 0 ' 実際にスキャンした回数

        ' Do
        '       (1)測定値読み取り
        '       (2)中断ボタンが押されていればループを抜ける
        '       (3)指定回数が終了すればループを抜ける
        ' Loop
        Do
            ' (1)測定値読み取り
            ' このプログラムでは 4ch のスキャンを実施している。
            Do ' 
                DMM.WriteString("DATA:POIN?")  ' データ数の問い合わせ
                intDataPoint = Integer.Parse(DMM.ReadString)
                If (intDataPoint >= ScanCount) Then
                    ' 4個以上のデータがある場合 →　D_TEST 8個じゃないの？　ScanCountは8だよ
                    DMM.WriteString("DATA:REMOVE? " & strScanCount)  ' n個の測定値の取得
                    strResp = DMM.ReadString()
                    'addMessage("スキャン1回目 " & strResp)
                    intActualScan = 1
                Else ' データが4個未満の場合、(1)測定値読み取りを抜ける
                    Exit Do
                End If

            Loop
            System.Threading.Thread.Sleep(50)
            Application.DoEvents()

            ' (2) 指定回数終了確認
            '　　指定されたスキャン回数が完了した場合、ループを抜ける
            If intActualScan = 1 Then 'スキャン回数が終了していればループを抜ける。
                Exit Do
            End If
        Loop
        ' 1回目終了

        Dim strScanData() As String
        strScanData = strResp.Split(",")
        Dim dblScanData1 As Double = 0
        For i = 0 To (ScanCount - 1)
            dblScanData1 += Double.Parse(strScanData(i))
        Next
        dblScanData1 /= ScanCount
        addMessage("平均1回目 " & dblScanData1.ToString)
        System.Threading.Thread.Sleep(50)
        Application.DoEvents()


        'addMessage("Wait " & ScanWait.ToString & "ms")
        System.Threading.Thread.Sleep(ScanWait)


        DMM.WriteString("TRIG:COUN " & strScanCount)  ' スキャンは10回    D_TEST 8回だと思われる。。。。。
        'DMM.WriteString("READ?")  ' READ
        DMM.WriteString("SYST:ERR?")  ' エラー有無の確認

        strResp = DMM.ReadString()
        If Integer.Parse(strResp.Substring(0, strResp.IndexOf(","))) <> 0 Then  ' エラーが発生したら
            addMessage("スキャン設定エラー : " & strResp)
            Return GoNg ' 繰り返しスキャンの処理を抜ける。
        End If

        ' 繰り返しスキャンの開始と測定値の取得
        DMM.WriteString("INIT")                     'D_TEST INITでTRIG待機状態となる
        'addMessage("スキャン開始2回目")

        Do
            ' (1)測定値読み取り
            ' このプログラムでは 4ch のスキャンを実施している。
            Do ' 
                DMM.WriteString("DATA:POIN?")  ' データ数の問い合わせ
                intDataPoint = Integer.Parse(DMM.ReadString)
                If (intDataPoint >= ScanCount) Then
                    ' 4個以上のデータがある場合
                    DMM.WriteString("DATA:REMOVE? " & strScanCount)  ' n個の測定値の取得
                    strResp = DMM.ReadString()
                    'addMessage("スキャン2回目 " & strResp)
                    intActualScan = 2
                Else ' データが4個未満の場合、(1)測定値読み取りを抜ける
                    Exit Do
                End If
            Loop
            System.Threading.Thread.Sleep(50)
            Application.DoEvents()

            ' (2) 指定回数終了確認
            '　　指定されたスキャン回数が完了した場合、ループを抜ける
            If intActualScan = 2 Then 'スキャン回数が終了していればループを抜ける。
                Exit Do
            End If
        Loop

        strScanData = strResp.Split(",")
        Dim dblScanData2 As Double = 0
        For i = 0 To (ScanCount - 1)
            dblScanData2 += Double.Parse(strScanData(i))
        Next

        dblScanData2 /= ScanCount
        addMessage("平均2回目 " & dblScanData2.ToString)

        dmmdata = dblScanData2

        '差分を計算
        Dim Diff As Double
        If dblScanData2 > dblScanData1 Then
            Diff = dblScanData2 - dblScanData1
        Else
            Diff = dblScanData1 - dblScanData2
        End If



        '差分が条件を満たしているか？
        If Diff < diffVolt Then
            GoNg = True
        End If

        'デバッグ情報 1000倍して表示するけど、全てが1000倍ではないので注意
        'Diff = Diff * 1000

        addMessage("変動電圧 " & Diff.ToString & " V")

        ' DMM設定を戻しておかないとその後ボタンを押すとエラーがでる。
        DMM.WriteString("CONF:VOLT:DC AUTO")  ' 電圧測定 autoレンジ
        DMM.WriteString("SYST:ERR?")  ' エラー有無の確認
        strResp = DMM.ReadString()

        Return GoNg
    End Function


    Private Sub BtnExtrCAL_Click(sender As Object, e As EventArgs) Handles BtnExtrCAL.Click
        '**************************************
        ' Extractor電圧のキャリブレーション
        ' 実行時間が長いので途中で止める手段が欲しい
        '**************************************

        Dim CalName As String = "Extractor"     ' 繰り返し回数制限

        Dim limit_count As Integer = 10         ' 繰り返し回数制限
        Dim dmmdata As Double = 0               ' DMMデータ取り込み用
        Dim offset_K As Double = -31.33         ' Extractorはoffset 1 で31.33V変化する
        Dim offset_S As Double = 15             ' offset OK閾値

        Dim testVolt As Double = -10000         ' テスト電圧 -10kV
        Dim gain_K As Double = -0.85            ' gain係数 10kV時
        Dim gain_S As Double = 0.5              ' gain OK閾値 V
        Dim gain As Double = 10000              ' gain 10000が中心

        Dim MonitV_Offset As Double = 0         ' モニター電圧OFFSET 
        Dim MonitV_Gain As Double = 10000       ' モニター電圧GAIN
        Dim MonitV_Offset_K As Double = 3.2     ' モニター電圧OFFSET係数
        Dim MonitV_Offset_S As Double = 0.25    ' モニター電圧OFFSET OK閾値 V
        Dim MonitV_Gain_K As Double = 0.8       ' モニター電圧GAIN係数
        Dim MonitV_Gain_S As Double = 0.5       ' モニター電圧GAIN OK閾値 V

        Dim MonitI_Offset As Double = 0         ' モニター電流OFFSET
        Dim MonitI_Gain As Double = 10000       ' モニター電流GAIN
        Dim MonitI_Offset_K As Double = 2500    ' モニター電流OFFSET係数
        Dim MonitI_Offset_S As Double = 0.0005  ' モニター電流OFFSETT OK閾値 uA
        Dim MonitI_Gain_K As Double = 800       ' モニター電流GAIN係数
        Dim MonitI_Gain_S As Double = 0.002     ' モニター電流GAIN OK閾値 uA

        Dim Probe1000 As Double = 1000          ' HVプローブ 1000倍の値を使用する
        Dim dmmdata1000 As Double = 0           ' 1000倍したデータを処理するときの一時変数
        Dim load_Mohm As Double = 1000          ' 負荷抵抗 MΩ値  電圧値から電流を算出するための値　実験中はHVプローブのみを負荷として1000MΩ
        Dim dmmCurrent As Double = 0            ' 電流値を処理するときの一時変数
        Dim MonitVolt As Double = 0             ' 電流値を処理するときの一時変数

        Const txtOutp_SetComm As String = "~ 00 65 "       ' DAC出力
        Const txtOffs_SetComm As String = "~ 00 05 0C "    ' GAIN
        Const txtGain_SetComm As String = "~ 00 05 0B "    ' OFFSET

        Const txtMoniV_OffsSetComm As String = "~ 00 05 25 "  ' モニターV OFFSET コマンド
        Const txtMoniV_GainSetComm As String = "~ 00 05 24 "  ' モニターV GAIN コマンド
        Const txtMoniI_OffsSetComm As String = "~ 00 05 27 "  ' モニターI OFFSET コマンド
        Const txtMoniI_GainSetComm As String = "~ 00 05 26 "  ' モニターI GAIN　コマンド

        Const txtMoniV_ReadComm As String = "~ 00 78 1E"  ' モニターV 読出しコマンド
        Const txtMoniI_ReadComm As String = "~ 00 78 1F"  ' モニターI 読出しコマンド

        Const txtCurr_LimSetComm As String = "~ 00 72 "  ' Extractor 電流リミット設定 コマンド




        Dim txtMonitVolt As String = ""
        Dim txtMonitVOffset As String = ""     ' 表示用文字列
        Dim txtMonitIOffset As String = ""     ' 表示用文字列


        'DMM通信とシリアル通信がOKなら処理を実行する。
        Dim interfaceOK As Boolean = Proofread And DmmOpen And bPortClose.Enabled
        If Not (interfaceOK) Then
            '
            MessageBox.Show("DMMを接続してください。" _
                            & vbCrLf & "校正データを取り込んでください。" _
                            & vbCrLf & "LMIGとシリアル接続して下さい。",
                            "Calibration", MessageBoxButtons.OK)
            If DEBUG_ENABLE = False Then     'D_TEST
                Exit Sub
            End If

        End If


        ' ============キャリブレーション開始処理==========================
        bReadBack.Enabled = False   ' Readbackを止める
        Timer1.Enabled = False      ' 同上
        cbReadBack.Checked = False  ' 同上

        CalCancel = False           ' キャリブレーション途中停止フラグを落とす
        ProgressBar1.Value = 0
        'ProgressBar1.ForeColor = Color.OrangeRed
        BtnCalStop.Enabled = True
        BtnCalStop.BackColor = Color.GreenYellow

        visa_btn_disable()


        '強制的にDAC出力をZEROにする。 D_TEST ExtPS電圧(AD5066B)
        Dim txtOutput As String = "0"
        Send_RS232(txtOutp_SetComm + txtOutput)  ' ゼロにしない状態で取り込み検証実験
        addMessage("DAC出力を" + txtOutput.ToString + " に設定")

        '最初はOFFSET ZEROから開始する。
        Dim txtOffset As String = "0"
        Send_RS232(txtOffs_SetComm + txtOffset)
        addMessage("OFFSETを" + txtOffset.ToString + " に設定")

        '最初はGain補正ZEROから開始する。
        Send_RS232(txtGain_SetComm + gain.ToString("#"))
        addMessage("Gainを" + gain.ToString("#") + " に設定")

        ' Extr Curr Limit とりあえず15uAに設定しておく
        Send_RS232(txtCurr_LimSetComm + "15.0")
        addMessage("Extr Curr Limitを15.0uA に設定")

        '最初はモニターV OFFSET ZEROから開始する。
        Send_RS232(txtMoniV_OffsSetComm + MonitV_Offset.ToString("0"))
        addMessage("モニターV OFFSET=" + MonitV_Offset.ToString("0") + " に設定")

        '最初はモニターV GAIN補正0から開始する。
        Send_RS232(txtMoniV_GainSetComm + MonitV_Gain.ToString("0"))
        addMessage("モニターV GAIN=" + MonitV_Gain.ToString("0") + " に設定")

        '最初はモニターI OFFSET ZEROから開始する。
        Send_RS232(txtMoniI_OffsSetComm + MonitI_Offset.ToString("0"))
        addMessage("モニターI OFFSET=" + MonitI_Offset.ToString("0") + " に設定")

        '最初はモニターI GAIN補正0から開始する。
        Send_RS232(txtMoniI_GainSetComm + MonitI_Gain.ToString("0"))
        addMessage("モニターI GAIN=" + MonitI_Gain.ToString("0") + " に設定")



        addMessage("DMM取得電圧の安定度チェック開始")

        ProgressBar1.Value = 1
        Application.DoEvents()
        System.Threading.Thread.Sleep(50)

        dmmdata1000 = ReadDmm(Probe1000)
        'TextBoxDMM(0, 1000)   ' DMM表示用TextBoxを更新する。数値が動かないと動作していないようにみえるから

        Do While dmm_stable(8, 1000, (0.1 / 1000), dmmdata) = False   '8回平均 1000ms空けて計測　0.1V以下の誤差

            ProgressBar1.Value += 1
            If CalCancel Then   ' 途中キャンセル処理
                GoTo stop_cal
            End If

            ReadDmm(Probe1000) ' DMM表示用TextBoxを更新する。数値が動かないと動作していないようにみえるから
            Application.DoEvents()
            System.Threading.Thread.Sleep(10)

            ' 繰り返し回数制限
            limit_count = limit_count - 1
            If limit_count < 0 Then
                MessageBox.Show("電圧が安定していません。" & vbCrLf & "設定を確認して下さい。",
                                "Calibration", MessageBoxButtons.OK)
                If DEBUG_ENABLE = True Then     'D_TEST 本当は Return
                    Exit Do
                Else
                    Return
                End If
            End If
        Loop

        dmmdata1000 = ReadDmm(Probe1000)
        addMessage("DMM = " + dmmdata1000.ToString("0.00") + "V")

        System.Threading.Thread.Sleep(10)
        Application.DoEvents()
        If CalCancel Then   ' 途中キャンセル処理
            GoTo stop_cal
        End If



        ' ====================== Extr Offset 調整 =============================
        addMessage("============= OFFSET 調整開始 =============")

        ProgressBar1.Value = 10
        Dim offset_set As Double = 0
        limit_count = 10

        'D_TEST ExtPS電圧のDAC値を0として、その時の電圧値をDMMで読み込む。
        'D_TEST DMMの値が、+/- 15 の範囲であればOK
        Do While (dmmdata1000 > offset_S) Or (dmmdata1000 < offset_S * -1)

            ProgressBar1.Value += 1
            System.Threading.Thread.Sleep(1000)
            Application.DoEvents()
            If CalCancel Then   ' 途中キャンセル処理
                GoTo stop_cal
            End If


            dmmdata1000 = ReadDmm8(Probe1000)

            addMessage("DMM = " + dmmdata1000.ToString("0.00") + "V Loop残り" + limit_count.ToString("#") + "回")
            Application.DoEvents()

            limit_count -= 1
            If limit_count = 0 Then
                MessageBox.Show("OFFSET調整の規定回数に達しました。", "Calibration", MessageBoxButtons.OK)
                Exit Do
            End If

            offset_set = offset_set + (dmmdata1000 / offset_K / 1.5)  ' 徐々に近づけていくため1.5で割っている（要調整）

            txtOffset = offset_set.ToString("0")
            Send_RS232(txtOffs_SetComm + txtOffset)

            addMessage("Offset = " & txtOffset)

        Loop


        addMessage("Offset = " & txtOffset & " にて調整完了")
        Application.DoEvents()
        System.Threading.Thread.Sleep(50)
        If CalCancel Then   ' 途中キャンセル処理
            GoTo stop_cal
        End If


        ' ====================== Extr 電圧モニターOFFSET 調整 =============================
        addMessage("=============電圧モニターOFFSET 調整開始=============")
        ProgressBar1.Value = 20

        txtMonitVolt = Mid(Send_RS232(txtMoniV_ReadComm), 1)
        MonitVolt = Double.Parse(txtMonitVolt)

        addMessage("モニターV = " & txtMonitVolt)

        dmmdata1000 = ReadDmm(Probe1000)

        limit_count = 10
        Do While ((dmmdata1000 - MonitVolt) > MonitV_Offset_S) Or
            ((dmmdata1000 - MonitVolt) < MonitV_Offset_S * -1)  ' 要調整

            ProgressBar1.Value += 1
            System.Threading.Thread.Sleep(100)
            Application.DoEvents()
            If CalCancel Then   ' 途中キャンセル処理
                GoTo stop_cal
            End If


            dmmdata1000 = ReadDmm(Probe1000)

            txtMonitVolt = Mid(Send_RS232(txtMoniV_ReadComm), 1) ' モニタV確認
            MonitVolt = Double.Parse(txtMonitVolt)

            addMessage("DMM = " + dmmdata1000.ToString("0.000") + "V  Monit V = " _
                       + MonitVolt.ToString("0.000") + " V Loop残り" + limit_count.ToString("#") + "回")
            Application.DoEvents()

            limit_count -= 1
            If limit_count = 0 Then
                MessageBox.Show("OFFSET調整の規定回数に達しました。", "Calibration", MessageBoxButtons.OK)
                Exit Do
            End If

            MonitV_Offset = MonitV_Offset + ((dmmdata1000 - MonitVolt) * MonitV_Offset_K)  ' 徐々に近づけていく（要調整） 

            txtMonitVOffset = MonitV_Offset.ToString("0")
            Send_RS232(txtMoniV_OffsSetComm + txtMonitVOffset)

            addMessage("モニターV Offset = " & txtMonitVOffset)

        Loop

        txtMonitVOffset = MonitV_Offset.ToString("0")
        addMessage("モニターV Offset = " & txtMonitVOffset & "にて調整完了")
        Application.DoEvents()
        System.Threading.Thread.Sleep(100)
        If CalCancel Then   ' 途中キャンセル処理
            GoTo stop_cal
        End If

        ' ====================== Extr 電流モニターOFFSET 調整 =============================
        addMessage("=============電流モニターOFFSET 調整開始=============")
        ProgressBar1.Value = 30
        Dim txtMonitCuur As String = Mid(Send_RS232(txtMoniI_ReadComm), 1)
        Dim MonitCur As Double = Double.Parse(txtMonitCuur)

        addMessage("モニターI = " & txtMonitCuur)

        dmmCurrent = ReadDmm(Probe1000) / load_Mohm      ' 500MΩ負荷なので I = V/R 

        limit_count = 10
        Do While ((dmmCurrent - MonitCur) > MonitI_Offset_S) Or
            ((dmmCurrent - MonitCur) < MonitI_Offset_S * -1)  ' 要調整

            ProgressBar1.Value += 1
            System.Threading.Thread.Sleep(100)
            Application.DoEvents()
            If CalCancel Then   ' 途中キャンセル処理
                GoTo stop_cal
            End If

            txtMonitCuur = Mid(Send_RS232(txtMoniI_ReadComm), 1) ' モニタI確認
            MonitCur = Double.Parse(txtMonitCuur)

            dmmCurrent = ReadDmm(Probe1000) / load_Mohm      ' 500MΩ負荷なので I = V/R 

            addMessage("DMM = " + dmmCurrent.ToString("0.000000") + "uA  Monit I = " _
                       + MonitCur.ToString + " uA Loop残り" + limit_count.ToString("#") + "回")
            Application.DoEvents()

            limit_count -= 1
            If limit_count = 0 Then
                MessageBox.Show("OFFSET調整の規定回数に達しました。", "Calibration", MessageBoxButtons.OK)
                Exit Do
            End If

            MonitI_Offset = MonitI_Offset + ((dmmCurrent - MonitCur) * MonitI_Offset_K)  ' 徐々に近づけていく（要調整）

            txtMonitIOffset = MonitI_Offset.ToString("0")
            Send_RS232(txtMoniI_OffsSetComm + txtMonitIOffset)

            addMessage("モニターI Offset = " & txtMonitIOffset)

        Loop

        txtMonitIOffset = MonitI_Offset.ToString("0")
        addMessage("モニターI Offset = " & txtMonitIOffset & "にて調整完了")
        Application.DoEvents()
        System.Threading.Thread.Sleep(100)
        If CalCancel Then   ' 途中キャンセル処理
            GoTo stop_cal
        End If

        ' ====================== Extr Gain 調整 =============================
        addMessage("================== 出力電圧 変更 ===================")
        ProgressBar1.Value = 40

        ' 出力電圧を指定の電圧に設定
        Send_RS232(txtOutp_SetComm + testVolt.ToString("#"))
        addMessage("出力を " + testVolt.ToString("#") + " Vに設定")


        Send_RS232(txtGain_SetComm + gain.ToString("#"))
        addMessage("Gainを " + gain.ToString("#") + " に設定")


        Application.DoEvents()
        System.Threading.Thread.Sleep(1000)
        If CalCancel Then   ' 途中キャンセル処理
            GoTo stop_cal
        End If

        addMessage("電圧を上昇します。安定するまで2分程度かかります。")

        ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee

        ' 10kVに上げた直後は1分くらい待たないと安定しない。
        Dim wait10kV As Integer
        For wait10kV = 1 To 10

            'ProgressBar1.Value += 1
            waitaddMessage(10)   '10 sec Wait
            dmmdata1000 = ReadDmm8(Probe1000)
            If CalCancel Then   ' 途中キャンセル処理
                GoTo stop_cal
            End If

            addMessage("電圧上昇中 " & wait10kV & "/10 DMM = " & dmmdata1000.ToString("0.00") & " V")

        Next

        addMessage("DMM取得電圧の安定度チェック開始")
        Application.DoEvents()

        limit_count = 10 ' 10回でリミット
        Do While dmm_stable(8, 10000, (0.1 / 1000), dmmdata) = False   '8回平均 10sec空けて計測　0.1V以下の誤差

            'ProgressBar1.Value += 1
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
            If CalCancel Then   ' 途中キャンセル処理
                GoTo stop_cal
            End If

            ' 繰り返し回数制限
            limit_count = limit_count - 1
            If limit_count < 0 Then
                MessageBox.Show("電圧が安定していません。" & vbCrLf & "設定を確認して下さい。",
                                "Calibration", MessageBoxButtons.OK)
                If DEBUG_ENABLE = True Then     'D_TEST originalは Return
                    Exit Do
                Else
                    Return
                End If
            End If
        Loop

        dmmdata1000 = ReadDmm(Probe1000)
        addMessage("DMM = " + dmmdata1000.ToString("0.00") + "Vで安定")
        Application.DoEvents()
        System.Threading.Thread.Sleep(50)
        If CalCancel Then   ' 途中キャンセル処理
            GoTo stop_cal
        End If

        ' ====================== Extr GAIN 調整 =============================
        addMessage("=============Gainキャリブレーション開始=============")
        ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Blocks
        ProgressBar1.Value = 65

        limit_count = 10 ' 10回でリミット
        Do While (dmmdata1000 > testVolt + gain_S) Or (dmmdata1000 < testVolt - gain_S)
            addMessage("DMM = " + dmmdata1000.ToString("0.00") + "V Loop残り" + limit_count.ToString("#") + "回")

            ProgressBar1.Value += 1
            limit_count -= 1
            If limit_count = 0 Then
                MessageBox.Show("Gain調整の規定回数に達しました。", "Calibration", MessageBoxButtons.OK)
                Exit Do
            End If

            gain = gain + (testVolt - dmmdata1000) * gain_K ' 徐々に近づけていく（電圧に応じて要調整）

            If (gain < MaxVal_Gain) And (gain > MinVal_Gain) Then
                Send_RS232(txtGain_SetComm + gain.ToString("#"))
            End If

            addMessage("Gain = " & gain.ToString("#"))

            System.Threading.Thread.Sleep(10000)    ' 10sec空ける
            Application.DoEvents()
            If CalCancel Then   ' 途中キャンセル処理
                GoTo stop_cal
            End If

            dmmdata1000 = ReadDmm8(Probe1000)

        Loop

        addMessage("Gain = " & gain.ToString("#") & "で完了しました。")
        addMessage("DMM = " & dmmdata1000.ToString("0.00") & " V")


        ' ====================== Extr 電圧モニターGAIN 調整 =============================
        addMessage("=============電圧モニターGAIN 調整開始=============")
        ProgressBar1.Value = 70
        txtMonitVolt = Mid(Send_RS232(txtMoniV_ReadComm), 1) ' モニタV確認
        MonitVolt = Double.Parse(txtMonitVolt)
        If CalCancel Then   ' 途中キャンセル処理
            GoTo stop_cal
        End If

        dmmdata1000 = ReadDmm(Probe1000)

        limit_count = 10 ' 10回でリミット
        Do While (dmmdata1000 > MonitVolt + MonitV_Gain_S) Or (dmmdata1000 < MonitVolt - MonitV_Gain_S)

            ProgressBar1.Value += 1

            addMessage("DMM = " + dmmdata1000.ToString("0.000") + "V  Monit V = " _
                       + MonitVolt.ToString("0.000") + " V Loop残り" + limit_count.ToString("#") + "回")

            limit_count -= 1
            If limit_count = 0 Then
                MessageBox.Show("Gain調整の規定回数に達しました。", "Calibration", MessageBoxButtons.OK)
                Exit Do
            End If

            txtMonitVolt = Mid(Send_RS232(txtMoniV_ReadComm), 1) ' モニタV確認
            MonitVolt = Double.Parse(txtMonitVolt)

            dmmdata1000 = ReadDmm(Probe1000)

            MonitV_Gain = MonitV_Gain + (MonitVolt - dmmdata1000) * MonitV_Gain_K ' 徐々に近づけていく（電圧に応じて要調整）

            If (MonitV_Gain < MaxVal_Gain) And (MonitV_Gain > MinVal_Gain) Then
                Send_RS232(txtMoniV_GainSetComm + MonitV_Gain.ToString("#"))    ' gain数値を大きくすると、表示も大きくなる
                addMessage("Gain = " & MonitV_Gain.ToString("#"))
            End If

            System.Threading.Thread.Sleep(100)    ' 100msec空ける
            Application.DoEvents()
            If CalCancel Then   ' 途中キャンセル処理
                GoTo stop_cal
            End If

        Loop

        addMessage("電圧モニターGain = " & MonitV_Gain.ToString("#") & "で完了しました。")
        addMessage("電圧モニター = " & txtMonitVolt)

        ' ====================== Extr 電流モニターGAIN 調整 =============================
        addMessage("=============電流モニターGAIN 調整開始=============")
        ProgressBar1.Value = 75

        txtMonitCuur = Mid(Send_RS232(txtMoniI_ReadComm), 1) ' モニタI確認
        MonitCur = Double.Parse(txtMonitCuur)

        dmmCurrent = ReadDmm(Probe1000) / load_Mohm      ' 500MΩ負荷なので I = V/R 

        System.Threading.Thread.Sleep(10)
        Application.DoEvents()
        If CalCancel Then   ' 途中キャンセル処理
            GoTo stop_cal
        End If


        limit_count = 10 ' 10回でリミット
        Do While (dmmCurrent > MonitCur + MonitI_Gain_S) Or (dmmCurrent < MonitCur - MonitI_Gain_S)

            ProgressBar1.Value += 1

            addMessage("DMM = " + dmmCurrent.ToString("0.000") + " uA  Monit I = " _
                       + MonitCur.ToString("0.000") + " uA Loop残り" + limit_count.ToString("#") + "回")

            limit_count -= 1
            If limit_count = 0 Then
                MessageBox.Show("Gain調整の規定回数に達しました。", "Calibration", MessageBoxButtons.OK)
                Exit Do
            End If

            txtMonitCuur = Mid(Send_RS232(txtMoniI_ReadComm), 1) ' モニタI確認
            MonitCur = Double.Parse(txtMonitCuur)

            dmmCurrent = ReadDmm(Probe1000) / load_Mohm      ' 500MΩ負荷なので I = V/R 

            MonitI_Gain = MonitI_Gain + (MonitCur - dmmCurrent) * MonitI_Gain_K ' 徐々に近づけていく（電圧に応じて要調整）

            If (MonitI_Gain < MaxVal_Gain) And (MonitI_Gain > MinVal_Gain) Then
                Send_RS232(txtMoniI_GainSetComm + MonitI_Gain.ToString("#"))    ' gain数値を大きくすると、表示も大きくなる
                addMessage("Gain = " & MonitI_Gain.ToString("#"))
            End If

            System.Threading.Thread.Sleep(100)    ' 100msec空ける
            Application.DoEvents()
            If CalCancel Then   ' 途中キャンセル処理
                GoTo stop_cal
            End If
        Loop

        addMessage("モニターI Gain = " & MonitI_Gain.ToString("#") & "で完了しました。")
        addMessage("モニターI = " & txtMonitCuur)


stop_cal:
        If CalCancel Then
            addMessage("=======キャリブレーションを途中キャンセルしました。=======")
            ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Blocks
            'ProgressBar1.ForeColor = Color.Red
            'ProgressBar1.Value += 1
            Application.DoEvents()
        End If
        ' ====================== キャリブレーション終了処理 =============================
        ProgressBar1.Value = 80

        '強制的にDAC出力をZEROにする。
        txtOutput = "0"
        Send_RS232(txtOutp_SetComm + txtOutput)  ' 出力をゼロに戻しておく
        addMessage("DAC出力を" + txtOutput.ToString + " に設定。  ======電圧降下開始======")
        Application.DoEvents()

        ' 0kVに下げたあと30秒くらいくらい待たないとゼロに落ちない

        limit_count = 30 ' 30回でリミット
        Do While (ReadDmm(Probe1000) < -1.0)
            If ProgressBar1.Value < 100 Then
                ProgressBar1.Value += 1
            End If
            limit_count -= 1
            If limit_count = 0 Then
                MessageBox.Show("規定回数に達しました。", "Calibration", MessageBoxButtons.OK)
                Exit Do
            End If

            waitaddMessage(5)   '8 sec Wait
            'dmmdata1000 = ReadDmm(Probe1000)
        Loop

        dmmdata1000 = ReadDmm(Probe1000)
        addMessage("電圧降下 " & dmmdata1000.ToString("0.00") & " V 完了")

        System.Media.SystemSounds.Hand.Play()
        ProgressBar1.Value = 100

        addMessage(CalName + " Offset         = " & txtOffset)
        addMessage(CalName + " Gain           = " & gain.ToString("#"))
        addMessage(CalName + " Monit V Offset = " & txtMonitVOffset)
        addMessage(CalName + " Monit V Gain   = " & MonitV_Gain.ToString("#"))
        addMessage(CalName + " Monit I Offset = " & txtMonitIOffset)
        addMessage(CalName + " Monit I Gain   = " & MonitI_Gain.ToString("#"))

        If SelectedLogFile Is "" Then
            'LOGファイルを指定してなかったら標準のファイルを使う。
            'ただしフォルダ/ファイル名が見つからなかったら残らないと思う。
            'Console.WriteLine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal))
            Dim LocalPCpath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            TextBoxLogFile.Text = LocalPCpath + "\test\Log_" + Format(Now, "yyyyMMdd") + ".txt"
        Else
            TextBoxLogFile.Text = SelectedLogFile
        End If

        My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, ControlChars.NewLine, True)
        My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, TimeValue(Now), True)
        My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, ControlChars.NewLine, True)

        If CalCancel Then
            My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, CalName + " Calibration Cancelled " + vbCrLf, True)
        End If

        My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, CalName + " Offset         = " + vbTab + txtOffset + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, CalName + " Gain           = " + vbTab + gain.ToString("#") + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, CalName + " Monit V Offset = " + vbTab + txtMonitVOffset + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, CalName + " Monit V Gain   = " + vbTab + MonitV_Gain.ToString("#") + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, CalName + " Monit I Offset = " + vbTab + txtMonitIOffset + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(TextBoxLogFile.Text, CalName + " Monit I Gain   = " + vbTab + MonitI_Gain.ToString("#") + vbCrLf, True)


        If CalCancel Then
            MessageBox.Show("Calibration Cancelled", "Calibration", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Calibration OK", "Calibration", MessageBoxButtons.OK)
        End If

        ' キャリブレーション終了処理
        ProgressBar1.Value = 0
        BtnCalStop.BackColor = Color.Transparent
        BtnCalStop.Enabled = False

        bReadBack.Enabled = True
        visa_btn_enable()


    End Sub

    Private Sub BtnSupCAL_Click(sender As Object, e As EventArgs) Handles BtnSupCAL.Click

        System.Media.SystemSounds.Hand.Play()
        System.Threading.Thread.Sleep(1000)
        System.Media.SystemSounds.Hand.Play()
        System.Threading.Thread.Sleep(1000)
        System.Media.SystemSounds.Hand.Play()
        System.Threading.Thread.Sleep(1000)
        System.Media.SystemSounds.Hand.Play()

        MessageBox.Show("Calibration OK", "Calibration", MessageBoxButtons.OK)

    End Sub


    Private Function Proofreading(dcv As Double)

        ' 校正データがひとつでも入っていなかったら算出しない。
        'If TextBoxHV10k.Text And TextBoxHV20k.Text And TextBoxHV30k.Text And TextBoxHV40k.Text Then
        If Proofread Then

            Dim pointA As Double = Double.Parse(TextBoxHV10k.Text)
            Dim pointB As Double = Double.Parse(TextBoxHV20k.Text)
            Dim pointC As Double = Double.Parse(TextBoxHV30k.Text)
            Dim pointD As Double = Double.Parse(TextBoxHV40k.Text)

            Dim K10k As Double = pointA / 10000
            Dim K20k As Double = (pointB - pointA) / 10000
            Dim K30k As Double = (pointC - pointB) / 10000
            Dim K40k As Double = (pointD - pointC) / 10000

            Dim DCVminus As Boolean

            If dcv < 0 Then
                dcv *= -1
                DCVminus = True
            Else
                DCVminus = False
            End If

            If dcv < pointA Then
                dcv = dcv / K10k                        ' 0-10kV
            ElseIf dcv < pointB Then
                dcv = (dcv - pointA) / K20k + 10000     ' 10-20kV
            ElseIf dcv < pointC Then
                dcv = (dcv - pointB) / K30k + 20000     ' 20-30kV
            Else
                dcv = (dcv - pointC) / K40k + 30000     ' 30-40kV  と それ以上
            End If

            If DCVminus Then
                dcv *= -1
            End If

            TextBoxProofreading.Text = dcv.ToString("0.0000")
            TB_dmm.Text = Format(dcv, "#,0.0000")
        Else
            TextBoxProofreading.Text = "校正データなし"    'VISA COM の 校正電圧　textbox のこと D_TEST
        End If


        Return dcv

    End Function

    Private Sub BtnReadDmm_Click(sender As Object, e As EventArgs) Handles BtnReadDmm.Click

        'Dim strResp As String = "" ' DMMからの応答を受け取る変数

        visa_btn_disable()

        Dim DCV As Double = ReadDmm(1000)

        visa_btn_enable()

    End Sub

    Private Function ReadDmm(by_X As Integer)
        '****************************************
        ' DMMで読み出すルーチン 　
        ' Returnはby_X=1000時はHVプローブ校正する
        '****************************************

        Dim strResp As String = "" ' DMMからの応答を受け取る変数
        Dim proof As Double = 0
        Dim DCV1000 As Double = 0

        If DEBUG_ENABLE = True Then         'D_TEST
            Return DCV1000
        End If

        DMM.WriteString("READ?")  ' READ
        strResp = DMM.ReadString()
        TextBoxReadDmm.Text = strResp

        ' textBoxに書いちゃう
        Dim DCV As Double = Double.Parse(TextBoxReadDmm.Text)


        If by_X = 1000 Then ' 1000:1の時HVプローブ使用とする
            DCV1000 = DCV * 1000    ' 1000:1 プローブ
            TextBoxDCV.Text = DCV1000.ToString("0.00")
            proof = Proofreading(DCV1000) ' HVプローブ校正
            Return proof
        Else                ' 1:1
            TextBoxDCV.Text = DCV.ToString("0.00")
            TextBoxProofreading.Text = "No HV-Probe"
            Return DCV
        End If


    End Function

    Private Function ReadDmm8(by_X As Integer)
        '****************************************
        ' 8回平均をDMMで読み出すルーチン 　
        ' Returnはby_X=1000時はHVプローブ校正する
        '****************************************

        Dim strResp As String = ""          ' DMMからの応答を受け取る変数
        Dim strScanData() As String         ' DMMからの応答を分解
        Dim dblScanData1 As Double = 0
        Dim proof As Double = 0

        If DEBUG_ENABLE = True Then         'D_TEST
            Return dblScanData1
        End If

        DMM.WriteString("TRIG:COUN 8")  ' スキャンは8回
        DMM.WriteString("SYST:ERR?")  ' エラー有無の確認

        strResp = DMM.ReadString()
        If Integer.Parse(strResp.Substring(0, strResp.IndexOf(","))) <> 0 Then  ' エラーが発生したら
            addMessage("スキャン設定エラー : " & strResp)
            Return -1 ' 繰り返しスキャンの処理を抜ける。
        End If

        ' 繰り返しスキャンの開始と測定値の取得
        DMM.WriteString("INIT")

        ' ループで使用する変数宣言
        Dim intDataPoint As Integer
        Dim intActualScan As Integer

        intActualScan = 0 ' 実際にスキャンした回数

        Do
            ' (1)測定値読み取り
            Do
                DMM.WriteString("DATA:POIN?")  ' データ数の問い合わせ
                intDataPoint = Integer.Parse(DMM.ReadString)
                If (intDataPoint >= 8) Then
                    ' 8個以上のデータがある場合
                    DMM.WriteString("DATA:REMOVE? 8")  ' n個の測定値の取得
                    strResp = DMM.ReadString()
                    intActualScan = 1
                Else ' データが8個未満の場合、(1)測定値読み取りを抜ける
                    Exit Do
                End If

            Loop
            System.Threading.Thread.Sleep(50)
            Application.DoEvents()

            ' (2) 指定回数終了確認
            '　　指定されたスキャン回数が完了した場合、ループを抜ける
            If intActualScan = 1 Then 'スキャン回数が終了していればループを抜ける。
                Exit Do
            End If
        Loop


        strScanData = strResp.Split(",")

        For i = 0 To (8 - 1)
            dblScanData1 += Double.Parse(strScanData(i))
        Next

        dblScanData1 /= 8

        TextBoxReadDmm.Text = dblScanData1.ToString("E8")

        ' 設定を戻しておかないと次回DMMにアクセスするとERRORがでる。
        DMM.WriteString("CONF:VOLT:DC AUTO")  ' 電圧測定 autoレンジ
        DMM.WriteString("SYST:ERR?")  ' エラー有無の確認
        strResp = DMM.ReadString()


        If by_X = 1000 Then ' 1000:1の時HVプローブ使用とする
            dblScanData1 = dblScanData1 * 1000    ' 1000:1 プローブ
            TextBoxDCV.Text = dblScanData1.ToString("0.00")
            proof = Proofreading(dblScanData1) ' HVプローブ校正
            Return proof
        Else                ' 1:1
            TextBoxDCV.Text = dblScanData1.ToString("0.00")
            TextBoxProofreading.Text = "No HV-Probe"
            Return dblScanData1
        End If

    End Function


    Private Sub BtnReadDmm8_Click(sender As Object, e As EventArgs) Handles BtnReadDmm8.Click
        '****************************************
        ' 8回平均したデータを取得する。
        ' 他のルーチンから使うので関数化  ReadDmm8()
        '****************************************

        visa_btn_disable()

        Dim dblScanData As Double = ReadDmm8(1000)

        TextBoxReadDmm.Text = dblScanData.ToString("E8")

        visa_btn_enable()

    End Sub

    'Private Function TextBoxDMM(dblData As Double, by_X As Integer)

    '    'DMM表示用TextBoxを更新
    '    'dblDataは未校正データ
    '    'by_Xはプローブの減衰率 1:1 or 1000:1

    '    Dim proof As Double = 0

    '    TextBoxReadDmm.Text = dblData.ToString("E8")

    '    Dim dblData1000 = dblData * by_X　　' 1:1 or 1000:1 プローブ
    '    TextBoxDCV.Text = dblData1000.ToString("0.00")

    '    ' ついでに校正データも表示更新する
    '    If by_X = 1000 Then ' 1000:1の時HVプローブ使用とする
    '        proof = Proofreading(dblData1000) ' HVプローブ校正

    '    Else    ' 1:1ではHVプローブ使っていない。つまり校正もなし
    '        TextBoxProofreading.Text = "No HV-Probe"
    '        proof = dblData1000
    '    End If

    '    Return proof    ' 校正データを返す
    'End Function

    Private Sub visa_btn_enable()
        BtnReadDmm8.Enabled = True
        BtnReadDmm.Enabled = True
        BtnExtrCAL.Enabled = True
        'BtnExtrCAL.BackColor = System.Drawing.Color.GreenYellow
        BtnSupCAL.Enabled = True

    End Sub

    Private Sub visa_btn_disable()
        BtnReadDmm8.Enabled = False
        BtnReadDmm.Enabled = False
        BtnExtrCAL.Enabled = False
        'BtnExtrCAL.BackColor = System.Drawing.Color.Transparent
        BtnSupCAL.Enabled = False

    End Sub

    'CAL STOPボタン　停止しないように見えるが・・・・・ D_TEST
    Private Sub BtnCalStop_Click(sender As Object, e As EventArgs) Handles BtnCalStop.Click
        ' キャリブレーション途中停止フラグ
        Dim result As DialogResult = MessageBox.Show("実行中のキャリブレーションを停止しますか？" + vbCrLf +
                                                     "「はい(Y)」 を押すと停止します。",
                                             "Calibration",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation,
                                             MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            CalCancel = True
            BtnCalStop.BackColor = Color.Red
            BtnCalStop.Enabled = False
        End If

    End Sub

    Private Sub btnTestAll_Click(sender As Object, e As EventArgs) Handles btnTestAll.Click

        If btnTestAll.Text = "DeSelect ALL" Then
            cbTest1.Checked = False
            cbTest2.Checked = False
            cbTest3.Checked = False
            cbTest4.Checked = False
            cbTest5.Checked = False
            cbTest6.Checked = False
            cbTest7.Checked = False
            cbTest8.Checked = False
            cbTest9.Checked = False
            cbTest10.Checked = False
            btnTestAll.Text = "Select ALL"
        Else
            cbTest1.Checked = True
            cbTest2.Checked = True
            cbTest3.Checked = True
            cbTest4.Checked = True
            cbTest5.Checked = True
            cbTest6.Checked = True
            cbTest7.Checked = True
            cbTest8.Checked = True
            cbTest9.Checked = True
            cbTest10.Checked = True
            btnTestAll.Text = "DeSelect ALL"
        End If

    End Sub


    Private Sub addTestMsg(str As String, Optional dontnewline As Boolean = False)
        '****************************************
        ' メッセージを残すサブルーチン for Pre-Potting TEST
        '****************************************
        If dontnewline Then
            txtTestMsg.Text = txtTestMsg.Text & str
        Else
            txtTestMsg.Text = txtTestMsg.Text & str & vbCrLf
        End If

        txtTestMsg.SelectionStart = txtTestMsg.TextLength  ' TextBoxオブジェクトの最後の行を表示
        txtTestMsg.ScrollToCaret()

        If Not (Testlogfile = "") Then
            My.Computer.FileSystem.WriteAllText(Testlogfile, str, True)
            If Not dontnewline Then
                My.Computer.FileSystem.WriteAllText(Testlogfile, ControlChars.NewLine, True)
            End If
        End If

    End Sub

    Private Function StatusChack(xmlpre As PrePotting)

        Dim NotPass As Boolean = False

        Dim fanL As Single = xmlpre.StatusTests.Item(0).FanLowlim
        Dim fanH As Single = xmlpre.StatusTests.Item(0).FanHilim

        ' INTLK OPEN
        MessageBox.Show("インターロックをOPENにして下さい。", "20-750 TEST RUN", MessageBoxButtons.OK)

        Dim status_return As Integer
        Dim strRTN As String

        strRTN = Send_RS232(cStatusGet)
        status_return = Convert.ToInt32(strRTN, 16)

        'status_return = Convert.ToInt16(Send_RS232(cStatusGet))

        If (status_return And &H400) Then
            addTestMsg("OK. INTLK is OPEN Status=0x" + strRTN)
        Else
            addTestMsg("NG. INTLK is OPEN Status=0x" + strRTN)
            NotPass = True
        End If


        ' INTLK CLOSE
        MessageBox.Show("インターロックをCLOSEにして下さい。", "20-750 TEST RUN", MessageBoxButtons.OK)

        Send_RS232(cStatusClear)               ' Status clear
        System.Threading.Thread.Sleep(200)     ' 200ms wait

        strRTN = Send_RS232(cStatusGet)
        status_return = Convert.ToInt32(strRTN, 16)

        'status_return = Convert.ToInt16(Send_RS232(cStatusGet))
        If (status_return And &H400) Then
            addTestMsg("NG. INTLK is CLOSE Status=0x" + strRTN)
            NotPass = True
        Else
            addTestMsg("OK. INTLK is CLOSE Status=0x" + strRTN)
        End If
        Application.DoEvents()


        ' FAN Speed
        Dim strRPM As String = Send_RS232(cFanSpeedGet, True)  ' 文字列全部を取得する True
        Dim arrRPM() As String = strRPM.Split(" ")

        Dim rpm1 As Integer = Convert.ToInt16(arrRPM(3))
        Dim rpm2 As Integer = Convert.ToInt16(arrRPM(4))
        Dim str1 As String = ""
        Dim str2 As String = ""

        If (rpm1 > fanL) And (rpm1 < fanH) Then
            str1 = "OK. "
        Else
            str1 = "NG. "
            NotPass = True
        End If

        If (rpm2 > fanL) And (rpm2 < fanH) Then
            str2 = "OK. "
        Else
            str2 = "NG. "
            NotPass = True
        End If

        addTestMsg(str1 + "FAN 1 SPEED (Rear) = " + arrRPM(3) + " rpm, Expected " + fanL.ToString + " -- " + fanH.ToString + " rpm.")
        addTestMsg(str2 + "FAN 2 SPEED (Front) = " + arrRPM(4) + " rpm, Expected " + fanL.ToString + " -- " + fanH.ToString + " rpm.")


        Return NotPass

    End Function

    Private Function v24Check(xmlpre As PrePotting)

        Dim NotPass As Boolean = False

        Dim F24L As Single = xmlpre.P24VSupplies.Item(0).FloatLowlim
        Dim F24H As Single = xmlpre.P24VSupplies.Item(0).FloatHilim

        Dim B24L As Single = xmlpre.P24VSupplies.Item(0).BeamLowlim
        Dim B24H As Single = xmlpre.P24VSupplies.Item(0).BeamHilim

        Dim L1L As Single = xmlpre.P24VSupplies.Item(0).L1Lowlim
        Dim L1H As Single = xmlpre.P24VSupplies.Item(0).L1Hilim

        Dim L2L As Single = xmlpre.P24VSupplies.Item(0).L2Lowlim
        Dim L2H As Single = xmlpre.P24VSupplies.Item(0).L2Hilim

        Dim str1 As String = ""

        ' Float 24V --------------------------------------------------
        Dim Vstr As String = Send_RS232("~ 00 78 55")
        Dim Vval As Single = Single.Parse(Vstr)

        If (Vval > F24L) And (Vval < F24H) Then
            str1 = "OK. "
        Else
            str1 = "NG. "
            NotPass = True
        End If

        addTestMsg(str1 + "+24V FLOAT = " + Vstr + " V, Expected " + F24L.ToString + " -- " + F24H.ToString + "V")
        Application.DoEvents()

        ' Beam 24V --------------------------------------------------
        Vstr = Send_RS232(cBeam24VGet)
        Vval = Single.Parse(Vstr)

        If (Vval > B24L) And (Vval < B24H) Then
            str1 = "OK. "
        Else
            str1 = "NG. "
            NotPass = True
        End If

        addTestMsg(str1 + "+24V BEAM = " + Vstr + " V, Expected " + B24L.ToString + " -- " + B24H.ToString + "V")
        Application.DoEvents()

        ' L1 24V --------------------------------------------------
        Vstr = Send_RS232(cL1_24VGet)
        Vval = Single.Parse(Vstr)

        If (Vval > L1L) And (Vval < L1H) Then
            str1 = "OK. "
        Else
            str1 = "NG. "
            NotPass = True
        End If

        addTestMsg(str1 + "+24V L1 = " + Vstr + " V, Expected " + L1L.ToString + " -- " + L1H.ToString + "V")
        Application.DoEvents()

        ' L2 24V --------------------------------------------------
        Vstr = Send_RS232(cL2_24VGet)
        Vval = Single.Parse(Vstr)

        If (Vval > L2L) And (Vval < L2H) Then
            str1 = "OK. "
        Else
            str1 = "NG. "
            NotPass = True
        End If

        addTestMsg(str1 + "+24V L2 = " + Vstr + " V, Expected " + L2L.ToString + " -- " + L2H.ToString + "V")
        Application.DoEvents()

        Return NotPass

    End Function

    Private Function v25Check(xmlpre As PrePotting)

        Dim NotPass As Boolean = False

        Dim VL As Single = xmlpre.P25VFloat.Item(0).Lowlim
        Dim VH As Single = xmlpre.P25VFloat.Item(0).Hilim

        Dim str1 As String = ""

        ' 25V Float Supply --------------------------------------------------
        Dim Vstr As String = Send_RS232(cF25VGet)
        Dim Vval As Single = Single.Parse(Vstr)

        If (Vval > VL) And (Vval < VH) Then
            str1 = "OK. "
        Else
            str1 = "NG. "
            NotPass = True
        End If

        addTestMsg(str1 + "25V Float Supply  = " + Vstr + " V, Expected " + VL.ToString + " -- " + VH.ToString + "V")
        Application.DoEvents()

        If Not NotPass Then
            btPass3.BackColor = System.Drawing.Color.GreenYellow
        Else
            btPass3.BackColor = System.Drawing.Color.Transparent
        End If

        Return NotPass

    End Function

    Private Function v15Check(xmlpre As PrePotting)

        Dim NotPass As Boolean = False

        Dim V15L As Single = xmlpre.P15VFloat.Item(0).Lowlim
        Dim V15H As Single = xmlpre.P15VFloat.Item(0).Hilim

        Dim str1 As String = ""

        ' 15V Float Supply --------------------------------------------------
        Dim Vstr As String = Send_RS232("~ 00 78 83")
        Dim Vval As Single = Single.Parse(Vstr)

        If (Vval > V15L) And (Vval < V15H) Then
            str1 = "OK. "
        Else
            str1 = "NG. "
            NotPass = True
        End If

        addTestMsg(str1 + "15V Float Supply = " + Vstr + " V, Expected " + V15L.ToString + " -- " + V15H.ToString + "V")
        Application.DoEvents()

        Return NotPass

    End Function

    Private Function HeaterPSCheck(xmlpre As PrePotting)

        Dim NotPass As Boolean = False

        Dim item_num As Integer = 0
        Dim waitloop As Integer

        Dim VL As Single
        Dim VH As Single
        Dim IL As Single
        Dim IH As Single
        Dim Wait As Single
        Dim ISet As Single
        Dim CheckCount As Single

        Dim str1 As String = ""
        Dim Istr As String
        Dim Ival As Single
        Dim Vstr As String
        Dim Vval As Single

        Dim cc As Integer

        For item_num = 0 To (xmlpre.Heater.Count - 1) ' 0=ZERO 1=2A 2=4A 設定

            VL = xmlpre.Heater.Item(item_num).VLowlim
            VH = xmlpre.Heater.Item(item_num).VHilim
            IL = xmlpre.Heater.Item(item_num).ILowlim
            IH = xmlpre.Heater.Item(item_num).IHilim
            Wait = xmlpre.Heater.Item(item_num).Wait
            ISet = xmlpre.Heater.Item(item_num).Isetting
            CheckCount = xmlpre.Heater.Item(item_num).CheckCount

            If CheckCount = 0 Then  ' もしxmlにデータが入っていなかったら1回はチェックする
                CheckCount = 1
            End If

            tbCheckHeat.Text = CheckCount.ToString

            addTestMsg("----------")
            addTestMsg("Heater set to " + xmlpre.Heater.Item(item_num).name)
            Send_RS232(cHeaterIset + ISet.ToString)

            addTestMsg("wait " + Wait.ToString + "sec.")

            For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
                Application.DoEvents()
                System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
            Next

            ' HeaterI --------------------------------------------------
            str1 = "OK. "
            addTestMsg("Heater I =") ' True=改行なし

            For cc = 1 To CheckCount
                Istr = Send_RS232(cHeaterIread)
                Ival = Single.Parse(Istr)
                addTestMsg("    " + Istr + " A") ' True=改行なし

                If (Ival > IL) And (Ival < IH) Then

                Else
                    str1 = "NG. "
                    NotPass = True
                End If
                System.Threading.Thread.Sleep(100)
            Next
            'addTestMsg(" ")
            'addTestMsg(str1 + "Heater I = " + Istr + " A, Expected " + IL.ToString + " -- " + IH.ToString + "A")
            addTestMsg(str1 + " Expected " + IL.ToString + " -- " + IH.ToString + "A")


            ' HeaterV --------------------------------------------------
            str1 = "OK. "
            addTestMsg("Heater V =") ' True=改行なし

            For cc = 1 To CheckCount
                Vstr = Send_RS232(cHeaterVread)
                Vval = Single.Parse(Vstr)
                addTestMsg("    " + Vstr + " V") ' True=改行なし

                If (Vval > VL) And (Vval < VH) Then

                Else
                    str1 = "NG. "
                    NotPass = True
                End If
                System.Threading.Thread.Sleep(100)
            Next
            'addTestMsg(" ")
            'addTestMsg(str1 + "Heater V = " + Vstr + " V, Expected " + VL.ToString + " -- " + VH.ToString + "V")
            addTestMsg(str1 + " Expected " + VL.ToString + " -- " + VH.ToString + "V")

            ' 終了判断 ---------------------------------------------------
            If NotPass = True Then  ' NotPassなら途中で止めて終了処理に移行する。
                Exit For
            End If

        Next

        ' 終了処理 -----------------------------------------------------
        ISet = 0
        Wait = 20   ' 長めにしておかないと次の項目でEmission電流がNGになる。

        addTestMsg("Heater set to " + ISet.ToString + "A")
        Send_RS232(cHeaterIset + ISet.ToString)

        addTestMsg("wait " + Wait.ToString + "sec.")

        For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
            Application.DoEvents()
            System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
        Next

        Return NotPass

    End Function

    Private Function SuppressorCheck(xmlpre As PrePotting)

        Dim NotPass As Boolean = False

        Dim item_num As Integer = 0
        Dim waitloop As Integer

        Dim VL As Single
        Dim VH As Single
        Dim IL As Single
        Dim IH As Single
        Dim Wait As Single
        Dim VSet As Single
        Dim EmiIL As Single
        Dim EmiIH As Single
        Dim CheckCount As Single

        Dim str1 As String = ""
        Dim Istr As String
        Dim Ival As Single
        Dim Vstr As String
        Dim Vval As Single

        Dim cc As Integer

        For item_num = 0 To (xmlpre.Suppressor.Count - 1) ' 0=ZERO 1=-500V 2=-2500V 設定

            VL = xmlpre.Suppressor.Item(item_num).VLowlim
            VH = xmlpre.Suppressor.Item(item_num).VHilim
            IL = xmlpre.Suppressor.Item(item_num).ILowlim
            IH = xmlpre.Suppressor.Item(item_num).IHilim
            Wait = xmlpre.Suppressor.Item(item_num).Wait
            VSet = xmlpre.Suppressor.Item(item_num).Vsetting
            EmiIL = xmlpre.Suppressor.Item(item_num).EmiLowlim
            EmiIH = xmlpre.Suppressor.Item(item_num).EmiHilim
            CheckCount = xmlpre.Suppressor.Item(item_num).CheckCount

            If CheckCount = 0 Then  ' もしxmlにデータが入っていなかったら1回はチェックする
                CheckCount = 1
            End If

            tbCheckSup.Text = CheckCount.ToString

            addTestMsg("----------")
            addTestMsg("Suppressor set to " + xmlpre.Suppressor.Item(item_num).name)
            Send_RS232(cSupVset + VSet.ToString)

            addTestMsg("wait " + Wait.ToString + "sec.")

            For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
                Application.DoEvents()
                System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
            Next

            ' Suppressor V --------------------------------------------------
            str1 = "OK. "
            addTestMsg("Suppressor V =") ' True=改行なし

            For cc = 1 To CheckCount
                Vstr = Send_RS232(cSupVread)
                Vval = Single.Parse(Vstr)
                addTestMsg("    " + Vstr + " V") ' True=改行なし

                If (Vval > VH) And (Vval < VL) Then

                Else
                    str1 = "NG. "
                    NotPass = True
                End If
                System.Threading.Thread.Sleep(100)
            Next
            'addTestMsg(" ")
            'addTestMsg(str1 + "Suppressor V = " + Vstr + " V, Expected " + VL.ToString + " -- " + VH.ToString + "V")
            addTestMsg(str1 + " Expected " + VL.ToString + " -- " + VH.ToString + "V")

            ' Suppressor I --------------------------------------------------
            str1 = "OK. "
            addTestMsg("Suppressor I =") ' True=改行なし

            For cc = 1 To CheckCount
                Istr = Send_RS232(cSupIread)
                Ival = Single.Parse(Istr)
                addTestMsg("    " + Istr + " uA") ' True=改行なし

                If (Ival > IL) And (Ival < IH) Then

                Else
                    str1 = "NG. "
                    NotPass = True
                End If
                System.Threading.Thread.Sleep(100)
            Next
            'addTestMsg(" ")
            'addTestMsg(str1 + "Suppressor I = " + Istr + " uA, Expected " + IL.ToString + " -- " + IH.ToString + "uA")
            addTestMsg(str1 + " Expected " + IL.ToString + " -- " + IH.ToString + "uA")

            ' Emission I --------------------------------------------------
            str1 = "OK. "
            addTestMsg("Emission I =") ' True=改行なし

            For cc = 1 To CheckCount
                Istr = Send_RS232(cEmiIread)
                Ival = Single.Parse(Istr)
                addTestMsg("    " + Istr + " uA") ' True=改行なし

                If (Ival > EmiIL) And (Ival < EmiIH) Then

                Else
                    str1 = "NG. "
                    NotPass = True
                End If
            Next

            addTestMsg(str1 + " Expected " + EmiIL.ToString + " -- " + EmiIH.ToString + "uA")

            ' 終了判断 ---------------------------------------------------
            If NotPass = True Then  ' NotPassなら途中で止めて終了処理に移行する。
                Exit For
            End If
        Next

        ' 終了処理 -----------------------------------------------------
        VSet = 0
        Wait = 20   ' 長めにしておかないと次の項目でEmission電流がNGになる。

        addTestMsg("Suppressor set to " + VSet.ToString + "V")
        Send_RS232(cSupVset + VSet.ToString)

        addTestMsg("wait " + Wait.ToString + "sec.")

        For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
            Application.DoEvents()
            System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
        Next

        Return NotPass

    End Function

    Private Function ExtractorCheck(xmlpre As PrePotting, final As Boolean)

        Dim NotPass As Boolean = False

        Dim item_num As Integer = 0
        Dim waitloop As Integer

        Dim VL As Single
        Dim VH As Single
        Dim IL As Single
        Dim IH As Single
        Dim Wait As Single
        Dim VSet As Single
        Dim ISet As Single
        Dim EmiIL As Single
        Dim EmiIH As Single
        Dim CheckCount As Single

        Dim str1 As String = ""
        Dim Istr As String
        Dim Ival As Single
        Dim Vstr As String
        Dim Vval As Single

        Dim cc As Integer


        For item_num = 0 To (xmlpre.Extractor.Count - 1) '

            VL = xmlpre.Extractor.Item(item_num).VLowlim
            VH = xmlpre.Extractor.Item(item_num).VHilim
            IL = xmlpre.Extractor.Item(item_num).ILowlim
            IH = xmlpre.Extractor.Item(item_num).IHilim
            Wait = xmlpre.Extractor.Item(item_num).Wait
            VSet = xmlpre.Extractor.Item(item_num).Vsetting
            ISet = xmlpre.Extractor.Item(item_num).Isetting
            EmiIL = xmlpre.Extractor.Item(item_num).EmiLowlim
            EmiIH = xmlpre.Extractor.Item(item_num).EmiHilim
            CheckCount = xmlpre.Extractor.Item(item_num).CheckCount

            If CheckCount = 0 Then  ' もしxmlにデータが入っていなかったら1回はチェックする
                CheckCount = 1
            End If

            tbCheckExtr.Text = CheckCount.ToString

            addTestMsg("----------")
            ' Setting current limit
            addTestMsg("Setting Extractor current limit to " + ISet.ToString + "uA")
            Send_RS232(cExtrCurLim + ISet.ToString)

            ' Setting Voltage
            addTestMsg("Setting Extractor set to " + xmlpre.Extractor.Item(item_num).name)
            Send_RS232(cExtrVset + VSet.ToString)

            addTestMsg("wait " + Wait.ToString + "sec.")

            For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
                Application.DoEvents()
                System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
            Next

            ' Extractor V --------------------------------------------------
            str1 = "OK. "
            addTestMsg("Extractor V =") ' True=改行なし

            For cc = 1 To CheckCount
                Vstr = Send_RS232(cExtrVread)
                Vval = Single.Parse(Vstr)
                addTestMsg("    " + Vstr + " V") ' True=改行なし

                ' 絶対値で大きい数値で表している（ファイ仕様）
                If (Vval > VH) And (Vval < VL) Then

                Else
                    str1 = "NG. "
                    NotPass = True
                End If
                System.Threading.Thread.Sleep(100)
            Next

            'addTestMsg(str1 + "Extractor V = " + Vstr + " V, Expected " + VL.ToString + " -- " + VH.ToString + "V")
            addTestMsg(str1 + " Expected " + VL.ToString + " -- " + VH.ToString + "V " + item_num.ToString)

            ' Extractor I --------------------------------------------------
            str1 = "OK. "
            addTestMsg("Extractor I =") ' True=改行なし

            For cc = 1 To CheckCount
                Istr = Send_RS232(cExtrIread)
                Ival = Single.Parse(Istr)
                addTestMsg("    " + Istr + " uA") ' True=改行なし

                If (Ival > IH) And (Ival < IL) Then

                Else
                    str1 = "NG. "
                    NotPass = True
                End If
                System.Threading.Thread.Sleep(100)
            Next

            'addTestMsg(str1 + "Extractor I = " + Istr + " uA, Expected " + IL.ToString + " -- " + IH.ToString + "uA")
            addTestMsg(str1 + " Expected " + IL.ToString + " -- " + IH.ToString + "uA")

            ' Emission I --------------------------------------------------
            If Not (item_num = 2) Then  ' current limit の時はパスする

                str1 = "OK. "
                addTestMsg("Emission I =") ' True=改行なし

                For cc = 1 To CheckCount
                    Istr = Send_RS232(cEmiIread)
                    Ival = Single.Parse(Istr)
                    addTestMsg("    " + Istr + " uA") ' True=改行なし

                    If (Ival > EmiIL) And (Ival < EmiIH) Then
                        str1 = "OK. "
                    Else
                        str1 = "NG. "
                        NotPass = True
                    End If
                    System.Threading.Thread.Sleep(100)
                Next

                'addTestMsg(str1 + "Emission I = " + Istr + " uA, Expected " + EmiIL.ToString + " -- " + EmiIH.ToString + "uA")
                addTestMsg(str1 + " Expected " + EmiIL.ToString + " -- " + EmiIH.ToString + "uA")

            End If

            ' 終了判断 ---------------------------------------------------
            If NotPass = True Then  ' NotPassなら途中で止めて終了処理に移行する。
                Exit For
            End If

            If (Not final) And (item_num = 3) Then   ' Final では最後まで実行
                Exit For
            End If

        Next

        ' 終了処理 -----------------------------------------------------
        VSet = 0
        ISet = 0
        Wait = 20   ' 長めにしておかないと次の項目でEmission電流がNGになる。

        addTestMsg("Setting Extractor current limit to " + ISet.ToString + "uA")
        Send_RS232(cExtrCurLim + ISet.ToString)
        addTestMsg("Extractor set to " + VSet.ToString + "V")
        Send_RS232(cExtrVset + VSet.ToString)

        addTestMsg("wait " + Wait.ToString + "sec.")

        For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
            Application.DoEvents()
            System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
        Next

        Return NotPass

    End Function


    Private Function BeamCheck(xmlpre As PrePotting, final As Boolean)

        Dim NotPass As Boolean = False

        Dim item_num As Integer = 0
        Dim waitloop As Integer

        Dim VL As Single
        Dim VH As Single
        Dim IL As Single
        Dim IH As Single
        Dim Wait As Single
        Dim VSet As Single
        Dim EmiIL As Single
        Dim EmiIH As Single

        Dim str1 As String = ""
        Dim Istr As String
        Dim Ival As Single
        Dim Vstr As String
        Dim Vval As Single

        For item_num = 0 To (xmlpre.Beam.Count - 1) '

            VL = xmlpre.Beam.Item(item_num).VLowlim
            VH = xmlpre.Beam.Item(item_num).VHilim
            IL = xmlpre.Beam.Item(item_num).ILowlim
            IH = xmlpre.Beam.Item(item_num).IHilim
            Wait = xmlpre.Beam.Item(item_num).Wait
            VSet = xmlpre.Beam.Item(item_num).Vsetting
            EmiIL = xmlpre.Beam.Item(item_num).EmiLowlim
            EmiIH = xmlpre.Beam.Item(item_num).EmiHilim

            ' Setting Voltage
            addTestMsg("----------")
            addTestMsg("Beam set to " + xmlpre.Beam.Item(item_num).name)
            Send_RS232(cBeamVset + VSet.ToString)

            addTestMsg("wait " + Wait.ToString + "sec.")

            For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
                Application.DoEvents()
                System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
            Next

            ' Beam V --------------------------------------------------
            Vstr = Send_RS232(cBeamVread)
            Vval = Single.Parse(Vstr)

            If (Vval > VL) And (Vval < VH) Then
                str1 = "OK. "
            Else
                str1 = "NG. "
                NotPass = True
            End If

            addTestMsg(str1 + "Beam V = " + Vstr + " V, Expected " + VL.ToString + " -- " + VH.ToString + "V")

            ' Beam I --------------------------------------------------
            Istr = Send_RS232(cBeamIread)
            Ival = Single.Parse(Istr)

            If (Ival > IL) And (Ival < IH) Then
                str1 = "OK. "
            Else
                str1 = "NG. "
                NotPass = True
            End If

            addTestMsg(str1 + "Beam I = " + Istr + " uA, Expected " + IL.ToString + " -- " + IH.ToString + "uA")

            ' Emission I --------------------------------------------------
            Istr = Send_RS232(cEmiIread)
            Ival = Single.Parse(Istr)

            If (Ival > EmiIL) And (Ival < EmiIH) Then
                str1 = "OK. "
            Else
                str1 = "NG. "
                NotPass = True
            End If

            addTestMsg(str1 + "Emission I = " + Istr + " uA, Expected " + EmiIL.ToString + " -- " + EmiIH.ToString + "uA")

            ' 終了判断 ---------------------------------------------------
            If NotPass = True Then  ' NotPassなら途中で止めて終了処理に移行する。
                Exit For
            End If

            If (Not final) And (item_num = 2) Then   ' Final では最後まで実行
                Exit For
            End If

        Next

        ' 終了処理 -----------------------------------------------------
        VSet = 0
        Wait = 20   ' 長めにしておかないと次の項目でEmission電流がNGになる。

        addTestMsg("Beam set to " + VSet.ToString + "V")
        Send_RS232(cBeamVset + VSet.ToString)

        addTestMsg("wait " + Wait.ToString + "sec.")

        For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
            Application.DoEvents()
            System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
        Next

        Return NotPass

    End Function


    Private Function L1Check(xmlpre As PrePotting, final As Boolean)

        Dim NotPass As Boolean = False

        Dim item_num As Integer = 0
        Dim waitloop As Integer

        Dim VL As Single
        Dim VH As Single
        Dim IL As Single
        Dim IH As Single
        Dim Wait As Single
        Dim VSet As Single

        Dim str1 As String = ""
        Dim Istr As String
        Dim Ival As Single
        Dim Vstr As String
        Dim Vval As Single

        For item_num = 0 To (xmlpre.L1.Count - 1) '

            VL = xmlpre.L1.Item(item_num).VLowlim
            VH = xmlpre.L1.Item(item_num).VHilim
            IL = xmlpre.L1.Item(item_num).ILowlim
            IH = xmlpre.L1.Item(item_num).IHilim
            Wait = xmlpre.L1.Item(item_num).Wait
            VSet = xmlpre.L1.Item(item_num).Vsetting

            ' Setting Voltage
            addTestMsg("----------")
            addTestMsg("L1 set to " + xmlpre.L1.Item(item_num).name)
            Send_RS232(cLens1Vset + VSet.ToString)

            addTestMsg("wait " + Wait.ToString + "sec.")

            For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
                Application.DoEvents()
                System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
            Next

            If item_num = 3 Then  ' 3は一旦0Vにして待つだけ
                'addTestMsg("0Vにして待ちまーーーーす。")
            Else
                ' L1 V --------------------------------------------------
                Vstr = Send_RS232(cLens1Vread)
                Vval = Single.Parse(Vstr)

                If (Vval > VL) And (Vval < VH) Then
                    str1 = "OK. "
                Else
                    str1 = "NG. "
                    NotPass = True
                End If

                addTestMsg(str1 + "L1 V = " + Vstr + " V, Expected " + VL.ToString + " -- " + VH.ToString + "V")

                ' L1 I --------------------------------------------------
                Istr = Send_RS232(cLens1Iread)
                Ival = Single.Parse(Istr)

                If (Ival > IL) And (Ival < IH) Then
                    str1 = "OK. "
                Else
                    str1 = "NG. "
                    NotPass = True
                End If

                addTestMsg(str1 + "L1 I = " + Istr + " uA, Expected " + IL.ToString + " -- " + IH.ToString + "uA")

            End If


            ' 終了判断 ---------------------------------------------------
            If NotPass = True Then  ' NotPassなら途中で止めて終了処理に移行する。
                Exit For
            End If

            If (Not final) And (item_num = 1 Or item_num = 4) Then  ' Pre-Potting では 2、5を飛ばす
                item_num += 1
            End If

        Next

        ' 終了処理 -----------------------------------------------------
        VSet = 0
        Wait = 10

        addTestMsg("L1 set to " + VSet.ToString + "V")
        Send_RS232(cLens1Vset + VSet.ToString)

        addTestMsg("wait " + Wait.ToString + "sec.")

        For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
            Application.DoEvents()
            System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
        Next

        ' 一度＋電圧にしておかないと、次回のZERO検査時に－電圧が検出されNG判定になってしまう。
        VSet = 100
        Wait = 2
        Send_RS232(cLens1Vset + VSet.ToString)
        For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
            Application.DoEvents()
            System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
        Next

        ' ここで0Vに戻して終了
        VSet = 0
        Send_RS232(cLens1Vset + VSet.ToString)


        Return NotPass

    End Function


    Private Function L2Check(xmlpre As PrePotting, final As Boolean)

        Dim NotPass As Boolean = False

        Dim item_num As Integer = 0
        Dim waitloop As Integer

        Dim VL As Single
        Dim VH As Single
        Dim IL As Single
        Dim IH As Single
        Dim Wait As Single
        Dim VSet As Single

        Dim str1 As String = ""
        Dim Istr As String
        Dim Ival As Single
        Dim Vstr As String
        Dim Vval As Single

        For item_num = 0 To (xmlpre.L2.Count - 1) '

            VL = xmlpre.L2.Item(item_num).VLowlim
            VH = xmlpre.L2.Item(item_num).VHilim
            IL = xmlpre.L2.Item(item_num).ILowlim
            IH = xmlpre.L2.Item(item_num).IHilim
            Wait = xmlpre.L2.Item(item_num).Wait
            VSet = xmlpre.L2.Item(item_num).Vsetting

            ' Setting Voltage
            addTestMsg("----------")
            addTestMsg("L2 set to " + xmlpre.L2.Item(item_num).name)
            Send_RS232(cLens2Vset + VSet.ToString)

            addTestMsg("wait " + Wait.ToString + "sec.")

            For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
                Application.DoEvents()
                System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
            Next


            ' L2 V --------------------------------------------------
            Vstr = Send_RS232(cLens2Vread)
            Vval = Single.Parse(Vstr)


            If (Vval > VL) And (Vval < VH) Then
                str1 = "OK. "
            Else
                str1 = "NG. "
                NotPass = True
            End If

            addTestMsg(str1 + "L2 V = " + Vstr + " V, Expected " + VL.ToString + " -- " + VH.ToString + "V")

            ' L2 I --------------------------------------------------
            Istr = Send_RS232(cLens2Iread)
            Ival = Single.Parse(Istr)

            If (Ival > IL) And (Ival < IH) Then
                str1 = "OK. "
            Else
                str1 = "NG. "
                NotPass = True
            End If

            addTestMsg(str1 + "L2 I = " + Istr + " uA, Expected " + IL.ToString + " -- " + IH.ToString + "uA")

            ' 終了判断 ---------------------------------------------------
            If NotPass = True Then  ' NotPassなら途中で止めて終了処理に移行する。
                Exit For
            End If

            If (Not final) And (item_num = 2) Then  ' Pre-Potting では 2で終わり。
                Exit For
            End If

        Next

        ' 終了処理 -----------------------------------------------------
        VSet = 0
        Wait = 10

        addTestMsg("L2 set to " + VSet.ToString + "V")
        Send_RS232(cLens2Vset + VSet.ToString)

        addTestMsg("wait " + Wait.ToString + "sec.")

        For waitloop = 1 To (Wait * 10)    ' Wait=1sec 
            Application.DoEvents()
            System.Threading.Thread.Sleep(100) ' 100ms毎にイベントを拾うようにしないとフリーズに見える。
        Next

        Return NotPass

    End Function


    Private Sub TestPassClr()
        btPass1.BackColor = System.Drawing.Color.Transparent
        btPass2.BackColor = System.Drawing.Color.Transparent
        btPass3.BackColor = System.Drawing.Color.Transparent
        btPass4.BackColor = System.Drawing.Color.Transparent
        btPass5.BackColor = System.Drawing.Color.Transparent
        btPass6.BackColor = System.Drawing.Color.Transparent
        btPass7.BackColor = System.Drawing.Color.Transparent
        btPass8.BackColor = System.Drawing.Color.Transparent
        btPass9.BackColor = System.Drawing.Color.Transparent
        btPass10.BackColor = System.Drawing.Color.Transparent
        btPass1.Text = "PASS"
        btPass2.Text = "PASS"
        btPass3.Text = "PASS"
        btPass4.Text = "PASS"
        btPass5.Text = "PASS"
        btPass6.Text = "PASS"
        btPass7.Text = "PASS"
        btPass8.Text = "PASS"
        btPass9.Text = "PASS"
        btPass10.Text = "PASS"
    End Sub


    Private Sub PrePotting(xmlpre As PrePotting)
        '****************************************
        '     Pre-Potting TEST
        '****************************************
        Dim final As Boolean = False

        TestPassClr()

        If cbTest1.Checked Then
            addTestMsg("")
            addTestMsg("1. Status Tests ---------------Pre-Potting-----------------")
            If StatusChack(xmlpre) Then
                addTestMsg("==> FAIL")
                btPass1.Text = "FAIL"
                btPass1.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass1.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest2.Checked Then
            addTestMsg("")
            addTestMsg("2. 24V Supplies Tests -------------Pre-Potting-------------")
            If v24Check(xmlpre) Then
                addTestMsg("==> FAIL")
                btPass2.Text = "FAIL"
                btPass2.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass2.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest3.Checked Then
            addTestMsg("")
            addTestMsg("3. 25V Float Tests ------------Pre-Potting-----------------")
            If v25Check(xmlpre) Then
                addTestMsg("==> FAIL")
                btPass3.Text = "FAIL"
                btPass3.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass3.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest4.Checked Then
            addTestMsg("")
            addTestMsg("4. 15V Float Tests -------------Pre-Potting----------------")
            If v15Check(xmlpre) Then
                addTestMsg("==> FAIL")
                btPass4.Text = "FAIL"
                btPass4.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass4.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest5.Checked Then
            addTestMsg("")
            addTestMsg("5. Heater PS Tests --------------Pre-Potting---------------")
            If HeaterPSCheck(xmlpre) Then
                addTestMsg("==> FAIL")
                btPass5.Text = "FAIL"
                btPass5.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass5.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest6.Checked Then
            addTestMsg("")
            addTestMsg("6. Suppressor Tests -------------Pre-Potting---------------")
            If SuppressorCheck(xmlpre) Then
                addTestMsg("==> FAIL")
                btPass6.Text = "FAIL"
                btPass6.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass6.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest7.Checked Then
            addTestMsg("")
            addTestMsg("7. Extractor Tests -------------Pre-Potting----------------")
            If ExtractorCheck(xmlpre, final) Then
                addTestMsg("==> FAIL")
                btPass7.Text = "FAIL"
                btPass7.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass7.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest8.Checked Then
            addTestMsg("")
            addTestMsg("8. Beam V Tests ---------------Pre-Potting-----------------")
            If BeamCheck(xmlpre, final) Then
                addTestMsg("==> FAIL")
                btPass8.Text = "FAIL"
                btPass8.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass8.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest9.Checked Then
            addTestMsg("")
            addTestMsg("9. L1 Tests ------------------Pre-Potting------------------")
            If L1Check(xmlpre, final) Then
                addTestMsg("==> FAIL")
                btPass9.Text = "FAIL"
                btPass9.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass9.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest10.Checked Then
            addTestMsg("")
            addTestMsg("10. L2 Tests -----------------Pre-Potting------------------")
            If L2Check(xmlpre, final) Then
                addTestMsg("==> FAIL")
                btPass10.Text = "FAIL"
                btPass10.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass10.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

    End Sub


    Private Sub Final(xmlpre As PrePotting)
        '****************************************
        '     Fainal TEST
        '****************************************
        Dim final As Boolean = True

        TestPassClr()

        If cbTest1.Checked Then
            addTestMsg("")
            addTestMsg("1. Status Tests ----------------final----------------")
            If StatusChack(xmlpre) Then
                addTestMsg("==> FAIL")
                btPass1.Text = "FAIL"
                btPass1.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass1.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest2.Checked Then
            addTestMsg("")
            addTestMsg("2. 24V Supplies Tests ------------final--------------")
            If v24Check(xmlpre) Then
                addTestMsg("==> FAIL")
                btPass2.Text = "FAIL"
                btPass2.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass2.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest3.Checked Then
            addTestMsg("")
            addTestMsg("3. 25V Float Tests -------------final----------------")
            If v25Check(xmlpre) Then
                addTestMsg("==> FAIL")
                btPass3.Text = "FAIL"
                btPass3.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass3.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest4.Checked Then
            addTestMsg("")
            addTestMsg("4. 15V Float Tests -------------final----------------")
            If v15Check(xmlpre) Then
                addTestMsg("==> FAIL")
                btPass4.Text = "FAIL"
                btPass4.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass4.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest5.Checked Then
            addTestMsg("")
            addTestMsg("5. Heater PS Tests --------------final---------------")
            If HeaterPSCheck(xmlpre) Then
                addTestMsg("==> FAIL")
                btPass5.Text = "FAIL"
                btPass5.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass5.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest6.Checked Then
            addTestMsg("")
            addTestMsg("6. Suppressor Tests -------------final---------------")
            If SuppressorCheck(xmlpre) Then
                addTestMsg("==> FAIL")
                btPass6.Text = "FAIL"
                btPass6.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass6.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest7.Checked Then
            addTestMsg("")
            addTestMsg("7. Extractor Tests -------------final----------------")
            If ExtractorCheck(xmlpre, final) Then
                addTestMsg("==> FAIL")
                btPass7.Text = "FAIL"
                btPass7.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass7.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest8.Checked Then
            addTestMsg("")
            addTestMsg("8. Beam V Tests ---------------final-----------------")
            If BeamCheck(xmlpre, final) Then
                addTestMsg("==> FAIL")
                btPass8.Text = "FAIL"
                btPass8.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass8.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest9.Checked Then
            addTestMsg("")
            addTestMsg("9. L1 Tests ------------------final------------------")
            If L1Check(xmlpre, final) Then
                addTestMsg("==> FAIL")
                btPass9.Text = "FAIL"
                btPass9.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass9.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

        If cbTest10.Checked Then
            addTestMsg("")
            addTestMsg("10. L2 Tests -----------------final------------------")
            If L2Check(xmlpre, final) Then
                addTestMsg("==> FAIL")
                btPass10.Text = "FAIL"
                btPass10.BackColor = System.Drawing.Color.Red
            Else
                addTestMsg("==> PASS")
                btPass10.BackColor = System.Drawing.Color.GreenYellow
            End If
        End If

    End Sub


    Private Sub CpuBoardParamCHECK()

        '--------------- DAC param-----------------
        BeamGain_Read()
        BeamOffset_Read()
        Lens1pGain_Read()
        Lens1pOffset_Read()
        Lens1nGain_Read()
        Lens1nOffset_Read()
        Lens2Gain_Read()
        Lens2Offset_Read()
        SupGain_Read()
        SupOffset_Read()
        ExtGain_Read()
        ExtOffset_Read()
        HeaterGain_Read()
        HeaterOffset_Read()
        EmiGain_R()
        EmiOffset_R()

        '---------------Monitor V param------------------
        BeamVGain_Read()
        BeamVOffset_Read()
        Lens1pVGain_Read()
        Lens1pVOffset_Read()
        Lens1nVGain_Read()
        Lens1nVOffset_Read()
        Lens2VGain_Read()
        Lens2VOffset_Read()
        SupVGain_Read()
        SupVOffset_Read()
        ExtVGain_Read()
        ExtVOffset_Read()
        HeaterVGain_Read()
        HeaterVOffset_Read()

        '---------------Monitor I param------------------
        BeamIGain_Read()
        BeamIOffset_Read()
        Lens1pIGain_Read()
        Lens1pIOffset_Read()
        Lens1nIGain_Read()
        Lens1nIOffset_Read()
        Lens2IGain_Read()
        Lens2IOffset_Read()
        SupIGain_Read()
        SupIOffset_Read()
        ExtIGain_Read()
        ExtIOffset_Read()
        HeaterIGain_Read()
        HeaterIOffset_Read()


    End Sub


    Private Sub btnTestRun_Click(sender As Object, e As EventArgs) Handles btnTestRun.Click
        '－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－
        ' PrePotting.xmlファイルにテスト条件を記入する。
        ' PreもFinalも同じファイルにできた。
        '－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－－

        ' 結果をログファイルに残すようにする。
        Dim LocalPCpath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)


        If Not myRS232.IsOpen Then
            MessageBox.Show("COM未接続です。", "20-750 TEST RUN", MessageBoxButtons.OK)
            Exit Sub
        End If

        btnTestRun.Enabled = False  ' 二重押し禁止

        cbReadBack.Checked = False ' ReadBack を止める

        ' TextBox クリア Log file name クリア
        txtTestMsg.Text = String.Empty
        Testlogfile = ""

        ' xmlファイル デシリアライズ
        Dim xmlSerializer = New XmlSerializer(GetType(PrePotting))
        Dim xmlset As PrePotting
        Dim xmlSettings = New System.Xml.XmlReaderSettings() _
            With {
                .CheckCharacters = False ' 不正な文字をチェックしない
            }

        Try
            Using streamReader = New StreamReader(xmlPrePotting, Encoding.UTF8)
                Using xmlReader = System.Xml.XmlReader.Create(streamReader, xmlSettings)
                    'Try
                    xmlset = CType(xmlSerializer.Deserialize(xmlReader), PrePotting)
                End Using
            End Using
        Catch ex As Exception
            addTestMsg("セッティングデータ読み出し" + xmlPrePotting + " ====== 失敗 =====")
            btnTestRun.Enabled = True
            Exit Sub
        End Try


        addTestMsg("セッティングデータ読み出し" + xmlPrePotting + " ====== 成功 =====")

        Dim testdate As String = Format(Now, "yyyyMMdd_HHmm_ss")

        If tbSirialNum.Text Is "" Then
            MessageBox.Show("テストユニットのS/Nを入力してください。", "20-750 TEST RUN", MessageBoxButtons.OK)
            btnTestRun.Enabled = True
            Exit Sub
        Else
            tbSerialNum2.Text = tbSirialNum.Text
            Get_Ver()

            If rbPrePotting.Checked Then
                Testlogfile = LocalPCpath + "\test\PrePottingTest_" + tbSirialNum.Text + "_" + testdate + ".txt"
                addTestMsg("Pre-Potting test SerialNumber = " + tbSirialNum.Text)
                addTestMsg("firmware Version " + txt_FirmVer.Text)
                addTestMsg("date = " + testdate)
                addTestMsg("Ambient temperature " + tbAmbTemp.Text + " ℃  Humidity " + tbAmbHumidity.Text + " %")
                CpuBoardParamCHECK()
                addTestMsg("CalParm" + vbTab + "DAC-Gain" + vbTab + "Offset" + vbTab + "M-V-Gain" + vbTab + "Offset" + vbTab + "M-I-Gain" + vbTab + "Offset")
                addTestMsg("BeamPS " + vbTab + txt_BeamGain_R.Text + vbTab + txt_BeamOffset_R.Text + vbTab + txt_BeamVGain_ADC_R.Text + vbTab + txt_BeamVOffset_ADC_R.Text + vbTab + txt_BeamIGain_ADC_R.Text + vbTab + txt_BeamIOffset_ADC_R.Text)
                addTestMsg("L1PS+  " + vbTab + txt_L1pGain_R.Text + vbTab + txt_L1pOffset_R.Text + vbTab + txt_L1pVGain_ADC_R.Text + vbTab + txt_L1pVOffset_ADC_R.Text + vbTab + txt_L1pIGain_ADC_R.Text + vbTab + txt_L1pIOffset_ADC_R.Text)
                addTestMsg("L1PS-  " + vbTab + txt_L1nGain_R.Text + vbTab + txt_L1nOffset_R.Text + vbTab + txt_L1nVGain_ADC_R.Text + vbTab + txt_L1nVOffset_ADC_R.Text + vbTab + txt_L1nIGain_ADC_R.Text + vbTab + txt_L1nIOffset_ADC_R.Text)
                addTestMsg("L2PS   " + vbTab + txt_L2Gain_R.Text + vbTab + txt_L2Offset_R.Text + vbTab + txt_L2VGain_ADC_R.Text + vbTab + txt_L2VOffset_ADC_R.Text + vbTab + txt_L2IGain_ADC_R.Text + vbTab + txt_L2IOffset_ADC_R.Text)
                addTestMsg("SupPS  " + vbTab + txt_SupGain_R.Text + vbTab + txt_SupOffset_R.Text + vbTab + txt_SupVGain_ADC_R.Text + vbTab + txt_SupVOffset_ADC_R.Text + vbTab + txt_SupIGain_ADC_R.Text + vbTab + txt_SupIOffset_ADC_R.Text)
                addTestMsg("ExtPS  " + vbTab + txt_ExtGain_R.Text + vbTab + txt_ExtOffset_R.Text + vbTab + txt_ExtVGain_ADC_R.Text + vbTab + txt_ExtVOffset_ADC_R.Text + vbTab + txt_ExtIGain_ADC_R.Text + vbTab + txt_ExtIOffset_ADC_R.Text)
                addTestMsg("HeatPS " + vbTab + txt_HtrGain_R.Text + vbTab + txt_HtrOffset_R.Text + vbTab + txt_HtrVGain_ADC_R.Text + vbTab + txt_HtrVOffset_ADC_R.Text + vbTab + txt_HtrIGain_ADC_R.Text + vbTab + txt_HtrIOffset_ADC_R.Text)
                addTestMsg("Emiss  " + vbTab + txt_EmiGain_R.Text + vbTab + txt_EmiOffset_R.Text)
                PrePotting(xmlset)
            Else
                Testlogfile = LocalPCpath + "\test\FinalTest_" + tbSirialNum.Text + "_" + testdate + ".txt"
                addTestMsg("Final test SerialNumber = " + tbSirialNum.Text)
                addTestMsg("firmware Version " + txt_FirmVer.Text)
                addTestMsg("date = " + testdate)
                addTestMsg("Ambient temperature " + tbAmbTemp.Text + " ℃  Humidity " + tbAmbHumidity.Text + " %")
                CpuBoardParamCHECK()
                addTestMsg("CalParm" + vbTab + "DAC-Gain" + vbTab + "Offset" + vbTab + "M-V-Gain" + vbTab + "Offset" + vbTab + "M-I-Gain" + vbTab + "Offset")
                addTestMsg("BeamPS " + vbTab + txt_BeamGain_R.Text + vbTab + txt_BeamOffset_R.Text + vbTab + txt_BeamVGain_ADC_R.Text + vbTab + txt_BeamVOffset_ADC_R.Text + vbTab + txt_BeamIGain_ADC_R.Text + vbTab + txt_BeamIOffset_ADC_R.Text)
                addTestMsg("L1PS+  " + vbTab + txt_L1pGain_R.Text + vbTab + txt_L1pOffset_R.Text + vbTab + txt_L1pVGain_ADC_R.Text + vbTab + txt_L1pVOffset_ADC_R.Text + vbTab + txt_L1pIGain_ADC_R.Text + vbTab + txt_L1pIOffset_ADC_R.Text)
                addTestMsg("L1PS-  " + vbTab + txt_L1nGain_R.Text + vbTab + txt_L1nOffset_R.Text + vbTab + txt_L1nVGain_ADC_R.Text + vbTab + txt_L1nVOffset_ADC_R.Text + vbTab + txt_L1nIGain_ADC_R.Text + vbTab + txt_L1nIOffset_ADC_R.Text)
                addTestMsg("L2PS   " + vbTab + txt_L2Gain_R.Text + vbTab + txt_L2Offset_R.Text + vbTab + txt_L2VGain_ADC_R.Text + vbTab + txt_L2VOffset_ADC_R.Text + vbTab + txt_L2IGain_ADC_R.Text + vbTab + txt_L2IOffset_ADC_R.Text)
                addTestMsg("SupPS  " + vbTab + txt_SupGain_R.Text + vbTab + txt_SupOffset_R.Text + vbTab + txt_SupVGain_ADC_R.Text + vbTab + txt_SupVOffset_ADC_R.Text + vbTab + txt_SupIGain_ADC_R.Text + vbTab + txt_SupIOffset_ADC_R.Text)
                addTestMsg("ExtPS  " + vbTab + txt_ExtGain_R.Text + vbTab + txt_ExtOffset_R.Text + vbTab + txt_ExtVGain_ADC_R.Text + vbTab + txt_ExtVOffset_ADC_R.Text + vbTab + txt_ExtIGain_ADC_R.Text + vbTab + txt_ExtIOffset_ADC_R.Text)
                addTestMsg("HeatPS " + vbTab + txt_HtrGain_R.Text + vbTab + txt_HtrOffset_R.Text + vbTab + txt_HtrVGain_ADC_R.Text + vbTab + txt_HtrVOffset_ADC_R.Text + vbTab + txt_HtrIGain_ADC_R.Text + vbTab + txt_HtrIOffset_ADC_R.Text)
                addTestMsg("Emiss  " + vbTab + txt_EmiGain_R.Text + vbTab + txt_EmiOffset_R.Text)
                Final(xmlset)
            End If

        End If

        btnTestRun.Enabled = True

    End Sub

#If 1 Then  'どこからも参照されていない？     D_TEST
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        ' xmlファイル デシリアライズのテスト
        Dim xmlSerializer = New XmlSerializer(GetType(PrePotting))
        Dim result As PrePotting
        Dim xmlSettings = New System.Xml.XmlReaderSettings() _
            With {
                .CheckCharacters = False ' 不正な文字をチェックしない
            }

        Try
            Using streamReader = New StreamReader(xmlPrePotting, Encoding.UTF8)
                Using xmlReader = System.Xml.XmlReader.Create(streamReader, xmlSettings)
                    'Try
                    result = CType(xmlSerializer.Deserialize(xmlReader), PrePotting)
                End Using
            End Using
        Catch ex As Exception
            addTestMsg("セッティングデータ読み出し" + xmlPrePotting + " ====== 失敗 =====")
            Exit Sub
        End Try
        addTestMsg("セッティングデータ読み出し" + xmlPrePotting + " ====== 成功 =====")

        addTestMsg(result.StatusTests.Item(0).FanLowlim)
        addTestMsg(result.StatusTests.Item(0).FanHilim)
        addTestMsg(result.Heater.Item(0).name)
        addTestMsg("Isetting=" + result.Heater.Item(0).Isetting.ToString)
        addTestMsg("IHilim=" + result.Heater.Item(0).IHilim.ToString)
        addTestMsg("ILowlim=" + result.Heater.Item(0).ILowlim.ToString)
        addTestMsg("VLowlim=" + result.Heater.Item(0).VLowlim.ToString)
        addTestMsg("VHilim=" + result.Heater.Item(0).VHilim.ToString)
        addTestMsg("Wait=" + result.Heater.Item(0).Wait.ToString)

        addTestMsg(result.Heater.Item(1).name)
        addTestMsg(result.Heater.Item(2).name)

    End Sub

#End If

    'Burn-inのラジオボタンのイベント ChechedChanged 立ち上がり時に必ず呼ばれる   D_TEST
    'ラジオボタン押下のたびに、2回呼ばれる(CheckChangedなので.....)
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles RBPrepotAging.CheckedChanged, RBFinalAging.CheckedChanged
        ' xmlファイル デシリアライズのテスト
        Dim xmlSerializer = New XmlSerializer(GetType(listAging))   'オブジェクトの型指定     D_TEST
        Dim result As listAging
        Dim xmlSettings = New System.Xml.XmlReaderSettings() _      'ignorecommentsなどの設定ができる    D_TEST
            With {
                .CheckCharacters = False ' 不正な文字をチェックしない
            }

        Try
            Using streamReader = New StreamReader(xmlAging, Encoding.UTF8)
                Using xmlReader = System.Xml.XmlReader.Create(streamReader, xmlSettings)
                    'Try
                    result = CType(xmlSerializer.Deserialize(xmlReader), listAging)
                End Using
            End Using
        Catch ex As Exception
            addTestMsg("セッティングデータ読み出し" + xmlAging + " ====== 失敗 =====")
            Exit Sub
        End Try
        addTestMsg("セッティングデータ読み出し" + xmlAging + " ====== 成功 =====")

        If RBPrepotAging.Checked Then

            TBagingBeam.Text = result.Aging.Item(0).BeamV.ToString
            TBagingSup.Text = result.Aging.Item(0).SuppV.ToString
            TBagingExt.Text = result.Aging.Item(0).ExtrV.ToString
            TBagingHeat.Text = result.Aging.Item(0).HeatA.ToString
            TBagingL1.Text = result.Aging.Item(0).L1V.ToString
            TBagingL2.Text = result.Aging.Item(0).L2V.ToString
            TBagingTime.Text = result.Aging.Item(0).TimeHour.ToString

        Else

            TBagingBeam.Text = result.Aging.Item(1).BeamV.ToString
            TBagingSup.Text = result.Aging.Item(1).SuppV.ToString
            TBagingExt.Text = result.Aging.Item(1).ExtrV.ToString
            TBagingHeat.Text = result.Aging.Item(1).HeatA.ToString
            TBagingL1.Text = result.Aging.Item(1).L1V.ToString
            TBagingL2.Text = result.Aging.Item(1).L2V.ToString
            TBagingTime.Text = result.Aging.Item(1).TimeHour.ToString

        End If


    End Sub


#If 0 Then  'どこからも参照されていない？     D_TEST
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        '-----------------------------------------------------
        ' 予期しない文字 '.' が見つかりました。 というエラーでデシリアライズ出来ない。
        '-----------------------------------------------------
        Dim serializer As New DataContractJsonSerializer(GetType(jcPrePotting))
        Dim stream As New MemoryStream(Encoding.UTF8.GetBytes(JsonPrePotting))
        Dim result As jcPrePotting

        'Using stream As New IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(JsonPrePotting))
        '   result = DirectCast(serializer.ReadObject(stream), jcPrePotting)
        'End Using

        Try
            result = DirectCast(serializer.ReadObject(stream), jcPrePotting)
        Catch ex As Exception
            addTestMsg("セッティングデータ読み出し[\PrePotting.json] ====== 失敗 =====")
            'Exit Sub
            Throw
        Finally
            stream.Dispose()
            stream = Nothing
            serializer = Nothing
        End Try

        addTestMsg("セッティングデータ読み出し[\PrePotting.json] ====== 成功 =====")

        addTestMsg(result.StatusTests(0).FanHilim)

    End Sub
#End If

    Private Sub BtnCalStop2_Click(sender As Object, e As EventArgs)
        ' キャリブレーション途中停止フラグ
        Dim result As DialogResult = MessageBox.Show("実行中のキャリブレーションを停止しますか？" + vbCrLf +
                                                     "「はい(Y)」 を押すと停止します。",
                                             "Calibration",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation,
                                             MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            CalCancel = True
            BtnCalStop.BackColor = Color.Red
            BtnCalStop.Enabled = False
        End If

    End Sub



    Private Sub AgingLogWrite(dtnow As DateTime)

        My.Computer.FileSystem.WriteAllText(Aginglogfile, dtnow.ToString("yyyy/MM/dd_hh:mm:ss"), True)

        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + TBagingBV.Text, True)
        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + TBagingSV.Text, True)
        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + TBagingEV.Text, True)
        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + TBagingHV.Text, True)
        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + TBagingL1V.Text, True)
        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + TBagingL2V.Text, True)

        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + TBagingBI.Text, True)
        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + TBagingSI.Text, True)
        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + TBagingEI.Text, True)
        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + TBagingHI.Text, True)
        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + TBagingL1I.Text, True)
        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + TBagingL2I.Text, True)

        ' フローティングBOXの温度
        Dim txtTemp As String = Mid(Send_RS232("~ 00 78 82"), 1)
        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + txtTemp, True)

        ' 周囲温度
        My.Computer.FileSystem.WriteAllText(Aginglogfile, vbTab + tbAmbTemp.Text, True)

        My.Computer.FileSystem.WriteAllText(Aginglogfile, ControlChars.NewLine, True)

    End Sub

    Private Sub AgingReadNow(OneMinute As Boolean)

        'Static aaa As Integer = 0
        'aaa += 1

        TBagingBV.Text = Send_RS232(cBeamVread)
        TBagingSV.Text = Send_RS232(cSupVread)
        TBagingEV.Text = Send_RS232(cExtrVread)
        TBagingHV.Text = Send_RS232(cHeaterVread)
        TBagingL1V.Text = Send_RS232(cLens1Vread)
        TBagingL2V.Text = Send_RS232(cLens2Vread)

        TBagingBI.Text = Send_RS232(cBeamIread)
        TBagingSI.Text = Send_RS232(cSupIread)
        TBagingEI.Text = Send_RS232(cExtrIread)
        TBagingHI.Text = Send_RS232(cHeaterIread)
        TBagingL1I.Text = Send_RS232(cLens1Iread)
        TBagingL2I.Text = Send_RS232(cLens2Iread)

        ' エラー処理 数値以外だったら空白にする。
        If Not IsNumeric(TBagingBV.Text) Then
            TBagingBV.Text = ""
        End If
        If Not IsNumeric(TBagingSV.Text) Then
            TBagingSV.Text = ""
        End If
        If Not IsNumeric(TBagingEV.Text) Then
            TBagingEV.Text = ""
        End If
        If Not IsNumeric(TBagingHV.Text) Then
            TBagingHV.Text = ""
        End If
        If Not IsNumeric(TBagingL1V.Text) Then
            TBagingL1V.Text = ""
        End If
        If Not IsNumeric(TBagingL2V.Text) Then
            TBagingL2V.Text = ""
        End If


        If Not IsNumeric(TBagingBI.Text) Then
            TBagingBI.Text = ""
        End If
        If Not IsNumeric(TBagingSI.Text) Then
            TBagingSI.Text = ""
        End If
        If Not IsNumeric(TBagingEI.Text) Then
            TBagingEI.Text = ""
        End If
        If Not IsNumeric(TBagingHI.Text) Then
            TBagingHI.Text = ""
        End If
        If Not IsNumeric(TBagingL1I.Text) Then
            TBagingL1I.Text = ""
        End If
        If Not IsNumeric(TBagingL2I.Text) Then
            TBagingL2I.Text = ""
        End If

        If OneMinute Then
            TBagingBV1.Text = TBagingBV.Text
            TBagingSV1.Text = TBagingSV.Text
            TBagingEV1.Text = TBagingEV.Text
            TBagingHV1.Text = TBagingHV.Text
            TBagingL1V1.Text = TBagingL1V.Text
            TBagingL2V1.Text = TBagingL2V.Text

            TBagingBI1.Text = TBagingBI.Text
            TBagingSI1.Text = TBagingSI.Text
            TBagingEI1.Text = TBagingEI.Text
            TBagingHI1.Text = TBagingHI.Text
            TBagingL1I1.Text = TBagingL1I.Text
            TBagingL2I1.Text = TBagingL2I.Text
        End If

        System.Threading.Thread.Sleep(5)
        Application.DoEvents()

        If IsNumeric(TBagingBV1.Text) And IsNumeric(TBagingBV.Text) Then    'ゼロ割り対策、エラー処理
            TBagingBVp.Text = ((Double.Parse(TBagingBV.Text) - Double.Parse(TBagingBV1.Text)) / Double.Parse(TBagingBV1.Text)).ToString("P")  ' %計算
        End If
        If IsNumeric(TBagingSV1.Text) And IsNumeric(TBagingSV.Text) Then    'ゼロ割り対策、エラー処理
            TBagingSVp.Text = ((Double.Parse(TBagingSV.Text) - Double.Parse(TBagingSV1.Text)) / Double.Parse(TBagingSV1.Text)).ToString("P")  ' %計算
        End If
        If IsNumeric(TBagingEV1.Text) And IsNumeric(TBagingEV.Text) Then    'ゼロ割り対策、エラー処理
            TBagingEVp.Text = ((Double.Parse(TBagingEV.Text) - Double.Parse(TBagingEV1.Text)) / Double.Parse(TBagingEV1.Text)).ToString("P")  ' %計算
        End If
        If IsNumeric(TBagingHV1.Text) And IsNumeric(TBagingHV.Text) Then    'ゼロ割り対策、エラー処理
            TBagingHVp.Text = ((Double.Parse(TBagingHV.Text) - Double.Parse(TBagingHV1.Text)) / Double.Parse(TBagingHV1.Text)).ToString("P")  ' %計算
        End If
        If IsNumeric(TBagingL1V1.Text) And IsNumeric(TBagingL1V.Text) Then    'ゼロ割り対策、エラー処理
            TBagingL1Vp.Text = ((Double.Parse(TBagingL1V.Text) - Double.Parse(TBagingL1V1.Text)) / Double.Parse(TBagingL1V1.Text)).ToString("P")  ' %計算
        End If
        If IsNumeric(TBagingL2V1.Text) And IsNumeric(TBagingL2V.Text) Then    'ゼロ割り対策、エラー処理
            TBagingL2Vp.Text = ((Double.Parse(TBagingL2V.Text) - Double.Parse(TBagingL2V1.Text)) / Double.Parse(TBagingL2V1.Text)).ToString("P")  ' %計算
        End If



        If IsNumeric(TBagingBI1.Text) And IsNumeric(TBagingBI.Text) Then    'ゼロ割り対策、エラー処理
            TBagingBIp.Text = ((Double.Parse(TBagingBI.Text) - Double.Parse(TBagingBI1.Text)) / Double.Parse(TBagingBI1.Text)).ToString("P")  ' %計算
        End If
        If IsNumeric(TBagingSI1.Text) And IsNumeric(TBagingSI.Text) Then    'ゼロ割り対策、エラー処理
            TBagingSIp.Text = ((Double.Parse(TBagingSI.Text) - Double.Parse(TBagingSI1.Text)) / Double.Parse(TBagingSI1.Text)).ToString("P")  ' %計算
        End If
        If IsNumeric(TBagingEI1.Text) And IsNumeric(TBagingEI.Text) Then    'ゼロ割り対策、エラー処理
            TBagingEIp.Text = ((Double.Parse(TBagingEI.Text) - Double.Parse(TBagingEI1.Text)) / Double.Parse(TBagingEI1.Text)).ToString("P")  ' %計算
        End If
        If IsNumeric(TBagingHI1.Text) And IsNumeric(TBagingHI.Text) Then    'ゼロ割り対策、エラー処理
            TBagingHIp.Text = ((Double.Parse(TBagingHI.Text) - Double.Parse(TBagingHI1.Text)) / Double.Parse(TBagingHI1.Text)).ToString("P")  ' %計算
        End If
        If IsNumeric(TBagingL1I1.Text) And IsNumeric(TBagingL1I.Text) Then    'ゼロ割り対策、エラー処理
            TBagingL1Ip.Text = ((Double.Parse(TBagingL1I.Text) - Double.Parse(TBagingL1I1.Text)) / Double.Parse(TBagingL1I1.Text)).ToString("P")  ' %計算
        End If
        If IsNumeric(TBagingL2I1.Text) And IsNumeric(TBagingL2I.Text) Then    'ゼロ割り対策、エラー処理
            TBagingL2Ip.Text = ((Double.Parse(TBagingL2I.Text) - Double.Parse(TBagingL2I1.Text)) / Double.Parse(TBagingL2I1.Text)).ToString("P")  ' %計算
        End If


        'If (Double.Parse(TBagingBVp.Text) > 0.1) Or (Double.Parse(TBagingBVp.Text) < -0.1) Then
        '    TBagingBVp.BackColor = System.Drawing.Color.Red
        'Else
        '    TBagingBVp.BackColor = System.Drawing.Color.Transparent
        'End If

        Application.DoEvents()

    End Sub



    Private Sub AgingSetNow()
        '=================================================
        ' エージング用の設定コマンドを発行
        '=================================================
        Send_RS232(cBeamVset + TBagingBeam.Text)
        System.Threading.Thread.Sleep(100)
        Application.DoEvents()

        Send_RS232(cSupVset + TBagingSup.Text)
        System.Threading.Thread.Sleep(100)
        Application.DoEvents()

        Send_RS232(cExtrCurLim + "40")  ' Extrctorは current limit必要
        System.Threading.Thread.Sleep(100)
        Send_RS232(cExtrVset + TBagingExt.Text)
        System.Threading.Thread.Sleep(100)
        Application.DoEvents()

        Send_RS232(cHeaterIset + TBagingHeat.Text)
        System.Threading.Thread.Sleep(100)
        Application.DoEvents()

        '今の所L1,L2はエージング設定なし。
        Send_RS232(cLens1Vset + TBagingL1.Text)
        System.Threading.Thread.Sleep(100)
        Application.DoEvents()

        Send_RS232(cLens2Vset + TBagingL2.Text)
        Application.DoEvents()

    End Sub


    Private Sub BTagingRun_Click(sender As Object, e As EventArgs) Handles BTagingRun.Click

        'Dim testdate As String = Format(Now, "MM/dd HH:mm:ss")
        Dim dt1 As DateTime = DateTime.Now
        Dim dt2 As DateTime = dt1.AddHours(Integer.Parse(TBagingTime.Text))
        Dim dt3 As DateTime
        Dim keika As Int32
        Dim keika60 As Int32

        ' 結果をログファイルに残すようにする。
        Dim LocalPCpath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)


        If myRS232.IsOpen Then

        Else
            'MsgBox("RS232C OPEN していません。")
            MessageBox.Show("RS232C OPEN していません。", "20-750 Aging RUN", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim ret As String = Send_RS232("~ 00 AF")

        If ret = "RS232ERROR" Then
            'MsgBox("通信できません。")
            MessageBox.Show("通信できません。", "20-750 Aging RUN", MessageBoxButtons.OK)
            Exit Sub
        End If

        If tbSerialNum2.Text Is "" Then
            MessageBox.Show("テストユニットのS/Nを入力してください。", "20-750 Aging RUN", MessageBoxButtons.OK)
            Exit Sub
        End If


        If BTagingRun.Text Is "RUN" Then

            AgingCancel = False
            TB_date.Text = dt1.ToString
            TB_date2.Text = dt2.ToString
            TBkeika.Text = "00:00"
            Application.DoEvents()

            Aginglogfile = LocalPCpath + "\test\Aging_" + tbSerialNum2.Text + "_" + dt1.ToString("yyyyMMdd_hhmm_ss") + ".txt"


            SaveSetting("20_750", "Operation_Value", "Aging_status", "RUN")
            If RBPrepotAging.Checked Then
                SaveSetting("20_750", "Operation_Value", "Aging_mode", "PrepotAging")
            Else
                SaveSetting("20_750", "Operation_Value", "Aging_mode", "FinalAging")
            End If

            SaveSetting("20_750", "Operation_Value", "Aging_date", TB_date.Text)
            SaveSetting("20_750", "Operation_Value", "Aging_date2", TB_date2.Text)

            SaveSetting("20_750", "Operation_Value", "Aging_Serial", tbSerialNum2.Text)
            SaveSetting("20_750", "Operation_Value", "Aging_logfile", Aginglogfile)


            BTagingRun.Text = "STOP"
            BTagingRun.BackColor = Color.Red
            Panel1.Enabled = False
            TBagingTime.Enabled = False
            BTAgingRunAgain.Enabled = False

            ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee

            My.Computer.FileSystem.WriteAllText(Aginglogfile, "TIME" _
                     + vbTab + "BeamV" + vbTab + "SupV" + vbTab + "ExtrV" + vbTab + "HeaterV" + vbTab + "Lens1V" + vbTab + "Lens2V" _
                     + vbTab + "BeamI" + vbTab + "SupI" + vbTab + "ExtrI" + vbTab + "HeaterI" + vbTab + "Lens1I" + vbTab + "Lens2I" _
                     + vbTab + "FbTemp" + vbTab + "AmTemp" + vbCrLf, True)


            AgingReadNow(False)                 ' 各種電圧・電流値を取得
            AgingLogWrite(DateTime.Now)

            AgingSetNow()                          ' エージング用の設定コマンドを発行

            Dim Wait As Integer = 5
            Dim waitloop As Integer = 0

            For waitloop = 1 To (Wait)    ' Wait=1sec 
                Application.DoEvents()
                System.Threading.Thread.Sleep(700)  ' 最初は1s毎に更新
                AgingReadNow(False)                 ' 各種電圧・電流値を取得 300msくらいかかる
                AgingLogWrite(DateTime.Now)
                Application.DoEvents()
                If BTagingRun.Text = "RUN" Then
                    Exit For
                End If
            Next

            keika = 1

            While True
                System.Threading.Thread.Sleep(200) ' 200ms毎にイベントを拾うようにしないとフリーズに見える。
                Application.DoEvents()
                dt3 = DateTime.Now

                If dt3 >= dt1.AddMinutes(keika) Then
                    keika60 = Math.Floor(keika / 60)
                    TBkeika.Text = keika60.ToString("00") + ":" + (keika Mod 60).ToString("00")

                    If keika = 1 Then
                        AgingReadNow(True)      ' エージング開始から1分後の値を取得
                    Else
                        AgingReadNow(False)     ' 1分毎の値を取得
                    End If

                    AgingLogWrite(dt3)
                    keika += 1

                End If

                If BTagingRun.Text = "RUN" Then
                    Exit While
                End If

            End While

        Else

            Setallzero()

            BTagingRun.Text = "RUN"
            BTagingRun.BackColor = Color.Transparent
            Panel1.Enabled = True
            TBagingTime.Enabled = True
            SaveSetting("20_750", "Operation_Value", "Aging_status", "STOP")

            ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Blocks

        End If


    End Sub

    Private Sub BTAgingRunAgain_Click(sender As Object, e As EventArgs) Handles BTAgingRunAgain.Click

        'Dim testdate As String = Format(Now, "MM/dd HH:mm:ss")

        Dim dt1 As DateTime = DateTime.Parse(TB_date.Text)
        Dim dt2 As DateTime = DateTime.Parse(TB_date2.Text)
        Dim dt3 As DateTime = DateTime.Now
        Dim keika As Int32
        Dim keika60 As Int32

        'エージング中にアプリが落ちた時のリカバリ＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
        Dim AgingRun As String = GetSetting("20_750", "Operation_Value", "Aging_status")

        If AgingRun = "STOP" Then
            Exit Sub
        End If

        ' 結果をログファイルに残すようにする。
        'Dim LocalPCpath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)

        Aginglogfile = GetSetting("20_750", "Operation_Value", "Aging_logfile")


        If myRS232.IsOpen Then

        Else
            'MsgBox("RS232C OPEN していません。")
            MessageBox.Show("RS232C OPEN していません。", "20-750 Aging RUN", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim ret As String = Send_RS232("~ 00 AF")

        If ret = "RS232ERROR" Then
            'MsgBox("通信できません。")
            MessageBox.Show("通信できません。", "20-750 Aging RUN", MessageBoxButtons.OK)
            Exit Sub
        End If

        If tbSerialNum2.Text Is "" Then
            MessageBox.Show("テストユニットのS/Nを入力してください。", "20-750 Aging RUN", MessageBoxButtons.OK)
            Exit Sub
        End If



        If BTagingRun.Text Is "RUN" Then    ' RUN表示中にボタンを押すとここに来る。

            AgingCancel = False
            TB_date.Text = dt1.ToString
            TB_date2.Text = dt2.ToString
            BTAgingRunAgain.Enabled = False

            Dim dtsub As TimeSpan = dt3 - dt1
            keika = dtsub.TotalMinutes
            TBkeika.Text = keika60.ToString("00") + ":" + (keika Mod 60).ToString("00")

            Application.DoEvents()

            'AgingSetNow()                          ' エージング用の設定コマンドを発行

            BTagingRun.Text = "STOP"
            BTagingRun.BackColor = Color.Red
            Panel1.Enabled = False
            TBagingTime.Enabled = False

            ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee
            AgingReadNow(True)

            Dim Wait As Integer = 5
            Dim waitloop As Integer = 0

            While True
                System.Threading.Thread.Sleep(200) ' 200ms毎にイベントを拾うようにしないとフリーズに見える。
                Application.DoEvents()
                dt3 = DateTime.Now

                If dt3 >= dt1.AddMinutes(keika) Then
                    keika60 = Math.Floor(keika / 60)
                    TBkeika.Text = keika60.ToString("00") + ":" + (keika Mod 60).ToString("00")

                    If keika = 1 Then
                        AgingReadNow(True)      ' エージング開始から1分後の値を取得
                    Else
                        AgingReadNow(False)     ' 1分毎の値を取得
                    End If

                    AgingLogWrite(dt3)
                    keika += 1

                End If

                If BTagingRun.Text = "RUN" Then
                    Exit While
                End If

            End While

        Else ' STOP表示中にボタンを押すとここに来る。

            Setallzero()

            BTagingRun.Text = "RUN"
            BTagingRun.BackColor = Color.Transparent
            Panel1.Enabled = True
            TBagingTime.Enabled = True
            SaveSetting("20_750", "Operation_Value", "Aging_status", "STOP")

            ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Blocks

        End If

    End Sub


    Private Sub CpuProgress()

        Dim pc As New System.Diagnostics.PerformanceCounter("Processor", "% Processor Time", "_Total", True)
        Dim usage(8) As Single
        Dim i As Integer = 0
        Dim heikin As Double

        Do While CalCancel = False

            If (pc IsNot Nothing) Then
                usage(i) = pc.NextValue()
                i += 1
                If i = 8 Then
                    i = 0
                End If
            End If

            heikin = usage(0) + usage(1) + usage(2) + usage(3) _
            + usage(4) + usage(5) + usage(6) + usage(7)

            ProgressBar3.Value = heikin / 8
            Application.DoEvents()

            Thread.Sleep(100)
        Loop

    End Sub

#If 0 Then  'どこからも参照されていない？     D_TEST
    Private Sub Label141_Click(sender As Object, e As EventArgs) Handles Label141.Click

    End Sub
#End If


    'DAC/ADCのCAL値を 0x06 コマンドでLMIGから取得する
    '取得したCAL値を整数値で保存する
    Private Sub GetCalValues()

        Dim strNline, cmdString As String
        Dim i, dacno, adcno, sumCheck As Long
        Dim gainIndex, ofstIndex As Int16
        'Dim pArray() As String

        strNline = myRS232.NewLine                   'NewLineを取得
        strNline = strNline.Replace(vbLf, vbCr)          '文字中のLFをCRに置換する場合

        myRS232.NewLine = strNline                   '置換したデリミタをNewLineに格納
        myRS232.ReadTimeout = 1000                   'タイムアウト 1000msec
        myRS232.WriteTimeout = 1000                  '

        'コマンド組み立てとsumcheck
        'DACの補正値　取得
        '0x06コマンドのパラメータ　DACは、0x01から0x0E　奇数がGAIN
        gainIndex = 0
        ofstIndex = 0
        ReceivedData = " "
        For dacno = 1 To &HE                    'GAIN->OFFSET->GAIN->OFFSETの順......
            sumCheck = 0
            cmdString = "~ 00 06 "
            cmdString += dacno.ToString("X2")   'Sub Command
            cmdString += " "
            For i = 1 To cmdString.Length - 1
                sumCheck += Asc(cmdString(i))
            Next

            Dim CkAA As Byte = Math.Truncate((sumCheck / 2 ^ 4)) And &HF
            Dim CkBB As Byte = sumCheck And &HF
            cmdString += CkAA.ToString("X") + CkBB.ToString("X") ' + vbCr

            Try
                myRS232.WriteLine(cmdString) '送信
            Catch ex As Exception
                MessageBox.Show(ex.Message, "CAL値取得　送信 エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            Try
                ReceivedData = myRS232.ReadLine     '受信
            Catch ex As Exception
                ReceivedData = ex.Message
                MessageBox.Show(ex.Message, "CAL値取得　受信 エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            Dim pArray() As String = ReceivedData.Split(" ")

            If dacno Mod 2 Then                 'DACはADCのGAIN/OFFSET と逆です。DACは奇数がGAIN
                'May be GAIN
                Console.WriteLine(pArray(3))
                DacGainCalValues(gainIndex) = Integer.Parse(pArray(3))
                gainIndex += 1
            Else
                'May be OFFSET
                Console.WriteLine(pArray(3))
                DacOfstCalValues(ofstIndex) = Integer.Parse(pArray(3))
                ofstIndex += 1
            End If
        Next


        'ADCの補正値　取得
        '0x06コマンドのパラメータ　ADCは、0x10から0x2D 偶数がGAIN
        gainIndex = 0
        ofstIndex = 0
        For adcno = &H10 To &H2D                    'GAIN->OFFSET->GAIN->OFFSETの順......
            sumCheck = 0
            cmdString = "~ 00 06 "
            cmdString += adcno.ToString("X2")   'Sub Command
            cmdString += " "
            For i = 1 To cmdString.Length - 1
                sumCheck += Asc(cmdString(i))
            Next

            Dim CkAA As Byte = Math.Truncate((sumCheck / 2 ^ 4)) And &HF
            Dim CkBB As Byte = sumCheck And &HF
            cmdString += CkAA.ToString("X") + CkBB.ToString("X") ' + vbCr

            Try
                myRS232.WriteLine(cmdString) '送信
            Catch ex As Exception
                MessageBox.Show(ex.Message, "送信 エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            Try
                ReceivedData = myRS232.ReadLine     '受信
            Catch ex As Exception
                ReceivedData = ex.Message
                MessageBox.Show(ex.Message, "受信 エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            Dim pArray() As String = ReceivedData.Split(" ")

            If adcno Mod 2 Then             'ADCはDACのGAIN/OFFSET の逆です。ADCは奇数がOFFSET
                'May be OFFSET
                Console.WriteLine(pArray(3))
                AdcOfstCalValues(ofstIndex) = Integer.Parse(pArray(3))
                ofstIndex += 1
            Else
                'May be GAIN
                Console.WriteLine(pArray(3))
                AdcGainCalValues(gainIndex) = Integer.Parse(pArray(3))
                gainIndex += 1
            End If
        Next

    End Sub


    'GetCalValues()で求めたCAL値をそれぞれのTextBoxへ表示する
    Private Sub SetEachCalTextBox()
        '個別にTextBoxへ代入する以外方法はない.......


    End Sub

End Class


Public Class HVProbe
    Public Property HV10kV As Double
    Public Property HV20kV As Double
    Public Property HV30kV As Double
    Public Property HV40kV As Double

End Class

Public Class PrePotting
    <XmlElement("StatusTests")> Public Property StatusTests As List(Of StatusTests)
    <XmlElement("P24VSupplies")> Public Property P24VSupplies As List(Of P24VSupplies)
    <XmlElement("P25VFloat")> Public Property P25VFloat As List(Of P25VFloat)
    <XmlElement("P15VFloat")> Public Property P15VFloat As List(Of P15VFloat)
    <XmlElement("Heater")> Public Property Heater As List(Of Heater)
    <XmlElement("Suppressor")> Public Property Suppressor As List(Of Suppressor)
    <XmlElement("Extractor")> Public Property Extractor As List(Of Extractor)
    <XmlElement("Beam")> Public Property Beam As List(Of Beam)
    <XmlElement("L1")> Public Property L1 As List(Of L1)
    <XmlElement("L2")> Public Property L2 As List(Of L2)
End Class

Public Class jcPrePotting   ' JSON用のclass定義　うまく読み込めないのでペンディング
    Public Property StatusTests As StatusTests()
    Public Property P24VSupplies As P24VSupplies()
    '    Public Property P25VFloat As P25VFloat()
    '    Public Property P15VFloat As P15VFloat()
    '    Public Property Heater As Heater()
    '    Public Property Suppressor As Suppressor()
    '    Public Property Extractor As Extractor()
End Class

Public Class StatusTests
    Public Property FanLowlim As Single
    Public Property FanHilim As Single
End Class

Public Class P24VSupplies
    Public Property HeaterLowlim As Single
    Public Property HeaterHilim As Single
    Public Property FloatLowlim As Single
    Public Property FloatHilim As Single
    Public Property BeamLowlim As Single
    Public Property BeamHilim As Single
    Public Property L1Lowlim As Single
    Public Property L1Hilim As Single
    Public Property L2Lowlim As Single
    Public Property L2Hilim As Single
End Class

Public Class P25VFloat
    Public Property Lowlim As Single
    Public Property Hilim As Single
End Class

Public Class P15VFloat
    Public Property Lowlim As Single
    Public Property Hilim As Single
End Class

Public Class Heater
    <XmlAttribute> Public Property name As String
    'Public Property name As String
    Public Property Isetting As Single
    Public Property ILowlim As Single
    Public Property IHilim As Single
    Public Property VLowlim As Single
    Public Property VHilim As Single
    Public Property Wait As Single
    Public Property CheckCount As Single
End Class

Public Class Suppressor
    <XmlAttribute> Public Property name As String
    'Public Property name As String
    Public Property Vsetting As Single
    Public Property VLowlim As Single
    Public Property VHilim As Single
    Public Property ILowlim As Single
    Public Property IHilim As Single
    Public Property EmiLowlim As Single
    Public Property EmiHilim As Single
    Public Property Wait As Single
    Public Property CheckCount As Single
End Class

Public Class Extractor
    <XmlAttribute> Public Property name As String
    'Public Property name As String
    Public Property Vsetting As Single
    Public Property Isetting As Single
    Public Property VLowlim As Single
    Public Property VHilim As Single
    Public Property ILowlim As Single
    Public Property IHilim As Single
    Public Property EmiLowlim As Single
    Public Property EmiHilim As Single
    Public Property Wait As Single
    Public Property CheckCount As Single
End Class

Public Class Beam
    <XmlAttribute> Public Property name As String
    'Public Property name As String
    Public Property Vsetting As Single
    Public Property VLowlim As Single
    Public Property VHilim As Single
    Public Property ILowlim As Single
    Public Property IHilim As Single
    Public Property EmiLowlim As Single
    Public Property EmiHilim As Single
    Public Property Wait As Single
End Class

Public Class L1
    <XmlAttribute> Public Property name As String
    'Public Property name As String
    Public Property Vsetting As Single
    Public Property VLowlim As Single
    Public Property VHilim As Single
    Public Property ILowlim As Single
    Public Property IHilim As Single
    Public Property Wait As Single
End Class

Public Class L2
    <XmlAttribute> Public Property name As String
    'Public Property name As String
    Public Property Vsetting As Single
    Public Property VLowlim As Single
    Public Property VHilim As Single
    Public Property ILowlim As Single
    Public Property IHilim As Single
    Public Property Wait As Single
End Class



Public Class listAging
    <XmlElement("Aging")> Public Property Aging As List(Of Aging)
End Class


Public Class Aging
    <XmlAttribute> Public Property name As String
    Public Property BeamV As Single
    Public Property SuppV As Single
    Public Property ExtrV As Single
    Public Property HeatA As Single
    Public Property L1V As Single
    Public Property L2V As Single
    Public Property TimeHour As Single
End Class

'Public Class FinalAging
'   Public Property BeamV As Single
'   Public Property SuppV As Single
'   Public Property ExtrV As Single
'   Public Property HeatA As Single
'   Public Property L1V As Single
'   Public Property L2V As Single
'End Class



Public Enum DacGainItems
    DAC_BEAMPS_GAIN = 0
    DAC_LENS1PS_P_GAIN
    DAC_LENS1PS_M_GAIN
    DAC_LENS2PS_GAIN
    DAC_SUPPS_GAIN
    DAC_EXTPS_GAIN
    DAC_HEATERPS_GAIN
    MAX_OF_DAC_GAIN_ITEMS
End Enum

Public Enum DacOfstItems
    DAC_BEAMPS_OFST = 0
    DAC_LENS1PS_P_OFST
    DAC_LENS1PS_M_OFST
    DAC_LENS2PS_OFST
    DAC_SUPPS_OFST
    DAC_EXTPS_OFST
    DAC_HEATERPS_OFST
    MAX_OF_DAC_OFST_ITEMS
End Enum

Public Enum AdcGainItems
    ADC_BEAMPS_V_GAIN = 0
    ADC_BEAMPS_I_GAIN
    ADC_LENS1PS_V_GAIN_P
    ADC_LENS1PS_V_GAIN_M
    ADC_LENS1PS_I_GAIN_P
    ADC_LENS1PS_I_GAIN_M
    ADC_LENS2PS_V_GAIN
    ADC_LENS2PS_I_GAIN
    ADC_SUPPS_V_GAIN
    ADC_SUPPS_I_GAIN
    ADC_EXTPS_V_GAIN
    ADC_EXTPS_I_GAIN
    ADC_HEATERPS_V_GAIN
    ADC_HEATERPS_I_GAIN
    ADC_EMISSION_GAIN
    MAX_OF_ADC_GAIN_ITEMS
End Enum

Public Enum AdcOfstItems
    ADC_BEAMPS_V_OFST = 0
    ADC_BEAMPS_I_OFST
    ADC_LENS1PS_V_OFST_P
    ADC_LENS1PS_V_OFST_M
    ADC_LENS1PS_I_OFST_P
    ADC_LENS1PS_I_OFST_M
    ADC_LENS2PS_V_OFST
    ADC_LENS2PS_I_OFST
    ADC_SUPPS_V_OFST
    ADC_SUPPS_I_OFST
    ADC_EXTPS_V_OFST
    ADC_EXTPS_I_OFST
    ADC_HEATERPS_V_OFST
    ADC_HEATERPS_I_OFST
    ADC_EMISSION_OFST
    MAX_OF_ADC_OFST_ITEMS
End Enum

