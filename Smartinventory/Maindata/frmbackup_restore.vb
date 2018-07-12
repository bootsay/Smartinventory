Imports System.Data.SqlClient
Public Class frmbackup_restore
    Dim con, con1 As SqlConnection
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader
    Dim cn As New connectdb

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        server()
    End Sub
    Private Sub server()
        'con = New SqlConnection("Data Source=" & str & ";Database=Master;integrated security=SSPI;")
        'con.Open()
        cn.connect()
        cmd = New SqlCommand("select * from sys.servers", cn.conn)
        dread = cmd.ExecuteReader
        While dread.Read
            cmbserver.Items.Add(dread(1))
        End While
        dread.Close()
    End Sub
    Sub connection()
        'con = New SqlConnection("Data Source=" & Trim(cmbserver.Text) & ";Database=Master;integrated security=SSPI;")
        'con.Open()
        cn.connect()
        cmbdatabase.Items.Clear()
        cmd = New SqlCommand("SELECT name FROM master.dbo.sysdatabases", cn.conn)
        dread = cmd.ExecuteReader
        While dread.Read
            cmbdatabase.Items.Add(dread(0))
        End While
        dread.Close()
    End Sub

    Private Sub cmbserver_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbserver.SelectedIndexChanged
        connection()
    End Sub
    Sub query(ByVal que As String)
        cn.connect()
        On Error Resume Next
        cmd = New SqlCommand(que, cn.conn)
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            MsgBox("ສໍາເລັດ")
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
    End Sub
    Sub blank(ByVal str As String)
        If cmbserver.Text = "" Or cmbdatabase.Text = "" Then
            MessageBox.Show("ກະລຸນາເລືອກຊື່ຖານຊື່ຖານຂໍ້ມູນ ແລະ ຊື່ Server", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            'If str = "backup" Then
            '    SaveFileDialog1.FileName = cmbdatabase.Text

            'If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '    Timer1.Enabled = True
            '    ProgressBar1.Visible = True
            '    'Dim s As String
            '    's = SaveFileDialog1.FileName

            'Else

            'End If
            Dim b As String = System.DateTime.Now
            Dim path As String = Application.StartupPath & "\Database\" & b & ".bak"
            query("backup database " & cmbdatabase.Text & " to disk='" & path & "'")
            ''ElseIf str = "restore" Then
            ''If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ''    Timer1.Enabled = True
            ''    ProgressBar1.Visible = True
            ''    query("RESTORE DATABASE " & cmbdatabase.Text & " FROM disk=N'" & OpenFileDialog1.FileName & "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10")
            ''Else

            ''End If

            'End If
        End If
    End Sub
  

    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        'blank("backup")
        ''SaveFileDialog1.FileName = cmbdatabase.Text
        'SaveFileDialog1.ShowDialog()
        'Timer1.Enabled = True
        'ProgressBar1.Visible = True
        ''Dim s As String
        ''s = SaveFileDialog1.FileName
        'query("backup database " & cmbdatabase.Text & " to disk='" & s & "'")

        ''Dim b As String = System.DateTime.Now
        ''Dim path As String = Application.StartupPath & "\Database\" & s & ""
        ''MessageBox.Show(path)
        ''query("backup database " & cmbdatabase.Text & " to disk='" & path & "'")

        Dim b As String = System.DateTime.Now.ToString("ddMMyyyy")
        SaveFileDialog1.FileName = cmbdatabase.Text
        Timer1.Enabled = True
        ProgressBar1.Visible = True
        Dim s As String
        s = SaveFileDialog1.FileName
        'Dim path As String = Application.StartupPath & "\Database\" & s & ""

        Dim path As String = Application.StartupPath & "\Database\" & b & "" & s & ".bak"
        'MessageBox.Show(b)
        query("backup database smartinventory to disk='" & path & "'")
    End Sub

    Private Sub btnrestore_Click(sender As Object, e As EventArgs) Handles btnrestore.Click
        blank("restore")
    End Sub
End Class
