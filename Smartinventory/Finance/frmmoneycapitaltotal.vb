Public Class frmmoneycapitaltotal
    Dim money As New tbsetmoney
    Dim capitalmoney As New tbcapitalmoney
    Dim account As New tbaccount
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtcapitaltotal.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        capitalmoney.save(txtcapitalid.Text, cbaccount.SelectedValue, txtcapitaltotal.Text, Format(CDate(txtinputdate.Text), "MM/dd/yyyy"))
        'capitalmoney.loaddatamoney(cbaccount.SelectedValue, dgvdetail)
        capitalmoney.viewsumaryaccount(cbaccount.SelectedValue, dgvmain)
        txtcapitalid.Text = capitalmoney.runid
        enablesave()
        txtcapitaltotal.Clear()
        txtcapitaltotal.Select()
    End Sub

    Private Sub frmdistrict_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtcapitalid.Text = capitalmoney.runid
            account.combocategory(cbaccount)
            'capitalmoney.loaddatamoney(cbaccount.SelectedValue, dgvdetail)
            capitalmoney.viewsumaryaccount(cbaccount.SelectedValue, dgvmain)
            'cate.viewdistrict(cbprovience.SelectedValue, dgvshow)
            enablesave()
            txtcapitaltotal.Select()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub enablesave()
        btnsave.Enabled = True
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = False
        btnnew.Enabled = True
    End Sub
    Private Sub enableedit()
        btnsave.Enabled = False
        btndelete.Enabled = True
        btnedit.Enabled = True
        btnupdate.Enabled = False
        btnnew.Enabled = True
    End Sub
    Private Sub enableupdate()
        btnsave.Enabled = False
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = True
        btnnew.Enabled = True
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        capitalmoney.delete(txtcapitalid.Text)
        txtcapitalid.Text = capitalmoney.runid
        'capitalmoney.loaddatamoney(cbaccount.SelectedValue, dgvdetail)
        capitalmoney.viewsumaryaccount(cbaccount.SelectedValue, dgvmain)
        txtcapitaltotal.Clear()
        txtcapitaltotal.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            With dgvdetail
                txtcapitalid.Text = .CurrentRow.Cells(0).Value
                txtcapitaltotal.Text = .CurrentRow.Cells(1).Value
                txtinputdate.Text = .CurrentRow.Cells(2).Value
                txtcapitaltotal.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtcapitaltotal.ReadOnly = False
        txtcapitaltotal.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        capitalmoney.update(txtcapitalid.Text, cbaccount.SelectedValue, txtcapitaltotal.Text, Format(CDate(txtinputdate.Text), "MM/dd/yyyy"))
        txtcapitaltotal.ReadOnly = False
        txtcapitalid.Text = capitalmoney.runid
        'capitalmoney.loaddatamoney(cbaccount.SelectedValue, dgvdetail)
        capitalmoney.viewsumaryaccount(cbaccount.SelectedValue, dgvmain)
        txtcapitaltotal.Clear()
        txtcapitaltotal.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtcapitaltotal.Clear()
        txtcapitaltotal.ReadOnly = False
        txtcapitalid.Text = capitalmoney.runid
        'capitalmoney.loaddatamoney(cbaccount.SelectedValue, dgvdetail)
        capitalmoney.viewsumaryaccount(cbaccount.SelectedValue, dgvmain)
        txtcapitaltotal.Select()
        enablesave()
    End Sub

    Private Sub cbmoneyid_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            'capitalmoney.loaddatamoney( dgvshow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Try
            frmaccount.ShowDialog()
            frmaccount.Close()
            account.combocategory(cbaccount)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcapitaltotal_TextChanged(sender As Object, e As EventArgs) Handles txtcapitaltotal.TextChanged
        Try
            Dim tem As Double = txtcapitaltotal.Text
            txtcapitaltotal.Text = tem.ToString("N0")
            txtcapitaltotal.SelectionStart = txtcapitaltotal.TextLength

        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub cbaccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbaccount.SelectedIndexChanged
        Try
            'capitalmoney.loaddatamoney(cbaccount.SelectedValue, dgvdetail)
            capitalmoney.viewsumaryaccount(cbaccount.SelectedValue, dgvmain)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvdetail_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvdetail.CellMouseUp
        Try
            With dgvdetail
                txtcapitalid.Text = .CurrentRow.Cells(0).Value
                cbaccount.Text = .CurrentRow.Cells(1).Value
                txtcapitaltotal.Text = .CurrentRow.Cells(2).Value
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class