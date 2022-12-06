Imports System.Windows.Forms

Public Class Dialog4

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = Mid(Main1.Send_RS232("~ 00 78 0C"), 1) + " V"
        TextBox2.Text = Mid(Main1.Send_RS232("~ 00 78 1D"), 1) + " V"
        'TextBox3.Text = Mid(Main1.Send_RS232("~ 00 78 44"), 10, 7) + " V"  'コマンド無い
        TextBox4.Text = Mid(Main1.Send_RS232("~ 00 78 50"), 1) + " V"
        TextBox5.Text = Mid(Main1.Send_RS232("~ 00 78 51"), 1) + " V"
        TextBox6.Text = Mid(Main1.Send_RS232("~ 00 78 52"), 1) + " V"
        TextBox7.Text = Mid(Main1.Send_RS232("~ 00 78 53"), 1) + " V"
        'TextBox8.Text = Mid(Main1.Send_RS232("~ 00 78 54"), 1) + " V"   'エラー出る 未対応
        TextBox9.Text = Mid(Main1.Send_RS232("~ 00 78 55"), 1) + " V"
        TextBox10.Text = Mid(Main1.Send_RS232("~ 00 78 56"), 1) + " V"
        TextBox11.Text = Mid(Main1.Send_RS232("~ 00 78 57"), 1) + " V"
        TextBox12.Text = Mid(Main1.Send_RS232("~ 00 78 81"), 1) + " V"
        TextBox13.Text = Mid(Main1.Send_RS232("~ 00 78 82"), 1) + " C"
        TextBox14.Text = Mid(Main1.Send_RS232("~ 00 78 83"), 1) + " V"
        TextBox15.Text = Mid(Main1.Send_RS232("~ 00 78 84"), 1) + " V"
        TextBox17.Text = Mid(Main1.Send_RS232("~ 00 78 58"), 1) + "V"   'エラー出る－＞OKになった

        Dim strRPM As String = Main1.Send_RS232("~ 00 84", True)

        If strRPM IsNot "" Then
            Dim arrRPM() As String = strRPM.Split(" ")

            TextBox16.Text = arrRPM(3) + " rpm"
            TextBox19.Text = arrRPM(4) + " rpm"
        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strRTN As String
        Dim status_return As Integer
        'Main1.Send_RS232("~ 00 82")
        '        status_return = Convert.ToInt16(Mid(Main1.Send_RS232("~ 00 82"), 10, 1))
        strRTN = Main1.Send_RS232("~ 00 82")
        If strRTN IsNot "" Then
            status_return = Convert.ToInt32(strRTN, 16)
            TextBox18.Text = "0x" + strRTN
        Else
            TextBox18.Text = ""
        End If

        CBox0.Checked = False
        CBox1.Checked = False
        CBox2.Checked = False
        CBox3.Checked = False
        CBox4.Checked = False
        CBox5.Checked = False
        CBox6.Checked = False
        CBox7.Checked = False
        CBox8.Checked = False
        CBox9.Checked = False
        CBox10.Checked = False
        CBox11.Checked = False
        CBox12.Checked = False
        CBox13.Checked = False
        CBox14.Checked = False
        CBox15.Checked = False

        If status_return And &H1 Then   ' RUN OK
            CBox0.Checked = True
        End If
        If status_return And &H2 Then   ' Time OUT
            CBox1.Checked = True
        End If
        If status_return And &H4 Then   ' Float PS Err 
            CBox2.Checked = True
        End If
        If status_return And &H8 Then   ' Heater PS Err
            CBox3.Checked = True
        End If
        If status_return And &H10 Then  ' WATCHDOG_ERR
            CBox4.Checked = True
        End If
        If status_return And &H20 Then  ' GUN_ON
            CBox5.Checked = True
        End If
        If status_return And &H40 Then  '
            CBox6.Checked = True
        End If
        If status_return And &H80 Then  '
            CBox7.Checked = True
        End If
        If status_return And &H100 Then '
            CBox8.Checked = True
        End If
        If status_return And &H200 Then '
            CBox9.Checked = True
        End If
        If status_return And &H400 Then ' InerLock Err
            CBox10.Checked = True
        End If
        If status_return And &H800 Then ' phi internal Comm Err / 
            CBox11.Checked = True
        End If
        If status_return And &H1000 Then ' phi Lached Vac InterLock Err / 
            CBox12.Checked = True
        End If
        If status_return And &H2000 Then    '
            CBox13.Checked = True
        End If
        If status_return And &H4000 Then    'ulvac Rom Read Err
            CBox14.Checked = True
        End If
        If status_return And &H8000 Then    'ulvac Emergency stop state
            CBox15.Checked = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main1.Send_RS232("~ 00 83")
        'Button1.PerformClick()
    End Sub


End Class
