Public Class frmsubcategory
    Dim cate As New tbcategory
    Dim subcate As New tbsubcategory
    Dim catename As String
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txttype.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttype.Select()
            Return
        End If
        If cbcategory.SelectedValue = 0 Then
            catename = "%"
            Return
        Else
            Dim rows As DataRowView = cbcategory.SelectedItem
            Dim row As DataRow = rows.Row
            catename = row(1).ToString
        End If
        Dim check As String = subcate.Check_duplicate_prefix(txtprefix.Text)
        If check = "True" Then
            MessageBox.Show("ຂໍໂທດທ່ານມີຄໍານໍາໜ້ານີ້ແລ້ວໃນລະບົບ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        subcate.save(txtid.Text, cbcategory.SelectedValue, txtprefix.Text, txttype.Text)
        txttype.Clear()
        txtprefix.Clear()
        subcate.loadtbcategory(catename, dgvshow)
        txtid.Text = subcate.runid()
        enablesave()
        txttype.Select()
    End Sub

    Private Sub frmcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = subcate.runid
        cate.combocategory1(cbcategory)
        cbcategory.SelectedValue = 0
        If cbcategory.SelectedValue = 0 Then
            catename = "%"
        Else
            Dim rows As DataRowView = cbcategory.SelectedItem
            Dim row As DataRow = rows.Row
            catename = row(1).ToString
        End If
        subcate.loadtbcategory(catename, dgvshow)
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
        subcate.delete(txtid.Text)
        txttype.ReadOnly = False
        txtid.Text = subcate.runid
        If cbcategory.SelectedValue = 0 Then
            catename = "%"
        Else
            Dim rows As DataRowView = cbcategory.SelectedItem
            Dim row As DataRow = rows.Row
            catename = row(1).ToString
        End If
        subcate.loadtbcategory(catename, dgvshow)
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                cbcategory.Text = .CurrentRow.Cells(1).Value()
                txtprefix.Text = .CurrentRow.Cells(2).Value
                txttype.Text = .CurrentRow.Cells(3).Value

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
        subcate.update(txtid.Text, cbcategory.SelectedValue, txtprefix.Text, txttype.Text)
        txttype.ReadOnly = False
        txtid.Text = subcate.runid
        If cbcategory.SelectedValue = 0 Then
            catename = "%"
        Else
            Dim rows As DataRowView = cbcategory.SelectedItem
            Dim row As DataRow = rows.Row
            catename = row(1).ToString
        End If
        subcate.loadtbcategory(catename, dgvshow)
        txtprefix.Clear()
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txttype.Clear()
        txtprefix.Clear()
        txttype.ReadOnly = False
        txtid.Text = subcate.runid
        If cbcategory.SelectedValue = 0 Then
            catename = "%"
        Else
            Dim rows As DataRowView = cbcategory.SelectedItem
            Dim row As DataRow = rows.Row
            catename = row(1).ToString
        End If
        subcate.loadtbcategory(catename, dgvshow)
        txttype.Select()
        enablesave()
    End Sub

    Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcategory.SelectedIndexChanged
        Try
            If cbcategory.SelectedValue = 0 Then
                catename = "%"
            Else
                Dim rows As DataRowView = cbcategory.SelectedItem
                Dim row As DataRow = rows.Row
                catename = row(1).ToString
            End If
            subcate.loadtbcategory(catename, dgvshow)
        Catch ex As Exception

        End Try
    End Sub
End Class