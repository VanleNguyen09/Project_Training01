Imports System.Data.SqlClient

Public Class frm_Manager
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Private Property DeptmangerId As Integer

    Private Class Selected_Managers
        Public department_name As String = ""
        Public from_date As Date = Date.Now()
        Public to_date As Date = Date.Now()
        Public deptmanager_id As Integer
        Public Sub New()
        End Sub
    End Class

    Private selectedManagers As Selected_Managers = New Selected_Managers()

    Private Sub frm_Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim initialDepartment As ComboBoxItem = New ComboBoxItem("Select Department", "-1")
        Dim initialEmployee As ComboBoxItem = New ComboBoxItem("Select Employee", "-1")
        cb_Department.Items.Add(initialDepartment)
        cb_DepCreate.Items.Add(initialDepartment)
        cb_EmpCreate.Items.Add(initialEmployee)
        cb_Department.SelectedIndex = 0
        cb_DepCreate.SelectedIndex = 0
        cb_EmpCreate.SelectedIndex = 0
        EnableAdd()

        Select_Departments()
        Select_Employees()
        LoadData()
    End Sub

    Public Enum ManagerParameters
        empId
        deptId
        fromDate
        toDate
        deptManagerId
    End Enum

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
        dgv_DeptManager.ClearSelection()
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

    Private Sub MakeButtonBackgroundBlurry(ByVal button As Button)
        Dim originalColor As Color = button.BackColor
        Dim blurredColor As Color = ControlPaint.Light(originalColor, 0.5)
        button.BackColor = blurredColor
    End Sub

    Public Sub ShowEmployeeManager(ByVal No As Integer, ByVal reader As SqlDataReader)
        Dim id As Integer = Convert.ToInt32(reader("id").ToString())
        Dim name As String = reader("name").ToString()
        Dim phone As String = reader("phone").ToString()
        Dim address As String = reader("address").ToString()
        Dim birthday As String = reader("birthday").ToString()
        Dim email As String = reader("email").ToString()
        Dim department_name As String = reader("department_name").ToString()
        Dim from_date As String = reader("from_date").ToString()
        Dim to_date As String = reader("to_date").ToString()
        Dim dept_id As Integer = Convert.ToInt32(reader("dept_id").ToString())
        Dim deptmanager_id As Integer = Convert.ToInt32(reader("deptmanager_id").ToString())
        Dim status As Integer = Convert.ToInt32(reader("status").ToString())
        dgv_DeptManager.Rows.Add(No, id, name, phone, birthday, address, email, department_name, from_date, to_date, dept_id, status, deptmanager_id)
    End Sub


    Private Sub LoadData()
        If con.State() <> 1 Then
            con.Open()
        End If
        dgv_DeptManager.Rows.Clear()
        Using cmd As SqlCommand = New SqlCommand("GetAllEmployeesManager", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim No As Integer = 1

            While reader.Read()
                ShowEmployeeManager(No, reader)
                No = No + 1
            End While
            con.Close()
        End Using
    End Sub

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
            MessageBox.Show("error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Return CheckEmpDeptExit
    End Function

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
            MessageBox.Show("error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Return CheckManagerExit
    End Function

    Private Function CheckManagerExitForUpdate(ByVal emp_id As Integer, ByVal dept_id As Integer, ByVal from_date As Date, ByVal to_date As Date) As Boolean
        CheckManagerExitForUpdate = False
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckManagerExitForUpdate", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                cmd.Parameters.AddWithValue("@from_date", from_date)
                cmd.Parameters.AddWithValue("@to_date", to_date)
                cmd.ExecuteNonQuery()

                Dim isExited As Integer = 0
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        isExited = CInt(reader("ReturnValue"))
                    End If
                End Using

                If isExited = 1 Then
                    CheckManagerExitForUpdate = True
                End If
            End Using
        Catch ex As Exception
            CheckManagerExitForUpdate = False
            MessageBox.Show("error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Return CheckManagerExitForUpdate
    End Function

    Private Function CheckManagerDateBigger(ByVal emp_id As Integer, ByVal dept_id As Integer, ByVal from_date As Date, ByVal to_date As Date) As Boolean
        CheckManagerDateBigger = False
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckManagerDateBigger", con)
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
                    CheckManagerDateBigger = True
                End If

            End Using
        Catch ex As Exception
            CheckManagerDateBigger = False
            MessageBox.Show("error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Return CheckManagerDateBigger
    End Function

    Private Sub Add_Manager(ByVal values As Dictionary(Of ManagerParameters, Object))
        Dim status As Integer = 1
        Dim empId As Integer = CInt(values(ManagerParameters.empId))
        Dim deptId As Integer = CInt(values(ManagerParameters.deptId))

        If CheckEmpDeptExit(empId, deptId) Then
            MessageBox.Show(Message.Message.employeeExitedForDepartment, titleMsgBox, buttons, icons)
            Exit Sub
        ElseIf CheckManagerExit(empId, deptId) Then
            MessageBox.Show(Message.Message.managerDuplicate, titleMsgBox, buttons, icons)
            Exit Sub
        Else
            If con.State <> 1 Then
                con.Open()
            End If
            Try
                Using cmd As SqlCommand = New SqlCommand("InsertDeptManager", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@emp_id", empId)
                    cmd.Parameters.AddWithValue("@dept_id", deptId)
                    cmd.Parameters.AddWithValue("@from_date", values(ManagerParameters.fromDate))
                    cmd.Parameters.AddWithValue("@to_date", values(ManagerParameters.toDate))
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Manager has been added successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                End Using
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Update_Manager(ByVal values As Dictionary(Of ManagerParameters, Object))
        Dim status As Integer = 1
        Dim empId As Integer = CInt(values(ManagerParameters.empId))
        Dim deptId As Integer = CInt(values(ManagerParameters.deptId))
        Dim fromDate As Date = Convert.ToDateTime(values(ManagerParameters.fromDate))
        Dim toDate As Date = Convert.ToDateTime(values(ManagerParameters.toDate))

        If CheckEmpDeptExit(empId, deptId) Then
            MessageBox.Show(Message.Message.employeeExitedForDepartment, titleMsgBox, buttons, icons)
            Exit Sub
        ElseIf CheckManagerExitForUpdate(empId, deptId, fromDate, toDate) Then
            MessageBox.Show(Message.Message.managerDuplicate, titleMsgBox, buttons, icons)
            Exit Sub
        ElseIf CheckManagerDateBigger(empId, deptId, fromDate, toDate) Then
            MessageBox.Show("Date is smaller than date exist in system. Please try again!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            If con.State <> 1 Then
                con.Open()
            End If

            Try
                Using cmd As SqlCommand = New SqlCommand("UpdateManager", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@emp_id", empId)
                    cmd.Parameters.AddWithValue("@dept_id", deptId)
                    cmd.Parameters.AddWithValue("@from_date", values(ManagerParameters.fromDate))
                    cmd.Parameters.AddWithValue("@to_date", values(ManagerParameters.toDate))
                    cmd.Parameters.AddWithValue("@deptmanager_id", values(ManagerParameters.deptManagerId))

                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Manager has been updated successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                End Using
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub Delete_Manager(ByVal emp_id As Integer, ByVal dept_id As Integer)
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("DeleteManagerInDepartment", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub SearchManagersByKeyword(ByVal keyword As String, ByVal department_id As Integer)
        Console.WriteLine(keyword)
        If con.State <> 1 Then
            con.Open()
        End If

        dgv_DeptManager.Rows.Clear()
        Dim reload = False
        Using cmd As SqlCommand = New SqlCommand("GetManagersByKeyWord", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@keyword", keyword)
            cmd.Parameters.AddWithValue("@department_id", department_id)
            Dim No As Integer = 1

            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ShowEmployeeManager(No, reader)
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
            cb_Department.SelectedIndex = 0
            LoadData()
        End If
    End Sub

    Private Sub cb_Department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Department.SelectedIndexChanged
        Dim dept_id As Integer = cb_Department.SelectedItem.hiddenvalue
        dgv_DeptManager.RowCount = 0
        If con.State <> 1 Then
            con.Open()
        End If
        Dim reader As SqlDataReader
        If dept_id = -1 Then
            Using cmd As SqlCommand = New SqlCommand("GetAllEmployeesManager", con)
                cmd.CommandType = CommandType.StoredProcedure
                reader = cmd.ExecuteReader()
                Dim No As Integer = 1
                While reader.Read()
                    ShowEmployeeManager(No, reader)
                    No = No + 1
                End While
                con.Close()
            End Using
        Else
            Using cmd As SqlCommand = New SqlCommand("GetManagerByDeptId", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                reader = cmd.ExecuteReader()
                Dim No As Integer = 1
                While reader.Read()
                    ShowEmployeeManager(No, reader)
                    No = No + 1
                End While
                con.Close()
            End Using
        End If
    End Sub

    Dim titleMsgBox As String = "Notification"
    Dim titleErrorBox As String = "Error"
    Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
    Dim icons As MessageBoxIcon = MessageBoxIcon.Warning
    Dim errorIcons As MessageBoxIcon = MessageBoxIcon.Error

    Private selectedEmpId As Integer

    Private Sub dgv_DeptManager_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DeptManager.CellClick

        If e.RowIndex >= 0 Then
            Dim selectedrow = dgv_DeptManager.Rows(e.RowIndex)
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

            selectedManagers.department_name = cb_DepCreate.SelectedItem.displayvalue

            dtp_FromDate.Value = Convert.ToDateTime(selectedrow.Cells("from_date").Value)
            selectedManagers.from_date = dtp_FromDate.Value
            dtp_ToDate.Value = Convert.ToDateTime(selectedrow.Cells("to_date").Value)
            selectedManagers.to_date = dtp_ToDate.Value
            DeptmangerId = CInt(selectedrow.Cells("deptmanager_id").Value)
            selectedManagers.deptmanager_id = DeptmangerId
            dgv_DeptManager.ReadOnly = True
            btn_Add.Enabled = False
            btn_Delete.Enabled = True
            cb_EmpCreate.Enabled = False
            DisableAdd()
        End If
    End Sub
    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim keyword As String = txt_Search.Text.Trim()
        Dim department_id As Integer = cb_Department.SelectedItem.hiddenvalue
        If Not String.IsNullOrEmpty(keyword) Then
            SearchManagersByKeyword(keyword, department_id)
        Else
            MessageBox.Show(Message.Message.emptyDataSearchMessage, titleMsgBox, buttons, icons)
            LoadData()
            cb_Department.SelectedIndex = 0
        End If
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
            If btn_Add.Enabled = True Then
                btn_Add.Focus()
            Else
                btn_Update.Focus()
            End If
        End If
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim emp_id As Integer = cb_EmpCreate.SelectedItem.hiddenvalue
        Dim dept_id As Integer = cb_DepCreate.SelectedItem.hiddenvalue
        Dim from_date As Date = dtp_FromDate.Value
        Dim to_date As Date = dtp_ToDate.Value

        If emp_id < 0 OrElse dept_id < 0 Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        Dim datesValid As Boolean = FuntionCommon.Validation.ValidateDate(from_date, to_date)

        If Not datesValid Then
            MessageBox.Show(Message.Message.errorInvalidDate, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        Dim fromInputYear As Integer = from_date.Year
        Dim toInputYear As Integer = to_date.Year
        Dim currentYear As Integer = DateTime.Now.Year

        Dim fromIsValid As Boolean = FuntionCommon.Validation.ValidateYear(fromInputYear, currentYear)
        Dim toIsValid As Boolean = FuntionCommon.Validation.ValidateYear(toInputYear, currentYear)

        If Not fromIsValid OrElse Not toIsValid Then
            MessageBox.Show(Message.Message.yearInvalidError, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        Dim values As New Dictionary(Of ManagerParameters, Object)
        values.Add(ManagerParameters.empId, emp_id)
        values.Add(ManagerParameters.deptId, dept_id)
        values.Add(ManagerParameters.fromDate, from_date)
        values.Add(ManagerParameters.toDate, to_date)

        Add_Manager(values)
        ClearForm()
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        ClearForm()
        EnableAdd()
    End Sub

    Private Sub btn_Manage_Click(sender As Object, e As EventArgs) Handles btn_Manage.Click
        Me.Close()
        Dim department As New frm_Department
        department.Show()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgv_DeptManager.SelectedRows

        If selectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected manager(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim empIdColumn As DataGridViewColumn = dgv_DeptManager.Columns("emp_id")
                Dim deptIdColumn As DataGridViewColumn = dgv_DeptManager.Columns("dept_id")

                If empIdColumn IsNot Nothing And deptIdColumn IsNot Nothing Then
                    MessageBox.Show("Manager has been deleted successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                    For i As Integer = 0 To selectedRows.Count - 1
                        Dim selectedRow As DataGridViewRow = selectedRows(i)
                        Dim emp_id As Integer = CInt(selectedRow.Cells(empIdColumn.Index).Value)
                        Dim dept_id As Integer = CInt(selectedRow.Cells(deptIdColumn.Index).Value)
                        Delete_Manager(emp_id, dept_id)
                    Next
                    LoadData()
                    ClearForm()
                    EnableAdd()
                End If
            Else
                MessageBox.Show("Delete canceled.", "Information", buttons, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Dim dept_id As Integer = CInt(cb_DepCreate.SelectedItem.hiddenvalue)
        Dim emp_id As Integer = CInt(cb_EmpCreate.SelectedItem.hiddenvalue)
        Dim from_date As Date = dtp_FromDate.Value
        Dim to_date As Date = dtp_ToDate.Value

        If emp_id < 0 OrElse dept_id < 0 Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        Dim datesValid As Boolean = FuntionCommon.Validation.ValidateDate(from_date, to_date)

        If Not datesValid Then
            MessageBox.Show(Message.Message.errorInvalidDate, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        Dim fromInputYear As Integer = from_date.Year
        Dim toInputYear As Integer = to_date.Year
        Dim currentYear As Integer = DateTime.Now.Year

        Dim fromIsValid As Boolean = FuntionCommon.Validation.ValidateYear(fromInputYear, currentYear)
        Dim toIsValid As Boolean = FuntionCommon.Validation.ValidateYear(toInputYear, currentYear)


        If Not fromIsValid OrElse Not toIsValid Then
            MessageBox.Show(Message.Message.yearInvalidError, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        Dim values As New Dictionary(Of ManagerParameters, Object)
        values.Add(ManagerParameters.empId, emp_id)
        values.Add(ManagerParameters.deptId, dept_id)
        values.Add(ManagerParameters.fromDate, from_date)
        values.Add(ManagerParameters.toDate, to_date)
        values.Add(ManagerParameters.deptManagerId, DeptmangerId)

        Update_Manager(values)
        ClearForm()
        EnableAdd()
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        For Each item As ComboBoxItem In cb_DepCreate.Items
            If item.displayvalue = selectedManagers.department_name Then
                cb_DepCreate.SelectedItem = item
                Exit For
            End If
        Next
        dtp_FromDate.Value = selectedManagers.from_date
        dtp_ToDate.Value = selectedManagers.to_date
        DeptmangerId = selectedManagers.deptmanager_id
    End Sub
    Private Sub frm_Manager_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgv_DeptManager.ClearSelection()
    End Sub
End Class