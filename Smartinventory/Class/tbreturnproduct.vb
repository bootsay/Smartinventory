Imports System.Data.SqlClient
Public Class tbreturnproduct
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Public Function returnautoid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 returnautoid from tbreturn order by returnautoid desc", cn.conn)
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

    Public Function auto_returndetailid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 returndetailid from tbreturndetail order by returndetailid desc", cn.conn)
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
        Dim str As String = "select top 1 returnautoid from tbreturn order by returnautoid desc"
        cm = New SqlCommand(str, cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            re.Read()
            intsequence = Convert.ToInt32(re("returnautoid") + 1)
        Else
            intsequence = 1
        End If
        strseqno = intsequence
        strseqno = String.Format("{0}{1}-F" & m & "" & y & "" & w & "", strprefix, intsequence.ToString().PadLeft(lengs, "0"))
        Return strseqno
    End Function

    Public Function savereturn(returnNO As String, autoid As Integer, userid As Integer, supid As String, total As Double, note As String, returndate As String, getproductdate As String, statusid As Integer, approve As String, statussent As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbreturn values('" & returnNO & "','" & autoid & "','" & userid & "','" & supid & "','" & total & "',N'" & note & "','" & returndate & "','" & getproductdate & "','" & statusid & "','" & approve & "','" & statussent & "')", cn.conn)
            cm.ExecuteNonQuery()
            MessageBox.Show("ທ່ານປ້ອນຂໍ້ມູນສໍາເລັດແລ້ວ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function savereturndetail(id As Integer, returnNO As String, proid As String, unitname As String, returnqty As Integer, return_problem As String, returntotal As Double)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbreturndetail values('" & id & "','" & returnNO & "','" & proid & "',N'" & unitname & "','" & returnqty & "',N'" & return_problem & "','" & returntotal & "')", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function updatereturn(returnNO As String, supid As Integer, total As Double, note As String, returndate As String, getproductdate As String, statusid As Integer, approve As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbreturn set sup_id='" & supid & "', total_return='" & total & "', return_note=N'" & note & "', returndate='" & returndate & "', returndate_back='" & getproductdate & "', statusid='" & statusid & "', approve='" & approve & "' where returnNO='" & returnNO & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete_returndetail(returnNO As String)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbreturndetail where returnNO='" & returnNO & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function
    Public Function viewreturn_search_id(dgv As DataTable, returnNO As String)
        cn.connect()
        Try
            dgv.Clear()
            da = New SqlDataAdapter("select * from viewreturn where retrunNO like N'%" & returnNO & "%' order by retrunNO asc", cn.conn)
            da.Fill(dgv)
            'frmstockout(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewreturn_search_statusname(dgv As DataTable, statusname As String)
        cn.connect()
        Try
            dgv.Clear()
            da = New SqlDataAdapter("select * from viewreturn where statusname=N'" & statusname & "' order by returnNO asc", cn.conn)
            da.Fill(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewreturndetail(id As String, dgv As DataTable)
        cn.connect()
        Try
            dgv.Clear()
            da = New SqlDataAdapter("select * from viewreturndetail where returnNO='" & id & "'", cn.conn)
            da.Fill(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewreturn_search_date(dt1 As String, dt2 As String, status As String, approve As String, id As String, comname As String, dgv As DataTable)
        cn.connect()
        Try
            dgv.Clear()
            da = New SqlDataAdapter("select * from viewreturn where returnNO like N'%" & id & "%' and companyname like N'%" & comname & "%' and returndate>='" & dt1 & "' and returndate<='" & dt2 & "' and statusname like N'%" & status & "%' and approve like N'%" & approve & "%' order by returnNO desc", cn.conn)
            da.Fill(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function viewreturn_search_all(status As String, approve As String, id As String, comname As String, dgv As DataTable)
        cn.connect()
        Try
            dgv.Clear()
            da = New SqlDataAdapter("select * from viewreturn where returnNO like N'%" & id & "%' and statusname like N'%" & status & "%' and approve like N'%" & approve & "%' and companyname like N'%" & comname & "%' order by returnNO desc", cn.conn)
            da.Fill(dgv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Cancel_return(id As String)
        Try
            cn.connect()
            cm = New SqlCommand("update tbreturn set statusid=4 where returnNO='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Update_approve(id As String)
        Try
            cm = New SqlCommand("update tbreturn set approve='YES' where returnNO='" & id & "'", cn.conn)
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function Check_existreturnNO(returnNO As String)
        cn.connect()
        Dim saleno1 As String = Nothing
        Try
            cm = New SqlCommand("select top 1 returnNO from tbreturn where returnNO='" & returnNO & "'", cn.conn)
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

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return saleno1
    End Function
 
End Class
