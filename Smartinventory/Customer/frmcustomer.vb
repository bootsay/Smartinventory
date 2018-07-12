Public Class frmcustomer
    Dim customer As New tbsuppliers
    Dim adds As New tbprovience
    Dim custype_C As New tbcustomertype
    Dim txtid As New TextBox
    Dim custype As String
    Dim village As String
    Dim provience As String
    Dim district As String
    Private Sub frmcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = customer.runidsupplier
            custype_C.combocustype(cbtype)
            cbtype.SelectedValue = 0
            custype = "ລູກຄ້າ"
            'rdcustomer.Checked = True
            adds.comboprovience(cbprovience)
            cbprovience.SelectedValue = 1
            customer.showsuppliers(custype, dgvcustomer, "%", "%", "%")
            enableSave()
            txtcount.Text = dgvcustomer.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub enableSave()
        btnsave.Enabled = True
        btnedit.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnnew.Enabled = False
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
        btnnew.Enabled = False
    End Sub
    Private Sub cleartext()
        txtcomname.Clear()
        txtcontactname.Clear()

        txttel.Clear()
        txtfax.Clear()

        txtemail.Clear()
    End Sub
    Private Sub disabletext()
        txtcomname.Enabled = False
        txtcontactname.Enabled = False

        txttel.Enabled = False
        txtfax.Enabled = False

        txtemail.Enabled = False
    End Sub
    Private Sub Enabletext()
        txtcomname.Enabled = True
        txtcontactname.Enabled = True

        txttel.Enabled = True
        txtfax.Enabled = True

        txtemail.Enabled = True
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If cbprovience.SelectedValue < 1 Then
            MessageBox.Show("ກະລຸນາເລືອກແຂວງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cbdistrict.SelectedValue < 1 Then
            MessageBox.Show("ກະລຸນາເລືອກເມືອງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        'If cbvillage.SelectedValue < 1 Then
        '    MessageBox.Show("ກະລຸນາເລືອກບ້ານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return
        'End If
        If txtcomname.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
            txtcomname.Focus()
            Return
        End If
        If txtcontactname.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
            txtcontactname.Focus()
            Return
        End If

        If txttel.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
            txttel.Focus()
            Return
        End If
        Dim autoid As Integer = customer.runidauto
        Dim rows As DataRowView = cbtype.SelectedItem
        Dim row As DataRow = rows.Row
        custype = row(1).ToString

        If cbdistrict.SelectedValue < 1 Then
            district = "none"
        End If
        If cbvillage.SelectedValue < 1 Then
            village = "none"
        End If
        If cbprovience.SelectedValue < 1 Then
            provience = "none"
        End If
        If cbtype.SelectedValue = 0 Then
            MessageBox.Show("ກະລຸນາເລືອກລູກຄ້າ", "ຄໍແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Return
        End If
        txtid.Text = customer.runidsupplier
        customer.save(txtid.Text, txtcomname.Text, txtcontactname.Text, provience, district, village, txttel.Text, txtfax.Text, txtemail.Text, custype, autoid)
        cleartext()
        txtcomname.Select()
        txtid.Text = customer.runidsupplier
      
        enableSave()
        customer.showsuppliers(custype, dgvcustomer, "%", "%", "%")
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        enableSave()
        Enabletext()
        cleartext()
        txtcomname.Select()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        'Dim autoid As Integer = customer.runidauto
        Dim rows As DataRowView = cbtype.SelectedItem
        Dim row As DataRow = rows.Row
        custype = row(1).ToString
        customer.update(txtid.Text, txtcomname.Text, txtcontactname.Text, provience, district, village, txttel.Text, txtfax.Text, txtemail.Text, custype)
        cleartext()
        txtcomname.Select()
        enableSave()
        customer.showsuppliers(custype, dgvcustomer, "%", "%", "%")
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Enabletext()
        txtcomname.Select()
        enableUpdate()
    End Sub

    Private Sub dgvcustomer_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvcustomer.CellMouseUp
        Try
            With dgvcustomer
                txtid.Text = .CurrentRow.Cells(0).Value
                txtcomname.Text = .CurrentRow.Cells(1).Value
                txtcontactname.Text = .CurrentRow.Cells(2).Value
                cbprovience.Text = .CurrentRow.Cells(3).Value
                cbdistrict.Text = .CurrentRow.Cells(4).Value
                cbvillage.Text = .CurrentRow.Cells(5).Value
                txttel.Text = .CurrentRow.Cells(6).Value
                txtfax.Text = .CurrentRow.Cells(7).Value
                txtemail.Text = .CurrentRow.Cells(8).Value
                cbtype.Text = .CurrentRow.Cells(9).Value
                disabletext()
                enableEdit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        customer.delete(txtid.Text)
        Enabletext()
        cleartext()
        txtcomname.Select()
        enableSave()
        customer.showsuppliers(custype, dgvcustomer, "%", "%", "%")
    End Sub
    Private Sub cbprovience_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbprovience.SelectedIndexChanged
        Try
            Dim rows As DataRowView = cbprovience.SelectedItem
            Dim row As DataRow = rows.Row
            provience = row(1).ToString
            adds.comboboxdistrict(cbprovience.SelectedValue, cbdistrict)
            'customer.showsuppliers(custype, dgvcustomer, "%", "%", "%")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbdistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdistrict.SelectedIndexChanged
        Try
            Dim rows As DataRowView = cbdistrict.SelectedItem
            Dim row As DataRow = rows.Row
            district = row(1).ToString
            adds.comboboxvillage(cbdistrict.SelectedValue, cbvillage)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdbigshop_CheckedChanged(sender As Object, e As EventArgs)

        'If rdcustomer.Checked = True Then
        '    custype = "ລູກຄ້າ"
        '    'txtid.Text = customer.runidcustomer
        'ElseIf rdbigshop.Checked = True Then
        '    custype = "ຮ້ານໃຫ່ຍ"
        '    'txtid.Text = customer.runidbigshop
        'ElseIf rdsmallshop.Checked = True Then
        '    custype = "ຮ້ານນ້ອຍ"
        '    'txtid.Text = customer.runidsmallshop
        'ElseIf rdsupplier.Checked = True Then
        '    custype = "ຜູ້ສະໜອງ"
        '    'txtid.Text = customer.runidsupplier
        'End If
        customer.showsuppliers(custype, dgvcustomer, "%", "%", "%")
        txtcount.Text = dgvcustomer.Rows.Count
    End Sub

    Private Sub rdsmallshop_CheckedChanged(sender As Object, e As EventArgs)

        'If rdcustomer.Checked = True Then
        '    custype = "ລູກຄ້າ"
        '    'txtid.Text = customer.runidcustomer
        'ElseIf rdbigshop.Checked = True Then
        '    custype = "ຮ້ານໃຫ່ຍ"
        '    'txtid.Text = customer.runidbigshop
        'ElseIf rdsmallshop.Checked = True Then
        '    custype = "ຮ້ານນ້ອຍ"
        '    'txtid.Text = customer.runidsmallshop
        'ElseIf rdsupplier.Checked = True Then
        '    custype = "ຜູ້ສະໜອງ"
        '    'txtid.Text = customer.runidsupplier
        'End If
        customer.showsuppliers(custype, dgvcustomer, "%", "%", "%")
        txtcount.Text = dgvcustomer.Rows.Count
    End Sub

    Private Sub frmcustomer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
           If cbtype.SelectedValue = 0 Then
                custype = "%"
            Else
                Dim rows As DataRowView = cbtype.SelectedItem
                Dim row As DataRow = rows.Row
                custype = row(1).ToString
            End If
            customer.showsuppliers(custype, dgvcustomer, "%", "%", "%")
            txtcount.Text = dgvcustomer.Rows.Count
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbvillage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbvillage.SelectedIndexChanged
        Try
            Dim rows As DataRowView = cbvillage.SelectedItem
            Dim row As DataRow = rows.Row
            village = row(1).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        frmcustype.ShowDialog()
        frmcustype.Close()
        custype_C.combocustype(cbtype)
    End Sub

    Private Sub cbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtype.SelectedIndexChanged
        Try
            If cbtype.SelectedValue = 0 Then
                custype = "%"
            Else
                Dim rows As DataRowView = cbtype.SelectedItem
                Dim row As DataRow = rows.Row
                custype = row(1).ToString
            End If
            customer.showsuppliers(custype, dgvcustomer, "%", "%", "%")
            txtcount.Text = dgvcustomer.Rows.Count
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprovince_Click(sender As Object, e As EventArgs) Handles btnprovince.Click
        Try
            frmprovience.ShowDialog()
            frmprovience.Close()
            adds.comboprovience(cbprovience)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndistrict_Click(sender As Object, e As EventArgs) Handles btndistrict.Click
        Try
            frmdistrict.ShowDialog()
            frmdistrict.Close()
            adds.comboboxdistrict(cbprovience.SelectedValue, cbdistrict)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnban_Click(sender As Object, e As EventArgs) Handles btnban.Click
        Try
            frmvillage.ShowDialog()
            frmvillage.Close()
            adds.comboboxvillage(cbdistrict.SelectedValue, cbvillage)

        Catch ex As Exception

        End Try
    End Sub

End Class