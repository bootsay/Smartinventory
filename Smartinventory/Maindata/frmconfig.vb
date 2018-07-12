
Public Class frmconfig
    Dim setups As New tbsetup
    Dim frm As frmmain = CType(Application.OpenForms("frmmain"), frmmain)
    Dim cleardata As New tbcleardate
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

   
    Private Sub frmconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtnextpaydate.Text = frm.nextpaydate
            txtremindbeforepay.Text = frm.remindpaydate
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnsale_Click(sender As Object, e As EventArgs) Handles btnsale.Click
        Try
            If MessageBox.Show("ທ່ານຕ້ອງການປ່ຽນແປງການຕັ້ງຄ່າແທ້ບໍ່?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                setups.updatesetup(txtnextpaydate.Text, txtremindbeforepay.Text)
                setups.Call_setup(frm.dtsetup)
                frm.nextpaydate = frm.dtsetup.Rows(0).Item(1)
                frm.remindpaydate = frm.dtsetup.Rows(0).Item(2)
            
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnclearsale_Click(sender As Object, e As EventArgs) Handles btnclearsale.Click
        If MessageBox.Show("ຄໍາເຕືອນ: ຂໍ້ມູນຂອງທ່ານຈະບໍ່ສາມາດກູ້ຄືນໄດ້", "ຄໍາເຕືອນ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            cleardata.deletetbpay()
            cleardata.deletesaledetail()
            cleardata.deletesale()
            cleardata.delete_subitemdetail()
            cleardata.delete_subitem()
        End If
    End Sub

    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        If MessageBox.Show("ຄໍາເຕືອນ: ຂໍ້ມູນຂອງທ່ານຈະບໍ່ສາມາດກູ້ຄືນໄດ້", "ຄໍາເຕືອນ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            cleardata.deletepayorder()
            cleardata.deleteorderdetail()
            cleardata.deleteorder()


        End If
    End Sub

    Private Sub btnreceive_Click(sender As Object, e As EventArgs) Handles btnreceive.Click
        If MessageBox.Show("ຄໍາເຕືອນ: ຂໍ້ມູນຂອງທ່ານຈະບໍ່ສາມາດກູ້ຄືນໄດ້", "ຄໍາເຕືອນ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            cleardata.deletereceiveorderdetail()
            cleardata.deletereceive()
            cleardata.upatestockqty()
        End If
    End Sub
End Class