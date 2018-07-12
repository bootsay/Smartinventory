Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmbillquotation
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim cry As New billquotation
    Dim data1 As New mydata
    Private Sub frmbillquotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from viewsaledetail where saleNO=N'" & frmsale.txtid.Text & "'order by saledetailid asc", cn.conn)
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
            cry.SetParameterValue("Sumvat", frmsale.txttax.Text)
            cry.SetParameterValue("note", frmsale.txtnote.Text)
            CrystalReportViewer1.ReportSource = cry
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class