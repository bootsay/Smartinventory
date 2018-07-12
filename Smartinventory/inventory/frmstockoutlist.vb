Public Class frmstockoutlist
    Public dt As New DataTable
    Public formstockout As Boolean
    Dim stockout As New tbstockout
    Public stockoutpro As Boolean = False

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
                dt1.Visible = False
                dt2.Visible = False
                txtsearch.Visible = False
                cbstatus.Visible = True
                cbstatus.SelectedIndex = 1
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
                txtsearch.Select()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    Public Sub format_salelist()
        Dim id As New DataGridViewTextBoxColumn
        Dim type As New DataGridViewTextBoxColumn
        Dim stockname As New DataGridViewTextBoxColumn
        Dim employeename As New DataGridViewTextBoxColumn
        Dim totalsale As New DataGridViewTextBoxColumn
        Dim saledate As New DataGridViewTextBoxColumn
        Dim status As New DataGridViewCheckBoxColumn
        Dim approve As New DataGridViewCheckBoxColumn
        Dim note As New DataGridViewTextBoxColumn
        Dim empid As New DataGridViewTextBoxColumn
        Dim statusid As New DataGridViewTextBoxColumn

        dgvsalelist.Columns.Add(id)
        dgvsalelist.Columns.Add(type)
        dgvsalelist.Columns.Add(stockname)
        dgvsalelist.Columns.Add(employeename)
        dgvsalelist.Columns.Add(totalsale)
        dgvsalelist.Columns.Add(saledate)
        dgvsalelist.Columns.Add(status)
        dgvsalelist.Columns.Add(approve)
        dgvsalelist.Columns.Add(note)
        dgvsalelist.Columns.Add(empid)
        dgvsalelist.Columns.Add(statusid)


        With dgvsalelist
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ປະເພດ"
            .Columns(2).HeaderText = "ນາຍສາງ"
            .Columns(3).HeaderText = "ຜູ້ເບີກ"
            .Columns(4).HeaderText = "ລວມ"
            .Columns(5).HeaderText = "ວັນທີ"
            .Columns(6).HeaderText = "ຍົກເລີກ"
            .Columns(7).HeaderText = "ສົ່ງຄືນ"
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Try
            If rdstatus.Checked = True Then
                dt.Clear()
                dgvsalelist.Columns.Clear()
                dgvsalelist.Rows.Clear()
                stockout.viewstockout_search_statusname(dt, cbstatus.SelectedItem.ToString)
                format_salelist()
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim id As String = dt.Rows(i).Item(0)
                    Dim type As String = dt.Rows(i).Item(1)
                    Dim stockname As String = dt.Rows(i).Item(2)
                    Dim employeename As String = dt.Rows(i).Item(3)
                    Dim totalsale As String = dt.Rows(i).Item(4)
                    Dim saledate As String = dt.Rows(i).Item(5)
                    Dim status As String = dt.Rows(i).Item(6)
                    Dim approve As String = dt.Rows(i).Item(7)
                    Dim note1 As String = dt.Rows(i).Item(8)
                    Dim empid As String = dt.Rows(i).Item(9)
                    Dim statusid As String = dt.Rows(i).Item(10)
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
                    dgvsalelist.Rows.Add(id, type, stockname, employeename, totalsale, saledate, status, approve, note1, empid, statusid)
                Next
            ElseIf rddate.Checked = True Then
                dt.Clear()
                dgvsalelist.Columns.Clear()
                dgvsalelist.Rows.Clear()
                stockout.viewstockout_search_stockoutdate(dt, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))
                format_salelist()
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim id As String = dt.Rows(i).Item(0)
                    Dim type As String = dt.Rows(i).Item(1)
                    Dim stockname As String = dt.Rows(i).Item(2)
                    Dim employeename As String = dt.Rows(i).Item(3)
                    Dim totalsale As String = dt.Rows(i).Item(4)
                    Dim saledate As String = dt.Rows(i).Item(5)
                    Dim status As String = dt.Rows(i).Item(6)
                    Dim approve As String = dt.Rows(i).Item(7)
                    Dim note1 As String = dt.Rows(i).Item(8)
                    Dim empid As String = dt.Rows(i).Item(9)
                    Dim statusid As String = dt.Rows(i).Item(10)
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
                    dgvsalelist.Rows.Add(id, type, stockname, employeename, totalsale, saledate, status, approve, note1, empid, statusid)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub showsale_Click(sender As Object, e As EventArgs) Handles showsale.Click
        frmstockout.ShowDialog()
        frmstockout.Close()
    End Sub

    Private Sub btnshowdetail_Click(sender As Object, e As EventArgs) Handles btnshowdetail.Click
        Try
            If dgvsalelist.Rows.Count < 1 Then
                Return
            End If
            formstockout = True
            frmstockout.ShowDialog()
            frmstockout.Close()
            formstockout = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If rdno.Checked = True Then
            dt.Clear()
            dgvsalelist.Columns.Clear()
            dgvsalelist.Rows.Clear()
            stockout.viewstockout_search_id(dt, txtsearch.Text)
            format_salelist()
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim id As String = dt.Rows(i).Item(0)
                Dim type As String = dt.Rows(i).Item(1)
                Dim stockname As String = dt.Rows(i).Item(2)
                Dim employeename As String = dt.Rows(i).Item(3)
                Dim totalsale As String = dt.Rows(i).Item(4)
                Dim saledate As String = dt.Rows(i).Item(5)
                Dim status As String = dt.Rows(i).Item(6)
                Dim approve As String = dt.Rows(i).Item(7)
                Dim note1 As String = dt.Rows(i).Item(8)
                Dim empid As String = dt.Rows(i).Item(9)
                Dim statusid As String = dt.Rows(i).Item(10)
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
                dgvsalelist.Rows.Add(id, type, stockname, employeename, totalsale, saledate, status, approve, note1, empid, statusid)
            Next
        End If
    End Sub

    Private Sub frmstockoutlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rddate.Checked = True
        dt1.Text = Today.Date
        dt2.Text = Today.Date
        dt.Clear()
        dgvsalelist.Columns.Clear()
        dgvsalelist.Rows.Clear()
        stockout.viewstockout_search_stockoutdate(dt, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))
        format_salelist()
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim id As String = dt.Rows(i).Item(0)
            Dim type As String = dt.Rows(i).Item(1)
            Dim stockname As String = dt.Rows(i).Item(2)
            Dim employeename As String = dt.Rows(i).Item(3)
            Dim totalsale As String = dt.Rows(i).Item(4)
            Dim saledate As String = dt.Rows(i).Item(5)
            Dim status As String = dt.Rows(i).Item(6)
            Dim approve As String = dt.Rows(i).Item(7)
            Dim note1 As String = dt.Rows(i).Item(8)
            Dim empid As String = dt.Rows(i).Item(9)
            Dim statusid As String = dt.Rows(i).Item(10)
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
            dgvsalelist.Rows.Add(id, type, stockname, employeename, totalsale, saledate, status, approve, note1, empid, statusid)

        Next
    End Sub

    Private Sub dgvsalelist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsalelist.CellContentClick

    End Sub

    Private Sub dgvsalelist_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsalelist.CellDoubleClick
        Try
            If dgvsalelist.Rows.Count < 1 Then
                Return
            End If
            formstockout = True
            frmstockout.ShowDialog()
            frmstockout.Close()
            formstockout = False
        Catch ex As Exception

        End Try






    End Sub
End Class