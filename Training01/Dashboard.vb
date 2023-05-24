Imports System.Data.SqlClient

Public Class Dashboard
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub pn_nhanvien_Paint_Click(sender As Object, e As PaintEventArgs) Handles pn_nhanvien.Paint
    End Sub

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
        Me.Hide()
        Dim Department As New frm_Salary
        Department.Show()
    End Sub

    Private Sub btnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click
        Dim leave As New Leave
        Me.Hide()
        leave.Show()
    End Sub
End Class