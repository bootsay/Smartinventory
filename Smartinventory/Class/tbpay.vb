Imports System.Data.SqlClient
Public Class tbpay
    Dim cn As New connectdb
    Dim cm As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim re As SqlDataReader
    Public Function deletepay(saleno As String)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbpay where saleNO='" & saleno & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function select_viewpay(saleno As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewpay where saleNO='" & saleno & "' order by pay_id asc", cn.conn)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function count_pay(saleID As String)
        Dim count As Integer
        cm = New SqlCommand("select top 1 paycount from tbpay where saleNO='" & saleID & "' order by paycount desc", cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            While re.Read
                count = re.GetValue(0) + 1
            End While
        Else
            count = 1
        End If
        re.Close()
        Return count
    End Function

End Class
