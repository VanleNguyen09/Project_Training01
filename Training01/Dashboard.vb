Imports System.Data.SqlClient

Public Class Dashboard

    Private Sub btn_Employee_Click(sender As Object, e As EventArgs) Handles btn_Employee.Click
        Dim con As SqlConnection

        con = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

        If con.State <> 1 Then
            con.Open()
        End If

        Me.Hide()
        Dim employee As New frm_Employee
        employee.Show()


    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Transparent
        Dim con As SqlConnection

        con = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

        If con.State <> 1 Then
            con.Open()
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Dim posMenu As New PositionMenu
        posMenu.Show()
    End Sub

    Private Sub btn_Department_Click(sender As Object, e As EventArgs) Handles btn_Department.Click
        Me.Hide()
        Dim Department As New frm_Department
        Department.Show()
    End Sub

    Private Sub btn_Salary_Click(sender As Object, e As EventArgs) Handles btn_Salary.Click
        Dim salary As New SalaryEmp
        Me.Hide()
        salary.Show()
    End Sub

    Private Sub btn_Manager_Click(sender As Object, e As EventArgs) Handles btn_Manager.Click
        Dim manager As New frm_Manager
        Me.Hide()
        manager.Show()
    End Sub

    Private Sub btn_Leave_Click(sender As Object, e As EventArgs) Handles btn_Leave.Click
        Dim leave As New Leave
        Me.Hide()
        leave.Show()
    End Sub

    Private Sub ptb_Icon_Click(sender As Object, e As EventArgs) Handles ptb_Icon.Click
        Me.Close()
    End Sub
End Class