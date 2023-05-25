Imports System.Data.SqlClient

Public Class frm_Salary
    Private Sub frm_Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_TitleSalary.BackColor = Color.Transparent
        lbl_SalaryID.BackColor = Color.Transparent
        lbl_EmpID.BackColor = Color.Transparent
        lbl_Salary.BackColor = Color.Transparent
        lbl_FromDate.BackColor = Color.Transparent
        lbl_FromDate.BackColor = Color.Transparent
        lbl_ToDate.BackColor = Color.Transparent
        btn_Update.Enabled = False
        btn_Delete.Enabled = False
        txt_SalaryID.Enabled = False

        LoadData()
    End Sub

    Private Class Selected_Salaries
        Public salary_id As Integer = 0
        Public emp_id As Integer = 0
        Public salary As Single = 0
        Public from_date As Date = Date.Now()
        Public to_date As Date = Date.Now()

        Public Sub New()
        End Sub
    End Class

    Private selectedSalaries As Selected_Salaries = New Selected_Salaries()

    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

    Private Sub ptb_Close_Click(sender As Object, e As EventArgs) Handles ptb_Close.Click
        Me.Hide()
        Dim dashboard As New Dashboard
        dashboard.Show()
    End Sub

    Public Sub ShowSalaries(ByVal reader As SqlDataReader)
        Dim id As Integer = CInt(reader("id"))
        Dim emp_id As Integer = CInt(reader("emp_id"))

        Dim salary As Single = CSng(reader("salary"))
        Dim from_date As String = reader("from_date").ToString()
        Dim to_date As String = reader("to_date").ToString()
        dgrv_Salary.Rows.Add(id, emp_id, salary, from_date, to_date)
    End Sub

    Public Sub LoadData()
        If con.State <> 1 Then
            con.Open()
        End If
        dgrv_Salary.Rows.Clear()
        Using cmd As SqlCommand = New SqlCommand("GetAllSalaries", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ShowSalaries(reader)
            End While
            con.Close()
        End Using
    End Sub


    Private Sub EnableAdd()
        btn_Add.Enabled = True
        btn_Update.Enabled = False
        btn_Delete.Enabled = False
    End Sub

    Private Sub DisableAdd()
        btn_Add.Enabled = False
        btn_Update.Enabled = True
        btn_Delete.Enabled = True
    End Sub

    Private Sub ClearForm()
        txt_EmpID.Text = String.Empty
        txt_Salary.Text = String.Empty
        dtp_FromDate.Value = Date.Now()
        dtp_ToDate.Value = Date.Now()
        dgrv_Salary.ClearSelection()
    End Sub

    Public Sub Add_Salaries(emp_id As Integer, salary As Single, from_date As Date, to_date As Date)
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("InsertSalaries", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@salary", salary)
                cmd.Parameters.AddWithValue("@from_date", from_date)
                cmd.Parameters.AddWithValue("@to_date", to_date)

                cmd.ExecuteNonQuery()
                LoadData()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub Update_Salary(id As Integer, emp_id As Integer, salary As Single, from_date As Date, to_date As Date)
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("UpdateSalaries", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@emp_id", emp_id)
                cmd.Parameters.AddWithValue("@salary", salary)
                cmd.Parameters.AddWithValue("@from_date", from_date)
                cmd.Parameters.AddWithValue("@to_date", to_date)

                cmd.ExecuteNonQuery()
                LoadData()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Delete_Salary(id As Integer)
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("DeleteSalaries", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                LoadData()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchSalariesByKeyword(keyword As String)
        Console.WriteLine(keyword)
        If con.State <> 1 Then
            con.Open()
        End If

        dgrv_Salary.Rows.Clear()
        Using cmd As SqlCommand = New SqlCommand("GetSalariesByKeyWord", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@keyword", keyword)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ShowSalaries(reader)
                    End While
                Else
                    MessageBox.Show(Message.Message.errorInvalidSearch, titleMsgBox, buttons, icons)
                End If
            End Using
        End Using
        con.Close()
    End Sub

    Private Sub CalculateTotal()
        If con.State <> 1 Then
            con.Open()
        End If

        Using cmd As SqlCommand = New SqlCommand("GetCalculateTotalSalaries", con)
            cmd.CommandType = CommandType.StoredProcedure

            Dim totalSalaryParam As SqlParameter = New SqlParameter("@TotalSalary", SqlDbType.Decimal)
            totalSalaryParam.Direction = ParameterDirection.Output
            cmd.Parameters.Add(totalSalaryParam)

            cmd.ExecuteNonQuery()

            Dim totalSalary As Decimal = Convert.ToDecimal(totalSalaryParam.Value)
            MessageBox.Show("Total Salary: " & totalSalary.ToString(), titleMsgBox)
        End Using
        con.Close()
    End Sub


    Private Sub TotalSalaries()
        If con.State <> 1 Then
            con.Open()
        End If

        'Xóa hết các cột hiện có trên dataGridview
        dgrv_Salary.Columns.Clear()


        If dgrv_Salary.Columns.Contains("salary_id") Then
            dgrv_Salary.Columns.Remove("salary_id")
        End If

        'Thêm cột emp_id
        Dim empIdColumn As New DataGridViewTextBoxColumn()
        empIdColumn.Name = "emp_id"
        empIdColumn.HeaderText = "Employeed ID"
        dgrv_Salary.Columns.Add(empIdColumn)

        'Thêm cột total_salary
        Dim totalSalaryColumn As New DataGridViewTextBoxColumn()
        totalSalaryColumn.Name = "total_salary"
        totalSalaryColumn.HeaderText = "Total Salary"
        dgrv_Salary.Columns.Add(totalSalaryColumn)

        dgrv_Salary.Rows.Clear()

        Using cmd As SqlCommand = New SqlCommand("GetTotalSalaryByEmployee", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader
                If reader.HasRows Then
                    While reader.Read()
                        Dim emp_id As Integer = reader.GetInt32(0)
                        Dim total_salary As Single = Convert.ToSingle(reader.GetDouble(1))

                        dgrv_Salary.Rows.Add(emp_id, total_salary)
                    End While
                End If
            End Using
        End Using
        con.Close()
    End Sub

    Dim titleMsgBox As String = "Notification"
    Dim titleErrorBox As String = "Error"
    Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
    Dim icons As MessageBoxIcon = MessageBoxIcon.Warning
    Dim errorIcons As MessageBoxIcon = MessageBoxIcon.Error

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim emp_id As Integer = CInt(txt_EmpID.Text)
        Dim salary As Single = CSng(txt_Salary.Text)
        Dim from_date As Date = dtp_FromDate.Value
        Dim to_date As Date = dtp_ToDate.Value

        If String.IsNullOrEmpty(txt_EmpID.Text) OrElse
          String.IsNullOrEmpty(txt_Salary.Text) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        Dim idValid As Boolean = FuntionCommon.Validation.ValidateID(txt_EmpID.Text)
        Dim salaryValid As Boolean = FuntionCommon.Validation.ValidateSalary(txt_Salary.Text)

        If Not idValid Then
            MessageBox.Show(Message.Message.errorInvalidId, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        If Not salaryValid Then
            MessageBox.Show(Message.Message.errorInvalidSalary, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        ' Validate Date inputs
        Dim fromDate As Date = dtp_FromDate.Value
        Dim toDate As Date = dtp_ToDate.Value
        Dim datesValid As Boolean = FuntionCommon.Validation.ValidateDate(fromDate, toDate)

        If Not datesValid Then
            MessageBox.Show(Message.Message.errorInvalidDate, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        Add_Salaries(emp_id, salary, from_date, to_date)
        ClearForm()
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Dim id As Integer = CInt(txt_SalaryID.Text)
        Dim emp_id As Integer = CInt(txt_EmpID.Text)
        Dim salary As Single = CSng(txt_Salary.Text)
        Dim from_date As Date = dtp_FromDate.Value
        Dim to_date As Date = dtp_ToDate.Value

        If String.IsNullOrEmpty(txt_EmpID.Text) OrElse
          String.IsNullOrEmpty(txt_Salary.Text) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleMsgBox, buttons, icons)
            Exit Sub
        End If


        Dim idValid As Boolean = FuntionCommon.Validation.ValidateID(txt_EmpID.Text)
        Dim salaryValid As Boolean = FuntionCommon.Validation.ValidateSalary(txt_Salary.Text)

        If Not idValid Then
            MessageBox.Show(Message.Message.errorInvalidId, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        If Not salaryValid Then
            MessageBox.Show(Message.Message.errorInvalidSalary, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        ' Validate Date inputs
        Dim fromDate As Date = dtp_FromDate.Value
        Dim toDate As Date = dtp_ToDate.Value
        Dim datesValid As Boolean = FuntionCommon.Validation.ValidateDate(fromDate, toDate)

        If Not datesValid Then
            MessageBox.Show(Message.Message.errorInvalidDate, titleErrorBox, buttons, errorIcons)
            Exit Sub
        End If

        Update_Salary(id, emp_id, salary, from_date, to_date)
        EnableAdd()
        ClearForm()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Dim id As Integer = Convert.ToInt32(txt_SalaryID.Text)
        Dim selectedRows As DataGridViewSelectedRowCollection = dgrv_Salary.SelectedRows
        If selectedRows.Count >= 0 AndAlso MessageBox.Show("Are you sure you want to delete the selected salary?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For Each selectedRow As DataGridViewRow In selectedRows
                dgrv_Salary.Rows.Remove(selectedRow)
            Next
            Delete_Salary(id)
            ClearForm()
            EnableAdd()

        Else
            MessageBox.Show("Deletion canceled.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Hide()
        Dim dashboard As New Dashboard
        dashboard.Show()
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        txt_SalaryID.Text = selectedSalaries.salary_id
        txt_EmpID.Text = selectedSalaries.emp_id
        txt_Salary.Text = selectedSalaries.salary
        dtp_FromDate.Value = selectedSalaries.from_date
        dtp_ToDate.Value = selectedSalaries.to_date
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        ClearForm()
        EnableAdd()
    End Sub

    Private Sub dgrv_Salary_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrv_Salary.CellClick
        If e.RowIndex >= 0 Then
            DisableAdd()
            Dim selectedRow = dgrv_Salary.Rows(e.RowIndex)

            txt_SalaryID.Text = selectedRow.Cells("salary_id").Value.ToString()
            selectedSalaries.salary_id = txt_SalaryID.Text
            txt_EmpID.Text = selectedRow.Cells("emp_id").Value.ToString()
            selectedSalaries.emp_id = txt_EmpID.Text
            txt_Salary.Text = selectedRow.Cells("salary").Value.ToString()
            selectedSalaries.salary = txt_Salary.Text
            dtp_FromDate.Value = Convert.ToDateTime(selectedRow.Cells("from_date").Value)
            selectedSalaries.from_date = dtp_FromDate.Value
            dtp_ToDate.Value = Convert.ToDateTime(selectedRow.Cells("to_date").Value)
            selectedSalaries.to_date = dtp_ToDate.Value
        End If
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim keyword As String = txt_Search.Text.Trim()
        If Not String.IsNullOrEmpty(keyword) Then
            SearchSalariesByKeyword(keyword)
        Else
            MessageBox.Show(Message.Message.emptyDataSearchMessage, titleMsgBox, buttons, icons)
        End If
    End Sub

    Private Sub btn_calculatetotal_click(sender As Object, e As EventArgs) Handles btn_CalculateTotal.Click
        TotalSalaries()
        dgrv_Salary.Enabled = False
    End Sub

    Private Sub btn_Total_Click(sender As Object, e As EventArgs) Handles btn_Total.Click
        CalculateTotal()
    End Sub
End Class