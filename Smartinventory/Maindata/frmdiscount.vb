Public Class frmdiscount
    Dim discount As New tbdiscounts
    Dim id As New TextBox
    Dim idd As Integer
    Private Sub frmdiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        discount.loadtbdiscount(dgvdiscount)
        id.Text = discount.runid()
        enableSave()
        txtamount.Select()
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

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        discount.save(id.Text, txtamount.Text)
        discount.loadtbdiscount(dgvdiscount)
        txtamount.Clear()
        id.Text = discount.runid
        txtamount.Focus()
    End Sub

    Private Sub dgvdiscount_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvdiscount.MouseUp
        Try
            With dgvdiscount
                txtamount.Text = .CurrentRow.Cells(1).Value
                idd = .CurrentRow.Cells(0).Value
            End With
            enableEdit()
            txtamount.ReadOnly = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        enableUpdate()
        txtamount.ReadOnly = False
        txtamount.Select()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            discount.update(idd, txtamount.Text)
            id.Text = discount.runid()
            discount.loadtbdiscount(dgvdiscount)
            txtamount.Clear()
            enableSave()
            txtamount.ReadOnly = False
            txtamount.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            discount.delete(idd)
            discount.loadtbdiscount(dgvdiscount)
            id.Text = discount.runid
            txtamount.Clear()
            enableSave()
            txtamount.ReadOnly = False
            txtamount.Select()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Try
            id.Text = discount.runid
            txtamount.Clear()
            enableSave()
            txtamount.ReadOnly = False
            txtamount.Select()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        Dim FullStop As Char
        FullStop = "."

        ' if the '.' key was pressed see if there already is a '.' in the string
        ' if so, dont handle the keypress
        If e.KeyChar = FullStop And txtamount.Text.IndexOf(FullStop) <> -1 Then
            e.Handled = True
            Return
        End If

        ' If the key aint a digit
        If Not Char.IsDigit(e.KeyChar) Then
            ' verify whether special keys were pressed
            ' (i.e. all allowed non digit keys - in this example
            ' only space and the '.' are validated)
            If (e.KeyChar <> FullStop) And
               (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
                ' if its a non-allowed key, dont handle the keypress
                e.Handled = True
                Return
            End If
        End If
    End Sub
End Class