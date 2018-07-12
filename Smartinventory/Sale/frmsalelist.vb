Public Class frmsalelist
    Dim sale As New tbsales
    Public saledetail As Boolean = False
    Public dt As New DataTable
    Public sup_id As String
    Public formsalelist As Boolean = False
    Private Sub frmsalelist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dgvsalelist.Enabled = False
        'btnshowdetail.Enabled = False
        rddate.Checked = True
        dt1.Text = Today.Date
        dt2.Text = Today.Date
        'sale.viewsale_bydate(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dgvsalelist)
        If rddate.Checked = True Then
            dgvsalelist.Columns.Clear()
            dgvsalelist.Rows.Clear()
            format_salelist()
            dt.Clear()
            sale.viewsale_bydate_datatable(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dt)

            'MessageBox.Show(dt.Rows.Count)
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim idd As String = dt.Rows(i).Item(0)
                Dim payname As String = dt.Rows(i).Item(1)
                Dim salename As String = dt.Rows(i).Item(29)
                Dim buyname As String = dt.Rows(i).Item(3)
                Dim discount As Double = dt.Rows(i).Item(4)
                Dim vath As Double = dt.Rows(i).Item(5)
                Dim totalsale As Double = dt.Rows(i).Item(6)
                Dim deposit As Double = dt.Rows(i).Item(7)
                Dim notpay As Double = dt.Rows(i).Item(8)
                Dim mainmoney As String = dt.Rows(i).Item(9)
                Dim saledate As String = dt.Rows(i).Item(10)
                Dim status As String = dt.Rows(i).Item(11)
                Dim location_install As String = dt.Rows(i).Item(28)
                Dim pricetype As String = dt.Rows(i).Item(30)
                If status = "ປົກກະຕິ" Then
                    status = False
                Else
                    status = True
                End If
                Dim checkapprove As String = dt.Rows(i).Item(12)
                If checkapprove = "YES" Then
                    checkapprove = True
                Else
                    checkapprove = False
                End If
                Dim sup_id As String = dt.Rows(i).Item(17)
                Dim note As String = dt.Rows(i).Item(19)
                Dim datecredit As Integer = dt.Rows(i).Item(23)
                dgvsalelist.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, status, checkapprove, sup_id, note, datecredit, location_install, pricetype)
            Next
        End If
    End Sub
    'Private Sub loaddata()
    '    If rddate.Checked = True Then
    '        dgvsalelist.Columns.Clear()
    '        dgvsalelist.Rows.Clear()
    '        format_salelist()
    '        dt.Clear()
    '        sale.viewsale_bydate_datatable(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dt)
    '        For i As Integer = 0 To dt.Rows.Count - 1
    '            Dim idd As String = dt.Rows(i).Item(0)
    '            Dim payname As String = dt.Rows(i).Item(1)
    '            Dim salename As String = dt.Rows(i).Item(29)
    '            Dim buyname As String = dt.Rows(i).Item(3)
    '            Dim discount As Double = dt.Rows(i).Item(4)
    '            Dim vath As Double = dt.Rows(i).Item(5)
    '            Dim totalsale As Double = dt.Rows(i).Item(6)
    '            Dim deposit As Double = dt.Rows(i).Item(7)
    '            Dim notpay As Double = dt.Rows(i).Item(8)
    '            Dim mainmoney As String = dt.Rows(i).Item(9)
    '            Dim saledate As String = dt.Rows(i).Item(10)
    '            Dim status As String = dt.Rows(i).Item(11)
    '            Dim location_install As String = dt.Rows(i).Item(28)
    '            Dim pricetype As String = dt.Rows(i).Item(30)
    '            If status = "ປົກກະຕິ" Then
    '                status = False
    '            Else
    '                status = True
    '            End If
    '            Dim checkapprove As String = dt.Rows(i).Item(12)
    '            If checkapprove = "YES" Then
    '                checkapprove = True
    '            Else
    '                checkapprove = False
    '            End If
    '            Dim sup_id As String = dt.Rows(i).Item(17)
    '            Dim note As String = dt.Rows(i).Item(19)
    '            Dim datecredit As Integer = dt.Rows(i).Item(23)
    '            dgvsalelist.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, status, checkapprove, sup_id, note, datecredit, location_install, pricetype)
    '        Next
    '    End If
    'End Sub
    Private Sub rddate_CheckedChanged(sender As Object, e As EventArgs) Handles rddate.CheckedChanged
        Try
            If rddate.Checked = True Then
                dt1.Visible = True
                dt2.Visible = True
                txtsearch.Visible = False
                cbstatus.Visible = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rdno_CheckedChanged(sender As Object, e As EventArgs) Handles rdno.CheckedChanged
        Try
            If rdno.Checked = True Then
                dt1.Visible = False
                dt2.Visible = False
                txtsearch.Visible = True
                cbstatus.Visible = False
                txtsearch.Select()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rdstatus_CheckedChanged(sender As Object, e As EventArgs) Handles rdstatus.CheckedChanged
        Try
            If rdstatus.Checked = True Then
                cbstatus.SelectedIndex = 1
                dt1.Visible = False
                dt2.Visible = False
                txtsearch.Visible = False
                cbstatus.Visible = True
                'txtsearch.Select()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdcustomer_CheckedChanged(sender As Object, e As EventArgs) Handles rdcustomer.CheckedChanged
        Try
            If rdcustomer.Checked = True Then
                dt1.Visible = False
                dt2.Visible = False
                txtsearch.Visible = True
                cbstatus.Visible = False
                txtsearch.Enabled = False
                btnshow.Text = "ເລືອກຜູ້ຊື້"
            Else
                txtsearch.Enabled = True
                btnshow.Text = "ສະແດງ"
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub format_salelist()
        Dim id As New DataGridViewTextBoxColumn
        Dim payname As New DataGridViewTextBoxColumn
        Dim salename As New DataGridViewTextBoxColumn
        Dim buyname As New DataGridViewTextBoxColumn
        Dim discount As New DataGridViewTextBoxColumn
        Dim vath As New DataGridViewTextBoxColumn
        Dim totalsale As New DataGridViewTextBoxColumn
        Dim deposite As New DataGridViewTextBoxColumn
        Dim balance As New DataGridViewTextBoxColumn
        Dim money As New DataGridViewTextBoxColumn
        Dim saledate As New DataGridViewTextBoxColumn
        Dim status As New DataGridViewCheckBoxColumn
        Dim approve As New DataGridViewCheckBoxColumn
        Dim supid As New DataGridViewTextBoxColumn
        Dim note As New DataGridViewTextBoxColumn
        Dim daycredit As New DataGridViewTextBoxColumn
        Dim location_install As New DataGridViewTextBoxColumn
        Dim pricetype As New DataGridViewTextBoxColumn
        dgvsalelist.Columns.Add(id)
        dgvsalelist.Columns.Add(payname)
        dgvsalelist.Columns.Add(salename)
        dgvsalelist.Columns.Add(buyname)
        dgvsalelist.Columns.Add(discount)
        dgvsalelist.Columns.Add(vath)
        dgvsalelist.Columns.Add(totalsale)
        dgvsalelist.Columns.Add(deposite)
        dgvsalelist.Columns.Add(balance)
        dgvsalelist.Columns.Add(money)
        dgvsalelist.Columns.Add(saledate)
        dgvsalelist.Columns.Add(status)
        dgvsalelist.Columns.Add(approve)
        dgvsalelist.Columns.Add(supid)
        dgvsalelist.Columns.Add(note)
        dgvsalelist.Columns.Add(daycredit)
        dgvsalelist.Columns.Add(location_install)
        dgvsalelist.Columns.Add(pricetype)

        With dgvsalelist
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ປະເພດ"
            .Columns(2).HeaderText = "ຜູ້ຂາຍຫຼືຜູ້ອານຸມັດ"
            .Columns(3).HeaderText = "ຜູ້ຊືິ້"
            .Columns(4).HeaderText = "ສ່ວນລຸດ"
            .Columns(5).HeaderText = "ພາສີ"
            .Columns(6).HeaderText = "ລວມ"
            .Columns(7).HeaderText = "ຈ່າຍແລ້ວ"
            .Columns(8).HeaderText = "ໜີ້"
            .Columns(9).HeaderText = "ເງີນ"
            .Columns(10).HeaderText = "ວັນທີຂາຍ"
            .Columns(11).HeaderText = "ຍົກເລີກ"
            .Columns(12).HeaderText = "ອານຸມັດ"
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            '.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            '.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            '.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            '.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(4).DefaultCellStyle.Format = "N0"
            .Columns(6).DefaultCellStyle.Format = "N0"
            .Columns(7).DefaultCellStyle.Format = "N0"
            .Columns(8).DefaultCellStyle.Format = "N0"
            .Columns(9).Width = 50
            '.Columns(11).Width = 60
            '.Columns(12).Width = 60
        End With
    End Sub

    Private Sub showsale_Click(sender As Object, e As EventArgs) Handles showsale.Click
        saledetail = False
        frmsale.txtsalenameproduct.Text = frmmain.lalaoname.Text
        frmsale.ShowDialog()
        frmsale.Close()
    End Sub

    Private Sub btnshowdetail_Click(sender As Object, e As EventArgs) Handles btnshowdetail.Click
        If dgvsalelist.SelectedCells.Count > 0 Then
            saledetail = True
            frmsale.dgvsale.DataSource = Nothing
            frmsale.ShowDialog()
            saledetail = False
        Else

        End If

    End Sub


    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Try
            If rddate.Checked = True Then
                dgvsalelist.Columns.Clear()
                dgvsalelist.Rows.Clear()
                format_salelist()
                dt.Clear()
                sale.viewsale_bydate_datatable(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim idd As String = dt.Rows(i).Item(0)
                    Dim payname As String = dt.Rows(i).Item(1)
                    Dim salename As String = dt.Rows(i).Item(29)
                    Dim buyname As String = dt.Rows(i).Item(3)
                    Dim discount As Double = dt.Rows(i).Item(4)
                    Dim vath As Double = dt.Rows(i).Item(5)
                    Dim totalsale As Double = dt.Rows(i).Item(6)
                    Dim deposit As Double = dt.Rows(i).Item(7)
                    Dim notpay As Double = dt.Rows(i).Item(8)
                    Dim mainmoney As String = dt.Rows(i).Item(9)
                    Dim saledate As String = dt.Rows(i).Item(10)
                    Dim status As String = dt.Rows(i).Item(11)
                    Dim location_install As String = dt.Rows(i).Item(28)
                    Dim pricetype As String = dt.Rows(i).Item(30)
                    If status = "ປົກກະຕິ" Then
                        status = False
                    Else
                        status = True
                    End If
                    Dim checkapprove As String = dt.Rows(i).Item(12)
                    If checkapprove = "YES" Then
                        checkapprove = True
                    Else
                        checkapprove = False
                    End If
                    Dim sup_id As String = dt.Rows(i).Item(17)
                    Dim note As String = dt.Rows(i).Item(19)
                    Dim datecredit As Integer = dt.Rows(i).Item(23)
                    dgvsalelist.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, status, checkapprove, sup_id, note, datecredit, location_install, pricetype)
                Next
            ElseIf rdno.Checked = True Then
                dgvsalelist.Columns.Clear()
                dgvsalelist.Rows.Clear()
                format_salelist()
                dt.Clear()
                sale.viewsale_bysaleNO(txtsearch.Text, dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim idd As String = dt.Rows(i).Item(0)
                    Dim payname As String = dt.Rows(i).Item(1)
                    Dim salename As String = dt.Rows(i).Item(29)
                    Dim buyname As String = dt.Rows(i).Item(3)
                    Dim discount As Double = dt.Rows(i).Item(4)
                    Dim vath As Double = dt.Rows(i).Item(5)
                    Dim totalsale As Double = dt.Rows(i).Item(6)
                    Dim deposit As Double = dt.Rows(i).Item(7)
                    Dim notpay As Double = dt.Rows(i).Item(8)
                    Dim mainmoney As String = dt.Rows(i).Item(9)
                    Dim saledate As String = dt.Rows(i).Item(10)
                    Dim status As String = dt.Rows(i).Item(11)
                    Dim location_install As String = dt.Rows(i).Item(28)
                    Dim pricetype As String = dt.Rows(i).Item(30)
                    If status = "ປົກກະຕິ" Then
                        status = False
                    Else
                        status = True
                    End If
                    Dim checkapprove As String = dt.Rows(i).Item(12)
                    If checkapprove = "YES" Then
                        checkapprove = True
                    Else
                        checkapprove = False
                    End If
                    Dim sup_id As String = dt.Rows(i).Item(17)
                    Dim note As String = dt.Rows(i).Item(19)
                    Dim datecredit As Integer = dt.Rows(i).Item(23)
                    dgvsalelist.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, status, checkapprove, sup_id, note, datecredit, location_install, pricetype)
                Next
            ElseIf rdcustomer.Checked = True Then
                formsalelist = True
                frmshowcustomer.ShowDialog()
                frmshowcustomer.Close()
                formsalelist = False
                dgvsalelist.Columns.Clear()
                dgvsalelist.Rows.Clear()
                format_salelist()
                dt.Clear()
                sale.viewsale_byCustomername(txtsearch.Text, dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim idd As String = dt.Rows(i).Item(0)
                    Dim payname As String = dt.Rows(i).Item(1)
                    Dim salename As String = dt.Rows(i).Item(29)
                    Dim buyname As String = dt.Rows(i).Item(3)
                    Dim discount As Double = dt.Rows(i).Item(4)
                    Dim vath As Double = dt.Rows(i).Item(5)
                    Dim totalsale As Double = dt.Rows(i).Item(6)
                    Dim deposit As Double = dt.Rows(i).Item(7)
                    Dim notpay As Double = dt.Rows(i).Item(8)
                    Dim mainmoney As String = dt.Rows(i).Item(9)
                    Dim saledate As String = dt.Rows(i).Item(10)
                    Dim status As String = dt.Rows(i).Item(11)
                    Dim location_install As String = dt.Rows(i).Item(28)
                    Dim pricetype As String = dt.Rows(i).Item(30)
                    If status = "ປົກກະຕິ" Then
                        status = False
                    Else
                        status = True
                    End If
                    Dim checkapprove As String = dt.Rows(i).Item(12)
                    If checkapprove = "YES" Then
                        checkapprove = True
                    Else
                        checkapprove = False
                    End If
                    Dim sup_id As String = dt.Rows(i).Item(17)
                    Dim note As String = dt.Rows(i).Item(19)
                    Dim datecredit As Integer = dt.Rows(i).Item(23)
                    dgvsalelist.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, status, checkapprove, sup_id, note, datecredit, location_install, pricetype)
                Next
            ElseIf rdstatus.Checked = True Then

                Dim sts As String = Nothing
                If cbstatus.SelectedIndex = 0 Then
                    sts = "YES"
                ElseIf cbstatus.SelectedIndex = 1 Then
                    sts = "NO"
                ElseIf cbstatus.SelectedIndex = 2 Then
                    sts = "cancel"
                End If
                dgvsalelist.Columns.Clear()
                dgvsalelist.Rows.Clear()
                format_salelist()
                dt.Clear()
                sale.viewsale_byapprove_datatable(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), dt, sts)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim idd As String = dt.Rows(i).Item(0)
                    Dim payname As String = dt.Rows(i).Item(1)
                    Dim salename As String = dt.Rows(i).Item(29)
                    Dim buyname As String = dt.Rows(i).Item(3)
                    Dim discount As Double = dt.Rows(i).Item(4)
                    Dim vath As Double = dt.Rows(i).Item(5)
                    Dim totalsale As Double = dt.Rows(i).Item(6)
                    Dim deposit As Double = dt.Rows(i).Item(7)
                    Dim notpay As Double = dt.Rows(i).Item(8)
                    Dim mainmoney As String = dt.Rows(i).Item(9)
                    Dim saledate As String = dt.Rows(i).Item(10)
                    Dim status As String = dt.Rows(i).Item(11)
                    Dim location_install As String = dt.Rows(i).Item(28)
                    Dim pricetype As String = dt.Rows(i).Item(30)
                    If status = "ປົກກະຕິ" Then
                        status = False
                    Else
                        status = True
                    End If
                    Dim checkapprove As String = dt.Rows(i).Item(12)
                    If checkapprove = "YES" Then
                        checkapprove = True
                    Else
                        checkapprove = False
                    End If
                    Dim sup_id As String = dt.Rows(i).Item(17)
                    Dim note As String = dt.Rows(i).Item(19)
                    Dim datecredit As Integer = dt.Rows(i).Item(23)
                    dgvsalelist.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, status, checkapprove, sup_id, note, datecredit, location_install, pricetype)
                Next
            End If
            'btnshowdetail.Enabled = True
            'dgvsalelist.Enabled = True
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try


            If rdno.Checked = True Then
                dgvsalelist.Columns.Clear()
                dgvsalelist.Rows.Clear()
                format_salelist()
                dt.Clear()
                sale.viewsale_bysaleNO(txtsearch.Text, dt)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim idd As String = dt.Rows(i).Item(0)
                    Dim payname As String = dt.Rows(i).Item(1)
                    Dim salename As String = dt.Rows(i).Item(29)
                    Dim buyname As String = dt.Rows(i).Item(3)
                    Dim discount As Double = dt.Rows(i).Item(4)
                    Dim vath As Double = dt.Rows(i).Item(5)
                    Dim totalsale As Double = dt.Rows(i).Item(6)
                    Dim deposit As Double = dt.Rows(i).Item(7)
                    Dim notpay As Double = dt.Rows(i).Item(8)
                    Dim mainmoney As String = dt.Rows(i).Item(9)
                    Dim saledate As String = dt.Rows(i).Item(10)
                    Dim status As String = dt.Rows(i).Item(11)
                    Dim location_install As String = dt.Rows(i).Item(28)
                    Dim pricetype As String = dt.Rows(i).Item(30)
                    If status = "ປົກກະຕິ" Then
                        status = False
                    Else
                        status = True
                    End If
                    Dim checkapprove As String = dt.Rows(i).Item(12)
                    If checkapprove = "YES" Then
                        checkapprove = True
                    Else
                        checkapprove = False
                    End If
                    Dim sup_id As String = dt.Rows(i).Item(17)
                    Dim note As String = dt.Rows(i).Item(19)
                    Dim datecredit As Integer = dt.Rows(i).Item(23)
                    dgvsalelist.Rows.Add(idd, payname, salename, buyname, discount, vath, totalsale, deposit, notpay, mainmoney, saledate, status, checkapprove, sup_id, note, datecredit, location_install, pricetype)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvsalelist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsalelist.CellContentClick

    End Sub

    Private Sub dgvsalelist_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsalelist.CellDoubleClick
        'Try
        If dgvsalelist.SelectedCells.Count > 0 Then
            saledetail = True
            frmsale.dgvsale.DataSource = Nothing
            frmsale.ShowDialog()
            saledetail = False
        Else

        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class