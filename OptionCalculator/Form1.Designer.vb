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
        Me.Leg1StockPrice = New System.Windows.Forms.NumericUpDown()
        Me.Leg1EntryDate = New System.Windows.Forms.DateTimePicker()
        Me.Leg1Contracts = New System.Windows.Forms.NumericUpDown()
        Me.Leg1Type = New System.Windows.Forms.ComboBox()
        Me.Leg1StrikePrice = New System.Windows.Forms.NumericUpDown()
        Me.Leg1ExpirationDate = New System.Windows.Forms.DateTimePicker()
        Me.Leg1ExpPrev = New System.Windows.Forms.Button()
        Me.Leg1ExpNext = New System.Windows.Forms.Button()
        Me.Leg1OptionPrice = New System.Windows.Forms.NumericUpDown()
        Me.Leg1IV = New System.Windows.Forms.NumericUpDown()
        Me.Leg1Value = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Leg1StockPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Leg1Contracts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Leg1StrikePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Leg1OptionPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Leg1IV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.Leg1Value)
        Me.Panel1.Controls.Add(Me.Leg1IV)
        Me.Panel1.Controls.Add(Me.Leg1OptionPrice)
        Me.Panel1.Controls.Add(Me.Leg1ExpNext)
        Me.Panel1.Controls.Add(Me.Leg1ExpPrev)
        Me.Panel1.Controls.Add(Me.Leg1ExpirationDate)
        Me.Panel1.Controls.Add(Me.Leg1StrikePrice)
        Me.Panel1.Controls.Add(Me.Leg1StockPrice)
        Me.Panel1.Controls.Add(Me.Leg1EntryDate)
        Me.Panel1.Controls.Add(Me.Leg1Contracts)
        Me.Panel1.Controls.Add(Me.Leg1Type)
        Me.Panel1.Location = New System.Drawing.Point(105, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 42)
        Me.Panel1.TabIndex = 1
        '
        'Leg1StockPrice
        '
        Me.Leg1StockPrice.DecimalPlaces = 2
        Me.Leg1StockPrice.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1StockPrice.Location = New System.Drawing.Point(243, 15)
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
        Me.Leg1EntryDate.Location = New System.Drawing.Point(149, 15)
        Me.Leg1EntryDate.Name = "Leg1EntryDate"
        Me.Leg1EntryDate.Size = New System.Drawing.Size(88, 22)
        Me.Leg1EntryDate.TabIndex = 2
        Me.Leg1EntryDate.TabStop = False
        '
        'Leg1Contracts
        '
        Me.Leg1Contracts.Location = New System.Drawing.Point(94, 15)
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
        Me.Leg1Type.Location = New System.Drawing.Point(6, 14)
        Me.Leg1Type.Name = "Leg1Type"
        Me.Leg1Type.Size = New System.Drawing.Size(82, 24)
        Me.Leg1Type.TabIndex = 0
        Me.Leg1Type.Text = "Long Call"
        '
        'Leg1StrikePrice
        '
        Me.Leg1StrikePrice.DecimalPlaces = 2
        Me.Leg1StrikePrice.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1StrikePrice.Location = New System.Drawing.Point(299, 15)
        Me.Leg1StrikePrice.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Leg1StrikePrice.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Leg1StrikePrice.Name = "Leg1StrikePrice"
        Me.Leg1StrikePrice.Size = New System.Drawing.Size(49, 22)
        Me.Leg1StrikePrice.TabIndex = 4
        Me.Leg1StrikePrice.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Leg1ExpirationDate
        '
        Me.Leg1ExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Leg1ExpirationDate.Location = New System.Drawing.Point(356, 15)
        Me.Leg1ExpirationDate.Name = "Leg1ExpirationDate"
        Me.Leg1ExpirationDate.Size = New System.Drawing.Size(88, 22)
        Me.Leg1ExpirationDate.TabIndex = 5
        '
        'Leg1ExpPrev
        '
        Me.Leg1ExpPrev.Location = New System.Drawing.Point(446, 1)
        Me.Leg1ExpPrev.Name = "Leg1ExpPrev"
        Me.Leg1ExpPrev.Size = New System.Drawing.Size(20, 20)
        Me.Leg1ExpPrev.TabIndex = 6
        Me.Leg1ExpPrev.Text = "-"
        Me.Leg1ExpPrev.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Leg1ExpPrev.UseVisualStyleBackColor = True
        '
        'Leg1ExpNext
        '
        Me.Leg1ExpNext.Location = New System.Drawing.Point(446, 22)
        Me.Leg1ExpNext.Name = "Leg1ExpNext"
        Me.Leg1ExpNext.Size = New System.Drawing.Size(20, 20)
        Me.Leg1ExpNext.TabIndex = 7
        Me.Leg1ExpNext.Text = "+"
        Me.Leg1ExpNext.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Leg1ExpNext.UseVisualStyleBackColor = True
        '
        'Leg1OptionPrice
        '
        Me.Leg1OptionPrice.DecimalPlaces = 2
        Me.Leg1OptionPrice.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1OptionPrice.Location = New System.Drawing.Point(471, 15)
        Me.Leg1OptionPrice.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Leg1OptionPrice.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1OptionPrice.Name = "Leg1OptionPrice"
        Me.Leg1OptionPrice.Size = New System.Drawing.Size(59, 22)
        Me.Leg1OptionPrice.TabIndex = 8
        Me.Leg1OptionPrice.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'Leg1IV
        '
        Me.Leg1IV.DecimalPlaces = 2
        Me.Leg1IV.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1IV.Location = New System.Drawing.Point(536, 15)
        Me.Leg1IV.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Leg1IV.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1IV.Name = "Leg1IV"
        Me.Leg1IV.Size = New System.Drawing.Size(59, 22)
        Me.Leg1IV.TabIndex = 9
        Me.Leg1IV.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'Leg1Value
        '
        Me.Leg1Value.Location = New System.Drawing.Point(603, 15)
        Me.Leg1Value.Name = "Leg1Value"
        Me.Leg1Value.ReadOnly = True
        Me.Leg1Value.Size = New System.Drawing.Size(89, 22)
        Me.Leg1Value.TabIndex = 10
        Me.Leg1Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 853)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Option Calculator V0.1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Leg1StockPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Leg1Contracts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Leg1StrikePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Leg1OptionPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Leg1IV, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Leg1ExpPrev As Button
    Friend WithEvents Leg1ExpNext As Button
    Friend WithEvents Leg1OptionPrice As NumericUpDown
    Friend WithEvents Leg1IV As NumericUpDown
    Friend WithEvents Leg1Value As TextBox
End Class
