Imports System.ComponentModel
Imports System.Windows.Forms

Public Class SortationNO
    Public Shared Sub SortAndPreventNoColumnSorting(ByRef dgv As DataGridView, ByVal noColumnName As String)

        Dim originalNoValues As Integer() = New Integer(dgv.Rows.Count - 1) {}

        For i As Integer = 0 To dgv.Rows.Count - 1
            originalNoValues(i) = i + 1
        Next

        'Restore the value of column "No" after sorting
        For i As Integer = 0 To dgv.Rows.Count - 1
            dgv.Rows(i).Cells(noColumnName).Value = originalNoValues(i)
        Next
    End Sub
End Class
