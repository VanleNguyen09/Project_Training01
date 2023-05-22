<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.dtp_Birthday = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Birthday = New System.Windows.Forms.Label()
        Me.rdo_Female = New System.Windows.Forms.RadioButton()
        Me.rdo_Male = New System.Windows.Forms.RadioButton()
        Me.lbl_Gender = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.txt_Phone = New System.Windows.Forms.TextBox()
        Me.lbl_Phone = New System.Windows.Forms.Label()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.txt_EmployeeID = New System.Windows.Forms.TextBox()
        Me.lbl_EmployeeID = New System.Windows.Forms.Label()
        Me.btn_Upload = New System.Windows.Forms.Button()
        Me.lbl_Department = New System.Windows.Forms.Label()
        Me.cb_Department = New System.Windows.Forms.ComboBox()
        Me.ptb_Employee = New System.Windows.Forms.PictureBox()
        Me.dgrv_Employee = New System.Windows.Forms.DataGridView()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.images = New System.Windows.Forms.DataGridViewImageColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_TitleEmployee = New System.Windows.Forms.Label()
        Me.cb_Department_Change = New System.Windows.Forms.ComboBox()
        Me.lbl_Department_Change = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.lbl_Search = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        CType(Me.ptb_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrv_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.Silver
        Me.btn_Close.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.Location = New System.Drawing.Point(507, 489)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(141, 47)
        Me.btn_Close.TabIndex = 47
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.AllowDrop = True
        Me.btn_Delete.BackColor = System.Drawing.Color.Tomato
        Me.btn_Delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.Location = New System.Drawing.Point(345, 489)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(136, 47)
        Me.btn_Delete.TabIndex = 46
        Me.btn_Delete.Text = "Delete"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'btn_Update
        '
        Me.btn_Update.BackColor = System.Drawing.Color.Gold
        Me.btn_Update.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.Location = New System.Drawing.Point(190, 489)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(128, 47)
        Me.btn_Update.TabIndex = 45
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.Cyan
        Me.btn_Add.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(35, 489)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(124, 47)
        Me.btn_Add.TabIndex = 44
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(159, 399)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(192, 30)
        Me.txt_Email.TabIndex = 40
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Email.Location = New System.Drawing.Point(17, 399)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(65, 23)
        Me.lbl_Email.TabIndex = 39
        Me.lbl_Email.Text = "Email:"
        '
        'dtp_Birthday
        '
        Me.dtp_Birthday.AllowDrop = True
        Me.dtp_Birthday.CalendarFont = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Birthday.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtp_Birthday.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Birthday.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Birthday.Location = New System.Drawing.Point(158, 298)
        Me.dtp_Birthday.Name = "dtp_Birthday"
        Me.dtp_Birthday.Size = New System.Drawing.Size(193, 33)
        Me.dtp_Birthday.TabIndex = 38
        Me.dtp_Birthday.Value = New Date(2023, 5, 16, 0, 0, 0, 0)
        '
        'lbl_Birthday
        '
        Me.lbl_Birthday.AutoSize = True
        Me.lbl_Birthday.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Birthday.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Birthday.Location = New System.Drawing.Point(16, 306)
        Me.lbl_Birthday.Name = "lbl_Birthday"
        Me.lbl_Birthday.Size = New System.Drawing.Size(90, 23)
        Me.lbl_Birthday.TabIndex = 37
        Me.lbl_Birthday.Text = "Birthday:"
        '
        'rdo_Female
        '
        Me.rdo_Female.AllowDrop = True
        Me.rdo_Female.AutoSize = True
        Me.rdo_Female.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Female.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rdo_Female.Location = New System.Drawing.Point(262, 254)
        Me.rdo_Female.Name = "rdo_Female"
        Me.rdo_Female.Size = New System.Drawing.Size(89, 26)
        Me.rdo_Female.TabIndex = 36
        Me.rdo_Female.TabStop = True
        Me.rdo_Female.Text = "Female"
        Me.rdo_Female.UseVisualStyleBackColor = True
        '
        'rdo_Male
        '
        Me.rdo_Male.AllowDrop = True
        Me.rdo_Male.AutoSize = True
        Me.rdo_Male.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Male.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rdo_Male.Location = New System.Drawing.Point(158, 253)
        Me.rdo_Male.Name = "rdo_Male"
        Me.rdo_Male.Size = New System.Drawing.Size(72, 26)
        Me.rdo_Male.TabIndex = 35
        Me.rdo_Male.TabStop = True
        Me.rdo_Male.Text = "Male"
        Me.rdo_Male.UseVisualStyleBackColor = True
        '
        'lbl_Gender
        '
        Me.lbl_Gender.AutoSize = True
        Me.lbl_Gender.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Gender.Location = New System.Drawing.Point(16, 254)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(81, 23)
        Me.lbl_Gender.TabIndex = 34
        Me.lbl_Gender.Text = "Gender:"
        '
        'txt_Address
        '
        Me.txt_Address.AllowDrop = True
        Me.txt_Address.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address.Location = New System.Drawing.Point(158, 192)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(193, 30)
        Me.txt_Address.TabIndex = 33
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Address.Location = New System.Drawing.Point(16, 199)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(85, 23)
        Me.lbl_Address.TabIndex = 32
        Me.lbl_Address.Text = "Address:"
        '
        'txt_Phone
        '
        Me.txt_Phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Phone.Location = New System.Drawing.Point(507, 82)
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(248, 30)
        Me.txt_Phone.TabIndex = 31
        '
        'lbl_Phone
        '
        Me.lbl_Phone.AutoSize = True
        Me.lbl_Phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Phone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Phone.Location = New System.Drawing.Point(390, 84)
        Me.lbl_Phone.Name = "lbl_Phone"
        Me.lbl_Phone.Size = New System.Drawing.Size(69, 23)
        Me.lbl_Phone.TabIndex = 30
        Me.lbl_Phone.Text = "Phone:"
        '
        'txt_Name
        '
        Me.txt_Name.AllowDrop = True
        Me.txt_Name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Name.Location = New System.Drawing.Point(158, 135)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(193, 30)
        Me.txt_Name.TabIndex = 29
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Name.Location = New System.Drawing.Point(16, 142)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(66, 23)
        Me.lbl_Name.TabIndex = 28
        Me.lbl_Name.Text = "Name:"
        '
        'txt_EmployeeID
        '
        Me.txt_EmployeeID.AllowDrop = True
        Me.txt_EmployeeID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmployeeID.Location = New System.Drawing.Point(158, 82)
        Me.txt_EmployeeID.Name = "txt_EmployeeID"
        Me.txt_EmployeeID.Size = New System.Drawing.Size(193, 30)
        Me.txt_EmployeeID.TabIndex = 27
        '
        'lbl_EmployeeID
        '
        Me.lbl_EmployeeID.AutoSize = True
        Me.lbl_EmployeeID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EmployeeID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_EmployeeID.Location = New System.Drawing.Point(16, 79)
        Me.lbl_EmployeeID.Name = "lbl_EmployeeID"
        Me.lbl_EmployeeID.Size = New System.Drawing.Size(122, 23)
        Me.lbl_EmployeeID.TabIndex = 26
        Me.lbl_EmployeeID.Text = "Employee Id:"
        '
        'btn_Upload
        '
        Me.btn_Upload.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_Upload.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Upload.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Upload.Location = New System.Drawing.Point(557, 352)
        Me.btn_Upload.Name = "btn_Upload"
        Me.btn_Upload.Size = New System.Drawing.Size(150, 47)
        Me.btn_Upload.TabIndex = 51
        Me.btn_Upload.Text = "Choose FIle"
        Me.btn_Upload.UseVisualStyleBackColor = False
        '
        'lbl_Department
        '
        Me.lbl_Department.AutoSize = True
        Me.lbl_Department.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Department.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Department.Location = New System.Drawing.Point(17, 352)
        Me.lbl_Department.Name = "lbl_Department"
        Me.lbl_Department.Size = New System.Drawing.Size(118, 23)
        Me.lbl_Department.TabIndex = 52
        Me.lbl_Department.Text = "Department:"
        '
        'cb_Department
        '
        Me.cb_Department.AllowDrop = True
        Me.cb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Department.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Department.FormattingEnabled = True
        Me.cb_Department.Location = New System.Drawing.Point(158, 351)
        Me.cb_Department.Name = "cb_Department"
        Me.cb_Department.Size = New System.Drawing.Size(193, 30)
        Me.cb_Department.TabIndex = 53
        '
        'ptb_Employee
        '
        Me.ptb_Employee.BackgroundImage = Global.Training01.My.Resources.Resources.avatar2
        Me.ptb_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_Employee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptb_Employee.Location = New System.Drawing.Point(507, 129)
        Me.ptb_Employee.Name = "ptb_Employee"
        Me.ptb_Employee.Size = New System.Drawing.Size(248, 202)
        Me.ptb_Employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Employee.TabIndex = 50
        Me.ptb_Employee.TabStop = False
        '
        'dgrv_Employee
        '
        Me.dgrv_Employee.AllowUserToAddRows = False
        Me.dgrv_Employee.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgrv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrv_Employee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeID, Me.department_name, Me.EmployeeName, Me.images, Me.phone, Me.address, Me.gender, Me.birthday, Me.email})
        Me.dgrv_Employee.Location = New System.Drawing.Point(21, 568)
        Me.dgrv_Employee.Name = "dgrv_Employee"
        Me.dgrv_Employee.RowHeadersWidth = 51
        Me.dgrv_Employee.RowTemplate.Height = 24
        Me.dgrv_Employee.Size = New System.Drawing.Size(1008, 290)
        Me.dgrv_Employee.TabIndex = 54
        '
        'EmployeeID
        '
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.DefaultCellStyle = DataGridViewCellStyle22
        Me.EmployeeID.HeaderText = "EmployeeID"
        Me.EmployeeID.MinimumWidth = 6
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.ReadOnly = True
        Me.EmployeeID.Width = 125
        '
        'department_name
        '
        Me.department_name.HeaderText = "Department Name"
        Me.department_name.MinimumWidth = 6
        Me.department_name.Name = "department_name"
        Me.department_name.Width = 125
        '
        'EmployeeName
        '
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeName.DefaultCellStyle = DataGridViewCellStyle23
        Me.EmployeeName.HeaderText = "Name"
        Me.EmployeeName.MinimumWidth = 6
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeName.Width = 125
        '
        'images
        '
        Me.images.HeaderText = "Image"
        Me.images.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.images.MinimumWidth = 6
        Me.images.Name = "images"
        Me.images.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.images.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.images.Width = 80
        '
        'phone
        '
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone.DefaultCellStyle = DataGridViewCellStyle24
        Me.phone.HeaderText = "Phone"
        Me.phone.MinimumWidth = 6
        Me.phone.Name = "phone"
        Me.phone.Width = 125
        '
        'address
        '
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.DefaultCellStyle = DataGridViewCellStyle25
        Me.address.HeaderText = "Address"
        Me.address.MinimumWidth = 6
        Me.address.Name = "address"
        Me.address.Width = 125
        '
        'gender
        '
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.DefaultCellStyle = DataGridViewCellStyle26
        Me.gender.HeaderText = "Gender"
        Me.gender.MinimumWidth = 6
        Me.gender.Name = "gender"
        Me.gender.Width = 125
        '
        'birthday
        '
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday.DefaultCellStyle = DataGridViewCellStyle27
        Me.birthday.HeaderText = "Birthday"
        Me.birthday.MinimumWidth = 6
        Me.birthday.Name = "birthday"
        Me.birthday.Width = 125
        '
        'email
        '
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.DefaultCellStyle = DataGridViewCellStyle28
        Me.email.HeaderText = "Email"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.Width = 125
        '
        'lbl_TitleEmployee
        '
        Me.lbl_TitleEmployee.AutoSize = True
        Me.lbl_TitleEmployee.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TitleEmployee.ForeColor = System.Drawing.Color.Red
        Me.lbl_TitleEmployee.Location = New System.Drawing.Point(281, 9)
        Me.lbl_TitleEmployee.Name = "lbl_TitleEmployee"
        Me.lbl_TitleEmployee.Size = New System.Drawing.Size(353, 45)
        Me.lbl_TitleEmployee.TabIndex = 25
        Me.lbl_TitleEmployee.Text = "EMPLOYEE LIST"
        '
        'cb_Department_Change
        '
        Me.cb_Department_Change.AllowDrop = True
        Me.cb_Department_Change.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Department_Change.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Department_Change.FormattingEnabled = True
        Me.cb_Department_Change.Location = New System.Drawing.Point(538, 425)
        Me.cb_Department_Change.Name = "cb_Department_Change"
        Me.cb_Department_Change.Size = New System.Drawing.Size(193, 30)
        Me.cb_Department_Change.TabIndex = 56
        '
        'lbl_Department_Change
        '
        Me.lbl_Department_Change.AllowDrop = True
        Me.lbl_Department_Change.AutoSize = True
        Me.lbl_Department_Change.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Department_Change.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Department_Change.Location = New System.Drawing.Point(390, 425)
        Me.lbl_Department_Change.Name = "lbl_Department_Change"
        Me.lbl_Department_Change.Size = New System.Drawing.Size(118, 23)
        Me.lbl_Department_Change.TabIndex = 55
        Me.lbl_Department_Change.Text = "Department:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-19, -19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 57
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(-19, -19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 58
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(799, 197)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(230, 30)
        Me.txt_Search.TabIndex = 59
        '
        'lbl_Search
        '
        Me.lbl_Search.AutoSize = True
        Me.lbl_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Search.Location = New System.Drawing.Point(795, 151)
        Me.lbl_Search.Name = "lbl_Search"
        Me.lbl_Search.Size = New System.Drawing.Size(75, 23)
        Me.lbl_Search.TabIndex = 60
        Me.lbl_Search.Text = "Search:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-19, -19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(-19, -19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.Color.Lime
        Me.btn_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.Location = New System.Drawing.Point(799, 242)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(141, 47)
        Me.btn_Search.TabIndex = 64
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'btn_Reset
        '
        Me.btn_Reset.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_Reset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Reset.Location = New System.Drawing.Point(671, 489)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(141, 47)
        Me.btn_Reset.TabIndex = 65
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.UseVisualStyleBackColor = False
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.Orange
        Me.btn_Clear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(834, 489)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(141, 47)
        Me.btn_Clear.TabIndex = 66
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'frm_Employee
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1073, 881)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_Search)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cb_Department_Change)
        Me.Controls.Add(Me.lbl_Department_Change)
        Me.Controls.Add(Me.dgrv_Employee)
        Me.Controls.Add(Me.cb_Department)
        Me.Controls.Add(Me.lbl_Department)
        Me.Controls.Add(Me.btn_Upload)
        Me.Controls.Add(Me.ptb_Employee)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.dtp_Birthday)
        Me.Controls.Add(Me.lbl_Birthday)
        Me.Controls.Add(Me.rdo_Female)
        Me.Controls.Add(Me.rdo_Male)
        Me.Controls.Add(Me.lbl_Gender)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.lbl_Address)
        Me.Controls.Add(Me.txt_Phone)
        Me.Controls.Add(Me.lbl_Phone)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.txt_EmployeeID)
        Me.Controls.Add(Me.lbl_EmployeeID)
        Me.Controls.Add(Me.lbl_TitleEmployee)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "employees"
        CType(Me.ptb_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrv_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Close As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents lbl_Email As Label
    Private WithEvents dtp_Birthday As DateTimePicker
    Friend WithEvents lbl_Birthday As Label
    Friend WithEvents rdo_Female As RadioButton
    Friend WithEvents rdo_Male As RadioButton
    Friend WithEvents lbl_Gender As Label
    Friend WithEvents txt_Address As TextBox
    Friend WithEvents lbl_Address As Label
    Friend WithEvents txt_Phone As TextBox
    Friend WithEvents lbl_Phone As Label
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents txt_EmployeeID As TextBox
    Friend WithEvents lbl_EmployeeID As Label
    Friend WithEvents ptb_Employee As PictureBox
    Friend WithEvents btn_Upload As Button
    Friend WithEvents lbl_Department As Label
    Friend WithEvents cb_Department As ComboBox
    Friend WithEvents dgrv_Employee As DataGridView
    Friend WithEvents name1 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_TitleEmployee As Label
    Friend WithEvents cb_Department_Change As ComboBox
    Friend WithEvents lbl_Department_Change As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents lbl_Search As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_Search As Button
    Friend WithEvents btn_Reset As Button
    Friend WithEvents EmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents department_name As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents images As DataGridViewImageColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents birthday As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents btn_Clear As Button
End Class
