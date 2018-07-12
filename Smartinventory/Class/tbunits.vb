Imports System.Data.SqlClient
Public Class tbunits
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(unit_id As Integer, unitname As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbunit(unit_id,unitname)values('" & unit_id & "',N'" & unitname & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
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

    Public Function delete(unit_id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbunit where unit_id='" & unit_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
                cm.Dispose()
                cn.conn.Close()
            Else

            End If
        Catch ex As Exception

        End Try
        Return True
    End Function

    Public Function update(unit_id As Integer, unitname As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbunit set unitname=N'" & unitname & "' where unit_id='" & unit_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
                cm.Dispose()
                cn.conn.Close()
            Else

            End If
        Catch ex As Exception

        End Try
        Return True
    End Function

    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 unit_id from tbunit order by unit_id desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0).ToString + 1
                End While
            Else
                id = 1
            End If
        Catch ex As Exception

        End Try
        re.Close()
        cm.Dispose()
        cn.conn.Close()
        Return id
    End Function

    Public Function loadtbunit(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbunit", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function combounit(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbunit", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("unitname").ToString
                .ValueMember = dt.Columns("unit_id").ToString
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadtbunit_byproid(proid As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewunitsale where proID='" & proid & "'", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .Columns(0).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(1).HeaderText = "ຈໍານວນຕັດ"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).Visible = False
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
            End With
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
