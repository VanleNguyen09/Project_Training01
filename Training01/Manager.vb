Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography

Public Class frm_Manager
    Private Sub ptb_Icon_Click(sender As Object, e As EventArgs) Handles ptb_Icon.Click
        Me.Hide()
        Dim dashboard As New Dashboard
        dashboard.Show()
    End Sub

    Private Sub frm_Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim initialDepartment As ComboBoxItem = New ComboBoxItem("Select Department", "-1")
        Dim initialEmployee As ComboBoxItem = New ComboBoxItem("Select Employee", "-1")
        cb_Department.Items.Add(initialDepartment)
        cb_DepCreate.Items.Add(initialDepartment)
        cb_EmpCreate.Items.Add(initialEmployee)
        cb_DeptRemove.Items.Add(initialDepartment)
        cb_Department.SelectedIndex = 0
        cb_DepCreate.SelectedIndex = 0
        cb_EmpCreate.SelectedIndex = 0
        cb_DeptRemove.SelectedIndex = 0
        cb_DeptRemove.Enabled = False

        Select_Departments()
        Select_Employees()
        LoadData()
    End Sub

    Private Sub ClearForm()
        cb_DepCreate.SelectedIndex = 0
        cb_EmpCreate.SelectedIndex = 0
        dtp_FromDate.Value = Date.Now()
        dtp_ToDate.Value = Date.Now()
        dgv_DeptManager.ClearSelection() 'Xóa bỏ việc chọn hàng trong DataGridView             
        grb_create.Enabled = True
        cb_DeptRemove.Enabled = False
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
                    cb_DeptRemove.Items.Add(currentItem)
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

    Public Sub ShowEmployeeManager(ByVal reader As SqlDataReader)
        Dim id As Integer = Convert.ToInt32(reader("id"))
        Dim name As String = reader("name").ToString()
        Dim phone As String = reader("phone").ToString()
        Dim address As String = reader("address").ToString()
        Dim birthday As String = reader("birthday").ToString()
        Dim email As String = reader("email").ToString()
        Dim department_name As String = If(reader.IsDBNull(reader.GetOrdinal("department_name")), String.Empty, reader("department_name").ToString())
        Dim from_date As String = reader("from_date").ToString()
        Dim to_date As String = reader("to_date").ToString()

        dgv_DeptManager.Rows.Add(id, name, phone, address, birthday, email, department_name, from_date, to_date)
    End Sub


    Private Sub LoadData()
        If con.State() <> 1 Then
            con.Open()
        End If
        dgv_DeptManager.Rows.Clear()
        Using cmd As SqlCommand = New SqlCommand("GetAllEmployeesManager", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ShowEmployeeManager(reader)
            End While
            con.Close()
        End Using

    End Sub

    Private Function check_exit(ByVal emp_id As Integer, ByVal dept_id As Integer) As Boolean
        check_exit = False
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckManagerExit", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                cmd.ExecuteNonQuery()
                Dim reader = cmd.ExecuteReader
                If reader.Read() Then
                    If reader("ReturnValue") = 1 Then check_exit = True
                End If
            End Using
        Catch ex As Exception
            check_exit = False
            MessageBox.Show("error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Return check_exit
    End Function

    Private Sub Add_Manager(emp_id As Integer, dept_id As Integer, from_date As Date, to_date As Date)
        If check_exit(emp_id, dept_id) = True Then
            MessageBox.Show(Message.Message.managerExitedForDepartment, titleMsgBox, buttons, icons)
            Exit Sub
        Else
        End If
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("InsertDeptManager", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                cmd.Parameters.AddWithValue("@from_date", from_date)
                cmd.Parameters.AddWithValue("@to_date", to_date)
                cmd.ExecuteNonQuery()
                LoadData()
            End Using
            MessageBox.Show("Manager has been added successfully!!!", "Success", buttons, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Delete_Manager(emp_id As Integer, dept_id As Integer)
        'Dim dept_id As Integer = CInt(cb_Department.SelectedItem.hiddenvalue)
        If cb_DeptRemove.SelectedItem.hiddenvalue = -1 Then
            MessageBox.Show("Please select a department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim checkExit As Boolean = check_exit(emp_id, dept_id)
        If Not checkExit Then
            MessageBox.Show("The manager is not in the selected department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If con.State <> ConnectionState.Open Then
            con.Open()
        End If

        Try
            Using cmd As SqlCommand = New SqlCommand("DeleteManagerInDepartment", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@dept_id", dept_id) ' Thêm tham số dept_id vào thủ tục xóa
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Manager has been deleted successfully!!!", "Success", buttons, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        LoadData()
    End Sub

    Private Sub SearchManagersByKeyword(keyword As String, department_id As Integer)
        Console.WriteLine(keyword)
        If con.State <> 1 Then
            con.Open()
        End If

        dgv_DeptManager.Rows.Clear()

        Using cmd As SqlCommand = New SqlCommand("GetManagersByKeyWord", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@keyword", keyword)
            cmd.Parameters.AddWithValue("@department_id", department_id)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ShowEmployeeManager(reader)
                    End While
                Else
                    MessageBox.Show(Message.Message.errorInvalidSearch, titleMsgBox, buttons, icons)
                End If
            End Using
        End Using
        con.Close()
    End Sub

    Private Sub cb_Department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Department.SelectedIndexChanged
        Dim dept_id = CInt(cb_Department.SelectedItem.hiddenvalue)
        dgv_DeptManager.RowCount = 0
        If con.State <> 1 Then
            con.Open()
        End If
        Dim reader As SqlDataReader
        If dept_id = -1 Then
            Using cmd As SqlCommand = New SqlCommand("GetAllEmployeesManager", con)
                cmd.CommandType = CommandType.StoredProcedure
                reader = cmd.ExecuteReader()
                While reader.Read()
                    ShowEmployeeManager(reader)
                End While
                con.Close()
            End Using
        Else
            Using cmd As SqlCommand = New SqlCommand("GetManagerByDeptId", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@dept_id", dept_id)
                reader = cmd.ExecuteReader()
                While reader.Read()
                    ShowEmployeeManager(reader)
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
        Add_Manager(emp_id, dept_id, from_date, to_date)
        ClearForm()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If dgv_DeptManager.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected manager(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                'Duyệt qua các hàng được chọn và thực hiện xóa
                For Each selectedRow As DataGridViewRow In dgv_DeptManager.SelectedRows
                    Dim emp_id As Integer = CInt(selectedRow.Cells("id").Value)
                    Dim dept_id As Integer = CInt(cb_DeptRemove.SelectedItem.hiddenvalue)
                    Delete_Manager(emp_id, dept_id)
                Next
                ClearForm()
            End If
        Else
            MessageBox.Show("Please select at least one manager to delete.", "Warning", buttons, icons)
        End If
    End Sub

    Private Sub btn_Manage_Click(sender As Object, e As EventArgs) Handles btn_Manage.Click
        Me.Hide()
        Dim department As New frm_Department
        department.Show()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Hide()
        Dim dashboard As New Dashboard
        dashboard.Show()
    End Sub

    Private Sub dgv_DeptManager_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DeptManager.CellClick
        If e.RowIndex >= 0 Then
            grb_create.Enabled = False
            cb_DeptRemove.Enabled = True
        End If
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        ClearForm()

    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim keyword As String = txt_Search.Text.Trim()
        Dim department_id As Integer = cb_Department.SelectedItem.hiddenvalue
        If Not String.IsNullOrEmpty(keyword) Then
            SearchManagersByKeyword(keyword, department_id)
        Else
            MessageBox.Show(Message.Message.emptyDataSearchMessage, titleMsgBox, buttons, icons)
        End If
    End Sub
End Class