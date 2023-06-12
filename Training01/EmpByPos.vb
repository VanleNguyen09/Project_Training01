﻿Imports System.Data.SqlClient
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
                    cbPosCreate.Items.Add(New DictionaryEntry(CInt(reader("id").ToString()), reader("name").ToString()))
                    cbSearch.Items.Add(New DictionaryEntry(CInt(reader("id").ToString()), reader("name").ToString()))
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
                    cbEmpCreate.Items.Add(New DictionaryEntry(CInt(reader("id").ToString()), reader("name").ToString()))
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

        'Remove selected cell
        dgvEmpByPos.CurrentCell = Nothing
        CustomElements.MovingForm(Me)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim empId As Integer = cbEmpCreate.SelectedItem.Key
        Dim posId As Integer = cbPosCreate.SelectedItem.Key
        Dim posIndex As Integer = cbPosCreate.SelectedIndex

        Dim titleMsgBox = Message.Title.error
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
                    titleMsgBox = Message.Title.success
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
        Dim selectedRows As New List(Of DataGridViewRow)()
        If dgvEmpByPos.SelectedCells.Count > 0 Then
            For Each cell As DataGridViewCell In dgvEmpByPos.SelectedCells
                Dim row As DataGridViewRow = dgvEmpByPos.Rows(cell.RowIndex)

                'Check row is existed?
                If Not selectedRows.Contains(row) Then
                    selectedRows.Add(row)
                End If
            Next
        Else
            MessageBox.Show(Message.Message.selectedRowError, Message.Title.notif, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Confirm Delete
        Dim result As DialogResult = MessageBox.Show(Message.Message.confirmedDelete, Message.Title.notif, MessageBoxButtons.YesNo)
        Select Case result
            Case DialogResult.No
                Exit Sub
            Case DialogResult.Yes
                Dim idEmpList As List(Of Integer) = New List(Of Integer)
                Dim posIdList As List(Of Integer) = New List(Of Integer)

                For Each dgvr As DataGridViewRow In selectedRows
                    idEmpList.Add(dgvr.Cells("id").Value)
                    posIdList.Add(dgvr.Cells("pos_id").Value)
                Next

                Dim sql = "DeleteEmpInPos"
                Try
                    For i As Integer = 0 To idEmpList.Count - 1
                        'Delete An Employee in Selected Position
                        Using cmd As SqlCommand = New SqlCommand(sql, con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("emp_id", idEmpList(i))
                            cmd.Parameters.AddWithValue("pos_id", posIdList(i))

                            If con.State() <> 1 Then
                                con.Open()
                            End If
                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    MessageBox.Show(Message.Message.successfullDeleteEmpPos, Message.Title.notif, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Reload Data
                    LoadDgvEmps(cbSearch.SelectedItem.Key)
                Catch ex As Exception
                    MsgBox($"ERROR Delete: {ex.Message}")
                Finally
                    con.Close()
                End Try

        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
        Dim posMenu As New PositionMenu
        posMenu.Show()
    End Sub

    Private Sub btnManagePos_Click(sender As Object, e As EventArgs) Handles btnManagePos.Click
        Me.Hide()
        Dim managePos As New Position
        managePos.Show()
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Me.Close()
    End Sub

    Private Sub dgvEmpByPos_Sorted(sender As Object, e As EventArgs) Handles dgvEmpByPos.Sorted
        'If it is stt column, sorted normal 
        If dgvEmpByPos.SortedColumn.Name <> "stt" Then
            For i As Integer = 0 To dgvEmpByPos.Rows.Count - 1
                dgvEmpByPos.Rows(i).Cells("stt").Value = (i + 1).ToString()
            Next
        End If
    End Sub

    Private Sub EmpByPos_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        LoadDgvEmps(cbSearch.SelectedItem.Key)
        dgvEmpByPos.EndEdit()
        'Remove selected cell
        dgvEmpByPos.CurrentCell = Nothing

        ' Hide sorted icon
        For Each column As DataGridViewColumn In dgvEmpByPos.Columns
            column.HeaderCell.SortGlyphDirection = Nothing
        Next
    End Sub

    '------------- FUNCTIONS -------------
    Private Sub LoadDgvEmps(posId As Integer)
        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            Dim sql = "GetEmpsByPosId"
            'load datagridview by posId
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("pos_id", posId)

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dgvEmpByPos.Rows.Clear()

                While reader.Read
                    dgvEmpByPos.Rows.Add(New String() {
                                         reader("stt").ToString(), reader("id").ToString(),
                                         reader("name").ToString(), reader("phone").ToString(),
                                         reader("email").ToString(), reader("birthday").ToString(),
                                         reader("pos_name").ToString(), reader("pos_id").ToString()})
                End While

                'Remove selected cell
                dgvEmpByPos.CurrentCell = Nothing
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

End Class