Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub TestNames()

        'this sub does not actually do anything, it just tests that you have the correct names for the various controls
        'if you see a name such as "Leg1Type" underlined with a blue squiggly line below, it probably means you misspelled the name of the control
        'change the name of the control in the Properties window to match what is shown below
        'do not change the names below - they are the correct names, which MUST be used in order for all functions to work

        'a blue squiggly line can also indicate that you added the wrong type of control
        'for instance, Leg1Contracts is supposed to be a NumericUpDown control
        'if you added it as a TextBox instead, there will be a blue squiggly line under all of "Leg1Contracts.Value", not just the name

        Dim txt As String = Leg1Type.Text
        Dim int As Integer = Leg1Contracts.Value
        Dim sng As Single = Leg1StockPrice.Value
        sng = Leg1StrikePrice.Value
        Dim dt As Date = Leg1EntryDate.Value
        dt = Leg1ExpirationDate.Value
        sng = Leg1OptionPrice.Value
        sng = Leg1OptionPrice.Value
        txt = Leg1Value.Text
        sng = InterestRate.Value
        sng = Dividends.Value
        txt = Messages.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Leg1Value_TextChanged(sender As Object, e As EventArgs) Handles Leg1Value.TextChanged

    End Sub
End Class
