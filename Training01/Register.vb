Imports System.Data.SqlClient

Public Class Register
    Dim con As SqlConnection
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

    End Sub

    Private Sub Register_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txt_phone.Select()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
        If con.State() <> 1 Then
            con.Open()
        End If

        Using cmd As SqlCommand = New SqlCommand("GetAllProvinces", con)
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            If reader.Read Then
                While reader.Read
                    cbb_province.Items.Add(reader("name"))
                End While
            End If
            con.Close()
        End Using

    End Sub

    Private Sub cbb_province_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_province.SelectedIndexChanged

    End Sub
End Class