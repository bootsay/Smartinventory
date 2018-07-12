Public Class frmreturnproduct
    Dim returnproduct As New tbreturnproduct
    Dim vath As New tbtax
    Dim sale As New tbsales
    Dim exch As New tbexchange
    Dim pays As New tbpay
    Public formreturnproduct As Boolean = False
    Dim tem_totalsale As Double
    Public sup_id As String
    Dim frmmain As frmmain = CType(Application.OpenForms("frmmain"), frmmain)
    Public mainmoney As String
    Public payname As String
    Public dt As New DataTable
    Private pCase As Integer
    Public proid As String
    Public unitname As String
    Public statusnote As String
    Private Sub frmsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If frmmain.UserAuthentication = "" Then
                btncancel.Enabled = False
            Else
                Dim btncancel1 As String = "F"
                btncancel1 = frmmain.UserAuthentication.Substring(34, 1)
                If btncancel1 = "T" Then
                    btncancel.Enabled = True
                Else
                    btncancel.Visible = False
                End If
            End If

            dgvreturn.Columns.Clear()
            dgvreturn.Rows.Clear()
            If frmreturnproductlist.formreturn = True Then
                Makecolumns()
                dgvreturn.Rows.Clear()
                dt.Clear()
                returnproduct.viewreturndetail(frmreturnproductlist.dgvsalelist.CurrentRow.Cells(0).Value, dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim proid As String = dt.Rows(i).Item(1)
                    Dim proname As String = dt.Rows(i).Item(2)
                    Dim unitname3 As String = dt.Rows(i).Item(3)
                    Dim qty2 As Integer = dt.Rows(i).Item(4)
                    Dim problem2 As String = dt.Rows(i).Item(5)
                    Dim total2 As Double = dt.Rows(i).Item(6)
                    dgvreturn.Rows.Add(proid, proname, unitname3, qty2, problem2, total2)
                Next
                Dim sum1 As Double
                For i As Integer = 0 To dgvreturn.Rows.Count - 1
                    sum1 += dgvreturn.Rows(i).Cells(5).Value
                Next
                If frmreturnproductlist.dgvsalelist.CurrentRow.Cells(7).Value = True And frmreturnproductlist.dgvsalelist.CurrentRow.Cells(8).Value = False Then
                    statusnote = "ຍົກເລີກ"
                    btncancel.Enabled = False
                    btnreceive.Enabled = False
                ElseIf frmreturnproductlist.dgvsalelist.CurrentRow.Cells(7).Value = True And frmreturnproductlist.dgvsalelist.CurrentRow.Cells(8).Value = True Then
                    statusnote = "ຍົກເລີກ"
                    btncancel.Enabled = False
                    btnreceive.Enabled = False
                ElseIf frmreturnproductlist.dgvsalelist.CurrentRow.Cells(7).Value = False And frmreturnproductlist.dgvsalelist.CurrentRow.Cells(8).Value = False Then
                    statusnote = "ຍັງບໍ່ໄດ້ຮັບສີນຄ້າ"
                    btncancel.Enabled = True
                    btnreceive.Enabled = True
                ElseIf frmreturnproductlist.dgvsalelist.CurrentRow.Cells(7).Value = False And frmreturnproductlist.dgvsalelist.CurrentRow.Cells(8).Value = True Then
                    statusnote = "ຮັບສີນຄ້າແລ້ວ"
                    btncancel.Enabled = True
                    btnreceive.Enabled = False
                End If
                txtorderNO.Text = frmreturnproductlist.dgvsalelist.CurrentRow.Cells(0).Value
                dt1.Text = frmreturnproductlist.dgvsalelist.CurrentRow.Cells(5).Value
                dtget.Text = frmreturnproductlist.dgvsalelist.CurrentRow.Cells(6).Value
                txttotallast.Text = sum1.ToString("N0")
                enableedit()
            Else
                enablesave()
                statusnote = "ຍັງບໍ່ໄດ້ຮັບສີນຄ້າ"
            End If



        Catch ex As Exception

        End Try
    End Sub
    Private Sub enableform()

        txtproblem.Enabled = True
        btnsave.Enabled = True
        btnclear.Enabled = True
        btnminus.Enabled = True
        dgvreturn.Enabled = True
    End Sub
    Private Sub disableform()

        txtproblem.Enabled = False
        btnsave.Enabled = False
        btnclear.Enabled = False
        btnminus.Enabled = False

        dgvreturn.Enabled = False
    End Sub
    Private Sub formclear()
        txtorderNO.Clear()
        txtproblem.Clear()
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
        Dim qty As New DataGridViewTextBoxColumn()
        Dim problem As New DataGridViewTextBoxColumn()
        Dim valuefix As New DataGridViewTextBoxColumn()
        dgvreturn.Columns.Add(id)
        dgvreturn.Columns.Add(name)
        dgvreturn.Columns.Add(unit)
        dgvreturn.Columns.Add(qty)
        dgvreturn.Columns.Add(problem)
        dgvreturn.Columns.Add(valuefix)
        With dgvreturn
            .Columns(0).HeaderText = "ລະຫັດສິນຄ້າ"
            .Columns(1).HeaderText = "ລາຍການ"
            .Columns(2).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(3).HeaderText = "ຈໍານວນ"
            .Columns(4).HeaderText = "ບັນຫາ"
            .Columns(5).HeaderText = "ຄ່າສ້ອມແປງ"
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        
        End With
   

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
                    formreturnproduct = True
                    frmshowproductsale.ShowDialog()
                    With dgvreturn
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
                    formreturnproduct = False
                    pCase = 0
                    Exit Select
                End If
            Case 2
                If True Then
                    formreturnproduct = True
                    frmshowunit.ShowDialog()
                    formreturnproduct = False
                    Exit Select
                End If
        End Select
    End Sub

    Private Sub btnbrown_Click(sender As Object, e As EventArgs) Handles btnbrown.Click
        formreturnproduct = True
        frmshowcustomer.ShowDialog()
        frmshowcustomer.Close()
        formreturnproduct = False
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
    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvsale_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvreturn.EditingControlShowing
        Try
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
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



    Private Sub btnadd_Click(sender As Object, e As EventArgs)
        Try
            dgvreturn.Rows.Add()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnew_Click_1(sender As Object, e As EventArgs) Handles btnnew.Click
        Try
            dgvreturn.Columns.Clear()
            dgvreturn.Rows.Clear()
            txtorderNO.Text = returnproduct.run_runNO
            txtproblem.Select()
            Makecolumns()
            dgvreturn.ReadOnly = True
            enablesave()
            btncancel.Enabled = True
            btnreceive.Enabled = True
            dtget.Value = Today.AddDays(30)
            sum_datachange()
            txtproblem.Select()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        Try
            If dgvreturn.SelectedCells.Count > 0 Then
                dgvreturn.Rows.RemoveAt(dgvreturn.CurrentRow.Index)
                sum_datachange()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Try
            dgvreturn.Rows.Clear()
            sum_datachange()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnfree_Click(sender As Object, e As EventArgs)
        Try
            If dgvreturn.CurrentRow.Cells(6).Selected = True And dgvreturn.CurrentRow.Cells(6).Value = False Then
                dgvreturn.CurrentRow.Cells(6).Value = True
                dgvreturn.CurrentRow.Cells(7).Value = 0
                sum_datachange()
            Else
                dgvreturn.CurrentRow.Cells(6).Value = False
                sum_datachange()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub sum_datachange()
        Dim totalsale As Double
        For i As Integer = 0 To dgvreturn.Rows.Count - 1
            totalsale += dgvreturn.Rows(i).Cells(5).Value
        Next
        tem_totalsale = totalsale
        txttotallast.Text = totalsale.ToString("N0")
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        'Try
        If txtorderNO.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນໃຫ້ຄົບສາກ່ອນ")
            Exit Sub
        End If
        If txtsupname.Text = "" Then
            MessageBox.Show("ກະລູນາປ້ອນຂໍ້ມູນຜູ້ສະໜອງກ່ອນ")
            txtsupname.Focus()
            Exit Sub
        End If
        If dgvreturn.Rows.Count < 1 Then
            MessageBox.Show("ກະລຸນາເພີ້ມລາຍການຂາຍ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

            Dim returnautoid As Integer = returnproduct.returnautoid
            Dim returnNO As String = returnproduct.run_runNO
            Dim approve As String = "NO"
            Dim sentstatus As String = "NO"
            returnproduct.savereturn(returnNO, returnautoid, frmmain.userid, sup_id, txttotallast.Text, txtnote.Text, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dtget.Text), "MM/dd/yyy"), 5, approve, sentstatus)
            For i As Integer = 0 To dgvreturn.Rows.Count - 1
                Dim returndetailid As Integer
                returndetailid = returnproduct.auto_returndetailid
                Dim proid As String = dgvreturn.Rows(i).Cells(0).Value
                Dim unitname2 As String = dgvreturn.Rows(i).Cells(2).Value
                Dim returnqty As Integer = dgvreturn.Rows(i).Cells(3).Value
                Dim returnproblem As String = dgvreturn.Rows(i).Cells(4).Value
                Dim totalfix As Double = dgvreturn.Rows(i).Cells(5).Value
                returnproduct.savereturndetail(returndetailid, returnNO, proid, unitname2, returnqty, returnproblem, totalfix)
            Next
            enablesave()
            btnsave.Enabled = False
            dgvreturn.ReadOnly = True

        End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub frmsale_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
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
            Dim checksaleNO As String = returnproduct.Check_existreturnNO(txtorderNO.Text)
            If checksaleNO = "false" Then

            Else
                frmbillreturnproduct.ShowDialog()
                frmbillreturnproduct.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim ddt As New DataTable
        returnproduct.viewreturndetail(txtorderNO.Text, ddt)
        If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງລາຍການແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            returnproduct.updatereturn(txtorderNO.Text, sup_id, txttotallast.Text, txtnote.Text, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dtget.Text), "MM/dd/yyy"), 5, "NO")
            If ddt.Rows.Count > 0 Then
                For i As Integer = 0 To ddt.Rows.Count - 1
                    Dim orderdetailid As Integer = ddt.Rows(i).Item(10)
                    returnproduct.delete_returndetail(orderdetailid)
                Next
            End If
          For i As Integer = 0 To dgvreturn.Rows.Count - 1
                Dim returndetailid As Integer
                returndetailid = returnproduct.auto_returndetailid
                Dim proid As String = dgvreturn.Rows(i).Cells(0).Value
                Dim unitname2 As String = dgvreturn.Rows(i).Cells(2).Value
                Dim returnqty As Integer = dgvreturn.Rows(i).Cells(3).Value
                Dim returnproblem As String = dgvreturn.Rows(i).Cells(4).Value
                Dim totalfix As Double = dgvreturn.Rows(i).Cells(5).Value
                returnproduct.savereturndetail(returndetailid, txtorderNO.Text, proid, unitname2, returnqty, returnproblem, totalfix)
            Next
            enablesave()
            dgvreturn.ReadOnly = True
        End If

    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtamount_TextChanged(sender As Object, e As EventArgs) Handles txtamount.TextChanged
        Try
            Dim tem As Double = txtamount.Text
            txtamount.Text = tem.ToString("N0")
            txtamount.SelectionStart = txtamount.TextLength


        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnbrwown_Click(sender As Object, e As EventArgs) Handles btnbrwown.Click
        formreturnproduct = True
        frmshowproduct.ShowDialog()
        frmshowproduct.Close()
        formreturnproduct = False
    End Sub

    Private Sub txtadd_Click(sender As Object, e As EventArgs) Handles txtadd.Click
        Try
            If txtproduct.Text = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ຂໍ້ມູນເລືອກສີນຄ້າ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtproduct.Select()
                Return
            End If
            If txtproblem.Text = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ບັນຫາ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtproduct.Select()
                Return
            End If
            If txtnote.Text = "" Then
                txtnote.Text = "."
            End If
            If txtamount.Text = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ມູນຄ່າຊ້ອມແປງ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK)
                txtamount.Select()
                Return
            End If
            If txtqty.Text = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK)
                txtqty.Select()
                Return
            End If
            dgvreturn.Rows.Add(proid, txtproduct.Text, unitname, txtqty.Text, txtproblem.Text, txtamount.Text)
            sum_datachange()
            txtproduct.Clear()
            txtnote.Clear()
            txtproblem.Clear()
            txtamount.Clear()
            txtqty.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        Dim checksaleNO As String = returnproduct.Check_existreturnNO(txtorderNO.Text)
        If checksaleNO = "false" Then

        Else
            If MessageBox.Show("ທ່ານຕ້ອງການຍົກເລີກບີນນີ້ແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                returnproduct.Cancel_return(txtorderNO.Text)
                btncancel.Enabled = False
            End If
            End If



    End Sub

    Private Sub btnreceive_Click(sender As Object, e As EventArgs) Handles btnreceive.Click

        Dim checksaleNO As String = returnproduct.Check_existreturnNO(txtorderNO.Text)
        If checksaleNO = "false" Then

        Else
            If MessageBox.Show("ກະລຸນາກົດປຸ່ມ OK ເພື່ອຢືນຢັນການຮັບສີນຄ້າ?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                returnproduct.Update_approve(txtorderNO.Text)
                btncancel.Enabled = False
            End If
            End If


    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Dim cus As New tbsuppliers
        formreturnproduct = True
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
        formreturnproduct = False
    End Sub
End Class