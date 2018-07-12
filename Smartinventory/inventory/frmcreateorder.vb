Public Class frmcreateorder
    Dim orderpay As New tbpayorder
    Dim setmoney As New tbsetmoney
    Dim order As New tborder
    Dim vath As New tbtax
    Dim sale As New tbsales
    Dim exch As New tbexchange
    Dim pays As New tbpay
    Public formcreateorder As Boolean = False
    Private pCase As Integer
    Private btnSelector As New Button()
    Private rowIndex As Integer = 0
    Dim tem_totalsale As Double
    Public sup_id As String
    Dim frmmain As frmmain = CType(Application.OpenForms("frmmain"), frmmain)
    Public mainmoney As String
    Public payname As String
    Public dt As New DataTable
    Dim cbt As Int16
    Dim dtorderdetail As New DataTable
    Dim cus As New tbsuppliers
    Private Sub frmsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If frmmain.UserAuthentication = "" Then
                btncancel.Enabled = False
            Else
                Dim btncancel1 As String = "F"
                btncancel1 = frmmain.UserAuthentication.Substring(31, 1)
                If btncancel1 = "T" Then
                    btncancel.Enabled = True
                Else
                    btncancel.Visible = False

                End If
            End If

            dgvlist.Columns.Clear()
            dgvlist.Rows.Clear()
            vath.combotax(cbtax)
            If frmorder.formorder = True Then
                disableform()
                enableedit()
                Makecolumns()
                dgvlist.Rows.Clear()
                dt.Clear()
                order.loadorderdetail(frmorder.dgvshow.CurrentRow.Cells(0).Value, dt)

                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim proid As String = dt.Rows(i).Item(8)
                    Dim proname As String = dt.Rows(i).Item(2)
                    Dim unitname As String = dt.Rows(i).Item(3)
                    Dim price As Double = dt.Rows(i).Item(4)
                    Dim qty As Integer = dt.Rows(i).Item(5)
                    Dim discount As Double = dt.Rows(i).Item(6)
                    Dim tatol As Double = dt.Rows(i).Item(7)
                    Dim ordercut As Integer = dt.Rows(i).Item(9)
                    Dim totalorderqty As Integer = dt.Rows(i).Item(10)
                    dgvlist.Rows.Add(proid, proname, unitname, price, qty, discount, tatol, ordercut, totalorderqty)
                    'dgvreceive.Rows.Add(proid, proname, unitname, price, qty, tatol, ordercut, totalorderqty, "", Day)
                Next
                dtsale.Text = frmorder.dgvshow.CurrentRow.Cells(9).Value
                txtordername.Text = frmorder.dgvshow.CurrentRow.Cells(2).Value
                txtorderNO.Text = frmorder.dgvshow.CurrentRow.Cells(0).Value
                txtorderNote.Text = frmorder.dgvshow.CurrentRow.Cells(12).Value
                sup_id = frmorder.dgvshow.CurrentRow.Cells(14).Value
                txtsupname.Text = frmorder.dgvshow.CurrentRow.Cells(15).Value
                Dim pay As String = frmorder.dgvshow.CurrentRow.Cells(1).Value
                Dim mainmoney As String = frmorder.dgvshow.CurrentRow.Cells(13).Value
                If pay = "ສົດ" Then
                    rdcash.Checked = True
                    rddebit.Checked = False
                Else
                    rddebit.Checked = True
                    rdcash.Checked = False
                End If
                If mainmoney = "ກີບ" Then
                    rdkip.Checked = True
                ElseIf mainmoney = "ບາດ" Then
                    rdbath.Checked = True
                Else
                    rddolla.Checked = True
                End If
                If frmorder.dgvshow.CurrentRow.Cells(10).Value = False And frmorder.dgvshow.CurrentRow.Cells(11).Value = False Then
                    btncancel.Enabled = True
                    btnedit.Enabled = True
                ElseIf frmorder.dgvshow.CurrentRow.Cells(10).Value = False And frmorder.dgvshow.CurrentRow.Cells(11).Value = True Then

                    btncancel.Enabled = True
                    btnedit.Enabled = False
                ElseIf frmorder.dgvshow.CurrentRow.Cells(10).Value = True Then
                    btnedit.Enabled = False
                    btncancel.Enabled = False
                End If

                Dim sum1 As Double
                For i As Integer = 0 To dgvlist.Rows.Count - 1
                    sum1 += dgvlist.Rows(i).Cells(6).Value
                Next
                txttotal.Text = sum1.ToString("N0")
                Dim discout As Double = frmorder.dgvshow.CurrentRow.Cells(5).Value
                'MessageBox.Show(discout)

                txtdiscount.Text = discout.ToString("N0")
                Dim lasttotal As Double = Val(CInt(txttotal.Text)) - Val(CInt(txtdiscount.Text))
                txttotallast.Text = lasttotal.ToString("N0")

                Dim etax As Integer = frmorder.dgvshow.CurrentRow.Cells(4).Value
                If etax > 0 Then
                    cbtax.Text = frmorder.dgvshow.CurrentRow.Cells(4).Value
                    Dim total As Double = frmorder.dgvshow.CurrentRow.Cells(6).Value
                    'txttotal.Text = total.ToString("N0")
                    txttotallast.Text = total.ToString("N0")
                    'txtdiscount.Text = 0
                End If



            Else
                txtordername.Text = frmmain.laoname
                txtdiscount.Text = 0
                enablesave()
                mainmoney = setmoney.Call_mainmoney
                If mainmoney = "ກີບ" Then
                    rdkip.Checked = True
                ElseIf mainmoney = "ບາດ" Then
                    rdbath.Checked = True
                Else
                    rddolla.Checked = True
                End If
            End If
            Dim counts As Integer = 0
            For i As Integer = 0 To dgvlist.Rows.Count - 1
                If dgvlist.Rows(i).Cells(0).Value Is Nothing Then
                Else
                    counts += 1
                End If
            Next
            txtcount.Text = counts

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub enableform()
        txtorderNote.Enabled = True
        btnsave.Enabled = True
        btnclear.Enabled = True
        btnadd.Enabled = True
        btnminus.Enabled = True
        dgvlist.Enabled = True
    End Sub
    Private Sub disableform()
        txtorderNote.Enabled = False
        btnsave.Enabled = False
        btnclear.Enabled = False
        btnadd.Enabled = False
        btnminus.Enabled = False
        dgvlist.Enabled = False
    End Sub
    Private Sub formclear()
        txtorderNO.Clear()
        txtorderNote.Clear()
        txtsupname.Clear()
        txttotal.Clear()
        txtdiscount.Clear()
        txttotallast.Clear()
    End Sub
    Private Sub enablesave()
        btnsave.Enabled = True
        btnedit.Enabled = False
        btnupdate.Enabled = False
        btnnew.Enabled = True
    End Sub
    Private Sub enableedit()
        btnsave.Enabled = False
        btnedit.Enabled = True
        btnupdate.Enabled = False
        btnnew.Enabled = True
    End Sub
    Private Sub enableupdate()
        btnsave.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = True
        btnnew.Enabled = True
    End Sub
    Private Sub Makecolumns()
        Dim id As New DataGridViewTextBoxColumn()
        Dim name As New DataGridViewTextBoxColumn()
        Dim unit As New DataGridViewTextBoxColumn()
        Dim price As New DataGridViewTextBoxColumn()
        Dim qty As New DataGridViewTextBoxColumn()
        Dim discount As New DataGridViewTextBoxColumn()
        Dim total As New DataGridViewTextBoxColumn()
        Dim numbercut As New DataGridViewTextBoxColumn()
        Dim sumnumbercut As New DataGridViewTextBoxColumn()

        dgvlist.Columns.Add(id)
        dgvlist.Columns.Add(name)
        dgvlist.Columns.Add(unit)
        dgvlist.Columns.Add(price)
        dgvlist.Columns.Add(qty)
        dgvlist.Columns.Add(discount)
        dgvlist.Columns.Add(total)
        dgvlist.Columns.Add(numbercut)
        dgvlist.Columns.Add(sumnumbercut)
        With dgvlist
            .Columns(0).HeaderText = "ລະຫັດສິນຄ້າ"
            .Columns(1).HeaderText = "ຊື່ສິນຄ້າ"
            .Columns(2).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(3).HeaderText = "ລາຄາ/ໜ່ວຍ"
            .Columns(4).HeaderText = "ຈໍານວນ"
            .Columns(5).HeaderText = "ລຸດ"
            .Columns(6).HeaderText = "ລວມ"
            .Columns(7).HeaderText = "ຈໍານວນຕັດ"
            .Columns(8).HeaderText = "ລວມຈໍານວນຕັດ"

            .Columns(0).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(6).ReadOnly = True

            .Columns(0).Width = 120
            .Columns(1).Width = 250
            .Columns(2).Width = 100
            .Columns(3).Width = 150
            .Columns(4).Width = 100
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(7).Visible = False
            .Columns(8).Visible = False
        End With
        dgvlist.Columns(3).DefaultCellStyle.Format = "N0"
        dgvlist.Columns(4).DefaultCellStyle.Format = "N0"
        dgvlist.Columns(5).DefaultCellStyle.Format = "N0"
        dgvlist.Columns(6).DefaultCellStyle.Format = "N0"
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
                    dgvlist.ClearSelection()
                    formcreateorder = True
                    frmshowproduct.ShowDialog()
                    With dgvlist
                        .Columns(0).ReadOnly = True
                        .Columns(1).ReadOnly = True
                        .Columns(2).ReadOnly = True
                        .Columns(3).DefaultCellStyle.Format = "N0"
                        .Columns(4).DefaultCellStyle.Format = "N0"
                        .Columns(5).DefaultCellStyle.Format = "N0"
                        .Columns(6).DefaultCellStyle.Format = "N0"
                        .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    End With
                    formcreateorder = False
                    pCase = 0

                    Dim counts As Integer = 0
                    For i As Integer = 0 To dgvlist.Rows.Count - 1
                        If dgvlist.Rows(i).Cells(0).Value Is Nothing Then
                        Else
                            counts += 1
                        End If
                    Next
                    txtcount.Text = counts
                    Exit Sub

                End If

                Exit Select
            Case 2
                If True Then
                    formcreateorder = True
                    frmshowunit.ShowDialog()
                    formcreateorder = False
                    pCase = 0
                    Exit Select
                End If
        End Select
    End Sub
  

    Private Sub btnbrown_Click(sender As Object, e As EventArgs) Handles btnbrown.Click
        formcreateorder = True
        frmshowcustomer.ShowDialog()
        frmshowcustomer.Close()
        formcreateorder = False
    End Sub

    Private Sub btnsalename_Click(sender As Object, e As EventArgs)
        Try
            frmsalename.ShowDialog()
            frmsalename.Close()
            'salename.combosalename(cbsalename)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnshowtax_Click(sender As Object, e As EventArgs) Handles btnshowtax.Click
        frmtax.ShowDialog()
        frmtax.Close()
        vath.combotax(cbtax)
    End Sub

    Private Sub dgvsale_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellClick
        Try

            If dgvlist.CurrentRow.Cells(3).Selected = True Or dgvlist.CurrentRow.Cells(4).Selected = True Or dgvlist.CurrentRow.Cells(5).Selected = True Then
                dgvlist.ReadOnly = False
                dgvlist.BeginEdit(True)
            Else
                dgvlist.ReadOnly = True
                dgvlist.EndEdit(True)
            End If
            If dgvlist.CurrentRow.Cells(8).Selected = True Then
                Dim checksaleno As String = sale.Check_existsaleNO(txtorderNO.Text)
                If checksaleno = "false" Then

                Else
                    frmsalesubitem.ShowDialog()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvsale_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellEnter
        If dgvlist.CurrentRow.Cells(1).Selected = True Then
            pCase = 1
            Dim Loc As Rectangle = dgvlist.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
            Dim Wid As Integer = dgvlist.CurrentCell.Size.Width
            btnSelector.Location = New Point(Loc.X - 28 + Wid, Loc.Y)
            btnSelector.Show()

        ElseIf dgvlist.CurrentRow.Cells(2).Selected = True Then
            pCase = 2
            Dim Loc As Rectangle = dgvlist.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
            Dim Wid As Integer = dgvlist.CurrentCell.Size.Width
            btnSelector.Location = New Point(Loc.X - 28 + Wid, Loc.Y)
            btnSelector.Show()
        Else

            btnSelector.Hide()
        End If
    End Sub
    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvsale_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvlist.EditingControlShowing
        Try
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvsale_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvlist.CellMouseUp
        Try
            dgvlist.Columns(3).DefaultCellStyle.Format = "N0"
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Me.dgvlist.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex
                Me.dgvlist.CurrentCell = Me.dgvlist.Rows(e.RowIndex).Cells(1)
                'Me.ContextMenuStrip1.Show(Me.dgvlist, e.Location)
                'ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs)
        If Not Me.dgvlist.Rows(Me.rowIndex).IsNewRow Then
            Me.dgvlist.Rows.RemoveAt(Me.rowIndex)
        End If
    End Sub
    Private Sub pricediscount()
        Try
            'If txtdiscount.Text = "" Then
            '    txtdiscount.Text = 0
            'End If
            Dim tem As Double = txtdiscount.Text
            txtdiscount.Text = tem.ToString("N0")
            txtdiscount.SelectionStart = txtdiscount.TextLength
            Dim tem_totalsale As Double = Val(CInt(txttotal.Text))
            Dim discount As Double = Val(CInt(txtdiscount.Text))
            Dim c As Double = tem_totalsale - discount
            txt_dispersent.Text = c.ToString("N0")
            txttotallast.Text = c.ToString("N0")
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub pricetax()
        Try
            Dim tax As Double
            Dim rows As DataRowView = cbtax.SelectedItem
            Dim row As DataRow = rows.Row
            Dim tem_totalsale = Val(CInt(txt_dispersent.Text))
            tax = row(1).ToString
            txttax.Text = ((tax * tem_totalsale) / 100).ToString
            Dim addtax As Double = tem_totalsale + ((tax * tem_totalsale) / 100)
            'txttotal.Text = addtax.ToString("N0")
            txttotallast.Text = addtax.ToString("N0")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtdiscount_TextChanged(sender As Object, e As EventArgs) Handles txtdiscount.TextChanged
        pricediscount()
        pricetax()
    End Sub
    Private Sub cbtax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtax.SelectedIndexChanged
        pricediscount()
        pricetax()
    End Sub

    Private Sub txtdiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdiscount.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtdeposite_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txttotalsale_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        Try
            txttotallast.Text = txttotal.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

  

    Private Sub btnnew_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            dgvlist.Rows.Add()
            CreateButton(btnSelector)
            dgvlist.Controls.Add(btnSelector)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnew_Click_1(sender As Object, e As EventArgs) Handles btnnew.Click
        Try

            Dim mm As String = setmoney.Call_mainmoney
            If mm = "ກີບ" Then
                rdkip.Checked = True
            ElseIf mm = "ບາດ" Then
                rdbath.Checked = True
            Else
                rddolla.Checked = True
            End If
            enableform()
            dgvlist.Columns.Clear()
            dgvlist.Rows.Clear()
            txtdiscount.Text = 0
            txt_dispersent.Text = 0


            rdcash.Checked = True
            txtorderNO.Text = order.run_runNO

            txtorderNote.Select()
            Makecolumns()
            For i As Integer = 0 To 10
                dgvlist.Rows.Add()
            Next
            dgvlist.ReadOnly = False
            CreateButton(btnSelector)
            dgvlist.Controls.Add(btnSelector)
            dgvlist.ReadOnly = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        'Try
        If dgvlist.SelectedCells.Count > 0 Then
            dgvlist.Rows.RemoveAt(dgvlist.CurrentRow.Index)
            dgvlist.EndEdit(True)
            sum_datachange()

        Else

        End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Try
            dgvlist.Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnfree_Click(sender As Object, e As EventArgs)
        Try
            If dgvlist.CurrentRow.Cells(6).Selected = True And dgvlist.CurrentRow.Cells(6).Value = False Then
                dgvlist.CurrentRow.Cells(6).Value = True
                dgvlist.CurrentRow.Cells(7).Value = 0
                sum_datachange()
            Else
                dgvlist.CurrentRow.Cells(6).Value = False
                sum_datachange()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub sum_datachange()
        Dim totalsale As Double
        For i As Integer = 0 To dgvlist.Rows.Count - 1
            'If dgvlist.Rows(i).Cells(6).Value = True Then
            '    dgvlist.Rows(i).Cells(7).Value = 0
            'Else
            Dim a As Integer = dgvlist.Rows(i).Cells(4).Value
            'Dim discount As Double = dgvlist.Rows(i).Cells(5).Value
            Dim qtycut As Integer = dgvlist.Rows(i).Cells(7).Value
            Dim price As Double = dgvlist.Rows(i).Cells(3).Value
            Dim discount As Double = dgvlist.Rows(i).Cells(5).Value
            Dim total As Double = (a * price) - discount
            dgvlist.Rows(i).Cells(6).Value = total
            dgvlist.Rows(i).Cells(8).Value = a * qtycut
            With dgvlist
                .Columns(3).DefaultCellStyle.Format = "N0"
                .Columns(5).DefaultCellStyle.Format = "N0"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                totalsale += dgvlist.Rows(i).Cells(6).Value
            End With

            'End If
        Next
        tem_totalsale = totalsale
        txttotal.Text = totalsale.ToString("N0")
        txt_dispersent.Text = totalsale.ToString("N0")
    End Sub
    Private Sub dgvsale_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellEndEdit
        Try
            sum_datachange()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        'Try
        If txtorderNO.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນໃຫ້ຄົບສາກ່ອນ")
            Exit Sub
        End If
        If txtorderNO.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນໃຫ້ຄົບສາກ່ອນ")
            Exit Sub
        End If
        If txtsupname.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນຜູ້ສະໜອງກ່ອນ")
            txtsupname.Focus()
            Exit Sub
        End If
        If dgvlist.Rows.Count < 1 Then
            MessageBox.Show("ກະລຸນາເພີ້ມລາຍການຂາຍ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cash As String
        If rdkip.Checked = True Then
            cash = "ກີບ"
        ElseIf rdbath.Checked = True Then
            cash = "ບາດ"
        Else
            cash = "ໂດລາ"
        End If

        Dim payname As String
        If rdcash.Checked = True Then
            payname = "ສົດ"
        Else
            payname = "ຕິດໜີ້"
        End If
        Dim amount_tax As Double
        Dim rows As DataRowView = cbtax.SelectedItem
        Dim row As DataRow = rows.Row
        amount_tax = row(1).ToString

        If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Dim orderautoid As Integer = order.runid
            Dim orderNO As String = order.run_runNO
            If rdcash.Checked = True Then
                order.saveorder(orderNO, orderautoid, payname, frmmain.userid, sup_id, txtdiscount.Text, amount_tax, txttotallast.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"), txtorderNote.Text, 5, "NO", cash, txttotallast.Text)
                orderpay.savepayorder(orderNO, txttotallast.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"), txttotallast.Text, Format(CDate(dtsale.Value), "MM/dd/yyyy"), 5, 1)
            Else
                order.saveorder(orderNO, orderautoid, payname, frmmain.userid, sup_id, txtdiscount.Text, amount_tax, txttotallast.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"), txtorderNote.Text, 5, "NO", cash, txttotallast.Text)
                orderpay.savepayorder(orderNO, 0, Format(CDate(dtsale.Text), "MM/dd/yyyy"), txttotallast.Text, Format(CDate(dtsale.Value), "MM/dd/yyyy"), 5, 1)
            End If

            For i As Integer = 0 To dgvlist.Rows.Count - 1
                If dgvlist.Rows(i).Cells(0).Value Is Nothing Then
                    'ບໍ່ເຮັດວຽກ'
                Else
                    Dim orderdetailid As Integer = order.runiddetail
                    Dim proid As String = dgvlist.Rows(i).Cells(0).Value
                    Dim unitname As String = dgvlist.Rows(i).Cells(2).Value
                    Dim order_price As Double = dgvlist.Rows(i).Cells(3).Value
                    Dim order_qty As Integer = dgvlist.Rows(i).Cells(4).Value
                    Dim discount As Double = dgvlist.Rows(i).Cells(5).Value
                    Dim order_total As Double = dgvlist.Rows(i).Cells(6).Value
                    Dim ordercut As Integer = dgvlist.Rows(i).Cells(7).Value
                    Dim totalorderqty As Double = dgvlist.Rows(i).Cells(8).Value
                    order.savedetail(orderdetailid, orderNO, proid, unitname, order_price, order_qty, discount, order_total, ordercut, totalorderqty)
                End If
            Next
            disableform()
        End If

        Dim counts As Integer = 0
        For i As Integer = 0 To dgvlist.Rows.Count - 1
            If dgvlist.Rows(i).Cells(0).Value Is Nothing Then
            Else
                counts += 1
            End If
        Next
        txtcount.Text = counts

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub frmsale_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            frmorder.dgvshow.Columns.Clear()
            frmorder.dgvshow.Rows.Clear()
            frmorder.Ordercolumns()
            frmorder.dtorder.Clear()
            order.loadorder_dt(Format(CDate(frmorder.dt1.Text), "MM/dd/yyyy"), Format(CDate(frmorder.dt2.Text), "MM/dd/yyyy"), frmorder.dtorder, "%", "%")
            'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)
            For i As Integer = 0 To frmorder.dtorder.Rows.Count - 1
                Dim orderno1 As String = frmorder.dtorder.Rows(i).Item(0)
                Dim pay As String = frmorder.dtorder.Rows(i).Item(2)
                Dim ordername As String = frmorder.dtorder.Rows(i).Item(12)
                Dim buyfrom As String = frmorder.dtorder.Rows(i).Item(3)
                Dim discount1 As Double = frmorder.dtorder.Rows(i).Item(4)
                Dim total As Double = frmorder.dtorder.Rows(i).Item(5)
                Dim totalpay As Double = frmorder.dtorder.Rows(i).Item(6)
                Dim notpay As Double = frmorder.dtorder.Rows(i).Item(7)
                Dim saledate1 As String = frmorder.dtorder.Rows(i).Item(8)
                Dim tax As Integer = frmorder.dtorder.Rows(i).Item(28)
                Dim status As Integer = frmorder.dtorder.Rows(i).Item(27)
                Dim receive As String = frmorder.dtorder.Rows(i).Item(11)
                Dim note1 As String = frmorder.dtorder.Rows(i).Item(9)
                Dim mainmoney As String = frmorder.dtorder.Rows(i).Item(25)
                Dim sup_id As String = frmorder.dtorder.Rows(i).Item(24)
                Dim supname As String = frmorder.dtorder.Rows(i).Item(3)
                If status = 5 Then
                    status = False
                Else
                    status = True
                End If
                If receive = "NO" Then
                    receive = False
                Else
                    receive = True
                End If
                frmorder.dgvshow.Rows.Add(orderno1, pay, ordername, buyfrom, tax, discount1, total, totalpay, notpay, saledate1, status, receive, note1, mainmoney, sup_id, supname)
            Next
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        enableform()
        btnsave.Enabled = False
        btnupdate.Enabled = True
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try
            If dgvlist.Rows.Count > 0 Then
                frmbillorder.ShowDialog()
                frmbillorder.Close()
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtorderNO.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນໃຫ້ຄົບສາກ່ອນ")
            Exit Sub
        End If
        If txtorderNO.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນໃຫ້ຄົບສາກ່ອນ")
            Exit Sub
        End If
        If txtsupname.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນຜູ້ສະໜອງກ່ອນ")
            txtsupname.Focus()
            Exit Sub
        End If
        If dgvlist.Rows.Count < 1 Then
            MessageBox.Show("ກະລຸນາເພີ້ມລາຍການຂາຍ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cash As String
        If rdkip.Checked = True Then
            cash = "ກີບ"
        ElseIf rdbath.Checked = True Then
            cash = "ບາດ"
        Else
            cash = "ໂດລາ"
        End If
        Dim amount_tax As Double
        Dim rows As DataRowView = cbtax.SelectedItem
        Dim row As DataRow = rows.Row
        amount_tax = row(1).ToString
        If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງລາຍການແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim payname As String
            orderpay.delete_orderpay(txtorderNO.Text)

            If rdcash.Checked = True Then
                payname = "ສົດ"
                order.updateorder(txtorderNO.Text, payname, frmmain.userid, sup_id, txtdiscount.Text, amount_tax, txttotallast.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"), txtorderNote.Text, 5, cash, txttotallast.Text)
                orderpay.savepayorder(txtorderNO.Text, txttotallast.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"), 0, Format(CDate(dtsale.Value), "MM/dd/yyyy"), 5, 1)
            Else
                payname = "ຕິດໜີ້"
                order.updateorder(txtorderNO.Text, payname, frmmain.userid, sup_id, txtdiscount.Text, amount_tax, txttotallast.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"), txtorderNote.Text, 5, cash, txttotallast.Text)
                orderpay.savepayorder(txtorderNO.Text, 0, Format(CDate(dtsale.Text), "MM/dd/yyyy"), txttotallast.Text, Format(CDate(dtsale.Value), "MM/dd/yyyy"), 5, 1)
            End If

            Dim ddt As New DataTable
            ddt.Clear()
            order.loadorderdetail(txtorderNO.Text, ddt)
            If ddt.Rows.Count > 0 Then
                For i As Integer = 0 To ddt.Rows.Count - 1
                    Dim orderdetailid As Integer = ddt.Rows(i).Item(0)
                    order.deleteorderdetail(orderdetailid)
                Next
            End If

            For i As Integer = 0 To dgvlist.Rows.Count - 1
                If dgvlist.Rows(i).Cells(0).Value Is Nothing Then
                    'ບໍ່ເຮັດວຽກ'
                Else
                    Dim orderdetailid As Integer = order.runiddetail
                    Dim proid As String = dgvlist.Rows(i).Cells(0).Value
                    Dim unitname As String = dgvlist.Rows(i).Cells(2).Value
                    Dim order_price As Double = dgvlist.Rows(i).Cells(3).Value
                    Dim order_qty As Integer = dgvlist.Rows(i).Cells(4).Value
                    Dim discount As Double = dgvlist.Rows(i).Cells(5).Value
                    Dim order_total As Double = dgvlist.Rows(i).Cells(6).Value
                    Dim ordercut As Integer = dgvlist.Rows(i).Cells(7).Value
                    Dim totalorderqty As Double = dgvlist.Rows(i).Cells(8).Value
                    order.savedetail(orderdetailid, txtorderNO.Text, proid, unitname, order_price, order_qty, discount, order_total, ordercut, totalorderqty)
                End If
            Next
        End If

        'order.loadorder(Format(CDate(frmorder.dt1.Text), "MM/dd/yyyy"), Format(CDate(frmorder.dt2.Text), "MM/dd/yyyy"), frmorder.dgvshow)
        disableform()
        Dim counts As Integer = 0
        For i As Integer = 0 To dgvlist.Rows.Count - 1
            If dgvlist.Rows(i).Cells(0).Value Is Nothing Then
            Else
                counts += 1
            End If
        Next
        txtcount.Text = counts
    End Sub

    Private Sub dgvlist_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellValueChanged
        Try
            sum_datachange()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim product As New tbproduct
        Dim receive As New tbreceive
        Dim ddts As New DataTable
        ddts.Clear()
        receive.loadviewreceive(txtorderNO.Text, ddts)
        If dgvlist.Rows.Count > 0 Then
            If MessageBox.Show("ທ່ານຕ້ອງການຍົກເລີກລາຍການສັ່ງຊື້ແທ້ບໍ່", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                If frmorder.dgvshow.CurrentRow.Cells(11).Value = True Then
                    If dt.Rows.Count > 0 Then
                        order.Cancle_order(txtorderNO.Text)
                        For i As Integer = 0 To dt.Rows.Count - 1
                            Dim proid2 As String = dt.Rows(i).Item(8)
                            Dim callstockqty As Integer = product.Callstock_qty(proid2)
                            Dim qty As Integer = dt.Rows(i).Item(10)
                            Dim newqty As Integer = callstockqty - qty
                            product.updateStock(proid2, newqty)
                        Next
                    Else
                        MessageBox.Show("call orderdetail cannot find data to present")
                    End If
                    If ddts.Rows.Count > 0 Then
                        Dim receiveNO As String = ddts.Rows(0).Item(0)
                        receive.Cancelreceive(receiveNO)
                    Else
                        MessageBox.Show("Call ReceiveNO cannot find data to present")
                    End If
                    btnedit.Enabled = False

                Else
                    order.Cancle_order(txtorderNO.Text)
                    btnedit.Enabled = False
                End If

                btncancel.Enabled = False

            End If
        End If
    End Sub

    Private Sub btncustomer_Click(sender As Object, e As EventArgs) Handles btncustomer.Click
        formcreateorder = True
        frmcustomer.ShowDialog()
        frmcustomer.Close()
        Dim customerdt As New DataTable
        customerdt.Clear()
        cus.Selectcustomer(customerdt)
        If customerdt.Rows.Count > 0 Then
            sup_id = customerdt.Rows(0).Item(0)
            txtsupname.Text = customerdt.Rows(0).Item(1)
        Else

        End If
        formcreateorder = False
    End Sub

    Private Sub txt_dispersent_TextChanged(sender As Object, e As EventArgs) Handles txt_dispersent.TextChanged
        If txt_dispersent.Text = "" Then
            txt_dispersent.Text = 0
        End If
    End Sub

    Private Sub dgvlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellContentClick

    End Sub

    Private Sub txttotallast_TextChanged(sender As Object, e As EventArgs) Handles txttotallast.TextChanged

    End Sub

    Private Sub dgvlist_CellStyleChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellStyleChanged
        Try
            sum_datachange()
            pricediscount()
            pricetax()
        Catch ex As Exception

        End Try
    End Sub
End Class