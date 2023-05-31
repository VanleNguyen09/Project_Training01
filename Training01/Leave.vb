Imports System.Data.SqlClient

Public Class Leave
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Private DateTimeformat = DTFormat.Type.NormalDatetime

    Private Sub Leave_Load(sender As Object, e As EventArgs)
        'Settings for Combobox
        cbEmpAdd.DisplayMember = "Value"
        cbEmpAdd.ValueMember = "Key"
        cbEmpAdd.Items.Add(New DictionaryEntry(-1, "-SELECT-"))

        Load_cbEmpAdd()
        Load_DGVLeave()

        'Add Delete Buttons
        Dim btn As New DataGridViewButtonColumn
        btn.HeaderText = ""
        btn.Text = "DELETE"
        btn.Name = "btnDelete"
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
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Environment.Exit(0)
    End Sub

    Private Sub Load_DGVLeave()
        Dim sql = "GetAllLeavesByWord"
        Dim searchWord = txtSearch.Text.Trim()

        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            'load datagridview by posId
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("word", searchWord)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                dgvLeave.Rows.Clear()
                While reader.Read
                    dgvLeave.Rows.Add(New String() {reader("id"), reader("emp_id"), reader("emp_name"), reader("from_date"), reader("reason")})
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(Message.Message.errorSQLQuery & $": {ex.Message}", Message.Title.error, MessageBoxButtons.OK)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Load_cbEmpAdd()
        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            'Load Employees Data To Combobox
            Dim Sql = "GetAllEmployees"
            Using cmd As SqlCommand = New SqlCommand(Sql, con)
                cmd.CommandType = CommandType.StoredProcedure
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

        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            Dim sql = "InsertLeave"
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("emp_id", empId)
                cmd.Parameters.AddWithValue("from_date", fromDate)
                cmd.Parameters.AddWithValue("reason", reason)

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(Message.Message.successfully, Message.Title.success, MessageBoxButtons.OK)

                    'Reload Data
                    Load_DGVLeave()

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
        Load_DGVLeave()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Load_DGVLeave()
    End Sub

    Private Sub dgvLeave_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeave.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            'Confirm Delete
            Dim result As DialogResult = MessageBox.Show(Message.Message.confirmedDelete, Message.Title.notif, MessageBoxButtons.YesNo)

            Select Case result
                Case DialogResult.No
                    Exit Sub
                Case DialogResult.Yes
                    Dim leaveId = CInt(dgvLeave.Rows(e.RowIndex).Cells(0).Value)

                    'Delete Position By Id
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
                            Load_DGVLeave()
                        End Using
                    Catch ex As Exception
                        MsgBox($"{ex.Message}")
                    Finally
                        con.Close()
                    End Try
            End Select
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
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
                cmd.Parameters.AddWithValue("word", searchWord)
                cmd.Parameters.AddWithValue("s_datetime", sDate)
                cmd.Parameters.AddWithValue("e_datetime", eDate)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                dgvLeave.Rows.Clear()
                While reader.Read
                    dgvLeave.Rows.Add(New String() {reader("id"), reader("emp_id"), reader("emp_name"), reader("from_date"), reader("reason")})
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(Message.Message.errorSQLQuery & $": {ex.Message}", Message.Title.error, MessageBoxButtons.OK)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dgvLeave_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeave.CellDoubleClick
        Dim row As DataGridViewRow = dgvLeave.Rows(e.RowIndex)
        Dim editLeaveForm As New EditLeaveForm

        Dim id As Integer = Convert.ToInt32(row.Cells("id").Value)
        Dim empId As Integer = Convert.ToInt32(row.Cells("emp_id").Value)
        Dim name As String = row.Cells("emp_name").Value.ToString()
        Dim fromDate As Date = row.Cells("from_date").Value
        Dim reason As String = row.Cells("reason").Value.ToString()
        editLeaveForm.TempData = ValueTuple.Create(id, empId, name, fromDate, reason)
        editLeaveForm.SetCallback(Sub()
                                      MessageBox.Show(Message.Message.successfully, Message.Title.success, MessageBoxButtons.OK)
                                      Load_DGVLeave()
                                  End Sub)
        editLeaveForm.Show()
    End Sub

    Private Sub x(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class