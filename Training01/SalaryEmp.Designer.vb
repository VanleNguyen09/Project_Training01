﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvEmps = New System.Windows.Forms.DataGridView()
        Me.stt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary_emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSalaries = New System.Windows.Forms.DataGridView()
        Me.salary_stt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalaryName = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbSalary = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtSearchSalary = New System.Windows.Forms.TextBox()
        Me.gbEmps = New System.Windows.Forms.GroupBox()
        Me.closeApp = New System.Windows.Forms.PictureBox()
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
        Me.Label1.Location = New System.Drawing.Point(403, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE'S SALARY"
        '
        'dgvEmps
        '
        Me.dgvEmps.AllowUserToAddRows = False
        Me.dgvEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stt, Me.id, Me.emp_name, Me.phone, Me.address, Me.birthday, Me.email, Me.salary_emp_id})
        Me.dgvEmps.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvEmps.Location = New System.Drawing.Point(14, 55)
        Me.dgvEmps.MultiSelect = False
        Me.dgvEmps.Name = "dgvEmps"
        Me.dgvEmps.RowHeadersVisible = False
        Me.dgvEmps.RowHeadersWidth = 51
        Me.dgvEmps.RowTemplate.Height = 40
        Me.dgvEmps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmps.Size = New System.Drawing.Size(363, 318)
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
        'phone
        '
        Me.phone.HeaderText = "PHONE"
        Me.phone.MinimumWidth = 6
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        Me.phone.Visible = False
        Me.phone.Width = 125
        '
        'address
        '
        Me.address.HeaderText = "ADDRESS"
        Me.address.MinimumWidth = 6
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Visible = False
        Me.address.Width = 125
        '
        'birthday
        '
        Me.birthday.HeaderText = "BIRTHDAY"
        Me.birthday.MinimumWidth = 6
        Me.birthday.Name = "birthday"
        Me.birthday.ReadOnly = True
        Me.birthday.Width = 90
        '
        'email
        '
        Me.email.HeaderText = "EMAIL"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 130
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
        Me.dgvSalaries.Size = New System.Drawing.Size(428, 318)
        Me.dgvSalaries.TabIndex = 7
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
        Me.salary_name.Width = 120
        '
        'salary
        '
        Me.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.NullValue = "0.00"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.salary.DefaultCellStyle = DataGridViewCellStyle1
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
        Me.btnUpdate.Location = New System.Drawing.Point(410, 293)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(85, 33)
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
        Me.txtSalaryName.Size = New System.Drawing.Size(209, 20)
        Me.txtSalaryName.TabIndex = 9
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(10, 91)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(209, 20)
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
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(9, 132)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(212, 31)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.IndianRed
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(444, 340)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(227, 33)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.IndianRed
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(444, 301)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(227, 33)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(14, 28)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(335, 20)
        Me.txtSearch.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Training01.My.Resources.Resources.search_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Training01.My.Resources.Resources.search_icon
        Me.PictureBox1.Location = New System.Drawing.Point(355, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'gbSalary
        '
        Me.gbSalary.BackColor = System.Drawing.Color.Transparent
        Me.gbSalary.Controls.Add(Me.GroupBox3)
        Me.gbSalary.Controls.Add(Me.btnExit)
        Me.gbSalary.Controls.Add(Me.PictureBox2)
        Me.gbSalary.Controls.Add(Me.btnDelete)
        Me.gbSalary.Controls.Add(Me.txtSearchSalary)
        Me.gbSalary.Controls.Add(Me.dgvSalaries)
        Me.gbSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSalary.ForeColor = System.Drawing.Color.White
        Me.gbSalary.Location = New System.Drawing.Point(501, 108)
        Me.gbSalary.Name = "gbSalary"
        Me.gbSalary.Size = New System.Drawing.Size(687, 387)
        Me.gbSalary.TabIndex = 5
        Me.gbSalary.TabStop = False
        Me.gbSalary.Text = "SALARY'S MANAGEMENT"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Controls.Add(Me.txtSalary)
        Me.GroupBox3.Controls.Add(Me.txtSalaryName)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(444, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 179)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CREATE SALARY"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Training01.My.Resources.Resources.search_icon
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Training01.My.Resources.Resources.search_icon
        Me.PictureBox2.Location = New System.Drawing.Point(416, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'txtSearchSalary
        '
        Me.txtSearchSalary.Location = New System.Drawing.Point(10, 28)
        Me.txtSearchSalary.Name = "txtSearchSalary"
        Me.txtSearchSalary.Size = New System.Drawing.Size(400, 20)
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
        Me.gbEmps.Size = New System.Drawing.Size(392, 387)
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
        Me.closeApp.Location = New System.Drawing.Point(1151, 1)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(37, 36)
        Me.closeApp.TabIndex = 12
        Me.closeApp.TabStop = False
        Me.closeApp.Visible = False
        '
        'SalaryEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.tech_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1196, 509)
        Me.Controls.Add(Me.closeApp)
        Me.Controls.Add(Me.gbEmps)
        Me.Controls.Add(Me.gbSalary)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbSalary As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSearchSalary As TextBox
    Friend WithEvents gbEmps As GroupBox
    Friend WithEvents closeApp As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents salary_stt As DataGridViewTextBoxColumn
    Friend WithEvents salary_id As DataGridViewTextBoxColumn
    Friend WithEvents salary_name As DataGridViewTextBoxColumn
    Friend WithEvents salary As DataGridViewTextBoxColumn
    Friend WithEvents salary_number As DataGridViewTextBoxColumn
    Friend WithEvents stt As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents emp_name As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents birthday As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents salary_emp_id As DataGridViewTextBoxColumn
End Class
