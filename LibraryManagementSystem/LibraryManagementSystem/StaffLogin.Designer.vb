<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffLogin
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
        Me.Buttons = New System.Windows.Forms.Panel()
        Me.ReIssueBook = New System.Windows.Forms.Button()
        Me.ReturnBook = New System.Windows.Forms.Button()
        Me.IssueBook = New System.Windows.Forms.Button()
        Me.BookButton = New System.Windows.Forms.Button()
        Me.StudentButton = New System.Windows.Forms.Button()
        Me.Action = New System.Windows.Forms.Panel()
        Me.Buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'Buttons
        '
        Me.Buttons.Controls.Add(Me.ReIssueBook)
        Me.Buttons.Controls.Add(Me.ReturnBook)
        Me.Buttons.Controls.Add(Me.IssueBook)
        Me.Buttons.Controls.Add(Me.BookButton)
        Me.Buttons.Controls.Add(Me.StudentButton)
        Me.Buttons.Location = New System.Drawing.Point(2, 0)
        Me.Buttons.Name = "Buttons"
        Me.Buttons.Size = New System.Drawing.Size(230, 735)
        Me.Buttons.TabIndex = 0
        '
        'ReIssueBook
        '
        Me.ReIssueBook.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold)
        Me.ReIssueBook.Location = New System.Drawing.Point(0, 205)
        Me.ReIssueBook.Name = "ReIssueBook"
        Me.ReIssueBook.Size = New System.Drawing.Size(230, 95)
        Me.ReIssueBook.TabIndex = 4
        Me.ReIssueBook.Text = "ReIssue Book"
        Me.ReIssueBook.UseVisualStyleBackColor = True
        '
        'ReturnBook
        '
        Me.ReturnBook.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold)
        Me.ReturnBook.Location = New System.Drawing.Point(0, 104)
        Me.ReturnBook.Name = "ReturnBook"
        Me.ReturnBook.Size = New System.Drawing.Size(230, 95)
        Me.ReturnBook.TabIndex = 3
        Me.ReturnBook.Text = "Return Book"
        Me.ReturnBook.UseVisualStyleBackColor = True
        '
        'IssueBook
        '
        Me.IssueBook.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IssueBook.Location = New System.Drawing.Point(0, 3)
        Me.IssueBook.Name = "IssueBook"
        Me.IssueBook.Size = New System.Drawing.Size(230, 95)
        Me.IssueBook.TabIndex = 2
        Me.IssueBook.Text = "Issue Book"
        Me.IssueBook.UseVisualStyleBackColor = True
        '
        'BookButton
        '
        Me.BookButton.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BookButton.Location = New System.Drawing.Point(0, 306)
        Me.BookButton.Name = "BookButton"
        Me.BookButton.Size = New System.Drawing.Size(230, 95)
        Me.BookButton.TabIndex = 1
        Me.BookButton.Text = "Add/Modify Book"
        Me.BookButton.UseVisualStyleBackColor = True
        '
        'StudentButton
        '
        Me.StudentButton.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold)
        Me.StudentButton.Location = New System.Drawing.Point(0, 407)
        Me.StudentButton.Name = "StudentButton"
        Me.StudentButton.Size = New System.Drawing.Size(230, 95)
        Me.StudentButton.TabIndex = 0
        Me.StudentButton.Text = "Add/Modify Student"
        Me.StudentButton.UseVisualStyleBackColor = True
        '
        'Action
        '
        Me.Action.Location = New System.Drawing.Point(238, 0)
        Me.Action.Name = "Action"
        Me.Action.Size = New System.Drawing.Size(880, 735)
        Me.Action.TabIndex = 1
        '
        'testing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 733)
        Me.Controls.Add(Me.Action)
        Me.Controls.Add(Me.Buttons)
        Me.Name = "testing"
        Me.Text = "testing"
        Me.Buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Buttons As System.Windows.Forms.Panel
    Friend WithEvents StudentButton As System.Windows.Forms.Button
    Friend WithEvents Action As System.Windows.Forms.Panel
    Friend WithEvents IssueBook As System.Windows.Forms.Button
    Friend WithEvents BookButton As System.Windows.Forms.Button
    Friend WithEvents ReturnBook As System.Windows.Forms.Button
    Friend WithEvents ReIssueBook As System.Windows.Forms.Button
End Class
