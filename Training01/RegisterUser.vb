Imports System.Data.SqlClient

Public Class RegisterUser
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

#Region "EVENTS"
    Private Sub RegisterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.Select()
        CustomElements.MovingForm(Me)
        ptb_TogglePassword.Image = My.Resources.hide
        ptb_ToggleCFPassword.Image = My.Resources.hide
    End Sub
    Private isPasswordVisible As Boolean = False ' Trạng thái ban đầu của mật khẩu (ẩn)
    Private isCFPasswordVisible As Boolean = False ' Trạng thái ban đầu của mật khẩu (ẩn)

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtEmail.Text = Nothing
        txtFullName.Text = Nothing
        txtPassword.Text = Nothing
        txtConfirmPassword.Text = Nothing
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'If Login form is hidden
        For Each frm As Form In Application.OpenForms
            If Not frm.Visible And frm.Name = "Login" Then
                frm.Show()
                Exit Sub
            End If
        Next

        'If Login is not created
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
        Dim icon = MessageBoxIcon.Warning

        'Empty Validations
        If email = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleMsgBox, buttons, icon)
            txtEmail.Select()
            Exit Sub
        End If

        If fullName = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleMsgBox, buttons, icon)
            txtFullName.Select()
            Exit Sub
        End If

        If password = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleMsgBox, buttons, icon)
            txtPassword.Select()
            Exit Sub
        End If

        If cPassword = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, titleMsgBox, buttons, icon)
            txtConfirmPassword.Select()
            Exit Sub
        End If

        'Email Validations
        If Not FuntionCommon.Validation.IsEmail(email) Then
            MessageBox.Show(Message.Message.emailErrorMessage, titleMsgBox, buttons, icon)
            txtEmail.Select()
            Exit Sub
        End If

        'Password Validations
        If Not FuntionCommon.Validation.CheckPassword(password) Then
            MessageBox.Show(Message.Message.passwordErrorMessage, titleMsgBox, buttons, icon)
            txtPassword.Select()
            Exit Sub
        End If

        'Confirmed Password Validations
        If Not FuntionCommon.Validation.CheckConfirmPassword(password, cPassword) Then
            MessageBox.Show(Message.Message.cPasswordErrorMessage, titleMsgBox, buttons, icon)
            txtConfirmPassword.Select()
            Exit Sub
        End If

        'Check Connection
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

                Dim result As DialogResult = MessageBox.Show(Message.Message.successfulregisterMsg, Message.Title.success, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub RegisterUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub ptb_ToggleCFPassword_Click(sender As Object, e As EventArgs) Handles ptb_ToggleCFPassword.Click
        ' Invert state
        isCFPasswordVisible = Not isCFPasswordVisible

        ' Make a state change
        If isCFPasswordVisible Then
            txtConfirmPassword.PasswordChar = ""
            ptb_ToggleCFPassword.Image = My.Resources.view
        Else
            txtConfirmPassword.PasswordChar = "*"
            ptb_ToggleCFPassword.Image = My.Resources.hide
        End If

    End Sub

    Private Sub ptb_TogglePassword_Click(sender As Object, e As EventArgs) Handles ptb_TogglePassword.Click
        isPasswordVisible = Not isPasswordVisible

        If isPasswordVisible Then
            txtPassword.PasswordChar = ""
            ptb_TogglePassword.Image = My.Resources.view
        Else
            txtPassword.PasswordChar = "*"
            ptb_TogglePassword.Image = My.Resources.hide
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        btnExit.PerformClick()
    End Sub
#End Region
End Class