Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmbillreceive
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim cry As New billreceive
    Dim data1 As New mydata
    Private Sub frmreportorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt.Clear()
            cn.connect()
            Dim dttt As New DataTable
            dttt.Clear()
            da = New SqlDataAdapter("select * from tbbusiness", cn.conn)
            da.Fill(data1.tbbusiness)
            dttt = data1.tbbusiness
            cm = New SqlCommand("select * from viewreceive where receiveNO='" & frmreceiveproduct.receiveNO & "'", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With

            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.Database.Tables("tbbusiness").SetDataSource(dttt)

            cry.SetDataSource(dt)
            cry.SetParameterValue("Sumvat", frmreceiveproduct.txttax.Text)
            CrystalReportViewer1.ReportSource = cry
            da.Dispose()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class