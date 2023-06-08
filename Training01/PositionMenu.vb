Public Class PositionMenu
    Private Sub PositionMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomElements.RoundButton(btnEmployee)
        CustomElements.RoundButton(btnPosition)
        CustomElements.RoundButton(btnExit)
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        Dim empByPos As New EmpByPos
        empByPos.Show()
    End Sub

    Private Sub btnPosition_Click(sender As Object, e As EventArgs) Handles btnPosition.Click
        Dim position As New Position
        position.Show()
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class