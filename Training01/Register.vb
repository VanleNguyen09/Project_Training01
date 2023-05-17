Imports System.Data.SqlClient

Public Class Register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim con As SqlConnection

        con = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

        If con.State() <> 1 Then
            con.Open()
        End If

    End Sub

    Private Sub Register_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txt_phone.Select()
    End Sub
End Class