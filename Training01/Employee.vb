Imports System.Data.SqlClient

Public Class frm_Employee
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
        lbl_Address.BackColor = Color.Transparent
        lbl_Birthday.BackColor = Color.Transparent

        rdo_Female.Text = "Female"
        rdo_Male.Text = "Male"
        LoadData()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="phone"></param>
    ''' <param name="address"></param>
    ''' <param name="gender"></param>
    ''' <param name="birthday"></param>
    ''' <param name="email"></param>
    Public Sub Add_Employees(name As String, phone As String, address As String, gender As String, birthday As Date, email As String)
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
                cmd.ExecuteNonQuery()

                MessageBox.Show("Add Data Success!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub LoadData()
        dgrv_Employee.Rows.Clear()
        If con.State <> 1 Then
            con.Open()
        End If

        Using cmd As SqlCommand = New SqlCommand("GetAllEmployees", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim id As Integer = Convert.ToInt32(reader("id"))
                Dim name As String = reader("name").ToString()
                Dim phone As String = reader("phone").ToString()
                Dim address As String = reader("address").ToString()
                Dim gender As String = reader("gender").ToString()
                Dim birthday As String = reader("birthday").ToString()
                Dim email As String = reader("email").ToString()
                dgrv_Employee.Rows.Add(id, name, phone, address, gender, birthday, email)
            End While
            con.Close()
        End Using
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim name As String = txt_Name.Text
        Dim phone As String = txt_Phone.Text
        Dim address As String = txt_Address.Text
        Dim gender As String
        If rdo_Male.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
            MsgBox("Your gender is" & gender)
        End If
        Dim birthday As Date = dtp_Birthday.Value
        Dim email As String = txt_Email.Text

        If String.IsNullOrEmpty(name) OrElse
            String.IsNullOrEmpty(phone) OrElse
            String.IsNullOrEmpty(address) OrElse
            String.IsNullOrEmpty(gender) OrElse
            String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please fill full data!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If FuntionCommon.Validation.IsEmail(email) Then
        Else
            MessageBox.Show("Please fill an valid email!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        'If FuntionCommon.Validation.ValidateDate(birthday) Then
        'Else
        '    MessageBox.Show("Please fill an valid date!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If

        'If FuntionCommon.Validation.ValidatePhone(phone) Then
        'Else
        '    MessageBox.Show("Please fill an valid phone number!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If

        'Add_Employees(name, phone, address, gender, birthday, email)
    End Sub
End Class