Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmreportstockout

    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim salename As New tbsalename
    Dim stockoutype As New tbstockouttype
    Public frmreportsaledetaillist As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        'Try


        Dim stockouttype1 As String = Nothing
        If cbstockoutype.SelectedValue = 0 Then
            stockouttype1 = "%"
        Else
            Dim rows As DataRowView = cbstockoutype.SelectedItem
            Dim row As DataRow = rows.Row
            stockouttype1 = row(1).ToString
        End If
       

        Dim customer As String = Nothing
        If txtcustomer.Text = "" Then
            customer = "%"
        Else
            customer = txtcustomer.Text

        End If
       

        dt.Clear()
        cn.connect()
        cm = New SqlCommand("select * from viewstockout where date_out>='" & Format(CDate(date1.Text), "MM/dd/yyyy") & "' and date_out<='" & Format(CDate(date2.Text), "MM/dd/yyyy") & "' and approve='YES' and employeename like N'%" & customer & "%' and stockouttypename like N'%" & stockouttype1 & "%' and statusid<>4  order by stockoutNO asc", cn.conn)
        With da
            .SelectCommand = cm
            .Fill(dt)
        End With
        Dim cry As New crystockoutbilldetail
        cry.SetDataSource(dt)
        cry.SetDatabaseLogon(cn.user, cn.password)
        cry.SetParameterValue("dt1", date1.Text)
        cry.SetParameterValue("dt2", date2.Text)
        CrystalReportViewer1.ReportSource = cry
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
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

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmreportorderbill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stockoutype.combostockouttype1(cbstockoutype)
        cbstockoutype.SelectedValue = 0
    End Sub
End Class