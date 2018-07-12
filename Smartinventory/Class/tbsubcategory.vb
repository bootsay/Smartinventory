Imports System.Data.SqlClient
Public Class tbsubcategory
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(id As Integer, cate_id As Integer, prefix As String, name As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbsubcategory values('" & id & "','" & cate_id & "',N'" & prefix & "',N'" & name & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(cate_id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbsubcategory where subid='" & cate_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function

    Public Function update(id As Integer, cate_id As Integer, prefix As String, name As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbsubcategory set cateID=N'" & cate_id & "',prefix=N'" & prefix & "',subname=N'" & name & "' where subid='" & id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 subid from tbsubcategory order by subid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0).ToString + 1
                End While
            Else
                id = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        re.Close()
        Return id
    End Function

    Public Function loadtbcategory(catename As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsubcategory where catename like N'%" & catename & "%' order by catename asc", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            formatdgv(dgv)
          
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function formatdgv(dgv As DataGridView)
        With dgv
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ປະເພດຫລັກ"
            .Columns(2).HeaderText = "ຄໍານໍາໜ້າ"
            .Columns(3).HeaderText = "ປະເພດຍ່ອຍ"
            .Columns(4).Visible = False

            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End With

        Return True
    End Function
    Public Function combocategory(id As Integer, cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbsubcategory where cateID='" & id & "'", cn.conn)
            da.Fill(dt)
            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("subname").ToString
                .ValueMember = dt.Columns("subid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function combosubcate(cb As ComboBox)
        cn.connect()
        Dim dt1 As New DataTable

        'Try
        da = New SqlDataAdapter("select subid, catename, subname, tbcategory.cateID from tbsubcategory inner join tbcategory on  tbsubcategory.cateID = tbcategory.cateID order by tbsubcategory.subid asc ", cn.conn)
        da.Fill(dt1)
        dt1.Rows.Add("0", "-ທັງໜົດ-")
        With cb
            .DataSource = dt1
            .DisplayMember = dt1.Columns("subname").ToString
            .ValueMember = dt1.Columns("subid").ToString
        End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function

    Public Function combopaytype(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select top 2 * from tbpaytype order by pay_id asc", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("payname").ToString
                .ValueMember = dt.Columns("pay_id").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Check_duplicate_prefix(prefix As String)
        cn.connect()
        Dim prefix1 As String = Nothing
        Try
            cm = New SqlCommand("select prefix from tbsubcategory where prefix='" & prefix & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        prefix1 = "False"
                    Else
                        prefix1 = "True"
                    End If
                End While
            Else
                prefix1 = "False"
            End If
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return prefix1
    End Function
    Public Function Call_prefix(subcateid As Integer)
        cn.connect()
        Dim prefix As String = Nothing
        Try
            cm = New SqlCommand("select prefix from tbsubcategory where subid='" & subcateid & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        prefix = ""
                    Else
                        prefix = re.GetValue(0)
                    End If

                End While
            Else
                prefix = ""
            End If
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return prefix
    End Function
End Class
