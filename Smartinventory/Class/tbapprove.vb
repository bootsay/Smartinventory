Imports System.Data.SqlClient
Public Class tbapprove
    Dim cm As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Public Function saveapprovesale(saleNO As String, dt As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbsaleapprove(saleNO,saleapprovedate)values('" & saleNO & "','" & dt & "')", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function delete(id As String)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbsaleapprove where saleNO='" & id & "'", cn.conn)
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
    Public Function savereceivestockoutback(id As Integer, stockNO As String, dt As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbstockreceivedate values('" & id & "','" & stockNO & "','" & dt & "')", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function runid_stockoutreceive()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 stockout_receiveid from tbstockreceivedate order by stockout_receiveid desc", cn.conn)
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
End Class
