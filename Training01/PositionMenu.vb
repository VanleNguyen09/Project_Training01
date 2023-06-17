﻿Public Class PositionMenu

#Region "EVENTS"
    Private Sub PositionMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomElements.RoundButton(btnEmployee)
        CustomElements.RoundButton(btnPosition)
        CustomElements.RoundButton(btnExit)
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        NewDashboard.LoadUserData()
        NewDashboard.ShowFormInMainPanel(EmpByPos)
        NewDashboard.currentSelection = "Employees In Positions"
        NewDashboard.UpdateTitleLabel()
        Me.Close()
    End Sub

    Private Sub btnPosition_Click(sender As Object, e As EventArgs) Handles btnPosition.Click
        NewDashboard.LoadUserData()
        NewDashboard.ShowFormInMainPanel(Position)
        NewDashboard.currentSelection = "Positions"
        NewDashboard.UpdateTitleLabel()
        Me.Close()
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
#End Region
End Class