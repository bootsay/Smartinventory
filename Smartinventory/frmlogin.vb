Imports System.Data.SqlClient
Public Class frmlogin
    Dim cn As New connectdb
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.WindowState = FormWindowState.Maximized
        Dim dt As String = System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern()
        If dt <> "dd/MM/yyyy" Then
            MessageBox.Show("ກະລະນາປັບວັນທີເດືອນປີໃຫ້ເປັນ dd/MM/yyyy", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If MessageBox.Show("ທ່ານຕ້ອງການອອກຈາກໂປຮແກມແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        cn.connect()
        Dim dt As New DateTimePicker
        dt = New DateTimePicker


        'Dim txtid As New TextBox
        'Dim txtlevel As New TextBox
        Try
            cn.connect()
            cm = New SqlCommand("select * from viewuser where username='" & txtuser.Text & "' and password=@password", cn.conn)
            'cm = New SqlCommand("select * from tbuser where username='" & txtuser.Text & "' and password='" & txtpass.Text & "'", cn.conn)
            cm.Parameters.Add(New SqlParameter("password", txtpassword.Text))
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    frmmain.userid = re.GetValue(0).ToString
                    frmmain.laoname = re.GetValue(2).ToString
                    frmsale.txtsalenameproduct.Text = re.GetValue(2).ToString
                    frmmain.level = re.GetValue(6).ToString
                    frmmain.Show()

                End While
                re.Close()
                cm.Dispose()
                cn.conn.Close()
                Me.Hide()
            Else
                MessageBox.Show("ຊື່ ແລະ ລະຫັດບໍ່ຖືກຕ້ອງ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtpassword.Clear()
                txtpassword.Select()
            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາເດເຊື່ອມຕໍ່ຖານຂໍ້ມູນ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            cn.connect()
            Dim dt As New DateTimePicker
            dt = New DateTimePicker


            'Dim txtid As New TextBox
            'Dim txtlevel As New TextBox
            Try
                cn.connect()
                cm = New SqlCommand("select * from viewuser where username='" & txtuser.Text & "' and password=@password", cn.conn)
                'cm = New SqlCommand("select * from tbuser where username='" & txtuser.Text & "' and password='" & txtpass.Text & "'", cn.conn)
                cm.Parameters.Add(New SqlParameter("password", txtpassword.Text))
                re = cm.ExecuteReader
                If re.HasRows Then
                    While re.Read
                        frmmain.userid = re.GetValue(0).ToString
                        frmmain.laoname = re.GetValue(2).ToString
                        frmsale.txtsalenameproduct.Text = re.GetValue(2).ToString
                        frmmain.level = re.GetValue(6).ToString
                        frmmain.Show()

                    End While
                    re.Close()
                    cm.Dispose()
                    cn.conn.Close()
                    Me.Hide()
                Else
                    MessageBox.Show("ຊື່ ແລະ ລະຫັດບໍ່ຖືກຕ້ອງ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpassword.Clear()
                    txtpassword.Select()
                End If
            Catch ex As Exception
                MessageBox.Show("ບໍ່ສາມາເດເຊື່ອມຕໍ່ຖານຂໍ້ມູນ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    'Private Sub txtuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtuser.KeyPress
    '    Dim tb As TextBox
    '    tb = CType(sender, TextBox)

    '    If Char.IsControl(e.KeyChar) Then
    '        If e.KeyChar.Equals(Chr(Keys.Return)) Then
    '            Me.SelectNextControl(tb, True, True, False, True)
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtuser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuser.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        SendKeys.Send("{TAB}")
    '    Else
    '        Exit Sub
    '    End If
    'End Sub

    Private Sub txtuser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuser.KeyDown
        If e.KeyCode = Keys.Return Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub
End Class