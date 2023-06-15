<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PDFViewer
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
        Dim gbtn_Cancel As Guna.UI2.WinForms.Guna2GradientButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PDFViewer))
        Me.gbtn_OK = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pn_Botttom = New System.Windows.Forms.Panel()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        gbtn_Cancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pn_Botttom.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbtn_Cancel
        '
        gbtn_Cancel.BackColor = System.Drawing.Color.Transparent
        gbtn_Cancel.BorderRadius = 5
        gbtn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        gbtn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        gbtn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        gbtn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        gbtn_Cancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        gbtn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        gbtn_Cancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        gbtn_Cancel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        gbtn_Cancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        gbtn_Cancel.ForeColor = System.Drawing.Color.White
        gbtn_Cancel.Location = New System.Drawing.Point(992, 44)
        gbtn_Cancel.Name = "gbtn_Cancel"
        gbtn_Cancel.Size = New System.Drawing.Size(180, 45)
        gbtn_Cancel.TabIndex = 3
        gbtn_Cancel.Text = "CANCEL"
        AddHandler gbtn_Cancel.Click, AddressOf Me.gbtn_Cancel_Click
        '
        'gbtn_OK
        '
        Me.gbtn_OK.BackColor = System.Drawing.Color.Transparent
        Me.gbtn_OK.BorderRadius = 5
        Me.gbtn_OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbtn_OK.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_OK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gbtn_OK.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_OK.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtn_OK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gbtn_OK.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbtn_OK.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbtn_OK.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtn_OK.ForeColor = System.Drawing.Color.White
        Me.gbtn_OK.Location = New System.Drawing.Point(373, 44)
        Me.gbtn_OK.Name = "gbtn_OK"
        Me.gbtn_OK.Size = New System.Drawing.Size(180, 45)
        Me.gbtn_OK.TabIndex = 2
        Me.gbtn_OK.Text = "OK"
        '
        'pn_Botttom
        '
        Me.pn_Botttom.BackColor = System.Drawing.Color.Transparent
        Me.pn_Botttom.BackgroundImage = Global.Training01.My.Resources.Resources.pngtree_simple_blue_tech_lines_background_image_206074
        Me.pn_Botttom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pn_Botttom.Controls.Add(Me.gbtn_OK)
        Me.pn_Botttom.Controls.Add(gbtn_Cancel)
        Me.pn_Botttom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pn_Botttom.Location = New System.Drawing.Point(0, 742)
        Me.pn_Botttom.Name = "pn_Botttom"
        Me.pn_Botttom.Size = New System.Drawing.Size(1464, 133)
        Me.pn_Botttom.TabIndex = 4
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 47)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(1603, 781)
        Me.AxAcroPDF1.TabIndex = 1
        '
        'PDFViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.tech_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1464, 875)
        Me.Controls.Add(Me.pn_Botttom)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PDFViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDFViewer"
        Me.pn_Botttom.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbtn_OK As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pn_Botttom As Panel
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
End Class
