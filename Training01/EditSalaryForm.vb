Imports System.Data.SqlClient

Public Class EditSalaryForm
    Public Delegate Sub MyCallbackDelegate()
    Private myCallback As MyCallbackDelegate
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    'id, name, salary
    Public Property TempData As Object()

#Region "EVENTS"
    Private Sub EditSalaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TempData(0) = -1 Then
            txtName.Enabled = False
            txtSalary.Enabled = False
        End If
        txtId.Text = TempData(0)
        txtName.Text = TempData(1)
        txtSalary.Text = TempData(2)
        CustomElements.MovingForm(Me)
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
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

                        btnSave.Enabled = False
                        cmd.ExecuteNonQuery()

                        CustomElements.ShowCirProgressBar(3, New Size(150, 150), Sub()
                                                                                     Me.Close()
                                                                                     myCallback.Invoke()
                                                                                 End Sub)
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
#End Region

#Region "FUNCTIONS"
    Public Sub SetCallback(callback As MyCallbackDelegate)
        myCallback = callback
    End Sub

    Private Sub EnOrDisableBtnSave()
        If txtName.Text.Trim() = TempData(1).ToString() AndAlso txtSalary.Text.Trim() = TempData(2).ToString() Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub
#End Region
End Class