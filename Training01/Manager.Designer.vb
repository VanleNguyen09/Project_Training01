<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Manager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cb_Department = New System.Windows.Forms.ComboBox()
        Me.lbl_titleManager = New System.Windows.Forms.Label()
        Me.ptb_Icon = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_DeptManager = New System.Windows.Forms.DataGridView()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Manage = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.grb_create = New System.Windows.Forms.GroupBox()
        Me.dtp_ToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.cb_EmpCreate = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_DepCreate = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.from_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.to_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ptb_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_DeptManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_create.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_Department
        '
        Me.cb_Department.AllowDrop = True
        Me.cb_Department.DropDownHeight = 200
        Me.cb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Department.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Department.FormattingEnabled = True
        Me.cb_Department.IntegralHeight = False
        Me.cb_Department.Location = New System.Drawing.Point(137, 109)
        Me.cb_Department.Name = "cb_Department"
        Me.cb_Department.Size = New System.Drawing.Size(229, 30)
        Me.cb_Department.TabIndex = 54
        '
        'lbl_titleManager
        '
        Me.lbl_titleManager.AutoSize = True
        Me.lbl_titleManager.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titleManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titleManager.ForeColor = System.Drawing.Color.Linen
        Me.lbl_titleManager.Location = New System.Drawing.Point(214, 9)
        Me.lbl_titleManager.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_titleManager.Name = "lbl_titleManager"
        Me.lbl_titleManager.Size = New System.Drawing.Size(622, 39)
        Me.lbl_titleManager.TabIndex = 55
        Me.lbl_titleManager.Text = "MANAGERS LIST BY DEPARTMENT"
        '
        'ptb_Icon
        '
        Me.ptb_Icon.BackColor = System.Drawing.SystemColors.Control
        Me.ptb_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_Icon.ErrorImage = Nothing
        Me.ptb_Icon.Image = Global.Training01.My.Resources.Resources.blue_exit_icon_16
        Me.ptb_Icon.Location = New System.Drawing.Point(1484, 0)
        Me.ptb_Icon.Name = "ptb_Icon"
        Me.ptb_Icon.Size = New System.Drawing.Size(43, 37)
        Me.ptb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Icon.TabIndex = 68
        Me.ptb_Icon.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Linen
        Me.Label2.Location = New System.Drawing.Point(13, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Department"
        '
        'dgv_DeptManager
        '
        Me.dgv_DeptManager.AllowUserToAddRows = False
        Me.dgv_DeptManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DeptManager.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NO, Me.emp_id, Me.emp_name, Me.phone, Me.birthday, Me.address, Me.email, Me.department_name, Me.from_date, Me.to_date, Me.dept_id, Me.status})
        Me.dgv_DeptManager.Location = New System.Drawing.Point(2, 482)
        Me.dgv_DeptManager.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_DeptManager.Name = "dgv_DeptManager"
        Me.dgv_DeptManager.RowHeadersVisible = False
        Me.dgv_DeptManager.RowHeadersWidth = 51
        Me.dgv_DeptManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_DeptManager.Size = New System.Drawing.Size(1525, 397)
        Me.dgv_DeptManager.TabIndex = 70
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(136, 56)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(230, 30)
        Me.txt_Search.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Linen
        Me.Label6.Location = New System.Drawing.Point(13, 56)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Search"
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.Color.Linen
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.Black
        Me.btn_Search.Location = New System.Drawing.Point(386, 85)
        Me.btn_Search.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(271, 35)
        Me.btn_Search.TabIndex = 79
        Me.btn_Search.Text = "SEARCH"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.Linen
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.Black
        Me.btn_Clear.Location = New System.Drawing.Point(482, 237)
        Me.btn_Clear.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(203, 39)
        Me.btn_Clear.TabIndex = 84
        Me.btn_Clear.Text = "CLEAR"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.Linen
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.Black
        Me.btn_Exit.Location = New System.Drawing.Point(482, 295)
        Me.btn_Exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(203, 39)
        Me.btn_Exit.TabIndex = 83
        Me.btn_Exit.Text = "EXIT"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_Manage
        '
        Me.btn_Manage.BackColor = System.Drawing.Color.Linen
        Me.btn_Manage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Manage.ForeColor = System.Drawing.Color.Black
        Me.btn_Manage.Location = New System.Drawing.Point(482, 171)
        Me.btn_Manage.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Manage.Name = "btn_Manage"
        Me.btn_Manage.Size = New System.Drawing.Size(429, 39)
        Me.btn_Manage.TabIndex = 80
        Me.btn_Manage.Text = "MANAGE DEPARTMENT"
        Me.btn_Manage.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.Linen
        Me.btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.ForeColor = System.Drawing.Color.Black
        Me.btn_Delete.Location = New System.Drawing.Point(708, 239)
        Me.btn_Delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(203, 35)
        Me.btn_Delete.TabIndex = 81
        Me.btn_Delete.Text = "REMOVE"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'grb_create
        '
        Me.grb_create.BackColor = System.Drawing.Color.Transparent
        Me.grb_create.Controls.Add(Me.dtp_ToDate)
        Me.grb_create.Controls.Add(Me.dtp_FromDate)
        Me.grb_create.Controls.Add(Me.Label5)
        Me.grb_create.Controls.Add(Me.Label1)
        Me.grb_create.Controls.Add(Me.btn_Add)
        Me.grb_create.Controls.Add(Me.cb_EmpCreate)
        Me.grb_create.Controls.Add(Me.Label4)
        Me.grb_create.Controls.Add(Me.cb_DepCreate)
        Me.grb_create.Controls.Add(Me.Label3)
        Me.grb_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_create.ForeColor = System.Drawing.Color.Linen
        Me.grb_create.Location = New System.Drawing.Point(13, 157)
        Me.grb_create.Margin = New System.Windows.Forms.Padding(4)
        Me.grb_create.Name = "grb_create"
        Me.grb_create.Padding = New System.Windows.Forms.Padding(4)
        Me.grb_create.Size = New System.Drawing.Size(436, 297)
        Me.grb_create.TabIndex = 82
        Me.grb_create.TabStop = False
        Me.grb_create.Text = "CREATE"
        '
        'dtp_ToDate
        '
        Me.dtp_ToDate.AllowDrop = True
        Me.dtp_ToDate.CalendarFont = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ToDate.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtp_ToDate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ToDate.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ToDate.Location = New System.Drawing.Point(121, 197)
        Me.dtp_ToDate.Name = "dtp_ToDate"
        Me.dtp_ToDate.Size = New System.Drawing.Size(267, 33)
        Me.dtp_ToDate.TabIndex = 74
        Me.dtp_ToDate.Value = New Date(2023, 5, 24, 0, 0, 0, 0)
        '
        'dtp_FromDate
        '
        Me.dtp_FromDate.AllowDrop = True
        Me.dtp_FromDate.CalendarFont = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FromDate.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtp_FromDate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_FromDate.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FromDate.Location = New System.Drawing.Point(119, 144)
        Me.dtp_FromDate.Name = "dtp_FromDate"
        Me.dtp_FromDate.Size = New System.Drawing.Size(267, 33)
        Me.dtp_FromDate.TabIndex = 73
        Me.dtp_FromDate.Value = New Date(2023, 5, 24, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Linen
        Me.Label5.Location = New System.Drawing.Point(9, 197)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "To Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Linen
        Me.Label1.Location = New System.Drawing.Point(9, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From Date"
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.Linen
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.Black
        Me.btn_Add.Location = New System.Drawing.Point(119, 239)
        Me.btn_Add.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(267, 39)
        Me.btn_Add.TabIndex = 3
        Me.btn_Add.Text = "ADD"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'cb_EmpCreate
        '
        Me.cb_EmpCreate.DropDownHeight = 200
        Me.cb_EmpCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_EmpCreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_EmpCreate.FormattingEnabled = True
        Me.cb_EmpCreate.IntegralHeight = False
        Me.cb_EmpCreate.ItemHeight = 22
        Me.cb_EmpCreate.Location = New System.Drawing.Point(121, 89)
        Me.cb_EmpCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_EmpCreate.Name = "cb_EmpCreate"
        Me.cb_EmpCreate.Size = New System.Drawing.Size(265, 30)
        Me.cb_EmpCreate.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Linen
        Me.Label4.Location = New System.Drawing.Point(9, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Employee"
        '
        'cb_DepCreate
        '
        Me.cb_DepCreate.DropDownHeight = 200
        Me.cb_DepCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_DepCreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_DepCreate.FormattingEnabled = True
        Me.cb_DepCreate.IntegralHeight = False
        Me.cb_DepCreate.Location = New System.Drawing.Point(121, 43)
        Me.cb_DepCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_DepCreate.Name = "cb_DepCreate"
        Me.cb_DepCreate.Size = New System.Drawing.Size(265, 30)
        Me.cb_DepCreate.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Linen
        Me.Label3.Location = New System.Drawing.Point(9, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department"
        '
        'btn_Update
        '
        Me.btn_Update.BackColor = System.Drawing.Color.Linen
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.ForeColor = System.Drawing.Color.Black
        Me.btn_Update.Location = New System.Drawing.Point(708, 295)
        Me.btn_Update.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(203, 39)
        Me.btn_Update.TabIndex = 85
        Me.btn_Update.Text = "UPDATE"
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'NO
        '
        Me.NO.HeaderText = "NO"
        Me.NO.MinimumWidth = 6
        Me.NO.Name = "NO"
        Me.NO.ReadOnly = True
        Me.NO.Width = 80
        '
        'emp_id
        '
        Me.emp_id.HeaderText = "Emp ID"
        Me.emp_id.MinimumWidth = 6
        Me.emp_id.Name = "emp_id"
        Me.emp_id.Visible = False
        Me.emp_id.Width = 50
        '
        'emp_name
        '
        Me.emp_name.HeaderText = "NAME"
        Me.emp_name.MinimumWidth = 6
        Me.emp_name.Name = "emp_name"
        Me.emp_name.Width = 125
        '
        'phone
        '
        Me.phone.HeaderText = "PHONE"
        Me.phone.MinimumWidth = 6
        Me.phone.Name = "phone"
        Me.phone.Width = 125
        '
        'birthday
        '
        Me.birthday.HeaderText = "BIRTHDAY"
        Me.birthday.MinimumWidth = 6
        Me.birthday.Name = "birthday"
        Me.birthday.Width = 125
        '
        'address
        '
        Me.address.HeaderText = "ADDRESS"
        Me.address.MinimumWidth = 6
        Me.address.Name = "address"
        Me.address.Width = 125
        '
        'email
        '
        Me.email.HeaderText = "EMAIL"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.Width = 150
        '
        'department_name
        '
        Me.department_name.HeaderText = "Department"
        Me.department_name.MinimumWidth = 6
        Me.department_name.Name = "department_name"
        Me.department_name.Width = 125
        '
        'from_date
        '
        Me.from_date.HeaderText = "From Date"
        Me.from_date.MinimumWidth = 6
        Me.from_date.Name = "from_date"
        Me.from_date.Width = 125
        '
        'to_date
        '
        Me.to_date.HeaderText = "To Date"
        Me.to_date.MinimumWidth = 6
        Me.to_date.Name = "to_date"
        Me.to_date.Width = 125
        '
        'dept_id
        '
        Me.dept_id.HeaderText = "Department ID"
        Me.dept_id.MinimumWidth = 6
        Me.dept_id.Name = "dept_id"
        Me.dept_id.Visible = False
        Me.dept_id.Width = 125
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.Visible = False
        Me.status.Width = 125
        '
        'frm_Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1586, 966)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Manage)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.grb_create)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.dgv_DeptManager)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ptb_Icon)
        Me.Controls.Add(Me.lbl_titleManager)
        Me.Controls.Add(Me.cb_Department)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Manager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ptb_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_DeptManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_create.ResumeLayout(False)
        Me.grb_create.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_Department As ComboBox
    Friend WithEvents lbl_titleManager As Label
    Friend WithEvents ptb_Icon As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_DeptManager As DataGridView
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_Search As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Manage As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents grb_create As GroupBox
    Private WithEvents dtp_ToDate As DateTimePicker
    Private WithEvents dtp_FromDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Add As Button
    Friend WithEvents cb_EmpCreate As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_DepCreate As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Update As Button
    Friend WithEvents NO As DataGridViewTextBoxColumn
    Friend WithEvents emp_id As DataGridViewTextBoxColumn
    Friend WithEvents emp_name As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents birthday As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents department_name As DataGridViewTextBoxColumn
    Friend WithEvents from_date As DataGridViewTextBoxColumn
    Friend WithEvents to_date As DataGridViewTextBoxColumn
    Friend WithEvents dept_id As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
