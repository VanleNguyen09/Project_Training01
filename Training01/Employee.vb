Imports System.Data.SqlClient
Imports System.IO

Public Class frm_Employee
    Private con As SqlConnection = New SqlConnection(Connection.ConnectSQL.GetConnectionString())

    Private selectedEmployees As Selected_Employees = New Selected_Employees()

    Private currentPage As Integer = GlobalVariables.currentPage
    Private totalPages As Integer = GlobalVariables.totalPages
    Private pageSize As Integer = GlobalVariables.pageSize
    Private totalRows As Integer = GlobalVariables.totalRows

    Dim buttonOK As MessageBoxButtons = GlobalVariables.buttonOK
    Dim buttonYesNo As MessageBoxButtons = GlobalVariables.buttonYesNo
    Dim warmIcon As MessageBoxIcon = GlobalVariables.warmIcon
    Dim questionIcon As MessageBoxIcon = GlobalVariables.questionIcon
    Dim infoIcon As MessageBoxIcon = GlobalVariables.infoIcon
    Dim errorIcon As MessageBoxIcon = GlobalVariables.errorIcon

    Dim titleSucces As String = GlobalVariables.titleSucces
    Dim titleNotif As String = GlobalVariables.titleNotif
    Dim titleError As String = GlobalVariables.titleError
    Dim titleConfỉrm As String = GlobalVariables.titleConfirm
    Dim titleInfo As String = GlobalVariables.titleInfo
    Private Property Id As Integer

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
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomElements.AddClearButtonInsideTextBox(txt_Search, "pbCloseSearch", Sub()
                                                                                    txt_Search.Text = ""
                                                                                    gbtn_Search.PerformClick()
                                                                                End Sub)
        dtp_Birthday.Value = dtp_Birthday.Value.AddYears(-18)
        dgrv_Employee.Columns("No").SortMode = DataGridViewColumnSortMode.NotSortable
        GlobalVariables.lblPage = lbl_Page
        rdo_Female.Text = "Female"
        rdo_Male.Text = "Male"
        rdo_Male.Checked = True
        rdo_Female.Checked = False
        EnableAdd()
        dgrv_Employee.Rows.Clear()
        totalRows = GetTotalRowsEmployees()
        UpdatePaginationPicBox()
        LoadData()
        dgrv_Employee.ClearSelection()
    End Sub

    Private Sub frm_Employee_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgrv_Employee.ClearSelection()
    End Sub

    Private Enum EmployeeParameters
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
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
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
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
        Finally
            con.Close()
        End Try
        Return CheckEmployeeExitForUpdate
    End Function

    Private Sub Add_Employees(ByVal values As Dictionary(Of EmployeeParameters, Object))
        Dim status As Integer = 1
        Dim name As String = values(EmployeeParameters.Name)
        Dim phone As String = values(EmployeeParameters.Phone)

        If CheckEmployeeExit(name, phone) Then
            MessageBox.Show(Message.Message.employeeDuplicate, titleNotif, buttonOK, warmIcon)
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
                    cmd.Parameters.AddWithValue("@email", values(EmployeeParameters.Email))
                    cmd.Parameters.AddWithValue("@image", values(EmployeeParameters.Image))
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show(Message.Message.employeeAddSuccess, titleSucces, buttonOK, infoIcon)
                End Using
                ClearForm()
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
            Finally
                con.Close()
            End Try
        End If

    End Sub

    Private Sub Update_Employee(ByVal values As Dictionary(Of EmployeeParameters, Object))
        Dim status As Integer = 1
        Dim name As String = values(EmployeeParameters.Name)
        Dim phone As String = values(EmployeeParameters.Phone)
        Dim id As Integer = CInt(values(EmployeeParameters.Id))

        If CheckEmployeeExitForUpdate(name, phone, id) Then
            MessageBox.Show(Message.Message.employeeDuplicate, titleNotif, buttonOK, warmIcon)
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

                    MessageBox.Show(Message.Message.employeeUpdateSuccess, titleSucces, buttonOK, infoIcon)

                End Using
                ClearForm()
                LoadData()
                EnableAdd()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Delete_Employee(ByVal id As Integer)
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
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
        Finally
            con.Close()
        End Try
    End Sub

    Private Function GetTotalRowsEmployees() As Integer
        If con.State <> 1 Then
            con.Open()
        End If
        Try
            Using cmd As SqlCommand = New SqlCommand("CountTotalEmployees", con)
                cmd.CommandType = CommandType.StoredProcedure
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read Then
                        totalRows = reader("SL_NV").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, titleError, buttonOK, errorIcon)
        Finally
            con.Close()
        End Try
        Return totalRows
    End Function

    Private Sub ShowEmployee(ByVal No As Integer, ByVal reader As SqlDataReader)
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
        Dim birthdayFormat As String = FuntionCommon.FormatDateTime.FormatDateTime(birthday)
        Dim email As String = reader("email").ToString()
        Dim status As Integer = Convert.ToInt32(reader("status").ToString())

        dgrv_Employee.Rows.Add(No, id, name, img, phone, address, gender, birthdayFormat, email, status)
    End Sub

    'Private Sub LoadData(ByVal currentPage As Integer, ByVal pageSize As Integer)
    '    If con.State <> 1 Then
    '        con.Open()
    '    End If
    '    dgrv_Employee.Rows.Clear()
    '    Using cmd As SqlCommand = New SqlCommand("GetAllEmployees", con)
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.AddWithValue("@curentPage", currentPage)
    '        cmd.Parameters.AddWithValue("@pageSize", pageSize)
    '        cmd.ExecuteNonQuery()
    '        Dim reader As SqlDataReader = cmd.ExecuteReader()
    '        Dim No As Integer = 1
    '        While reader.Read()
    '            ShowEmployee(No, reader)
    '            No += 1
    '        End While
    '        con.Close()
    '    End Using
    '    Pagination.PaginateDataGridView(dgrv_Employee, currentPage)
    'End Sub
    Private Sub LoadData()
        If con.State <> 1 Then
            con.Open()
        End If
        dgrv_Employee.Rows.Clear()
        Using cmd As SqlCommand = New SqlCommand("GetAllEmployeesPaging", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@currentPage", currentPage)
            cmd.Parameters.AddWithValue("@pageSize", pageSize)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim No As Integer = 1
            While reader.Read()
                ShowEmployee(No, reader)
                No += 1
            End While
            con.Close()
        End Using
        Pagination.Paginatedatagridview2(currentPage, totalRows)
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
        'txt_EmployeeID.Text = String.Empty
        txt_Email.Text = String.Empty
        rdo_Male.Checked = True
        rdo_Female.Checked = False
        dtp_Birthday.Value = Date.Now()
        ptb_Employee.Image = Nothing
        currentPage = 1
        ptb_Next.Enabled = True
        ptb_Previous.Enabled = False
        ' Set Value of Checkbox to False
        For Each row As DataGridViewRow In dgrv_Employee.Rows
            Dim checkboxCell As DataGridViewCheckBoxCell = DirectCast(row.Cells("ckb_Delete"), DataGridViewCheckBoxCell)
            checkboxCell.Value = False
        Next
        dgrv_Employee.ClearSelection()
    End Sub

    Private Sub SearchEmployeesByKeyword(ByVal keyword As String)
        If con.State <> 1 Then
            con.Open()
        End If
        dgrv_Employee.Rows.Clear()
        Dim reload = False
        Using cmd As SqlCommand = New SqlCommand("GetEmployeesByKeyWord", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@keyword", keyword)
            cmd.Parameters.AddWithValue("@currentPage", currentPage)
            cmd.Parameters.AddWithValue("@pageSize", pageSize)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    Dim No As Integer = 1
                    While reader.Read()
                        ShowEmployee(No, reader)
                        No += 1
                    End While
                    totalRows = dgrv_Employee.Rows.Count
                Else
                    MessageBox.Show(Message.Message.errorInvalidSearch, titleNotif, buttonOK, warmIcon)
                    reload = True
                End If
                Pagination.Paginatedatagridview2(currentPage, totalRows)
                UpdatePaginationPicBox()
            End Using
        End Using
        con.Close()
        If reload Then
            totalRows = GetTotalRowsEmployees()
            txt_Search.Text = Nothing
            LoadData()
            UpdatePaginationPicBox()
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
        End If
        Dim birthday As Date = dtp_Birthday.Value
        Dim email As String = txt_Email.Text.Trim()

        If String.IsNullOrEmpty(name) OrElse
            String.IsNullOrEmpty(phone) OrElse
            String.IsNullOrEmpty(address) OrElse
            String.IsNullOrEmpty(gender) OrElse
            String.IsNullOrEmpty(email) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleNotif, buttonOK, warmIcon)
            Return
        End If

        If Not FuntionCommon.Validation.IsEmail(email) Then
            MessageBox.Show(Message.Message.emailInvalidMessage, titleNotif, buttonOK, warmIcon)
            Exit Sub
        End If

        If Not FuntionCommon.Validation.ValidatePhone(phone) Then
            MessageBox.Show(Message.Message.phoneInvalidMessage, titleNotif, buttonOK, warmIcon)
            Exit Sub
        End If

        Dim inputYear As Integer = birthday.Year
        Dim currentYear As Integer = DateTime.Now.Year

        Dim isValid As Boolean = FuntionCommon.Validation.ValidateYear(inputYear, currentYear)

        If Not isValid Then
            MessageBox.Show(Message.Message.yearInvalidError, titleNotif, buttonOK, warmIcon)
            Exit Sub
        End If

        Dim img As Byte() = ImageToByte(ptb_Employee.Image)
        If imageSelected = False Then
            MessageBox.Show(Message.Message.imageEmptyError, titleNotif, buttonOK, warmIcon)
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
    End Sub

    Private Sub gbtn_Update_Click(sender As Object, e As EventArgs) Handles gbtn_Update.Click
        'Dim id As Integer = Convert.ToInt32()
        Dim name As String = txt_Name.Text.Trim()
        Dim phone As String = txt_Phone.Text.Trim()
        Dim address As String = txt_Address.Text.Trim()
        Dim gender As String

        If rdo_Male.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If
        Dim birthday As Date = dtp_Birthday.Value
        Dim email As String = txt_Email.Text.Trim()


        If String.IsNullOrEmpty(name) OrElse
                String.IsNullOrEmpty(phone) OrElse
                String.IsNullOrEmpty(address) OrElse
                String.IsNullOrEmpty(gender) OrElse
                String.IsNullOrEmpty(email) Then
            MessageBox.Show(Message.Message.emptyDataErrorMessage, titleNotif, buttonOK, warmIcon)
            Return
        End If

        If Not FuntionCommon.Validation.IsEmail(email) Then
            MessageBox.Show(Message.Message.emailInvalidMessage, titleNotif, buttonOK, warmIcon)
            Exit Sub
        End If

        If Not FuntionCommon.Validation.ValidatePhone(phone) Then
            MessageBox.Show(Message.Message.phoneInvalidMessage, titleNotif, buttonOK, warmIcon)
            Exit Sub
        End If

        Dim inputYear As Integer = birthday.Year
        Dim currentYear As Integer = DateTime.Now.Year

        Dim isValid As Boolean = FuntionCommon.Validation.ValidateYear(inputYear, currentYear)

        If Not isValid Then
            MessageBox.Show(Message.Message.yearInvalidError, titleNotif, buttonOK, warmIcon)
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
        values.Add(EmployeeParameters.Id, Id)

        Update_Employee(values)
    End Sub

    Private Sub dgrv_employee_cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrv_Employee.CellClick
        dgrv_Employee.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If e.ColumnIndex = dgrv_Employee.Columns.Count - 1 Then
            dgrv_Employee.SelectionMode = DataGridViewSelectionMode.CellSelect
            dgrv_Employee.ReadOnly = False
            txt_Name.Text = String.Empty
            txt_Address.Text = String.Empty
            txt_Phone.Text = String.Empty
            txt_Email.Text = String.Empty
            rdo_Male.Checked = True
            rdo_Female.Checked = False
            dtp_Birthday.Value = Date.Now()
            ptb_Employee.Image = Nothing
        Else
            If e.RowIndex >= 0 Then
                Dim selectedrow = dgrv_Employee.Rows(e.RowIndex)
                Id = CInt(selectedrow.Cells("EmployeeID").Value)
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
        End If
        DisableAdd()
    End Sub

    Private Sub gbtn_Delete_Click(sender As Object, e As EventArgs) Handles gbtn_Delete.Click

        'Dim Checked As Boolean = CType(dgrv_Employee.CurrentCell.Value, Boolean)

        'For Each gvrow As DataGridViewRow In dgrv_Employee.Rows
        '    Dim Checked As Boolean = CType(dgrv_Employee.CurrentCell.Value, Boolean)
        'Next
        ' Check if any row is selected
        Dim selectedRows As New List(Of DataGridViewRow)()

        For Each row As DataGridViewRow In dgrv_Employee.Rows
            Dim checkboxCell As DataGridViewCheckBoxCell = TryCast(row.Cells("ckb_Delete"), DataGridViewCheckBoxCell)
            If checkboxCell IsNot Nothing AndAlso checkboxCell.Value = True Then
                selectedRows.Add(row)
            End If
        Next

        ' Check if no row is selected
        If selectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one checkbox to delete", titleNotif, buttonOK, warmIcon)
            Return
        End If

        ' Show delete confirmation message
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete the selected employee?", titleConfỉrm, buttonYesNo, questionIcon)
        Dim employeeIdColumn As DataGridViewColumn = dgrv_Employee.Columns("EmployeeID")

        ' Delete rows if user confirm
        If confirmResult = DialogResult.Yes Then
            For Each row As DataGridViewRow In selectedRows
                Dim id As Integer = CInt(row.Cells(employeeIdColumn.Index).Value)
                Delete_Employee(id)
                ClearForm()
            Next
            LoadData()
            EnableAdd()
        End If


        'Dim selectedRows As DataGridViewSelectedRowCollection = dgrv_Employee.SelectedRows
        'Dim employeeIdColumn As DataGridViewColumn = dgrv_Employee.Columns("EmployeeID")

        'If selectedRows.Count > 0 AndAlso MessageBox.Show("Are you sure you want to delete the selected employee?", titleConfỉrm, buttonYesNo, questionIcon) = DialogResult.Yes Then
        '    If employeeIdColumn IsNot Nothing Then
        '        MessageBox.Show(Message.Message.employeeDeleteSuccess, titleSucces, buttonOK, infoIcon)
        '        For i As Integer = 0 To selectedRows.Count - 1
        '            Dim selectedRow As DataGridViewRow = selectedRows(i)
        '            Dim id As Integer = CInt(selectedRow.Cells(employeeIdColumn.Index).Value)
        '            Delete_Employee(id)
        '            ClearForm()
        '        Next
        '        LoadData()
        '        EnableAdd()
        '    Else
        '        MessageBox.Show("Unable to find the employee ID column.", titleError, buttonOK, errorIcon)
        '    End If
        'End If
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

    Private Function ImageToByte(ByVal img As Image) As Byte()
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
            dgrv_Employee.Rows.Clear()
        End If
    End Sub
    Private Sub gbtn_Reset_Click(sender As Object, e As EventArgs) Handles gbtn_Reset.Click
        'txt_EmployeeID.Text = selectedEmployees.id
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
        LoadData()
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

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        txt_Search.Controls("pbCloseSearch").Visible = (txt_Search.Text.Length > 0)
    End Sub

    Private Sub UpdatePaginationPicBox()
        If currentPage = 1 Then
            ptb_Previous.Enabled = False
        Else
            ptb_Previous.Enabled = True
        End If

        If currentPage = Math.Ceiling(totalRows / pageSize) Then
            ptb_Next.Enabled = False
        Else
            ptb_Next.Enabled = True
        End If
    End Sub

    Private Sub ptb_Previous_Click(sender As Object, e As EventArgs) Handles ptb_Previous.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadData()
        End If
        UpdatePaginationPicBox()
    End Sub

    Private Sub ptb_Next_Click(sender As Object, e As EventArgs) Handles ptb_Next.Click
        totalPages = Math.Ceiling(totalRows / pageSize)

        If currentPage < totalPages Then
            currentPage += 1
            LoadData()
        End If
        UpdatePaginationPicBox()
    End Sub

    Private Sub dgrv_Employee_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgrv_Employee.ColumnHeaderMouseClick
        FuntionCommon.SortationNO.SortAndPreventNoColumnSorting(dgrv_Employee, "No")
        Pagination.Paginatedatagridview2(currentPage, totalRows)
    End Sub

    Private Sub btn_EmpDept_Click(sender As Object, e As EventArgs) Handles btn_EmpDept.Click
        NewDashboard.LoadUserData()
        NewDashboard.ShowFormInMainPanel(frm_EmpInDept)
        NewDashboard.currentSelection = "Employee In Department"
        NewDashboard.UpdateTitleLabel()
        Me.Close()
    End Sub

    Private Sub dgrv_Employee_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgrv_Employee.CellMouseEnter
        If (e.ColumnIndex = 6 OrElse e.ColumnIndex = 7) AndAlso e.RowIndex >= 0 Then
            ' Set the pointer type to hand when hovering the mouse over the cell 
            dgrv_Employee.Cursor = Cursors.Hand
        Else
            dgrv_Employee.Cursor = Cursors.Default
        End If
    End Sub
End Class