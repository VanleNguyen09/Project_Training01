Imports System.Data.SqlClient

Public Class Login
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.Transparent
        LinkLabel1.BackColor = Color.Transparent
        Label1.BackColor = Color.Transparent
        Email.BackColor = Color.Transparent
        lblPassWord.BackColor = Color.Transparent
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim pass As String = txtPassword.Text.Trim()
        Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
        Dim titleMsgBox As String = "ERROR"

        'Validations
        If email = String.Empty OrElse pass = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleMsgBox, buttons)
            Exit Sub
        End If

        If Not FuntionCommon.Validation.IsEmail(email) Then
            MessageBox.Show(Message.Message.emailErrorMessage, titleMsgBox, buttons)
            Exit Sub
        End If

        If Not FuntionCommon.Validation.CheckPassword(pass) Then
            MessageBox.Show(Message.Message.passwordErrorMessage, titleMsgBox, buttons)
            Exit Sub
        End If

        'Switch to Dashboard if CheckLogin is successful
        If CheckLogin(email, pass) Then
            Me.Hide()
            Dim dashboard As New Dashboard
            dashboard.Show()
        Else
            MessageBox.Show(Message.Message.failedLoginMsg, titleMsgBox, buttons)
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim register As New RegisterUser
        register.Show()
    End Sub

    Private Function CheckLogin(email As String, pass As String) As Boolean
        'Check Connection
        If con.State() <> 1 Then
            con.Open()
        End If

        Dim procedureSql As String = "GetUserByEmail"

        'Check email and password in database
        Using cmd As SqlCommand = New SqlCommand(procedureSql, con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("email", email)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read Then
                If FuntionCommon.HasMD5.GetHash(pass) = reader("password") Then
                    con.Close()
                    Return True
                End If
            End If

            con.Close()
            Return False
        End Using
    End Function
End Class