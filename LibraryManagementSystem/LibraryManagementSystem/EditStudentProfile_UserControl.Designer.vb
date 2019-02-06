<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStudentProfile_UserControl
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
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Me.DatabaseDataSet = New LibraryManagementSystem.DatabaseDataSet()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New LibraryManagementSystem.DatabaseDataSetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New LibraryManagementSystem.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.picBoxProfile = New System.Windows.Forms.PictureBox()
        Me.btnChangePic = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BiosciencesAndBioengineeringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChemicalEngineeringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChemistryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CivilEngineeringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputerScienceAndEnggToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HumanitiesAndSocialSciencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MathematicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MechanicjalEngineeringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhysicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDepartment = New System.Windows.Forms.Button()
        Me.lblDepartment = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(196, 197)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "Password:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(196, 253)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(196, 279)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 11
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(196, 305)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 13
        DepartmentLabel.Text = "Department:"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(196, 171)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(38, 13)
        UserNameLabel.TabIndex = 3
        UserNameLabel.Text = "Name:"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.DatabaseDataSet
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Nothing
        Me.TableAdapterManager.BorrowedTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LibraryManagementSystem.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Password", True))
        Me.txtPassword.Location = New System.Drawing.Point(283, 194)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(104, 20)
        Me.txtPassword.TabIndex = 6
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(283, 250)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(104, 20)
        Me.EmailTextBox.TabIndex = 10
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(283, 276)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PhoneNumberTextBox.TabIndex = 12
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "UserName", True))
        Me.txtName.Location = New System.Drawing.Point(283, 168)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(104, 20)
        Me.txtName.TabIndex = 4
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(260, 405)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(190, 42)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update Profile"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'picBoxProfile
        '
        Me.picBoxProfile.Location = New System.Drawing.Point(591, 155)
        Me.picBoxProfile.Name = "picBoxProfile"
        Me.picBoxProfile.Size = New System.Drawing.Size(163, 195)
        Me.picBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxProfile.TabIndex = 16
        Me.picBoxProfile.TabStop = False
        '
        'btnChangePic
        '
        Me.btnChangePic.Location = New System.Drawing.Point(601, 395)
        Me.btnChangePic.Name = "btnChangePic"
        Me.btnChangePic.Size = New System.Drawing.Size(121, 41)
        Me.btnChangePic.TabIndex = 17
        Me.btnChangePic.Text = "Upload Image"
        Me.btnChangePic.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BiosciencesAndBioengineeringToolStripMenuItem, Me.ChemicalEngineeringToolStripMenuItem, Me.ChemistryToolStripMenuItem, Me.CivilEngineeringToolStripMenuItem, Me.ComputerScienceAndEnggToolStripMenuItem, Me.HumanitiesAndSocialSciencesToolStripMenuItem, Me.MathematicsToolStripMenuItem, Me.MechanicjalEngineeringToolStripMenuItem, Me.PhysicsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(242, 202)
        '
        'BiosciencesAndBioengineeringToolStripMenuItem
        '
        Me.BiosciencesAndBioengineeringToolStripMenuItem.Name = "BiosciencesAndBioengineeringToolStripMenuItem"
        Me.BiosciencesAndBioengineeringToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.BiosciencesAndBioengineeringToolStripMenuItem.Text = "Biosciences and Bioengineering"
        '
        'ChemicalEngineeringToolStripMenuItem
        '
        Me.ChemicalEngineeringToolStripMenuItem.Name = "ChemicalEngineeringToolStripMenuItem"
        Me.ChemicalEngineeringToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ChemicalEngineeringToolStripMenuItem.Text = "Chemical Engineering"
        '
        'ChemistryToolStripMenuItem
        '
        Me.ChemistryToolStripMenuItem.Name = "ChemistryToolStripMenuItem"
        Me.ChemistryToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ChemistryToolStripMenuItem.Text = "Chemistry"
        '
        'CivilEngineeringToolStripMenuItem
        '
        Me.CivilEngineeringToolStripMenuItem.Name = "CivilEngineeringToolStripMenuItem"
        Me.CivilEngineeringToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.CivilEngineeringToolStripMenuItem.Text = "Civil Engineering"
        '
        'ComputerScienceAndEnggToolStripMenuItem
        '
        Me.ComputerScienceAndEnggToolStripMenuItem.Name = "ComputerScienceAndEnggToolStripMenuItem"
        Me.ComputerScienceAndEnggToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ComputerScienceAndEnggToolStripMenuItem.Text = "Computer Science and Engg"
        '
        'HumanitiesAndSocialSciencesToolStripMenuItem
        '
        Me.HumanitiesAndSocialSciencesToolStripMenuItem.Name = "HumanitiesAndSocialSciencesToolStripMenuItem"
        Me.HumanitiesAndSocialSciencesToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.HumanitiesAndSocialSciencesToolStripMenuItem.Text = "Humanities and Social Sciences"
        '
        'MathematicsToolStripMenuItem
        '
        Me.MathematicsToolStripMenuItem.Name = "MathematicsToolStripMenuItem"
        Me.MathematicsToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.MathematicsToolStripMenuItem.Text = "Mathematics"
        '
        'MechanicjalEngineeringToolStripMenuItem
        '
        Me.MechanicjalEngineeringToolStripMenuItem.Name = "MechanicjalEngineeringToolStripMenuItem"
        Me.MechanicjalEngineeringToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.MechanicjalEngineeringToolStripMenuItem.Text = "Mechanical Engineering"
        '
        'PhysicsToolStripMenuItem
        '
        Me.PhysicsToolStripMenuItem.Name = "PhysicsToolStripMenuItem"
        Me.PhysicsToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.PhysicsToolStripMenuItem.Text = "Physics"
        '
        'btnDepartment
        '
        Me.btnDepartment.Location = New System.Drawing.Point(392, 305)
        Me.btnDepartment.Name = "btnDepartment"
        Me.btnDepartment.Size = New System.Drawing.Size(23, 22)
        Me.btnDepartment.TabIndex = 18
        Me.btnDepartment.UseVisualStyleBackColor = True
        '
        'lblDepartment
        '
        Me.lblDepartment.Location = New System.Drawing.Point(287, 310)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(99, 27)
        Me.lblDepartment.TabIndex = 19
        Me.lblDepartment.Text = "Label1"
        '
        'EditStudentProfile_UserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.btnDepartment)
        Me.Controls.Add(Me.btnChangePic)
        Me.Controls.Add(Me.picBoxProfile)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Name = "EditStudentProfile_UserControl"
        Me.Size = New System.Drawing.Size(1079, 681)
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As LibraryManagementSystem.DatabaseDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As LibraryManagementSystem.DatabaseDataSetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As LibraryManagementSystem.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents picBoxProfile As System.Windows.Forms.PictureBox
    Friend WithEvents btnChangePic As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BiosciencesAndBioengineeringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChemicalEngineeringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChemistryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CivilEngineeringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputerScienceAndEnggToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HumanitiesAndSocialSciencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MathematicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MechanicjalEngineeringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhysicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDepartment As System.Windows.Forms.Button
    Friend WithEvents lblDepartment As System.Windows.Forms.Label

End Class
