Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmreportwithdraw
    Dim cn As New connectdb
    Dim saleapprove As New tbapprovedate
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim cry As New cryreportwithdraw
    Dim data1 As New mydata
    Dim saledate As String
    Dim sale As New tbsales
    Private Sub frmbillsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt.Clear()
            cn.connect()
            Dim ff As frmcash = DirectCast(Application.OpenForms("frmcashpay"), frmcash)
            cm = New SqlCommand("select * from viewwithdraw where accountid='" & ff.cbmainaccountsearch.SelectedValue & "' and datewithdraw>='" & Format(CDate(ff.dtt1.Text), "MM/dd/yyyy") & "' and datewithdraw<='" & Format(CDate(ff.dtt2.Text), "MM/dd/yyyy") & "' order by datewithdraw", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            cry.SetParameterValue("dt1", ff.dtt1.Text)
            cry.SetParameterValue("dt2", ff.dtt2.Text)
            cry.SetParameterValue("totalamount", ff.totalcapitaltotal)
            cry.SetParameterValue("remindamount", ff.totalremind)
            CrystalReportViewer1.ReportSource = cry
            'cry.Dispose()
            'cry.Close()
            'GC.Collect()
            'cm.Dispose()
            'cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class