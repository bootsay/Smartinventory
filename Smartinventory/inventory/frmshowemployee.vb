Public Class frmshowemployee
    Dim emp As New tbemployee
    Private Sub frmshowemployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emp.loademployee_all(dgvshow)
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                frmstockout.empid = .CurrentRow.Cells(0).Value
                frmstockout.txtsupname.Text = .CurrentRow.Cells(1).Value
                Me.Close()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class