﻿Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class NewDashboard

    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

    Dim btnEmployeeClicked As Boolean = False

    Private Sub ptb_Icon_Click(sender As Object, e As EventArgs) Handles ptb_Icon.Click
        Me.Hide()
        Dim dashboard As New Dashboard
        dashboard.Show()
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
                    Dim DeptString As String = "Best Dept Manager: " & " " & vbCrLf & manager_name & " - " & dept_count
                    lbl_DeptManagerMax.Text = DeptString
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
                    Dim DeptString As String = "Best Pos Emp: " & " " & pos_name & " - " & emp_count
                    lbl_PosEmpMax.Text = DeptString
                    lbl_PosEmpMax.Font = New Font(lbl_PosEmpMax.Font, FontStyle.Bold)
                    lbl_PosEmpMax.ForeColor = Color.SpringGreen
                End If
            End Using
        End Using
    End Sub

    Private currentForm As Form = Nothing

    Private initialContentPanel As Panel = Nothing

    Private Sub pn_Main_Paint(sender As Object, e As PaintEventArgs) Handles pn_Main.Paint
        initialContentPanel = pn_Content
    End Sub

    Private Sub btn_Dashboard_Click(sender As Object, e As EventArgs) Handles btn_Dashboard.Click
        ResetMainPanel()
        Dim clickedButton As Button = CType(sender, Button)

        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)

        ResetButtonColors(clickedButton)
    End Sub

    Private Sub NewDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub ShowFormInMainPanel(formToShow As Form)
        ' Kiểm tra nếu form hiện tại không phải là formToShow
        If currentForm IsNot formToShow Then
            ' Đóng form hiện tại (nếu có)
            If currentForm IsNot Nothing Then
                currentForm.Close()
            End If

            ' Hiển thị formToShow trong contentPanel
            formToShow.TopLevel = False
            formToShow.TopMost = True
            formToShow.FormBorderStyle = FormBorderStyle.None
            formToShow.Dock = DockStyle.Fill
            pn_Main.Controls.Clear()
            pn_Main.Controls.Add(formToShow)
            formToShow.Show()

            ' Cập nhật form hiện tại
            currentForm = formToShow
        End If
    End Sub

    Private Sub ChangeButtonColor(button As Button, backColor As Color, foreColor As Color)
        button.BackColor = backColor
        button.ForeColor = foreColor
    End Sub

    Private Sub ResetButtonColors(clickedButton As Button)
        For Each btn As Button In pn_Sidebar.Controls.OfType(Of Button)()
            If btn IsNot clickedButton Then
                btn.BackColor = SystemColors.Control
                btn.ForeColor = SystemColors.ControlText
            End If
        Next
    End Sub

    Private Sub btn_Employee_Click(sender As Object, e As EventArgs) Handles btn_Employee.Click
        Dim employee As New frm_Employee
        ShowFormInMainPanel(frm_Employee)
        Dim clickedButton As Button = CType(sender, Button)

        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)

        ResetButtonColors(clickedButton)
    End Sub

    Private Sub btn_Department_Click(sender As Object, e As EventArgs) Handles btn_Department.Click
        Dim department As New frm_Department
        ShowFormInMainPanel(department)
        Dim clickedButton As Button = CType(sender, Button)

        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)

        ResetButtonColors(clickedButton)
    End Sub

    Private Sub btn_Manager_Click(sender As Object, e As EventArgs) Handles btn_Manager.Click
        Dim manager As New frm_Manager
        ShowFormInMainPanel(manager)
        Dim clickedButton As Button = CType(sender, Button)

        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)

        ResetButtonColors(clickedButton)
    End Sub

    Private Sub btn_Position_Click(sender As Object, e As EventArgs) Handles btn_Position.Click
        Dim positon As New PositionMenu
        ShowFormInMainPanel(positon)
        Dim clickedButton As Button = CType(sender, Button)

        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)

        ResetButtonColors(clickedButton)
    End Sub

    Private Sub btn_Salary_Click(sender As Object, e As EventArgs) Handles btn_Salary.Click
        Dim salary As New SalaryEmp
        ShowFormInMainPanel(salary)
        Dim clickedButton As Button = CType(sender, Button)

        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)

        ResetButtonColors(clickedButton)
    End Sub

    Private Sub btn_Leave_Click(sender As Object, e As EventArgs) Handles btn_Leave.Click
        Dim leave As New Leave
        ShowFormInMainPanel(leave)
        Dim clickedButton As Button = CType(sender, Button)

        ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)

        ResetButtonColors(clickedButton)
    End Sub

End Class