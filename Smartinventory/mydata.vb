Partial Class mydata
    Partial Class viewbillby_customerDataTable

        Private Sub viewbillby_customerDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.discountColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class viewsumaryallbillDataTable

    End Class

End Class
