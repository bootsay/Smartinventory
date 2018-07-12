Public Class formclose
    Public f As New Form
    Public Function closeform()
        For Each fm In frmmain.MdiChildren
            f.Close()
        Next
        Return True
    End Function
End Class