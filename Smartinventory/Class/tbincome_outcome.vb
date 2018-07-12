Imports System.Data.SqlClient
Public Class tbincome_outcome
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Public Function save(id As Integer, userid As Integer, souceid As Integer, des As String, total As Double, moneyid As Integer, status As String, dt As String, rated As Double)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbincome_outcome values('" & id & "','" & userid & "','" & souceid & "',N'" & des & "','" & total & "','" & moneyid & "',N'" & status & "','" & dt & "','" & rated & "')", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function update(id As Integer, userid As Integer, sourid As Integer, des As String, total As Double, moneyid As Integer, status As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbincome_outcome set user_id='" & userid & "',sourceid='" & sourid & "', des=N'" & des & "', totalprice='" & total & "',money_id='" & moneyid & "', status=N'" & status & "' where inout_id='" & id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function delete(id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbincome_outcome where inout_id='" & id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
        Return True
    End Function
    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 inout_id from tbincome_outcome order by inout_id desc", cn.conn)
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
        Return id
    End Function
    Public Function viewincome_outcome(sourceid As Integer, status As String, dgv As DataGridView)
        cn.connect()
        'Try
        da = New SqlDataAdapter("select top 20 * from viewfinancial where sourceid='" & sourceid & "' and status=N'" & status & "' order by inout_id desc", cn.conn)
        da.Fill(ds, "inout")
        ds.Tables.Clear()
        da.Fill(ds, "inout")
        dgv.DataSource = ds.Tables(0)
        With dgv
            .Columns(0).HeaderText = "ລໍາດັບ"
            .Columns(1).HeaderText = "ຜູ້ບັນທືກ"
            .Columns(2).HeaderText = "ປະເພດ"
            .Columns(3).HeaderText = "ຈໍານວນ"
            .Columns(4).HeaderText = "ເງີນ"
            .Columns(5).HeaderText = "ລາຍລະອຽດ"
            .Columns(6).HeaderText = "ສະຖານະ"
            .Columns(7).HeaderText = "ວັນທີ"
            .Columns(3).DefaultCellStyle.Format = "N0"
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
        End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return True
    End Function
    Public Function sum_incomekip(dt1 As String, dt2 As String)
        cn.connect()
        Dim totalincome As Double
        Try
            cm = New SqlCommand("select sum(totalprice) as total from tbincome_outcome where status=N'ລາຍຮັບ' and moneytype=N'ກີບ' and recordedate>='" & dt1 & "' and recordedate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalincome = re.GetValue(0)
                End While
            Else
                totalincome = 0
            End If
            re.Close()
        Catch ex As Exception

        End Try
        Return totalincome
    End Function
    Public Function sum_incomebath(dt1 As String, dt2 As String)
        cn.connect()
        Dim totalincome As Double
        Try
            cm = New SqlCommand("select sum(totalprice) as total from tbincome_outcome where status=N'ລາຍຮັບ' and moneytype=N'ບາດ' and recordedate>='" & dt1 & "' and recordedate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalincome = re.GetValue(0)
                End While
            Else
                totalincome = 0
            End If
            re.Close()
        Catch ex As Exception

        End Try
        Return totalincome
    End Function
    Public Function sum_outcomekip(dt1 As String, dt2 As String)
        cn.connect()
        Dim totalincome As Double
        Try
            cm = New SqlCommand("select sum(totalprice) as total from tbincome_outcome where status=N'ລາຍຈ່າຍ' and moneytype=N'ກີບ' and recordedate>='" & dt1 & "' and recordedate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalincome = re.GetValue(0)
                End While
            Else
                totalincome = 0
            End If
            re.Close()
        Catch ex As Exception

        End Try
        Return totalincome
    End Function
    Public Function sum_outcomebath(dt1 As String, dt2 As String)
        cn.connect()
        Dim totalincome As Double
        Try
            cm = New SqlCommand("select sum(totalprice) as total from tbincome_outcome where status=N'ລາຍຈ່າຍ' and moneytype=N'ບາດ' and recordedate>='" & dt1 & "' and recordedate<='" & dt2 & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    totalincome = re.GetValue(0)
                End While
            Else
                totalincome = 0
            End If
            re.Close()
        Catch ex As Exception

        End Try
        Return totalincome
    End Function
End Class
