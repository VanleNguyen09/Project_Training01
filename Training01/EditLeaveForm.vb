Imports System.Data.SqlClient

Public Class EditLeaveForm
    Public Delegate Sub MyCallbackDelegate()
    Private myCallback As MyCallbackDelegate
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    'id, emp_id, name, from_date, reason
    Public Property TempData() As ValueTuple(Of Integer, Integer, String, Date, String)

    Public Sub SetCallback(callback As MyCallbackDelegate)
        myCallback = callback
    End Sub

    Private daTFormat As String = DTFormat.Type.NormalDatetime

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Me.Close()
    End Sub

    Private Sub EditLeaveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Settings for Combobox
        cbEmpName.DisplayMember = "Value"
        cbEmpName.ValueMember = "Key"

        Load_cbEmpName()
        ResetData()

        'Set Format
        dtpFromDate.Format = DateTimePickerFormat.Custom
        dtpFromDate.CustomFormat = daTFormat
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Close()
        myCallback.Invoke()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetData()
    End Sub

    Private Sub ResetData()
        Dim empId As Integer = TempData.Item2
        Dim empName As String = TempData.Item3
        Dim index As Integer = cbEmpName.FindStringExact(empId & " - " & empName)

        lbIdValue.Text = TempData.Item1
        lbEmpIdValue.Text = empId

        If index >= 0 Then
            cbEmpName.SelectedIndex = index
        Else
            cbEmpName.Text = "None"
        End If

        dtpFromDate.Value = TempData.Item4
        rtxtReason.Text = TempData.Item5
    End Sub

    Private Sub rtxtReason_TextChanged(sender As Object, e As EventArgs) Handles rtxtReason.TextChanged
        EnableOrDisableSaveButton()
    End Sub

    Private Sub EnableOrDisableSaveButton()
        If lbEmpIdValue.Text = TempData.Item2.ToString() AndAlso
           cbEmpName.Text = TempData.Item3 AndAlso
           dtpFromDate.Value = TempData.Item4 AndAlso
           rtxtReason.Text.Trim() = TempData.Item5 Then
            btnSave.Enabled = False 'Disable Save button
        Else
            btnSave.Enabled = True 'Enable Save button
        End If
    End Sub

    Private Sub cbEmpName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpName.SelectedIndexChanged
        EnableOrDisableSaveButton()
    End Sub

    Private Sub dtpFromDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpFromDate.ValueChanged
        EnableOrDisableSaveButton()
    End Sub

    Private Sub lbEmpIdValue_Click(sender As Object, e As EventArgs) Handles lbEmpIdValue.Click
        cbEmpName.Select() 'Focus
    End Sub

    Private Sub Load_cbEmpName()
        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            'Load Employees Data To Combobox
            Dim Sql = "GetAllEmployees"
            Using cmd As SqlCommand = New SqlCommand(Sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read
                    cbEmpName.Items.Add(New DictionaryEntry(CInt(reader("id")), reader("id") & " - " & reader("name").ToString()))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, Message.Title.error, MessageBoxButtons.OK)
        Finally
            con.Close()
        End Try
    End Sub
End Class