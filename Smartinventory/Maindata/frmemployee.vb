Public Class frmemployee
    Dim department As New tbdepartment
    Dim employee As New tbemployee
    Private Sub frmemployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = employee.runid
        department.combodepartment(cmbdepartment)
        employee.formatdgv(dgvshow)
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
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtname.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtname.Select()
            Return
        End If
        employee.save(txtid.Text, txtname.Text, cmbdepartment.SelectedValue, txtposition.Text)
        txtname.Clear()
        txtposition.Clear()
        employee.formatdgv(dgvshow)
        txtid.Text = employee.runid
        enablesave()
        txtname.Select()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        employee.delete(txtid.Text)
        txtname.ReadOnly = False
        txtid.Text = department.runid
        employee.formatdgv(dgvshow)
        txtname.Clear()
        txtposition.Clear()
        txtname.Select()
        enablesave()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtname.ReadOnly = False
        txtname.ReadOnly = False
        txtposition.ReadOnly = False
        txtname.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        employee.update(txtid.Text, txtname.Text, cmbdepartment.SelectedValue, txtposition.Text)
        txtname.ReadOnly = False
        txtposition.ReadOnly = False
        txtid.Text = employee.runid
        employee.formatdgv(dgvshow)
        txtname.Clear()
        txtposition.Clear()
        txtname.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtname.Clear()
        txtname.Clear()
        txtposition.Clear()
        txtname.ReadOnly = False
        txtposition.ReadOnly = False
        txtid.Text = employee.runid
        employee.formatdgv(dgvshow)
        txtname.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtname.Text = .CurrentRow.Cells(1).Value
                cmbdepartment.Text = .CurrentRow.Cells(2).Value
                txtposition.Text = .CurrentRow.Cells(3).Value
                txtname.ReadOnly = True
                txtposition.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class