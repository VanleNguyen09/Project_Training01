<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
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
        Me.Viewer1 = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
        Me.Viewer2 = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
        Me.closeApp = New System.Windows.Forms.PictureBox()
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Viewer1
        '
        Me.Viewer1.CurrentPage = 0
        Me.Viewer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Viewer1.Location = New System.Drawing.Point(101, 72)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.PagesBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Viewer1.PreviewPages = 0
        '
        '
        '
        '
        '
        '
        Me.Viewer1.Sidebar.ParametersPanel.ContextMenu = Nothing
        Me.Viewer1.Sidebar.ParametersPanel.Text = "Parameters"
        Me.Viewer1.Sidebar.ParametersPanel.Width = 200
        '
        '
        '
        Me.Viewer1.Sidebar.SearchPanel.ContextMenu = Nothing
        Me.Viewer1.Sidebar.SearchPanel.Text = "Search results"
        Me.Viewer1.Sidebar.SearchPanel.Width = 200
        '
        '
        '
        Me.Viewer1.Sidebar.ThumbnailsPanel.ContextMenu = Nothing
        Me.Viewer1.Sidebar.ThumbnailsPanel.Text = "Page thumbnails"
        Me.Viewer1.Sidebar.ThumbnailsPanel.Width = 200
        Me.Viewer1.Sidebar.ThumbnailsPanel.Zoom = 0.1R
        '
        '
        '
        Me.Viewer1.Sidebar.TocPanel.ContextMenu = Nothing
        Me.Viewer1.Sidebar.TocPanel.Expanded = True
        Me.Viewer1.Sidebar.TocPanel.Text = "Document map"
        Me.Viewer1.Sidebar.TocPanel.Width = 200
        Me.Viewer1.Sidebar.Width = 200
        Me.Viewer1.Size = New System.Drawing.Size(824, 441)
        Me.Viewer1.TabIndex = 70
        '
        'Viewer2
        '
        Me.Viewer2.CurrentPage = 0
        Me.Viewer2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Viewer2.Location = New System.Drawing.Point(0, 37)
        Me.Viewer2.Name = "Viewer2"
        Me.Viewer2.PagesBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Viewer2.PreviewPages = 0
        '
        '
        '
        '
        '
        '
        Me.Viewer2.Sidebar.ParametersPanel.ContextMenu = Nothing
        Me.Viewer2.Sidebar.ParametersPanel.Text = "Parameters"
        Me.Viewer2.Sidebar.ParametersPanel.Width = 200
        '
        '
        '
        Me.Viewer2.Sidebar.SearchPanel.ContextMenu = Nothing
        Me.Viewer2.Sidebar.SearchPanel.Text = "Search results"
        Me.Viewer2.Sidebar.SearchPanel.Width = 200
        '
        '
        '
        Me.Viewer2.Sidebar.ThumbnailsPanel.ContextMenu = Nothing
        Me.Viewer2.Sidebar.ThumbnailsPanel.Text = "Page thumbnails"
        Me.Viewer2.Sidebar.ThumbnailsPanel.Width = 200
        Me.Viewer2.Sidebar.ThumbnailsPanel.Zoom = 0.1R
        '
        '
        '
        Me.Viewer2.Sidebar.TocPanel.ContextMenu = Nothing
        Me.Viewer2.Sidebar.TocPanel.Expanded = True
        Me.Viewer2.Sidebar.TocPanel.Text = "Document map"
        Me.Viewer2.Sidebar.TocPanel.Width = 200
        Me.Viewer2.Sidebar.Width = 200
        Me.Viewer2.Size = New System.Drawing.Size(1242, 711)
        Me.Viewer2.TabIndex = 70
        '
        'closeApp
        '
        Me.closeApp.BackColor = System.Drawing.Color.Transparent
        Me.closeApp.BackgroundImage = Global.Training01.My.Resources.Resources.x_icon
        Me.closeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeApp.Location = New System.Drawing.Point(1215, 5)
        Me.closeApp.Margin = New System.Windows.Forms.Padding(4)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(27, 25)
        Me.closeApp.TabIndex = 71
        Me.closeApp.TabStop = False
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Training01.My.Resources.Resources.tech_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1242, 748)
        Me.Controls.Add(Me.closeApp)
        Me.Controls.Add(Me.Viewer2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Report"
        Me.Text = "Report"
        CType(Me.closeApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DataGridViewStyler1 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents Viewer1 As GrapeCity.ActiveReports.Viewer.Win.Viewer
    Friend WithEvents Viewer2 As GrapeCity.ActiveReports.Viewer.Win.Viewer
    Friend WithEvents closeApp As PictureBox
End Class
