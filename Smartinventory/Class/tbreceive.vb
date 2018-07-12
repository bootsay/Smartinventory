Imports System.Data.SqlClient
Public Class tbreceive
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function call_startstock()
        cn.connect()
        Dim a As String = Nothing
        Try
            cm = New SqlCommand("select top 1 receive_date from viewreceivedetail order by receivedetailid asc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    a = re.GetValue(0)
                End While
            Else
                a = Today.Date
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return a
    End Function
    Public Function runreceiveautoid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 receiveautoid from tbreceive order by receiveautoid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0) + 1
                End While
            Else
                id = 1
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function

    Public Function runreceivedetailautoid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 receivedetailid from tbreceivedetail order by receivedetailid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0) + 1
                End While
            Else
                id = 1
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function runreceiveNO()
        Dim y As String
        Dim years As New DateTimePicker

        y = years.Value.Year

        Dim m As String
        Dim month As New DateTimePicker
        m = month.Value.Month

        Dim d As String
        Dim day As New DateTimePicker
        d = day.Value.Day
        Dim w As String
        w = "WTS"
        'MessageBox.Show(a)
        Dim strseqno As String
        Dim strprefix = ""
        Dim lengs = 5
        Dim intsequence = 0
        cn.connect()
        Dim str As String = "select top 1 receiveautoid from tbreceive order by receiveautoid desc"
        cm = New SqlCommand(str, cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            re.Read()
            intsequence = Convert.ToInt32(re("receiveautoid") + 1)
        Else
            intsequence = 1
        End If
        strseqno = intsequence
        strseqno = String.Format("{0}{1}-R" & m & "" & y & "" & w & "", strprefix, intsequence.ToString().PadLeft(lengs, "0"))
        re.Close()
        cm.Dispose()
        cn.conn.Close()
        Return strseqno
    End Function
    Public Function Check_existreceiveNO(id As String)
        cn.connect()
        Dim idd As String = Nothing
        Try
            cm = New SqlCommand("select receiveNO from tbreceive where receiveNO='" & id & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    idd = re.GetValue(0)
                End While
            Else
                idd = "False"
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return idd
    End Function
    Public Function Check_existreceiveNO_bybillorderNO(id As String)
        cn.connect()
        Dim idd As String = Nothing
        Try
            cm = New SqlCommand("select receiveNO from tbreceive where billNO_order='" & id & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    idd = re.GetValue(0)
                End While
            Else
                idd = "False"
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return idd
    End Function
    Public Function savereceive(receiveNO As String, receiveautoid As Integer, user_id As Integer, sup_id As String, billNO_order As String, billno_bill As String, discount As Double, tax As Double, receive_total As Double, receive_date As String, statusid As Integer, mainmoney As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbreceive values('" & receiveNO & "','" & receiveautoid & "','" & user_id & "','" & sup_id & "','" & billNO_order & "','" & billno_bill & "','" & discount & "','" & tax & "','" & receive_total & "','" & receive_date & "','" & statusid & "',N'" & mainmoney & "')", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function update_balance_cut(detailid As Integer, qtycut As Integer)
        cn.connect()
        cm = New SqlCommand("update tbreceivedetail set receive_balancecut='" & qtycut & "' where receivedetailid='" & detailid & "'", cn.conn)
        cm.ExecuteNonQuery()
        cm.Dispose()
        cn.conn.Close()
        Return True
    End Function
    Public Function call_balace_cut(proid As string, dgv As DataTable)
        cn.connect()
        Try
            dgv.Clear()
            da = New SqlDataAdapter("select top 2 proID, receive_balancecut,receivedetailid,receive_price from viewreceivedetail where proID='" & proid & "' and receive_balancecut>0 and statusid=5 order by receivedetailid asc", cn.conn)
            da.Fill(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function savereceivedetail(receivedetailid As Integer, receiveNO As String, proID As String, unitname As String, receive_price As Double, receive_qty As Integer, discount As Double, receive_total As Double, receive_money As String, receive_balancecut As Integer, totalin As Integer, SerialID As String, product_expire As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbreceivedetail values('" & receivedetailid & "','" & receiveNO & "','" & proID & "',N'" & unitname & "','" & receive_price & "','" & receive_qty & "','" & discount & "','" & receive_total & "',N'" & receive_money & "','" & receive_balancecut & "','" & totalin & "','" & SerialID & "','" & product_expire & "')", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function


    Public Function loadpeorder_name(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbpreorder", cn.conn)
            da.Fill(ds, "tbpreorder")
            ds.Tables.Clear()
            da.Fill(ds, "tbpreorder")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(2).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(3).HeaderText = "ລາຄາ"
                .Columns(4).HeaderText = "ຈໍານວນ"
                .Columns(5).HeaderText = "ລວມ"

                .Columns(0).Width = 100
                .Columns(1).Width = 300
                .Columns(2).Width = 100
                .Columns(3).Width = 100
                .Columns(4).Width = 100
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Check_balancecut(proid)
        Dim qty As Integer
        cn.connect()
        Try
            cm = New SqlCommand("select proid,sum(receive_balancecut) as qty from viewreceivedetail where proid='" & proid & "' and statusid!=4 group by proid", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(1) Is DBNull.Value Then
                        qty = 0
                    Else
                        qty = re.GetValue(1)
                    End If
                End While
            Else
                qty = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return qty
    End Function
    Public Function Call_balancecutqty(proid As String)
        Dim id As Integer
        cn.connect()
        Try
            cm = New SqlCommand("select top 1 receive_balancecut from viewreceivedetail where proID='" & proid & "' and receive_balancecut>0 and statusid!=4 order by receivedetailid asc", cn.conn)
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
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function Call_ID_balancecut(proid As String)
        Dim id As Integer
        cn.connect()
        Try
            cm = New SqlCommand("select top 1 receivedetailid from viewreceivedetail where proID='" & proid & "' and statusid!=4 and receive_balancecut>0 order by receivedetailid asc", cn.conn)
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
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function Call_ID_balancecut_equal_zero(proid As String)
        Dim id As Integer
        cn.connect()
        Try
            cm = New SqlCommand("select top 1 receivedetailid from viewreceivedetail where proID='" & proid & "' and statusid!=4 and receive_balancecut>=0 order by receivedetailid desc", cn.conn)
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
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function Update_cancel_balancecut(id As Integer, qty As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("update tbreceivedetail set receive_balancecut='" & qty & "' where receivedetailid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadviewreceivesumarydetail(proid As String, dt1 As String, dt2 As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsumaryreceivedetail where receive_date>='" & dt1 & "' and receive_date<='" & dt2 & "' and proid=N'" & proid & "' and statusid<>4 order by receiveNO desc", cn.conn)
            da.Fill(ds, "ss")
            ds.Tables.Clear()
            da.Fill(ds, "ss")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ຜູ້ສັ່ງຊື້"
                .Columns(2).HeaderText = "ຊື້ຈາກ"
                .Columns(3).HeaderText = "ເລກບີນ"
                .Columns(4).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(5).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(6).HeaderText = "ລາຄາ"
                .Columns(7).HeaderText = "ຈໍານວນ"
                .Columns(8).HeaderText = "ລວມ"
                .Columns(9).HeaderText = "ວັນທີ"
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadviewreceive(orderno As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewreceive where billNO_order='" & orderno & "'", cn.conn)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function select_viewreceivedetail(receiveNO As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewreceivedetail where receiveNO='" & receiveNO & "'", cn.conn)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Cancelreceive(receiveNO As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbreceive set statusid=4 where receiveNO='" & receiveNO & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
