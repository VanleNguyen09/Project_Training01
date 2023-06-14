Imports System.Windows.Forms
Imports Guna.UI2.WinForms

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

    ''' <summary>
    ''' Press Enter Key in Current Page Textbox
    ''' </summary>
    ''' <param name="txtCurrentPage"></param>
    ''' <param name="currentPage"></param>
    ''' <param name="totalPages"></param>
    ''' <param name="key"></param>
    ''' <param name="loadDGV"></param>
    Public Shared Sub PressEnterKeyTxtCurrentPage(txtCurrentPage As Guna2TextBox, ByRef currentPage As Integer, totalPages As Integer, key As Char, loadDGV As Action)
        If key = Convert.ToChar(Keys.Enter) Then
            If Not FuntionCommon.Validation.IsIntegerNumber(txtCurrentPage.Text) Then
                MessageBox.Show("Error Type Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCurrentPage.Text = currentPage
                Exit Sub
            End If

            Dim CurrPage As Integer = CInt(txtCurrentPage.Text)
            If CurrPage < 1 OrElse CurrPage > totalPages Then
                MessageBox.Show("Error number is bigger than total pages or lower than 1", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCurrentPage.Text = currentPage
                Exit Sub
            End If

            currentPage = CurrPage
            loadDGV()
        End If
    End Sub

    ''' <summary>
    ''' When Click Previous Button
    ''' </summary>
    ''' <param name="addButton"></param>
    ''' <param name="btnType"></param>
    ''' <param name="totalPages"></param>
    ''' <param name="currentPage"></param>
    ''' <param name="loadDGV"></param>
    Public Shared Sub ClickPreviousButton(ByRef addButton As Guna2Button, btnType As ButtonType, totalPages As Integer, ByRef currentPage As Integer, loadDGV As Action)
        currentPage -= 1
        loadDGV()
        UpdatePaginationButtons(addButton, ButtonType.Previous, totalPages, currentPage)
    End Sub

    ''' <summary>
    ''' When Click Next Button
    ''' </summary>
    ''' <param name="addButton"></param>
    ''' <param name="btnType"></param>
    ''' <param name="totalPages"></param>
    ''' <param name="currentPage"></param>
    ''' <param name="loadDGV"></param>
    Public Shared Sub ClickNextButton(ByRef addButton As Guna2Button, btnType As ButtonType, totalPages As Integer, ByRef currentPage As Integer, loadDGV As Action)
        currentPage += 1
        loadDGV()
        UpdatePaginationButtons(addButton, ButtonType.Next, totalPages, currentPage)
    End Sub

    ''' <summary>
    ''' Update status for Pagination buttons
    ''' </summary>
    ''' <param name="button"></param>
    ''' <param name="btnType"></param>
    ''' <param name="totalPages"></param>
    ''' <param name="currentPage"></param>
    Public Shared Sub UpdatePaginationButtons(ByRef button As Guna2Button, btnType As ButtonType, totalPages As Integer, currentPage As Integer)
        Select Case btnType
            Case ButtonType.Previous
                If currentPage = 1 Then
                    button.Enabled = False
                Else
                    button.Enabled = True
                End If
            Case ButtonType.Next
                If currentPage = totalPages Then
                    button.Enabled = False
                Else
                    button.Enabled = True
                End If
        End Select
    End Sub
End Class
