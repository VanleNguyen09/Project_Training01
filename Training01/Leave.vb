Imports System.Data.SqlClient
Imports FuntionCommon

Public Class Leave
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Private DateTimeformat = DTFormat.Type.NormalDateAndHourMinusTime
    Private isClickedFindBtn = False
    Private RowsPerPage As Integer = 7
    Private CurrentPage As Integer = 1
    Private LeaveDatas As New DataTable

    Private Sub Leave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Settings for Combobox
        cbEmpAdd.DisplayMember = "Value"
        cbEmpAdd.ValueMember = "Key"
        cbEmpAdd.Items.Add(New DictionaryEntry(-1, "-SELECT-"))

        Load_cbEmpAdd()
        LoadLeaveDatas()

        'Add Delete Buttons
        Dim btn As New DataGridViewButtonColumn
        btn.HeaderText = ""
        btn.Text = "DELETE"
        btn.Name = "btnDelete"
        btn.FlatStyle = FlatStyle.Flat
        btn.CellTemplate.Style.ForeColor = Color.White
        btn.CellTemplate.Style.BackColor = Color.Red
        btn.CellTemplate.Style.SelectionForeColor = Color.White
        btn.CellTemplate.Style.SelectionBackColor = Color.Red

        btn.UseColumnTextForButtonValue = True
        dgvLeave.Columns.Insert(dgvLeave.Columns.Count, btn)

        'Set default
        cbEmpAdd.SelectedIndex = 0
        dtpStartDate.Format = DateTimePickerFormat.Custom
        dtpStartDate.CustomFormat = DateTimeformat

        dtpEndDate.Format = DateTimePickerFormat.Custom
        dtpEndDate.CustomFormat = DateTimeformat

        dtpFromDate.Format = DateTimePickerFormat.Custom
        dtpFromDate.CustomFormat = DateTimeformat
        CustomElements.AddClearButtonInsideTextBox(txtSearch, "btnClearSearch", Sub()
                                                                                    txtSearch.Text = ""
                                                                                End Sub)
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Environment.Exit(0)
    End Sub

    Private Sub Load_cbEmpAdd()
        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            'Load Employees Data To Combobox
            Dim Sql = "Select * from Employees"
            Using cmd As SqlCommand = New SqlCommand(Sql, con)
                cmd.CommandType = CommandType.Text
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read
                    cbEmpAdd.Items.Add(New DictionaryEntry(CInt(reader("id")), reader("id") & " - " & reader("name").ToString()))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, Message.Title.error, MessageBoxButtons.OK)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim empId As Integer = cbEmpAdd.SelectedItem.Key
        Dim fromDate As Date = dtpFromDate.Value
        Dim reason As String = rtxtReason.Text.Trim()

        'Validations for Add comboboxes
        If empId < 0 OrElse reason = String.Empty OrElse fromDate = Nothing Then
            MessageBox.Show(Message.Message.emptyErrorMessage, Message.Title.error, MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim separators() As Char = {"-"c}
        Dim empName As String = cbEmpAdd.SelectedItem.Value.ToString().Split(separators, 2, StringSplitOptions.RemoveEmptyEntries)(1).Trim()

        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            Dim sql = "InsertLeave"
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", empId)
                cmd.Parameters.AddWithValue("@emp_name", empName)
                cmd.Parameters.AddWithValue("@from_date", fromDate.AddSeconds(-fromDate.Second))
                cmd.Parameters.AddWithValue("@reason", reason)

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(Message.Message.successfully, Message.Title.success, MessageBoxButtons.OK)
                    'Reload Data
                    LoadLeaveDatas()

                    'Reset
                    cbEmpAdd.SelectedIndex = 0
                    rtxtReason.Text = ""
                    dtpFromDate.ResetText()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, Message.Title.error, MessageBoxButtons.OK)
                End Try
            End Using
        Catch ex As Exception
            MsgBox($"ERROR btnAdd_Click: {ex.Message}")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        txtSearch.Text = ""
        cbEmpAdd.SelectedIndex = 0
        rtxtReason.Text = ""
        dtpFromDate.ResetText()
        dtpStartDate.ResetText()
        dtpEndDate.ResetText()
        isClickedFindBtn = False
        LoadLeaveDatas()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        txtSearch.Controls("btnClearSearch").Visible = (txtSearch.Text.Length > 0)
        CurrentPage = 1
        If isClickedFindBtn Then
            btnFindFromDate.PerformClick()
        Else
            LoadLeaveDatas()
        End If
        txtSearch.Select()
    End Sub

    Private Sub dgvLeave_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeave.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Select Case senderGrid.Columns(e.ColumnIndex).Name
                Case "btnDelete"
                    'Confirm Delete
                    Dim result As DialogResult = MessageBox.Show(Message.Message.confirmedDelete, Message.Title.notif, MessageBoxButtons.YesNo)

                    Select Case result
                        Case DialogResult.No
                            Exit Sub
                        Case DialogResult.Yes
                            Dim leaveId = CInt(dgvLeave.Rows(e.RowIndex).Cells("id").Value)

                            'Delete Leave By Id
                            Try
                                If con.State() <> 1 Then
                                    con.Open()
                                End If

                                Dim sql = "DeleteLeaveById"
                                Using cmd As SqlCommand = New SqlCommand(sql, con)
                                    cmd.CommandType = CommandType.StoredProcedure
                                    cmd.Parameters.AddWithValue("leave_id", leaveId)
                                    cmd.ExecuteNonQuery()

                                    MessageBox.Show(Message.Message.successfully, Message.Title.notif, MessageBoxButtons.OK)

                                    If isClickedFindBtn Then
                                        btnFindFromDate.PerformClick()
                                    Else
                                        LoadLeaveDatas()
                                    End If
                                End Using
                            Catch ex As Exception
                                MsgBox($"{ex.Message}")
                            Finally
                                con.Close()
                            End Try
                    End Select

                Case "is_confirmed"
                    If dgvLeave.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "1" Then
                        Exit Sub
                    End If

                    'Confirm Leave
                    Dim result As DialogResult = MessageBox.Show(Message.Message.confirmedUpdate, Message.Title.notif, MessageBoxButtons.YesNo)

                    Select Case result
                        Case DialogResult.No
                            Exit Sub
                        Case DialogResult.Yes
                            Dim leaveId = CInt(dgvLeave.Rows(e.RowIndex).Cells("id").Value)

                            'Confirm Leave By Id
                            Try
                                If con.State() <> 1 Then
                                    con.Open()
                                End If

                                Dim sql = "UPDATE leave SET is_confirmed = 1 WHERE id = @id"
                                Using cmd As SqlCommand = New SqlCommand(sql, con)
                                    cmd.CommandType = CommandType.Text
                                    cmd.Parameters.AddWithValue("@id", leaveId)
                                    cmd.ExecuteNonQuery()

                                    MessageBox.Show(Message.Message.successfully, Message.Title.notif, MessageBoxButtons.OK)

                                    If isClickedFindBtn Then
                                        btnFindFromDate.PerformClick()
                                    Else
                                        LoadLeaveDatas()
                                    End If
                                End Using
                            Catch ex As Exception
                                MsgBox($"{ex.Message}")
                            Finally
                                con.Close()
                            End Try
                    End Select
            End Select

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Dim dboard As New Dashboard
        Me.Hide()
        dboard.Show()
    End Sub

    Private Sub btnFindFromDate_Click(sender As Object, e As EventArgs) Handles btnFindFromDate.Click
        'Start DateTime and End DateTime Validations
        If dtpStartDate.Value.Date > dtpEndDate.Value.Date Then
            MessageBox.Show(Message.Message.errorInvalidDate, Message.Title.error, MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim searchWord = txtSearch.Text
        Dim sDate = dtpStartDate.Value
        Dim eDate = dtpEndDate.Value

        Try
            If con.State() <> 1 Then
                con.Open()
            End If
            Dim Sql = "GetAllLeavesByWordAndDateTime"
            Using cmd As SqlCommand = New SqlCommand(Sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@word", searchWord)
                cmd.Parameters.AddWithValue("@s_datetime", sDate)
                cmd.Parameters.AddWithValue("@e_datetime", eDate)

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                LeaveDatas.Rows.Clear()
                LeaveDatas.Load(reader)
                CurrentPage = 1

                LoadDGV()
                isClickedFindBtn = True
            End Using
        Catch ex As Exception
            MessageBox.Show(Message.Message.errorSQLQuery & $": {ex.Message}", Message.Title.error, MessageBoxButtons.OK)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dgvLeave_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeave.CellDoubleClick
        If (e.RowIndex > -1) Then
            Dim row As DataGridViewRow = dgvLeave.Rows(e.RowIndex)
            Dim editLeaveForm As New EditLeaveForm

            Dim id As Integer = Convert.ToInt32(row.Cells("id").Value)
            Dim empId As Integer = Convert.ToInt32(row.Cells("emp_id").Value)
            Dim name As String = row.Cells("emp_name").Value.ToString()
            Dim fromDate As Date = row.Cells("from_date").Value
            Dim reason As String = row.Cells("reason").Value.ToString()
            Dim isConfirmed As Integer = row.Cells("is_confirmed").Value

            editLeaveForm.TempData = ValueTuple.Create(id, empId, name, fromDate, reason, isConfirmed)
            editLeaveForm.SetCallback(Sub()
                                          MessageBox.Show(Message.Message.successfully, Message.Title.success, MessageBoxButtons.OK)
                                          LoadLeaveDatas()
                                      End Sub)
            editLeaveForm.Show()
        End If
    End Sub

    Private Sub dgvLeave_Sorted(sender As Object, e As EventArgs) Handles dgvLeave.Sorted
        'If it is stt column, sorted normal 
        If dgvLeave.SortedColumn.Name <> "stt" Then
            For i As Integer = 0 To dgvLeave.Rows.Count - 1
                dgvLeave.Rows(i).Cells("stt").Value = (i + 1).ToString()
            Next
        End If
    End Sub

    Private Sub dgvLeave_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvLeave.CellFormatting
        If e.ColumnIndex = 6 AndAlso e.Value IsNot Nothing Then
            If e.Value.ToString() = "0" Then
                e.CellStyle.BackColor = Color.DarkOrange
                e.CellStyle.ForeColor = Color.White

                e.CellStyle.SelectionBackColor = Color.DarkOrange
                e.CellStyle.SelectionForeColor = Color.White

                e.Value = "Confirm"
                e.FormattingApplied = True
            ElseIf e.Value.ToString() = "1" Then
                e.CellStyle.BackColor = Color.Green
                e.CellStyle.ForeColor = Color.White

                e.CellStyle.SelectionBackColor = Color.Green
                e.CellStyle.SelectionForeColor = Color.White

                e.Value = "Confirmed"
                e.FormattingApplied = True
            End If
        End If
    End Sub

    Private Sub dgvLeave_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeave.CellMouseEnter
        If (e.ColumnIndex = 6 OrElse e.ColumnIndex = 7) AndAlso e.RowIndex >= 0 Then
            ' Thiết lập kiểu con trỏ thành tay trỏ (hand) khi di chuột vào ô
            If dgvLeave.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> "1" Then
                dgvLeave.Cursor = Cursors.Hand
            Else
                dgvLeave.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub dgvLeave_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeave.CellMouseLeave
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            dgvLeave.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub LoadLeaveDatas()
        Dim sql = "GetAllLeavesByWord"
        Dim searchWord = txtSearch.Text.Trim()

        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            'load datagridview by posId
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@word", searchWord)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                LeaveDatas.Rows.Clear()
                LeaveDatas.Load(reader)

                LoadDGV()
            End Using
        Catch ex As Exception
            MessageBox.Show(Message.Message.errorSQLQuery & $": {ex.Message}", Message.Title.error, MessageBoxButtons.OK)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadDGV()
        Dim totalPages = Math.Ceiling(LeaveDatas.Rows.Count / RowsPerPage)
        If totalPages = 0 Then
            CurrentPage = 1
            totalPages = 1
        End If
        txtCurrentPage.Text = CurrentPage
        txtTotalPage.Text = totalPages

        Dim pagingDatas = FuntionCommon.Pagination.PaginateDataTable(CurrentPage, RowsPerPage, totalPages, LeaveDatas)
        dgvLeave.Rows.Clear()

        For i As Integer = 0 To pagingDatas.Rows.Count - 1
            Dim stt = pagingDatas.Rows(i)("stt").ToString()
            Dim id = pagingDatas.Rows(i)("id").ToString()
            Dim empId = pagingDatas.Rows(i)("emp_id").ToString()
            Dim empName = pagingDatas.Rows(i)("emp_name").ToString()
            Dim fromDate = pagingDatas.Rows(i)("from_date").ToString().Split(" ")(0) 'Only get date
            Dim reason = pagingDatas.Rows(i)("reason").ToString()
            Dim isConfirmed = pagingDatas.Rows(i)("is_confirmed").ToString()
            dgvLeave.Rows.Add(New String() {stt, id, empId, empName, fromDate, reason, isConfirmed})
        Next

        UpdatePaginationButtons()
        dgvLeave.Select()
        dgvLeave.CurrentCell = Nothing
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ' Move previous page
        CurrentPage -= 1
        LoadDGV()
        UpdatePaginationButtons()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Move next page
        CurrentPage += 1
        LoadDGV()
        UpdatePaginationButtons()
    End Sub

    Private Sub UpdatePaginationButtons()
        If CurrentPage = 1 Then
            btnPrevious.Enabled = False
        Else
            btnPrevious.Enabled = True
        End If

        If CurrentPage = CInt(txtTotalPage.Text) Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If
    End Sub

    Private Sub dgvLeave_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLeave.ColumnHeaderMouseClick
        FuntionCommon.Sortation.SortDataTableAndPreventSttColumn(dgvLeave, LeaveDatas,
                                                                 e.ColumnIndex, "stt")
        LoadDGV()
    End Sub

    Private Sub txtCurrentPage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCurrentPage.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If Not FuntionCommon.Validation.IsIntegerNumber(txtCurrentPage.Text) Then
                MessageBox.Show(Message.Message.errorNumberType, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCurrentPage.Text = CurrentPage
                Exit Sub
            End If

            Dim CurrPage = CInt(txtCurrentPage.Text)
            Dim totalPages = Math.Ceiling(dgvLeave.Rows.Count / RowsPerPage) + 1
            If CurrPage < 1 OrElse CurrPage > totalPages Then
                MessageBox.Show(Message.Message.errorPageNumber, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCurrentPage.Text = CurrentPage
                Exit Sub
            End If

            CurrentPage = CurrPage
            LoadDGV()
        End If
    End Sub
End Class