Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Windows.Forms

Public Class CommonOfficeFunctions
    Public Shared Sub ExportToExcel(ByVal data As DataTable, Optional ByVal callback As Action = Nothing)
        ' Create Excel Object
        Dim excelApp As New Excel.Application()

        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()

        Dim worksheet As Excel.Worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

        ' Add header from DataTable to Excel.
        For i As Integer = 0 To data.Columns.Count - 1
            worksheet.Cells(1, i + 1) = data.Columns(i).ColumnName
            worksheet.Cells(1, i + 1).Font.Bold = True
        Next

        ' Add data from DataTable to Excel.
        For i As Integer = 0 To data.Rows.Count - 1
            worksheet.Rows(i + 2).RowHeight = worksheet.Rows(i + 2).RowHeight + 10
            For j As Integer = 0 To data.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1).Value = data.Rows(i)(j)
                worksheet.Columns(j + 1).AutoFit()
                worksheet.Columns(j + 1).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            Next
        Next

        ' Show Dialog choose saving location
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            workbook.SaveAs(saveDialog.FileName)
            workbook.Close()
            excelApp.Quit()

            If callback IsNot Nothing Then
                callback.Invoke()
            End If
        End If
    End Sub
End Class
