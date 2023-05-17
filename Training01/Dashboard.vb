Imports System.Data.SqlClient

Public Class Dashboard
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub pn_nhanvien_Paint_Click(sender As Object, e As PaintEventArgs) Handles pn_nhanvien.Paint

        'Dim con As SqlConnection

        'con = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

        'If con.State <> 1 Then
        '    con.Open()
        'End If

        'Me.Hide()
        'Dim employee As New Employee
        'employee.Show()

    End Sub

    Private Sub btn_Employee_Click(sender As Object, e As EventArgs) Handles btn_Employee.Click
        Dim con As SqlConnection

        con = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

        If con.State <> 1 Then
            con.Open()
        End If

        Me.Hide()
        Dim employee As New Employee
        employee.Show()


    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As SqlConnection

        con = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

        If con.State <> 1 Then
            con.Open()
        End If


        Using cmd As SqlCommand = New SqlCommand("", con)
            'trong "" là tên store procedure
            cmd.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read

            End While
            If reader.Read Then
                While reader.Read

                End While
                Dim a As String = reader("abc").ToString()
            End If
        End Using
    End Sub
End Class