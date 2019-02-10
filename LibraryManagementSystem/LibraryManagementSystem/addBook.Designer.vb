<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addBook
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ISBNTextBox1 = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.RemainingTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.PublishYearDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.myButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddNumber = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.uploadButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.PriceBox = New System.Windows.Forms.MaskedTextBox()
        Me.ISBNLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.RemainingLabel = New System.Windows.Forms.Label()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.PublishYearLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.PublisherLabel = New System.Windows.Forms.Label()
        Me.FieldLabel = New System.Windows.Forms.Label()
        Me.DatabaseDataSet1 = New LibraryManagementSystem.DatabaseDataSet()
        Me.FieldTextBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.AddNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ISBNTextBox1
        '
        Me.ISBNTextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNTextBox1.Location = New System.Drawing.Point(198, 79)
        Me.ISBNTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ISBNTextBox1.Name = "ISBNTextBox1"
        Me.ISBNTextBox1.Size = New System.Drawing.Size(244, 26)
        Me.ISBNTextBox1.TabIndex = 11
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(198, 117)
        Me.TotalTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(244, 26)
        Me.TotalTextBox.TabIndex = 13
        Me.TotalTextBox.Text = "0"
        Me.TotalTextBox.Visible = False
        '
        'RemainingTextBox
        '
        Me.RemainingTextBox.Enabled = False
        Me.RemainingTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemainingTextBox.Location = New System.Drawing.Point(198, 148)
        Me.RemainingTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RemainingTextBox.Name = "RemainingTextBox"
        Me.RemainingTextBox.Size = New System.Drawing.Size(244, 26)
        Me.RemainingTextBox.TabIndex = 15
        Me.RemainingTextBox.Text = "0"
        Me.RemainingTextBox.Visible = False
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(198, 189)
        Me.LocationTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(244, 26)
        Me.LocationTextBox.TabIndex = 17
        Me.LocationTextBox.Visible = False
        '
        'PublishYearDateTimePicker
        '
        Me.PublishYearDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublishYearDateTimePicker.Location = New System.Drawing.Point(198, 230)
        Me.PublishYearDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.PublishYearDateTimePicker.Name = "PublishYearDateTimePicker"
        Me.PublishYearDateTimePicker.Size = New System.Drawing.Size(244, 26)
        Me.PublishYearDateTimePicker.TabIndex = 19
        Me.PublishYearDateTimePicker.Visible = False
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(198, 262)
        Me.TitleTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(244, 26)
        Me.TitleTextBox.TabIndex = 21
        Me.TitleTextBox.Visible = False
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorTextBox.Location = New System.Drawing.Point(198, 296)
        Me.AuthorTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(244, 26)
        Me.AuthorTextBox.TabIndex = 23
        Me.AuthorTextBox.Visible = False
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublisherTextBox.Location = New System.Drawing.Point(198, 330)
        Me.PublisherTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(244, 26)
        Me.PublisherTextBox.TabIndex = 25
        Me.PublisherTextBox.Visible = False
        '
        'myButton
        '
        Me.myButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.myButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.myButton.FlatAppearance.BorderSize = 0
        Me.myButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.myButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myButton.ForeColor = System.Drawing.Color.White
        Me.myButton.Location = New System.Drawing.Point(217, 497)
        Me.myButton.Margin = New System.Windows.Forms.Padding(2)
        Me.myButton.Name = "myButton"
        Me.myButton.Size = New System.Drawing.Size(225, 42)
        Me.myButton.TabIndex = 30
        Me.myButton.Text = "Search"
        Me.myButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 444)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 19)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Number of books to add"
        Me.Label1.Visible = False
        '
        'AddNumber
        '
        Me.AddNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNumber.Location = New System.Drawing.Point(271, 442)
        Me.AddNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.AddNumber.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.AddNumber.Name = "AddNumber"
        Me.AddNumber.Size = New System.Drawing.Size(171, 26)
        Me.AddNumber.TabIndex = 33
        Me.AddNumber.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(583, 79)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'uploadButton
        '
        Me.uploadButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.uploadButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uploadButton.FlatAppearance.BorderSize = 0
        Me.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uploadButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadButton.ForeColor = System.Drawing.Color.White
        Me.uploadButton.Location = New System.Drawing.Point(583, 308)
        Me.uploadButton.Margin = New System.Windows.Forms.Padding(2)
        Me.uploadButton.Name = "uploadButton"
        Me.uploadButton.Size = New System.Drawing.Size(200, 48)
        Me.uploadButton.TabIndex = 35
        Me.uploadButton.Text = "Upload Image"
        Me.uploadButton.UseVisualStyleBackColor = False
        Me.uploadButton.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(121, 403)
        Me.PriceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(40, 23)
        Me.PriceLabel.TabIndex = 36
        Me.PriceLabel.Text = "Price"
        Me.PriceLabel.UseCompatibleTextRendering = True
        Me.PriceLabel.Visible = False
        '
        'PriceBox
        '
        Me.PriceBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceBox.Location = New System.Drawing.Point(198, 400)
        Me.PriceBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.Size = New System.Drawing.Size(244, 26)
        Me.PriceBox.TabIndex = 37
        Me.PriceBox.Visible = False
        '
        'ISBNLabel
        '
        Me.ISBNLabel.AutoSize = True
        Me.ISBNLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNLabel.Location = New System.Drawing.Point(113, 82)
        Me.ISBNLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ISBNLabel.Name = "ISBNLabel"
        Me.ISBNLabel.Size = New System.Drawing.Size(48, 19)
        Me.ISBNLabel.TabIndex = 10
        Me.ISBNLabel.Text = "ISBN:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(119, 120)
        Me.TotalLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(42, 19)
        Me.TotalLabel.TabIndex = 12
        Me.TotalLabel.Text = "Total:"
        Me.TotalLabel.Visible = False
        '
        'RemainingLabel
        '
        Me.RemainingLabel.AutoSize = True
        Me.RemainingLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemainingLabel.Location = New System.Drawing.Point(87, 151)
        Me.RemainingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RemainingLabel.Name = "RemainingLabel"
        Me.RemainingLabel.Size = New System.Drawing.Size(74, 19)
        Me.RemainingLabel.TabIndex = 14
        Me.RemainingLabel.Text = "Remaining:"
        Me.RemainingLabel.Visible = False
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationLabel.Location = New System.Drawing.Point(96, 192)
        Me.LocationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(65, 19)
        Me.LocationLabel.TabIndex = 16
        Me.LocationLabel.Text = "Location:"
        Me.LocationLabel.Visible = False
        '
        'PublishYearLabel
        '
        Me.PublishYearLabel.AutoSize = True
        Me.PublishYearLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublishYearLabel.Location = New System.Drawing.Point(75, 236)
        Me.PublishYearLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PublishYearLabel.Name = "PublishYearLabel"
        Me.PublishYearLabel.Size = New System.Drawing.Size(86, 19)
        Me.PublishYearLabel.TabIndex = 18
        Me.PublishYearLabel.Text = "Publish Year:"
        Me.PublishYearLabel.Visible = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(124, 265)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(37, 19)
        Me.TitleLabel.TabIndex = 20
        Me.TitleLabel.Text = "Title:"
        Me.TitleLabel.Visible = False
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorLabel.Location = New System.Drawing.Point(105, 296)
        Me.AuthorLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(54, 19)
        Me.AuthorLabel.TabIndex = 22
        Me.AuthorLabel.Text = "Author:"
        Me.AuthorLabel.Visible = False
        '
        'PublisherLabel
        '
        Me.PublisherLabel.AutoSize = True
        Me.PublisherLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublisherLabel.Location = New System.Drawing.Point(94, 333)
        Me.PublisherLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PublisherLabel.Name = "PublisherLabel"
        Me.PublisherLabel.Size = New System.Drawing.Size(67, 19)
        Me.PublisherLabel.TabIndex = 24
        Me.PublisherLabel.Text = "Publisher:"
        Me.PublisherLabel.Visible = False
        '
        'FieldLabel
        '
        Me.FieldLabel.AutoSize = True
        Me.FieldLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FieldLabel.Location = New System.Drawing.Point(117, 365)
        Me.FieldLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FieldLabel.Name = "FieldLabel"
        Me.FieldLabel.Size = New System.Drawing.Size(42, 19)
        Me.FieldLabel.TabIndex = 26
        Me.FieldLabel.Text = "Field:"
        Me.FieldLabel.Visible = False
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FieldTextBox
        '
        Me.FieldTextBox.AllowDrop = True
        Me.FieldTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FieldTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FieldTextBox.FormattingEnabled = True
        Me.FieldTextBox.Items.AddRange(New Object() {"Biosciences and Bioengineering", "Chemical Engineering", "Chemistry", "Civil Engineering", "Computer Science and Engg.", "Design", "Electronics and Electrical Engg.", "Humanities and Social Sciences", "Mathematics", "Mechanical Engineering", "Physics"})
        Me.FieldTextBox.Location = New System.Drawing.Point(198, 362)
        Me.FieldTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FieldTextBox.Name = "FieldTextBox"
        Me.FieldTextBox.Size = New System.Drawing.Size(244, 27)
        Me.FieldTextBox.TabIndex = 38
        Me.FieldTextBox.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(44, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 23)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Add Book"
        '
        'addBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FieldTextBox)
        Me.Controls.Add(Me.PriceBox)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.uploadButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AddNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.myButton)
        Me.Controls.Add(Me.ISBNLabel)
        Me.Controls.Add(Me.ISBNTextBox1)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.RemainingLabel)
        Me.Controls.Add(Me.RemainingTextBox)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Me.PublishYearLabel)
        Me.Controls.Add(Me.PublishYearDateTimePicker)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.AuthorLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(Me.PublisherLabel)
        Me.Controls.Add(Me.PublisherTextBox)
        Me.Controls.Add(Me.FieldLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "addBook"
        Me.Size = New System.Drawing.Size(1017, 681)
        CType(Me.AddNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ISBNTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemainingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublishYearDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublisherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents myButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents uploadButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents PriceBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents ISBNLabel As System.Windows.Forms.Label
    Friend WithEvents PublisherLabel As System.Windows.Forms.Label
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents AuthorLabel As System.Windows.Forms.Label
    Friend WithEvents FieldLabel As System.Windows.Forms.Label
    Friend WithEvents RemainingLabel As System.Windows.Forms.Label
    Friend WithEvents LocationLabel As System.Windows.Forms.Label
    Friend WithEvents PublishYearLabel As System.Windows.Forms.Label
    Friend WithEvents DatabaseDataSet1 As LibraryManagementSystem.DatabaseDataSet
    Friend WithEvents FieldTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label


End Class
