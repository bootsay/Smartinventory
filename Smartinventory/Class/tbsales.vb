Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class tbsales
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Dim closeform As New formclose

    Public Function savesale(saleNO As String, sale_id As Integer, useid As Integer, payname As String, salename As String, supid As String, discount As Integer, vath As Double, totalsale As Double, mainmoney As String, dt As String, statuid As Integer, approve As String, note As String, location As String, pricetype As String)
        cn.connect()
        'Try
        cm = New SqlCommand("insert into tbsale values('" & saleNO & "','" & sale_id & "','" & useid & "',N'" & payname & "',N'" & salename & "','" & supid & "','" & discount & "','" & vath & "','" & totalsale & "',N'" & mainmoney & "','" & dt & "','" & statuid & "','" & approve & "',N'" & note & "',N'" & location & "',N'" & pricetype & "')", cn.conn)
        cm.ExecuteNonQuery()
        cm.Dispose()
        cn.conn.Close()
        ''Catch ex As Exception
        ''    MessageBox.Show(ex.Message)
        ''End Try
        Return True
    End Function
    Public Function select_mainmoney(saleno As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select mainmoney from viewsale where saleNO='" & saleno & "'", cn.conn)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function update_saleapprove(id As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbsale set approve='YES' where saleNO='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function update_saleapprove1(id As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbsale set approve='NO' where saleNO='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function


    Public Function count(id As String)
        cn.connect()
        Try
            cm = New SqlCommand("SELECT Count(*) From tbsaledetail where saleNO='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()


            'dT = New DataTable
            'dT.Load(dtr)
            'RCount = CInt(cm.ExecuteScalar())
            'txtShow.Text = (" ຂໍ້ມູນໃນຕາຕະລາງມີ " & RCount & "  ລາຍການ  ")

            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update_sale(saleNO As String, useid As Integer, payname As String, salename As String, supid As String, discount As Integer, vath As Double, totalsale As Double, mainmoney As String, note As String, location As String, pricetype As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbsale set user_id='" & useid & "', payname=N'" & payname & "',salename=N'" & salename & "',sup_id='" & supid & "', discount='" & discount & "', vath='" & vath & "',totalsale='" & totalsale & "',mainmoney=N'" & mainmoney & "',note=N'" & note & "',location_install=N'" & location & "',pricetype=N'" & pricetype & "'  where saleNO='" & saleNO & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function savepay(saleid As String, todaypay As Double, paydate As String, moneynotpay As Double, nextpaydate As String, statusid As Integer, paycount As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbpay(saleNO,todaypay,paydate,moneynotpay,nextpaydate,statusid,paycount) values('" & saleid & "','" & todaypay & "', '" & paydate & "','" & moneynotpay & "','" & nextpaydate & "','" & statusid & "','" & paycount & "')", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function updatepay_status(id As Integer, statusid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("update tbpay set statusid='" & statusid & "' where pay_id='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletesaledetail(saleNO As String)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbsaledetail where saleNO='" & saleNO & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function savesaledetail(saleid As String, proID As String, proname As String, unitname As String, pricebuy As Double, pricesale As Double, qty As Double, discount As Double, total As Double, totalcut As Integer, bath As Double, dolla As Double)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbsaledetail values('" & saleid & "','" & proID & "',N'" & proname & "',N'" & unitname & "','" & pricebuy & "','" & pricesale & "','" & qty & "','" & discount & "','" & total & "','" & totalcut & "','" & bath & "','" & dolla & "')", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function runsaleNO()
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
            cm = New SqlCommand("select top 1 sale_id from tbsale order by sale_id desc", cn.conn)
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
    Public Function runsale_id()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 sale_id from tbsale order by sale_id desc", cn.conn)
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
    Public Function Check_existsaleNO(saleno As String)
        cn.connect()
        Dim saleno1 As String = Nothing
        Try
            cm = New SqlCommand("select top 1 saleNO from tbsale where saleNO='" & saleno & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        saleno1 = "false"
                    Else
                        saleno1 = re.GetValue(0)
                    End If
                End While
            Else
                saleno1 = "false"
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return saleno1
    End Function
    Public Function selectop_saleNO()
        cn.connect()
        Dim id As String = Nothing
        Try
            cm = New SqlCommand("select top 1 sale_id,saleID from tbsale order by sale_id asc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(1)
                End While
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function viewsale_bysaleNO(id As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewsaleall where saleNO like N'%" & id & "%' order by sale_id desc", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewsaledetail_bysaleNO(id As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewsaledetail where saleNO like N'%" & id & "%'", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewsale_byStatus(id As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewsaleall where approve=N'" & id & "'", cn.conn)
            da.Fill(dt)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewsale_byCustomername(id As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewsaleall where companyname=N'" & id & "' order by sale_id desc", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Select_viewsaleall_bysupid_dt(supid As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select saleNO,payname,salename,discount,vath,totalsale,todaypay,moneynotpay,mainmoney,saledate,saleapprovedate from viewsaleall where sup_id='" & supid & "' and approve='YES' and statusid<>4 and saleNO in (select saleNO from tbsaleapprove) order by saleNO asc", cn.conn)
            da.Fill(dt)

            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Select_viewsaleall_bysupid(supid As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select saleNO,payname,salename,discount,vath,totalsale,todaypay,moneynotpay,mainmoney,saledate,saleapprovedate from viewsaleall where sup_id='" & supid & "' and approve='YES' and statusid<>4 and saleNO in (select saleNO from tbsaleapprove) order by saleNO asc", cn.conn)
            da.Fill(ds, "dd")
            ds.Tables.Clear()
            da.Fill(ds, "dd")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ເລກບີນ"
                .Columns(1).HeaderText = "ການຈ່າຍ"
                .Columns(2).HeaderText = "ຜູ້ຂາຍ"
                .Columns(3).HeaderText = "ລຸດ"
                .Columns(4).HeaderText = "ອາກອນ"
                .Columns(5).HeaderText = "ລວມ"
                .Columns(6).HeaderText = "ຈ່າຍແລ້ວ"
                .Columns(7).HeaderText = "ຕິດໜີ້"
                .Columns(8).HeaderText = "ເງີນ"
                .Columns(9).HeaderText = "ວັນທີອອກບີນ"
                .Columns(10).HeaderText = "ວັນທີອະນຸມັດ"

                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(5).DefaultCellStyle.Format = "N0"
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function viewsale_byapprove_datatable(d1 As String, d2 As String, dt As DataTable, sta As String)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewsaleall where saledate>='" & d1 & "' and saledate<='" & d2 & "' and approve='" & sta & "'  order by sale_id desc", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewsale_bydate_datatable(d1 As String, d2 As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewsaleall where saledate>='" & d1 & "' and saledate<='" & d2 & "' order by sale_id desc", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewsaledebit_bydate_datatable_approve(payname As String, d1 As String, d2 As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewsaleall where saleNO in (select saleNO from tbsaleapprove where saleapprovedate>='" & d1 & "' and saleapprovedate<='" & d2 & "' ) and approve='YES' and statusid<>4 and payname=N'" & payname & "' order by saleNO asc", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewsaledebit_bydate_datatable_approve_all(payname As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewsaleall where approve='YES' and statusid<>4 and payname=N'" & payname & "' and moneynotpay>0 order by saleNO asc", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewsale_bydate(d1 As String, d2 As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsaleall where saledate>='" & d1 & "' and saledate<='" & d2 & "'", cn.conn)
            da.Fill(ds, "cash")
            ds.Tables.Clear()
            da.Fill(ds, "cash")
            dgv.DataSource = ds.Tables(0)
            format_dgvsale(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Call_saledetail_bysaleNO(saleNO As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewsaledetail where saleNO='" & saleNO & "' order by saledetailid asc", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function format_dgvsale(dgv As DataGridView)
        With dgv
            .Columns(0).HeaderText = "ລັດຫັດ"
            .Columns(1).HeaderText = "ປະເພດ"
            .Columns(2).HeaderText = "ຜູ້ຂາຍ"
            .Columns(3).HeaderText = "ຜູ້ຊື້"
            .Columns(4).HeaderText = "ລຸດ"
            .Columns(5).HeaderText = "ພາສີ"
            .Columns(6).HeaderText = "ລວມ"
            .Columns(7).HeaderText = "ຈ່າຍ"
            .Columns(8).HeaderText = "ໜີ້"
            .Columns(9).HeaderText = "ເງີນ"
            .Columns(10).HeaderText = "ວັນທີຂາຍ"
            .Columns(11).HeaderText = "ສະຖານະ"
            .Columns(12).HeaderText = "ອານຸມັດ"
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
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            .Columns(4).DefaultCellStyle.Format = "#,####.00"
            .Columns(5).DefaultCellStyle.Format = "#,####.00"
            .Columns(6).DefaultCellStyle.Format = "#,####.00"

            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        End With
        Return True
    End Function
    Public Function viewsale_alloption_without_rangdate_paydetail(payname As String, provience As String, district As String, ban As String, custype As String, salename As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewpay where payname like N'%" & payname & "%' and provience like N'%" & provience & "%' and district like N'%" & district & "%' and village like N'%" & ban & "%' and custype like N'%" & custype & "%' and salename like N'%" & salename & "%' order by sale_id asc", cn.conn)
            da.Fill(ds, "cash")
            ds.Tables.Clear()
            da.Fill(ds, "cash")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລັດຫັດ"
                .Columns(1).HeaderText = "ປະເພດເງີນ"
                .Columns(2).HeaderText = "ຜູ້ຂາຍ"
                .Columns(3).HeaderText = "ຜູ້ຊື້"
                .Columns(4).HeaderText = "ມູນຄ່າຈ່າຍ"
                .Columns(5).HeaderText = "ວັນທີຈ່າຍ"
                .Columns(6).HeaderText = "ຍັງຄ້າງ"
                .Columns(7).Visible = False
                .Columns(8).HeaderText = "ສະຖານະ"
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
                .Columns(17).Visible = False
                .Columns(18).Visible = False
                .Columns(19).Visible = False
                '.Columns(20).Visible = False
                '.Columns(21).Visible = False
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"

            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewsale_alloption_without_rangdate(payname As String, provience As String, district As String, ban As String, custype As String, salename As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsumarysale where payname like N'%" & payname & "%' and provience like N'%" & provience & "%' and district like N'%" & district & "%' and village like N'%" & ban & "%' and custype like N'%" & custype & "%' and salename like N'%" & salename & "%' order by sale_id asc", cn.conn)
            da.Fill(ds, "cash")
            ds.Tables.Clear()
            da.Fill(ds, "cash")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລັດຫັດ"
                .Columns(1).HeaderText = "ປະເພດເງີນ"
                .Columns(2).HeaderText = "ຜູ້ຂາຍ"
                .Columns(3).HeaderText = "ຜູ້ຊື້"
                .Columns(4).HeaderText = "ວັນທີ"
                .Columns(5).HeaderText = "ສ່ວນລຸດ"
                .Columns(6).HeaderText = "ລວມ"
                .Columns(7).HeaderText = "ຈ່າຍແລ້ວ"
                .Columns(8).HeaderText = "ຍັງຄ້າງ"
                .Columns(9).HeaderText = "ວັນທີຈ່າຍຄັ້ງໜ້າ"
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).HeaderText = "ສະຖານະ"
                .Columns(16).Visible = False
                '.Columns(17).Visible = False
                '.Columns(18).HeaderText = "ປະເພດ"
                '.Columns(19).Visible = False
                '.Columns(20).Visible = False
                '.Columns(21).Visible = False
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"

            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewsale_sumarycustomer_list(supid As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsumarysale2 where sup_id='" & supid & "'order by sale_id asc", cn.conn)
            da.Fill(ds, "cash")
            ds.Tables.Clear()
            da.Fill(ds, "cash")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລັດຫັດ"
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ຜູ້ຂາຍ"
                .Columns(3).HeaderText = "ຜູ້ຊື້"
                .Columns(4).HeaderText = "ວັນທີ"
                .Columns(5).HeaderText = "ສ່ວນລຸດ"
                .Columns(6).HeaderText = "ລວມ"
                .Columns(7).HeaderText = "ຈ່າຍແລ້ວ"
                .Columns(8).HeaderText = "ຍັງຄ້າງ"
                .Columns(9).HeaderText = "ວັນທີຈ່າຍຄັ້ງໜ້າ"
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).HeaderText = "ສະຖານະ"
                .Columns(16).Visible = False
                .Columns(17).Visible = False
                '.Columns(18).HeaderText = "ປະເພດ"
                '.Columns(19).Visible = False
                '.Columns(20).Visible = False
                '.Columns(21).Visible = False
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"

            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewsale_alloption_with_rangdate(payname As String, dt1 As String, dt2 As String, provience As String, district As String, ban As String, custype As String, salename As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsumarysale where saledate>='" & dt1 & "' and saledate<='" & dt2 & "' and payname like N'%" & payname & "%' and provience like N'%" & provience & "%' and district like N'%" & district & "%' and village like N'%" & ban & "%' and custype like N'%" & custype & "%' and salename like N'%" & salename & "%' order by sale_id asc", cn.conn)
            da.Fill(ds, "cash")
            ds.Tables.Clear()
            da.Fill(ds, "cash")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລັດຫັດ"
                .Columns(1).HeaderText = "ປະເພດເງີນ"
                .Columns(2).HeaderText = "ຜູ້ຂາຍ"
                .Columns(3).HeaderText = "ຜູ້ຊື້"
                .Columns(4).HeaderText = "ວັນທີ"
                .Columns(5).HeaderText = "ສ່ວນລຸດ"
                .Columns(6).HeaderText = "ລວມ"
                .Columns(7).HeaderText = "ຈ່າຍແລ້ວ"
                .Columns(8).HeaderText = "ຍັງຄ້າງ"
                .Columns(9).HeaderText = "ວັນທີຈ່າຍຄັ້ງໜ້າ"
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
   
    Public Function viewdebit_finisth_bysaleID(saleid As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsumarysale2 where payname=N'ຕິດໜີ້' and status_id=3 and saleID like N'%" & saleid & "%' order by sale_id asc", cn.conn)
            da.Fill(ds, "debit1")
            ds.Tables.Clear()
            da.Fill(ds, "debit1")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລັດຫັດ"
                .Columns(1).HeaderText = "ປະເພດເງີນ"
                .Columns(2).HeaderText = "ຜູ້ຂາຍ"
                .Columns(3).HeaderText = "ຜູ້ຊື້"
                .Columns(4).HeaderText = "ວັນທີ"
                .Columns(5).HeaderText = "ສ່ວນລຸດ"
                .Columns(6).HeaderText = "ລວມ"
                .Columns(7).HeaderText = "ຈ່າຍແລ້ວ"
                .Columns(8).HeaderText = "ຍັງຄ້າງ"
                .Columns(9).HeaderText = "ວັນທີຈ່າຍຄັ້ງໜ້າ"
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).HeaderText = "ສະຖານະ"
                .Columns(16).Visible = False
                .Columns(17).Visible = False
               
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewdebit_notpay_bysaleID(saleid As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsumarysale2 where payname=N'ຕິດໜີ້' and saleID like N'%" & saleid & "%' order by sale_id asc", cn.conn)
            da.Fill(ds, "debit1")
            ds.Tables.Clear()
            da.Fill(ds, "debit1")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລັດຫັດ"
                .Columns(1).HeaderText = "ປະເພດເງີນ"
                .Columns(2).HeaderText = "ຜູ້ຂາຍ"
                .Columns(3).HeaderText = "ຜູ້ຊື້"
                .Columns(4).HeaderText = "ວັນທີ"
                .Columns(5).HeaderText = "ສ່ວນລຸດ"
                .Columns(6).HeaderText = "ລວມ"
                .Columns(7).HeaderText = "ຈ່າຍແລ້ວ"
                .Columns(8).HeaderText = "ຍັງຄ້າງ"
                .Columns(9).HeaderText = "ວັນທີຈ່າຍຄັ້ງໜ້າ"
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).HeaderText = "ສະຖານະ"
                .Columns(16).Visible = False
                .Columns(17).Visible = False
           
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function vewsaledetail(saleID As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsaledetail where saleNO='" & saleID & "'", cn.conn)
            da.Fill(ds, "viewsaledetail")
            ds.Tables.Clear()
            da.Fill(ds, "viewsaledetail")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(3).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(4).HeaderText = "ລາຄາ"
                .Columns(5).Visible = False
                .Columns(6).HeaderText = "ຈໍານວນ"
                .Columns(7).HeaderText = "ລຸດ"
                .Columns(8).HeaderText = "ລວມ"
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
                .Columns(17).Visible = False
                .Columns(18).Visible = False
                .Columns(6).DefaultCellStyle.Format = "#,###.00"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewsumarysaledetail(proid As String, dgv As DataGridView, dt1 As String, dt2 As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsumarysaledetail where proid=N'" & proid & "' and saledate>='" & dt1 & "' and saledate<='" & dt2 & "' and statusid<>4 and approve='YES'", cn.conn)
            da.Fill(ds, "viewsumarysaledetail")
            ds.Tables.Clear()
            da.Fill(ds, "viewsumarysaledetail")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ຜູ້ຂາຍ"
                .Columns(2).HeaderText = "ຜູ້ຊື້"
                .Columns(3).HeaderText = "ລາຍການ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ລາຄາ"
                .Columns(6).HeaderText = "ຈໍານວນ"
                .Columns(7).HeaderText = "ລຸດ"
                .Columns(8).Visible = False   'ອາກອນ
                .Columns(9).HeaderText = "ລວມ"
                .Columns(10).HeaderText = "ວັນທີ"
                .Columns(11).Visible = False
                .Columns(12).Visible = False

                .Columns(5).DefaultCellStyle.Format = "#,###.00"
                .Columns(9).DefaultCellStyle.Format = "#,###.00"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Cancle_sale(saleid As String, statusid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("update tbsale set status_id='" & statusid & "' where saleID='" & saleid & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function finishpay(saleID As String, d1 As String, userreceive As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbpay set user_receivemoney=N'" & userreceive & "', pay_date='" & d1 & "' where saleID='" & saleID & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function update_Salestatus(saleID As String, paystatusid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("update tbsale set statusid='" & paystatusid & "' where saleNO='" & saleID & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function sum_customerdebitpay()
        Dim total As Double
        cn.connect()
        Try
            cm = New SqlCommand("select sum(today_pay) as total1 from tbpay where custu_id=4", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    total = re.GetValue(0)
                End While
            Else

            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return total
    End Function
    Public Function sum_customerdebitpay_bydate(d1 As String, d2 As String)
        Dim total As Double
        cn.connect()
        Try
            cm = New SqlCommand("select sum(today_pay) as total1 from tbpay where custu_id=2 or custu_id=4 and paydate>='" & d1 & "' and paydate<='" & d2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    total = re.GetValue(0)
                End While
            Else
                total = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return total
    End Function
    Public Function Call_printersetting()
        cn.connect()
        Dim st As String = Nothing
        Try
            cm = New SqlCommand("select top 1 sale_printer from tbprintersetting", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    st = re.GetValue(0).ToString
                End While
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return st
    End Function
    Public Function update_printersetting(name As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbprintersetting set sale_printer='" & name & "' where set_id=1", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function GetDefaultPrinter() As String
        Dim settings As PrinterSettings = New PrinterSettings()
        Return settings.PrinterName
    End Function
    Public Function calc_income(dt1 As String, dt2 As String)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(totalincome) as dd from viewsaledetail where saledate>='" & dt1 & "' and saledate<='" & dt2 & "' and paystatus_id!=3", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    total = re.GetValue(0)
                End While
            Else
                total = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return total
    End Function
    Public Function Checkqty_start(proID As String)
        cn.connect()
        Dim qty As Integer
        Try
            cm = New SqlCommand("select pro_qty from tbproductprice where proID='" & proID & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    qty = re.GetValue(0)
                End While
            Else
                qty = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return qty
    End Function
    Public Function Checkqty_end(proID As String)
        cn.connect()
        Dim qty As Integer
        Try
            cm = New SqlCommand("select pro_qtyend from tbproductprice where proID='" & proID & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    qty = re.GetValue(0)
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
    Public Function Call_price(qt1 As Integer, qt2 As Integer, proID As String)
        cn.connect()
        Dim qty As Double
        Try
            cm = New SqlCommand("select price_sale from tbproductprice where proID='" & proID & "' and pro_qty>='" & qt1 & "' and pro_qtyend<='" & qt2 & "'", cn.conn)
            If re.HasRows Then
                While re.Read
                    qty = re.GetValue(0)
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
    Public Function viewproductprice(proid As Int64, dgv As DataGridView)
        cn.connect()
        da = New SqlDataAdapter("select * from viewproductprice where proID='" & proid & "'", cn.conn)
        da.Fill(ds, "pp")
        ds.Tables.Clear()
        da.Fill(ds, "pp")
        dgv.DataSource = ds.Tables(0)
        dgv.Refresh()
        Return True
    End Function
    Public Function viewaddbarcode(bar As String, dgv As DataGridView)
        cn.connect()
        da = New SqlDataAdapter("select * from tbaddbarcode where barcode='" & bar & "'", cn.conn)
        da.Fill(ds, "ppp")
        ds.Tables.Clear()
        da.Fill(ds, "ppp")
        dgv.DataSource = ds.Tables(0)
        dgv.Refresh()
        Return True
    End Function
    Public Function sum_Cash_kip(dt1 As String, dt2 As String)
        Dim totalcash As Double
        cn.connect()
        Try
            cm = New SqlCommand("select sum(sumkip) as total from viewsale where pay_id=1 and paystatus_id=1 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalcash = re.GetValue(0)
                End While
            Else
                totalcash = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totalcash
    End Function
    Public Function sum_Cash_bath(dt1 As String, dt2 As String)
        Dim totalcash As Double
        cn.connect()
        Try
            cm = New SqlCommand("select sum(sumbath) as total from viewsale where pay_id=1 and paystatus_id=1 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalcash = re.GetValue(0)
                End While
            Else
                totalcash = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totalcash
    End Function
    Public Function sum_Debit_kip(dt1 As String, dt2 As String)
        Dim totaldebit As Double
        cn.connect()
        Try
            cm = New SqlCommand("select sum(sumkip) as total from viewsale where pay_id=2 and paystatus_id!=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totaldebit = re.GetValue(0)
                End While
            Else
                totaldebit = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totaldebit
    End Function
    Public Function sum_Debit_kip_BysupID(Supid As String)
        Dim totaldebit As Double
        cn.connect()
        Try
            cm = New SqlCommand("select sum(sumkip) as total from viewsale where sup_id='" & Supid & "' and  pay_id=2 and paystatus_id!=3", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totaldebit = re.GetValue(0)
                End While
            Else
                totaldebit = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totaldebit
    End Function
    Public Function sum_Debit_bath(dt1 As String, dt2 As String)
        Dim totaldebit As Double
        cn.connect()
        Try
            cm = New SqlCommand("select sum(sumbath) as total from viewsale where pay_id=2 and paystatus_id!=3 and paystatus_id!=1 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totaldebit = re.GetValue(0)
                End While
            Else
                totaldebit = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totaldebit
    End Function
    Public Function sum_Debit_bath_bysupid(supid As String)
        Dim totaldebit As Double
        cn.connect()
        Try
            cm = New SqlCommand("select sum(sumbath) as total from viewsale where sup_id='" & supid & "' and  pay_id=2 and paystatus_id!=3 and paystatus_id!=1", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totaldebit = re.GetValue(0)
                End While
            Else
                totaldebit = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totaldebit
    End Function
    Public Function sum_benefitcash_kip(dt1 As String, dt2 As String)
        Dim benefitkip As Double
        cn.connect()
        Try
            cm = New SqlCommand("select sum(totalincomekip)+sum(totalincomekip1) as benefitkip from viewsaledetail where pay_id=1 and moneytype=N'ກີບ' and paystatus_id!=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    benefitkip = re.GetValue(0)
                End While
            Else
                benefitkip = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return benefitkip
    End Function
    Public Function sum_benefitdebit_kip(dt1 As String, dt2 As String)
        Dim benefitkip As Double
        cn.connect()
        Try
            cm = New SqlCommand("select sum(totalincomekip)+sum(totalincomekip1) as benefitkip from viewsaledetail where pay_id=2 and moneytype=N'ກີບ' and paystatus_id!=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    benefitkip = re.GetValue(0)
                End While
            Else
                benefitkip = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return benefitkip
    End Function
    Public Function sum_benefitcash_bath(dt1 As String, dt2 As String)
        Dim benefitkip As Double
        cn.connect()
        Try
            cm = New SqlCommand("select sum(totalincomebath)+sum(totalincomebath1) as benefitbath from viewsaledetail where pay_id=1 and moneytype=N'ບາດ' and paystatus_id!=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    benefitkip = re.GetValue(0)
                End While
            Else
                benefitkip = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return benefitkip
    End Function
    Public Function sum_benefitdebit_bath(dt1 As String, dt2 As String)
        Dim benefitkip As Double
        cn.connect()
        Try
            cm = New SqlCommand("select sum(totalincomebath)+sum(totalincomebath1) as benefitkip from viewsaledetail where pay_id=2 and moneytype=N'ບາດ' and paystatus_id!=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    benefitkip = re.GetValue(0)
                End While
            Else
                benefitkip = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return benefitkip
    End Function
    Public Function sum_Cancelkip(dt1 As String, dt2 As String)
        cn.connect()
        Dim totalcancel As Double
        Try
            cm = New SqlCommand("select sum(sumkip) as cancel from viewsale where paystatus_id=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalcancel = re.GetValue(0)
                End While
            Else
                totalcancel = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totalcancel
    End Function
    Public Function sum_Cancebath(dt1 As String, dt2 As String)
        cn.connect()
        Dim totalcancel As Double
        Try
            cm = New SqlCommand("select sum(sumbath) as cancel from viewsale where paystatus_id=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalcancel = re.GetValue(0)
                End While
            Else
                totalcancel = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totalcancel
    End Function
    Public Function sum_totalsalekip(dt1 As String, dt2 As String)
        cn.connect()
        Dim totalsale As Double
        Try
            cm = New SqlCommand("select sum(sumkip) as totalsale from viewsale where paystatus_id!=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalsale = re.GetValue(0)
                End While
            Else
                totalsale = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totalsale
    End Function
    Public Function sum_benefitbath(dt1 As String, dt2 As String)
        cn.connect()
        Dim totalsale As Double
        Try
            cm = New SqlCommand("select sum(totalincomebath)+sum(totalincomebath1) as totalsale from viewsaledetail where paystatus_id!=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalsale = re.GetValue(0)
                End While
            Else
                totalsale = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totalsale
    End Function
    Public Function sum_benefitkip(dt1 As String, dt2 As String)
        cn.connect()
        Dim totalsale As Double
        Try
            cm = New SqlCommand("select sum(totalincomekip)+sum(totalincomekip1) as totalsale from viewsaledetail where paystatus_id!=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalsale = re.GetValue(0)
                End While
            Else
                totalsale = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totalsale
    End Function
    Public Function sum_totalsalebath(dt1 As String, dt2 As String)
        cn.connect()
        Dim totalsale As Double
        Try
            cm = New SqlCommand("select sum(sumbath) as totalsale from viewsale where paystatus_id!=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalsale = re.GetValue(0)
                End While
            Else
                totalsale = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totalsale
    End Function
    Public Function sum_totalsale(dt1 As String, dt2 As String)
        cn.connect()
        Dim totalsale As Double
        Try
            cm = New SqlCommand("select sum(totalkip) as totalsale from viewsale where paystatus_id!=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalsale = re.GetValue(0)
                End While
            Else
                totalsale = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return totalsale
    End Function
    Public Function sum_totalbuypriceSale(dt1 As String, dt2 As String)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(totalbuyprice) as total from viewsaledetail where paystatus_id!=3 and saledate>='" & dt1 & "' and saledate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    total = re.GetValue(0)
                End While
            Else
                total = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return total
    End Function
    Public Function barcode_viewprice(dgv As DataGridView, moneytypeid As Integer, barcode As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where barcode=N'" & barcode & "' and money_id='" & moneytypeid & "' order by price_id asc", cn.conn)
            da.Fill(ds, "tbprice")
            ds.Tables.Clear()
            da.Fill(ds, "tbprice")
            dgv.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function barcode_viewprice_barcode(dgv As DataGridView, barcode As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where barcode=N'" & barcode & "' order by price_id asc", cn.conn)
            da.Fill(ds, "tbprice2")
            ds.Tables.Clear()
            da.Fill(ds, "tbprice2")
            dgv.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function barcode_receiveproduct(dgv As DataGridView, barcode As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select top 1 * from viewprice where barcode=N'" & barcode & "' order by price_id asc", cn.conn)
            da.Fill(ds, "tbprice3")
            ds.Tables.Clear()
            da.Fill(ds, "tbprice3")
            dgv.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function barcode_viewprice_proid(dgv As DataGridView, proid As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where proID=N'" & proid & "' order by price_id asc", cn.conn)
            da.Fill(ds, "tbprice1")
            ds.Tables.Clear()
            da.Fill(ds, "tbprice1")
            dgv.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function barcode_tbaddbarcode(barcode As String)
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select proID from tbaddbarcode where barcode=N'" & barcode & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0)
                End While
            End If
        Catch ex As Exception

        End Try
        re.Close()
        cm.Dispose()
        cn.conn.Close()
        Return id
    End Function
    Public Function Delete_saledetail(saleID As String)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbsaledetail where saleNO='" & saleID & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function sum_debitpaybath(dt1 As String, dt2 As String)
        cn.connect()
        Dim total As Double
        Try
          
            cm = New SqlCommand("select sum(today_paybath) as dd from viewpay where pay_id=2 and remind_paybath >0 and paydate>='" & dt1 & "' and paydate<='" & dt2 & "'", cn.conn)
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
    Public Function sum_debitpaybath_bysupid(supid As String)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(today_paybath) as dd from viewpay where sup_id='" & supid & "' and pay_id=2 and remind_paybath >0 ", cn.conn)
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
    Public Function sum_debitpaykip(dt1 As String, dt2 As String)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(today_paykip) as dd from viewpay where pay_id=2 and remind_paykip >0 and paydate>='" & dt1 & "' and paydate<='" & dt2 & "'", cn.conn)
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
    Public Function sum_debitpaykip_bysupid(supid As String)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(today_paykip) as dd from viewpay where sup_id='" & supid & "' and pay_id=2 and remind_paykip >0 ", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    total = re.GetValue(0)
                End While
            Else
                total = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception

        End Try
        Return total
    End Function

    Public Function sum_viewsaledetail(saleNO As String)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(totalsale) as dd from viewsaledetail where saleNO='" & saleNO & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    total = re.GetValue(0)
                End While
            Else
                total = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception

        End Try
        Return total
    End Function


    Public Function Get_startsaeldate()
        Dim dd As String = Nothing
        cn.connect()
        Try
            cm = New SqlCommand("select top 1 saledate from tbsale order by sale_id asc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        dd = ""
                    Else
                        dd = re.GetValue(0)
                    End If
                End While
            Else
                dd = ""
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dd
    End Function
    Public Function loadviewsumarysale(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsumarysale order by sup_id asc", cn.conn)
            da.Fill(ds, "ss")
            ds.Tables.Clear()
            da.Fill(ds, "ss")
            dgv.DataSource = ds.Tables(0)
            'With dgv
            '    .Columns(0).HeaderText = "ລະຫັດລູກຄ້າ"
            '    .Columns(1).HeaderText = "ຊື່ລູກຄ້າ"
            '    .Columns(2).HeaderText = "ລວມກີບ"
            '    .Columns(3).HeaderText = "ລວມບາດ"
            '    .Columns(4).HeaderText = "ລວມໂດລາ"
            '    .Columns(5).HeaderText = "ຈ່າຍກີບ"
            '    .Columns(6).HeaderText = "ຈ່າຍບາດ"
            '    .Columns(7).HeaderText = "ຈ່າຍໂດລາ"
            '    .Columns(8).HeaderText = "ໜີ້ກີບ"
            '    .Columns(9).HeaderText = "ໜີ້ບາດ"
            '    .Columns(10).HeaderText = "ໜີ້ໂດລາ"

            '    .Columns(2).DefaultCellStyle.Format = "#,###.00"
            '    .Columns(3).DefaultCellStyle.Format = "#,###.00"
            '    .Columns(4).DefaultCellStyle.Format = "#,###.00"
            '    .Columns(5).DefaultCellStyle.Format = "#,###.00"
            '    .Columns(6).DefaultCellStyle.Format = "#,###.00"
            '    .Columns(7).DefaultCellStyle.Format = "#,###.00"
            '    .Columns(8).DefaultCellStyle.Format = "#,###.00"
            '    .Columns(9).DefaultCellStyle.Format = "#,###.00"
            '    .Columns(10).DefaultCellStyle.Format = "#,###.00"

            '    .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '    .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '    .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '    .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '    .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '    .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '    .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '    .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '    .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight



            '    .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '    .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            'End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadviewsumarysale_bysup_id(supid As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsumarysale where sup_id='" & supid & "' order by sup_id asc", cn.conn)
            da.Fill(ds, "ss")
            ds.Tables.Clear()
            da.Fill(ds, "ss")
            dgv.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
