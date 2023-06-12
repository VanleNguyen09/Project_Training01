﻿Imports System.Data.SqlClient

Imports System.IO
Imports Guna.UI2.WinForms

Public Class frm_Employee
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

    Private Class Selected_Employees
        Public id As Integer = 0
        Public name As String = ""
        Public img As Image = Nothing

        Public phone As String = ""
        Public address As String = ""
        Public gender As String = ""
        Public birthday As Date = Date.Now()
        Public email As String = ""
        Public Sub New()
        End Sub

    End Class

    Private selectedEmployees As Selected_Employees = New Selected_Employees()

    Dim currentPage As Integer = 1

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomElements.AddClearButtonInsideTextBox(txt_Search, "pbCloseSearch", Sub()
                                                                                    txt_Search.Text = ""
                                                                                    gbtn_Search.PerformClick()
                                                                                End Sub)
        dtp_Birthday.Value = dtp_Birthday.Value.AddYears(-18)
        GlobalVariables.lblPage = lbl_Page
        rdo_Female.Text = "Female"
        rdo_Male.Text = "Male"
        rdo_Male.Checked = True
        rdo_Female.Checked = False
        EnableAdd()
        txt_EmployeeID.Enabled = False
        gbtn_Reset.Enabled = False
        dgrv_Employee.ClearSelection()
        LoadData()
    End Sub

    Public Enum EmployeeParameters
        Name
        Phone
        Address
        Gender
        Birthday
        Email
        Image
        Id
    End Enum

    Private Function CheckEmployeeExit(ByVal name As String, ByVal phone As String) As Boolean
        CheckEmployeeExit = False

        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckEmployeeExit", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@phone", phone)
                cmd.ExecuteNonQuery()

                Dim isExited As Integer = 0
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        isExited = CInt(reader("ReturnValue"))
                    End If
                End Using

                If isExited = 1 Then
                    CheckEmployeeExit = True
                End If
            End Using
        Catch ex As Exception
            CheckEmployeeExit = False
            MessageBox.Show("error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Return CheckEmployeeExit
    End Function

    Private Function CheckEmployeeExitForUpdate(ByVal name As String, ByVal phone As String, ByVal id As Integer) As Boolean
        CheckEmployeeExitForUpdate = False

        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckEmployeeExitForUpdate", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@phone", phone)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()

                Dim isExited As Integer = 0
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        isExited = CInt(reader("ReturnValue"))
                    End If
                End Using

                If isExited = 1 Then
                    CheckEmployeeExitForUpdate = True
                End If
            End Using
        Catch ex As Exception
            CheckEmployeeExitForUpdate = False
            MessageBox.Show("error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Return CheckEmployeeExitForUpdate
    End Function

    Public Sub Add_Employees(ByVal values As Dictionary(Of EmployeeParameters, Object))
        Dim status As Integer = 1
        Dim name As String = values(EmployeeParameters.Name)
        Dim phone As String = values(EmployeeParameters.Phone)

        If CheckEmployeeExit(name, phone) Then
            MessageBox.Show(Message.Message.employeeDuplicate, titleMsgBox, buttons, icons)
            Exit Sub
        Else
            If con.State <> 1 Then
                con.Open()
            End If

            Try
                Using cmd As SqlCommand = New SqlCommand("InsertEmployees", con)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@phone", phone)
                    cmd.Parameters.AddWithValue("@address", values(EmployeeParameters.Address))
                    cmd.Parameters.AddWithValue("@gender", If((values(EmployeeParameters.Gender) = "Male"), True, False))
                    cmd.Parameters.AddWithValue("@birthday", values(EmployeeParameters.Birthday))
                    cmd.Parameters.AddWithValue("@email", values(EmployeeParameters.Address))
                    cmd.Parameters.AddWithValue("@image", values(EmployeeParameters.Image))
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Employee has been added successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                End Using
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If

    End Sub

    Public Sub Update_Employee(ByVal values As Dictionary(Of EmployeeParameters, Object))
        Dim status As Integer = 1
        Dim name As String = values(EmployeeParameters.Name)
        Dim phone As String = values(EmployeeParameters.Phone)
        Dim id As Integer = CInt(values(EmployeeParameters.Id))


        If CheckEmployeeExitForUpdate(name, phone, id) Then
            MessageBox.Show(Message.Message.employeeDuplicate, titleMsgBox, buttons, icons)
            Exit Sub
        Else
            If con.State <> 1 Then
                con.Open()
            End If

            Try
                Using cmd As SqlCommand = New SqlCommand("UpdateEmployees", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@phone", phone)
                    cmd.Parameters.AddWithValue("@address", values(EmployeeParameters.Address))
                    cmd.Parameters.AddWithValue("@gender", If((values(EmployeeParameters.Gender) = "Male"), True, False))
                    cmd.Parameters.AddWithValue("@birthday", values(EmployeeParameters.Birthday))
                    cmd.Parameters.AddWithValue("@email", values(EmployeeParameters.Email))
                    cmd.Parameters.AddWithValue("@image", values(EmployeeParameters.Image))
                    cmd.Parameters.AddWithValue("@id", id)

                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Employee has been updated successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                End Using
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Public Sub Delete_Employee(ByVal id As Integer)
            If con.State <> 1 Then
                con.Open()
            End If
            Try
                Using cmd As SqlCommand = New SqlCommand("DeleteEmployee", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()

                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        End Sub

        Public Sub ShowEmployee(ByVal No As Integer, ByVal reader As SqlDataReader)
            Dim id As Integer = Convert.ToInt32(reader("id").ToString())
            Dim name As String = reader("name").ToString()
            Dim img As Image = Nothing

            If reader("image").ToString() <> String.Empty Then
                Dim bytes As Byte() = CType(reader("image"), Byte())
                If bytes IsNot Nothing AndAlso bytes.Length > 0 Then
                    Try
                        img = Image.FromStream(New MemoryStream(bytes))
                    Catch ex As Exception
                        Console.WriteLine("Error creating image: " & ex.Message)
                    End Try
                Else
                    Console.WriteLine("Invalid or empty image data")
                End If
            End If

            Dim phone As String = reader("phone").ToString()
            Dim address As String = reader("address").ToString()
            Dim gender As String = reader("gender").ToString()
            Dim birthday As String = reader("birthday").ToString()
            Dim email As String = reader("email").ToString()
            Dim status As Integer = Convert.ToInt32(reader("status").ToString())
            dgrv_Employee.Rows.Add(No, id, name, img, phone, address, gender, birthday, email, status)
        End Sub

        Public Sub LoadData()
            If con.State <> 1 Then
                con.Open()
            End If
            dgrv_Employee.Rows.Clear()
            Using cmd As SqlCommand = New SqlCommand("GetAllEmployees", con)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                Dim No As Integer = 1
                While reader.Read()
                    ShowEmployee(No, reader)
                    No += 1
                End While
                con.Close()
            End Using

            Pagination.PaginateDataGridView(dgrv_Employee, 1)
        End Sub

        Private Sub EnableAdd()
            gbtn_Add.Enabled = True
            gbtn_Update.Enabled = False
            gbtn_Delete.Enabled = False
        gbtn_Reset.Enabled = False
    End Sub

    Private Sub DisableAdd()
        gbtn_Add.Enabled = False
        gbtn_Update.Enabled = True
        gbtn_Delete.Enabled = True
        gbtn_Reset.Enabled = True
    End Sub

    Private Sub ClearForm()
            txt_Name.Text = String.Empty
            txt_Address.Text = String.Empty
            txt_Phone.Text = String.Empty
            txt_EmployeeID.Text = String.Empty
            txt_Email.Text = String.Empty
            rdo_Male.Checked = True
            rdo_Female.Checked = False
            dtp_Birthday.Value = Date.Now()
            ptb_Employee.Image = Nothing
            dgrv_Employee.ClearSelection()
        End Sub

        Dim titleMsgBox As String = "notification"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
        Dim icons As MessageBoxIcon = MessageBoxIcon.Warning

        Private Sub SearchEmployeesByKeyword(ByVal keyword As String)
            If con.State <> 1 Then
                con.Open()
            End If

            dgrv_Employee.Rows.Clear()
            Dim reload = False
            Using cmd As SqlCommand = New SqlCommand("GetEmployeesByKeyWord", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@keyword", keyword)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Dim No As Integer = 1
                        While reader.Read()
                            ShowEmployee(No, reader)
                            No += 1
                        End While
                    Else
                        MessageBox.Show(Message.Message.errorInvalidSearch, titleMsgBox, buttons, icons)
                        reload = True
                    End If
                End Using
            End Using
            con.Close()
            If reload Then
                txt_Search.Text = Nothing
                LoadData()
            End If
        End Sub

    Private Sub gbtn_Add_Click(sender As Object, e As EventArgs) Handles gbtn_Add.Click
        Dim name As String = txt_Name.Text.Trim()
        Dim phone As String = txt_Phone.Text.Trim()
        Dim address As String = txt_Address.Text.Trim()
        Dim gender As String


        If rdo_Male.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
            MsgBox("your gender is" & gender)
        End If
        Dim birthday As Date = dtp_Birthday.Value
        Dim email As String = txt_Email.Text.Trim()

        If String.IsNullOrEmpty(name) OrElse
                String.IsNullOrEmpty(phone) OrElse
                String.IsNullOrEmpty(address) OrElse
                String.IsNullOrEmpty(gender) OrElse
                String.IsNullOrEmpty(email) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleMsgBox, buttons, icons)
            Return
        End If

        If Not FuntionCommon.Validation.IsEmail(email) Then
            MessageBox.Show(Message.Message.emailInvalidMessage, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        If Not FuntionCommon.Validation.ValidatePhone(phone) Then
            MessageBox.Show(Message.Message.phoneInvalidMessage, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        Dim inputYear As Integer = birthday.Year
        Dim currentYear As Integer = DateTime.Now.Year

        Dim isValid As Boolean = FuntionCommon.Validation.ValidateYear(inputYear, currentYear)

        If Not isValid Then
            MessageBox.Show(Message.Message.yearInvalidError, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        Dim img As Byte() = ImageToByte(ptb_Employee.Image)
        If imageSelected = False Then
            MessageBox.Show(Message.Message.imageEmptyError, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        Dim values As New Dictionary(Of EmployeeParameters, Object)
        values.Add(EmployeeParameters.Name, name)
        values.Add(EmployeeParameters.Phone, phone)
        values.Add(EmployeeParameters.Address, address)
        values.Add(EmployeeParameters.Gender, gender)
        values.Add(EmployeeParameters.Birthday, birthday)
        values.Add(EmployeeParameters.Email, email)
        values.Add(EmployeeParameters.Image, img)


        Add_Employees(values)
        ClearForm()
    End Sub

    Private Sub gbtn_Update_Click(sender As Object, e As EventArgs) Handles gbtn_Update.Click
        Dim id As Integer = Convert.ToInt32(txt_EmployeeID.Text)
        Dim name As String = txt_Name.Text.Trim()
        Dim phone As String = txt_Phone.Text.Trim()
        Dim address As String = txt_Address.Text.Trim()
        Dim gender As String

        If rdo_Male.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
            MsgBox("your gender is" & gender)
        End If
        Dim birthday As Date = dtp_Birthday.Value
        Dim email As String = txt_Email.Text.Trim()


        If String.IsNullOrEmpty(name) OrElse
                String.IsNullOrEmpty(phone) OrElse
                String.IsNullOrEmpty(address) OrElse
                String.IsNullOrEmpty(gender) OrElse
                String.IsNullOrEmpty(email) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleMsgBox, buttons, icons)
            Return
        End If

        If Not FuntionCommon.Validation.IsEmail(email) Then
            MessageBox.Show(Message.Message.emailInvalidMessage, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        If Not FuntionCommon.Validation.ValidatePhone(phone) Then
            MessageBox.Show(Message.Message.phoneInvalidMessage, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        Dim inputYear As Integer = birthday.Year
        Dim currentYear As Integer = DateTime.Now.Year

        Dim isValid As Boolean = FuntionCommon.Validation.ValidateYear(inputYear, currentYear)

        If Not isValid Then
            MessageBox.Show(Message.Message.yearInvalidError, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        Dim img As Byte() = ImageToByte(ptb_Employee.Image)


        Dim values As New Dictionary(Of EmployeeParameters, Object)
        values.Add(EmployeeParameters.Name, name)
        values.Add(EmployeeParameters.Phone, phone)
        values.Add(EmployeeParameters.Address, address)
        values.Add(EmployeeParameters.Gender, gender)
        values.Add(EmployeeParameters.Birthday, birthday)
        values.Add(EmployeeParameters.Email, email)
        values.Add(EmployeeParameters.Image, img)
        values.Add(EmployeeParameters.Id, id)

        Update_Employee(values)
        EnableAdd()
        ClearForm()
    End Sub

    Private Sub dgrv_employee_cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrv_Employee.CellClick

        If e.RowIndex >= 0 Then
            DisableAdd()
            Dim selectedrow = dgrv_Employee.Rows(e.RowIndex)
            txt_EmployeeID.Text = selectedrow.Cells("employeeid").Value.ToString()
            selectedEmployees.id = txt_EmployeeID.Text
            txt_EmployeeID.ReadOnly = True
            txt_Name.Text = selectedrow.Cells("employeename").Value.ToString()
            selectedEmployees.name = txt_Name.Text
            txt_Phone.Text = selectedrow.Cells("phone").Value.ToString()
            selectedEmployees.phone = txt_Phone.Text
            txt_Email.Text = selectedrow.Cells("email").Value.ToString()
            selectedEmployees.email = txt_Email.Text
            dgrv_Employee.ReadOnly = True

            Dim cellValue As Object = selectedrow.Cells("images").Value
            selectedEmployees.img = cellValue
            If TypeOf cellValue Is Image Then
                Dim image As Image = DirectCast(cellValue, Image)
                ptb_Employee.Image = image
            Else
                ptb_Employee.Image = Nothing
            End If
            txt_Address.Text = selectedrow.Cells("address").Value.ToString()
            selectedEmployees.address = txt_Address.Text
            Dim gender = selectedrow.Cells("gender")
            If CBool(gender.Value) = True Then
                rdo_Male.Checked = True
            Else
                rdo_Female.Checked = True
            End If
            selectedEmployees.gender = CBool(gender.Value)
            dtp_Birthday.Value = Convert.ToDateTime(selectedrow.Cells("birthday").Value)
            selectedEmployees.birthday = dtp_Birthday.Value
        End If
    End Sub

    Private Sub gbtn_Delete_Click(sender As Object, e As EventArgs) Handles gbtn_Delete.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgrv_Employee.SelectedRows
        Dim employeeIdColumn As DataGridViewColumn = dgrv_Employee.Columns("EmployeeID") ' Replace "name" with the actual column name for department ID

        If selectedRows.Count > 0 AndAlso MessageBox.Show("Are you sure you want to delete the selected employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If employeeIdColumn IsNot Nothing Then
                MessageBox.Show("Employee has been deleted successfully!!!", "Success", buttons, MessageBoxIcon.Information)
                For i As Integer = 0 To selectedRows.Count - 1
                    Dim selectedRow As DataGridViewRow = selectedRows(i)
                    Dim id As Integer = CInt(selectedRow.Cells(employeeIdColumn.Index).Value)
                    Delete_Employee(id)
                Next
                LoadData()
                ClearForm()
                EnableAdd()
            Else
                MessageBox.Show("Unable to find the employee ID column.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Deletion canceled.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txt_Phone_TextChanged(sender As Object, e As EventArgs) Handles txt_Phone.TextChanged
        Dim phone As String = txt_Phone.Text
        If FuntionCommon.Validation.ValidatePhone(phone) Then
            txt_Address.Focus()
        End If
    End Sub

    Private imageSelected As Boolean = False
    Private Sub gbtn_Upload_Click(sender As Object, e As EventArgs) Handles gbtn_Upload.Click
        Dim open As New OpenFileDialog()
        open.Title = "Please select an image you want!!!"
        open.Filter = "Image File|*.jpg;*.jpeg;*.png;*.gif"
        If open.ShowDialog() = DialogResult.OK Then
            Dim selectedImage As String = open.FileName
            ptb_Employee.Image = Image.FromFile(selectedImage)
            imageSelected = True
        End If
    End Sub

    Public Function ImageToByte(ByVal img As Image) As Byte()
        If img Is Nothing Then
            Return New Byte(-1) {}
        End If
        Dim byteArray As Byte() = New Byte(-1) {}
        Using stream As New MemoryStream()
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
            stream.Close()
            byteArray = stream.ToArray()
        End Using
        Return byteArray
    End Function

    Private Sub gbtn_Search_Click(sender As Object, e As EventArgs) Handles gbtn_Search.Click
        Dim keyword As String = txt_Search.Text.Trim()
        If Not String.IsNullOrEmpty(keyword) Then
            SearchEmployeesByKeyword(keyword)
        Else
            MessageBox.Show(Message.Message.emptyDataSearchMessage, titleMsgBox, buttons, icons)
        End If
    End Sub
    Private Sub gbtn_Reset_Click(sender As Object, e As EventArgs) Handles gbtn_Reset.Click
        txt_EmployeeID.Text = selectedEmployees.id
        txt_Name.Text = selectedEmployees.name
        txt_Phone.Text = selectedEmployees.phone
        ptb_Employee.Image = selectedEmployees.img

        dtp_Birthday.Value = selectedEmployees.birthday
        txt_Address.Text = selectedEmployees.address
        If selectedEmployees.gender Then
            rdo_Male.Checked = True
        Else
            rdo_Female.Checked = True
        End If
        txt_Email.Text = selectedEmployees.email
    End Sub

    Private Sub gbtn_Clear_Click(sender As Object, e As EventArgs) Handles gbtn_Clear.Click
        ClearForm()
        EnableAdd()
    End Sub

    Private Sub txt_Name_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Name.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txt_Phone.Focus()
        End If
    End Sub

    Private Sub txt_Phone_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Phone.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txt_Address.Focus()
        End If
    End Sub

    Private Sub txt_Address_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Address.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            rdo_Male.Focus()
        End If
    End Sub

    Private Sub rdo_male_keydown(sender As Object, e As KeyEventArgs) Handles rdo_Male.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            rdo_Female.Focus()
        End If
    End Sub

    Private Sub rdo_female_keydown(sender As Object, e As KeyEventArgs) Handles rdo_Female.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dtp_Birthday.Focus()
        End If
    End Sub

    Private Sub dtp_Birthday_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_Birthday.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txt_Email.Focus()
        End If
    End Sub

    Private Sub txt_Email_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Email.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If gbtn_Add.Enabled = True Then
                gbtn_Add.Focus()
            Else
                gbtn_Update.Focus()
            End If
        End If
    End Sub

    Private Sub gbtn_EmpDept_Click(sender As Object, e As EventArgs) Handles gbtn_EmpDept.Click
        Me.Close()
        Dim empDept As New frm_EmpInDept
        empDept.Show()
    End Sub

    Private Sub frm_Employee_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgrv_Employee.ClearSelection()
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        txt_Search.Controls("pbCloseSearch").Visible = (txt_Search.Text.Length > 0)
    End Sub

    Private Sub ptb_Previous_Click(sender As Object, e As EventArgs) Handles ptb_Previous.Click
        If currentPage > 1 Then
            currentPage -= 1
            Pagination.PaginateDataGridView(dgrv_Employee, currentPage)
        End If
    End Sub

    Private Sub ptb_Next_Click(sender As Object, e As EventArgs) Handles ptb_Next.Click
        Dim totalRows As Integer = dgrv_Employee.Rows.Count
        Dim pageSize As Integer = 10
        Dim totalPages As Integer = Math.Ceiling(totalRows / pageSize)

        If currentPage < totalPages Then
            currentPage += 1
            Pagination.PaginateDataGridView(dgrv_Employee, currentPage)
        End If
    End Sub
End Class