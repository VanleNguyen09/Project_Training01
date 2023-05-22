<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PositionMenu
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
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnPosition = New System.Windows.Forms.Button()
        Me.closeApp = New System.Windows.Forms.PictureBox()
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "POSITION MENU"
        '
        'btnEmployee
        '
        Me.btnEmployee.BackColor = System.Drawing.Color.White
        Me.btnEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.Location = New System.Drawing.Point(64, 142)
        Me.btnEmployee.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(291, 39)
        Me.btnEmployee.TabIndex = 1
        Me.btnEmployee.Text = "EMPLOYEES LIST BY POSITION"
        Me.btnEmployee.UseVisualStyleBackColor = False
        '
        'btnPosition
        '
        Me.btnPosition.BackColor = System.Drawing.Color.White
        Me.btnPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPosition.Location = New System.Drawing.Point(64, 209)
        Me.btnPosition.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPosition.Name = "btnPosition"
        Me.btnPosition.Size = New System.Drawing.Size(291, 39)
        Me.btnPosition.TabIndex = 1
        Me.btnPosition.Text = "MANAGE POSITIONS"
        Me.btnPosition.UseVisualStyleBackColor = False
        '
        'closeApp
        '
        Me.closeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeApp.Image = Global.Training01.My.Resources.Resources.close_btn
        Me.closeApp.Location = New System.Drawing.Point(386, 2)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(33, 32)
        Me.closeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closeApp.TabIndex = 2
        Me.closeApp.TabStop = False
        '
        'PositionMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.BackgroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(421, 344)
        Me.Controls.Add(Me.closeApp)
        Me.Controls.Add(Me.btnPosition)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PositionMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Position"
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnPosition As Button
    Friend WithEvents closeApp As PictureBox
End Class
