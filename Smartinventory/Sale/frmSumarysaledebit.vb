Imports System.Data.SqlClient
Public Class frmSumarysaledebit
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
    Public formsaledebit As Boolean = False
    Dim salename As New tbsalename
    Public sup_id As String
    Public frmSumarysaledebit As Boolean = False

    Private Sub frmcheckstockoption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim st As String = stockin.call_startstock()
            dt1.MinDate = Format(CDate(st), "yyyy/MM/dd")
            dt2.MinDate = Today.Date
            dt2.Text = Today.Date
            dt1.Text = Today.Date
            salename.combosalename(cbsalename)
            'stockin.comboyear(cbyear)
            'cbyear.SelectedIndex = 0
            'stockin.comboMonth(cbmonth)
            'cbmonth.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
 
    Private Sub dgvproduct_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvproduct.CellMouseUp
        Try
            With dgvproduct
                sales.vewsaledetail(.CurrentRow.Cells(0).Value, dgvsaleout)
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

    'Private Sub dgvproduct_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvproduct.KeyDown
    '    Try
    '        With dgvproduct
    '            sales.vewsaledetail(.CurrentRow.Cells(0).Value, dgvsaleout)
    '        End With
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs)
        Try
            If dgvproduct.Rows.Count > 0 Then
                frmreportsumaryproductinout.ShowDialog()
                frmreportsumaryproductinout.Close()
            Else

            End If

            'btnreport.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcategory.SelectedIndexChanged
    '    Try
    '        If cbcategory.SelectedValue = 0 Then

    '        Else
    '            subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub makesalelist_table(dgvsalelist As DataGridView)
        Dim saleNO As New DataGridViewTextBoxColumn
        Dim salename As New DataGridViewTextBoxColumn
        Dim companyname As New DataGridViewTextBoxColumn
        Dim totalsale As New DataGridViewTextBoxColumn
        Dim totaldebit As New DataGridViewTextBoxColumn
        Dim Finishpay As New DataGridViewTextBoxColumn
        Dim Todaypay As New DataGridViewCheckBoxColumn
        Dim Restdebit As New DataGridViewTextBoxColumn

        dgvsalelist.Columns.Add(saleNO)
        dgvsalelist.Columns.Add(salename)
        dgvsalelist.Columns.Add(companyname)
        dgvsalelist.Columns.Add(totalsale)
        dgvsalelist.Columns.Add(totaldebit)
        dgvsalelist.Columns.Add(Finishpay)
        dgvsalelist.Columns.Add(Todaypay)
        dgvsalelist.Columns.Add(Restdebit)
        With dgvsalelist
            .Columns(0).HeaderText = "ລັດຫັດ"
            .Columns(1).HeaderText = "ພະນັກງານຂາຍ"
            .Columns(2).HeaderText = "ຊື່ບໍລິສັດ"
            .Columns(3).HeaderText = "ທັງໝົດ"
            .Columns(4).HeaderText = "ຍອດໜີ້"
            .Columns(5).HeaderText = "ຈ່າຍແລ້ວ"
            .Columns(6).HeaderText = "ຈ່າຍມື້ນີ້"
            .Columns(7).Visible = False
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(3).DefaultCellStyle.Format = "N0"
            .Columns(4).DefaultCellStyle.Format = "N0"
            .Columns(5).DefaultCellStyle.Format = "N0"
            .Columns(6).DefaultCellStyle.Format = "N0"
            '.Columns(7).DefaultCellStyle.Format = "#,###.00"
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub
    Private Sub Makereceivetable(dgvsalelist As DataGridView)
        Dim saleNO As New DataGridViewTextBoxColumn
        Dim salename As New DataGridViewTextBoxColumn
        Dim companyname As New DataGridViewTextBoxColumn
        Dim totalsale As New DataGridViewTextBoxColumn
        Dim totaldebit As New DataGridViewTextBoxColumn
        Dim Finishpay As New DataGridViewTextBoxColumn
        Dim Todaypay As New DataGridViewCheckBoxColumn
        Dim Restdebit As New DataGridViewTextBoxColumn

        dgvsalelist.Columns.Add(saleNO)
        dgvsalelist.Columns.Add(salename)
        dgvsalelist.Columns.Add(companyname)
        dgvsalelist.Columns.Add(totalsale)
        dgvsalelist.Columns.Add(totaldebit)
        dgvsalelist.Columns.Add(Finishpay)
        dgvsalelist.Columns.Add(Todaypay)
        dgvsalelist.Columns.Add(Restdebit)
        With dgvsalelist
            .Columns(0).HeaderText = "ລັດຫັດ"
            .Columns(1).HeaderText = "ພະນັກງານຂາຍ"
            .Columns(2).HeaderText = "ຊື່ບໍລິສັດ"
            .Columns(3).HeaderText = "ທັງໝົດ"
            .Columns(4).HeaderText = "ຍອດໜີ້"
            .Columns(5).HeaderText = "ຈ່າຍແລ້ວ"
            .Columns(6).HeaderText = "ຈ່າຍມື້ນີ້"
            .Columns(7).Visible = False
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(3).DefaultCellStyle.Format = "N0"
            .Columns(4).DefaultCellStyle.Format = "N0"
            .Columns(5).DefaultCellStyle.Format = "N0"
            .Columns(6).DefaultCellStyle.Format = "N0"
            '.Columns(7).DefaultCellStyle.Format = "#,###.00"
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.M
        End With
    End Sub


    Private Sub dt2_Click(sender As Object, e As EventArgs) Handles dt2.Click

    End Sub

    Private Sub btnbrown_Click(sender As Object, e As EventArgs) Handles btnbrown.Click
        frmSumarysaledebit = True
        frmshowcustomer.ShowDialog()
        frmshowcustomer.Close()
        frmSumarysaledebit = False
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        'Try
        cn.connect()
        'Dim dt1 As String =
        dt.Sumarysaledebit.Clear()
        dgvproduct.DataSource = Nothing

        Dim salename As String = Nothing
        If cbsalename.SelectedValue = 0 Then
            salename = "%"
            'cbsupcategory.SelectedValue = 0
        Else
            Dim rows As DataRowView = cbsalename.SelectedItem
            Dim row As DataRow = rows.Row
            salename = row(1).ToString
        End If
        Dim supname As String
        If txtsupname.Text = "" Then
            supname = "%"
        Else
            supname = txtsupname.Text
        End If

        da = New SqlDataAdapter("exec Sumarysaledebit'" & Format(CDate(dt1.Text), "MM/dd/yyyy") & "','" & Format(CDate(dt2.Text), "MM/dd/yyyy") & "',N'" & salename & "',N'" & supname & "'", cn.conn)
        da.Fill(ds, "dd")
        ds.Tables.Clear()
        da.Fill(ds, "dd")
        da.Fill(dt.Sumarysaledebit)
        dgvproduct.DataSource = ds.Tables(0)
        With dgvproduct
            .Columns(0).HeaderText = "ລັດຫັດ"
            .Columns(1).HeaderText = "ພະນັກງານຂາຍ"
            .Columns(2).HeaderText = "ຊື່ບໍລິສັດ"
            .Columns(3).HeaderText = "ທັງໝົດ"
            .Columns(4).HeaderText = "ຍອດໜີ້"
            .Columns(5).HeaderText = "ຈ່າຍແລ້ວ"
            .Columns(6).HeaderText = "ຈ່າຍມື້ນີ້"
            .Columns(7).Visible = False
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(3).DefaultCellStyle.Format = "N0"
            .Columns(4).DefaultCellStyle.Format = "N0"
            .Columns(5).DefaultCellStyle.Format = "N0"
            .Columns(6).DefaultCellStyle.Format = "N0"
            '.Columns(7).DefaultCellStyle.Format = "#,###.00"
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.M
        End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub dgvproduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproduct.CellContentClick

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            If dgvproduct.Rows.Count > 0 Then
                frmreportSumarysaledebit.ShowDialog()
                frmreportSumarysaledebit.Close()
            Else

            End If

            'btnreport.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class