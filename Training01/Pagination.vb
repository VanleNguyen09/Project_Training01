Imports Org.BouncyCastle.Math.EC

Public Class Pagination
    Public Shared Sub PaginateDataGridView(dataGridView As DataGridView, currentPage As Integer)
        Dim pageSize As Integer = 10 ' Số dòng hiển thị trên mỗi trang
        Dim totalRows As Integer = dataGridView.Rows.Count

        ' Tính toán chỉ mục bắt đầu và kết thúc của dữ liệu trên trang hiện tại
        Dim startIndex As Integer = (currentPage - 1) * pageSize
        Dim endIndex As Integer = Math.Min(startIndex + pageSize - 1, totalRows - 1)

        ' Hiển thị dữ liệu từ startRow đến endRow trên DataGridView
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

        ' Gọi phương thức cập nhật giá trị lblPage từ form hiện tại
        UpdateLblPage(currentPage, totalPages)
    End Sub

    Private Shared Sub UpdateLblPage(currentPage As Integer, totalPages As Integer)
        If GlobalVariables.lblPage IsNot Nothing Then
            GlobalVariables.lblPage.Text = "Page " & currentPage & " of " & totalPages
        End If
    End Sub
End Class
