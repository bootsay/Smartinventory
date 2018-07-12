Public Class frmcategory
    Dim cate As New tbcategory
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txttype.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttype.Select()
            Return
        End If
        cate.save(txtid.Text, txttype.Text)
        txttype.Clear()
        cate.loadtbcategory(dgvshow)
        txtid.Text = cate.runid
        enablesave()
        txttype.Select()
    End Sub

    Private Sub frmcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = cate.runid
        cate.loadtbcategory(dgvshow)
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
        cate.delete(txtid.Text)
        txttype.ReadOnly = False
        txtid.Text = cate.runid
        cate.loadtbcategory(dgvshow)
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txttype.Text = .CurrentRow.Cells(1).Value
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
        cate.update(txtid.Text, txttype.Text)
        txttype.ReadOnly = False
        txtid.Text = cate.runid
        cate.loadtbcategory(dgvshow)
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txttype.Clear()
        txttype.ReadOnly = False
        txtid.Text = cate.runid
        cate.loadtbcategory(dgvshow)
        txttype.Select()
        enablesave()
    End Sub
End Class