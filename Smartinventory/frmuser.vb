Public Class frmuser
    Dim user As New tbuser

    Dim frmsale1 As String
    Dim frmproductinfo11 As String
    Dim frmsumarysale111 As String
    Dim frmsalelistapprove1 As String
    Dim frmsumarysale11 As String
    Dim frmreportsale1 As String

    Dim frmproduct11 As String
    Dim frmcheckstock11 As String
    Dim frmorder11 As String
    Dim frmreceiveproduct11 As String
    Dim frmreturnproduct11 As String
    Dim frmstockin_out11 As String
    Dim frmstockreport11 As String

    Dim frmaddress11 As String
    Dim frmcustomer11 As String
    Dim frmcustomerdebit11 As String
    Dim frmdebitcustomer11 As String
    Dim frmreportcustomer11 As String

    Dim frmincome_outcome11 As String
    Dim frmreportdaily11 As String

    Dim frmmainproduct1 As String
    Dim frmuser11 As String
    Dim frmexchange11 As String
    Dim frmsalename11 As String
    Dim frmbusiness11 As String
    Dim frmbackup11 As String
    Dim frmconfig11 As String
    Dim frmother1 As String

    Dim btnupdate41 As String
    Dim btndelete41 As String
    Dim btnreceive11 As String
    Dim btncancel11 As String
    Dim btncancel21 As String
    Dim btnapprove31 As String
    Dim btncancel31 As String
    Dim btncancel41 As String
    Dim btnapprove51 As String
    Dim btncancel51 As String
    Dim btnunaprove1 As String
    Dim cbkcash1 As String
    Dim cbksent1 As String
    Dim cbkshowprice1 As String

    Private Sub enablesave()
        btnsave.Enabled = True
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = False
        btnnew.Enabled = True
    End Sub
    Private Sub enableedit()
        btnsave.Enabled = False
        btndelete.Enabled = True
        btnedit.Enabled = True
        btnupdate.Enabled = False
        btnnew.Enabled = True
    End Sub
    Private Sub enableupdate()
        btnsave.Enabled = False
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = True
        btnnew.Enabled = True
    End Sub

    Private Sub frmuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        txtid.Text = user.runid
        user.loaduser(dgvuser)
        txteng.Select()
        enablesave()
        user.combolevel(cblevel)
        cbadmin.Checked = True

        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub disabletext()
        txteng.ReadOnly = True
        txtlao.ReadOnly = True
        txtdept.ReadOnly = True
        txtposition.ReadOnly = True
        txtpassword.ReadOnly = True

    End Sub
    Private Sub Enabletext()
        txteng.ReadOnly = False
        txtlao.ReadOnly = False
        txtdept.ReadOnly = False
        txtposition.ReadOnly = False
        txtpassword.ReadOnly = False
    End Sub
    Private Sub cleartext()
        txteng.Clear()
        txtlao.Clear()
        txtdept.Clear()
        txtpassword.Clear()
        txtposition.Clear()
        cblevel.Text = "ເລືອກ"
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If cbkcash.Checked = True Then
            cbkcash1 = "T"
        Else
            cbkcash1 = "F"
        End If
        If cbksent.Checked = True Then
            cbksent1 = "T"
        Else
            cbksent1 = "F"
        End If
        If cbkshowprice.Checked = True Then
            cbkshowprice1 = "T"
        Else
            cbkshowprice1 = "F"
        End If
        If frmsale11.Checked = True Then
            frmsale1 = "T"
        Else
            frmsale1 = "F"
        End If

        If frmsale11.Checked = True Then
            frmsale1 = "T"
        Else
            frmsale1 = "F"
        End If
        If frmproductinfo.Checked = True Then
            frmproductinfo11 = "T"
        Else
            frmproductinfo11 = "F"
        End If
        If frmsalelistapprove.Checked = True Then
            frmsalelistapprove1 = "T"
        Else
            frmsalelistapprove1 = "F"
        End If
        If frmsumarysale.Checked = True Then
            frmsumarysale11 = "T"
        Else
            frmsumarysale11 = "F"
        End If
        If frmreportsale.Checked = True Then
            frmreportsale1 = "T"
        Else
            frmreportsale1 = "F"
        End If

        If frmproduct12.Checked = True Then
            frmproduct11 = "T"
        Else
            frmproduct11 = "F"
        End If
        If frmcheckstock.Checked = True Then
            frmcheckstock11 = "T"
        Else
            frmcheckstock11 = "F"
        End If
        If frmorder.Checked = True Then
            frmorder11 = "T"
        Else
            frmorder11 = "F"
        End If
        If frmreceiveproduct.Checked = True Then
            frmreceiveproduct11 = "T"
        Else
            frmreceiveproduct11 = "F"
        End If
        If frmreturnproduct.Checked = True Then
            frmreturnproduct11 = "T"
        Else
            frmreturnproduct11 = "F"
        End If
        If frmstockin_out.Checked = True Then
            frmstockin_out11 = "T"
        Else
            frmstockin_out11 = "F"
        End If
        If frmstockreport.Checked = True Then
            frmstockreport11 = "T"
        Else
            frmstockreport11 = "F"
        End If


        If frmaddress.Checked = True Then
            frmaddress11 = "T"
        Else
            frmaddress11 = "F"
        End If
        If frmcustomer.Checked = True Then
            frmcustomer11 = "T"
        Else
            frmcustomer11 = "F"
        End If
        If frmcustomerdebit.Checked = True Then
            frmcustomerdebit11 = "T"
        Else
            frmcustomerdebit11 = "F"
        End If
        If frmdebitcustomer.Checked = True Then
            frmdebitcustomer11 = "T"
        Else
            frmdebitcustomer11 = "F"
        End If
        If frmreportcustomer.Checked = True Then
            frmreportcustomer11 = "T"
        Else
            frmreportcustomer11 = "F"
        End If


        If frmmainproduct.Checked = True Then
            frmmainproduct1 = "T"
        Else
            frmmainproduct1 = "F"
        End If
        If frmuser1.Checked = True Then
            frmuser11 = "T"
        Else
            frmuser11 = "F"
        End If
        If frmexchange.Checked = True Then
            frmexchange11 = "T"
        Else
            frmexchange11 = "F"
        End If
        If frmsalename.Checked = True Then
            frmsalename11 = "T"
        Else
            frmsalename11 = "F"
        End If
        If frmbusiness.Checked = True Then
            frmbusiness11 = "T"
        Else
            frmbusiness11 = "F"
        End If
        If frmbackup.Checked = True Then
            frmbackup11 = "T"
        Else
            frmbackup11 = "F"
        End If
        If frmconfig.Checked = True Then
            frmconfig11 = "T"
        Else
            frmconfig11 = "F"
        End If
        If frmother.Checked = True Then
            frmother1 = "T"
        Else
            frmother1 = "F"
        End If

        If frmincome_outcome.Checked = True Then
            frmincome_outcome11 = "T"
        Else
            frmincome_outcome11 = "F"
        End If
        If frmreportdaily.Checked = True Then
            frmreportdaily11 = "T"
        Else
            frmreportdaily11 = "F"
        End If

        If btnupdate4.Checked = True Then
            btnupdate41 = "T"
        Else
            btnupdate41 = "F"
        End If
        If btndelete4.Checked = True Then
            btndelete41 = "T"
        Else
            btndelete41 = "F"
        End If
        If btnreceive1.Checked = True Then
            btnreceive11 = "T"
        Else
            btnreceive11 = "F"
        End If
        If btncancel1.Checked = True Then
            btncancel11 = "T"
        Else
            btncancel11 = "F"
        End If
        If btncancel2.Checked = True Then
            btncancel21 = "T"
        Else
            btncancel21 = "F"
        End If
        If btnapprove3.Checked = True Then
            btnapprove31 = "T"
        Else
            btnapprove31 = "F"
        End If
        If btncancel3.Checked = True Then
            btncancel31 = "T"
        Else
            btncancel31 = "F"
        End If

        If btncancel4.Checked = True Then
            btncancel41 = "T"
        Else
            btncancel41 = "F"
        End If

        If btnapprove5.Checked = True Then
            btnapprove51 = "T"
        Else
            btnapprove51 = "F"
        End If

        If btncancel5.Checked = True Then
            btncancel51 = "T"
        Else
            btncancel51 = "F"
        End If
        If btnunaprove.Checked = True Then
            btnunaprove1 = "T"
        Else
            btnunaprove1 = "F"
        End If
        Dim auth As String = frmsale1 + frmproductinfo11 + frmsalelistapprove1 + frmsumarysale11 + frmreportsale1 + frmproduct11 + frmcheckstock11 + frmorder11 + frmreceiveproduct11 + frmreturnproduct11 + frmstockin_out11 + frmstockreport11 + frmaddress11 + frmcustomer11 + frmcustomerdebit11 + frmdebitcustomer11 + frmreportcustomer11 + frmmainproduct1 + frmuser11 + frmexchange11 + frmsalename11 + frmbusiness11 + frmbackup11 + frmconfig11 + frmother1 + frmincome_outcome11 + frmreportdaily11 + btnupdate41 + btndelete41 + btnreceive11 + btncancel11 + btncancel21 + btnapprove31 + btncancel31 + btncancel41 + btnapprove51 + btncancel51 + cbkcash1 + cbksent1 + cbkshowprice1 + btnunaprove1
        Dim checkusername As String = user.check_userduplicatename(txtusername.Text)
        If checkusername = "True" Then
            MessageBox.Show("ມີຊື່ນີ້ແລ້ວໃນຖານຂໍ້ມູນ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txteng.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື້ຜູ້ໃຊ້", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txteng.Select()
            Return
        End If
        If txtlao.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື້ພາສາລາວ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtlao.Select()
            Return
        End If
        If txtdept.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື່ພະແນກ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtdept.Select()
            Return
        End If
        If txtpassword.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນລະຫັດການໍາໃຊ້ລະບົບ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword.Select()
            Return
        End If
        If cblevel.Text = "ເລືອກ" Then
            MessageBox.Show("ກະລຸນາເລືອກສິດທິການນໍາໃຊ້", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        user.save(txtid.Text, txteng.Text, txtlao.Text, txtdept.Text, txtposition.Text, txtpassword.Text, cblevel.SelectedValue, auth)
        cleartext()
        txtid.Text = user.runid
        user.loaduser(dgvuser)
        enablesave()
        txteng.Select()
    End Sub

    Private Sub dgvuser_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvuser.CellFormatting
        Try
            If e.ColumnIndex = 5 Then
                e.Value = "****"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvuser_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvuser.CellMouseUp
        With dgvuser
            txtid.Text = .CurrentRow.Cells(0).Value
            txteng.Text = .CurrentRow.Cells(1).Value
            txtlao.Text = .CurrentRow.Cells(2).Value
            txtdept.Text = .CurrentRow.Cells(3).Value
            txtposition.Text = .CurrentRow.Cells(4).Value
            txtpassword.Text = .CurrentRow.Cells(5).Value
            cblevel.Text = .CurrentRow.Cells(6).Value
            txtuserid.Text = .CurrentRow.Cells(0).Value
            txtusername.Text = .CurrentRow.Cells(6).Value

            disabletext()
            enableedit()
        End With
        If dgvuser.CurrentRow.Cells(7).Value = 1 Then
            cbadmin.Checked = True
        Else
            cbuser.Checked = True
        End If
        'TabControl1.SelectedTab = Panel2.Select
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Enabletext()
        enableupdate()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        user.delete(txtid.Text)
        cleartext()
        txtid.Text = user.runid
        user.loaduser(dgvuser)
        Enabletext()
        enablesave()
        txteng.Select()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If cbkcash.Checked = True Then
            cbkcash1 = "T"
        Else
            cbkcash1 = "F"
        End If
        If cbksent.Checked = True Then
            cbksent1 = "T"
        Else
            cbksent1 = "F"
        End If
        If cbkshowprice.Checked = True Then
            cbkshowprice1 = "T"
        Else
            cbkshowprice1 = "F"
        End If
        If frmsale11.Checked = True Then
            frmsale1 = "T"
        Else
            frmsale1 = "F"
        End If
        If frmproductinfo.Checked = True Then
            frmproductinfo11 = "T"
        Else
            frmproductinfo11 = "F"
        End If
        If frmsalelistapprove.Checked = True Then
            frmsalelistapprove1 = "T"
        Else
            frmsalelistapprove1 = "F"
        End If
        If frmsumarysale.Checked = True Then
            frmsumarysale11 = "T"
        Else
            frmsumarysale11 = "F"
        End If
        If frmreportsale.Checked = True Then
            frmreportsale1 = "T"
        Else
            frmreportsale1 = "F"
        End If

        If frmproduct12.Checked = True Then
            frmproduct11 = "T"
        Else
            frmproduct11 = "F"
        End If
        If frmcheckstock.Checked = True Then
            frmcheckstock11 = "T"
        Else
            frmcheckstock11 = "F"
        End If
        If frmorder.Checked = True Then
            frmorder11 = "T"
        Else
            frmorder11 = "F"
        End If
        If frmreceiveproduct.Checked = True Then
            frmreceiveproduct11 = "T"
        Else
            frmreceiveproduct11 = "F"
        End If
        If frmreturnproduct.Checked = True Then
            frmreturnproduct11 = "T"
        Else
            frmreturnproduct11 = "F"
        End If
        If frmstockin_out.Checked = True Then
            frmstockin_out11 = "T"
        Else
            frmstockin_out11 = "F"
        End If
        If frmstockreport.Checked = True Then
            frmstockreport11 = "T"
        Else
            frmstockreport11 = "F"
        End If


        If frmaddress.Checked = True Then
            frmaddress11 = "T"
        Else
            frmaddress11 = "F"
        End If
        If frmcustomer.Checked = True Then
            frmcustomer11 = "T"
        Else
            frmcustomer11 = "F"
        End If
        If frmcustomerdebit.Checked = True Then
            frmcustomerdebit11 = "T"
        Else
            frmcustomerdebit11 = "F"
        End If
        If frmdebitcustomer.Checked = True Then
            frmdebitcustomer11 = "T"
        Else
            frmdebitcustomer11 = "F"
        End If
        If frmreportcustomer.Checked = True Then
            frmreportcustomer11 = "T"
        Else
            frmreportcustomer11 = "F"
        End If


        If frmmainproduct.Checked = True Then
            frmmainproduct1 = "T"
        Else
            frmmainproduct1 = "F"
        End If
        If frmuser1.Checked = True Then
            frmuser11 = "T"
        Else
            frmuser11 = "F"
        End If
        If frmexchange.Checked = True Then
            frmexchange11 = "T"
        Else
            frmexchange11 = "F"
        End If
        If frmsalename.Checked = True Then
            frmsalename11 = "T"
        Else
            frmsalename11 = "F"
        End If
        If frmbusiness.Checked = True Then
            frmbusiness11 = "T"
        Else
            frmbusiness11 = "F"
        End If
        If frmbackup.Checked = True Then
            frmbackup11 = "T"
        Else
            frmbackup11 = "F"
        End If
        If frmconfig.Checked = True Then
            frmconfig11 = "T"
        Else
            frmconfig11 = "F"
        End If
        If frmother.Checked = True Then
            frmother1 = "T"
        Else
            frmother1 = "F"
        End If

        If frmincome_outcome.Checked = True Then
            frmincome_outcome11 = "T"
        Else
            frmincome_outcome11 = "F"
        End If
        If frmreportdaily.Checked = True Then
            frmreportdaily11 = "T"
        Else
            frmreportdaily11 = "F"
        End If

        If btnupdate4.Checked = True Then
            btnupdate41 = "T"
        Else
            btnupdate41 = "F"
        End If
        If btndelete4.Checked = True Then
            btndelete41 = "T"
        Else
            btndelete41 = "F"
        End If
        If btnreceive1.Checked = True Then
            btnreceive11 = "T"
        Else
            btnreceive11 = "F"
        End If
        If btncancel1.Checked = True Then
            btncancel11 = "T"
        Else
            btncancel11 = "F"
        End If
        If btncancel2.Checked = True Then
            btncancel21 = "T"
        Else
            btncancel21 = "F"
        End If
        If btnapprove3.Checked = True Then
            btnapprove31 = "T"
        Else
            btnapprove31 = "F"
        End If
        If btncancel3.Checked = True Then
            btncancel31 = "T"
        Else
            btncancel31 = "F"
        End If

        If btncancel4.Checked = True Then
            btncancel41 = "T"
        Else
            btncancel41 = "F"
        End If

        If btnapprove5.Checked = True Then
            btnapprove51 = "T"
        Else
            btnapprove51 = "F"
        End If

        If btncancel5.Checked = True Then
            btncancel51 = "T"
        Else
            btncancel51 = "F"
        End If

        If btnunaprove.Checked = True Then
            btnunaprove1 = "T"
        Else
            btnunaprove1 = "F"
        End If
        Dim auth As String = frmsale1 + frmproductinfo11 + frmsalelistapprove1 + frmsumarysale11 + frmreportsale1 + frmproduct11 + frmcheckstock11 + frmorder11 + frmreceiveproduct11 + frmreturnproduct11 + frmstockin_out11 + frmstockreport11 + frmaddress11 + frmcustomer11 + frmcustomerdebit11 + frmdebitcustomer11 + frmreportcustomer11 + frmmainproduct1 + frmuser11 + frmexchange11 + frmsalename11 + frmbusiness11 + frmbackup11 + frmconfig11 + frmother1 + frmincome_outcome11 + frmreportdaily11 + btnupdate41 + btndelete41 + btnreceive11 + btncancel11 + btncancel21 + btnapprove31 + btncancel31 + btncancel41 + btnapprove51 + btncancel51 + cbkcash1 + cbksent1 + cbkshowprice1 + btnunaprove1
       If txteng.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື້ຜູ້ໃຊ້", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txteng.Select()
            Return
        End If
        If txtlao.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື້ພາສາລາວ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtlao.Select()
            Return
        End If
        If txtdept.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື່ພະແນກ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtdept.Select()
            Return
        End If
        If txtpassword.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນລະຫັດການໍາໃຊ້ລະບົບ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword.Select()
            Return
        End If
        If cblevel.Text = "ເລືອກ" Then
            MessageBox.Show("ກະລຸນາເລືອກສິດທິການນໍາໃຊ້", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        user.update(txtid.Text, txteng.Text, txtlao.Text, txtdept.Text, txtposition.Text, txtpassword.Text, cblevel.SelectedValue, auth)
        cleartext()
        txtid.Text = user.runid
        user.loaduser(dgvuser)
        enablesave()
        txteng.Select()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Enabletext()
        cleartext()
        txtid.Text = user.runid
        user.loaduser(dgvuser)
        enablesave()
        txteng.Select()
    End Sub


    Private Sub cbadmin_CheckedChanged(sender As Object, e As EventArgs) Handles cbadmin.CheckedChanged
        If cbadmin.Checked = True Then
            frmsale11.Checked = True
            frmsalelistapprove.Checked = True
            frmsumarysale.Checked = True
            frmreportsale.Checked = True
            frmproduct12.Checked = True
            frmorder.Checked = True
            frmreceiveproduct.Checked = True
            frmreturnproduct.Checked = True
            frmstockin_out.Checked = True
            frmstockreport.Checked = True
            frmaddress.Checked = True
            frmcustomer.Checked = True
            frmcustomerdebit.Checked = True
            frmdebitcustomer.Checked = True
            frmreportcustomer.Checked = True
            frmmainproduct.Checked = True
            frmuser1.Checked = True
            frmexchange.Checked = True
            frmsalename.Checked = True
            frmbusiness.Checked = True
            frmbackup.Checked = True
            frmconfig.Checked = True
            btnupdate4.Checked = True
            btndelete4.Checked = True
            btnreceive1.Checked = True
            btncancel1.Checked = True
            btncancel2.Checked = True
            btnapprove3.Checked = True
            btncancel3.Checked = True
            btncancel4.Checked = True
            btnapprove5.Checked = True
            btncancel5.Checked = True
            frmproductinfo.Checked = True
            frmcheckstock.Checked = True
            frmother.Checked = True
            frmincome_outcome.Checked = True
            frmreportdaily.Checked = True
            cbkcash.Checked = True
            cbksent.Checked = True
            cbkshowprice.Checked = True
            btnunaprove.Checked = True
        End If
    End Sub

    Private Sub cbuser_CheckedChanged(sender As Object, e As EventArgs) Handles cbuser.CheckedChanged
        If cbuser.Checked = True Then
            frmsale11.Checked = False
            frmsalelistapprove.Checked = False
            frmsumarysale.Checked = False
            frmreportsale.Checked = False
            frmproduct12.Checked = False
            frmorder.Checked = False
            frmreceiveproduct.Checked = False
            frmreturnproduct.Checked = False
            frmstockin_out.Checked = False
            frmstockreport.Checked = False
            frmaddress.Checked = False
            frmcustomer.Checked = False
            frmcustomerdebit.Checked = False
            frmdebitcustomer.Checked = False
            frmreportcustomer.Checked = False
            frmmainproduct.Checked = False
            frmuser1.Checked = False
            frmexchange.Checked = False
            frmsalename.Checked = False
            frmbusiness.Checked = False
            frmbackup.Checked = False
            frmconfig.Checked = False
            btnupdate4.Checked = False
            btndelete4.Checked = False
            btnreceive1.Checked = False
            btncancel1.Checked = False
            btncancel2.Checked = False
            btnapprove3.Checked = False
            btncancel3.Checked = False
            btncancel4.Checked = False
            btnapprove5.Checked = False
            btncancel5.Checked = False
            frmproductinfo.Checked = False
            frmcheckstock.Checked = False
            frmother.Checked = False
            frmincome_outcome.Checked = False
            frmreportdaily.Checked = False
            cbkcash.Checked = False
            cbksent.Checked = False
            cbkshowprice.Checked = False
            btnunaprove.Checked = False
        End If
    End Sub

    Private Sub cblevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cblevel.SelectedIndexChanged
        Try
            If cblevel.SelectedValue = 1 Then
                cbadmin.Checked = True
            Else
                cbuser.Checked = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdatelevel_Click(sender As Object, e As EventArgs) Handles btnupdatelevel.Click
        Try
            If cbkcash.Checked = True Then
                cbkcash1 = "T"
            Else
                cbkcash1 = "F"
            End If
            If cbksent.Checked = True Then
                cbksent1 = "T"
            Else
                cbksent1 = "F"
            End If
            If cbkshowprice.Checked = True Then
                cbkshowprice1 = "T"
            Else
                cbkshowprice1 = "F"
            End If
            If frmsale11.Checked = True Then
                frmsale1 = "T"
            Else
                frmsale1 = "F"
            End If
            If frmproductinfo.Checked = True Then
                frmproductinfo11 = "T"
            Else
                frmproductinfo11 = "F"
            End If
            If frmsalelistapprove.Checked = True Then
                frmsalelistapprove1 = "T"
            Else
                frmsalelistapprove1 = "F"
            End If
            If frmsumarysale.Checked = True Then
                frmsumarysale11 = "T"
            Else
                frmsumarysale11 = "F"
            End If
            If frmreportsale.Checked = True Then
                frmreportsale1 = "T"
            Else
                frmreportsale1 = "F"
            End If

            If frmproduct12.Checked = True Then
                frmproduct11 = "T"
            Else
                frmproduct11 = "F"
            End If
            If frmcheckstock.Checked = True Then
                frmcheckstock11 = "T"
            Else
                frmcheckstock11 = "F"
            End If
            If frmorder.Checked = True Then
                frmorder11 = "T"
            Else
                frmorder11 = "F"
            End If
            If frmreceiveproduct.Checked = True Then
                frmreceiveproduct11 = "T"
            Else
                frmreceiveproduct11 = "F"
            End If
            If frmreturnproduct.Checked = True Then
                frmreturnproduct11 = "T"
            Else
                frmreturnproduct11 = "F"
            End If
            If frmstockin_out.Checked = True Then
                frmstockin_out11 = "T"
            Else
                frmstockin_out11 = "F"
            End If
            If frmstockreport.Checked = True Then
                frmstockreport11 = "T"
            Else
                frmstockreport11 = "F"
            End If


            If frmaddress.Checked = True Then
                frmaddress11 = "T"
            Else
                frmaddress11 = "F"
            End If
            If frmcustomer.Checked = True Then
                frmcustomer11 = "T"
            Else
                frmcustomer11 = "F"
            End If
            If frmcustomerdebit.Checked = True Then
                frmcustomerdebit11 = "T"
            Else
                frmcustomerdebit11 = "F"
            End If
            If frmdebitcustomer.Checked = True Then
                frmdebitcustomer11 = "T"
            Else
                frmdebitcustomer11 = "F"
            End If
            If frmreportcustomer.Checked = True Then
                frmreportcustomer11 = "T"
            Else
                frmreportcustomer11 = "F"
            End If


            If frmmainproduct.Checked = True Then
                frmmainproduct1 = "T"
            Else
                frmmainproduct1 = "F"
            End If
            If frmuser1.Checked = True Then
                frmuser11 = "T"
            Else
                frmuser11 = "F"
            End If
            If frmexchange.Checked = True Then
                frmexchange11 = "T"
            Else
                frmexchange11 = "F"
            End If
            If frmsalename.Checked = True Then
                frmsalename11 = "T"
            Else
                frmsalename11 = "F"
            End If
            If frmbusiness.Checked = True Then
                frmbusiness11 = "T"
            Else
                frmbusiness11 = "F"
            End If
            If frmbackup.Checked = True Then
                frmbackup11 = "T"
            Else
                frmbackup11 = "F"
            End If
            If frmconfig.Checked = True Then
                frmconfig11 = "T"
            Else
                frmconfig11 = "F"
            End If
            If frmother.Checked = True Then
                frmother1 = "T"
            Else
                frmother1 = "F"
            End If

            If frmincome_outcome.Checked = True Then
                frmincome_outcome11 = "T"
            Else
                frmincome_outcome11 = "F"
            End If
            If frmreportdaily.Checked = True Then
                frmreportdaily11 = "T"
            Else
                frmreportdaily11 = "F"
            End If

            If btnupdate4.Checked = True Then
                btnupdate41 = "T"
            Else
                btnupdate41 = "F"
            End If
            If btndelete4.Checked = True Then
                btndelete41 = "T"
            Else
                btndelete41 = "F"
            End If
            If btnreceive1.Checked = True Then
                btnreceive11 = "T"
            Else
                btnreceive11 = "F"
            End If
            If btncancel1.Checked = True Then
                btncancel11 = "T"
            Else
                btncancel11 = "F"
            End If
            If btncancel2.Checked = True Then
                btncancel21 = "T"
            Else
                btncancel21 = "F"
            End If
            If btnapprove3.Checked = True Then
                btnapprove31 = "T"
            Else
                btnapprove31 = "F"
            End If
            If btncancel3.Checked = True Then
                btncancel31 = "T"
            Else
                btncancel31 = "F"
            End If

            If btncancel4.Checked = True Then
                btncancel41 = "T"
            Else
                btncancel41 = "F"
            End If

            If btnapprove5.Checked = True Then
                btnapprove51 = "T"
            Else
                btnapprove51 = "F"
            End If

            If btncancel5.Checked = True Then
                btncancel51 = "T"
            Else
                btncancel51 = "F"
            End If

            If btnunaprove.Checked = True Then
                btnunaprove1 = "T"
            Else
                btnunaprove1 = "F"
            End If
            Dim auth As String = frmsale1 + frmproductinfo11 + frmsalelistapprove1 + frmsumarysale11 + frmreportsale1 + frmproduct11 + frmcheckstock11 + frmorder11 + frmreceiveproduct11 + frmreturnproduct11 + frmstockin_out11 + frmstockreport11 + frmaddress11 + frmcustomer11 + frmcustomerdebit11 + frmdebitcustomer11 + frmreportcustomer11 + frmmainproduct1 + frmuser11 + frmexchange11 + frmsalename11 + frmbusiness11 + frmbackup11 + frmconfig11 + frmother1 + frmincome_outcome11 + frmreportdaily11 + btnupdate41 + btndelete41 + btnreceive11 + btncancel11 + btncancel21 + btnapprove31 + btncancel31 + btncancel41 + btnapprove51 + btncancel51 + cbkcash1 + cbksent1 + cbkshowprice1 + btnunaprove1
            user.updateauth(txtuserid.Text, auth)
            MessageBox.Show("ທ່ານກໍານົດສິດທິສໍາເລັດແລ້ວ", "ຜົນການກວດສອບ")
            txtclear()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtclear()
        frmsale11.Checked = False
        frmsalelistapprove.Checked = False
        frmsumarysale.Checked = False
        frmreportsale.Checked = False
        frmproduct12.Checked = False
        frmorder.Checked = False
        frmreceiveproduct.Checked = False
        frmreturnproduct.Checked = False
        frmstockin_out.Checked = False
        frmstockreport.Checked = False
        frmaddress.Checked = False
        frmcustomer.Checked = False
        frmcustomerdebit.Checked = False
        frmdebitcustomer.Checked = False
        frmreportcustomer.Checked = False
        frmmainproduct.Checked = False
        frmuser1.Checked = False
        frmexchange.Checked = False
        frmsalename.Checked = False
        frmbusiness.Checked = False
        frmbackup.Checked = False
        frmconfig.Checked = False
        btnupdate4.Checked = False
        btndelete4.Checked = False
        btnreceive1.Checked = False
        btncancel1.Checked = False
        btncancel2.Checked = False
        btnapprove3.Checked = False
        btncancel3.Checked = False
        btncancel4.Checked = False
        btnapprove5.Checked = False
        btncancel5.Checked = False
        frmincome_outcome.Checked = False
        frmreportdaily.Checked = False
        cbadmin.Checked = False
        cbuser.Checked = False
        frmproductinfo.Checked = False
        frmcheckstock.Checked = False
        frmother.Checked = False
        cbkcash.Checked = False
        cbksent.Checked = False
        cbkshowprice.Checked = False
        btnunaprove.Checked = False
        txtid.Clear()
        txteng.Clear()
        txtlao.Clear()
        txtdept.Clear()
        txtposition.Clear()
        txtpassword.Clear()
    End Sub
    Private Sub TabItem3_Click(sender As Object, e As EventArgs) Handles TabItem3.Click
        'If dgvuser.CurrentRow.Cells(0).Value < 1 Then
        '    MessageBox.Show("r")
        '    Return
        'End If
        Try
            Dim auth As String
            auth = user.user_auth(dgvuser.CurrentRow.Cells(0).Value)

            If auth.Substring(0, 1) = "T" Then
                frmsale11.Checked = True
            Else
                frmsale11.Checked = False
            End If
            If auth.Substring(1, 1) = "T" Then
                frmproductinfo.Checked = True
            Else
                frmproductinfo.Checked = False
            End If
            If auth.Substring(2, 1) = "T" Then
                frmsalelistapprove.Checked = True
            Else
                frmsalelistapprove.Checked = False
            End If
            If auth.Substring(3, 1) = "T" Then
                frmsumarysale.Checked = True
            Else
                frmsumarysale.Checked = False
            End If
            If auth.Substring(4, 1) = "T" Then
                frmreportsale.Checked = True
            Else
                frmreportsale.Checked = False
            End If
            If auth.Substring(5, 1) = "T" Then
                frmproduct12.Checked = True
            Else
                frmproduct12.Checked = False
            End If
            If auth.Substring(6, 1) = "T" Then
                frmcheckstock.Checked = True
            Else
                frmcheckstock.Checked = False
            End If
            If auth.Substring(7, 1) = "T" Then
                frmorder.Checked = True
            Else
                frmorder.Checked = False
            End If
            If auth.Substring(8, 1) = "T" Then
                frmreceiveproduct.Checked = True
            Else
                frmreceiveproduct.Checked = False
            End If
            If auth.Substring(9, 1) = "T" Then
                frmreturnproduct.Checked = True
            Else
                frmreturnproduct.Checked = False
            End If
            If auth.Substring(10, 1) = "T" Then
                frmstockin_out.Checked = True
            Else
                frmstockin_out.Checked = False
            End If
            If auth.Substring(11, 1) = "T" Then
                frmstockreport.Checked = True
            Else
                frmstockreport.Checked = False
            End If
            If auth.Substring(12, 1) = "T" Then
                frmaddress.Checked = True
            Else
                frmaddress.Checked = False
            End If
            If auth.Substring(13, 1) = "T" Then
                frmcustomer.Checked = True
            Else
                frmcustomer.Checked = False
            End If
            If auth.Substring(14, 1) = "T" Then
                frmcustomerdebit.Checked = True
            Else
                frmcustomerdebit.Checked = False
            End If
            If auth.Substring(15, 1) = "T" Then
                frmdebitcustomer.Checked = True
            Else
                frmdebitcustomer.Checked = False
            End If
            If auth.Substring(16, 1) = "T" Then
                frmreportcustomer.Checked = True
            Else
                frmreportcustomer.Checked = False
            End If

            If auth.Substring(17, 1) = "T" Then
                frmmainproduct.Checked = True
            Else
                frmmainproduct.Checked = False
            End If
            If auth.Substring(18, 1) = "T" Then
                frmuser1.Checked = True
            Else
                frmuser1.Checked = False
            End If
            If auth.Substring(19, 1) = "T" Then
                frmexchange.Checked = True
            Else
                frmexchange.Checked = False
            End If
            If auth.Substring(20, 1) = "T" Then
                frmsalename.Checked = True
            Else
                frmsalename.Checked = False
            End If
            If auth.Substring(21, 1) = "T" Then
                frmbusiness.Checked = True
            Else
                frmbusiness.Checked = False
            End If
            If auth.Substring(22, 1) = "T" Then
                frmbackup.Checked = True
            Else
                frmbackup.Checked = False
            End If
            If auth.Substring(23, 1) = "T" Then
                frmconfig.Checked = True
            Else
                frmconfig.Checked = False
            End If
            If auth.Substring(24, 1) = "T" Then
                frmother.Checked = True
            Else
                frmother.Checked = False
            End If
            If auth.Substring(25, 1) = "T" Then
                frmincome_outcome.Checked = True
            Else
                frmincome_outcome.Checked = False
            End If
            If auth.Substring(26, 1) = "T" Then
                frmreportdaily.Checked = True
            Else
                frmreportdaily.Checked = False
            End If

            If auth.Substring(27, 1) = "T" Then
                btnupdate4.Checked = True
            Else
                btnupdate4.Checked = False
            End If

            If auth.Substring(28, 1) = "T" Then
                btndelete4.Checked = True
            Else
                btndelete4.Checked = False
            End If

            If auth.Substring(29, 1) = "T" Then
                btnreceive1.Checked = True
            Else
                btnreceive1.Checked = False
            End If

            If auth.Substring(30, 1) = "T" Then
                btncancel1.Checked = True
            Else
                btncancel1.Checked = False
            End If

            If auth.Substring(31, 1) = "T" Then
                btncancel2.Checked = True
            Else
                btncancel2.Checked = False
            End If
            If auth.Substring(32, 1) = "T" Then
                btnapprove3.Checked = True
            Else
                btnapprove3.Checked = False
            End If

            If auth.Substring(33, 1) = "T" Then
                btncancel3.Checked = True
            Else
                btncancel3.Checked = False
            End If

            If auth.Substring(34, 1) = "T" Then
                btncancel4.Checked = True
            Else
                btncancel4.Checked = False
            End If

            If auth.Substring(35, 1) = "T" Then
                btnapprove5.Checked = True
            Else
                btnapprove5.Checked = False
            End If

            If auth.Substring(36, 1) = "T" Then
                btncancel5.Checked = True
            Else
                btncancel5.Checked = False
            End If
            If auth.Substring(37, 1) = "T" Then
                cbkcash.Checked = True
            Else
                cbkcash.Checked = False
            End If
            If auth.Substring(38, 1) = "T" Then
                cbksent.Checked = True
            Else
                cbksent.Checked = False
            End If
            If auth.Substring(39, 1) = "T" Then
                cbkshowprice.Checked = True
            Else
                cbkshowprice.Checked = False
            End If
            If auth.Substring(40, 1) = "T" Then
                btnunaprove.Checked = True
            Else
                btnunaprove.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class