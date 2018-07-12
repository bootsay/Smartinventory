Public Class frmstockout
    Dim stockouttype As New tbstockouttype
    Dim stockout As New tbstockout
    Dim setmoney As New tbsetmoney
    Dim vath As New tbtax
    Dim sale As New tbsales
    Dim exch As New tbexchange
    Dim pays As New tbpay
    Dim C_cancel As New tbcancel
    Dim approve As New tbapprove
    Public formstockout As Boolean = False
    Private pCase As Integer
    Private rowIndex As Integer = 0
    Private btnSelector As New Button()
    Dim tem_totalsale As Double
    Public empid As String
    Dim frmmain As frmmain = CType(Application.OpenForms("frmmain"), frmmain)
    Public mainmoney As String
    Public payname As String
    Public dt As New DataTable
    Dim cbt As Int16
    Dim dtorderdetail As New DataTable
    Dim currendate As String
    Private Sub frmsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        currendate = System.DateTime.Now.ToString("MM/dd/yyyy")
        If frmmain.UserAuthentication = "" Then
            btnapprove.Enabled = False
            btncancel.Enabled = False
        Else
            Dim btnapprove1 As String = "F"
            Dim btncancel1 As String = "F"
            btnapprove1 = frmmain.UserAuthentication.Substring(32, 1)
            btncancel1 = frmmain.UserAuthentication.Substring(33, 1)

            If btnapprove1 = "T" Then
                btnapprove.Enabled = True
            Else
                btnapprove.Visible = False
            End If
            If btncancel1 = "T" Then
                btncancel.Enabled = True
            Else
                btncancel.Visible = False
            End If
        End If

        If frmstockoutlist.formstockout = True Then
            dt.Clear()
            dgvlist.Columns.Clear()
            dgvlist.Rows.Clear()
            Makecolumns()
            stockout.viewstockoutdetail(frmstockoutlist.dgvsalelist.CurrentRow.Cells(0).Value, dt)
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim proid As String = dt.Rows(i).Item(11)
                Dim proname As String = dt.Rows(i).Item(2)
                Dim unitname As String = dt.Rows(i).Item(3)
                Dim price As Double = dt.Rows(i).Item(4)
                Dim qty As Integer = dt.Rows(i).Item(5)
                Dim tatol As Double = dt.Rows(i).Item(6)
                Dim ordercut As Integer = dt.Rows(i).Item(7)
                Dim totalorderqty As Integer = dt.Rows(i).Item(8)
                dgvlist.Rows.Add(proid, proname, unitname, price, qty, tatol, ordercut, totalorderqty)
                'dgvreceive.Rows.Add(proid, proname, unitname, price, qty, tatol, ordercut, totalorderqty, "", Day)
            Next
            txtstockoutNO.Text = frmstockoutlist.dgvsalelist.CurrentRow.Cells(0).Value
            txtorderNote.Text = frmstockoutlist.dgvsalelist.CurrentRow.Cells(8).Value
            empid = frmstockoutlist.dgvsalelist.CurrentRow.Cells(9).Value
            txtsupname.Text = frmstockoutlist.dgvsalelist.CurrentRow.Cells(3).Value
            Dim sum1 As Double
            For i As Integer = 0 To dgvlist.Rows.Count - 1
                sum1 += dgvlist.Rows(i).Cells(5).Value
            Next
            txttotallast.Text = sum1.ToString("N0")
            disableform()
            enableedit()
            If frmstockoutlist.dgvsalelist.CurrentRow.Cells(6).Value = False And frmstockoutlist.dgvsalelist.CurrentRow.Cells(7).Value = False Then
                btncancel.Enabled = True
                btnapprove.Enabled = True
            ElseIf frmstockoutlist.dgvsalelist.CurrentRow.Cells(6).Value = False And frmstockoutlist.dgvsalelist.CurrentRow.Cells(7).Value = True Then
                btncancel.Enabled = True
                btnapprove.Enabled = False

                btnedit.Enabled = False
            ElseIf frmstockoutlist.dgvsalelist.CurrentRow.Cells(6).Value = True And frmstockoutlist.dgvsalelist.CurrentRow.Cells(7).Value = False Then
                btncancel.Enabled = False
                btnapprove.Enabled = False

                btnedit.Enabled = False
            ElseIf frmstockoutlist.dgvsalelist.CurrentRow.Cells(6).Value = True And frmstockoutlist.dgvsalelist.CurrentRow.Cells(7).Value = True Then
                btncancel.Enabled = False
                btnapprove.Enabled = False

                btnedit.Enabled = False
            End If
           
        Else
            txtordername.Text = frmmain.laoname
            enablesave()

         


        End If
        stockouttype.combostockouttype(cbstockouttype)
        cbstockouttype.SelectedValue = 1

   
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
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
        txtstockoutNO.Clear()
        txtorderNote.Clear()
        txtsupname.Clear()
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
        dgvlist.Columns.Add(total)
        dgvlist.Columns.Add(numbercut)
        dgvlist.Columns.Add(sumnumbercut)
        With dgvlist
            .Columns(0).HeaderText = "ລະຫັດສິນຄ້າ"
            .Columns(1).HeaderText = "ຊື່ສິນຄ້າ"
            .Columns(2).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(3).HeaderText = "ລາຄາ/ໜ່ວຍ"
            .Columns(4).HeaderText = "ຈໍານວນ"
            .Columns(5).HeaderText = "ລວມ"
            .Columns(6).HeaderText = "ຈໍານວນຕັດ"
            .Columns(7).HeaderText = "ລວມຈໍານວນຕັດ"

            .Columns(0).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(5).ReadOnly = True

            .Columns(0).Width = 120
            .Columns(1).Width = 250
            .Columns(2).Width = 100
            .Columns(3).Width = 150
            .Columns(4).Width = 100
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(6).Visible = False
            .Columns(7).Visible = False
        End With
        dgvlist.Columns(3).DefaultCellStyle.Format = "N0"
        dgvlist.Columns(5).DefaultCellStyle.Format = "N0"
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
                    formstockout = True
                    frmshowproduct.ShowDialog()
                    With dgvlist
                        .Columns(0).ReadOnly = True
                        .Columns(1).ReadOnly = True
                        .Columns(2).ReadOnly = True
                        .Columns(3).DefaultCellStyle.Format = "N0"
                        .Columns(5).DefaultCellStyle.Format = "N0"
                        .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    End With
                    formstockout = False
                    pCase = 0
                    sum_datachange()
                End If
                Exit Select
            Case 2
                If True Then
                    formstockout = True
                    frmshowunit.ShowDialog()
                    formstockout = False
                    Exit Select
                End If
        End Select
    End Sub
    Private Sub saletable()
        Dim id As New DataGridViewTextBoxColumn
        Dim name As New DataGridViewTextBoxColumn
        Dim unitname As New DataGridViewTextBoxColumn
        Dim price As New DataGridViewTextBoxColumn
        Dim saleqty As New DataGridViewTextBoxColumn
        Dim discount As New DataGridViewTextBoxColumn
        Dim free As New DataGridViewCheckBoxColumn
        Dim total As New DataGridViewTextBoxColumn
        Dim options As New DataGridViewButtonColumn
        Dim unitid As New DataGridViewTextBoxColumn
        Dim qtycut As New DataGridViewTextBoxColumn
        Dim totalqtycut As New DataGridViewTextBoxColumn
        Dim pricebuy As New DataGridViewTextBoxColumn
        dgvlist.Columns.Add(id)
        dgvlist.Columns.Add(name)
        dgvlist.Columns.Add(unitname)
        dgvlist.Columns.Add(price)
        dgvlist.Columns.Add(saleqty)
        dgvlist.Columns.Add(discount)
        dgvlist.Columns.Add(free)
        dgvlist.Columns.Add(total)
        dgvlist.Columns.Add(options)
        'dgvsale.Columns.Add(unitid)
        dgvlist.Columns.Add(qtycut)
        dgvlist.Columns.Add(totalqtycut)
        dgvlist.Columns.Add(pricebuy)
        With dgvlist
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ລາຍການ"
            .Columns(2).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(3).HeaderText = "ລາຄາ"
            .Columns(4).HeaderText = "ຈໍານວນ"
            .Columns(5).HeaderText = "ລຸດ"
            .Columns(6).HeaderText = "ແຖມ"
            .Columns(7).HeaderText = "ລວມ"
            .Columns(8).HeaderText = "ເພີ້ມເຕີມ"
            '.Columns(9).HeaderText = "ໄອດີ"
            .Columns(9).HeaderText = "qtycut"
            .Columns(10).HeaderText = "totalqtycut"
            .Columns(11).HeaderText = "pricebuy"

            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns(8).Visible = False
            .Columns(6).Width = 40
            .Columns(7).Width = 70
        End With
    End Sub

    Private Sub btnbrown_Click(sender As Object, e As EventArgs) Handles btnbrown.Click
        formstockout = True
        frmshowemployee.ShowDialog()
        frmshowemployee.Close()
        formstockout = False
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
                Dim checksaleno As String = sale.Check_existsaleNO(txtstockoutNO.Text)
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
            btnSelector.Location = New Point(Loc.X - 30 + Wid, Loc.Y)
            btnSelector.Show()

        ElseIf dgvlist.CurrentRow.Cells(2).Selected = True Then
            pCase = 2
            Dim Loc As Rectangle = dgvlist.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
            Dim Wid As Integer = dgvlist.CurrentCell.Size.Width
            btnSelector.Location = New Point(Loc.X - 30 + Wid, Loc.Y)
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
                Me.ContextMenuStrip1.Show(Me.dgvlist, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtdiscount_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtdeposite_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
          
            dgvlist.Rows.Add()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnew_Click_1(sender As Object, e As EventArgs) Handles btnnew.Click
        Try
            enableform()
            dgvlist.Columns.Clear()
            dgvlist.Rows.Clear()
            txtstockoutNO.Text = stockout.run_runNO
            txtorderNote.Select()
            Makecolumns()
            For i As Integer = 0 To 10
                dgvlist.Rows.Add()
            Next
            dgvlist.ReadOnly = False
            CreateButton(btnSelector)
            dgvlist.Controls.Add(btnSelector)
            dgvlist.ReadOnly = True
            txttotallast.Clear()
            txttotallast.Text = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        Try
            dgvlist.Rows.RemoveAt(dgvlist.CurrentRow.Index)
        Catch ex As Exception

        End Try
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
            Dim qty As Integer = dgvlist.Rows(i).Cells(4).Value
            Dim price As Double = dgvlist.Rows(i).Cells(3).Value
            Dim qtycut As Integer = dgvlist.Rows(i).Cells(6).Value
            Dim total As Double = (qty * price)
            dgvlist.Rows(i).Cells(5).Value = total
            dgvlist.Rows(i).Cells(7).Value = qty * qtycut
            With dgvlist
                .Columns(3).DefaultCellStyle.Format = "N0"
                .Columns(4).DefaultCellStyle.Format = "N0"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                totalsale += dgvlist.Rows(i).Cells(5).Value
            End With

        Next
        tem_totalsale = totalsale
        txttotallast.Text = totalsale.ToString("N0")
    End Sub
    Private Sub dgvsale_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellEndEdit
        Try
            sum_datachange()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        'Try
        If txtstockoutNO.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນໃຫ້ຄົບສາກ່ອນ")
            Exit Sub
        End If
        If txtstockoutNO.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນໃຫ້ຄົບສາກ່ອນ")
            Exit Sub
        End If
        If txtsupname.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນຜູ້ຍືມສີນຄ້າ")
            txtsupname.Focus()
            Exit Sub
        End If
        If dgvlist.Rows.Count < 1 Then
            MessageBox.Show("ກະລຸນາເພີ້ມລາຍການຂາຍ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Dim stockoutid As Integer = stockout.stockid
            Dim stockoutNO As String = stockout.run_runNO
            stockout.savestockout(stockoutNO, stockoutid, cbstockouttype.SelectedValue, frmmain.userid, empid, txttotallast.Text, 5, "NO", txtorderNote.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"))
            For i As Integer = 0 To dgvlist.Rows.Count - 1
                If dgvlist.Rows(i).Cells(0).Value Is Nothing Then
                    'ບໍ່ເຮັດວຽກ'
                Else
                    Dim stockdetailid As Integer = stockout.stockoutdetailid
                    Dim proid As String = dgvlist.Rows(i).Cells(0).Value
                    Dim unitname As String = dgvlist.Rows(i).Cells(2).Value
                    Dim order_price As Double = dgvlist.Rows(i).Cells(3).Value
                    Dim order_qty As Integer = dgvlist.Rows(i).Cells(4).Value
                    Dim order_total As Double = dgvlist.Rows(i).Cells(5).Value
                    Dim ordercut As Integer = dgvlist.Rows(i).Cells(6).Value
                    Dim totalorderqty As Double = dgvlist.Rows(i).Cells(7).Value
                    stockout.savestockoutdetail(stockdetailid, stockoutNO, proid, unitname, order_price, order_qty, order_total, ordercut, totalorderqty)
                End If
            Next
            disableform()
        End If


        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        enableform()
        btnsave.Enabled = False
        btnupdate.Enabled = True
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try
            If dgvlist.Rows.Count > 0 Then
                Dim checkNO As String = stockout.Check_existstockoutNO(txtstockoutNO.Text)
                If checkNO = "false" Then
                    Return
                End If
                frmbillstockinout.ShowDialog()
                frmbillstockinout.Close()
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtstockoutNO.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນໃຫ້ຄົບສາກ່ອນ")
            Exit Sub
        End If
        If txtstockoutNO.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນໃຫ້ຄົບສາກ່ອນ")
            Exit Sub
        End If
        If txtsupname.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນຜູ້ສະໜອງກ່ອນ")
            txtsupname.Focus()
            Exit Sub
        End If
        If dgvlist.Rows.Count < 1 Then
            MessageBox.Show("ກະລຸນາເພີ້ມລາຍການ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງລາຍການແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            stockout.updatestockout(txtstockoutNO.Text, frmmain.userid, empid, txttotallast.Text, 5, txtorderNote.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"))
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim orderdetailid As Integer = dt.Rows(i).Item(0)
                stockout.deletestockoutdetail(orderdetailid)
            Next
            For i As Integer = 0 To dgvlist.Rows.Count - 1
                If dgvlist.Rows(i).Cells(0).Value Is Nothing Then
                    'ບໍ່ເຮັດວຽກ'
                Else
                    Dim stockdetailid As Integer = stockout.stockoutdetailid
                    Dim proid As String = dgvlist.Rows(i).Cells(0).Value
                    Dim unitname As String = dgvlist.Rows(i).Cells(2).Value
                    Dim order_price As Double = dgvlist.Rows(i).Cells(3).Value
                    Dim order_qty As Integer = dgvlist.Rows(i).Cells(4).Value
                    Dim order_total As Double = dgvlist.Rows(i).Cells(5).Value
                    Dim ordercut As Integer = dgvlist.Rows(i).Cells(6).Value
                    Dim totalorderqty As Double = dgvlist.Rows(i).Cells(7).Value
                    stockout.savestockoutdetail(stockdetailid, txtstockoutNO.Text, proid, unitname, order_price, order_qty, order_total, ordercut, totalorderqty)
                End If
            Next

        End If
        'order.loadorder(Format(CDate(frmorder.dt1.Text), "MM/dd/yyyy"), Format(CDate(frmorder.dt2.Text), "MM/dd/yyyy"), frmorder.dgvshow)
        disableform()

    End Sub

    Private Sub dgvlist_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellValueChanged
        Try
            With dgvlist
                Dim qty As Integer = .CurrentRow.Cells(4).Value
                Dim price As Double = .CurrentRow.Cells(3).Value

                Dim total As Double = qty * price
                .CurrentRow.Cells(5).Value = total.ToString("N0")
                Dim qtycut As Integer = .CurrentRow.Cells(6).Value
                .CurrentRow.Cells(7).Value = qtycut * qty

            End With
            Dim sum As Double
            For i As Integer = 0 To dgvlist.Rows.Count - 1
                sum += dgvlist.Rows(i).Cells(5).Value
            Next
            tem_totalsale = sum

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim checkNO As String = stockout.Check_existstockoutNO(txtstockoutNO.Text)
        If checkNO = "false" Then
            Return
        End If
        Dim product As New tbproduct
        Dim receive As New tbreceive
        If dgvlist.Rows.Count > 0 Then
            If MessageBox.Show("ທ່ານຕ້ອງການຍົກເລີກລາຍການເບີກສີນຄ້າແທ້ບໍ່?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                stockout.Update_stockoutcancel(txtstockoutNO.Text)
                Dim idstock As Integer = C_cancel.runid_cancelstockout
                C_cancel.savestockoutcancel(idstock, txtstockoutNO.Text, currendate)
                For i As Integer = 0 To dgvlist.Rows.Count - 1
                    If dgvlist.Rows(i).Cells(0).Value Is Nothing Then

                    Else
                        Dim proid2 As String = dgvlist.Rows(i).Cells(0).Value
                        Dim totalqtycut As Integer = dgvlist.Rows(i).Cells(7).Value
                        Dim stockqty As Integer = product.Callstock_qty(proid2)
                        Dim balancecut As Integer = receive.Check_balancecut(proid2)
                        Dim stockdetailid As Integer
                        Dim updatebalance_cut_qty As Integer
                        Dim balancecutqty As Integer
                        If balancecut > 0 Then
                            balancecutqty = receive.Call_balancecutqty(proid2)
                            stockdetailid = receive.Call_ID_balancecut(proid2)
                            updatebalance_cut_qty = balancecutqty + totalqtycut
                        Else
                            balancecutqty = receive.Call_balancecutqty(proid2)
                            stockdetailid = receive.Call_ID_balancecut_equal_zero(proid2)
                            updatebalance_cut_qty = balancecutqty + totalqtycut
                        End If

                        Dim updatestockqty As Integer = stockqty + totalqtycut
                        product.updateStock(proid2, updatestockqty)
                        receive.Update_cancel_balancecut(stockdetailid, updatebalance_cut_qty)
                    End If
                Next
            End If
            btncancel.Enabled = False
        End If

    End Sub

    Private Sub btnapprove_Click(sender As Object, e As EventArgs) Handles btnapprove.Click
        Dim receive As New tbreceive
        Dim product As New tbproduct
        Dim checksaleNO As String = stockout.Check_existstockoutNO(txtstockoutNO.Text)
        If checksaleNO = "false" Then
        Else

            'For k As Integer = 0 To dgvlist.Rows.Count - 1
            '    Dim productid As String = dgvlist.Rows(k).Cells(0).Value
            '    Dim callstockqty As Integer = product.Callstock_qty(productid)
            '    If callstockqty < dgvlist.Rows(k).Cells(7).Value Then
            '        MessageBox.Show("ຂໍໂທດລາຍການສີນຄ້າໃນບີນນີ້ມີຈໍານວນຫລາຍກວ່າສີນຄ້າໃນສາງ, ທ່ານບໍ່ສາມາດອະນຸມັດການຂາຍໄດ້, ກະລຸນາກວດສອບຈໍານວນສີນຄ້າຄືນ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '        Exit Sub
            '    End If
            'Next

            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກການຮັບສິນຄ້າທີ່ພະນັກງານຢືມໄປຄືນແທ້ບໍ່ ?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                stockout.Update_approve(txtstockoutNO.Text)
                Dim idrece As Integer = approve.runid_stockoutreceive
                approve.savereceivestockoutback(idrece, txtstockoutNO.Text, currendate)
                For i As Integer = 0 To dgvlist.Rows.Count - 1
                    If dgvlist.Rows(i).Cells(0).Value Is Nothing Then

                    Else
                        Dim proid1 As String = dgvlist.Rows(i).Cells(0).Value
                        Dim totalcut As Integer = dgvlist.Rows(i).Cells(7).Value
                        Dim stockqty As Integer = product.Callstock_qty(proid1)
                        Dim updatestock As Integer = stockqty - totalcut
                        'product.updateStock(proid1, updatestock)
                        'update balance cut'
                        Dim dtbalancecut As New DataTable
                        dtbalancecut.Clear()
                        'receive.call_balace_cut(proid1, dtbalancecut)
                        'If dtbalancecut.Rows.Count <= 1 Then
                        '    Dim detailid1 As Integer = dtbalancecut.Rows(0).Item(2)
                        '    Dim a1 As Integer = dtbalancecut.Rows(0).Item(1)
                        '    Dim c As Integer = a1
                        '    If a1 >= totalcut Then
                        '        Dim qcut1 As Integer = a1 - totalcut
                        '        receive.update_balance_cut(detailid1, qcut1)
                        '    End If
                        'ElseIf dtbalancecut.Rows.Count > 1 Then
                        '    Dim detailid1 As Integer = dtbalancecut.Rows(0).Item(2)
                        '    Dim detailid2 As Integer = dtbalancecut.Rows(1).Item(2)
                        '    Dim a1 As Integer = dtbalancecut.Rows(0).Item(1)
                        '    Dim a2 As Integer = dtbalancecut.Rows(1).Item(1)
                        '    Dim c As Integer = a1 + a2
                        '    If a1 >= totalcut Then
                        '        Dim qcut1 As Integer = a1 - totalcut
                        '        receive.update_balance_cut(detailid1, qcut1)
                        '    End If
                        '    If totalcut > a1 Then
                        '        Dim qcut2 As Integer = totalcut - a1
                        '        Dim qcut3 As Integer = a2 - qcut2
                        '        receive.update_balance_cut(detailid1, 0)
                        '        receive.update_balance_cut(detailid2, qcut3)
                        '    End If
                        'End If

                    End If


                Next
                btnapprove.Enabled = False
            End If

        End If
    End Sub

    Private Sub frmstockout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Try
        If frmstockoutlist.rdstatus.Checked = True Then
            frmstockoutlist.dt.Clear()
            frmstockoutlist.dgvsalelist.Columns.Clear()
            frmstockoutlist.dgvsalelist.Rows.Clear()
            stockout.viewstockout_search_statusname(frmstockoutlist.dt, frmstockoutlist.cbstatus.SelectedItem)
            frmstockoutlist.format_salelist()
            For i As Integer = 0 To frmstockoutlist.dt.Rows.Count - 1
                Dim id As String = frmstockoutlist.dt.Rows(i).Item(0)
                Dim type As String = frmstockoutlist.dt.Rows(i).Item(1)
                Dim stockname As String = frmstockoutlist.dt.Rows(i).Item(2)
                Dim employeename As String = frmstockoutlist.dt.Rows(i).Item(3)
                Dim totalsale As String = frmstockoutlist.dt.Rows(i).Item(4)
                Dim saledate As String = frmstockoutlist.dt.Rows(i).Item(5)
                Dim status As String = frmstockoutlist.dt.Rows(i).Item(6)
                Dim approve As String = frmstockoutlist.dt.Rows(i).Item(7)
                Dim note1 As String = frmstockoutlist.dt.Rows(i).Item(8)
                Dim empid As String = frmstockoutlist.dt.Rows(i).Item(9)
                Dim statusid As String = frmstockoutlist.dt.Rows(i).Item(10)
                If status = "ປົກກະຕິ" Then
                    status = False
                Else
                    status = True
                End If
                If approve = "YES" Then
                    approve = True
                Else
                    approve = False
                End If
                frmstockoutlist.dgvsalelist.Rows.Add(id, type, stockname, employeename, totalsale, saledate, status, approve, note1, empid, statusid)
            Next
        ElseIf frmstockoutlist.rddate.Checked = True Then
            frmstockoutlist.dt.Clear()
            frmstockoutlist.dgvsalelist.Columns.Clear()
            frmstockoutlist.dgvsalelist.Rows.Clear()
            stockout.viewstockout_search_stockoutdate(frmstockoutlist.dt, Format(CDate(frmstockoutlist.dt1.Text), "MM/dd/yyyy"), Format(CDate(frmstockoutlist.dt2.Text), "MM/dd/yyyy"))
            frmstockoutlist.format_salelist()

            For i As Integer = 0 To frmstockoutlist.dt.Rows.Count - 1
                Dim id As String = frmstockoutlist.dt.Rows(i).Item(0)
                Dim type As String = frmstockoutlist.dt.Rows(i).Item(1)
                Dim stockname As String = frmstockoutlist.dt.Rows(i).Item(2)
                Dim employeename As String = frmstockoutlist.dt.Rows(i).Item(3)
                Dim totalsale As String = frmstockoutlist.dt.Rows(i).Item(4)
                Dim saledate As String = frmstockoutlist.dt.Rows(i).Item(5)
                Dim status As String = frmstockoutlist.dt.Rows(i).Item(6)
                Dim approve As String = frmstockoutlist.dt.Rows(i).Item(7)
                Dim note1 As String = frmstockoutlist.dt.Rows(i).Item(8)
                Dim empid As String = frmstockoutlist.dt.Rows(i).Item(9)
                Dim statusid As String = frmstockoutlist.dt.Rows(i).Item(10)
                If status = "ປົກກະຕິ" Then
                    status = False
                Else
                    status = True
                End If
                If approve = "YES" Then
                    approve = True
                Else
                    approve = False
                End If
                frmstockoutlist.dgvsalelist.Rows.Add(id, type, stockname, employeename, totalsale, saledate, status, approve, note1, empid, statusid)
            Next
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

   
    Private Sub dgvlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellContentClick

    End Sub
End Class