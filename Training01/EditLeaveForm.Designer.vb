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
        Me.cbEmpName = New System.Windows.Forms.ComboBox()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.rtxtReason = New System.Windows.Forms.RichTextBox()
        Me.gbInformation = New System.Windows.Forms.GroupBox()
        Me.lbEmpIdValue = New System.Windows.Forms.Label()
        Me.lbIdValue = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
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
        Me.closeApp.Location = New System.Drawing.Point(771, 0)
        Me.closeApp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(53, 48)
        Me.closeApp.TabIndex = 0
        Me.closeApp.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(212, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LEAVE INFORMATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(33, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(33, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "EMPLOYEE ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(33, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "EMPLOYEE NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(33, 204)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "FROM DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(33, 267)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "REASON"
        '
        'cbEmpName
        '
        Me.cbEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpName.FormattingEnabled = True
        Me.cbEmpName.Location = New System.Drawing.Point(243, 139)
        Me.cbEmpName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbEmpName.Name = "cbEmpName"
        Me.cbEmpName.Size = New System.Drawing.Size(275, 28)
        Me.cbEmpName.TabIndex = 4
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Location = New System.Drawing.Point(243, 201)
        Me.dtpFromDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(275, 26)
        Me.dtpFromDate.TabIndex = 5
        '
        'rtxtReason
        '
        Me.rtxtReason.Location = New System.Drawing.Point(243, 267)
        Me.rtxtReason.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtxtReason.Name = "rtxtReason"
        Me.rtxtReason.Size = New System.Drawing.Size(455, 153)
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
        Me.gbInformation.Location = New System.Drawing.Point(45, 80)
        Me.gbInformation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbInformation.Name = "gbInformation"
        Me.gbInformation.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbInformation.Size = New System.Drawing.Size(736, 448)
        Me.gbInformation.TabIndex = 1
        Me.gbInformation.TabStop = False
        Me.gbInformation.Text = "INFORMATION"
        '
        'lbEmpIdValue
        '
        Me.lbEmpIdValue.AutoSize = True
        Me.lbEmpIdValue.BackColor = System.Drawing.Color.White
        Me.lbEmpIdValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmpIdValue.ForeColor = System.Drawing.Color.Black
        Me.lbEmpIdValue.Location = New System.Drawing.Point(243, 86)
        Me.lbEmpIdValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEmpIdValue.Name = "lbEmpIdValue"
        Me.lbEmpIdValue.Size = New System.Drawing.Size(199, 20)
        Me.lbEmpIdValue.TabIndex = 3
        Me.lbEmpIdValue.Text = "EMPLOYEE ID VALUE"
        '
        'lbIdValue
        '
        Me.lbIdValue.AutoSize = True
        Me.lbIdValue.BackColor = System.Drawing.Color.White
        Me.lbIdValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdValue.ForeColor = System.Drawing.Color.Black
        Me.lbIdValue.Location = New System.Drawing.Point(243, 36)
        Me.lbIdValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbIdValue.Name = "lbIdValue"
        Me.lbIdValue.Size = New System.Drawing.Size(94, 20)
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
        Me.btnSave.Location = New System.Drawing.Point(597, 550)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(184, 41)
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
        Me.btnReset.Location = New System.Drawing.Point(405, 550)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(184, 41)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'EditLeaveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(824, 606)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbInformation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeApp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
End Class
