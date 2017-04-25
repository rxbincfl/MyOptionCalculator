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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Leg1Type = New System.Windows.Forms.ComboBox()
        Me.Leg1Contracts = New System.Windows.Forms.NumericUpDown()
        Me.Leg1EntryData = New System.Windows.Forms.DateTimePicker()
        Me.Leg1StockPrice = New System.Windows.Forms.NumericUpDown()
        Me.Leg1ExpirationData = New System.Windows.Forms.DateTimePicker()
        Me.Leg1ExpPrev = New System.Windows.Forms.Button()
        Me.Leg1ExpNext = New System.Windows.Forms.Button()
        Me.Leg1IV = New System.Windows.Forms.NumericUpDown()
        Me.Leg1Value = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Leg1Contracts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Leg1StockPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Leg1IV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Leg1Value)
        Me.Panel1.Controls.Add(Me.Leg1IV)
        Me.Panel1.Controls.Add(Me.Leg1ExpNext)
        Me.Panel1.Controls.Add(Me.Leg1ExpPrev)
        Me.Panel1.Controls.Add(Me.Leg1ExpirationData)
        Me.Panel1.Controls.Add(Me.Leg1StockPrice)
        Me.Panel1.Controls.Add(Me.Leg1EntryData)
        Me.Panel1.Controls.Add(Me.Leg1Contracts)
        Me.Panel1.Controls.Add(Me.Leg1Type)
        Me.Panel1.Location = New System.Drawing.Point(12, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(882, 42)
        Me.Panel1.TabIndex = 0
        '
        'Leg1Type
        '
        Me.Leg1Type.FormattingEnabled = True
        Me.Leg1Type.Items.AddRange(New Object() {"Long Call", "Long Put", "Short Call", "Short Put"})
        Me.Leg1Type.Location = New System.Drawing.Point(6, 15)
        Me.Leg1Type.Name = "Leg1Type"
        Me.Leg1Type.Size = New System.Drawing.Size(82, 24)
        Me.Leg1Type.TabIndex = 0
        Me.Leg1Type.Text = "Long Call"
        '
        'Leg1Contracts
        '
        Me.Leg1Contracts.Location = New System.Drawing.Point(103, 15)
        Me.Leg1Contracts.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Leg1Contracts.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Leg1Contracts.Name = "Leg1Contracts"
        Me.Leg1Contracts.Size = New System.Drawing.Size(49, 22)
        Me.Leg1Contracts.TabIndex = 1
        Me.Leg1Contracts.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Leg1EntryData
        '
        Me.Leg1EntryData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Leg1EntryData.Location = New System.Drawing.Point(205, 13)
        Me.Leg1EntryData.Name = "Leg1EntryData"
        Me.Leg1EntryData.Size = New System.Drawing.Size(88, 22)
        Me.Leg1EntryData.TabIndex = 2
        '
        'Leg1StockPrice
        '
        Me.Leg1StockPrice.DecimalPlaces = 2
        Me.Leg1StockPrice.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1StockPrice.Location = New System.Drawing.Point(344, 15)
        Me.Leg1StockPrice.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Leg1StockPrice.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Leg1StockPrice.Name = "Leg1StockPrice"
        Me.Leg1StockPrice.Size = New System.Drawing.Size(82, 22)
        Me.Leg1StockPrice.TabIndex = 3
        Me.Leg1StockPrice.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Leg1StockPrice.Visible = False
        '
        'Leg1ExpirationData
        '
        Me.Leg1ExpirationData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Leg1ExpirationData.Location = New System.Drawing.Point(458, 14)
        Me.Leg1ExpirationData.Name = "Leg1ExpirationData"
        Me.Leg1ExpirationData.Size = New System.Drawing.Size(90, 22)
        Me.Leg1ExpirationData.TabIndex = 4
        '
        'Leg1ExpPrev
        '
        Me.Leg1ExpPrev.Location = New System.Drawing.Point(610, 3)
        Me.Leg1ExpPrev.Name = "Leg1ExpPrev"
        Me.Leg1ExpPrev.Size = New System.Drawing.Size(22, 20)
        Me.Leg1ExpPrev.TabIndex = 5
        Me.Leg1ExpPrev.Text = "-"
        Me.Leg1ExpPrev.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Leg1ExpPrev.UseVisualStyleBackColor = True
        '
        'Leg1ExpNext
        '
        Me.Leg1ExpNext.Location = New System.Drawing.Point(612, 22)
        Me.Leg1ExpNext.Name = "Leg1ExpNext"
        Me.Leg1ExpNext.Size = New System.Drawing.Size(20, 20)
        Me.Leg1ExpNext.TabIndex = 6
        Me.Leg1ExpNext.Text = "+"
        Me.Leg1ExpNext.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Leg1ExpNext.UseVisualStyleBackColor = True
        '
        'Leg1IV
        '
        Me.Leg1IV.DecimalPlaces = 2
        Me.Leg1IV.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1IV.Location = New System.Drawing.Point(680, 13)
        Me.Leg1IV.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Leg1IV.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Leg1IV.Name = "Leg1IV"
        Me.Leg1IV.Size = New System.Drawing.Size(59, 22)
        Me.Leg1IV.TabIndex = 7
        Me.Leg1IV.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Leg1IV.Visible = False
        '
        'Leg1Value
        '
        Me.Leg1Value.Location = New System.Drawing.Point(790, 13)
        Me.Leg1Value.Name = "Leg1Value"
        Me.Leg1Value.ReadOnly = True
        Me.Leg1Value.Size = New System.Drawing.Size(89, 22)
        Me.Leg1Value.TabIndex = 8
        Me.Leg1Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Location = New System.Drawing.Point(3, -33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(718, 32)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TextBox9)
        Me.Panel3.Controls.Add(Me.TextBox7)
        Me.Panel3.Controls.Add(Me.TextBox8)
        Me.Panel3.Controls.Add(Me.TextBox6)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Location = New System.Drawing.Point(12, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(882, 50)
        Me.Panel3.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(82, 22)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Option Type"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(99, 13)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(63, 22)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Contracts"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(205, 9)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 22)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "Entry Date"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(344, 5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(82, 22)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = "Stock Price"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(344, 27)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(82, 22)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = "At Entry"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(448, 16)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 22)
        Me.TextBox6.TabIndex = 5
        Me.TextBox6.Text = "Expiration Date"
        '
        'TextBox7
        '
        Me.TextBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TextBox7.Location = New System.Drawing.Point(579, 25)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(82, 22)
        Me.TextBox7.TabIndex = 7
        Me.TextBox7.Text = "Next"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TextBox8.Location = New System.Drawing.Point(579, 3)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(82, 22)
        Me.TextBox8.TabIndex = 6
        Me.TextBox8.Text = "Prev/"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox9
        '
        Me.TextBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TextBox9.Location = New System.Drawing.Point(667, 0)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(82, 47)
        Me.TextBox9.TabIndex = 8
        Me.TextBox9.Text = "Option" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Price"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 245)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "BasicOptionGraph"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Leg1Contracts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Leg1StockPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Leg1IV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Leg1Type As ComboBox
    Friend WithEvents Leg1Contracts As NumericUpDown
    Friend WithEvents Leg1EntryData As DateTimePicker
    Friend WithEvents Leg1StockPrice As NumericUpDown
    Friend WithEvents Leg1ExpirationData As DateTimePicker
    Friend WithEvents Leg1ExpPrev As Button
    Friend WithEvents Leg1ExpNext As Button
    Friend WithEvents Leg1IV As NumericUpDown
    Friend WithEvents Leg1Value As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
End Class
