<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reissuebook
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
        Dim AccNoLabel As System.Windows.Forms.Label
        Dim BorrowerIdLabel As System.Windows.Forms.Label
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerIdTextBox = New System.Windows.Forms.TextBox()
        Me.issueButton = New System.Windows.Forms.Button()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        AccNoLabel = New System.Windows.Forms.Label()
        BorrowerIdLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AccNoLabel
        '
        AccNoLabel.AutoSize = True
        AccNoLabel.Font = New System.Drawing.Font("Showcard Gothic", 20.0!)
        AccNoLabel.Location = New System.Drawing.Point(185, 192)
        AccNoLabel.Name = "AccNoLabel"
        AccNoLabel.Size = New System.Drawing.Size(171, 43)
        AccNoLabel.TabIndex = 0
        AccNoLabel.Text = "Book Id:"
        '
        'BorrowerIdLabel
        '
        BorrowerIdLabel.AutoSize = True
        BorrowerIdLabel.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BorrowerIdLabel.Location = New System.Drawing.Point(93, 314)
        BorrowerIdLabel.Name = "BorrowerIdLabel"
        BorrowerIdLabel.Size = New System.Drawing.Size(263, 42)
        BorrowerIdLabel.TabIndex = 2
        BorrowerIdLabel.Text = "Borrower Id:"

        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.AccNoTextBox.Location = New System.Drawing.Point(473, 190)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(333, 45)
        Me.AccNoTextBox.TabIndex = 1
        '
        'BorrowerIdTextBox
        '
        Me.BorrowerIdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BorrowerIdTextBox.Location = New System.Drawing.Point(473, 315)
        Me.BorrowerIdTextBox.Name = "BorrowerIdTextBox"
        Me.BorrowerIdTextBox.Size = New System.Drawing.Size(333, 45)
        Me.BorrowerIdTextBox.TabIndex = 3
        '
        'issueButton
        '
        Me.issueButton.Location = New System.Drawing.Point(453, 459)
        Me.issueButton.Name = "issueButton"
        Me.issueButton.Size = New System.Drawing.Size(75, 23)
        Me.issueButton.TabIndex = 4
        Me.issueButton.Text = "Issue"
        Me.issueButton.UseVisualStyleBackColor = True
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.Location = New System.Drawing.Point(100, 521)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ISBNTextBox.TabIndex = 6
        '
        'issuebook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(Me.issueButton)
        Me.Controls.Add(AccNoLabel)
        Me.Controls.Add(Me.AccNoTextBox)
        Me.Controls.Add(BorrowerIdLabel)
        Me.Controls.Add(Me.BorrowerIdTextBox)
        Me.Name = "issuebook"
        Me.Size = New System.Drawing.Size(1040, 699)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BorrowerIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents issueButton As System.Windows.Forms.Button
    Friend WithEvents ISBNTextBox As System.Windows.Forms.TextBox

End Class
