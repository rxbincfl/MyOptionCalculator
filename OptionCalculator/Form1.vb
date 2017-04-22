Public Class Form1

    Friend leg1 As EquityOption

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As Date = startupdate()
        Leg1ExpirationDate.Value = dt
        Messages.Text = "Reminder: Double-Click any number to change it quickly"
        Messages.ForeColor = Color.Blue
    End Sub

    Private Sub FindButtonsHandler(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_FindPrice.Click, B_FindIV.Click
        createlegs()
        If checkdates() = True Then
            If sender.name = "B_FindPrice" Then
                setprices()
                If Dividends.Value > 0 Then
                    Messages.Text = "Option Prices on Dividend Paying stocks are approximate"
                Else
                    Messages.Text = "Option Price calculated from IV"
                End If
            Else
                setvolatility()
                If Dividends.Value > 0 Then
                    Messages.Text = "Option Prices on Dividend Paying stocks are approximate"
                Else
                    Messages.Text = "IV calculated from Option Price"
                End If
            End If
            setvalues()
            Messages.ForeColor = Color.DarkGreen
        Else
            setzeros()
            Messages.ForeColor = Color.Red
            Messages.Text = "Expiration date is on or before the Entry date"
        End If
    End Sub

    Private Sub ChangeExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Leg1ExpPrev.Click, Leg1ExpNext.Click
        Dim direction As Integer = 1
        If sender.name.contains("Prev") Then
            direction = -1
        End If
        Leg1ExpirationDate.Value = changeexpiration(Leg1ExpirationDate.Value, direction)
    End Sub

    Private Sub createlegs()
        'each option leg belongs to the EquityOption class
        leg1 = New EquityOption(Leg1Type.Text, Leg1Contracts.Value, Leg1EntryDate.Value, Leg1StockPrice.Value, Leg1StrikePrice.Value, Leg1ExpirationDate.Value, Leg1OptionPrice.Value, Leg1IV.Value, True, InterestRate.Value, Dividends.Value)
    End Sub

    Private Function checkdates() As Boolean
        Return leg1.expirationafterentry
    End Function

    Function startupdate() As Date
        Dim dt As Date = changeexpiration(Now.Date, 0)
        If DateDiff(DateInterval.Day, Now.Date, dt) > 0 Then
            Return dt
        Else
            Return changeexpiration(Now.Date, 1)
        End If
    End Function

    Private Sub setprices()
        Leg1OptionPrice.Value = leg1.price
    End Sub

    Private Sub setvolatility()
        Leg1IV.Value = leg1.volatility
    End Sub

    Private Sub setvalues()
        Leg1Value.Text = leg1.totalvalue(Leg1OptionPrice.Value)
        Leg1Value.BackColor = leg1.colorize
    End Sub

    Private Sub setzeros()
        Leg1Value.Text = FormatCurrency(0)
        Leg1Value.BackColor = Color.Gray
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Leg1Value_TextChanged(sender As Object, e As EventArgs) Handles Leg1Value.TextChanged

    End Sub
End Class
