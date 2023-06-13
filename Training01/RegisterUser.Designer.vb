<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterUser
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
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblCPassword = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.closeApp = New System.Windows.Forms.PictureBox()
        Me.ptb_TogglePassword = New System.Windows.Forms.PictureBox()
        Me.ptb_ToggleCFPassword = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_TogglePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_ToggleCFPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(151, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTER FORM"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(125, 37)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 20)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(196, 33)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(365, 26)
        Me.txtEmail.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(85, 171)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(91, 20)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(196, 167)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(365, 26)
        Me.txtPassword.TabIndex = 2
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.White
        Me.lblFullName.Location = New System.Drawing.Point(91, 105)
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(85, 20)
        Me.lblFullName.TabIndex = 1
        Me.lblFullName.Text = "Fullname"
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(196, 101)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(365, 26)
        Me.txtFullName.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ptb_ToggleCFPassword)
        Me.Panel1.Controls.Add(Me.ptb_TogglePassword)
        Me.Panel1.Controls.Add(Me.txtConfirmPassword)
        Me.Panel1.Controls.Add(Me.lblCPassword)
        Me.Panel1.Controls.Add(Me.txtFullName)
        Me.Panel1.Controls.Add(Me.lblFullName)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Location = New System.Drawing.Point(16, 101)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 284)
        Me.Panel1.TabIndex = 3
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(196, 228)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(365, 26)
        Me.txtConfirmPassword.TabIndex = 3
        '
        'lblCPassword
        '
        Me.lblCPassword.AutoSize = True
        Me.lblCPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblCPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPassword.ForeColor = System.Drawing.Color.White
        Me.lblCPassword.Location = New System.Drawing.Point(5, 231)
        Me.lblCPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCPassword.Name = "lblCPassword"
        Me.lblCPassword.Size = New System.Drawing.Size(163, 20)
        Me.lblCPassword.TabIndex = 1
        Me.lblCPassword.Text = "Confirm Password"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnConfirm.Location = New System.Drawing.Point(16, 406)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(157, 37)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(443, 406)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(157, 37)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(232, 406)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(157, 37)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'closeApp
        '
        Me.closeApp.BackColor = System.Drawing.Color.Transparent
        Me.closeApp.BackgroundImage = Global.Training01.My.Resources.Resources.blue_exit_icon_16
        Me.closeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeApp.Image = Global.Training01.My.Resources.Resources.blue_exit_icon_16
        Me.closeApp.Location = New System.Drawing.Point(569, -1)
        Me.closeApp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(47, 42)
        Me.closeApp.TabIndex = 7
        Me.closeApp.TabStop = False
        '
        'ptb_TogglePassword
        '
        Me.ptb_TogglePassword.BackColor = System.Drawing.SystemColors.Control
        Me.ptb_TogglePassword.Location = New System.Drawing.Point(502, 161)
        Me.ptb_TogglePassword.Name = "ptb_TogglePassword"
        Me.ptb_TogglePassword.Size = New System.Drawing.Size(41, 32)
        Me.ptb_TogglePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_TogglePassword.TabIndex = 10
        Me.ptb_TogglePassword.TabStop = False
        '
        'ptb_ToggleCFPassword
        '
        Me.ptb_ToggleCFPassword.BackColor = System.Drawing.SystemColors.Control
        Me.ptb_ToggleCFPassword.Location = New System.Drawing.Point(502, 224)
        Me.ptb_ToggleCFPassword.Name = "ptb_ToggleCFPassword"
        Me.ptb_ToggleCFPassword.Size = New System.Drawing.Size(41, 30)
        Me.ptb_ToggleCFPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_ToggleCFPassword.TabIndex = 11
        Me.ptb_ToggleCFPassword.TabStop = False
        '
        'RegisterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.tech_background
        Me.ClientSize = New System.Drawing.Size(616, 458)
        Me.Controls.Add(Me.closeApp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "RegisterUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_TogglePassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_ToggleCFPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblCPassword As Label
    Friend WithEvents closeApp As PictureBox
    Friend WithEvents ptb_ToggleCFPassword As PictureBox
    Friend WithEvents ptb_TogglePassword As PictureBox
End Class
