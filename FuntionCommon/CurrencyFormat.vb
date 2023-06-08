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

        ' Check Integer Part
        While integerPart > 0
            Dim groupValue As Integer = CInt(integerPart Mod 1000) ' group 3 last numbers
            integerPart \= 1000 ' Rest numbers

            If groupValue > 0 Then
                Dim groupText As String = ""

                'If number is hundred
                If groupValue >= 100 Then
                    groupText &= numbers(groupValue \ 100) & " trăm"
                    groupValue = groupValue Mod 100
                End If

                '2,200,022
                If groupValue >= 10 AndAlso groupValue <= 19 Then
                    groupText &= " mười"
                    groupValue = groupValue Mod 10
                ElseIf groupValue >= 20 Then
                    groupText &= " " & numbers(groupValue \ 10) & " mươi"
                    groupValue = groupValue Mod 10
                End If

                If groupValue > 0 Then
                    groupText &= " " & numbers(groupValue)
                End If

                groupText &= " " & units(groupIndex) 'Add unit
                result = groupText & " " & result.Trim()
            End If

            groupIndex += 1
        End While

        result = result.Trim() & " đồng"

        'Check Decimal Part
        If decimalPart >= 20 Then
            result &= " và " & numbers(decimalPart \ 10) & " mươi "
            result &= If(decimalPart Mod 10 = 0, "", numbers(decimalPart Mod 10)) & " xu"
        ElseIf decimalPart = 10 Then
            result &= " và mười xu"
        ElseIf decimalPart > 10 AndAlso decimalPart < 20 Then
            result &= " và mười " & numbers(decimalPart Mod 10) & " xu"
        ElseIf decimalPart > 0 AndAlso decimalPart < 10 Then
            result &= " và " & numbers(decimalPart Mod 10) & " xu"
        End If

        Return result.Trim()
    End Function

End Class