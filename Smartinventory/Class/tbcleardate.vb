Imports System.Data.SqlClient
Public Class tbcleardate
    Dim cm As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cn As New connectdb
    Public Function deletetbpay()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbpay", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletepayorder()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbpayorder", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletesaledetail()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbsaledetail", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletesale()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbsale", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletereceiveorderdetail()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbreceivedetail", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletereceive()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbreceive", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deleteorderdetail()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tborderdetail", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deleteorder()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tborder", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function upatestockqty()
        cn.connect()
        Try
            cm = New SqlCommand("update tbproduct set stockqty=0", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function delete_subitemdetail()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbsalesubitemdetail", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function delete_subitem()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbsalesubitem", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
