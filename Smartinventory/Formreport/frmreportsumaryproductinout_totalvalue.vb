Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmreportsumaryproductinout_totalvalue
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt, dt1, dt2 As New DataTable
    Dim cm As New SqlCommand
    Dim cate As New tbcategory
    Dim subcate As New tbsubcategory
    Dim cry As New sumarystock_Value
    Dim ds As New DataSet
    Dim data1 As New mydata
    Private Sub Frmreport_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        'report()
        dt.Clear()
        cn.connect()

        Dim dttt As New DataTable
        da = New SqlDataAdapter("select * from tbbusiness", cn.conn)
        da.Fill(data1.tbbusiness)
        dttt.Clear()
        dttt = data1.tbbusiness



        Dim dt1 As New DataTable
        Dim ff As frmcheckstockoption = CType(Application.OpenForms("frmcheckstockoption"), frmcheckstockoption)
        dt1 = ff.dt.sumaryproductin_out
        cry.SetDataSource(dt1)

        cry.Database.Tables("tbbusiness").SetDataSource(dttt)
        cry.SetParameterValue("dt1", ff.dt1.Text)
        cry.SetParameterValue("dt2", ff.dt2.Text)
        CrystalReportViewer1.ReportSource = cry

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    'Private Sub report()
    '    dt.Clear()
    '    cn.connect()
    '    cm = New SqlCommand("select * from tbbusiness", cn.conn)
    '    With da
    '        .SelectCommand = cm
    '        .Fill(dt)
    '    End With
    '    cry.SetDatabaseLogon(cn.user, cn.password)
    '    cry.SetDataSource(dt)
    '    CrystalReportViewer1.ReportSource = cry
    'End Sub

End Class