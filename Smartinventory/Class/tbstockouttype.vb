Imports System.Data.SqlClient
Public Class tbstockouttype
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand

    Public Function save(cate_id As Integer, name As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbstockouttype values('" & cate_id & "',N'" & name & "')", cn.conn)
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
            cm = New SqlCommand("delete from tbstockouttype where stockouttypeid='" & cate_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
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
            cm = New SqlCommand("update tbstockouttype set stockouttypename=N'" & name & "' where stockouttypeid='" & cate_id & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 stockouttypeid from tbstockouttype order by stockouttypeid desc", cn.conn)
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

    Public Function loadtbstockouttype(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbstockouttype", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ປະເພດ"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function combostockouttype(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbstockouttype", cn.conn)
            da.Fill(dt)
            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("stockouttypename").ToString
                .ValueMember = dt.Columns("stockouttypeid").ToString
            End With
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function combostockouttype1(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        'Try
        da = New SqlDataAdapter("select * from tbstockouttype order by stockouttypeid desc", cn.conn)
        da.Fill(dt)
        dt.Rows.Add(0, "ທັງໜົດ")
        With cb
            .DataSource = dt
            .DisplayMember = dt.Columns("stockouttypename").ToString
            .ValueMember = dt.Columns("stockouttypeid").ToString
        End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function

End Class
