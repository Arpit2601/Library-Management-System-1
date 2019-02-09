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
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Me.DatabaseDataSet = New LibraryManagementSystem.DatabaseDataSet()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New LibraryManagementSystem.DatabaseDataSetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New LibraryManagementSystem.DatabaseDataSetTableAdapters.TableAdapterManager()
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(123, 211)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 19)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        AddHandler EmailLabel.Click, AddressOf Me.EmailLabel_Click
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneNumberLabel.Location = New System.Drawing.Point(64, 244)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(104, 19)
        PhoneNumberLabel.TabIndex = 11
        PhoneNumberLabel.Text = "Phone Number:"
        AddHandler PhoneNumberLabel.Click, AddressOf Me.PhoneNumberLabel_Click
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(85, 282)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(83, 19)
        DepartmentLabel.TabIndex = 13
        DepartmentLabel.Text = "Department:"
        AddHandler DepartmentLabel.Click, AddressOf Me.DepartmentLabel_Click
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserNameLabel.Location = New System.Drawing.Point(123, 104)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(49, 19)
        UserNameLabel.TabIndex = 3
        UserNameLabel.Text = "Name:"
        AddHandler UserNameLabel.Click, AddressOf Me.UserNameLabel_Click
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
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(202, 211)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(225, 26)
        Me.EmailTextBox.TabIndex = 10
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(202, 244)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(225, 26)
        Me.PhoneNumberTextBox.TabIndex = 12
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "UserName", True))
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(202, 104)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(225, 26)
        Me.txtName.TabIndex = 4
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(202, 382)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(225, 42)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update Profile"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'picBoxProfile
        '
        Me.picBoxProfile.Location = New System.Drawing.Point(559, 104)
        Me.picBoxProfile.Name = "picBoxProfile"
        Me.picBoxProfile.Size = New System.Drawing.Size(200, 205)
        Me.picBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxProfile.TabIndex = 16
        Me.picBoxProfile.TabStop = False
        '
        'btnChangePic
        '
        Me.btnChangePic.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnChangePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePic.FlatAppearance.BorderSize = 0
        Me.btnChangePic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangePic.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePic.ForeColor = System.Drawing.Color.White
        Me.btnChangePic.Location = New System.Drawing.Point(559, 336)
        Me.btnChangePic.Name = "btnChangePic"
        Me.btnChangePic.Size = New System.Drawing.Size(200, 41)
        Me.btnChangePic.TabIndex = 17
        Me.btnChangePic.Text = "Upload Image"
        Me.btnChangePic.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
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
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Biosciences & Bioengineering", "Chemical Engineering", "Chemistry", "Civil Engineering", "Computer Science & Engg.", "Design", "Electronics & Electrical Engg.", "Humanities and Social Sciences", "Mathematics", "Mechanical Engineering", "Physics"})
        Me.ComboBox1.Location = New System.Drawing.Point(202, 282)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 27)
        Me.ComboBox1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(47, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 23)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Edit Profile"
        '
        'EditStudentProfile_UserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnChangePic)
        Me.Controls.Add(Me.picBoxProfile)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.txtName)
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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
