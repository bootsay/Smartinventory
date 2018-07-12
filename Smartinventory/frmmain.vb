Imports System.Data.SqlClient
Public Class frmmain
    Dim formclose As New formclose
    Dim exch As New tbexchange
    Dim setup As New tbsetup
    Public userid As Integer
    Public laoname As String
    Public level As String
    Public bath As Double
    Public dolla As Double
    Public nextpaydate As Integer
    Public remindpaydate As Integer
    Public dtsetup As New DataTable
    Public UserAuthentication As String = ""

    Public users As New tbuser
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim dr As SqlDataReader
    Private Sub showdata()
        cn.connect()
        cm = New SqlCommand("select id,servername,databasename,timebackup from tbbackup where id='" & txtid.Text & "'", cn.conn)
        'cm=New SqlCommand()
        cm.ExecuteNonQuery()
        dr = cm.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            'txtid.Text = dr.GetString(dr.GetOrdinal("id"))
            txtservername.Text = dr.GetString(dr.GetOrdinal("servername"))
            txtdatabasename.Text = dr.GetString(dr.GetOrdinal("databasename"))
            txttimebackup.Text = dr.GetString(dr.GetOrdinal("timebackup"))
        Else
        End If
        dr.Close()
        cm.Dispose()
        cn.conn.Close()
    End Sub
    Private Sub backup()
        Dim b As String = System.DateTime.Now.ToString("ddMMyyyy")
        SaveFileDialog1.FileName = txtdatabasename.Text
        Dim s As String
        s = SaveFileDialog1.FileName
        Dim path As String = Application.StartupPath & "\Database\" & b & "" & s & ".bak"
        query("backup database " & txtdatabasename.Text & " to disk='" & path & "'")
    End Sub
    Sub query(ByVal que As String)
        cn.connect()
        On Error Resume Next
        cm = New SqlCommand(que, cn.conn)
        cm.ExecuteNonQuery()
        cm.Dispose()
        cn.conn.Close()
    End Sub


    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.WindowState = FormWindowState.Maximized
        showdata()

        'If System.DateTime.Now.ToString("mm:ss tt") = txttimebackup.Text Then
        '    backup()
        'End If

        setup.Call_setup(dtsetup)

        lalaoname.Text = laoname
        lalevel.Text = level

        nextpaydate = dtsetup.Rows(0).Item(1)
        remindpaydate = dtsetup.Rows(0).Item(2)
        labath.Text = exch.loadbaht
        ladolla.Text = exch.loaddolla

        lalaoname.Text = laoname
        lalevel.Text = level
        nextpaydate = dtsetup.Rows(0).Item(1)
        remindpaydate = dtsetup.Rows(0).Item(2)
        labath.Text = exch.loadbaht
        ladolla.Text = exch.loaddolla

        UserAuthentication = users.user_auth(userid)

        If UserAuthentication = "" Then
            'MessageBox.Show(userid)
            frmsale1.Enabled = False
            frmproductinfo1.Enabled = False
            frmsalelistapprove.Enabled = False
            frmsumarysale1.Enabled = False
            frmreportsale.Enabled = False

            frmproduct11.Enabled = False
            frmcheckstock1.Enabled = False
            frmorder1.Enabled = False
            frmreceiveproduct1.Enabled = False
            frmreturnproduct1.Enabled = False
            frmstockin_out1.Enabled = False
            frmstockreport1.Enabled = False

            frmaddress1.Enabled = False
            frmcustomer1.Enabled = False
            frmcustomerdebit1.Enabled = False
            frmdebitcustomer1.Enabled = False
            frmreportcustomer1.Enabled = False

            frmincome_outcome1.Enabled = False
            frmreportdaily.Enabled = False

            frmmainproduct.Enabled = False
            frmuser1.Enabled = False
            frmexchange1.Enabled = False
            frmsalename1.Enabled = False
            frmbusiness1.Enabled = False
            frmbackup1.Enabled = False
            frmconfig1.Enabled = False
            frmother.Enabled = False

            frmproduct1.btnupdate4.Enabled = False
            frmproduct1.btndelete4.Enabled = False
            frmreceiveproduct.btnreceive.Enabled = False
            frmreceiveproduct.btncancel.Enabled = False
            frmcreateorder.btncancel.Enabled = False
            frmreturnproduct.btncancel.Enabled = False
            frmsale.btnapprove.Enabled = False
            frmsale.btncancel.Enabled = False

            'frmsale.cbselectbill.SelectedItem(0) = False
            'frmsale.cbselectbill.SelectedItem(1) = False
            'frmsale.cbselectbill.SelectedItem(2) = False

        Else
            Dim frmsale11 As String = "F"
            Dim frmproductinfo11 As String = "F"
            Dim frmsalelistapprove1 As String = "F"
            Dim frmsumarysale11 As String = "F"
            Dim frmreportsale1 As String = "F"

            Dim frmproduct12 As String = "F"
            Dim frmcheckstock11 As String = "F"
            Dim frmorder11 As String = "F"
            Dim frmreceiveproduct11 As String = "F"
            Dim frmreturnproduct11 As String = "F"
            Dim frmstockin_out11 As String = "F"
            Dim frmstockreport11 As String = "F"

            Dim frmaddress11 As String = "F"
            Dim frmcustomer11 As String = "F"
            Dim frmcustomerdebit11 As String = "F"
            Dim frmdebitcustomer11 As String = "F"
            Dim frmreportcustomer11 As String = "F"

            Dim frmincome_outcome11 As String = "F"
            Dim frmreportdaily11 As String = "F"

            Dim frmmainproduct1 As String = "F"
            Dim frmuser11 As String = "F"
            Dim frmexchange11 As String = "F"
            Dim frmsalename11 As String = "F"
            Dim frmbusiness11 As String = "F"
            Dim frmbackup11 As String = "F"
            Dim frmconfig11 As String = "F"
            Dim frmother1 As String = "F"

            Dim btnupdate41 As String = "F"
            Dim btndelete41 As String = "F"
            Dim btnreceive1 As String = "F"
            Dim btncancel1 As String = "F"
            Dim btncancel2 As String = "F"
            Dim btnapprove3 As String = "F"
            Dim btncancel3 As String = "F"
            Dim btncancel4 As String = "F"
            Dim btnapprove5 As String = "F"
            Dim btncancel5 As String = "F"

            Dim cbkcash1 As String = "F"
            Dim cbksent1 As String = "F"
            Dim cbkshowprice1 As String = "F"

            Dim billcash As String
            Dim billdevery As String
            Dim billquotation As String

            frmsale11 = UserAuthentication.Substring(0, 1)
            frmproductinfo11 = UserAuthentication.Substring(1, 1)
            frmsalelistapprove1 = UserAuthentication.Substring(2, 1)
            frmsumarysale11 = UserAuthentication.Substring(3, 1)
            frmreportsale1 = UserAuthentication.Substring(4, 1)

            frmproduct12 = UserAuthentication.Substring(5, 1)
            frmcheckstock11 = UserAuthentication.Substring(6, 1)
            frmorder11 = UserAuthentication.Substring(7, 1)
            frmreceiveproduct11 = UserAuthentication.Substring(8, 1)
            frmreturnproduct11 = UserAuthentication.Substring(9, 1)
            frmstockin_out11 = UserAuthentication.Substring(10, 1)
            frmstockreport11 = UserAuthentication.Substring(11, 1)

            frmaddress11 = UserAuthentication.Substring(12, 1)
            frmcustomer11 = UserAuthentication.Substring(13, 1)
            frmcustomerdebit11 = UserAuthentication.Substring(14, 1)
            frmdebitcustomer11 = UserAuthentication.Substring(15, 1)
            frmreportcustomer11 = UserAuthentication.Substring(16, 1)


            frmmainproduct1 = UserAuthentication.Substring(17, 1)
            frmuser11 = UserAuthentication.Substring(18, 1)
            frmexchange11 = UserAuthentication.Substring(19, 1)
            frmsalename11 = UserAuthentication.Substring(20, 1)
            frmbusiness11 = UserAuthentication.Substring(21, 1)
            frmbackup11 = UserAuthentication.Substring(22, 1)
            frmconfig11 = UserAuthentication.Substring(23, 1)
            frmother1 = UserAuthentication.Substring(24, 1)

            frmincome_outcome11 = UserAuthentication.Substring(25, 1)
            frmreportdaily11 = UserAuthentication.Substring(26, 1)

            btnupdate41 = UserAuthentication.Substring(27, 1)
            btndelete41 = UserAuthentication.Substring(28, 1)

            btnreceive1 = UserAuthentication.Substring(29, 1)
            btncancel1 = UserAuthentication.Substring(30, 1)

            btncancel2 = UserAuthentication.Substring(31, 1)

            btnapprove3 = UserAuthentication.Substring(32, 1)
            btncancel3 = UserAuthentication.Substring(33, 1)
            btncancel4 = UserAuthentication.Substring(34, 1)

            btnapprove5 = UserAuthentication.Substring(35, 1)
            btncancel5 = UserAuthentication.Substring(36, 1)


            billcash = UserAuthentication.Substring(37, 1)
            billdevery = UserAuthentication.Substring(38, 1)
            billquotation = UserAuthentication.Substring(39, 1)

            '11111111111111111111111111111111111111111111111111111111111111111111111111111
                   If billcash = "T" Then

            Else
                'ໃບຮັບເງີນສົດ()
                'ໃບສົ່ງເຄືອງ()
                'ໃບສະເໜີລາຄາ()
                frmsale.cbselectbill.Items.Clear()
                frmsale.cbselectbill.Items.Add("ໃບສະເໜີລາຄາ")
                frmsale.cbselectbill.Items.Add("ໃບສົ່ງເຄືອງ")
            End If


            If frmsale11 = "T" Then
                frmsale1.Enabled = True
            Else
                frmsale1.Visible = False
            End If
            If frmproductinfo11 = "T" Then
                frmproductinfo1.Enabled = True
            Else
                frmproductinfo1.Visible = False
            End If
            If frmsalelistapprove1 = "T" Then
                frmsalelistapprove.Enabled = True
            Else
                frmsalelistapprove.Visible = False
            End If
            If frmsumarysale11 = "T" Then
                frmsumarysale1.Enabled = True
            Else
                frmsumarysale1.Visible = False
            End If
            If frmreportsale1 = "T" Then
                frmreportsale.Enabled = True
            Else
                frmreportsale.Visible = False
            End If

            If frmproduct12 = "T" Then
                frmproduct11.Enabled = True
            Else
                frmproduct11.Visible = False
            End If

            If frmcheckstock11 = "T" Then
                frmcheckstock1.Enabled = True
            Else
                frmcheckstock1.Visible = False
            End If
            If frmorder11 = "T" Then
                frmorder1.Enabled = True
            Else
                frmorder1.Visible = False
            End If
            If frmreceiveproduct11 = "T" Then
                frmreceiveproduct1.Enabled = True
            Else
                frmreceiveproduct1.Visible = False
            End If
            If frmreturnproduct11 = "T" Then
                frmreturnproduct1.Enabled = True
            Else
                frmreturnproduct1.Visible = False
            End If
            If frmstockin_out11 = "T" Then
                frmstockin_out1.Enabled = True
            Else
                frmstockin_out1.Visible = False
            End If
            If frmstockreport11 = "T" Then
                frmstockreport1.Enabled = True
            Else
                frmstockreport1.Visible = False
            End If
            If frmaddress11 = "T" Then
                frmaddress1.Enabled = True
            Else
                frmaddress1.Visible = False
            End If
            If frmcustomer11 = "T" Then
                frmcustomer1.Enabled = True
            Else
                frmcustomer1.Visible = False
            End If
            If frmcustomerdebit11 = "T" Then
                frmcustomerdebit1.Enabled = True
            Else
                frmcustomerdebit1.Visible = False
            End If
            If frmdebitcustomer11 = "T" Then
                frmdebitcustomer1.Enabled = True
            Else
                frmdebitcustomer1.Visible = False
            End If
            If frmreportcustomer11 = "T" Then
                frmreportcustomer1.Enabled = True
            Else
                frmreportcustomer1.Visible = False
            End If
            If frmmainproduct1 = "T" Then
                frmmainproduct.Enabled = True
            Else
                frmmainproduct.Visible = False
            End If
            If frmuser11 = "T" Then
                frmuser1.Enabled = True
            Else
                frmuser1.Visible = False
            End If
            If frmexchange11 = "T" Then
                frmexchange1.Enabled = True
            Else
                frmexchange1.Visible = False
            End If
            If frmsalename11 = "T" Then
                frmsalename1.Enabled = True
            Else
                frmsalename1.Visible = False
            End If
            If frmbusiness11 = "T" Then
                frmbusiness1.Enabled = True
            Else
                frmbusiness1.Visible = False
            End If
            If frmbackup11 = "T" Then
                frmbackup1.Enabled = True
            Else
                frmbackup1.Visible = False
            End If
            If frmconfig11 = "T" Then
                frmconfig1.Enabled = True
            Else
                frmconfig1.Visible = False
            End If
            If frmother1 = "T" Then
                frmother.Enabled = True
            Else
                frmother.Visible = False
            End If
            '=============================
            If frmincome_outcome11 = "T" Then
                frmincome_outcome1.Enabled = True
            Else
                frmincome_outcome1.Visible = False
            End If

            If frmreportdaily11 = "T" Then
                frmreportdaily.Enabled = True
            Else
                frmreportdaily.Visible = False
            End If
            '=============================
            If btnapprove5 = "T" Then
                frmsale.btnapprove.Enabled = True
            Else
                frmsale.btnapprove.Visible = False
            End If
            If btncancel5 = "T" Then
                frmsale.btncancel.Enabled = True
            Else
                frmsale.btncancel.Visible = False
            End If

            If btnapprove3 = "T" Then
                frmstockout.btncancel.Enabled = True
            Else
                frmstockout.btncancel.Visible = False
            End If
            If btncancel3 = "T" Then
                frmstockout.btncancel.Enabled = True
            Else
                frmstockout.btncancel.Visible = False
            End If

            If btncancel4 = "T" Then
                frmreturnproduct.btncancel.Enabled = True
            Else
                frmreturnproduct.btncancel.Visible = False
            End If
            If btncancel2 = "T" Then
                frmcreateorder.btncancel.Enabled = True
            Else
                frmcreateorder.btncancel.Visible = False
            End If

            If btnreceive1 = "T" Then
                frmreceiveproduct.btnreceive.Enabled = True
            Else
                frmreceiveproduct.btnreceive.Visible = False
            End If
            If btncancel1 = "T" Then
                frmreceiveproduct.btncancel.Enabled = True
            Else
                frmreceiveproduct.btncancel.Visible = False
            End If
            If btnupdate41 = "T" Then
                frmproduct1.btnupdate4.Enabled = True
            Else
                frmproduct1.btnupdate4.Visible = False
            End If

            If btndelete41 = "T" Then
                frmproduct1.btndelete4.Enabled = True
            Else
                frmproduct1.btndelete4.Visible = False
            End If



        End If
    End Sub

    Private Sub addcategory_Click(sender As Object, e As EventArgs) Handles addcategory.Click
        frmcategory.ShowDialog()
        frmcategory.Close()

    End Sub

    Private Sub addunit_Click(sender As Object, e As EventArgs) Handles addunit.Click
        frmunit.ShowDialog()
        frmunit.Close()
    End Sub

    Private Sub addbrand_Click(sender As Object, e As EventArgs) Handles addbrand.Click
        frmbrand.ShowDialog()
        frmbrand.Close()
    End Sub

    Private Sub addcolor_Click(sender As Object, e As EventArgs) Handles addcolor.Click
        frmsubcategory.ShowDialog()
        frmsubcategory.Close()
    End Sub

    Private Sub addprocut_Click(sender As Object, e As EventArgs) Handles addprocut.Click
        formclose.closeform()
        formclose.f = frmproduct1
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub showuser_Click(sender As Object, e As EventArgs) Handles frmuser1.Click
        formclose.closeform()
        formclose.f = frmuser
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub showexchange_Click(sender As Object, e As EventArgs) Handles frmexchange1.Click
        frmexchange.ShowDialog()
        frmexchange.Close()

    End Sub

    Private Sub btnprovience_Click(sender As Object, e As EventArgs) Handles btnprovience.Click
        frmprovience.ShowDialog()
        frmprovience.Close()
    End Sub

    Private Sub btndistrict_Click(sender As Object, e As EventArgs) Handles btndistrict.Click
        frmdistrict.ShowDialog()
        frmdistrict.Close()
    End Sub

    Private Sub btnban_Click(sender As Object, e As EventArgs) Handles btnban.Click
        frmvillage.ShowDialog()
        frmvillage.Close()
    End Sub

    Private Sub showorder_Click(sender As Object, e As EventArgs) Handles frmorder1.Click
        formclose.closeform()
        formclose.f = frmorder
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub showproduct_Click(sender As Object, e As EventArgs) Handles frmproduct11.Click
        formclose.closeform()
        formclose.f = frmproduct1
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.StartPosition = FormStartPosition.CenterScreen
        formclose.f.Show()
    End Sub

    Private Sub showcustomer_Click(sender As Object, e As EventArgs) Handles frmcustomer1.Click
        formclose.closeform()
        formclose.f = frmcustomer
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub btnsale_Click(sender As Object, e As EventArgs) Handles frmsale1.Click
        formclose.closeform()
        formclose.f = frmsalelist
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub


    Private Sub customerreport_Click(sender As Object, e As EventArgs) Handles customerreport.Click
        'formclose.closeform()
        'formclose.f = frmreportcustomer
        'formclose.f.MdiParent = Me
        ''formclose.f.Dock = DockStyle.Fill
        'formclose.f.Show()
        frmreportcustomer.ShowDialog()
        frmreportcustomer.Close()
    End Sub

    Private Sub showsale_Click(sender As Object, e As EventArgs)
        formclose.closeform()
        formclose.f = frmsalelist
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub showreceive_Click(sender As Object, e As EventArgs) Handles frmreceiveproduct1.Click
        frmreceiveproduct.ShowDialog()

    End Sub

    Private Sub showreturn_Click(sender As Object, e As EventArgs) Handles frmreturnproduct1.Click
        formclose.closeform()
        formclose.f = frmreturnproductlist
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub btngetproduct_Click(sender As Object, e As EventArgs) Handles frmstockin_out1.Click
        formclose.closeform()
        formclose.f = frmstockoutlist
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub showcompanyinfo_Click(sender As Object, e As EventArgs) Handles frmbusiness1.Click
        'Try
        frmbusiness.ShowDialog()
        frmbusiness.Close()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub showsystemsetup_Click(sender As Object, e As EventArgs) Handles frmconfig1.Click
        formclose.closeform()
        formclose.f = frmconfig
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub showsumarysale_Click(sender As Object, e As EventArgs) Handles frmsalelistapprove.Click
        formclose.closeform()
        formclose.f = frmsumarysale
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub showcustomerdebit_Click(sender As Object, e As EventArgs) Handles frmcustomerdebit1.Click
        formclose.closeform()
        formclose.f = frmcustomerdebitlist
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub frmproductinfo_Click(sender As Object, e As EventArgs) Handles frmproductinfo1.Click
        formclose.closeform()
        formclose.f = frmproductinfo
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub btnreportdailysale_Click(sender As Object, e As EventArgs) Handles btnreportdailysale.Click
        frmreportsaledetaillist.ShowDialog()
        frmreportsaledetaillist.Close()
    End Sub

    Private Sub cryreportsaledetail_Click(sender As Object, e As EventArgs) Handles cryreportsaledetail.Click
        frmreportsaledetail.ShowDialog()
        frmreportsaledetail.Close()
    End Sub

    Private Sub cryreportsumarysaledetail_Click(sender As Object, e As EventArgs) Handles cryreportsumarysaledetail.Click
        frmreportsaledetail_sumary.ShowDialog()
        frmreportsaledetail_sumary.Close()
    End Sub

    Private Sub cryreportproduct_Click(sender As Object, e As EventArgs) Handles cryreportproduct.Click
        Frmreportproduct.ShowDialog()
        frmreportcustomer.Close()
    End Sub

    Private Sub cryreportstock_Click(sender As Object, e As EventArgs) Handles cryreportstock.Click
        frmcheckstockoption.ShowDialog()
        frmcheckstockoption.Close()
    End Sub


    Private Sub showcryorderbill_Click(sender As Object, e As EventArgs) Handles showcryorderbill.Click
        'formclose.f = frmreportorderbill
        ''formclose.f.MdiParent = Me
        'formclose.f.Dock = DockStyle.Fill
        'formclose.f.Show()
        frmreportorderbill.ShowDialog()
        frmreportorderbill.Close()
    End Sub

    Private Sub btnshoworderbilldetail_Click(sender As Object, e As EventArgs) Handles btnshoworderbilldetail.Click
        frmreportorderdetail.ShowDialog()
        frmreportorderdetail.Close()
    End Sub

    Private Sub btnreceive_Click(sender As Object, e As EventArgs) Handles btnreceive.Click
        frmreportreceive.ShowDialog()
        frmreportreceive.Close()
    End Sub

    Private Sub btnreceivedetail_Click(sender As Object, e As EventArgs) Handles btnreceivedetail.Click
        frmreportreceivedetail.ShowDialog()
        frmreportreceivedetail.Close()
    End Sub

    Private Sub btnstockoutin_Click(sender As Object, e As EventArgs) Handles btnstockoutin.Click
        frmreportstockout.ShowDialog()
        frmreportstockout.Close()
    End Sub

    Private Sub btnstockinoutdetail_Click(sender As Object, e As EventArgs) Handles btnstockinoutdetail.Click
        frmreportstockoutdetail.ShowDialog()
        frmreportstockoutdetail.Close()
    End Sub

    Private Sub btnstockout1_Click(sender As Object, e As EventArgs) Handles btnstockout1.Click
        frmstockouttype.ShowDialog()
        frmstockouttype.Close()
    End Sub
    Private Sub btnemployee_Click(sender As Object, e As EventArgs) Handles btnemployee.Click
        frmemployee.ShowDialog()
        frmemployee.Close()
    End Sub

    Private Sub btnstockoutpoint_Click(sender As Object, e As EventArgs) Handles btnstockoutpoint.Click
        frmdepartment.ShowDialog()
        frmdepartment.Close()
    End Sub

    Private Sub frmsalename1_Click(sender As Object, e As EventArgs) Handles frmsalename1.Click
        frmsalename.ShowDialog()
        frmsalename.Close()
    End Sub

    Private Sub frmbackup1_Click(sender As Object, e As EventArgs) Handles frmbackup1.Click
        frmbackup_restore.ShowDialog()
        frmbackup_restore.Close()
    End Sub

    Private Sub btncheckstock_Click(sender As Object, e As EventArgs) Handles frmcheckstock1.Click
        fromproductremind.ShowDialog()
        fromproductremind.Close()
    End Sub

    Private Sub frmsumarysale1_Click(sender As Object, e As EventArgs) Handles frmsumarysale1.Click
        formclose.closeform()
        formclose.f = frmsumarysale
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub


    Private Sub reportdaily_Click(sender As Object, e As EventArgs)
        frmreportincome_outcomedetail.ShowDialog()
        frmreportincome_outcomedetail.Close()
    End Sub

    Private Sub frmdebitcustomer1_Click(sender As Object, e As EventArgs) Handles frmdebitcustomer1.Click
        formclose.closeform()
        formclose.f = frmdebitcustomerlist
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            '        backup()
            '        If ProgressBar1.Value = 100 Then
            '            Timer1.Enabled = False
            '            'ProgressBar1.Visible = False
            '            MsgBox("ສໍາເລັດ")
            '        Else
            '            ProgressBar1.Value = ProgressBar1.Value + 5
            '        End If
            lstarttime.Text = DateAndTime.Now.ToString("hh:mm tt")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmmain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try

            Application.Exit()

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '   
    '    res = MessageBox.Show("ທ່ານຕ້ອງການປິດໂປຼແກຼມແມ່ນບໍ່", "ປິດໂປຼແກຼມ", MessageBoxButtons.YesNo)
    '    If res = DialogResult.Yes Then
    '        backup()
    '        Application.Exit()
    '        'Else
    '        '    e.Cancel = True
    '    End If
    'End Sub
    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        frmsetupbackup.ShowDialog()
        frmsetupbackup.Close()
    End Sub


    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Try
    '        backup()
    '        If ProgressBar1.Value = 100 Then
    '            Timer1.Enabled = False
    '            'ProgressBar1.Visible = False
    '            MsgBox("ສໍາເລັດ")
    '        Else
    '            ProgressBar1.Value = ProgressBar1.Value + 5
    '        End If
    '        lstarttime.Text = DateAndTime.Now.ToString("hh:mm tt")
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub lstarttime_TextChanged(sender As Object, e As EventArgs) Handles lstarttime.TextChanged
        If lstarttime.Text = txttimebackup.Text Then
            backup()
        Else

        End If
    End Sub

    Private Sub showsetmoney_Click(sender As Object, e As EventArgs) Handles showsetmoney.Click
        frmsetmoney.ShowDialog()
        frmsetmoney.Close()
    End Sub
    Private Sub frmincome_outcome1_Click(sender As Object, e As EventArgs) Handles frmincome_outcome1.Click
        'frmcash.ShowDialog()
        frmmoneycapitaltotal.ShowDialog()
        frmmoneycapitaltotal.Close()
    End Sub

    Private Sub showpaymoney_Click(sender As Object, e As EventArgs) Handles frmreportdaily.Click
        formclose.closeform()
        formclose.f = frmcash
        formclose.f.MdiParent = Me
        formclose.f.Dock = DockStyle.Fill
        formclose.f.Show()
    End Sub

    Private Sub pricecash_Click(sender As Object, e As EventArgs) Handles pricecash.Click
        frmreportsaledetaillist1.ShowDialog()
        frmreportsaledetaillist1.Close()
    End Sub

    Private Sub pricesend_Click(sender As Object, e As EventArgs) Handles pricesend.Click
        frmreportsaledetaillist2.ShowDialog()
        frmreportsaledetaillist2.Close()
    End Sub


    Private Sub ButtonItem9_Click(sender As Object, e As EventArgs) Handles ButtonItem9.Click
        frmreportsaledetaillist.ShowDialog()
        frmreportsaledetaillist.Close()
    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub
End Class