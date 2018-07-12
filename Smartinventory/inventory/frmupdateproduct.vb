Public Class frmupdateproduct
    Dim upp As New viewupdateproduct
    Dim product As New tbproduct
    Private Sub btnup_Click(sender As Object, e As EventArgs) Handles btnup.Click
        Dim dt As New DataTable
        dt.Clear()
        upp.selectviewupdate(dt)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim idd As String = dt.Rows(i).Item(0)
                Dim stockqty As Integer = dt.Rows(i).Item(2)
                product.updateStock(idd, stockqty)
            Next
            MessageBox.Show("ປັບປຸງສາງສໍາເລັດ")
        End If
    End Sub
End Class