Public Class frmshowsubsale
    Dim stock As New tbstock
    Dim cate As New tbcategory
    Dim subcate As New tbsubcategory
    'Dim product As New tbproduct
    Dim price As New tbprice
    Dim catename As String
    Private Sub frmshowproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        stock.combocategory(cbstock)
        cate.combocategory1(cbcate)
        cbcate.SelectedValue = 0
        'subcate.combosubcate(cbsubcate)
        'cbsubcate.SelectedValue = 0
        price.viewprice_all(dgvprodouct)
        'With dgvprodouct
        '    .Columns(3).AutoSizeMode = 
        '    '.Columns(5).Visible = False
        '    '.Columns(6).Visible = False
        '    '.Columns(8).Visible = False
        '    '.Columns(9).Visible = False
        '    '.Columns(12).Visible = False
        'End With
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cbcate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcate.SelectedIndexChanged
        Try
            If cbcate.SelectedValue = 0 Then
                price.viewprice_all(dgvprodouct)
            Else
                subcate.combocategory(cbcate.SelectedValue, cbsubcate)
                price.viewpricesale_bycate_andsubcate(cbcate.SelectedValue, cbsubcate.SelectedValue, dgvprodouct)


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbsubcate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsubcate.SelectedIndexChanged
        Try
            price.viewpricesale_bycate_andsubcate(cbcate.SelectedValue, cbsubcate.SelectedValue, dgvprodouct)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvprodouct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprodouct.CellClick
        Try
            Dim frmsale As frmsale = CType(Application.OpenForms("frmsale"), frmsale)
            If frmsale.formsale = True Then
                With dgvprodouct
                    frmsale.dgvsale.CurrentRow.Cells(0).Value = .CurrentRow.Cells(0).Value
                    frmsale.dgvsale.CurrentRow.Cells(1).Value = .CurrentRow.Cells(1).Value
                    frmsale.dgvsale.CurrentRow.Cells(2).Value = .CurrentRow.Cells(2).Value
                    frmsale.dgvsale.CurrentRow.Cells(11).Value = .CurrentRow.Cells(13).Value
                    If frmsale.cbprice.SelectedIndex = 1 Then
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(4).Value
                    ElseIf frmsale.cbprice.SelectedIndex = 2 Then
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(5).Value
                    ElseIf frmsale.cbprice.SelectedIndex = 3 Then
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(6).Value
                    ElseIf frmsale.cbprice.SelectedIndex = 4 Then
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(7).Value
                    End If
                    frmsale.dgvsale.CurrentRow.Cells(9).Value = .CurrentRow.Cells(3).Value
                    frmsale.dgvsale.CurrentRow.Cells(4).Value = ""
                    frmsale.dgvsale.CurrentRow.Cells(5).Value = 0

                    'frmsale.dgvsale.CurrentRow.Cells(6).Value = frmsale.dgvsale.CurrentRow.Cells(3).Value

                End With

                Me.Close()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmshowproductsale_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Try
        '    frmsale.dgvsale.Rows.Add()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            price.viewpricesale_byname(txtsearch.Text, dgvprodouct)
        Catch ex As Exception

        End Try
    End Sub

End Class