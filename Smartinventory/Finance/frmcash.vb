Public Class frmcash
    Dim inout As New tbwithdraw
    Public txtempid As New TextBox
    Dim sourcetype As New tbincomesource
    Dim pro As New tbproduct
    Dim moneycapital As New tbcapitalmoney
    Dim frm As frmmain = CType(Application.OpenForms("frmmain"), frmmain)
    Dim capitalid As Integer
    Public totalmoney As Double
    Public totalcapitaltotal As Double = 0
    Public totalremind As Double = 0
    Dim account As New tbaccount
    Dim totalmoneypay As Double
    Dim totalmoneyreceive As Double
    Dim totalexistmoney As Double
    Private Sub enableSave()
        btnsave.Enabled = True
        btnedit.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnnew.Enabled = True
    End Sub
    Private Sub enableEdit()
        btnsave.Enabled = False
        btnedit.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = True
        btnnew.Enabled = True
    End Sub
    Private Sub enableUpdate()
        btnsave.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = False
        btnnew.Enabled = True
    End Sub
    Private Sub dgvpay_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvpay.CellMouseUp
        Try
            Try
                With dgvpay
                    txtid.Text = .CurrentRow.Cells(0).Value
                    txtdetail.Text = .CurrentRow.Cells(8).Value
                    cbsource.Text = .CurrentRow.Cells(3).Value
                    txttotal.Text = .CurrentRow.Cells(4).Value
                    cbmainaccount.Text = .CurrentRow.Cells(1).Value
                    txtpayperson.Text = .CurrentRow.Cells(7).Value
                    txtreceiveperson.Text = .CurrentRow.Cells(8).Value
                    txtdetail.ReadOnly = True
                    txttotal.ReadOnly = True
                    enableEdit()
                End With
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnaddsource_Click(sender As Object, e As EventArgs) Handles btnaddsource.Click
        frmaddaccounttype.ShowDialog()
        frmaddaccounttype.Close()
    End Sub

    Private Sub frmcashpay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            txtpayperson.Text = frmmain.lalaoname.Text
            rdoutcome.Checked = True
            account.combocategory(cbmainaccount)
            cbmainaccount.SelectedValue = 1
            txtid.Text = inout.runid

            totalmoney = moneycapital.call_capitalmoney(cbmainaccount.SelectedValue)
            totalmoneypay = inout.sum_paymoney_nodate(cbmainaccount.SelectedValue)
            totalmoneyreceive = inout.sum_receivemoney_nodate(cbmainaccount.SelectedValue)
            totalexistmoney = totalmoney - totalmoneypay + totalmoneyreceive
            txtremindmoney.Text = totalexistmoney.ToString("N0")

            sourcetype.combosourcetype(cbsource)
            txtid.Text = inout.runid
            Dim pay As String
            If rdincome.Checked = True Then
                pay = "ຮັບ"
            Else
                pay = "ຈ່າຍ"
            End If
            inout.viewwithdraw(cbmainaccount.SelectedValue, dgvpay, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt1.Text), "MM/dd/yyyy"), "ຈ່າຍ")
            cbsource.SelectedValue = 1
            dt1.Enabled = False
            txtid.ReadOnly = True
            txttotal.Select()
            enableSave()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        Try
            Dim tem As Double = txttotal.Text
            txttotal.Text = tem.ToString("N0")
            txttotal.SelectionStart = txttotal.TextLength
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txttotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotal.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If cbsource.SelectedValue < 1 Then
            MessageBox.Show("ກະລຸນາເລືອກປະເພດບັນຊີ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If txtdetail.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtdetail.Select()
            Return
        End If
        If txttotal.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttotal.Select()
            Return
        End If
        Dim pay As String
        If rdincome.Checked = True Then
            pay = "ຮັບ"
        Else
            pay = "ຈ່າຍ"
            If Val(CInt(txttotal.Text) > Val(CInt(txtremindmoney.Text))) Then
                MessageBox.Show("ມູນຄ່າຫລາຍກ່ວາເງີນໃນຄັງ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If
       
        If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim idd As Integer = inout.runid
            Dim totalpay As Double
            Dim totalrecieve As Double
            If rdoutcome.Checked = True Then
                totalpay = txttotal.Text
                totalrecieve = 0
            Else
                totalrecieve = txttotal.Text
                totalpay = 0
            End If
            Dim remindtotal As Double
            If rdincome.Checked = True Then
                remindtotal = totalexistmoney + Val(CInt(txttotal.Text))
            Else
                remindtotal = totalexistmoney - Val(CInt(txttotal.Text))
            End If
            'Dim remindtotal As Double = totalexistmoney - Val(CInt(txttotal.Text))
            inout.savewithdraw(idd, frmmain.userid, cbmainaccount.SelectedValue, cbsource.SelectedValue, txtpayperson.Text, txtreceiveperson.Text, totalpay, totalrecieve, remindtotal, txtdetail.Text, pay, Format(CDate(dt1.Text), "MM/dd/yyyy"))
            'Dim dt As New DataTable
            'dt.Clear()
            'moneycapital.select_capitalmoney(cbmainaccount.SelectedValue, dt)
            'Dim total As Double = Val(CInt(txttotal.Text))
            'Dim ddt As New mydata
            'ddt.tbwithdraw.Clear()
            'For i As Integer = 0 To dt.Rows.Count - 1
            '    Dim totalmoney As Double = dt.Rows(i).Item(2)
            '    Dim id As Double = dt.Rows(i).Item(0)
            '    Dim totale As Double = totalmoney - total
            '    'ddt.tbwithdraw.Rows.Add(id, totalmoney, )
            'Next
            'dgv.DataSource = ddt.tbwithdraw
            'Return
            'totalmoney = moneycapital.call_capitalmoney(cbmainaccount.SelectedValue)
            txtremindmoney.Text = totalmoney.ToString("N0")
            If rdincome.Checked = True Then
                pay = "ຮັບ"
            Else
                pay = "ຈ່າຍ"
            End If
            inout.viewwithdraw(cbmainaccount.SelectedValue, dgvpay, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt1.Text), "MM/dd/yyyy"), pay)
            txtid.Text = inout.runid
            totalmoney = moneycapital.call_capitalmoney(cbmainaccount.SelectedValue)
            totalmoneypay = inout.sum_paymoney_nodate(cbmainaccount.SelectedValue)
            totalmoneyreceive = inout.sum_receivemoney_nodate(cbmainaccount.SelectedValue)
            totalexistmoney = totalmoney - totalmoneypay + totalmoneyreceive
            txtremindmoney.Text = totalexistmoney.ToString("N0")
            txtdetail.Clear()
            txttotal.Clear()
            txttotal.Select()
            enableSave()
        Else

        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        Try
            If MessageBox.Show("ທ່ານຕ້ອງການລືບຂໍ້ມູນແທ້ບໍ່", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                inout.delete(txtid.Text)
                txtdetail.ReadOnly = False
                txttotal.ReadOnly = False
                txtdetail.Clear()
                txttotal.Clear()
                txtdetail.Select()
                txtid.Text = inout.runid
                Dim pay As String
                If rdincome.Checked = True Then
                    pay = "ຮັບ"
                Else
                    pay = "ຈ່າຍ"
                End If
                inout.viewwithdraw(cbmainaccount.SelectedValue, dgvpay, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt1.Text), "MM/dd/yyyy"), pay)
                totalmoney = moneycapital.call_capitalmoney(cbmainaccount.SelectedValue)
                totalmoneypay = inout.sum_paymoney_nodate(cbmainaccount.SelectedValue)
                totalmoneyreceive = inout.sum_receivemoney_nodate(cbmainaccount.SelectedValue)
                totalexistmoney = totalmoney - totalmoneypay + totalmoneyreceive
                txtremindmoney.Text = totalexistmoney.ToString("N0")
                enableSave()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try

            If txtdetail.Text = "" Then
                MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtdetail.Select()
                Return
            End If
            If txttotal.Text = "" Then
                MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txttotal.Select()
                Return
            End If
            Dim pay As String
            If rdincome.Checked = True Then
                pay = "ຮັບ"
            Else
                pay = "ຈ່າຍ"
            End If
            Dim totalpay As Double
            Dim totalrecieve As Double
            If rdoutcome.Checked = True Then
                totalpay = txttotal.Text
                totalrecieve = 0
            Else
                totalrecieve = txttotal.Text
                totalpay = 0
            End If

            'inout.updatewithdraw(txtid.Text, frmmain.userid, cbmainaccount.SelectedValue, cbsource.SelectedValue, txtpayperson.Text, txtreceiveperson.Text, totalpay, totalrecieve, remindtotal, txtdetail.Text, pay)

            'inout.delete(txtid.Text)
            'txtdetail.ReadOnly = False
            'txttotal.ReadOnly = False
            'txtdetail.Clear()
            'txttotal.Clear()
            'txtdetail.Select()
            'txtid.Text = inout.runid
            inout.viewwithdraw(cbmainaccount.SelectedValue, dgvpay, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt1.Text), "MM/dd/yyyy"), pay)
            totalmoney = moneycapital.call_capitalmoney(cbmainaccount.SelectedValue)
            totalmoneypay = inout.sum_paymoney_nodate(cbmainaccount.SelectedValue)
            totalmoneyreceive = inout.sum_receivemoney_nodate(cbmainaccount.SelectedValue)
            totalexistmoney = totalmoney - totalmoneypay + totalmoneyreceive
            txtremindmoney.Text = totalexistmoney.ToString("N0")

            enableSave()
            txtid.Text = inout.runid
            txtdetail.Clear()
            txttotal.Clear()
            txttotal.Select()
            enableSave()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click

        txtid.Text = inout.runid
        Dim pay As String
        If rdincome.Checked = True Then
            pay = "ຮັບ"
        Else
            pay = "ຈ່າຍ"
        End If
        inout.viewwithdraw(cbmainaccount.SelectedValue, dgvpay, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt1.Text), "MM/dd/yyyy"), pay)
        txtdetail.Clear()
        txttotal.Clear()
        txtreceiveperson.Clear()
        txtdetail.Clear()
        txtdetail.ReadOnly = False
        txttotal.ReadOnly = False
        txttotal.Select()
        enableSave()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtdetail.ReadOnly = False
        txttotal.ReadOnly = False
        txtdetail.Select()
        enableUpdate()

    End Sub

    Private Sub cbmainaccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmainaccount.SelectedIndexChanged
        Try
            Dim pay As String = Nothing
            If rdincome.Checked = True Then
                pay = "ຮັບ"
            Else
                pay = "ຈ່າຍ"
            End If
            inout.viewwithdraw(cbmainaccount.SelectedValue, dgvpay, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt1.Text), "MM/dd/yyyy"), pay)
            totalmoney = moneycapital.call_capitalmoney(cbmainaccount.SelectedValue)
            totalmoneypay = inout.sum_paymoney_nodate(cbmainaccount.SelectedValue)
            totalmoneyreceive = inout.sum_receivemoney_nodate(cbmainaccount.SelectedValue)
            totalexistmoney = totalmoney - totalmoneypay + totalmoneyreceive
            txtremindmoney.Text = totalexistmoney.ToString("N0")
            txttotal.Clear()
            txtdetail.Clear()
            txtdetail.ReadOnly = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabItem2_Click(sender As Object, e As EventArgs) Handles TabItem2.Click
        Try
            account.combocategory(cbmainaccountsearch)
            dtt1.Text = Today.Date
            dtt2.Text = Today.Date
            Dim pay As String = Nothing
            If rdincome.Checked = True Then
                pay = "ຮັບ"
            Else
                pay = "ຈ່າຍ"
            End If
            inout.viewwithdraw(cbmainaccount.SelectedValue, dgvpay, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt1.Text), "MM/dd/yyyy"), pay)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        'Try
        Dim pay As String = "%"
        inout.viewwithdraw(cbmainaccount.SelectedValue, dgvlist, Format(CDate(dtt1.Text), "MM/dd/yyyy"), Format(CDate(dtt2.Text), "MM/dd/yyyy"), pay)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub cbmainaccountsearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmainaccountsearch.SelectedIndexChanged
        Try
            Dim pay As String = Nothing
            If rdincome.Checked = True Then
                pay = "ຮັບ"
            Else
                pay = "ຈ່າຍ"
            End If
            inout.viewwithdraw(cbmainaccount.SelectedValue, dgvpay, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt1.Text), "MM/dd/yyyy"), pay)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        'Try
        Dim withno As String = inout.check_existwithdrawNO(txtid.Text)
        If withno > 0 Then
            frmbillcashpay.ShowDialog()
            frmbillcashpay.Close()
        Else

        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        Try
            'totalcapitaltotal = moneycapital.Call_summoneycapital(cbmainaccountsearch.SelectedValue)
            'totalremind = moneycapital.call_capitalmoney(cbmainaccountsearch.SelectedValue)
            frmreportwithdraw.ShowDialog()
            frmreportwithdraw.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdoutcome_CheckedChanged(sender As Object, e As EventArgs) Handles rdoutcome.CheckedChanged
        Try
            Dim pay As String = Nothing
            If rdincome.Checked = True Then
                pay = "ຮັບ"
            Else
                pay = "ຈ່າຍ"
            End If
            inout.viewwithdraw(cbmainaccount.SelectedValue, dgvpay, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt1.Text), "MM/dd/yyyy"), pay)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdincome_CheckedChanged(sender As Object, e As EventArgs) Handles rdincome.CheckedChanged
        Try
            Dim pay As String = Nothing
            If rdincome.Checked = True Then
                pay = "ຮັບ"
            Else
                pay = "ຈ່າຍ"
            End If
            inout.viewwithdraw(cbmainaccount.SelectedValue, dgvpay, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt1.Text), "MM/dd/yyyy"), pay)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellContentClick

    End Sub
End Class