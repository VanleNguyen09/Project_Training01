Imports System.Data.SqlClient
Imports Page = FuntionCommon.Pagination
Imports Forms = System.Windows.Forms

Public Class EmpByPos
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Private RowsPerPage As Integer = 10
    Private CurrentPage As Integer = 1
    Private EmpByPosDatas As New DataTable
    Private SortedColumnIndex As Integer = -1
    Private SortedDirection As Forms.SortOrder = Forms.SortOrder.None

#Region "EVENTS"
    Private Sub cb_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearch.SelectedIndexChanged
        CurrentPage = 1
        'Settings Datagridview
        dgvEmpByPos.Columns("stt").DataPropertyName = "stt"
        dgvEmpByPos.Columns("id").DataPropertyName = "id"
        dgvEmpByPos.Columns("emp_name").DataPropertyName = "name"
        dgvEmpByPos.Columns("phone").DataPropertyName = "phone"
        dgvEmpByPos.Columns("email").DataPropertyName = "email"
        dgvEmpByPos.Columns("birthday").DataPropertyName = "birthday"
        dgvEmpByPos.Columns("pos_name").DataPropertyName = "pos_name"
        dgvEmpByPos.Columns("pos_id").DataPropertyName = "pos_id"
        LoadDataAsync()
    End Sub

    Private Sub Load_cbPosCreate_cbSearch()
        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            'Load Position Data To Combobox
            Dim sql = "SELECT id, name FROM Position WHERE status = 1"
            Using cmd As SqlCommand = New SqlCommand(sql, con)
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
            Dim Sql = "SELECT id, name FROM dbo.Employees WHERE status = 1"
            Using cmd As SqlCommand = New SqlCommand(Sql, con)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read
                    cbEmpCreate.Items.Add(New DictionaryEntry(CInt(reader("id").ToString()), reader("id").ToString() & " - " & reader("name").ToString()))
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
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim empId As Integer = cbEmpCreate.SelectedItem.Key
        Dim posId As Integer = cbPosCreate.SelectedItem.Key

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
                    'LoadEmpByPosDatas()
                    LoadDataAsync()
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
        Dim checkedRows As New List(Of DataGridViewRow)()

        If dgvEmpByPos.SelectedCells.Count > 0 Then
            For Each row As DataGridViewRow In dgvEmpByPos.Rows
                If (row.Cells("selectionBtn").Value = True) Then
                    checkedRows.Add(row)
                End If
            Next

            If (checkedRows.Count = 0) Then
                For Each cell As DataGridViewCell In dgvEmpByPos.SelectedCells
                    Dim row As DataGridViewRow = dgvEmpByPos.Rows(cell.RowIndex)
                    'Check row is existed?
                    If Not selectedRows.Contains(row) Then
                        selectedRows.Add(row)
                    End If
                Next
            End If
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

                If (checkedRows.Count = 0) Then
                    For Each dgvr As DataGridViewRow In selectedRows
                        idEmpList.Add(dgvr.Cells("id").Value)
                        posIdList.Add(dgvr.Cells("pos_id").Value)
                    Next
                Else
                    For Each dgvr As DataGridViewRow In checkedRows
                        idEmpList.Add(dgvr.Cells("id").Value)
                        posIdList.Add(dgvr.Cells("pos_id").Value)
                    Next
                End If

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
                    'LoadEmpByPosDatas()
                    LoadDataAsync()
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
        NewDashboard.LoadUserData()
        NewDashboard.btnPosManagement.PerformClick()
        Me.Close()
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Me.Close()
    End Sub

    Private Sub EmpByPos_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        LoadDataAsync()
        dgvEmpByPos.EndEdit()
        'Remove selected cell
        dgvEmpByPos.CurrentCell = Nothing

        ' Hide sorted icon
        For Each column As DataGridViewColumn In dgvEmpByPos.Columns
            column.HeaderCell.SortGlyphDirection = Nothing
        Next
    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Dim totalPages = Math.Ceiling(EmpByPosDatas.Rows.Count / RowsPerPage)
        Dim btnType = Page.ButtonType.Previous
        Page.ClickPreviousButton(btnPrevious, btnType, totalPages, CurrentPage, Sub() LoadDGV())
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim totalPages = Math.Ceiling(EmpByPosDatas.Rows.Count / RowsPerPage)
        Dim btnType = Page.ButtonType.Next
        Page.ClickNextButton(btnNext, btnType, totalPages, CurrentPage, Sub() LoadDGV())
    End Sub

    Private Sub txtCurrentPage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCurrentPage.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        Dim totalPages = Math.Ceiling(EmpByPosDatas.Rows.Count / RowsPerPage)
        Page.PressEnterKeyTxtCurrentPage(txtCurrentPage, CurrentPage, totalPages, e.KeyChar, Sub() LoadDGV())
    End Sub

    Private Sub dgvEmpByPos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvEmpByPos.ColumnHeaderMouseClick
        Dim sortedColumnIndex = e.ColumnIndex
        Dim dgvColumn = dgvEmpByPos.Columns(sortedColumnIndex)

        If e.ColumnIndex <> 0 AndAlso e.Button = MouseButtons.Left AndAlso dgvColumn.SortMode <> DataGridViewColumnSortMode.NotSortable Then
            Dim replaceColumnNameList As New Dictionary(Of String, String)
            replaceColumnNameList.Add("emp_name", "name")

            'Datas will change when sorted
            FuntionCommon.Sortation.SortDGVAndPreventNoColumn(dgvEmpByPos, EmpByPosDatas, sortedColumnIndex, "stt", replaceColumnNameList, Sub() LoadDGV())
            Me.SortedColumnIndex = sortedColumnIndex
            Me.SortedDirection = dgvEmpByPos.Columns(sortedColumnIndex).HeaderCell.SortGlyphDirection
        End If
    End Sub
#End Region

#Region "FUNCTIONS"
    Private Sub LoadEmpByPosDatas()
        Dim posId As Integer = cbSearch.SelectedItem.Key
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
                EmpByPosDatas.Rows.Clear()
                EmpByPosDatas.Load(reader)

                'Load in datagridview
                LoadDGV()
            End Using
        Catch ex As Exception
            MsgBox($"ERROR Load_DgvEmps: {ex.Message}")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadDGV()
        Dim totalPages = Math.Ceiling(EmpByPosDatas.Rows.Count / RowsPerPage)
        If totalPages = 0 Then
            CurrentPage = 1
            totalPages = 1
        End If

        txtCurrentPage.Text = CurrentPage
        txtTotalPage.Text = totalPages
        'Dim pagingDatas = Page.PaginateDataTable(CurrentPage, RowsPerPage, totalPages, EmpByPosDatas)
        Dim pagingDatas = From row In EmpByPosDatas.AsEnumerable()
                          Select row
                          Skip (RowsPerPage * (CurrentPage - 1))
                          Take (RowsPerPage)

        dgvEmpByPos.DataSource = pagingDatas.CopyToDataTable()

        If SortedColumnIndex > -1 Then
            dgvEmpByPos.Columns(SortedColumnIndex).HeaderCell.SortGlyphDirection = Me.SortedDirection
        End If

        Page.UpdatePaginationButtons(btnPrevious, Page.ButtonType.Previous, totalPages, CurrentPage)
        Page.UpdatePaginationButtons(btnNext, Page.ButtonType.Next, totalPages, CurrentPage)

        dgvEmpByPos.Select()
        dgvEmpByPos.CurrentCell = Nothing
    End Sub
    Private Sub LoadDataAsync()
        FuntionCommon.AsyncLoad.AsyncLoadDGV(dgvEmpByPos, Sub() LoadEmpByPosDatas())
    End Sub
#End Region
End Class