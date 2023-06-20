<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Department
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_TitleDepartment = New System.Windows.Forms.Label()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.dgrv_Department = New System.Windows.Forms.DataGridView()
        Me.lbl_Search = New System.Windows.Forms.Label()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.gbtn_Add = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Update = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Delete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Reset = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Clear = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtn_Search = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ptb_Next = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ptb_Previous = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_Page = New System.Windows.Forms.Label()
        Me.ckb_Delete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Number_Manager = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgrv_Department, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Next, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Previous, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_TitleDepartment
        '
        Me.lbl_TitleDepartment.AutoSize = True
        Me.lbl_TitleDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TitleDepartment.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TitleDepartment.ForeColor = System.Drawing.Color.Linen
        Me.lbl_TitleDepartment.Location = New System.Drawing.Point(371, 9)
        Me.lbl_TitleDepartment.Name = "lbl_TitleDepartment"
        Me.lbl_TitleDepartment.Size = New System.Drawing.Size(404, 45)
        Me.lbl_TitleDepartment.TabIndex = 26
        Me.lbl_TitleDepartment.Text = "DEPARTMENT LIST"
        Me.lbl_TitleDepartment.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_Name
        '
        Me.txt_Name.AllowDrop = True
        Me.txt_Name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Name.Location = New System.Drawing.Point(207, 71)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(190, 30)
        Me.txt_Name.TabIndex = 32
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.ForeColor = System.Drawing.Color.Linen
        Me.lbl_Name.Location = New System.Drawing.Point(44, 71)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(66, 23)
        Me.lbl_Name.TabIndex = 33
        Me.lbl_Name.Text = "Name:"
        '
        'dgrv_Department
        '
        Me.dgrv_Department.AllowUserToAddRows = False
        Me.dgrv_Department.AllowUserToOrderColumns = True
        Me.dgrv_Department.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgrv_Department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrv_Department.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.department_id, Me.department_name, Me.status, Me.Number_Emp, Me.Number_Manager, Me.ckb_Delete})
        Me.dgrv_Department.Location = New System.Drawing.Point(444, 71)
        Me.dgrv_Department.Name = "dgrv_Department"
        Me.dgrv_Department.RowHeadersVisible = False
        Me.dgrv_Department.RowHeadersWidth = 51
        Me.dgrv_Department.RowTemplate.Height = 24
        Me.dgrv_Department.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgrv_Department.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrv_Department.Size = New System.Drawing.Size(720, 322)
        Me.dgrv_Department.TabIndex = 52
        '
        'lbl_Search
        '
        Me.lbl_Search.AutoSize = True
        Me.lbl_Search.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Search.ForeColor = System.Drawing.Color.Linen
        Me.lbl_Search.Location = New System.Drawing.Point(44, 316)
        Me.lbl_Search.Name = "lbl_Search"
        Me.lbl_Search.Size = New System.Drawing.Size(75, 23)
        Me.lbl_Search.TabIndex = 70
        Me.lbl_Search.Text = "Search:"
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(153, 316)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(244, 30)
        Me.txt_Search.TabIndex = 69
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
        Me.gbtn_Add.FillColor = System.Drawing.Color.LightSalmon
        Me.gbtn_Add.FillColor2 = System.Drawing.Color.LightGoldenrodYellow
        Me.gbtn_Add.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Add.Location = New System.Drawing.Point(40, 180)
        Me.gbtn_Add.Name = "gbtn_Add"
        Me.gbtn_Add.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Add.Size = New System.Drawing.Size(88, 45)
        Me.gbtn_Add.TabIndex = 111
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
        Me.gbtn_Update.FillColor = System.Drawing.Color.LightSalmon
        Me.gbtn_Update.FillColor2 = System.Drawing.Color.LightGoldenrodYellow
        Me.gbtn_Update.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Update.Location = New System.Drawing.Point(153, 180)
        Me.gbtn_Update.Name = "gbtn_Update"
        Me.gbtn_Update.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Update.Size = New System.Drawing.Size(116, 45)
        Me.gbtn_Update.TabIndex = 112
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
        Me.gbtn_Delete.FillColor = System.Drawing.Color.LightSalmon
        Me.gbtn_Delete.FillColor2 = System.Drawing.Color.LightGoldenrodYellow
        Me.gbtn_Delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Delete.Location = New System.Drawing.Point(294, 180)
        Me.gbtn_Delete.Name = "gbtn_Delete"
        Me.gbtn_Delete.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Delete.Size = New System.Drawing.Size(103, 45)
        Me.gbtn_Delete.TabIndex = 113
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
        Me.gbtn_Reset.FillColor = System.Drawing.Color.LightSalmon
        Me.gbtn_Reset.FillColor2 = System.Drawing.Color.LightGoldenrodYellow
        Me.gbtn_Reset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Reset.Location = New System.Drawing.Point(95, 243)
        Me.gbtn_Reset.Name = "gbtn_Reset"
        Me.gbtn_Reset.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Reset.Size = New System.Drawing.Size(105, 45)
        Me.gbtn_Reset.TabIndex = 114
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
        Me.gbtn_Clear.FillColor = System.Drawing.Color.LightSalmon
        Me.gbtn_Clear.FillColor2 = System.Drawing.Color.LightGoldenrodYellow
        Me.gbtn_Clear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Clear.Location = New System.Drawing.Point(223, 243)
        Me.gbtn_Clear.Name = "gbtn_Clear"
        Me.gbtn_Clear.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Clear.Size = New System.Drawing.Size(116, 45)
        Me.gbtn_Clear.TabIndex = 115
        Me.gbtn_Clear.Text = "Clear"
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
        Me.gbtn_Search.FillColor = System.Drawing.Color.LightSalmon
        Me.gbtn_Search.FillColor2 = System.Drawing.Color.LightGoldenrodYellow
        Me.gbtn_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbtn_Search.Location = New System.Drawing.Point(48, 359)
        Me.gbtn_Search.Name = "gbtn_Search"
        Me.gbtn_Search.PressedColor = System.Drawing.Color.Transparent
        Me.gbtn_Search.Size = New System.Drawing.Size(349, 45)
        Me.gbtn_Search.TabIndex = 116
        Me.gbtn_Search.Text = "Search"
        '
        'ptb_Next
        '
        Me.ptb_Next.BackColor = System.Drawing.Color.Transparent
        Me.ptb_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptb_Next.FillColor = System.Drawing.Color.Transparent
        Me.ptb_Next.Image = Global.Training01.My.Resources.Resources.right_arrow__1_
        Me.ptb_Next.ImageRotate = 0!
        Me.ptb_Next.Location = New System.Drawing.Point(880, 397)
        Me.ptb_Next.Name = "ptb_Next"
        Me.ptb_Next.Size = New System.Drawing.Size(25, 25)
        Me.ptb_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Next.TabIndex = 119
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
        Me.ptb_Previous.Location = New System.Drawing.Point(689, 397)
        Me.ptb_Previous.Name = "ptb_Previous"
        Me.ptb_Previous.Size = New System.Drawing.Size(25, 25)
        Me.ptb_Previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Previous.TabIndex = 118
        Me.ptb_Previous.TabStop = False
        '
        'lbl_Page
        '
        Me.lbl_Page.AutoSize = True
        Me.lbl_Page.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Page.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Page.ForeColor = System.Drawing.Color.Azure
        Me.lbl_Page.Location = New System.Drawing.Point(736, 399)
        Me.lbl_Page.Name = "lbl_Page"
        Me.lbl_Page.Size = New System.Drawing.Size(57, 23)
        Me.lbl_Page.TabIndex = 117
        Me.lbl_Page.Text = "Page "
        '
        'ckb_Delete
        '
        Me.ckb_Delete.HeaderText = "Confirm"
        Me.ckb_Delete.MinimumWidth = 6
        Me.ckb_Delete.Name = "ckb_Delete"
        Me.ckb_Delete.Width = 60
        '
        'Number_Manager
        '
        Me.Number_Manager.HeaderText = "Number Manager"
        Me.Number_Manager.MinimumWidth = 6
        Me.Number_Manager.Name = "Number_Manager"
        Me.Number_Manager.Width = 140
        '
        'Number_Emp
        '
        Me.Number_Emp.HeaderText = "Number Emp"
        Me.Number_Emp.MinimumWidth = 6
        Me.Number_Emp.Name = "Number_Emp"
        Me.Number_Emp.Width = 120
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.Visible = False
        Me.status.Width = 125
        '
        'department_name
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department_name.DefaultCellStyle = DataGridViewCellStyle7
        Me.department_name.HeaderText = "Department Name"
        Me.department_name.MinimumWidth = 6
        Me.department_name.Name = "department_name"
        Me.department_name.Width = 150
        '
        'department_id
        '
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department_id.DefaultCellStyle = DataGridViewCellStyle8
        Me.department_id.HeaderText = "DepartmentID"
        Me.department_id.MinimumWidth = 6
        Me.department_id.Name = "department_id"
        Me.department_id.ReadOnly = True
        Me.department_id.Visible = False
        Me.department_id.Width = 125
        '
        'No
        '
        Me.No.HeaderText = "NO"
        Me.No.MinimumWidth = 6
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 70
        '
        'frm_Department
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.tech_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1189, 467)
        Me.Controls.Add(Me.ptb_Next)
        Me.Controls.Add(Me.ptb_Previous)
        Me.Controls.Add(Me.lbl_Page)
        Me.Controls.Add(Me.gbtn_Search)
        Me.Controls.Add(Me.gbtn_Clear)
        Me.Controls.Add(Me.gbtn_Reset)
        Me.Controls.Add(Me.gbtn_Delete)
        Me.Controls.Add(Me.gbtn_Update)
        Me.Controls.Add(Me.gbtn_Add)
        Me.Controls.Add(Me.lbl_Search)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.dgrv_Department)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.lbl_TitleDepartment)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Department"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department"
        CType(Me.dgrv_Department, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Next, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Previous, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_TitleDepartment As Label
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents dgrv_Department As DataGridView
    Friend WithEvents lbl_Search As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents gbtn_Add As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Update As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Delete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Reset As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Clear As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gbtn_Search As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ptb_Next As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ptb_Previous As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_Page As Label
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents department_id As DataGridViewTextBoxColumn
    Friend WithEvents department_name As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents Number_Emp As DataGridViewTextBoxColumn
    Friend WithEvents Number_Manager As DataGridViewTextBoxColumn
    Friend WithEvents ckb_Delete As DataGridViewCheckBoxColumn
End Class
