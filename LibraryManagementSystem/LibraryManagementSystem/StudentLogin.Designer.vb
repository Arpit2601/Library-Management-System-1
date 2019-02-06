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
        Me.buttonPanel = New System.Windows.Forms.Panel()
        Me.btnEditProfile = New System.Windows.Forms.Button()
        Me.btnItemsCheckedout = New System.Windows.Forms.Button()
        Me.btnMyProfile = New System.Windows.Forms.Button()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.buttonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonPanel
        '
        Me.buttonPanel.Controls.Add(Me.btnLogout)
        Me.buttonPanel.Controls.Add(Me.btnEditProfile)
        Me.buttonPanel.Controls.Add(Me.btnItemsCheckedout)
        Me.buttonPanel.Controls.Add(Me.btnMyProfile)
        Me.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.buttonPanel.Location = New System.Drawing.Point(0, 0)
        Me.buttonPanel.Name = "buttonPanel"
        Me.buttonPanel.Size = New System.Drawing.Size(247, 681)
        Me.buttonPanel.TabIndex = 0
        '
        'btnEditProfile
        '
        Me.btnEditProfile.Location = New System.Drawing.Point(70, 156)
        Me.btnEditProfile.Name = "btnEditProfile"
        Me.btnEditProfile.Size = New System.Drawing.Size(177, 45)
        Me.btnEditProfile.TabIndex = 2
        Me.btnEditProfile.Text = "Edit Profile"
        Me.btnEditProfile.UseVisualStyleBackColor = True
        '
        'btnItemsCheckedout
        '
        Me.btnItemsCheckedout.Location = New System.Drawing.Point(65, 110)
        Me.btnItemsCheckedout.Name = "btnItemsCheckedout"
        Me.btnItemsCheckedout.Size = New System.Drawing.Size(179, 40)
        Me.btnItemsCheckedout.TabIndex = 1
        Me.btnItemsCheckedout.Text = "Items Checked Out"
        Me.btnItemsCheckedout.UseVisualStyleBackColor = True
        '
        'btnMyProfile
        '
        Me.btnMyProfile.Location = New System.Drawing.Point(70, 61)
        Me.btnMyProfile.Name = "btnMyProfile"
        Me.btnMyProfile.Size = New System.Drawing.Size(179, 43)
        Me.btnMyProfile.TabIndex = 0
        Me.btnMyProfile.Text = "My Profile"
        Me.btnMyProfile.UseVisualStyleBackColor = True
        '
        'contentPanel
        '
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.contentPanel.Location = New System.Drawing.Point(255, 0)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(1009, 681)
        Me.contentPanel.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(70, 207)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(177, 44)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'StudentLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.buttonPanel)
        Me.Controls.Add(Me.contentPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentLogin"
        Me.Text = "StudentLogin"
        Me.buttonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents buttonPanel As System.Windows.Forms.Panel
    Friend WithEvents btnItemsCheckedout As System.Windows.Forms.Button
    Friend WithEvents btnMyProfile As System.Windows.Forms.Button
    Friend WithEvents contentPanel As System.Windows.Forms.Panel
    Friend WithEvents btnEditProfile As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
