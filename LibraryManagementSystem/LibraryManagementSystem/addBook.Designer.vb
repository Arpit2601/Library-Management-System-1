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
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim RemainingLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim PublishYearLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim PublisherLabel As System.Windows.Forms.Label
        Dim FieldLabel As System.Windows.Forms.Label
        Dim ImageLabel As System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ISBNTextBox1 = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.RemainingTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.PublishYearDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.FieldTextBox = New System.Windows.Forms.TextBox()
        Me.ImageTextBox = New System.Windows.Forms.TextBox()
        Me.myButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddNumber = New System.Windows.Forms.NumericUpDown()
        ISBNLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        RemainingLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        PublishYearLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        PublisherLabel = New System.Windows.Forms.Label()
        FieldLabel = New System.Windows.Forms.Label()
        ImageLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        ISBNLabel.Location = New System.Drawing.Point(363, 180)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(64, 25)
        ISBNLabel.TabIndex = 10
        ISBNLabel.Text = "ISBN:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        TotalLabel.Location = New System.Drawing.Point(363, 208)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(62, 25)
        TotalLabel.TabIndex = 12
        TotalLabel.Text = "Total:"
        '
        'RemainingLabel
        '
        RemainingLabel.AutoSize = True
        RemainingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        RemainingLabel.Location = New System.Drawing.Point(363, 236)
        RemainingLabel.Name = "RemainingLabel"
        RemainingLabel.Size = New System.Drawing.Size(110, 25)
        RemainingLabel.TabIndex = 14
        RemainingLabel.Text = "Remaining:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        LocationLabel.Location = New System.Drawing.Point(363, 264)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(92, 25)
        LocationLabel.TabIndex = 16
        LocationLabel.Text = "Location:"
        '
        'PublishYearLabel
        '
        PublishYearLabel.AutoSize = True
        PublishYearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        PublishYearLabel.Location = New System.Drawing.Point(363, 293)
        PublishYearLabel.Name = "PublishYearLabel"
        PublishYearLabel.Size = New System.Drawing.Size(128, 25)
        PublishYearLabel.TabIndex = 18
        PublishYearLabel.Text = "Publish Year:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        TitleLabel.Location = New System.Drawing.Point(363, 320)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(55, 25)
        TitleLabel.TabIndex = 20
        TitleLabel.Text = "Title:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        AuthorLabel.Location = New System.Drawing.Point(363, 348)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(76, 25)
        AuthorLabel.TabIndex = 22
        AuthorLabel.Text = "Author:"
        '
        'PublisherLabel
        '
        PublisherLabel.AutoSize = True
        PublisherLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        PublisherLabel.Location = New System.Drawing.Point(363, 376)
        PublisherLabel.Name = "PublisherLabel"
        PublisherLabel.Size = New System.Drawing.Size(99, 25)
        PublisherLabel.TabIndex = 24
        PublisherLabel.Text = "Publisher:"
        '
        'FieldLabel
        '
        FieldLabel.AutoSize = True
        FieldLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        FieldLabel.Location = New System.Drawing.Point(363, 404)
        FieldLabel.Name = "FieldLabel"
        FieldLabel.Size = New System.Drawing.Size(60, 25)
        FieldLabel.TabIndex = 26
        FieldLabel.Text = "Field:"
        '
        'ImageLabel
        '
        ImageLabel.AutoSize = True
        ImageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        ImageLabel.Location = New System.Drawing.Point(363, 432)
        ImageLabel.Name = "ImageLabel"
        ImageLabel.Size = New System.Drawing.Size(72, 25)
        ImageLabel.TabIndex = 28
        ImageLabel.Text = "Image:"
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
        Me.ISBNTextBox1.Location = New System.Drawing.Point(545, 180)
        Me.ISBNTextBox1.Name = "ISBNTextBox1"
        Me.ISBNTextBox1.Size = New System.Drawing.Size(254, 30)
        Me.ISBNTextBox1.TabIndex = 11
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TotalTextBox.Location = New System.Drawing.Point(545, 206)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(254, 30)
        Me.TotalTextBox.TabIndex = 13
        '
        'RemainingTextBox
        '
        Me.RemainingTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RemainingTextBox.Location = New System.Drawing.Point(545, 236)
        Me.RemainingTextBox.Name = "RemainingTextBox"
        Me.RemainingTextBox.Size = New System.Drawing.Size(254, 30)
        Me.RemainingTextBox.TabIndex = 15
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LocationTextBox.Location = New System.Drawing.Point(545, 264)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(254, 30)
        Me.LocationTextBox.TabIndex = 17
        '
        'PublishYearDateTimePicker
        '
        Me.PublishYearDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PublishYearDateTimePicker.Location = New System.Drawing.Point(545, 292)
        Me.PublishYearDateTimePicker.Name = "PublishYearDateTimePicker"
        Me.PublishYearDateTimePicker.Size = New System.Drawing.Size(254, 30)
        Me.PublishYearDateTimePicker.TabIndex = 19
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TitleTextBox.Location = New System.Drawing.Point(545, 320)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(254, 30)
        Me.TitleTextBox.TabIndex = 21
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AuthorTextBox.Location = New System.Drawing.Point(545, 348)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(254, 30)
        Me.AuthorTextBox.TabIndex = 23
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PublisherTextBox.Location = New System.Drawing.Point(545, 376)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(254, 30)
        Me.PublisherTextBox.TabIndex = 25
        '
        'FieldTextBox
        '
        Me.FieldTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FieldTextBox.Location = New System.Drawing.Point(545, 404)
        Me.FieldTextBox.Name = "FieldTextBox"
        Me.FieldTextBox.Size = New System.Drawing.Size(254, 30)
        Me.FieldTextBox.TabIndex = 27
        '
        'ImageTextBox
        '
        Me.ImageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ImageTextBox.Location = New System.Drawing.Point(545, 432)
        Me.ImageTextBox.Name = "ImageTextBox"
        Me.ImageTextBox.Size = New System.Drawing.Size(254, 30)
        Me.ImageTextBox.TabIndex = 29
        '
        'myButton
        '
        Me.myButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.myButton.Location = New System.Drawing.Point(584, 524)
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
        Me.Label1.Location = New System.Drawing.Point(298, 471)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Number of books to add"
        '
        'AddNumber
        '
        Me.AddNumber.Location = New System.Drawing.Point(545, 474)
        Me.AddNumber.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.AddNumber.Name = "AddNumber"
        Me.AddNumber.Size = New System.Drawing.Size(120, 22)
        Me.AddNumber.TabIndex = 33
        '
        'addBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AddNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.myButton)
        Me.Controls.Add(ISBNLabel)
        Me.Controls.Add(Me.ISBNTextBox1)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(RemainingLabel)
        Me.Controls.Add(Me.RemainingTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(PublishYearLabel)
        Me.Controls.Add(Me.PublishYearDateTimePicker)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(AuthorLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(PublisherLabel)
        Me.Controls.Add(Me.PublisherTextBox)
        Me.Controls.Add(FieldLabel)
        Me.Controls.Add(Me.FieldTextBox)
        Me.Controls.Add(ImageLabel)
        Me.Controls.Add(Me.ImageTextBox)
        Me.Name = "addBook"
        Me.Size = New System.Drawing.Size(1133, 781)
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
    Friend WithEvents FieldTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents myButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddNumber As System.Windows.Forms.NumericUpDown

End Class
