Public Class frmshowcustomer
    Dim custype As New tbcustomertype
    Dim sup As New tbsuppliers
    Dim adds As New tbprovience
    Dim custype1 As String
    Private Sub frmshowcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            rtype.Checked = True
            custype.combocustype(cbtype)
            cbtype.SelectedValue = 0
            'adds.comboprovience1(cbprovince)
            'cbprovince.SelectedValue = 0
            'adds.comboboxdistrict1(cbprovince.SelectedValue, cbdistrict)
            'cbdistrict.SelectedValue = 0
            'adds.comboboxvillage1(cbdistrict.SelectedValue, cbban)
            'cbban.SelectedValue = 0


            Dim p As String = "%"
            Dim d As String = "%"
            Dim b As String = "%"
            sup.showsuppliers(custype1, dgvcus, p, d, b)
            With dgvcus
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rtype_CheckedChanged(sender As Object, e As EventArgs) Handles rtype.CheckedChanged
        If rtype.Checked = True Then
            txtsearch.Visible = False
            cbtype.Visible = True
        Else
            txtsearch.Visible = True
            cbtype.Visible = False
        End If
    End Sub

    Private Sub rname_CheckedChanged(sender As Object, e As EventArgs) Handles rname.CheckedChanged
        If rname.Checked = True Then
            txtsearch.Select()
        End If
    End Sub

    Private Sub cbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtype.SelectedIndexChanged
        Try
            If rtype.Checked = True Then
                Dim custype1 As String
                If cbtype.SelectedValue = 0 Then
                    custype1 = "%"
                Else
                    Dim rows As DataRowView = cbtype.SelectedItem
                    Dim row As DataRow = rows.Row
                    custype1 = row(1).ToString
                End If

                Dim p As String = "%"
                Dim d As String = "%"
                Dim b As String = "%"
                sup.showsuppliers(custype1, dgvcus, p, d, b)
                With dgvcus
                    .Columns(3).Visible = False
                    .Columns(4).Visible = False
                    .Columns(5).Visible = False
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            Dim custype1 As String = "%"
            Dim p As String = "%"
            Dim d As String = "%"
            Dim b As String = "%"
            sup.showsuppliers(custype1, dgvcus, p, d, b)
            With dgvcus
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            If rname.Checked = True Then
                custype1 = "%"
                sup.search_suppliers(txtsearch.Text, custype1, dgvcus)
            End If
            With dgvcus
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvcus_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcus.CellMouseEnter

    End Sub

    Private Sub dgvcus_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvcus.CellMouseUp
        Try
            'Dim frmsale As frmsale = CType(Application.OpenForms("frmsale"), frmsale)
            With dgvcus
                If frmsale.formsale = True Then
                    frmsale.sup_id = .CurrentRow.Cells(0).Value
                    frmsale.txtsupname.Text = .CurrentRow.Cells(1).Value
                    If dgvcus.CurrentRow.Cells(9).Value = "ລູກຄ້າຂາຍສົ່ງ" Then
                        frmsale.cbprice.SelectedIndex = 3
                        frmsale.cbprice.Enabled = False
                    Else
                        frmsale.cbprice.SelectedIndex = 0
                        frmsale.cbprice.Enabled = True
                    End If
                    Me.Close()
                End If
                If frmcreateorder.formcreateorder = True Then
                    frmcreateorder.sup_id = .CurrentRow.Cells(0).Value
                    frmcreateorder.txtsupname.Text = .CurrentRow.Cells(1).Value
                    Me.Close()
                End If
                If frmreceiveproduct.formreceive = True Then
                    frmreceiveproduct.sup_id = .CurrentRow.Cells(0).Value
                    frmreceiveproduct.txtsupname.Text = .CurrentRow.Cells(1).Value
                    Me.Close()
                End If
                If frmorder.formorder = True Then
                    frmorder.sup_id = .CurrentRow.Cells(0).Value
                    frmorder.txtsearch.Text = .CurrentRow.Cells(1).Value
                    Me.Close()
                End If
                If frmsalelist.formsalelist = True Then
                    frmsalelist.sup_id = .CurrentRow.Cells(0).Value
                    frmsalelist.txtsearch.Text = .CurrentRow.Cells(1).Value
                    Me.Close()
                End If
                If frmsumarysale.formsumarysale = True Then
                    frmsumarysale.sup_id = .CurrentRow.Cells(0).Value
                    frmsumarysale.txtsearch.Text = .CurrentRow.Cells(1).Value
                    Me.Close()
                End If
                If frmreturnproduct.formreturnproduct = True Then
                    frmreturnproduct.sup_id = .CurrentRow.Cells(0).Value
                    frmreturnproduct.txtsupname.Text = .CurrentRow.Cells(1).Value
                    Me.Close()
                End If
                If frmreportorderbill.formreportorderbill = True Then
                    frmreportorderbill.txtcustomer.Text = .CurrentRow.Cells(1).Value
                    frmreportorderbill.sup_id = .CurrentRow.Cells(0).Value
                    Me.Close()
                End If
                If frmreportreceive.formreportreceive = True Then
                    frmreportreceive.txtcustomer.Text = .CurrentRow.Cells(1).Value
                    frmreportreceive.sup_id = .CurrentRow.Cells(0).Value
                    Me.Close()
                End If
                If frmreportsaledetail.frmreportsaledetail = True Then
                    frmreportsaledetail.txtcustomer.Text = .CurrentRow.Cells(1).Value
                    frmreportsaledetail.sup_id = .CurrentRow.Cells(0).Value
                    frmreportsaledetail.txtcustomer.Focus()
                    Me.Close()
                End If
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvcus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcus.CellContentClick

    End Sub
End Class