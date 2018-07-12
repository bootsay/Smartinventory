Public Class frmexchange
    Dim exh As New tbexchange
    Dim txtid As New TextBox
    Dim bath As Double
    Dim dolla As Double
    Private Sub frmexchange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbaht.Enabled = False
        txtdolla.Enabled = False
        btnupdate.Enabled = False
        exh.loadtbexchange(dgvexchange)
        Try
            With dgvexchange
                txtid.Text = .CurrentRow.Cells(0).Value
                Dim a As Double = .CurrentRow.Cells(1).Value
                txtbaht.Text = a.ToString("N0")
                Dim ba As Double = .CurrentRow.Cells(2).Value
                txtdolla.Text = ba.ToString("N0")
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        btnupdate.Enabled = True
        txtbaht.Enabled = True
        txtdolla.Enabled = True
        txtbaht.Select()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim exits As Integer = exh.Check_exchangeExist()
        If exits > 0 Then
            exh.update(txtid.Text, txtbaht.Text, txtdolla.Text)
            txtbaht.Enabled = False
            txtdolla.Enabled = False
            btnupdate.Enabled = False
            exh.loadtbexchange(dgvexchange)
            bath = exh.loadbaht
            dolla = exh.loaddolla
            frmmain.bath = bath.ToString("N")
            frmmain.dolla = dolla.ToString("N")
        Else
            exh.save(1, txtbaht.Text, txtdolla.Text)
            txtbaht.Enabled = False
            txtdolla.Enabled = False
            btnupdate.Enabled = False
            exh.loadtbexchange(dgvexchange)
            bath = exh.loadbaht
            dolla = exh.loaddolla
            frmmain.bath = bath.ToString("N")
            frmmain.dolla = dolla.ToString("N")
        End If
       

    End Sub

    Private Sub txtbaht_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbaht.KeyPress
        Dim FullStop As Char
        FullStop = "."

        ' if the '.' key was pressed see if there already is a '.' in the string
        ' if so, dont handle the keypress
        If e.KeyChar = FullStop And txtbaht.Text.IndexOf(FullStop) <> -1 Then
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

    Private Sub txtdolla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdolla.KeyPress
        Dim FullStop As Char
        FullStop = "."

        ' if the '.' key was pressed see if there already is a '.' in the string
        ' if so, dont handle the keypress
        If e.KeyChar = FullStop And txtdolla.Text.IndexOf(FullStop) <> -1 Then
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