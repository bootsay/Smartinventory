Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmbillsalesub

    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim cry As New billsalesubitemdetail
    Dim data1 As New mydata
    Dim salesubdate As String
    Private Sub frmbillorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'Dim salelist As frmorder = CType(Application.OpenForms("frmorder"), frmorder)
            'Dim fm As frmmain = CType(Application.OpenForms("frmmain"), frmmain)
            'Dim fm1 As frmorder = CType(Application.OpenForms("frmorder"), frmorder)
            Dim salesum As frmsalesubitem = DirectCast(Application.OpenForms("frmsalesubitem"), frmsalesubitem)
            'MessageBox.Show(salesum.txtid.Text)
            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from viewsalesubitem where saleNO='" & salesum.txtid.Text & "'", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            salesubdate = frmsale.dtsale.Text
            Dim dttt As New DataTable
            da = New SqlDataAdapter("select * from tbbusiness", cn.conn)
            da.Fill(data1.tbbusiness)
            dttt.Clear()
            dttt = data1.tbbusiness

            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            cry.Database.Tables("tbbusiness").SetDataSource(dttt)
            cry.SetParameterValue("subdate", salesubdate)
            CrystalReportViewer1.ReportSource = cry


            'txtorderNO.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class