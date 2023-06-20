Imports System.Data.SqlClient
Imports Org.BouncyCastle.Math.EC
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

    Public Shared Sub PaginateDataGridView1(dataGridView As DataGridView, currentPage As Integer, totalRows As Integer)
        Console.WriteLine(totalRows)
        'Console.WriteLine(dataGridView.RowCount)

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


    Private Shared Sub UpdateLblPage(currentPage As Integer, totalPages As Integer)
        If GlobalVariables.lblPage IsNot Nothing Then
            GlobalVariables.lblPage.Text = "Page " & currentPage & " of " & totalPages
        End If
    End Sub
End Class
