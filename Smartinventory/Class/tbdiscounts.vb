Imports System.Data.SqlClient
Public Class tbdiscounts
    Dim cn As New connectdb
    Dim cm As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim re As SqlDataReader

    Public Function save(dis_id As Integer, amount As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbdiscounts(discount_id,disamount)values('" & dis_id & "','" & amount & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return True

    End Function

    Public Function update(dis_id As Integer, amount As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbdiscounts set disamount='" & amount & "' where discount_id='" & dis_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return True
    End Function

    Public Function delete(dis_id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbdiscounts where discount_id='" & dis_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function

    Public Function runid()
        Dim id As Integer
        cn.connect()
        Try
            cm = New SqlCommand("select top 1 discount_id from tbdiscounts order by discount_id desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0).ToString + 1
                End While
            Else
                id = "1"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        re.Close()
        Return id
    End Function

    Public Function loadtbdiscount(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbdiscounts", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ສ່ວນຫຼຸດ"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function combodiscount(cb As ComboBox)
        cn.connect()
        Try
            cm = New SqlCommand("select * from tbdiscounts", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    cb.Items.Add(re(1))
                End While
            End If
        Catch ex As Exception

        End Try
        Return True
    End Function
End Class
