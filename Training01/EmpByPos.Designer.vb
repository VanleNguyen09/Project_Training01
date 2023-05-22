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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpByPos))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.cbSearch = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvEmpByPos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grb_create = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cbEmpCreate = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbPosCreate = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.closeApp = New System.Windows.Forms.PictureBox()
        Me.btnManagePos = New System.Windows.Forms.Button()
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
        Me.lbl_title.Location = New System.Drawing.Point(173, 31)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(452, 31)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "EMPLOYEES LIST BY POSITION"
        '
        'cbSearch
        '
        Me.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearch.FormattingEnabled = True
        Me.cbSearch.Location = New System.Drawing.Point(93, 90)
        Me.cbSearch.Name = "cbSearch"
        Me.cbSearch.Size = New System.Drawing.Size(178, 21)
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
        Me.dgvEmpByPos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.emp_name, Me.phone, Me.email, Me.birthday})
        Me.dgvEmpByPos.Location = New System.Drawing.Point(24, 126)
        Me.dgvEmpByPos.Name = "dgvEmpByPos"
        Me.dgvEmpByPos.Size = New System.Drawing.Size(483, 246)
        Me.dgvEmpByPos.TabIndex = 3
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'emp_name
        '
        Me.emp_name.HeaderText = "NAME"
        Me.emp_name.Name = "emp_name"
        '
        'phone
        '
        Me.phone.HeaderText = "PHONE"
        Me.phone.Name = "phone"
        '
        'email
        '
        Me.email.HeaderText = "EMAIL"
        Me.email.Name = "email"
        '
        'birthday
        '
        Me.birthday.HeaderText = "BIRTHDAY"
        Me.birthday.Name = "birthday"
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
        Me.grb_create.Location = New System.Drawing.Point(511, 166)
        Me.grb_create.Name = "grb_create"
        Me.grb_create.Size = New System.Drawing.Size(304, 162)
        Me.grb_create.TabIndex = 4
        Me.grb_create.TabStop = False
        Me.grb_create.Text = "CREATE"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(91, 108)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(200, 32)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cbEmpCreate
        '
        Me.cbEmpCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpCreate.FormattingEnabled = True
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
        Me.cbPosCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPosCreate.FormattingEnabled = True
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
        Me.btnRemove.BackColor = System.Drawing.Color.White
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(511, 126)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(304, 32)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(701, 340)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 32)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'closeApp
        '
        Me.closeApp.BackColor = System.Drawing.Color.Transparent
        Me.closeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeApp.Image = CType(resources.GetObject("closeApp.Image"), System.Drawing.Image)
        Me.closeApp.Location = New System.Drawing.Point(785, 0)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(41, 39)
        Me.closeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeApp.TabIndex = 5
        Me.closeApp.TabStop = False
        '
        'btnManagePos
        '
        Me.btnManagePos.BackColor = System.Drawing.Color.White
        Me.btnManagePos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagePos.ForeColor = System.Drawing.Color.Black
        Me.btnManagePos.Location = New System.Drawing.Point(511, 340)
        Me.btnManagePos.Name = "btnManagePos"
        Me.btnManagePos.Size = New System.Drawing.Size(184, 32)
        Me.btnManagePos.TabIndex = 3
        Me.btnManagePos.Text = "MANAGE POSITION"
        Me.btnManagePos.UseVisualStyleBackColor = False
        '
        'EmpByPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(827, 406)
        Me.Controls.Add(Me.closeApp)
        Me.Controls.Add(Me.btnManagePos)
        Me.Controls.Add(Me.btnExit)
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
    Friend WithEvents btnAdd As Button
    Friend WithEvents cbEmpCreate As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbPosCreate As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents emp_name As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents birthday As DataGridViewTextBoxColumn
    Friend WithEvents btnExit As Button
    Friend WithEvents closeApp As PictureBox
    Friend WithEvents btnManagePos As Button
End Class
