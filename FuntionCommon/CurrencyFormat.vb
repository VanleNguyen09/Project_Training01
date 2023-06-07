Public Class CurrencyFormat
    Private Shared currencyNames As New List(Of String)
    Private Shared currencyValues As New List(Of String)

    Public Shared Function ConvertCurrencyVND(ByVal value As Decimal) As String
        currencyNames.Clear()
        currencyNames.AddRange(New List(Of String) From {"vnđ", "nghìn", "triệu", "tỷ"})

        currencyValues.Clear()
        currencyValues.AddRange(New List(Of String) From {1, 1000, 1000000, 1000000000})

        Return SplitTheMoney(value)
    End Function

    Private Shared Function SplitTheMoney(ByVal value As Decimal) As String
        Dim result As String = ""

        For i As Integer = currencyValues.Count - 1 To 0 Step -1
            If value >= currencyValues(i) Then
                Dim count As Integer = CInt(Math.Floor(value / currencyValues(i)))
                value -= count * currencyValues(i)

                result &= count.ToString() & " " & currencyNames(i) & " "
            End If
        Next

        Return result.TrimEnd()
    End Function

    ''' <summary>
    ''' Convert To VND letter form
    ''' </summary>
    ''' <param name="amount"></param>
    ''' <returns></returns>
    Public Shared Function ConvertToVnd(ByVal amount As Double) As String
        Dim numbers As String() = {"không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"}
        Dim units As String() = {"", "nghìn", "triệu", "tỷ"}
        Dim result As String = ""

        If amount = 0 Then
            Return "không đồng"
        End If

        Dim integerPart As Long = CLng(Math.Floor(amount))
        Dim decimalPart As Long = CLng(Math.Round((amount - integerPart) * 100))

        Dim groupIndex As Integer = 0

        'Xử lý phần nguyên 1,234,400
        While integerPart > 0
            Dim groupValue As Integer = CInt(integerPart Mod 1000) ' Tách 3 số cuối để phân tích
            integerPart \= 1000 ' Số còn lại

            'Phân tích 3 số cuối
            If groupValue > 0 Then
                Dim groupText As String = ""

                'Nếu số ở phần trăm
                If groupValue >= 100 Then
                    'Tương ứng với chỉ số nào trong mảng number thì hiện ra
                    groupText &= numbers(groupValue \ 100) & " trăm "
                    groupValue = groupValue Mod 100
                End If

                ' Tương tự với hàng chục
                ' Lớn hơn 10 và nhỏ hơn 20 thì là mười
                ' Lớn hơn bằng 20 thì là thêm số và chữ mươi
                If groupValue >= 10 AndAlso groupValue <= 19 Then
                    groupText &= "mười "
                    groupValue = groupValue Mod 10
                ElseIf groupValue >= 20 Then
                    groupText &= numbers(groupValue \ 10) & " mươi "
                    groupValue = groupValue Mod 10
                End If

                ' Tương tự hàng đơn vị
                If groupValue > 0 Then
                    groupText &= numbers(groupValue)
                End If

                groupText &= " " & units(groupIndex) 'Cộng với đơn vị tương ứng
                result = groupText & " " & result ' Cộng chuỗi lùi
            End If

            'Tăng chỉ số đơn vị
            groupIndex += 1
        End While

        result = result.Trim()

        'Kiểm tra hàng thập phân 2 số
        If decimalPart > 0 Then
            result &= " và " & numbers(decimalPart \ 10) & " mươi " & numbers(decimalPart Mod 10) & " xu"
        Else
            result &= " đồng"
        End If

        result = result.Trim()

        Return result
    End Function

End Class