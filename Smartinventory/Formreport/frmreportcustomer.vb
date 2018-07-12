Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmreportcustomer
    Dim sup As New tbsuppliers
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim cm As New SqlCommand
    Dim dt As New DataTable
    Private Sub frmreportcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim a As Integer = Screen.PrimaryScreen.WorkingArea.Height
            Me.Height = a - 150
            rdall.Checked = True
            If rdall.Checked = True Then
                cbcustomer.Enabled = False
            Else
                cbcustomer.Enabled = True

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub rdspecific_CheckedChanged(sender As Object, e As EventArgs) Handles rdspecific.CheckedChanged
        Try
            sup.combocustype(cbcustomer)
            cbcustomer.SelectedIndex = 0
            If rdall.Checked = True Then
                cbcustomer.Enabled = False
            Else
                cbcustomer.Enabled = True

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Try
            'MessageBox.Show(cbcustomer.SelectedItem)
            dt.Clear()
            cn.connect()
            Dim search As String
            If rdall.Checked = True Then
                search = "%"
                cm = New SqlCommand("select * from tbsuppliers where custype like N'%" & search & "%' order by sup_id asc", cn.conn)
                With da
                    .SelectCommand = cm
                    .Fill(dt)
                End With
            Else
                search = cbcustomer.SelectedItem
                If search = "-ປະເພດລູກຄ້າທັງໜົດ-" Then
                    search = "%"
                Else
                    search = cbcustomer.SelectedItem
                End If
                cm = New SqlCommand("select * from tbsuppliers where custype like N'%" & search & "%' order by sup_id asc", cn.conn)
                With da
                    .SelectCommand = cm
                    .Fill(dt)
                End With

            End If
            Dim cry As New crycustomer
            cry.SetDataSource(dt)
            cry.SetDatabaseLogon(cn.user, cn.password)

            If rdall.Checked = True Then
                cry.SetParameterValue("order", "-ປະເພດລູກຄ້າທັງໜົດ-")
            Else
                cry.SetParameterValue("order", cbcustomer.SelectedItem)
            End If

            CrystalReportViewer1.ReportSource = cry

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class