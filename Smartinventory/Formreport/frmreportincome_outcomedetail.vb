Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmreportincome_outcomedetail
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim cm As New SqlCommand
    Dim income As New tbincomesource

    Private Sub frmreportincome_outcomedetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt1.Text = Today.Date
            dt2.Text = Today.Date
            rddate.Checked = True
            rdall.Checked = True
            income.combosourcetype(cbtype)
            If rdall.Checked = True Then
                cbtype.Enabled = False
            Else
                cbtype.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub show_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Dim type As String = Nothing
        Dim rows As DataRowView = cbtype.SelectedItem
        Dim row As DataRow = rows.Row
        type = row(1).ToString

        Dim dt As New DataTable
        If rdall.Checked = True Then
            dt.Clear()
            cn.connect()
            Dim status1 As String = "%"
            cm = New SqlCommand("select * from viewfinancial where recordedate>='" & Format(CDate(dt1.Text), "MM/dd/yyyy") & "' and recordedate<='" & Format(CDate(dt2.Text), "MM/dd/yyyy") & "'", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            Dim cry As New cryreportfinancial
            cry.SetDataSource(dt)
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetParameterValue("dt1", dt1.Text)
            cry.SetParameterValue("dt2", dt2.Text)
            CrystalReportViewer1.ReportSource = cry
        ElseIf rdtype.Checked = True Then
            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from viewfinancial where sourceid='" & cbtype.SelectedValue & "' and recordedate>='" & Format(CDate(dt1.Text), "MM/dd/yyyy") & "' and recordedate<='" & Format(CDate(dt2.Text), "MM/dd/yyyy") & "'", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            Dim cry As New cryreportfinancial
            cry.SetDataSource(dt)
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetParameterValue("dt1", dt1.Text)
            cry.SetParameterValue("dt2", dt2.Text)
            CrystalReportViewer1.ReportSource = cry
        End If
    End Sub

    Private Sub rdall_CheckedChanged(sender As Object, e As EventArgs) Handles rdall.CheckedChanged
        If rdall.Checked = True Then
            cbtype.Enabled = False
        Else
            cbtype.Enabled = True
        End If
    End Sub
End Class