
Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.Transparent
        LinkLabel1.BackColor = Color.Transparent
        Label1.BackColor = Color.Transparent
        Email.BackColor = Color.Transparent
        lblPassWord.BackColor = Color.Transparent
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Dim dashboard As New Dashboard
        dashboard.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim register As New RegisterUser
        register.Show()
    End Sub
End Class