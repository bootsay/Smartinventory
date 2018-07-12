Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class Frmreportproduct
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt, dt1, dt2 As New DataTable
    Dim cm As New SqlCommand
    Dim cry As New cryproduct
    Dim cate As New tbcategory
    Dim subcate As New tbsubcategory

    Private Sub Frmreport_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rdall.Checked = True
            If rdall.Checked = True Then
                cbcategory.Enabled = False
                cbsupcategory.Enabled = False
            Else
                cbcategory.Enabled = True
                cbsupcategory.Enabled = True
            End If
            cate.combocategory1(cbcategory)
            cbcategory.SelectedValue = 0
            If cbcategory.SelectedValue > 0 Then
                subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            dt.Clear()
            cn.connect()
            Dim catename As String = Nothing
            Dim subname As String = Nothing
            If rdall.Checked = True Then
                subname = "%"

            ElseIf rdcate.Checked = True Then
                If cbcategory.SelectedValue > 0 Then
                    Dim rows As DataRowView = cbsupcategory.SelectedItem
                    Dim row As DataRow = rows.Row
                    subname = row(3).ToString

                End If
            End If
            cm = New SqlCommand("select * from viewproduct where  subname like N'%" & subname & "%' ORDER BY proID ASC", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            cry.SetParameterValue("subname", cbsupcategory.Text)
            CrystalReportViewer1.ReportSource = cry
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcategory.SelectedIndexChanged
        Try
            If cbcategory.SelectedValue > 0 Then
                subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
            Else

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdall_CheckedChanged(sender As Object, e As EventArgs) Handles rdall.CheckedChanged
        If rdall.Checked = True Then
            cbcategory.Enabled = False
            cbsupcategory.Enabled = False
        Else
            cbcategory.Enabled = True
            cbsupcategory.Enabled = True
        End If
    End Sub

    Private Sub rdcate_CheckedChanged(sender As Object, e As EventArgs) Handles rdcate.CheckedChanged
        If rdall.Checked = True Then
            cbcategory.Enabled = False
            cbsupcategory.Enabled = False
        Else
            cbcategory.Enabled = True
            cbsupcategory.Enabled = True
        End If
    End Sub
End Class