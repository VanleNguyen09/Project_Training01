Public Class FormatDateTime
    Public Shared Function FormatDateTime(ByRef dt As DateTime) As String
        Return dt.Date.ToString("dd/MM/yyyy")
    End Function
End Class
