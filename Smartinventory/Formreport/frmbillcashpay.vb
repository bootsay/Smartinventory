Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmbillcashpay
    Dim cn As New connectdb
    Dim saleapprove As New tbapprovedate
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim cry As New billcashpay
    Dim data1 As New mydata
    Dim saledate As String
    Dim sale As New tbsales
    Private Sub frmbillsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        dt.Clear()
        Dim dttt As New DataTable
        cn.connect()
        da = New SqlDataAdapter("select * from tbbusiness", cn.conn)
        da.Fill(data1.tbbusiness)
        dttt.Clear()
        dttt = data1.tbbusiness
        cm = New SqlCommand("select * from viewwithdraw where withdrawid=N'" & frmcash.txtid.Text & "'", cn.conn)
        With da
            .SelectCommand = cm
            .Fill(dt)
        End With

        cry.SetDatabaseLogon(cn.user, cn.password)
        cry.Database.Tables("tbbusiness").SetDataSource(dttt)
        cry.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cry



        'cry.Dispose()
        'cry.Close()
        'GC.Collect()
        'cm.Dispose()
        'cn.conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
End Class