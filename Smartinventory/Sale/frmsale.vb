Public Class frmsale
    Dim salename As New tbsalename
    Dim saleapprove As New tbapprovedate
    Dim approve As New tbapprove
    Dim cancelsale As New tbcancelsale
    Dim sup As New tbsuppliers
    Dim setmoney As New tbsetmoney
    Dim product As New tbproduct
    Dim vath As New tbtax
    Dim sale As New tbsales
    Dim exch As New tbexchange
    Dim pays As New tbpay
    Public formsale As Boolean = False
    Private pCase As Integer
    Private btnSelector As New Button()
    Private rowIndex As Integer = 0
    Dim tem_totalsale As Double
    Public sup_id As String
    Dim frmmain1 As frmmain = DirectCast(Application.OpenForms("frmmain"), frmmain)
    Public mainmoney As String
    Public payname As String
    Public nextday As New DateTimePicker
    Public dt As New DataTable
    Dim totalsale As Double
    Dim subsale As New tbsalesubitem
    'Dim ids As Integer
    'Dim frmsalelist As frmsalelist = CType(Application.OpenForms("frmsalelist"), frmsalelist)
    Dim currentdate As String
    Dim billcash As String
    Dim billdevery As String
    Dim billquotation As String
    Private Sub sum_datachange()
        Try


            totalsale = 0
            For i As Integer = 0 To dgvsale.Rows.Count - 1
                If dgvsale.Rows(i).Cells(6).Value = True Then
                    dgvsale.Rows(i).Cells(7).Value = 0

                    'ElseIf dgvsale.Rows(i).Cells(12).Value = 3 Then

                    'totalsale += dgvsale.Rows(i).Cells(7).Value

                Else
                    Dim a As Integer = dgvsale.Rows(i).Cells(4).Value
                    Dim discount As Double = dgvsale.Rows(i).Cells(5).Value
                    Dim qtycut As Integer = dgvsale.Rows(i).Cells(9).Value
                    Dim price As Double = dgvsale.Rows(i).Cells(3).Value
                    Dim total As Double = (a * price) - discount
                    dgvsale.Rows(i).Cells(7).Value = total
                    dgvsale.Rows(i).Cells(10).Value = a * qtycut
                    With dgvsale
                        .Columns(3).DefaultCellStyle.Format = "N0"
                        .Columns(4).DefaultCellStyle.Format = "N0"
                        .Columns(7).DefaultCellStyle.Format = "N0"
                        .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        totalsale += dgvsale.Rows(i).Cells(7).Value
                    End With
                End If
            Next
            Dim b As Double
            Dim c As Double
            Try
                b = Val(CInt(txttotallast.Text))

            Catch ex As Exception
                b = 0


            End Try
            Try

                c = Val(CInt(txtdeposite.Text))
            Catch ex As Exception

                c = 0

            End Try
            tem_totalsale = totalsale

            txttotalsale.Text = totalsale.ToString("N0")
            txttotallastall.Text = totalsale.ToString("N0")
            'txttotallastall.Text = b - c

            discount()
            pricetax()
            deposit()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            currentdate = System.DateTime.Now.ToString("MM/dd/yyyy")
            Dim frmsalelist1 As frmsalelist = DirectCast(Application.OpenForms("frmsalelist"), frmsalelist)
            Dim frmmain1 As frmmain = DirectCast(Application.OpenForms("frmmain"), frmmain)
            rddebit.Checked = True
            'Try
            txtnameaprove.Text = "..."
            txtdiscount.Text = 0
            txtdeposite.Text = 0
            cbselectbill.SelectedIndex = 0
            'btnedit.Enabled = False
            'If btnapprove.Enabled = False Then
            '    btnedit.Enabled = False
            'Else
            '    btnedit.Enabled = True
            'End If
            'MessageBox.Show("11")
            If frmmain1.UserAuthentication = "" Then
                btnapprove.Enabled = False
                btncancel.Enabled = False
                btnunapprove.Enabled = False
            Else
                'MessageBox.Show("22")
                Dim btnapprove1 As String = "F"
                Dim btncancel1 As String = "F"
                Dim btnunapprove1 As String = "F"
                btnapprove1 = frmmain1.UserAuthentication.Substring(35, 1)
                btncancel1 = frmmain1.UserAuthentication.Substring(36, 1)

                billcash = frmmain1.UserAuthentication.Substring(37, 1)
                billdevery = frmmain1.UserAuthentication.Substring(38, 1)
                billquotation = frmmain1.UserAuthentication.Substring(39, 1)
                btnunapprove1 = frmmain1.UserAuthentication.Substring(40, 1)
                'MessageBox.Show(billcash + billdevery + billquotation)


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

                If btnunapprove1 = "T" Then
                    btnunapprove.Enabled = True
                Else
                    btnunapprove.Visible = False
                End If

            End If
            ''MessageBox.Show("test")
            dgvsale.Columns.Clear()
            dgvsale.Rows.Clear()
            salename.combosalename(cbsalename)
            vath.combotax(cbtax)
            'MessageBox.Show(frmsalelist1.saledetail)
            'MessageBox.Show(frmsalelist1.dgvsalelist.CurrentRow.Cells(0).Value)
            If frmsalelist1.saledetail = True Then
                'MessageBox.Show(frmsalelist1.dgvsalelist.CurrentRow.Cells(0).Value)
                saletable()
                dgvsale.Rows.Clear()
                dt.Clear()
                sale.Call_saledetail_bysaleNO(frmsalelist1.dgvsalelist.CurrentRow.Cells(0).Value, dt)
                txtaprovedate.Text = saleapprove.call_saleapprovedate(frmsalelist1.dgvsalelist.CurrentRow.Cells(0).Value)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim id As String = dt.Rows(i).Item(1)
                    Dim list As String = dt.Rows(i).Item(2)
                    Dim unit As String = dt.Rows(i).Item(3)
                    Dim pricebuy As Double = dt.Rows(i).Item(4)
                    Dim pricesale As Double = dt.Rows(i).Item(5)
                    Dim saleqty As Double = dt.Rows(i).Item(6)
                    Dim discount As Double = dt.Rows(i).Item(7)
                    Dim totalsale As Double = dt.Rows(i).Item(8)
                    Dim totalqtycut As Integer = dt.Rows(i).Item(9)
                    Dim cutype As Integer = dt.Rows(i).Item(18)
                    Dim qtycut As Integer
                    If totalqtycut < 1 Then
                        qtycut = 0
                        totalqtycut = 0
                    Else
                        qtycut = totalqtycut / saleqty
                    End If
                    Dim givefree As Boolean
                    If totalsale > 1 Then
                        givefree = False

                    ElseIf totalsale = 0 Then
                        givefree = True
                    End If
                    dgvsale.Rows.Add(id, list, unit, pricesale, saleqty, discount, givefree, totalsale, "", qtycut, totalqtycut, pricebuy, cutype)
                Next
                If frmsalelist1.dgvsalelist.CurrentRow.Cells(9).Value = "ກີບ" Then
                    rdkip.Checked = True
                ElseIf frmsalelist1.dgvsalelist.CurrentRow.Cells(9).Value = "ບາດ" Then
                    rdbath.Checked = True
                Else
                    rddolla.Checked = True
                End If
                If frmsalelist1.dgvsalelist.CurrentRow.Cells(1).Value = "ສົດ" Then
                    rdcash.Checked = True
                    txtdeposite.Text = 0
                Else
                    cbprice.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(17).Value
                    txtdeposite.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(7).Value
                    rddebit.Checked = True
                End If
                'disableform()
                'enableedit()
                enableedit()
                If frmsalelist1.dgvsalelist.CurrentRow.Cells(11).Value = False And frmsalelist1.dgvsalelist.CurrentRow.Cells(12).Value = False Then
                    btnapprove.Enabled = True
                    btncancel.Enabled = True
                    btnunapprove.Enabled = False
                ElseIf frmsalelist1.dgvsalelist.CurrentRow.Cells(11).Value = False And frmsalelist1.dgvsalelist.CurrentRow.Cells(12).Value = True Then
                    btnapprove.Enabled = False
                    btncancel.Enabled = True
                    btnunapprove.Enabled = True
                    'MessageBox.Show("2")
                    btnedit.Enabled = False
                ElseIf frmsalelist1.dgvsalelist.CurrentRow.Cells(11).Value = True And frmsalelist1.dgvsalelist.CurrentRow.Cells(12).Value = False Then
                    btnapprove.Enabled = False
                    btncancel.Enabled = False
                    'MessageBox.Show("3")
                    btnedit.Enabled = False
                    btnunapprove.Enabled = True
                ElseIf frmsalelist1.dgvsalelist.CurrentRow.Cells(11).Value = True And frmsalelist1.dgvsalelist.CurrentRow.Cells(12).Value = True Then
                    btnapprove.Enabled = False
                    btnunapprove.Enabled = True
                    btncancel.Enabled = False
                    'MessageBox.Show(btnedit.Enabled)
                    btnedit.Enabled = False
                End If
                txtid.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(0).Value
                txtsupname.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(3).Value
                cbsalename.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(2).Value
                txtsalenameproduct.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(2).Value
                sup_id = frmsalelist1.dgvsalelist.CurrentRow.Cells(13).Value
                txtnote.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(14).Value
                cbprice.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(17).Value

                txttotallastall.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(7).Value

                'For i As Integer = 0 To frmsalelist.dt.Rows.Count - 1
                '        Dim checkapprove As String = frmsalelist.dt.Rows(i).Item(12)
                'If checkapprove = "YES" Then
                '    txtnameaprove.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(2).Value
                'Else
                '    txtnameaprove.Text = ""
                'End If
                'Next
                If btnapprove.Enabled = False Then
                    txtnameaprove.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(2).Value

                    txtnameaprove.ForeColor = Color.Green
                Else
                    txtnameaprove.Text = "ຍັງບໍ່ທັນໄດ້ຮັບການອານຸມັດ"
                    txtnameaprove.ForeColor = Color.Red
                End If


                txtlocation.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(16).Value
                'sum_datachange()
                'Dim tax As Double = frmsalelist1.dgvsalelist.CurrentRow.Cells(5).Value
                'Dim taxvalue As Double
                Dim sum1 As Double
                For i As Integer = 0 To dgvsale.Rows.Count - 1
                    sum1 += dgvsale.Rows(i).Cells(7).Value
                Next
                txttotalsale.Text = sum1.ToString("N0")


                Dim discout As Double = frmsalelist1.dgvsalelist.CurrentRow.Cells(4).Value
                'MessageBox.Show(discout)
                txtdiscount.Text = discout.ToString("N0")
                Dim lasttotal As Double = Val(CInt(txttotalsale.Text)) - Val(CInt(txtdiscount.Text))

                txttotallast.Text = lasttotal.ToString("N0")

                Dim etax As Integer = frmsalelist1.dgvsalelist.CurrentRow.Cells(5).Value
                If etax > 0 Then
                    cbtax.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(5).Value
                    Dim total As Double = frmsalelist1.dgvsalelist.CurrentRow.Cells(6).Value
                    'txttotal.Text = total.ToString("N0")  
                    'MessageBox.Show(total)
                    txttotallast.Text = total.ToString("N0")
                    'txttotallastall.Text = total.ToString("N0")
                    'txtdiscount.Text = 0
                End If
                'txtdiscount.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(4).Value
                'cbtax.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(5).Value
                'taxvalue = ((Val(CInt(txtdiscount.Text)) * tax) / 100)
                'txttotallast.Text = (Val(CInt(txt_dispersent.Text)) + taxvalue).ToString("N0")
                ''txttotalsale.Text = sum1.ToString("N0")


                txtdaycredit.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(15).Value
                If txtdeposite.Text = "" Then

                    txtdeposite.Text = 0
                End If
                If txtdiscount.Text = "" Then
                    txtdiscount.Text = 0
                End If

                'Dim distotal As Double = Val(CInt(txttotalsale.Text)) - Val(CInt(txtdiscount.Text))
                'txt_dispersent.Text = distotal.ToString("N0")
                'Dim lasttotal As Double = Val(CInt(txt_dispersent.Text)) - Val(CInt(txtdeposite.Text))
                'txttotallast.Text = lasttotal.ToString("N0")
                disableform()


                dtsale.Text = frmsalelist1.dgvsalelist.CurrentRow.Cells(10).Value

            Else
                'MessageBox.Show("dd")
                formclear()
                dgvsale.Rows.Clear()
                saletable()
                enablesave()
                btnsave.Enabled = False

                mainmoney = setmoney.Call_mainmoney
                If mainmoney = "ກີບ" Then
                    rdkip.Checked = True
                    mainmoney = "ກີບ"
                ElseIf mainmoney = "ບາດ" Then
                    rdbath.Checked = True
                    mainmoney = "ບາດ"
                Else
                    rddolla.Checked = True
                    mainmoney = "ໂດລາ"
                End If
            End If
            Dim counts As Integer = 0
            For i As Integer = 0 To dgvsale.Rows.Count - 1
                If dgvsale.Rows(i).Cells(0).Value Is Nothing Then
                Else
                    counts += 1
                End If
            Next
            txtcount.Text = counts
            If billcash = "T" Then

            Else
                'ໃບຮັບເງີນສົດ()
                'ໃບສົ່ງເຄືອງ()
                'ໃບສະເໜີລາຄາ()
                cbselectbill.Items.Clear()
                cbselectbill.Items.Add("ໃບສະເໜີລາຄາ")
                cbselectbill.Items.Add("ໃບສົ່ງເຄືອງ")

            End If
            frmsalelist.formsalelist = False
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub enableform()
        cbsalename.Enabled = True
        txtnote.Enabled = True
        txtlocation.Enabled = True
        cbprice.Enabled = True
        btnsave.Enabled = True
        btnclear.Enabled = True
        btnadd.Enabled = True
        btnminus.Enabled = True
        btnfree.Enabled = True
        dgvsale.Enabled = True
        txtdeposite.Enabled = True
        txtdiscount.Enabled = True
        cbtax.Enabled = True
    End Sub
    Private Sub disableform()
        cbsalename.Enabled = False
        txtnote.Enabled = False
        txtlocation.Enabled = False
        cbprice.Enabled = False
        btnsave.Enabled = False
        btnclear.Enabled = False
        btnadd.Enabled = False
        btnminus.Enabled = False
        btnfree.Enabled = False
        dgvsale.Enabled = False
        txtdeposite.Enabled = False
        txtdiscount.Enabled = False
        cbtax.Enabled = False
    End Sub
    Private Sub formclear()
        txtid.Clear()
        cbsalename.DropDownStyle = ComboBoxStyle.DropDownList
        txtnote.Clear()
        txtlocation.Clear()
        txtsupname.Clear()
        txttotalsale.Clear()
        txtdiscount.Clear()
        txt_dispersent.Clear()
        txtdeposite.Clear()
        txttotallast.Clear()
        txtdaycredit.Clear()

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
                    formsale = True
                        frmshowproductsale.ShowDialog()
                        With dgvsale
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
                        formsale = False
                        pCase = 0
                    sum_datachange()
                    Dim counts As Integer = 0
                    For i As Integer = 0 To dgvsale.Rows.Count - 1
                        If dgvsale.Rows(i).Cells(0).Value Is Nothing Then
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
                    formsale = True
                    frmshowunit.ShowDialog()
                    formsale = False
                    pCase = 0
                    sum_datachange()

                    Exit Sub
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
        Dim cutype As New DataGridViewTextBoxColumn
        dgvsale.Columns.Add(id)
        dgvsale.Columns.Add(name)
        dgvsale.Columns.Add(unitname)
        dgvsale.Columns.Add(price)
        dgvsale.Columns.Add(saleqty)
        dgvsale.Columns.Add(discount)
        dgvsale.Columns.Add(free)
        dgvsale.Columns.Add(total)
        dgvsale.Columns.Add(options)
        'dgvsale.Columns.Add(unitid)
        dgvsale.Columns.Add(qtycut)
        dgvsale.Columns.Add(totalqtycut)
        dgvsale.Columns.Add(pricebuy)
        dgvsale.Columns.Add(cutype)
        'options.Text = "ບີນຍ່ອຍ"
        options.UseColumnTextForButtonValue = True

        With dgvsale
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ລາຍການ"
            .Columns(2).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(3).HeaderText = "ລາຄາ"
            .Columns(4).HeaderText = "ຈໍານວນ"
            .Columns(5).HeaderText = "ລຸດ"
            .Columns(6).HeaderText = "ແຖມ"
            .Columns(7).HeaderText = "ລວມ"
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns(8).Visible = False
            .Columns(6).Width = 40
            .Columns(7).Width = 150
            .Columns(3).DefaultCellStyle.Format = "N0"
            .Columns(7).DefaultCellStyle.Format = "N0"
        End With
    End Sub

    Private Sub btnbrown_Click(sender As Object, e As EventArgs) Handles btnbrown.Click
        formsale = True
        frmshowcustomer.ShowDialog()
        frmshowcustomer.Close()
        formsale = False
    End Sub

    Private Sub btnsalename_Click(sender As Object, e As EventArgs) Handles btnsalename.Click
        Try
            frmsalename.ShowDialog()
            frmsalename.Close()
            salename.combosalename(cbsalename)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnshowtax_Click(sender As Object, e As EventArgs) Handles btnshowtax.Click
        frmtax.ShowDialog()
        frmtax.Close()
        vath.combotax(cbtax)
    End Sub

    Private Sub dgvsale_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsale.CellClick
        Try
            'If dgvsale.CurrentRow.Cells(6).Selected = True Then
            'dgvsale.ReadOnly = True
            ' ''If dgvsale.CurrentRow.Cells(6).Selected = True And dgvsale.CurrentRow.Cells(6).Value = False Then
            ' ''    dgvsale.CurrentRow.Cells(6).Value = True
            ' ''    dgvsale.CurrentRow.Cells(7).Value = 0
            ' ''    sum_datachange()
            ' ''ElseIf dgvsale.CurrentRow.Cells(6).Selected = False Then
            ' ''    sum_datachange()
            ' ''Else
            ' ''    dgvsale.CurrentRow.Cells(6).Value = False
            ' ''    sum_datachange()
            ' ''End If
            'End If


            '=========================


            If dgvsale.CurrentRow.Cells(7).Selected = True And dgvsale.CurrentRow.Cells(12).Value = 3 Then
                dgvsale.ReadOnly = False
                dgvsale.BeginEdit(True)

            ElseIf dgvsale.CurrentRow.Cells(3).Selected = True Or dgvsale.CurrentRow.Cells(4).Selected = True Or dgvsale.CurrentRow.Cells(5).Selected = True And dgvsale.CurrentRow.Cells(12).Value <> 3 Then
                dgvsale.ReadOnly = False
                dgvsale.BeginEdit(True)

            End If
            ''If dgvsale.CurrentRow.Cells(3).Selected = True Or dgvsale.CurrentRow.Cells(4).Selected = True Or dgvsale.CurrentRow.Cells(5).Selected = True And dgvsale.CurrentRow.Cells(12).Value <> 3 Then
            ''    dgvsale.ReadOnly = False
            ''    dgvsale.BeginEdit(True)
            ''Else
            ''    dgvsale.ReadOnly = True
            ''    dgvsale.EndEdit(True)
            ''End If

            If dgvsale.CurrentRow.Cells(8).Selected = True And dgvsale.CurrentRow.Cells(12).Value = 3 Then
                Dim checksaleno As String = sale.Check_existsaleNO(txtid.Text)
                If checksaleno = "false" Then

                Else
                    frmsalesubitem.ShowDialog()
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbprice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbprice.SelectedIndexChanged
        'MessageBox.Show(cbprice.SelectedItem.ToString())
        Try
            If cbprice.SelectedIndex = 0 Then
                dgvsale.ReadOnly = False
            Else
                If dgvsale.Rows.Count > 0 Then

                Else
                    For i As Integer = 0 To 10
                        dgvsale.Rows.Add()
                    Next
                    dgvsale.ReadOnly = True
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvsale_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsale.CellEnter
        If dgvsale.CurrentRow.Cells(1).Selected = True Then
            pCase = 1
            Dim Loc As Rectangle = dgvsale.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
            Dim Wid As Integer = dgvsale.CurrentCell.Size.Width
            btnSelector.Location = New Point(Loc.X - 30 + Wid, Loc.Y)
            btnSelector.Show()

        ElseIf dgvsale.CurrentRow.Cells(2).Selected = True Then
            pCase = 2
            Dim Loc As Rectangle = dgvsale.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
            Dim Wid As Integer = dgvsale.CurrentCell.Size.Width
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
    Private Sub dgvsale_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvsale.EditingControlShowing
        Try
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvsale_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvsale.CellMouseUp
        Try
            dgvsale.Columns(3).DefaultCellStyle.Format = "N0"
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Me.dgvsale.Rows(e.RowIndex).Selected = True
                Me.rowIndex = e.RowIndex
                Me.dgvsale.CurrentCell = Me.dgvsale.Rows(e.RowIndex).Cells(1)
                'Me.ContextMenuStrip1.Show(Me.dgvsale, e.Location)
                'ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception

        End Try
    End Sub

  




    Private Sub txtdiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdiscount.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtdeposite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdeposite.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txttotalsale_TextChanged(sender As Object, e As EventArgs) Handles txttotalsale.TextChanged
        Try
            txt_dispersent.Text = txttotalsale.Text
            txttotallast.Text = txttotalsale.Text
            deposit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub discount()
        Try
            If txtdiscount.Text = "" Then
                txtdiscount.Text = 0
            End If
            Dim tem As Double = txtdiscount.Text
            txtdiscount.Text = tem.ToString("N0")
            txtdiscount.SelectionStart = txtdiscount.TextLength
            Dim tem_totalsale As Double = Val(CInt(txttotalsale.Text))
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
            txttax.Text = ((tax * tem_totalsale) / 100).ToString("N0")
            Dim addtax As Double = tem_totalsale + ((tax * tem_totalsale) / 100)
            txttotallast.Text = addtax.ToString("N0")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub deposit()
        Try
            If txtdeposite.Text = "" Then
                txtdeposite.Text = 0
            End If
            'If Val(CInt(txt_dispersent.Text)) = "" Then
            '    txt_dispersent.Text = 0
            'End If  
            Dim tem As Integer = txtdeposite.Text
            Dim a As Integer = Val(CInt(txttotallast.Text))
            Dim b As Integer = Val(CInt(txtdeposite.Text))
            txtdeposite.Text = tem.ToString("N0")
            txtdeposite.SelectionStart = txtdeposite.TextLength
            Dim c As Integer = a - b
            txttotallastall.Text = c.ToString("N0")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cbtax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtax.SelectedIndexChanged
        discount()
        pricetax()
        deposit()
        txtdiscount.Enabled = True
    End Sub
    Private Sub txtdeposite_TextChanged(sender As Object, e As EventArgs) Handles txtdeposite.TextChanged
        discount()
        pricetax()
        deposit()
    End Sub
    Private Sub txtdiscount_TextChanged(sender As Object, e As EventArgs) Handles txtdiscount.TextChanged
        discount()
        pricetax()
        deposit()
    End Sub
    Private Sub btnnew_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            dgvsale.Rows.Add()
            CreateButton(btnSelector)
            dgvsale.Controls.Add(btnSelector)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        Try
            'If dgvsale.SelectedCells.Count > 0 Then
            Dim saleno As String = subsale.Check_existsaleNO_insubsale(dgvsale.CurrentRow.Cells(0).Value)
            If saleno = True Then
                If MessageBox.Show("ລາຍການນີ້ມີບີນຍ່ອຍ, ທ່ານຕ້ອງການລຶບແທ້ບໍ", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                    subsale.delete_subsaleitemdetail(txtid.Text)
                    subsale.delete_subsaleitem(txtid.Text)
                    dgvsale.Rows.RemoveAt(dgvsale.CurrentRow.Index)
                    sum_datachange()
                    discount()
                    pricetax()
                    deposit()

                End If
            ElseIf saleno = False Then
                dgvsale.Rows.RemoveAt(dgvsale.CurrentRow.Index)
                sum_datachange()

                discount()
                pricetax()
                deposit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs)
        If Not Me.dgvsale.Rows(Me.rowIndex).IsNewRow Then
            Dim saleno As String = subsale.Check_existsaleNO_insubsale(dgvsale.CurrentRow.Cells(0).Value)
            If saleno = True Then
                If MessageBox.Show("ລາຍການນີ້ມີບີນຍ່ອຍ, ທ່ານຕ້ອງການລຶບແທ້ບໍ", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                    subsale.delete_subsaleitemdetail(txtid.Text)
                    subsale.delete_subsaleitem(txtid.Text)
                    Me.dgvsale.Rows.RemoveAt(Me.rowIndex)
                    sum_datachange()
                    discount()
                    pricetax()
                    deposit()
                End If
            ElseIf saleno = False Then
                sum_datachange()
                discount()
                pricetax()
                deposit()
                Me.dgvsale.Rows.RemoveAt(Me.rowIndex)
            End If
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Try
            dgvsale.Rows.Clear()
            sum_datachange()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnfree_Click(sender As Object, e As EventArgs) Handles btnfree.Click
        Try
            If dgvsale.CurrentRow.Cells(6).Selected = True And dgvsale.CurrentRow.Cells(6).Value = False Then
                dgvsale.CurrentRow.Cells(6).Value = True
                dgvsale.CurrentRow.Cells(7).Value = 0
                sum_datachange()
            Else
                dgvsale.CurrentRow.Cells(6).Value = False
                sum_datachange()
            End If
        Catch ex As Exception

        End Try

    End Sub
  
    Private Sub dgvsale_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsale.CellEndEdit
        Try
            sum_datachange()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If txtsupname.Text = "" Then
                MessageBox.Show("ກະລຸນາເລືອກລູກຄ້າ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim x As Integer
            x = CInt(txtdiscount.Text)
            Dim y As Integer
            y = CInt(txttotalsale.Text)
            Dim z As Integer
            z = CInt(txtdeposite.Text)
            If x > y Or z > y Then
                MessageBox.Show("ຈໍານວນເງີນທີ່ທ່ານປ້ອນຫຼາຍກົ່ວຈໍານວນຍອດເງີນໃນບິນ")
                txtdiscount.Clear()
                txtdeposite.Clear()
                Exit Sub
            Else

                If rdcash.Checked = True Then
                    payname = "ສົດ"
                Else
                    payname = "ຕິດໜີ້"
                End If

                Dim salename As String
                Dim vath As Double
                Dim frmmain2 As frmmain = DirectCast(Application.OpenForms("frmmain"), frmmain)
                Dim rows As DataRowView = cbsalename.SelectedItem
                Dim row As DataRow = rows.Row
                salename = row(1).ToString
                Dim rows1 As DataRowView = cbtax.SelectedItem
                Dim row1 As DataRow = rows1.Row
                vath = row1(1).ToString
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
                If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກການຂາຍແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Dim autoid As Integer = sale.runsale_id
                    Dim saleNO As String = sale.runsaleNO
                    Dim a As Integer = 0
                    Dim approve As String = "NO"

                    Dim pricetype As String = cbprice.SelectedItem.ToString
                    If rdcash.Checked = True Then

                        'MessageBox.Show(pricetype)
                        sale.savesale(saleNO, autoid, frmmain2.userid, payname, salename, sup_id, txtdiscount.Text, vath, txttotallast.Text, mainmoney, Format(CDate(dtsale.Text), "MM/dd/yyyy"), 5, approve, txtnote.Text, txtlocation.Text, pricetype)
                        sale.savepay(saleNO, txttotallastall.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"), 0, Format(CDate(dtsale.Text), "MM/dd/yyyy"), 5, 1)
                        Dim ids As Integer = saleapprove.runid_saleapprove

                        saleapprove.save(ids, txtid.Text, currentdate, frmmain2.userid)
                    Else

                        nextday.Value = Today.AddDays(txtdaycredit.Text)

                        'MessageBox.Show(frmmain2.userid)

                        sale.savesale(saleNO, autoid, frmmain2.userid, payname, salename, sup_id, txtdiscount.Text, vath, txttotallast.Text, mainmoney, Format(CDate(dtsale.Text), "MM/dd/yyyy"), 5, approve, txtnote.Text, txtlocation.Text, pricetype)
                        sale.savepay(saleNO, txtdeposite.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"), txttotallastall.Text, Format(CDate(nextday.Value), "MM/dd/yyyy"), 5, 7)
                    End If
                    For k As Integer = 0 To dgvsale.Rows.Count - 1

                        If dgvsale.Rows(k).Cells(0).Value Is Nothing Then

                        Else
                            Dim proid1 As String = dgvsale.Rows(k).Cells(0).Value
                            Dim pronamesale As String = dgvsale.Rows(k).Cells(1).Value
                            Dim unitname1 As String = dgvsale.Rows(k).Cells(2).Value
                            Dim pricebuy1 As Double = dgvsale.Rows(k).Cells(11).Value
                            Dim pricesale1 As Double = dgvsale.Rows(k).Cells(3).Value
                            Dim discount1 As Double = dgvsale.Rows(k).Cells(5).Value
                            Dim saleqty As Integer = dgvsale.Rows(k).Cells(4).Value
                            Dim totalcut As Integer = dgvsale.Rows(k).Cells(10).Value
                            Dim totalsale As Double = dgvsale.Rows(k).Cells(7).Value
                            sale.savesaledetail(saleNO, proid1, pronamesale, unitname1, pricebuy1, pricesale1, saleqty, discount1, totalsale, totalcut, bath, dolla)
                            'a += 1
                        End If

                    Next
                    disableform()
                    cbselectbill.SelectedIndex = 0
                    btnedit.Enabled = True
                End If

                Dim counts As Integer = 0
                For i As Integer = 0 To dgvsale.Rows.Count - 1
                    If dgvsale.Rows(i).Cells(0).Value Is Nothing Then
                    Else
                        counts += 1
                    End If
                Next
                txtcount.Text = counts
                '    MessageBox.Show(a)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmsale_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If frmsalelist.rddate.Checked = True Then
                frmsalelist.dgvsalelist.Columns.Clear()
                frmsalelist.dgvsalelist.Rows.Clear()
                frmsalelist.format_salelist()
                dt.Clear()
                sale.viewsale_bydate_datatable(Format(CDate(frmsalelist.dt1.Text), "MM/dd/yyyy"), Format(CDate(frmsalelist.dt2.Text), "MM/dd/yyyy"), frmsalelist.dt)
                For i As Integer = 0 To frmsalelist.dt.Rows.Count - 1
                    Dim idd As String = frmsalelist.dt.Rows(i).Item(0)
                    Dim payname As String = frmsalelist.dt.Rows(i).Item(1)
                    Dim salename As String = frmsalelist.dt.Rows(i).Item(29)
                    Dim buyname As String = frmsalelist.dt.Rows(i).Item(3)
                    Dim discount As Double = frmsalelist.dt.Rows(i).Item(4)
                    Dim vath As Double = frmsalelist.dt.Rows(i).Item(5)
                    Dim totalsale As Double = frmsalelist.dt.Rows(i).Item(6)
                    Dim deposit As Double = frmsalelist.dt.Rows(i).Item(7)
                    Dim notpay As Double = frmsalelist.dt.Rows(i).Item(8)
                    Dim mainmoney As String = frmsalelist.dt.Rows(i).Item(9)
                    Dim saledate As String = frmsalelist.dt.Rows(i).Item(10)
                    Dim status As String = frmsalelist.dt.Rows(i).Item(11)
                    Dim location_install As String = frmsalelist.dt.Rows(i).Item(28)
                    Dim pricetype As String = frmsalelist.dt.Rows(i).Item(30)
                    If status = "ປົກກະຕິ" Then
                        status = False
                    Else
                        status = True
                    End If
                    Dim checkapprove As String = frmsalelist.dt.Rows(i).Item(12)
                    If checkapprove = "YES" Then
                        checkapprove = True
                    Else
                        checkapprove = False
                    End If
                    Dim sup_id As String = frmsalelist.dt.Rows(i).Item(17)
                    Dim note As String = frmsalelist.dt.Rows(i).Item(19)
                    Dim datecredit As Integer = frmsalelist.dt.Rows(i).Item(23)
                    frmsalelist.dgvsalelist.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, status, checkapprove, sup_id, note, datecredit, location_install, pricetype)
                Next
            ElseIf frmsalelist.rdno.Checked = True Then
                frmsalelist.dgvsalelist.Columns.Clear()
                frmsalelist.dgvsalelist.Rows.Clear()
                frmsalelist.format_salelist()
                frmsalelist.dt.Clear()
                sale.viewsale_bysaleNO(frmsalelist.txtsearch.Text, frmsalelist.dt)
                For i As Integer = 0 To frmsalelist.dt.Rows.Count - 1
                    Dim idd As String = frmsalelist.dt.Rows(i).Item(0)
                    Dim payname As String = frmsalelist.dt.Rows(i).Item(1)
                    Dim salename As String = frmsalelist.dt.Rows(i).Item(29)
                    Dim buyname As String = frmsalelist.dt.Rows(i).Item(3)
                    Dim discount As Double = frmsalelist.dt.Rows(i).Item(4)
                    Dim vath As Double = frmsalelist.dt.Rows(i).Item(5)
                    Dim totalsale As Double = frmsalelist.dt.Rows(i).Item(6)
                    Dim deposit As Double = frmsalelist.dt.Rows(i).Item(7)
                    Dim notpay As Double = frmsalelist.dt.Rows(i).Item(8)
                    Dim mainmoney As String = frmsalelist.dt.Rows(i).Item(9)
                    Dim saledate As String = frmsalelist.dt.Rows(i).Item(10)
                    Dim status As String = frmsalelist.dt.Rows(i).Item(11)
                    Dim location_install As String = frmsalelist.dt.Rows(i).Item(28)
                    Dim pricetype As String = frmsalelist.dt.Rows(i).Item(30)
                    If status = "ປົກກະຕິ" Then
                        status = False
                    Else
                        status = True
                    End If
                    Dim checkapprove As String = frmsalelist.dt.Rows(i).Item(12)
                    If checkapprove = "YES" Then
                        checkapprove = True
                    Else
                        checkapprove = False
                    End If
                    Dim sup_id As String = frmsalelist.dt.Rows(i).Item(17)
                    Dim note As String = frmsalelist.dt.Rows(i).Item(19)
                    Dim datecredit As Integer = frmsalelist.dt.Rows(i).Item(23)
                    frmsalelist.dgvsalelist.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, status, checkapprove, sup_id, note, datecredit, location_install, pricetype)
                Next
            ElseIf frmsalelist.rdcustomer.Checked = True Then
                frmsalelist.dgvsalelist.Columns.Clear()
                frmsalelist.dgvsalelist.Rows.Clear()
                frmsalelist.format_salelist()
                frmsalelist.dt.Clear()
                sale.viewsale_bysaleNO(frmsalelist.txtsearch.Text, frmsalelist.dt)
                For i As Integer = 0 To frmsalelist.dt.Rows.Count - 1
                    Dim idd As String = frmsalelist.dt.Rows(i).Item(0)
                    Dim payname As String = frmsalelist.dt.Rows(i).Item(1)
                    Dim salename As String = frmsalelist.dt.Rows(i).Item(29)
                    Dim buyname As String = frmsalelist.dt.Rows(i).Item(3)
                    Dim discount As Double = frmsalelist.dt.Rows(i).Item(4)
                    Dim vath As Double = frmsalelist.dt.Rows(i).Item(5)
                    Dim totalsale As Double = frmsalelist.dt.Rows(i).Item(6)
                    Dim deposit As Double = frmsalelist.dt.Rows(i).Item(7)
                    Dim notpay As Double = frmsalelist.dt.Rows(i).Item(8)
                    Dim mainmoney As String = frmsalelist.dt.Rows(i).Item(9)
                    Dim saledate As String = frmsalelist.dt.Rows(i).Item(10)
                    Dim status As String = frmsalelist.dt.Rows(i).Item(11)
                    Dim location_install As String = frmsalelist.dt.Rows(i).Item(28)
                    Dim pricetype As String = frmsalelist.dt.Rows(i).Item(30)
                    If status = "ປົກກະຕິ" Then
                        status = False
                    Else
                        status = True
                    End If
                    Dim checkapprove As String = frmsalelist.dt.Rows(i).Item(12)
                    If checkapprove = "YES" Then
                        checkapprove = True
                    Else
                        checkapprove = False
                    End If
                    Dim sup_id As String = frmsalelist.dt.Rows(i).Item(17)
                    Dim note As String = frmsalelist.dt.Rows(i).Item(19)
                    Dim datecredit As Integer = frmsalelist.dt.Rows(i).Item(23)
                    frmsalelist.dgvsalelist.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, status, checkapprove, sup_id, note, datecredit, location_install, pricetype)
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        enableform()
        'cbprice.SelectedIndex = 0
        btnsave.Enabled = False
        btnupdate.Enabled = True
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try
            If cbselectbill.SelectedIndex < 0 Then
                MessageBox.Show("ກະລຸນາເລືອກລາຍການທີ່ທ່ານຕ້ອງການອອກໃບບິນກ່ອນ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim checksaleNO As String = sale.Check_existsaleNO(txtid.Text)
                If checksaleNO = "false" Then
                Else
                    If cbselectbill.SelectedItem.ToString = "ໃບຮັບເງີນສົດ" Then

                        frmbillcash.ShowDialog()

                    ElseIf cbselectbill.SelectedItem.ToString = "ໃບສົ່ງເຄືອງ" Then
                        frmbilldevery.ShowDialog()
                    Else
                        frmbillquotation.ShowDialog()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            Dim x As Integer
            x = CInt(txtdiscount.Text)
            Dim y As Integer
            y = CInt(txttotalsale.Text)
            Dim z As Integer
            z = CInt(txtdeposite.Text)
            If x > y Or z > y Then
                MessageBox.Show("ຈໍານວນເງີນທີ່ທ່ານປ້ອນຫຼາຍກົ່ວຈໍານວນຍອດເງີນໃນບິນ")
                txtdiscount.Clear()
                txtdeposite.Clear()
                Exit Sub
            Else
                Dim frmmain2 As frmmain = DirectCast(Application.OpenForms("frmmain"), frmmain)
                cbsalename.DropDownStyle = ComboBoxStyle.DropDownList
                If txtsupname.Text = "" Then
                    MessageBox.Show("ກະລຸນາເລືອກລູກຄ້າ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                If rdcash.Checked = True Then
                    payname = "ສົດ"
                Else
                    payname = "ຕິດໜີ້"
                End If
                Dim pricetype As String = cbprice.SelectedItem.ToString
                Dim salename As String
                Dim vath As Double
                Dim rows As DataRowView = cbsalename.SelectedItem
                Dim row As DataRow = rows.Row
                salename = row(1).ToString

                Dim rows1 As DataRowView = cbtax.SelectedItem
                Dim row1 As DataRow = rows1.Row
                vath = row1(1).ToString

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

                'Dim autoid As Integer = sale.runsale_id
                'Dim saleNO As String = sale.runsaleNO
                Dim a As Integer = 0
                Dim approve As String = "NO"
                If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If rdcash.Checked = True Then
                        'MessageBox.Show(cbprice.Text)
                        'sale.savesale(saleNO, autoid, frmmain2.userid, payname, salename, sup_id, txtdiscount.Text, vath, txttotallast.Text, mainmoney, Format(CDate(dtsale.Text), "MM/dd/yyyy"), 5, approve, txtnote.Text, txtlocation.Text, pricetype)
                        sale.update_sale(txtid.Text, frmmain2.userid, payname, salename, sup_id, txtdiscount.Text, vath, txttotallast.Text, mainmoney, txtnote.Text, txtlocation.Text, pricetype)
                        sale.Delete_saledetail(txtid.Text)
                        pays.deletepay(txtid.Text)
                        sale.savepay(txtid.Text, txtdeposite.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"), txttotallast.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"), 5, 1)

                    Else
                        'Dim nextday As New DateTimePicker
                        nextday.Value = Today.AddDays(txtdaycredit.Text)
                        'MessageBox.Show(cbprice.Text)
                        sale.update_sale(txtid.Text, frmmain2.userid, payname, salename, sup_id, txtdiscount.Text, vath, txttotallast.Text, mainmoney, txtnote.Text, txtlocation.Text, pricetype)
                        sale.Delete_saledetail(txtid.Text)
                        pays.deletepay(txtid.Text)
                        sale.savepay(txtid.Text, txtdeposite.Text, Format(CDate(dtsale.Text), "MM/dd/yyyy"), txttotallastall.Text, Format(CDate(nextday.Value), "MM/dd/yyyy"), 5, 1)
                    End If
                    For k As Integer = 0 To dgvsale.Rows.Count - 1
                        If dgvsale.Rows(k).Cells(0).Value Is Nothing Then
                        Else
                            Dim proid1 As String = dgvsale.Rows(k).Cells(0).Value
                            Dim pronamesale As String = dgvsale.Rows(k).Cells(1).Value
                            Dim unitname1 As String = dgvsale.Rows(k).Cells(2).Value
                            Dim pricebuy1 As Double = dgvsale.Rows(k).Cells(11).Value
                            Dim pricesale1 As Double = dgvsale.Rows(k).Cells(3).Value
                            Dim discount1 As Double = dgvsale.Rows(k).Cells(5).Value
                            Dim saleqty As Integer = dgvsale.Rows(k).Cells(4).Value
                            Dim totalcut As Integer = dgvsale.Rows(k).Cells(10).Value
                            Dim totalsale As Double = dgvsale.Rows(k).Cells(7).Value
                            sale.savesaledetail(txtid.Text, proid1, pronamesale, unitname1, pricebuy1, pricesale1, saleqty, discount1, totalsale, totalcut, bath, dolla)
                            'a += 1
                        End If

                    Next
                End If
                disableform()
                cbselectbill.SelectedIndex = 0

                Dim counts As Integer = 0
                For i As Integer = 0 To dgvsale.Rows.Count - 1
                    If dgvsale.Rows(i).Cells(0).Value Is Nothing Then
                    Else
                        counts += 1
                    End If
                Next
                txtcount.Text = counts
                '    MessageBox.Show(a)
                End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnapprove_Click(sender As Object, e As EventArgs) Handles btnapprove.Click
        Dim salesubitem As New tbsalesubitem
        Dim subitemdt As New DataTable
        subitemdt.Clear()
        salesubitem.select_subitemdetail(txtid.Text, subitemdt)
        Dim frmmain3 As frmmain = DirectCast(Application.OpenForms("frmmain"), frmmain)
        Dim receive As New tbreceive
        Dim checksaleNO As String = sale.Check_existsaleNO(txtid.Text)
        If checksaleNO = "false" Then

        Else
            If subitemdt.Rows.Count > 0 Then
                For a As Integer = 0 To subitemdt.Rows.Count - 1
                    Dim proid As String = subitemdt.Rows(a).Item(2)
                    Dim Name As String = subitemdt.Rows(a).Item(3)
                    Dim stockqtycall As Integer = product.Callstock_qty(proid)
                    If stockqtycall < subitemdt.Rows(a).Item(10) Then

                        MessageBox.Show("ທ່ານບໍ່ສາມາດອອກບິນຂາຍໄດ້ ກະລຸນາກວດສອບຈໍານວນສີນຄ້າລະຫັດ: " + proid + " ຊື່: " + Name, "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    End If
                Next
            End If
         
            'For k As Integer = 0 To dgvsale.Rows.Count - 1
            '    'MessageBox.Show(dgvsale.Rows(k).Cells(10).Value)
            '    If dgvsale.Rows(k).Cells(12).Value = 1 Then
            '        Dim productid As String = dgvsale.Rows(k).Cells(0).Value
            '        Dim callstockqty As Integer = product.Callstock_qty(productid)
            '        'MessageBox.Show(dgvsale.Rows(k).Cells(10).Value)
            '        If callstockqty < dgvsale.Rows(k).Cells(10).Value Then
            '            MessageBox.Show("ຂໍໂທດລາຍການສີນຄ້າໃນບີນນີ້ມີຈໍານວນຫລາຍກວ່າສີນຄ້າໃນສາງ, ທ່ານບໍ່ສາມາດອະນຸມັດການຂາຍໄດ້, ກະລຸນາກວດສອບຈໍານວນສີນຄ້າຄືນ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '            Exit Sub
            '        End If
            '    End If
            'Next

            If MessageBox.Show("ທ່ານຕ້ອງການອະນຸມັດການຂາຍແທ້ບໍ່, ກົດ OK ເພື່ອຍອມຮັບການຕັດສະຕ໋ອກ ?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                sale.update_saleapprove(txtid.Text)
                Dim ids As Integer = saleapprove.runid_saleapprove
                saleapprove.save(ids, txtid.Text, currentdate, frmmain3.userid)



                'For i As Integer = 0 To dgvsale.Rows.Count - 1
                '    If dgvsale.Rows(i).Cells(0).Value Is Nothing Then

                '    Else
                '        Dim proid1 As String = dgvsale.Rows(i).Cells(0).Value
                '        Dim totalcut As Integer = dgvsale.Rows(i).Cells(10).Value
                '        Dim stockqty As Integer = product.Callstock_qty(proid1)
                '        Dim updatestock As Integer = stockqty - totalcut
                '        product.updateStock(proid1, updatestock)

                '        'update balance cut'
                '        Dim dtbalancecut As New DataTable
                '        dtbalancecut.Clear()
                '        receive.call_balace_cut(proid1, dtbalancecut)
                '        If dtbalancecut.Rows.Count = 1 Then
                '            Dim detailid1 As Integer = dtbalancecut.Rows(0).Item(2)
                '            Dim a1 As Integer = dtbalancecut.Rows(0).Item(1)
                '            Dim c As Integer = a1
                '            If a1 >= totalcut Then
                '                Dim qcut1 As Integer = a1 - totalcut
                '                receive.update_balance_cut(detailid1, qcut1)
                '            End If
                '        ElseIf dtbalancecut.Rows.Count > 1 Then
                '            Dim detailid1 As Integer = dtbalancecut.Rows(0).Item(2)
                '            Dim detailid2 As Integer = dtbalancecut.Rows(1).Item(2)
                '            Dim a1 As Integer = dtbalancecut.Rows(0).Item(1)
                '            Dim a2 As Integer = dtbalancecut.Rows(1).Item(1)
                '            Dim c As Integer = a1 + a2
                '            If a1 >= totalcut Then
                '                Dim qcut1 As Integer = a1 - totalcut
                '                receive.update_balance_cut(detailid1, qcut1)
                '            End If
                '            If totalcut > a1 Then
                '                Dim qcut2 As Integer = totalcut - a1
                '                Dim qcut3 As Integer = a2 - qcut2
                '                receive.update_balance_cut(detailid1, 0)
                '                receive.update_balance_cut(detailid2, qcut3)
                '            End If
                '        End If

                '    End If
                'Next

                If subitemdt.Rows.Count > 0 Then
                    For d As Integer = 0 To subitemdt.Rows.Count - 1
                        Dim proid1 As String = subitemdt.Rows(d).Item(2)
                        Dim totalcut As Integer = subitemdt.Rows(d).Item(10)
                        Dim stockqty As Integer = product.Callstock_qty(proid1)
                        Dim updatestock As Integer = stockqty - totalcut
                        If subitemdt.Rows(d).Item(13) = 1 Then
                            product.updateStock(proid1, updatestock)
                        End If
                        'update balance cut'
                        Dim dtbalancecut As New DataTable
                        dtbalancecut.Clear()
                        receive.call_balace_cut(proid1, dtbalancecut)
                        If dtbalancecut.Rows.Count = 1 Then
                            Dim detailid1 As Integer = dtbalancecut.Rows(0).Item(2)
                            Dim a1 As Integer = dtbalancecut.Rows(0).Item(1)
                            Dim c As Integer = a1
                            If a1 >= totalcut Then
                                Dim qcut1 As Integer = a1 - totalcut
                                receive.update_balance_cut(detailid1, qcut1)
                            End If
                        ElseIf dtbalancecut.Rows.Count > 1 Then
                            Dim detailid1 As Integer = dtbalancecut.Rows(0).Item(2)
                            Dim detailid2 As Integer = dtbalancecut.Rows(1).Item(2)
                            Dim a1 As Integer = dtbalancecut.Rows(0).Item(1)
                            Dim a2 As Integer = dtbalancecut.Rows(1).Item(1)
                            Dim c As Integer = a1 + a2
                            If a1 >= totalcut Then
                                Dim qcut1 As Integer = a1 - totalcut
                                receive.update_balance_cut(detailid1, qcut1)
                            End If
                            If totalcut > a1 Then
                                Dim qcut2 As Integer = totalcut - a1
                                Dim qcut3 As Integer = a2 - qcut2
                                receive.update_balance_cut(detailid1, 0)
                                receive.update_balance_cut(detailid2, qcut3)
                            End If
                        End If

                    Next


                End If

                btnapprove.Enabled = False
                btnedit.Enabled = False
                btnupdate.Enabled = False
            End If


        End If

    End Sub

    Private Sub txtdaycredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdaycredit.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim salesubitem As New tbsalesubitem
        Dim subitemdt As New DataTable
        subitemdt.Clear()
        salesubitem.select_subitemdetail(txtid.Text, subitemdt)
        Dim receive As New tbreceive
        If dgvsale.Rows.Count > 0 Then
            If MessageBox.Show("ທ່ານຕ້ອງການຍົກເລີກບີນນີ້ແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                sale.update_Salestatus(txtid.Text, 4)
                Dim idc As Integer = cancelsale.runid
                cancelsale.save(idc, txtid.Text, currentdate)
                For i As Integer = 0 To dgvsale.Rows.Count - 1
                    Dim proid2 As String = dgvsale.Rows(i).Cells(0).Value
                    Dim totalqtycut As Integer = dgvsale.Rows(i).Cells(10).Value
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
                Next

                If subitemdt.Rows.Count > 0 Then
                    For i As Integer = 0 To subitemdt.Rows.Count - 1
                        Dim proid2 As String = subitemdt.Rows(i).Item(2)
                        Dim totalqtycut As Integer = subitemdt.Rows(i).Item(10)
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
                    Next
                End If




                btnapprove.Enabled = False
                btncancel.Enabled = False
            End If

        End If

    End Sub

    Private Sub rdcash_CheckedChanged(sender As Object, e As EventArgs) Handles rdcash.CheckedChanged
        If rdcash.Checked = True Then
            txtdeposite.Enabled = False
            txtdaycredit.Enabled = False
        Else
            txtdeposite.Enabled = True
            txtdaycredit.Enabled = True
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Dim cus As New tbsuppliers
        formsale = True
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
        formsale = False

    End Sub


    Private Sub dgvsale_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvsale.CellMouseClick
        If dgvsale.CurrentRow.Cells(6).Selected = True And dgvsale.CurrentRow.Cells(6).Value = False Then
            dgvsale.CurrentRow.Cells(6).Value = True
            dgvsale.CurrentRow.Cells(7).Value = 0
            sum_datachange()
        ElseIf dgvsale.CurrentRow.Cells(6).Selected = False Then
            sum_datachange()
        Else
            dgvsale.CurrentRow.Cells(6).Value = False
            sum_datachange()
        End If
    End Sub

    Private Sub dgvsale_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsale.CellContentClick

    End Sub

    Private Sub rdkip_CheckedChanged(sender As Object, e As EventArgs) Handles rdkip.CheckedChanged
        If rdkip.Checked = True Then
            mainmoney = "ກີບ"
        ElseIf rdbath.Checked = True Then
            mainmoney = "ບາດ"
        ElseIf rddolla.Checked = True Then
            mainmoney = "ໂດລາ"
        End If
    End Sub

    Private Sub rdbath_CheckedChanged(sender As Object, e As EventArgs) Handles rdbath.CheckedChanged
        If rdkip.Checked = True Then
            mainmoney = "ກີບ"
        ElseIf rdbath.Checked = True Then
            mainmoney = "ບາດ"
        ElseIf rddolla.Checked = True Then
            mainmoney = "ໂດລາ"
        End If
    End Sub

    Private Sub rddolla_CheckedChanged(sender As Object, e As EventArgs) Handles rddolla.CheckedChanged
        If rdkip.Checked = True Then
            mainmoney = "ກີບ"
        ElseIf rdbath.Checked = True Then
            mainmoney = "ບາດ"
        ElseIf rddolla.Checked = True Then
            mainmoney = "ໂດລາ"
        End If
    End Sub

    'Private Sub btnapprove_TextChanged(sender As Object, e As EventArgs) Handles btnapprove.TextChanged
    '    If btnapprove.Enabled = False Then
    '        btnedit.Enabled = False
    '    Else
    '        btnedit.Enabled = True
    '    End If
    'End Sub

    Private Sub cbtax_TextChanged(sender As Object, e As EventArgs) Handles cbtax.TextChanged
        Try
            Dim tax As Double
            Dim rows As DataRowView = cbtax.SelectedItem
            Dim row As DataRow = rows.Row
            Dim totalsale As Double = CDbl(txttotalsale.Text)
            'Dim tem_totalsale As Double = CInt(txttotallast.Text)
            tax = row(1).ToString
            Dim addtax As Double = totalsale + ((tax * totalsale) / 100)

            If cbtax.Text = 0 Then
                txttotallast.Text = totalsale.ToString("N0")
                txt_dispersent.Text = totalsale.ToString("N0")
            Else
                txttotallast.Text = addtax.ToString("N0")
                txt_dispersent.Text = addtax.ToString("N0")
            End If
            'tem_totalsale = addtax
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnew_Click_1(sender As Object, e As EventArgs) Handles btnnew.Click
        'Try
        Dim frmmain As frmmain = DirectCast(Application.OpenForms("frmmain"), frmmain)
        txtsalenameproduct.Text = frmmain.lalaoname.Text
        txtnameaprove.Text = "..."
        enableform()
        formclear()
        dgvsale.Rows.Clear()
        cbprice.SelectedIndex = 0
        dgvsale.ReadOnly = True
        dtsale.Value = Today.Date
        txtid.Text = sale.runsaleNO
        'Dim ids As Integer =
        saleapprove.runid_saleapprove()
        rddebit.Checked = True
        rdbath.Checked = True
        vath.combotax(cbtax)
        cbtax.SelectedValue = 1
        salename.combosalename(cbsalename)
        cbsalename.SelectedValue = 1
        txtdiscount.Text = 0
        txtdeposite.Text = 0
       
        CreateButton(btnSelector)
        dgvsale.Controls.Add(btnSelector)
        txtdaycredit.Text = frmmain.nextpaydate
        btnsave.Enabled = True
        btnapprove.Enabled = True
        If rdcash.Checked = True Then
            Dim supdt As New DataTable
            sup.Select_top1customer(supdt)
            If supdt.Rows.Count > 0 Then
                sup_id = supdt.Rows(0).Item(0)
                txtsupname.Text = supdt.Rows(0).Item(1)
            Else
                MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນລູກຄ້າໜ້າຮ້ານໃຫ້ເປັນລໍາດັບທໍາອິດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If
        For i As Integer = 0 To 10
            dgvsale.Rows.Add()
        Next
        With dgvsale
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(6).ReadOnly = True
        End With
        dgvsale.ReadOnly = True

        txtcount.Text = 0
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Dim checksaleno As String = sale.Check_existsaleNO(txtid.Text)
        If checksaleno = "false" Then

        Else
            frmsalesubitem.ShowDialog()
        End If
    End Sub


    Private Sub btnunapprove_Click(sender As Object, e As EventArgs) Handles btnunapprove.Click
        Dim salesubitem As New tbsalesubitem
        Dim subitemdt As New DataTable
        subitemdt.Clear()
        salesubitem.select_subitemdetail(txtid.Text, subitemdt)
        Dim frmmain3 As frmmain = DirectCast(Application.OpenForms("frmmain"), frmmain)
        Dim receive As New tbreceive
        Dim checksaleNO As String = sale.Check_existsaleNO(txtid.Text)
        If checksaleNO = "false" Then

        Else
            If subitemdt.Rows.Count > 0 Then
                For a As Integer = 0 To subitemdt.Rows.Count - 1
                    Dim proid As String = subitemdt.Rows(a).Item(2)
                    Dim Name As String = subitemdt.Rows(a).Item(3)
                    Dim stockqtycall As Integer = product.Callstock_qty(proid)
                    If stockqtycall < subitemdt.Rows(a).Item(10) Then
                        MessageBox.Show("ທ່ານບໍ່ສາມາດອອກບິນຂາຍໄດ້ ກະລຸນາກວດສອບຈໍານວນສີນຄ້າລະຫັດ: " + proid + " ຊື່: " + Name, "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    End If
                Next
            End If

            If MessageBox.Show("ທ່ານຕ້ອງການຍົກເລີກການອະນຸມັດການຂາຍແທ້ບໍ່, ກົດ OK ເພື່ອຍອມຮັບການຄືນສະຕ໋ອກ ?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                sale.update_saleapprove1(txtid.Text)
                Dim ids As Integer = saleapprove.runid_saleapprove
                approve.delete(txtid.Text)

                If subitemdt.Rows.Count > 0 Then
                    For d As Integer = 0 To subitemdt.Rows.Count - 1
                        Dim proid1 As String = subitemdt.Rows(d).Item(2)
                        Dim totalcut As Integer = subitemdt.Rows(d).Item(10)
                        Dim stockqty As Integer = product.Callstock_qty(proid1)
                        Dim updatestock As Integer = stockqty + totalcut
                        If subitemdt.Rows(d).Item(13) = 1 Then
                            product.updateStock(proid1, updatestock)
                        End If
                        'update balance cut'
                        Dim dtbalancecut As New DataTable
                        dtbalancecut.Clear()
                        receive.call_balace_cut(proid1, dtbalancecut)
                        If dtbalancecut.Rows.Count = 1 Then
                            Dim detailid1 As Integer = dtbalancecut.Rows(0).Item(2)
                            Dim a1 As Integer = dtbalancecut.Rows(0).Item(1)
                            Dim c As Integer = a1
                            If a1 >= totalcut Then
                                Dim qcut1 As Integer = a1 + totalcut
                                receive.update_balance_cut(detailid1, qcut1)
                            End If
                        ElseIf dtbalancecut.Rows.Count > 1 Then
                            Dim detailid1 As Integer = dtbalancecut.Rows(0).Item(2)
                            Dim detailid2 As Integer = dtbalancecut.Rows(1).Item(2)
                            Dim a1 As Integer = dtbalancecut.Rows(0).Item(1)
                            Dim a2 As Integer = dtbalancecut.Rows(1).Item(1)
                            Dim c As Integer = a1 + a2
                            If a1 >= totalcut Then
                                Dim qcut1 As Integer = a1 + totalcut
                                receive.update_balance_cut(detailid1, qcut1)
                            End If
                            If totalcut > a1 Then
                                Dim qcut2 As Integer = totalcut + a1
                                Dim qcut3 As Integer = a2 + qcut2
                                receive.update_balance_cut(detailid1, 0)
                                receive.update_balance_cut(detailid2, qcut3)
                            End If
                        End If
                    Next
                End If
                btnapprove.Enabled = True
                btnunapprove.Enabled = False
                btnedit.Enabled = True
                btnupdate.Enabled = True
            End If
        End If
    End Sub


    Private Sub dgvsale_CellStyleChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsale.CellStyleChanged
        Try
            sum_datachange()
            discount()
            pricetax()
            deposit()
        Catch ex As Exception

        End Try

    End Sub
End Class