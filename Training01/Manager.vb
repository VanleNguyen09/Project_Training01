Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Web.UI.WebControls
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frm_Manager
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Private Property DeptmangerId As Integer
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

    Private selectedEmpId As Integer

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
        CustomElements.AddClearButtonInsideTextBox(txt_Search, "pbCloseSearch", Sub()
                                                                                    txt_Search.Text = ""
                                                                                    gbtn_Search.PerformClick()
                                                                                End Sub)
        Dim initialDepartment As ComboBoxItem = New ComboBoxItem("Select Department", "-1")
        Dim initialEmployee As ComboBoxItem = New ComboBoxItem("Select Employee", "-1")
        GlobalVariables.lblPage = lbl_Page
        cb_Department.Items.Add(initialDepartment)
        cb_DepCreate.Items.Add(initialDepartment)
        cb_EmpCreate.Items.Add(initialEmployee)
        dtp_FromDate.Value = Date.Now()
        dtp_ToDate.Value = Date.Now()
        cb_Department.SelectedIndex = 0
        cb_DepCreate.SelectedIndex = 0
        cb_EmpCreate.SelectedIndex = 0
        dgv_DeptManager.Columns("No").SortMode = DataGridViewColumnSortMode.NotSortable
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
        dgv_DeptManager.ClearSelection()
        ptb_Next.Enabled = True
        ptb_Previous.Enabled = False
        grb_create.Enabled = True
        currentPage = 1
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
    Public Sub ShowEmployeeManager(ByVal No As Integer, ByVal reader As SqlDataReader)
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
        Dim deptmanager_id As Integer = Convert.ToInt32(reader("deptmanager_id").ToString())
        Dim status As Integer = Convert.ToInt32(reader("status").ToString())
        dgv_DeptManager.Rows.Add(No, id, name, phone, birthdayFormat, address, email, department_name, fromDateFormat, toDateFormat, dept_id, status, deptmanager_id)
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

        Pagination.PaginateDataGridView(dgv_DeptManager, currentPage)
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
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
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
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
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
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
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
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
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
            MessageBox.Show(Message.Message.employeeExitedForDepartment, titleNotif, buttonOK, warmIcon)
            Exit Sub
        ElseIf CheckManagerExit(empId, deptId) Then
            MessageBox.Show(Message.Message.managerDuplicate, titleNotif, buttonOK, warmIcon)
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
                    MessageBox.Show(Message.Message.managerAddSuccess, titleSucces, buttonOK, infoIcon)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
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
            MessageBox.Show(Message.Message.employeeExitedForDepartment, titleNotif, buttonOK, warmIcon)
            Exit Sub
        ElseIf CheckManagerExitForUpdate(empId, deptId, fromDate, toDate) Then
            MessageBox.Show(Message.Message.managerDuplicate, titleNotif, buttonOK, warmIcon)
            Exit Sub
        ElseIf CheckManagerDateBigger(empId, deptId, fromDate, toDate) Then
            MessageBox.Show("Date is smaller than date exist in system. Please try again!!!", titleNotif, buttonOK, warmIcon)
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
                    MessageBox.Show(Message.Message.managerUpdateSuccess, titleSucces, buttonOK, infoIcon)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
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
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
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
                    MessageBox.Show(Message.Message.errorInvalidSearch, titleNotif, buttonOK, warmIcon)
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
        Pagination.PaginateDataGridView(dgv_DeptManager, currentPage)
    End Sub

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
            gbtn_Add.Enabled = False
            gbtn_Delete.Enabled = True
            cb_EmpCreate.Enabled = False
            DisableAdd()
        End If
    End Sub
    Private Sub gbtn_Search_Click(sender As Object, e As EventArgs) Handles gbtn_Search.Click
        Dim keyword As String = txt_Search.Text.Trim()
        Dim department_id As Integer = cb_Department.SelectedItem.hiddenvalue
        If Not String.IsNullOrEmpty(keyword) Then
            SearchManagersByKeyword(keyword, department_id)
        Else
            MessageBox.Show(Message.Message.emptyDataSearchMessage, titleNotif, buttonOK, warmIcon)
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
            If gbtn_Add.Enabled = True Then
                gbtn_Add.Focus()
            Else
                gbtn_Update.Focus()
            End If
        End If
    End Sub
    Private Sub gbtn_Add_Click(sender As Object, e As EventArgs) Handles gbtn_Add.Click
        Dim emp_id As Integer = cb_EmpCreate.SelectedItem.hiddenvalue
        Dim dept_id As Integer = cb_DepCreate.SelectedItem.hiddenvalue
        Dim from_date As Date = dtp_FromDate.Value
        Dim to_date As Date = dtp_ToDate.Value

        If emp_id < 0 OrElse dept_id < 0 Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleError, buttonOK, errorIcon)
            Exit Sub
        End If

        Dim datesValid As Boolean = FuntionCommon.Validation.ValidateDate(from_date, to_date)

        If Not datesValid Then
            MessageBox.Show(Message.Message.errorInvalidDate, titleError, buttonOK, errorIcon)
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

        Dim values As New Dictionary(Of ManagerParameters, Object)
        values.Add(ManagerParameters.empId, emp_id)
        values.Add(ManagerParameters.deptId, dept_id)
        values.Add(ManagerParameters.fromDate, from_date)
        values.Add(ManagerParameters.toDate, to_date)

        Add_Manager(values)
        ClearForm()
        LoadData()
    End Sub

    Private Sub gbtn_Clear_Click(sender As Object, e As EventArgs) Handles gbtn_Clear.Click
        ClearForm()
        Pagination.PaginateDataGridView(dgv_DeptManager, currentPage)
        EnableAdd()
    End Sub
    Private Sub gbtn_Manage_Click(sender As Object, e As EventArgs) Handles gbtn_Manage.Click
        Me.Close()
        Dim department As New frm_Department
        department.Show()
    End Sub
    Private Sub gbtn_Delete_Click(sender As Object, e As EventArgs) Handles gbtn_Delete.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgv_DeptManager.SelectedRows

        If selectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected manager(s)?", titleConfỉrm, buttonYesNo, questionIcon)

            If result = DialogResult.Yes Then
                Dim empIdColumn As DataGridViewColumn = dgv_DeptManager.Columns("emp_id")
                Dim deptIdColumn As DataGridViewColumn = dgv_DeptManager.Columns("dept_id")

                If empIdColumn IsNot Nothing And deptIdColumn IsNot Nothing Then
                    MessageBox.Show(Message.Message.managerDeleteSuccess, titleSucces, buttonOK, infoIcon)
                    For i As Integer = 0 To selectedRows.Count - 1
                        Dim selectedRow As DataGridViewRow = selectedRows(i)
                        Dim emp_id As Integer = CInt(selectedRow.Cells(empIdColumn.Index).Value)
                        Dim dept_id As Integer = CInt(selectedRow.Cells(deptIdColumn.Index).Value)
                        Delete_Manager(emp_id, dept_id)
                        ClearForm()
                    Next
                    LoadData()
                    EnableAdd()
                End If
            Else
                MessageBox.Show(Message.Message.cancelDelete, titleInfo, buttonOK, infoIcon)
            End If
        End If
    End Sub
    Private Sub gbtn_Update_Click(sender As Object, e As EventArgs) Handles gbtn_Update.Click
        Dim dept_id As Integer = CInt(cb_DepCreate.SelectedItem.hiddenvalue)
        Dim emp_id As Integer = CInt(cb_EmpCreate.SelectedItem.hiddenvalue)
        Dim from_date As Date = dtp_FromDate.Value
        Dim to_date As Date = dtp_ToDate.Value

        If emp_id < 0 OrElse dept_id < 0 Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleError, buttonOK, errorIcon)
            Exit Sub
        End If

        Dim datesValid As Boolean = FuntionCommon.Validation.ValidateDate(from_date, to_date)

        If Not datesValid Then
            MessageBox.Show(Message.Message.errorInvalidDate, titleError, buttonOK, errorIcon)
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

        Dim values As New Dictionary(Of ManagerParameters, Object)
        values.Add(ManagerParameters.empId, emp_id)
        values.Add(ManagerParameters.deptId, dept_id)
        values.Add(ManagerParameters.fromDate, from_date)
        values.Add(ManagerParameters.toDate, to_date)
        values.Add(ManagerParameters.deptManagerId, DeptmangerId)

        Update_Manager(values)
        ClearForm()
        LoadData()
        EnableAdd()
    End Sub

    Private Sub gbtn_Reset_Click(sender As Object, e As EventArgs) Handles gbtn_Reset.Click
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

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        txt_Search.Controls("pbCloseSearch").Visible = (txt_Search.Text.Length > 0)
    End Sub

    Private Function UTF8Encode(ByVal str As String) As String
        Dim utf8Bytes As Byte() = Encoding.UTF8.GetBytes(str)
        Dim encodeString As String = Encoding.UTF8.GetString(utf8Bytes)

        Return encodeString
    End Function

    Private Sub ExportSalarySlipToPDF()
        If con.State <> 1 Then
            con.Open()
        End If

        Try
            Using cmd As SqlCommand = New SqlCommand("GetSalarySlipData", con)
                cmd.CommandType = CommandType.StoredProcedure

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    Dim folderPath As String = ""
                    Using dialog As New FolderBrowserDialog()
                        If dialog.ShowDialog() = DialogResult.OK Then
                            ' Lấy đường dẫn tới thư mục đã chọn.
                            folderPath = dialog.SelectedPath

                            Using saveDialog As New SaveFileDialog()
                                saveDialog.InitialDirectory = folderPath
                                saveDialog.Filter = "PDF files (*.pdf)|*.pdf"
                                If saveDialog.ShowDialog() = DialogResult.OK Then
                                    ' Get the path to the created file.
                                    Dim filePath As String = saveDialog.FileName
                                    Dim tempPath As String = Path.GetTempFileName() + ".pdf"

                                    Dim document As New Document

                                    document.SetMargins(10, 10, 10, 10)
                                    Dim outputStream As New FileStream(tempPath, FileMode.Create)

                                    Dim writer As PdfWriter = PdfWriter.GetInstance(document, outputStream)

                                    document.Open()

                                    Dim fontTitle As Font = FontFactory.GetFont("Arial", 18, FontStyle.Bold, BaseColor.RED)
                                    Dim titleText As String = "Employee Salary Slip"
                                    Dim cellPaddingTop As Single = 5

                                    Dim titleUpper As String = titleText.ToUpper()

                                    Dim title As New Paragraph(titleUpper, fontTitle)
                                    title.Alignment = Element.ALIGN_CENTER

                                    document.Add(title)
                                    document.Add(Chunk.NEWLINE)

                                    Dim fontPath As String = "C:\Windows\Fonts\Arial.ttf"
                                    Dim baseFont As BaseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)

                                    Dim fontHeader As New Font(baseFont, 9, Font.Bold)
                                    Dim fontContent As New Font(baseFont, 8)

                                    ' Generate a list of column widths based on desired number of columns and width percentage
                                    Dim columnWidths() As Single = {20, 45, 45, 45, 45, 45, 45, 45, 45, 45}

                                    Dim columnHeaders() As String = {"ID", "Name", "Phone", "Address", "Salary Name",
                                    "Salary", "Department", "From Date", "Position", "From Date"}
                                    Dim table As New PdfPTable(columnWidths.Length)

                                    table.WidthPercentage = 100
                                    table.SetWidths(columnWidths)

                                    Dim isFirstRow As Boolean = True

                                    ' Set fixed height for table cells
                                    table.DefaultCell.FixedHeight = 30

                                    ' Read data from SqlDataReader and add content to table
                                    While reader.Read()
                                        Dim employeeID As Integer? = If(Not reader.IsDBNull(0), reader.GetInt32(0), Nothing)
                                        Dim employeeName As String = reader.GetString(1)
                                        Dim phone As String = reader.GetString(2)
                                        Dim address As String = reader.GetString(3)
                                        Dim salaryName As String = reader.GetString(4)
                                        Dim salary As Decimal = reader.GetDecimal(5)
                                        Dim department As String = reader.GetString(6)
                                        Dim fromDateDept As DateTime = reader.GetDateTime(7)
                                        Dim fromDateDeptFormat As String = FuntionCommon.FormatDateTime.FormatDateTime(fromDateDept)

                                        Dim postion As String = reader.GetString(8)
                                        Dim fromDatePos As DateTime = reader.GetDateTime(9)
                                        Dim fromDatePosFormat As String = FuntionCommon.FormatDateTime.FormatDateTime(fromDatePos)

                                        If isFirstRow Then
                                            ' Add column headers in the first row
                                            For Each columnHeader As String In columnHeaders
                                                Dim cell As New PdfPCell(New Phrase(columnHeader, fontHeader))
                                                cell.BackgroundColor = BaseColor.LIGHT_GRAY
                                                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                                                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE
                                                cell.FixedHeight = 30

                                                table.AddCell(cell)
                                            Next

                                            isFirstRow = False
                                        End If

                                        Dim employeeIDCell As New PdfPCell(New Phrase(employeeID.ToString(), fontContent))
                                        employeeIDCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                                        employeeIDCell.VerticalAlignment = PdfPCell.ALIGN_CENTER
                                        employeeIDCell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE
                                        table.AddCell(employeeIDCell)
                                        Dim employeeNameCell As New PdfPCell(New PdfPCell(New Phrase(employeeName, fontContent)))
                                        employeeNameCell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE
                                        table.AddCell(employeeNameCell)
                                        Dim phoneCell As New PdfPCell(New PdfPCell(New Phrase(phone, fontContent)))
                                        phoneCell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE
                                        table.AddCell(phoneCell)
                                        Dim addressCell As New PdfPCell(New PdfPCell(New Phrase(address, fontContent)))
                                        addressCell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE
                                        table.AddCell(addressCell)
                                        Dim salaryNameCell As New PdfPCell(New Phrase(salaryName, fontContent))
                                        salaryNameCell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE
                                        table.AddCell(salaryNameCell)
                                        Dim salaryCell As New PdfPCell(New Phrase(salary, fontContent))
                                        salaryCell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE
                                        table.AddCell(salaryCell)
                                        Dim departmentCell As New PdfPCell(New Phrase(department, fontContent))
                                        departmentCell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE
                                        table.AddCell(departmentCell)
                                        Dim fromDateDeptFormatCell As New PdfPCell(New Phrase(fromDateDeptFormat.ToString(), fontContent))
                                        fromDateDeptFormatCell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE
                                        table.AddCell(fromDateDeptFormatCell)
                                        Dim positionCell As New PdfPCell(New Phrase(postion, fontContent))
                                        positionCell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE
                                        table.AddCell(positionCell)
                                        Dim fromDatePosFormatCell As New PdfPCell(New Phrase(fromDatePosFormat.ToString(), fontContent))
                                        fromDatePosFormatCell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE
                                        table.AddCell(fromDatePosFormatCell)
                                    End While
                                    document.Add(table)
                                    document.Close()

                                    PDFViewer.SetData(tempPath, filePath)
                                    PDFViewer.Show()
                                End If
                            End Using
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub gbtn_ExportPDF_Click(sender As Object, e As EventArgs) Handles gbtn_ExportPDF.Click
        ExportSalarySlipToPDF()
    End Sub

    Private Sub UpdatePaginationPicBox()
        If currentPage = 1 Then
            ptb_Previous.Enabled = False
        Else
            ptb_Previous.Enabled = True
        End If

        If currentPage = Math.Ceiling(dgv_DeptManager.Rows.Count / pageSize) Then
            ptb_Next.Enabled = False
        Else
            ptb_Next.Enabled = True
        End If
    End Sub
    Private Sub ptb_Previous_Click(sender As Object, e As EventArgs) Handles ptb_Previous.Click
        If currentPage > 1 Then
            currentPage -= 1
            Pagination.PaginateDataGridView(dgv_DeptManager, currentPage)
        End If
        UpdatePaginationPicBox()
    End Sub

    Private Sub ptb_Next_Click(sender As Object, e As EventArgs) Handles ptb_Next.Click
        totalRows = dgv_DeptManager.Rows.Count
        totalPages = Math.Ceiling(totalRows / pageSize)

        If currentPage < totalPages Then
            currentPage += 1
            Pagination.PaginateDataGridView(dgv_DeptManager, currentPage)
        End If
        UpdatePaginationPicBox()
    End Sub


    Private Sub dgv_DeptManager_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_DeptManager.ColumnHeaderMouseClick
        FuntionCommon.SortationNO.SortAndPreventNoColumnSorting(dgv_DeptManager, e.ColumnIndex, "No")
        Pagination.PaginateDataGridView(dgv_DeptManager, currentPage)
    End Sub
End Class