﻿Public Class CustomElements

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
        btn.Size = New Size(18, textbox.ClientSize.Height + 2)
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