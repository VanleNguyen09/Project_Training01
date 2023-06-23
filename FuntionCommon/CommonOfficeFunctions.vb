Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Windows.Forms
Imports System.IO
Imports System.Threading
Imports System.Globalization

Public Class CommonOfficeFunctions
    Public Shared Function ImportFromExcel(loadingBar As Action) As DataTable
        Dim dt As New DataTable()

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm"
        openFileDialog1.Title = "Select an Excel File"
        openFileDialog1.Multiselect = False

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim thread As New Thread(Sub() loadingBar.Invoke())
            thread.SetApartmentState(ApartmentState.STA)
            thread.Start()

            Dim excelApp As New Excel.Application()
            Dim workbook As Excel.Workbook = excelApp.Workbooks.Open(openFileDialog1.FileName)
            Dim worksheet As Excel.Worksheet = workbook.Worksheets(1)

            Try
                Dim rowCount As Integer = worksheet.UsedRange.Rows.Count
                Dim colCount As Integer = worksheet.UsedRange.Columns.Count

                ' Header column name
                For col As Integer = 1 To colCount
                    Dim headerValue As String = worksheet.Cells(1, col).Value2
                    If Not String.IsNullOrEmpty(headerValue) Then
                        dt.Columns.Add(headerValue.Trim())
                    End If
                Next

                ' Row's Datas
                For row As Integer = 2 To rowCount
                    Dim dataRow As DataRow = dt.NewRow()
                    Dim columnIndex As Integer = 0

                    Dim headerValue As String
                    Dim cellValue As Object
                    Dim dateValue As DateTime

                    For col As Integer = 1 To colCount
                        headerValue = worksheet.Cells(1, col).Value2
                        If Not String.IsNullOrEmpty(headerValue) Then
                            cellValue = worksheet.Cells(row, col).Value2
                            If TypeOf cellValue Is Double AndAlso headerValue = "BIRTHDAY" AndAlso
                                DateTime.FromOADate(cellValue).ToString("dd/MM/yyyy") <> "01/01/1900" Then
                                dateValue = DateTime.FromOADate(cellValue).Date
                                dataRow(columnIndex) = dateValue.ToString("dd/MM/yyyy")
                            Else
                                dataRow(columnIndex) = cellValue
                            End If
                            columnIndex += 1
                        End If
                    Next
                    dt.Rows.Add(dataRow)
                Next

                thread.Abort()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                workbook.Close(False)
                excelApp.Quit()

                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
            End Try
        End If
        Return dt
    End Function

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
