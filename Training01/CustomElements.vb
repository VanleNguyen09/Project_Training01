Imports Org.BouncyCastle.Asn1.X509

Public Class CustomElements

    ''' <summary>
    ''' Add Sorted DGV Events and Prevent sort no column
    ''' Conditions: Datagridview.datasource = datatable
    ''' Author: DatRikai
    ''' Created Date: 15/06/2023
    ''' </summary>
    ''' <param name="dgv"></param>
    ''' <param name="Datas"></param>
    ''' <param name="noColumnName"></param>
    ''' <param name="replaceColumnNameList"></param>
    Public Shared Sub AddSortedDGVEvents(dgv As DataGridView, Datas As DataTable, ByVal noColumnName As String, Optional ByVal replaceColumnNameList As Dictionary(Of String, String) = Nothing)
        AddHandler dgv.ColumnHeaderMouseClick, Sub(sender As Object, e As DataGridViewCellMouseEventArgs)
                                                   Dim sortedColumnIndex = e.ColumnIndex
                                                   Dim dgvColumn = dgv.Columns(sortedColumnIndex)

                                                   If e.ColumnIndex <> 0 AndAlso e.Button = MouseButtons.Left AndAlso dgvColumn.SortMode <> DataGridViewColumnSortMode.NotSortable Then
                                                       'Datas will change when sorted
                                                       FuntionCommon.Sortation.SortDGVAndPreventNoColumn(dgv, Datas, sortedColumnIndex, noColumnName, replaceColumnNameList)
                                                   End If
                                               End Sub
    End Sub
    ''' <summary>
    ''' Rounded Button
    ''' Author: Dat
    ''' </summary>
    ''' <param name="btn"></param>
    Public Shared Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.White
        'btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        'btn.Font = New Font("Century Gothic", 14, FontStyle.Bold)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btn.Region = New Region(Raduis)
    End Sub

    ''' <summary>
    ''' Keep Column Unsorted Data
    ''' Author: Dat
    ''' </summary>
    ''' <param name="dgv"></param>
    ''' <param name="nameColumn"></param>
    ''' <param name="getCurrentPage"></param>
    ''' <param name="getRowsNumberInAPage"></param>
    Public Shared Sub KeepColumnUnsorted(ByRef dgv As DataGridView,
                                         ByVal nameColumn As String,
                                         ByVal getCurrentPage As Func(Of Integer),
                                         ByVal getRowsNumberInAPage As Func(Of Integer))
        Dim tempDgv As DataGridView = dgv
        AddHandler dgv.Sorted, Sub()
                                   Dim currentPage As Integer = getCurrentPage()
                                   Dim recordsPerPage As Integer = getRowsNumberInAPage()

                                   Dim startIndex As Integer = (currentPage - 1) * recordsPerPage
                                   Dim endIndex As Integer = startIndex + recordsPerPage - 1

                                   If tempDgv.SortedColumn.Name <> nameColumn Then
                                       For i As Integer = startIndex To endIndex
                                           tempDgv.Rows(i).Cells(nameColumn).Value = (i + 1).ToString()
                                       Next
                                   End If
                               End Sub
    End Sub

    Public Shared Sub KeepNoColumnUnsorted(ByRef dgv As DataGridView, ByVal nameColumn As String)
        Dim tempDgv As DataGridView = dgv
        AddHandler dgv.Sorted, Sub()
                                   'If it is stt column, sorted normal 
                                   If tempDgv.SortedColumn.Name <> nameColumn Then
                                       For i As Integer = 0 To tempDgv.Rows.Count - 1
                                           tempDgv.Rows(i).Cells(nameColumn).Value = (i + 1).ToString()
                                       Next
                                   End If
                               End Sub
    End Sub

    ''' <summary>
    ''' Show Circular ProgressBar
    ''' </summary>
    ''' <param name="time">seconds</param>
    ''' <param name="callback">Function call when Progress is over</param>
    Public Shared Sub ShowCirProgressBar(ByVal time As Integer, ByVal size As Size, Optional ByVal callback As Action = Nothing)
        Dim progressBar As New CircularProgressBar.CircularProgressBar()

        'Settings
        progressBar.Size = size
        progressBar.Location = New Point((Form.ActiveForm.ClientSize.Width - progressBar.Width) / 2, (Form.ActiveForm.ClientSize.Height - progressBar.Height) / 2)
        progressBar.ProgressWidth = 20
        progressBar.Text = "Processing..."
        progressBar.OuterColor = Color.White
        progressBar.OuterMargin = -25
        progressBar.OuterWidth = 25
        progressBar.StartAngle = 270
        progressBar.InnerColor = Color.Transparent
        progressBar.Style = ProgressBarStyle.Marquee
        progressBar.Font = New Font(progressBar.Font.OriginalFontName, 9)
        progressBar.ForeColor = Color.White
        progressBar.SubscriptText = ""
        progressBar.SuperscriptText = ""
        progressBar.MarqueeAnimationSpeed = 1000

        Form.ActiveForm.Controls.Add(progressBar)
        progressBar.BringToFront()
        progressBar.BackColor = Color.DarkBlue

        ' Set Value and Maximum của CircularProgressBar
        progressBar.Value = 0
        progressBar.Maximum = time

        ' Create Timer to update values of CircularProgressBar
        Dim timer As New Timer()
        AddHandler timer.Tick, Sub(sender, e)
                                   progressBar.Value += 1
                                   If progressBar.Value = progressBar.Maximum Then
                                       timer.Stop()
                                       progressBar.Visible = False
                                       If callback IsNot Nothing Then
                                           callback()
                                       End If
                                   End If
                               End Sub
        timer.Interval = 1000
        timer.Start()
    End Sub

    ''' <summary>
    ''' Moving Form when moving mouse
    ''' </summary>
    ''' <param name="mainForm">Form which you want to move</param>
    Public Shared Sub MovingForm(ByRef mainForm As Form)
        Dim mousePosX As Integer
        Dim mousePosY As Integer
        Dim formTemp As Form = mainForm

        AddHandler mainForm.MouseDown, Sub(sender As Object, e As MouseEventArgs)
                                           If e.Button = MouseButtons.Left Then
                                               mousePosX = e.X
                                               mousePosY = e.Y
                                           End If
                                       End Sub

        AddHandler mainForm.MouseMove, Sub(sender As Object, e As MouseEventArgs)
                                           If e.Button = MouseButtons.Left Then
                                               formTemp.Left += e.X - mousePosX
                                               formTemp.Top += e.Y - mousePosY
                                           End If
                                       End Sub
    End Sub

    ''' <summary>
    ''' Moving Dashboard by Panels
    ''' </summary>
    ''' <param name="dashboard">The Dashboard form</param>
    ''' <param name="header">The Header panel</param>
    ''' <param name="sideBar">The Sidebar panel</param>
    Public Shared Sub MovingDashboardByPanels(ByRef dashboard As Form,
                                              Optional ByRef header As Panel = Nothing,
                                              Optional ByRef sideBar As Panel = Nothing)
        Dim mousePosX As Integer
        Dim mousePosY As Integer
        Dim formTemp As Form = dashboard
        Dim mouseDownEvent = Sub(sender As Object, e As MouseEventArgs)
                                 If e.Button = MouseButtons.Left Then
                                     mousePosX = e.X
                                     mousePosY = e.Y
                                 End If
                             End Sub
        Dim mouseMoveEvent = Sub(sender As Object, e As MouseEventArgs)
                                 If e.Button = MouseButtons.Left Then
                                     formTemp.Left += e.X - mousePosX
                                     formTemp.Top += e.Y - mousePosY
                                 End If
                             End Sub

        AddHandler dashboard.MouseDown, mouseDownEvent
        AddHandler dashboard.MouseMove, mouseMoveEvent

        If Not header Is Nothing Then
            AddHandler header.MouseDown, mouseDownEvent
            AddHandler header.MouseMove, mouseMoveEvent
        End If

        If Not sideBar Is Nothing Then
            AddHandler sideBar.MouseDown, mouseDownEvent
            AddHandler sideBar.MouseMove, mouseMoveEvent
        End If
    End Sub

    ''' <summary>
    ''' Create a clear button inside textbox
    ''' Author: Dat
    ''' </summary>
    ''' <param name="textbox"></param>
    ''' <param name="name"></param>
    ''' <param name="buttonClickHandler"></param>
    Public Shared Sub AddClearButtonInsideTextBox(textbox As Object, name As String, ByVal buttonClickHandler As EventHandler)
        Dim btn As New PictureBox
        btn.Name = name
        btn.BackgroundImage = My.Resources.x_icon
        btn.BackgroundImageLayout = ImageLayout.Stretch
        btn.BackColor = Color.White
        btn.Cursor = Cursors.Default
        btn.Size = New Size(18, textbox.ClientSize.Height)
        btn.Location = New Point(textbox.ClientSize.Width - btn.Width - 1, -1)
        btn.Visible = False

        AddHandler btn.Click, buttonClickHandler
        textbox.Controls.Add(btn)

        ' Send EM_SETMARGINS to prevent text from disappearing underneath the button
        SendMessage(textbox.Handle, &HD3, CType(2, IntPtr), CType((btn.Width << 16), IntPtr))
    End Sub

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr
    End Function
End Class