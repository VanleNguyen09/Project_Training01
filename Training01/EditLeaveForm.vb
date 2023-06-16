Imports System.Data.SqlClient

Public Class EditLeaveForm
    Public Delegate Sub MyCallbackDelegate()
    Private myCallback As MyCallbackDelegate
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Private daTFormat As String = DTFormat.Type.NormalDateAndHourMinusTime
    Public Property TempData() As List(Of Object) 'id, emp_id, name, from_date, reason, isConfirmed

#Region "EVENTS"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Me.Hide()
    End Sub

    Private Sub EditLeaveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Settings for Combobox
        cbEmpName.DisplayMember = "Value"
        cbEmpName.ValueMember = "Key"

        Dim loadingForm As New CommonLoading()
        FuntionCommon.AsyncLoad.AsyncLoadCBB(cbEmpName, Sub()
                                                            Load_cbEmpName()
                                                            ResetData()
                                                            loadingForm.Hide()
                                                        End Sub)
        loadingForm.ShowDialog()

        If (TempData(5) = 1) Then
            cbEmpName.Enabled = False
            dtpFromDate.Enabled = False
            rtxtReason.Enabled = False
            btnSave.Visible = False
            btnReset.Visible = False
            btnConfirm.Visible = False
        End If

        'Set Format
        dtpFromDate.Format = DateTimePickerFormat.Custom
        dtpFromDate.CustomFormat = daTFormat
        CustomElements.MovingForm(Me)
        'Load_cbEmpName()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim leaveId As Integer = lbIdValue.Text
        Dim empId As Integer = lbEmpIdValue.Text

        Dim separators() As Char = {"-"c}
        Dim empName As String = cbEmpName.SelectedItem.Value.ToString().Split(separators, 2, StringSplitOptions.RemoveEmptyEntries)(1).Trim()

        Dim fDate As Date = dtpFromDate.Value
        Dim reason As String = rtxtReason.Text.Trim()


        If empId < 0 Then
            MessageBox.Show(Message.Message.emptyErrorMessage, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbEmpName.Select()
            Exit Sub
        End If

        If reason = String.Empty Then
            MessageBox.Show(Message.Message.emptyErrorMessage, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
            rtxtReason.Select()
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

                    Dim sql = "UpdateLeave"
                    Using cmd As SqlCommand = New SqlCommand(sql, con)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("id", leaveId)
                        cmd.Parameters.AddWithValue("emp_id", empId)
                        cmd.Parameters.AddWithValue("emp_name", empName)
                        cmd.Parameters.AddWithValue("from_date", fDate.AddSeconds(-fDate.Second))
                        cmd.Parameters.AddWithValue("reason", reason)
                        cmd.ExecuteNonQuery()
                        CustomElements.ShowCirProgressBar(3, New Size(180, 180), Sub()
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetData()
    End Sub

    Private Sub rtxtReason_TextChanged(sender As Object, e As EventArgs) Handles rtxtReason.TextChanged
        EnableOrDisableSaveButton()
    End Sub

    Private Sub cbEmpName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpName.SelectedIndexChanged
        lbEmpIdValue.Text = cbEmpName.SelectedItem.Key
        EnableOrDisableSaveButton()
    End Sub

    Private Sub dtpFromDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpFromDate.ValueChanged
        EnableOrDisableSaveButton()
    End Sub

    Private Sub lbEmpIdValue_Click(sender As Object, e As EventArgs) Handles lbEmpIdValue.Click
        cbEmpName.Select() 'Focus
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'Confirm Leave
        Dim result As DialogResult = MessageBox.Show(Message.Message.confirmedUpdate, Message.Title.notif, MessageBoxButtons.YesNo)

        Select Case result
            Case DialogResult.No
                Exit Sub
            Case DialogResult.Yes
                Dim leaveId = CInt(lbIdValue.Text)

                'Confirm Leave By Id
                Try
                    If con.State() <> 1 Then
                        con.Open()
                    End If

                    Dim sql = "UPDATE leave SET is_confirmed = 1 WHERE id = @id"
                    Using cmd As SqlCommand = New SqlCommand(sql, con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("@id", leaveId)
                        cmd.ExecuteNonQuery()

                        MessageBox.Show(Message.Message.successfully, Message.Title.notif, MessageBoxButtons.OK)
                    End Using

                    Me.Close()
                    myCallback.Invoke()
                Catch ex As Exception
                    MsgBox($"{ex.Message}")
                Finally
                    con.Close()
                End Try
        End Select
    End Sub
#End Region

#Region "FUNCTIONS"
    Public Sub SetCallback(callback As MyCallbackDelegate)
        myCallback = callback
    End Sub

    Private Sub ResetData()
        Dim empId As Integer = TempData(1)
        Dim empName As String = TempData(2)
        Dim index As Integer = cbEmpName.FindStringExact(empId & " - " & empName)

        lbIdValue.Text = TempData(0)
        lbEmpIdValue.Text = empId

        If index >= 0 Then
            cbEmpName.SelectedIndex = index
        Else
            cbEmpName.Text = empId & empName
        End If

        dtpFromDate.Value = TempData(3)
        rtxtReason.Text = TempData(4)
    End Sub

    Private Sub EnableOrDisableSaveButton()
        If lbEmpIdValue.Text = TempData(1).ToString() AndAlso
           dtpFromDate.Value = TempData(3) AndAlso
           rtxtReason.Text.Trim() = TempData(4) Then
            btnSave.Enabled = False 'Disable Save button
        Else
            btnSave.Enabled = True 'Enable Save button
        End If
    End Sub

    Private Sub Load_cbEmpName()
        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            'Load Employees Data To Combobox
            Dim Sql = "Select id, name from Employees"
            Using cmd As SqlCommand = New SqlCommand(Sql, con)
                cmd.CommandType = CommandType.Text
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read
                    cbEmpName.Items.Add(New DictionaryEntry(CInt(reader("id").ToString()), reader("id").ToString() & " - " & reader("name").ToString()))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, Message.Title.error, MessageBoxButtons.OK)
        Finally
            con.Close()
        End Try
    End Sub
#End Region
End Class