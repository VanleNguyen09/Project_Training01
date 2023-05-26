Imports System.Data.SqlClient
Imports System.IO



Public Class frm_Employee

    Private Class ComboBoxItem
        Public displayvalue As String
        Public hiddenvalue As String

        Public Sub New(ByVal displayvalue As String, ByVal hiddenvalue As String)
            Me.displayvalue = displayvalue
            Me.hiddenvalue = hiddenvalue
        End Sub

        Public Overrides Function tostring() As String
            Return displayvalue
        End Function
    End Class

    Private Class Selected_Employees
        Public id As Integer = 0
        Public name As String = ""
        Public department_name As String = ""
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

    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_TitleEmployee.BackColor = Color.Transparent
        lbl_EmployeeID.BackColor = Color.Transparent
        lbl_Name.BackColor = Color.Transparent
        lbl_Phone.BackColor = Color.Transparent
        lbl_Gender.BackColor = Color.Transparent
        rdo_Female.BackColor = Color.Transparent
        rdo_Male.BackColor = Color.Transparent
        lbl_Email.BackColor = Color.Transparent
        lbl_Department.BackColor = Color.Transparent
        lbl_Department_Change.BackColor = Color.Transparent
        lbl_Address.BackColor = Color.Transparent
        lbl_Birthday.BackColor = Color.Transparent
        dtp_Birthday.Value = dtp_Birthday.Value.AddYears(-18)
        rdo_Female.Text = "Female"
        rdo_Male.Text = "Male"
        rdo_Male.Checked = True
        btn_Update.Enabled = False
        btn_Delete.Enabled = False
        txt_EmployeeID.Enabled = False

        Dim initialItem As ComboBoxItem = New ComboBoxItem("Select Department", "-1")
        cb_Department.Items.Add(initialItem)
        cb_Department_Change.Items.Add(initialItem)
        cb_Department.SelectedIndex = 0
        cb_Department_Change.SelectedIndex = 0
        Select_Departments()
        LoadAndSortData()
    End Sub

    Private Sub LoadAndSortData()
        LoadData()
        SortDataById()
    End Sub

    Private Function CheckEmployeeExit(ByVal phone As String) As Boolean
        CheckEmployeeExit = False
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckEmployeeExit", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@phone", phone)
                cmd.ExecuteNonQuery()
                Dim reader = cmd.ExecuteReader
                If reader.Read() Then
                    If reader("ReturnValue") = 1 Then CheckEmployeeExit = True
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


    Private Function CheckEmployeeExitForUpdate(ByVal phone As String, ByVal id As Integer) As Boolean
        CheckEmployeeExitForUpdate = False
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CheckEmployeeExitForUpdate", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@phone", phone)
                cmd.Parameters.AddWithValue("id", id)
                cmd.ExecuteNonQuery()
                Dim reader = cmd.ExecuteReader
                If reader.Read() Then
                    If reader("ReturnValue") = 1 Then CheckEmployeeExitForUpdate = True
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

    Public Sub Update_Employee(id As Integer, department_id As Integer, name As String, phone As String, address As String, gender As String, birthday As Date, email As String, img As Byte())
        If CheckEmployeeExitForUpdate(phone, id) = True Then
            MessageBox.Show(Message.Message.employeeExited, titleMsgBox, buttons, icons)
            Exit Sub
        End If
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("UpdateEmployees", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@phone", phone)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.Parameters.AddWithValue("@gender", If((gender = "Male"), True, False))
                cmd.Parameters.AddWithValue("@birthday", birthday)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@image", img)
                cmd.Parameters.AddWithValue("@department_id", department_id)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()

            End Using
            MessageBox.Show("Employee has been updated successfully!!!", "Success", buttons, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        LoadAndSortData()
    End Sub

    Public Sub Add_Employees(name As String, department_id As Integer, phone As String, address As String, gender As String, birthday As Date, email As String, img As Byte())
        Dim status As Integer = 1
        If CheckEmployeeExit(phone) = True Then
            MessageBox.Show(Message.Message.employeeExited, titleMsgBox, buttons, icons)
            Exit Sub
        End If
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("InsertEmployees", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@phone", phone)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.Parameters.AddWithValue("@gender", If((gender = "Male"), True, False))
                cmd.Parameters.AddWithValue("@birthday", birthday)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@image", img)
                cmd.Parameters.AddWithValue("@department_id", department_id)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.ExecuteNonQuery()
                'Load lại data lúc add xong
                LoadAndSortData()
            End Using
            MessageBox.Show("Employee has been added successfully!!!", "Success", buttons, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MakeButtonBackgroundBlurry(button As Button)
        Dim originalColor As Color = button.BackColor
        Dim blurredColor As Color = ControlPaint.Light(originalColor, 0.5)
        button.BackColor = blurredColor
    End Sub

    Public Sub Delete_Employee(id As Integer)
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("DeleteEmployee", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()

            End Using
            MessageBox.Show("Employee has been deleted successfully!!!", "Success", buttons, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        LoadAndSortData()
    End Sub

    Public Sub SortDataById()
        dgrv_Employee.Sort(dgrv_Employee.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Public Sub ShowEmployee(ByVal No As Integer, ByVal reader As SqlDataReader)
        Dim id As Integer = Convert.ToInt32(reader("id"))
        Dim name As String = reader("name").ToString()
        Dim department_name As String = reader("department_name").ToString()
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
        Dim status As Integer = Convert.ToInt32(reader("status"))
        dgrv_Employee.Rows.Add(No, id, department_name, name, img, phone, address, gender, birthday, email, status)
    End Sub

    Public Sub LoadData()
        If con.State <> 1 Then
            con.Open()
        End If
        dgrv_Employee.Rows.Clear()
        Using cmd As SqlCommand = New SqlCommand("GetAllEmployeesByDepartment", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim No As Integer = 1
            While reader.Read()
                ShowEmployee(No, reader)
                No = No + 1
            End While
            con.Close()
        End Using
    End Sub

    Private Sub EnableAdd()
        btn_Add.Enabled = True
        btn_Update.Enabled = False
        btn_Delete.Enabled = False
        MakeButtonBackgroundBlurry(btn_Update)
        MakeButtonBackgroundBlurry(btn_Delete)
    End Sub

    Private Sub DisableAdd()
        btn_Add.Enabled = False
        btn_Update.Enabled = True
        btn_Delete.Enabled = True
        MakeButtonBackgroundBlurry(btn_Add)
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
        cb_Department.SelectedIndex = 0
        dgrv_Employee.ClearSelection() ' Xóa bỏ việc chọn hàng trong DataGridView             
    End Sub

    Dim titleMsgBox As String = "notification"
    Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
    Dim icons As MessageBoxIcon = MessageBoxIcon.Warning


    Public Sub Select_Departments()
        If con.State <> 1 Then
            con.Open()
        End If

        Using cmd As SqlCommand = New SqlCommand("GetAllDepartments", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                Dim currentItem As ComboBoxItem = New ComboBoxItem(reader("name"), reader("id"))
                cb_Department_Change.Items.Add(currentItem)
                cb_Department.Items.Add(currentItem)
            End While
            con.Close()

        End Using

    End Sub


    Private Sub SearchEmployeesByKeyword(keyword As String, department_id As Integer)
        Console.WriteLine(keyword)
        If con.State <> 1 Then
            con.Open()
        End If

        dgrv_Employee.Rows.Clear()
        Dim reload = False
        Using cmd As SqlCommand = New SqlCommand("GetEmployeesByKeyWord", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@keyword", keyword)
            cmd.Parameters.AddWithValue("@department_id", department_id)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    Dim No As Integer = 1
                    While reader.Read()
                        ShowEmployee(No, reader)
                        No = No + 1
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
            LoadAndSortData()
        End If
    End Sub

    Private Sub btn_add_click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim name As String = txt_Name.Text
        Dim department_id As Integer = CInt(cb_Department.SelectedItem.hiddenvalue)
        Dim phone As String = txt_Phone.Text
        Dim address As String = txt_Address.Text
        Dim gender As String


        If rdo_Male.Checked = True Then
            gender = "male"
        Else
            gender = "female"
            MsgBox("your gender is" & gender)
        End If
        Dim birthday As Date = dtp_Birthday.Value
        Dim email As String = txt_Email.Text

        Dim department As String = cb_Department_Change.SelectedValue


        If String.IsNullOrEmpty(name) OrElse
            String.IsNullOrEmpty(phone) OrElse
            String.IsNullOrEmpty(address) OrElse
            String.IsNullOrEmpty(gender) OrElse
            String.IsNullOrEmpty(email) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleMsgBox, buttons, icons)
            Return
        End If

        If FuntionCommon.Validation.IsEmail(email) Then
        Else
            MessageBox.Show(Message.Message.emailInvalidMessage, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        If CInt(cb_Department.SelectedItem.hiddenValue) = -1 Then
            MessageBox.Show("Please select a department!", titleMsgBox, buttons, icons)
            Return
        End If

        If FuntionCommon.Validation.ValidatePhone(phone) Then
        Else
            MessageBox.Show(Message.Message.phoneInvalidMessage, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        Dim img As Byte() = ImageToByte(ptb_Employee.Image)

        Add_Employees(name, department_id, phone, address, gender, birthday, email, img)
        ClearForm()
    End Sub


    Private Sub btn_update_click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Dim id As Integer = Convert.ToInt32(txt_EmployeeID.Text)
        Dim name As String = txt_Name.Text
        Dim department_id As Integer = CInt(cb_Department.SelectedItem.hiddenvalue)
        Dim phone As String = txt_Phone.Text
        Dim address As String = txt_Address.Text
        Dim gender As String

        If rdo_Male.Checked = True Then
            gender = "male"
        Else
            gender = "female"
            MsgBox("your gender is" & gender)
        End If
        Dim birthday As Date = dtp_Birthday.Value
        Dim email As String = txt_Email.Text


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

        If CInt(cb_Department.SelectedItem.hiddenValue) = -1 Then
            MessageBox.Show("Please select a department!", titleMsgBox, buttons, icons)
            Return
        End If

        If Not FuntionCommon.Validation.ValidatePhone(phone) Then
            MessageBox.Show(Message.Message.phoneInvalidMessage, titleMsgBox, buttons, icons)
            Exit Sub
        End If

        Dim img As Byte() = ImageToByte(ptb_Employee.Image)

        Update_Employee(id, department_id, name, phone, address, gender, birthday, email, img)
        EnableAdd()
        ClearForm()
    End Sub

    Private Sub dgrv_employee_cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrv_Employee.CellClick

        If e.RowIndex >= 0 Then
            DisableAdd()
            Dim selectedrow = dgrv_Employee.Rows(e.RowIndex)
            For Each item As ComboBoxItem In cb_Department.Items
                If item.displayvalue = selectedrow.Cells("department_name").Value.ToString() Then
                    cb_Department.SelectedItem = item
                    Exit For
                End If
            Next
            txt_EmployeeID.Text = selectedrow.Cells("employeeid").Value.ToString()
            selectedEmployees.id = txt_EmployeeID.Text
            selectedEmployees.department_name = cb_Department.SelectedItem.displayvalue
            txt_EmployeeID.ReadOnly = True
            txt_Name.Text = selectedrow.Cells("employeename").Value.ToString()
            selectedEmployees.name = txt_Name.Text
            txt_Phone.Text = selectedrow.Cells("phone").Value.ToString()
            selectedEmployees.phone = txt_Phone.Text
            txt_Email.Text = selectedrow.Cells("email").Value.ToString()
            selectedEmployees.email = txt_Email.Text

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
            selectedEmployees.gender = CBool(gender.Value)
            dtp_Birthday.Value = Convert.ToDateTime(selectedrow.Cells("birthday").Value)
            selectedEmployees.birthday = dtp_Birthday.Value
        End If
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Dim selectedRows As DataGridViewSelectedRowCollection = dgrv_Employee.SelectedRows

        If selectedRows.Count >= 0 AndAlso MessageBox.Show("Are you sure you want to delete the selected employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For i As Integer = dgrv_Employee.SelectedRows.Count - 1 To 0 Step -1
                Dim selectedRow As DataGridViewRow = dgrv_Employee.SelectedRows(i)
                Dim id As Integer = CInt(selectedRow.Cells("EmployeeID").Value)
                Delete_Employee(id)
            Next
            ClearForm()
            EnableAdd()

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

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
        Dim dashboard As New Dashboard
        dashboard.Show()
    End Sub


    Private Sub btn_Upload_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click
        Dim open As New OpenFileDialog()
        open.Title = "Please select an image you want!!!"
        open.Filter = "Image File|*.jpg;*.jpeg;*.png;*.gif"
        If open.ShowDialog() = DialogResult.OK Then
            Dim selectedImage As String = open.FileName
            ptb_Employee.Image = Image.FromFile(selectedImage)
        End If

    End Sub

    Public Function ImageToByte(img As Image) As Byte()
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


    Private Sub cb_Department_Change_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Department_Change.SelectedIndexChanged
        Dim department_id = CInt(cb_Department_Change.SelectedItem.hiddenvalue)
        dgrv_Employee.RowCount = 0
        If con.State <> 1 Then
            con.Open()
        End If
        Dim reader As SqlDataReader
        If department_id = -1 Then
            Using cmd As SqlCommand = New SqlCommand("GetAllEmployeesByDepartment", con)
                cmd.CommandType = CommandType.StoredProcedure
                reader = cmd.ExecuteReader()
                Dim No As Integer = 1
                While reader.Read()
                    ShowEmployee(No, reader)
                    No = No + 1
                End While
                con.Close()
            End Using
        Else
            Using cmd As SqlCommand = New SqlCommand("GetEmployeeByDepartment", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@department_id", department_id)
                reader = cmd.ExecuteReader()
                Dim No As Integer = 1
                While reader.Read()
                    ShowEmployee(No, reader)
                    No = No + 1
                End While
                con.Close()

            End Using
        End If
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim keyword As String = txt_Search.Text.Trim()
        Dim department_id As Integer = cb_Department_Change.SelectedItem.hiddenvalue
        If Not String.IsNullOrEmpty(keyword) Then
            SearchEmployeesByKeyword(keyword, department_id)
        Else
            MessageBox.Show(Message.Message.emptyDataSearchMessage, titleMsgBox, buttons, icons)
        End If
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        txt_EmployeeID.Text = selectedEmployees.id
        txt_Name.Text = selectedEmployees.name
        txt_Phone.Text = selectedEmployees.phone
        ptb_Employee.Image = selectedEmployees.img

        dtp_Birthday.Value = selectedEmployees.birthday
        cb_Department.SelectedItem.displayvalue = selectedEmployees.department_name
        txt_Address.Text = selectedEmployees.address
        If selectedEmployees.gender Then
            rdo_Male.Checked = True
        Else
            rdo_Female.Checked = True
        End If
        txt_Email.Text = selectedEmployees.email
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        ClearForm()
        EnableAdd()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ptb_Icon.Click
        Me.Close()
        Dim dashboard As New Dashboard
        dashboard.Show()
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
            cb_Department.Focus()
        End If
    End Sub

    Private Sub cb_Department_KeyDown(sender As Object, e As KeyEventArgs) Handles cb_Department.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txt_Email.Focus()
        End If
    End Sub

    Private Sub txt_Email_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Email.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class