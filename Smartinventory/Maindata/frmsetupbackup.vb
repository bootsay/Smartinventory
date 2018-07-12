Imports System.Data.SqlClient
Public Class frmsetupbackup
    Dim con, con1 As SqlConnection
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader
    Dim cn As New connectdb
    Dim backup As New tbbackup
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        server()
        backup.loadbackup(dgvshow)
        txtid.Text = backup.runid
        txttimebackup.Text = TimeOfDay.ToString("hh:mm tt")
        If txtid.Text = 2 Then
            txtid.Clear()
            'txttimebackup.Clear()
            txtid.Enabled = False
            cbservername.Enabled = False
            cbdatabasename.Enabled = False
            txttimebackup.Enabled = False
        Else
            txtid.Text = backup.runid
        End If
    End Sub
    Private Sub server()
        'con = New SqlConnection("Data Source=" & str & ";Database=Master;integrated security=SSPI;")
        'con.Open()
        cn.connect()
        cmd = New SqlCommand("select * from sys.servers", cn.conn)
        dread = cmd.ExecuteReader
        While dread.Read
            cbservername.Items.Add(dread(1))
        End While
        dread.Close()
    End Sub
    Sub connection()
        'con = New SqlConnection("Data Source=" & Trim(cmbserver.Text) & ";Database=Master;integrated security=SSPI;")
        'con.Open()
        cn.connect()
        cbdatabasename.Items.Clear()
        cmd = New SqlCommand("SELECT name FROM master.dbo.sysdatabases", cn.conn)
        dread = cmd.ExecuteReader
        While dread.Read
            cbdatabasename.Items.Add(dread(0))
        End While
        dread.Close()
    End Sub

    Private Sub cmbserver_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbservername.SelectedIndexChanged
        connection()
    End Sub
    Sub query(ByVal que As String)
        cn.connect()
        On Error Resume Next
        cmd = New SqlCommand(que, cn.conn)
        cmd.ExecuteNonQuery()
    End Sub
    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    If ProgressBar1.Value = 100 Then
    '        Timer1.Enabled = False
    '        ProgressBar1.Visible = False
    '        MsgBox("ສໍາເລັດ")
    '    Else
    '        ProgressBar1.Value = ProgressBar1.Value + 5
    '    End If
    'End Sub
  
    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        If txtid.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Select()
            Return
        End If
        backup.save(txtid.Text, cbservername.Text, cbdatabasename.Text, txttimebackup.Text)
        backup.loadbackup(dgvshow)
        txtid.Clear()
        'txttimebackup.Clear()
        txtid.Enabled = False
        cbservername.Enabled = False
        cbdatabasename.Enabled = False
        txttimebackup.Enabled = False
    End Sub

    Private Sub btnrestore_Click(sender As Object, e As EventArgs) Handles btnrestore.Click
        backup.update(txtid.Text, cbservername.Text, cbdatabasename.Text, txttimebackup.Text)
        backup.loadbackup(dgvshow)
        txtid.Clear()
        'txttimebackup.Clear()
        txtid.Enabled = False
        cbservername.Enabled = False
        cbdatabasename.Enabled = False
        txttimebackup.Enabled = False
    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                cbservername.Text = .CurrentRow.Cells(1).Value
                cbdatabasename.Text = .CurrentRow.Cells(2).Value
                txttimebackup.Text = .CurrentRow.Cells(3).Value
                txtid.Enabled = False
                cbservername.Enabled = True
                cbdatabasename.Enabled = True
                txttimebackup.Enabled = True
                btnbackup.Enabled = False
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
