Imports System.Data.SqlClient
Public Class frmreceiveproduct
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Dim order As New tborder
    Dim receive As New tbreceive
    Dim vath As New tbtax
    Dim exch As New tbexchange
    Dim pays As New tbpay
    Public formreceive As Boolean = False
    Private pCase As Integer
    Private btnSelector As New Button()
    Private rowIndex As Integer = 0
    Dim tem_totalsale As Double
    Public sup_id As String
    Dim frmmain As frmmain = CType(Application.OpenForms("frmmain"), frmmain)
    Public mainmoney As String
    Public payname As String
    Public dt As New DataTable
    Dim orderNO As String
    Public dtprice As New DataTable
    Dim product As New tbproduct
    Public receiveNO As String
    'Dim frmsalelist As frmsalelist = CType(Application.OpenForms("frmsalelist"), frmsalelist)
    Private Sub frmsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        If frmmain.UserAuthentication = "" Then
            btnreceive.Enabled = False
            btncancel.Enabled = False
        Else
            Dim btnreceive1 As String = "F"
            Dim btncancel1 As String = "F"
            btnreceive1 = frmmain.UserAuthentication.Substring(29, 1)
            btncancel1 = frmmain.UserAuthentication.Substring(30, 1)
            If btnreceive1 = "T" Then
                btnreceive.Enabled = True
            Else
                btnreceive.Visible = False
            End If
            If btncancel1 = "T" Then
                btncancel.Enabled = True
            Else
                btncancel.Visible = False
            End If
        End If

        If frmorder.formorder = True Then
            rdorderbill.Enabled = False
            dt.Clear()
            Dim Day As String
            Day = Today.AddDays(365)
            dgvreceive.Rows.Clear()
            dgvreceive.Columns.Clear()
            makecolumns()
            order.loadorderdetail(frmorder.dgvshow.CurrentRow.Cells(0).Value, dt)
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim proid As String = dt.Rows(i).Item(8)
                Dim proname As String = dt.Rows(i).Item(2)
                Dim unitname As String = dt.Rows(i).Item(3)
                Dim price As Double = dt.Rows(i).Item(4)
                Dim qty As Integer = dt.Rows(i).Item(5)
                Dim discount As Integer = dt.Rows(i).Item(6)
                Dim tatol As Double = dt.Rows(i).Item(7)
                Dim ordercut As Integer = dt.Rows(i).Item(9)
                Dim totalorderqty As Integer = dt.Rows(i).Item(10)
                'dgvlist.Rows.Add(proid, proname, unitname, price, qty, tatol, ordercut, totalorderqty)
                dgvreceive.Rows.Add(proid, proname, unitname, price, qty, discount, tatol, ordercut, totalorderqty, "", Day)
            Next

            txtid.Text = frmorder.dgvshow.CurrentRow.Cells(0).Value
            sup_id = frmorder.dgvshow.CurrentRow.Cells(14).Value

            txtdiscount.Text = frmorder.dgvshow.CurrentRow.Cells(5).Value

            sum_datachange()

            txttotallast.Text = frmorder.dgvshow.CurrentRow.Cells(6).Value

            txtsupname.Text = frmorder.dgvshow.CurrentRow.Cells(15).Value
            orderNO = frmorder.dgvshow.CurrentRow.Cells(0).Value

            Dim mainmoney As String = frmorder.dgvshow.CurrentRow.Cells(13).Value
            If mainmoney = "ກີບ" Then
                rdkip.Checked = True
            ElseIf mainmoney = "ບາດ" Then
                rdbath.Checked = True
            Else
                rddolla.Checked = True
            End If

            'Dim sum1 As Double
            'For i As Integer = 0 To dgvreceive.Rows.Count - 1
            '    sum1 += dgvreceive.Rows(i).Cells(6).Value
            'Next
            'tem_totalsale = sum1
            ''txttotal.Text = sum1.ToString("N0")

            cbtax.Text = frmorder.dgvshow.CurrentRow.Cells(4).Value

            Dim discout As Double = frmorder.dgvshow.CurrentRow.Cells(5).Value
            txtdiscount.Text = discout.ToString("N0")

            Dim lasttotal As Double = Val(CInt(txttotal.Text)) - Val(CInt(txtdiscount.Text))

            'txttotallast.Text = lasttotal.ToString("N0")

            rdorderbill.Checked = True
            txtreceivename.Text = frmorder.dgvshow.CurrentRow.Cells(2).Value
            If frmorder.dgvshow.CurrentRow.Cells(10).Value = False And frmorder.dgvshow.CurrentRow.Cells(11).Value = False Then

            ElseIf frmorder.dgvshow.CurrentRow.Cells(10).Value = True And frmorder.dgvshow.CurrentRow.Cells(11).Value = False Then
                dgvreceive.Enabled = False
                cbapprove.Enabled = False
                btnreceive.Enabled = False
                dgvreceive.Enabled = False
                Dim dtt As New DataTable
                dtt.Clear()



                receive.loadviewreceive(txtid.Text, dtt)
                receiveNO = dtt.Rows(0).Item(0)
                txtbillno.Text = dtt.Rows(0).Item(4)
                dtsale.Text = dtt.Rows(0).Item(8)
                cbapprove.Checked = False
                cbapprove.Enabled = False
                btnreceive.Enabled = False
            ElseIf frmorder.dgvshow.CurrentRow.Cells(10).Value = False And frmorder.dgvshow.CurrentRow.Cells(11).Value = True Then
                dgvreceive.Enabled = False
                Dim dtt As New DataTable
                dtt.Clear()
                receive.loadviewreceive(txtid.Text, dtt)
                receiveNO = dtt.Rows(0).Item(0)
                txtbillno.Text = dtt.Rows(0).Item(4)
                dtsale.Text = dtt.Rows(0).Item(8)
                cbapprove.Checked = False
                cbapprove.Enabled = False
                btnreceive.Enabled = False

            ElseIf frmorder.dgvshow.CurrentRow.Cells(10).Value = True And frmorder.dgvshow.CurrentRow.Cells(11).Value = True Then
                cbapprove.Enabled = False
                btnreceive.Enabled = False
                btncancel.Enabled = False
                dgvreceive.Enabled = False
                Dim dtt As New DataTable
                dtt.Clear()
                receive.loadviewreceive(txtid.Text, dtt)
                receiveNO = dtt.Rows(0).Item(0)
                txtbillno.Text = dtt.Rows(0).Item(4)
                dtsale.Text = dtt.Rows(0).Item(8)
                cbapprove.Checked = False
                cbapprove.Enabled = False
                btnreceive.Enabled = False
            End If

            vath.combotax(cbtax)
            Dim etax As Integer = frmorder.dgvshow.CurrentRow.Cells(4).Value
            If etax > 0 Then
                cbtax.Text = frmorder.dgvshow.CurrentRow.Cells(4).Value
                Dim total As Double = frmorder.dgvshow.CurrentRow.Cells(6).Value
                'txttotal.Text = total.ToString("N0")
                'txttotallast.Text = total.ToString("N0")
                'txtdiscount.Text = 0
            End If




            btnsave.Enabled = False
            btnedit.Enabled = False
            btnupdate.Enabled = False
            btnnew.Enabled = False
            btnclear.Enabled = False
            btnadd.Enabled = False
            btnminus.Enabled = False
            btnfree.Enabled = False
            'disableform()
            'enableedit()

        Else
            rdorderbill.Enabled = False
            dgvreceive.Columns.Clear()
            dgvreceive.Rows.Clear()
            vath.combotax(cbtax)
        End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Sub makecolumns()
        Dim proid As New DataGridViewTextBoxColumn()
        Dim barcode As New DataGridViewTextBoxColumn()
        Dim productname As New DataGridViewTextBoxColumn()
        Dim unit As New DataGridViewTextBoxColumn()
        Dim price As New DataGridViewTextBoxColumn()
        Dim discount As New DataGridViewTextBoxColumn()
        Dim total As New DataGridViewTextBoxColumn()
        Dim qtycut As New DataGridViewTextBoxColumn()
        Dim totalqtycut As New DataGridViewTextBoxColumn()
        Dim SerialID As New DataGridViewTextBoxColumn()
        Dim product_expire As New DataGridViewTextBoxColumn()
        Dim cash As New DataGridViewTextBoxColumn()
        Dim free As New DataGridViewCheckBoxColumn

        dgvreceive.Columns.Add(proid)
        dgvreceive.Columns.Add(barcode)
        dgvreceive.Columns.Add(productname)
        dgvreceive.Columns.Add(unit)
        dgvreceive.Columns.Add(price)
        dgvreceive.Columns.Add(discount)
        dgvreceive.Columns.Add(total)
        dgvreceive.Columns.Add(qtycut)
        dgvreceive.Columns.Add(totalqtycut)
        dgvreceive.Columns.Add(SerialID)
        dgvreceive.Columns.Add(product_expire)
        dgvreceive.Columns.Add(cash)
        dgvreceive.Columns.Add(free)
        With dgvreceive
            .Columns(0).HeaderText = "ລະຫັດສິນຄ້າ"
            .Columns(1).HeaderText = "ຊື່ສິນຄ້າ"
            .Columns(2).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(3).HeaderText = "ລາຄາ/ໜ່ວຍ"
            .Columns(4).HeaderText = "ຈໍານວນ"
            .Columns(5).HeaderText = "ລຸດ"
            .Columns(6).HeaderText = "ລວມ"
            .Columns(7).Visible = False            ' .Columns(7).HeaderText = "ຈໍານວນຕັດ"
            .Columns(8).Visible = False    '.Columns(8).HeaderText = "ລວມຈໍານວນຕັດ"
            .Columns(9).HeaderText = "SerialID/Barcode"
            .Columns(10).HeaderText = "ວັນໝົດປະກັນ"
            .Columns(11).HeaderText = "cach"
            .Columns(12).HeaderText = "ແຖມ"

            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
            .Columns(6).ReadOnly = True
            .Columns(7).ReadOnly = True
            .Columns(8).ReadOnly = False
            .Columns(9).ReadOnly = True
            .Columns(10).ReadOnly = True
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
           
            .Columns(11).Visible = False
        End With
        dgvreceive.Columns(3).DefaultCellStyle.Format = "N0"
        dgvreceive.Columns(5).DefaultCellStyle.Format = "N0"
    End Sub
    Private Sub enableform()
        btnsave.Enabled = True
        btnclear.Enabled = True
        btnadd.Enabled = True
        btnminus.Enabled = True
        dgvreceive.ReadOnly = False
        dgvreceive.Enabled = True
    End Sub
    Private Sub disableform()
        btnsave.Enabled = False
        btnclear.Enabled = False
        btnadd.Enabled = False
        btnminus.Enabled = False
        dgvreceive.Enabled = False
    End Sub
    Private Sub formclear()
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
                    formreceive = True
                    frmshowproductsale.ShowDialog()
                    With dgvreceive
                        .Columns(0).ReadOnly = True
                        .Columns(1).ReadOnly = True
                        .Columns(2).ReadOnly = True
                        '.Columns(3).ReadOnly = True
                        .Columns(3).DefaultCellStyle.Format = "N0"
                        .Columns(4).DefaultCellStyle.Format = "N0"
                        .Columns(6).DefaultCellStyle.Format = "N0"
                        '.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                        .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                    End With
                    formreceive = False
                    pCase = 0
                End If
                Exit Select
            Case 2
                If True Then
                    formreceive = True
                    frmshowunit.ShowDialog()
                    formreceive = False
                    pCase = 0
                    Exit Select
                End If
        End Select
    End Sub
 

    Private Sub btnbrown_Click(sender As Object, e As EventArgs) Handles btnbrown.Click
        formreceive = True
        frmshowcustomer.ShowDialog()
        frmshowcustomer.Close()
        formreceive = False
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


    Private Sub dgvsale_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreceive.CellEnter
        If dgvreceive.CurrentRow.Cells(1).Selected = True Then
            pCase = 1
            Dim Loc As Rectangle = dgvreceive.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
            Dim Wid As Integer = dgvreceive.CurrentCell.Size.Width
            btnSelector.Location = New Point(Loc.X - 30 + Wid, Loc.Y)
            btnSelector.Show()

        ElseIf dgvreceive.CurrentRow.Cells(2).Selected = True Then
            pCase = 2
            Dim Loc As Rectangle = dgvreceive.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
            Dim Wid As Integer = dgvreceive.CurrentCell.Size.Width
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
    Private Sub dgvsale_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvreceive.EditingControlShowing
        Try
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvsale_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvreceive.CellMouseUp
        Try
            dgvreceive.Columns(3).DefaultCellStyle.Format = "N0"
            If e.Button = Windows.Forms.MouseButtons.Right Then

                Me.dgvreceive.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex
                Me.dgvreceive.CurrentCell = Me.dgvreceive.Rows(e.RowIndex).Cells(1)
                'Me.ContextMenuStrip1.Show(Me.dgvreceive, e.Location)
                'ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs)
        If Not Me.dgvreceive.Rows(Me.rowIndex).IsNewRow Then
            Me.dgvreceive.Rows.RemoveAt(Me.rowIndex)
        End If
    End Sub

    Private Sub txtdiscount_TextChanged(sender As Object, e As EventArgs) Handles txtdiscount.TextChanged
        Try

            If txtdiscount.Text = "" Then
                txtdiscount.Text = 0
            End If
            'Dim tem As Double = txtdiscount.Text
            'txtdiscount.Text = tem.ToString("N0")
            'txtdiscount.SelectionStart = txtdiscount.TextLength
            'Dim tem_totalsale As Double = CInt(txttotal.Text)
            'Dim discount As Double = CInt(txtdiscount.Text)
            'Dim c As Double = tem_totalsale - discount
            'txttotallast.Text = c.ToString("N0")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
    Private Sub cbtax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtax.SelectedIndexChanged
        Try
            'If cbtax.SelectedValue > 1 Then
            Dim tax As Double
            Dim rows As DataRowView = cbtax.SelectedItem
            Dim row As DataRow = rows.Row
            Dim tem_totalsale As Double = CInt(txttotal.Text)
            tax = row(1).ToString
            txttax.Text = ((tax * tem_totalsale) / 100).ToString
            Dim addtax As Double = tem_totalsale + ((tax * tem_totalsale) / 100)
            'txttotallast.Text = addtax.ToString("N0")
            'Else

            'End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            dgvreceive.Rows.Add()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnew_Click_1(sender As Object, e As EventArgs) Handles btnnew.Click
        'Try
        dgvreceive.Columns.Clear()
        dgvreceive.Rows.Clear()
        enableform()
        formclear()
        dgvreceive.Rows.Clear()
        dgvreceive.ReadOnly = True
        rdbath.Checked = True
        vath.combotax(cbtax)
        cbtax.SelectedValue = 1

        makecolumns()
        For i As Integer = 0 To 10
            dgvreceive.Rows.Add()
        Next

        txtdiscount.Text = 0
        With dgvreceive
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(6).ReadOnly = True
        End With
        CreateButton(btnSelector)
        dgvreceive.Controls.Add(btnSelector)
        btnsave.Enabled = True
        txtid.Text = receive.runreceiveNO
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        Try
            dgvreceive.Rows.RemoveAt(dgvreceive.CurrentRow.Index)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Try
            dgvreceive.Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub sum_datachange()
        Dim totalsale As Double
        For i As Integer = 0 To dgvreceive.Rows.Count - 1
            If dgvreceive.Rows(i).Cells(11).Value = True Then
                dgvreceive.Rows(i).Cells(5).Value = 0
            Else
                Dim a As Integer = dgvreceive.Rows(i).Cells(4).Value
                Dim qtycut As Integer = dgvreceive.Rows(i).Cells(6).Value
                Dim price As Double = dgvreceive.Rows(i).Cells(3).Value
                Dim total As Double = (a * price)
                dgvreceive.Rows(i).Cells(5).Value = total.ToString("N0")
                'dgvreceive.Rows(i).Cells(10).Value = a * qtycut
                With dgvreceive
                    .Columns(3).DefaultCellStyle.Format = "N0"
                    .Columns(5).DefaultCellStyle.Format = "N0"
                    totalsale += dgvreceive.Rows(i).Cells(5).Value
                End With

            End If
        Next
        tem_totalsale = totalsale
        txttotal.Text = totalsale.ToString("N0")
    End Sub
    Private Sub dgvsale_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreceive.CellEndEdit
        Try
            sum_datachange()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        'If txtreceiveNO.Text = "" Then
        '    MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນໃຫ້ຄົບສາກ່ອນ")
        '    Exit Sub
        'End If
        If txtsupname.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນຜູ້ສະໜອງກ່ອນ")
            txtsupname.Focus()
            Exit Sub
        End If
        If txtid.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນລະຫັດບິນສາກ່ອນ")
            txtid.Focus()
            Exit Sub
        End If
        If dgvreceive.Rows.Count < 1 Then
            MessageBox.Show("ກະລຸນາເພີ້ມລາຍການຂາຍ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'If rdcash.Checked = "ກີບ" Then
        '    rkip.Checked = True
        'ElseIf cash1 = "ບາດ" Then
        '    rbath.Checked = True
        'ElseIf cash1 = "ໂດລາ" Then
        '    rdola.Checked = True
        'End If
        'receive.savereceive(txtreceiveNO.Text, receiveautoid, frmmain.userid, txtsupplierreciveid.Text, txtbillNOrecive.Text, txtreceive_total.Text, Format(CDate(txtreceive_date.Text), "yyyy/MM/dd"), txtreceivenote.Text, 4, txtcash.Text)
        'For i As Integer = 0 To dgvreceive.Rows.Count - 2
        'Dim recivedetailid As Integer
        'txtrecivedetailid.Text = receive.runreceiveautoid
        'Dim reciveNO As String = txtorderNO.Text
        'Dim proid As String = dgvreceive.Rows(i).Cells(0).Value
        'Dim recive_price As Double = dgvreceive.Rows(i).Cells(3).Value
        'Dim recive_qty As Integer = dgvreceive.Rows(i).Cells(4).Value
        'Dim recive_total As Double = dgvreceive.Rows(i).Cells(5).Value
        ''Dim recive_money As String = dgvlist.Rows(i).Cells(6).Value
        'Dim recive_blancecut As Integer = dgvreceive.Rows(i).Cells(7).Value
        'Dim Product_expire As String = dgvreceive.Rows(i).Cells(8).Value
        'Dim SerialID As String = dgvreceive.Rows(i).Cells(9).Value
        'Dim cash As String = dgvreceive.Rows(i).Cells(10).Value

        '    receive.savereceivedetail(txtrecivedetailid.Text, txtreceiveNO.Text, proid, recive_price, recive_qty, recive_total, cash, recive_blancecut, SerialID, Product_expire)
        'Next
        'order.updatestatus(txtorderNO.Text, 1)
        'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)

        'txtrecivedetailid.Text = receive.runreceivedetailautoid
        'txtreceiveNO.Text = receive.run_runNO

        'txtwriterecive()
        'txtclear()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        enableform()
        btnsave.Enabled = False
        btnupdate.Enabled = True
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click

        'Try
        'Dim neworderid As String
        'If frmorder.formorder = True Then
        '    neworderid = orderNO
        'Else
        '    neworderid = txtid.Text
        'End If
        'MessageBox.Show(receiveNO)
        'Dim checksaleNO As String = receive.Check_existreceiveNO(receiveNO)
        ''MessageBox.Show(checksaleNO)
        'If checksaleNO = "False" Then

        'Else
        Dim checkid As String = receive.Check_existreceiveNO_bybillorderNO(txtid.Text)
        If checkid = "False" Then
            Return
        Else
            receiveNO = checkid
        End If
         
        frmbillreceive.ShowDialog()
        frmbillreceive.Close()

        'End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        'Try
        If txtsupname.Text = "" Then
            MessageBox.Show("ກະລຸນາເລືອກລູກຄ້າ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bath As Double
        Dim dolla As Double
        bath = exch.loadbaht
        dolla = exch.loaddolla

        Dim totalbath As Double = bath
        If rdkip.Checked = True Then
            mainmoney = "ກີບ"

        ElseIf rdbath.Checked = True Then
            mainmoney = "ບາດ"

        ElseIf rddolla.Checked = True Then
            mainmoney = "ໂດລາ"

        End If

    End Sub

    Private Sub btnapprove_Click(sender As Object, e As EventArgs) Handles btnreceive.Click
        Dim pro As New tbproduct
        If txtbillno.Text = "" Then
            MessageBox.Show("ກະລຸນາໃນເລກທີບີນ", "ຄໍາແນະນໍາ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            txtbillno.Select()
            Return
        End If
        If txtsupname.Text = "" Then
            MessageBox.Show("ກະລຸນາເລືອກຜູ້ສະໜອງສີນຄ້າ", "ຄໍາແນະນໍາ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            txtsupname.Select()
            Return
        End If
        If dgvreceive.Rows.Count < 1 Then
            MessageBox.Show("ກະລຸນາເພີ້ມລາຍການສີນຄ້າ", "ຄໍາແນະນໍາ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            Return
        End If
        If MessageBox.Show("ທ່ານຕ້ອງການອະນຸມັດການຮັບສິນຄ້າແທ້ບໍ່, ກົດ OK ເພື່ອຍອມຮັບ?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim receiveNO As String = receive.runreceiveNO
            Dim autoid As Integer = receive.runreceiveautoid
            Dim vath As Double
            Dim mainmoney As String = Nothing
            If rdkip.Checked = True Then
                mainmoney = "ກີບ"
            ElseIf rdbath.Checked = True Then
                mainmoney = "ບາດ"
            ElseIf rddolla.Checked = True Then
                mainmoney = "ໂດລາ"
            End If
            Dim rows1 As DataRowView = cbtax.SelectedItem
            Dim row1 As DataRow = rows1.Row
            vath = row1(1).ToString
            If rdorderbill.Checked = True Then
                receive.savereceive(receiveNO, autoid, frmmain.userid, sup_id, orderNO, txtbillno.Text, txtdiscount.Text, vath, txttotallast.Text, Format(CDate(dtsale.Text), "MM/dd/yyy"), 5, mainmoney)
                For i As Integer = 0 To dgvreceive.Rows.Count - 1

                    Dim proid As String = dgvreceive.Rows(i).Cells(0).Value
                    Dim callcapital As Double = pro.Select_Capitalprice(proid)

                    Dim getqty As Integer = pro.Callstock_qty(proid)
                    Dim detailid As Integer = receive.runreceivedetailautoid
                    Dim unitname As String = dgvreceive.Rows(i).Cells(2).Value
                    Dim receivePrice As Double = dgvreceive.Rows(i).Cells(3).Value
                    If receivePrice = callcapital Then

                    Else
                        pro.update_pricebuy(proid, receivePrice)
                    End If

                    Dim receiveqty As Integer = dgvreceive.Rows(i).Cells(4).Value
                    Dim discount As Integer = dgvreceive.Rows(i).Cells(5).Value
                    Dim receiveTotalprice As Double = dgvreceive.Rows(i).Cells(6).Value
                    Dim totalcut As Integer = dgvreceive.Rows(i).Cells(8).Value
                    Dim barcode1 As String = dgvreceive.Rows(i).Cells(9).Value
                    Dim date1 As String = dgvreceive.Rows(i).Cells(10).Value
                    Dim dda As String = Format(CDate(date1), "MM/dd/yyyy")
                    receive.savereceivedetail(detailid, receiveNO, proid, unitname, receivePrice, receiveqty, discount, receiveTotalprice, mainmoney, totalcut, totalcut, barcode1, dda)
                    Dim newqty As Integer = getqty + totalcut
                    pro.updateStock(proid, newqty)
                Next
                order.Update_receproduct(orderNO)
                dgvreceive.Enabled = False
                btnreceive.Enabled = False
                btnedit.Enabled = False
                btnnew.Enabled = False
            End If

        End If

    End Sub

    Private Sub dgvreceive_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreceive.CellClick
        Try
            If rdorderbill.Checked = True Then
                dgvreceive.ReadOnly = True
                If dgvreceive.CurrentRow.Cells(10).Selected = True Then
                    frmshowdate.ShowDialog()
                    frmshowdate.Close()
                End If
            Else
                If dgvreceive.CurrentRow.Cells(3).Selected = True Or dgvreceive.CurrentRow.Cells(4).Selected = True Or dgvreceive.CurrentRow.Cells(5).Selected = True Then
                    dgvreceive.ReadOnly = False
                    dgvreceive.BeginEdit(True)
                ElseIf dgvreceive.CurrentRow.Cells(9).Selected = True Then
                    dgvreceive.Enabled = True
                    dgvreceive.ReadOnly = False
                    frmshowdate.ShowDialog()
                    frmshowdate.Close()
                Else

                    dgvreceive.ReadOnly = True
                    dgvreceive.EndEdit(True)

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnfree_Click(sender As Object, e As EventArgs) Handles btnfree.Click
        Try
            If dgvreceive.CurrentRow.Cells(11).Value = False Then
                dgvreceive.CurrentRow.Cells(11).Value = True
                dgvreceive.CurrentRow.Cells(5).Value = 0
                sum_datachange()
            Else
                dgvreceive.CurrentRow.Cells(11).Value = False
                sum_datachange()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub productbrowse_Click(sender As Object, e As EventArgs) Handles productbrowse.Click
        Try
            frmshowproduct.ShowDialog()
            frmshowproduct.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdmanualbill_CheckedChanged(sender As Object, e As EventArgs) Handles rdmanualbill.CheckedChanged
        If rdmanualbill.Checked = True Then
            enablesave()
            enableform()
            dgvreceive.Rows.Clear()
            dgvreceive.Columns.Clear()
        End If
    End Sub

    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                cn.connect()
                Dim checkbarcode As String = Nothing
                cm = New SqlCommand("select barcode, proID from viewprice where barcode='" & txtbarcode.Text & "'", cn.conn)
                re = cm.ExecuteReader
                If re.HasRows Then
                    While re.Read
                        checkbarcode = re.GetValue(1)
                    End While
                Else
                    checkbarcode = False
                End If
                re.Close()
                If checkbarcode = False Then
                    txtbarcode.Clear()
                    txtbarcode.Select()
                Else
                    cn.connect()

                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub frmreceiveproduct_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
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
                Dim ordername As String = frmorder.dtorder.Rows(i).Item(10)
                Dim buyfrom As String = frmorder.dtorder.Rows(i).Item(3)
                Dim discount1 As Double = frmorder.dtorder.Rows(i).Item(4)
                Dim total As Double = frmorder.dtorder.Rows(i).Item(5)
                Dim totalpay As Double = frmorder.dtorder.Rows(i).Item(6)
                Dim notpay As Double = frmorder.dtorder.Rows(i).Item(7)
                Dim saledate1 As String = frmorder.dtorder.Rows(i).Item(8)
                Dim tax As String = frmorder.dtorder.Rows(i).Item(28)
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
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim recedt As New DataTable
        receive.select_viewreceivedetail(txtid.Text, recedt)
        If recedt.Rows.Count > 0 Then
            If MessageBox.Show("ທ່ານຕ້ອງການຍົກເລີກລາຍການນີ້ແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                For i As Integer = 0 To recedt.Rows.Count - 1
                    Dim proid As String = recedt.Rows(i).Item(1)
                    Dim callstockqty As Integer = product.Callstock_qty(proid)
                    If callstockqty < recedt.Rows(i).Item(9) Then
                        MessageBox.Show("ທ່ານບໍ່ສາມາຍົກເລີກບີນນີ້ໄດ້ເນືອງຈາກທ່ານໄດ້ມີການຂາຍສີນຄ້າບີນນີ້ອອກແລ້ວ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Next

                For k As Integer = 0 To recedt.Rows.Count - 1
                    Dim proid As String = recedt.Rows(k).Item(1)
                    Dim callstockqty As Integer = product.Callstock_qty(proid)
                    Dim returnqty As Integer = recedt.Rows(k).Item(9)
                    Dim updateqty As Integer = callstockqty - returnqty
                    product.updateStock(proid, updateqty)
                Next
                receive.Cancelreceive(txtid.Text)
                btnedit.Enabled = False
            End If
        End If
    End Sub
    Private Sub dgvreceive_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvreceive.CellContentClick

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim cus As New tbsuppliers
        formreceive = True
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
        formreceive = False
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txttotal_TextChanged_1(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        Dim tem As Double = txttotal.Text
        txttotal.Text = tem.ToString("N0")
        txttotal.SelectionStart = txttotal.TextLength
    End Sub

    Private Sub txttotallast_TextChanged(sender As Object, e As EventArgs) Handles txttotallast.TextChanged
        Dim tem As Double = txttotallast.Text
        txttotallast.Text = tem.ToString("N0")
        txttotallast.SelectionStart = txttotallast.TextLength

    End Sub
End Class