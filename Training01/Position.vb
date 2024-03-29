﻿Imports System.Data.SqlClient

Public Class Position
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Dim DGVhasChanged As Boolean

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles appClose.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
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
        dgvPositions.Columns.Insert(2, btn)
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
                    dgvPositions.Rows.Add(New String() {reader("id"), reader("name")})
                End While
                DGVhasChanged = False
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
                    Dim posId = CInt(dgvPositions.Rows(e.RowIndex).Cells(0).Value)

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
        Me.Hide()
        Dim empByPos As New EmpByPos
        empByPos.Show()
    End Sub

    Private Sub btnUpdateAll_Click(sender As Object, e As EventArgs) Handles btnUpdateAll.Click
        If Not DGVhasChanged Then
            MessageBox.Show(Message.Message.nothingChange, Message.Title.notif, MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim posId As Integer
        Dim editedName As String

        'Confirm Update All
        Dim result As DialogResult = MessageBox.Show(Message.Message.confirmedUpdate + " The employees involved will be updated", Message.Title.notif, MessageBoxButtons.YesNo)

        Select Case result
            Case DialogResult.No
                Exit Sub
            Case DialogResult.Yes
                Dim sql = "UpdatePositionById"

                For i = 0 To dgvPositions.Rows.Count - 1
                    posId = dgvPositions.Rows(i).Cells(0).Value
                    editedName = dgvPositions.Rows(i).Cells(1).Value

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
                    End Try
                Next
                MessageBox.Show(Message.Message.successfully, Message.Title.notif, MessageBoxButtons.OK)
                Load_DGVPosition()
        End Select
    End Sub

    Private Sub dgvPositions_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPositions.CellValueChanged
        DGVhasChanged = True
    End Sub
End Class