<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pn_nhanvien = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Employee = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pn_nhanvien.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Beige
        Me.Label1.Location = New System.Drawing.Point(532, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DASHBOARD"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(45, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(301, 102)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Employee Total"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(1041, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(270, 102)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Salary"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOrange
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(387, 81)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(300, 102)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Department"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkOrange
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(715, 81)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(307, 102)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Position"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'pn_nhanvien
        '
        Me.pn_nhanvien.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pn_nhanvien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_nhanvien.Controls.Add(Me.Panel1)
        Me.pn_nhanvien.Controls.Add(Me.Button5)
        Me.pn_nhanvien.Controls.Add(Me.Panel7)
        Me.pn_nhanvien.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pn_nhanvien.Location = New System.Drawing.Point(100, 247)
        Me.pn_nhanvien.Name = "pn_nhanvien"
        Me.pn_nhanvien.Size = New System.Drawing.Size(149, 175)
        Me.pn_nhanvien.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_Employee)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 175)
        Me.Panel1.TabIndex = 5
        '
        'btn_Employee
        '
        Me.btn_Employee.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_Employee.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Employee.Location = New System.Drawing.Point(-2, 137)
        Me.btn_Employee.Name = "btn_Employee"
        Me.btn_Employee.Size = New System.Drawing.Size(149, 37)
        Me.btn_Employee.TabIndex = 2
        Me.btn_Employee.Text = "Employee"
        Me.btn_Employee.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Training01.My.Resources.Resources.avatar3
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Location = New System.Drawing.Point(26, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(97, 97)
        Me.Panel2.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(-2, 137)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(149, 37)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Employee"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel7.Location = New System.Drawing.Point(26, 19)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(97, 97)
        Me.Panel7.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.Button7)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(454, 243)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(149, 175)
        Me.Panel6.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(-2, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(149, 175)
        Me.Panel4.TabIndex = 13
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button8.Location = New System.Drawing.Point(-2, 137)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(149, 37)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Department"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Training01.My.Resources.Resources.avatar3
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(26, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(97, 97)
        Me.Panel3.TabIndex = 1
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button7.Location = New System.Drawing.Point(-2, 137)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(149, 37)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Department"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel8.Location = New System.Drawing.Point(26, 19)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(97, 97)
        Me.Panel8.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.Button10)
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.Location = New System.Drawing.Point(1104, 247)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(149, 171)
        Me.Panel9.TabIndex = 14
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button10.Location = New System.Drawing.Point(-2, 137)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(149, 37)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "Salary"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.BackgroundImage = Global.Training01.My.Resources.Resources.avatar3
        Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Location = New System.Drawing.Point(26, 23)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(97, 93)
        Me.Panel11.TabIndex = 1
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.Button9)
        Me.Panel10.Controls.Add(Me.Panel5)
        Me.Panel10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(789, 243)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(149, 175)
        Me.Panel10.TabIndex = 13
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button9.Location = New System.Drawing.Point(-2, 137)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(149, 37)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "Position"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.Training01.My.Resources.Resources.avatar3
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Location = New System.Drawing.Point(26, 19)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(97, 97)
        Me.Panel5.TabIndex = 1
        Me.Panel5.UseWaitCursor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1353, 695)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.pn_nhanvien)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.pn_nhanvien.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Public WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pn_nhanvien As Panel
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Employee As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Button9 As Button
End Class
