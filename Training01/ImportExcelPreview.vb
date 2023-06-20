Imports System.Data.SqlClient

Public Class ImportExcelPreview
    Private Datas As DataTable
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Public CallBack As Action

#Region "EVENTS"
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnChooseFile_Click(sender As Object, e As EventArgs) Handles btnChooseFile.Click
        Datas = FuntionCommon.CommonOfficeFunctions.ImportFromExcel()

        ' check column in DataTable and DataGridView are matched?
        Dim columnsMatch As Boolean = False
        Dim dataColumnName As String
        Dim dgvColumnName As String
        Dim headerDGVName As String

        For i As Integer = 0 To Datas.Columns.Count - 1
            dataColumnName = Datas.Columns(i).ColumnName
            dgvColumnName = dgv.Columns(i).Name
            headerDGVName = dgv.Columns(i).HeaderText

            If String.Equals(dataColumnName, dgvColumnName, StringComparison.OrdinalIgnoreCase) OrElse
                String.Equals(dataColumnName, headerDGVName, StringComparison.OrdinalIgnoreCase) Then
                columnsMatch = True
            Else
                columnsMatch = False
                Exit For
            End If
        Next

        If columnsMatch Then
            dgv.Columns("stt").DataPropertyName = Datas.Columns(0).ColumnName
            dgv.Columns("id").DataPropertyName = Datas.Columns(1).ColumnName
            dgv.Columns("emp_name").DataPropertyName = Datas.Columns(2).ColumnName
            dgv.Columns("phone").DataPropertyName = Datas.Columns(3).ColumnName
            dgv.Columns("birthday").DataPropertyName = Datas.Columns(4).ColumnName
            dgv.Columns("email").DataPropertyName = Datas.Columns(5).ColumnName
            dgv.Columns("salary_name").DataPropertyName = Datas.Columns(6).ColumnName
            dgv.Columns("salary").DataPropertyName = Datas.Columns(7).ColumnName

            dgv.DataSource = Datas
        Else
            MessageBox.Show("The columns in the Excel file do not match the columns in the DataGridView.")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If con.State() <> 1 Then
                con.Open()
            End If

            Dim sql = "UpdateSalariesByExcelFile"
            For Each row As DataRow In Datas.Rows
                Using cmd As SqlCommand = New SqlCommand(sql, con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@emp_id", row("ID"))
                    cmd.Parameters.AddWithValue("@emp_name", row("NAME"))
                    cmd.Parameters.AddWithValue("@salary_name", If(row("SALARY_NAME") Is Nothing, DBNull.Value, row("SALARY_NAME")))
                    cmd.Parameters.AddWithValue("@salary", If(row("SALARY") Is Nothing, DBNull.Value, row("SALARY")))

                    cmd.ExecuteNonQuery()
                End Using
            Next
        Catch ex As Exception
            MsgBox($"SAVED ERROR: {ex.Message}")
            Exit Sub
        Finally
            con.Close()
        End Try

        Me.Close()
        CallBack()
    End Sub
#End Region

End Class