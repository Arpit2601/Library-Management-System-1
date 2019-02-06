<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ISBNRadioButton = New System.Windows.Forms.RadioButton()
        Me.PublisherRadioButton = New System.Windows.Forms.RadioButton()
        Me.AuthorRadioButton = New System.Windows.Forms.RadioButton()
        Me.FieldRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TitleRadioButton = New System.Windows.Forms.RadioButton()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ISBNRadioButton)
        Me.Panel1.Controls.Add(Me.PublisherRadioButton)
        Me.Panel1.Controls.Add(Me.AuthorRadioButton)
        Me.Panel1.Controls.Add(Me.FieldRadioButton1)
        Me.Panel1.Controls.Add(Me.TitleRadioButton)
        Me.Panel1.Controls.Add(Me.SearchTextBox)
        Me.Panel1.Location = New System.Drawing.Point(26, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1209, 144)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(1018, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ISBNRadioButton
        '
        Me.ISBNRadioButton.AutoSize = True
        Me.ISBNRadioButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNRadioButton.ForeColor = System.Drawing.Color.White
        Me.ISBNRadioButton.Location = New System.Drawing.Point(844, 95)
        Me.ISBNRadioButton.Name = "ISBNRadioButton"
        Me.ISBNRadioButton.Size = New System.Drawing.Size(66, 24)
        Me.ISBNRadioButton.TabIndex = 11
        Me.ISBNRadioButton.TabStop = True
        Me.ISBNRadioButton.Text = "ISBN"
        Me.ISBNRadioButton.UseVisualStyleBackColor = True
        '
        'PublisherRadioButton
        '
        Me.PublisherRadioButton.AutoSize = True
        Me.PublisherRadioButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublisherRadioButton.ForeColor = System.Drawing.Color.White
        Me.PublisherRadioButton.Location = New System.Drawing.Point(674, 95)
        Me.PublisherRadioButton.Name = "PublisherRadioButton"
        Me.PublisherRadioButton.Size = New System.Drawing.Size(90, 24)
        Me.PublisherRadioButton.TabIndex = 10
        Me.PublisherRadioButton.TabStop = True
        Me.PublisherRadioButton.Text = "Publisher"
        Me.PublisherRadioButton.UseVisualStyleBackColor = True
        '
        'AuthorRadioButton
        '
        Me.AuthorRadioButton.AutoSize = True
        Me.AuthorRadioButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorRadioButton.ForeColor = System.Drawing.Color.White
        Me.AuthorRadioButton.Location = New System.Drawing.Point(320, 95)
        Me.AuthorRadioButton.Name = "AuthorRadioButton"
        Me.AuthorRadioButton.Size = New System.Drawing.Size(76, 24)
        Me.AuthorRadioButton.TabIndex = 9
        Me.AuthorRadioButton.TabStop = True
        Me.AuthorRadioButton.Text = "Author"
        Me.AuthorRadioButton.UseVisualStyleBackColor = True
        '
        'FieldRadioButton1
        '
        Me.FieldRadioButton1.AutoSize = True
        Me.FieldRadioButton1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FieldRadioButton1.ForeColor = System.Drawing.Color.White
        Me.FieldRadioButton1.Location = New System.Drawing.Point(474, 95)
        Me.FieldRadioButton1.Name = "FieldRadioButton1"
        Me.FieldRadioButton1.Size = New System.Drawing.Size(61, 24)
        Me.FieldRadioButton1.TabIndex = 8
        Me.FieldRadioButton1.TabStop = True
        Me.FieldRadioButton1.Text = "Field"
        Me.FieldRadioButton1.UseVisualStyleBackColor = True
        '
        'TitleRadioButton
        '
        Me.TitleRadioButton.AutoSize = True
        Me.TitleRadioButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleRadioButton.ForeColor = System.Drawing.Color.White
        Me.TitleRadioButton.Location = New System.Drawing.Point(173, 95)
        Me.TitleRadioButton.Name = "TitleRadioButton"
        Me.TitleRadioButton.Size = New System.Drawing.Size(60, 24)
        Me.TitleRadioButton.TabIndex = 7
        Me.TitleRadioButton.TabStop = True
        Me.TitleRadioButton.Text = "Title"
        Me.TitleRadioButton.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.ForeColor = System.Drawing.Color.Black
        Me.SearchTextBox.Location = New System.Drawing.Point(81, 44)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(912, 30)
        Me.SearchTextBox.TabIndex = 0
        Me.SearchTextBox.Text = "Enter Book Details"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(26, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1209, 372)
        Me.Panel2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(712, 38)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "LIBRARY MANAGEMENT SYSTEM - IIT GUWAHATI"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1136, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Exit"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.White
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LoginButton.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Image = CType(resources.GetObject("LoginButton.Image"), System.Drawing.Image)
        Me.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoginButton.Location = New System.Drawing.Point(1040, 106)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(90, 35)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Login"
        Me.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'BrowseButton
        '
        Me.BrowseButton.BackColor = System.Drawing.Color.White
        Me.BrowseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrowseButton.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseButton.Image = CType(resources.GetObject("BrowseButton.Image"), System.Drawing.Image)
        Me.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BrowseButton.Location = New System.Drawing.Point(884, 106)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(140, 35)
        Me.BrowseButton.TabIndex = 1
        Me.BrowseButton.Text = "Browse All"
        Me.BrowseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BrowseButton.UseVisualStyleBackColor = False
        '
        'MainPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "MainPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BrowseButton As System.Windows.Forms.Button
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TitleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PublisherRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AuthorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FieldRadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ISBNRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox

End Class
