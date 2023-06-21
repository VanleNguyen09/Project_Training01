Public Class Pagination

    Public Shared Sub PaginateDataGridView(dataGridView As DataGridView, currentPage As Integer)
        Dim pageSize As Integer = 10
        Dim totalRows As Integer = dataGridView.Rows.Count

        ' Calculate start and end index of data on current page
        Dim startIndex As Integer = (currentPage - 1) * pageSize
        Dim endIndex As Integer = Math.Min(startIndex + pageSize - 1, totalRows - 1)

        ' Display data from startRow to endRow on DataGridView
        For i As Integer = 0 To totalRows - 1
            If i >= startIndex AndAlso i <= endIndex Then
                dataGridView.Rows(i).Visible = True
            Else
                dataGridView.Rows(i).Visible = False
            End If
        Next

        Dim totalPages As Integer

        If totalRows = 0 Then
            totalPages = 1
        Else
            totalPages = Math.Ceiling(totalRows / pageSize)
        End If

        UpdateLblPage(currentPage, totalPages)
    End Sub

    Public Shared Sub Paginatedatagridview2(currentpage As Integer, totalrows As Integer)
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

    Public Shared Sub Paginatedatagridview1(datagridview As DataGridView, currentpage As Integer, totalrows As Integer)
        ' calculate start and end index of data on current page
        Dim startindex As Integer = (currentpage - 1) * pageSize
        Dim endindex As Integer = Math.Min(startindex + pageSize - 1, totalrows - 1)

        ' display data from startrow to endrow on datagridview
        For i As Integer = 0 To datagridview.Rows.Count - 1
            If i >= startindex AndAlso i <= endindex Then
                datagridview.Rows(i).Visible = True
            Else
                datagridview.Rows(i).Visible = False
            End If
        Next

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
