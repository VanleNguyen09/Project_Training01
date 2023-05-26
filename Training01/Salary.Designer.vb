<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Salary
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
        Me.lbl_TitleSalary = New System.Windows.Forms.Label()
        Me.lbl_SalaryID = New System.Windows.Forms.Label()
        Me.txt_SalaryID = New System.Windows.Forms.TextBox()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.lbl_Search = New System.Windows.Forms.Label()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.lbl_EmpID = New System.Windows.Forms.Label()
        Me.txt_EmpID = New System.Windows.Forms.TextBox()
        Me.txt_Salary = New System.Windows.Forms.TextBox()
        Me.lbl_FromDate = New System.Windows.Forms.Label()
        Me.lbl_Salary = New System.Windows.Forms.Label()
        Me.lbl_ToDate = New System.Windows.Forms.Label()
        Me.dtp_FromDate = New System.Windows.Forms.DateTimePicker()
        Me.dtp_ToDate = New System.Windows.Forms.DateTimePicker()
        Me.dgrv_Salary = New System.Windows.Forms.DataGridView()
        Me.salary_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.from_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.to_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ptb_Close = New System.Windows.Forms.PictureBox()
        Me.btn_CalculateTotal = New System.Windows.Forms.Button()
        Me.btn_Total = New System.Windows.Forms.Button()
        CType(Me.dgrv_Salary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_TitleSalary
        '
        Me.lbl_TitleSalary.AutoSize = True
        Me.lbl_TitleSalary.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_TitleSalary.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TitleSalary.ForeColor = System.Drawing.Color.Red
        Me.lbl_TitleSalary.Location = New System.Drawing.Point(370, 19)
        Me.lbl_TitleSalary.Name = "lbl_TitleSalary"
        Me.lbl_TitleSalary.Size = New System.Drawing.Size(285, 45)
        Me.lbl_TitleSalary.TabIndex = 27
        Me.lbl_TitleSalary.Text = "SALARY LIST"
        '
        'lbl_SalaryID
        '
        Me.lbl_SalaryID.AutoSize = True
        Me.lbl_SalaryID.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_SalaryID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SalaryID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_SalaryID.Location = New System.Drawing.Point(70, 90)
        Me.lbl_SalaryID.Name = "lbl_SalaryID"
        Me.lbl_SalaryID.Size = New System.Drawing.Size(97, 23)
        Me.lbl_SalaryID.TabIndex = 86
        Me.lbl_SalaryID.Text = "Salary ID:"
        '
        'txt_SalaryID
        '
        Me.txt_SalaryID.AllowDrop = True
        Me.txt_SalaryID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SalaryID.Location = New System.Drawing.Point(193, 85)
        Me.txt_SalaryID.Name = "txt_SalaryID"
        Me.txt_SalaryID.Size = New System.Drawing.Size(163, 30)
        Me.txt_SalaryID.TabIndex = 85
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.Color.Lime
        Me.btn_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.Location = New System.Drawing.Point(414, 332)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(86, 35)
        Me.btn_Search.TabIndex = 84
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'lbl_Search
        '
        Me.lbl_Search.AutoSize = True
        Me.lbl_Search.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Search.Location = New System.Drawing.Point(70, 339)
        Me.lbl_Search.Name = "lbl_Search"
        Me.lbl_Search.Size = New System.Drawing.Size(75, 23)
        Me.lbl_Search.TabIndex = 83
        Me.lbl_Search.Text = "Search:"
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(165, 332)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(230, 30)
        Me.txt_Search.TabIndex = 82
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.Orange
        Me.btn_Clear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(141, 265)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(90, 38)
        Me.btn_Clear.TabIndex = 81
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_Reset
        '
        Me.btn_Reset.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_Reset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Reset.Location = New System.Drawing.Point(65, 265)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(70, 38)
        Me.btn_Reset.TabIndex = 80
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.UseVisualStyleBackColor = False
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.Silver
        Me.btn_Close.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.Location = New System.Drawing.Point(318, 204)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(77, 37)
        Me.btn_Close.TabIndex = 79
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.AllowDrop = True
        Me.btn_Delete.BackColor = System.Drawing.Color.Tomato
        Me.btn_Delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.Location = New System.Drawing.Point(237, 205)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(75, 35)
        Me.btn_Delete.TabIndex = 78
        Me.btn_Delete.Text = "Delete"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'btn_Update
        '
        Me.btn_Update.BackColor = System.Drawing.Color.Gold
        Me.btn_Update.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.Location = New System.Drawing.Point(141, 203)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(90, 37)
        Me.btn_Update.TabIndex = 77
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.Cyan
        Me.btn_Add.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(65, 203)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(70, 37)
        Me.btn_Add.TabIndex = 76
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'lbl_EmpID
        '
        Me.lbl_EmpID.AutoSize = True
        Me.lbl_EmpID.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_EmpID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EmpID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_EmpID.Location = New System.Drawing.Point(70, 137)
        Me.lbl_EmpID.Name = "lbl_EmpID"
        Me.lbl_EmpID.Size = New System.Drawing.Size(81, 23)
        Me.lbl_EmpID.TabIndex = 75
        Me.lbl_EmpID.Text = "Emp ID:"
        '
        'txt_EmpID
        '
        Me.txt_EmpID.AllowDrop = True
        Me.txt_EmpID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmpID.Location = New System.Drawing.Point(193, 134)
        Me.txt_EmpID.Name = "txt_EmpID"
        Me.txt_EmpID.Size = New System.Drawing.Size(163, 30)
        Me.txt_EmpID.TabIndex = 74
        '
        'txt_Salary
        '
        Me.txt_Salary.AllowDrop = True
        Me.txt_Salary.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Salary.Location = New System.Drawing.Point(515, 90)
        Me.txt_Salary.Name = "txt_Salary"
        Me.txt_Salary.Size = New System.Drawing.Size(163, 30)
        Me.txt_Salary.TabIndex = 89
        '
        'lbl_FromDate
        '
        Me.lbl_FromDate.AutoSize = True
        Me.lbl_FromDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_FromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FromDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_FromDate.Location = New System.Drawing.Point(391, 137)
        Me.lbl_FromDate.Name = "lbl_FromDate"
        Me.lbl_FromDate.Size = New System.Drawing.Size(107, 23)
        Me.lbl_FromDate.TabIndex = 88
        Me.lbl_FromDate.Text = "From Date:"
        '
        'lbl_Salary
        '
        Me.lbl_Salary.AutoSize = True
        Me.lbl_Salary.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_Salary.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Salary.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Salary.Location = New System.Drawing.Point(391, 90)
        Me.lbl_Salary.Name = "lbl_Salary"
        Me.lbl_Salary.Size = New System.Drawing.Size(71, 23)
        Me.lbl_Salary.TabIndex = 90
        Me.lbl_Salary.Text = "Salary:"
        '
        'lbl_ToDate
        '
        Me.lbl_ToDate.AutoSize = True
        Me.lbl_ToDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_ToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_ToDate.Location = New System.Drawing.Point(697, 137)
        Me.lbl_ToDate.Name = "lbl_ToDate"
        Me.lbl_ToDate.Size = New System.Drawing.Size(84, 23)
        Me.lbl_ToDate.TabIndex = 92
        Me.lbl_ToDate.Text = "To Date:"
        '
        'dtp_FromDate
        '
        Me.dtp_FromDate.AllowDrop = True
        Me.dtp_FromDate.CalendarFont = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FromDate.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtp_FromDate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_FromDate.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FromDate.Location = New System.Drawing.Point(515, 137)
        Me.dtp_FromDate.Name = "dtp_FromDate"
        Me.dtp_FromDate.Size = New System.Drawing.Size(163, 33)
        Me.dtp_FromDate.TabIndex = 93
        Me.dtp_FromDate.Value = New Date(2023, 5, 23, 0, 0, 0, 0)
        '
        'dtp_ToDate
        '
        Me.dtp_ToDate.AllowDrop = True
        Me.dtp_ToDate.CalendarFont = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ToDate.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtp_ToDate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ToDate.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ToDate.Location = New System.Drawing.Point(796, 134)
        Me.dtp_ToDate.Name = "dtp_ToDate"
        Me.dtp_ToDate.Size = New System.Drawing.Size(163, 33)
        Me.dtp_ToDate.TabIndex = 94
        Me.dtp_ToDate.Value = New Date(2023, 5, 23, 0, 0, 0, 0)
        '
        'dgrv_Salary
        '
        Me.dgrv_Salary.AllowUserToAddRows = False
        Me.dgrv_Salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrv_Salary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.salary_id, Me.emp_id, Me.salary, Me.from_date, Me.to_date})
        Me.dgrv_Salary.Location = New System.Drawing.Point(516, 208)
        Me.dgrv_Salary.Name = "dgrv_Salary"
        Me.dgrv_Salary.RowHeadersWidth = 51
        Me.dgrv_Salary.RowTemplate.Height = 24
        Me.dgrv_Salary.Size = New System.Drawing.Size(729, 246)
        Me.dgrv_Salary.TabIndex = 95
        '
        'salary_id
        '
        Me.salary_id.HeaderText = "Salary ID"
        Me.salary_id.MinimumWidth = 6
        Me.salary_id.Name = "salary_id"
        Me.salary_id.ReadOnly = True
        Me.salary_id.Width = 125
        '
        'emp_id
        '
        Me.emp_id.HeaderText = "Emp ID"
        Me.emp_id.MinimumWidth = 6
        Me.emp_id.Name = "emp_id"
        Me.emp_id.Width = 125
        '
        'salary
        '
        Me.salary.HeaderText = "Salary"
        Me.salary.MinimumWidth = 6
        Me.salary.Name = "salary"
        Me.salary.Width = 125
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
        'ptb_Close
        '
        Me.ptb_Close.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ptb_Close.BackgroundImage = Global.Training01.My.Resources.Resources.close_btn
        Me.ptb_Close.Image = Global.Training01.My.Resources.Resources.blue_exit_icon_16
        Me.ptb_Close.Location = New System.Drawing.Point(1252, 3)
        Me.ptb_Close.Name = "ptb_Close"
        Me.ptb_Close.Size = New System.Drawing.Size(43, 40)
        Me.ptb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_Close.TabIndex = 96
        Me.ptb_Close.TabStop = False
        '
        'btn_CalculateTotal
        '
        Me.btn_CalculateTotal.BackColor = System.Drawing.Color.Turquoise
        Me.btn_CalculateTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CalculateTotal.Location = New System.Drawing.Point(237, 265)
        Me.btn_CalculateTotal.Name = "btn_CalculateTotal"
        Me.btn_CalculateTotal.Size = New System.Drawing.Size(90, 38)
        Me.btn_CalculateTotal.TabIndex = 97
        Me.btn_CalculateTotal.Text = "Total"
        Me.btn_CalculateTotal.UseVisualStyleBackColor = False
        '
        'btn_Total
        '
        Me.btn_Total.BackColor = System.Drawing.Color.Yellow
        Me.btn_Total.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Total.Location = New System.Drawing.Point(333, 265)
        Me.btn_Total.Name = "btn_Total"
        Me.btn_Total.Size = New System.Drawing.Size(90, 38)
        Me.btn_Total.TabIndex = 98
        Me.btn_Total.Text = "Total"
        Me.btn_Total.UseVisualStyleBackColor = False
        '
        'frm_Salary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1294, 617)
        Me.Controls.Add(Me.btn_Total)
        Me.Controls.Add(Me.btn_CalculateTotal)
        Me.Controls.Add(Me.ptb_Close)
        Me.Controls.Add(Me.dgrv_Salary)
        Me.Controls.Add(Me.dtp_ToDate)
        Me.Controls.Add(Me.dtp_FromDate)
        Me.Controls.Add(Me.lbl_ToDate)
        Me.Controls.Add(Me.lbl_Salary)
        Me.Controls.Add(Me.txt_Salary)
        Me.Controls.Add(Me.lbl_FromDate)
        Me.Controls.Add(Me.lbl_SalaryID)
        Me.Controls.Add(Me.txt_SalaryID)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.lbl_Search)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.lbl_EmpID)
        Me.Controls.Add(Me.txt_EmpID)
        Me.Controls.Add(Me.lbl_TitleSalary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Salary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary"
        CType(Me.dgrv_Salary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_TitleSalary As Label
    Friend WithEvents lbl_SalaryID As Label
    Friend WithEvents txt_SalaryID As TextBox
    Friend WithEvents btn_Search As Button
    Friend WithEvents lbl_Search As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Reset As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents lbl_EmpID As Label
    Friend WithEvents txt_EmpID As TextBox
    Friend WithEvents txt_Salary As TextBox
    Friend WithEvents lbl_FromDate As Label
    Friend WithEvents lbl_Salary As Label
    Friend WithEvents lbl_ToDate As Label
    Private WithEvents dtp_FromDate As DateTimePicker
    Private WithEvents dtp_ToDate As DateTimePicker
    Friend WithEvents dgrv_Salary As DataGridView
    Friend WithEvents salary_id As DataGridViewTextBoxColumn
    Friend WithEvents emp_id As DataGridViewTextBoxColumn
    Friend WithEvents salary As DataGridViewTextBoxColumn
    Friend WithEvents from_date As DataGridViewTextBoxColumn
    Friend WithEvents to_date As DataGridViewTextBoxColumn
    Friend WithEvents ptb_Close As PictureBox
    Friend WithEvents btn_CalculateTotal As Button
    Friend WithEvents btn_Total As Button
End Class
