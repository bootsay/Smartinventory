Imports System.Data.SqlClient
Public Class tbuser
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Public Function save(id As Integer, username As String, laoname As String, department As String, position As String, password As String, autority As Integer, auth As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbuser values('" & id & "', N'" & username & "',N'" & laoname & "', N'" & department & "', N'" & position & "', '" & password & "', N'" & autority & "','" & auth & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function update(user_id As Integer, username As String, laoname As String, department As String, position As String, password As String, autority As Integer, auth As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbuser set username=N'" & username & "',laoname=N'" & laoname & "', department=N'" & department & "', position=N'" & position & "', password='" & password & "', level_id='" & autority & "', auth='" & auth & "' where user_id='" & user_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function delete(user_id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbuser where user_id='" & user_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loaduser(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewuser", cn.conn)
            da.Fill(ds, "user")
            ds.Tables.Clear()
            da.Fill(ds, "user")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ຊຶ່ເຂົ້າລະບົບ"
                .Columns(2).HeaderText = "ຊື່ພາສາລາວ"
                .Columns(3).HeaderText = "ພະແນກ"
                .Columns(4).HeaderText = "ຕໍາແໜ່ງ"
                .Columns(5).HeaderText = "ລະຫັດ"
                .Columns(6).HeaderText = "ສິດທິ"
                .Columns(7).Visible = False
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function runid()
        Dim idd As Integer = Nothing
        cn.connect()
        Try
            cm = New SqlCommand("select top 1 user_id from tbuser order by user_id desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    idd = re.GetValue(0) + 1
                End While
            Else
                idd = 1001
            End If
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return idd
    End Function
    Public Function combolevel(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tblevel", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("levelname").ToString
                .ValueMember = dt.Columns("level_id").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function updateauth(id As Integer, auth As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbuser set auth='" & auth & "' where user_id='" & id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງສິດທິຂອງຜູ້ໃຊ້ແທ້ບໍ່ ?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function user_auth(id As Integer)
        Dim auth As String = Nothing
        cn.connect()
        'Try
        cm = New SqlCommand("select auth from tbuser where user_id='" & id & "'", cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            While re.Read
                auth = re.GetValue(0)
            End While

        End If
        re.Close()
        cm.Dispose()
        cn.conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return auth
    End Function
    Public Function check_userduplicatename(name As String)
        cn.connect()
        Dim duplicatename As String = Nothing
        Try
            cm = New SqlCommand("select username frm tbuser where username='" & name & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    duplicatename = "True"
                End While
            Else
                duplicatename = "False"
            End If
        Catch ex As Exception

        End Try
        Return duplicatename
    End Function

End Class
