<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class issuebook
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
        Me.AccNoLabel = New System.Windows.Forms.Label()
        Me.BorrowerIdLabel = New System.Windows.Forms.Label()
        Me.issueButton = New System.Windows.Forms.Button()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerIdTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AccNoLabel
        '
        Me.AccNoLabel.AutoSize = True
        Me.AccNoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccNoLabel.Location = New System.Drawing.Point(129, 71)
        Me.AccNoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AccNoLabel.Name = "AccNoLabel"
        Me.AccNoLabel.Size = New System.Drawing.Size(63, 19)
        Me.AccNoLabel.TabIndex = 5
        Me.AccNoLabel.Text = "Book Id:"
        '
        'BorrowerIdLabel
        '
        Me.BorrowerIdLabel.AutoSize = True
        Me.BorrowerIdLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowerIdLabel.Location = New System.Drawing.Point(56, 110)
        Me.BorrowerIdLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BorrowerIdLabel.Name = "BorrowerIdLabel"
        Me.BorrowerIdLabel.Size = New System.Drawing.Size(136, 19)
        Me.BorrowerIdLabel.TabIndex = 7
        Me.BorrowerIdLabel.Text = "Borrower Username:"
        '
        'issueButton
        '
        Me.issueButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.issueButton.FlatAppearance.BorderSize = 0
        Me.issueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.issueButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issueButton.ForeColor = System.Drawing.Color.White
        Me.issueButton.Location = New System.Drawing.Point(590, 87)
        Me.issueButton.Margin = New System.Windows.Forms.Padding(2)
        Me.issueButton.Name = "issueButton"
        Me.issueButton.Size = New System.Drawing.Size(225, 42)
        Me.issueButton.TabIndex = 9
        Me.issueButton.Text = "Issue"
        Me.issueButton.UseVisualStyleBackColor = False
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccNoTextBox.Location = New System.Drawing.Point(227, 71)
        Me.AccNoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(251, 26)
        Me.AccNoTextBox.TabIndex = 6
        '
        'BorrowerIdTextBox
        '
        Me.BorrowerIdTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowerIdTextBox.Location = New System.Drawing.Point(227, 110)
        Me.BorrowerIdTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BorrowerIdTextBox.Name = "BorrowerIdTextBox"
        Me.BorrowerIdTextBox.Size = New System.Drawing.Size(251, 26)
        Me.BorrowerIdTextBox.TabIndex = 8
        '
        'issuebook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.issueButton)
        Me.Controls.Add(Me.AccNoLabel)
        Me.Controls.Add(Me.AccNoTextBox)
        Me.Controls.Add(Me.BorrowerIdLabel)
        Me.Controls.Add(Me.BorrowerIdTextBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "issuebook"
        Me.Size = New System.Drawing.Size(1017, 227)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents issueButton As System.Windows.Forms.Button
    Friend WithEvents AccNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BorrowerIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccNoLabel As System.Windows.Forms.Label
    Friend WithEvents BorrowerIdLabel As System.Windows.Forms.Label

End Class
