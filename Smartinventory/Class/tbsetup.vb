Imports System.Data.SqlClient
Public Class tbsetup
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Public Function updatesetup(nexpaydate As Integer, remindpaydate As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("update tbsetup set nextpaydate='" & nexpaydate & "', remindpaydate='" & remindpaydate & "' where setupid=1", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function Call_setup(dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from tbsetup", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
