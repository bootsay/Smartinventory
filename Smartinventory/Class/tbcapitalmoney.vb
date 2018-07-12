Imports System.Data.SqlClient
Public Class tbcapitalmoney
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim account As New tbaccount
    Public Function Call_summoneycapital(accountid As Integer)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(capitaltotal) as total from tbcapitalmoney where accountid='" & accountid & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        total = 0
                    Else
                        total = re.GetValue(0)
                    End If
                End While
            Else
                total = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return total
    End Function
    Public Function select_capitalmoney(moneyid As Integer, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from tbcapitalmoney where cutcapitaltotal>0 order by capitalid asc", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True

    End Function
    Public Function cut_money(capitalid As Integer, total As Double)
        cn.connect()
        Try
            cm = New SqlCommand("update tbcapitalmoney set cutcapitaltotal='" & total & "' where capitalid='" & capitalid & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function call_capitalmoney(accountid As Integer)
        cn.connect()
        Dim total As Double
        Try
            cm = New SqlCommand("select sum(capitaltotal) as total, accountid from tbcapitalmoney where accountid='" & accountid & "' group by accountid ", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        total = 0
                    Else
                        total = re.GetValue(0)
                    End If
                End While
            Else
                total = 0
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return total
    End Function
    Public Function save(capitalid As Integer, accountid As Integer, capitaltotal As Double, inputdate As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbcapitalmoney values('" & capitalid & "','" & accountid & "', '" & capitaltotal & "','" & inputdate & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
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

    Public Function delete(capitalid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbcapitalmoney where capitalid='" & capitalid & "'", cn.conn)
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

    Public Function update(capitalid As Integer, accountid As Integer, capitaltotal As Double,  inputdate As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbcapitalmoney set accountid='" & accountid & "', capitaltotal='" & capitaltotal & "',inputdate='" & inputdate & "' where capitalid='" & capitalid & "'", cn.conn)
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

    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 capitalid from tbcapitalmoney order by capitalid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0).ToString + 1
                End While
            Else
                id = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        re.Close()
        cm.Dispose()
        cn.conn.Close()
        Return id
    End Function

    Public Function loaddata(dgv As DataGridView)
        cn.connect()
        Try
            MessageBox.Show("boot")
            da = New SqlDataAdapter("select * from viewmoneycapitaltotal order by capitailid asc", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ຮັບເຂົ້າ"
                .Columns(3).HeaderText = "ເງີນ"
                .Columns(4).HeaderText = "ວັນທີ"
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(1).DefaultCellStyle.Format = "N0"
                .Columns(2).DefaultCellStyle.Format = "N0"
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewsumaryaccount(accountid As Integer, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewsumaryaccount where accountid='" & accountid & "' order by capitalid desc", cn.conn)
            da.Fill(ds, "dd")
            ds.Tables.Clear()
            da.Fill(ds, "dd")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ຊື່ບັນຊີ"
                .Columns(2).HeaderText = "ຍອດເງີນ"
                .Columns(3).HeaderText = "ສະກຸນເງີນ"
                .Columns(4).HeaderText = "ວັນທີ"
                .Columns(5).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).DefaultCellStyle.Format = "N0"
            End With
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function loaddatamoney(accountid As Integer, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewmoneycapitaltotal where accountid='" & accountid & "' order by capitalid desc", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ບັນຊີ"
                .Columns(2).HeaderText = "ຮັບເຂົ້າ"
                .Columns(3).HeaderText = "ເງີນ"
                .Columns(4).HeaderText = "ວັນທີ"
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).DefaultCellStyle.Format = "N0"
                .Columns(3).DefaultCellStyle.Format = "N0"
                .Columns(5).Visible = False
                .Columns(6).Visible = False

            End With
        Catch ex As Exception

        End Try
        Return True
    End Function
    'Public Function combocategory(cb As ComboBox)
    '    cn.connect()
    '    Dim dt As New DataTable
    '    Try
    '        da = New SqlDataAdapter("select * from tbcapitalmoney order by cateID asc", cn.conn)
    '        da.Fill(dt)
    '        With cb
    '            .DataSource = dt
    '            .DisplayMember = dt.Columns("catename").ToString
    '            .ValueMember = dt.Columns("cateID").ToString
    '        End With
    '        da.Dispose()
    '        cn.conn.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    '    Return True
    'End Function
    Public Function combocategory1(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        'Try
        da = New SqlDataAdapter("select * from tbcapitalmoney order by cateID asc", cn.conn)
        da.Fill(dt)
        dt.Rows.Add(0, "ປະເພດທັງໜົດ")
        With cb
            .DataSource = dt
            .DisplayMember = dt.Columns("catename").ToString
            .ValueMember = dt.Columns("cateID").ToString
        End With
        da.Dispose()
        cn.conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function

    Public Function combopaytype(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select top 2 * from tbcapitalmoney order by pay_id asc", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("payname").ToString
                .ValueMember = dt.Columns("pay_id").ToString
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
