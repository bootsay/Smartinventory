Imports System.Data.SqlClient
Public Class tbsetmoney
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Public Function check_existid()
        Dim id As Integer
        cn.connect()
        Try
            cm = New SqlCommand("select count(mainmoneyid) as dd from tbmainmoney", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        id = 0
                    Else
                        id = re.GetValue(0)
                    End If
                End While
            Else
                id = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception

        End Try
        Return id
    End Function
    Public Function savemainmoney(id As Integer, money As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbmainmoney values('" & id & "',N'" & money & "')", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function update(id As Integer, money As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbmainmoney set mainmoney=N'" & money & "' where mainmoneyid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadmainmoney(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbmainmoney", cn.conn)
            da.Fill(ds, "dd")
            ds.Tables.Clear()
            da.Fill(ds, "dd")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ເງີນ"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function select_mainmoney(dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from tbmainmoney", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Call_mainmoney()
        Dim mm As String = Nothing
        cn.connect()
        Try
            cm = New SqlCommand("select top 1 mainmoney from tbmainmoney order by mainmoneyid asc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        mm = ""
                    Else
                        mm = re.GetValue(0)
                    End If
                End While
            Else
                mm = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return mm
    End Function
End Class
