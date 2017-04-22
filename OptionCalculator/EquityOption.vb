Public Class EquityOption
    Dim otype As String
    Dim numc As Integer
    Dim entry, exp As Date
    Dim stock, strike, oprice, ivol, intrate, div As Single
    Dim include As Boolean
    Public Sub New(ByVal optiontype As String, ByVal numcontracts As Integer, ByVal entrydate As Date, ByVal stockprice As Single, ByVal strikeprice As Single, ByVal expiration As Date, ByVal price As Single, ByVal iv As Single, ByVal included As Boolean, ByVal interestrate As Single, ByVal dividends As Single)
        otype = optiontype
        numc = numcontracts
        entry = entrydate.Date
        stock = stockprice
        strike = strikeprice
        exp = expiration.Date
        oprice = Math.Round(price, 2)
        ivol = Math.Round(iv / 100, 2)
        include = included
        intrate = interestrate
        div = dividends
    End Sub

    Function price() As Single
        oprice = optionvalue(stock, strike, timeleft(entry, exp), intrate, ivol, div, otype)
        If oprice < 0.01 Then
            Return 0.01
        Else
            Return Math.Round(oprice, 2)
        End If
    End Function

    Function volatility() As Single
        ivol = findIV(stock, strike, timeleft(entry, exp), intrate, div, oprice, otype)
        If ivol < 0.01 Then
            Return 0.01
        Else
            Return Math.Round(ivol, 2)
        End If
    End Function

    Function totalvalue(ByVal displayprice As Decimal) As String
        If include = True Then
            Return FormatCurrency(valuesign() * displayprice * 100 * numc)
        Else
            Return FormatCurrency(0)
        End If
    End Function

    Function colorize() As Color
        If include = True Then
            If otype.Contains("Long") Then
                Return Color.Pink
            Else
                Return Color.LightGreen
            End If
        Else
            Return Color.Gray
        End If
    End Function

    Function expirationafterentry() As Boolean
        'need to check all legs included or not, otherwise could get errors when figuring price
        If DateDiff(DateInterval.Day, entry, exp) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function valuesign() As Integer
        If otype.Contains("Long") Then
            Return 1
        Else
            Return -1
        End If
    End Function
End Class
