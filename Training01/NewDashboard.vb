Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class NewDashboard

    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

    Dim btnEmployeeClicked As Boolean = False
    Private initialUserName As String = "UserName"
    Private initialLabel As String = "EmployeeManagement"

    Private currentForm As Form = Nothing

    Private initialContentPanel As Panel = Nothing

    Dim isLoggedIn = My.Settings.IsLoggedIn
    Dim loggedInUserEmail = My.Settings.LoggedInUserEmail

    Dim buttonOK As MessageBoxButtons = GlobalVariables.buttonOK
    Dim buttonYesNo As MessageBoxButtons = GlobalVariables.buttonYesNo
    Dim warmIcon As MessageBoxIcon = GlobalVariables.warmIcon
    Dim questionIcon As MessageBoxIcon = GlobalVariables.questionIcon
    Dim infoIcon As MessageBoxIcon = GlobalVariables.infoIcon
    Dim errorIcon As MessageBoxIcon = GlobalVariables.errorIcon

    Dim titleSucces As String = GlobalVariables.titleSucces
    Dim titleNotif As String = GlobalVariables.titleNotif
    Dim titleError As String = GlobalVariables.titleError
    Dim titleConfỉrm As String = GlobalVariables.titleConfirm
    Dim titleInfo As String = GlobalVariables.titleInfo

    Private selectedButton As Button

    Public currentSelection As String = ""
    Public Sub UpdateTitleLabel()
        If String.IsNullOrEmpty(currentSelection) Then
            lbl_Title.Text = initialLabel
        Else
            lbl_Title.Text = currentSelection
        End If
    End Sub

    Public Sub GetInfoManagement()
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

    Public Sub LoadUserData()
        If isLoggedIn Then
            Dim email As String = loggedInUserEmail
            Dim fullName As String = GetFullNameByEmail(email)

            If Not String.IsNullOrEmpty(fullName) Then
                lbl_UserName.Text = fullName
            End If
            'Else
            '    MessageBox.Show("Please login to access dashboard page!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.Hide()
            '    Dim login As New Login
            '    login.ShowDialog()
        End If
    End Sub

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
        SetActiveButton(btn_Dashboard)
        GetInfoManagement()
        CustomElements.MovingDashboardByPanels(Me, pn_Header, pn_Sidebar)
    End Sub
    Private Sub NewDashboard_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadUserData()
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
        ' Close the current form (if any)
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If

        ' Remove controls in main panel
        pn_Main.Controls.Clear()

        ' Redisplay initial content (initialContentPanel) in main panel
        pn_Main.Controls.Add(initialContentPanel)
    End Sub

    Private Const WS_CHILD As Integer = &H40000000
    Private Const WS_CLIPSIBLINGS As Integer = &H4000000

    <DllImport("user32.dll")>
    Private Shared Function SetWindowLong(hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetWindowPos(hWnd As IntPtr, hWndInsertAfter As IntPtr, x As Integer, y As Integer, cx As Integer, cy As Integer, uFlags As UInteger) As Boolean
    End Function

    Public Sub ShowFormInMainPanel(ByVal formToShow As Form)
        If currentForm IsNot formToShow Then
            ' Close currentForm
            If currentForm IsNot Nothing Then
                currentForm.Close()
            End If

            pn_Main.Controls.Clear()
            ' Display formToShow in pn_Main
            formToShow.TopLevel = False
            formToShow.TopMost = True
            formToShow.FormBorderStyle = FormBorderStyle.None
            formToShow.Dock = DockStyle.Fill
            formToShow.AutoScroll = True
            pn_Main.Controls.Add(formToShow)

            'Set WS_CHILD và WS_CLIPSIBLINGS to Prevent override UI
            Dim style As Integer = SetWindowLong(formToShow.Handle, -16, WS_CHILD Or WS_CLIPSIBLINGS)
            SetWindowPos(formToShow.Handle, IntPtr.Zero, 0, 0, 0, 0, &H10 Or &H20 Or &H1 Or &H2)

            formToShow.Show()

            ' Update curentForm
            currentForm = formToShow
        End If
    End Sub

    Public Sub ChangeButtonColor(ByVal button As Button, ByVal backColor As Color, ByVal foreColor As Color)
        button.BackColor = backColor
        button.ForeColor = foreColor
    End Sub

    Public Sub ResetButtonColors(ByVal clickedButton As Button)
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
            Dim result As DialogResult = MessageBox.Show("Are you sure to log out user!!!", titleConfirm, buttonYesNo, questionIcon)

            If result = DialogResult.Yes Then
                My.Settings.Reset()
                ResetFormState()
                MessageBox.Show(Message.Message.logoutSuccess, titleNotif, buttonOK, infoIcon)
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