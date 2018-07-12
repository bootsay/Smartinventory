Imports System.Data.SqlClient
Public Class tbprovience
    Dim cn As New connectdb
    Dim cm As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim re As SqlDataReader
    Dim ds As New DataSet
    Public Function runprovienceid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 provienceid from tbprovience order by provienceid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0) + 1
                End While
            Else
                id = 1
            End If
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function runvillageid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 villageid from tbvillage order by villageid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0) + 1
                End While
            Else
                id = 1
            End If
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function rundistrictid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 districtid from tbdistrict order by districtid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0) + 1
                End While
            Else
                id = 1
            End If
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function saveprovience(id As Integer, proname As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbprovience values('" & id & "',N'" & proname & "')", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function savedistrict(id As Integer, provienc As Integer, proname As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbdistrict values('" & id & "','" & provienc & "',N'" & proname & "')", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function savevillage(id As Integer, provien As Integer, district As Integer, proname As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbvillage values('" & id & "','" & provien & "','" & district & "',N'" & proname & "')", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function deleteprovience(id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbprovience where provienceid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletedistrict(id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbdistrict where districtid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletevillage(id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbvillage where villageid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function updateprovience(id As Integer, proname As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbprovience set proviencename=N'" & proname & "' where provienceid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function updatedistrict(id As Integer, provienceid As Integer, proname As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbdistrict set provienceid=N'" & provienceid & "', districtname=N'" & proname & "' where districtid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function updatevillage(id As Integer, provienceid As Integer, districtid As Integer, proname As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbvillage set provienceid='" & provienceid & "', districtid='" & districtid & "', villagename=N'" & proname & "' where villageid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewprovience(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbprovience order by provienceid asc", cn.conn)
            da.Fill(ds, "prov")
            ds.Tables.Clear()
            da.Fill(ds, "prov")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(0).Visible = False
                .Columns(1).HeaderText = "ຊື່ແຂວງ"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewdistrict(proid As Integer, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select districtid, proviencename,districtname, tbprovience.provienceid FROM dbo.tbdistrict INNER JOIN dbo.tbprovience ON dbo.tbdistrict.provienceid = dbo.tbprovience.provienceid where tbprovience.provienceid='" & proid & "' order by districtid asc ", cn.conn)
            da.Fill(ds, "dis1")
            ds.Tables.Clear()
            da.Fill(ds, "dis1")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ຊື່ແຂວງ"
                .Columns(2).HeaderText = "ຊື່ເມືອງ"
                .Columns(3).Visible = False
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewvillage(proviceid As Integer, disrictid As Integer, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select villageid,proviencename,districtname,villagename,tbvillage.districtid from tbvillage inner join tbdistrict on tbvillage.districtid = tbdistrict.districtid inner join tbprovience on tbvillage.provienceid = tbprovience.provienceid where tbprovience.provienceid='" & proviceid & "' and  tbvillage.districtid='" & disrictid & "' order by villageid asc", cn.conn)
            da.Fill(ds, "dis")
            ds.Tables.Clear()
            da.Fill(ds, "dis")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ແຂວງ"
                .Columns(2).HeaderText = "ເມືອງ"
                .Columns(3).HeaderText = "ບ້ານ"
                .Columns(4).Visible = False
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function comboprovience(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbprovience", cn.conn)
            da.Fill(dt)
            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("proviencename").ToString
                .ValueMember = dt.Columns("provienceid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function comboprovience1(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbprovience", cn.conn)
            da.Fill(dt)
            dt.Rows.Add("0", "-ແຂວງທັງໜົດ-")
            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("proviencename").ToString
                .ValueMember = dt.Columns("provienceid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function comboboxdistrict1(proid As Integer, cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select districtid,districtname,tbprovience.provienceid from tbdistrict inner join tbprovience on tbdistrict.provienceid = tbprovience.provienceid where tbprovience.provienceid='" & proid & "' order by districtid asc", cn.conn)
            da.Fill(dt)
            dt.Rows.Add("0", "-ເມືອງທັງໜົດ-")
            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("districtname").ToString
                .ValueMember = dt.Columns("districtid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function comboboxvillage1(districtid As Integer, cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select villageid,villagename,tbdistrict.districtid from tbvillage inner join tbdistrict on tbvillage.districtid = tbdistrict.districtid where tbdistrict.districtid='" & districtid & "' order by villageid asc", cn.conn)
            da.Fill(dt)
            dt.Rows.Add("0", "-ບ້ານທັງໜົດ-")
            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("villagename").ToString
                .ValueMember = dt.Columns("villageid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function comboboxdistrict(proid As Integer, cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select districtid,districtname,tbprovience.provienceid from tbdistrict inner join tbprovience on tbdistrict.provienceid = tbprovience.provienceid where tbprovience.provienceid='" & proid & "' order by districtid asc", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("districtname").ToString
                .ValueMember = dt.Columns("districtid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function comboboxvillage(districtid As Integer, cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select villageid,villagename,tbdistrict.districtid from tbvillage inner join tbdistrict on tbvillage.districtid = tbdistrict.districtid where tbdistrict.districtid='" & districtid & "' order by villageid asc", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("villagename").ToString
                .ValueMember = dt.Columns("villageid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
