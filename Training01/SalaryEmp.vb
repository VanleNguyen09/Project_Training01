Imports System.Data.SqlClient

Public Class SalaryEmp
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Private salariesList As New List(Of Decimal)

    ''' <summary>
    ''' LOAD THIS FORM
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SalaryEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_DGV_Emp()
        Load_DGV_SalaryEmp()
    End Sub

    ''' <summary>
    ''' LOAD DATA INTO DATAGRIDVIEW EMP
    ''' </summary>
    Private Sub Load_DGV_Emp()
        Dim searchText As String = txtSearch.Text
        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            Dim sql = "GetAllEmployeesByWords"
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("words", searchText)

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dgvEmps.Rows.Clear()

                While reader.Read
                    dgvEmps.Rows.Add(New String() {
                                         reader("stt"), reader("id"),
                                         reader("name"), reader("phone"),
                                         reader("address"), reader("birthday"),
                                         reader("email"), If(reader("salary_emp_id") Is DBNull.Value, -1, reader("salary_emp_id"))})
                End While

                'Remove selected cell
                dgvEmps.CurrentCell = Nothing
                dgvSalaries.CurrentCell = Nothing
            End Using
        Catch ex As Exception
            MessageBox.Show("Load_DGV_Emp: " & Message.Message.errorSQLQuery & ex.Message, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    ''' <summary>
    ''' LOAD DATA INTO DATAGRIDVIEW SALARY EMP
    ''' </summary>
    Private Sub Load_DGV_SalaryEmp()
        Dim searchText As String = txtSearchSalary.Text
        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            Dim sql = "GetAllSalariesByWords"
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("words", searchText)

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dgvSalaries.Rows.Clear()
                salariesList.Clear()

                While reader.Read
                    dgvSalaries.Rows.Add({reader("stt"), reader("salary_id"), reader("salary_name"), reader("salary")})
                End While

                'Remove selected cell
                dgvSalaries.CurrentCell = Nothing

                For Each r In dgvSalaries.Rows
                    r.DefaultCellStyle.BackColor = dgvSalaries.DefaultCellStyle.BackColor
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Load_DGV_SalaryEmp: " & Message.Message.errorSQLQuery & ex.Message, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    ''' <summary>
    ''' ROW PREPARE PAINT 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvEmps_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvEmps.RowPrePaint
        ' Set color for all rows of Datagridview (Because they has white color of groupbox)
        For Each cell As DataGridViewCell In dgvEmps.Rows(e.RowIndex).Cells
            cell.Style.ForeColor = Color.Black
        Next
    End Sub

    ''' <summary>
    ''' CHANGED SEARCH TEXTBOX EVENT
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Load_DGV_Emp()
    End Sub

    ''' <summary>
    ''' SORTED DGV EMPS EVENT
    ''' - Prevent sort stt column
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvEmps_Sorted(sender As Object, e As EventArgs) Handles dgvEmps.Sorted
        'If it is stt column, sorted normal 
        If dgvEmps.SortedColumn.Name <> "stt" Then
            For i As Integer = 0 To dgvEmps.Rows.Count - 1
                dgvEmps.Rows(i).Cells("stt").Value = (i + 1).ToString()
            Next
        End If
    End Sub

    ''' <summary>
    ''' CLOSE APP
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dboard As New Dashboard
        dboard.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim salaryName = txtSalaryName.Text.Trim()
        Dim salary = txtSalary.Text.Trim()

        If salaryName = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSalaryName.Select()
            Exit Sub
        End If

        If salary = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSalary.Select()
            Exit Sub
        End If

        If Not FuntionCommon.Validation.IsSalary(salary) Then
            MessageBox.Show(Message.Message.errorInvalidSalary, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSalary.Select()
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show(Message.Message.confirmCreate, Message.Title.notif, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        Select Case result
            Case DialogResult.No
                Exit Sub
            Case DialogResult.Yes
                Try
                    If con.State() <> 1 Then
                        con.Open()
                    End If

                    Dim sql = "InsertSalary"
                    Using cmd As SqlCommand = New SqlCommand(sql, con)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("name", salaryName)
                        cmd.Parameters.AddWithValue("salary", Convert.ToDecimal(salary))
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show(Message.Message.errorSQLQuery & ex.Message, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Finally
                    con.Close()
                End Try
        End Select

        Load_DGV_SalaryEmp()
        txtSalaryName.Text = ""
        txtSalary.Text = ""
        dgvEmps_SelectionChanged(sender, e)
    End Sub

    ''' <summary>
    ''' ROW PRE PAINT
    ''' SET AGAIN COLOR FOR CELL Because they has white color of groupbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvSalaries_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvSalaries.RowPrePaint
        ' Set color for all rows of Datagridview (Because they has white color of groupbox)
        For Each cell As DataGridViewCell In dgvSalaries.Rows(e.RowIndex).Cells
            cell.Style.ForeColor = Color.Black
        Next
    End Sub

    ''' <summary>
    ''' FORMATTING FOR SALARY COLUMN
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvSalaries_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSalaries.CellFormatting
        ' Salary is fourth column
        If e.ColumnIndex = 3 Then
            Dim value As Decimal = CDec(e.Value)
            salariesList.Add(value)
            If value = 0 OrElse value = Nothing Then
                e.Value = 0
                Exit Sub
            End If
            e.Value = FuntionCommon.CurrencyFormat.ConvertCurrencyVND(value)
        End If
    End Sub

    ''' <summary>
    ''' SET COLOR DEFAULT AND COLOR CHANGED WHEN SELECT OTHER SALARY
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvSalaries_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSalaries.SelectionChanged
        If dgvEmps.SelectedRows.Count > 0 AndAlso dgvSalaries.SelectedRows.Count > 0 Then
            Dim selectedRowDGVEmps As DataGridViewRow = dgvEmps.SelectedRows(0)
            Dim selectedRowDGVSalaries As DataGridViewRow = dgvSalaries.SelectedRows(0)
            ' Get id of 2 tables
            Dim salaryEmpId As Integer = Convert.ToInt32(selectedRowDGVEmps.Cells("salary_emp_id").Value)
            Dim salaryId As Integer = Convert.ToInt32(selectedRowDGVSalaries.Cells("salary_id").Value)

            If salaryEmpId = salaryId Then
                selectedRowDGVSalaries.DefaultCellStyle.BackColor = Color.Yellow
                btnUpdate.Enabled = False
            Else
                btnUpdate.Enabled = True
                selectedRowDGVEmps.DefaultCellStyle.BackColor = dgvEmps.DefaultCellStyle.BackColor
                selectedRowDGVSalaries.DefaultCellStyle.BackColor = dgvSalaries.DefaultCellStyle.BackColor
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (dgvSalaries.SelectedRows.Count > 1) Then
            MessageBox.Show(Message.Message.chooseOneRow, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim selectedRowDGVEmps As DataGridViewRow = dgvEmps.SelectedRows(0)
        Dim selectedRowDGVSalaries As DataGridViewRow = dgvSalaries.SelectedRows(0)
        Dim selectedRowIndexInDGVEmps As Integer = selectedRowDGVEmps.Index
        ' Get id of 2 tables
        Dim salaryEmpId As Integer = Convert.ToInt32(selectedRowDGVEmps.Cells("salary_emp_id").Value)
        Dim salaryId As Integer = Convert.ToInt32(selectedRowDGVSalaries.Cells("salary_id").Value)

        If salaryEmpId = salaryId Then
            MessageBox.Show(Message.Message.nothingChange, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show(Message.Message.confirmedUpdate, Message.Title.notif, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        Select Case result
            Case DialogResult.No
                Exit Sub
            Case DialogResult.Yes
                Try
                    If con.State() <> 1 Then
                        con.Open()
                    End If

                    Dim empId As Integer = selectedRowDGVEmps.Cells("id").Value
                    Dim sql = "UpdateSalaryForEmp"
                    Using cmd As SqlCommand = New SqlCommand(sql, con)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("emp_id", empId)
                        cmd.Parameters.AddWithValue("salary_id", salaryId)
                        cmd.ExecuteNonQuery()

                        MessageBox.Show(Message.Message.successfully, Message.Title.success, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("btnUpdate_Click: " & Message.Message.errorSQLQuery & ex.Message, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Finally
                    con.Close()
                End Try

                'Reload again and Select again
                Load_DGV_Emp()
                dgvEmps.CurrentCell = dgvEmps.Rows(selectedRowIndexInDGVEmps).Cells(0)
                dgvEmps.FirstDisplayedScrollingRowIndex = selectedRowIndexInDGVEmps
                dgvEmps_SelectionChanged(sender, e)
        End Select
    End Sub

    ''' <summary>
    ''' AFTER FORM IS SHOWN 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SalaryEmp_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgvEmps.CurrentCell = Nothing
        dgvSalaries.CurrentCell = Nothing
    End Sub

    Private Sub txtSearchSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSalary.TextChanged
        Load_DGV_SalaryEmp()
    End Sub

    Private Sub dgvSalaries_Sorted(sender As Object, e As EventArgs) Handles dgvSalaries.Sorted
        'If it is stt column, sorted normal 
        If dgvSalaries.SortedColumn.Name <> "salary_stt" Then
            For i As Integer = 0 To dgvEmps.Rows.Count + 1
                dgvSalaries.Rows(i).Cells("salary_stt").Value = (i + 1).ToString()
            Next
        End If
    End Sub

    Private Sub dgvEmps_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmps.SelectionChanged
        'reset color of DGV Salaries when click other row in DGV Emps
        For Each r In dgvSalaries.Rows
            r.DefaultCellStyle.BackColor = dgvSalaries.DefaultCellStyle.BackColor
        Next

        If dgvEmps.CurrentRow Is Nothing OrElse dgvEmps.CurrentRow.Index = -1 Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = dgvEmps.Rows(dgvEmps.CurrentRow.Index)

        Dim salaryId As Integer = Convert.ToInt32(row.Cells("salary_emp_id").Value)

        ' Check value of salary_id column in dgvSalaries
        For Each r As DataGridViewRow In dgvSalaries.Rows
            r.Selected = False 'Check when nothing change
            If (r.Cells("salary_id").Value = salaryId) Then
                r.Selected = True
            End If
        Next
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvSalaries.SelectedRows.Count < 1 Then
            MessageBox.Show(Message.Message.selectedRowError, Message.Title.error, MessageBoxButtons.OK)
            Exit Sub
        End If
        'Confirm Delete
        Dim result As DialogResult = MessageBox.Show(Message.Message.confirmedDelete & " Employees had this salary will be set Unknown Salary!", Message.Title.notif, MessageBoxButtons.YesNo)
        Select Case result
            Case DialogResult.No
                Exit Sub
            Case DialogResult.Yes
                Dim salaryIdList As New List(Of Integer)

                For Each dgvr As DataGridViewRow In dgvSalaries.SelectedRows
                    salaryIdList.Add(dgvr.Cells("salary_id").Value)
                Next

                Dim sql = "DeleteSalaryById"
                Try
                    For i As Integer = 0 To salaryIdList.Count - 1
                        'Delete a Salary in Selected Position
                        Using cmd As SqlCommand = New SqlCommand(sql, con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("salary_id", salaryIdList(i))

                            If con.State() <> 1 Then
                                con.Open()
                            End If

                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    MessageBox.Show(Message.Message.successfullDeleteEmpPos, Message.Title.notif, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Reload Data
                    Load_DGV_Emp()
                    Load_DGV_SalaryEmp()
                Catch ex As Exception
                    MsgBox($"ERROR: {ex.Message}")
                Finally
                    con.Close()
                End Try
        End Select
    End Sub

    Private Sub dgvSalaries_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalaries.CellDoubleClick
        Dim row As DataGridViewRow = dgvSalaries.Rows(e.RowIndex)
        Dim editSalaryForm As New EditSalaryForm

        Dim id As Integer = Convert.ToInt32(row.Cells("salary_id").Value)
        Dim salaryName As String = row.Cells("salary_name").Value.ToString()
        Dim salary As Decimal = salariesList(e.RowIndex)

        editSalaryForm.TempData = ValueTuple.Create(id, salaryName, salary)
        editSalaryForm.SetCallback(Sub()
                                       MessageBox.Show(Message.Message.successfully, Message.Title.success, MessageBoxButtons.OK)
                                       Load_DGV_SalaryEmp()
                                   End Sub)
        editSalaryForm.Show()
    End Sub

    Private Sub txtSalaryName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalaryName.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnAdd.PerformClick()
        End If
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnAdd.PerformClick()
        End If
    End Sub

    Private Sub dgvSalaries_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSalaries.KeyDown
        If e.KeyCode = Keys.Delete Then
            btnDelete.PerformClick()
        End If

        If e.KeyCode = Keys.Enter Then
            e.Handled = True 'Prevent default action
            btnUpdate.PerformClick()
        End If

        If e.KeyCode = Keys.Left Then
            ' Press Key Left -> Focus DGV Emps
            dgvEmps.Focus()
        End If
    End Sub

    Private Sub dgvEmps_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvEmps.KeyDown
        If e.KeyCode = Keys.Right Then
            ' Press Key Right -> Focus DGV Salaries
            dgvSalaries.Focus()
        End If
    End Sub
End Class