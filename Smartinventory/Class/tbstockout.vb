Imports System.Data.SqlClient
Public Class tbstockout
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Public Function stockid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 stockoutid from tbstockout order by stockoutid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0) + 1
                End While
            Else
                id = 1
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function

    Public Function stockoutdetailid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 stockoutdetailid from tbstockoutdetail order by stockoutdetailid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0) + 1
                End While
            Else
                id = 1
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function run_runNO()
        Dim y As String
        Dim years As New DateTimePicker

        y = years.Value.Year

        Dim m As String
        Dim month As New DateTimePicker
        m = month.Value.Month

        Dim d As String
        Dim day As New DateTimePicker
        d = day.Value.Day
        Dim w As String
        w = "WTS"
        'MessageBox.Show(a)
        Dim strseqno As String
        Dim strprefix = ""
        Dim lengs = 5
        Dim intsequence = 0
        cn.connect()
        Dim str As String = "select top 1 stockoutid from tbstockout order by stockoutid desc"
        cm = New SqlCommand(str, cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            re.Read()
            intsequence = Convert.ToInt32(re("stockoutid") + 1)
        Else
            intsequence = 1
        End If
        strseqno = intsequence
        strseqno = String.Format("{0}{1}-B" & m & "" & y & "" & w & "", strprefix, intsequence.ToString().PadLeft(lengs, "0"))
        re.Close()
        cm.Dispose()
        cn.conn.Close()
        Return strseqno
    End Function

    Public Function savestockout(stockoutNO As String, stockid As Integer, stocktypeid As Integer, userid As Integer, employeeid As Integer, total As Double, statusid As Integer, approve As String, note As String, date_out As String)
        cn.connect()
        'Try
        cm = New SqlCommand("insert into tbstockout values('" & stockoutNO & "','" & stockid & "','" & stocktypeid & "','" & userid & "','" & employeeid & "','" & total & "','" & statusid & "','" & approve & "',N'" & note & "','" & date_out & "')", cn.conn)
        cm.ExecuteNonQuery()
        cm.Dispose()
        cn.conn.Close()
        'MessageBox.Show("ທ່ານປ້ອນຂໍ້ມູນສໍາເລັດແລ້ວ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function

    Public Function savestockoutdetail(stockoutdetailid As Integer, stockoutNO As String, proid As String, unitname As String, price_out As Integer, qty_out As Integer, total_out As Double, qtycut As Integer, qty_totalout As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbstockoutdetail values('" & stockoutdetailid & "','" & stockoutNO & "','" & proid & "',N'" & unitname & "','" & price_out & "','" & qty_out & "','" & total_out & "','" & qtycut & "','" & qty_totalout & "')", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function updatestockout(stockoutNO As String, userid As String, employeeid As Integer, total As Double, statusid As Integer, note As String, date_out As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbstockout set user_id='" & userid & "',employee_id='" & employeeid & "',total='" & total & "',statusid='" & statusid & "',note=N'" & note & "',date_out='" & date_out & "' where stockoutNO='" & stockoutNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
                cm.Dispose()
                cn.conn.Close()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function


    Public Function deletestockout(stockoutNO As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbstockout where stockoutNO='" & stockoutNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
                cm.Dispose()
                cn.conn.Close()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function

    Public Function deletestockoutdetail(stockoutNO As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbstockoutdetail where stockoutdetailid='" & stockoutNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
                cm.Dispose()
                cn.conn.Close()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function
    Public Function viewstockout_search_id(dgv As DataTable, stockoutNO As String)
        cn.connect()
        Try
            dgv.Clear()
            da = New SqlDataAdapter("select * from viewstockout where stockoutNO like N'%" & stockoutNO & "%' order by stockoutNO asc", cn.conn)
            da.Fill(dgv)
            'frmstockout(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewstockout_search_statusname(dgv As DataTable, statusname As String)
        cn.connect()
        Try
            dgv.Clear()
            da = New SqlDataAdapter("select * from viewstockout where statusname=N'" & statusname & "' order by stockoutNO asc", cn.conn)
            da.Fill(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewstockoutdetail(id As String, dgv As DataTable)
        cn.connect()
        Try
            dgv.Clear()
            da = New SqlDataAdapter("select * from viewstockoutdetail where stockoutNO='" & id & "'", cn.conn)
            da.Fill(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewstockout_search_stockoutdate(dgv As DataTable, dt1 As String, dt2 As String)
        cn.connect()
        Try
            dgv.Clear()
            da = New SqlDataAdapter("select * from viewstockout where date_out>='" & dt1 & "' and date_out<='" & dt2 & "'  order by stockoutNO desc", cn.conn)
            da.Fill(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Update_stockoutcancel(id As String)
        Try
            cn.connect()
            cm = New SqlCommand("update tbstockout set statusid=4 where stockoutNO='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Update_approve(id As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbstockout set approve='YES' where stockoutNO='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Check_existstockoutNO(saleno As String)
        cn.connect()
        Dim saleno1 As String = Nothing
        Try
            cm = New SqlCommand("select top 1 stockoutNO from tbstockout where stockoutNO='" & saleno & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        saleno1 = "false"
                    Else
                        saleno1 = re.GetValue(0)
                    End If
                End While
            Else
                saleno1 = "false"
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return saleno1
    End Function
    Public Function loadviewsumarystockoutdetail(proid As String, dt1 As String, dt2 As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsumarystockoutdetail where proid='" & proid & "' and date_out>='" & dt1 & "' and date_out<='" & dt2 & "' and statusid<>4 and approve='YES' order by stockoutNO desc", cn.conn)
            da.Fill(ds, "dd")
            ds.Tables.Clear()
            da.Fill(ds, "dd")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ປະເພດເບີກ"
                .Columns(2).HeaderText = "ສາງ"
                .Columns(3).HeaderText = "ຜູ້ເບີກ"
                .Columns(4).HeaderText = "ຊື່ສີນຄ້າ"
                .Columns(5).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(6).HeaderText = "ລາຄາ"
                .Columns(7).HeaderText = "ຈໍານວນ"
                .Columns(8).HeaderText = "ລວມ"
                .Columns(9).HeaderText = "ວັນທີ"
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(6).DefaultCellStyle.Format = "#,###.00"
                .Columns(8).DefaultCellStyle.Format = "#,###.00"
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
