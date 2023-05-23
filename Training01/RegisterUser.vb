Imports System.Data.SqlClient

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
        Dim email As String = txtEmail.Text.Trim()
        Dim fullName As String = txtFullName.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim cPassword As String = txtConfirmPassword.Text.Trim()
        Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
        Dim titleMsgBox As String = Message.Title.error

        'Validations
        If email = String.Empty OrElse fullName = String.Empty OrElse password = String.Empty OrElse cPassword = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleMsgBox, buttons)
            Exit Sub
        End If

        If Not FuntionCommon.Validation.IsEmail(email) Then
            MessageBox.Show(Message.Message.emailErrorMessage, titleMsgBox, buttons)
            txtEmail.Select()
            Exit Sub
        End If

        If Not FuntionCommon.Validation.CheckPassword(password) Then
            MessageBox.Show(Message.Message.passwordErrorMessage, titleMsgBox, buttons)
            txtPassword.Select()
            Exit Sub
        End If

        If Not FuntionCommon.Validation.CheckConfirmPassword(password, cPassword) Then
            MessageBox.Show(Message.Message.cPasswordErrorMessage, titleMsgBox, buttons)
            txtConfirmPassword.Select()
            Exit Sub
        End If

        'Check connection
        If con.State() <> 1 Then
            con.Open()
        End If

        Dim procedureSql As String = "GetUserByEmail"

        'Get user to check email is existed?
        Using cmd As SqlCommand = New SqlCommand(procedureSql, con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("email", email)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read Then
                MessageBox.Show(Message.Message.registeredEmailMsg, titleMsgBox, buttons)
            Else
                reader.Close()
                procedureSql = "AddUser"

                'Add User to database
                Using subCommand As SqlCommand = New SqlCommand(procedureSql, con)
                    subCommand.CommandType = CommandType.StoredProcedure
                    subCommand.Parameters.AddWithValue("email", email)
                    subCommand.Parameters.AddWithValue("full_name", fullName)
                    subCommand.Parameters.AddWithValue("password", FuntionCommon.HasMD5.GetHash(password))

                    Dim subReader As SqlDataReader = subCommand.ExecuteReader()
                End Using

                Dim result As DialogResult = MessageBox.Show(Message.Message.successfulregisterMsg, Message.Title.success, MessageBoxButtons.OK)
                If result = DialogResult.OK Then
                    'Switch to Login Form and fill email to email textbox
                    Dim login As New Login
                    login.txtEmail.Text = email
                    Me.Hide()
                    login.Show()
                    con.Close()
                End If
            End If
        End Using
    End Sub

End Class