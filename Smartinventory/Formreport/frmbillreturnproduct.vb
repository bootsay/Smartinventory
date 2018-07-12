Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmbillreturnproduct
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim cry As New billreturnproduct
    Dim data1 As New mydata
    Dim saledate As String
    Private Sub frmbillsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        'order by returndetailid asc
        dt.Clear()
        cn.connect()
        cm = New SqlCommand("select * from viewreturn where returnNO=N'" & frmreturnproduct.txtorderNO.Text & "'", cn.conn)
        With da
            .SelectCommand = cm
            .Fill(dt)
        End With

        Dim dttt As New DataTable
        da = New SqlDataAdapter("select * from tbbusiness", cn.conn)
        da.Fill(data1.tbbusiness)
        dttt.Clear()
        dttt = data1.tbbusiness

        cry.SetDatabaseLogon(cn.user, cn.password)
        cry.Database.Tables("tbbusiness").SetDataSource(dttt)
        cry.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cry
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
End Class