Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmpaorderdebitbilldetail
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim cry As New billpaysupplierdetail
    Private Sub frmbillsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from viewpayorder where orderNO='" & frmdebitcustomerlist.dgvshow.CurrentRow.Cells(0).Value & "'", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = cry

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class