Imports System.Data.SqlClient

Public Class EmpByPos
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

    '------------- EVENTS -------------
    Private Sub cb_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearch.SelectedIndexChanged
        Dim posId As String = cbSearch.SelectedItem.Key
        LoadDgvEmps(posId) 'Load dataGridView for employees list
    End Sub

    Private Sub EmpByPos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Column's Headers DataGridView
        If dgvEmpByPos.Columns.Count = 0 Then
            Dim columns = {"ID", "NAME", "PHONE", "EMAIL", "BIRTHDAY"}
            For i As Integer = 0 To columns.Length - 1
                dgvEmpByPos.Columns.Add(New DataGridViewTextBoxColumn With {.Name = columns(i)})
            Next
        End If

        OpenConnection()

        'Load Position Data To Combobox
        Dim sql = "GetAllPositions"
        Using cmd As SqlCommand = New SqlCommand(sql, con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            'Settings for Combobox
            cbPosCreate.DisplayMember = "Value"
            cbPosCreate.ValueMember = "Key"
            cbPosCreate.Items.Add(New DictionaryEntry(-1, "-SELECT-"))

            cbPosRemove.DisplayMember = "Value"
            cbPosRemove.ValueMember = "Key"

            cbSearch.DisplayMember = "Value"
            cbSearch.ValueMember = "Key"
            cbSearch.Items.Add(New DictionaryEntry(-1, "-ALL-"))

            While reader.Read
                cbPosCreate.Items.Add(New DictionaryEntry(CInt(reader("id")), reader("name").ToString()))
                cbSearch.Items.Add(New DictionaryEntry(CInt(reader("id")), reader("name").ToString()))
            End While

        End Using

        'Load Employees Data To Combobox
        sql = "GetAllEmployees"
        Using cmd As SqlCommand = New SqlCommand(sql, con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            'Settings for Combobox
            cbEmpCreate.DisplayMember = "Value"
            cbEmpCreate.ValueMember = "Key"
            cbEmpCreate.Items.Add(New DictionaryEntry(-1, "-SELECT-"))

            cbEmpRemove.DisplayMember = "Value"
            cbEmpRemove.ValueMember = "Key"
            cbEmpRemove.Items.Add(New DictionaryEntry(-1, "-SELECT-"))

            While reader.Read
                cbEmpCreate.Items.Add(New DictionaryEntry(CInt(reader("id")), reader("name").ToString()))
                cbEmpRemove.Items.Add(New DictionaryEntry(CInt(reader("id")), reader("name").ToString()))
            End While
        End Using

        'reset combobox to default
        cbPosCreate.SelectedIndex = 0
        cbSearch.SelectedIndex = 0
        cbEmpCreate.SelectedIndex = 0
        cbEmpRemove.SelectedIndex = 0
    End Sub

    Private Sub cbEmpRemove_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpRemove.SelectedIndexChanged
        OpenConnection()

        Dim empId As Integer = cbEmpRemove.SelectedItem.Key
        cbPosRemove.Items.Clear()
        cbPosRemove.Text = ""

        If empId < 0 Then
            Exit Sub
        End If

        'Load data for position combobox
        Dim sql = "GetAllPosByEmpId"
        Using cmd As SqlCommand = New SqlCommand(sql, con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("emp_id", empId)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            'Settings for combobox
            cbPosRemove.DisplayMember = "Value"
            cbPosRemove.ValueMember = "Key"
            cbPosRemove.Items.Add(New DictionaryEntry(-1, "-SELECT-"))
            cbPosRemove.SelectedIndex = 0

            While reader.Read
                cbPosRemove.Items.Add(New DictionaryEntry(CInt(reader("id")), reader("name").ToString()))
            End While
        End Using
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

        OpenConnection()

        'Add Employee to Selected Position
        Dim sql = "AddEmpToPos"
        Using cmd As SqlCommand = New SqlCommand(sql, con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("emp_id", empId)
            cmd.Parameters.AddWithValue("pos_id", posId)
            Try
                cmd.ExecuteReader()
                titleMsgBox = "SUCCESS"
                MessageBox.Show(Message.Message.successfullAddPosForThisEmp, titleMsgBox, buttons)

                'Reload Data
                ReloadDGVEmps(posId, posIndex)
            Catch ex As Exception
                'If this position is existed for this employee
                MessageBox.Show(Message.Message.existedPosForThisEmp, titleMsgBox, buttons)
            End Try
        End Using
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim empId As Integer = cbEmpRemove.SelectedItem.Key
        Dim posId As Integer = If(cbPosRemove.SelectedIndex = -1, -1, cbPosRemove.SelectedItem.Key)
        Dim posIndex As Integer = cbPosRemove.SelectedIndex

        Dim titleMsgBox = "ERROR"
        Dim buttons = MessageBoxButtons.OK

        'Validations for Add comboboxes
        If empId < 0 OrElse posId < 0 Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleMsgBox, buttons)
            Exit Sub
        End If

        OpenConnection()

        'Delete An Employee in Selected Position
        Dim sql = "DeleteEmpInPos"
        Using cmd As SqlCommand = New SqlCommand(sql, con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("emp_id", empId)
            cmd.Parameters.AddWithValue("pos_id", posId)
            Try
                cmd.ExecuteReader()
                titleMsgBox = "SUCCESS"
                MessageBox.Show(Message.Message.successfullDeleteEmpPos, titleMsgBox, buttons)

                'Reload Data
                ReloadDGVEmps(posId, posIndex)
                cbEmpRemove.SelectedIndex = 0
            Catch ex As Exception
                'If this position is existed for this employee
                MessageBox.Show(Message.Message.errorSQLQuery, titleMsgBox, buttons)
            End Try
        End Using
    End Sub

    '------------- FUNCTIONS -------------
    Protected Overrides Sub Finalize()
        con.Close()
    End Sub

    Private Sub OpenConnection()
        If con.State() <> 1 Then
            con.Open()
        End If
    End Sub

    Private Sub LoadDgvEmps(posId As Integer)
        Dim sql As String

        dgvEmpByPos.Rows.Clear()

        OpenConnection()

        'load datagridview by posId
        If posId < 0 Then
            sql = "GetAllEmployees"
        Else
            sql = "GetEmpsByPosId"
        End If
        Using cmd As SqlCommand = New SqlCommand(sql, con)
            cmd.CommandType = CommandType.StoredProcedure
            'If not get All
            If posId > -1 Then
                cmd.Parameters.AddWithValue("pos_id", posId)
            End If

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read
                dgvEmpByPos.Rows.Add(
                        New String() {
                                         reader("id"),
                                         reader("name"),
                                         reader("phone"),
                                         reader("email"),
                                         reader("birthday")})
            End While
        End Using
    End Sub

    Private Sub ReloadDGVEmps(posId As Integer, posIndex As Integer)
        If (cbSearch.SelectedIndex = posIndex) Then
            LoadDgvEmps(posId) 'Change Event doesn't run so call the function
        Else
            cbSearch.SelectedIndex = posIndex 'Change Event runs when cbSearch is changed 
        End If
    End Sub
End Class