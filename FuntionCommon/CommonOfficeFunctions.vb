Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Windows.Forms
Imports System.IO

Public Class CommonOfficeFunctions
    Public Shared Sub ExportToExcel(ByVal data As DataTable, Optional ByVal callback As Action(Of String) = Nothing)
        ' Create Excel Object
        Dim excelApp As New Excel.Application()

        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()

        Dim worksheet As Excel.Worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

        ' Add header from DataTable to Excel.
        For i As Integer = 0 To data.Columns.Count - 1
            worksheet.Cells(1, i + 1) = data.Columns(i).ColumnName.ToUpper()
            worksheet.Cells(1, i + 1).Font.Bold = True
        Next

        ' Add data from DataTable to Excel.
        For i As Integer = 0 To data.Rows.Count - 1
            worksheet.Rows(i + 2).RowHeight = worksheet.Rows(i + 2).RowHeight + 10
            For j As Integer = 0 To data.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1).Value = data.Rows(i)(j)
                worksheet.Columns(j + 1).AutoFit()
                worksheet.Columns(j + 1).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                worksheet.Columns(j + 1).HorizontalAlignment = Excel.Constants.xlLeft
            Next
        Next

        ' Show Dialog choose saving location
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveDialog.FileName

            If File.Exists(filePath) Then
                Dim result As DialogResult = MessageBox.Show("This file is existed. Do you want to override this file?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' Override file Excel by ConflictResolution:=Excel.XlSaveConflictResolution.xlLocalSessionChanges
                If result = DialogResult.Yes Then
                    workbook.SaveAs(filePath, AccessMode:=Excel.XlSaveAsAccessMode.xlExclusive, ConflictResolution:=Excel.XlSaveConflictResolution.xlLocalSessionChanges)
                End If

                If result = DialogResult.No Then
                    workbook.Close()
                    excelApp.Quit()
                End If
            Else
                workbook.SaveAs(filePath)
            End If

            workbook.Close()
            excelApp.Quit()

            If callback IsNot Nothing Then
                Dim savedFilePath As String = saveDialog.FileName
                callback.Invoke(savedFilePath)
            End If
        End If
    End Sub
End Class
