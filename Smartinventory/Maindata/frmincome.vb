Public Class frmincome
    Dim inout As New tbincome_outcome
    Public txtempid As New TextBox
    Dim sourcetype As New tbincomesource
    Dim pro As New tbproduct
    Dim frm As frmmain = CType(Application.OpenForms("frmmain"), frmmain)
    Private Sub frmofficepay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cbmoney.Enabled = False
        pro.combomoney(cbmoney)
        sourcetype.combosourcetype(cbsource)
        txtid.Text = inout.runid
        Dim pay As String
        rdpay.Checked = True
        If rdget.Checked = True Then
            pay = "ລາຍຮັບ"
        Else
            pay = "ລາຍຈ່າຍ"
        End If
        cbsource.SelectedValue = 1
        inout.viewincome_outcome(cbsource.SelectedValue, pay, dgvpay)
        enableSave()
        dt1.Enabled = False
        txtid.ReadOnly = True
        txttotal.Select()
    End Sub
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
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

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
        If rdget.Checked = True Then
            pay = "ລາຍຮັບ"
        Else
            pay = "ລາຍຈ່າຍ"
        End If
        inout.update(txtid.Text, frmmain.userid, cbsource.SelectedValue, txtdetail.Text, txttotal.Text, cbmoney.SelectedValue, pay)

        If rdget.Checked = True Then
            pay = "ລາຍຮັບ"
        Else
            pay = "ລາຍຈ່າຍ"
        End If
        inout.viewincome_outcome(cbsource.SelectedValue, pay, dgvpay)
        txtid.Text = inout.runid
        txtdetail.Clear()
        txttotal.Clear()
        txttotal.Select()
        enableSave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click

        txtid.Text = inout.runid
        Dim pay As String
        If rdget.Checked = True Then
            pay = "ລາຍຮັບ"
        Else
            pay = "ລາຍຈ່າຍ"
        End If
        inout.viewincome_outcome(cbsource.SelectedValue, pay, dgvpay)
        txtdetail.Clear()
        txttotal.Clear()
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

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        inout.delete(txtid.Text)
        txtdetail.ReadOnly = False
        txttotal.ReadOnly = False
        txtdetail.Clear()
        txttotal.Clear()
        txtdetail.Select()
        txtid.Text = inout.runid
        Dim pay As String
        If rdget.Checked = True Then
            pay = "ລາຍຮັບ"
        Else
            pay = "ລາຍຈ່າຍ"
        End If
        inout.viewincome_outcome(cbsource.SelectedValue, pay, dgvpay)
        enableSave()

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
        If rdget.Checked = True Then
            pay = "ລາຍຮັບ"
        Else
            pay = "ລາຍຈ່າຍ"
        End If

        If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            inout.save(txtid.Text, frmmain.userid, cbsource.SelectedValue, txtdetail.Text, txttotal.Text, cbmoney.SelectedValue, pay, Format(CDate(dt1.Text), "MM/dd/yyyy"), frm.labath.Text)
            If rdget.Checked = True Then
                pay = "ລາຍຮັບ"
            Else
                pay = "ລາຍຈ່າຍ"
            End If
            inout.viewincome_outcome(cbsource.SelectedValue, pay, dgvpay)
            txtid.Text = inout.runid
            txtdetail.Clear()
            txttotal.Clear()
            txttotal.Select()
            enableSave()
        Else

        End If
    End Sub

    Private Sub txttotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotal.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        Try
            Dim tem As Double = txttotal.Text
            txttotal.Text = tem.ToString("N0")
            txttotal.SelectionStart = txttotal.TextLength
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbmoney_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmoney.SelectedIndexChanged

    End Sub

    Private Sub rdget_CheckedChanged(sender As Object, e As EventArgs) Handles rdget.CheckedChanged
        Try
            Dim pay As String
            If rdget.Checked = True Then
                pay = "ລາຍຮັບ"
            Else
                pay = "ລາຍຈ່າຍ"
            End If
            inout.viewincome_outcome(cbsource.SelectedValue, pay, dgvpay)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdpay_CheckedChanged(sender As Object, e As EventArgs) Handles rdpay.CheckedChanged
        Try
            Dim pay As String
            If rdget.Checked = True Then
                pay = "ລາຍຮັບ"
            Else
                pay = "ລາຍຈ່າຍ"
            End If
            inout.viewincome_outcome(cbsource.SelectedValue, pay, dgvpay)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbsource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsource.SelectedIndexChanged
        Try
            Dim pay As String
            If rdget.Checked = True Then
                pay = "ລາຍຮັບ"
            Else
                pay = "ລາຍຈ່າຍ"
            End If
            inout.viewincome_outcome(cbsource.SelectedValue, pay, dgvpay)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnaddsource_Click(sender As Object, e As EventArgs) Handles btnaddsource.Click
        frmaddaccounttype.ShowDialog()
        frmaddaccounttype.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub dgvpay_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvpay.CellMouseUp
        Try
            With dgvpay
                txtid.Text = .CurrentRow.Cells(0).Value
                txtdetail.Text = .CurrentRow.Cells(2).Value
                txttotal.Text = .CurrentRow.Cells(3).Value
                cbmoney.Text = .CurrentRow.Cells(6).Value
                txtdetail.ReadOnly = True
                txttotal.ReadOnly = True
                enableEdit()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class