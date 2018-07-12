Imports System.Data.SqlClient
Public Class frmdebitcustomerlist
    Dim exch As New tbexchange
    Public proid As Integer
    Private rowIndex As Integer = 0
    Dim order As New tborder
    Dim order1 As New tborder
    Dim productid As New tbproduct
    Dim brands As New tbbrand
    Dim receive As New tbreceive
    Dim totalprice As Double
    Dim orderautoid As Integer
    Public callorderNO As String
    Public formorder As Boolean = False
    Public formorder1 As Boolean = False
    Public sup_id As String
    Public user_id As Integer
    Dim receiveautoid As Integer
    Public formorder_receive As Boolean = False
    Dim cbt As Int16
    Dim cash1 As String = Nothing
    Dim cashpay As String
    Dim bath As Double
    Dim dolla As Double
    Public dgvdetail As New DataTable
    Private pCase As Integer
    Private btnSelector As New Button()
    Dim txtsum1 As New TextBox
    Public dtorder As New DataTable
    Private Sub frmorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bath = exch.loadbaht
        dolla = exch.loaddolla
        txtsum1.Text = 0
        dgvshow.Columns.Clear()
        dgvshow.Rows.Clear()
        Ordercolumns()
        dtorder.Clear()
        order.loadorder_dt(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dtorder, "ຕິດໜີ້", 5)
        'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)
        For i As Integer = 0 To dtorder.Rows.Count - 1
            Dim orderno1 As String = dtorder.Rows(i).Item(0)
            Dim pay As String = dtorder.Rows(i).Item(2)
            Dim ordername As String = dtorder.Rows(i).Item(12)
            Dim buyfrom As String = dtorder.Rows(i).Item(3)
            Dim discount1 As Double = dtorder.Rows(i).Item(4)
            Dim total As Double = dtorder.Rows(i).Item(5)
            Dim totalpay As Double = dtorder.Rows(i).Item(6)
            Dim notpay As Double = dtorder.Rows(i).Item(7)
            Dim saledate1 As String = dtorder.Rows(i).Item(8)

            Dim status As Integer = dtorder.Rows(i).Item(27)
            Dim receive As String = dtorder.Rows(i).Item(11)
            Dim note1 As String = dtorder.Rows(i).Item(9)
            Dim mainmoney As String = dtorder.Rows(i).Item(25)
            Dim sup_id As String = dtorder.Rows(i).Item(24)
            Dim supname As String = dtorder.Rows(i).Item(3)
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
            dgvshow.Rows.Add(orderno1, pay, ordername, buyfrom, discount1, total, totalpay, notpay, saledate1, status, receive, note1, mainmoney, sup_id, supname)
        Next
        rdate.Checked = True
        txtshow.Text = dgvshow.Rows.Count



        'pro.viewpricebuy(dgvproduct)

        'Timer1.Start()
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTabIndex = 1
    End Sub


    Private Sub btnback_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTabIndex = 0
    End Sub

    Private Sub btnclose2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
    Private Sub btnbrown_Click(sender As Object, e As EventArgs)
        formorder = True
        frmshowcustomer.ShowDialog()
        formorder = False
    End Sub
    Public Sub Ordercolumns()
        Dim orderno As New DataGridViewTextBoxColumn
        Dim pay As New DataGridViewTextBoxColumn
        Dim ordername As New DataGridViewTextBoxColumn
        Dim buyfrom As New DataGridViewTextBoxColumn
        Dim discount As New DataGridViewTextBoxColumn
        Dim total As New DataGridViewTextBoxColumn
        Dim totalpay As New DataGridViewTextBoxColumn
        Dim notpay As New DataGridViewTextBoxColumn
        Dim saledate As New DataGridViewTextBoxColumn
        Dim status As New DataGridViewCheckBoxColumn
        Dim receive As New DataGridViewCheckBoxColumn
        Dim note As New DataGridViewTextBoxColumn
        Dim mainmoney As New DataGridViewTextBoxColumn
        Dim supid As New DataGridViewTextBoxColumn
        Dim supname As New DataGridViewTextBoxColumn


        dgvshow.Columns.Add(orderno)
        dgvshow.Columns.Add(pay)

        dgvshow.Columns.Add(ordername)
        dgvshow.Columns.Add(buyfrom)
        dgvshow.Columns.Add(discount)
        dgvshow.Columns.Add(total)
        dgvshow.Columns.Add(totalpay)
        dgvshow.Columns.Add(notpay)
        dgvshow.Columns.Add(saledate)
        dgvshow.Columns.Add(status)
        dgvshow.Columns.Add(receive)
        dgvshow.Columns.Add(note)
        dgvshow.Columns.Add(mainmoney)
        dgvshow.Columns.Add(supid)
        dgvshow.Columns.Add(supname)

        With dgvshow
            .Columns(0).HeaderText = "ເລກບີນ"
            .Columns(1).HeaderText = "ການຈ່າຍ"
            .Columns(2).HeaderText = "ຜູ້ອອກບີນ"
            .Columns(3).HeaderText = "ຊື້ຈາກ"
            .Columns(4).HeaderText = "ສ່ວນລຸດ"
            .Columns(5).HeaderText = "ລວມ"
            .Columns(6).HeaderText = "ຈ່າຍແລ້ວ"
            .Columns(7).HeaderText = "ໜີ້"

            .Columns(8).HeaderText = "ວັນທີ"
            .Columns(9).HeaderText = "ຍົກເລີກ"
            .Columns(10).HeaderText = "ຮັບ"
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(5).DefaultCellStyle.Format = "#,####.00"
            .Columns(6).DefaultCellStyle.Format = "#,####.00"
            .Columns(7).DefaultCellStyle.Format = "#,####.00"
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        End With


    End Sub


    Private Sub btnshowsupplier_Click(sender As Object, e As EventArgs)
        formorder_receive = True
        frmshowcustomer.ShowDialog()
        formorder_receive = False
    End Sub

    Private Sub btnshowproname_Click(sender As Object, e As EventArgs)
        formorder_receive = True
        frmshowproduct.ShowDialog()
        formorder_receive = False
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Try
            If rdate.Checked = True Then
                dgvshow.Columns.Clear()
                dgvshow.Rows.Clear()
                Ordercolumns()
                dtorder.Clear()
                order.loadorder_dt(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dtorder, "ຕິດໜີ້", "ປົກກະຕິ")
                'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)
                For i As Integer = 0 To dtorder.Rows.Count - 1
                    Dim orderno1 As String = dtorder.Rows(i).Item(0)
                    Dim pay As String = dtorder.Rows(i).Item(2)
                    Dim ordername As String = dtorder.Rows(i).Item(12)
                    Dim buyfrom As String = dtorder.Rows(i).Item(3)
                    Dim discount1 As Double = dtorder.Rows(i).Item(4)
                    Dim total As Double = dtorder.Rows(i).Item(5)
                    Dim totalpay As Double = dtorder.Rows(i).Item(6)
                    Dim notpay As Double = dtorder.Rows(i).Item(7)
                    Dim saledate1 As String = dtorder.Rows(i).Item(8)

                    Dim status As Integer = dtorder.Rows(i).Item(27)
                    Dim receive As String = dtorder.Rows(i).Item(11)
                    Dim note1 As String = dtorder.Rows(i).Item(9)
                    Dim mainmoney As String = dtorder.Rows(i).Item(25)
                    Dim sup_id As String = dtorder.Rows(i).Item(24)
                    Dim supname As String = dtorder.Rows(i).Item(3)
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
                    dgvshow.Rows.Add(orderno1, pay, ordername, buyfrom, discount1, total, totalpay, notpay, saledate1, status, receive, note1, mainmoney, sup_id, supname)
                Next
            ElseIf rid.Checked = True Then
                order.vieworder_byid(txtsearch.Text, dtorder)
                dgvshow.Columns.Clear()
                dgvshow.Rows.Clear()
                Ordercolumns()
                dtorder.Clear()
                order.loadorder_dt(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dtorder, "ຕິດໜີ້", "ປົກກະຕິ")
                'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)
                For i As Integer = 0 To dtorder.Rows.Count - 1
                    Dim orderno1 As String = dtorder.Rows(i).Item(0)
                    Dim pay As String = dtorder.Rows(i).Item(2)
                    Dim ordername As String = dtorder.Rows(i).Item(12)
                    Dim buyfrom As String = dtorder.Rows(i).Item(3)
                    Dim discount1 As Double = dtorder.Rows(i).Item(4)
                    Dim total As Double = dtorder.Rows(i).Item(5)
                    Dim totalpay As Double = dtorder.Rows(i).Item(6)
                    Dim notpay As Double = dtorder.Rows(i).Item(7)
                    Dim saledate1 As String = dtorder.Rows(i).Item(8)

                    Dim status As Integer = dtorder.Rows(i).Item(27)
                    Dim receive As String = dtorder.Rows(i).Item(11)
                    Dim note1 As String = dtorder.Rows(i).Item(9)
                    Dim mainmoney As String = dtorder.Rows(i).Item(25)
                    Dim sup_id As String = dtorder.Rows(i).Item(24)
                    Dim supname As String = dtorder.Rows(i).Item(3)
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
                    dgvshow.Rows.Add(orderno1, pay, ordername, buyfrom, discount1, total, totalpay, notpay, saledate1, status, receive, note1, mainmoney, sup_id, supname)
                Next
                txtshow.Text = dgvshow.Rows.Count

            ElseIf rstatus.Checked = True Then

                dtorder.Clear()
                dgvshow.Columns.Clear()
                dgvshow.Rows.Clear()
                Ordercolumns()
                order.viewstatus(cbstatus.SelectedItem.ToString, dtorder, "ຕິດໜີ້")
                'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)
                For i As Integer = 0 To dtorder.Rows.Count - 1
                    Dim orderno1 As String = dtorder.Rows(i).Item(0)
                    Dim pay As String = dtorder.Rows(i).Item(2)
                    Dim ordername As String = dtorder.Rows(i).Item(12)
                    Dim buyfrom As String = dtorder.Rows(i).Item(3)
                    Dim discount1 As Double = dtorder.Rows(i).Item(4)
                    Dim total As Double = dtorder.Rows(i).Item(5)
                    Dim totalpay As Double = dtorder.Rows(i).Item(6)
                    Dim notpay As Double = dtorder.Rows(i).Item(7)
                    Dim saledate1 As String = dtorder.Rows(i).Item(8)

                    Dim status As Integer = dtorder.Rows(i).Item(27)
                    Dim receive As String = dtorder.Rows(i).Item(11)
                    Dim note1 As String = dtorder.Rows(i).Item(9)
                    Dim mainmoney As String = dtorder.Rows(i).Item(25)
                    Dim sup_id As String = dtorder.Rows(i).Item(24)
                    Dim supname As String = dtorder.Rows(i).Item(3)
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
                    dgvshow.Rows.Add(orderno1, pay, ordername, buyfrom, discount1, total, totalpay, notpay, saledate1, status, receive, note1, mainmoney, sup_id, supname)
                Next
                txtshow.Text = dgvshow.Rows.Count


            ElseIf rdcustomer.Checked = True Then
                formorder = True
                frmshowcustomer.ShowDialog()
                frmshowcustomer.Close()
                formorder = False
                dgvshow.Columns.Clear()
                dgvshow.Rows.Clear()
                Ordercolumns()
                dtorder.Clear()
                order.loadorder_bysupplier(sup_id, dtorder)
                'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)
                For i As Integer = 0 To dtorder.Rows.Count - 1
                    Dim orderno1 As String = dtorder.Rows(i).Item(0)
                    Dim pay As String = dtorder.Rows(i).Item(2)
                    Dim ordername As String = dtorder.Rows(i).Item(12)
                    Dim buyfrom As String = dtorder.Rows(i).Item(3)
                    Dim discount1 As Double = dtorder.Rows(i).Item(4)
                    Dim total As Double = dtorder.Rows(i).Item(5)
                    Dim totalpay As Double = dtorder.Rows(i).Item(6)
                    Dim notpay As Double = dtorder.Rows(i).Item(7)
                    Dim saledate1 As String = dtorder.Rows(i).Item(8)

                    Dim status As Integer = dtorder.Rows(i).Item(27)
                    Dim receive As String = dtorder.Rows(i).Item(11)
                    Dim note1 As String = dtorder.Rows(i).Item(9)
                    Dim mainmoney As String = dtorder.Rows(i).Item(25)
                    Dim sup_id As String = dtorder.Rows(i).Item(24)
                    Dim supname As String = dtorder.Rows(i).Item(3)
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
                    dgvshow.Rows.Add(orderno1, pay, ordername, buyfrom, discount1, total, totalpay, notpay, saledate1, status, receive, note1, mainmoney, sup_id, supname)
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        If dgvshow.SelectedCells.Count < 1 Then

        Else


            frmpaorderdebitbilldetail.ShowDialog()
            frmpaorderdebitbilldetail.Close()

        End If

    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub dgvshow_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellDoubleClick
        Try
            If dgvshow.SelectedCells.Count < 1 Then
                Return
            End If
            frmpaysupplier.ShowDialog()
            frmpaysupplier.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        'Try

        With dgvshow
            order.loadorderdetail(dgvshow.CurrentRow.Cells(0).Value, dgvdetail)
        End With

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub rdate_CheckedChanged(sender As Object, e As EventArgs) Handles rdate.CheckedChanged
        If rdate.Checked = True Then
            dt1.Visible = True
            dt2.Visible = True
            txtsearch.Visible = False
            cbstatus.Visible = False
        ElseIf rid.Checked = True Then
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Visible = True
            txtsearch.Select()
            cbstatus.Visible = False
        ElseIf rstatus.Checked = True Then
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Visible = False
            cbstatus.Visible = True
        End If
    End Sub

    Private Sub rid_CheckedChanged(sender As Object, e As EventArgs) Handles rid.CheckedChanged
        If rdate.Checked = True Then
            dt1.Visible = True
            dt2.Visible = True
            txtsearch.Visible = False
            cbstatus.Visible = False
        ElseIf rid.Checked = True Then
            txtsearch.Clear()
            txtsearch.Enabled = True
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Visible = True
            txtsearch.Select()
            cbstatus.Visible = False
        ElseIf rstatus.Checked = True Then
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Visible = False
            cbstatus.Visible = True
        End If
    End Sub

    Private Sub rstatus_CheckedChanged(sender As Object, e As EventArgs) Handles rstatus.CheckedChanged
        If rdate.Checked = True Then
            dt1.Visible = True
            dt2.Visible = True
            txtsearch.Visible = False
            cbstatus.Visible = False
        ElseIf rid.Checked = True Then
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Visible = True
            txtsearch.Select()
            cbstatus.Visible = False
        ElseIf rstatus.Checked = True Then
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Visible = False
            cbstatus.Visible = True
        End If
    End Sub


    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            If rid.Checked = True Then

                dgvshow.Columns.Clear()
                dgvshow.Rows.Clear()
                Ordercolumns()
                dtorder.Clear()
                order.vieworder_byid(txtsearch.Text, dtorder)
                'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)
                For i As Integer = 0 To dtorder.Rows.Count - 1
                    Dim orderno1 As String = dtorder.Rows(i).Item(0)
                    Dim pay As String = dtorder.Rows(i).Item(2)
                    Dim ordername As String = dtorder.Rows(i).Item(10)
                    Dim buyfrom As String = dtorder.Rows(i).Item(3)
                    Dim discount1 As Double = dtorder.Rows(i).Item(4)
                    Dim total As Double = dtorder.Rows(i).Item(5)
                    Dim saledate1 As String = dtorder.Rows(i).Item(6)

                    Dim status As Integer = dtorder.Rows(i).Item(25)
                    Dim receive As String = dtorder.Rows(i).Item(9)
                    Dim note1 As String = dtorder.Rows(i).Item(7)
                    Dim mainmoney As String = dtorder.Rows(i).Item(23)
                    Dim sup_id As String = dtorder.Rows(i).Item(22)
                    Dim supname As String = dtorder.Rows(i).Item(3)
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
                    dgvshow.Rows.Add(orderno1, pay, ordername, buyfrom, discount1, total, saledate1, status, receive, note1, mainmoney, sup_id, supname)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbstatus.SelectedIndexChanged
        Try
            If rstatus.Checked = True Then
                dtorder.Clear()
                dgvshow.Columns.Clear()
                dgvshow.Rows.Clear()
                Ordercolumns()
                order.viewstatus(cbstatus.SelectedItem.ToString, dtorder, "ຕິດໜີ້")
                'order.loadorder(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvshow)
                For i As Integer = 0 To dtorder.Rows.Count - 1
                    Dim orderno1 As String = dtorder.Rows(i).Item(0)
                    Dim pay As String = dtorder.Rows(i).Item(2)
                    Dim ordername As String = dtorder.Rows(i).Item(10)
                    Dim buyfrom As String = dtorder.Rows(i).Item(3)
                    Dim discount1 As Double = dtorder.Rows(i).Item(4)
                    Dim total As Double = dtorder.Rows(i).Item(5)
                    Dim saledate1 As String = dtorder.Rows(i).Item(6)
                    Dim status As Integer = dtorder.Rows(i).Item(25)
                    Dim receive As String = dtorder.Rows(i).Item(9)
                    Dim note1 As String = dtorder.Rows(i).Item(7)
                    Dim mainmoney As String = dtorder.Rows(i).Item(23)
                    Dim sup_id As String = dtorder.Rows(i).Item(22)
                    Dim supname As String = dtorder.Rows(i).Item(3)
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
                    dgvshow.Rows.Add(orderno1, pay, ordername, buyfrom, discount1, total, saledate1, status, receive, note1, mainmoney, sup_id, supname)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btncreate_Click_1(sender As Object, e As EventArgs) Handles btncreate.Click
        Try
            If dgvshow.SelectedCells.Count < 1 Then
                Return
            End If
            frmpaysupplier.ShowDialog()
            frmpaysupplier.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdcustomer_CheckedChanged(sender As Object, e As EventArgs) Handles rdcustomer.CheckedChanged
        If rdcustomer.Checked = True Then
            btnshow.Text = "ເລືອກລູກຄ້າ"
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Visible = True
            txtsearch.Enabled = False
            cbstatus.Visible = False
        Else
            btnshow.Text = "ສະແດງ"
            dt1.Visible = False
            dt2.Visible = False
            txtsearch.Visible = True
            txtsearch.Select()
            cbstatus.Visible = False
        End If
    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub
End Class