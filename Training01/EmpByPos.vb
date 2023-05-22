Imports System.Data.SqlClient

Public Class EmpByPos
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

    '------------- EVENTS -------------
    Private Sub cb_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearch.SelectedIndexChanged
        Dim posId As String = cbSearch.SelectedItem.Key
        LoadDgvEmps(posId) 'Load dataGridView for employees list
    End Sub

    Private Sub Load_cbPosCreate_cbSearch()
        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            'Load Position Data To Combobox
            Dim sql = "GetAllPositions"
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read
                    cbPosCreate.Items.Add(New DictionaryEntry(CInt(reader("id")), reader("name").ToString()))
                    cbSearch.Items.Add(New DictionaryEntry(CInt(reader("id")), reader("name").ToString()))
                End While

            End Using
        Catch ex As Exception
            MsgBox($"ERROR Load_cbPosCreate_cbSearch: {ex.Message}")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Load_cbEmpCreate_cbEmpRemove()
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
                    cbEmpCreate.Items.Add(New DictionaryEntry(CInt(reader("id")), reader("name").ToString()))
                End While
            End Using
        Catch ex As Exception
            MsgBox($"ERROR Load_cbEmpCreate_cbEmpRemove: {ex.Message}")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub EmpByPos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Settings for Combobox
        cbPosCreate.DisplayMember = "Value"
        cbPosCreate.ValueMember = "Key"
        cbPosCreate.Items.Add(New DictionaryEntry(-1, "-SELECT-"))

        cbSearch.DisplayMember = "Value"
        cbSearch.ValueMember = "Key"
        cbSearch.Items.Add(New DictionaryEntry(-1, "-ALL-"))

        cbEmpCreate.DisplayMember = "Value"
        cbEmpCreate.ValueMember = "Key"
        cbEmpCreate.Items.Add(New DictionaryEntry(-1, "-SELECT-"))

        Load_cbPosCreate_cbSearch()
        Load_cbEmpCreate_cbEmpRemove()

        'reset combobox to default
        cbPosCreate.SelectedIndex = 0
        cbSearch.SelectedIndex = 0
        cbEmpCreate.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim empId As Integer = cbEmpCreate.SelectedItem.Key
        Dim posId As Integer = cbPosCreate.SelectedItem.Key
        Dim posIndex As Integer = cbPosCreate.SelectedIndex

        Dim titleMsgBox = "ERROR"
        Dim buttons = MessageBoxButtons.OK

        'Validations for Add comboboxes
        If empId < 0 OrElse posId < 0 Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleMsgBox, buttons)
            Exit Sub
        End If

        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            'Add Employee to Selected Position
            Dim sql = "AddEmpToPos"
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("emp_id", empId)
                cmd.Parameters.AddWithValue("pos_id", posId)
                Try
                    cmd.ExecuteNonQuery()
                    titleMsgBox = "SUCCESS"
                    MessageBox.Show(Message.Message.successfullAddPosForThisEmp, titleMsgBox, buttons)

                    'Reload Data
                    ReloadDGVEmps(posId, posIndex)
                Catch ex As Exception
                    'If this position is existed for this employee
                    MessageBox.Show(Message.Message.existedPosForThisEmp, titleMsgBox, buttons)
                End Try
            End Using
        Catch ex As Exception
            MsgBox($"ERROR btnAdd_Click: {ex.Message}")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'Selected Rows to Delete
        If dgvEmpByPos.SelectedRows.Count < 1 Then
            MsgBox(Message.Message.selectedRowError)
            Exit Sub
        End If

        Dim posId As Integer = cbSearch.SelectedItem.Key

        'Selected Position to Delete
        If posId < 0 Then
            MsgBox(Message.Message.selectedPositionError)
            Exit Sub
        End If

        'Confirm Delete
        Dim result As DialogResult = MessageBox.Show(Message.Message.confirmedDelete, "NOTIFICATION", MessageBoxButtons.YesNo)
        Select Case result
            Case DialogResult.No
                Exit Sub
            Case DialogResult.Yes
                Dim idEmpList As List(Of Integer) = New List(Of Integer)

                For Each dgvr As DataGridViewRow In dgvEmpByPos.SelectedRows
                    idEmpList.Add(dgvr.Cells(0).Value)
                Next

                Dim sql = "DeleteEmpInPos"
                Try
                    For Each empId As Integer In idEmpList
                        'Delete An Employee in Selected Position
                        Using cmd As SqlCommand = New SqlCommand(sql, con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("emp_id", empId)
                            cmd.Parameters.AddWithValue("pos_id", posId)

                            If con.State() <> 1 Then
                                con.Open()
                            End If
                            cmd.ExecuteNonQuery()
                            'con.Close()
                        End Using
                    Next
                Catch ex As Exception
                    MsgBox($"ERROR Delete: {ex.Message}")
                    Exit Sub
                Finally
                    con.Close()
                End Try
                MessageBox.Show(Message.Message.successfullDeleteEmpPos, "NOTIFICATION", MessageBoxButtons.OK)
                'Reload Data
                LoadDgvEmps(posId)
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Dim posMenu As New PositionMenu
        posMenu.Show()
    End Sub

    Private Sub btnManagePos_Click(sender As Object, e As EventArgs) Handles btnManagePos.Click
        Me.Hide()
        Dim managePos As New Position
        managePos.Show()
    End Sub
    '------------- FUNCTIONS -------------
    Private Sub LoadDgvEmps(posId As Integer)
        Dim sql As String

        dgvEmpByPos.Rows.Clear()

        If posId < 0 Then
            sql = "GetAllEmployees"
        Else
            sql = "GetEmpsByPosId"
        End If

        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            'load datagridview by posId
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                'If not get All
                If posId > -1 Then
                    cmd.Parameters.AddWithValue("pos_id", posId)
                End If

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read
                    dgvEmpByPos.Rows.Add(New String() {reader("id"), reader("name"), reader("phone"), reader("email"), reader("birthday")})
                End While
            End Using
        Catch ex As Exception
            MsgBox($"ERROR Load_DgvEmps: {ex.Message}")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ReloadDGVEmps(posId As Integer, posIndex As Integer)
        If (cbSearch.SelectedIndex = posIndex) Then
            LoadDgvEmps(posId) 'Change Event doesn't run so call the function
        Else
            cbSearch.SelectedIndex = posIndex 'Change Event runs when cbSearch is changed 
        End If
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Environment.Exit(0)
    End Sub
End Class