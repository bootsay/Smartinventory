Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmreportsumaryproductin_out
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt, dt1, dt2 As New DataTable
    Dim cm As New SqlCommand
    Dim cate As New tbcategory
    Dim subcate As New tbsubcategory
    Dim cry As New crysaledaily
    Private Sub btnreportsalelist_Click(sender As Object, e As EventArgs) Handles btnreportsalelist.Click
        Try
            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from viewsaledetail ORDER BY saleNO ASC", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            'cry.SetParameterValue("dt1", dt1.Text)
            'cry.SetParameterValue("dt2", dt2.Text)
            CrystalReportViewer1.ReportSource = cry

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Frmreport_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cate.combocategory(cbcategory)
            cbcategory.SelectedIndex = 0
            If cbcategory.SelectedValue > 0 Then
                subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from viewsaledetail where  subname=N'" & cbsupcategory.Text & "'ORDER BY saleNO ASC", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            cry.SetParameterValue("subname", cbsupcategory.Text)
            'cry.SetParameterValue("dt1", dt1.Text)
            'cry.SetParameterValue("dt2", dt2.Text)
            CrystalReportViewer1.ReportSource = cry
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreportsaleno_Click(sender As Object, e As EventArgs) Handles btnreportsaleno.Click
        'Try
        dt.Clear()
        cn.connect()
        cm = New SqlCommand("select * from viewsaledetail where statusid!=4 and saledate>='" & Format(CDate(date1.Text), "MM/dd/yyyy") & "'and saledate<='" & Format(CDate(date2.Text), "MM/dd/yyyy") & "'ORDER BY saleNO ASC", cn.conn)
        With da
            .SelectCommand = cm
            .Fill(dt)
        End With
        cry.SetDatabaseLogon(cn.user, cn.password)
        cry.SetDataSource(dt)
        'cry.SetParameterValue("subname", Cmbtype.Text)
        cry.SetParameterValue("dt1", date1.Text)
        cry.SetParameterValue("dt2", date2.Text)
        CrystalReportViewer1.ReportSource = cry
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcategory.SelectedIndexChanged
        Try
            subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
        Catch ex As Exception

        End Try
    End Sub
End Class