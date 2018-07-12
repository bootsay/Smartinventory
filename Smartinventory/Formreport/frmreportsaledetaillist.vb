Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmreportsaledetaillist
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim salename As New tbsalename
    Public frmreportsaledetaillist As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Frmreport_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'cbstatus.SelectedIndex = 1
            cbstatusapprove.SelectedIndex = 0
            salename.combosalename(cmbosalename)
            cmbosalename.SelectedValue = 0
            r5.Checked = True

        Catch ex As Exception

        End Try
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Dim status As String = Nothing
            If r3.Checked = True Then
                status = "ສົດ"
            ElseIf r4.Checked = True Then
                status = "ຕິດໜີ້"
            ElseIf r5.Checked = True Then
                status = "%"
            End If

            Dim customer As String
            customer = txtcustomer.Text
            If customer = "" Then
                txtcustomer.Text = "%"
            Else
            End If

            Dim cmbosalename1 As String
            Dim statusname As String = Nothing
            Dim cancelnum As Integer = Nothing
            If cbstatusapprove.SelectedIndex = 0 Then
                statusname = "%"
                cancelnum = 5
            ElseIf cbstatusapprove.SelectedIndex = 1 Then
                statusname = "YES"
                cancelnum = 5
            ElseIf cbstatusapprove.SelectedIndex = 2 Then
                statusname = "NO"
                cancelnum = 5
            ElseIf cbstatusapprove.SelectedIndex = 3 Then
                statusname = "%"
                cancelnum = 4
            End If

            Dim rows As DataRowView = cmbosalename.SelectedItem
            Dim row As DataRow = rows.Row
            If cmbosalename.SelectedValue = 0 Then
                cmbosalename1 = "%"
            Else
                cmbosalename1 = row(1).ToString
            End If
            dt.Clear()
            cn.connect()
            If cbstatusapprove.SelectedIndex = 0 Then
                cm = New SqlCommand("select * from viewsale where saledate>='" & Format(CDate(date1.Text), "MM/dd/yyyy") & "' and saledate<='" & Format(CDate(date2.Text), "MM/dd/yyyy") & "' and  statusid='" & cancelnum & "' and payname like N'%" & status & "%' order by saleNO asc", cn.conn)         
            ElseIf cbstatusapprove.SelectedIndex = 1 Then
                cm = New SqlCommand("select * from viewsale where  saleNO in (select saleNO from tbsaleapprove where saleapprovedate>='" & Format(CDate(date1.Text), "MM/dd/yyyy") & "' and saleapprovedate<='" & Format(CDate(date2.Text), "MM/dd/yyyy") & "') and approve  like N'%" & statusname & "%' and statusid='" & cancelnum & "' and payname like N'%" & status & "%' order by saleNO asc", cn.conn)
            ElseIf cbstatusapprove.SelectedIndex = 2 Then
                cm = New SqlCommand("select * from viewsale where saledate>='" & Format(CDate(date1.Text), "MM/dd/yyyy") & "' and saledate<='" & Format(CDate(date2.Text), "MM/dd/yyyy") & "'   and statusid='" & cancelnum & "' and payname like N'%" & status & "%' order by saleNO asc", cn.conn)
            ElseIf cbstatusapprove.SelectedIndex = 3 Then
                cm = New SqlCommand("select * from viewsale where saledate>='" & Format(CDate(date1.Text), "MM/dd/yyyy") & "' and saledate<='" & Format(CDate(date2.Text), "MM/dd/yyyy") & "' and  statusid='" & cancelnum & "' and payname like N'%" & status & "%' order by saleNO asc", cn.conn)

            End If
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With

            Dim cry As New reportsaledetaillist
            cry.SetDataSource(dt)
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetParameterValue("dt1", date1.Text)
            cry.SetParameterValue("dt2", date2.Text)
            CrystalReportViewer1.ReportSource = cry
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            'If cbcategory.SelectedValue = 0 Then
            '    subcate.combosubcate(cbsupcategory)
            '    cbsupcategory.SelectedValue = 0
            'Else
            '    subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
            'End If


        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmreportsaledetaillist = True
        frmshowcustomer.ShowDialog()
        frmshowcustomer.Close()
        frmreportsaledetaillist = False
    End Sub


    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim status As String = Nothing
            If r3.Checked = True Then
                status = "ສົດ"
            ElseIf r4.Checked = True Then
                status = "ຕິດໜີ້"
            ElseIf r5.Checked = True Then
                status = "%"
            End If
            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from viewsale where  saleNO like N'%" & TextBox1.Text & "%' and payname like N'%" & status & "%' order by saleNO asc", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            Dim cry As New reportsaledetaillist
            cry.SetDataSource(dt)
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetParameterValue("dt1", date1.Text)
            cry.SetParameterValue("dt2", date2.Text)
            CrystalReportViewer1.ReportSource = cry
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class