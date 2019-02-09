<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentProfile_UserControl
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
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim DesignationLabel As System.Windows.Forms.Label
        Dim TotalFineLabel As System.Windows.Forms.Label
        Dim MaxBooksLabel As System.Windows.Forms.Label
        Me.DatabaseDataSet = New LibraryManagementSystem.DatabaseDataSet()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New LibraryManagementSystem.DatabaseDataSetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New LibraryManagementSystem.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.picBoxProfile = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblDesignation = New System.Windows.Forms.Label()
        Me.lblFine = New System.Windows.Forms.Label()
        Me.lblMaxBooks = New System.Windows.Forms.Label()
        Me.lblWelcome2 = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        DesignationLabel = New System.Windows.Forms.Label()
        TotalFineLabel = New System.Windows.Forms.Label()
        MaxBooksLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserNameLabel.Location = New System.Drawing.Point(128, 128)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(73, 19)
        UserNameLabel.TabIndex = 3
        UserNameLabel.Text = "Username:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(156, 161)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 19)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneNumberLabel.Location = New System.Drawing.Point(97, 196)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(104, 19)
        PhoneNumberLabel.TabIndex = 11
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(118, 233)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(83, 19)
        DepartmentLabel.TabIndex = 13
        DepartmentLabel.Text = "Department:"
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesignationLabel.Location = New System.Drawing.Point(119, 267)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(82, 19)
        DesignationLabel.TabIndex = 15
        DesignationLabel.Text = "Designation:"
        '
        'TotalFineLabel
        '
        TotalFineLabel.AutoSize = True
        TotalFineLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalFineLabel.Location = New System.Drawing.Point(129, 310)
        TotalFineLabel.Name = "TotalFineLabel"
        TotalFineLabel.Size = New System.Drawing.Size(72, 19)
        TotalFineLabel.TabIndex = 17
        TotalFineLabel.Text = "Total Fine:"

        '
        'MaxBooksLabel
        '
        MaxBooksLabel.AutoSize = True
        MaxBooksLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MaxBooksLabel.Location = New System.Drawing.Point(117, 346)
        MaxBooksLabel.Name = "MaxBooksLabel"
        MaxBooksLabel.Size = New System.Drawing.Size(84, 19)
        MaxBooksLabel.TabIndex = 23
        MaxBooksLabel.Text = "Max Books:"
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
        'picBoxProfile
        '
        Me.picBoxProfile.Location = New System.Drawing.Point(600, 128)
        Me.picBoxProfile.Name = "picBoxProfile"
        Me.picBoxProfile.Size = New System.Drawing.Size(191, 225)
        Me.picBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxProfile.TabIndex = 25
        Me.picBoxProfile.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.Location = New System.Drawing.Point(28, 21)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1021, 40)
        Me.lblWelcome.TabIndex = 26
        Me.lblWelcome.Text = "Label1"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(212, 128)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(51, 19)
        Me.lblUsername.TabIndex = 28
        Me.lblUsername.Text = "Label2"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(212, 161)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(51, 19)
        Me.lblEmail.TabIndex = 30
        Me.lblEmail.Text = "Label4"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(212, 196)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(51, 19)
        Me.lblPhone.TabIndex = 31
        Me.lblPhone.Text = "Label5"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(212, 233)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(51, 19)
        Me.lblDepartment.TabIndex = 32
        Me.lblDepartment.Text = "Label6"
        '
        'lblDesignation
        '
        Me.lblDesignation.AutoSize = True
        Me.lblDesignation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignation.Location = New System.Drawing.Point(212, 267)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(51, 19)
        Me.lblDesignation.TabIndex = 33
        Me.lblDesignation.Text = "Label7"
        '
        'lblFine
        '
        Me.lblFine.AutoSize = True
        Me.lblFine.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFine.Location = New System.Drawing.Point(212, 310)
        Me.lblFine.Name = "lblFine"
        Me.lblFine.Size = New System.Drawing.Size(51, 19)
        Me.lblFine.TabIndex = 34
        Me.lblFine.Text = "Label8"
        '
        'lblMaxBooks
        '
        Me.lblMaxBooks.AutoSize = True
        Me.lblMaxBooks.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxBooks.Location = New System.Drawing.Point(212, 346)
        Me.lblMaxBooks.Name = "lblMaxBooks"
        Me.lblMaxBooks.Size = New System.Drawing.Size(51, 19)
        Me.lblMaxBooks.TabIndex = 35
        Me.lblMaxBooks.Text = "Label9"
        '
        'lblWelcome2
        '
        Me.lblWelcome2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome2.ForeColor = System.Drawing.Color.Red
        Me.lblWelcome2.Location = New System.Drawing.Point(28, 22)
        Me.lblWelcome2.Name = "lblWelcome2"
        Me.lblWelcome2.Size = New System.Drawing.Size(950, 39)
        Me.lblWelcome2.TabIndex = 36
        Me.lblWelcome2.Text = "Label1"
        Me.lblWelcome2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StudentProfile_UserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblWelcome2)
        Me.Controls.Add(Me.lblMaxBooks)
        Me.Controls.Add(Me.lblFine)
        Me.Controls.Add(Me.lblDesignation)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.picBoxProfile)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(DesignationLabel)
        Me.Controls.Add(TotalFineLabel)
        Me.Controls.Add(MaxBooksLabel)
        Me.Name = "StudentProfile_UserControl"
        Me.Size = New System.Drawing.Size(1011, 681)
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As LibraryManagementSystem.DatabaseDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As LibraryManagementSystem.DatabaseDataSetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As LibraryManagementSystem.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents picBoxProfile As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblDesignation As System.Windows.Forms.Label
    Friend WithEvents lblFine As System.Windows.Forms.Label
    Friend WithEvents lblMaxBooks As System.Windows.Forms.Label
    Friend WithEvents lblWelcome2 As System.Windows.Forms.Label

End Class
