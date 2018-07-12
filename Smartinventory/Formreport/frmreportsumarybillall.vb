Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmreportsumarybillall
    Dim cn As New connectdb
    Dim saleapprove As New tbapprovedate
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim cry As New cryreportsumaryallbill
    Dim data1 As New mydata
    Dim saledate As String
    Private Sub frmbillsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt.Clear()

            Dim summ As frmsumarysale = CType(Application.OpenForms("frmsumarysale"), frmsumarysale)
            Dim mydata As New mydata
            dt = summ.mydata.viewsumaryallbill
            cry.SetDatabaseLogon(cn.user, cn.password)
            'cry.Database.Tables("tbbusiness").SetDataSource(dttt)
            cry.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = cry
            'cry.Dispose()
            'cry.Close()
            'GC.Collect()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class