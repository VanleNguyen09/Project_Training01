﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmpInDept
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
        Me.dtp_ToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.cb_EmpCreate = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_DepCreate = New System.Windows.Forms.ComboBox()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.grb_create = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.dgv_DeptEmp = New System.Windows.Forms.DataGridView()
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
        Me.deptemp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_titleManager = New System.Windows.Forms.Label()
        Me.cb_Department = New System.Windows.Forms.ComboBox()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.ptb_Icon = New System.Windows.Forms.PictureBox()
        Me.grb_create.SuspendLayout()
        CType(Me.dgv_DeptEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label5.ForeColor = System.Drawing.Color.Lavender
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
        Me.Label1.ForeColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(9, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From Date"
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.Lavender
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
        Me.Label4.ForeColor = System.Drawing.Color.Lavender
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
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.Lavender
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.Black
        Me.btn_Clear.Location = New System.Drawing.Point(506, 192)
        Me.btn_Clear.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(203, 39)
        Me.btn_Clear.TabIndex = 98
        Me.btn_Clear.Text = "CLEAR"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.Color.Lavender
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.Black
        Me.btn_Search.Location = New System.Drawing.Point(415, 108)
        Me.btn_Search.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(271, 35)
        Me.btn_Search.TabIndex = 93
        Me.btn_Search.Text = "SEARCH"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(9, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department"
        '
        'btn_Update
        '
        Me.btn_Update.BackColor = System.Drawing.Color.Lavender
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.ForeColor = System.Drawing.Color.Black
        Me.btn_Update.Location = New System.Drawing.Point(506, 251)
        Me.btn_Update.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(203, 39)
        Me.btn_Update.TabIndex = 90
        Me.btn_Update.Text = "UPDATE"
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.Lavender
        Me.btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.ForeColor = System.Drawing.Color.Black
        Me.btn_Delete.Location = New System.Drawing.Point(732, 192)
        Me.btn_Delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(203, 39)
        Me.btn_Delete.TabIndex = 95
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
        Me.grb_create.ForeColor = System.Drawing.Color.Lavender
        Me.grb_create.Location = New System.Drawing.Point(42, 180)
        Me.grb_create.Margin = New System.Windows.Forms.Padding(4)
        Me.grb_create.Name = "grb_create"
        Me.grb_create.Padding = New System.Windows.Forms.Padding(4)
        Me.grb_create.Size = New System.Drawing.Size(436, 297)
        Me.grb_create.TabIndex = 96
        Me.grb_create.TabStop = False
        Me.grb_create.Text = "CREATE AND UPDATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lavender
        Me.Label6.Location = New System.Drawing.Point(42, 79)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Search"
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(165, 79)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(230, 30)
        Me.txt_Search.TabIndex = 91
        '
        'dgv_DeptEmp
        '
        Me.dgv_DeptEmp.AllowUserToAddRows = False
        Me.dgv_DeptEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DeptEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NO, Me.emp_id, Me.emp_name, Me.phone, Me.birthday, Me.address, Me.email, Me.department_name, Me.from_date, Me.to_date, Me.dept_id, Me.status, Me.deptemp_id})
        Me.dgv_DeptEmp.Location = New System.Drawing.Point(42, 491)
        Me.dgv_DeptEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_DeptEmp.Name = "dgv_DeptEmp"
        Me.dgv_DeptEmp.RowHeadersVisible = False
        Me.dgv_DeptEmp.RowHeadersWidth = 51
        Me.dgv_DeptEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_DeptEmp.Size = New System.Drawing.Size(1452, 363)
        Me.dgv_DeptEmp.TabIndex = 89
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
        Me.emp_name.Width = 130
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
        Me.birthday.Width = 140
        '
        'address
        '
        Me.address.HeaderText = "ADDRESS"
        Me.address.MinimumWidth = 6
        Me.address.Name = "address"
        Me.address.Width = 180
        '
        'email
        '
        Me.email.HeaderText = "EMAIL"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.Width = 180
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
        Me.from_date.Width = 140
        '
        'to_date
        '
        Me.to_date.HeaderText = "To Date"
        Me.to_date.MinimumWidth = 6
        Me.to_date.Name = "to_date"
        Me.to_date.Width = 140
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
        Me.status.Width = 50
        '
        'deptemp_id
        '
        Me.deptemp_id.HeaderText = "DeptEmp ID"
        Me.deptemp_id.MinimumWidth = 6
        Me.deptemp_id.Name = "deptemp_id"
        Me.deptemp_id.Visible = False
        Me.deptemp_id.Width = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lavender
        Me.Label2.Location = New System.Drawing.Point(42, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Department"
        '
        'lbl_titleManager
        '
        Me.lbl_titleManager.AutoSize = True
        Me.lbl_titleManager.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titleManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titleManager.ForeColor = System.Drawing.Color.Lavender
        Me.lbl_titleManager.Location = New System.Drawing.Point(243, 32)
        Me.lbl_titleManager.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_titleManager.Name = "lbl_titleManager"
        Me.lbl_titleManager.Size = New System.Drawing.Size(637, 39)
        Me.lbl_titleManager.TabIndex = 86
        Me.lbl_titleManager.Text = "EMPLOYEES LIST BY DEPARTMENT"
        '
        'cb_Department
        '
        Me.cb_Department.AllowDrop = True
        Me.cb_Department.DropDownHeight = 200
        Me.cb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Department.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Department.FormattingEnabled = True
        Me.cb_Department.IntegralHeight = False
        Me.cb_Department.Location = New System.Drawing.Point(166, 132)
        Me.cb_Department.Name = "cb_Department"
        Me.cb_Department.Size = New System.Drawing.Size(229, 30)
        Me.cb_Department.TabIndex = 85
        '
        'btn_Reset
        '
        Me.btn_Reset.BackColor = System.Drawing.Color.Lavender
        Me.btn_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Reset.ForeColor = System.Drawing.Color.Black
        Me.btn_Reset.Location = New System.Drawing.Point(732, 251)
        Me.btn_Reset.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(203, 39)
        Me.btn_Reset.TabIndex = 99
        Me.btn_Reset.Text = "RESET"
        Me.btn_Reset.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.Lavender
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.Black
        Me.btn_Exit.Location = New System.Drawing.Point(506, 305)
        Me.btn_Exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(203, 39)
        Me.btn_Exit.TabIndex = 100
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'ptb_Icon
        '
        Me.ptb_Icon.BackColor = System.Drawing.SystemColors.Control
        Me.ptb_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_Icon.ErrorImage = Nothing
        Me.ptb_Icon.Image = Global.Training01.My.Resources.Resources.blue_exit_icon_16
        Me.ptb_Icon.Location = New System.Drawing.Point(1521, 0)
        Me.ptb_Icon.Name = "ptb_Icon"
        Me.ptb_Icon.Size = New System.Drawing.Size(43, 40)
        Me.ptb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Icon.TabIndex = 101
        Me.ptb_Icon.TabStop = False
        '
        'frm_EmpInDept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1562, 954)
        Me.Controls.Add(Me.ptb_Icon)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.grb_create)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.dgv_DeptEmp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_titleManager)
        Me.Controls.Add(Me.cb_Department)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_EmpInDept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmpInDept"
        Me.grb_create.ResumeLayout(False)
        Me.grb_create.PerformLayout()
        CType(Me.dgv_DeptEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dtp_ToDate As DateTimePicker
    Private WithEvents dtp_FromDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Add As Button
    Friend WithEvents cb_EmpCreate As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_DepCreate As ComboBox
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Search As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents grb_create As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents dgv_DeptEmp As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_titleManager As Label
    Friend WithEvents cb_Department As ComboBox
    Friend WithEvents btn_Reset As Button
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
    Friend WithEvents deptemp_id As DataGridViewTextBoxColumn
    Friend WithEvents btn_Exit As Button
    Friend WithEvents ptb_Icon As PictureBox
End Class
