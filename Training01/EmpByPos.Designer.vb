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
        Me.grb_create = New System.Windows.Forms.GroupBox()
        Me.cbPosCreate = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEmpCreate = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grb_del = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.cbPosRemove = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbEmpRemove = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvEmpByPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_create.SuspendLayout()
        Me.grb_del.SuspendLayout()
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
        Me.dgvEmpByPos.Location = New System.Drawing.Point(24, 126)
        Me.dgvEmpByPos.Name = "dgvEmpByPos"
        Me.dgvEmpByPos.Size = New System.Drawing.Size(483, 246)
        Me.dgvEmpByPos.TabIndex = 3
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
        Me.grb_create.Location = New System.Drawing.Point(517, 87)
        Me.grb_create.Name = "grb_create"
        Me.grb_create.Size = New System.Drawing.Size(304, 140)
        Me.grb_create.TabIndex = 4
        Me.grb_create.TabStop = False
        Me.grb_create.Text = "CREATE"
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
        'cbEmpCreate
        '
        Me.cbEmpCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpCreate.FormattingEnabled = True
        Me.cbEmpCreate.Location = New System.Drawing.Point(91, 72)
        Me.cbEmpCreate.Name = "cbEmpCreate"
        Me.cbEmpCreate.Size = New System.Drawing.Size(200, 21)
        Me.cbEmpCreate.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(209, 99)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 32)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'grb_del
        '
        Me.grb_del.BackColor = System.Drawing.Color.Transparent
        Me.grb_del.Controls.Add(Me.btnRemove)
        Me.grb_del.Controls.Add(Me.cbPosRemove)
        Me.grb_del.Controls.Add(Me.Label5)
        Me.grb_del.Controls.Add(Me.cbEmpRemove)
        Me.grb_del.Controls.Add(Me.Label6)
        Me.grb_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_del.ForeColor = System.Drawing.Color.White
        Me.grb_del.Location = New System.Drawing.Point(517, 232)
        Me.grb_del.Name = "grb_del"
        Me.grb_del.Size = New System.Drawing.Size(304, 140)
        Me.grb_del.TabIndex = 4
        Me.grb_del.TabStop = False
        Me.grb_del.Text = "REMOVE"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.White
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(209, 99)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(82, 32)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'cbPosRemove
        '
        Me.cbPosRemove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPosRemove.FormattingEnabled = True
        Me.cbPosRemove.Location = New System.Drawing.Point(91, 72)
        Me.cbPosRemove.Name = "cbPosRemove"
        Me.cbPosRemove.Size = New System.Drawing.Size(200, 21)
        Me.cbPosRemove.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Employee"
        '
        'cbEmpRemove
        '
        Me.cbEmpRemove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpRemove.FormattingEnabled = True
        Me.cbEmpRemove.Location = New System.Drawing.Point(91, 35)
        Me.cbEmpRemove.Name = "cbEmpRemove"
        Me.cbEmpRemove.Size = New System.Drawing.Size(200, 21)
        Me.cbEmpRemove.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Position"
        '
        'EmpByPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(827, 406)
        Me.Controls.Add(Me.grb_del)
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
        Me.grb_del.ResumeLayout(False)
        Me.grb_del.PerformLayout()
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
    Friend WithEvents grb_del As GroupBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents cbPosRemove As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbEmpRemove As ComboBox
    Friend WithEvents Label6 As Label
End Class
