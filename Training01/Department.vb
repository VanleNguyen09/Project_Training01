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
    Private Property Id As Integer

    Private Class Selected_Departments
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
        GlobalVariables.lblPage = lbl_Page
        totalRows = GetTotalRowsDepartments()
        dgrv_Department.Columns("No").SortMode = DataGridViewColumnSortMode.NotSortable
        EnableAdd()
        dgrv_Department.Rows.Clear()
        UpdatePaginationPicBox()
        LoadData()
    End Sub

    Private Function GetTotalRowsDepartments() As Integer
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CountTotalDepartments", con)
                cmd.CommandType = CommandType.StoredProcedure
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read Then
                        totalRows = reader("SL_DP").ToString()
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

    Private Sub frm_Department_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgrv_Department.ClearSelection()
    End Sub

    Private selectedDepartment As Selected_Departments = New Selected_Departments()

    Private Sub ShowDepartment(ByVal No As Integer, ByVal reader As SqlDataReader)
        Dim id As Integer = Convert.ToInt32(reader("id").ToString())
        Dim name As String = reader("name").ToString()
        Dim status As Integer = Convert.ToInt32(reader("status").ToString())
        Dim number_emp As Integer = Convert.ToInt32(reader("Number_Emp").ToString())
        Dim number_manager As Integer = Convert.ToInt32(reader("Number_Manager").ToString())
        dgrv_Department.Rows.Add(No, id, name, status, number_emp, number_manager)
    End Sub
    Private Sub LoadData()
        If con.State <> 1 Then
            con.Open()
        End If
        ' Clear the DataGridView
        dgrv_Department.Rows.Clear()

        Using cmd As SqlCommand = New SqlCommand("GetCountEmpManagerAllDepartments", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@currentPage", currentPage)
            cmd.Parameters.AddWithValue("@pageSize", pageSize)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim No As Integer = 1
            While reader.Read()
                ShowDepartment(No, reader)
                No += 1
            End While
            con.Close()
        End Using

        Pagination.Paginatedatagridview2(currentPage, totalRows)
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
        'txt_DepartmentID.Text = String.Empty

        dgrv_Department.ClearSelection()
        ptb_Next.Enabled = True
        ptb_Previous.Enabled = False
        ' Set Value of Checkbox to False
        For Each row As DataGridViewRow In dgrv_Department.Rows
            Dim checkboxCell As DataGridViewCheckBoxCell = DirectCast(row.Cells("ckb_Delete"), DataGridViewCheckBoxCell)
            checkboxCell.Value = False
        Next
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

    Private Sub Add_Department(ByVal name As String)
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
                ClearForm()
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Update_Department(ByVal name As String, ByVal id As Integer)
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
                ClearForm()
                LoadData()
                EnableAdd()
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
            cmd.Parameters.AddWithValue("@currentPage", currentPage)
            cmd.Parameters.AddWithValue("@pageSize", pageSize)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    Dim No As Integer = 1
                    While reader.Read()
                        ShowDepartment(No, reader)
                        No += 1
                    End While
                    totalRows = dgrv_Department.Rows.Count
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
            totalRows = GetTotalRowsDepartments()
            txt_Search.Text = Nothing
            LoadData()
            UpdatePaginationPicBox()
        End If
    End Sub

    Private Sub Delete_Department(ByVal id As Integer)
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
    End Sub
    Private Sub gbtn_Update_Click(sender As Object, e As EventArgs) Handles gbtn_Update.Click
        Dim name As String = txt_Name.Text

        If String.IsNullOrEmpty(name) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleNotif, buttonOK, warmIcon)
            Return
        End If

        Update_Department(name, Id)
    End Sub
    Private Sub dgrv_Department_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrv_Department.CellClick
        If e.ColumnIndex = dgrv_Department.Columns.Count - 1 Then
            dgrv_Department.SelectionMode = DataGridViewSelectionMode.CellSelect
            dgrv_Department.ReadOnly = False
            txt_Name.Text = Nothing
        Else
            If e.RowIndex >= 0 Then
                Dim selectedRow = dgrv_Department.Rows(e.RowIndex)
                Id = CInt(selectedRow.Cells("department_id").Value)
                txt_Name.Text = selectedRow.Cells("department_name").Value.ToString()
                selectedDepartment.name = txt_Name.Text
                dgrv_Department.ReadOnly = True
            End If
            DisableAdd()
        End If

    End Sub
    Private Sub gbtn_Delete_Click(sender As Object, e As EventArgs) Handles gbtn_Delete.Click
        Dim selectedRows As New List(Of DataGridViewRow)()

        For Each row As DataGridViewRow In dgrv_Department.Rows
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
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete the selected department? Employee involved will also be deleted", titleConfỉrm, buttonYesNo, questionIcon)
        Dim departmentIdColumn As DataGridViewColumn = dgrv_Department.Columns("department_id")

        ' Delete rows if user confirm
        If confirmResult = DialogResult.Yes Then
            For Each row As DataGridViewRow In selectedRows
                Dim id As Integer = CInt(row.Cells(departmentIdColumn.Index).Value)
                Delete_Department(id)
                ClearForm()
            Next
            LoadData()
            EnableAdd()
        End If
        'If selectedRows.Count > 0 AndAlso MessageBox.Show("Are you sure you want to delete the selected department? Employee involved will also be deleted", titleConfỉrm, buttonYesNo, questionIcon) = DialogResult.Yes Then
        '    Dim departmentIdColumn As DataGridViewColumn = dgrv_Department.Columns("department_id") ' Replace "name" with the actual column name for department ID
        '    If departmentIdColumn IsNot Nothing Then
        '        MessageBox.Show(Message.Message.departmentDeleteSuccess, titleSucces, buttonOK, infoIcon)
        '        For i As Integer = 0 To selectedRows.Count - 1
        '            Dim selectedRow As DataGridViewRow = selectedRows(i)
        '            Dim id As Integer = CInt(selectedRow.Cells(departmentIdColumn.Index).Value)
        '            Delete_Department(id)
        '            ClearForm()
        '        Next

        '        LoadData()
        '        EnableAdd()
        '    Else
        '        MessageBox.Show("Unable to find the department ID column.", titleError, buttonOK, warmIcon)
        '    End If
        'End If
    End Sub

    Private Sub gbtn_Reset_Click(sender As Object, e As EventArgs) Handles gbtn_Reset.Click
        txt_Name.Text = selectedDepartment.name
    End Sub
    Private Sub gbtn_Clear_Click(sender As Object, e As EventArgs) Handles gbtn_Clear.Click
        ClearForm()
        LoadData()
        EnableAdd()
    End Sub

    Private Sub gbtn_Search_Click(sender As Object, e As EventArgs) Handles gbtn_Search.Click
        Dim keyword As String = txt_Search.Text.Trim
        If Not String.IsNullOrEmpty(keyword) Then
            SearchDepartmentsByKeyword(keyword)
        Else
            dgrv_Department.Rows.Clear()
        End If
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
        'totalRows = dgrv_Department.Rows.Count
        totalPages = Math.Ceiling(totalRows / pageSize)

        If currentPage < totalPages Then
            currentPage += 1
            LoadData()
        End If
        UpdatePaginationPicBox()
    End Sub
    Private Sub dgrv_Department_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgrv_Department.ColumnHeaderMouseClick
        FuntionCommon.SortationNO.SortAndPreventNoColumnSorting(dgrv_Department, "No")
        Pagination.Paginatedatagridview2(currentPage, totalRows)
    End Sub
    Private Sub dgrv_Department_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgrv_Department.CellMouseEnter
        If (e.ColumnIndex = 6 OrElse e.ColumnIndex = 7) AndAlso e.RowIndex >= 0 Then
            ' Set the pointer type to hand when hovering the mouse over the cell
        Else
            dgrv_Department.Cursor = Cursors.Default
        End If
    End Sub
End Class