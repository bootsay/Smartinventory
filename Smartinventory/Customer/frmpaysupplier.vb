Public Class frmpaysupplier
    Dim orderpay As New tbpayorder
    Dim cus As New tbsuppliers
    Dim sale As New tbsales
    Dim order As New tborder
    Public orderNO As String
    'Dim supID As String
    Public formpaysupplier As Boolean
    Dim adkip As Double
    Dim adbath As Double
    Dim peroid As Integer
    Public dtpay As New DataTable
    Dim notpay As Double
    Dim frm As frmmain = CType(Application.OpenForms("frmmain"), frmmain)
    Dim frmdebitcustomerlist1 As frmdebitcustomerlist = CType(Application.OpenForms("frmdebitcustomerlist"), frmdebitcustomerlist)
    Private Sub frmpaysupplier_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
          
            If frmdebitcustomerlist1.rdate.Checked = True Then
                dgvshow.Columns.Clear()
                dgvshow.Rows.Clear()
                frmdebitcustomerlist1.Ordercolumns()
                frmdebitcustomerlist1.dtorder.Clear()
                order.loadorder_dt(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), frmdebitcustomerlist1.dtorder, "ຕິດໜີ້", "ປົກກະຕິ")
                'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)
                For i As Integer = 0 To frmdebitcustomerlist1.dtorder.Rows.Count - 1
                    Dim orderno1 As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(0)
                    Dim pay As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(2)
                    Dim ordername As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(12)
                    Dim buyfrom As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(3)
                    Dim discount1 As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(4)
                    Dim total As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(5)
                    Dim totalpay As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(6)
                    Dim notpay As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(7)
                    Dim saledate1 As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(8)
                    Dim status As Integer = frmdebitcustomerlist1.dtorder.Rows(i).Item(27)
                    Dim receive As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(11)
                    Dim note1 As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(9)
                    Dim mainmoney As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(25)
                    Dim sup_id As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(24)
                    Dim supname As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(3)
                    If status = 5 Then
                        status = False
                    Else
                        status = True
                    End If
                    If receive = "NO" Then
                        receive = False
                    Else
                        receive = True
                    End If
                    frmdebitcustomerlist1.dgvshow.Rows.Add(orderno1, pay, ordername, buyfrom, discount1, total, totalpay, notpay, saledate1, status, receive, note1, mainmoney, sup_id, supname)
                Next
            ElseIf frmdebitcustomerlist1.rid.Checked = True Then
                order.vieworder_byid(frmdebitcustomerlist1.txtsearch.Text, frmdebitcustomerlist1.dtorder)
                frmdebitcustomerlist1.dgvshow.Columns.Clear()
                frmdebitcustomerlist1.dgvshow.Rows.Clear()
                frmdebitcustomerlist1.Ordercolumns()
                frmdebitcustomerlist1.dtorder.Clear()
                order.loadorder_dt(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), frmdebitcustomerlist1.dtorder, "ຕິດໜີ້", "ປົກກະຕິ")
                'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)
                For i As Integer = 0 To frmdebitcustomerlist1.dtorder.Rows.Count - 1
                    Dim orderno1 As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(0)
                    Dim pay As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(2)
                    Dim ordername As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(12)
                    Dim buyfrom As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(3)
                    Dim discount1 As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(4)
                    Dim total As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(5)
                    Dim totalpay As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(6)
                    Dim notpay As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(7)
                    Dim saledate1 As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(8)
                    Dim status As Integer = frmdebitcustomerlist1.dtorder.Rows(i).Item(27)
                    Dim receive As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(11)
                    Dim note1 As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(9)
                    Dim mainmoney As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(25)
                    Dim sup_id As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(24)
                    Dim supname As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(3)
                    If status = 5 Then
                        status = False
                    Else
                        status = True
                    End If
                    If receive = "NO" Then
                        receive = False
                    Else
                        receive = True
                    End If
                    frmdebitcustomerlist1.dgvshow.Rows.Add(orderno1, pay, ordername, buyfrom, discount1, total, totalpay, notpay, saledate1, status, receive, note1, mainmoney, sup_id, supname)
                Next
                frmdebitcustomerlist1.txtshow.Text = dgvshow.Rows.Count

            ElseIf frmdebitcustomerlist1.rstatus.Checked = True Then

                frmdebitcustomerlist1.dtorder.Clear()
                frmdebitcustomerlist1.dgvshow.Columns.Clear()
                frmdebitcustomerlist1.dgvshow.Rows.Clear()
                frmdebitcustomerlist1.Ordercolumns()
                order.viewstatus(frmdebitcustomerlist1.cbstatus.SelectedItem.ToString, frmdebitcustomerlist1.dtorder, "ຕິດໜີ້")
                'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)
                For i As Integer = 0 To frmdebitcustomerlist1.dtorder.Rows.Count - 1
                    Dim orderno1 As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(0)
                    Dim pay As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(2)
                    Dim ordername As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(12)
                    Dim buyfrom As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(3)
                    Dim discount1 As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(4)
                    Dim total As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(5)
                    Dim totalpay As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(6)
                    Dim notpay As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(7)
                    Dim saledate1 As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(8)
                    Dim status As Integer = frmdebitcustomerlist1.dtorder.Rows(i).Item(27)
                    Dim receive As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(11)
                    Dim note1 As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(9)
                    Dim mainmoney As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(25)
                    Dim sup_id As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(24)
                    Dim supname As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(3)
                    If status = 5 Then
                        status = False
                    Else
                        status = True
                    End If
                    If receive = "NO" Then
                        receive = False
                    Else
                        receive = True
                    End If
                    frmdebitcustomerlist1.dgvshow.Rows.Add(orderno1, pay, ordername, buyfrom, discount1, total, totalpay, notpay, saledate1, status, receive, note1, mainmoney, sup_id, supname)
                Next
                frmdebitcustomerlist1.txtshow.Text = dgvshow.Rows.Count


            ElseIf frmdebitcustomerlist1.rdcustomer.Checked = True Then
                frmdebitcustomerlist1.formorder = True
                frmshowcustomer.ShowDialog()
                frmshowcustomer.Close()
                frmdebitcustomerlist1.formorder = False
                frmdebitcustomerlist1.dgvshow.Columns.Clear()
                frmdebitcustomerlist1.dgvshow.Rows.Clear()
                frmdebitcustomerlist1.Ordercolumns()
                frmdebitcustomerlist1.dtorder.Clear()
                order.loadorder_bysupplier(frmdebitcustomerlist1.sup_id, frmdebitcustomerlist1.dtorder)
                'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)
                For i As Integer = 0 To frmdebitcustomerlist1.dtorder.Rows.Count - 1
                    Dim orderno1 As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(0)
                    Dim pay As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(2)
                    Dim ordername As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(12)
                    Dim buyfrom As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(3)
                    Dim discount1 As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(4)
                    Dim total As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(5)
                    Dim totalpay As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(6)
                    Dim notpay As Double = frmdebitcustomerlist1.dtorder.Rows(i).Item(7)
                    Dim saledate1 As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(8)
                    Dim status As Integer = frmdebitcustomerlist1.dtorder.Rows(i).Item(27)
                    Dim receive As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(11)
                    Dim note1 As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(9)
                    Dim mainmoney As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(25)
                    Dim sup_id As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(24)
                    Dim supname As String = frmdebitcustomerlist1.dtorder.Rows(i).Item(3)
                    If status = 5 Then
                        status = False
                    Else
                        status = True
                    End If
                    If receive = "NO" Then
                        receive = False
                    Else
                        receive = True
                    End If
                    frmdebitcustomerlist1.dgvshow.Rows.Add(orderno1, pay, ordername, buyfrom, discount1, total, totalpay, notpay, saledate1, status, receive, note1, mainmoney, sup_id, supname)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmcustomerpay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        orderNO = frmdebitcustomerlist.dgvshow.CurrentRow.Cells(0).Value
        dgvshow.Columns.Clear()
        dgvshow.Rows.Clear()
        Makecollumnspay()
        dtpay.Clear()
        orderpay.select_viewpay(orderNO, dtpay)
        For i As Integer = 0 To dtpay.Rows.Count - 1
            Dim paycount As Integer = dtpay.Rows(i).Item(0)
            Dim laoname As String = dtpay.Rows(i).Item(2)
            Dim supplier As String = dtpay.Rows(i).Item(3)
            Dim totalbill As Double = dtpay.Rows(i).Item(4)
            Dim todaypay As Double = dtpay.Rows(i).Item(5)
            Dim moneynotpay As Double = dtpay.Rows(i).Item(6)
            Dim paydate As String = dtpay.Rows(i).Item(7)
            Dim nextpaydate As String = dtpay.Rows(i).Item(8)
            dgvshow.Rows.Add(paycount, laoname, supplier, totalbill, todaypay, moneynotpay, paydate, nextpaydate)
        Next
        dt2.Text = Today.AddDays(30)
        txtpay.Text = 0

        Dim a As Integer = dgvshow.Rows.Count
        notpay = dgvshow.Rows(a - 1).Cells(5).Value
        txtnotpay.Text = notpay.ToString("#,###.00")
        txtremindpay.Text = notpay.ToString("#,###.00")
        txtpay.Select()
    End Sub
    Private Sub Makecollumnspay()
        Dim paycount As New DataGridViewTextBoxColumn
        Dim saleno As New DataGridViewTextBoxColumn
        Dim salename As New DataGridViewTextBoxColumn
        Dim totalbill As New DataGridViewTextBoxColumn
        Dim todaypay As New DataGridViewTextBoxColumn
        Dim moneynotpay As New DataGridViewTextBoxColumn
        Dim paydate As New DataGridViewTextBoxColumn
        Dim nextpaydate As New DataGridViewTextBoxColumn

        dgvshow.Columns.Add(paycount)
        dgvshow.Columns.Add(saleno)
        dgvshow.Columns.Add(salename)
        dgvshow.Columns.Add(totalbill)
        dgvshow.Columns.Add(todaypay)
        dgvshow.Columns.Add(moneynotpay)
        dgvshow.Columns.Add(paydate)
        dgvshow.Columns.Add(nextpaydate)
        With dgvshow
            .Columns(0).HeaderText = "ລໍາດັບ"
            .Columns(1).HeaderText = "ຜູ້ອອກບີນ"
            .Columns(2).HeaderText = "ຜູ້ຂາຍ"
            .Columns(3).HeaderText = "ມູນຄ່າ"
            .Columns(4).HeaderText = "ຈ່າຍແລ້ວ"
            .Columns(5).HeaderText = "ຕິດໜີ້"
            .Columns(6).HeaderText = "ວັນທີຈ່າຍ"
            .Columns(7).HeaderText = "ວັນທີຄັ້ງໜ້າ"
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).DefaultCellStyle.Format = "#,###.00"
            .Columns(4).DefaultCellStyle.Format = "#,###.00"
            .Columns(5).DefaultCellStyle.Format = "#,###.00"
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

    Private Sub txtpay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpay.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtpay_TextChanged(sender As Object, e As EventArgs) Handles txtpay.TextChanged
        Try
            If txtpay.Text = "" Then
                txtpay.Text = 0
            End If
            Dim tem As Double = txtpay.Text
            txtpay.Text = tem.ToString("N0")
            txtpay.SelectionStart = txtpay.TextLength
            Dim a As Double = CInt(txtnotpay.Text) - CInt(txtpay.Text)
            txtremindpay.Text = a.ToString("N0")
            If txtpay.Text = "" Then
                txtremindpay.Text = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbpaykob_CheckedChanged(sender As Object, e As EventArgs) Handles cbpaykob.CheckedChanged
        If cbpaykob.Checked = True Then
            txtpay.Text = txtnotpay.Text
            txtpay.ReadOnly = True
            dt2.Enabled = False
        Else
            txtpay.ReadOnly = False
            dt2.Enabled = True
        End If
    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        'Try
        If Val(txtpay.Text) = 0 Then
            MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນເງີນທີຕ້ອງການຈ່າຍ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpay.Select()
            Return
        End If
        If Val(CInt(txtpay.Text)) > Val(CInt(txtnotpay.Text)) Then
            MessageBox.Show("ມູນຄ່າການຈ່າຍຫລາຍກ່ວາຈໍານວນເງີນ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpay.Select()
            Return
        End If

        If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກການຈ່າຍແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim paycount As Integer = orderpay.count_pay(orderNO)
            If Val(CInt(txtremindpay.Text)) > 10 Then
                orderpay.savepayorder(orderNO, txtpay.Text, Format(CDate(dt1.Text), "MM/dd/yyyy"), txtremindpay.Text, Format(CDate(dt2.Text), "MM/dd/yyyy"), 5, paycount)
                dgvshow.Columns.Clear()
                dgvshow.Rows.Clear()
                Makecollumnspay()
                dtpay.Clear()
                orderpay.select_viewpay(orderNO, dtpay)
                For i As Integer = 0 To dtpay.Rows.Count - 1
                    Dim paycount1 As Integer = dtpay.Rows(i).Item(0)
                    Dim laoname As String = dtpay.Rows(i).Item(2)
                    Dim supplier As String = dtpay.Rows(i).Item(3)
                    Dim totalbill As Double = dtpay.Rows(i).Item(4)
                    Dim todaypay As Double = dtpay.Rows(i).Item(5)
                    Dim moneynotpay As Double = dtpay.Rows(i).Item(6)
                    Dim paydate As String = dtpay.Rows(i).Item(7)
                    Dim nextpaydate As String = dtpay.Rows(i).Item(8)
                    dgvshow.Rows.Add(paycount1, laoname, supplier, totalbill, todaypay, moneynotpay, paydate, nextpaydate)
                Next
                'MessageBox.Show("KK")
            Else
                orderpay.savepayorder(orderNO, txtpay.Text, Format(CDate(dt1.Text), "MM/dd/yyyy"), txtremindpay.Text, Format(CDate(dt2.Text), "MM/dd/yyyy"), 5, paycount)
                dgvshow.Columns.Clear()
                dgvshow.Rows.Clear()
                Makecollumnspay()
                dtpay.Clear()
                orderpay.select_viewpay(orderNO, dtpay)
                For i As Integer = 0 To dtpay.Rows.Count - 1
                    Dim paycount1 As Integer = dtpay.Rows(i).Item(0)
                    Dim laoname As String = dtpay.Rows(i).Item(2)
                    Dim supplier As String = dtpay.Rows(i).Item(3)
                    Dim totalbill As Double = dtpay.Rows(i).Item(4)
                    Dim todaypay As Double = dtpay.Rows(i).Item(5)
                    Dim moneynotpay As Double = dtpay.Rows(i).Item(6)
                    Dim paydate As String = dtpay.Rows(i).Item(7)
                    Dim nextpaydate As String = dtpay.Rows(i).Item(8)
                    dgvshow.Rows.Add(paycount1, laoname, supplier, totalbill, todaypay, moneynotpay, paydate, nextpaydate)
                Next

            End If

            Dim a As Integer = dgvshow.Rows.Count - 1
            Dim b As Integer = dgvshow.Rows(a).Cells(5).Value
            txtnotpay.Text = b.ToString("#,###.00")
            txtpay.Clear()
            txtremindpay.Clear()
            txtpay.Select()
        Else

        End If
        txtpay.Clear()
        txtpay.Select()

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        If dt1.Text > dtall.Text Then
            MessageBox.Show("ທ່ານບໍ່ສາມາດເລືອກວັນທີ່ເກີນວັນປະຈຸບັນໄດ້", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dt1.Text = System.DateTime.Now.ToString
        End If
    End Sub

    Private Sub txtnotpay_TextChanged(sender As Object, e As EventArgs) Handles txtnotpay.TextChanged
        If txtnotpay.Text = 0 Then
            dt1.Enabled = False
            dt2.Enabled = False
            cbpaykob.Enabled = False
            txtpay.Enabled = False
        Else
            dt1.Enabled = True
            dt2.Enabled = True
            cbpaykob.Enabled = True
            txtpay.Enabled = True
        End If
    End Sub
End Class