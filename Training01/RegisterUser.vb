Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class RegisterUser
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Private Sub RegisterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.Select()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtEmail.Text = Nothing
        txtFullName.Text = Nothing
        txtPassword.Text = Nothing
        txtConfirmPassword.Text = Nothing
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Dim login As New Login
        login.Show()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If con.State() <> 1 Then
            con.Open()
        End If
        Dim sqlQuery As String = ""

        If txtEmail.Text <> String.Empty And txtFullName.Text IsNot Nothing AndAlso txtPassword.Text IsNot Nothing And txtConfirmPassword.Text IsNot Nothing Then

        End If

        Using cmd As SqlCommand = New SqlCommand(sqlQuery, con)
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            If reader.Read Then
                If reader("email") Then
                    MsgBox("User has been registered.")
                End If
            End If
            con.Close()
        End Using
    End Sub
End Class