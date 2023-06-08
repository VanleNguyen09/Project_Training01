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
        Dim warningIcon = MessageBoxIcon.Warning
        Dim titleMsgBox As String = Message.Title.error

        'Validations
        If email = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleMsgBox, buttons, warningIcon)
            txtEmail.Select()
            Exit Sub
        End If
        If pass = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleMsgBox, buttons, warningIcon)
            txtPassword.Select()
            Exit Sub
        End If

        If Not FuntionCommon.Validation.IsEmail(email) Then
            MessageBox.Show(Message.Message.emailErrorMessage, titleMsgBox, buttons, warningIcon)
            txtEmail.Select()
            Exit Sub
        End If

        If Not FuntionCommon.Validation.CheckPassword(pass) Then
            MessageBox.Show(Message.Message.passwordErrorMessage, titleMsgBox, buttons, warningIcon)
            txtPassword.Select()
            Exit Sub
        End If


        'Switch to Dashboard if CheckLogin is successful
        If CheckLogin(email, pass) Then
            My.Settings.IsLoggedIn = True
            My.Settings.LoggedInUserEmail = email
            My.Settings.Save()
            MessageBox.Show("Login succes. User can access to dashboard page", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim dashboard As New NewDashboard()
            dashboard.Show()
        Else
            MessageBox.Show(Message.Message.failedLoginMsg, Message.Title.notif, buttons, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim register As New RegisterUser
        register.Show()
    End Sub

    Private Function CheckLogin(email As String, pass As String) As Boolean
        Try
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
                        Return True
                    End If
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return False
    End Function

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Environment.Exit(0)
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        EnterClick(e)
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        EnterClick(e)
    End Sub

    Private Sub EnterClick(e As KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class