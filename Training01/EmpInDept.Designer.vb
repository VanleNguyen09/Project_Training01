﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_EmpInDept
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
        Me.dtp_ToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_EmpCreate = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_DepCreate = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grb_create = New System.Windows.Forms.GroupBox()
        Me.gbtn_Add = New Guna.UI2.WinForms.Guna2GradientButton()
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
        Me.ptb_Icon = New System.Windows.Forms.PictureBox()
        Me.ptb_Next = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ptb_Previous = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_Page = New System.Windows.Forms.Label()
        Me.gbtn_Clear = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Exit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Update = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Reset = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Delete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Search = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.grb_create.SuspendLayout()
        CType(Me.dgv_DeptEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Next, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Previous, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'grb_create
        '
        Me.grb_create.BackColor = System.Drawing.Color.Transparent
        Me.grb_create.Controls.Add(Me.gbtn_Add)
        Me.grb_create.Controls.Add(Me.dtp_ToDate)
        Me.grb_create.Controls.Add(Me.dtp_FromDate)
        Me.grb_create.Controls.Add(Me.Label5)
        Me.grb_create.Controls.Add(Me.Label1)
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
        Me.gbtn_Add.FillColor = System.Drawing.Color.Orchid
        Me.gbtn_Add.FillColor2 = System.Drawing.Color.Aqua
        Me.gbtn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Add.Location = New System.Drawing.Point(121, 236)
        Me.gbtn_Add.Name = "gbtn_Add"
        Me.gbtn_Add.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Add.Size = New System.Drawing.Size(267, 39)
        Me.gbtn_Add.TabIndex = 102
        Me.gbtn_Add.Text = "ADD"
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
        Me.dgv_DeptEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_DeptEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DeptEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NO, Me.emp_id, Me.emp_name, Me.phone, Me.birthday, Me.address, Me.email, Me.department_name, Me.from_date, Me.to_date, Me.dept_id, Me.status, Me.deptemp_id})
        Me.dgv_DeptEmp.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_DeptEmp.Location = New System.Drawing.Point(42, 491)
        Me.dgv_DeptEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_DeptEmp.Name = "dgv_DeptEmp"
        Me.dgv_DeptEmp.RowHeadersVisible = False
        Me.dgv_DeptEmp.RowHeadersWidth = 51
        Me.dgv_DeptEmp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_DeptEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_DeptEmp.Size = New System.Drawing.Size(1399, 303)
        Me.dgv_DeptEmp.TabIndex = 89
        '
        'NO
        '
        Me.NO.HeaderText = "NO"
        Me.NO.MinimumWidth = 6
        Me.NO.Name = "NO"
        Me.NO.ReadOnly = True
        Me.NO.Width = 50
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
        Me.emp_name.Width = 120
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
        'ptb_Icon
        '
        Me.ptb_Icon.BackColor = System.Drawing.Color.Transparent
        Me.ptb_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_Icon.ErrorImage = Nothing
        Me.ptb_Icon.Image = Global.Training01.My.Resources.Resources.blue_exit_icon_16
        Me.ptb_Icon.Location = New System.Drawing.Point(1471, 0)
        Me.ptb_Icon.Name = "ptb_Icon"
        Me.ptb_Icon.Size = New System.Drawing.Size(43, 40)
        Me.ptb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Icon.TabIndex = 101
        Me.ptb_Icon.TabStop = False
        '
        'ptb_Next
        '
        Me.ptb_Next.BackColor = System.Drawing.Color.Transparent
        Me.ptb_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptb_Next.FillColor = System.Drawing.Color.Transparent
        Me.ptb_Next.Image = Global.Training01.My.Resources.Resources.right_arrow__1_
        Me.ptb_Next.ImageRotate = 0!
        Me.ptb_Next.Location = New System.Drawing.Point(779, 815)
        Me.ptb_Next.Name = "ptb_Next"
        Me.ptb_Next.Size = New System.Drawing.Size(48, 32)
        Me.ptb_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Next.TabIndex = 107
        Me.ptb_Next.TabStop = False
        '
        'ptb_Previous
        '
        Me.ptb_Previous.BackColor = System.Drawing.Color.Transparent
        Me.ptb_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_Previous.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptb_Previous.FillColor = System.Drawing.Color.Transparent
        Me.ptb_Previous.Image = Global.Training01.My.Resources.Resources.left_arrow
        Me.ptb_Previous.ImageRotate = 0!
        Me.ptb_Previous.Location = New System.Drawing.Point(524, 815)
        Me.ptb_Previous.Name = "ptb_Previous"
        Me.ptb_Previous.Size = New System.Drawing.Size(48, 32)
        Me.ptb_Previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Previous.TabIndex = 106
        Me.ptb_Previous.TabStop = False
        '
        'lbl_Page
        '
        Me.lbl_Page.AutoSize = True
        Me.lbl_Page.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Page.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Page.ForeColor = System.Drawing.Color.Azure
        Me.lbl_Page.Location = New System.Drawing.Point(599, 815)
        Me.lbl_Page.Name = "lbl_Page"
        Me.lbl_Page.Size = New System.Drawing.Size(79, 32)
        Me.lbl_Page.TabIndex = 105
        Me.lbl_Page.Text = "Page "
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
        Me.gbtn_Clear.FillColor = System.Drawing.Color.Orchid
        Me.gbtn_Clear.FillColor2 = System.Drawing.Color.Aqua
        Me.gbtn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Clear.Location = New System.Drawing.Point(506, 192)
        Me.gbtn_Clear.Name = "gbtn_Clear"
        Me.gbtn_Clear.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Clear.Size = New System.Drawing.Size(203, 39)
        Me.gbtn_Clear.TabIndex = 103
        Me.gbtn_Clear.Text = "CLEAR"
        '
        'gbtn_Exit
        '
        Me.gbtn_Exit.BackColor = System.Drawing.Color.Transparent
        Me.gbtn_Exit.BorderRadius = 8
        Me.gbtn_Exit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.gbtn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbtn_Exit.CustomBorderColor = System.Drawing.Color.Transparent
        Me.gbtn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Exit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gbtn_Exit.FillColor = System.Drawing.Color.Orchid
        Me.gbtn_Exit.FillColor2 = System.Drawing.Color.Aqua
        Me.gbtn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Exit.Location = New System.Drawing.Point(506, 318)
        Me.gbtn_Exit.Name = "gbtn_Exit"
        Me.gbtn_Exit.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Exit.Size = New System.Drawing.Size(203, 39)
        Me.gbtn_Exit.TabIndex = 108
        Me.gbtn_Exit.Text = "EXIT"
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
        Me.gbtn_Update.FillColor = System.Drawing.Color.Orchid
        Me.gbtn_Update.FillColor2 = System.Drawing.Color.Aqua
        Me.gbtn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Update.Location = New System.Drawing.Point(506, 251)
        Me.gbtn_Update.Name = "gbtn_Update"
        Me.gbtn_Update.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Update.Size = New System.Drawing.Size(203, 39)
        Me.gbtn_Update.TabIndex = 109
        Me.gbtn_Update.Text = "UPDATE"
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
        Me.gbtn_Reset.FillColor = System.Drawing.Color.Orchid
        Me.gbtn_Reset.FillColor2 = System.Drawing.Color.Aqua
        Me.gbtn_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Reset.Location = New System.Drawing.Point(732, 251)
        Me.gbtn_Reset.Name = "gbtn_Reset"
        Me.gbtn_Reset.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Reset.Size = New System.Drawing.Size(203, 39)
        Me.gbtn_Reset.TabIndex = 110
        Me.gbtn_Reset.Text = "RESET"
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
        Me.gbtn_Delete.FillColor = System.Drawing.Color.Orchid
        Me.gbtn_Delete.FillColor2 = System.Drawing.Color.Aqua
        Me.gbtn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Delete.Location = New System.Drawing.Point(732, 192)
        Me.gbtn_Delete.Name = "gbtn_Delete"
        Me.gbtn_Delete.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Delete.Size = New System.Drawing.Size(203, 39)
        Me.gbtn_Delete.TabIndex = 111
        Me.gbtn_Delete.Text = "REMOVE"
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
        Me.gbtn_Search.FillColor = System.Drawing.Color.Orchid
        Me.gbtn_Search.FillColor2 = System.Drawing.Color.Aqua
        Me.gbtn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Search.Location = New System.Drawing.Point(431, 102)
        Me.gbtn_Search.Name = "gbtn_Search"
        Me.gbtn_Search.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Search.Size = New System.Drawing.Size(278, 39)
        Me.gbtn_Search.TabIndex = 112
        Me.gbtn_Search.Text = "SEARCH"
        '
        'frm_EmpInDept
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.tech_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1517, 916)
        Me.Controls.Add(Me.gbtn_Search)
        Me.Controls.Add(Me.gbtn_Delete)
        Me.Controls.Add(Me.gbtn_Reset)
        Me.Controls.Add(Me.gbtn_Update)
        Me.Controls.Add(Me.gbtn_Exit)
        Me.Controls.Add(Me.gbtn_Clear)
        Me.Controls.Add(Me.ptb_Next)
        Me.Controls.Add(Me.ptb_Previous)
        Me.Controls.Add(Me.lbl_Page)
        Me.Controls.Add(Me.ptb_Icon)
        Me.Controls.Add(Me.grb_create)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.dgv_DeptEmp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_titleManager)
        Me.Controls.Add(Me.cb_Department)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_EmpInDept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmpInDept"
        Me.grb_create.ResumeLayout(False)
        Me.grb_create.PerformLayout()
        CType(Me.dgv_DeptEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Next, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Previous, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dtp_ToDate As DateTimePicker
    Private WithEvents dtp_FromDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_EmpCreate As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_DepCreate As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents grb_create As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents dgv_DeptEmp As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_titleManager As Label
    Friend WithEvents cb_Department As ComboBox
    Friend WithEvents ptb_Icon As PictureBox
    Friend WithEvents ptb_Next As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ptb_Previous As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_Page As Label
    Friend WithEvents gbtn_Add As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Clear As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Exit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Update As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Reset As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Delete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Search As Guna.UI2.WinForms.Guna2GradientButton
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
End Class
