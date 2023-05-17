Imports System.Data.SqlClient

Public Class Employee
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    cb_Department.Items.Add("")
                End While
                Dim a As String = reader("abc").ToString()
            End If
        End Using
    End Sub

    Private Sub cb_Department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Department.SelectedIndexChanged

    End Sub
End Class