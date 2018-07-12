Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmbillcash
    Dim cn As New connectdb
    Dim saleapprove As New tbapprovedate
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim cry As New billcash
    Dim data1 As New mydata
    Dim saledate As String
    Dim sale As New tbsales
    Private Sub frmbillsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt.Clear()
            Dim dttt As New DataTable

            Dim sumtotal As Double
            sumtotal = sale.sum_viewsaledetail(frmsale.txtid.Text)
            cn.connect()
            da = New SqlDataAdapter("select * from tbbusiness", cn.conn)
            da.Fill(data1.tbbusiness)
            dttt.Clear()
            dttt = data1.tbbusiness
            saledate = saleapprove.call_saleapprovedate(frmsale.txtid.Text)
            If saledate = "" Then
                saledate = frmsale.dtsale.Text
            Else
                saledate = saledate
            End If

            cm = New SqlCommand("select * from viewsaledetail where saleNO=N'" & frmsale.txtid.Text & "'order by saledetailid asc", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With


            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            cry.Database.Tables("tbbusiness").SetDataSource(dttt)
            cry.SetParameterValue("saledate", saledate)
            cry.SetParameterValue("sumtotal", sumtotal)
            cry.SetParameterValue("note", frmsale.txtnote.Text)
            cry.SetParameterValue("Sumvat", frmsale.txttax.Text)
            cry.SetParameterValue("nextpaydate", frmsale.nextday.Value)
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