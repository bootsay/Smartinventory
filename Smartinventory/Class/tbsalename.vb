Imports System.Data.SqlClient
Public Class tbsalename
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand

    Public Function save(cate_id As Integer, name As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbsalename values('" & cate_id & "',N'" & name & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
                cn.conn.Close()
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
            cm = New SqlCommand("delete from tbsalename where salenameid='" & cate_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
                cm.Dispose()
                cn.conn.Close()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function

    Public Function update(cate_id As Integer, name As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbsalename set salename=N'" & name & "' where salenameid='" & cate_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
                cm.Dispose()
                cn.conn.Close()
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
            cm = New SqlCommand("select top 1 salenameid from tbsalename order by salenameid desc", cn.conn)
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
        cm.Dispose()
        cn.conn.Close()
        Return id
    End Function

    Public Function loadtbcategory(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbsalename", cn.conn)
            da.Fill(ds, "pt1")
            ds.Tables.Clear()
            da.Fill(ds, "pt1")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ຊື່ຜູ້ຂາຍ"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function combosalename(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbsalename", cn.conn)
            da.Fill(dt)
            dt.Rows.Add("0", "-ຜູ້ຂາຍທັງໜົດ-")
            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("salename").ToString
                .ValueMember = dt.Columns("salenameid").ToString
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
