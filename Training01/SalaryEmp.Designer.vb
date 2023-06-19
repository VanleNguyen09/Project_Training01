<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalaryEmp
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvEmps = New System.Windows.Forms.DataGridView()
        Me.stt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary_emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSalaries = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalaryName = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbSalary = New System.Windows.Forms.GroupBox()
        Me.ProgressBarLoad = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.gBtnDelete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.gbtnExportExcel = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.gBtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtSearchSalary = New System.Windows.Forms.TextBox()
        Me.gbEmps = New System.Windows.Forms.GroupBox()
        Me.closeApp = New System.Windows.Forms.PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTotalPage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCurrentPage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPrevious = New Guna.UI2.WinForms.Guna2Button()
        Me.bwLoadEmpsDatas = New System.ComponentModel.BackgroundWorker()
        Me.salary_stt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvEmps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSalaries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSalary.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEmps.SuspendLayout()
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(310, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE'S SALARY"
        '
        'dgvEmps
        '
        Me.dgvEmps.AllowUserToAddRows = False
        Me.dgvEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stt, Me.id, Me.emp_name, Me.birthday, Me.salary_emp_id})
        Me.dgvEmps.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvEmps.Location = New System.Drawing.Point(14, 55)
        Me.dgvEmps.MultiSelect = False
        Me.dgvEmps.Name = "dgvEmps"
        Me.dgvEmps.RowHeadersVisible = False
        Me.dgvEmps.RowHeadersWidth = 51
        Me.dgvEmps.RowTemplate.Height = 40
        Me.dgvEmps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmps.Size = New System.Drawing.Size(235, 304)
        Me.dgvEmps.TabIndex = 3
        '
        'stt
        '
        Me.stt.HeaderText = "STT"
        Me.stt.MinimumWidth = 6
        Me.stt.Name = "stt"
        Me.stt.ReadOnly = True
        Me.stt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.stt.Width = 40
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 125
        '
        'emp_name
        '
        Me.emp_name.HeaderText = "NAME"
        Me.emp_name.MinimumWidth = 6
        Me.emp_name.Name = "emp_name"
        Me.emp_name.ReadOnly = True
        '
        'birthday
        '
        Me.birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.birthday.HeaderText = "BIRTHDAY"
        Me.birthday.MinimumWidth = 6
        Me.birthday.Name = "birthday"
        Me.birthday.ReadOnly = True
        '
        'salary_emp_id
        '
        Me.salary_emp_id.HeaderText = "SalaryId"
        Me.salary_emp_id.MinimumWidth = 6
        Me.salary_emp_id.Name = "salary_emp_id"
        Me.salary_emp_id.ReadOnly = True
        Me.salary_emp_id.Visible = False
        Me.salary_emp_id.Width = 125
        '
        'dgvSalaries
        '
        Me.dgvSalaries.AllowUserToAddRows = False
        Me.dgvSalaries.AllowUserToDeleteRows = False
        Me.dgvSalaries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalaries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.salary_stt, Me.salary_id, Me.salary_name, Me.salary, Me.salary_number})
        Me.dgvSalaries.Location = New System.Drawing.Point(10, 55)
        Me.dgvSalaries.Name = "dgvSalaries"
        Me.dgvSalaries.RowHeadersVisible = False
        Me.dgvSalaries.RowHeadersWidth = 51
        Me.dgvSalaries.RowTemplate.Height = 40
        Me.dgvSalaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalaries.Size = New System.Drawing.Size(364, 304)
        Me.dgvSalaries.TabIndex = 7
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.OrangeRed
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUpdate.FlatAppearance.BorderSize = 2
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(282, 292)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(70, 33)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name's salary board"
        '
        'txtSalaryName
        '
        Me.txtSalaryName.Location = New System.Drawing.Point(9, 41)
        Me.txtSalaryName.Name = "txtSalaryName"
        Me.txtSalaryName.Size = New System.Drawing.Size(189, 20)
        Me.txtSalaryName.TabIndex = 9
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(10, 91)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(188, 20)
        Me.txtSalary.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Salary"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(14, 28)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(205, 20)
        Me.txtSearch.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Training01.My.Resources.Resources.search_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Training01.My.Resources.Resources.search_icon
        Me.PictureBox1.Location = New System.Drawing.Point(225, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'gbSalary
        '
        Me.gbSalary.BackColor = System.Drawing.Color.Transparent
        Me.gbSalary.Controls.Add(Me.ProgressBarLoad)
        Me.gbSalary.Controls.Add(Me.gBtnDelete)
        Me.gbSalary.Controls.Add(Me.gbtnExportExcel)
        Me.gbSalary.Controls.Add(Me.GroupBox3)
        Me.gbSalary.Controls.Add(Me.PictureBox2)
        Me.gbSalary.Controls.Add(Me.txtSearchSalary)
        Me.gbSalary.Controls.Add(Me.dgvSalaries)
        Me.gbSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSalary.ForeColor = System.Drawing.Color.White
        Me.gbSalary.Location = New System.Drawing.Point(358, 108)
        Me.gbSalary.Name = "gbSalary"
        Me.gbSalary.Size = New System.Drawing.Size(602, 373)
        Me.gbSalary.TabIndex = 5
        Me.gbSalary.TabStop = False
        Me.gbSalary.Text = "SALARY'S MANAGEMENT"
        '
        'ProgressBarLoad
        '
        Me.ProgressBarLoad.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ProgressBarLoad.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ProgressBarLoad.ForeColor = System.Drawing.Color.White
        Me.ProgressBarLoad.Location = New System.Drawing.Point(40, 130)
        Me.ProgressBarLoad.Minimum = 0
        Me.ProgressBarLoad.Name = "ProgressBarLoad"
        Me.ProgressBarLoad.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ProgressBarLoad.Size = New System.Drawing.Size(128, 128)
        Me.ProgressBarLoad.TabIndex = 16
        Me.ProgressBarLoad.Text = "Guna2CircleProgressBar1"
        Me.ProgressBarLoad.Visible = False
        '
        'gBtnDelete
        '
        Me.gBtnDelete.Animated = True
        Me.gBtnDelete.AutoRoundedCorners = True
        Me.gBtnDelete.BorderColor = System.Drawing.Color.White
        Me.gBtnDelete.BorderRadius = 17
        Me.gBtnDelete.BorderThickness = 2
        Me.gBtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gBtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gBtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gBtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gBtnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gBtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gBtnDelete.FillColor2 = System.Drawing.Color.DarkMagenta
        Me.gBtnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gBtnDelete.ForeColor = System.Drawing.Color.White
        Me.gBtnDelete.Location = New System.Drawing.Point(380, 277)
        Me.gBtnDelete.Name = "gBtnDelete"
        Me.gBtnDelete.Size = New System.Drawing.Size(208, 37)
        Me.gBtnDelete.TabIndex = 15
        Me.gBtnDelete.Text = "DELETE"
        '
        'gbtnExportExcel
        '
        Me.gbtnExportExcel.Animated = True
        Me.gbtnExportExcel.AutoRoundedCorners = True
        Me.gbtnExportExcel.BorderRadius = 18
        Me.gbtnExportExcel.BorderThickness = 2
        Me.gbtnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbtnExportExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gbtnExportExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gbtnExportExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtnExportExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gbtnExportExcel.FillColor = System.Drawing.Color.White
        Me.gbtnExportExcel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gbtnExportExcel.ForeColor = System.Drawing.Color.Black
        Me.gbtnExportExcel.Image = Global.Training01.My.Resources.Resources.download_icon
        Me.gbtnExportExcel.Location = New System.Drawing.Point(380, 320)
        Me.gbtnExportExcel.Name = "gbtnExportExcel"
        Me.gbtnExportExcel.Size = New System.Drawing.Size(208, 39)
        Me.gbtnExportExcel.TabIndex = 14
        Me.gbtnExportExcel.Text = "EXPORT EXCEL"
        Me.gbtnExportExcel.UseTransparentBackground = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.gBtnAdd)
        Me.GroupBox3.Controls.Add(Me.txtSalary)
        Me.GroupBox3.Controls.Add(Me.txtSalaryName)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(380, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 179)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CREATE SALARY"
        '
        'gBtnAdd
        '
        Me.gBtnAdd.Animated = True
        Me.gBtnAdd.AutoRoundedCorners = True
        Me.gBtnAdd.BorderColor = System.Drawing.Color.White
        Me.gBtnAdd.BorderRadius = 18
        Me.gBtnAdd.BorderThickness = 2
        Me.gBtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gBtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gBtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gBtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gBtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gBtnAdd.FillColor = System.Drawing.Color.DarkViolet
        Me.gBtnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gBtnAdd.ForeColor = System.Drawing.Color.White
        Me.gBtnAdd.Location = New System.Drawing.Point(8, 129)
        Me.gBtnAdd.Name = "gBtnAdd"
        Me.gBtnAdd.Size = New System.Drawing.Size(190, 38)
        Me.gBtnAdd.TabIndex = 11
        Me.gBtnAdd.Text = "ADD"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Training01.My.Resources.Resources.search_icon
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Training01.My.Resources.Resources.search_icon
        Me.PictureBox2.Location = New System.Drawing.Point(352, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'txtSearchSalary
        '
        Me.txtSearchSalary.Location = New System.Drawing.Point(10, 28)
        Me.txtSearchSalary.Name = "txtSearchSalary"
        Me.txtSearchSalary.Size = New System.Drawing.Size(336, 20)
        Me.txtSearchSalary.TabIndex = 6
        '
        'gbEmps
        '
        Me.gbEmps.BackColor = System.Drawing.Color.Transparent
        Me.gbEmps.Controls.Add(Me.PictureBox1)
        Me.gbEmps.Controls.Add(Me.txtSearch)
        Me.gbEmps.Controls.Add(Me.dgvEmps)
        Me.gbEmps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEmps.ForeColor = System.Drawing.Color.White
        Me.gbEmps.Location = New System.Drawing.Point(12, 108)
        Me.gbEmps.Name = "gbEmps"
        Me.gbEmps.Size = New System.Drawing.Size(264, 373)
        Me.gbEmps.TabIndex = 1
        Me.gbEmps.TabStop = False
        Me.gbEmps.Text = "EMPLOYEE'S LIST"
        '
        'closeApp
        '
        Me.closeApp.BackColor = System.Drawing.Color.Transparent
        Me.closeApp.BackgroundImage = Global.Training01.My.Resources.Resources.blue_exit_icon_16
        Me.closeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeApp.Location = New System.Drawing.Point(929, 2)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(37, 36)
        Me.closeApp.TabIndex = 12
        Me.closeApp.TabStop = False
        Me.closeApp.Visible = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(132, 493)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(18, 18)
        Me.Guna2HtmlLabel1.TabIndex = 17
        Me.Guna2HtmlLabel1.Text = "Of"
        '
        'txtTotalPage
        '
        Me.txtTotalPage.Animated = True
        Me.txtTotalPage.AutoRoundedCorners = True
        Me.txtTotalPage.BackColor = System.Drawing.Color.Transparent
        Me.txtTotalPage.BorderRadius = 13
        Me.txtTotalPage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalPage.DefaultText = ""
        Me.txtTotalPage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotalPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotalPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalPage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalPage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalPage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTotalPage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalPage.Location = New System.Drawing.Point(156, 488)
        Me.txtTotalPage.Name = "txtTotalPage"
        Me.txtTotalPage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalPage.PlaceholderText = ""
        Me.txtTotalPage.ReadOnly = True
        Me.txtTotalPage.SelectedText = ""
        Me.txtTotalPage.Size = New System.Drawing.Size(41, 28)
        Me.txtTotalPage.TabIndex = 15
        '
        'txtCurrentPage
        '
        Me.txtCurrentPage.Animated = True
        Me.txtCurrentPage.BackColor = System.Drawing.Color.Transparent
        Me.txtCurrentPage.BorderRadius = 13
        Me.txtCurrentPage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCurrentPage.DefaultText = ""
        Me.txtCurrentPage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCurrentPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCurrentPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCurrentPage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCurrentPage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCurrentPage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCurrentPage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCurrentPage.Location = New System.Drawing.Point(87, 488)
        Me.txtCurrentPage.Name = "txtCurrentPage"
        Me.txtCurrentPage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCurrentPage.PlaceholderText = ""
        Me.txtCurrentPage.SelectedText = ""
        Me.txtCurrentPage.Size = New System.Drawing.Size(41, 28)
        Me.txtCurrentPage.TabIndex = 16
        '
        'btnNext
        '
        Me.btnNext.Animated = True
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BorderRadius = 10
        Me.btnNext.BorderThickness = 1
        Me.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(203, 487)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(59, 29)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseTransparentBackground = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Animated = True
        Me.btnPrevious.BackColor = System.Drawing.Color.Transparent
        Me.btnPrevious.BorderRadius = 10
        Me.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Location = New System.Drawing.Point(26, 487)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(55, 29)
        Me.btnPrevious.TabIndex = 14
        Me.btnPrevious.Text = "PRE"
        Me.btnPrevious.UseTransparentBackground = True
        '
        'bwLoadEmpsDatas
        '
        '
        'salary_stt
        '
        Me.salary_stt.HeaderText = "STT"
        Me.salary_stt.MinimumWidth = 6
        Me.salary_stt.Name = "salary_stt"
        Me.salary_stt.ReadOnly = True
        Me.salary_stt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.salary_stt.Width = 40
        '
        'salary_id
        '
        Me.salary_id.HeaderText = "ID"
        Me.salary_id.MinimumWidth = 6
        Me.salary_id.Name = "salary_id"
        Me.salary_id.ReadOnly = True
        Me.salary_id.Visible = False
        Me.salary_id.Width = 125
        '
        'salary_name
        '
        Me.salary_name.HeaderText = "NAME"
        Me.salary_name.MinimumWidth = 6
        Me.salary_name.Name = "salary_name"
        Me.salary_name.ReadOnly = True
        Me.salary_name.Width = 80
        '
        'salary
        '
        Me.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.NullValue = "0.00"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.salary.DefaultCellStyle = DataGridViewCellStyle3
        Me.salary.HeaderText = "SALARY"
        Me.salary.MinimumWidth = 6
        Me.salary.Name = "salary"
        Me.salary.ReadOnly = True
        '
        'salary_number
        '
        Me.salary_number.HeaderText = "SALARY NUMBER"
        Me.salary_number.Name = "salary_number"
        Me.salary_number.ReadOnly = True
        Me.salary_number.Width = 120
        '
        'SalaryEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.tech_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(971, 522)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.txtTotalPage)
        Me.Controls.Add(Me.txtCurrentPage)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.closeApp)
        Me.Controls.Add(Me.gbEmps)
        Me.Controls.Add(Me.gbSalary)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SalaryEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalaryUser"
        CType(Me.dgvEmps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSalaries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSalary.ResumeLayout(False)
        Me.gbSalary.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEmps.ResumeLayout(False)
        Me.gbEmps.PerformLayout()
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEmps As DataGridView
    Friend WithEvents dgvSalaries As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSalaryName As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbSalary As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSearchSalary As TextBox
    Friend WithEvents gbEmps As GroupBox
    Friend WithEvents closeApp As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents gbtnExportExcel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gBtnDelete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gBtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTotalPage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCurrentPage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPrevious As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bwLoadEmpsDatas As System.ComponentModel.BackgroundWorker
    Friend WithEvents stt As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents emp_name As DataGridViewTextBoxColumn
    Friend WithEvents birthday As DataGridViewTextBoxColumn
    Friend WithEvents salary_emp_id As DataGridViewTextBoxColumn
    Friend WithEvents ProgressBarLoad As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents salary_stt As DataGridViewTextBoxColumn
    Friend WithEvents salary_id As DataGridViewTextBoxColumn
    Friend WithEvents salary_name As DataGridViewTextBoxColumn
    Friend WithEvents salary As DataGridViewTextBoxColumn
    Friend WithEvents salary_number As DataGridViewTextBoxColumn
End Class
