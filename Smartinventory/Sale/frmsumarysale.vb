Public Class frmsumarysale
    Dim sale As New tbsales
    Dim setmoney As New tbsetmoney
    Dim mainmoney As String
    Public dtlist As New DataTable
    Public formsumarysale As Boolean = False
    Public sup_id As String
    Public mydata As New mydata
    Private Sub frmsumarysale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        mainmoney = setmoney.Call_mainmoney
        If mainmoney = "ກີບ" Then
            rdkip.Checked = True
        ElseIf mainmoney = "ບາດ" Then
            rdbath.Checked = True
        Else
            rddolla.Checked = True
        End If

        sale.loadviewsumarysale(dgvmainlist)

        If mainmoney = "ກີບ" Then
            With dgvmainlist
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ຊື່ລູກຄ້າ"
                .Columns(2).HeaderText = "ທັງໜົດ"
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).HeaderText = "ຈ່າຍແລ້ວ"
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).HeaderText = "ຄ້າງຈ່າຍ"
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).DefaultCellStyle.Format = "N0"
                .Columns(5).DefaultCellStyle.Format = "N0"
                '.Columns(8).DefaultCellStyle.Format = "N0"
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

        ElseIf mainmoney = "ບາດ" Then
            With dgvmainlist
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ຊື່ລູກຄ້າ"
                .Columns(2).Visible = False
                .Columns(3).HeaderText = "ທັງໜົດ"
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).HeaderText = "ຈ່າຍແລ້ວ"
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(9).HeaderText = "ຄ້າງຈ່າຍ"
                .Columns(10).Visible = False
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).DefaultCellStyle.Format = "N0"
                .Columns(6).DefaultCellStyle.Format = "N0"
                '.Columns(9).DefaultCellStyle.Format = "N0"
            End With

        Else
            With dgvmainlist
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ຊື່ລູກຄ້າ"
                .Columns(2).Visible = False
                .Columns(3).Visible = False
                .Columns(4).HeaderText = "ທັງໜົດ"
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).HeaderText = "ຈ່າຍແລ້ວ"
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).HeaderText = "ຄ້າງຈ່າຍ"
                .Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Format = "N0"
                '.Columns(10).DefaultCellStyle.Format = "N0"
            End With

        End If



        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub dgvmainlist_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvmainlist.CellMouseUp
        Try
            With dgvmainlist
                sale.Select_viewsaleall_bysupid(dgvmainlist.CurrentRow.Cells(0).Value, dgvbillist)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    Private Sub makesalelist_table()
        Dim proid As New DataGridViewTextBoxColumn
        Dim proname As New DataGridViewTextBoxColumn
        Dim unitname As New DataGridViewTextBoxColumn
        Dim price As New DataGridViewTextBoxColumn
        Dim qty As New DataGridViewTextBoxColumn
        Dim discount As New DataGridViewTextBoxColumn
        Dim free As New DataGridViewCheckBoxColumn
        Dim total As New DataGridViewTextBoxColumn

        dgvpaylist.Columns.Add(proid)
        dgvpaylist.Columns.Add(proname)
        dgvpaylist.Columns.Add(unitname)
        dgvpaylist.Columns.Add(price)
        dgvpaylist.Columns.Add(qty)
        dgvpaylist.Columns.Add(discount)
        dgvpaylist.Columns.Add(free)
        dgvpaylist.Columns.Add(total)
        With dgvpaylist
            .Columns(0).HeaderText = "ລັດຫັດ"
            .Columns(1).HeaderText = "ລາຍການ"
            .Columns(2).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(3).HeaderText = "ລາຄາ"
            .Columns(4).HeaderText = "ຈໍານວນ"
            .Columns(5).HeaderText = "ສ່ວນລຸດ"
            .Columns(6).HeaderText = "ແຖມ"
            .Columns(7).HeaderText = "ລວມ"
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).DefaultCellStyle.Format = "N0"
            .Columns(7).DefaultCellStyle.Format = "N0"
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

    Private Sub dgvbillist_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            dgvpaylist.Columns.Clear()
            dgvpaylist.Rows.Clear()
            dtlist.Clear()
            sale.viewsaledetail_bysaleNO(dgvbillist.CurrentRow.Cells(0).Value, dtlist)
            makesalelist_table()
            For i As Integer = 0 To dtlist.Rows.Count - 1
                Dim proid As String = dtlist.Rows(i).Item(1)
                Dim proname As String = dtlist.Rows(i).Item(2)
                Dim unitname As String = dtlist.Rows(i).Item(3)
                Dim price As Double = dtlist.Rows(i).Item(5)
                Dim qty As Integer = dtlist.Rows(i).Item(6)
                Dim discount As Double = dtlist.Rows(i).Item(7)

                Dim total As Double = dtlist.Rows(i).Item(8)
                Dim free As String
                If total < 1 Then
                    free = True
                Else
                    free = False
                End If
                dgvpaylist.Rows.Add(proid, proname, unitname, price, qty, discount, free, total)
            Next
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub rdall_CheckedChanged(sender As Object, e As EventArgs) Handles rdall.CheckedChanged
    '    If rdall.Checked = True Then
    '        'dt1.Visible = False
    '        'dt2.Visible = False
    '        'txtsearch.Visible = False
    '        'Label1.Visible = False
    '    End If
    'End Sub
    Private Sub rdcustomer_CheckedChanged(sender As Object, e As EventArgs) Handles rdcustomer.CheckedChanged
        Try
            If rdcustomer.Checked = True Then
                txtsearch.Visible = True
                btnshow.Text = "ເລືອກລູກຄ້າ"
            Else
                btnshow.Text = "ສະແດງ"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Try
            If rdcustomer.Checked = True Then

                formsumarysale = True
                frmshowcustomer.ShowDialog()
                frmshowcustomer.Close()
                sale.loadviewsumarysale_bysup_id(sup_id, dgvmainlist)
                If rdkip.Checked = True Then
                    With dgvmainlist
                        .Columns(0).HeaderText = "ລະຫັດ"
                        .Columns(1).HeaderText = "ຊື່ລູກຄ້າ"
                        .Columns(2).HeaderText = "ທັງໜົດ"
                        .Columns(3).Visible = False
                        .Columns(4).Visible = False
                        .Columns(5).HeaderText = "ຈ່າຍແລ້ວ"
                        .Columns(6).Visible = False
                        .Columns(7).Visible = False
                        .Columns(8).HeaderText = "ຄ້າງຈ່າຍ"
                        .Columns(9).Visible = False
                        .Columns(10).Visible = False
                        .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        .Columns(2).DefaultCellStyle.Format = "N0"
                        .Columns(5).DefaultCellStyle.Format = "N0"
                        '.Columns(8).DefaultCellStyle.Format = "N0"
                        .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    End With

                ElseIf rdbath.Checked = True Then
                    With dgvmainlist
                        .Columns(0).HeaderText = "ລະຫັດ"
                        .Columns(1).HeaderText = "ຊື່ລູກຄ້າ"
                        .Columns(2).Visible = False
                        .Columns(3).HeaderText = "ທັງໜົດ"
                        .Columns(4).Visible = False
                        .Columns(5).Visible = False
                        .Columns(6).HeaderText = "ຈ່າຍແລ້ວ"
                        .Columns(7).Visible = False
                        .Columns(8).Visible = False
                        .Columns(9).HeaderText = "ຄ້າງຈ່າຍ"
                        .Columns(10).Visible = False
                        .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        .Columns(3).DefaultCellStyle.Format = "N0"
                        .Columns(6).DefaultCellStyle.Format = "N0"
                        .Columns(9).DefaultCellStyle.Format = "N0"
                    End With

                Else
                    With dgvmainlist
                        .Columns(0).HeaderText = "ລະຫັດ"
                        .Columns(1).HeaderText = "ຊື່ລູກຄ້າ"
                        .Columns(2).Visible = False
                        .Columns(3).Visible = False
                        .Columns(4).HeaderText = "ທັງໜົດ"
                        .Columns(5).Visible = False
                        .Columns(6).Visible = False
                        .Columns(7).HeaderText = "ຈ່າຍແລ້ວ"
                        .Columns(8).Visible = False
                        .Columns(9).Visible = False
                        .Columns(10).HeaderText = "ຄ້າງຈ່າຍ"
                        .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        .Columns(4).DefaultCellStyle.Format = "N0"
                        .Columns(7).DefaultCellStyle.Format = "N0"
                        .Columns(10).DefaultCellStyle.Format = "N0"
                    End With

                End If
                formsumarysale = False

          
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdkip_CheckedChanged(sender As Object, e As EventArgs) Handles rdkip.CheckedChanged
        Try
            If rdkip.Checked = True Then
                dgvmainlist.DataSource = Nothing
                sale.loadviewsumarysale(dgvmainlist)
                With dgvmainlist
                    .Columns(0).HeaderText = "ລະຫັດ"
                    .Columns(1).HeaderText = "ຊື່ລູກຄ້າ"
                    .Columns(2).HeaderText = "ທັງໜົດ"
                    .Columns(3).Visible = False
                    .Columns(4).Visible = False
                    .Columns(5).HeaderText = "ຈ່າຍແລ້ວ"
                    .Columns(6).Visible = False
                    .Columns(7).Visible = False
                    .Columns(8).HeaderText = "ຄ້າງຈ່າຍ"
                    .Columns(9).Visible = False
                    .Columns(10).Visible = False
                    .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns(2).DefaultCellStyle.Format = "N0"
                    .Columns(5).DefaultCellStyle.Format = "N0"
                    '.Columns(8).DefaultCellStyle.Format = "N0"
                    .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdbath_CheckedChanged(sender As Object, e As EventArgs) Handles rdbath.CheckedChanged
        Try
            If rdbath.Checked = True Then
                dgvmainlist.DataSource = Nothing
                sale.loadviewsumarysale(dgvmainlist)
                With dgvmainlist
                    .Columns(0).HeaderText = "ລະຫັດ"
                    .Columns(1).HeaderText = "ຊື່ລູກຄ້າ"
                    .Columns(2).Visible = False
                    .Columns(3).HeaderText = "ທັງໜົດ"
                    .Columns(4).Visible = False
                    .Columns(5).Visible = False
                    .Columns(6).HeaderText = "ຈ່າຍແລ້ວ"
                    .Columns(7).Visible = False
                    .Columns(8).Visible = False
                    .Columns(9).HeaderText = "ຄ້າງຈ່າຍ"
                    .Columns(10).Visible = False
                    .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns(3).DefaultCellStyle.Format = "N0"
                    .Columns(6).DefaultCellStyle.Format = "N0"
                    '.Columns(9).DefaultCellStyle.Format = "N0"
                    .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rddolla_CheckedChanged(sender As Object, e As EventArgs) Handles rddolla.CheckedChanged
        Try
            If rddolla.Checked = True Then
                dgvmainlist.DataSource = Nothing
                sale.loadviewsumarysale(dgvmainlist)
                With dgvmainlist
                    .Columns(0).HeaderText = "ລະຫັດ"
                    .Columns(1).HeaderText = "ຊື່ລູກຄ້າ"
                    .Columns(2).Visible = False
                    .Columns(3).Visible = False
                    .Columns(4).HeaderText = "ທັງໜົດ"
                    .Columns(5).Visible = False
                    .Columns(6).Visible = False
                    .Columns(7).HeaderText = "ຈ່າຍແລ້ວ"
                    .Columns(8).Visible = False
                    .Columns(9).Visible = False
                    .Columns(10).HeaderText = "ຄ້າງຈ່າຍ"
                    .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns(4).DefaultCellStyle.Format = "N0"
                    .Columns(7).DefaultCellStyle.Format = "N0"
                    '.Columns(10).DefaultCellStyle.Format = "N0"
                    .Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub reportsumarysale_Click(sender As Object, e As EventArgs) Handles reportsumarysale.Click
        Try
            mydata.viewsumaryallbill.Clear()
            Dim money As String
            If rdkip.Checked = True Then
                money = "ກີບ"
                For i As Integer = 0 To dgvmainlist.Rows.Count - 1
                    Dim id As String = dgvmainlist.Rows(i).Cells(0).Value
                    Dim cusname As String = dgvmainlist.Rows(i).Cells(1).Value
                    Dim total As Double = dgvmainlist.Rows(i).Cells(2).Value
                    Dim pay As Double = dgvmainlist.Rows(i).Cells(5).Value
                    Dim debit As Double = dgvmainlist.Rows(i).Cells(8).Value
                    mydata.viewsumaryallbill.Rows.Add(id, cusname, total, pay, debit, money)
                Next
            ElseIf rdbath.Checked = True Then
                money = "ບາດ"
                For i As Integer = 0 To dgvmainlist.Rows.Count - 1
                    Dim id As String = dgvmainlist.Rows(i).Cells(0).Value
                    Dim cusname As String = dgvmainlist.Rows(i).Cells(1).Value
                    Dim total As Double = dgvmainlist.Rows(i).Cells(3).Value
                    Dim pay As Double = dgvmainlist.Rows(i).Cells(6).Value
                    Dim debit As Double = dgvmainlist.Rows(i).Cells(9).Value
                    mydata.viewsumaryallbill.Rows.Add(id, cusname, total, pay, debit, money)
                Next

            Else
                money = "ໂດລາ"
                For i As Integer = 0 To dgvmainlist.Rows.Count - 1
                    Dim id As String = dgvmainlist.Rows(i).Cells(0).Value
                    Dim cusname As String = dgvmainlist.Rows(i).Cells(1).Value
                    Dim total As Double = dgvmainlist.Rows(i).Cells(4).Value
                    Dim pay As Double = dgvmainlist.Rows(i).Cells(7).Value
                    Dim debit As Double = dgvmainlist.Rows(i).Cells(10).Value
                    mydata.viewsumaryallbill.Rows.Add(id, cusname, total, pay, debit, money)
                Next
            End If
         
            frmreportsumarybillall.ShowDialog()
            frmreportsumarybillall.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub reportsalebycustomer_Click(sender As Object, e As EventArgs) Handles reportsalebycustomer.Click
        If dgvmainlist.SelectedCells.Count - 1 Then

        End If
    End Sub

End Class