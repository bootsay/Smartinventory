Public Class frmcustomerdebitlist
    Dim cus As New tbsuppliers
    Dim sale As New tbsales
    Public formcustomerdebitlist As Boolean
    Public supid As String
    Public totalkip As Double
    Public totalbath As Double
    Public paykip As Double
    Public paybath As Double
    Public notpaykip As Double
    Public notpaybath As Double
    Public cusname As String
    Dim pay As New tbpay
    Public fcustomer As Boolean = False
    Dim cate As New tbcategory
    Public dt As New DataTable
    Private Sub frmcustomerdebitlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rddate.Checked = True
        dt1.Text = Today.Date
        dt2.Text = Today.Date
        dgvshow.Columns.Clear()
        dgvshow.Rows.Clear()
        format_salelist()
        dt.Clear()
        sale.viewsaledebit_bydate_datatable_approve("ຕິດໜີ້", Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dt)
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim idd As String = dt.Rows(i).Item(0)
            Dim payname As String = dt.Rows(i).Item(1)
            Dim salename As String = dt.Rows(i).Item(29)
            Dim buyname As String = dt.Rows(i).Item(3)
            Dim discount As Double = dt.Rows(i).Item(4)
            Dim vath As Double = dt.Rows(i).Item(5)
            Dim totalsale As Double = dt.Rows(i).Item(6)
            Dim deposit As Double = dt.Rows(i).Item(7)
            Dim notpay As Double = dt.Rows(i).Item(8)
            Dim mainmoney As String = dt.Rows(i).Item(9)
            Dim saledate As String = dt.Rows(i).Item(10)
            Dim status As String = dt.Rows(i).Item(11)
            Dim sup_id As String = dt.Rows(i).Item(17)
            Dim note As String = dt.Rows(i).Item(19)
            Dim datecredit As Integer = dt.Rows(i).Item(23)
            dgvshow.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, sup_id, note, datecredit)
        Next
    End Sub
    Public Sub format_salelist()
        Dim id As New DataGridViewTextBoxColumn
        Dim payname As New DataGridViewTextBoxColumn
        Dim salename As New DataGridViewTextBoxColumn
        Dim buyname As New DataGridViewTextBoxColumn
        Dim discount As New DataGridViewTextBoxColumn
        Dim vath As New DataGridViewTextBoxColumn
        Dim totalsale As New DataGridViewTextBoxColumn
        Dim deposite As New DataGridViewTextBoxColumn
        Dim balance As New DataGridViewTextBoxColumn
        Dim money As New DataGridViewTextBoxColumn
        Dim saledate As New DataGridViewTextBoxColumn
        Dim supid As New DataGridViewTextBoxColumn
        Dim note As New DataGridViewTextBoxColumn
        Dim daycredit As New DataGridViewTextBoxColumn
        dgvshow.Columns.Add(id)
        dgvshow.Columns.Add(payname)
        dgvshow.Columns.Add(salename)
        dgvshow.Columns.Add(buyname)
        dgvshow.Columns.Add(discount)
        dgvshow.Columns.Add(vath)
        dgvshow.Columns.Add(totalsale)
        dgvshow.Columns.Add(deposite)
        dgvshow.Columns.Add(balance)
        dgvshow.Columns.Add(money)
        dgvshow.Columns.Add(saledate)
     
        dgvshow.Columns.Add(supid)
        dgvshow.Columns.Add(note)
        dgvshow.Columns.Add(daycredit)
        With dgvshow
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ປະເພດ"
            .Columns(2).HeaderText = "ຜູ້ຂາຍ"
            .Columns(3).HeaderText = "ຜູ້ຊືິ້"
            .Columns(4).HeaderText = "ສ່ວນລຸດ"
            .Columns(5).HeaderText = "ພາສີ"
            .Columns(6).HeaderText = "ລວມ"
            .Columns(7).HeaderText = "ຈ່າຍແລ້ວ"
            .Columns(8).HeaderText = "ຍັງເຫລືອ"
            .Columns(9).HeaderText = "ເງີນ"
            .Columns(10).HeaderText = "ວັນທີຂາຍ"
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(9).Width = 50
        End With
    End Sub
    Private Sub btnpaymoney_Click(sender As Object, e As EventArgs) Handles btnpaymoney.Click
        Try
            If dgvshow.SelectedCells.Count >= 1 Then
                formcustomerdebitlist = True
                frmcustomerpay.ShowDialog()
                frmcustomerpay.Close()
                formcustomerdebitlist = False
            Else

            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Try
            If rddate.Checked = True Then
                dgvshow.Columns.Clear()
                dgvshow.Rows.Clear()
                format_salelist()
                dt.Clear()
                sale.viewsaledebit_bydate_datatable_approve("ຕິດໜີ້", Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim idd As String = dt.Rows(i).Item(0)
                    Dim payname As String = dt.Rows(i).Item(1)
                    Dim salename As String = dt.Rows(i).Item(29)
                    Dim buyname As String = dt.Rows(i).Item(3)
                    Dim discount As Double = dt.Rows(i).Item(4)
                    Dim vath As Double = dt.Rows(i).Item(5)
                    Dim totalsale As Double = dt.Rows(i).Item(6)
                    Dim deposit As Double = dt.Rows(i).Item(7)
                    Dim notpay As Double = dt.Rows(i).Item(8)
                    Dim mainmoney As String = dt.Rows(i).Item(9)
                    Dim saledate As String = dt.Rows(i).Item(10)
                    Dim status As String = dt.Rows(i).Item(11)
                    Dim sup_id As String = dt.Rows(i).Item(17)
                    Dim note As String = dt.Rows(i).Item(19)
                    Dim datecredit As Integer = dt.Rows(i).Item(23)
                    dgvshow.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, sup_id, note, datecredit)
                Next
            ElseIf rdall.Checked = True Then
                dgvshow.Columns.Clear()
                dgvshow.Rows.Clear()
                format_salelist()
                dt.Clear()
                sale.viewsaledebit_bydate_datatable_approve_all("ຕິດໜີ້", dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim idd As String = dt.Rows(i).Item(0)
                    Dim payname As String = dt.Rows(i).Item(1)
                    Dim salename As String = dt.Rows(i).Item(29)
                    Dim buyname As String = dt.Rows(i).Item(3)
                    Dim discount As Double = dt.Rows(i).Item(4)
                    Dim vath As Double = dt.Rows(i).Item(5)
                    Dim totalsale As Double = dt.Rows(i).Item(6)
                    Dim deposit As Double = dt.Rows(i).Item(7)
                    Dim notpay As Double = dt.Rows(i).Item(8)
                    Dim mainmoney As String = dt.Rows(i).Item(9)
                    Dim saledate As String = dt.Rows(i).Item(10)
                    Dim status As String = dt.Rows(i).Item(11)
                    Dim sup_id As String = dt.Rows(i).Item(17)
                    Dim note As String = dt.Rows(i).Item(19)
                    Dim datecredit As Integer = dt.Rows(i).Item(23)
                    dgvshow.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, sup_id, note, datecredit)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

   
    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            With dgvshow

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        Try
            If dgvshow.Rows.Count < 1 Then
                Return
            End If
            frmpaydetail.ShowDialog()
            frmpaydetail.Close()
            'frmreportCustomerpay_debit_detailvb.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub rddate_CheckedChanged(sender As Object, e As EventArgs) Handles rddate.CheckedChanged
        If rddate.Checked = True Then
            txtsearch.Visible = False
            cbstatus.Visible = False
            dt1.Visible = True
            dt2.Visible = True
        ElseIf rdid.Checked = True Then
            txtsearch.Visible = True
            cbstatus.Visible = False
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Select()
        ElseIf rdcusname.Checked = True Then
            txtsearch.Visible = True
            cbstatus.Visible = False
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Select()
        End If
    End Sub

    Private Sub rdid_CheckedChanged(sender As Object, e As EventArgs) Handles rdid.CheckedChanged
        If rddate.Checked = True Then
            txtsearch.Visible = False
            cbstatus.Visible = False
            dt1.Visible = True
            dt2.Visible = True
        ElseIf rdid.Checked = True Then
            txtsearch.Visible = True
            cbstatus.Visible = False
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Select()
      
        ElseIf rdcusname.Checked = True Then
            txtsearch.Visible = True
            cbstatus.Visible = False
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Select()
        End If
    End Sub

    Private Sub rdtype_CheckedChanged(sender As Object, e As EventArgs)
        If rddate.Checked = True Then
            txtsearch.Visible = False
            cbstatus.Visible = False
            dt1.Visible = True
            dt2.Visible = True
        ElseIf rdid.Checked = True Then
            txtsearch.Visible = True
            cbstatus.Visible = False
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Select()
    
        ElseIf rdcusname.Checked = True Then
            txtsearch.Visible = True
            cbstatus.Visible = False
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Select()
        End If
    End Sub

    Private Sub rdcusname_CheckedChanged(sender As Object, e As EventArgs) Handles rdcusname.CheckedChanged
        If rddate.Checked = True Then
            txtsearch.Visible = False
            cbstatus.Visible = False
            dt1.Visible = True
            dt2.Visible = True
        ElseIf rdid.Checked = True Then
            txtsearch.Visible = True
            cbstatus.Visible = False
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Select()
        ElseIf rdcusname.Checked = True Then
            txtsearch.Visible = True
            cbstatus.Visible = False
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Select()
        End If
    End Sub

    Private Sub cbstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbstatus.SelectedIndexChanged
        Try
            'sale.viewsale_status_id("ຕິດໜີ້", cbstatus.SelectedValue, dgvshow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            'If rdid.Checked = True And rdpay.Checked = True Then
            '    sale.viewdebit_finisth_bysaleID(txtsearch.Text, dgvshow)
            'ElseIf rdid.Checked = True And rdnotpay.Checked = True Then
            '    sale.viewdebit_notpay_bysaleID(txtsearch.Text, dgvshow)
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btntransaction_Click(sender As Object, e As EventArgs) Handles btntransaction.Click
        Try
            frmSumarysaledebit.ShowDialog()
            frmSumarysaledebit.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub

    Private Sub dgvshow_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellDoubleClick
        Try
            If dgvshow.SelectedCells.Count >= 1 Then
                formcustomerdebitlist = True
                frmcustomerpay.ShowDialog()
                frmcustomerpay.Close()
                formcustomerdebitlist = False
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class