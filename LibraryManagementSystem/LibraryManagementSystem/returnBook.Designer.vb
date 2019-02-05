<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class returnBook
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
        Dim AccNoLabel As System.Windows.Forms.Label
        Me.issueButton = New System.Windows.Forms.Button()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        AccNoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'issueButton
        '
        Me.issueButton.Location = New System.Drawing.Point(524, 439)
        Me.issueButton.Name = "issueButton"
        Me.issueButton.Size = New System.Drawing.Size(75, 23)
        Me.issueButton.TabIndex = 11
        Me.issueButton.Text = "Return"
        Me.issueButton.UseVisualStyleBackColor = True
        '
        'AccNoLabel
        '
        AccNoLabel.AutoSize = True
        AccNoLabel.Font = New System.Drawing.Font("Showcard Gothic", 20.0!)
        AccNoLabel.Location = New System.Drawing.Point(298, 215)
        AccNoLabel.Name = "AccNoLabel"
        AccNoLabel.Size = New System.Drawing.Size(171, 43)
        AccNoLabel.TabIndex = 7
        AccNoLabel.Text = "Book Id:"
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.AccNoTextBox.Location = New System.Drawing.Point(586, 213)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(333, 45)
        Me.AccNoTextBox.TabIndex = 8
        '
        'returnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.issueButton)
        Me.Controls.Add(AccNoLabel)
        Me.Controls.Add(Me.AccNoTextBox)
        Me.Name = "returnBook"
        Me.Size = New System.Drawing.Size(1125, 779)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents issueButton As System.Windows.Forms.Button
    Friend WithEvents AccNoTextBox As System.Windows.Forms.TextBox

End Class
