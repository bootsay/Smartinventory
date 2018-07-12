Imports System.Data.SqlClient
Public Class connectdb
    Public conn As New SqlConnection
    Public user As String = configuration.Default.username
    Public password As String = configuration.Default.password
    Public str As String = "data source='" & configuration.Default.servername & "'; initial catalog='" & configuration.Default.dbname & "'; User ID='" & user & "';Password='" & password & "'"
    Public Function connect()
        Try
            With conn
                If conn.State = ConnectionState.Open Then .Close()
                .ConnectionString = str
                .Open()
            End With

        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດເຊື່ອມຕໍ່ກັບຖານຂໍ້ມູນ, ກະລຸນາກວດເບີ່ງການເຊື່ອມຕໍ່", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Return True
    End Function

End Class
