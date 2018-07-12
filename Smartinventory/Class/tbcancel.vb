Imports System.Data.SqlClient
Public Class tbcancel
    Dim cm As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Public Function runid_cancelstockout()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 stockout_cancelid from tbstockcanceldate order by stockout_cancelid desc", cn.conn)
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

    Public Function savestockoutcancel(id As Integer, stockoutno As String, dt As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbstockoutcanceldate values('" & id & "','" & stockoutno & "','" & dt & "')", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
