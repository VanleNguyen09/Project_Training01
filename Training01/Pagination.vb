Public Class Pagination
    Public Shared Sub Paginatedatagridview(currentpage As Integer, totalrows As Integer)
        ' calculate start and end index of data on current page
        Dim startindex As Integer = (currentpage - 1) * pageSize
        Dim endindex As Integer = Math.Min(startindex + pageSize - 1, totalrows - 1)

        Dim totalpages As Integer

        If totalrows = 0 Then
            totalpages = 1
        Else
            totalpages = Math.Ceiling(totalrows / pageSize)
        End If

        UpdateLblPage(currentpage, totalpages)
    End Sub
    Private Shared Sub UpdateLblPage(currentPage As Integer, totalPages As Integer)
        If GlobalVariables.lblPage IsNot Nothing Then
            GlobalVariables.lblPage.Text = "Page " & currentPage & " of " & totalPages
        End If
    End Sub
End Class
