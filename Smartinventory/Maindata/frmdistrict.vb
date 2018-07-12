Public Class frmdistrict
    Dim cate As New tbprovience
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If cbprovience.SelectedValue < 1 Then
            MessageBox.Show("ກະລຸນາເລືອກແຂວງ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If txttype.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttype.Select()
            Return
        End If
        cate.savedistrict(txtid.Text, cbprovience.SelectedValue, txttype.Text)
        txttype.Clear()
        cate.viewdistrict(cbprovience.SelectedValue, dgvshow)
        txtid.Text = cate.rundistrictid
        enablesave()
        txttype.Select()
    End Sub

    Private Sub frmdistrict_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = cate.rundistrictid
            cate.comboprovience(cbprovience)
            'cbprovience.SelectedIndex = 0
            'cate.viewdistrict(cbprovience.SelectedValue, dgvshow)
            enablesave()
            txttype.Select()
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
        cate.deletedistrict(txtid.Text)
        txttype.ReadOnly = False
        txtid.Text = cate.rundistrictid
        cate.viewdistrict(cbprovience.SelectedValue, dgvshow)
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txttype.Text = .CurrentRow.Cells(2).Value
                cbprovience.Text = .CurrentRow.Cells(1).Value
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
        cate.updatedistrict(txtid.Text, cbprovience.SelectedValue, txttype.Text)
        txttype.ReadOnly = False
        txtid.Text = cate.rundistrictid
        cate.viewprovience(dgvshow)
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txttype.Clear()
        txttype.ReadOnly = False
        txtid.Text = cate.rundistrictid
        cate.viewdistrict(cbprovience.SelectedValue, dgvshow)
        txttype.Select()
        enablesave()
    End Sub

    Private Sub cbprovience_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbprovience.SelectedIndexChanged
        Try
            cate.viewdistrict(cbprovience.SelectedValue, dgvshow)
        Catch ex As Exception

        End Try
    End Sub
End Class