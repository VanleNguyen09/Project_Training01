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
        Shared errorInvalidSalary As String = "Please enter numeric type and have a maximum of 10 numbers and 2 decimal places if possible!"
        Shared errorInvalidDate As String = "Invalid date range. The 'From Date' cannot be greater than the 'To Date'!!!"
        Shared managerExitedForDepartment As String = "Manager has name and id is exited for this department. Can not add employee. Please try again!!!"
        Shared departmentExited As String = "Department is exited. Please try again!!!"
        Shared employeeExitedForDepartment As String = "Employee has name and id is exited for this department. Can not add manager. Please try again!!!"
        Shared chooseOneRow As String = "Please only choose one salary that you want to set salary!"
        Shared confirmCreate As String = "Are you sure to confirm create?"
        Shared departmentDuplicate As String = "Duplicate department entry!!!"
        Shared managerDuplicate As String = "Duplicate manager entry!!!"
        Shared employeeDuplicate As String = "Duplicate employee entry!!!"
        Shared yearInvalidError As String = "Year is invalid. Please try again!!!"
        Shared imageEmptyError As String = "Please select an image. Let's try again!!!"
        Shared errorNumberType As String = "Content is not number! Please enter again!!!"
        Shared errorPageNumber As String = "The number of entries cannot be less than 1 or exceed the total number of pages!"
        Shared employeeAddSuccess As String = "Employee has been added successfully!!!"
        Shared employeeUpdateSuccess As String = "Employee has been updated successfully!!!"
        Shared employeeDeleteSuccess As String = "Employee has been deleted successfully!!!"
        Shared departmentAddSuccess As String = "Department has been added successfully!!!"
        Shared departmentUpdateSuccess As String = "Department has been updated successfully!!!"
        Shared departmentDeleteSuccess As String = "Department has been deleted successfully!!!"
        Shared managerAddSuccess As String = "Manager has been added successfully!!!"
        Shared managerUpdateSuccess As String = "Manager has been updated successfully!!!"
        Shared managerDeleteSuccess As String = "Manager has been deleted successfully!!!"
        Shared empDeptAddSuccess As String = "Employee Department has been added successfully!!!"
        Shared empDeptUpdateSuccess As String = "Employee Department has been updated successfully!!!"
        Shared empDeptDeleteSuccess As String = "Employee Department has been deleted successfully!!!"
        Shared exportPDFSuccess As String = "Salary slip has been exported successfully!!!"
        Shared exportPDFCancel As String = "Salary slip has been canceled!!!"
        Shared cancelSavePDFSuccess As String = "Cancel save PDF file successly!!!"
        Shared loginSuccess As String = "Login succes. User can access to dashboard page"
        Shared logoutSuccess As String = "You logout success!!!"
        Shared cancelDelete As String = "Deletion canceled."
        Shared dateSmallerValid As String = "Date is smaller than date exist in system. Please try again!!!"
    End Structure

    Public Structure Title
        Shared [error] As String = "ERROR"
        Shared success As String = "SUCCESS"
        Shared notif As String = "NOTIFICATION"
        Shared errorInvalidId As String = "Invalid ID. Please enter a numeric value!!!"
        Shared errorInvalidSalary As String = "Invalid Salary. Please enter a numeric value!"
        Shared errorInvalidDate As String = "Invalid date range. The 'From Date' cannot be greater than the 'To Date'!!!"
    End Structure
End Class
