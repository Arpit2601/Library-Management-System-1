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
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ISBNRadioButton = New System.Windows.Forms.RadioButton()
        Me.PublisherRadioButton = New System.Windows.Forms.RadioButton()
        Me.AuthorRadioButton = New System.Windows.Forms.RadioButton()
        Me.FieldRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TitleRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(42, 30)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(217, 42)
        Me.BrowseButton.TabIndex = 1
        Me.BrowseButton.Text = "Browse All"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(970, 30)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(129, 42)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ISBNRadioButton)
        Me.Panel1.Controls.Add(Me.PublisherRadioButton)
        Me.Panel1.Controls.Add(Me.AuthorRadioButton)
        Me.Panel1.Controls.Add(Me.FieldRadioButton1)
        Me.Panel1.Controls.Add(Me.TitleRadioButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.SearchTextBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1243, 151)
        Me.Panel1.TabIndex = 3
        '
        'ISBNRadioButton
        '
        Me.ISBNRadioButton.AutoSize = True
        Me.ISBNRadioButton.Location = New System.Drawing.Point(985, 108)
        Me.ISBNRadioButton.Name = "ISBNRadioButton"
        Me.ISBNRadioButton.Size = New System.Drawing.Size(50, 17)
        Me.ISBNRadioButton.TabIndex = 11
        Me.ISBNRadioButton.TabStop = True
        Me.ISBNRadioButton.Text = "ISBN"
        Me.ISBNRadioButton.UseVisualStyleBackColor = True
        '
        'PublisherRadioButton
        '
        Me.PublisherRadioButton.AutoSize = True
        Me.PublisherRadioButton.Location = New System.Drawing.Point(815, 108)
        Me.PublisherRadioButton.Name = "PublisherRadioButton"
        Me.PublisherRadioButton.Size = New System.Drawing.Size(70, 17)
        Me.PublisherRadioButton.TabIndex = 10
        Me.PublisherRadioButton.TabStop = True
        Me.PublisherRadioButton.Text = "Publilsher"
        Me.PublisherRadioButton.UseVisualStyleBackColor = True
        '
        'AuthorRadioButton
        '
        Me.AuthorRadioButton.AutoSize = True
        Me.AuthorRadioButton.Location = New System.Drawing.Point(461, 108)
        Me.AuthorRadioButton.Name = "AuthorRadioButton"
        Me.AuthorRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.AuthorRadioButton.TabIndex = 9
        Me.AuthorRadioButton.TabStop = True
        Me.AuthorRadioButton.Text = "Author"
        Me.AuthorRadioButton.UseVisualStyleBackColor = True
        '
        'FieldRadioButton1
        '
        Me.FieldRadioButton1.AutoSize = True
        Me.FieldRadioButton1.Location = New System.Drawing.Point(615, 108)
        Me.FieldRadioButton1.Name = "FieldRadioButton1"
        Me.FieldRadioButton1.Size = New System.Drawing.Size(47, 17)
        Me.FieldRadioButton1.TabIndex = 8
        Me.FieldRadioButton1.TabStop = True
        Me.FieldRadioButton1.Text = "Field"
        Me.FieldRadioButton1.UseVisualStyleBackColor = True
        '
        'TitleRadioButton
        '
        Me.TitleRadioButton.AutoSize = True
        Me.TitleRadioButton.Location = New System.Drawing.Point(314, 108)
        Me.TitleRadioButton.Name = "TitleRadioButton"
        Me.TitleRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.TitleRadioButton.TabIndex = 7
        Me.TitleRadioButton.TabStop = True
        Me.TitleRadioButton.Text = "Title"
        Me.TitleRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(314, 27)
        Me.SearchTextBox.Multiline = True
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(742, 34)
        Me.SearchTextBox.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Location = New System.Drawing.Point(12, 273)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1242, 329)
        Me.Panel2.TabIndex = 4
        '
        'MainPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.BrowseButton)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "MainPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BrowseButton As System.Windows.Forms.Button
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PublisherRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AuthorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FieldRadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ISBNRadioButton As System.Windows.Forms.RadioButton

End Class
