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
        Me.lbl_TitleEmployee = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_Department = New System.Windows.Forms.Label()
        Me.cb_Department = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgrv_Employee = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrv_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.Silver
        Me.btn_Close.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.Location = New System.Drawing.Point(525, 489)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(141, 47)
        Me.btn_Close.TabIndex = 47
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
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
        Me.txt_Email.Size = New System.Drawing.Size(285, 30)
        Me.txt_Email.TabIndex = 40
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email.Location = New System.Drawing.Point(17, 399)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(65, 23)
        Me.lbl_Email.TabIndex = 39
        Me.lbl_Email.Text = "Email:"
        '
        'dtp_Birthday
        '
        Me.dtp_Birthday.CalendarFont = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Birthday.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Birthday.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Birthday.Location = New System.Drawing.Point(158, 298)
        Me.dtp_Birthday.Name = "dtp_Birthday"
        Me.dtp_Birthday.Size = New System.Drawing.Size(239, 33)
        Me.dtp_Birthday.TabIndex = 38
        Me.dtp_Birthday.Value = New Date(2023, 5, 16, 0, 0, 0, 0)
        '
        'lbl_Birthday
        '
        Me.lbl_Birthday.AutoSize = True
        Me.lbl_Birthday.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Birthday.Location = New System.Drawing.Point(16, 306)
        Me.lbl_Birthday.Name = "lbl_Birthday"
        Me.lbl_Birthday.Size = New System.Drawing.Size(90, 23)
        Me.lbl_Birthday.TabIndex = 37
        Me.lbl_Birthday.Text = "Birthday:"
        '
        'rdo_Female
        '
        Me.rdo_Female.AutoSize = True
        Me.rdo_Female.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Female.Location = New System.Drawing.Point(284, 253)
        Me.rdo_Female.Name = "rdo_Female"
        Me.rdo_Female.Size = New System.Drawing.Size(89, 26)
        Me.rdo_Female.TabIndex = 36
        Me.rdo_Female.TabStop = True
        Me.rdo_Female.Text = "Female"
        Me.rdo_Female.UseVisualStyleBackColor = True
        '
        'rdo_Male
        '
        Me.rdo_Male.AutoSize = True
        Me.rdo_Male.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lbl_Gender.Location = New System.Drawing.Point(16, 254)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(81, 23)
        Me.lbl_Gender.TabIndex = 34
        Me.lbl_Gender.Text = "Gender:"
        '
        'txt_Address
        '
        Me.txt_Address.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address.Location = New System.Drawing.Point(158, 192)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(334, 30)
        Me.txt_Address.TabIndex = 33
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address.Location = New System.Drawing.Point(16, 199)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(85, 23)
        Me.lbl_Address.TabIndex = 32
        Me.lbl_Address.Text = "Address:"
        '
        'txt_Phone
        '
        Me.txt_Phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Phone.Location = New System.Drawing.Point(602, 82)
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(248, 30)
        Me.txt_Phone.TabIndex = 31
        '
        'lbl_Phone
        '
        Me.lbl_Phone.AutoSize = True
        Me.lbl_Phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Phone.Location = New System.Drawing.Point(444, 84)
        Me.lbl_Phone.Name = "lbl_Phone"
        Me.lbl_Phone.Size = New System.Drawing.Size(69, 23)
        Me.lbl_Phone.TabIndex = 30
        Me.lbl_Phone.Text = "Phone:"
        '
        'txt_Name
        '
        Me.txt_Name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Name.Location = New System.Drawing.Point(158, 135)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(239, 30)
        Me.txt_Name.TabIndex = 29
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(16, 142)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(66, 23)
        Me.lbl_Name.TabIndex = 28
        Me.lbl_Name.Text = "Name:"
        '
        'txt_EmployeeID
        '
        Me.txt_EmployeeID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmployeeID.Location = New System.Drawing.Point(158, 82)
        Me.txt_EmployeeID.Name = "txt_EmployeeID"
        Me.txt_EmployeeID.Size = New System.Drawing.Size(215, 30)
        Me.txt_EmployeeID.TabIndex = 27
        '
        'lbl_EmployeeID
        '
        Me.lbl_EmployeeID.AutoSize = True
        Me.lbl_EmployeeID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EmployeeID.Location = New System.Drawing.Point(16, 79)
        Me.lbl_EmployeeID.Name = "lbl_EmployeeID"
        Me.lbl_EmployeeID.Size = New System.Drawing.Size(122, 23)
        Me.lbl_EmployeeID.TabIndex = 26
        Me.lbl_EmployeeID.Text = "Employee Id:"
        '
        'lbl_TitleEmployee
        '
        Me.lbl_TitleEmployee.AutoSize = True
        Me.lbl_TitleEmployee.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TitleEmployee.ForeColor = System.Drawing.Color.Red
        Me.lbl_TitleEmployee.Location = New System.Drawing.Point(299, 9)
        Me.lbl_TitleEmployee.Name = "lbl_TitleEmployee"
        Me.lbl_TitleEmployee.Size = New System.Drawing.Size(353, 45)
        Me.lbl_TitleEmployee.TabIndex = 25
        Me.lbl_TitleEmployee.Text = "EMPLOYEE LIST"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(668, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 47)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbl_Department
        '
        Me.lbl_Department.AutoSize = True
        Me.lbl_Department.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Department.Location = New System.Drawing.Point(17, 352)
        Me.lbl_Department.Name = "lbl_Department"
        Me.lbl_Department.Size = New System.Drawing.Size(118, 23)
        Me.lbl_Department.TabIndex = 52
        Me.lbl_Department.Text = "Department:"
        '
        'cb_Department
        '
        Me.cb_Department.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Department.FormattingEnabled = True
        Me.cb_Department.Location = New System.Drawing.Point(158, 351)
        Me.cb_Department.Name = "cb_Department"
        Me.cb_Department.Size = New System.Drawing.Size(286, 30)
        Me.cb_Department.TabIndex = 53
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Training01.My.Resources.Resources.avatar2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(574, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'dgrv_Employee
        '
        Me.dgrv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrv_Employee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.EmployeeName, Me.phone, Me.address, Me.gender, Me.birthday, Me.email})
        Me.dgrv_Employee.Location = New System.Drawing.Point(35, 612)
        Me.dgrv_Employee.Name = "dgrv_Employee"
        Me.dgrv_Employee.RowHeadersWidth = 51
        Me.dgrv_Employee.RowTemplate.Height = 24
        Me.dgrv_Employee.Size = New System.Drawing.Size(868, 190)
        Me.dgrv_Employee.TabIndex = 54
        '
        'Column1
        '
        Me.Column1.HeaderText = "EmployeeID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'EmployeeName
        '
        Me.EmployeeName.HeaderText = "Name"
        Me.EmployeeName.MinimumWidth = 6
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Width = 125
        '
        'phone
        '
        Me.phone.HeaderText = "Phone"
        Me.phone.MinimumWidth = 6
        Me.phone.Name = "phone"
        Me.phone.Width = 125
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.MinimumWidth = 6
        Me.address.Name = "address"
        Me.address.Width = 125
        '
        'gender
        '
        Me.gender.HeaderText = "Gender"
        Me.gender.MinimumWidth = 6
        Me.gender.Name = "gender"
        Me.gender.Width = 125
        '
        'birthday
        '
        Me.birthday.HeaderText = "Birthday"
        Me.birthday.MinimumWidth = 6
        Me.birthday.Name = "birthday"
        Me.birthday.Width = 125
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.Width = 125
        '
        'frm_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1347, 881)
        Me.Controls.Add(Me.dgrv_Employee)
        Me.Controls.Add(Me.cb_Department)
        Me.Controls.Add(Me.lbl_Department)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "employees"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbl_TitleEmployee As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_Department As Label
    Friend WithEvents cb_Department As ComboBox
    Friend WithEvents dgrv_Employee As DataGridView
    Friend WithEvents name1 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents birthday As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
End Class
