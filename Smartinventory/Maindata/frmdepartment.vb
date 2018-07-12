Public Class frmdepartment
    Dim department As New tbdepartment
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtname.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtname.Select()
            Return
        End If
        department.save(txtid.Text, txtname.Text)
        txtname.Clear()
        department.laoddepartment(dgvshow)
        txtid.Text = department.runid
        enablesave()
        txtname.Select()
    End Sub

    Private Sub frmcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = department.runid
        department.laoddepartment(dgvshow)
        enablesave()
        txtname.Select()
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
        department.delete(txtid.Text)
        txtname.ReadOnly = False
        txtid.Text = department.runid
        department.laoddepartment(dgvshow)
        txtname.Clear()
        txtname.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtname.Text = .CurrentRow.Cells(1).Value
                txtname.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtname.ReadOnly = False
        txtname.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        department.update(txtid.Text, txtname.Text)
        txtname.ReadOnly = False
        txtid.Text = department.runid
        department.laoddepartment(dgvshow)
        txtname.Clear()
        txtname.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtname.Clear()
        txtname.ReadOnly = False
        txtid.Text = department.runid
        department.laoddepartment(dgvshow)
        txtname.Select()
        enablesave()
    End Sub
End Class