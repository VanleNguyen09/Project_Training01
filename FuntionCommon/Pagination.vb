Imports System.Windows.Forms

Public Class Pagination
    Public Enum ButtonType
        Previous
        [Next]
    End Enum

    ''' <summary>
    ''' Paging Datatable
    ''' </summary>
    ''' <param name="currentPage"></param>
    ''' <param name="recordsPerPage"></param>
    ''' <param name="totalRecords"></param>
    ''' <param name="data"></param>
    ''' <returns></returns>
    Public Shared Function PaginateDataTable(currentPage As Integer, recordsPerPage As Integer, totalRecords As Integer, data As DataTable) As DataTable
        Dim totalPages As Integer = Math.Ceiling(totalRecords / recordsPerPage)
        Dim startIndex As Integer = (currentPage - 1) * recordsPerPage
        Dim endIndex As Integer = startIndex + recordsPerPage - 1
        Dim pageData As DataTable = data.Clone()

        For i As Integer = startIndex To endIndex
            If i >= data.Rows.Count Then
                Exit For
            End If

            pageData.ImportRow(data.Rows(i))
        Next

        Return pageData
    End Function

    Public Shared Sub ClickPreviousButton(ByRef addButton As Button, ByRef currentPage As Integer, loadDGV As Action)
        currentPage -= 1
        loadDGV()
    End Sub
End Class
