Imports System.Data.SqlClient
Public Class tbproduct
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Public Function countproduct(prefix As String)
        Dim id As Integer
        cn.connect()
        'MessageBox.Show(prefix)

        Try
            'cm = New SqlCommand("select count(proID) as number from tbproduct where proID like N'" & prefix & "%'", cn.conn)
            cm = New SqlCommand("select top 1 proID from tbproduct where proID like N'" & prefix & "0%' order by proID desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    Dim count As Integer = prefix.Length
                    'MessageBox.Show(count)

                    Dim dd As String = re.GetValue(0)
                    Dim cc As String = dd.Remove(0, count)
                    id = CInt(cc)
                    'MessageBox.Show(id)

                    'Dim p() As String
                    'p = re.GetValue(0).ToString.Split(prefix)
                    'Dim p1 As String = p(0)
                    'Dim p2 As String = p(1)
                    'MessageBox.Show(p1)
                    'MessageBox.Show(p2)
                    ''orderno = "SO" + Format(CInt(p2) + 1)
                    'id = CInt(p2)
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
    Public Function runid(count As Integer, prefix1 As String)
        Dim id As String = Nothing
        Dim prefix As String = prefix1
        Dim length As Integer = 4
        Dim inorder As Integer
        'y = Format(CDate(a.Value.Year.ToString()), "yy")
        Try
            inorder = count + 1
            id = inorder
            id = String.Format("{0}{1}", prefix, inorder.ToString().PadLeft(length, "0"))
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    'Public Function runid()
    '    Dim id As Integer = Nothing
    '    cn.connect()
    '    Try
    '        cm = New SqlCommand("select top 1 proID from tbproduct order by proID desc", cn.conn)
    '        re = cm.ExecuteReader
    '        If re.HasRows Then
    '            While re.Read
    '                id = re.GetValue(0) + 1
    '            End While
    '        Else
    '            id = "10001"
    '        End If
    '        re.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    '    Return id
    'End Function
    Public Function save(proid As String, stockid As Integer, catid As Integer, barndid As Integer, proname As String, model As String, unitid As Integer, qtylow As Integer, qtyheight As Integer, capitalid As Integer, price As Double, moneyid As Integer, notifyqty As Integer, cutypeid As Integer, serialid As Integer, notify As String, stockqty As Integer)
        cn.connect()
        Try
            Dim sav As String = "insert into tbproduct values('" & proid & "','" & stockid & "','" & catid & "','" & barndid & "', N'" & proname & "',N'" & model & "','" & unitid & "','" & qtylow & "','" & qtyheight & "','" & capitalid & "','" & price & "','" & moneyid & "','" & notifyqty & "','" & cutypeid & "','" & serialid & "',N'" & notify & "','" & stockqty & "')"
            'If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກຂໍ້ມູນແທ້ບໍ່?", "ຄໍາແນະນໍາ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
            With cm
                .CommandType = CommandType.Text
                .CommandText = sav
                .Connection = cn.conn
                .ExecuteNonQuery()
            End With
            'Else

            'End If
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function saveimage() As Byte()
        Dim frmp As frmproduct1 = CType(Application.OpenForms("frmproduct1"), frmproduct1)
        Dim memstream1 As New IO.MemoryStream
        'frmp.pimage.Image.Save(memstream1, Drawing.Imaging.ImageFormat.Jpeg)
        Return memstream1.ToArray()
    End Function
    Public Function savebarcode() As Byte()
        Dim frmp As frmproduct1 = CType(Application.OpenForms("frmproduct1"), frmproduct1)
        Dim memstream As New IO.MemoryStream
        'frmp.barcode.Image.Save(memstream, Drawing.Imaging.ImageFormat.Jpeg)
        Return memstream.ToArray()
    End Function
    Public Function delete(id As String)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbproduct where proID='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show("ຂໍ້ມູນມີການໃຊ້ງານບໍ່ສາມາດລືບໄດ້", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function
    Public Function update(proid As String, stockid As Integer, subid As Integer, barndid As Integer, proname As String, model As String, unitid As Integer, qtylow As Integer, qtyheight As Integer, capitalid As Integer, price As Double, moneyid As Integer, notifyqty As Integer, cutypeid As Integer, serialid As Integer, notify As String)
        cn.connect()
        'Dim pic() As Byte = reimageUpdate()
        'cm.Parameters.AddWithValue("pic", pic)
        Try
            Dim upd As String = "update tbproduct set  stockid='" & stockid & "', subid='" & subid & "', brandid='" & barndid & "', proname=N'" & proname & "',modelname=N'" & model & "',  unit_id='" & unitid & "', qtylow='" & qtylow & "', qtyheight='" & qtyheight & "', capitalid='" & capitalid & "', pricebuy='" & price & "', money_id='" & moneyid & "', notifyqty='" & notifyqty & "', cutypeid='" & cutypeid & "', serialid='" & serialid & "', notify=N'" & notify & "' where proID='" & proid & "'"
            'If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງຂໍ້ມູນແທ້ບໍ່?", "ຄໍາແນະນໍາ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
            With cm
                .CommandType = CommandType.Text
                .CommandText = upd
                .Connection = cn.conn
                .ExecuteNonQuery()
            End With
            cm.Dispose()
            cn.conn.Close()
            'Else
            'End If
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function check_duplicatename(name As String)
        cn.connect()
        Dim name1 As String = Nothing
        Try

            cm = New SqlCommand("select proname from tbproduct where proname=N'" & name & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    name1 = "True"
                End While
            Else
                name1 = "False"
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return name1
    End Function
    Public Function showimage(dgv As DataGridView)
        Dim product As frmproduct1 = CType(Application.OpenForms("frmproduct1"), frmproduct1)
        cn.connect()
        Try
            cm = New SqlCommand("select picture from tbproduct where proID='" & dgv.CurrentRow.Cells(0).Value & "'", cn.conn)
            re = cm.ExecuteReader
            If re.Read Then
                Dim bytimage() As Byte

                bytimage = CType(re(0), Byte())
                Dim ms As New System.IO.MemoryStream(bytimage)
                Dim bmimage As New Bitmap(ms)
                ms.Close()
                'product.pimage.SizeMode = PictureBoxSizeMode.Normal

                'product.pimage.Image = bmimage
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function reimageUpdate() As Byte()
        Dim pd As frmproduct1 = CType(Application.OpenForms("frmproduct1"), frmproduct1)
        Dim bytimage() As Byte
        Dim ms As New System.IO.MemoryStream
        'Dim dd As New Bitmap(pd.pimage.Image)
        'dd.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        bytimage = ms.ToArray()
        Return ms.ToArray()
    End Function
    Public Function search_categorycombo(cateid As Integer, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct where cateID='" & cateid & "'", cn.conn)
            da.Fill(ds, "viewproduct")
            ds.Tables.Clear()
            da.Fill(ds, "viewproduct")
            dgv.DataSource = ds.Tables(0)
            formatdgv_product(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception

        End Try
        Return True
    End Function
  
    Public Function countrow()
        Dim count As Integer
        cn.connect()
        Try
            cm = New SqlCommand("select count(proID) as countt from tbproduct", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    count = re.GetValue(0)
                End While
            Else
                count = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception

        End Try
        Return count
    End Function
    Public Function updateStock(proid As String, qty As Integer)
        cn.connect()
        'Try
        cm = New SqlCommand("update tbproduct set stockqty='" & qty & "' where proID='" & proid & "'", cn.conn)
        cm.ExecuteNonQuery()
        cm.Dispose()
        cn.conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function
    Public Function Callstock_qty(proid As String)
        cn.connect()
        Dim qty As Integer
        'Try
        cm = New SqlCommand("select stockqty from tbproduct where proID='" & proid & "'", cn.conn)
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
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return qty
    End Function
    
   
    Public Function update_pricebuy(proid As String, pricebuy As Double)
        cn.connect()
        Try
            cm = New SqlCommand("update tbproduct set pricebuy='" & pricebuy & "' where proID='" & proid & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricebuy(dgv As DataGridView, capitalid As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from Viewproduct where capitalid<>'" & capitalid & "' order by proID asc", cn.conn)
            da.Fill(ds, "viewproduct1")
            ds.Tables.Clear()
            da.Fill(ds, "viewproduct1")
            dgv.DataSource = ds.Tables(0)
            formatdgv_product(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricebuy_byproid(proid As String, dgv As DataGridView, capitalid As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from Viewproduct where proID='" & proid & "' and capitalid<>'" & capitalid & "'", cn.conn)
            da.Fill(ds, "viewproduct2")
            ds.Tables.Clear()
            da.Fill(ds, "viewproduct2")
            dgv.DataSource = ds.Tables(0)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricebuy_outofstock(dgv As DataGridView, stockqty As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from Viewproduct where stockqty<='" & stockqty & "' order by proid asc", cn.conn)
            da.Fill(ds, "viewproduct")
            ds.Tables.Clear()
            da.Fill(ds, "viewproduct")
            dgv.DataSource = ds.Tables(0)
            formatdgv_product(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricebuy_outofstock_searchname(dgv As DataGridView, stockqty As Integer, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from Viewproduct where stockqty<='" & stockqty & "' and proname like N'%" & name & "%' order by proid asc", cn.conn)
            da.Fill(ds, "viewproduct2")
            ds.Tables.Clear()
            da.Fill(ds, "viewproduct2")
            dgv.DataSource = ds.Tables(0)
            formatdgv_product(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricebuy_search_Noprice(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct where proID not in (select proID from viewprice) order by proid asc", cn.conn)
            da.Fill(ds, "viewproductsearch_id")
            ds.Tables.Clear()
            da.Fill(ds, "viewproductsearch_id")
            dgv.DataSource = ds.Tables(0)
            formatdgv_product(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricebuy_search_id(dgv As DataGridView, name As String, capitalid As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from Viewproduct where proID like N'%" & name & "%' and capitalid<>'" & capitalid & "' order by proid asc", cn.conn)
            da.Fill(ds, "viewproductsearch_id")
            ds.Tables.Clear()
            da.Fill(ds, "viewproductsearch_id")
            dgv.DataSource = ds.Tables(0)
            formatdgv_product(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricebuy_productorderlist(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from Viewproduct where stockqty<=notifyqty and notify='YES' order by proid asc", cn.conn)
            da.Fill(ds, "viewproductsearch_id")
            ds.Tables.Clear()
            da.Fill(ds, "viewproductsearch_id")
            dgv.DataSource = ds.Tables(0)
            formatdgv_product(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function formatdgv_product(dgv As DataGridView)
        With dgv
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).Visible = False
            .Columns(2).Visible = False
            .Columns(3).HeaderText = "ປະເພດຍ່ອຍ"
            .Columns(4).HeaderText = "ຊື່ສີນຄ້າ"
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).HeaderText = "ລາຄາ"
            .Columns(11).HeaderText = "ຈໍານວນ"
            .Columns(12).HeaderText = "ມູນຄ່າ"
            .Columns(13).HeaderText = "ເງີນ"
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
            .Columns(24).Visible = False
            .Columns(25).Visible = False
            .Columns(26).Visible = False
            .Columns(10).DefaultCellStyle.Format = "N0"
            .Columns(12).DefaultCellStyle.Format = "N0"
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End With
      
        Return True
    End Function
    Public Function viewrpricebuy_barcode(dgv As DataGridView, proid As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from Viewproduct where proid='" & proid & "'", cn.conn)
            da.Fill(ds, "view9")
            ds.Tables.Clear()
            da.Fill(ds, "view9")
            dgv.DataSource = ds.Tables(0)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricebuy_search_name(dgv As DataGridView, name As String, capitalid As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from Viewproduct where proname like N'%" & name & "%' and capitalid<>'" & capitalid & "' order by proid asc", cn.conn)
            da.Fill(ds, "viewproductsearch_name")
            ds.Tables.Clear()
            da.Fill(ds, "viewproductsearch_name")
            dgv.DataSource = ds.Tables(0)
            formatdgv_product(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricebuy_search_category(dgv As DataGridView, cateid As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from Viewproduct where cateID='" & cateid & "' order by proid asc", cn.conn)
            da.Fill(ds, "viewproductsearch")
            ds.Tables.Clear()
            da.Fill(ds, "viewproductsearch")
            dgv.DataSource = ds.Tables(0)
            formatdgv_product(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Check_duplicationID(proid As String)
        cn.connect()
        Dim id As String
        cm = New SqlCommand("select proID from tbproduct where proID='" & proid & "'", cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            While re.Read
                id = re.GetValue(0)
            End While
        Else
            id = "false"
        End If
        re.Close()
        cm.Dispose()
        cn.conn.Close()
        Return True
    End Function
    Public Function Check_duplicationModel(model As String)
        cn.connect()
        Dim id As String = Nothing
        cm = New SqlCommand("select modelname from tbproduct where modelname='" & model & "'", cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            While re.Read
                If re.GetValue(0) Is DBNull.Value Then
                    id = "nothing"
                Else
                    id = re.GetValue(0)
                End If

            End While
        Else
            id = "nothing"
        End If
        re.Close()
        cm.Dispose()
        cn.conn.Close()
        Return id
    End Function
    Public Function sum_stockvaluekip()
        cn.connect()
        Dim total As Double
        'Try
        cm = New SqlCommand("select sum(stockqty * priceunit) as total from Viewproduct where moneyname=N'ກີບ'", cn.conn)
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
        'Catch ex As Exception

        'End Try
        Return total
    End Function
    Public Function sum_stockvaluebath()
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(stockqty * priceunit) as total from Viewproduct where moneyname=N'ບາດ'", cn.conn)
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
    Public Function viewpricebuy_unit(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct", cn.conn)
            da.Fill(ds, "pricebuyunit")
            ds.Tables.Clear()
            da.Fill(ds, "pricebuyunit")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).HeaderText = "ລາຄາ"
                .Columns(9).HeaderText = "ເງີນ"
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
                .Columns(9).Width = 50
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(11).DefaultCellStyle.Format = "N0"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function viewpricebuy_unit_searchby_name(name As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct where proname like N'%" & name & "%'", cn.conn)
            da.Fill(ds, "pricebuyunit")
            ds.Tables.Clear()
            da.Fill(ds, "pricebuyunit")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).HeaderText = "ລາຄາ"
                .Columns(9).HeaderText = "ເງີນ"
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
                .Columns(9).Width = 50
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(11).DefaultCellStyle.Format = "N0"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function viewpricebuy_unit_searchby_cateID(cateid As Integer, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct where cateID='" & cateid & "'", cn.conn)
            da.Fill(ds, "pricebuyunit")
            ds.Tables.Clear()
            da.Fill(ds, "pricebuyunit")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).HeaderText = "ລາຄາ"
                .Columns(9).HeaderText = "ເງີນ"
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
                .Columns(9).Width = 50
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(11).DefaultCellStyle.Format = "N0"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function viewpricebuy_pack(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct", cn.conn)
            da.Fill(ds, "pricebuypack")
            ds.Tables.Clear()
            da.Fill(ds, "pricebuypack")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).HeaderText = "ລາຄາ"
                .Columns(8).Visible = False
                .Columns(9).HeaderText = "ເງີນ"
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
                .Columns(9).Width = 50
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(11).DefaultCellStyle.Format = "N0"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function viewpricebuy_pack_searchby_cateID(cateid As Integer, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct where cateID='" & cateid & "'", cn.conn)
            da.Fill(ds, "pricebuypack")
            ds.Tables.Clear()
            da.Fill(ds, "pricebuypack")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).HeaderText = "ລາຄາ"
                .Columns(8).Visible = False
                .Columns(9).HeaderText = "ເງີນ"
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
                .Columns(9).Width = 50
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(11).DefaultCellStyle.Format = "N0"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function viewpricebuy_pack_search_byname(name As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct where proname like N'%" & name & "%' ", cn.conn)
            da.Fill(ds, "pricebuypack")
            ds.Tables.Clear()
            da.Fill(ds, "pricebuypack")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).HeaderText = "ລາຄາ"
                .Columns(8).Visible = False
                .Columns(9).HeaderText = "ເງີນ"
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
                .Columns(9).Width = 50
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(11).DefaultCellStyle.Format = "N0"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function viewpricebuy_box(dgv As DataGridView)
        cn.connect()
        'Try
        da = New SqlDataAdapter("select * from viewproduct", cn.conn)
        da.Fill(ds, "pricebox5")
        ds.Tables.Clear()
        da.Fill(ds, "pricebox5")
        dgv.DataSource = ds.Tables(0)
        With dgv
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).HeaderText = "ຊື່ສີນຄ້າ"
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).HeaderText = "ລາຄາ"
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).HeaderText = "ເງີນ"
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
            .Columns(9).Width = 50
            .Columns(6).DefaultCellStyle.Format = "N0"
            .Columns(7).DefaultCellStyle.Format = "N0"
            .Columns(8).DefaultCellStyle.Format = "N0"
            .Columns(11).DefaultCellStyle.Format = "N0"
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With

        'Catch ex As Exception

        'End Try
        Return True
    End Function
    Public Function viewpricebuy_box_byname(name As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct where proname like N'%" & name & "%'", cn.conn)
            da.Fill(ds, "pricebox2")
            ds.Tables.Clear()
            da.Fill(ds, "pricebox2")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).HeaderText = "ລາຄາ"
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).HeaderText = "ເງີນ"
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
                .Columns(9).Width = 50
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(11).DefaultCellStyle.Format = "N0"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function viewpricebuy_bycate_andsubcate(cateid As Integer, subcateid As Integer, dgv As DataGridView, capitalid As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct where cateID='" & cateid & "' and subid='" & subcateid & "' and capitalid<>'" & capitalid & "'", cn.conn)
            da.Fill(ds, "pricebox21")
            ds.Tables.Clear()
            da.Fill(ds, "pricebox21")
            dgv.DataSource = ds.Tables(0)
            formatdgv_product(dgv)

        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function combomoney(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbmoney", cn.conn)
            da.Fill(dt)
            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("moneyname").ToString
                .ValueMember = dt.Columns("money_id").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Check_product_remindStock(qty As Integer, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct where stockqty<='" & qty & "' and notification='YES' order by proID asc", cn.conn)
            da.Fill(ds, "rem")
            ds.Tables.Clear()
            da.Fill(ds, "rem")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(3).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(4).HeaderText = "ຈໍານວນຕໍາ"
                .Columns(5).HeaderText = "ຈໍານວນສູງ"
                .Columns(6).HeaderText = "ຕົ້ນທືນສະເລ່ຍ"
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).HeaderText = "ເງີນ"
                .Columns(10).HeaderText = "ຈໍານວນ"
                .Columns(11).HeaderText = "ມູນຄ່າ"
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
                .Columns(17).Visible = False
                .Columns(18).Visible = False
                .Columns(19).Visible = False
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(11).DefaultCellStyle.Format = "N0"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function Count_productnotstock(remindqty As Integer)
        cn.connect()
        Dim qty As Integer
        Try
            cm = New SqlCommand("select count(proID) as dd from viewproduct where notification='YES' and stockqty<='" & remindqty & "'", cn.conn)
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
    Public Function Call_pricebuybalance(proid As String)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select top 1 pricebuy_balance from viewpricebuybalance where proID='" & proid & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        total = 0
                    Else
                        total = re.GetValue(0)
                    End If
                End While
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return total
    End Function
    Public Function Select_Capitalprice(proid As String)
        cn.connect()
        Dim pricebuy As Double
        Try
            cm = New SqlCommand("select pricebuy from tbproduct where proID='" & proid & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        pricebuy = 0
                    Else
                        pricebuy = re.GetValue(0)
                    End If
                End While
            Else
                pricebuy = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
