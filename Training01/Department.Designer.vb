<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Department
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_TitleDepartment = New System.Windows.Forms.Label()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.dgrv_Department = New System.Windows.Forms.DataGridView()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.lbl_Search = New System.Windows.Forms.Label()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.lbl_DepartmentID = New System.Windows.Forms.Label()
        Me.txt_DepartmentID = New System.Windows.Forms.TextBox()
        Me.ptb_Icon = New System.Windows.Forms.PictureBox()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgrv_Department, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_TitleDepartment
        '
        Me.lbl_TitleDepartment.AutoSize = True
        Me.lbl_TitleDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TitleDepartment.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TitleDepartment.ForeColor = System.Drawing.Color.Linen
        Me.lbl_TitleDepartment.Location = New System.Drawing.Point(287, 18)
        Me.lbl_TitleDepartment.Name = "lbl_TitleDepartment"
        Me.lbl_TitleDepartment.Size = New System.Drawing.Size(404, 45)
        Me.lbl_TitleDepartment.TabIndex = 26
        Me.lbl_TitleDepartment.Text = "DEPARTMENT LIST"
        '
        'txt_Name
        '
        Me.txt_Name.AllowDrop = True
        Me.txt_Name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Name.Location = New System.Drawing.Point(227, 137)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(163, 30)
        Me.txt_Name.TabIndex = 32
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.ForeColor = System.Drawing.Color.Linen
        Me.lbl_Name.Location = New System.Drawing.Point(64, 137)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(66, 23)
        Me.lbl_Name.TabIndex = 33
        Me.lbl_Name.Text = "Name:"
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.Linen
        Me.btn_Close.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.Location = New System.Drawing.Point(295, 260)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(95, 37)
        Me.btn_Close.TabIndex = 51
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.AllowDrop = True
        Me.btn_Delete.BackColor = System.Drawing.Color.Linen
        Me.btn_Delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.Location = New System.Drawing.Point(295, 197)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(95, 35)
        Me.btn_Delete.TabIndex = 50
        Me.btn_Delete.Text = "Delete"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.Linen
        Me.btn_Add.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(60, 195)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(79, 37)
        Me.btn_Add.TabIndex = 48
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'btn_Update
        '
        Me.btn_Update.BackColor = System.Drawing.Color.Linen
        Me.btn_Update.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.Location = New System.Drawing.Point(170, 197)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(98, 37)
        Me.btn_Update.TabIndex = 49
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'dgrv_Department
        '
        Me.dgrv_Department.AllowUserToAddRows = False
        Me.dgrv_Department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrv_Department.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.department_id, Me.department_name, Me.status})
        Me.dgrv_Department.Location = New System.Drawing.Point(465, 88)
        Me.dgrv_Department.Name = "dgrv_Department"
        Me.dgrv_Department.RowHeadersVisible = False
        Me.dgrv_Department.RowHeadersWidth = 51
        Me.dgrv_Department.RowTemplate.Height = 24
        Me.dgrv_Department.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrv_Department.Size = New System.Drawing.Size(371, 356)
        Me.dgrv_Department.TabIndex = 52
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.Linen
        Me.btn_Clear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(170, 260)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(98, 38)
        Me.btn_Clear.TabIndex = 68
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_Reset
        '
        Me.btn_Reset.BackColor = System.Drawing.Color.Linen
        Me.btn_Reset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Reset.Location = New System.Drawing.Point(60, 260)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(79, 38)
        Me.btn_Reset.TabIndex = 67
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.UseVisualStyleBackColor = False
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.Color.Linen
        Me.btn_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.Location = New System.Drawing.Point(60, 368)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(330, 44)
        Me.btn_Search.TabIndex = 71
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'lbl_Search
        '
        Me.lbl_Search.AutoSize = True
        Me.lbl_Search.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Search.ForeColor = System.Drawing.Color.Linen
        Me.lbl_Search.Location = New System.Drawing.Point(64, 322)
        Me.lbl_Search.Name = "lbl_Search"
        Me.lbl_Search.Size = New System.Drawing.Size(75, 23)
        Me.lbl_Search.TabIndex = 70
        Me.lbl_Search.Text = "Search:"
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(160, 320)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(230, 30)
        Me.txt_Search.TabIndex = 69
        '
        'lbl_DepartmentID
        '
        Me.lbl_DepartmentID.AutoSize = True
        Me.lbl_DepartmentID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_DepartmentID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DepartmentID.ForeColor = System.Drawing.Color.Linen
        Me.lbl_DepartmentID.Location = New System.Drawing.Point(64, 88)
        Me.lbl_DepartmentID.Name = "lbl_DepartmentID"
        Me.lbl_DepartmentID.Size = New System.Drawing.Size(144, 23)
        Me.lbl_DepartmentID.TabIndex = 73
        Me.lbl_DepartmentID.Text = "Department ID:"
        '
        'txt_DepartmentID
        '
        Me.txt_DepartmentID.AllowDrop = True
        Me.txt_DepartmentID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DepartmentID.Location = New System.Drawing.Point(227, 88)
        Me.txt_DepartmentID.Name = "txt_DepartmentID"
        Me.txt_DepartmentID.Size = New System.Drawing.Size(163, 30)
        Me.txt_DepartmentID.TabIndex = 72
        '
        'ptb_Icon
        '
        Me.ptb_Icon.Image = Global.Training01.My.Resources.Resources.blue_exit_icon_16
        Me.ptb_Icon.Location = New System.Drawing.Point(977, 0)
        Me.ptb_Icon.Name = "ptb_Icon"
        Me.ptb_Icon.Size = New System.Drawing.Size(52, 40)
        Me.ptb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Icon.TabIndex = 74
        Me.ptb_Icon.TabStop = False
        '
        'No
        '
        Me.No.HeaderText = "NO"
        Me.No.MinimumWidth = 6
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 70
        '
        'department_id
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department_id.DefaultCellStyle = DataGridViewCellStyle1
        Me.department_id.HeaderText = "DepartmentID"
        Me.department_id.MinimumWidth = 6
        Me.department_id.Name = "department_id"
        Me.department_id.ReadOnly = True
        Me.department_id.Visible = False
        Me.department_id.Width = 125
        '
        'department_name
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.department_name.HeaderText = "Department Name"
        Me.department_name.MinimumWidth = 6
        Me.department_name.Name = "department_name"
        Me.department_name.Width = 180
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.Visible = False
        Me.status.Width = 125
        '
        'frm_Department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1025, 464)
        Me.Controls.Add(Me.ptb_Icon)
        Me.Controls.Add(Me.lbl_DepartmentID)
        Me.Controls.Add(Me.txt_DepartmentID)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.lbl_Search)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.dgrv_Department)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.lbl_TitleDepartment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Department"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department"
        CType(Me.dgrv_Department, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_TitleDepartment As Label
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents btn_Close As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents dgrv_Department As DataGridView
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Reset As Button
    Friend WithEvents btn_Search As Button
    Friend WithEvents lbl_Search As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents lbl_DepartmentID As Label
    Friend WithEvents txt_DepartmentID As TextBox
    Friend WithEvents ptb_Icon As PictureBox
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents department_id As DataGridViewTextBoxColumn
    Friend WithEvents department_name As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
