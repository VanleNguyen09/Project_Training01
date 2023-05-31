Public Class CurrencyFormat
    Public Shared Function ConvertCurrencyVND(ByVal value As Decimal) As String
        Dim currencyNames() As String = {"đồng", "nghìn", "tr", "tỷ"}
        Dim currencyValues() As Decimal = {1, 1000, 1000000, 1000000000}
        Dim result As String = ""

        For i As Integer = currencyValues.Length - 1 To 0 Step -1
            If value >= currencyValues(i) Then
                Dim count As Integer = CInt(Math.Floor(value / currencyValues(i)))
                value -= count * currencyValues(i)

                result &= count.ToString() & " " & currencyNames(i) & " "
            End If
        Next

        Return result.TrimEnd()
    End Function
End Class
