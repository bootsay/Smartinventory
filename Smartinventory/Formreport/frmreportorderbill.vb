Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmreportorderbill

    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim salename As New tbsalename
    Public sup_id As String
    Public formreportorderbill As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        'Try


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

      
        dt.Clear()
        cn.connect()
        cm = New SqlCommand("select * from vieworder where payname like N'%" & status & "%' and orderdate>='" & Format(CDate(date1.Text), "MM/dd/yyyy") & "' and orderdate<='" & Format(CDate(date2.Text), "MM/dd/yyyy") & "' and companyname like N'%" & txtcustomer.Text & "%' and statusid<>4  order by orderNO asc", cn.conn)
        With da
            .SelectCommand = cm
            .Fill(dt)
        End With
        Dim cry As New cryorderbilldetail
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
        formreportorderbill = True
        frmshowcustomer.ShowDialog()
        frmshowcustomer.Close()
        formreportorderbill = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmreportorderbill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        r2.Checked = True
        r5.Checked = True
    End Sub
End Class