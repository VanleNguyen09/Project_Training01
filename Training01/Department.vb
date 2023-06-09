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

    Private currentPage As Integer = 0
    Private Const pageSize As Integer = 10
    Private totalRows As Integer = 0
    Private initialData As List(Of Object()) = New List(Of Object()) ' Lưu giữ dữ liệu của trang đầu tiên


    Private Sub SetupDataGridView()
        ' Clear DataGridView and load initial data
        dgrv_Department.Rows.Clear()
        LoadData()
        DisplayPage(currentPage)
    End Sub

    Private Sub DisplayPage(pageIndex As Integer)
        ' Clear the existing rows in the DataGridView
        dgrv_Department.Rows.Clear()

        ' Calculate the total number of rows
        totalRows = GetTotalRows()

        ' Calculate the number of pages and the page size
        Dim totalPages As Integer = Math.Ceiling(totalRows / pageSize) ' Số lượng trang, mỗi trang có 10 dòng

        ' Calculate the starting and ending index of rows for the current page
        Dim startIndex As Integer = pageIndex * pageSize
        Dim endIndex As Integer = Math.Min(startIndex + pageSize - 1, totalRows - 1)

        ' Add the rows for the current page to the DataGridView
        For i As Integer = startIndex To endIndex
            Dim rowValues As Object() = GetRowValues(i)
            dgrv_Department.Rows.Add(rowValues)
        Next

        ' Update the current page label
        lbl_CurrentPage.Text = (pageIndex + 1).ToString()
        ' Update the total pages label
        lbl_TotalPage.Text = totalPages.ToString()
    End Sub

    Private Function GetRowValues(rowIndex As Integer) As Object()
        Dim rowValues As New List(Of Object)

        If rowIndex >= 0 AndAlso rowIndex < dgrv_Department.Rows.Count Then
            Dim row As DataGridViewRow = dgrv_Department.Rows(rowIndex)

            For Each cell As DataGridViewCell In row.Cells
                rowValues.Add(cell.Value)
            Next
        End If

        Return rowValues.ToArray()
    End Function

    Private Sub frm_Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomElements.AddClearButtonInsideTextBox(txt_Search, "pbCloseSearch", Sub()
                                                                                    txt_Search.Text = ""
                                                                                    btn_Search.PerformClick()
                                                                                End Sub)

        btn_Update.Enabled = False
        btn_Previous.Enabled = False
        btn_Next.Enabled = False
        btn_Delete.Enabled = False
        txt_DepartmentID.Enabled = False
        EnableAdd()
        'SetupDataGridView()

        LoadData()
    End Sub

    Private selectedDepartment As Selected_Departments = New Selected_Departments()

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
        ' Clear the DataGridView
        dgrv_Department.Rows.Clear()

        ' Reset totalRows
        totalRows = 0

        Using cmd As SqlCommand = New SqlCommand("GetCountEmpManagerAllDepartments", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim No As Integer = 1
            While reader.Read()
                ShowDepartment(No, reader)
                No += 1
                totalRows += 1 ' Tăng giá trị totalRows sau mỗi hàng được thêm
            End While
            con.Close()

            ' Lưu giữ dữ liệu của trang đầu tiên
            If currentPage = 0 Then
                initialData.Clear()
                For Each row As DataGridViewRow In dgrv_Department.Rows
                    Dim rowValues As Object() = GetRowValues(row.Index)
                    initialData.Add(rowValues)
                Next
            End If
        End Using
    End Sub

    Private Function GetTotalRows() As Integer
        Dim totalRows As Integer = 0

        For Each row As DataGridViewRow In dgrv_Department.Rows
            If Not row.IsNewRow Then
                totalRows += 1
            End If
        Next

        Return totalRows
    End Function

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

    Private Function CheckDepartmentExitForUpdate(ByVal name As String, ByVal id As Integer) As Boolean
        CheckDepartmentExitForUpdate = False
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckDepartmentExitForUpdate", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@id", id)
                Dim reader = cmd.ExecuteReader
                If reader.Read() Then
                    If reader("ReturnValue") = 1 Then CheckDepartmentExitForUpdate = True
                End If
            End Using
        Catch ex As Exception
            CheckDepartmentExitForUpdate = False
            MessageBox.Show("error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Return CheckDepartmentExitForUpdate
    End Function

    Public Sub Add_Department(ByVal name As String)
        Dim status As Integer = 1
        If CheckDepartmentExit(name) Then
            MessageBox.Show(Message.Message.departmentDuplicate, titleMsgBox, buttons, icons)
            Exit Sub
        Else
            If con.State <> 1 Then
                con.Open()
            End If
            Try
                Using cmd As SqlCommand = New SqlCommand("InsertDepartments", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@status", status)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Department has been added successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                End Using
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Public Sub Update_Department(ByVal name As String, ByVal id As Integer)
        Dim status As Integer = 1

        If CheckDepartmentExitForUpdate(name, id) Then
            MessageBox.Show(Message.Message.departmentDuplicate, titleMsgBox, buttons, icons)
            Exit Sub
        Else
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

                    MessageBox.Show("Department has been updated successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                End Using
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SearchDepartmentsByKeyword(ByVal keyword As String)
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
            LoadData()
        End If
    End Sub

    Public Sub Delete_Department(ByVal id As Integer)
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
                LoadData()
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

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        txt_Search.Controls("pbCloseSearch").Visible = (txt_Search.Text.Length > 0)
    End Sub

    Private Sub btn_Previous_Click(sender As Object, e As EventArgs) Handles btn_Previous.Click
        ' Kiểm tra xem có trang trước đó không
        Console.WriteLine(currentPage)
        If currentPage > 0 Then
            ' Giảm giá trị của currentPage
            currentPage -= 1

            ' Hiển thị trang trước đó
            DisplayPage(currentPage)
        Else
            ' Hiển thị lại dữ liệu của trang đầu tiên

            currentPage = 0
            DisplayPage(0)
        End If
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        ' Kiểm tra xem có trang tiếp theo không
        Dim totalPages As Integer = Math.Ceiling(totalRows / pageSize)
        Console.WriteLine(currentPage)
        If currentPage < totalPages - 1 Then
            ' Tăng giá trị của currentPage
            currentPage += 1
        ElseIf currentPage = totalPages - 1 Then
            ' Hiển thị lại dữ liệu của trang đầu tiên
            currentPage = 0
        End If
        DisplayPage(currentPage)
    End Sub
End Class