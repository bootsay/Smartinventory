Imports System.Data.SqlClient
Public Class tborder
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Public Function run_runNO()
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
        Dim str As String = "select top 1 orderautoid from tborder order by orderautoid desc"
        cm = New SqlCommand(str, cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            re.Read()
            intsequence = Convert.ToInt32(re("orderautoid") + 1)
        Else
            intsequence = 1
        End If
        strseqno = intsequence
        strseqno = String.Format("{0}{1}-PO" & m & "" & y & "" & w & "", strprefix, intsequence.ToString().PadLeft(lengs, "0"))
        re.Close()
        cm.Dispose()
        cn.conn.Close()

        Return strseqno
    End Function
    Public Function saveorder(orderNO As String, orderautoid As Integer, payname As String, user_id As Integer, sup_id As String, discount As Double, tax As Double, ordertotalkip As Double, orderdate As String, orderNote As String, statusid As Integer, receive As String, cash As String, sumall As Double)
        cn.connect()
        'Try
        cm = New SqlCommand("insert into tborder values('" & orderNO & "','" & orderautoid & "',N'" & payname & "','" & user_id & "','" & sup_id & "','" & discount & "','" & tax & "','" & ordertotalkip & "','" & orderdate & "',N'" & orderNote & "','" & statusid & "','" & receive & "',N'" & cash & "','" & sumall & "')", cn.conn)
        cm.ExecuteNonQuery()
        cm.Dispose()
        cn.conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function
    Public Function update_payorder(id As String, todaypay As Double, paydate As String, moneynotpay As Double, nextpaydate As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbpayorder set todaypay='" & todaypay & "', paydate='" & paydate & "', moneynotpay='" & moneynotpay & "', nextpaydate='" & nextpaydate & "' where orderNO='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function updateorder(orderNO As String, payname As String, user_id As Integer, sup_id As String, discount As Double, tax As Double, ordertotalkip As Double, orderdate As String, orderNote As String, statusid As Integer, cash As String, sumall As Double)
        cn.connect()
        Try
            cm = New SqlCommand("update tborder set  payname=N'" & payname & "',user_id='" & user_id & "',sup_id='" & sup_id & "',discount='" & discount & "',tax='" & tax & "',ordertotalkip='" & ordertotalkip & "',orderdate='" & orderdate & "',orderNote=N'" & orderNote & "',statusid='" & statusid & "',cash=N'" & cash & "',sumall='" & sumall & "' where orderNO='" & orderNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function updatestatus(orderNO As String, statusid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("update tborder set  statusid='" & statusid & "' where orderNO='" & orderNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
            cm.Dispose()
            cn.conn.Close()
            'cm = New SqlCommand("update tborder set  statusid='" & statusid & "' where orderNO='" & orderNO & "'", cn.conn)
            'cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 orderautoid from tborder order by orderautoid desc", cn.conn)
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
    Public Function runiddetail()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 orderdetailid from tborderdetail order by orderdetailid desc", cn.conn)
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
    Public Function savedetail(orderdetailid As Integer, orderNO As String, proID As String, unitname As String, order_price As Double, order_qty As Integer, discount As Double, order_total As Double, ordercut As Integer, totalorderqty As Double)
        cn.connect()
        'Try
        Dim sav As String = "insert into tborderdetail values('" & orderdetailid & "','" & orderNO & "','" & proID & "',N'" & unitname & "','" & order_price & "','" & order_qty & "','" & discount & "','" & order_total & "','" & ordercut & "','" & totalorderqty & "')"
        With cm
            .CommandType = CommandType.Text
            .CommandText = sav
            .Connection = cn.conn
            .ExecuteNonQuery()
        End With
        cm.Dispose()
        cn.conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function
    Public Function deleteorderdetail(orderdetailid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tborderdetail where orderdetailid='" & orderdetailid & "'", cn.conn)
            'If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            cm.ExecuteNonQuery()
            'Else

            'End If
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function
    Public Function updatedetail(orderdetailid As Integer, orderNO As String, proID As String, unitname As String, order_price As Double, order_qty As Integer, order_total As Double)
        cn.connect()
        Try
            cm = New SqlCommand("update tbreceive set  orderNO='" & orderNO & "',proID='" & proID & "',unitname=N'" & unitname & "',order_price='" & order_price & "',order_price='" & order_qty & "',order_total='" & order_total & "'where orderdetailid='" & orderdetailid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function


    Public Function update(receiveNO As String, receiveautoid As Integer, user_id As Integer, sup_id As String, billNO As String, receive_totalkip As Double, receive_bath As Double, receive_dolla As Double, receive_date As String, receive_note As String, statusid As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbreceive set  receiveNO='" & receiveNO & "',receiveautoid='" & receiveautoid & "',user_id='" & user_id & "',sup_id='" & sup_id & "',billNO='" & billNO & "',receive_totalkip='" & receive_totalkip & "',receive_bath='" & receive_bath & "',receive_dolla='" & receive_dolla & "'receive_date='" & receive_date & "',receive_note=N'" & receive_note & "',statusid='" & statusid & "' where receiveNO='" & receiveNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function



    Public Function delete(receiveNO As String)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbreceive where receiveNO='" & receiveNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
                cm.Dispose()
                cn.conn.Close()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function
 
    Public Function vieworderdate(dt1 As String, dt2 As String, dgv As DataGridView, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from Vieworderall where orderdate>='" & dt1 & "' and orderdate<='" & dt2 & "'and user_id='" & name & "' order by orderautoid asc", cn.conn)
            da.Fill(ds, "orddate")
            ds.Tables.Clear()
            da.Fill(ds, "orddate")
            dgv.DataSource = ds.Tables(0)
            format_dgvorder(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function vieworder_byid(name As String, dgv As DataTable)
        cn.connect()
        Try
            dgv.Clear()
            da = New SqlDataAdapter("select * from Vieworderall where  orderNO like N'%" & name & "%' order by orderautoid asc", cn.conn)
            da.Fill(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewstatus(name As String, dgv As DataTable, payname As String)
        cn.connect()
        Try
            dgv.Clear()
            da = New SqlDataAdapter("select * from Vieworderall where payname like N'%" & payname & "%' and statusname=N'" & name & "' order by orderautoid asc", cn.conn)
            da.Fill(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadorder(dt1 As String, dt2 As String, dgv As DataGridView)
        cn.connect()
        'Try
        da = New SqlDataAdapter("select * from Vieworderall where orderdate>='" & dt1 & "' and orderdate<='" & dt2 & "' order by orderdate desc", cn.conn)
        da.Fill(ds, "pt")
        ds.Tables.Clear()
        da.Fill(ds, "pt")
        dgv.DataSource = ds.Tables(0)
        format_dgvorder(dgv)
        'Catch ex As Exception

        'End Try
        Return True
    End Function
    Public Function Cancle_order(id As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tborder set statusid=4 where orderNO='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadorder_dt(dt1 As String, dt2 As String, dt As DataTable, payname As String, statusname As String)
        cn.connect()
        'Try
        dt.Clear()
        da = New SqlDataAdapter("select * from vieworderall where statusname like N'%" & statusname & "%' and  payname like N'%" & payname & "%' and orderdate>='" & dt1 & "' and orderdate<='" & dt2 & "' order by orderNO desc", cn.conn)
        da.Fill(dt)
        'Catch ex As Exception

        'End Try
        Return True
    End Function
    Public Function loadorder_dt_debit(dt1 As String, dt2 As String, dt As DataTable)
        cn.connect()
        'Try
        dt.Clear()
        da = New SqlDataAdapter("select * from vieworderall where statusid<>4 and receive_status='YES' and orderdate>='" & dt1 & "' and orderdate<='" & dt2 & "' order by orderdate desc", cn.conn)
        da.Fill(dt)
        'Catch ex As Exception

        'End Try
        Return True
    End Function
    Public Function loadorder_bysupplier(supid As String, dt As DataTable)
        cn.connect()
        'Try
        dt.Clear()
        da = New SqlDataAdapter("select * from Vieworderall where sup_id='" & supid & "' order by orderdate desc", cn.conn)
        da.Fill(dt)
        'Catch ex As Exception

        'End Try
        Return True
    End Function
    Public Function loadorder_bysupplier_debit(supid As String, dt As DataTable)
        cn.connect()
        'Try
        dt.Clear()
        da = New SqlDataAdapter("select * from Vieworderall where statusid<>4 and receive_status='YES' and  sup_id='" & supid & "' order by orderdate desc", cn.conn)
        da.Fill(dt)
        'Catch ex As Exception

        'End Try
        Return True
    End Function
    Public Function format_dgvorder(dgv As DataGridView)
        With dgv
            .Columns(0).HeaderText = "ເລກທີບິນ"
            .Columns(1).Visible = False
            .Columns(2).HeaderText = "ການຈ່າຍ"
            .Columns(3).HeaderText = "ຊື້ຈາກ"
            .Columns(4).HeaderText = "ສ່ວນຫຼຸດ"
            .Columns(5).HeaderText = "ລວມ"
            .Columns(6).HeaderText = "ວັນທີ"
            .Columns(7).HeaderText = "ໝາຍເຫດ"
            .Columns(8).HeaderText = "ສະຖານະ"
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False

            .Columns(4).DefaultCellStyle.Format = "#,###.00"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Format = "#,###.00"
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(19).Visible = False
            .Columns(20).Visible = False
            .Columns(21).Visible = False
            .Columns(22).Visible = False
            .Columns(23).Visible = False
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
        Return True
    End Function
    Public Function loadorderdetail(orderno As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from vieworderdetail where orderNO='" & orderno & "'", cn.conn)
            da.Fill(dt)
        Catch ex As Exception

        End Try
        Return True
    End Function

    Public Function combobrand(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        'Try
        da = New SqlDataAdapter("select * from viewreceive", cn.conn)
        da.Fill(dt)

        With cb
            .DataSource = dt
            .DisplayMember = dt.Columns("brandname").ToString
            .ValueMember = dt.Columns("brandid").ToString
        End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function
    Public Function combopaytype(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select top 2 * from tbreceive order by pay_id asc", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("payname").ToString
                .ValueMember = dt.Columns("pay_id").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Update_receproduct(id As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tborder set receive_status='YES' where orderNO='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    
End Class
