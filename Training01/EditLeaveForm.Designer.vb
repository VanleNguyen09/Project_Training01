<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditLeaveForm
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
        Me.closeApp = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.cbEmpName = New System.Windows.Forms.ComboBox()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.rtxtReason = New System.Windows.Forms.RichTextBox()
        Me.gbInformation = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'closeApp
        '
        Me.closeApp.BackgroundImage = Global.Training01.My.Resources.Resources.close_btn
        Me.closeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeApp.Location = New System.Drawing.Point(575, 3)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(40, 39)
        Me.closeApp.TabIndex = 0
        Me.closeApp.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(159, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LEAVE INFORMATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "EMPLOYEE ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "EMPLOYEE NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(25, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "FROM DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(25, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "REASON"
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(182, 26)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(157, 23)
        Me.txtId.TabIndex = 1
        '
        'txtEmpId
        '
        Me.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpId.Location = New System.Drawing.Point(182, 67)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.ReadOnly = True
        Me.txtEmpId.Size = New System.Drawing.Size(157, 23)
        Me.txtEmpId.TabIndex = 2
        '
        'cbEmpName
        '
        Me.cbEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpName.FormattingEnabled = True
        Me.cbEmpName.Location = New System.Drawing.Point(182, 113)
        Me.cbEmpName.Name = "cbEmpName"
        Me.cbEmpName.Size = New System.Drawing.Size(207, 24)
        Me.cbEmpName.TabIndex = 3
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Location = New System.Drawing.Point(182, 163)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(207, 23)
        Me.dtpFromDate.TabIndex = 4
        '
        'rtxtReason
        '
        Me.rtxtReason.Location = New System.Drawing.Point(182, 217)
        Me.rtxtReason.Name = "rtxtReason"
        Me.rtxtReason.Size = New System.Drawing.Size(342, 125)
        Me.rtxtReason.TabIndex = 5
        Me.rtxtReason.Text = ""
        '
        'gbInformation
        '
        Me.gbInformation.BackColor = System.Drawing.Color.Transparent
        Me.gbInformation.Controls.Add(Me.rtxtReason)
        Me.gbInformation.Controls.Add(Me.dtpFromDate)
        Me.gbInformation.Controls.Add(Me.cbEmpName)
        Me.gbInformation.Controls.Add(Me.txtEmpId)
        Me.gbInformation.Controls.Add(Me.txtId)
        Me.gbInformation.Controls.Add(Me.Label6)
        Me.gbInformation.Controls.Add(Me.Label5)
        Me.gbInformation.Controls.Add(Me.Label4)
        Me.gbInformation.Controls.Add(Me.Label3)
        Me.gbInformation.Controls.Add(Me.Label2)
        Me.gbInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInformation.ForeColor = System.Drawing.Color.White
        Me.gbInformation.Location = New System.Drawing.Point(34, 65)
        Me.gbInformation.Name = "gbInformation"
        Me.gbInformation.Size = New System.Drawing.Size(552, 364)
        Me.gbInformation.TabIndex = 0
        Me.gbInformation.TabStop = False
        Me.gbInformation.Text = "INFORMATION"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(448, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 33)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EditLeaveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(618, 492)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbInformation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeApp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditLeaveForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditLeaveForm"
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInformation.ResumeLayout(False)
        Me.gbInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closeApp As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtEmpId As TextBox
    Friend WithEvents cbEmpName As ComboBox
    Friend WithEvents dtpFromDate As DateTimePicker
    Friend WithEvents rtxtReason As RichTextBox
    Friend WithEvents gbInformation As GroupBox
    Friend WithEvents Button1 As Button
End Class
