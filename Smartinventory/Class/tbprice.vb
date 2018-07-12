Imports System.Data.SqlClient
Public Class tbprice
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Public Function save(id As Integer, proid As String, barcode As String, proname As String, unitid As Integer, qtycut As Integer, saleall As Double, sale_eng As Double, sale_smallshop As Double, sale_big As Double)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbprice values('" & id & "','" & proid & "','" & barcode & "',N'" & proname & "','" & unitid & "','" & qtycut & "','" & saleall & "','" & sale_eng & "','" & sale_smallshop & "','" & sale_big & "')", cn.conn)
            'If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            cm.ExecuteNonQuery()
            'Else

            'End If
        Catch ex As Exception
            MessageBox.Show("ກະລຸນາບັນທືກຂໍ້ມູນສີນຄ້າກ່ອນ")
        End Try
        Return True
    End Function
    Public Function delete(id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbprice where price_id='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function
    Public Function update(id As Integer, proID As String, proname As String, barcode As String, unit As Integer, qtycut As Integer, bigprice As Double, small As Double, customerprice As Double)
        cn.connect()
        'Try
        cm = New SqlCommand("update tbprice set proID='" & proID & "', pronamesale=N'" & proname & "', barcode='" & barcode & "', unit_id='" & unit & "',qtycut='" & qtycut & "', bigshop_price='" & bigprice & "',smallshop_price='" & small & "',customer_price='" & customerprice & "' where price_id='" & id & "'", cn.conn)
        cm.ExecuteNonQuery()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function
    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 price_id from tbprice order by price_id desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0) + 1
                End While
            Else
                id = 1
            End If
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function viewprice(proID As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where proID='" & proID & "'", cn.conn)
            da.Fill(ds, "price1")
            ds.Tables.Clear()
            da.Fill(ds, "price1")
            dgv.DataSource = ds.Tables("price1")
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາໜ້າຮ້ານ"
                .Columns(7).HeaderText = "ລາຄາສາງ"
                .Columns(8).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(9).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(10).Visible = False
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(9).DefaultCellStyle.Format = "N0"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewprice_all(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewpricesale", cn.conn)
            da.Fill(ds, "price1")
            ds.Tables.Clear()
            da.Fill(ds, "price1")
            dgv.DataSource = ds.Tables("price1")
            format_price_datagridview(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_bycate_andsubcate(cateid As Integer, subcate As Integer, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewpricesale where cateID='" & cateid & "' and subid='" & subcate & "' order by proID asc", cn.conn)
            da.Fill(ds, "price11")
            ds.Tables.Clear()
            da.Fill(ds, "price11")
            dgv.DataSource = ds.Tables("price11")
            format_price_datagridview(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_byname(name As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewpricesale where proname like N'%" & name & "%' order by proID asc", cn.conn)
            da.Fill(ds, "price111")
            ds.Tables.Clear()
            da.Fill(ds, "price111")
            dgv.DataSource = ds.Tables("price111")
            format_price_datagridview(dgv)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function



    Public Function format_price_datagridview(dgv As DataGridView)
        With dgv
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ຊື່ສີນຄ້າ"
            .Columns(2).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(3).Visible = False
            .Columns(4).HeaderText = "ໜ້າຮ້ານ"
            .Columns(5).HeaderText = "ຊ່າງ"
            .Columns(6).HeaderText = "ຕິດຕັ້ງ"
            .Columns(7).HeaderText = "ຮ້ານໃຫຍ່"
            .Columns(8).HeaderText = "ໃນສາງ"
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
            .Columns(4).DefaultCellStyle.Format = "N0"
            .Columns(5).DefaultCellStyle.Format = "N0"
            .Columns(6).DefaultCellStyle.Format = "N0"
            .Columns(7).DefaultCellStyle.Format = "N0"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End With
        Return True
    End Function
    Public Function viewprice_byname(name As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where pronamesale like N'%" & name & "%'", cn.conn)
            da.Fill(ds, "price1")
            ds.Tables.Clear()
            da.Fill(ds, "price1")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາທົ່ວໄປ"
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
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewprice_bycateid(cateid As Integer, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where cateID='" & cateid & "'", cn.conn)
            da.Fill(ds, "price1")
            ds.Tables.Clear()
            da.Fill(ds, "price1")
            dgv.DataSource = ds.Tables("price1")
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາທົ່ວໄປ"
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
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewprice_filter_unitname(proID As String, unitname As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where proID='" & proID & "' and unitname=N'" & unitname & "'", cn.conn)
            da.Fill(ds, "price1")
            ds.Tables.Clear()
            da.Fill(ds, "price1")
            dgv.DataSource = ds.Tables("price1")
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາທົ່ວໄປ"
                .Columns(11).HeaderText = "ຫົວໜ່ວຍເງີນ"
                .Columns(12).HeaderText = "ປະເພດລາຄາ"
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
                .Columns(17).Visible = False
                .Columns(18).Visible = False
                .Columns(19).Visible = False
                .Columns(20).Visible = False
                .Columns(18).Visible = False
                .Columns(8).DefaultCellStyle.Format = "#,###.00"
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_unit_byproid(proid As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where qtycut=1 and proID='" & proid & "' order by proID asc", cn.conn)
            da.Fill(ds, "unit3")
            ds.Tables.Clear()
            da.Fill(ds, "unit3")
            dgv.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function viewpricesale_unit(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where qtycut=1 order by proID asc", cn.conn)
            da.Fill(ds, "unit")
            ds.Tables.Clear()
            da.Fill(ds, "unit")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາ"
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
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 150

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_pack_byproid(proid As Integer, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where qtycut>1 and qtycut<qty_height and proID='" & proid & "'", cn.conn)
            da.Fill(ds, "pack4")
            ds.Tables.Clear()
            da.Fill(ds, "pack4")
            dgv.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function viewpricesale_pack(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where qtycut>1 and qtycut<qty_height", cn.conn)
            da.Fill(ds, "pack")
            ds.Tables.Clear()
            da.Fill(ds, "pack")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາທົ່ວໄປ"
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
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 150
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_box_byproid(proid As Integer, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where qtycut=qty_height and proID='" & proid & "'", cn.conn)
            da.Fill(ds, "box111")
            ds.Tables.Clear()
            da.Fill(ds, "box111")
            dgv.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function viewpricesale_box(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where qtycut=qty_height", cn.conn)
            da.Fill(ds, "box11")
            ds.Tables.Clear()
            da.Fill(ds, "box11")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາທົ່ວໄປ"
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
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 150
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_unit_search_name(dgv As DataGridView, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where pronamesale like N'%" & name & "%' and qtycut=1", cn.conn)
            da.Fill(ds, "unitsearch1")
            ds.Tables.Clear()
            da.Fill(ds, "unitsearch1")
            dgv.DataSource = ds.Tables(0)
            With dgv
               .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາ"
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
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 150
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_unit_search_id(dgv As DataGridView, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where proID like N'%" & name & "%' and qtycut=1 ", cn.conn)
            da.Fill(ds, "unitsearch1")
            ds.Tables.Clear()
            da.Fill(ds, "unitsearch1")
            dgv.DataSource = ds.Tables(0)
            With dgv
               .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາ"
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
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 150
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_unit_search_category(dgv As DataGridView, cateid As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where cateID='" & cateid & "' and qtycut<=1", cn.conn)
            da.Fill(ds, "unitsearch12")
            ds.Tables.Clear()
            da.Fill(ds, "unitsearch12")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາ"
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
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 150
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_pack_search_name(dgv As DataGridView, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where qtycut>1 and qtycut!=qty_height and pronamesale like N'%" & name & "%'", cn.conn)
            da.Fill(ds, "searchpack")
            ds.Tables.Clear()
            da.Fill(ds, "searchpack")
            dgv.DataSource = ds.Tables(0)
            With dgv
               .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາທົ່ວໄປ"
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
                .Columns(17).Visible = False
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 150
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_pack_search_id(dgv As DataGridView, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where qtycut>1 and qtycut!=qty_height and proID like N'%" & name & "%'", cn.conn)
            da.Fill(ds, "searchpack")
            ds.Tables.Clear()
            da.Fill(ds, "searchpack")
            dgv.DataSource = ds.Tables(0)
            With dgv
              .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາທົ່ວໄປ"
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
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 150
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_pack_search_category(dgv As DataGridView, cateid As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where qtycut>1 and qtycut!=qty_height and cateID='" & cateid & "'", cn.conn)
            da.Fill(ds, "searchpack")
            ds.Tables.Clear()
            da.Fill(ds, "searchpack")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາທົ່ວໄປ"
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
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 150
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_box_search_name(dgv As DataGridView, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where qtycut=qty_height and pronamesale like N'%" & name & "%'", cn.conn)
            da.Fill(ds, "box")
            ds.Tables.Clear()
            da.Fill(ds, "box")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາທົ່ວໄປ"
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
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 150
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_box_search_id(dgv As DataGridView, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where qtycut=qty_height and proID like N'%" & name & "%'", cn.conn)
            da.Fill(ds, "box")
            ds.Tables.Clear()
            da.Fill(ds, "box")
            dgv.DataSource = ds.Tables(0)
            With dgv
                 .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາທົ່ວໄປ"
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
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 150
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewpricesale_box_search_category(dgv As DataGridView, cateid As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where qtycut=qty_height and cateID='" & cateid & "'", cn.conn)
            da.Fill(ds, "box")
            ds.Tables.Clear()
            da.Fill(ds, "box")
            dgv.DataSource = ds.Tables(0)
            With dgv
               .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ບາໂຄດ"
                .Columns(3).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(4).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ຈໍານວນຕັດ"
                .Columns(6).HeaderText = "ລາຄາຮ້ານໃຫ່ຍ"
                .Columns(7).HeaderText = "ລາຄາຮ້ານນ້ອຍ"
                .Columns(8).HeaderText = "ລາຄາທົ່ວໄປ"
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
                .Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Width = 150
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
  
    Public Function Check_duplicatebarcode()
        cn.connect()
        Dim barcode As String = Nothing
        Try
            cm = New SqlCommand("select barcode from tbprice", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    barcode = re.GetValue(0)
                End While
            End If
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return barcode
    End Function
    Public Function Gen_barcode_box()
        cn.connect()
        Dim barcode As String = Nothing
        'Try
        cm = New SqlCommand("select top 1 barcode from viewprice where qtycut=qty_height and barcode like '%-%' order by price_id desc", cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            While re.Read
                Dim p() As String
                p = re.GetValue(0).ToString.Split("-")
                Dim p1 As String = p(0)
                Dim p2 As Integer = p(1)
                barcode = "T-" + Format(CInt(p2) + 1)
            End While
        Else
            barcode = "T-10001"
        End If
        re.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return barcode
    End Function
    Public Function Gen_barcode_pack()
        cn.connect()
        Dim barcode As String = Nothing
        Try
            cm = New SqlCommand("select top 1 barcode from viewprice where  barcode like '%-%' and qtycut>1 and qtycut<qty_height order by price_id desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    Dim p() As String
                    p = re.GetValue(0).ToString.Split("-")
                    Dim p1 As String = p(0)
                    Dim p2 As Integer = p(1)
                    barcode = "T-" + Format(CInt(p2) + 1)
                End While
            Else
                barcode = "T-20001"
            End If
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return barcode
    End Function
    Public Function Gen_barcode_unit()
        cn.connect()
        Dim barcode As String = Nothing
        Try
            cm = New SqlCommand("select top 1 barcode from viewprice where barcode like '%-%' and qtycut=1 order by price_id desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    Dim p() As String
                    p = re.GetValue(0).ToString.Split("-")
                    Dim p1 As String = p(0)
                    Dim p2 As Integer = p(1)
                    barcode = "T-" + Format(CInt(p2) + 1)
                End While
            Else
                barcode = "T-30001"
            End If
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return barcode
    End Function
    Public Function viewpricesale(barcode As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewprice where barcode='" & barcode & "'", cn.conn)
            da.Fill(ds, "vie")
            ds.Tables.Clear()
            da.Fill(ds, "vie")
            dgv.DataSource = ds.Tables(0)

        Catch ex As Exception

        End Try
        Return True
    End Function
End Class
