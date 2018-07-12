Imports System.Data.SqlClient

Public Class tbcustomertype
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Public Function runid()
        Dim id As Integer
        cn.connect()
        Try
            cm = New SqlCommand("select top 1 custypeid from tbcustomertype order by custypeid desc", cn.conn)
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
    Public Function save(id As Integer, name As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbcustomertype values('" & id & "',N'" & name & "')", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function delete(id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbcustomertype where custypeid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function update(id As Integer, name As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbcustomertype set custypename=N'" & name & "' where custypeid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loaddata(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbcustomertype", cn.conn)
            da.Fill(ds, "sa")
            ds.Tables.Clear()
            da.Fill(ds, "sa")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ປະເພດລູກຄ້າ"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function combocustype(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        'Try
        da = New SqlDataAdapter("select * from tbcustomertype order by custypeid desc", cn.conn)
        da.Fill(dt)
        dt.Rows.Add(0, "ປະເພດທັງໜົດ")
        With cb
            .DataSource = dt
            .DisplayMember = dt.Columns("custypename").ToString
            .ValueMember = dt.Columns("custypeid").ToString
        End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function
End Class
