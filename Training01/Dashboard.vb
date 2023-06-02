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

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class