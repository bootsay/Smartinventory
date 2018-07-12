Imports System.Data.SqlClient
Public Class tbapprovedate
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Public Function call_saleapprovedate(saleNO As String)
        cn.connect()
        Dim dt As String = Nothing
        Try
            cm = New SqlCommand("select saleapprovedate from tbsaleapprove where saleNO='" & saleNO & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        dt = ""
                    Else
                        dt = re.GetValue(0)
                    End If
                End While
            Else
                dt = ""
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dt
    End Function
    Public Function runid_saleapprove()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 saleapproveid from tbsaleapprove order by saleapproveid desc", cn.conn)
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
    Public Function save(id As Integer, saleno As String, dt As String, user As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbsaleapprove values('" & id & "','" & saleno & "','" & dt & "','" & user & "')", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function


    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 cateID from tbcategory order by cateID desc", cn.conn)
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

End Class
