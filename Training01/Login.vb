Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = TextBox1.Text
        Dim passWord As String = FuntionCommon.HasMD5.GetHash(TextBox2.Text)

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        Dim register As New Register
        register.Show()
    End Sub
End Class