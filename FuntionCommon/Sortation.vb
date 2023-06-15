Imports System.Windows.Forms

Public Class Sortation
    ''' <summary>
    ''' Sort datagridview and prevent no column sorted
    ''' Condition datagridview.datasource = datatable
    ''' Sortcolumn set Programmic
    ''' </summary>
    ''' <param name="dgv"></param>
    ''' <param name="datas"></param>
    ''' <param name="sortedColumnIndex"></param>
    ''' <param name="noColumnName">Name of stt column which you want to prevent sorting</param>
    ''' <param name="replaceColumnNameList">Key: name is changed in dgv; Value: match name column in datas</param>
    Public Shared Sub SortDGVAndPreventNoColumn(ByRef dgv As DataGridView,
                                                       ByRef datas As DataTable,
                                                       ByVal sortedColumnIndex As Integer,
                                                       ByVal noColumnName As String,
                                                       Optional ByVal replaceColumnNameList As Dictionary(Of String, String) = Nothing,
                                                       Optional CallBack As Action = Nothing)
        Dim columnNameInDGV As String = dgv.Columns(sortedColumnIndex).Name
        Dim columnNameInDataTable As String = columnNameInDGV

        If replaceColumnNameList IsNot Nothing Then
            For Each kvp As KeyValuePair(Of String, String) In replaceColumnNameList
                If (kvp.Key = columnNameInDGV) Then
                    columnNameInDataTable = kvp.Value
                End If
            Next
        End If

        'Check in header of datagridview
        Dim sortingDirection = dgv.Columns(sortedColumnIndex).HeaderCell.SortGlyphDirection
        Dim sortedDirectionString As String = "ASC"

        If sortingDirection = SortOrder.None OrElse sortingDirection = SortOrder.Descending Then
            sortingDirection = SortOrder.Ascending
        ElseIf sortingDirection = SortOrder.Ascending Then
            sortingDirection = SortOrder.Descending
            sortedDirectionString = "DESC"
        End If

        datas.DefaultView.Sort = columnNameInDataTable + " " + sortedDirectionString
        datas = datas.DefaultView.ToTable

        'No column is unsorted
        datas.Columns(noColumnName).ReadOnly = False
        For i As Integer = 0 To datas.Rows.Count - 1
            datas.Rows(i)(noColumnName) = i + 1
        Next
        datas.Columns(noColumnName).ReadOnly = True

        If CallBack IsNot Nothing Then
            CallBack()
        Else
            dgv.DataSource = datas
        End If

        'Update icon on header of datagridview
        dgv.Columns(sortedColumnIndex).HeaderCell.SortGlyphDirection = sortingDirection
    End Sub

    ''' <summary>
    ''' Sort datatable and prevent stt column sorted
    ''' Condition: datagridview.datasource = nothing
    ''' </summary>
    ''' <param name="dgv"></param>
    ''' <param name="datas"></param>
    ''' <param name="sortedColumnIndex"></param>
    ''' <param name="noColumnName">Name of stt column which you want to prevent sorting</param>
    ''' <param name="replaceColumnNameList">Key: name is changed in dgv; Value: match name column in datas</param>
    Public Shared Sub SortDataTableAndPreventNoColumn(ByRef dgv As DataGridView,
                                                       ByRef datas As DataTable,
                                                       ByVal sortedColumnIndex As Integer,
                                                       ByVal noColumnName As String,
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

        datas.Columns(noColumnName).ReadOnly = False
        For i As Integer = 0 To datas.Rows.Count - 1
            datas.Rows(i)(noColumnName) = i + 1
        Next
        datas.Columns(noColumnName).ReadOnly = True
    End Sub
End Class
