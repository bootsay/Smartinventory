Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmreportsaledetail
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt, dt1, dt2 As New DataTable
    Dim cm As New SqlCommand
    Dim cate As New tbcategory
    Dim subcate As New tbsubcategory
    Dim cry As New crysaledetail
    Dim data1 As New mydata
    Dim dttt As New DataTable
    Public sup_id As String
    Public frmreportsaledetail As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Frmreport_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cate.combocategory1(cbcategory)
            cbcategory.SelectedValue = 0
            If cbcategory.SelectedValue > 0 Then
                subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcategory.SelectedIndexChanged
        Try
            If cbcategory.SelectedValue = 0 Then
            Else
                subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btncry_Click(sender As Object, e As EventArgs) Handles btncry.Click
        Try
            Dim subname As String = Nothing
            If cbcategory.SelectedValue = 0 Then
                subname = "%"
            Else
                Dim rows As DataRowView = cbsupcategory.SelectedItem
                Dim row As DataRow = rows.Row
                subname = row(3).ToString
            End If
            dt.Clear()
            cn.connect()

            cm = New SqlCommand("select * from viewsaledetail where saledate>='" & Format(CDate(date1.Text), "MM/dd/yyyy") & "'and saledate<='" & Format(CDate(date2.Text), "MM/dd/yyyy") & "' and  subname like N'%" & subname & "%' and approve='YES' and statusid<>4 ORDER BY saleNO ASC", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            cry.SetParameterValue("dt1", date1.Text)
            cry.SetParameterValue("dt2", date2.Text)
            CrystalReportViewer1.ReportSource = cry
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtid.KeyDown
        If e.KeyCode = Keys.Enter Then
            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from viewsaledetail where saleNO like N'%" & txtid.Text & "%' and approve='YES' and statusid<>4 ORDER BY saleNO ASC", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            cry.SetParameterValue("dt1", date1.Text)
            cry.SetParameterValue("dt2", date2.Text)
            CrystalReportViewer1.ReportSource = cry
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        frmreportsaledetail = True
        frmshowcustomer.ShowDialog()
        frmshowcustomer.Close()
        frmreportsaledetail = False
    End Sub

    Private Sub txtcustomer_TextChanged(sender As Object, e As EventArgs) Handles txtcustomer.TextChanged

        dt.Clear()
        cn.connect()
        cm = New SqlCommand("select * from viewsaledetail where companyname like N'%" & txtcustomer.Text & "%' and approve='YES' and statusid<>4 ORDER BY saleNO ASC", cn.conn)
        With da
            .SelectCommand = cm
            .Fill(dt)
        End With
        cry.SetDatabaseLogon(cn.user, cn.password)
        cry.SetDataSource(dt)
        cry.SetParameterValue("dt1", date1.Text)
        cry.SetParameterValue("dt2", date2.Text)
        CrystalReportViewer1.ReportSource = cry
    End Sub
End Class