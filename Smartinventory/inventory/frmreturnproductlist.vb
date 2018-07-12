Public Class frmreturnproductlist
    Dim returnproduct As New tbreturnproduct
    Public formreturn As Boolean = False
    Public dt As New DataTable
    Public returnpro As Boolean = False
    Private Sub rddate_CheckedChanged(sender As Object, e As EventArgs)
        If rddate.Checked = True Then
            dt1.Visible = True
            dt2.Visible = True
            txtsearch.Visible = False
            cbstatus.Visible = False
        End If
    End Sub

    Private Sub rdno_CheckedChanged(sender As Object, e As EventArgs) Handles rdno.CheckedChanged
        If rdno.Checked = True Then
            txtsearch.Visible = True
            cbstatus.Visible = False
            txtsearch.Select()
        End If
    End Sub

    Private Sub rdstatus_CheckedChanged(sender As Object, e As EventArgs) Handles rdstatus.CheckedChanged
        If rdstatus.Checked = True Then
            txtsearch.Visible = False
            cbstatus.Visible = True
            cbstatus.SelectedIndex = 0
            'txtsearch.Select()
        End If
    End Sub

    Private Sub rdcustomer_CheckedChanged(sender As Object, e As EventArgs) Handles rdcustomer.CheckedChanged
        If rdcustomer.Checked = True Then
            txtsearch.Visible = True
            cbstatus.Visible = False
            txtsearch.Select()
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    Public Sub format_returnlist()
        Dim id As New DataGridViewTextBoxColumn
        Dim username As New DataGridViewTextBoxColumn
        Dim productowner As New DataGridViewTextBoxColumn
        Dim totalprice As New DataGridViewTextBoxColumn
        Dim note As New DataGridViewTextBoxColumn
        Dim returndate As New DataGridViewTextBoxColumn
        Dim date_getproduct As New DataGridViewTextBoxColumn
        Dim statusname As New DataGridViewCheckBoxColumn
        Dim approve As New DataGridViewCheckBoxColumn
        Dim sents As New DataGridViewCheckBoxColumn

        dgvsalelist.Columns.Add(id)
        dgvsalelist.Columns.Add(username)
        dgvsalelist.Columns.Add(productowner)
        dgvsalelist.Columns.Add(totalprice)
        dgvsalelist.Columns.Add(note)
        dgvsalelist.Columns.Add(returndate)
        dgvsalelist.Columns.Add(date_getproduct)
        dgvsalelist.Columns.Add(statusname)
        dgvsalelist.Columns.Add(approve)
        dgvsalelist.Columns.Add(sents)
        With dgvsalelist
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ຜູ້ອອກບີນ"
            .Columns(2).HeaderText = "ຜູ້ແຈ້ງແປງ"
            .Columns(3).HeaderText = "ມູນຄ່າ"
            .Columns(4).HeaderText = "ໝາຍເຫດ"
            .Columns(5).HeaderText = "ວັນທີແຈ້ງ"
            .Columns(6).HeaderText = "ວັນທີຮັບ"
            .Columns(7).HeaderText = "ຍົກເລີກ"
            .Columns(8).HeaderText = "ຮັບແລ້ວ"
            .Columns(9).HeaderText = "ສົ່ງແລ້ວ"
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        End With

    End Sub
    Private Sub btnshowdetail_Click(sender As Object, e As EventArgs) Handles btnshowdetail.Click
        Try
            If dgvsalelist.SelectedCells.Count < 1 Then
                Return
            End If
            formreturn = True
            frmreturnproduct.ShowDialog()
            frmreturnproduct.Close()
            formreturn = False
        Catch ex As Exception

        End Try


    End Sub
    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Try
            dgvsalelist.Columns.Clear()
            dgvsalelist.Rows.Clear()
            format_returnlist()
            dt.Clear()
            Dim statusname1 As String = Nothing
            Dim approve As String = Nothing
            Dim comname As String = Nothing
            Dim idreturn As String = Nothing
            If cbstatus.SelectedIndex = 0 Then
                statusname1 = "%"
                approve = "%"
            ElseIf cbstatus.SelectedIndex = 1 Then
                statusname1 = "ປົກກະຕິ"
                approve = "YES"
            ElseIf cbstatus.SelectedIndex = 2 Then
                statusname1 = "ປົກກະຕິ"
                approve = "NO"
            ElseIf cbstatus.SelectedIndex = 3 Then
                statusname1 = "ຍົກເລີກ"
                approve = "%"
            End If
            If rdcustomer.Checked = True Then
                comname = txtsearch.Text
            Else
                comname = "%"
            End If
            If rdno.Checked = True Then
                idreturn = txtsearch.Text
            Else
                idreturn = "%"
            End If
            If rddate.Checked = True Then

                returnproduct.viewreturn_search_date(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), statusname1, approve, idreturn, comname, dt)
            Else
                returnproduct.viewreturn_search_all(statusname1, approve, idreturn, comname, dt)

            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                Dim id As String = dt.Rows(i).Item(0)
                Dim username As String = dt.Rows(i).Item(1)
                Dim productowner As String = dt.Rows(i).Item(2)
                Dim totalprice As Double = dt.Rows(i).Item(3)
                Dim note As String = dt.Rows(i).Item(4)
                Dim returndate As String = dt.Rows(i).Item(5)
                Dim date_getproduct As String = dt.Rows(i).Item(6)
                Dim statusname As String = dt.Rows(i).Item(7)
                Dim checkapprove As String = dt.Rows(i).Item(8)
                Dim checksent As String = dt.Rows(i).Item(20)
                If statusname = "ປົກກະຕິ" Then
                    statusname = False
                Else
                    statusname = True
                End If
                If checkapprove = "YES" Then
                    checkapprove = True
                Else
                    checkapprove = False
                End If
                If checksent = "YES" Then
                    checksent = True
                Else
                    checksent = False
                End If
                dgvsalelist.Rows.Add(id, username, productowner, totalprice, note, returndate, date_getproduct, statusname, checkapprove, checksent)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub showreturn_Click(sender As Object, e As EventArgs) Handles showreturn.Click
        frmreturnproduct.ShowDialog()
        frmreturnproduct.Close()
    End Sub

    Private Sub frmreturnproductlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rddate.Checked = True
            rdstatus.Checked = True
            cbstatus.SelectedItem = 0
            dt1.Text = Today.Date
            dt2.Text = Today.Date
            dgvsalelist.Columns.Clear()
            dgvsalelist.Rows.Clear()
            format_returnlist()
            dt.Clear()
            Dim statusname1 As String = Nothing
            Dim approve As String = Nothing
            Dim comname As String = Nothing
            Dim idreturn As String = Nothing
            If cbstatus.SelectedIndex = 0 Then
                statusname1 = "%"
                approve = "%"
            ElseIf cbstatus.SelectedIndex = 1 Then
                statusname1 = "ປົກກະຕິ"
                approve = "YES"
            ElseIf cbstatus.SelectedIndex = 2 Then
                statusname1 = "ປົກກະຕິ"
                approve = "NO"
            ElseIf cbstatus.SelectedIndex = 3 Then
                statusname1 = "ຍົກເລີກ"
                approve = "%"
            End If
            If rdcustomer.Checked = True Then
                comname = txtsearch.Text
            Else
                comname = "%"
            End If
            If rdno.Checked = True Then
                idreturn = txtsearch.Text
            Else
                idreturn = "%"
            End If
            If rddate.Checked = True Then
                returnproduct.viewreturn_search_date(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), statusname1, approve, idreturn, comname, dt)
            ElseIf rdall.Checked = True Then
                returnproduct.viewreturn_search_all(statusname1, approve, idreturn, comname, dt)

            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                Dim id As String = dt.Rows(i).Item(0)
                Dim username As String = dt.Rows(i).Item(1)
                Dim productowner As String = dt.Rows(i).Item(2)
                Dim totalprice As Double = dt.Rows(i).Item(3)
                Dim note As String = dt.Rows(i).Item(4)
                Dim returndate As String = dt.Rows(i).Item(5)
                Dim date_getproduct As String = dt.Rows(i).Item(6)
                Dim statusname As String = dt.Rows(i).Item(7)
                Dim checkapprove As String = dt.Rows(i).Item(8)
                Dim checksent As String = dt.Rows(i).Item(20)
                If statusname = "ປົກກະຕິ" Then
                    statusname = False
                Else
                    statusname = True
                End If
                If checkapprove = "YES" Then
                    checkapprove = True
                Else
                    checkapprove = False
                End If
                If checksent = "YES" Then
                    checksent = True
                Else
                    checksent = False
                End If
                dgvsalelist.Rows.Add(id, username, productowner, totalprice, note, returndate, date_getproduct, statusname, checkapprove, checksent)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            dgvsalelist.Columns.Clear()
            dgvsalelist.Rows.Clear()
            format_returnlist()
            dt.Clear()
            Dim statusname1 As String = Nothing
            Dim approve As String = Nothing
            Dim comname As String = Nothing
            Dim idreturn As String = Nothing
            If cbstatus.SelectedIndex = 0 Then
                statusname1 = "%"
                approve = "%"
            ElseIf cbstatus.SelectedIndex = 1 Then
                statusname1 = "ປົກກະຕິ"
                approve = "YES"
            ElseIf cbstatus.SelectedIndex = 2 Then
                statusname1 = "ປົກກະຕິ"
                approve = "NO"
            ElseIf cbstatus.SelectedIndex = 3 Then
                statusname1 = "ຍົກເລີກ"
                approve = "%"
            End If
            If rdcustomer.Checked = True Then
                comname = txtsearch.Text
            Else
                comname = "%"
            End If
            If rdno.Checked = True Then
                idreturn = txtsearch.Text
            Else
                idreturn = "%"
            End If
            If rddate.Checked = True Then

                returnproduct.viewreturn_search_date(Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), statusname1, approve, idreturn, comname, dt)
            Else
                returnproduct.viewreturn_search_all(statusname1, approve, idreturn, comname, dt)

            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                Dim id As String = dt.Rows(i).Item(0)
                Dim username As String = dt.Rows(i).Item(1)
                Dim productowner As String = dt.Rows(i).Item(2)
                Dim totalprice As Double = dt.Rows(i).Item(3)
                Dim note As String = dt.Rows(i).Item(4)
                Dim returndate As String = dt.Rows(i).Item(5)
                Dim date_getproduct As String = dt.Rows(i).Item(6)
                Dim statusname As String = dt.Rows(i).Item(7)
                Dim checkapprove As String = dt.Rows(i).Item(8)
                Dim checksent As String = dt.Rows(i).Item(20)
                If statusname = "ປົກກະຕິ" Then
                    statusname = False
                Else
                    statusname = True
                End If
                If checkapprove = "YES" Then
                    checkapprove = True
                Else
                    checkapprove = False
                End If
                If checksent = "YES" Then
                    checksent = True
                Else
                    checksent = False
                End If
                dgvsalelist.Rows.Add(id, username, productowner, totalprice, note, returndate, date_getproduct, statusname, checkapprove, checksent)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub rdall_CheckedChanged(sender As Object, e As EventArgs) Handles rdall.CheckedChanged
        If rdall.Checked = True Then
            dt1.Enabled = False
            dt2.Enabled = False
        Else
            dt1.Enabled = True
            dt2.Enabled = True
        End If
    End Sub

    Private Sub dgvsalelist_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsalelist.CellDoubleClick
        Try
            If dgvsalelist.SelectedCells.Count < 1 Then
                Return
            End If
            formreturn = True
            frmreturnproduct.ShowDialog()
            frmreturnproduct.Close()
            formreturn = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class