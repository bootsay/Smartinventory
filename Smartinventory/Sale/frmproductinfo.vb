Public Class frmproductinfo
    Dim cate As New tbcategory
    Dim product As New tbproduct
    Dim subcate As New tbsubcategory
    Dim pro As New tbproduct
    Dim price As New tbprice
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub frmproductinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rdname.Checked = True
            pro.viewpricebuy(dgvproduct, 0)
            If frmmain.level = "Administrator" Then
            Else
                With dgvproduct
                    .Columns(10).Visible = False
                    .Columns(12).Visible = False

                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdname_CheckedChanged(sender As Object, e As EventArgs) Handles rdname.CheckedChanged
        Try
            If rdname.Checked = True Then
                cbsearchtype.Visible = False
                cbsubcate.Visible = False
                txtsearch.Visible = True
                txtsearch.Clear()
                txtsearch.Select()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdid_CheckedChanged(sender As Object, e As EventArgs) Handles rdid.CheckedChanged
        Try
            If rdid.Checked = True Then
                cbsearchtype.Visible = False
                cbsubcate.Visible = False
                txtsearch.Visible = True
                txtsearch.Clear()
                txtsearch.Select()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdtype_CheckedChanged(sender As Object, e As EventArgs) Handles rdtype.CheckedChanged
        Try
            If rdtype.Checked = True Then
                txtsearch.Visible = False
                cbsubcate.Visible = True
                cbsearchtype.Visible = True
                cate.combocategory1(cbsearchtype)
                cbsearchtype.SelectedValue = 0
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbsearchtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsearchtype.SelectedIndexChanged
        Try
            subcate.combocategory(cbsearchtype.SelectedValue, cbsubcate)
            If cbsearchtype.SelectedValue = 0 Then
                pro.viewpricebuy(dgvproduct, 0)
            Else
                pro.viewpricebuy_search_category(dgvproduct, cbsearchtype.SelectedValue)
                pro.viewpricebuy_bycate_andsubcate(cbsearchtype.SelectedValue, cbsubcate.SelectedValue, dgvproduct, 0)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If rdid.Checked = True Then
            pro.viewpricebuy_search_id(dgvproduct, txtsearch.Text, 0)
        ElseIf rdname.Checked = True Then
            pro.viewpricebuy_search_name(dgvproduct, txtsearch.Text, 0)
        End If
        For i As Integer = 0 To dgvproduct.Rows.Count - 1
            'If dgvproduct.Rows(i).Cells(4).Value = 1 Then
            '    dgvproduct.Rows(i).Cells(7).Value = 0

            'End If
            If dgvproduct.Rows(i).Cells(13).Value = "ກີບ" Then
                dgvproduct.Rows(i).Cells(13).Style.BackColor = Color.LightSkyBlue
            Else
                dgvproduct.Rows(i).Cells(13).Style.BackColor = Color.LightPink
            End If
        Next
    End Sub

    Private Sub cbsubcate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsubcate.SelectedIndexChanged
        Try
            pro.viewpricebuy_bycate_andsubcate(cbsearchtype.SelectedValue, cbsubcate.SelectedValue, dgvproduct, 0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvproduct_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvproduct.CellMouseUp
        Try
            price.viewprice(dgvproduct.CurrentRow.Cells(0).Value, dgvproductsaleprice)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvproduct_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvproduct.KeyUp
        Try

            price.viewprice(dgvproduct.CurrentRow.Cells(0).Value, dgvproductsaleprice)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvproduct_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvproduct.KeyDown
        Try

            price.viewprice(dgvproduct.CurrentRow.Cells(0).Value, dgvproductsaleprice)

        Catch ex As Exception

        End Try
    End Sub
End Class