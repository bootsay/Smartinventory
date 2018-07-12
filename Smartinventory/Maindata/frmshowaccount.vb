Public Class frmshowaccount
    Dim acc As New tbincomesource
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub frmshowaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        acc.loadtbcategory(dgvshow)
    End Sub

    Private Sub dgvshow_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellDoubleClick
        'With dgvshow
        '    Dim rep As frmreport = CType(Application.OpenForms("frmreport"), frmreport)
        '    rep.proid = .CurrentRow.Cells(0).Value
        '    Me.Close()
        'End With
    End Sub
End Class