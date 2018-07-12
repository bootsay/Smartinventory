'Imports System.Data.SqlClient
''Public Class tbemployee
'Dim cn As New connectdb
'Dim da As New SqlDataAdapter
'Dim ds As New DataSet
'Dim cm As New SqlCommand
'Dim re As SqlDataReader
'Public Function runid()
'    cn.connect()
'    Dim id As Integer
'    Try
'        cm = New SqlCommand("select top 1 employee_id from tbemployee order by employee_id desc", cn.conn)
'        re = cm.ExecuteReader
'        If re.HasRows Then
'            While re.Read
'                id = re.GetValue(0).ToString + 1
'            End While
'        Else
'            id = 1
'        End If
'    Catch ex As Exception
'        MessageBox.Show(ex.Message)
'    End Try
'    re.Close()
'    Return id
'End Function
'Public Function save(employee_id As Integer, employeename As String, department_id As Integer, position As String)
'    cn.connect()
'    Try
'        cm = New SqlCommand("insert into tbemployee values('" & employee_id & "',N'" & employeename & "','" & department_id & "',N'" & position & "')", cn.conn)
'        If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
'            cm.ExecuteNonQuery()
'        Else

'        End If

'    Catch ex As Exception
'        MessageBox.Show(ex.Message)
'    End Try
'    Return True
'End Function

'Public Function update(employee_id As Integer, employeename As String, department_id As Integer, position As String)
'    cn.connect()
'    Try
'        cm = New SqlCommand("update tbemployee set employeename=N'" & employeename & "',department_id='" & department_id & "',position=N'" & position & "' where employee_id='" & employee_id & "'", cn.conn)
'        If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
'            cm.ExecuteNonQuery()
'        Else

'        End If
'    Catch ex As Exception
'        MessageBox.Show(ex.Message)
'    End Try
'    Return True
'End Function
'Public Function delete(employee_id As Integer)
'    cn.connect()
'    Try
'        cm = New SqlCommand("delete from tbemployee where employee_id='" & employee_id & "'", cn.conn)
'        If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
'            cm.ExecuteNonQuery()
'        Else

'        End If
'    Catch ex As Exception
'        MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'    End Try
'    Return True
'End Function
'Public Function loademployee_all(dgv As DataGridView)
'    cn.connect()
'    Try
'        da = New SqlDataAdapter("select * from viewemployee order by employee_id asc", cn.conn)
'        da.Fill(ds, "pt")
'        ds.Tables.Clear()
'        da.Fill(ds, "pt")
'        dgv.DataSource = ds.Tables(0)
'        formatdgv(dgv)

'    Catch ex As Exception

'    End Try
'    Return True
'End Function
'Public Function loademployee(catename As String, dgv As DataGridView)
'    cn.connect()
'    Try
'        da = New SqlDataAdapter("select * from viewemployee where employeename like N'%" & catename & "%' order by employee_id asc", cn.conn)
'        da.Fill(ds, "pt")
'        ds.Tables.Clear()
'        da.Fill(ds, "pt")
'        dgv.DataSource = ds.Tables(0)
'        formatdgv(dgv)

'    Catch ex As Exception

'    End Try
'    Return True
'End Function
'Public Function formatdgv(dgv As DataGridView)
'    cn.connect()
'    Try
'        da = New SqlDataAdapter("select * from viewemployee order by employee_id asc", cn.conn)
'        da.Fill(ds, "pt")
'        ds.Tables.Clear()
'        da.Fill(ds, "pt")
'        dgv.DataSource = ds.Tables(0)
'        dgv.Refresh()
'        With dgv
'            .Columns(0).HeaderText = "ລະຫັດ"
'            .Columns(1).HeaderText = "ຊື່ ແລະ ນາມສະກຸນ"
'            .Columns(2).HeaderText = "ພະແນກທີສັງກັດ"
'            .Columns(3).HeaderText = "ຕໍ່າແໜ່ງ"

'            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
'            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
'            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
'            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
'        End With

'    Catch ex As Exception
'        MessageBox.Show(ex.Message)
'    End Try
'    Return True
'End Function
'End Class
