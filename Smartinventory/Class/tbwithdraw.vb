Imports System.Data.SqlClient
Public Class tbwithdraw
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim cm As New SqlCommand
    Dim ds As New DataSet
    Dim re As SqlDataReader
    Public Function Call_backtotalpayback(accountid As Integer, dt1 As String)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(totalpay) as pay from tbwithdraw where accountid='" & accountid & "' and datewithdraw>='" & dt1 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        total = 0
                    Else
                        total = re.GetValue(0)
                    End If
                End While
            Else
                total = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return total
    End Function
    Public Function sum_paymoney(accountid As Integer, dt1 As String, dt2 As String)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(totalpay) as pay from tbwithdraw where accountid='" & accountid & "' and datewithdraw>='" & dt1 & "' and datewithdraw<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        total = 0
                    Else
                        total = re.GetValue(0)
                    End If
                End While
            Else
                total = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return total
    End Function
    Public Function sum_paymoney_nodate(accountid As Integer)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(totalpay) as pay from tbwithdraw where accountid='" & accountid & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        total = 0
                    Else
                        total = re.GetValue(0)
                    End If
                End While
            Else
                total = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return total
    End Function
    Public Function sum_receivemoney(accountid As Integer, dt1 As String, dt2 As String)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(totalreceive) as pay from tbwithdraw where accountid='" & accountid & "' and datewithdraw>='" & dt1 & "' and datewithdraw<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        total = 0
                    Else
                        total = re.GetValue(0)
                    End If
                End While
            Else
                total = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return total
    End Function
    Public Function sum_receivemoney_nodate(accountid As Integer)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(totalreceive) as pay from tbwithdraw where accountid='" & accountid & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        total = 0
                    Else
                        total = re.GetValue(0)
                    End If
                End While
            Else
                total = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return total
    End Function
    Public Function check_existwithdrawNO(id As String)
        cn.connect()
        Dim idd As Integer
        Try
            cm = New SqlCommand("select count(withdrawid) as count from tbwithdraw where withdrawid='" & id & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        idd = 0
                    Else
                        idd = re.GetValue(0)
                    End If
                End While
            Else
                idd = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return idd
    End Function
    Public Function summoneyin(accountid As Integer, dt1 As String, dt2 As String)
        cn.connect()
        Try
            'cm = New SqlCommand("select sum(capitaltotal) as total from tbcapitalmoney where inputdate>='" &")
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function savewithdraw(id As Integer, userid As Integer, accountid As Integer, sourcedid As Integer, payperson As String, receivepay As String, totalpay As Double, totalreceive As Double, totalremind As Double, des As String, status As String, dt As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbwithdraw values('" & id & "','" & userid & "', '" & accountid & "', '" & sourcedid & "',N'" & payperson & "',N'" & receivepay & "','" & totalpay & "','" & totalreceive & "','" & totalremind & "','" & des & "',N'" & status & "','" & dt & "')", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function updatewithdraw(id As Integer, userid As Integer, accountid As Integer, sourcedid As Integer, payperson As String, receivepay As String, totalpay As Double, totalreceive As Double, totalremind As Double, des As String, status As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbwithdraw set user_id='" & userid & "', accountid='" & accountid & "',  sourceid='" & sourcedid & "', personpay='" & payperson & "',personreceive=N'" & receivepay & "', totalpay='" & totalpay & "',totalreceive='" & totalreceive & "', totalremind='" & totalremind & "', des=N'" & des & "', status=N'" & status & "' withid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbwithdraw where withid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function withdrawNO()
        Dim id As String = Nothing
        Dim prefix As String = ""
        Dim length As Integer = 5
        Dim inorder As Integer
        Dim d As String = Today.Date.Day
        Dim m As String = Today.Month
        Dim a As New DateTimePicker
        Dim y As String = Today.Year
        'y = Format(CDate(a.Value.Year.ToString()), "yy")
        Try
            cn.connect()
            cm = New SqlCommand("select top 1 withid from tbwithdraw order by withid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    inorder = re.GetValue(0) + 1
                End While
            Else
                inorder = 1
            End If
            id = inorder
            id = String.Format("{0}{1}-" & m & "" & y & "WTS", prefix, inorder.ToString().PadLeft(length, "0"))
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 withid from tbwithdraw order by withid desc", cn.conn)
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
    Public Function viewwithdraw(accountid As Integer, dgv As DataGridView, dt1 As String, dt2 As String, status As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewwithdraw where accountid='" & accountid & "' and datewithdraw>='" & dt1 & "' and datewithdraw<='" & dt2 & "' and status like N'%" & status & "%' order by withid asc", cn.conn)
            da.Fill(ds, "dd")
            ds.Tables.Clear()
            da.Fill(ds, "dd")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ຜູ້ບັນທຶກ"
                .Columns(2).HeaderText = "ບັນຊີຫລັກ"
                .Columns(3).HeaderText = "ບັນຊີຍ່ອຍ"
                .Columns(4).HeaderText = "ຈ່າຍ"
                .Columns(5).HeaderText = "ຮັບ"
                .Columns(6).HeaderText = "ຍອດຍັງຫລືອ"
                .Columns(7).HeaderText = "ຜູ້ຈ່າຍ"
                .Columns(8).HeaderText = "ຜູ້ຮັບ"
                .Columns(9).HeaderText = "ລາຍລະອຽດ"
                .Columns(10).HeaderText = "ວັນທີ"
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(4).DefaultCellStyle.Format = "N0"
                .Columns(5).DefaultCellStyle.Format = "N0"
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
