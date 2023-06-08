Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices

Public Class frm_Department
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

    Private Class Selected_Departments
        Public id As Integer = 0
        Public name As String = ""
        Public Sub New()
        End Sub
    End Class

    Private Sub frm_Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Update.Enabled = False
        btn_Delete.Enabled = False
        txt_DepartmentID.Enabled = False
        EnableAdd()
        LoadAndSortData()
    End Sub

    Private selectedDepartment As Selected_Departments = New Selected_Departments()

    Private Sub LoadAndSortData()
        LoadData()
        SortDataById()
    End Sub

    Public Sub SortDataById()
        dgrv_Department.Sort(dgrv_Department.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Public Sub ShowDepartment(ByVal No As Integer, ByVal reader As SqlDataReader)
        Dim id As Integer = Convert.ToInt32(reader("id").ToString())
        Dim name As String = reader("name").ToString()
        Dim status As Integer = Convert.ToInt32(reader("status").ToString())
        Dim number_emp As Integer = Convert.ToInt32(reader("Number_Emp").ToString())
        Dim number_manager As Integer = Convert.ToInt32(reader("Number_Manager").ToString())
        dgrv_Department.Rows.Add(No, id, name, status, number_emp, number_manager)
    End Sub

    Public Sub LoadData()
        If con.State <> 1 Then
            con.Open()
        End If
        dgrv_Department.Rows.Clear()
        Using cmd As SqlCommand = New SqlCommand("GetCountEmpManagerAllDepartments", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim No As Integer = 1
            While reader.Read()
                ShowDepartment(No, reader)
                No += 1
            End While
            con.Close()
        End Using
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
        txt_Name.Text = String.Empty
        txt_DepartmentID.Text = String.Empty
        dgrv_Department.ClearSelection()
    End Sub

    Dim titleMsgBox As String = "notification"
    Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
    Dim icons As MessageBoxIcon = MessageBoxIcon.Warning

    Public Sub Update_Department(name As String, id As Integer)
        Dim status As Integer = 1

        If con.State <> 1 Then
            con.Open()
        End If

        Try
            Using cmd As SqlCommand = New SqlCommand("UpdateDepartments", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.ExecuteNonQuery()

                Dim isDuplicate As Integer = 0

                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        isDuplicate = CInt(reader("IsDuplicate"))
                    End If
                End Using

                If isDuplicate = 1 Then
                    MessageBox.Show(Message.Message.departmentDuplicate, titleMsgBox, buttons, icons)
                Else
                    MessageBox.Show("Department has been updated successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                    LoadAndSortData()
                    Exit Sub
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MakeButtonBackgroundBlurry(button As Button)
        Dim originalColor As Color = button.BackColor
        Dim blurredColor As Color = ControlPaint.Light(originalColor, 0.5)
        button.BackColor = blurredColor
    End Sub

    Private Function CheckDepartmentExit(ByVal name As String) As Boolean
        CheckDepartmentExit = False
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckDepartmentExit", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", name)
                Dim reader = cmd.ExecuteReader
                If reader.Read() Then
                    If reader("ReturnValue") = 1 Then CheckDepartmentExit = True
                End If
            End Using
        Catch ex As Exception
            CheckDepartmentExit = False
            MessageBox.Show("error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Return CheckDepartmentExit
    End Function

    Public Sub Add_Department(name As String)
        Dim status As Integer = 1

        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("InsertDepartments", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@status", status)

                Dim isDuplicate As Integer = 0

                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        isDuplicate = CInt(reader("IsDuplicate"))
                    End If
                End Using
                cmd.ExecuteNonQuery()
                If isDuplicate = 1 Then
                    MessageBox.Show(Message.Message.departmentDuplicate, titleMsgBox, buttons, icons)
                    Exit Sub
                Else
                    MessageBox.Show("Department has been added successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                    LoadAndSortData()
                    Exit Sub
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchDepartmentsByKeyword(keyword As String)
        Console.WriteLine(keyword)
        If con.State <> 1 Then
            con.Open()
        End If

        dgrv_Department.Rows.Clear()
        Dim reload = False
        Using cmd As SqlCommand = New SqlCommand("GetDepartmentsByKeyWord", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@keyword", keyword)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    Dim No As Integer = 1
                    While reader.Read()
                        ShowDepartment(No, reader)
                        No += 1
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
        End If
    End Sub

    Public Sub Delete_Department(id As Integer)
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("DeleteDepartment", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)

                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim name As String = txt_Name.Text

        If String.IsNullOrEmpty(name) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleMsgBox, buttons, icons)
            Return
        End If

        Add_Department(name)
        ClearForm()
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Dim name As String = txt_Name.Text
        Dim id As Integer = CInt(txt_DepartmentID.Text)

        If String.IsNullOrEmpty(name) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleMsgBox, buttons, icons)
            Return
        End If

        Update_Department(name, id)
        EnableAdd()
        ClearForm()
    End Sub

    Private Sub dgrv_Department_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrv_Department.CellClick
        If e.RowIndex >= 0 Then
            DisableAdd()
            Dim selectedRow = dgrv_Department.Rows(e.RowIndex)
            txt_DepartmentID.Text = selectedRow.Cells("department_id").Value.ToString()
            selectedDepartment.id = txt_DepartmentID.Text
            txt_Name.Text = selectedRow.Cells("department_name").Value.ToString()
            selectedDepartment.name = txt_Name.Text
            dgrv_Department.ReadOnly = True
        End If
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgrv_Department.SelectedRows

        If selectedRows.Count > 0 AndAlso MessageBox.Show("Are you sure you want to delete the selected department? Employee involved will also be deleted", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim departmentIdColumn As DataGridViewColumn = dgrv_Department.Columns("department_id") ' Replace "name" with the actual column name for department ID
            If departmentIdColumn IsNot Nothing Then
                MessageBox.Show("Department has been deleted successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                For i As Integer = 0 To selectedRows.Count - 1
                    Dim selectedRow As DataGridViewRow = selectedRows(i)
                    Dim id As Integer = CInt(selectedRow.Cells(departmentIdColumn.Index).Value)
                    Delete_Department(id)
                Next
                LoadAndSortData()
                ClearForm()
                EnableAdd()
            Else
                MessageBox.Show("Unable to find the department ID column.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Deletion canceled.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        txt_DepartmentID.Text = selectedDepartment.id
        txt_Name.Text = selectedDepartment.name
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        ClearForm()
        EnableAdd()
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim keyword As String = txt_Search.Text.Trim
        If Not String.IsNullOrEmpty(keyword) Then
            SearchDepartmentsByKeyword(keyword)
        Else
            MessageBox.Show(Message.Message.emptyDataSearchMessage, titleMsgBox, buttons, icons)
        End If
    End Sub

    Private Sub frm_Department_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgrv_Department.ClearSelection()
    End Sub

End Class