Public Class frmcustomerpay
    Dim pay As New tbpay
    Dim cus As New tbsuppliers
    Dim sale As New tbsales
    Public saleID As String
    'Dim supID As String
    Public formcustomerpay As Boolean
    Dim adkip As Double
    Dim adbath As Double
    Dim peroid As Integer
    Public dtpay As New DataTable
    Public dtpay1 As New DataTable
    Dim notpay As Double
    Dim frm As frmmain = CType(Application.OpenForms("frmmain"), frmmain)
    Dim frmcustomerdebitlist1 As frmcustomerdebitlist = DirectCast(Application.OpenForms("frmcustomerdebitlist"), frmcustomerdebitlist)
    Dim exchang As Double
    Public mainmoney As String

    Private Sub frmcustomerpay_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'Try

        If frmcustomerdebitlist1.rddate.Checked = True Then
            frmcustomerdebitlist1.dgvshow.Columns.Clear()
            frmcustomerdebitlist1.dgvshow.Rows.Clear()
            frmcustomerdebitlist1.format_salelist()
            frmcustomerdebitlist1.dt.Clear()
            sale.viewsaledebit_bydate_datatable_approve("ຕິດໜີ້", Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), frmcustomerdebitlist1.dt)
            For i As Integer = 0 To frmcustomerdebitlist1.dt.Rows.Count - 1
                Dim idd As String = frmcustomerdebitlist1.dt.Rows(i).Item(0)
                Dim payname As String = frmcustomerdebitlist1.dt.Rows(i).Item(1)
                Dim salename As String = frmcustomerdebitlist1.dt.Rows(i).Item(29)
                Dim buyname As String = frmcustomerdebitlist1.dt.Rows(i).Item(3)
                Dim discount As Double = frmcustomerdebitlist1.dt.Rows(i).Item(4)
                Dim vath As Double = frmcustomerdebitlist1.dt.Rows(i).Item(5)
                Dim totalsale As Double = frmcustomerdebitlist1.dt.Rows(i).Item(6)
                Dim deposit As Double = frmcustomerdebitlist1.dt.Rows(i).Item(7)
                Dim notpay As Double = frmcustomerdebitlist1.dt.Rows(i).Item(8)
                Dim mainmoney As String = frmcustomerdebitlist1.dt.Rows(i).Item(9)
                Dim saledate As String = frmcustomerdebitlist1.dt.Rows(i).Item(10)
                Dim status As String = frmcustomerdebitlist1.dt.Rows(i).Item(11)
                Dim sup_id As String = frmcustomerdebitlist1.dt.Rows(i).Item(17)
                Dim note As String = frmcustomerdebitlist1.dt.Rows(i).Item(19)
                Dim datecredit As Integer = frmcustomerdebitlist1.dt.Rows(i).Item(23)
                frmcustomerdebitlist1.dgvshow.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, sup_id, note, datecredit)
            Next
        ElseIf frmcustomerdebitlist1.rdall.Checked = True Then
            frmcustomerdebitlist1.dgvshow.Columns.Clear()
            frmcustomerdebitlist1.dgvshow.Rows.Clear()
            frmcustomerdebitlist1.format_salelist()
            frmcustomerdebitlist1.dt.Clear()
            sale.viewsaledebit_bydate_datatable_approve_all("ຕິດໜີ້", frmcustomerdebitlist1.dt)
            For i As Integer = 0 To frmcustomerdebitlist1.dt.Rows.Count - 1
                Dim idd As String = frmcustomerdebitlist1.dt.Rows(i).Item(0)
                Dim payname As String = frmcustomerdebitlist1.dt.Rows(i).Item(1)
                Dim salename As String = frmcustomerdebitlist1.dt.Rows(i).Item(29)
                Dim buyname As String = frmcustomerdebitlist1.dt.Rows(i).Item(3)
                Dim discount As Double = frmcustomerdebitlist1.dt.Rows(i).Item(4)
                Dim vath As Double = frmcustomerdebitlist1.dt.Rows(i).Item(5)
                Dim totalsale As Double = frmcustomerdebitlist1.dt.Rows(i).Item(6)
                Dim deposit As Double = frmcustomerdebitlist1.dt.Rows(i).Item(7)
                Dim notpay As Double = frmcustomerdebitlist1.dt.Rows(i).Item(8)
                Dim mainmoney As String = frmcustomerdebitlist1.dt.Rows(i).Item(9)
                Dim saledate As String = frmcustomerdebitlist1.dt.Rows(i).Item(10)
                Dim status As String = frmcustomerdebitlist1.dt.Rows(i).Item(11)
                Dim sup_id As String = frmcustomerdebitlist1.dt.Rows(i).Item(17)
                Dim note As String = frmcustomerdebitlist1.dt.Rows(i).Item(19)
                Dim datecredit As Integer = frmcustomerdebitlist1.dt.Rows(i).Item(23)
                frmcustomerdebitlist1.dgvshow.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, sup_id, note, datecredit)
            Next
        End If
        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub frmcustomerpay_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        sale.select_mainmoney(frmcustomerdebitlist.dgvshow.CurrentRow.Cells(0).Value, dtpay1)
        If dtpay1.Rows.Count > 0 Then
            If dtpay1.Rows(0).Item(0) = "ກີບ" Then
                rdkip.Checked = True
            ElseIf dtpay1.Rows(0).Item(0) = "ບາດ" Then
                rdbath.Checked = True
            Else
                rddolla.Checked = True
            End If
        End If



        saleID = frmcustomerdebitlist.dgvshow.CurrentRow.Cells(0).Value
        dgvshow.Columns.Clear()
        dgvshow.Rows.Clear()
        Makecollumnspay()
        dtpay.Clear()
        pay.select_viewpay(frmcustomerdebitlist.dgvshow.CurrentRow.Cells(0).Value, dtpay)
        For i As Integer = 0 To dtpay.Rows.Count - 1
            Dim paycount As String = dtpay.Rows(i).Item(0)
            Dim saleno As String = dtpay.Rows(i).Item(1)
            Dim salename As String = dtpay.Rows(i).Item(2)
            Dim totalbill As Double = dtpay.Rows(i).Item(3)
            Dim todaypay As Double = dtpay.Rows(i).Item(4)
            Dim moneynotpay As Double = dtpay.Rows(i).Item(5)
            Dim paydate As String = dtpay.Rows(i).Item(6)
            Dim nextpaydate As String = dtpay.Rows(i).Item(7)
            dgvshow.Rows.Add(paycount, saleno, salename, totalbill, todaypay, moneynotpay, paydate, nextpaydate)
        Next
        txtpay.Text = 0
        txtremindpay.Text = 0

        Dim a As Integer = dgvshow.Rows.Count
        notpay = dgvshow.Rows(a - 1).Cells(5).Value
        txtnotpay.Text = notpay.ToString("#,###.0")
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
            .Columns(1).HeaderText = "ເລກບີນ"
            .Columns(2).HeaderText = "ຜູ້ຂາຍ"
            .Columns(3).HeaderText = "ມູນຄ່າ"
            .Columns(4).HeaderText = "ຈ່າຍແລ້ວ"
            .Columns(5).HeaderText = "ຕິດໜີ້"
            .Columns(6).HeaderText = "ວັນທີຈ່າຍ"
            .Columns(7).HeaderText = "ວັນທີຄັ້ງໜ້າ"
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).DefaultCellStyle.Format = "#,###.0"
            .Columns(4).DefaultCellStyle.Format = "#,###.0"
            .Columns(5).DefaultCellStyle.Format = "#,###.0"
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
                txtremindpay.Text = 0
                txtpay.Text = 0
            End If
            Dim tem As Double = txtpay.Text
            txtpay.Text = tem.ToString("N0")
            txtpay.SelectionStart = txtpay.TextLength
            Dim a As Integer = CDbl(txtnotpay.Text) - CDbl(txtpay.Text)
            txtremindpay.Text = a.ToString("N0")


            Dim total As Double
            sale.select_mainmoney(frmcustomerdebitlist.dgvshow.CurrentRow.Cells(0).Value, dtpay1)

            If dtpay1.Rows.Count > 0 Then
                Dim holdcurrency As Double = 0
                total = CInt(txtnotpay.Text)
                Dim remindpay As Double
                If dtpay1.Rows(0).Item(0) = "ກີບ" Then
                    If rdkip.Checked = True Then
                        exchang = (Val(CInt(txtpay.Text)))
                        remindpay = total - (Val(CInt(txtpay.Text)))
                        txtremindpay.Text = remindpay.ToString("N0")

                    ElseIf rdbath.Checked = True Then
                        exchang = (Val(CInt(txtpay.Text)) * frmmain.labath.Text)
                        remindpay = total - (Val(CInt(txtpay.Text)) * frmmain.labath.Text)
                        txtremindpay.Text = remindpay.ToString("N0")
                    Else

                        exchang = (Val(CInt(txtpay.Text) * frmmain.ladolla.Text) * frmmain.labath.Text)
                        remindpay = total - (Val(CInt(txtpay.Text) * frmmain.ladolla.Text) * frmmain.labath.Text)

                        txtremindpay.Text = remindpay.ToString("N0")
                    End If

                ElseIf dtpay1.Rows(0).Item(0) = "ບາດ" Then

                    If rdkip.Checked = True Then
                        exchang = (Val(CInt(txtpay.Text)) / frmmain.labath.Text)
                        remindpay = total - (Val(CInt(txtpay.Text)) / frmmain.labath.Text)
                        txtremindpay.Text = remindpay.ToString("N0")
                    ElseIf rdbath.Checked = True Then
                        exchang = (Val(CInt(txtpay.Text)))
                        remindpay = total - (Val(CInt(txtpay.Text)))
                        txtremindpay.Text = remindpay.ToString("N0")
                    Else
                        exchang = (Val(CInt(txtpay.Text) * frmmain.ladolla.Text) / frmmain.labath.Text)
                        remindpay = total - (Val(CInt(txtpay.Text) * frmmain.ladolla.Text) / frmmain.labath.Text)

                        txtremindpay.Text = remindpay.ToString("N0")
                    End If

                Else
                    If rdkip.Checked = True Then

                        exchang = (Val(CInt(txtpay.Text) / frmmain.ladolla.Text))

                        remindpay = total - (Val(CInt(txtpay.Text) / frmmain.ladolla.Text))

                        txtremindpay.Text = remindpay.ToString("N0")

                    ElseIf rdbath.Checked = True Then
                        exchang = (Val(CInt(txtpay.Text) * frmmain.labath.Text) / frmmain.ladolla.Text)
                        remindpay = total - (Val(CInt(txtpay.Text) * frmmain.labath.Text) / frmmain.ladolla.Text)
                        txtremindpay.Text = remindpay.ToString("N0")
                    Else

                        exchang = (Val(CInt(txtpay.Text)))
                        remindpay = total - (Val(CInt(txtpay.Text)))
                        txtremindpay.Text = remindpay.ToString("N0")

                    End If
                End If
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
        Try
            If Val(txtpay.Text) = 0 Then
                MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນເງີນທີຕ້ອງການຈ່າຍ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtpay.Select()
                Return
            End If
            If exchang > Val(CInt(txtnotpay.Text)) Then
                MessageBox.Show("ມູນຄ່າການຈ່າຍຫລາຍກ່ວາຈໍານວນເງີນ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtpay.Select()
                Return
            End If

            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກການຈ່າຍແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Dim paycount As Integer = pay.count_pay(saleID)
                If Val(CInt(txtremindpay.Text)) > 10 Then
                    sale.savepay(saleID, txtpay.Text, Format(CDate(dt1.Text), "MM/dd/yyyy"), txtremindpay.Text, Format(CDate(dt1.Text), "MM/dd/yyyy"), 5, paycount)
                    dgvshow.Columns.Clear()
                    dgvshow.Rows.Clear()
                    Makecollumnspay()
                    dtpay.Clear()
                    pay.select_viewpay(frmcustomerdebitlist.dgvshow.CurrentRow.Cells(0).Value, dtpay)
                    For i As Integer = 0 To dtpay.Rows.Count - 1
                        Dim paycount1 As String = dtpay.Rows(i).Item(0)
                        Dim saleno As String = dtpay.Rows(i).Item(1)
                        Dim salename As String = dtpay.Rows(i).Item(2)
                        Dim totalbill As Double = dtpay.Rows(i).Item(3)
                        Dim todaypay As Double = dtpay.Rows(i).Item(4)
                        Dim moneynotpay As Double = dtpay.Rows(i).Item(5)
                        Dim paydate As String = dtpay.Rows(i).Item(6)
                        Dim nextpaydate As String = dtpay.Rows(i).Item(7)
                        dgvshow.Rows.Add(paycount1, saleno, salename, totalbill, todaypay, moneynotpay, paydate, nextpaydate)
                    Next

                    Dim ac As Integer = dgvshow.Rows.Count
                    notpay = dgvshow.Rows(ac - 1).Cells(5).Value
                    txtnotpay.Text = notpay.ToString("#,###.0")
                    txtpay.Text = ""
                    txtpay.Select()

                Else
                    sale.savepay(saleID, txtpay.Text, Format(CDate(dt1.Text), "MM/dd/yyyy"), txtremindpay.Text, Format(CDate(dt1.Text), "MM/dd/yyyy"), 5, paycount)
                    dgvshow.Columns.Clear()
                    dgvshow.Rows.Clear()
                    Makecollumnspay()
                    dtpay.Clear()
                    pay.select_viewpay(frmcustomerdebitlist.dgvshow.CurrentRow.Cells(0).Value, dtpay)
                    For i As Integer = 0 To dtpay.Rows.Count - 1
                        Dim paycount1 As String = dtpay.Rows(i).Item(0)
                        Dim saleno As String = dtpay.Rows(i).Item(1)
                        Dim salename As String = dtpay.Rows(i).Item(2)
                        Dim totalbill As Double = dtpay.Rows(i).Item(3)
                        Dim todaypay As Double = dtpay.Rows(i).Item(4)
                        Dim moneynotpay As Double = dtpay.Rows(i).Item(5)
                        Dim paydate As String = dtpay.Rows(i).Item(6)
                        Dim nextpaydate As String = dtpay.Rows(i).Item(7)
                        dgvshow.Rows.Add(paycount1, saleno, salename, totalbill, todaypay, moneynotpay, paydate, nextpaydate)
                    Next
                    Dim a1 As Integer = dgvshow.Rows.Count
                    notpay = dgvshow.Rows(a1 - 1).Cells(5).Value
                    txtnotpay.Text = notpay.ToString("#,###.0")
                    txtpay.Text = ""
                    txtpay.Select()
                End If
                Dim a As Integer = dgvshow.Rows.Count - 1
                Dim b As Integer = dgvshow.Rows(a).Cells(7).Value
                txtnotpay.Text = b.ToString("#,###.0")
                txtpay.Clear()
                txtremindpay.Clear()
                txtpay.Select()
            Else

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdkip.CheckedChanged
        If rdkip.Checked = True Then
            txtpay.Enabled = True
            Dim a As Double = txtnotpay.Text
            Dim b As Double = txtpay.Text
            txtremindpay.Text = a - b
        ElseIf rdbath.Checked = True Then

        Else

        End If
    End Sub

    Private Sub rdbath_CheckedChanged(sender As Object, e As EventArgs) Handles rdbath.CheckedChanged

    End Sub

    Private Sub rddolla_CheckedChanged(sender As Object, e As EventArgs) Handles rddolla.CheckedChanged

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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        If dt1.Text > dall.Text Then
            MessageBox.Show("ທ່ານບໍ່ສາມາດເລືອກວັນທີ່ເກີນວັນປະຈຸບັນໄດ້", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dt1.Text = System.DateTime.Now.ToString
        End If
    End Sub
End Class