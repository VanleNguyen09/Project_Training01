Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class frm_EmpInDept
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Private Property DeptEmpId As Integer

    Private Class Selected_EmpDept
        Public department_name As String = ""
        Public from_date As Date = Date.Now()
        Public to_date As Date = Date.Now()
        Public deptemp_id As Integer
        Public Sub New()
        End Sub
    End Class

    Private selectedEmpDept As Selected_EmpDept = New Selected_EmpDept

    Private currentPage As Integer = GlobalVariables.currentPage
    Private totalPages As Integer = GlobalVariables.totalPages
    Private pageSize As Integer = GlobalVariables.pageSize
    Private totalRows As Integer = GlobalVariables.totalRows

    Dim buttonOK As MessageBoxButtons = GlobalVariables.buttonOK
    Dim buttonYesNo As MessageBoxButtons = GlobalVariables.buttonYesNo
    Dim warmIcon As MessageBoxIcon = GlobalVariables.warmIcon
    Dim questionIcon As MessageBoxIcon = GlobalVariables.questionIcon
    Dim infoIcon As MessageBoxIcon = GlobalVariables.infoIcon
    Dim errorIcon As MessageBoxIcon = GlobalVariables.errorIcon

    Dim titleSucces As String = GlobalVariables.titleSucces
    Dim titleNotif As String = GlobalVariables.titleNotif
    Dim titleError As String = GlobalVariables.titleError
    Dim titleConfỉrm As String = GlobalVariables.titleConfirm
    Dim titleInfo As String = GlobalVariables.titleInfo
    Private Sub frm_EmpInDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomElements.AddClearButtonInsideTextBox(txt_Search, "pbCloseSearch", Sub()
                                                                                    txt_Search.Text = ""
                                                                                    gbtn_Search.PerformClick()
                                                                                End Sub)
        Dim initialDepartment As ComboBoxItem = New ComboBoxItem("Select Department", "-1")
        Dim initialEmployee As ComboBoxItem = New ComboBoxItem("Select Employee", "-1")
        GlobalVariables.lblPage = lbl_Page
        dtp_FromDate.Value = Date.Now()
        dtp_ToDate.Value = Date.Now()
        cb_Department.Items.Add(initialDepartment)
        cb_DepCreate.Items.Add(initialDepartment)
        cb_EmpCreate.Items.Add(initialEmployee)
        cb_Department.SelectedIndex = 0
        cb_DepCreate.SelectedIndex = 0
        cb_EmpCreate.SelectedIndex = 0
        dgv_DeptEmp.Columns("No").SortMode = DataGridViewColumnSortMode.NotSortable
        EnableAdd()
        dgv_DeptEmp.Rows.Clear()
        totalRows = GetTotalRowsEmpDept()
        LoadData()
        UpdatePaginationPicBox()
        Select_Departments()
        Select_Employees()
    End Sub

    Private Function GetTotalRowsEmpDept() As Integer
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CountTotalEmpDept", con)
                cmd.CommandType = CommandType.StoredProcedure
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read Then
                        totalRows = reader("SL_ED").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
        Finally
            con.Close()
        End Try
        Return totalRows
    End Function


    Private Sub frm_EmpInDept_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgv_DeptEmp.ClearSelection()
    End Sub

    Private Sub EnableAdd()
        gbtn_Add.Enabled = True
        gbtn_Update.Enabled = False
        gbtn_Delete.Enabled = False
        gbtn_Reset.Enabled = False
    End Sub

    Private Sub DisableAdd()
        gbtn_Add.Enabled = False
        gbtn_Update.Enabled = True
        gbtn_Delete.Enabled = True
        gbtn_Reset.Enabled = True
    End Sub

    Private Sub ClearForm()
        cb_DepCreate.SelectedIndex = 0
        cb_EmpCreate.SelectedIndex = 0
        dtp_FromDate.Value = Date.Now()
        cb_EmpCreate.Enabled = True
        dtp_ToDate.Value = Date.Now()
        dgv_DeptEmp.ClearSelection()
        grb_create.Enabled = True
        ptb_Next.Enabled = True
        ptb_Previous.Enabled = False
        ' Set Value of Checkbox to False
        For Each row As DataGridViewRow In dgv_DeptEmp.Rows
            Dim checkboxCell As DataGridViewCheckBoxCell = DirectCast(row.Cells("ckb_Delete"), DataGridViewCheckBoxCell)
            checkboxCell.Value = False
        Next
        currentPage = 1
    End Sub

    Private Enum EmpDeptParameters
        empId
        deptId
        fromDate
        toDate
        deptEmpId
    End Enum

    Private Class ComboBoxItem
        Public displayvalue As String
        Public hiddenvalue As String

        Public Sub New(ByVal displayvalue As String, ByVal hiddenvalue As String)
            Me.displayvalue = displayvalue
            Me.hiddenvalue = hiddenvalue
        End Sub

        Public Overrides Function tostring() As String
            Return displayvalue
        End Function
    End Class
    Private Sub ShowEmployeeDept(ByVal No As Integer, ByVal reader As SqlDataReader)
        Dim id As Integer = Convert.ToInt32(reader("id").ToString())
        Dim name As String = reader("name").ToString()
        Dim phone As String = reader("phone").ToString()
        Dim address As String = reader("address").ToString()
        Dim birthday As String = reader("birthday").ToString()
        Dim birthdayFormat As String = FuntionCommon.FormatDateTime.FormatDateTime(birthday)
        Dim email As String = reader("email").ToString()
        Dim department_name As String = reader("department_name").ToString()
        Dim from_date As String = reader("from_date").ToString()
        Dim fromDateFormat As String = FuntionCommon.FormatDateTime.FormatDateTime(from_date)
        Dim to_date As String = reader("to_date").ToString()
        Dim toDateFormat As String = FuntionCommon.FormatDateTime.FormatDateTime(to_date)
        Dim dept_id As Integer = Convert.ToInt32(reader("dept_id").ToString())
        Dim status As Integer = Convert.ToInt32(reader("status").ToString())
        Dim deptemp_id As Integer = Convert.ToInt32(reader("deptemp_id").ToString())

        dgv_DeptEmp.Rows.Add(No, id, name, phone, birthdayFormat, address, email, department_name, fromDateFormat, toDateFormat, dept_id, status, deptemp_id)
    End Sub

    Private Sub LoadData()
        If con.State() <> 1 Then
            con.Open()
        End If
        dgv_DeptEmp.Rows.Clear()
        Using cmd As SqlCommand = New SqlCommand("GetAllEmployeesByDepartment", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@currentPage", currentPage)
            cmd.Parameters.AddWithValue("@pageSize", pageSize)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim No As Integer = 1

            While reader.Read()
                ShowEmployeeDept(No, reader)
                No += 1
            End While
            con.Close()
        End Using
        Pagination.Paginatedatagridview2(currentPage, totalRows)
    End Sub
    Private Sub Select_Departments()
        If con.State <> 1 Then
            con.Open()
        End If

        Using cmd As SqlCommand = New SqlCommand("GetAllDepartments", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader
                While reader.Read
                    Dim currentItem As ComboBoxItem = New ComboBoxItem(reader("name"), reader("id"))
                    cb_Department.Items.Add(currentItem)
                    cb_DepCreate.Items.Add(currentItem)
                End While
            End Using
        End Using
    End Sub

    Private Sub Select_Employees()
        If con.State <> 1 Then
            con.Open()
        End If

        Using cmd As SqlCommand = New SqlCommand("GetAllEmployees", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader
                While reader.Read
                    Dim currentItem As ComboBoxItem = New ComboBoxItem(reader("id") & " - " & reader("name"), reader("id"))
                    cb_EmpCreate.Items.Add(currentItem)
                End While
            End Using
        End Using
    End Sub
    Private Function CheckManagerExit(ByVal emp_id As Integer, ByVal dept_id As Integer) As Boolean
        CheckManagerExit = False
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckManagerExit", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                cmd.ExecuteNonQuery()

                Dim isExited As Integer = 0
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        isExited = CInt(reader("ReturnValue"))
                    End If
                End Using

                If isExited = 1 Then
                    CheckManagerExit = True
                End If
            End Using
        Catch ex As Exception
            CheckManagerExit = False
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
        Finally
            con.Close()
        End Try
        Return CheckManagerExit
    End Function

    Private Function CheckEmpDeptExit(ByVal emp_id As Integer, ByVal dept_id As Integer) As Boolean
        CheckEmpDeptExit = False
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckEmpDeptExit", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                cmd.ExecuteNonQuery()

                Dim isExited As Integer = 0
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        isExited = CInt(reader("ReturnValue"))
                    End If
                End Using

                If isExited = 1 Then
                    CheckEmpDeptExit = True
                End If

            End Using
        Catch ex As Exception
            CheckEmpDeptExit = False
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
        Finally
            con.Close()
        End Try
        Return CheckEmpDeptExit
    End Function

    Private Function CheckEmpDeptExitForUpdate(ByVal emp_id As Integer, ByVal dept_id As Integer, ByVal id As Integer) As Boolean
        CheckEmpDeptExitForUpdate = False
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckEmpDeptExitForUpdate", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()

                Dim isExited As Integer = 0
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        isExited = CInt(reader("ReturnValue"))
                    End If
                End Using

                If isExited = 1 Then
                    CheckEmpDeptExitForUpdate = True
                End If
            End Using
        Catch ex As Exception
            CheckEmpDeptExitForUpdate = False
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
        Finally
            con.Close()
        End Try
        Return CheckEmpDeptExitForUpdate
    End Function

    Private Function CheckEmpDeptDateBigger(ByVal emp_id As Integer, ByVal dept_id As Integer, ByVal from_date As Date, ByVal to_date As Date) As Boolean
        CheckEmpDeptDateBigger = False
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckEmpDeptDateBigger", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                cmd.Parameters.AddWithValue("@from_date", from_date)
                cmd.Parameters.AddWithValue("@to_date", to_date)
                cmd.ExecuteNonQuery()

                Dim isBigger As Integer = 0
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        isBigger = CInt(reader("ReturnValue"))
                    End If
                End Using

                If isBigger = 1 Then
                    CheckEmpDeptDateBigger = True
                End If

            End Using
        Catch ex As Exception
            CheckEmpDeptDateBigger = False
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
        Finally
            con.Close()
        End Try
        Return CheckEmpDeptDateBigger
    End Function

    Private Sub Add_EmpDept(ByVal values As Dictionary(Of EmpDeptParameters, Object))
        Dim status As Integer = 1
        Dim empId As Integer = CInt(values(EmpDeptParameters.empId))
        Dim deptId As Integer = CInt(values(EmpDeptParameters.deptId))

        If CheckManagerExit(empId, deptId) Then
            MessageBox.Show(Message.Message.managerExitedForDepartment, titleNotif, buttonOK, warmIcon)
            Exit Sub
        ElseIf CheckEmpDeptExit(empId, deptId) Then
            MessageBox.Show(Message.Message.empDeptDuplicate, titleNotif, buttonOK, warmIcon)
            Exit Sub
        Else
            If con.State <> 1 Then
                con.Open()
            End If
            Try
                Using cmd As SqlCommand = New SqlCommand("InsertDeptEmp", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@emp_id", empId)
                    cmd.Parameters.AddWithValue("@dept_id", deptId)
                    cmd.Parameters.AddWithValue("@from_date", values(EmpDeptParameters.fromDate))
                    cmd.Parameters.AddWithValue("@to_date", values(EmpDeptParameters.toDate))
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(Message.Message.empDeptAddSuccess, titleSucces, buttonOK, infoIcon)
                End Using
                ClearForm()
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Update_EmpDept(ByVal values As Dictionary(Of EmpDeptParameters, Object))
        Dim status As Integer = 1
        Dim empId As Integer = CInt(values(EmpDeptParameters.empId))
        Dim deptId As Integer = CInt(values(EmpDeptParameters.deptId))
        Dim fromDate As Date = Convert.ToDateTime(values(EmpDeptParameters.fromDate))
        Dim toDate As Date = Convert.ToDateTime(values(EmpDeptParameters.toDate))
        Dim id As Integer = CInt(values(EmpDeptParameters.deptEmpId))

        If CheckManagerExit(empId, deptId) Then
            MessageBox.Show(Message.Message.managerExitedForDepartment, titleNotif, buttonOK, warmIcon)
            Exit Sub
        ElseIf CheckEmpDeptExitForUpdate(empId, deptId, id) Then
            MessageBox.Show(Message.Message.empDeptDuplicate, titleNotif, buttonOK, warmIcon)
            Exit Sub
        ElseIf CheckEmpDeptDateBigger(empId, deptId, fromDate, toDate) Then
            MessageBox.Show(Message.Message.dateSmallerValid, titleNotif, buttonOK, warmIcon)
            Exit Sub
        Else
            If con.State <> 1 Then
                con.Open()
            End If

            Try
                Using cmd As SqlCommand = New SqlCommand("UpdateDeptEmp", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@emp_id", empId)
                    cmd.Parameters.AddWithValue("@dept_id", deptId)
                    cmd.Parameters.AddWithValue("@from_date", values(EmpDeptParameters.fromDate))
                    cmd.Parameters.AddWithValue("@to_date", values(EmpDeptParameters.toDate))
                    cmd.Parameters.AddWithValue("@deptemp_id", values(EmpDeptParameters.deptEmpId))

                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(Message.Message.empDeptUpdateSuccess, titleSucces, buttonOK, infoIcon)
                End Using
                ClearForm()
                LoadData()
                EnableAdd()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub SearchEmpDeptKeyword(ByVal keyword As String, ByVal department_id As Integer)
        Console.WriteLine(keyword)
        If con.State <> 1 Then
            con.Open()
        End If

        dgv_DeptEmp.Rows.Clear()
        Dim reload = False
        Using cmd As SqlCommand = New SqlCommand("GetEmpDeptByKeyWord", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@keyword", keyword)
            cmd.Parameters.AddWithValue("@department_id", department_id)
            cmd.Parameters.AddWithValue("@currentPage", currentPage)
            cmd.Parameters.AddWithValue("@pageSize", pageSize)
            Dim No As Integer = 1

            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ShowEmployeeDept(No, reader)
                        No += 1
                    End While
                    totalRows = dgv_DeptEmp.Rows.Count
                Else
                    MessageBox.Show(Message.Message.errorInvalidSearch, titleNotif, buttonOK, warmIcon)
                    reload = True
                End If
                Pagination.Paginatedatagridview2(currentPage, totalRows)
                UpdatePaginationPicBox()
            End Using
        End Using
        con.Close()
        If reload Then
            txt_Search.Text = Nothing
            totalRows = GetTotalRowsEmpDept()
            LoadData()
            UpdatePaginationPicBox()
            cb_Department.SelectedIndex = 0
        End If
    End Sub

    Private Sub Delete_EmpDept(ByVal emp_id As Integer, ByVal dept_id As Integer)
        If con.State <> 1 Then
            con.Open()
        End If

        Try
            Using cmd As SqlCommand = New SqlCommand("DeleteEmployeeInDepartment", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@dept_id", dept_id) ' Thêm tham số dept_id vào thủ tục xóa
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cb_Department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Department.SelectedIndexChanged
        Dim dept_id As Integer = cb_Department.SelectedItem.hiddenvalue
        dgv_DeptEmp.RowCount = 0
        If con.State <> 1 Then
            con.Open()
        End If
        Dim reader As SqlDataReader
        If dept_id = -1 Then
            Using cmd As SqlCommand = New SqlCommand("GetAllEmployeesByDepartment", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@currentPage", currentPage)
                cmd.Parameters.AddWithValue("@pageSize", pageSize)
                reader = cmd.ExecuteReader()
                Dim No As Integer = 1
                While reader.Read()
                    ShowEmployeeDept(No, reader)
                    No += 1
                    Pagination.Paginatedatagridview2(currentPage, totalRows)
                End While
                con.Close()
            End Using
        Else
            Using cmd As SqlCommand = New SqlCommand("GetEmployeeByDepartment", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                cmd.Parameters.AddWithValue("@currentPage", currentPage)
                cmd.Parameters.AddWithValue("@pageSize", pageSize)
                reader = cmd.ExecuteReader()
                Dim No As Integer = 1
                While reader.Read()
                    ShowEmployeeDept(No, reader)
                    No += 1
                    Pagination.Paginatedatagridview2(currentPage, totalRows)
                End While
                con.Close()
            End Using
        End If
    End Sub
    Private Sub gbtn_Add_Click(sender As Object, e As EventArgs) Handles gbtn_Add.Click
        Dim emp_id As Integer = cb_EmpCreate.SelectedItem.hiddenvalue
        Dim dept_id As Integer = cb_DepCreate.SelectedItem.hiddenvalue
        Dim from_date As Date = dtp_FromDate.Value
        Dim to_date As Date = dtp_ToDate.Value

        If emp_id < 0 OrElse dept_id < 0 Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleError, buttonOK, warmIcon)
            Exit Sub
        End If

        Dim datesValid As Boolean = FuntionCommon.Validation.ValidateDate(from_date, to_date)

        If Not datesValid Then
            MessageBox.Show(Message.Message.errorInvalidDate, titleError, buttonOK, warmIcon)
            Exit Sub
        End If

        Dim fromInputYear As Integer = from_date.Year
        Dim toInputYear As Integer = to_date.Year
        Dim currentYear As Integer = DateTime.Now.Year

        Dim fromIsValid As Boolean = FuntionCommon.Validation.ValidateYear(fromInputYear, currentYear)
        Dim toIsValid As Boolean = FuntionCommon.Validation.ValidateYear(toInputYear, currentYear)

        If Not fromIsValid OrElse Not toIsValid Then
            MessageBox.Show(Message.Message.yearInvalidError, titleNotif, buttonOK, warmIcon)
            Exit Sub
        End If

        Dim values As New Dictionary(Of EmpDeptParameters, Object)
        values.Add(EmpDeptParameters.empId, emp_id)
        values.Add(EmpDeptParameters.deptId, dept_id)
        values.Add(EmpDeptParameters.fromDate, from_date)
        values.Add(EmpDeptParameters.toDate, to_date)

        Add_EmpDept(values)
    End Sub

    Private Sub gbtn_Clear_Click(sender As Object, e As EventArgs) Handles gbtn_Clear.Click
        ClearForm()
        LoadData()
        EnableAdd()
    End Sub
    Private Sub gbtn_Search_Click(sender As Object, e As EventArgs) Handles gbtn_Search.Click
        Dim keyword As String = txt_Search.Text.Trim()
        Dim department_id As Integer = cb_Department.SelectedItem.hiddenvalue
        If Not String.IsNullOrEmpty(keyword) Then
            SearchEmpDeptKeyword(keyword, department_id)
        Else
            cb_Department.SelectedIndex = 0
            dgv_DeptEmp.Rows.Clear()
        End If
    End Sub

    Private Sub gbtn_Delete_Click(sender As Object, e As EventArgs) Handles gbtn_Delete.Click
        ' Check if any row is selected
        Dim selectedRows As New List(Of DataGridViewRow)()

        For Each row As DataGridViewRow In dgv_DeptEmp.Rows
            Dim checkboxCell As DataGridViewCheckBoxCell = TryCast(row.Cells("ckb_Delete"), DataGridViewCheckBoxCell)
            If checkboxCell IsNot Nothing AndAlso checkboxCell.Value = True Then
                selectedRows.Add(row)
            End If
        Next

        ' Check if no row is selected
        If selectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one checkbox to delete", titleNotif, buttonOK, warmIcon)
            Return
        End If

        ' Show delete confirmation message
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete the selected employee?", titleConfỉrm, buttonYesNo, questionIcon)
        Dim employeeIdColumn As DataGridViewColumn = dgv_DeptEmp.Columns("EmployeeID")

        ' Delete rows if user confirm
        Dim empIdColumn As DataGridViewColumn = dgv_DeptEmp.Columns("emp_id")
        Dim deptIdColumn As DataGridViewColumn = dgv_DeptEmp.Columns("dept_id")
        If confirmResult = DialogResult.Yes Then
            For Each row As DataGridViewRow In selectedRows
                Dim emp_id As Integer = CInt(row.Cells(empIdColumn.Index).Value)
                Dim dept_id As Integer = CInt(row.Cells(deptIdColumn.Index).Value)
                Delete_EmpDept(emp_id, dept_id)
                ClearForm()
            Next
            LoadData()
            EnableAdd()
        End If

        'If selectedRows.Count > 0 Then
        '    Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected employee(s)?", titleConfỉrm, buttonYesNo, questionIcon)

        '    If result = DialogResult.Yes Then
        '        Dim empIdColumn As DataGridViewColumn = dgv_DeptEmp.Columns("emp_id")
        '        Dim deptIdColumn As DataGridViewColumn = dgv_DeptEmp.Columns("dept_id")

        '        If empIdColumn IsNot Nothing And deptIdColumn IsNot Nothing Then
        '            MessageBox.Show(Message.Message.empDeptDeleteSuccess, titleSucces, buttonOK, infoIcon)
        '            For i As Integer = 0 To selectedRows.Count - 1
        '                Dim selectedRow As DataGridViewRow = selectedRows(i)
        '                Dim emp_id As Integer = CInt(selectedRow.Cells(empIdColumn.Index).Value)
        '                Dim dept_id As Integer = CInt(selectedRow.Cells(deptIdColumn.Index).Value)
        '                Delete_EmpDept(emp_id, dept_id)
        '                ClearForm()
        '            Next
        '            LoadData()
        '            EnableAdd()
        '        End If
        '    End If
        'End If
    End Sub
    Private Sub gbtn_Update_Click(sender As Object, e As EventArgs) Handles gbtn_Update.Click
        Dim dept_id As Integer = CInt(cb_DepCreate.SelectedItem.hiddenvalue)
        Dim emp_id As Integer = CInt(cb_EmpCreate.SelectedItem.hiddenvalue)
        Dim from_date As Date = dtp_FromDate.Value
        Dim to_date As Date = dtp_ToDate.Value

        If emp_id < 0 OrElse dept_id < 0 Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleNotif, buttonOK, warmIcon)
            Exit Sub
        End If

        Dim datesValid As Boolean = FuntionCommon.Validation.ValidateDate(from_date, to_date)

        If Not datesValid Then
            MessageBox.Show(Message.Message.errorInvalidDate, titleError, buttonOK, warmIcon)
            Exit Sub
        End If

        Dim fromInputYear As Integer = from_date.Year
        Dim toInputYear As Integer = to_date.Year
        Dim currentYear As Integer = DateTime.Now.Year

        Dim fromIsValid As Boolean = FuntionCommon.Validation.ValidateYear(fromInputYear, currentYear)
        Dim toIsValid As Boolean = FuntionCommon.Validation.ValidateYear(toInputYear, currentYear)


        If Not fromIsValid OrElse Not toIsValid Then
            MessageBox.Show(Message.Message.yearInvalidError, titleNotif, buttonOK, warmIcon)
            Exit Sub
        End If

        Dim values As New Dictionary(Of EmpDeptParameters, Object)
        values.Add(EmpDeptParameters.empId, emp_id)
        values.Add(EmpDeptParameters.deptId, dept_id)
        values.Add(EmpDeptParameters.fromDate, from_date)
        values.Add(EmpDeptParameters.toDate, to_date)
        values.Add(EmpDeptParameters.deptEmpId, DeptEmpId)

        Update_EmpDept(values)
    End Sub

    Private selectedEmpId As Integer

    Private Sub dgv_DeptEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DeptEmp.CellClick
        If e.ColumnIndex = dgv_DeptEmp.Columns.Count - 1 Then
            dgv_DeptEmp.SelectionMode = DataGridViewSelectionMode.CellSelect
            dgv_DeptEmp.ReadOnly = False
            cb_DepCreate.SelectedIndex = 0
            cb_EmpCreate.SelectedIndex = 0
            dtp_FromDate.Value = Date.Now()
            dtp_ToDate.Value = Date.Now()
        Else
            If e.RowIndex >= 0 Then
                Dim selectedrow = dgv_DeptEmp.Rows(e.RowIndex)
                selectedEmpId = CInt(selectedrow.Cells("emp_id").Value)
                For Each item As ComboBoxItem In cb_DepCreate.Items
                    If item.displayvalue = selectedrow.Cells("department_name").Value.ToString() Then
                        cb_DepCreate.SelectedItem = item
                        Exit For
                    End If
                Next

                Dim empId As Integer
                If Integer.TryParse(selectedrow.Cells("emp_id").Value.ToString(), empId) Then
                    For Each item As ComboBoxItem In cb_EmpCreate.Items
                        If CInt(item.hiddenvalue) = empId Then
                            cb_EmpCreate.SelectedItem = item
                            Exit For
                        End If
                    Next
                End If

                selectedEmpDept.department_name = cb_DepCreate.SelectedItem.displayvalue

                dtp_FromDate.Value = Convert.ToDateTime(selectedrow.Cells("from_date").Value)
                selectedEmpDept.from_date = dtp_FromDate.Value
                dtp_ToDate.Value = Convert.ToDateTime(selectedrow.Cells("to_date").Value)
                selectedEmpDept.to_date = dtp_ToDate.Value
                DeptEmpId = CInt(selectedrow.Cells("deptemp_id").Value)
                selectedEmpDept.deptemp_id = DeptEmpId
                deptemp_id.ReadOnly = True
                gbtn_Add.Enabled = False
                gbtn_Delete.Enabled = True
                cb_EmpCreate.Enabled = False
            End If
        End If
        DisableAdd()
    End Sub
    Private Sub gbtn_Reset_Click(sender As Object, e As EventArgs) Handles gbtn_Reset.Click
        For Each item As ComboBoxItem In cb_DepCreate.Items
            If item.displayvalue = selectedEmpDept.department_name Then
                cb_DepCreate.SelectedItem = item
                Exit For
            End If
        Next
        dtp_FromDate.Value = selectedEmpDept.from_date
        dtp_ToDate.Value = selectedEmpDept.to_date
        DeptEmpId = selectedEmpDept.deptemp_id
    End Sub

    Private Sub cb_DepCreate_KeyDown(sender As Object, e As KeyEventArgs) Handles cb_DepCreate.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cb_EmpCreate.Focus()
        End If
    End Sub

    Private Sub cb_EmpCreate_KeyDown(sender As Object, e As KeyEventArgs) Handles cb_EmpCreate.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtp_FromDate.Focus()
        End If
    End Sub

    Private Sub dtp_FromDate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_FromDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtp_ToDate.Focus()
        End If
    End Sub

    Private Sub dtp_ToDate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_ToDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If gbtn_Add.Enabled = True Then
                gbtn_Add.Focus()
            Else
                gbtn_Update.Focus()
            End If
        End If
    End Sub

    Private Sub ptb_Icon_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
        NewDashboard.ShowFormInMainPanel(frm_Employee)
        NewDashboard.currentSelection = "Employee"
        NewDashboard.UpdateTitleLabel()
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        txt_Search.Controls("pbCloseSearch").Visible = (txt_Search.Text.Length > 0)
    End Sub

    Private Sub UpdatePaginationPicBox()
        If currentPage = 1 Then
            ptb_Previous.Enabled = False
        Else
            ptb_Previous.Enabled = True
        End If

        If currentPage = Math.Ceiling(totalRows / pageSize) Then
            ptb_Next.Enabled = False
        Else
            ptb_Next.Enabled = True
        End If
    End Sub

    Private Sub ptb_Previous_Click(sender As Object, e As EventArgs) Handles ptb_Previous.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadData()
        End If
        UpdatePaginationPicBox()
    End Sub

    Private Sub ptb_Next_Click(sender As Object, e As EventArgs) Handles ptb_Next.Click
        totalPages = Math.Ceiling(totalRows / pageSize)

        If currentPage < totalPages Then
            currentPage += 1
            LoadData()
        End If
        UpdatePaginationPicBox()
    End Sub

    Private Sub dgv_DeptEmp_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_DeptEmp.ColumnHeaderMouseClick
        FuntionCommon.SortationNO.SortAndPreventNoColumnSorting(dgv_DeptEmp, "No")
        Pagination.Paginatedatagridview2(currentPage, totalRows)
    End Sub

    Private Sub dgv_DeptEmp_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DeptEmp.CellMouseEnter
        If (e.ColumnIndex = 6 OrElse e.ColumnIndex = 7) AndAlso e.RowIndex >= 0 Then
            ' Set the pointer type to hand when hovering the mouse over the cell
            dgv_DeptEmp.Cursor = Cursors.Hand
        Else
            dgv_DeptEmp.Cursor = Cursors.Default
        End If
    End Sub
End Class