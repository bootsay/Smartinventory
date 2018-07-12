Imports System.Data.SqlClient
Public Class frmproduct1
    Dim cn As New connectdb
    Dim price As New tbprice
    Dim pro As New tbproduct
    Dim cate As New tbcategory
    Dim subcate As New tbsubcategory
    Dim da As New SqlDataAdapter
    Dim unit As New tbunits
    Dim stocks As New tbstock
    Dim brands As New tbbrand
    Dim colors As New tbcolor
    Dim dgvpricesalerownumber As Integer
    Dim note As String
    Dim checkproduct As Boolean
    Public edit As Boolean
    Private pCase As Integer
    Private btnSelector As New Button()
    Public formproduct As Boolean = False
    Private Sub frmproduct1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            checkproduct = True
            unit.combounit(cbunit)
            stocks.combocategory(cbstock)
            cate.combocategory(cbcategory)
            cbcategory.SelectedIndex = 0
            If cbcategory.SelectedValue > 0 Then
                subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
            End If

            pro.combomoney(cbmoney)
            stocks.combocapitaltype(cbcapitaltype)
            stocks.combocodetype(cbcodetype)
            stocks.combocutstock_type(cbcutstock)
            brands.combobrand(cbbrand)
            txtqtylow.Text = 1
            txtqtyheight.Text = 1
            'colors.comcolor(cbcolor)
            rdyes.Checked = True


            Dim barcode As New DataGridViewTextBoxColumn()
            Dim productname As New DataGridViewTextBoxColumn()
            Dim unitname As New DataGridViewTextBoxColumn()
            Dim cutstock As New DataGridViewTextBoxColumn()
            Dim qty1 As New DataGridViewTextBoxColumn()
            Dim qty2 As New DataGridViewTextBoxColumn()
            Dim engprice As New DataGridViewTextBoxColumn()
            Dim pricesale As New DataGridViewTextBoxColumn()
            Dim unitid As New DataGridViewTextBoxColumn()
            Dim propriceid As New DataGridViewButtonColumn()
            Dim addbutton As New DataGridViewButtonColumn()


            dgvprice.Columns.Add(barcode) '0
            dgvprice.Columns.Add(productname) '1
            dgvprice.Columns.Add(unitname) '2
            dgvprice.Columns.Add(cutstock) '3
            dgvprice.Columns.Add(qty1) '4
            dgvprice.Columns.Add(qty2) '5
            dgvprice.Columns.Add(engprice) '6
            dgvprice.Columns.Add(pricesale) '7
            dgvprice.Columns.Add(unitid) '8
            dgvprice.Columns.Add(propriceid) '9

            With dgvprice
                .Columns(0).HeaderText = "ບາໂຄດ"
                .Columns(1).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(2).HeaderText = "ຫົວໜ່ວຍສີນຄ້າ"
                .Columns(3).HeaderText = "ຈໍານວນຕັດ/ສະຕ໋ອກ"
                .Columns(4).HeaderText = "ລາຄາໜ້າຮ້ານ"
                .Columns(5).HeaderText = "ລາຄາຊ່າງ"
                .Columns(6).HeaderText = "ລາຄາຕິດຕັ້ງ"
                .Columns(7).HeaderText = "ລາຄາສົ່ງ"
                .Columns(8).HeaderText = "ລະຫັດຫົວໜ່ວຍ"
                .Columns(9).HeaderText = "ລະຫັດ"


                .Columns(0).Width = 180
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                .Columns(6).Width = 100
                .Columns(8).Visible = False
                .Columns(9).Visible = False


            End With
            CreateButton(btnSelector)
            dgvprice.Controls.Add(btnSelector)
            Dim fm As frmmain = CType(Application.OpenForms("frmmain"), frmmain)



          
            If cbsupcategory.SelectedValue > 0 Then
                Dim prefix As String = subcate.Call_prefix(cbsupcategory.SelectedValue)
                Dim count As Integer = pro.countproduct(prefix)
                txtid.Text = pro.runid(count, prefix)
            End If
            txtname.Focus()
            enablesave()

            If frmmain.UserAuthentication = "" Then
                btnupdate4.Enabled = False
                btndelete4.Enabled = False
            Else
                Dim btnupdate41 As String = "F"
                Dim btndelete41 As String = "F"
                btnupdate41 = frmmain.UserAuthentication.Substring(27, 1)
                btndelete41 = frmmain.UserAuthentication.Substring(28, 1)

                If btnupdate41 = "T" Then
                    btnupdate4.Visible = True
                Else
                    btnupdate4.Visible = False
                    T1.Visible = False
                End If
                If btndelete41 = "T" Then
                    btndelete4.Enabled = True
                Else
                    btndelete4.Visible = False
                    T2.Visible = False
                End If

            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CreateButton(ByRef myButton As Button)
        myButton.FlatAppearance.BorderSize = 0
        myButton.Size = New Size(30, 30)
        myButton.Text = "..."
        myButton.Hide()
        AddHandler myButton.Click, New EventHandler(AddressOf Me.SelectorClick)
    End Sub
    Private Sub SelectorClick(ByVal sender As Object, ByVal e As EventArgs)
        Select Case pCase
            Case 1
                If True Then
                    formproduct = True
                    frmshowunit.ShowDialog()
                    formproduct = False
                    Exit Select
                End If
        End Select
    End Sub

    Private Sub enablesave()
        btnsave4.Enabled = True
        btndelete4.Enabled = False
        btnedit4.Enabled = False
        btnupdate4.Enabled = False
        btnnew4.Enabled = True
    End Sub
    Private Sub enableedit()
        btnsave4.Enabled = False
        btndelete4.Enabled = True
        btnedit4.Enabled = True
        btnupdate4.Enabled = False
        btnnew4.Enabled = True
    End Sub
    Private Sub enableupdate()
        btnsave4.Enabled = False
        btndelete4.Enabled = False
        btnedit4.Enabled = False
        btnupdate4.Enabled = True
        btnnew4.Enabled = True
    End Sub
    Private Sub btnshowstock_Click(sender As Object, e As EventArgs)
        'frmstock.ShowDialog()
        'frmstock.Close()
    End Sub
    Private Sub dgvprice_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try

            'For i As Integer = 0 To dgvprice.Rows.Count - 1
            '    If dgvprice.Rows(i).Cells(i).Selected = True Then
            '        dgvprice.EndEdit(True)
            '    End If
            'Next
            If dgvprice.CurrentRow.Cells(4).Selected = True Then
                dgvprice.BeginEdit(True)
            ElseIf dgvprice.CurrentRow.Cells(13).Selected = True Then
                'frmproductionoption.ShowDialog()
                'frmproductionoption.Close()
                'dgvprice.EndEdit(True)
            End If
        Catch ex As Exception

        End Try

    End Sub

  
    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
 
    Private Sub dgvprice_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvprice.EditingControlShowing
        'MessageBox.Show(dgvprice.CurrentCell.ColumnIndex)

        Try
            If dgvprice.CurrentCell.ColumnIndex = 3 Or dgvprice.CurrentCell.ColumnIndex = 4 Or dgvprice.CurrentCell.ColumnIndex = 5 Or dgvprice.CurrentCell.ColumnIndex = 6 Then
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
            Else
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
            End If

        Catch ex As Exception

        End Try
      
    End Sub
    Private Sub btnaddrow_Click(sender As Object, e As EventArgs) Handles btnaddrow.Click
        'Try
        Dim qq As Integer = dgvprice.Rows.Count
        If dgvprice.Rows.Count > 0 Then
            dgvprice.Rows.Add()
            'dgvprice.Rows(qq + 1).Cells(3).ReadOnly = True
            dgvprice.Rows(qq).Height = 30
            dgvprice.Rows(qq).Cells(0).Value = txtid.Text
            dgvprice.Rows(qq).Cells(1).Value = txtname.Text
            dgvprice.EndEdit()

        Else
            dgvprice.Rows.Add()
            'dgvprice.Rows(0).Cells(3).ReadOnly = True
            dgvprice.Rows(0).Height = 30
            dgvprice.Rows(0).Cells(0).Value = txtid.Text
            dgvprice.Rows(0).Cells(1).Value = txtname.Text
            dgvprice.EndEdit()

        End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btndeleterow_Click(sender As Object, e As EventArgs) Handles btndeleterow.Click
        Try
            dgvprice.Rows.RemoveAt(dgvprice.Rows.Count - 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvprice_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprice.CellEnter, dgvprice.CellClick
        Try
            If dgvprice.CurrentRow.Cells(2).Selected = True Then
                pCase = 1
                Dim Loc As Rectangle = dgvprice.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
                Dim Wid As Integer = dgvprice.CurrentCell.Size.Width
                btnSelector.Location = New Point(Loc.X - 30 + Wid, Loc.Y)
                btnSelector.Show()
            Else
                btnSelector.Hide()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtpricesale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpricesale.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtpricesale_TextChanged(sender As Object, e As EventArgs) Handles txtpricesale.TextChanged
        Try
            Dim tem As Double = txtpricesale.Text
            txtpricesale.Text = tem.ToString("N0")
            txtpricesale.SelectionStart = txtpricesale.TextLength

       
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtqtylow_TextChanged(sender As Object, e As EventArgs) Handles txtqtylow.TextChanged
        Try
            Dim tem As Double = txtqtylow.Text
            txtqtylow.Text = tem.ToString("N0")
            txtqtylow.SelectionStart = txtqtylow.TextLength
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtqtyheight_TextChanged(sender As Object, e As EventArgs) Handles txtqtyheight.TextChanged
        Try
            Dim tem As Double = txtqtyheight.Text
            txtqtyheight.Text = tem.ToString("N0")
            txtqtyheight.SelectionStart = txtqtyheight.TextLength
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtqtylow_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqtylow.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtqtyheight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqtyheight.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnsave4_Click(sender As Object, e As EventArgs) Handles btnsave4.Click
        'Try
        dgvprice.EndEdit(True)
        If txtname.Text = "" Then
            MessageBox.Show("ກະລຸນາໃສ່ຊື່ສີນຄ້າ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtname.Select()
            Return
        End If
        If txtmodel.Text = "" Then
            MessageBox.Show("ກະລຸນາໃສ່ລຸ້ນ(Model)", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtmodel.Select()
            Return
        End If
        If txtpricesale.Text = "" Then
            MessageBox.Show("ກະລຸນາໃສ່ລາຄາຊື້ສີນຄ້າ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpricesale.Select()
            Return
        End If
        If txtqtylow.Text = "" Then
            MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນຕໍ່າສຸດ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtqtylow.Select()
            Return
        End If
        If txtqtyheight.Text = "" Then
            MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນສູງສຸດ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtqtyheight.Select()
            Return
        End If
        If txtremindqty.Text = "" Then
            MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນຈຸດສັ່ງຊື້", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtremindqty.Select()
            Return
        End If

        If dgvprice.Rows.Count <= 0 Then
            MessageBox.Show("ກະລຸນາເພີ້ມແຖວ ແລ້ວໃສ່ລາຄາຈໍາໜ່າຍ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        For b As Integer = 0 To dgvprice.Rows.Count - 1
            If dgvprice.Rows(b).Cells(0).Value = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນບາໂຄດ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Return
                Exit For
            End If
            If dgvprice.Rows(b).Cells(1).Value = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນຊື່ສີນຄ້າ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit For
                Return
            End If
            If dgvprice.Rows(b).Cells(2).Value = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນຫົວໜ່ວຍສີນຄ້າ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
                Exit For
            End If
            If dgvprice.Rows(b).Cells(3).Value < 1 Then
                MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນຕັດສະຕ໋ອກ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
                Exit For
            End If
            'If dgvprice.Rows(b).Cells(4).Value = "" Then
            '    MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນລາຄາໜ້າຮ້ານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return
            '    Exit For
            'End If
            If dgvprice.Rows(b).Cells(5).Value = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນລາຄາຊ່າງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
                Exit For
            End If
            If dgvprice.Rows(b).Cells(6).Value = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນລາຄາຕິດຕັ້ງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
                Exit For
            End If
            If dgvprice.Rows(b).Cells(7).Value = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນລາຄາສົ່ງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
                Exit For
            End If
        Next    
        Dim checkname As String = pro.check_duplicatename(txtname.Text)
        If checkname = "False" Then
        Else
            MessageBox.Show("ມີຊື່ນີ້ແລ້ວໃນຖານຂໍ້ມູນ, ລະຫັດແມ່ນ: " & checkname, "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtname.Select()
            Return
        End If
       
        Dim prefix As String = subcate.Call_prefix(cbsupcategory.SelectedValue)

        Dim count As Integer = pro.countproduct(prefix)
        Dim proid As String = pro.runid(count, prefix)
        MessageBox.Show(count)
        Dim Checkduplicate_proid As String = pro.Check_duplicationID(proid)
        If Checkduplicate_proid = "false" Then
            MessageBox.Show("ທ່ານມີລະຫັດນີ້ແລ້ວໃນລະບົບ", "ຄໍເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກຂໍ້ມູນແທ້ບໍ່?", "ຄໍາແນະນໍາ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then


            If rdyes.Checked = True Then
                note = "Yes"
            Else
                note = "No"
            End If
            pro.save(proid, cbstock.SelectedValue, cbsupcategory.SelectedValue, cbbrand.SelectedValue, txtname.Text, txtmodel.Text, cbunit.SelectedValue, txtqtylow.Text, txtqtyheight.Text, cbcapitaltype.SelectedValue, txtpricesale.Text, cbmoney.SelectedValue, txtremindqty.Text, cbcutstock.SelectedValue, cbcodetype.SelectedValue, note, 0)
            For i As Integer = 0 To dgvprice.Rows.Count - 1
                Dim priceid As Integer = price.runid
                Dim barcode As String = dgvprice.Rows(i).Cells(0).Value
                Dim proname As String = dgvprice.Rows(i).Cells(1).Value
                Dim qtycut As Integer = dgvprice.Rows(i).Cells(3).Value
                Dim saleall As Integer = dgvprice.Rows(i).Cells(4).Value
                Dim sale_eng As Integer = dgvprice.Rows(i).Cells(5).Value
                Dim sale_small As Double = dgvprice.Rows(i).Cells(6).Value
                Dim sale_big As Double = dgvprice.Rows(i).Cells(7).Value
                Dim unitid As Integer = dgvprice.Rows(i).Cells(8).Value
                price.save(priceid, txtid.Text, barcode, proname, unitid, qtycut, saleall, sale_eng, sale_small, sale_big)
            Next
            pro.viewpricebuy(dgvproduct, 0)
            txtname.Clear()
            txtpricesale.Clear()
            txtqtylow.Clear()
            txtqtyheight.Clear()
            Dim prefix1 As String = subcate.Call_prefix(cbsupcategory.SelectedValue)
            Dim count1 As Integer = pro.countproduct(prefix1)
            txtid.Text = pro.runid(count1, prefix1)
            txtname.Select()
            dgvprice.Rows.Clear()
            dgvprice.Refresh()
            txtqtylow.Text = 1
            txtqtyheight.Text = 1
        Else

        End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dgvproductsaleprice_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvproductsaleprice.CellMouseUp
        Try
            tab1.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTabIndex = 1
    End Sub

    Private Sub rdname_CheckedChanged(sender As Object, e As EventArgs) Handles rdname.CheckedChanged
        If rdname.Checked = True Then
            cbsearchtype.Visible = False
            cbsubcate.Visible = False
            txtsearch.Visible = True
            txtsearch.Clear()
            txtsearch.Select()
        End If
    End Sub

    Private Sub rdid_CheckedChanged(sender As Object, e As EventArgs) Handles rdid.CheckedChanged
        If rdid.Checked = True Then
            cbsearchtype.Visible = False
            cbsubcate.Visible = False
            txtsearch.Visible = True
            txtsearch.Clear()
            txtsearch.Select()
        End If
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

    Private Sub dgvproduct_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvproduct.CellMouseUp
        Try
            price.viewprice(dgvproduct.CurrentRow.Cells(0).Value, dgvproductsaleprice)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvproduct_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproduct.CellDoubleClick
        Try
            btnsave4.Enabled = False
            dgvprice.Rows.Clear()
            TabControl1.SelectedTabIndex = 0
            Dim bb As String
            With dgvproduct
                txtid.Text = .CurrentRow.Cells(0).Value
                cbstock.Text = .CurrentRow.Cells(1).Value
                cbcategory.Text = .CurrentRow.Cells(2).Value
                cbsubcate.Text = .CurrentRow.Cells(3).Value

                txtname.Text = .CurrentRow.Cells(4).Value
                cbbrand.Text = .CurrentRow.Cells(5).Value
                txtmodel.Text = .CurrentRow.Cells(6).Value
                'cbcolor.Text = .CurrentRow.Cells(6).Value
                cbunit.Text = .CurrentRow.Cells(7).Value
                txtqtylow.Text = .CurrentRow.Cells(8).Value
                txtqtyheight.Text = .CurrentRow.Cells(9).Value
                cbcapitaltype.Text = .CurrentRow.Cells(14).Value
                Dim price1 As Double = .CurrentRow.Cells(10).Value
                cbmoney.Text = .CurrentRow.Cells(13).Value
                txtremindqty.Text = .CurrentRow.Cells(15).Value
                cbcutstock.Text = .CurrentRow.Cells(16).Value
                cbcodetype.Text = .CurrentRow.Cells(17).Value
                bb = .CurrentRow.Cells(18).Value
                If bb = "Yes" Then
                    rdyes.Checked = True
                Else
                    rdno.Checked = True
                End If
                txtpricesale.Text = price1.ToString("N0")
                disabletext()
                enableedit()
                checkproduct = False
            End With
            For i As Integer = 0 To dgvproductsaleprice.Rows.Count - 1
                Dim barcode As String = dgvproductsaleprice.Rows(i).Cells(2).Value
                Dim proname As String = dgvproductsaleprice.Rows(i).Cells(3).Value
                Dim unitname As String = dgvproductsaleprice.Rows(i).Cells(4).Value
                Dim qtycut As Integer = dgvproductsaleprice.Rows(i).Cells(5).Value
                Dim priceall As Integer = dgvproductsaleprice.Rows(i).Cells(6).Value
                Dim price_eng As Integer = dgvproductsaleprice.Rows(i).Cells(7).Value
                Dim price_small As Double = dgvproductsaleprice.Rows(i).Cells(8).Value
                Dim price_big As Integer = dgvproductsaleprice.Rows(i).Cells(9).Value
                Dim unitid As Integer = dgvproductsaleprice.Rows(i).Cells(10).Value
                Dim propriceid As Integer = dgvproductsaleprice.Rows(i).Cells(0).Value
                dgvprice.Rows.Add(barcode, proname, unitname, qtycut, priceall, price_eng, price_small, price_big, unitid, propriceid)
            Next
            dgvpricesalerownumber = dgvproductsaleprice.Rows.Count
            dgvprice.Enabled = False
            btnaddrow.Enabled = False
            btndeleterow.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub disabletext()
        txtname.ReadOnly = True
        txtpricesale.ReadOnly = True
        txtqtylow.ReadOnly = True
        txtqtyheight.ReadOnly = True
        cbcategory.Enabled = False
        cbunit.Enabled = False
    End Sub
    Private Sub Enabletext()
        txtname.ReadOnly = False
        txtpricesale.ReadOnly = False
        txtqtylow.ReadOnly = False
        txtqtyheight.ReadOnly = False
        txtname.Select()
        cbcategory.Enabled = True
        cbunit.Enabled = True
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

    Private Sub btnedit4_Click(sender As Object, e As EventArgs) Handles btnedit4.Click
        edit = True
        checkproduct = False
        enableupdate()
        Enabletext()
        dgvprice.Enabled = True
        btnaddrow.Enabled = True
        btndeleterow.Enabled = True
    End Sub

    Private Sub btnaddcategory_Click(sender As Object, e As EventArgs) Handles btnaddcategory.Click
        frmcategory.ShowDialog()
        frmcategory.Close()
        cate.combocategory(cbcategory)
    End Sub

    Private Sub btnaddunit_Click(sender As Object, e As EventArgs) Handles btnaddunit.Click
        frmunit.ShowDialog()
        frmunit.Close()
        unit.combounit(cbunit)
    End Sub

    Private Sub btnupdate4_Click(sender As Object, e As EventArgs) Handles btnupdate4.Click
        dgvprice.EndEdit(True)
        If txtname.Text = "" Then
            MessageBox.Show("ກະລຸນາໃສ່ຊື່ສີນຄ້າ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtname.Select()
            Return
        End If
        If txtmodel.Text = "" Then
            MessageBox.Show("ກະລຸນາໃສ່ລຸ້ນ(Model)", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtmodel.Select()
            Return
        End If
        If txtpricesale.Text = "" Then
            MessageBox.Show("ກະລຸນາໃສ່ລາຄາຊື້ສີນຄ້າ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpricesale.Select()
            Return
        End If
        If txtqtylow.Text = "" Then
            MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນຕໍ່າສຸດ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtqtylow.Select()
            Return
        End If
        If txtqtyheight.Text = "" Then
            MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນສູງສຸດ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtqtyheight.Select()
            Return
        End If
        If txtremindqty.Text = "" Then
            MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນຈຸດສັ່ງຊື້", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtremindqty.Select()
            Return
        End If

        If dgvprice.Rows.Count <= 0 Then
            MessageBox.Show("ກະລຸນາເພີ້ມແຖວ ແລ້ວໃສ່ລາຄາຈໍາໜ່າຍ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        For b As Integer = 0 To dgvprice.Rows.Count - 1
            If dgvprice.Rows(b).Cells(0).Value = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນບາໂຄດ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Return
                Exit For
            End If
            If dgvprice.Rows(b).Cells(1).Value = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນຊື່ສີນຄ້າ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit For
                Return
            End If
            If dgvprice.Rows(b).Cells(2).Value = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນຫົວໜ່ວຍສີນຄ້າ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
                Exit For
            End If
            If dgvprice.Rows(b).Cells(3).Value < 1 Then
                MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນຕັດສະຕ໋ອກ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
                Exit For
            End If
            'If dgvprice.Rows(b).Cells(4).Value = "" Then
            '    MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນລາຄາໜ້າຮ້ານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return
            '    Exit For
            'End If
            'If dgvprice.Rows(b).Cells(5).Value = "" Then
            '    MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນລາຄາຊ່າງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return
            '    Exit For
            'End If
            'If dgvprice.Rows(b).Cells(6).Value = "" Then
            '    MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນລາຄາຕິດຕັ້ງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return
            '    Exit For
            'End If
            'If dgvprice.Rows(b).Cells(7).Value = "" Then
            '    MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນລາຄາສົ່ງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return
            '    Exit For
            'End If
        Next
       
        Dim dgvpricerow As Integer = dgvprice.Rows.Count
        If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນແທ້ບໍ່?", "ຄໍາແນະນໍາ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
            'Dim proid As Integer = pro.runid
            If rdyes.Checked = True Then
                note = "Yes"
            Else
                note = "No"
            End If
            pro.update(txtid.Text, cbstock.SelectedValue, cbsupcategory.SelectedValue, cbbrand.SelectedValue, txtname.Text, txtmodel.Text, cbunit.SelectedValue, txtqtylow.Text, txtqtyheight.Text, cbcapitaltype.SelectedValue, txtpricesale.Text, cbmoney.SelectedValue, txtremindqty.Text, cbcutstock.SelectedValue, cbcodetype.SelectedValue, note)
            For d As Integer = 0 To dgvproductsaleprice.Rows.Count - 1
                price.delete(dgvproductsaleprice.Rows(d).Cells(0).Value) 'delete data from tbprice
            Next
            For i As Integer = 0 To dgvprice.Rows.Count - 1
                Dim priceid As Integer = price.runid
                Dim barcode As String = dgvprice.Rows(i).Cells(0).Value
                Dim proname As String = dgvprice.Rows(i).Cells(1).Value
                Dim qtycut As Integer = dgvprice.Rows(i).Cells(3).Value
                Dim saleall As Integer = dgvprice.Rows(i).Cells(4).Value
                Dim sale_eng As Integer = dgvprice.Rows(i).Cells(5).Value
                Dim sale_small As Double = dgvprice.Rows(i).Cells(6).Value
                Dim sale_big As Double = dgvprice.Rows(i).Cells(7).Value
                Dim unitid As Integer = dgvprice.Rows(i).Cells(8).Value

                price.save(priceid, txtid.Text, barcode, proname, unitid, qtycut, saleall, sale_eng, sale_small, sale_big)
            Next
       
            'txtid.Text = pro.runid
        'price.viewprice(txtid.Text, dgvproductsaleprice)
        txtname.Clear()
        txtpricesale.Clear()
        txtqtylow.Clear()
        txtqtyheight.Clear()
            'txtid.Text = pro.runid
        txtname.Select()
        dgvprice.Rows.Clear()

            pro.viewpricebuy(dgvproduct, 0)
        enablesave()
        checkproduct = True
        txtqtylow.Text = 1
        txtqtyheight.Text = 1
        Else

        End If
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

    Private Sub btnbox_Click(sender As Object, e As EventArgs)
        If dgvprice.SelectedCells.Count >= 1 Then
            dgvprice.CurrentRow.Cells(0).Value = price.Gen_barcode_box()
        Else

        End If

    End Sub

    Private Sub btnpack_Click(sender As Object, e As EventArgs)
        If dgvprice.SelectedCells.Count >= 1 Then
            dgvprice.CurrentRow.Cells(0).Value = price.Gen_barcode_pack
        End If
    End Sub

    Private Sub btnunit_Click(sender As Object, e As EventArgs)
        If dgvprice.SelectedCells.Count >= 1 Then
            dgvprice.CurrentRow.Cells(0).Value = price.Gen_barcode_unit
        End If
    End Sub
    Private Sub btnnew4_Click(sender As Object, e As EventArgs) Handles btnnew4.Click
        'txtid.Text = pro.runid
        txtname.Clear()
        txtpricesale.Clear()
        txtqtylow.Clear()
        txtqtyheight.Clear()
        dgvprice.Rows.Clear()
        txtmodel.Clear()
        txtremindqty.Clear()
        txtname.ReadOnly = False
        txtpricesale.ReadOnly = False
        txtqtylow.ReadOnly = False
        txtqtyheight.ReadOnly = False
        cbunit.Enabled = True
        cbmoney.Enabled = True
        cbcategory.Enabled = True
        dgvprice.Enabled = True
        btnaddrow.Enabled = True
        btndeleterow.Enabled = True
        txtname.Select()
        enablesave()
        checkproduct = True
        edit = False
        txtqtylow.Text = 1
        txtqtyheight.Text = 1
        'Dim prefix As String = subcate.Call_prefix(cbsupcategory.SelectedValue)
        'Dim count As Integer = pro.countproduct(prefix)
        'txtid.Text = pro.runid(count, prefix)
        If btnsave4.Enabled = True Then
            Dim prefix As String = subcate.Call_prefix(cbsupcategory.SelectedValue)
            Dim count As Integer = pro.countproduct(prefix)
            txtid.Text = pro.runid(count, prefix)
            'MessageBox.Show(count)
            'MessageBox.Show(prefix)
        Else

        End If
    End Sub

    Private Sub dgvproduct_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvproduct.KeyDown
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

    Private Sub btndelete4_Click(sender As Object, e As EventArgs) Handles btndelete4.Click
        If MessageBox.Show("ທ່ານຕ້ອງການລືບຂໍ້ມູນແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            For k As Integer = 0 To dgvprice.Rows.Count - 1
                price.delete(dgvproductsaleprice.Rows(k).Cells(0).Value) 'delete data from tbprice
            Next
            pro.delete(txtid.Text)
            'txtid.Text = pro.runid
            txtname.Clear()
            txtpricesale.Clear()
            txtqtylow.Clear()
            txtqtyheight.Clear()
            dgvprice.Rows.Clear()
            txtname.ReadOnly = False
            txtpricesale.ReadOnly = False
            txtqtylow.ReadOnly = False
            txtqtyheight.ReadOnly = False
            cbunit.Enabled = True
            cbmoney.Enabled = True
            cbcategory.Enabled = True
            pro.viewpricebuy(dgvproduct, 0)
            txtname.Select()
            enablesave()
        Else

        End If
    End Sub


    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtname_MouseLeave(sender As Object, e As EventArgs) Handles txtname.MouseLeave
        'If checkproduct = True Then
        '    Dim checkname As String = pro.check_duplicatename(txtname.Text)
        '    If checkname = "NONAME" Then
        '    Else
        '        MessageBox.Show("ມີຊື່ນີ້ແລ້ວໃນຖານຂໍ້ມູນ, ລະຫັດແມ່ນ: " & checkname, "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Return
        '    End If
        'Else

        'End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnstock_Click(sender As Object, e As EventArgs) Handles btnstock.Click
        frmstock.ShowDialog()
        frmstock.Close()
        stocks.combocategory(cbstock)
    End Sub
    Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcategory.SelectedIndexChanged
        Try
            subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtremindqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtremindqty.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnsubcategory_Click(sender As Object, e As EventArgs) Handles btnsubcategory.Click
        Try
            frmsubcategory.ShowDialog()
            frmsubcategory.Close()
            subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnband_Click(sender As Object, e As EventArgs) Handles btnband.Click
        Try
            frmbrand.ShowDialog()
            frmbrand.Close()
            brands.combobrand(cbbrand)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbsubcate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsubcate.SelectedIndexChanged
        Try
            pro.viewpricebuy_bycate_andsubcate(cbsearchtype.SelectedValue, cbsubcate.SelectedValue, dgvproduct, 0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbsupcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsupcategory.SelectedIndexChanged
        Try
            If btnsave4.Enabled = True Then
                Dim prefix As String = subcate.Call_prefix(cbsupcategory.SelectedValue)
                Dim count As Integer = pro.countproduct(prefix)
                txtid.Text = pro.runid(count, prefix)
                'MessageBox.Show(count)
                'MessageBox.Show(prefix)
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

   

    Private Sub tab2_Click(sender As Object, e As EventArgs) Handles tab2.Click
        Try
            pro.viewpricebuy(dgvproduct, 0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rnopricesale.CheckedChanged
        Try
            If rnopricesale.Checked = True Then
                txtsearch.Visible = False
                cbsubcate.Visible = True
                cbsearchtype.Visible = True
                cate.combocategory1(cbsearchtype)
                cbsearchtype.SelectedValue = 0

                pro.viewpricebuy_search_Noprice(dgvproduct)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class