Public Class frmshowdate

    Private Sub frmshowdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Text = Today.AddDays(365)
        dt.Select()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        frmreceiveproduct.dgvreceive.CurrentRow.Cells(10).Value = dt.Text
        Me.Close()
    End Sub
End Class