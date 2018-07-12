Imports System.Data.SqlClient
Public Class tbexchange
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(ex_id As Integer, bath_to_kip As Double, dolla_to_kip As Double)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbexchange(ex_id,bath_to_kip,dolla_to_kip)values('" & ex_id & "','" & bath_to_kip & "','" & dolla_to_kip & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(ex_id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbexchange where ex_id='" & ex_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(ex_id As Integer, bath_to_kip As Double, dolla_to_kip As Double)
        cn.connect()
        Try
            cm = New SqlCommand("update tbexchange set bath_to_kip='" & bath_to_kip & "', dolla_to_kip='" & dolla_to_kip & "' where ex_id='" & ex_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
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
            cm = New SqlCommand("select top 1 ex_id from tbexchange order by ex_id desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0).ToString + 1
                End While
            Else
                id = "1"
            End If
        Catch ex As Exception

        End Try
        Return id
    End Function

    Public Function loadtbexchange(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbexchange", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ບາດ"
                .Columns(2).HeaderText = "ໂດຮາ"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(1).DefaultCellStyle.Format = "N0"
                .Columns(2).DefaultCellStyle.Format = "N0"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadbaht()
        Dim baht As Double
        cn.connect()
        cm = New SqlCommand("select * from tbexchange", cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            While re.Read
                baht = re.GetValue(1)
            End While
        End If
        re.Close()
        Return baht

    End Function
    Public Function loaddolla()
        Dim dolla As Double
        cn.connect()
        cm = New SqlCommand("select * from tbexchange", cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            While re.Read
                dolla = re.GetValue(2)
            End While
        End If
        re.Close()
        Return dolla

    End Function
    Public Function convertbaht(totalkip As Double)
        Dim total As Double
        Try

            Dim baht As New TextBox
            baht.Text = loadbaht()
            total = (totalkip * 100) / Val(baht.Text)

        Catch ex As Exception

        End Try
        Return total
    End Function
    Public Function convertdolla(dolla As Double)
        Dim total As Double
        Dim totaldolla As New TextBox
        totaldolla.Text = loaddolla()
        total = (dolla * 100) / Val(totaldolla.Text)
        Return total
    End Function
    Public Function convertkip(bath As Double)
        Dim total As Double
        Dim totaldolla As New TextBox
        totaldolla.Text = loadbaht()
        total = Val(totaldolla.Text) * bath / 100
        Return total
    End Function
    Public Function Check_exchangeExist()
        Dim id As Integer
        cn.connect()
        Try
            cm = New SqlCommand("select count(ex_id) as dd from tbexchange", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0)
                End While
            Else
                id = 0
            End If
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
End Class
