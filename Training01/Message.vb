Public Class Message
    Public Structure Message
        Shared emailErrorMessage As String = "Email is wrong syntax! Please check again!"
        Shared emptyErrorMessage As String = "All fields are not empty!"
        Shared passwordErrorMessage As String = "Password must be more than 6 characters!"
        Shared cPasswordErrorMessage As String = "Password and Confirm Password are not the same!"
        Shared registeredEmailMsg As String = "This Email has been registered. Please register other email!"
        Shared successfulregisterMsg As String = "You registerd successfully!"
        Shared failedLoginMsg As String = "Login Failed! Please check again carefully!"
    End Structure
End Class
