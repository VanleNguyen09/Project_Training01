Imports System.Text.RegularExpressions

Public Class Validation
    Shared Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailExpression.IsMatch(email)
    End Function

    Shared Function ValidateDate(dateString) As Boolean
        Dim date_regex As String = "^(0[1-9]|1[0-2])/(0[1-9]|1\d|2\d|3[01])/(19|20)\d{2}$"
        Return Regex.IsMatch(dateString, date_regex)
    End Function
    Shared Function ValidatePhone(phoneNumber As String) As Boolean
        Dim phone_regex As String = "^\d{3}-\d{3}-\d{4}$"
        Return Regex.IsMatch(phoneNumber, phone_regex)
    End Function
End Class
