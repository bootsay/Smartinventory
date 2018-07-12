Imports System.Data.SqlClient
Public Class tbpayorder
    Dim cn As New connectdb
    Dim cm As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim re As SqlDataReader
    Public Function deletepay(saleno As String)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbpayorder where orderNO='" & saleno & "'", cn.conn)
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
            da = New SqlDataAdapter("select * from viewpayorder where orderNO='" & saleno & "' order by paycount asc", cn.conn)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function count_pay(saleID As String)
        Dim count As Integer
        cm = New SqlCommand("select top 1 paycount from tbpayorder where orderNO='" & saleID & "' order by paycount desc", cn.conn)
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
    Public Function savepayorder(saleid As String, todaypay As Double, paydate As String, moneynotpay As Double, nextpaydate As String, statusid As Integer, paycount As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbpayorder(orderNO,todaypay,paydate,moneynotpay,nextpaydate,statusid,paycount) values('" & saleid & "','" & todaypay & "', '" & paydate & "','" & moneynotpay & "','" & nextpaydate & "','" & statusid & "','" & paycount & "')", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function delete_orderpay(id As String)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbpayorder where orderNO='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
