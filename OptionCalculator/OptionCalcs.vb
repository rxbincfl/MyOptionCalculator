Module OptionCalcs
    Function NORMSDIST(ByVal x As Single) As Single

        'returns the "standard normal CUMULATIVE distribution"

        Dim result As Single
        Dim y As Single = 1 / (1 + (0.2316419 * Math.Abs(x)))
        Dim z As Single = 0.3989423 * (Math.Exp((-x ^ 2) / 2))

        result = 1 - z * ((1.33027 * (y ^ 5)) - (1.821256 * (y ^ 4)) + (1.781478 * (y ^ 3)) - (0.356538 * (y ^ 2)) + (0.3193815 * y))

        If x > 0 Then
            Return result
        Else
            Return 1 - result
        End If
    End Function

    Function timeleft(ByVal dte1 As Date, ByVal dte2 As Date) As Single

        'takes the current date and the expiration date, and returns the time remaining as a fraction of a year

        Dim daysleft As Integer = DateDiff(DateInterval.Day, dte1, dte2)

        Return daysleft / 365

    End Function

    Function changeexpiration(ByVal dt As Date, ByVal num As Integer) As Date

        'changes the date supplied to the 15th, adds or subtracts num month(s) to the date,
        'and finds the first Friday on or after the 15th, which must be the 3rd Friday of that month

        dt = dt.AddDays(15 - dt.Day)
        dt = dt.AddMonths(num)

        For x As Integer = 1 To 7
            If dt.DayOfWeek = DayOfWeek.Friday Then
                Exit For
            End If
            dt = dt.AddDays(1)
        Next

        Return dt.AddDays(1) 'actual expiration is the Saturday after close of trade on expiration Friday

    End Function

    Function optionvalue(ByVal stockprice As Single, ByVal strikeprice As Single, ByVal timeremain As Single, ByVal interestrate As Single, ByVal iv As Single, ByVal dividend As Single, ByVal opttype As String) As Single

        'Black-Scholes function with dividend approximation

        'avoid one possible divide by zero error
        If timeremain <= 0 Then
            timeremain = 0.0000001
        End If

        Dim dividendyield As Single = dividend / stockprice
        Dim a, b, c, d1, d2 As Single
        a = Math.Log(stockprice / strikeprice)
        b = ((interestrate - dividendyield) + 0.5 * iv ^ 2) * timeremain
        c = iv * Math.Sqrt(timeremain)
        d1 = (a + b) / c
        d2 = d1 - iv * Math.Sqrt(timeremain)

        If opttype.Contains("Call") Then
            Return stockprice * Math.Exp(-dividendyield * timeremain) * NORMSDIST(d1) - strikeprice * Math.Exp(-interestrate * timeremain) * NORMSDIST(d2)
        Else
            Return strikeprice * Math.Exp(-interestrate * timeremain) * NORMSDIST(-d2) - stockprice * Math.Exp(-dividendyield * timeremain) * NORMSDIST(-d1)
        End If

    End Function

    Function findIV(ByVal stockprice As Single, ByVal strikeprice As Single, ByVal timeremain As Single, ByVal interestrate As Single, ByVal dividend As Single, ByVal optval As Double, ByVal opttype As String) As Single

        'uses a brute force method to find the IV that matches an option price

        Dim callval, putval, result As Single

        If opttype.Contains("Call") Then
            For iv = 0.0001 To 9 Step 0.0001 'changes the volatility .01% per run, from .01% to 900%
                callval = optionvalue(stockprice, strikeprice, timeremain, interestrate, iv, dividend, opttype)
                If callval > optval Then 'this way works better for calls
                    result = Math.Round(iv * 100, 2) 'returns IV to 2 decimals
                    Exit For
                End If
            Next
        End If

        If opttype.Contains("Put") Then
            For iv = 0.0001 To 9 Step 0.0001
                putval = optionvalue(stockprice, strikeprice, timeremain, interestrate, iv, dividend, opttype)
                If putval + 0.01 > optval Then
                    result = Math.Round(iv * 100, 2)
                    Exit For
                End If
            Next
        End If

        Return result

    End Function


End Module
