<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalaryEmp
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
        Me.Label1.Location = New System.Drawing.Point(615, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE'S SALARY"
        '
        'dgvEmps
        '
        Me.dgvEmps.AllowUserToAddRows = False
        Me.dgvEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stt, Me.id, Me.emp_name, Me.phone, Me.address, Me.birthday, Me.email, Me.salary_emp_id})
        Me.dgvEmps.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvEmps.Location = New System.Drawing.Point(19, 68)
        Me.dgvEmps.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvEmps.MultiSelect = False
        Me.dgvEmps.Name = "dgvEmps"
        Me.dgvEmps.RowHeadersVisible = False
        Me.dgvEmps.RowHeadersWidth = 51
        Me.dgvEmps.RowTemplate.Height = 40
        Me.dgvEmps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmps.Size = New System.Drawing.Size(772, 391)
        Me.dgvEmps.TabIndex = 3
        '
        'stt
        '
        Me.stt.HeaderText = "STT"
        Me.stt.MinimumWidth = 6
        Me.stt.Name = "stt"
        Me.stt.ReadOnly = True
        Me.stt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.stt.Width = 60
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
        Me.emp_name.Width = 125
        '
        'phone
        '
        Me.phone.HeaderText = "PHONE"
        Me.phone.MinimumWidth = 6
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        Me.phone.Width = 125
        '
        'address
        '
        Me.address.HeaderText = "ADDRESS"
        Me.address.MinimumWidth = 6
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Width = 125
        '
        'birthday
        '
        Me.birthday.HeaderText = "BIRTHDAY"
        Me.birthday.MinimumWidth = 6
        Me.birthday.Name = "birthday"
        Me.birthday.ReadOnly = True
        Me.birthday.Width = 125
        '
        'email
        '
        Me.email.HeaderText = "EMAIL"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 120
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
        Me.dgvSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalaries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.salary_stt, Me.salary_id, Me.salary_name, Me.salary})
        Me.dgvSalaries.Location = New System.Drawing.Point(13, 68)
        Me.dgvSalaries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvSalaries.Name = "dgvSalaries"
        Me.dgvSalaries.RowHeadersVisible = False
        Me.dgvSalaries.RowHeadersWidth = 51
        Me.dgvSalaries.RowTemplate.Height = 30
        Me.dgvSalaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalaries.Size = New System.Drawing.Size(473, 391)
        Me.dgvSalaries.TabIndex = 7
        '
        'salary_stt
        '
        Me.salary_stt.HeaderText = "STT"
        Me.salary_stt.MinimumWidth = 6
        Me.salary_stt.Name = "salary_stt"
        Me.salary_stt.ReadOnly = True
        Me.salary_stt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.salary_stt.Width = 70
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
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.salary.DefaultCellStyle = DataGridViewCellStyle1
        Me.salary.HeaderText = "SALARY"
        Me.salary.MinimumWidth = 6
        Me.salary.Name = "salary"
        Me.salary.ReadOnly = True
        Me.salary.Width = 160
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.OrangeRed
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(833, 361)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(113, 41)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name's salary board"
        '
        'txtSalaryName
        '
        Me.txtSalaryName.Location = New System.Drawing.Point(12, 50)
        Me.txtSalaryName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSalaryName.Name = "txtSalaryName"
        Me.txtSalaryName.Size = New System.Drawing.Size(277, 23)
        Me.txtSalaryName.TabIndex = 9
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(13, 112)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(277, 23)
        Me.txtSalary.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Salary"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(12, 162)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(283, 38)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.IndianRed
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(495, 370)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(303, 41)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.IndianRed
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(495, 418)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(303, 41)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(19, 34)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(733, 23)
        Me.txtSearch.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Training01.My.Resources.Resources.search_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Training01.My.Resources.Resources.search_icon
        Me.PictureBox1.Location = New System.Drawing.Point(761, 33)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 27)
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
        Me.gbSalary.Location = New System.Drawing.Point(955, 133)
        Me.gbSalary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbSalary.Name = "gbSalary"
        Me.gbSalary.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbSalary.Size = New System.Drawing.Size(809, 476)
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
        Me.GroupBox3.Location = New System.Drawing.Point(495, 68)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(303, 220)
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
        Me.PictureBox2.Location = New System.Drawing.Point(457, 34)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'txtSearchSalary
        '
        Me.txtSearchSalary.Location = New System.Drawing.Point(13, 34)
        Me.txtSearchSalary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchSalary.Name = "txtSearchSalary"
        Me.txtSearchSalary.Size = New System.Drawing.Size(435, 23)
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
        Me.gbEmps.Location = New System.Drawing.Point(16, 133)
        Me.gbEmps.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbEmps.Name = "gbEmps"
        Me.gbEmps.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbEmps.Size = New System.Drawing.Size(809, 476)
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
        Me.closeApp.Location = New System.Drawing.Point(1729, 0)
        Me.closeApp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(49, 44)
        Me.closeApp.TabIndex = 12
        Me.closeApp.TabStop = False
        '
        'SalaryEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1780, 626)
        Me.Controls.Add(Me.closeApp)
        Me.Controls.Add(Me.gbEmps)
        Me.Controls.Add(Me.gbSalary)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtSearchSalary As TextBox
    Friend WithEvents gbEmps As GroupBox
    Friend WithEvents closeApp As PictureBox
    Friend WithEvents stt As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents emp_name As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents birthday As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents salary_emp_id As DataGridViewTextBoxColumn
    Friend WithEvents salary_stt As DataGridViewTextBoxColumn
    Friend WithEvents salary_id As DataGridViewTextBoxColumn
    Friend WithEvents salary_name As DataGridViewTextBoxColumn
    Friend WithEvents salary As DataGridViewTextBoxColumn
End Class
