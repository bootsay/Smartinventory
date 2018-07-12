Public Class frmaddaccounttype
    Dim sour As New tbincomesource
   
    Private Sub frmaddaccounttype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = sour.runid
        sour.loadtbcategory(dgvshow)
        txttype.Select()
        enablesave()
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

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        sour.delete(txtid.Text)
        txtid.Text = sour.runid
        sour.loadtbcategory(dgvshow)
        txttype.ReadOnly = False
        txttype.Clear()
        txttype.Select()
        Dim income As frmincome = CType(Application.OpenForms("frmincome"), frmincome)
        sour.combosourcetype(income.cbsource)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txttype.Text = "" Then
            MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttype.Select()
            Return
        End If
        sour.save(txtid.Text, txttype.Text)
        txtid.Text = sour.runid
        sour.loadtbcategory(dgvshow)
        txttype.ReadOnly = False
        txttype.Clear()
        txttype.Select()
        enablesave()
        Dim income As frmincome = CType(Application.OpenForms("frmincome"), frmincome)
        sour.combosourcetype(income.cbsource)
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtid.Text = sour.runid
        sour.loadtbcategory(dgvshow)
        txttype.ReadOnly = False
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txttype.Text = "" Then
            MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttype.Select()
            Return
        End If
        sour.update(txtid.Text, txttype.Text)
        txtid.Text = sour.runid
        sour.loadtbcategory(dgvshow)
        txttype.ReadOnly = False
        txttype.Select()
        txttype.Clear()
        enablesave()
        Dim income As frmincome = CType(Application.OpenForms("frmincome"), frmincome)
        sour.combosourcetype(income.cbsource)
    End Sub
End Class