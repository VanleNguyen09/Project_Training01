<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leave
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvLeave = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.from_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gb_create = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.rtxtReason = New System.Windows.Forms.RichTextBox()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEmpAdd = New System.Windows.Forms.ComboBox()
        Me.gb_actions = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.closeApp = New System.Windows.Forms.PictureBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.btnFindFromDate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvLeave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_create.SuspendLayout()
        Me.gb_actions.SuspendLayout()
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(208, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LEAVING EMPLOYEES HISTORY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(77, 93)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(309, 20)
        Me.txtSearch.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(392, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "From Date"
        '
        'dgvLeave
        '
        Me.dgvLeave.AllowUserToAddRows = False
        Me.dgvLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeave.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.id_emp, Me.emp_name, Me.from_date, Me.reason})
        Me.dgvLeave.Location = New System.Drawing.Point(12, 119)
        Me.dgvLeave.Name = "dgvLeave"
        Me.dgvLeave.Size = New System.Drawing.Size(537, 319)
        Me.dgvLeave.TabIndex = 4
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 60
        '
        'id_emp
        '
        Me.id_emp.HeaderText = "ID EMP"
        Me.id_emp.Name = "id_emp"
        Me.id_emp.ReadOnly = True
        Me.id_emp.Width = 80
        '
        'emp_name
        '
        Me.emp_name.HeaderText = "NAME"
        Me.emp_name.Name = "emp_name"
        Me.emp_name.ReadOnly = True
        '
        'from_date
        '
        Me.from_date.HeaderText = "FROM DATE"
        Me.from_date.Name = "from_date"
        Me.from_date.ReadOnly = True
        Me.from_date.Width = 110
        '
        'reason
        '
        Me.reason.HeaderText = "REASON"
        Me.reason.Name = "reason"
        Me.reason.ReadOnly = True
        Me.reason.Width = 110
        '
        'gb_create
        '
        Me.gb_create.BackColor = System.Drawing.Color.Transparent
        Me.gb_create.Controls.Add(Me.btnAdd)
        Me.gb_create.Controls.Add(Me.rtxtReason)
        Me.gb_create.Controls.Add(Me.dtpFromDate)
        Me.gb_create.Controls.Add(Me.Label6)
        Me.gb_create.Controls.Add(Me.Label5)
        Me.gb_create.Controls.Add(Me.Label4)
        Me.gb_create.Controls.Add(Me.cbEmpAdd)
        Me.gb_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_create.ForeColor = System.Drawing.Color.White
        Me.gb_create.Location = New System.Drawing.Point(565, 119)
        Me.gb_create.Name = "gb_create"
        Me.gb_create.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gb_create.Size = New System.Drawing.Size(315, 223)
        Me.gb_create.TabIndex = 5
        Me.gb_create.TabStop = False
        Me.gb_create.Text = "CREATE"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Gray
        Me.btnAdd.Location = New System.Drawing.Point(11, 184)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(295, 27)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'rtxtReason
        '
        Me.rtxtReason.Location = New System.Drawing.Point(75, 100)
        Me.rtxtReason.Name = "rtxtReason"
        Me.rtxtReason.Size = New System.Drawing.Size(231, 78)
        Me.rtxtReason.TabIndex = 3
        Me.rtxtReason.Text = ""
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Location = New System.Drawing.Point(75, 65)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(231, 20)
        Me.dtpFromDate.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Reason"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "From Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Employee"
        '
        'cbEmpAdd
        '
        Me.cbEmpAdd.DropDownHeight = 200
        Me.cbEmpAdd.FormattingEnabled = True
        Me.cbEmpAdd.IntegralHeight = False
        Me.cbEmpAdd.Location = New System.Drawing.Point(75, 31)
        Me.cbEmpAdd.Name = "cbEmpAdd"
        Me.cbEmpAdd.Size = New System.Drawing.Size(231, 21)
        Me.cbEmpAdd.TabIndex = 0
        '
        'gb_actions
        '
        Me.gb_actions.BackColor = System.Drawing.Color.Transparent
        Me.gb_actions.Controls.Add(Me.btnExit)
        Me.gb_actions.Controls.Add(Me.btnReload)
        Me.gb_actions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_actions.ForeColor = System.Drawing.Color.White
        Me.gb_actions.Location = New System.Drawing.Point(565, 348)
        Me.gb_actions.Name = "gb_actions"
        Me.gb_actions.Size = New System.Drawing.Size(315, 89)
        Me.gb_actions.TabIndex = 6
        Me.gb_actions.TabStop = False
        Me.gb_actions.Text = "ACTIONS"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Location = New System.Drawing.Point(11, 52)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(295, 27)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.Gray
        Me.btnReload.Location = New System.Drawing.Point(11, 19)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(295, 27)
        Me.btnReload.TabIndex = 4
        Me.btnReload.Text = "RELOAD FORM"
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'closeApp
        '
        Me.closeApp.Image = Global.Training01.My.Resources.Resources.close_btn
        Me.closeApp.Location = New System.Drawing.Point(852, 0)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(40, 35)
        Me.closeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closeApp.TabIndex = 7
        Me.closeApp.TabStop = False
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(481, 93)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(140, 20)
        Me.dtpStartDate.TabIndex = 8
        '
        'btnFindFromDate
        '
        Me.btnFindFromDate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnFindFromDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindFromDate.ForeColor = System.Drawing.Color.White
        Me.btnFindFromDate.Location = New System.Drawing.Point(803, 93)
        Me.btnFindFromDate.Name = "btnFindFromDate"
        Me.btnFindFromDate.Size = New System.Drawing.Size(77, 21)
        Me.btnFindFromDate.TabIndex = 9
        Me.btnFindFromDate.Text = "FIND"
        Me.btnFindFromDate.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(624, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "To"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(657, 94)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(140, 20)
        Me.dtpEndDate.TabIndex = 8
        '
        'Leave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(892, 450)
        Me.Controls.Add(Me.btnFindFromDate)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.closeApp)
        Me.Controls.Add(Me.gb_actions)
        Me.Controls.Add(Me.gb_create)
        Me.Controls.Add(Me.dgvLeave)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Leave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leave"
        CType(Me.dgvLeave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_create.ResumeLayout(False)
        Me.gb_create.PerformLayout()
        Me.gb_actions.ResumeLayout(False)
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvLeave As DataGridView
    Friend WithEvents gb_create As GroupBox
    Friend WithEvents dtpFromDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbEmpAdd As ComboBox
    Friend WithEvents rtxtReason As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gb_actions As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReload As Button
    Friend WithEvents closeApp As PictureBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents btnFindFromDate As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents id_emp As DataGridViewTextBoxColumn
    Friend WithEvents emp_name As DataGridViewTextBoxColumn
    Friend WithEvents from_date As DataGridViewTextBoxColumn
    Friend WithEvents reason As DataGridViewTextBoxColumn
End Class
