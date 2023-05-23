Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class frm_Department

    Private Class Selected_Departments
        Public id As Integer = 0
        Public name As String = ""

        Public Sub New()
        End Sub
    End Class

    Private Sub frm_Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_TitleDepartment.BackColor = Color.Transparent
        lbl_Name.BackColor = Color.Transparent
        lbl_Search.BackColor = Color.Transparent
        btn_Update.Enabled = False
        btn_Delete.Enabled = False
        txt_DepartmentID.Enabled = False

        LoadData()
    End Sub

    Private selectedDepartment As Selected_Departments = New Selected_Departments()

    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())


    Public Sub ShowDepartment(ByVal reader As SqlDataReader)
        Dim id As Integer = Convert.ToInt32(reader("id"))
        Dim name As String = reader("name").ToString()

        dgrv_Department.Rows.Add(id, name)
    End Sub

    Public Sub LoadData()
        If con.State <> 1 Then
            con.Open()
        End If
        dgrv_Department.Rows.Clear()
        Using cmd As SqlCommand = New SqlCommand("GetAllDepartments", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ShowDepartment(reader)
            End While
            con.Close()
        End Using
    End Sub

    Private Sub EnableAdd()
        btn_Add.Enabled = True
        btn_Update.Enabled = False
        btn_Delete.Enabled = False
    End Sub

    Private Sub DisableAdd()
        btn_Add.Enabled = False
        btn_Update.Enabled = True
        btn_Delete.Enabled = True
    End Sub
    Private Sub ClearForm()
        txt_Name.Text = String.Empty
        txt_DepartmentID.Text = String.Empty
    End Sub

    Dim titleMsgBox As String = "notification"
    Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
    Dim icons As MessageBoxIcon = MessageBoxIcon.Warning


    Public Sub Update_Department(name As String, id As Integer)
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("UpdateDepartments", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@id", id)

                cmd.ExecuteNonQuery()
                'Load lại data lúc add xong
                LoadData()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Add_Department(name As String)
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("InsertDepartments", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", name)

                cmd.ExecuteNonQuery()
                'Load lại data lúc add xong
                LoadData()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchDepartmentsByKeyword(keyword As String)
        Console.WriteLine(keyword)
        If con.State <> 1 Then
            con.Open()
        End If

        dgrv_Department.Rows.Clear()
        Using cmd As SqlCommand = New SqlCommand("GetDepartmentsByKeyWord", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@keyword", keyword)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ShowDepartment(reader)
                    End While
                Else
                    MessageBox.Show(Message.Message.errorInvalidSearch, titleMsgBox, buttons, icons)
                End If
            End Using
        End Using
        con.Close()
    End Sub

    Public Sub Delete_Department(id As Integer)
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("DeleteDepartment", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)

                cmd.ExecuteNonQuery()
                LoadData()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim name As String = txt_Name.Text

        If String.IsNullOrEmpty(name) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleMsgBox, buttons, icons)
            Return
        End If

        Add_Department(name)
        ClearForm()
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Dim name As String = txt_Name.Text
        Dim id As Integer = CInt(txt_DepartmentID.Text)

        If String.IsNullOrEmpty(name) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleMsgBox, buttons, icons)
            Return
        End If

        Update_Department(name, id)
        EnableAdd()
        ClearForm()
    End Sub

    Private Sub dgrv_Department_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrv_Department.CellClick
        If e.RowIndex >= 0 Then
            DisableAdd()
            Dim selectedRow = dgrv_Department.Rows(e.RowIndex)
            txt_DepartmentID.Text = selectedRow.Cells("department_id").Value.ToString()
            selectedDepartment.id = txt_DepartmentID.Text
            txt_Name.Text = selectedRow.Cells("department_name").Value.ToString()
            selectedDepartment.name = txt_Name.Text
        End If
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Dim id As Integer = CInt(txt_DepartmentID.Text)
        Dim selectedRows As DataGridViewSelectedRowCollection = dgrv_Department.SelectedRows

        If selectedRows.Count >= 0 AndAlso MessageBox.Show("Are you sure you want to delete the selected department? Employee involved will also be deleted", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For Each selectedRow As DataGridViewRow In selectedRows
                dgrv_Department.Rows.Remove(selectedRow)
            Next
            Delete_Department(id)
            ClearForm()
            EnableAdd()
        Else
            MessageBox.Show("Deletion canceled.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Hide()
        Dim dashboard As New Dashboard
        dashboard.Show()
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        txt_DepartmentID.Text = selectedDepartment.id
        txt_Name.Text = selectedDepartment.name
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        ClearForm()
        EnableAdd()
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim keyword As String = txt_Search.Text.Trim
        If Not String.IsNullOrEmpty(keyword) Then
            SearchDepartmentsByKeyword(keyword)
        Else
            MessageBox.Show(Message.Message.emptyDataSearchMessage, titleMsgBox, buttons, icons)
        End If
    End Sub

    Private Sub ptb_Icon_Click(sender As Object, e As EventArgs) Handles ptb_Icon.Click
        Me.Hide()
        Dim dashboard As New Dashboard
        dashboard.Show()
    End Sub
End Class