Public Class frmvillage
    Dim cate As New tbprovience
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If cbprovience.SelectedValue < 1 Then
            MessageBox.Show("ກະລຸນາເລືອກແຂວງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cbdistrict.SelectedValue < 1 Then
            MessageBox.Show("ກະລຸນາເລືອກເມືອງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txttype.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttype.Select()
            Return
        End If

        cate.savevillage(txtid.Text, cbprovience.SelectedValue, cbdistrict.SelectedValue, txttype.Text)
        txttype.Clear()
        cate.viewvillage(cbprovience.SelectedValue, cbdistrict.SelectedValue, dgvshow)
        txtid.Text = cate.runvillageid
        enablesave()
        txttype.Select()
    End Sub

    Private Sub frmvillage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = cate.runvillageid
        cate.comboprovience(cbprovience)
        cate.comboboxdistrict(cbprovience.SelectedValue, cbdistrict)
        cate.viewvillage(cbprovience.SelectedValue, cbdistrict.SelectedValue, dgvshow)
        enablesave()
        txttype.Select()
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
        cate.deletedistrict(txtid.Text)
        txttype.ReadOnly = False
        txtid.Text = cate.runvillageid
        cate.viewvillage(cbprovience.SelectedValue, cbdistrict.SelectedValue, dgvshow)
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txttype.Text = .CurrentRow.Cells(2).Value
                cbdistrict.Text = .CurrentRow.Cells(1).Value
                txttype.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txttype.ReadOnly = False
        txttype.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        cate.updatevillage(txtid.Text, cbprovience.SelectedValue, cbdistrict.SelectedValue, txttype.Text)
        txttype.ReadOnly = False
        txtid.Text = cate.runvillageid
        cate.viewvillage(cbprovience.SelectedValue, cbdistrict.SelectedValue, dgvshow)
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txttype.Clear()
        txttype.ReadOnly = False
        txtid.Text = cate.runvillageid
        cate.viewvillage(cbprovience.SelectedValue, cbdistrict.SelectedValue, dgvshow)
        txttype.Select()
        enablesave()
    End Sub

    Private Sub cbprovience_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbprovience.SelectedIndexChanged
        Try
            cate.comboboxdistrict(cbprovience.SelectedValue, cbdistrict)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbdistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdistrict.SelectedIndexChanged
        Try
            cate.viewvillage(cbprovience.SelectedValue, cbdistrict.SelectedValue, dgvshow)
        Catch ex As Exception

        End Try
    End Sub
End Class