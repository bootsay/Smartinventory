Imports System.Data.SqlClient
Public Class frmcheckstockoption
    Dim stockin As New tbreceive
    Dim stockout As New tbstockout
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Dim sales As New tbsales
    Public dt As New mydata
    Dim cate As New tbcategory
    Dim subcate As New tbsubcategory
    Private Sub frmcheckstockoption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim st As String = stockin.call_startstock()
            dt1.MinDate = Format(CDate(st), "yyyy/MM/dd")
            dt2.MinDate = Today.Date
            dt2.Text = Today.Date
            dt1.Text = Today.Date

            cate.combocategory1(cbcategory)
            cbcategory.SelectedValue = 0
            If cbcategory.SelectedValue > 0 Then
                subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
            End If
            'stockin.comboyear(cbyear)
            'cbyear.SelectedIndex = 0
            'stockin.comboMonth(cbmonth)
            'cbmonth.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        'Try
        btnreport.Enabled = True
        cn.connect()
        'Dim dt1 As String =
        dt.sumaryproductin_out.Clear()

        dgvproduct.DataSource = Nothing
        Dim catename As String = Nothing
        Dim subcatename As String = Nothing
        If cbcategory.SelectedValue = 0 Then
            catename = "%"
            cbsupcategory.SelectedValue = 0
        Else
            Dim rows As DataRowView = cbcategory.SelectedItem
            Dim row As DataRow = rows.Row
            catename = row(1).ToString
        End If

        If cbsupcategory.SelectedValue > 0 Then
            Dim rows1 As DataRowView = cbsupcategory.SelectedItem
            Dim row1 As DataRow = rows1.Row
            subcatename = row1(3).ToString
        Else
            subcatename = "%"
        End If
        Dim note As String
        If rdall.Checked = True Then
            note = 1
        Else
            note = 0
        End If
        'MessageBox.Show(catename)
        'MessageBox.Show(subcatename)
        da = New SqlDataAdapter("exec sumaryproductin_out '" & Format(CDate(dt1.Text), "MM/dd/yyyy") & "','" & Format(CDate(dt2.Text), "MM/dd/yyyy") & "','" & catename & "','" & subcatename & "','" & note & "'", cn.conn)
        da.Fill(ds, "dd")
        ds.Tables.Clear()
        da.Fill(ds, "dd")
        da.Fill(dt.sumaryproductin_out)
        dgvproduct.DataSource = ds.Tables(0)
        With dgvproduct
            .Columns(0).HeaderText = "ລະຫັດສິນຄ້າ"
            .Columns(1).HeaderText = "ຊື່ສິນຄ້າ"
            .Columns(2).HeaderText = "ຍອດຍົກມາ"
            .Columns(3).HeaderText = "ຮັບເຂົ້າ"
            .Columns(4).HeaderText = "ຂາຍອອກ"
            .Columns(5).HeaderText = "ເບີກອອກ"
            .Columns(6).HeaderText = "ຍັງເຫຼືອ"
            .Columns(7).Visible = False
            .Columns(8).Visible = False
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
            .Columns(20).Visible = False
            .Columns(21).Visible = False
            .Columns(22).Visible = False
            .Columns(23).Visible = False
            .Columns(24).Visible = False
            .Columns(25).Visible = False

            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        End With
        'Catch ex As Exception
        '    'MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub dgvproduct_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvproduct.CellMouseUp
        Try
            With dgvproduct
                sales.viewsumarysaledetail(.CurrentRow.Cells(0).Value, dgvsaleout, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))
                stockin.loadviewreceivesumarydetail(.CurrentRow.Cells(0).Value, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvinstock)
                stockout.loadviewsumarystockoutdetail(.CurrentRow.Cells(0).Value, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvstockout)
            End With
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvproduct_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvproduct.KeyUp
        Try
            With dgvproduct
                'sales.viewsaledetail2_byproid(.CurrentRow.Cells(0).Value, dgvsaleout, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))
                'stockin.viewstockindetail2_proid(.CurrentRow.Cells(0).Value, dgvinstock, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvproduct_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvproduct.KeyDown
        Try
            With dgvproduct
                sales.viewsumarysaledetail(.CurrentRow.Cells(0).Value, dgvsaleout, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))
                'stockin.viewstockindetail2_proid(.CurrentRow.Cells(0).Value, dgvinstock, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        'Try
        If dgvproduct.Rows.Count > 0 Then
            frmreportsumaryproductinout.ShowDialog()
            frmreportsumaryproductinout.Close()
        Else

        End If

        '    'btnreport.Enabled = False
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcategory.SelectedIndexChanged
        Try
            If cbcategory.SelectedValue = 0 Then

            Else
                subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub makesalelist_table(dgvsalelist As DataGridView)
        Dim proid As New DataGridViewTextBoxColumn
        Dim proname As New DataGridViewTextBoxColumn
        Dim unitname As New DataGridViewTextBoxColumn
        Dim price As New DataGridViewTextBoxColumn
        Dim qty As New DataGridViewTextBoxColumn
        Dim discount As New DataGridViewTextBoxColumn
        Dim free As New DataGridViewCheckBoxColumn
        Dim total As New DataGridViewTextBoxColumn

        dgvsalelist.Columns.Add(proid)
        dgvsalelist.Columns.Add(proname)
        dgvsalelist.Columns.Add(unitname)
        dgvsalelist.Columns.Add(price)
        dgvsalelist.Columns.Add(qty)
        dgvsalelist.Columns.Add(discount)
        dgvsalelist.Columns.Add(free)
        dgvsalelist.Columns.Add(total)
        With dgvsalelist
            .Columns(0).HeaderText = "ລັດຫັດ"
            .Columns(1).HeaderText = "ລາຍການ"
            .Columns(2).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(3).HeaderText = "ລາຄາ"
            .Columns(4).HeaderText = "ຈໍານວນ"
            .Columns(5).HeaderText = "ສ່ວນລຸດ"
            .Columns(6).HeaderText = "ແຖມ"
            .Columns(7).HeaderText = "ລວມ"
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).DefaultCellStyle.Format = "#,###.00"
            .Columns(7).DefaultCellStyle.Format = "#,###.00"
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub
    Private Sub Makereceivetable(dgvsalelist As DataGridView)
        Dim proid As New DataGridViewTextBoxColumn
        Dim proname As New DataGridViewTextBoxColumn
        Dim unitname As New DataGridViewTextBoxColumn
        Dim price As New DataGridViewTextBoxColumn
        Dim qty As New DataGridViewTextBoxColumn
        Dim discount As New DataGridViewTextBoxColumn
        Dim free As New DataGridViewCheckBoxColumn
        Dim total As New DataGridViewTextBoxColumn

        dgvsalelist.Columns.Add(proid)
        dgvsalelist.Columns.Add(proname)
        dgvsalelist.Columns.Add(unitname)
        dgvsalelist.Columns.Add(price)
        dgvsalelist.Columns.Add(qty)
        dgvsalelist.Columns.Add(discount)
        dgvsalelist.Columns.Add(free)
        dgvsalelist.Columns.Add(total)
        With dgvsalelist
            .Columns(0).HeaderText = "ລັດຫັດ"
            .Columns(1).HeaderText = "ລາຍການ"
            .Columns(2).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(3).HeaderText = "ລາຄາ"
            .Columns(4).HeaderText = "ຈໍານວນ"
            .Columns(5).HeaderText = "ສ່ວນລຸດ"
            .Columns(6).HeaderText = "ແຖມ"
            .Columns(7).HeaderText = "ລວມ"
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).DefaultCellStyle.Format = "#,###.00"
            .Columns(7).DefaultCellStyle.Format = "#,###.00"
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

    Private Sub btnreporttotalmoney_Click(sender As Object, e As EventArgs) Handles btnreporttotalmoney.Click
        Try
            If dgvproduct.Rows.Count > 0 Then
                frmreportsumaryproductinout_totalvalue.ShowDialog()
                frmreportsumaryproductinout_totalvalue.Close()
            Else

            End If

            'btnreport.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub rdall_CheckedChanged(sender As Object, e As EventArgs) Handles rdall.CheckedChanged

    End Sub
End Class