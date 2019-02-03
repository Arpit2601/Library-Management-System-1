<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMyProfile = New System.Windows.Forms.Button()
        Me.btnItemsCheckedout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnItemsCheckedout)
        Me.Panel1.Controls.Add(Me.btnMyProfile)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(135, 638)
        Me.Panel1.TabIndex = 0
        '
        'btnMyProfile
        '
        Me.btnMyProfile.Location = New System.Drawing.Point(0, 0)
        Me.btnMyProfile.Name = "btnMyProfile"
        Me.btnMyProfile.Size = New System.Drawing.Size(135, 43)
        Me.btnMyProfile.TabIndex = 0
        Me.btnMyProfile.Text = "My Profile"
        Me.btnMyProfile.UseVisualStyleBackColor = True
        '
        'btnItemsCheckedout
        '
        Me.btnItemsCheckedout.Location = New System.Drawing.Point(2, 49)
        Me.btnItemsCheckedout.Name = "btnItemsCheckedout"
        Me.btnItemsCheckedout.Size = New System.Drawing.Size(133, 40)
        Me.btnItemsCheckedout.TabIndex = 1
        Me.btnItemsCheckedout.Text = "Button1"
        Me.btnItemsCheckedout.UseVisualStyleBackColor = True
        '
        'StudentLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 636)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StudentLogin"
        Me.Text = "StudentLogin"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnItemsCheckedout As System.Windows.Forms.Button
    Friend WithEvents btnMyProfile As System.Windows.Forms.Button
End Class
