﻿Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class frm_EmpInDept

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

    Private Sub frm_EmpInDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim initialDepartment As ComboBoxItem = New ComboBoxItem("Select Department", "-1")
        Dim initialEmployee As ComboBoxItem = New ComboBoxItem("Select Employee", "-1")
        cb_Department.Items.Add(initialDepartment)
        cb_DepCreate.Items.Add(initialDepartment)
        cb_EmpCreate.Items.Add(initialEmployee)
        cb_Department.SelectedIndex = 0
        cb_DepCreate.SelectedIndex = 0
        cb_EmpCreate.SelectedIndex = 0

        Select_Departments()
        Select_Employees()
        LoadAndSortData()
    End Sub

    Private Sub EnableAdd()
        btn_Add.Enabled = True
        btn_Update.Enabled = False
        btn_Delete.Enabled = False
        btn_Reset.Enabled = False
        MakeButtonBackgroundBlurry(btn_Update)
        MakeButtonBackgroundBlurry(btn_Delete)
    End Sub

    Private Sub DisableAdd()
        btn_Add.Enabled = False
        btn_Update.Enabled = True
        btn_Delete.Enabled = True
        btn_Reset.Enabled = True
        MakeButtonBackgroundBlurry(btn_Add)
    End Sub

    Private Sub ClearForm()
        cb_DepCreate.SelectedIndex = 0
        cb_EmpCreate.SelectedIndex = 0
        dtp_FromDate.Value = Date.Now()
        cb_EmpCreate.Enabled = True
        dtp_ToDate.Value = Date.Now()
        dgv_DeptEmp.ClearSelection() 'Xóa bỏ việc chọn hàng trong DataGridView             
        grb_create.Enabled = True
    End Sub

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

    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

    Public Sub ShowEmployeeDept(ByVal No As Integer, ByVal reader As SqlDataReader)
        Dim id As Integer = Convert.ToInt32(reader("id"))
        Dim name As String = reader("name").ToString()
        Dim phone As String = reader("phone").ToString()
        Dim address As String = reader("address").ToString()
        Dim birthday As String = reader("birthday").ToString()
        Dim email As String = reader("email").ToString()
        Dim department_name As String = reader("department_name").ToString()
        'Dim department_name As String = If(reader.IsDBNull(reader.GetOrdinal("department_name")), String.Empty, reader("department_name").ToString())
        Dim from_date As String = reader("from_date").ToString()
        Dim to_date As String = reader("to_date").ToString()
        Dim dept_id As Integer = Convert.ToInt32(reader("dept_id"))
        Dim status As Integer = Convert.ToInt32(reader("status"))
        Dim deptemp_id As Integer = Convert.ToInt32(reader("deptemp_id"))

        dgv_DeptEmp.Rows.Add(No, id, name, phone, birthday, address, email, department_name, from_date, to_date, dept_id, status, deptemp_id)
    End Sub

    Private Sub LoadData()
        If con.State() <> 1 Then
            con.Open()
        End If
        dgv_DeptEmp.Rows.Clear()
        Using cmd As SqlCommand = New SqlCommand("GetAllEmployeesByDepartment", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim No As Integer = 1

            While reader.Read()
                ShowEmployeeDept(No, reader)
                No = No + 1
            End While
            con.Close()
        End Using

    End Sub

    Private Sub LoadAndSortData()
        LoadData()
        SortDataById()
    End Sub

    Public Sub SortDataById()
        dgv_DeptEmp.Sort(dgv_DeptEmp.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
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

    Dim titleMsgBox As String = "Notification"
    Dim titleErrorBox As String = "Error"
    Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
    Dim icons As MessageBoxIcon = MessageBoxIcon.Warning
    Dim errorIcons As MessageBoxIcon = MessageBoxIcon.Error

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

                Dim returnValueParam As SqlParameter = New SqlParameter("@employee_exit", SqlDbType.Int)
                returnValueParam.Direction = ParameterDirection.Output
                cmd.Parameters.Add(returnValueParam)

                cmd.ExecuteNonQuery()

                If CInt(returnValueParam.Value) = 1 Then
                    CheckEmpDeptExit = True
                End If
            End Using
        Catch ex As Exception
            CheckEmpDeptExit = False
            MessageBox.Show("error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Return CheckEmpDeptExit
    End Function
    Private Sub Add_EmpDept(emp_id As Integer, dept_id As Integer, from_date As Date, to_date As Date)
        Dim status As Integer = 1
        'If CheckEmpDeptExit(emp_id, dept_id) = True Then
        '    MessageBox.Show(Message.Message.employeeExited, titleMsgBox, buttons, icons)
        '    Exit Sub
        'End If
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("InsertDeptEmp", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                cmd.Parameters.AddWithValue("@from_date", from_date)
                cmd.Parameters.AddWithValue("@to_date", to_date)
                cmd.Parameters.AddWithValue("@status", status)
                Dim isDuplicate As Integer = 0

                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        isDuplicate = CInt(reader("IsDuplicate"))
                    End If
                End Using
                If isDuplicate = 1 Then
                    MessageBox.Show(Message.Message.employeeDuplicate, titleMsgBox, buttons, icons)
                    Exit Sub
                Else
                    MessageBox.Show("Employee has been added successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                    LoadAndSortData()
                    Exit Sub
                End If
            End Using
            MessageBox.Show("Employee has been added successfully!!!", "Success", buttons, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Update_EmpDept(emp_id As Integer, dept_id As Integer, from_date As Date, to_date As Date, deptemp_id As Integer)
        Dim status As Integer = 1

        If con.State <> 1 Then
            con.Open()
        End If

        Try
            Using cmd As SqlCommand = New SqlCommand("UpdateDeptEmp", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                cmd.Parameters.AddWithValue("@from_date", from_date)
                cmd.Parameters.AddWithValue("@to_date", to_date)
                cmd.Parameters.AddWithValue("@deptemp_id", deptemp_id)
                cmd.Parameters.AddWithValue("@status", status)

                Dim isDuplicate As Integer = 0

                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        isDuplicate = CInt(reader("IsDuplicate"))
                    End If
                End Using

                If isDuplicate = 1 Then
                    MessageBox.Show(Message.Message.managerDuplicate, titleMsgBox, buttons, icons)
                Else
                    MessageBox.Show("Manager has been updated successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                    LoadAndSortData()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub SearchEmpDeptKeyword(keyword As String, department_id As Integer)
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
            Dim No As Integer = 1

            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ShowEmployeeDept(No, reader)
                        No = No + 1
                    End While
                Else
                    MessageBox.Show(Message.Message.errorInvalidSearch, titleMsgBox, buttons, icons)
                    reload = True
                End If
            End Using
        End Using
        con.Close()
        If reload Then
            txt_Search.Text = Nothing
            LoadAndSortData()
        End If
    End Sub

    Private Sub Delete_EmpDept(emp_id As Integer, dept_id As Integer)
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
            MessageBox.Show("Employee has been deleted successfully!!!", "Success", buttons, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        LoadAndSortData()
    End Sub

    Private Sub MakeButtonBackgroundBlurry(button As Button)
        Dim originalColor As Color = button.BackColor
        Dim blurredColor As Color = ControlPaint.Light(originalColor, 0.5)
        button.BackColor = blurredColor
    End Sub
    Private Sub ptb_Icon_Click(sender As Object, e As EventArgs) Handles ptb_Icon.Click
        Me.Close()
        Dim employee As New frm_Employee
        employee.Show()
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
                reader = cmd.ExecuteReader()
                Dim No As Integer = 1
                While reader.Read()
                    ShowEmployeeDept(No, reader)
                    No = No + 1
                End While
                con.Close()
            End Using
        Else
            Using cmd As SqlCommand = New SqlCommand("GetEmployeeByDepartment", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                reader = cmd.ExecuteReader()
                Dim No As Integer = 1
                While reader.Read()
                    ShowEmployeeDept(No, reader)
                    No = No + 1
                End While
                con.Close()
            End Using
        End If
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim emp_id As Integer = cb_EmpCreate.SelectedItem.hiddenvalue
        Dim dept_id As Integer = cb_DepCreate.SelectedItem.hiddenvalue
        Dim from_date As Date = dtp_FromDate.Value
        Dim to_date As Date = dtp_ToDate.Value

        'Validations for Add comboboxes
        If emp_id < 0 OrElse dept_id < 0 Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        ' Validate Date inputs
        Dim fromDate As Date = dtp_FromDate.Value
        Dim toDate As Date = dtp_ToDate.Value
        Dim datesValid As Boolean = FuntionCommon.Validation.ValidateDate(fromDate, toDate)

        If Not datesValid Then
            MessageBox.Show(Message.Message.errorInvalidDate, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If
        Add_EmpDept(emp_id, dept_id, from_date, to_date)
        ClearForm()
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        ClearForm()
        EnableAdd()
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim keyword As String = txt_Search.Text.Trim()
        Dim department_id As Integer = cb_Department.SelectedItem.hiddenvalue
        If Not String.IsNullOrEmpty(keyword) Then
            SearchEmpDeptKeyword(keyword, department_id)
        Else
            MessageBox.Show(Message.Message.emptyDataSearchMessage, titleMsgBox, buttons, icons)
            LoadAndSortData()
        End If
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
        Dim employee As New frm_Employee
        employee.Show()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgv_DeptEmp.SelectedRows

        If selectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected manager(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim empIdColumn As DataGridViewColumn = dgv_DeptEmp.Columns("emp_id") ' Replace "name" with the actual column name for department ID
                Dim deptIdColumn As DataGridViewColumn = dgv_DeptEmp.Columns("dept_id") ' Replace "name" with the actual column name for department ID

                If empIdColumn IsNot Nothing And deptIdColumn IsNot Nothing Then
                    For i As Integer = selectedRows.Count - 1 To 0 Step -1
                        Dim selectedRow As DataGridViewRow = selectedRows(i)
                        Dim emp_id As Integer = CInt(selectedRow.Cells(empIdColumn.Index).Value)
                        Dim dept_id As Integer = CInt(selectedRow.Cells(deptIdColumn.Index).Value)
                        Delete_EmpDept(emp_id, dept_id)
                    Next
                    ClearForm()
                    EnableAdd()
                End If
            Else
                MessageBox.Show("Please select at least one manager to delete.", "Warning", buttons, icons)
            End If
        End If
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Dim dept_id As Integer = CInt(cb_DepCreate.SelectedItem.hiddenvalue)
        Dim emp_id As Integer = CInt(cb_EmpCreate.SelectedItem.hiddenvalue)
        Dim from_date As Date = dtp_FromDate.Value
        Dim to_date As Date = dtp_ToDate.Value

        ' Validations for Add comboboxes
        If emp_id < 0 OrElse dept_id < 0 Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        Dim datesValid As Boolean = FuntionCommon.Validation.ValidateDate(from_date, to_date)

        If Not datesValid Then
            MessageBox.Show(Message.Message.errorInvalidDate, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        Update_EmpDept(emp_id, dept_id, from_date, to_date, DeptEmpId)
        EnableAdd()
        ClearForm()
    End Sub

    Private selectedEmpId As Integer

    Private Sub dgv_DeptEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DeptEmp.CellClick
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

            DeptEmpId = CInt(selectedrow.Cells("deptemp_id").Value)
            selectedEmpDept.deptemp_id = DeptEmpId

            dtp_FromDate.Value = Convert.ToDateTime(selectedrow.Cells("from_date").Value)
            selectedEmpDept.from_date = dtp_FromDate.Value
            dtp_ToDate.Value = Convert.ToDateTime(selectedrow.Cells("to_date").Value)
            selectedEmpDept.to_date = dtp_ToDate.Value

            btn_Add.Enabled = False
            btn_Delete.Enabled = True
            cb_EmpCreate.Enabled = False
            DisableAdd()
        End If
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
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
        End If
    End Sub
End Class