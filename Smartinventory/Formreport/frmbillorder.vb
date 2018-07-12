Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmbillorder
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cm As New SqlCommand
    Dim cry As New billorder
    Dim data1 As New mydata
    Private Sub frmbillorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'Dim salelist As frmorder = CType(Application.OpenForms("frmorder"), frmorder)
            'Dim fm As frmmain = CType(Application.OpenForms("frmmain"), frmmain)
            'Dim fm1 As frmorder = CType(Application.OpenForms("frmorder"), frmorder)

            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from vieworder where orderNO=N'" & frmcreateorder.txtorderNO.Text & "'order by orderautoid asc", cn.conn)
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
            cry.SetParameterValue("Sumvat", frmcreateorder.txttax.Text)
            CrystalReportViewer1.ReportSource = cry
            'txtorderNO.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class