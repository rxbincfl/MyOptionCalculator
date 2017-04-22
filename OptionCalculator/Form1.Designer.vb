<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Leg1Value = New System.Windows.Forms.TextBox()
        Me.Leg1IV = New System.Windows.Forms.NumericUpDown()
        Me.Leg1ExpirationDate = New System.Windows.Forms.DateTimePicker()
        Me.Leg1StrikePrice = New System.Windows.Forms.NumericUpDown()
        Me.Leg1StockPrice = New System.Windows.Forms.NumericUpDown()
        Me.Leg1EntryDate = New System.Windows.Forms.DateTimePicker()
        Me.Leg1Contracts = New System.Windows.Forms.NumericUpDown()
        Me.Leg1Type = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Leg1ExpNext = New System.Windows.Forms.Button()
        Me.Leg1ExpPrev = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ImpliedVol = New System.Windows.Forms.NumericUpDown()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Dividends = New System.Windows.Forms.NumericUpDown()
        Me.InterestRate = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Messages = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Leg1IV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Leg1StrikePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Leg1StockPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Leg1Contracts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ImpliedVol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Dividends, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InterestRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(728, 563)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ImpliedVol)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Leg1Value)
        Me.Panel1.Controls.Add(Me.Leg1IV)
        Me.Panel1.Controls.Add(Me.Leg1ExpirationDate)
        Me.Panel1.Controls.Add(Me.Leg1StrikePrice)
        Me.Panel1.Controls.Add(Me.Leg1StockPrice)
        Me.Panel1.Controls.Add(Me.Leg1EntryDate)
        Me.Panel1.Controls.Add(Me.Leg1Contracts)
        Me.Panel1.Controls.Add(Me.Leg1Type)
        Me.Panel1.Location = New System.Drawing.Point(38, 225)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1087, 60)
        Me.Panel1.TabIndex = 1
        '
        'Leg1Value
        '
        Me.Leg1Value.Location = New System.Drawing.Point(975, 18)
        Me.Leg1Value.Name = "Leg1Value"
        Me.Leg1Value.ReadOnly = True
        Me.Leg1Value.Size = New System.Drawing.Size(89, 22)
        Me.Leg1Value.TabIndex = 10
        Me.Leg1Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Leg1IV
        '
        Me.Leg1IV.DecimalPlaces = 2
        Me.Leg1IV.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1IV.Location = New System.Drawing.Point(767, 19)
        Me.Leg1IV.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Leg1IV.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1IV.Name = "Leg1IV"
        Me.Leg1IV.Size = New System.Drawing.Size(59, 22)
        Me.Leg1IV.TabIndex = 9
        Me.Leg1IV.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'Leg1ExpirationDate
        '
        Me.Leg1ExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Leg1ExpirationDate.Location = New System.Drawing.Point(508, 14)
        Me.Leg1ExpirationDate.Name = "Leg1ExpirationDate"
        Me.Leg1ExpirationDate.Size = New System.Drawing.Size(88, 22)
        Me.Leg1ExpirationDate.TabIndex = 5
        '
        'Leg1StrikePrice
        '
        Me.Leg1StrikePrice.DecimalPlaces = 2
        Me.Leg1StrikePrice.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1StrikePrice.Location = New System.Drawing.Point(407, 15)
        Me.Leg1StrikePrice.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Leg1StrikePrice.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Leg1StrikePrice.Name = "Leg1StrikePrice"
        Me.Leg1StrikePrice.Size = New System.Drawing.Size(49, 22)
        Me.Leg1StrikePrice.TabIndex = 4
        Me.Leg1StrikePrice.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Leg1StockPrice
        '
        Me.Leg1StockPrice.DecimalPlaces = 2
        Me.Leg1StockPrice.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1StockPrice.Location = New System.Drawing.Point(322, 13)
        Me.Leg1StockPrice.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Leg1StockPrice.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Leg1StockPrice.Name = "Leg1StockPrice"
        Me.Leg1StockPrice.Size = New System.Drawing.Size(49, 22)
        Me.Leg1StockPrice.TabIndex = 3
        Me.Leg1StockPrice.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'Leg1EntryDate
        '
        Me.Leg1EntryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Leg1EntryDate.Location = New System.Drawing.Point(213, 14)
        Me.Leg1EntryDate.Name = "Leg1EntryDate"
        Me.Leg1EntryDate.Size = New System.Drawing.Size(88, 22)
        Me.Leg1EntryDate.TabIndex = 2
        Me.Leg1EntryDate.TabStop = False
        '
        'Leg1Contracts
        '
        Me.Leg1Contracts.Location = New System.Drawing.Point(145, 10)
        Me.Leg1Contracts.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Leg1Contracts.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Leg1Contracts.Name = "Leg1Contracts"
        Me.Leg1Contracts.Size = New System.Drawing.Size(49, 22)
        Me.Leg1Contracts.TabIndex = 1
        Me.Leg1Contracts.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Leg1Type
        '
        Me.Leg1Type.FormattingEnabled = True
        Me.Leg1Type.Items.AddRange(New Object() {"Long Call", "Long Put", "Short Call", "Short Put", "Stock"})
        Me.Leg1Type.Location = New System.Drawing.Point(16, 8)
        Me.Leg1Type.Name = "Leg1Type"
        Me.Leg1Type.Size = New System.Drawing.Size(105, 24)
        Me.Leg1Type.TabIndex = 0
        Me.Leg1Type.Text = "Long Call"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Khaki
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(38, 167)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1087, 52)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Option Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contracts"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Entry Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Strike Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(492, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Expiration Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(672, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 34)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Prev /" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Next"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 34)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Strike Price" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " at Entry"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Leg1ExpNext)
        Me.Panel3.Controls.Add(Me.Leg1ExpPrev)
        Me.Panel3.Location = New System.Drawing.Point(675, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(35, 51)
        Me.Panel3.TabIndex = 11
        '
        'Leg1ExpNext
        '
        Me.Leg1ExpNext.Location = New System.Drawing.Point(15, 28)
        Me.Leg1ExpNext.Name = "Leg1ExpNext"
        Me.Leg1ExpNext.Size = New System.Drawing.Size(20, 20)
        Me.Leg1ExpNext.TabIndex = 7
        Me.Leg1ExpNext.Text = "+"
        Me.Leg1ExpNext.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Leg1ExpNext.UseVisualStyleBackColor = True
        '
        'Leg1ExpPrev
        '
        Me.Leg1ExpPrev.Location = New System.Drawing.Point(15, 5)
        Me.Leg1ExpPrev.Name = "Leg1ExpPrev"
        Me.Leg1ExpPrev.Size = New System.Drawing.Size(20, 20)
        Me.Leg1ExpPrev.TabIndex = 6
        Me.Leg1ExpPrev.Text = "-"
        Me.Leg1ExpPrev.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Leg1ExpPrev.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(764, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 34)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Option " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Price"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(878, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "IV"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(990, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Value"
        '
        'ImpliedVol
        '
        Me.ImpliedVol.DecimalPlaces = 2
        Me.ImpliedVol.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ImpliedVol.Location = New System.Drawing.Point(864, 17)
        Me.ImpliedVol.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ImpliedVol.Name = "ImpliedVol"
        Me.ImpliedVol.Size = New System.Drawing.Size(59, 22)
        Me.ImpliedVol.TabIndex = 12
        Me.ImpliedVol.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Messages)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Dividends)
        Me.Panel4.Controls.Add(Me.InterestRate)
        Me.Panel4.Location = New System.Drawing.Point(38, 101)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1087, 60)
        Me.Panel4.TabIndex = 3
        '
        'Dividends
        '
        Me.Dividends.DecimalPlaces = 2
        Me.Dividends.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Dividends.Location = New System.Drawing.Point(355, 29)
        Me.Dividends.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Dividends.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Dividends.Name = "Dividends"
        Me.Dividends.Size = New System.Drawing.Size(49, 22)
        Me.Dividends.TabIndex = 3
        Me.Dividends.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'InterestRate
        '
        Me.InterestRate.DecimalPlaces = 3
        Me.InterestRate.Location = New System.Drawing.Point(129, 31)
        Me.InterestRate.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.InterestRate.Minimum = New Decimal(New Integer() {5, 0, 0, 196608})
        Me.InterestRate.Name = "InterestRate"
        Me.InterestRate.Size = New System.Drawing.Size(49, 22)
        Me.InterestRate.TabIndex = 1
        Me.InterestRate.Value = New Decimal(New Integer() {5, 0, 0, 196608})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 34)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Risk Free" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Interest Rate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(184, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "$ per share Dividend"
        '
        'Messages
        '
        Me.Messages.ForeColor = System.Drawing.Color.Red
        Me.Messages.Location = New System.Drawing.Point(494, 31)
        Me.Messages.Name = "Messages"
        Me.Messages.Size = New System.Drawing.Size(398, 22)
        Me.Messages.TabIndex = 15
        Me.Messages.Text = "Sample Message"
        Me.Messages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 853)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Option Calculator V0.1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Leg1IV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Leg1StrikePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Leg1StockPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Leg1Contracts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ImpliedVol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Dividends, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InterestRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Leg1Type As ComboBox
    Friend WithEvents Leg1Contracts As NumericUpDown
    Friend WithEvents Leg1EntryDate As DateTimePicker
    Friend WithEvents Leg1StockPrice As NumericUpDown
    Friend WithEvents Leg1StrikePrice As NumericUpDown
    Friend WithEvents Leg1ExpirationDate As DateTimePicker
    Friend WithEvents Leg1IV As NumericUpDown
    Friend WithEvents Leg1Value As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Leg1ExpNext As Button
    Friend WithEvents Leg1ExpPrev As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ImpliedVol As NumericUpDown
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Dividends As NumericUpDown
    Friend WithEvents InterestRate As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Messages As TextBox
End Class
