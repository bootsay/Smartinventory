Imports System.Data.SqlClient
Public Class tbsuppliers
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand

    Public Function save(sup_id As String, companyname As String, personcontact As String, prov As String, dist As String, village As String, phone As String, fax As String, email As String, custype As String, autoid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbsuppliers values('" & sup_id & "',N'" & companyname & "',N'" & personcontact & "',N'" & prov & "',N'" & dist & "',N'" & village & "',N'" & phone & "',N'" & fax & "',N'" & email & "',N'" & custype & "','" & autoid & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function update(sup_id As String, companyname As String, personcontact As String, prov As String, dist As String, village As String, phone As String, fax As String, email As String, custype As String)
        cn.connect()
        'Try
        cm = New SqlCommand("update tbsuppliers set companyname=N'" & companyname & "', personcontact=N'" & personcontact & "',provience=N'" & prov & "',district=N'" & dist & "',village=N'" & village & "', phone =N'" & phone & "',email='" & email & "', fax=N'" & fax & "', custype=N'" & custype & "' where sup_id='" & sup_id & "'", cn.conn)
        If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງແທ້ບໍ່?", "ປັບປຸງ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
            cm.ExecuteNonQuery()
        Else
            MessageBox.Show("no")
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function
    Public Function delete(sup_id As String)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbsuppliers where sup_id='" & sup_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function runidauto()
        Dim id As Integer
        cn.connect()
        cm = New SqlCommand("select top 1 supidauto from tbsuppliers order by supidauto desc", cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            While re.Read
                id = re.GetValue(0) + 1
            End While
        Else
            id = 1
        End If
        re.Close()
        Return id
    End Function
    Public Function runidsupplier()
        Dim id As String = Nothing
        Dim prefix As String = "C"
        Dim length As Integer = 4
        Dim inorder As Integer
        Try
            cn.connect()
            cm = New SqlCommand("select top 1 supidauto from tbsuppliers order by supidauto desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    inorder = re.GetValue(0) + 1
                End While
            Else
                inorder = 1
            End If
            id = inorder
            id = String.Format("{0}{1}", prefix, inorder.ToString().PadLeft(length, "0"))
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function showsuppliers(type As String, dgv As DataGridView, p As String, d As String, v As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbsuppliers where custype like N'%" & type & "%' and provience like N'%" & p & "%' and district like N'%" & d & "%' and village like N'%" & v & "%' order by supidauto asc", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ຊື່ບໍລິສັດ"
                .Columns(2).HeaderText = "ຊື່ຜູ້ຕິດຕໍ່"
                .Columns(3).HeaderText = "ແຂວງ"
                .Columns(4).HeaderText = "ເມືອງ"
                .Columns(5).HeaderText = "ບ້ານ"
                .Columns(6).HeaderText = "ເບີໂທຕິດຕໍ່"
                .Columns(7).HeaderText = "ເບີແຟກ"
                .Columns(8).Visible = False
                .Columns(9).HeaderText = "ປະເພດ"
                .Columns(10).Visible = False
                '.Columns(11).Visible = False
                '.Columns(12).Visible = False
                '.Columns(13).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function search_suppliers(name As String, type As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbsuppliers where custype like N'%" & type & "%' and companyname like N'%" & name & "%'", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ຊື່ບໍລິສັດ"
                .Columns(2).HeaderText = "ຊື່ຜູ້ຕິດຕໍ່"
                .Columns(3).HeaderText = "ແຂວງ"
                .Columns(4).HeaderText = "ເມືອງ"
                .Columns(5).HeaderText = "ບ້ານ"
                .Columns(6).HeaderText = "ເບີໂທຕິດຕໍ່"
                .Columns(7).HeaderText = "ເບີແຟກ"
                .Columns(8).Visible = False
                .Columns(9).HeaderText = "ປະເພດ"
                .Columns(10).Visible = False
                '.Columns(11).Visible = False
                '.Columns(12).Visible = False
                '.Columns(13).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function combocustype(cb As ComboBox)
        cn.connect()
        Try
            cb.Items.Clear()
            cm = New SqlCommand("select distinct custype from tbsuppliers ", cn.conn)
            re = cm.ExecuteReader
            cb.Items.Add("-ປະເພດລູກຄ້າທັງໜົດ-")
            If re.HasRows Then
                While re.Read
                    cb.Items.Add(re.GetValue(0))
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Select_top1customer(dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select top 1 * from tbsuppliers order by sup_id asc", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Selectcustomer(dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select top 1 * from tbsuppliers order by supidauto desc", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
