Public Class frmsetmoney
    Dim mainmoney As New tbsetmoney
    Dim money As String
    Private Sub tbsetmainmoney_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt.Clear()
        mainmoney.select_mainmoney(dt)
        If dt.Rows.Count > 0 Then
            mainmoney.loadmainmoney(dgvlist)
            If dt.Rows(0).Item(1) = "ກີບ" Then
                rdkip.Checked = True
            ElseIf dt.Rows(0).Item(1) = "ບາດ" Then
                rdbth.Checked = True
            ElseIf dt.Rows(0).Item(1) = "ໂດລາ" Then
                rdusd.Checked = True
            End If
        Else
            mainmoney.loadmainmoney(dgvlist)
            rdkip.Checked = True
        End If
     
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim check As Integer = mainmoney.check_existid
        If check > 0 Then
            If rdkip.Checked = True Then
                money = "ກີບ"
            ElseIf rdbth.Checked = True Then
                money = "ບາດ"
            ElseIf rdusd.Checked = True Then
                money = "ໂດລາ"
            End If
            If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງແທ້ບໍ່", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                mainmoney.update(1, money)
                mainmoney.loadmainmoney(dgvlist)
            End If
         
        Else
            If rdkip.Checked = True Then
                money = "ກີບ"
            ElseIf rdbth.Checked = True Then
                money = "ບາດ"
            ElseIf rdusd.Checked = True Then
                money = "ໂດລາ"
            End If
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                mainmoney.savemainmoney(1, money)
                mainmoney.loadmainmoney(dgvlist)
            End If
      
        End If

    End Sub
End Class