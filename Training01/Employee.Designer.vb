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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.ptb_Employee = New System.Windows.Forms.PictureBox()
        Me.dgrv_Employee = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.images = New System.Windows.Forms.DataGridViewImageColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_TitleEmployee = New System.Windows.Forms.Label()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.lbl_Page = New System.Windows.Forms.Label()
        Me.gbtn_Add = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Update = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Delete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Reset = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Clear = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Upload = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Search = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ptb_Previous = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ptb_Next = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btn_EmpDept = New System.Windows.Forms.Button()
        CType(Me.ptb_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrv_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Previous, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Next, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(505, 197)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(192, 30)
        Me.txt_Email.TabIndex = 40
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email.ForeColor = System.Drawing.Color.Ivory
        Me.lbl_Email.Location = New System.Drawing.Point(389, 199)
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
        Me.dtp_Birthday.Location = New System.Drawing.Point(505, 131)
        Me.dtp_Birthday.Name = "dtp_Birthday"
        Me.dtp_Birthday.Size = New System.Drawing.Size(193, 33)
        Me.dtp_Birthday.TabIndex = 38
        Me.dtp_Birthday.Value = New Date(2023, 5, 16, 0, 0, 0, 0)
        '
        'lbl_Birthday
        '
        Me.lbl_Birthday.AutoSize = True
        Me.lbl_Birthday.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Birthday.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Birthday.ForeColor = System.Drawing.Color.Ivory
        Me.lbl_Birthday.Location = New System.Drawing.Point(389, 138)
        Me.lbl_Birthday.Name = "lbl_Birthday"
        Me.lbl_Birthday.Size = New System.Drawing.Size(90, 23)
        Me.lbl_Birthday.TabIndex = 37
        Me.lbl_Birthday.Text = "Birthday:"
        '
        'rdo_Female
        '
        Me.rdo_Female.AllowDrop = True
        Me.rdo_Female.AutoSize = True
        Me.rdo_Female.BackColor = System.Drawing.Color.Transparent
        Me.rdo_Female.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Female.ForeColor = System.Drawing.Color.Ivory
        Me.rdo_Female.Location = New System.Drawing.Point(991, 87)
        Me.rdo_Female.Name = "rdo_Female"
        Me.rdo_Female.Size = New System.Drawing.Size(89, 26)
        Me.rdo_Female.TabIndex = 36
        Me.rdo_Female.TabStop = True
        Me.rdo_Female.Text = "Female"
        Me.rdo_Female.UseVisualStyleBackColor = False
        '
        'rdo_Male
        '
        Me.rdo_Male.AllowDrop = True
        Me.rdo_Male.AutoSize = True
        Me.rdo_Male.BackColor = System.Drawing.Color.Transparent
        Me.rdo_Male.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Male.ForeColor = System.Drawing.Color.Ivory
        Me.rdo_Male.Location = New System.Drawing.Point(887, 86)
        Me.rdo_Male.Name = "rdo_Male"
        Me.rdo_Male.Size = New System.Drawing.Size(72, 26)
        Me.rdo_Male.TabIndex = 35
        Me.rdo_Male.TabStop = True
        Me.rdo_Male.Text = "Male"
        Me.rdo_Male.UseVisualStyleBackColor = False
        '
        'lbl_Gender
        '
        Me.lbl_Gender.AutoSize = True
        Me.lbl_Gender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Gender.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gender.ForeColor = System.Drawing.Color.Ivory
        Me.lbl_Gender.Location = New System.Drawing.Point(745, 87)
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
        Me.lbl_Address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Address.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address.ForeColor = System.Drawing.Color.Ivory
        Me.lbl_Address.Location = New System.Drawing.Point(16, 199)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(85, 23)
        Me.lbl_Address.TabIndex = 32
        Me.lbl_Address.Text = "Address:"
        '
        'txt_Phone
        '
        Me.txt_Phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Phone.Location = New System.Drawing.Point(158, 134)
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(193, 30)
        Me.txt_Phone.TabIndex = 31
        '
        'lbl_Phone
        '
        Me.lbl_Phone.AutoSize = True
        Me.lbl_Phone.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Phone.ForeColor = System.Drawing.Color.Ivory
        Me.lbl_Phone.Location = New System.Drawing.Point(17, 136)
        Me.lbl_Phone.Name = "lbl_Phone"
        Me.lbl_Phone.Size = New System.Drawing.Size(69, 23)
        Me.lbl_Phone.TabIndex = 30
        Me.lbl_Phone.Text = "Phone:"
        '
        'txt_Name
        '
        Me.txt_Name.AllowDrop = True
        Me.txt_Name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Name.Location = New System.Drawing.Point(505, 82)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(193, 30)
        Me.txt_Name.TabIndex = 29
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.ForeColor = System.Drawing.Color.Ivory
        Me.lbl_Name.Location = New System.Drawing.Point(389, 84)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(66, 23)
        Me.lbl_Name.TabIndex = 28
        Me.lbl_Name.Text = "Name:"
        '
        'txt_EmployeeID
        '
        Me.txt_EmployeeID.AllowDrop = True
        Me.txt_EmployeeID.Enabled = False
        Me.txt_EmployeeID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmployeeID.Location = New System.Drawing.Point(158, 82)
        Me.txt_EmployeeID.Name = "txt_EmployeeID"
        Me.txt_EmployeeID.ReadOnly = True
        Me.txt_EmployeeID.Size = New System.Drawing.Size(193, 30)
        Me.txt_EmployeeID.TabIndex = 27
        '
        'lbl_EmployeeID
        '
        Me.lbl_EmployeeID.AutoSize = True
        Me.lbl_EmployeeID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EmployeeID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EmployeeID.ForeColor = System.Drawing.Color.Ivory
        Me.lbl_EmployeeID.Location = New System.Drawing.Point(16, 79)
        Me.lbl_EmployeeID.Name = "lbl_EmployeeID"
        Me.lbl_EmployeeID.Size = New System.Drawing.Size(122, 23)
        Me.lbl_EmployeeID.TabIndex = 26
        Me.lbl_EmployeeID.Text = "Employee Id:"
        '
        'ptb_Employee
        '
        Me.ptb_Employee.BackgroundImage = Global.Training01.My.Resources.Resources.avatar2
        Me.ptb_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_Employee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptb_Employee.Location = New System.Drawing.Point(749, 131)
        Me.ptb_Employee.Name = "ptb_Employee"
        Me.ptb_Employee.Size = New System.Drawing.Size(111, 96)
        Me.ptb_Employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Employee.TabIndex = 50
        Me.ptb_Employee.TabStop = False
        '
        'dgrv_Employee
        '
        Me.dgrv_Employee.AllowUserToAddRows = False
        Me.dgrv_Employee.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgrv_Employee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgrv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrv_Employee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.EmployeeID, Me.EmployeeName, Me.images, Me.phone, Me.address, Me.gender, Me.birthday, Me.email, Me.status})
        Me.dgrv_Employee.Location = New System.Drawing.Point(21, 306)
        Me.dgrv_Employee.Name = "dgrv_Employee"
        Me.dgrv_Employee.RowHeadersVisible = False
        Me.dgrv_Employee.RowHeadersWidth = 51
        Me.dgrv_Employee.RowTemplate.Height = 24
        Me.dgrv_Employee.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgrv_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrv_Employee.Size = New System.Drawing.Size(1192, 322)
        Me.dgrv_Employee.TabIndex = 54
        '
        'No
        '
        Me.No.HeaderText = "NO"
        Me.No.MinimumWidth = 6
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 40
        '
        'EmployeeID
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.DefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeID.HeaderText = "EmployeeID"
        Me.EmployeeID.MinimumWidth = 6
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.ReadOnly = True
        Me.EmployeeID.Visible = False
        Me.EmployeeID.Width = 60
        '
        'EmployeeName
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeName.DefaultCellStyle = DataGridViewCellStyle2
        Me.EmployeeName.HeaderText = "Name"
        Me.EmployeeName.MinimumWidth = 6
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeName.Width = 110
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone.DefaultCellStyle = DataGridViewCellStyle3
        Me.phone.HeaderText = "Phone"
        Me.phone.MinimumWidth = 6
        Me.phone.Name = "phone"
        Me.phone.Width = 125
        '
        'address
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.DefaultCellStyle = DataGridViewCellStyle4
        Me.address.HeaderText = "Address"
        Me.address.MinimumWidth = 6
        Me.address.Name = "address"
        Me.address.Width = 160
        '
        'gender
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.DefaultCellStyle = DataGridViewCellStyle5
        Me.gender.HeaderText = "Gender"
        Me.gender.MinimumWidth = 6
        Me.gender.Name = "gender"
        Me.gender.Width = 80
        '
        'birthday
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday.DefaultCellStyle = DataGridViewCellStyle6
        Me.birthday.HeaderText = "Birthday"
        Me.birthday.MinimumWidth = 6
        Me.birthday.Name = "birthday"
        Me.birthday.Width = 125
        '
        'email
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.DefaultCellStyle = DataGridViewCellStyle7
        Me.email.HeaderText = "Email"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.Width = 180
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.Visible = False
        Me.status.Width = 60
        '
        'lbl_TitleEmployee
        '
        Me.lbl_TitleEmployee.AutoSize = True
        Me.lbl_TitleEmployee.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TitleEmployee.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TitleEmployee.ForeColor = System.Drawing.Color.Ivory
        Me.lbl_TitleEmployee.Location = New System.Drawing.Point(354, 9)
        Me.lbl_TitleEmployee.Name = "lbl_TitleEmployee"
        Me.lbl_TitleEmployee.Size = New System.Drawing.Size(353, 45)
        Me.lbl_TitleEmployee.TabIndex = 25
        Me.lbl_TitleEmployee.Text = "EMPLOYEE LIST"
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(880, 194)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(220, 30)
        Me.txt_Search.TabIndex = 59
        '
        'lbl_Page
        '
        Me.lbl_Page.AutoSize = True
        Me.lbl_Page.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Page.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Page.ForeColor = System.Drawing.Color.Azure
        Me.lbl_Page.Location = New System.Drawing.Point(596, 642)
        Me.lbl_Page.Name = "lbl_Page"
        Me.lbl_Page.Size = New System.Drawing.Size(57, 23)
        Me.lbl_Page.TabIndex = 90
        Me.lbl_Page.Text = "Page "
        '
        'gbtn_Add
        '
        Me.gbtn_Add.BackColor = System.Drawing.Color.Transparent
        Me.gbtn_Add.BorderRadius = 8
        Me.gbtn_Add.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.gbtn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbtn_Add.CustomBorderColor = System.Drawing.Color.Transparent
        Me.gbtn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gbtn_Add.FillColor = System.Drawing.Color.MistyRose
        Me.gbtn_Add.FillColor2 = System.Drawing.Color.AntiqueWhite
        Me.gbtn_Add.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Add.Location = New System.Drawing.Point(19, 250)
        Me.gbtn_Add.Name = "gbtn_Add"
        Me.gbtn_Add.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Add.Size = New System.Drawing.Size(94, 35)
        Me.gbtn_Add.TabIndex = 94
        Me.gbtn_Add.Text = "Add"
        '
        'gbtn_Update
        '
        Me.gbtn_Update.BackColor = System.Drawing.Color.Transparent
        Me.gbtn_Update.BorderRadius = 8
        Me.gbtn_Update.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.gbtn_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbtn_Update.CustomBorderColor = System.Drawing.Color.Transparent
        Me.gbtn_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Update.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gbtn_Update.FillColor = System.Drawing.Color.MistyRose
        Me.gbtn_Update.FillColor2 = System.Drawing.Color.AntiqueWhite
        Me.gbtn_Update.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Update.Location = New System.Drawing.Point(133, 250)
        Me.gbtn_Update.Name = "gbtn_Update"
        Me.gbtn_Update.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Update.Size = New System.Drawing.Size(94, 35)
        Me.gbtn_Update.TabIndex = 95
        Me.gbtn_Update.Text = "Update"
        '
        'gbtn_Delete
        '
        Me.gbtn_Delete.BackColor = System.Drawing.Color.Transparent
        Me.gbtn_Delete.BorderRadius = 8
        Me.gbtn_Delete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.gbtn_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbtn_Delete.CustomBorderColor = System.Drawing.Color.Transparent
        Me.gbtn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gbtn_Delete.FillColor = System.Drawing.Color.MistyRose
        Me.gbtn_Delete.FillColor2 = System.Drawing.Color.AntiqueWhite
        Me.gbtn_Delete.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Delete.Location = New System.Drawing.Point(246, 250)
        Me.gbtn_Delete.Name = "gbtn_Delete"
        Me.gbtn_Delete.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Delete.Size = New System.Drawing.Size(94, 35)
        Me.gbtn_Delete.TabIndex = 96
        Me.gbtn_Delete.Text = "Delete"
        '
        'gbtn_Reset
        '
        Me.gbtn_Reset.BackColor = System.Drawing.Color.Transparent
        Me.gbtn_Reset.BorderRadius = 8
        Me.gbtn_Reset.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.gbtn_Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbtn_Reset.CustomBorderColor = System.Drawing.Color.Transparent
        Me.gbtn_Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Reset.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gbtn_Reset.FillColor = System.Drawing.Color.MistyRose
        Me.gbtn_Reset.FillColor2 = System.Drawing.Color.AntiqueWhite
        Me.gbtn_Reset.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Reset.Location = New System.Drawing.Point(360, 250)
        Me.gbtn_Reset.Name = "gbtn_Reset"
        Me.gbtn_Reset.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Reset.Size = New System.Drawing.Size(94, 35)
        Me.gbtn_Reset.TabIndex = 97
        Me.gbtn_Reset.Text = "Reset"
        '
        'gbtn_Clear
        '
        Me.gbtn_Clear.BackColor = System.Drawing.Color.Transparent
        Me.gbtn_Clear.BorderRadius = 8
        Me.gbtn_Clear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.gbtn_Clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbtn_Clear.CustomBorderColor = System.Drawing.Color.Transparent
        Me.gbtn_Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Clear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gbtn_Clear.FillColor = System.Drawing.Color.MistyRose
        Me.gbtn_Clear.FillColor2 = System.Drawing.Color.AntiqueWhite
        Me.gbtn_Clear.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Clear.Location = New System.Drawing.Point(475, 250)
        Me.gbtn_Clear.Name = "gbtn_Clear"
        Me.gbtn_Clear.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Clear.Size = New System.Drawing.Size(94, 35)
        Me.gbtn_Clear.TabIndex = 98
        Me.gbtn_Clear.Text = "Clear"
        '
        'gbtn_Upload
        '
        Me.gbtn_Upload.BackColor = System.Drawing.Color.Transparent
        Me.gbtn_Upload.BorderRadius = 8
        Me.gbtn_Upload.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.gbtn_Upload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbtn_Upload.CustomBorderColor = System.Drawing.Color.Transparent
        Me.gbtn_Upload.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Upload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Upload.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Upload.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Upload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gbtn_Upload.FillColor = System.Drawing.Color.MistyRose
        Me.gbtn_Upload.FillColor2 = System.Drawing.Color.AntiqueWhite
        Me.gbtn_Upload.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.gbtn_Upload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Upload.Location = New System.Drawing.Point(880, 131)
        Me.gbtn_Upload.Name = "gbtn_Upload"
        Me.gbtn_Upload.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Upload.Size = New System.Drawing.Size(142, 40)
        Me.gbtn_Upload.TabIndex = 99
        Me.gbtn_Upload.Text = "Choose File"
        '
        'gbtn_Search
        '
        Me.gbtn_Search.BackColor = System.Drawing.Color.Transparent
        Me.gbtn_Search.BorderRadius = 8
        Me.gbtn_Search.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.gbtn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbtn_Search.CustomBorderColor = System.Drawing.Color.Transparent
        Me.gbtn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Search.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gbtn_Search.FillColor = System.Drawing.Color.MistyRose
        Me.gbtn_Search.FillColor2 = System.Drawing.Color.AntiqueWhite
        Me.gbtn_Search.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Search.Location = New System.Drawing.Point(1114, 192)
        Me.gbtn_Search.Name = "gbtn_Search"
        Me.gbtn_Search.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Search.Size = New System.Drawing.Size(99, 35)
        Me.gbtn_Search.TabIndex = 100
        Me.gbtn_Search.Text = "Search"
        '
        'ptb_Previous
        '
        Me.ptb_Previous.BackColor = System.Drawing.Color.Transparent
        Me.ptb_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_Previous.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptb_Previous.FillColor = System.Drawing.Color.Transparent
        Me.ptb_Previous.Image = Global.Training01.My.Resources.Resources.left_arrow
        Me.ptb_Previous.ImageRotate = 0!
        Me.ptb_Previous.Location = New System.Drawing.Point(533, 640)
        Me.ptb_Previous.Name = "ptb_Previous"
        Me.ptb_Previous.Size = New System.Drawing.Size(25, 25)
        Me.ptb_Previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Previous.TabIndex = 103
        Me.ptb_Previous.TabStop = False
        '
        'ptb_Next
        '
        Me.ptb_Next.BackColor = System.Drawing.Color.Transparent
        Me.ptb_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptb_Next.FillColor = System.Drawing.Color.Transparent
        Me.ptb_Next.Image = Global.Training01.My.Resources.Resources.right_arrow__1_
        Me.ptb_Next.ImageRotate = 0!
        Me.ptb_Next.Location = New System.Drawing.Point(755, 642)
        Me.ptb_Next.Name = "ptb_Next"
        Me.ptb_Next.Size = New System.Drawing.Size(25, 25)
        Me.ptb_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Next.TabIndex = 104
        Me.ptb_Next.TabStop = False
        '
        'btn_EmpDept
        '
        Me.btn_EmpDept.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_EmpDept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_EmpDept.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EmpDept.Location = New System.Drawing.Point(591, 250)
        Me.btn_EmpDept.Name = "btn_EmpDept"
        Me.btn_EmpDept.Size = New System.Drawing.Size(166, 35)
        Me.btn_EmpDept.TabIndex = 105
        Me.btn_EmpDept.Text = "Emp In Dept"
        Me.btn_EmpDept.UseVisualStyleBackColor = False
        '
        'frm_Employee
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.tech_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1225, 685)
        Me.Controls.Add(Me.btn_EmpDept)
        Me.Controls.Add(Me.ptb_Next)
        Me.Controls.Add(Me.ptb_Previous)
        Me.Controls.Add(Me.gbtn_Search)
        Me.Controls.Add(Me.gbtn_Upload)
        Me.Controls.Add(Me.gbtn_Clear)
        Me.Controls.Add(Me.gbtn_Reset)
        Me.Controls.Add(Me.gbtn_Delete)
        Me.Controls.Add(Me.gbtn_Update)
        Me.Controls.Add(Me.gbtn_Add)
        Me.Controls.Add(Me.lbl_Page)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.dgrv_Employee)
        Me.Controls.Add(Me.ptb_Employee)
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
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ptb_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrv_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Previous, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Next, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents dgrv_Employee As DataGridView
    Friend WithEvents name1 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_TitleEmployee As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents lbl_Page As Label
    Friend WithEvents gbtn_Add As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Update As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Delete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Reset As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Clear As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Upload As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Search As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ptb_Previous As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ptb_Next As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents images As DataGridViewImageColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents birthday As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents btn_EmpDept As Button
End Class
