Imports System.Windows.Forms

Public Class Sortation
    ''' <summary>
    ''' Sort datatable and prevent stt column sorted
    ''' </summary>
    ''' <param name="dgv"></param>
    ''' <param name="datas"></param>
    ''' <param name="sortedColumnIndex"></param>
    ''' <param name="sttColumnName">Name of stt column which you want to prevent sorting</param>
    ''' <param name="replaceColumnNameList">Key: name is changed in dgv; Value: match name column in datas</param>
    Public Shared Sub SortDataTableAndPreventSttColumn(ByRef dgv As DataGridView,
                                                       ByRef datas As DataTable,
                                                       ByVal sortedColumnIndex As Integer,
                                                       ByVal sttColumnName As String,
                                                       Optional ByVal replaceColumnNameList As Dictionary(Of String, String) = Nothing)
        Dim columnNameInDGV As String = dgv.Columns(sortedColumnIndex).Name
        Dim columnNameInDataTable As String = columnNameInDGV

        If replaceColumnNameList IsNot Nothing Then
            For Each kvp As KeyValuePair(Of String, String) In replaceColumnNameList
                If (kvp.Key = columnNameInDGV) Then
                    columnNameInDataTable = kvp.Value
                End If
            Next
        End If

        Dim sortDirection As String = "ASC"

        If dgv.Columns(columnNameInDGV).HeaderCell.SortGlyphDirection = SortOrder.Descending Then
            sortDirection = "DESC"
        End If

        datas.DefaultView.Sort = columnNameInDataTable + " " + sortDirection
        datas = datas.DefaultView.ToTable

        datas.Columns(sttColumnName).ReadOnly = False
        For i As Integer = 0 To datas.Rows.Count - 1
            datas.Rows(i)(sttColumnName) = i + 1
        Next
        datas.Columns(sttColumnName).ReadOnly = True
    End Sub
End Class
