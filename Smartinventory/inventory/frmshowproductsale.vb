Public Class frmshowproductsale
    Dim stock As New tbstock
    Dim cate As New tbcategory
    Dim subcate As New tbsubcategory
    Dim setmoney As New tbsetmoney
    'Dim product As New tbproduct
    Dim price As New tbprice
    Dim catename As String
    Dim mainmoney As String
    Private Sub frmshowsubsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mainmoney = setmoney.Call_mainmoney
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbcate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcate.SelectedIndexChanged
        Try
            If cbcate.SelectedValue = 0 Then
                price.viewprice_all(dgvprodouct)
            Else
                subcate.combocategory(cbcate.SelectedValue, cbsubcate)
                'MessageBox.Show(cbcate.SelectedValue)
                'MessageBox.Show(cbsubcate.SelectedValue)
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
        'Try
        Dim frmsale As frmsale = DirectCast(Application.OpenForms("frmsale"), frmsale)
        If frmsale.formsale = True Then
            With dgvprodouct
                'For i As Integer = 0 To frmsale.dgvsale.Rows.Count - 1

                '    If frmsale.dgvsale.Rows(i).Cells(0).Value = .CurrentRow.Cells(0).Value Then
                '        MessageBox.Show("ສີນຄ້ານີ້ມີແລ້ວກະລຸນາເລືອກສີນຄ້າໄໝ່", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '        Return
                '    End If
                'Next




                'If .CurrentRow.Cells(8).Value < 1 And .CurrentRow.Cells(14).Value = 1 Then
                '    MessageBox.Show("ຈໍານວນໃນສາງຂອງທ່ານມີ 0 ກຸລຸນາຮັບສີນຄ້າເຂົ້າສາງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    Exit Sub
                'End If

                frmsale.dgvsale.CurrentRow.Cells(12).Value = .CurrentRow.Cells(14).Value
                frmsale.dgvsale.CurrentRow.Cells(0).Value = .CurrentRow.Cells(0).Value
                frmsale.dgvsale.CurrentRow.Cells(1).Value = .CurrentRow.Cells(1).Value
                frmsale.dgvsale.CurrentRow.Cells(2).Value = .CurrentRow.Cells(2).Value
                frmsale.dgvsale.CurrentRow.Cells(11).Value = .CurrentRow.Cells(13).Value 'chang column'

                If frmsale.cbprice.SelectedIndex = 0 Then
                 
                    If frmsale.mainmoney = "ບາດ" And frmsale.mainmoney = mainmoney Then
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(4).Value

                    ElseIf frmsale.mainmoney = "ກີບ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(4).Value
                        Dim exchangerate As Double = pricesale * frmmain.labath.Text
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    ElseIf frmsale.mainmoney = "ໂດລາ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(4).Value
                        Dim exchangeratekip As Double = pricesale * frmmain.labath.Text
                        Dim exchangerate As Double = exchangeratekip / frmmain.ladolla.Text
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    End If
                ElseIf frmsale.cbprice.SelectedIndex = 1 Then
                    'frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(5).Value
                    If frmsale.mainmoney = "ບາດ" And frmsale.mainmoney = mainmoney Then
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(5).Value
                    ElseIf frmsale.mainmoney = "ກີບ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(5).Value
                        Dim exchangerate As Double = pricesale * frmmain.labath.Text
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    ElseIf frmsale.mainmoney = "ໂດລາ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(5).Value
                        Dim exchangeratekip As Double = pricesale * frmmain.labath.Text
                        Dim exchangerate As Double = exchangeratekip / frmmain.ladolla.Text
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    End If
                ElseIf frmsale.cbprice.SelectedIndex = 2 Then
                    'frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(6).Value
                    If frmsale.mainmoney = "ບາດ" And frmsale.mainmoney = mainmoney Then
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(6).Value
                    ElseIf frmsale.mainmoney = "ກີບ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(6).Value
                        Dim exchangerate As Double = pricesale * frmmain.labath.Text
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    ElseIf frmsale.mainmoney = "ໂດລາ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(6).Value
                        Dim exchangeratekip As Double = pricesale * frmmain.labath.Text
                        Dim exchangerate As Double = exchangeratekip / frmmain.ladolla.Text
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    End If
                ElseIf frmsale.cbprice.SelectedIndex = 3 Then
                    'frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(7).Value
                    If frmsale.mainmoney = "ບາດ" And frmsale.mainmoney = mainmoney Then
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(7).Value
                    ElseIf frmsale.mainmoney = "ກີບ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(7).Value
                        Dim exchangerate As Double = pricesale * frmmain.labath.Text
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    ElseIf frmsale.mainmoney = "ໂດລາ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(7).Value
                        Dim exchangeratekip As Double = pricesale * frmmain.labath.Text
                        Dim exchangerate As Double = exchangeratekip / frmmain.ladolla.Text
                        frmsale.dgvsale.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    End If
                End If
        frmsale.dgvsale.CurrentRow.Cells(9).Value = .CurrentRow.Cells(3).Value
        If .CurrentRow.Cells(15).Value = 3 Then
            frmsale.dgvsale.CurrentRow.Cells(4).Value = 0
        Else
            frmsale.dgvsale.CurrentRow.Cells(4).Value = 1
        End If

        frmsale.dgvsale.CurrentRow.Cells(5).Value = 0

        'frmsale.dgvsale.CurrentRow.Cells(6).Value = frmsale.dgvsale.CurrentRow.Cells(3).Value

            End With
            Me.Close()
        End If
        If frmsalesubitem.formsalesub = True Then
            With dgvprodouct
                'If .CurrentRow.Cells(8).Value < 1 And .CurrentRow.Cells(14).Value = 1 Then
                '    MessageBox.Show("ຈໍານວນໃນສາງຂອງທ່ານມີ 0 ກຸລຸນາຮັບສີນຄ້າເຂົ້າສາງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    Exit Sub
                'End If
                frmsalesubitem.dgvsub.CurrentRow.Cells(12).Value = .CurrentRow.Cells(14).Value
                frmsalesubitem.dgvsub.CurrentRow.Cells(0).Value = .CurrentRow.Cells(0).Value
                frmsalesubitem.dgvsub.CurrentRow.Cells(1).Value = .CurrentRow.Cells(1).Value
                frmsalesubitem.dgvsub.CurrentRow.Cells(2).Value = .CurrentRow.Cells(2).Value
                frmsalesubitem.dgvsub.CurrentRow.Cells(11).Value = .CurrentRow.Cells(13).Value
                If frmsalesubitem.cbprice.SelectedIndex = 0 Then
                    frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = .CurrentRow.Cells(4).Value
                ElseIf frmsalesubitem.cbprice.SelectedIndex = 1 Then
                    frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = .CurrentRow.Cells(5).Value
                ElseIf frmsalesubitem.cbprice.SelectedIndex = 2 Then
                    frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = .CurrentRow.Cells(6).Value
                ElseIf frmsalesubitem.cbprice.SelectedIndex = 3 Then
                    frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = .CurrentRow.Cells(7).Value
                End If
                frmsalesubitem.dgvsub.CurrentRow.Cells(9).Value = .CurrentRow.Cells(3).Value
                frmsalesubitem.dgvsub.CurrentRow.Cells(4).Value = 1
                frmsalesubitem.dgvsub.CurrentRow.Cells(5).Value = 0

                'frmsale.dgvsale.CurrentRow.Cells(6).Value = frmsale.dgvsale.CurrentRow.Cells(3).Value
                'ชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชชช

                If frmsale.cbprice.SelectedIndex = 0 Then

                    If frmsale.mainmoney = "ບາດ" And frmsale.mainmoney = mainmoney Then
                        frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = .CurrentRow.Cells(4).Value
                    ElseIf frmsale.mainmoney = "ກີບ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(4).Value
                        Dim exchangerate As Double = pricesale * frmmain.labath.Text
                        frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    ElseIf frmsale.mainmoney = "ໂດລາ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(4).Value
                        Dim exchangeratekip As Double = pricesale * frmmain.labath.Text
                        Dim exchangerate As Double = exchangeratekip / frmmain.ladolla.Text
                        frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    End If
                ElseIf frmsale.cbprice.SelectedIndex = 1 Then
                    'frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(5).Value
                    If frmsale.mainmoney = "ບາດ" And frmsale.mainmoney = mainmoney Then
                        frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = .CurrentRow.Cells(5).Value
                    ElseIf frmsale.mainmoney = "ກີບ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(5).Value
                        Dim exchangerate As Double = pricesale * frmmain.labath.Text
                        frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    ElseIf frmsale.mainmoney = "ໂດລາ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(5).Value
                        Dim exchangeratekip As Double = pricesale * frmmain.labath.Text
                        Dim exchangerate As Double = exchangeratekip / frmmain.ladolla.Text
                        frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    End If
                ElseIf frmsale.cbprice.SelectedIndex = 2 Then
                    'frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(6).Value
                    If frmsale.mainmoney = "ບາດ" And frmsale.mainmoney = mainmoney Then
                        frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = .CurrentRow.Cells(6).Value
                    ElseIf frmsale.mainmoney = "ກີບ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(6).Value
                        Dim exchangerate As Double = pricesale * frmmain.labath.Text
                        frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    ElseIf frmsale.mainmoney = "ໂດລາ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(6).Value
                        Dim exchangeratekip As Double = pricesale * frmmain.labath.Text
                        Dim exchangerate As Double = exchangeratekip / frmmain.ladolla.Text
                        frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    End If
                ElseIf frmsale.cbprice.SelectedIndex = 3 Then
                    'frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(7).Value
                    If frmsale.mainmoney = "ບາດ" And frmsale.mainmoney = mainmoney Then
                        frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = .CurrentRow.Cells(7).Value
                    ElseIf frmsale.mainmoney = "ກີບ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(7).Value
                        Dim exchangerate As Double = pricesale * frmmain.labath.Text
                        frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    ElseIf frmsale.mainmoney = "ໂດລາ" And frmsale.mainmoney <> mainmoney Then
                        Dim pricesale As Double = .CurrentRow.Cells(7).Value
                        Dim exchangeratekip As Double = pricesale * frmmain.labath.Text
                        Dim exchangerate As Double = exchangeratekip / frmmain.ladolla.Text
                        frmsalesubitem.dgvsub.CurrentRow.Cells(3).Value = exchangerate.ToString("N0")
                    End If
                End If
            End With
            Me.Close()

        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
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

    Private Sub dgvprodouct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprodouct.CellContentClick

    End Sub
End Class