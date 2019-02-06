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
        Me.ImageLabel = New System.Windows.Forms.Label()
        Me.DatabaseDataSet1 = New LibraryManagementSystem.DatabaseDataSet()
        Me.FieldTextBox = New System.Windows.Forms.ComboBox()
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
        Me.ISBNTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ISBNTextBox1.Location = New System.Drawing.Point(263, 130)
        Me.ISBNTextBox1.Name = "ISBNTextBox1"
        Me.ISBNTextBox1.Size = New System.Drawing.Size(254, 30)
        Me.ISBNTextBox1.TabIndex = 11
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TotalTextBox.Location = New System.Drawing.Point(263, 156)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(254, 30)
        Me.TotalTextBox.TabIndex = 13
        Me.TotalTextBox.Text = "0"
        Me.TotalTextBox.Visible = False
        '
        'RemainingTextBox
        '
        Me.RemainingTextBox.Enabled = False
        Me.RemainingTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RemainingTextBox.Location = New System.Drawing.Point(263, 186)
        Me.RemainingTextBox.Name = "RemainingTextBox"
        Me.RemainingTextBox.Size = New System.Drawing.Size(254, 30)
        Me.RemainingTextBox.TabIndex = 15
        Me.RemainingTextBox.Text = "0"
        Me.RemainingTextBox.Visible = False
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LocationTextBox.Location = New System.Drawing.Point(263, 214)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(254, 30)
        Me.LocationTextBox.TabIndex = 17
        Me.LocationTextBox.Visible = False
        '
        'PublishYearDateTimePicker
        '
        Me.PublishYearDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PublishYearDateTimePicker.Location = New System.Drawing.Point(263, 242)
        Me.PublishYearDateTimePicker.Name = "PublishYearDateTimePicker"
        Me.PublishYearDateTimePicker.Size = New System.Drawing.Size(254, 30)
        Me.PublishYearDateTimePicker.TabIndex = 19
        Me.PublishYearDateTimePicker.Visible = False
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TitleTextBox.Location = New System.Drawing.Point(263, 270)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(254, 30)
        Me.TitleTextBox.TabIndex = 21
        Me.TitleTextBox.Visible = False
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AuthorTextBox.Location = New System.Drawing.Point(263, 298)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(254, 30)
        Me.AuthorTextBox.TabIndex = 23
        Me.AuthorTextBox.Visible = False
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PublisherTextBox.Location = New System.Drawing.Point(263, 326)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(254, 30)
        Me.PublisherTextBox.TabIndex = 25
        Me.PublisherTextBox.Visible = False
        '
        'myButton
        '
        Me.myButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.myButton.Location = New System.Drawing.Point(449, 532)
        Me.myButton.Name = "myButton"
        Me.myButton.Size = New System.Drawing.Size(114, 48)
        Me.myButton.TabIndex = 30
        Me.myButton.Text = "Search"
        Me.myButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(66, 431)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Number of books to add"
        Me.Label1.Visible = False
        '
        'AddNumber
        '
        Me.AddNumber.Location = New System.Drawing.Point(353, 431)
        Me.AddNumber.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.AddNumber.Name = "AddNumber"
        Me.AddNumber.Size = New System.Drawing.Size(120, 22)
        Me.AddNumber.TabIndex = 33
        Me.AddNumber.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(695, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 274)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'uploadButton
        '
        Me.uploadButton.Location = New System.Drawing.Point(735, 449)
        Me.uploadButton.Name = "uploadButton"
        Me.uploadButton.Size = New System.Drawing.Size(150, 59)
        Me.uploadButton.TabIndex = 35
        Me.uploadButton.Text = "Upload"
        Me.uploadButton.UseVisualStyleBackColor = True
        Me.uploadButton.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(86, 399)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(35, 20)
        Me.PriceLabel.TabIndex = 36
        Me.PriceLabel.Text = "Price"
        Me.PriceLabel.UseCompatibleTextRendering = True
        Me.PriceLabel.Visible = False
        '
        'PriceBox
        '
        Me.PriceBox.Location = New System.Drawing.Point(263, 406)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.Size = New System.Drawing.Size(254, 22)
        Me.PriceBox.TabIndex = 37
        Me.PriceBox.Visible = False
        '
        'ISBNLabel
        '
        Me.ISBNLabel.AutoSize = True
        Me.ISBNLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ISBNLabel.Location = New System.Drawing.Point(81, 130)
        Me.ISBNLabel.Name = "ISBNLabel"
        Me.ISBNLabel.Size = New System.Drawing.Size(64, 25)
        Me.ISBNLabel.TabIndex = 10
        Me.ISBNLabel.Text = "ISBN:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TotalLabel.Location = New System.Drawing.Point(81, 158)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(62, 25)
        Me.TotalLabel.TabIndex = 12
        Me.TotalLabel.Text = "Total:"
        Me.TotalLabel.Visible = False
        '
        'RemainingLabel
        '
        Me.RemainingLabel.AutoSize = True
        Me.RemainingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RemainingLabel.Location = New System.Drawing.Point(81, 186)
        Me.RemainingLabel.Name = "RemainingLabel"
        Me.RemainingLabel.Size = New System.Drawing.Size(110, 25)
        Me.RemainingLabel.TabIndex = 14
        Me.RemainingLabel.Text = "Remaining:"
        Me.RemainingLabel.Visible = False
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LocationLabel.Location = New System.Drawing.Point(81, 214)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(92, 25)
        Me.LocationLabel.TabIndex = 16
        Me.LocationLabel.Text = "Location:"
        Me.LocationLabel.Visible = False
        '
        'PublishYearLabel
        '
        Me.PublishYearLabel.AutoSize = True
        Me.PublishYearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PublishYearLabel.Location = New System.Drawing.Point(81, 243)
        Me.PublishYearLabel.Name = "PublishYearLabel"
        Me.PublishYearLabel.Size = New System.Drawing.Size(128, 25)
        Me.PublishYearLabel.TabIndex = 18
        Me.PublishYearLabel.Text = "Publish Year:"
        Me.PublishYearLabel.Visible = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TitleLabel.Location = New System.Drawing.Point(81, 270)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(55, 25)
        Me.TitleLabel.TabIndex = 20
        Me.TitleLabel.Text = "Title:"
        Me.TitleLabel.Visible = False
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AuthorLabel.Location = New System.Drawing.Point(81, 298)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(76, 25)
        Me.AuthorLabel.TabIndex = 22
        Me.AuthorLabel.Text = "Author:"
        Me.AuthorLabel.Visible = False
        '
        'PublisherLabel
        '
        Me.PublisherLabel.AutoSize = True
        Me.PublisherLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PublisherLabel.Location = New System.Drawing.Point(81, 326)
        Me.PublisherLabel.Name = "PublisherLabel"
        Me.PublisherLabel.Size = New System.Drawing.Size(99, 25)
        Me.PublisherLabel.TabIndex = 24
        Me.PublisherLabel.Text = "Publisher:"
        Me.PublisherLabel.Visible = False
        '
        'FieldLabel
        '
        Me.FieldLabel.AutoSize = True
        Me.FieldLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FieldLabel.Location = New System.Drawing.Point(81, 354)
        Me.FieldLabel.Name = "FieldLabel"
        Me.FieldLabel.Size = New System.Drawing.Size(60, 25)
        Me.FieldLabel.TabIndex = 26
        Me.FieldLabel.Text = "Field:"
        Me.FieldLabel.Visible = False
        '
        'ImageLabel
        '
        Me.ImageLabel.AutoSize = True
        Me.ImageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ImageLabel.Location = New System.Drawing.Point(593, 219)
        Me.ImageLabel.Name = "ImageLabel"
        Me.ImageLabel.Size = New System.Drawing.Size(72, 25)
        Me.ImageLabel.TabIndex = 28
        Me.ImageLabel.Text = "Image:"
        Me.ImageLabel.Visible = False
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
        Me.FieldTextBox.FormattingEnabled = True
        Me.FieldTextBox.Items.AddRange(New Object() {"Biosciences & Bioengineering", "Chemical Engineering", "Chemistry", "Civil Engineering", "Computer Science & Engg.", "Design", "Electronics & Electrical Engg.", "Humanities and Social Sciences", "Mathematics", "Mechanical Engineering", "Physics"})
        Me.FieldTextBox.Location = New System.Drawing.Point(263, 362)
        Me.FieldTextBox.Name = "FieldTextBox"
        Me.FieldTextBox.Size = New System.Drawing.Size(254, 24)
        Me.FieldTextBox.TabIndex = 38
        Me.FieldTextBox.Visible = False
        '
        'addBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Controls.Add(Me.ImageLabel)
        Me.Name = "addBook"
        Me.Size = New System.Drawing.Size(1133, 781)
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
    Friend WithEvents ImageLabel As System.Windows.Forms.Label
    Friend WithEvents RemainingLabel As System.Windows.Forms.Label
    Friend WithEvents LocationLabel As System.Windows.Forms.Label
    Friend WithEvents PublishYearLabel As System.Windows.Forms.Label
    Friend WithEvents DatabaseDataSet1 As LibraryManagementSystem.DatabaseDataSet
    Friend WithEvents FieldTextBox As System.Windows.Forms.ComboBox


End Class
