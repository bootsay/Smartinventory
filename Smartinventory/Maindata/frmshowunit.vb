Public Class frmshowunit
    Dim unit As New tbunits
    Private Sub frmshowunit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Dim frmproduct As frmproduct1 = CType(Application.OpenForms("frmproduct1"), frmproduct1)
            'Dim frmsale As frmsale = CType(Application.OpenForms("frmsale"), frmsale)
            If frmsale.formsale = True Then
                unit.loadtbunit_byproid(frmsale.dgvsale.CurrentRow.Cells(0).Value, dgvunit)
            ElseIf frmproduct1.formproduct = True Then
                unit.loadtbunit(dgvunit)
            ElseIf frmcreateorder.formcreateorder = True Then
                unit.loadtbunit_byproid(frmcreateorder.dgvlist.CurrentRow.Cells(0).Value, dgvunit)
            ElseIf frmreceiveproduct.formreceive = True Then
                unit.loadtbunit_byproid(frmreceiveproduct.dgvreceive.CurrentRow.Cells(0).Value, dgvunit)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub dgvunit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvunit.CellClick
        'Try
        If frmsale.formsale = True Then
            With dgvunit
                frmsale.dgvsale.CurrentRow.Cells(2).Value = .CurrentRow.Cells(0).Value
                If frmsale.cbprice.SelectedIndex = 1 Then
                    frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(2).Value
                ElseIf frmsale.cbprice.SelectedIndex = 2 Then
                    frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(3).Value
                ElseIf frmsale.cbprice.SelectedIndex = 3 Then
                    frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(4).Value
                ElseIf frmsale.cbprice.SelectedIndex = 4 Then
                    frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(5).Value
                End If
                frmsale.dgvsale.CurrentRow.Cells(9).Value = .CurrentRow.Cells(1).Value
                Me.Close()
            End With
        ElseIf frmproduct1.formproduct = True Then
            With dgvunit
                frmproduct1.dgvprice.CurrentRow.Cells(2).Value = .CurrentRow.Cells(1).Value
                frmproduct1.dgvprice.CurrentRow.Cells(8).Value = .CurrentRow.Cells(0).Value
                Me.Close()
            End With
        ElseIf frmcreateorder.formcreateorder = True Then
            With dgvunit
                frmcreateorder.dgvlist.CurrentRow.Cells(2).Value = .CurrentRow.Cells(0).Value
                frmcreateorder.dgvlist.CurrentRow.Cells(6).Value = .CurrentRow.Cells(1).Value
            End With
            Me.Close()
        End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
End Class