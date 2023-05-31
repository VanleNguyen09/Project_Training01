Imports System.Data.SqlClient

Public Class Position
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Private beforeEdit As ValueTuple(Of Integer, String)

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles appClose.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Dim pMenu As New PositionMenu
        pMenu.Show()
    End Sub

    Private Sub Position_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_DGVPosition()
        Dim btn As New DataGridViewButtonColumn
        btn.HeaderText = ""
        btn.Text = "DELETE"
        btn.Name = "btnDelete"
        btn.UseColumnTextForButtonValue = True
        dgvPositions.Columns.Insert(dgvPositions.Columns.Count, btn)
    End Sub

    Private Sub Load_DGVPosition()
        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            Dim sql = "SearchAllPositions"
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("text", txtSearch.Text.Trim())
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                dgvPositions.Rows.Clear()
                While reader.Read
                    dgvPositions.Rows.Add({reader("stt"), reader("id"), reader("name"), reader("emp_num")})
                End While

                'Remove selected cell
                dgvPositions.CurrentCell = Nothing
            End Using
        Catch ex As Exception
            MsgBox($"ERROR Load DGVPosition: {ex.Message}")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Load_DGVPosition()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            Dim sql = "InsertPosition"
            Using cmd As SqlCommand = New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("name", txtPosName.Text.Trim())
                cmd.ExecuteNonQuery()

                MessageBox.Show(Message.Message.successfully, Message.Title.success, MessageBoxButtons.OK)
                Load_DGVPosition()
            End Using
        Catch ex As Exception
            MsgBox($"{ex.Message}")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dgvPositions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPositions.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            'Confirm Delete
            Dim result As DialogResult = MessageBox.Show(Message.Message.confirmedDelete + " The employees involved will be deleted", Message.Title.notif, MessageBoxButtons.YesNo)

            Select Case result
                Case DialogResult.No
                    Exit Sub
                Case DialogResult.Yes
                    Dim posId = CInt(dgvPositions.Rows(e.RowIndex).Cells("id").Value)

                    'Delete Position By Id
                    Try
                        If con.State() <> 1 Then
                            con.Open()
                        End If

                        Dim sql = "DeletePositionById"
                        Using cmd As SqlCommand = New SqlCommand(sql, con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("pos_id", posId)
                            cmd.ExecuteNonQuery()

                            MessageBox.Show(Message.Message.successfully, Message.Title.notif, MessageBoxButtons.OK)
                            Load_DGVPosition()
                        End Using
                    Catch ex As Exception
                        MsgBox($"{ex.Message}")
                    Finally
                        con.Close()
                    End Try
            End Select
        End If
    End Sub

    Private Sub btnEmpByPos_Click(sender As Object, e As EventArgs) Handles btnEmpByPos.Click
        Dim empByPos As New EmpByPos
        empByPos.Show()
        Me.Hide()
    End Sub

    Private Sub dgvPositions_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPositions.CellEndEdit
        ' Lấy row đang được chỉnh sửa
        Dim editedRow As DataGridViewRow = dgvPositions.Rows(e.RowIndex)
        Dim posId As Integer = editedRow.Cells("id").Value
        Dim editedName As String = editedRow.Cells("pos_name").Value

        If (beforeEdit.Item2 = editedName) Then
            Load_DGVPosition()
            Exit Sub
        Else
            'Confirm Update All
            Dim result As DialogResult = MessageBox.Show(Message.Message.confirmedUpdate + " The employees involved will be updated!", Message.Title.notif, MessageBoxButtons.YesNo)

            Select Case result
                Case DialogResult.No
                    Load_DGVPosition()
                    Exit Sub
                Case DialogResult.Yes
                    Dim sql = "UpdatePositionById"

                    'Update Position By Id
                    Try
                        If con.State() <> 1 Then
                            con.Open()
                        End If

                        Using cmd As SqlCommand = New SqlCommand(sql, con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("pos_id", posId)
                            cmd.Parameters.AddWithValue("name", editedName)
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        MsgBox($"{ex.Message}")
                        Exit Sub
                    Finally
                        con.Close()
                        Load_DGVPosition()
                    End Try

                    MessageBox.Show(Message.Message.successfully, Message.Title.notif, MessageBoxButtons.OK)
            End Select
        End If
    End Sub

    Private Sub dgvPositions_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvPositions.CellBeginEdit
        beforeEdit.Item1 = dgvPositions.Rows(e.RowIndex).Cells("id").Value
        beforeEdit.Item2 = dgvPositions.Rows(e.RowIndex).Cells("pos_name").Value.Trim()
    End Sub

    Private Sub dgvPositions_Sorted(sender As Object, e As EventArgs) Handles dgvPositions.Sorted
        'If it is stt column, sorted normal, and stt is not sorted
        If dgvPositions.SortedColumn.Name <> "stt" Then
            For i As Integer = 0 To dgvPositions.Rows.Count - 1
                dgvPositions.Rows(i).Cells("stt").Value = (i + 1).ToString()
            Next
        End If
    End Sub
End Class