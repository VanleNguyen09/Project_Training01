Imports System.Text.RegularExpressions

Public Class Validation
    Shared Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Return emailExpression.IsMatch(email)
    End Function

    Shared Function CheckPassword(ByVal pass As String) As Boolean
        If pass.Length < 6 Then
            Return False
        End If
        Return True
    End Function

    Shared Function CheckConfirmPassword(ByVal pass As String, ByVal cPass As String) As Boolean
        Return pass = cPass
    End Function
End Class
