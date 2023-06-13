<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Leave
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvLeave = New System.Windows.Forms.DataGridView()
        Me.stt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.from_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.is_confirmed = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.gb_create = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.rtxtReason = New System.Windows.Forms.RichTextBox()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEmpAdd = New System.Windows.Forms.ComboBox()
        Me.gb_actions = New System.Windows.Forms.GroupBox()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.closeApp = New System.Windows.Forms.PictureBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.btnFindFromDate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTotalPage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCurrentPage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPrevious = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Label1.Location = New System.Drawing.Point(274, 32)
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
        Me.txtSearch.Size = New System.Drawing.Size(350, 20)
        Me.txtSearch.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(433, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "From Date"
        '
        'dgvLeave
        '
        Me.dgvLeave.AllowUserToAddRows = False
        Me.dgvLeave.AllowUserToDeleteRows = False
        Me.dgvLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeave.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stt, Me.id, Me.emp_id, Me.emp_name, Me.from_date, Me.reason, Me.is_confirmed})
        Me.dgvLeave.Location = New System.Drawing.Point(12, 119)
        Me.dgvLeave.MultiSelect = False
        Me.dgvLeave.Name = "dgvLeave"
        Me.dgvLeave.RowHeadersVisible = False
        Me.dgvLeave.RowHeadersWidth = 51
        Me.dgvLeave.RowTemplate.Height = 35
        Me.dgvLeave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLeave.Size = New System.Drawing.Size(673, 319)
        Me.dgvLeave.TabIndex = 8
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
        Me.id.Width = 60
        '
        'emp_id
        '
        Me.emp_id.HeaderText = "ID EMP"
        Me.emp_id.MinimumWidth = 6
        Me.emp_id.Name = "emp_id"
        Me.emp_id.ReadOnly = True
        Me.emp_id.Width = 60
        '
        'emp_name
        '
        Me.emp_name.HeaderText = "NAME"
        Me.emp_name.MinimumWidth = 6
        Me.emp_name.Name = "emp_name"
        Me.emp_name.ReadOnly = True
        Me.emp_name.Width = 125
        '
        'from_date
        '
        Me.from_date.HeaderText = "FROM DATE"
        Me.from_date.MinimumWidth = 6
        Me.from_date.Name = "from_date"
        Me.from_date.ReadOnly = True
        Me.from_date.Width = 95
        '
        'reason
        '
        Me.reason.HeaderText = "REASON"
        Me.reason.MinimumWidth = 6
        Me.reason.Name = "reason"
        Me.reason.ReadOnly = True
        Me.reason.Width = 110
        '
        'is_confirmed
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        Me.is_confirmed.DefaultCellStyle = DataGridViewCellStyle2
        Me.is_confirmed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.is_confirmed.HeaderText = "IS CONFIRMED"
        Me.is_confirmed.MinimumWidth = 6
        Me.is_confirmed.Name = "is_confirmed"
        Me.is_confirmed.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.is_confirmed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.is_confirmed.Width = 120
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
        Me.gb_create.Location = New System.Drawing.Point(691, 119)
        Me.gb_create.Name = "gb_create"
        Me.gb_create.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gb_create.Size = New System.Drawing.Size(275, 223)
        Me.gb_create.TabIndex = 9
        Me.gb_create.TabStop = False
        Me.gb_create.Text = "CREATE"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.IndianRed
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(11, 184)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(250, 27)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'rtxtReason
        '
        Me.rtxtReason.Location = New System.Drawing.Point(75, 100)
        Me.rtxtReason.Name = "rtxtReason"
        Me.rtxtReason.Size = New System.Drawing.Size(186, 78)
        Me.rtxtReason.TabIndex = 15
        Me.rtxtReason.Text = ""
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Location = New System.Drawing.Point(75, 65)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(186, 20)
        Me.dtpFromDate.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Reason"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "From Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Employee"
        '
        'cbEmpAdd
        '
        Me.cbEmpAdd.DropDownHeight = 200
        Me.cbEmpAdd.FormattingEnabled = True
        Me.cbEmpAdd.IntegralHeight = False
        Me.cbEmpAdd.ItemHeight = 13
        Me.cbEmpAdd.Location = New System.Drawing.Point(75, 31)
        Me.cbEmpAdd.Name = "cbEmpAdd"
        Me.cbEmpAdd.Size = New System.Drawing.Size(186, 21)
        Me.cbEmpAdd.TabIndex = 11
        '
        'gb_actions
        '
        Me.gb_actions.BackColor = System.Drawing.Color.Transparent
        Me.gb_actions.Controls.Add(Me.btnReload)
        Me.gb_actions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_actions.ForeColor = System.Drawing.Color.White
        Me.gb_actions.Location = New System.Drawing.Point(691, 348)
        Me.gb_actions.Name = "gb_actions"
        Me.gb_actions.Size = New System.Drawing.Size(275, 89)
        Me.gb_actions.TabIndex = 17
        Me.gb_actions.TabStop = False
        Me.gb_actions.Text = "ACTIONS"
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.IndianRed
        Me.btnReload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Location = New System.Drawing.Point(11, 19)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(250, 52)
        Me.btnReload.TabIndex = 18
        Me.btnReload.Text = "RELOAD ALL"
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'closeApp
        '
        Me.closeApp.BackColor = System.Drawing.Color.Transparent
        Me.closeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeApp.Image = Global.Training01.My.Resources.Resources.blue_exit_icon_16
        Me.closeApp.Location = New System.Drawing.Point(942, 0)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(40, 35)
        Me.closeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closeApp.TabIndex = 7
        Me.closeApp.TabStop = False
        Me.closeApp.Visible = False
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(522, 94)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(158, 20)
        Me.dtpStartDate.TabIndex = 4
        '
        'btnFindFromDate
        '
        Me.btnFindFromDate.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnFindFromDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindFromDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindFromDate.ForeColor = System.Drawing.Color.White
        Me.btnFindFromDate.Location = New System.Drawing.Point(865, 95)
        Me.btnFindFromDate.Name = "btnFindFromDate"
        Me.btnFindFromDate.Size = New System.Drawing.Size(101, 21)
        Me.btnFindFromDate.TabIndex = 7
        Me.btnFindFromDate.Text = "FIND"
        Me.btnFindFromDate.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(686, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "To"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(719, 95)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(140, 20)
        Me.dtpEndDate.TabIndex = 6
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(334, 450)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(18, 18)
        Me.Guna2HtmlLabel1.TabIndex = 22
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
        Me.txtTotalPage.Location = New System.Drawing.Point(358, 445)
        Me.txtTotalPage.Name = "txtTotalPage"
        Me.txtTotalPage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalPage.PlaceholderText = ""
        Me.txtTotalPage.ReadOnly = True
        Me.txtTotalPage.SelectedText = ""
        Me.txtTotalPage.Size = New System.Drawing.Size(41, 28)
        Me.txtTotalPage.TabIndex = 20
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
        Me.txtCurrentPage.Location = New System.Drawing.Point(289, 445)
        Me.txtCurrentPage.Name = "txtCurrentPage"
        Me.txtCurrentPage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCurrentPage.PlaceholderText = ""
        Me.txtCurrentPage.SelectedText = ""
        Me.txtCurrentPage.Size = New System.Drawing.Size(41, 28)
        Me.txtCurrentPage.TabIndex = 21
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
        Me.btnNext.Location = New System.Drawing.Point(405, 444)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(89, 29)
        Me.btnNext.TabIndex = 18
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
        Me.btnPrevious.Location = New System.Drawing.Point(194, 444)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(89, 29)
        Me.btnPrevious.TabIndex = 19
        Me.btnPrevious.Text = "PREVIOUS"
        Me.btnPrevious.UseTransparentBackground = True
        '
        'Leave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.tech_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(983, 484)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.txtTotalPage)
        Me.Controls.Add(Me.txtCurrentPage)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
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
    Friend WithEvents btnReload As Button
    Friend WithEvents closeApp As PictureBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents btnFindFromDate As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTotalPage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCurrentPage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPrevious As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents stt As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents emp_id As DataGridViewTextBoxColumn
    Friend WithEvents emp_name As DataGridViewTextBoxColumn
    Friend WithEvents from_date As DataGridViewTextBoxColumn
    Friend WithEvents reason As DataGridViewTextBoxColumn
    Friend WithEvents is_confirmed As DataGridViewButtonColumn
End Class
