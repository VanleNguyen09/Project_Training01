<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditLeaveForm
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
        Me.closeApp = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbEmpName = New System.Windows.Forms.ComboBox()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.rtxtReason = New System.Windows.Forms.RichTextBox()
        Me.gbInformation = New System.Windows.Forms.GroupBox()
        Me.lbEmpIdValue = New System.Windows.Forms.Label()
        Me.lbIdValue = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'closeApp
        '
        Me.closeApp.BackColor = System.Drawing.Color.Transparent
        Me.closeApp.BackgroundImage = Global.Training01.My.Resources.Resources.blue_exit_icon_16
        Me.closeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeApp.Location = New System.Drawing.Point(578, 0)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(40, 39)
        Me.closeApp.TabIndex = 0
        Me.closeApp.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(159, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LEAVE INFORMATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(25, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(25, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "EMPLOYEE ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(25, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "EMPLOYEE NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(25, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "FROM DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(25, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "REASON"
        '
        'cbEmpName
        '
        Me.cbEmpName.DropDownHeight = 100
        Me.cbEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpName.FormattingEnabled = True
        Me.cbEmpName.IntegralHeight = False
        Me.cbEmpName.Location = New System.Drawing.Point(182, 113)
        Me.cbEmpName.Name = "cbEmpName"
        Me.cbEmpName.Size = New System.Drawing.Size(207, 24)
        Me.cbEmpName.TabIndex = 4
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Location = New System.Drawing.Point(182, 163)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(207, 23)
        Me.dtpFromDate.TabIndex = 5
        '
        'rtxtReason
        '
        Me.rtxtReason.Location = New System.Drawing.Point(182, 217)
        Me.rtxtReason.Name = "rtxtReason"
        Me.rtxtReason.Size = New System.Drawing.Size(342, 125)
        Me.rtxtReason.TabIndex = 6
        Me.rtxtReason.Text = ""
        '
        'gbInformation
        '
        Me.gbInformation.BackColor = System.Drawing.Color.Transparent
        Me.gbInformation.Controls.Add(Me.rtxtReason)
        Me.gbInformation.Controls.Add(Me.dtpFromDate)
        Me.gbInformation.Controls.Add(Me.cbEmpName)
        Me.gbInformation.Controls.Add(Me.Label6)
        Me.gbInformation.Controls.Add(Me.Label5)
        Me.gbInformation.Controls.Add(Me.Label4)
        Me.gbInformation.Controls.Add(Me.lbEmpIdValue)
        Me.gbInformation.Controls.Add(Me.Label3)
        Me.gbInformation.Controls.Add(Me.lbIdValue)
        Me.gbInformation.Controls.Add(Me.Label2)
        Me.gbInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInformation.ForeColor = System.Drawing.Color.White
        Me.gbInformation.Location = New System.Drawing.Point(34, 65)
        Me.gbInformation.Name = "gbInformation"
        Me.gbInformation.Size = New System.Drawing.Size(552, 364)
        Me.gbInformation.TabIndex = 1
        Me.gbInformation.TabStop = False
        Me.gbInformation.Text = "INFORMATION"
        '
        'lbEmpIdValue
        '
        Me.lbEmpIdValue.AutoSize = True
        Me.lbEmpIdValue.BackColor = System.Drawing.Color.Transparent
        Me.lbEmpIdValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmpIdValue.ForeColor = System.Drawing.Color.Transparent
        Me.lbEmpIdValue.Location = New System.Drawing.Point(182, 70)
        Me.lbEmpIdValue.Name = "lbEmpIdValue"
        Me.lbEmpIdValue.Size = New System.Drawing.Size(166, 17)
        Me.lbEmpIdValue.TabIndex = 3
        Me.lbEmpIdValue.Text = "EMPLOYEE ID VALUE"
        '
        'lbIdValue
        '
        Me.lbIdValue.AutoSize = True
        Me.lbIdValue.BackColor = System.Drawing.Color.Transparent
        Me.lbIdValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdValue.ForeColor = System.Drawing.Color.Transparent
        Me.lbIdValue.Location = New System.Drawing.Point(182, 29)
        Me.lbIdValue.Name = "lbIdValue"
        Me.lbIdValue.Size = New System.Drawing.Size(78, 17)
        Me.lbIdValue.TabIndex = 2
        Me.lbIdValue.Text = "ID VALUE"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.IndianRed
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Enabled = False
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(448, 447)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(138, 33)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Tomato
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(304, 447)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(138, 33)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Green
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(32, 447)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(262, 33)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "CONFIRM THIS LEAVE"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'EditLeaveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.tech_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(618, 492)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
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
    Friend WithEvents cbEmpName As ComboBox
    Friend WithEvents dtpFromDate As DateTimePicker
    Friend WithEvents rtxtReason As RichTextBox
    Friend WithEvents gbInformation As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lbEmpIdValue As Label
    Friend WithEvents lbIdValue As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnConfirm As Button
End Class
