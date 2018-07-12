Imports System.Data.SqlClient
Public Class tbbusiness
    Dim cn As New connectdb
    Dim cm As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim re As SqlDataReader
    Dim ds As New DataSet
    Public Function runbusinessid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 bsnnid from tbbusiness order by bsnnid desc", cn.conn)
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
    Public Function saveimage() As Byte()
        Dim frmp As frmbusiness = CType(Application.OpenForms("frmbusiness"), frmbusiness)
        Dim memstream1 As New IO.MemoryStream
        frmp.pimage.Image.Save(memstream1, Drawing.Imaging.ImageFormat.Jpeg)
        Return memstream1.ToArray()
    End Function
    Public Function savebusiness(bsnnid As Integer, bsnnamelao As String, bsnnameenglish As String, address As String, tel As String, email As String)
        cn.connect()
        'Try
        Dim pic() As Byte = saveimage()
        cm.Parameters.AddWithValue("pic", pic)
        Dim sav As String = "insert into tbbusiness values('" & bsnnid & "',N'" & bsnnamelao & "',N'" & bsnnameenglish & "',N'" & address & "',N'" & tel & "',N'" & email & "',@pic)"
        With cm
            .CommandType = CommandType.Text
            .CommandText = sav
            .Connection = cn.conn
            .ExecuteNonQuery()
        End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function
    Public Function updateimage()
        Dim product As frmbusiness = CType(Application.OpenForms("frmbusiness"), frmbusiness)
        Dim byteimage() As Byte
        Dim ms As New System.IO.MemoryStream
        Dim dd As New Bitmap(product.pimage.Image)
        dd.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        byteimage = ms.ToArray()
        Return ms.ToArray
    End Function
    Public Function updatebusiness(bsnnid As Integer, bsnnamelao As String, bsnnameenglish As String, address As String, tel As String, email As String)
        cn.connect()
        Try
            Dim pic() As Byte = updateimage()
            cm.Parameters.AddWithValue("pic", pic)
            Dim up As String = "update tbbusiness set bsnnid=N'" & bsnnid & "',bsnnamelao=N'" & bsnnamelao & "',bsnnameenglish=N'" & bsnnameenglish & "',address=N'" & address & "',tel=N'" & tel & "',email=N'" & email & "',pic=" & "@pic where bsnnid='" & bsnnid & "'"
            With cm
                .CommandType = CommandType.Text
                .CommandText = up
                .Connection = cn.conn
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function showimage(dgv As DataGridView)
        Dim product As frmbusiness = CType(Application.OpenForms("frmbusiness"), frmbusiness)
        cn.connect()
        Try
            cm = New SqlCommand("select pic from tbbusiness where bsnnid='" & dgv.CurrentRow.Cells(0).Value & "'", cn.conn)
            re = cm.ExecuteReader
            If re.Read Then
                Dim bytimage() As Byte

                bytimage = CType(re(0), Byte())
                Dim ms As New System.IO.MemoryStream(bytimage)
                Dim bmimage As New Bitmap(ms)
                ms.Close()
                product.pimage.SizeMode = PictureBoxSizeMode.StretchImage
                product.pimage.Image = bmimage
            End If
            re.Close()
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function deletedatebusiness(bsnnid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbbusiness where bsnnid='" & bsnnid & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function loadbusiness(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbbusiness order by bsnnid asc", cn.conn)
            da.Fill(ds, "bsn")
            ds.Tables.Clear()
            da.Fill(ds, "bsn")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ຊື່ບໍລິສັດ"
                .Columns(2).HeaderText = "ຊື່ອັງກິດ"
                .Columns(3).HeaderText = "ທີ່ຢູ່"
                .Columns(4).HeaderText = "ເບີໂທ"
                .Columns(5).HeaderText = "ອີເມວ"
                .Columns(6).HeaderText = "ຮູບພາບ"
                '.Columns(0).Width = 100
                '.Columns(1).Width = 150
                '.Columns(2).Width = 150
                '.Columns(3).Width = 200
                '.Columns(4).Width = 150
                .Columns(6).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function serchbusiness(name As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbbusiness where bsnnamelao like N'%" & name & "%'or bsnnameenglish like N'%" & name & "%'", cn.conn)
            da.Fill(ds, "bsn")
            ds.Tables.Clear()
            da.Fill(ds, "bsn")
            dgv.DataSource = ds.Tables(0)
            With dgv
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ຊື່ບໍລິສັດ"
                .Columns(2).HeaderText = "ຊື່ອັງກິດ"
                .Columns(3).HeaderText = "ທີ່ຢູ່"
                .Columns(4).HeaderText = "ເບີໂທ"
                .Columns(5).HeaderText = "ອີເມວ"
                .Columns(6).HeaderText = "ຮູບພາບ"
                '.Columns(0).Width = 100
                '.Columns(1).Width = 150
                '.Columns(2).Width = 150
                '.Columns(3).Width = 200
                .Columns(6).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
