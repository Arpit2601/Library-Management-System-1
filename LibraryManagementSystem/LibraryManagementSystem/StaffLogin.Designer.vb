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
        Me.btnLogout = New System.Windows.Forms.Button()
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
        Me.Buttons.BackColor = System.Drawing.Color.MidnightBlue
        Me.Buttons.Controls.Add(Me.btnLogout)
        Me.Buttons.Controls.Add(Me.ReIssueBook)
        Me.Buttons.Controls.Add(Me.ReturnBook)
        Me.Buttons.Controls.Add(Me.IssueBook)
        Me.Buttons.Controls.Add(Me.BookButton)
        Me.Buttons.Controls.Add(Me.StudentButton)
        Me.Buttons.Dock = System.Windows.Forms.DockStyle.Left
        Me.Buttons.ForeColor = System.Drawing.Color.White
        Me.Buttons.Location = New System.Drawing.Point(0, 0)
        Me.Buttons.Margin = New System.Windows.Forms.Padding(2)
        Me.Buttons.Name = "Buttons"
        Me.Buttons.Size = New System.Drawing.Size(247, 681)
        Me.Buttons.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 261)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(247, 45)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'ReIssueBook
        '
        Me.ReIssueBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReIssueBook.FlatAppearance.BorderSize = 0
        Me.ReIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReIssueBook.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReIssueBook.Location = New System.Drawing.Point(0, 125)
        Me.ReIssueBook.Margin = New System.Windows.Forms.Padding(2)
        Me.ReIssueBook.Name = "ReIssueBook"
        Me.ReIssueBook.Size = New System.Drawing.Size(247, 45)
        Me.ReIssueBook.TabIndex = 4
        Me.ReIssueBook.Text = "ReIssue Book"
        Me.ReIssueBook.UseVisualStyleBackColor = True
        '
        'ReturnBook
        '
        Me.ReturnBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnBook.FlatAppearance.BorderSize = 0
        Me.ReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnBook.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnBook.Location = New System.Drawing.Point(0, 82)
        Me.ReturnBook.Margin = New System.Windows.Forms.Padding(2)
        Me.ReturnBook.Name = "ReturnBook"
        Me.ReturnBook.Size = New System.Drawing.Size(247, 45)
        Me.ReturnBook.TabIndex = 3
        Me.ReturnBook.Text = "Return Book"
        Me.ReturnBook.UseVisualStyleBackColor = True
        '
        'IssueBook
        '
        Me.IssueBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IssueBook.FlatAppearance.BorderSize = 0
        Me.IssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IssueBook.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IssueBook.Location = New System.Drawing.Point(0, 39)
        Me.IssueBook.Margin = New System.Windows.Forms.Padding(2)
        Me.IssueBook.Name = "IssueBook"
        Me.IssueBook.Size = New System.Drawing.Size(247, 45)
        Me.IssueBook.TabIndex = 2
        Me.IssueBook.Text = "Issue Book"
        Me.IssueBook.UseVisualStyleBackColor = True
        '
        'BookButton
        '
        Me.BookButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BookButton.FlatAppearance.BorderSize = 0
        Me.BookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookButton.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookButton.Location = New System.Drawing.Point(0, 168)
        Me.BookButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BookButton.Name = "BookButton"
        Me.BookButton.Size = New System.Drawing.Size(247, 45)
        Me.BookButton.TabIndex = 1
        Me.BookButton.Text = "Add/Modify Book"
        Me.BookButton.UseVisualStyleBackColor = True
        '
        'StudentButton
        '
        Me.StudentButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StudentButton.FlatAppearance.BorderSize = 0
        Me.StudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StudentButton.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentButton.Location = New System.Drawing.Point(0, 211)
        Me.StudentButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StudentButton.Name = "StudentButton"
        Me.StudentButton.Size = New System.Drawing.Size(247, 45)
        Me.StudentButton.TabIndex = 0
        Me.StudentButton.Text = "Add/Modify Student"
        Me.StudentButton.UseVisualStyleBackColor = True
        '
        'Action
        '
        Me.Action.Dock = System.Windows.Forms.DockStyle.Right
        Me.Action.Location = New System.Drawing.Point(247, 0)
        Me.Action.Margin = New System.Windows.Forms.Padding(2)
        Me.Action.Name = "Action"
        Me.Action.Size = New System.Drawing.Size(1017, 681)
        Me.Action.TabIndex = 1
        '
        'StaffLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Action)
        Me.Controls.Add(Me.Buttons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StaffLogin"
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
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
