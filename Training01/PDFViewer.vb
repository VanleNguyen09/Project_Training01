Imports System.IO

Public Class PDFViewer
    Private Property tempPath As String
    Private Property pdfPath As String
    Dim buttonOK As MessageBoxButtons = GlobalVariables.buttonOK
    Dim buttonYesNo As MessageBoxButtons = GlobalVariables.buttonYesNo
    Dim warmIcon As MessageBoxIcon = GlobalVariables.warmIcon
    Dim questionIcon As MessageBoxIcon = GlobalVariables.questionIcon
    Dim infoIcon As MessageBoxIcon = GlobalVariables.infoIcon
    Dim errorIcon As MessageBoxIcon = GlobalVariables.errorIcon

    Dim titleSucces As String = GlobalVariables.titleSucces
    Dim titleNotif As String = GlobalVariables.titleNotif
    Dim titleError As String = GlobalVariables.titleError
    Dim titleConfỉrm As String = GlobalVariables.titleConfirm
    Dim titleInfo As String = GlobalVariables.titleInfo
    Public Sub SetData(ByVal tempPath As String, ByVal pdfPath As String)
        Me.tempPath = tempPath
        Me.pdfPath = pdfPath
    End Sub

    Private Sub CenterForm()
        Me.StartPosition = FormStartPosition.Manual
        Dim screenRectangle As Rectangle = Screen.PrimaryScreen.WorkingArea
        Dim left As Integer = (screenRectangle.Width - Me.Width) \ 2
        Dim top As Integer = (screenRectangle.Height - Me.Height) \ 2
        Me.Location = New Point(left, top)
    End Sub

    Private Sub PDFViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxAcroPDF1.LoadFile(Me.tempPath)
        AxAcroPDF1.Size = Me.ClientSize
        AxAcroPDF1.Location = New Point(0, 0)
        CenterForm()
        CustomElements.MovingForm(Me)
    End Sub

    Private Sub SavePdf(ByVal tempPath As String, ByVal pdfPath As String)
        File.Move(tempPath, pdfPath)
    End Sub

    Private Sub DeleteTemp(ByVal tempPath As String)
        File.Delete(tempPath)
    End Sub

    Private Sub gbtn_OK_Click(sender As Object, e As EventArgs) Handles gbtn_OK.Click
        SavePdf(Me.tempPath, Me.pdfPath)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to save PDF file??", "Confirmation", buttonYesNo, questionIcon)
        If result = DialogResult.Yes Then
            MessageBox.Show(Message.Message.exportPDFSuccess, titleInfo, buttonOK, infoIcon)
            Me.Close()
        Else
            MessageBox.Show(Message.Message.exportPDFCancel, titleInfo, buttonOK, infoIcon)
        End If
    End Sub

    Private Sub gbtn_Cancel_Click(sender As Object, e As EventArgs)
        DeleteTemp(Me.tempPath)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Cancel save PDF file??", "Confirmation", buttonYesNo, questionIcon)
        If result = DialogResult.Yes Then
            MessageBox.Show(Message.Message.cancelSavePDFSuccess, titleInfo, buttonOK, infoIcon)
            Me.Close()
        End If
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Me.Close()
    End Sub
End Class