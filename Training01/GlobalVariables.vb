Public Module GlobalVariables
    Public LoggedInUserEmail As String = ""
    Public loggedInUserFullName As String = ""
    Public IsLoggedIn As Boolean = False
    Public lblPage As Label
    Public pageSize As Integer = 10
    Public currentPage As Integer = 1
    Public totalPages As Integer = 0
    Public totalRows As Integer = 0

    'Global Icon
    Public infoIcon As MessageBoxIcon = MessageBoxIcon.Information
    Public questionIcon As MessageBoxIcon = MessageBoxIcon.Question
    Public errorIcon As MessageBoxIcon = MessageBoxIcon.Error
    Public warmIcon As MessageBoxIcon = MessageBoxIcon.Warning

    'Global Button
    Public buttonOK As MessageBoxButtons = MessageBoxButtons.OK
    Public buttonYesNo As MessageBoxButtons = MessageBoxButtons.YesNo

    'Global Title Message
    Public titleSucces As String = "Success"
    Public titleNotif As String = "Notification"
    Public titleError As String = "Error"
    Public titleConfirm As String = "Confirmation"
    Public titleInfo As String = "Infomation"
End Module
