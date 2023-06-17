Public Class PositionMenu

#Region "EVENTS"
    Private Sub PositionMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomElements.RoundButton(btnEmployee)
        CustomElements.RoundButton(btnPosition)
        CustomElements.RoundButton(btnExit)
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        Me.Close()
        NewDashboard.ShowFormInMainPanel(EmpByPos)
        Dim clickedButton As Button = CType(sender, Button)
        NewDashboard.ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)
        NewDashboard.currentSelection = "Employee In Positions"
        NewDashboard.UpdateTitleLabel()
        NewDashboard.ResetButtonColors(clickedButton)
    End Sub

    Private Sub btnPosition_Click(sender As Object, e As EventArgs) Handles btnPosition.Click
        Me.Close()
        NewDashboard.ShowFormInMainPanel(Position)
        Dim clickedButton As Button = CType(sender, Button)
        NewDashboard.ChangeButtonColor(clickedButton, Color.LightSalmon, Color.LavenderBlush)
        NewDashboard.currentSelection = "Positions"
        NewDashboard.UpdateTitleLabel()
        NewDashboard.ResetButtonColors(clickedButton)
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
#End Region
End Class