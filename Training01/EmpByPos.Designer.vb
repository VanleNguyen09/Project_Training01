<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpByPos
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.cbSearch = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvEmpByPos = New System.Windows.Forms.DataGridView()
        Me.stt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pos_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pos_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grb_create = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.cbEmpCreate = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbPosCreate = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.closeApp = New System.Windows.Forms.PictureBox()
        Me.btnManagePos = New System.Windows.Forms.Button()
        Me.btnPrevious = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCurrentPage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTotalPage = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dgvEmpByPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_create.SuspendLayout()
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(271, 31)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(452, 31)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "EMPLOYEES LIST BY POSITION"
        '
        'cbSearch
        '
        Me.cbSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbSearch.DropDownHeight = 100
        Me.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearch.DropDownWidth = 200
        Me.cbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearch.FormattingEnabled = True
        Me.cbSearch.IntegralHeight = False
        Me.cbSearch.Location = New System.Drawing.Point(93, 90)
        Me.cbSearch.Name = "cbSearch"
        Me.cbSearch.Size = New System.Drawing.Size(205, 21)
        Me.cbSearch.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Position"
        '
        'dgvEmpByPos
        '
        Me.dgvEmpByPos.AllowUserToAddRows = False
        Me.dgvEmpByPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpByPos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stt, Me.id, Me.emp_name, Me.phone, Me.email, Me.birthday, Me.pos_name, Me.pos_id})
        Me.dgvEmpByPos.Location = New System.Drawing.Point(24, 126)
        Me.dgvEmpByPos.Name = "dgvEmpByPos"
        Me.dgvEmpByPos.RowHeadersVisible = False
        Me.dgvEmpByPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpByPos.Size = New System.Drawing.Size(643, 246)
        Me.dgvEmpByPos.TabIndex = 3
        '
        'stt
        '
        Me.stt.HeaderText = "STT"
        Me.stt.Name = "stt"
        Me.stt.ReadOnly = True
        Me.stt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.stt.Width = 70
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.id.Visible = False
        Me.id.Width = 70
        '
        'emp_name
        '
        Me.emp_name.HeaderText = "NAME"
        Me.emp_name.Name = "emp_name"
        Me.emp_name.ReadOnly = True
        Me.emp_name.Width = 120
        '
        'phone
        '
        Me.phone.HeaderText = "PHONE"
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        Me.phone.Width = 110
        '
        'email
        '
        Me.email.HeaderText = "EMAIL"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 140
        '
        'birthday
        '
        Me.birthday.HeaderText = "BIRTHDAY"
        Me.birthday.Name = "birthday"
        Me.birthday.ReadOnly = True
        '
        'pos_name
        '
        Me.pos_name.HeaderText = "POSITION"
        Me.pos_name.Name = "pos_name"
        Me.pos_name.ReadOnly = True
        '
        'pos_id
        '
        Me.pos_id.HeaderText = "PositionId"
        Me.pos_id.Name = "pos_id"
        Me.pos_id.ReadOnly = True
        Me.pos_id.Visible = False
        '
        'grb_create
        '
        Me.grb_create.BackColor = System.Drawing.Color.Transparent
        Me.grb_create.Controls.Add(Me.btnAdd)
        Me.grb_create.Controls.Add(Me.cbEmpCreate)
        Me.grb_create.Controls.Add(Me.Label4)
        Me.grb_create.Controls.Add(Me.cbPosCreate)
        Me.grb_create.Controls.Add(Me.Label3)
        Me.grb_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_create.ForeColor = System.Drawing.Color.White
        Me.grb_create.Location = New System.Drawing.Point(673, 164)
        Me.grb_create.Name = "grb_create"
        Me.grb_create.Size = New System.Drawing.Size(304, 208)
        Me.grb_create.TabIndex = 4
        Me.grb_create.TabStop = False
        Me.grb_create.Text = "CREATE"
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.BorderColor = System.Drawing.Color.White
        Me.btnAdd.BorderThickness = 2
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(10, 115)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(281, 40)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "ADD"
        '
        'cbEmpCreate
        '
        Me.cbEmpCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbEmpCreate.DropDownHeight = 100
        Me.cbEmpCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpCreate.FormattingEnabled = True
        Me.cbEmpCreate.IntegralHeight = False
        Me.cbEmpCreate.Location = New System.Drawing.Point(91, 72)
        Me.cbEmpCreate.Name = "cbEmpCreate"
        Me.cbEmpCreate.Size = New System.Drawing.Size(200, 21)
        Me.cbEmpCreate.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Employee"
        '
        'cbPosCreate
        '
        Me.cbPosCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbPosCreate.DropDownHeight = 100
        Me.cbPosCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPosCreate.FormattingEnabled = True
        Me.cbPosCreate.IntegralHeight = False
        Me.cbPosCreate.Location = New System.Drawing.Point(91, 35)
        Me.cbPosCreate.Name = "cbPosCreate"
        Me.cbPosCreate.Size = New System.Drawing.Size(200, 21)
        Me.cbPosCreate.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Position"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.IndianRed
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(673, 126)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(304, 32)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'closeApp
        '
        Me.closeApp.BackColor = System.Drawing.Color.Transparent
        Me.closeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeApp.Image = Global.Training01.My.Resources.Resources.blue_exit_icon_16
        Me.closeApp.Location = New System.Drawing.Point(969, 0)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(41, 39)
        Me.closeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeApp.TabIndex = 5
        Me.closeApp.TabStop = False
        '
        'btnManagePos
        '
        Me.btnManagePos.BackColor = System.Drawing.Color.IndianRed
        Me.btnManagePos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManagePos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManagePos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagePos.ForeColor = System.Drawing.Color.White
        Me.btnManagePos.Location = New System.Drawing.Point(673, 378)
        Me.btnManagePos.Name = "btnManagePos"
        Me.btnManagePos.Size = New System.Drawing.Size(304, 32)
        Me.btnManagePos.TabIndex = 3
        Me.btnManagePos.Text = "MANAGE POSITION"
        Me.btnManagePos.UseVisualStyleBackColor = False
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
        Me.btnPrevious.Location = New System.Drawing.Point(182, 381)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(89, 29)
        Me.btnPrevious.TabIndex = 6
        Me.btnPrevious.Text = "PREVIOUS"
        Me.btnPrevious.UseTransparentBackground = True
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
        Me.btnNext.Location = New System.Drawing.Point(393, 381)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(89, 29)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseTransparentBackground = True
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
        Me.txtCurrentPage.Location = New System.Drawing.Point(277, 382)
        Me.txtCurrentPage.Name = "txtCurrentPage"
        Me.txtCurrentPage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCurrentPage.PlaceholderText = ""
        Me.txtCurrentPage.SelectedText = ""
        Me.txtCurrentPage.Size = New System.Drawing.Size(41, 28)
        Me.txtCurrentPage.TabIndex = 7
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(322, 387)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(18, 18)
        Me.Guna2HtmlLabel1.TabIndex = 8
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
        Me.txtTotalPage.Location = New System.Drawing.Point(346, 382)
        Me.txtTotalPage.Name = "txtTotalPage"
        Me.txtTotalPage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalPage.PlaceholderText = ""
        Me.txtTotalPage.ReadOnly = True
        Me.txtTotalPage.SelectedText = ""
        Me.txtTotalPage.Size = New System.Drawing.Size(41, 28)
        Me.txtTotalPage.TabIndex = 7
        '
        'EmpByPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.tech_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1010, 423)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.txtTotalPage)
        Me.Controls.Add(Me.txtCurrentPage)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.closeApp)
        Me.Controls.Add(Me.btnManagePos)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.grb_create)
        Me.Controls.Add(Me.dgvEmpByPos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbSearch)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmpByPos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmpByPos"
        CType(Me.dgvEmpByPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_create.ResumeLayout(False)
        Me.grb_create.PerformLayout()
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents cbSearch As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvEmpByPos As DataGridView
    Friend WithEvents grb_create As GroupBox
    Friend WithEvents cbEmpCreate As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbPosCreate As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents closeApp As PictureBox
    Friend WithEvents btnManagePos As Button
    Friend WithEvents btnPrevious As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCurrentPage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTotalPage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents stt As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents emp_name As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents birthday As DataGridViewTextBoxColumn
    Friend WithEvents pos_name As DataGridViewTextBoxColumn
    Friend WithEvents pos_id As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
End Class
