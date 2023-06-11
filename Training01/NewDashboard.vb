Imports System.Data.SqlClient
Public Class NewDashboard

    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

    Dim btnEmployeeClicked As Boolean = False
    Private initialUserName As String = "UserName"
    Private initialLabel As String = "EmployeeManagement"

    Private currentForm As Form = Nothing

    Private initialContentPanel As Panel = Nothing

    Dim isLoggedIn = My.Settings.IsLoggedIn
    Dim loggedInUserEmail = My.Settings.LoggedInUserEmail

    Private Sub EnableDoubleBuffering(panel As Panel)
        Dim doubleBufferedProperty = GetType(Control).GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        doubleBufferedProperty.SetValue(panel, True, Nothing)
    End Sub
    Private Sub NewDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_UserName.Text = initialUserName
        lbl_Title.Text = initialLabel
        Me.BackColor = TransparencyKey
        EnableDoubleBuffering(pn_Header)
        EnableDoubleBuffering(pn_Main)
        EnableDoubleBuffering(pn_Sidebar)
        EnableDoubleBuffering(pn_Content)
        Me.Controls.Add(pn_Sidebar)
        'LoadUserData()
        SetActiveButton(btn_Dashboard)
        CountTotalEmployees()
        CountTotalDepartments()
        CountTotalManagers()
        CountTotalPositions()
        CountTotalLeaves()
        CountTotalSalaries()
        MaxEmpDept()
        MaxDeptEmp()
        MaxDeptManager()
        MaxPosEmp()
    End Sub
    Private Sub NewDashboard_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadUserData()
    End Sub

    Private selectedButton As Button

    Private currentSelection As String = ""
    Private Sub UpdateTitleLabel()
        If String.IsNullOrEmpty(currentSelection) Then
            lbl_Title.Text = initialLabel
        Else
            lbl_Title.Text = currentSelection
        End If
    End Sub

    Private Sub SetActiveButton(ByVal button As Button)
        ChangeButtonColor(button, Color.LightSalmon, Color.LavenderBlush)
        ' Check if has button item selected
        If selectedButton IsNot Nothing Then
            ' Set active state to defaut for previous button item 
            selectedButton.BackColor = Color.Transparent
            selectedButton.Cursor = Cursors.Default
        End If

        selectedButton = button
    End Sub

    Public Sub LoadUserData()
        If isLoggedIn Then
            Dim email As String = loggedInUserEmail
            Dim fullName As String = GetFullNameByEmail(email)

            If Not String.IsNullOrEmpty(fullName) Then
                lbl_UserName.Text = fullName
            End If
        Else
            MessageBox.Show("Please login to access dashboard page!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide() ' Đóng form Dashboard
            Dim login As New Login
            login.ShowDialog()
        End If
    End Sub

    Private Sub CountTotalEmployees()
        If con.State <> 1 Then
            con.Open()
        End If

        Using cmd As SqlCommand = New SqlCommand("CountTotalEmployees", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read Then
                    lb_EmployeeTotal.Text = reader("SL_NV").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Sub CountTotalDepartments()
        If con.State <> 1 Then
            con.Open()
        End If
        Using cmd As SqlCommand = New SqlCommand("CountTotalDepartments", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read Then
                    lbl_DepartmentTotal.Text = reader("SL_DP").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Sub CountTotalManagers()
        If con.State <> 1 Then
            con.Open()
        End If
        Using cmd As SqlCommand = New SqlCommand("CountTotalManagers", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read Then
                    lbl_TotalManager.Text = reader("SL_MG").ToString()
                End If
            End Using
        End Using
    End Sub


    Private Sub CountTotalPositions()
        If con.State <> 1 Then
            con.Open()
        End If
        Using cmd As SqlCommand = New SqlCommand("CountTotalPositions", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read Then
                    lbl_TotalPositon.Text = reader("SL_PS").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Sub CountTotalLeaves()
        If con.State <> 1 Then
            con.Open()
        End If
        Using cmd As SqlCommand = New SqlCommand("CountTotalLeaves", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read Then
                    lbl_TotalLeave.Text = reader("SL_Leaves").ToString()
                End If
            End Using
        End Using
    End Sub


    Private Sub CountTotalSalaries()
        If con.State <> 1 Then
            con.Open()
        End If
        Using cmd As SqlCommand = New SqlCommand("CountTotalSalaries", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read Then
                    Dim salary = reader("TOTAL_SALARIES").ToString()
                    lbl_TotalSalary.Text = FuntionCommon.CurrencyFormat.ConvertCurrencyVND(salary)
                End If
            End Using
        End Using
    End Sub

    Private Sub MaxEmpDept()
        If con.State <> 1 Then
            con.Open()
        End If
        Using cmd As SqlCommand = New SqlCommand("MaxEmpDept", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read Then
                    Dim emp_name = reader("employee_name").ToString()
                    Dim dept_count = reader("department_count").ToString()
                    Dim EmpString As String = "Best Emp Dept: " & " " & emp_name & " - " & dept_count
                    lbl_EmptDeptMax.Text = EmpString
                    lbl_EmptDeptMax.Font = New Font(lbl_EmptDeptMax.Font, FontStyle.Bold)
                    lbl_EmptDeptMax.ForeColor = Color.Orange
                End If
            End Using
        End Using
    End Sub

    Private Sub MaxDeptEmp()
        If con.State <> 1 Then
            con.Open()
        End If
        Using cmd As SqlCommand = New SqlCommand("MaxDeptEmp", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read Then
                    Dim dept_name = reader("department_name").ToString()
                    Dim emp_count = reader("employee_count").ToString()
                    Dim DeptString As String = "Best Dept Emp: " & " " & dept_name & " - " & emp_count
                    lbl_DeptEmpMax.Text = DeptString
                    lbl_DeptEmpMax.Font = New Font(lbl_DeptEmpMax.Font, FontStyle.Bold)
                    lbl_DeptEmpMax.ForeColor = Color.Red
                End If
            End Using
        End Using
    End Sub

    Private Sub MaxDeptManager()
        If con.State <> 1 Then
            con.Open()
        End If
        Using cmd As SqlCommand = New SqlCommand("MaxDeptManager", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read Then
                    Dim manager_name = reader("manager_name").ToString()
                    Dim dept_count = reader("department_count").ToString()
                    Dim DeptMgString As String = "Best Dept Manager: " & " " & vbCrLf & manager_name & " - " & dept_count
                    lbl_DeptManagerMax.Text = DeptMgString
                    lbl_DeptManagerMax.Font = New Font(lbl_DeptManagerMax.Font, FontStyle.Bold)
                    lbl_DeptManagerMax.ForeColor = Color.Navy
                End If
            End Using
        End Using
    End Sub

    Private Sub MaxPosEmp()
        If con.State <> 1 Then
            con.Open()
        End If
        Using cmd As SqlCommand = New SqlCommand("MaxPosEmp", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read Then
                    Dim pos_name = reader("position_name").ToString()
                    Dim emp_count = reader("employee_count").ToString()
                    Dim PosString As String = "Best Pos Emp: " & " " & pos_name & " - " & emp_count
                    lbl_PosEmpMax.Text = PosString
                    lbl_PosEmpMax.Font = New Font(lbl_PosEmpMax.Font, FontStyle.Bold)
                    lbl_PosEmpMax.ForeColor = Color.SpringGreen
                End If
            End Using
        End Using
    End Sub

    Private Sub pn_Main_Paint(sender As Object, e As PaintEventArgs) Handles pn_Main.Paint
        initialContentPanel = pn_Content
    End Sub

    Private Function GetFullNameByEmail(ByVal email As String) As String
        Dim fullName As String = ""
        Try
            If con.State <> 1 Then
                con.Open()
            End If

            Using cmd As SqlCommand = New SqlCommand("GetFullNameByEmail", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@email", email)

                Dim reader As SqlDataReader = cmd.ExecuteReader
                If reader.Read Then
                    fullName = reader.GetString(reader.GetOrdinal("fullName"))
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return fullName
    End Function

    Private Sub ResetMainPanel()
        ' Đóng form hiện tại (nếu có)
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If

        ' Xóa các controls trong mainPanel
        pn_Main.Controls.Clear()

        ' Hiển thị lại nội dung ban đầu (initialContentPanel) trong mainPanel
        pn_Main.Controls.Add(initialContentPanel)
    End Sub

    Private Sub ShowFormInMainPanel(ByVal formToShow As Form)
        If currentForm IsNot formToShow Then
            ' Close currentForm
            If currentForm IsNot Nothing Then
                currentForm.Close()
            End If

            ' Display formToShow in pn_Main
            formToShow.TopLevel = False
            formToShow.TopMost = True
            formToShow.FormBorderStyle = FormBorderStyle.None
            formToShow.Dock = DockStyle.Fill
            formToShow.AutoScroll = True
            pn_Main.Controls.Clear()
            pn_Main.Controls.Add(formToShow)
            formToShow.Show()

            ' Update curentForm
            currentForm = formToShow
        End If
    End Sub

    Private Sub ChangeButtonColor(ByVal button As Button, ByVal backColor As Color, ByVal foreColor As Color)
        button.BackColor = backColor
        button.ForeColor = foreColor
    End Sub

    Private Sub ResetButtonColors(ByVal clickedButton As Button)
        For Each btn As Button In pn_Sidebar.Controls.OfType(Of Button)()
            If btn IsNot clickedButton Then
                btn.BackColor = SystemColors.Control
                btn.ForeColor = SystemColors.ControlText
            End If
        Next
    End Sub

    Private Sub ResetFormState()
        lbl_UserName.Text = initialUserName
    End Sub

    Private Sub btn_Dashboard_Click(sender As Object, e As EventArgs) Handles btn_Dashboard.Click
        ResetMainPanel()
        Dim clickedButton As Button = CType(sender, Button)
        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)
        currentSelection = "Dashboard"
        UpdateTitleLabel()
        ResetButtonColors(clickedButton)
    End Sub

    Private Sub btn_Employee_Click(sender As Object, e As EventArgs) Handles btn_Employee.Click
        ShowFormInMainPanel(frm_Employee)
        Dim clickedButton As Button = CType(sender, Button)
        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)
        currentSelection = "Employee"
        UpdateTitleLabel()
        ResetButtonColors(clickedButton)
    End Sub

    Private Sub btn_Department_Click(sender As Object, e As EventArgs) Handles btn_Department.Click
        ShowFormInMainPanel(frm_Department)
        Dim clickedButton As Button = CType(sender, Button)
        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)
        currentSelection = "Department"
        UpdateTitleLabel()
        ResetButtonColors(clickedButton)
    End Sub

    Private Sub btn_Manager_Click(sender As Object, e As EventArgs) Handles btn_Manager.Click
        ShowFormInMainPanel(frm_Manager)
        Dim clickedButton As Button = CType(sender, Button)
        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)
        currentSelection = "Manager"
        UpdateTitleLabel()
        ResetButtonColors(clickedButton)
    End Sub

    Private Sub btn_Position_Click(sender As Object, e As EventArgs) Handles btn_Position.Click
        ShowFormInMainPanel(PositionMenu)
        Dim clickedButton As Button = CType(sender, Button)
        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)
        currentSelection = "Position"
        UpdateTitleLabel()
        ResetButtonColors(clickedButton)
    End Sub

    Private Sub btn_Salary_Click(sender As Object, e As EventArgs) Handles btn_Salary.Click
        ShowFormInMainPanel(SalaryEmp)
        Dim clickedButton As Button = CType(sender, Button)
        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)
        currentSelection = "Salary"
        UpdateTitleLabel()
        ResetButtonColors(clickedButton)
    End Sub

    Private Sub btn_Leave_Click(sender As Object, e As EventArgs) Handles btn_Leave.Click
        ShowFormInMainPanel(My.Forms.Leave)
        Dim clickedButton As Button = CType(sender, Button)
        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)
        currentSelection = "Leave"
        UpdateTitleLabel()
        ResetButtonColors(clickedButton)
    End Sub


    Private Sub btn_Signout_Click(sender As Object, e As EventArgs) Handles btn_Signout.Click
        Dim clickedButton As Button = CType(sender, Button)
        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)
        currentSelection = "Signout"
        UpdateTitleLabel()
        ResetButtonColors(clickedButton)

        If isLoggedIn Then
            Dim result As DialogResult = MessageBox.Show("Are you sure to log out user!!!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                My.Settings.Reset()
                ResetFormState()
                MessageBox.Show("You logout success!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim login As New Login
                Me.Hide()
                login.ShowDialog()
            End If
        End If
    End Sub

    Private Sub ptb_Icon_Click(sender As Object, e As EventArgs) Handles ptb_Icon.Click
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub ptb_Icon_MouseEnter(sender As Object, e As EventArgs) Handles ptb_Icon.MouseEnter
        ptb_Icon.Cursor = Cursors.Hand
    End Sub

    Private Sub ptb_Icon_MouseLeave(sender As Object, e As EventArgs) Handles ptb_Icon.MouseLeave
        ptb_Icon.Cursor = Cursors.Default
    End Sub

End Class