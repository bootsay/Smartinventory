Public Class frmsalesubitem
    Dim itemid As String
    Dim subsale As New tbsalesubitem
    Public formsalesub As Boolean = False
    Private pCase As Integer
    Private btnSelector As New Button()
    Dim totalsale As Double
    Dim tem_totalsale As Double
    Dim saleNO As String
    Dim totalprice As Double
    Dim mainmoney As String
    Public subdt As New DataTable
    Private rowIndex As Integer = 0
    Private Sub frmsalesubitem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try

        subdt.Clear()
        saleNO = frmsale.txtid.Text
        subsale.select_subitemdetail(saleNO, subdt)
        txtid.Text = frmsale.txtid.Text
        itemid = frmsale.dgvsale.CurrentRow.Cells(0).Value
        txtitemid.Text = frmsale.dgvsale.CurrentRow.Cells(1).Value
        totalprice = frmsale.dgvsale.CurrentRow.Cells(7).Value
        cbprice.SelectedIndex = 2
        If subdt.Rows.Count > 0 Then
            dgvsub.Columns.Clear()
            dgvsub.Rows.Clear()
            saletable(dgvsub)
            For i As Integer = 0 To subdt.Rows.Count - 1
                Dim id As String = subdt.Rows(i).Item(2)
                Dim list As String = subdt.Rows(i).Item(3)
                Dim unit As String = subdt.Rows(i).Item(4)
                Dim saleqty As Double = subdt.Rows(i).Item(7)
                Dim pricesale As Double = subdt.Rows(i).Item(6)
                Dim pricebuy As Double = subdt.Rows(i).Item(5)
                Dim discount As Double = subdt.Rows(i).Item(8)
                Dim totalsale As Double = subdt.Rows(i).Item(9)
                Dim totalqtycut As Integer = subdt.Rows(i).Item(10)
                Dim cutype As Integer = 0
                Dim qtycut As Integer
                If totalqtycut < 1 Then
                    qtycut = 0
                    totalqtycut = 0
                Else
                    qtycut = totalqtycut / saleqty
                End If

                Dim givefree As Boolean = False
             
                dgvsub.Rows.Add(id, list, unit, pricesale, saleqty, discount, givefree, totalsale, "", qtycut, totalqtycut, pricebuy, cutype)
            Next
            sum_datachange()
            btnsale.Enabled = False
            btnupdate.Enabled = False
            btnedit.Enabled = True
        Else
            btnsale.Enabled = True
            btnupdate.Enabled = False
            btnedit.Enabled = False
            dgvsub.Columns.Clear()
            dgvsub.Rows.Clear()
            saletable(dgvsub)
            For i As Integer = 0 To 7
                dgvsub.Rows.Add()
            Next
            CreateButton(btnSelector)
            dgvsub.Controls.Add(btnSelector)
            cbprice.SelectedIndex = 1

        End If
        Dim counts As Integer = 0
        For i As Integer = 0 To dgvsub.Rows.Count - 1
            If dgvsub.Rows(i).Cells(0).Value Is Nothing Then
            Else
                counts += 1
            End If
        Next
        txtcount.Text = counts
        'Catch ex As Exception

        'End Try
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
                    formsalesub = True
                        frmshowproductsale.ShowDialog()
                    With dgvsub
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
                    formsalesub = False
                    sum_datachange()
                    pCase = 0

                    Dim counts As Integer = 0
                    For i As Integer = 0 To dgvsub.Rows.Count - 1
                        If dgvsub.Rows(i).Cells(0).Value Is Nothing Then
                        Else
                            counts += 1
                        End If
                    Next
                    txtcount.Text = counts


                        Exit Sub

                    Exit Select
                End If
            Case 2
                If True Then
                    formsalesub = True
                    frmshowunit.ShowDialog()
                    formsalesub = False
                    Exit Sub
                    Exit Select
                End If
        End Select
    End Sub
    Private Sub saletable(dgvsale As DataGridView)
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
        With dgvsale
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ລາຍການ"
            .Columns(2).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(3).HeaderText = "ລາຄາ"
            .Columns(4).HeaderText = "ຈໍານວນ"
            .Columns(5).HeaderText = "ລຸດ"
            .Columns(6).Visible = False ' free'
            .Columns(7).HeaderText = "ລວມ"
            .Columns(8).Visible = False ' option'
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns(8).Visible = False
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns(6).Width = 40
            '.Columns(7).Width = 150
        End With
    End Sub

    Private Sub dgvsub_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsub.CellEnter
        If dgvsub.CurrentRow.Cells(1).Selected = True Then
            pCase = 1
            Dim Loc As Rectangle = dgvsub.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
            Dim Wid As Integer = dgvsub.CurrentCell.Size.Width
            btnSelector.Location = New Point(Loc.X - 30 + Wid, Loc.Y)
            btnSelector.Show()

        ElseIf dgvsub.CurrentRow.Cells(2).Selected = True Then
            pCase = 2
            Dim Loc As Rectangle = dgvsub.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
            Dim Wid As Integer = dgvsub.CurrentCell.Size.Width
            btnSelector.Location = New Point(Loc.X - 30 + Wid, Loc.Y)
            btnSelector.Show()
        Else

            btnSelector.Hide()
        End If
    End Sub

    Private Sub dgvsub_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsub.CellClick
        Try
            If dgvsub.CurrentRow.Cells(3).Selected = True Or dgvsub.CurrentRow.Cells(4).Selected = True Or dgvsub.CurrentRow.Cells(5).Selected = True Then
                dgvsub.ReadOnly = False
                dgvsub.BeginEdit(True)
            Else
                dgvsub.ReadOnly = True
                dgvsub.EndEdit(True)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub sum_datachange()
        totalsale = 0
        For i As Integer = 0 To dgvsub.Rows.Count - 1
            If dgvsub.Rows(i).Cells(6).Value = True Then
                dgvsub.Rows(i).Cells(7).Value = 0
            Else
                Dim a As Integer = dgvsub.Rows(i).Cells(4).Value
                Dim discount As Double = dgvsub.Rows(i).Cells(5).Value
                Dim qtycut As Integer = dgvsub.Rows(i).Cells(9).Value
                Dim price As Double = dgvsub.Rows(i).Cells(3).Value
                Dim total As Double = (a * price) - discount
                dgvsub.Rows(i).Cells(7).Value = total
                dgvsub.Rows(i).Cells(10).Value = a * qtycut
                With dgvsub
                    .Columns(3).DefaultCellStyle.Format = "N0"
                    .Columns(4).DefaultCellStyle.Format = "N0"
                    .Columns(7).DefaultCellStyle.Format = "N0"
                    .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    totalsale += dgvsub.Rows(i).Cells(7).Value
                End With

            End If
        Next
        tem_totalsale = totalsale
        txttotallast.Text = totalsale.ToString("N0")
    End Sub

    Private Sub dgvsub_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsub.CellEndEdit
        Try
            sum_datachange()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        Try
            dgvsub.Rows.RemoveAt(dgvsub.CurrentRow.Index)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try

            dgvsub.Rows.Add()
            CreateButton(btnSelector)
            dgvsub.Controls.Add(btnSelector)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Try
            dgvsub.Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsale_Click(sender As Object, e As EventArgs) Handles btnsale.Click

        If dgvsub.Rows.Count < 1 Then
            Return
        End If
        If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກການລາຍການຍ່ອຍແທ້ບໍ່", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            If frmsale.rdkip.Checked = True Then
                mainmoney = "ກີບ"
            ElseIf frmsale.rdbath.Checked = True Then
                mainmoney = "ບາດ"
            ElseIf frmsale.rddolla.Checked = True Then
                mainmoney = "ໂດລາ"

            End If
            Dim bath As Double = frmmain.labath.Text
            Dim dolla As Double = frmmain.ladolla.Text
            Dim dt1 As New DateTimePicker
            dt1.Value = Today.Date
            Dim saleNO As String = txtid.Text
            Dim proid As String = dgvsub.CurrentRow.Cells(0).Value
            'MessageBox.Show(saleNO)
            'MessageBox.Show(proid)
            subsale.savesalesubitem(saleNO, 0, 0, mainmoney, Format(CDate(dt1.Value), "MM/dd/yyyy"), 5)
            For i As Integer = 0 To dgvsub.Rows.Count - 1
                If dgvsub.Rows(i).Cells(0).Value Is Nothing Then

                Else
                    Dim proid1 As String = dgvsub.Rows(i).Cells(0).Value
                    Dim pronamesale As String = dgvsub.Rows(i).Cells(1).Value
                    Dim unitname1 As String = dgvsub.Rows(i).Cells(2).Value
                    Dim pricebuy1 As Double = dgvsub.Rows(i).Cells(11).Value
                    Dim pricesale1 As Double = dgvsub.Rows(i).Cells(3).Value
                    Dim discount1 As Double = dgvsub.Rows(i).Cells(5).Value
                    Dim saleqty As Integer = dgvsub.Rows(i).Cells(4).Value
                    Dim totalcut As Integer = dgvsub.Rows(i).Cells(10).Value
                    Dim totalsale As Double = dgvsub.Rows(i).Cells(7).Value
                    subsale.savesaleitemdetail(saleNO, proid1, pronamesale, unitname1, pricebuy1, pricesale1, saleqty, discount1, totalsale, totalcut, bath, dolla)
                    'a += 1
                End If
            Next
            btnsale.Enabled = False
            btnedit.Enabled = True
            btnupdate.Enabled = False
            dgvsub.Enabled = False


        End If
        Dim counts As Integer = 0
        For i As Integer = 0 To dgvsub.Rows.Count - 1
            If dgvsub.Rows(i).Cells(0).Value Is Nothing Then
            Else
                counts += 1
            End If
        Next
        txtcount.Text = counts
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim check As String = subsale.check_existsaleNO(txtid.Text)
        If check = "false" Then
            MessageBox.Show("ກະລຸນາບັນທືກລາຍການກ່ອນ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        Else
            frmbillsalesub.ShowDialog()
            frmbillsalesub.Close()
        End If
    End Sub
   
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        btnupdate.Enabled = True
        dgvsub.ReadOnly = False
        dgvsub.Enabled = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtid.Text = "" Then
            MessageBox.Show("please select item from mainlist")
            Return
        End If
        If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງລາຍການແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

            If subdt.Rows.Count > 0 Then
                For i As Integer = 0 To subdt.Rows.Count - 1
                    subsale.delete_subitemdetail(subdt.Rows(i).Item(0))
                    'MessageBox.Show(subdt.Rows(i).Item(0))
                Next
                subsale.delete_subsaleitem(txtid.Text)

                Dim bath As Double = frmmain.labath.Text
                Dim dolla As Double = frmmain.ladolla.Text
                Dim dt1 As New DateTimePicker
                dt1.Value = Today.Date
                Dim proid As String = dgvsub.CurrentRow.Cells(0).Value

                subsale.savesalesubitem(saleNO, proid, totalprice, mainmoney, Format(CDate(dt1.Value), "MM/dd/yyyy"), 5)

                For i As Integer = 0 To dgvsub.Rows.Count - 1
                    If dgvsub.Rows(i).Cells(0).Value Is Nothing Then

                    Else
                        Dim proid1 As String = dgvsub.Rows(i).Cells(0).Value
                        Dim pronamesale As String = dgvsub.Rows(i).Cells(1).Value
                        Dim unitname1 As String = dgvsub.Rows(i).Cells(2).Value
                        Dim pricebuy1 As Double = dgvsub.Rows(i).Cells(11).Value
                        Dim pricesale1 As Double = dgvsub.Rows(i).Cells(3).Value
                        Dim discount1 As Double = dgvsub.Rows(i).Cells(5).Value
                        Dim saleqty As Integer = dgvsub.Rows(i).Cells(4).Value
                        Dim totalcut As Integer = dgvsub.Rows(i).Cells(10).Value
                        Dim totalsale As Double = dgvsub.Rows(i).Cells(7).Value
                        subsale.savesaleitemdetail(saleNO, proid1, pronamesale, unitname1, pricebuy1, pricesale1, saleqty, discount1, totalsale, totalcut, bath, dolla)
                        'a += 1
                    End If
                Next
                btnsale.Enabled = False
                btnedit.Enabled = True
                btnupdate.Enabled = False
                dgvsub.Enabled = False
            Else
                subdt.Clear()
                subsale.select_subitemdetail(saleNO, subdt)
                For k As Integer = 0 To subdt.Rows.Count - 1
                    subsale.delete_subitemdetail(subdt.Rows(k).Item(0))

                Next
                subsale.delete_subsaleitem(txtid.Text)

                Dim bath As Double = frmmain.labath.Text
                Dim dolla As Double = frmmain.ladolla.Text
                Dim dt1 As New DateTimePicker
                dt1.Value = Today.Date
                Dim proid As String = dgvsub.CurrentRow.Cells(0).Value

                subsale.savesalesubitem(saleNO, proid, totalprice, mainmoney, Format(CDate(dt1.Value), "MM/dd/yyyy"), 5)

                For i As Integer = 0 To dgvsub.Rows.Count - 1
                    If dgvsub.Rows(i).Cells(0).Value Is Nothing Then

                    Else
                        Dim proid1 As String = dgvsub.Rows(i).Cells(0).Value
                        Dim pronamesale As String = dgvsub.Rows(i).Cells(1).Value
                        Dim unitname1 As String = dgvsub.Rows(i).Cells(2).Value
                        Dim pricebuy1 As Double = dgvsub.Rows(i).Cells(11).Value
                        Dim pricesale1 As Double = dgvsub.Rows(i).Cells(3).Value
                        Dim discount1 As Double = dgvsub.Rows(i).Cells(5).Value
                        Dim saleqty As Integer = dgvsub.Rows(i).Cells(4).Value
                        Dim totalcut As Integer = dgvsub.Rows(i).Cells(10).Value
                        Dim totalsale As Double = dgvsub.Rows(i).Cells(7).Value
                        subsale.savesaleitemdetail(saleNO, proid1, pronamesale, unitname1, pricebuy1, pricesale1, saleqty, discount1, totalsale, totalcut, bath, dolla)
                        'a += 1
                    End If
                Next
                btnsale.Enabled = False
                btnedit.Enabled = True
                btnupdate.Enabled = False
                dgvsub.Enabled = False
            End If
            Dim counts As Integer = 0
            For i As Integer = 0 To dgvsub.Rows.Count - 1
                If dgvsub.Rows(i).Cells(0).Value Is Nothing Then
                Else
                    counts += 1
                End If
            Next
            txtcount.Text = counts
            subdt.Clear()
        End If

    End Sub

    Private Sub dgvsub_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsub.CellContentClick

    End Sub

    'Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Click
    '    If Not Me.dgvsub.Rows(Me.rowIndex).IsNewRow Then
    '        Me.dgvsub.Rows.RemoveAt(Me.rowIndex)
    '        Me.dgvsub.Rows.RemoveAt(Me.rowIndex)
    '    End If
    'End Sub

    Private Sub TextBox(sender As Object, e As KeyPressEventArgs)
        Throw New NotImplementedException
    End Sub

    'Private Sub dgvsub_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvsub.CellMouseDown
    '    'Try
    '    dgvsub.Columns(0).DefaultCellStyle.Format = "N0"
    '    If e.Button = Windows.Forms.MouseButtons.Right Then
    '        Me.dgvsub.Rows(e.RowIndex).Selected = True
    '        Me.rowIndex = e.RowIndex
    '        Me.dgvsub.CurrentCell = Me.dgvsub.Rows(e.RowIndex).Cells(1)
    '        Me.ContextMenuStrip1.Show(Me.dgvsub, e.Location)
    '        ContextMenuStrip1.Show(Cursor.Position)
    '    End If
    '    'Catch ex As Exception

    '    'End Try
    'End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        dgvsub.Enabled = True
        dgvsub.Rows.Clear()
    End Sub
End Class