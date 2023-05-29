Imports System.Data.SqlClient

Public Class SalaryEmp
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Private Sub SalaryEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_DGV_Emp()
        Load_DGV_SalaryEmp()
    End Sub

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
            End Using
        Catch ex As Exception
            MessageBox.Show("Load_DGV_Emp: " & Message.Message.errorSQLQuery & ex.Message, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Load_DGV_SalaryEmp()
        Dim searchText As String = txtSearch.Text
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
                dgvSalaries.Rows.Add({0, -1, "None", 0})

                While reader.Read
                    dgvSalaries.Rows.Add({reader("stt"), reader("salary_id"), reader("salary_name"), reader("salary")})
                End While

                'Remove selected cell
                dgvSalaries.CurrentCell = Nothing
            End Using
        Catch ex As Exception
            MessageBox.Show("Load_DGV_SalaryEmp: " & Message.Message.errorSQLQuery & ex.Message, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dgvEmps_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvEmps.RowPrePaint
        ' Set color for all rows of Datagridview
        For Each cell As DataGridViewCell In dgvEmps.Rows(e.RowIndex).Cells
            cell.Style.ForeColor = Color.Black
        Next
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Load_DGV_Emp()
    End Sub

    Private Sub dgvEmps_Sorted(sender As Object, e As EventArgs) Handles dgvEmps.Sorted
        'If it is stt column, sorted normal 
        If dgvEmps.SortedColumn.Name <> "stt" Then
            For i As Integer = 0 To dgvEmps.Rows.Count - 1
                dgvEmps.Rows(i).Cells("stt").Value = (i + 1).ToString()
            Next
        End If
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dboard As New Dashboard
        dboard.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim salaryName = txtSalaryName.Text
        Dim salary = txtSalary.Text

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
            Exit Sub
        End If

        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            Dim sql = "InsertSalary"
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("name", salaryName)
                cmd.Parameters.AddWithValue("salary", salary)
                cmd.ExecuteNonQuery()

                Load_DGV_SalaryEmp()
            End Using
        Catch ex As Exception
            MessageBox.Show("btnAdd_Click: " & Message.Message.errorSQLQuery & ex.Message, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dgvSalaries_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvSalaries.RowPrePaint
        ' Set color for all rows of Datagridview
        For Each cell As DataGridViewCell In dgvSalaries.Rows(e.RowIndex).Cells
            cell.Style.ForeColor = Color.Black
        Next
    End Sub

    Private Sub dgvSalaries_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSalaries.CellFormatting
        ' Salary is fourth column
        If e.ColumnIndex = 3 Then
            Dim value As Decimal = CDec(e.Value)
            If value = 0 OrElse value = Nothing Then
                e.Value = 0
                Exit Sub
            End If
            e.Value = FuntionCommon.CurrencyFormat.ConvertCurrencyVND(value)
        End If
    End Sub

    Private Sub dgvEmps_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmps.CellClick
        Dim row As DataGridViewRow = dgvEmps.Rows(e.RowIndex)

        Dim salaryId As Integer = Convert.ToInt32(row.Cells("salary_emp_id").Value)

        ' Check valye of salary_id column in dgvSalaries
        For Each r As DataGridViewRow In dgvSalaries.Rows
            r.Selected = (r.Cells("salary_id").Value = salaryId)
        Next
    End Sub
End Class