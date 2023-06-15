Imports System.Data.SqlClient

Public Class frm_Department
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

    Dim buttonOK As MessageBoxButtons = GlobalVariables.buttonOK
    Dim buttonYesNo As MessageBoxButtons = GlobalVariables.buttonYesNo
    Dim warmIcon As MessageBoxIcon = GlobalVariables.warmIcon
    Dim questionIcon As MessageBoxIcon = GlobalVariables.questionIcon
    Dim infoIcon As MessageBoxIcon = GlobalVariables.infoIcon
    Dim errorIcon As MessageBoxIcon = GlobalVariables.errorIcon

    Private currentPage As Integer = GlobalVariables.currentPage
    Private totalPages As Integer = GlobalVariables.totalPages
    Private pageSize As Integer = GlobalVariables.pageSize
    Private totalRows As Integer = GlobalVariables.totalRows

    Dim titleSucces As String = GlobalVariables.titleSucces
    Dim titleNotif As String = GlobalVariables.titleNotif
    Dim titleError As String = GlobalVariables.titleError
    Dim titleConfỉrm As String = GlobalVariables.titleConfirm
    Dim titleInfo As String = GlobalVariables.titleInfo

    Private Class Selected_Departments
        Public id As Integer = 0
        Public name As String = ""
        Public Sub New()
        End Sub
    End Class

    Private Sub frm_Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomElements.AddClearButtonInsideTextBox(txt_Search, "pbCloseSearch", Sub()
                                                                                    txt_Search.Text = ""
                                                                                    gbtn_Search.PerformClick()
                                                                                End Sub)

        gbtn_Update.Enabled = False
        gbtn_Delete.Enabled = False
        txt_DepartmentID.Enabled = False
        GlobalVariables.lblPage = lbl_Page
        dgrv_Department.Columns("No").SortMode = DataGridViewColumnSortMode.NotSortable
        EnableAdd()
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

        Using cmd As SqlCommand = New SqlCommand("GetCountEmpManagerAllDepartments", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim No As Integer = 1
            While reader.Read()
                ShowDepartment(No, reader)
                No += 1
            End While
            con.Close()
        End Using

        Pagination.PaginateDataGridView(dgrv_Department, currentPage)
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
        txt_Name.Text = String.Empty
        txt_DepartmentID.Text = String.Empty
        dgrv_Department.ClearSelection()
        ptb_Next.Enabled = True
        ptb_Previous.Enabled = False
        currentPage = 1
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
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
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
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
        Finally
            con.Close()
        End Try
        Return CheckDepartmentExitForUpdate
    End Function

    Public Sub Add_Department(ByVal name As String)
        Dim status As Integer = 1
        If CheckDepartmentExit(name) Then
            MessageBox.Show(Message.Message.departmentDuplicate, titleNotif, buttonOK, warmIcon)
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

                    MessageBox.Show(Message.Message.departmentAddSuccess, titleSucces, buttonOK, infoIcon)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Public Sub Update_Department(ByVal name As String, ByVal id As Integer)
        Dim status As Integer = 1

        If CheckDepartmentExitForUpdate(name, id) Then
            MessageBox.Show(Message.Message.departmentDuplicate, titleNotif, buttonOK, warmIcon)
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

                    MessageBox.Show(Message.Message.departmentUpdateSuccess, titleSucces, buttonOK, infoIcon)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
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
                    MessageBox.Show(Message.Message.errorInvalidSearch, titleNotif, buttonOK, warmIcon)
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
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub gbtn_Add_Click(sender As Object, e As EventArgs) Handles gbtn_Add.Click
        Dim name As String = txt_Name.Text

        If String.IsNullOrEmpty(name) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleNotif, buttonOK, warmIcon)
            Return
        End If
        Add_Department(name)
        ClearForm()
        LoadData()
    End Sub
    Private Sub gbtn_Update_Click(sender As Object, e As EventArgs) Handles gbtn_Update.Click
        Dim name As String = txt_Name.Text
        Dim id As Integer = CInt(txt_DepartmentID.Text)

        If String.IsNullOrEmpty(name) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleNotif, buttonOK, warmIcon)
            Return
        End If

        Update_Department(name, id)
        EnableAdd()
        ClearForm()
        LoadData()
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
    Private Sub gbtn_Delete_Click(sender As Object, e As EventArgs) Handles gbtn_Delete.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgrv_Department.SelectedRows

        If selectedRows.Count > 0 AndAlso MessageBox.Show("Are you sure you want to delete the selected department? Employee involved will also be deleted", titleConfỉrm, buttonYesNo, questionIcon) = DialogResult.Yes Then
            Dim departmentIdColumn As DataGridViewColumn = dgrv_Department.Columns("department_id") ' Replace "name" with the actual column name for department ID
            If departmentIdColumn IsNot Nothing Then
                MessageBox.Show(Message.Message.departmentDeleteSuccess, titleSucces, buttonOK, infoIcon)
                For i As Integer = 0 To selectedRows.Count - 1
                    Dim selectedRow As DataGridViewRow = selectedRows(i)
                    Dim id As Integer = CInt(selectedRow.Cells(departmentIdColumn.Index).Value)
                    Delete_Department(id)
                    ClearForm()
                Next

                LoadData()
                EnableAdd()
            Else
                MessageBox.Show("Unable to find the department ID column.", titleError, buttonOK, errorIcon)
            End If
        Else
            MessageBox.Show(Message.Message.cancelDelete, titleInfo, buttonOK, infoIcon)
        End If
    End Sub

    Private Sub gbtn_Reset_Click(sender As Object, e As EventArgs) Handles gbtn_Reset.Click
        txt_DepartmentID.Text = selectedDepartment.id
        txt_Name.Text = selectedDepartment.name
    End Sub
    Private Sub gbtn_Clear_Click(sender As Object, e As EventArgs) Handles gbtn_Clear.Click
        ClearForm()
        Pagination.PaginateDataGridView(dgrv_Department, currentPage)
        EnableAdd()
    End Sub

    Private Sub gbtn_Search_Click(sender As Object, e As EventArgs) Handles gbtn_Search.Click
        Dim keyword As String = txt_Search.Text.Trim
        If Not String.IsNullOrEmpty(keyword) Then
            SearchDepartmentsByKeyword(keyword)
        Else
            MessageBox.Show(Message.Message.emptyDataSearchMessage, titleNotif, buttonOK, warmIcon)
        End If
    End Sub

    Private Sub frm_Department_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgrv_Department.ClearSelection()
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

        If currentPage = Math.Ceiling(dgrv_Department.Rows.Count / pageSize) Then
            ptb_Next.Enabled = False
        Else
            ptb_Next.Enabled = True
        End If
    End Sub
    Private Sub ptb_Previous_Click(sender As Object, e As EventArgs) Handles ptb_Previous.Click
        If currentPage > 1 Then
            currentPage -= 1
            Pagination.PaginateDataGridView(dgrv_Department, currentPage)
        End If
        UpdatePaginationPicBox()
    End Sub

    Private Sub ptb_Next_Click(sender As Object, e As EventArgs) Handles ptb_Next.Click
        totalRows = dgrv_Department.Rows.Count
        totalPages = Math.Ceiling(totalRows / pageSize)

        If currentPage < totalPages Then
            currentPage += 1
            Pagination.PaginateDataGridView(dgrv_Department, currentPage)
        End If
        UpdatePaginationPicBox()
    End Sub

    Private Sub dgrv_Department_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgrv_Department.ColumnHeaderMouseClick
        FuntionCommon.SortationNO.SortAndPreventNoColumnSorting(dgrv_Department, e.ColumnIndex, "No")
        Pagination.PaginateDataGridView(dgrv_Department, currentPage)
    End Sub
End Class