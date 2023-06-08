Imports System.Data.SqlClient

Public Class EditSalaryForm
    Public Delegate Sub MyCallbackDelegate()
    Private myCallback As MyCallbackDelegate
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    'id, name, salary
    Public Property TempData() As ValueTuple(Of Integer, String, Decimal)

    Public Sub SetCallback(callback As MyCallbackDelegate)
        myCallback = callback
    End Sub

    Private Sub EditSalaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TempData.Item1 = -1 Then
            txtName.Enabled = False
            txtSalary.Enabled = False
        End If
        txtId.Text = TempData.Item1
        txtName.Text = TempData.Item2
        txtSalary.Text = TempData.Item3
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub EnOrDisableBtnSave()
        If txtName.Text.Trim() = TempData.Item2.ToString() AndAlso txtSalary.Text.Trim() = TempData.Item3.ToString() Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        EnOrDisableBtnSave()
    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged
        EnOrDisableBtnSave()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim salaryName = txtName.Text
        Dim salary = txtSalary.Text

        If salaryName = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Select()
            Exit Sub
        End If

        If salary = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSalary.Select()
            Exit Sub
        End If

        If Not FuntionCommon.Validation.IsSalary(salary) Then
            MessageBox.Show(Message.Message.errorInvalidSalary, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSalary.Select()
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show(Message.Message.confirmedUpdate, Message.Title.notif, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        Select Case result
            Case DialogResult.No
                Exit Sub
            Case DialogResult.Yes
                Try
                    If con.State() <> 1 Then
                        con.Open()
                    End If

                    Dim sql = "UpdateSalaryById"
                    Using cmd As SqlCommand = New SqlCommand(sql, con)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("salary_id", txtId.Text)
                        cmd.Parameters.AddWithValue("salary_name", salaryName)
                        cmd.Parameters.AddWithValue("salary", salary)
                        cmd.ExecuteNonQuery()

                        ' Show loading and disable button Save
                        cirProgressBar.Visible = True
                        btnSave.Enabled = False

                        ' Set timmer
                        Dim timer As New Timer
                        timer.Interval = 1000
                        AddHandler timer.Tick, Sub()
                                                   ' Hide loading and enable button Save
                                                   cirProgressBar.Visible = False
                                                   btnSave.Enabled = True
                                                   timer.Stop()
                                                   Me.Close()
                                                   myCallback.Invoke()
                                               End Sub
                        timer.Start()
                    End Using
                Catch ex As Exception
                    MessageBox.Show(Message.Message.errorSQLQuery & ex.Message, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
        End Select
    End Sub

    Private Sub EditSalaryForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnSave.PerformClick()
        End If
    End Sub
    ' Save location of mouse when moving the form
    Private mousePosX As Integer
    Private mousePosY As Integer

    Private Sub EditSalaryForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            mousePosX = e.X
            mousePosY = e.Y
        End If
    End Sub

    Private Sub EditSalaryForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Left += e.X - mousePosX
            Me.Top += e.Y - mousePosY
        End If
    End Sub
End Class