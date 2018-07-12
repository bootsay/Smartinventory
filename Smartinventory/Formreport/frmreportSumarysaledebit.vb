Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmreportSumarysaledebit
    Dim cn As New connectdb
    Dim saleapprove As New tbapprovedate
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim cry As New reportSumarysaledebit
    Dim data1 As New mydata
    Dim saledate As String
    Private Sub frmbillsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'report()
            Dim dt1 As New DataTable
            Dim ff As frmSumarysaledebit = CType(Application.OpenForms("frmSumarysaledebit"), frmSumarysaledebit)
            dt1 = ff.dt.Sumarysaledebit
            cry.SetDataSource(dt1)
            cry.SetParameterValue("dt1", ff.dt1.Text)
            cry.SetParameterValue("dt2", ff.dt2.Text)
            CrystalReportViewer1.ReportSource = cry
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class