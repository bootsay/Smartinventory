Public Class fromproductremind
    Dim pro As New tbproduct
    Private Sub fromproductremind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pro.viewpricebuy_productorderlist(dgvlist)
    End Sub

    Private Sub dgvlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellContentClick

    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        frmreportproductremindstock.ShowDialog()
        frmreportproductremindstock.Close()
    End Sub

    Private Sub dgvlist_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvlist.CellFormatting
        Try
            For i As Integer = 0 To dgvlist.Rows.Count - 1
                dgvlist.Rows(i).Cells(11).Style.BackColor = Color.Red
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class