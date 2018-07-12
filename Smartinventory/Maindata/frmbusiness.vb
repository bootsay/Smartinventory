Imports System.Data.SqlClient
Public Class frmbusiness
    Dim bsn As New tbbusiness
    Private Sub frmbusinessvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbsnnid.Text = bsn.runbusinessid
        bsn.loadbusiness(dgvshow)
        'enablesave()
        txtbsnnamelao.Select()
        If txtbsnnid.Text = "2" Then
            enablesave()
            btnsave.Enabled = False
        Else
            enableedit()
            btnsave.Enabled = True
        End If

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        'Try

        If txtbsnnid.Text = "2" Then
            MessageBox.Show("ທ່ານບໍ່ສາມາດປ້ອນຂໍ້ມູນໄດ້ອີກແລ້ວ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnsave.Enabled = False
            Exit Sub
        ElseIf txtbsnnamelao.Text = "1" Then
            MessageBox.Show("ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtbsnnamelao.Select()
            Return
        End If
        bsn.savebusiness(txtbsnnid.Text, txtbsnnamelao.Text, txtbsnnameenglish.Text, txtaddress.Text, txttel.Text, txtemail.Text)
        txtbsnnamelao.Clear()
        btnsave.Enabled = False
        bsn.loadbusiness(dgvshow)
        'txtbsnnid.Text = bsn.runbusinessid
        txtbsnnamelao.Select()
        enablesave()
        txtclear()

        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub enablesave()
        'btnsave.Enabled = True
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = False
        'btnnew.Enabled = True
        txtbsnnamelao.Enabled = False
        txtbsnnameenglish.Enabled = False
        txtaddress.Enabled = False
        txttel.Enabled = False
        txtemail.Enabled = False
    End Sub
    Private Sub enableedit()
        btnsave.Enabled = False
        btndelete.Enabled = True
        btnedit.Enabled = True
        btnupdate.Enabled = False
        'btnnew.Enabled = True
        txtbsnnid.Enabled = False
        txtbsnnamelao.Enabled = True
        txtbsnnameenglish.Enabled = True
        txtaddress.Enabled = True
        txttel.Enabled = True
        txtemail.Enabled = True
    End Sub
    Private Sub enableupdate()
        btnsave.Enabled = False
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = True
        'btnnew.Enabled = True
    End Sub
    Private Sub txtclear()
        txtbsnnamelao.Clear()
        txtbsnnameenglish.Clear()
        txtaddress.Clear()
        txttel.Clear()
        txtemail.Clear()
        pimage.Image = pimage.ErrorImage
    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        bsn.deletedatebusiness(txtbsnnid.Text)
        txtbsnnid.Text = bsn.runbusinessid
        bsn.loadbusiness(dgvshow)
        txtbsnnamelao.Select()
        enablesave()
        txtclear()
        btnsave.Enabled = False
        If txtbsnnid.Text = "2" Then
            enablesave()
            btnsave.Enabled = False
        Else
            enableedit()
            btnsave.Enabled = True
        End If
    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtbsnnid.Text = .CurrentRow.Cells(0).Value
                txtbsnnamelao.Text = .CurrentRow.Cells(1).Value
                txtbsnnameenglish.Text = .CurrentRow.Cells(2).Value
                txtaddress.Text = .CurrentRow.Cells(3).Value
                txttel.Text = .CurrentRow.Cells(4).Value
                txtemail.Text = .CurrentRow.Cells(5).Value
                bsn.showimage(dgvshow)
                enablesave()
                btnedit.Enabled = True
                btndelete.Enabled = True
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtbsnnamelao.ReadOnly = False
        txtbsnnamelao.Select()
        enableupdate()
        enableedit()
        btnupdate.Enabled = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        bsn.updatebusiness(txtbsnnid.Text, txtbsnnamelao.Text, txtbsnnameenglish.Text, txtaddress.Text, txttel.Text, txtemail.Text)
        txtbsnnid.ReadOnly = False
        txtbsnnid.Text = bsn.runbusinessid
        bsn.loadbusiness(dgvshow)
        txtbsnnid.Clear()
        txtbsnnamelao.Select()
        enablesave()
        txtclear()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pimage_Click(sender As Object, e As EventArgs) Handles pimage.Click

    End Sub

    Private Sub pimage_MouseClick(sender As Object, e As MouseEventArgs) Handles pimage.MouseClick
        Try
            Dim FilePath As String
            OpenFileDialog1.ShowDialog()
            FilePath = OpenFileDialog1.FileName
            If FilePath <> Nothing Then
                pimage.Image = Image.FromFile(FilePath)
                pimage.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class