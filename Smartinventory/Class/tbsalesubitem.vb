Imports System.Data.SqlClient
Public Class tbsalesubitem
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim cm As New SqlCommand
    Dim ds As New DataSet
    Dim re As SqlDataReader

    Public Function savesalesubitem(saleno As String, proid As String, total As Double, mainmoney As String, dt1 As String, statusid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbsalesubitem values('" & saleno & "','" & proid & "','" & total & "',N'" & mainmoney & "','" & dt1 & "','" & statusid & "')", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
   
    Public Function savesaleitemdetail(saleid As String, proID As String, proname As String, unitname As String, pricebuy As Double, pricesale As Double, qty As Double, discount As Double, total As Double, totalcut As Integer, bath As Double, dolla As Double)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbsalesubitemdetail values('" & saleid & "','" & proID & "',N'" & proname & "',N'" & unitname & "','" & pricebuy & "','" & pricesale & "','" & qty & "','" & discount & "','" & total & "','" & totalcut & "','" & bath & "','" & dolla & "')", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function select_subitemdetail(saleno As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewsubitemdetail where saleNO='" & saleno & "' order by saledetailid asc", cn.conn)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function check_existsaleNO(saleno As String)
        cn.connect()
        Dim check As String = Nothing
        Try
            cm = New SqlCommand("select saleNO from tbsalesubitem where saleNO='" & saleno & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        check = "false"
                    Else
                        check = re.GetValue(0)
                    End If
                End While
            Else
                check = "false"
            End If
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return check
    End Function
    Public Function delete_subitemdetail(id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbsalesubitemdetail where saledetailid='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Check_existsaleNO_insubsale(proid As String)
        cn.connect()
        Dim saleno1 As String = Nothing
        Try
            cm = New SqlCommand("select saleNO from tbsalesubitem where proid='" & proid & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    If re.GetValue(0) Is DBNull.Value Then
                        saleno1 = False
                    Else
                        saleno1 = True
                    End If
                End While
            Else
                saleno1 = False
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return saleno1
    End Function
    Public Function delete_subsaleitemdetail(saleNO As String)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbsalesubitemdetail where saleNO='" & saleNO & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function delete_subsaleitem(saleNO As String)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbsalesubitem where saleNO='" & saleNO & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Cancel_subitemdetail(id As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbsalesubitem set statusid=4 where saleNO='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class
