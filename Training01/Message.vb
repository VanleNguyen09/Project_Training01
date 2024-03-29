﻿Public Class Message
    Public Structure Message
        Shared emailErrorMessage As String = "Email is wrong syntax! Please check again!"
        Shared emptyErrorMessage As String = "All fields are not empty!"
        Shared passwordErrorMessage As String = "Password must be more than 6 characters!"
        Shared cPasswordErrorMessage As String = "Password and Confirm Password are not the same!"
        Shared registeredEmailMsg As String = "This Email has been registered. Please register other email!"
        Shared successfulregisterMsg As String = "You registerd successfully!"
        Shared failedLoginMsg As String = "Login Failed! Please check again carefully!"
        Shared existedPosForThisEmp As String = "This position is existed for this employee!"
        Shared successfullAddPosForThisEmp As String = "You added successfully!"
        Shared errorSQLQuery As String = "SQL Query is failed! Please check again!"
        Shared successfullDeleteEmpPos As String = "This employee is deleted successfully!"
        Shared emptyDataErrorMessage As String = "Please fill full data!!!"
        Shared emailInvalidMessage As String = "Please fill an valid email!!!"
        Shared phoneInvalidMessage As String = "Please fill an valid phone number!!!"
        Shared errorInvalidSearch As String = "Cannot find the matching result!!!"
        Shared emptyDataSearchMessage As String = "Please enter search keyword!!!"
        Shared confirmedDelete As String = "Do you confirm delete?"
        Shared selectedRowError As String = "Please select at least one row!"
        Shared selectedPositionError As String = "Please select position in combobox!"
        Shared successfully As String = "Successfully!"
        Shared confirmedUpdate As String = "Do you confirm update?"
        Shared nothingChange As String = "Nothing changed in DataTable!"
        Shared errorInvalidId As String = "Invalid ID. Please enter a numeric value!!!"
        Shared errorInvalidSalary As String = "Invalid Salary. Please enter a numeric value!!!"
        Shared errorInvalidDate As String = "Invalid date range. The 'From Date' cannot be greater than the 'To Date'!!!"
    End Structure

    Public Structure Title
        Shared [error] As String = "ERROR"
        Shared success As String = "SUCCESS"
        Shared notif As String = "NOTIFICATION"
        Shared errorInvalidId As String = "Invalid ID. Please enter a numeric value!!!"
        Shared errorInvalidSalary As String = "Invalid Salary. Please enter a numeric value!!!"
        Shared errorInvalidDate As String = "Invalid date range. The 'From Date' cannot be greater than the 'To Date'!!!"
    End Structure
End Class
