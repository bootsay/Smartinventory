Public Class frmshowproduct
    Dim stock As New tbstock
    Dim cate As New tbcategory
    Dim subcate As New tbsubcategory
    Dim product As New tbproduct
    Dim exch As New tbexchange
    Dim catename As String
    Dim bath As Double
    Dim dolla As Double
    Private Sub frmshowproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        bath = exch.loadbaht
        dolla = exch.loaddolla
        stock.combocategory(cbstock)
        cate.combocategory1(cbcate)
        cbcate.SelectedValue = 0
        'subcate.combosubcate(cbsubcate)
        'cbsubcate.SelectedValue = 0
        product.viewpricebuy(dgvprodouct, 3)
        With dgvprodouct
            .Columns(3).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(12).Visible = False
        End With
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cbcate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcate.SelectedIndexChanged
        Try
            If cbcate.SelectedValue = 0 Then
                product.viewpricebuy(dgvprodouct, 3)
                With dgvprodouct
                    .Columns(3).Visible = False
                    .Columns(5).Visible = False
                    .Columns(6).Visible = False
                    .Columns(8).Visible = False
                    .Columns(9).Visible = False
                    .Columns(12).Visible = False
                End With
            Else
                subcate.combocategory(cbcate.SelectedValue, cbsubcate)
                product.viewpricebuy_bycate_andsubcate(cbcate.SelectedValue, cbsubcate.SelectedValue, dgvprodouct, 3)

                With dgvprodouct
                    .Columns(3).Visible = False
                    .Columns(5).Visible = False
                    .Columns(6).Visible = False
                    .Columns(8).Visible = False
                    .Columns(9).Visible = False
                    .Columns(12).Visible = False
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbsubcate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsubcate.SelectedIndexChanged
        Try
            product.viewpricebuy_bycate_andsubcate(cbcate.SelectedValue, cbsubcate.SelectedValue, dgvprodouct, 3)
            With dgvprodouct
                .Columns(3).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(12).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvprodouct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprodouct.CellClick
        Try
            'Dim frmsale As frmsale = CType(Application.OpenForms("frmsale"), frmsale)
            'Dim frmorder As frmorder = CType(Application.OpenForms("frmorder"), frmorder)
            With dgvprodouct
                If frmcreateorder.formcreateorder = True Then
                    For i As Integer = 0 To frmcreateorder.dgvlist.Rows.Count - 1

                        If frmcreateorder.dgvlist.Rows(i).Cells(0).Value = .CurrentRow.Cells(0).Value Then
                            MessageBox.Show("ສີນຄ້ານີ້ມີແລ້ວກະລຸນາເລືອກສີນຄ້າໄໝ່", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    Next
                    frmcreateorder.dgvlist.CurrentRow.Cells(0).Value = .CurrentRow.Cells(0).Value
                    frmcreateorder.dgvlist.CurrentRow.Cells(1).Value = .CurrentRow.Cells(4).Value

                    frmcreateorder.dgvlist.CurrentRow.Cells(2).Value = .CurrentRow.Cells(7).Value
                    frmcreateorder.dgvlist.CurrentRow.Cells(7).Value = .CurrentRow.Cells(9).Value
                    frmcreateorder.dgvlist.CurrentRow.Cells(4).Value = .CurrentRow.Cells(9).Value
                    Dim ord As frmcreateorder = CType(Application.OpenForms("frmcreateorder"), frmcreateorder)
                    If ord.rdkip.Checked = True And .CurrentRow.Cells(13).Value = "ກີບ" Then
                        frmcreateorder.dgvlist.CurrentRow.Cells(3).Value = .CurrentRow.Cells(10).Value
                    ElseIf ord.rdkip.Checked = True And .CurrentRow.Cells(13).Value = "ບາດ" Then
                        Dim capital As Double = .CurrentRow.Cells(10).Value
                        Dim convertotkip = capital * bath
                        frmcreateorder.dgvlist.CurrentRow.Cells(3).Value = convertotkip.ToString("N0")
                    End If

                    If ord.rdbath.Checked = True And .CurrentRow.Cells(13).Value = "ກີບ" Then
                        Dim capital As Double = .CurrentRow.Cells(10).Value
                        Dim convertotkip = capital / bath
                        frmcreateorder.dgvlist.CurrentRow.Cells(3).Value = convertotkip.ToString("N0")
                    ElseIf ord.rdbath.Checked = True And .CurrentRow.Cells(13).Value = "ບາດ" Then
                        frmcreateorder.dgvlist.CurrentRow.Cells(3).Value = .CurrentRow.Cells(10).Value
                    End If
                    If ord.rddolla.Checked = True And .CurrentRow.Cells(13).Value = "ກີບ" Then
                        Dim capital As Double = .CurrentRow.Cells(10).Value
                        Dim convertotkip = capital / dolla
                        frmcreateorder.dgvlist.CurrentRow.Cells(3).Value = convertotkip.ToString("N0")
                    ElseIf ord.rddolla.Checked = True And .CurrentRow.Cells(13).Value = "ບາດ" Then
                        Dim capital As Double = .CurrentRow.Cells(10).Value
                        Dim convertotkip = capital / dolla
                        frmcreateorder.dgvlist.CurrentRow.Cells(3).Value = convertotkip.ToString("N0")
                    End If

                    Me.Close()

                End If
                If frmstockout.formstockout = True Then
                    For i As Integer = 0 To frmstockout.dgvlist.Rows.Count - 1
                        If frmstockout.dgvlist.Rows(i).Cells(0).Value = .CurrentRow.Cells(0).Value Then
                            MessageBox.Show("ສີນຄ້ານີ້ມີແລ້ວກະລຸນາເລືອກສີນຄ້າໄໝ່", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    Next

                    frmstockout.dgvlist.CurrentRow.Cells(0).Value = .CurrentRow.Cells(0).Value
                    frmstockout.dgvlist.CurrentRow.Cells(1).Value = .CurrentRow.Cells(4).Value
                    frmstockout.dgvlist.CurrentRow.Cells(2).Value = .CurrentRow.Cells(7).Value
                    frmstockout.dgvlist.CurrentRow.Cells(3).Value = .CurrentRow.Cells(10).Value
                    frmstockout.dgvlist.CurrentRow.Cells(6).Value = .CurrentRow.Cells(9).Value
                    frmstockout.dgvlist.CurrentRow.Cells(4).Value = 1

                    Me.Close()
                End If
                If frmreturnproduct.formreturnproduct = True Then
                    frmreturnproduct.proid = .CurrentRow.Cells(0).Value
                    frmreturnproduct.txtproduct.Text = .CurrentRow.Cells(4).Value
                    frmreturnproduct.unitname = .CurrentRow.Cells(7).Value
                    Me.Close()
                End If

                ''''''''''''''''''''''''''''''
                If frmreportreceivedetail.frmreportreceivedetail1 = True Then
                    frmreportreceivedetail.proid = .CurrentRow.Cells(0).Value
                    frmreportreceivedetail.txtproduct.Text = .CurrentRow.Cells(4).Value
                    Me.Close()
                End If

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            product.viewpricebuy_search_name(dgvprodouct, txtsearch.Text, 3)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvprodouct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprodouct.CellContentClick

    End Sub
End Class