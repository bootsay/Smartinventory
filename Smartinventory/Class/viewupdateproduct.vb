Imports System.Data.SqlClient

Public Class viewupdateproduct
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim cm As New SqlCommand
    Dim ds As New DataSet
    Public Function selectviewupdate(dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewupdateproduct", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
