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
        Dim UserIdLabel As System.Windows.Forms.Label
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
        Me.UserIdTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.TotalFineTextBox = New System.Windows.Forms.TextBox()
        Me.MaxBooksTextBox = New System.Windows.Forms.TextBox()
        UserIdLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        DesignationLabel = New System.Windows.Forms.Label()
        TotalFineLabel = New System.Windows.Forms.Label()
        MaxBooksLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(129, 247)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(44, 13)
        UserIdLabel.TabIndex = 1
        UserIdLabel.Text = "User Id:"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(129, 273)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(63, 13)
        UserNameLabel.TabIndex = 3
        UserNameLabel.Text = "User Name:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(129, 355)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(129, 381)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 11
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(129, 407)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 13
        DepartmentLabel.Text = "Department:"
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Location = New System.Drawing.Point(129, 433)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(66, 13)
        DesignationLabel.TabIndex = 15
        DesignationLabel.Text = "Designation:"
        '
        'TotalFineLabel
        '
        TotalFineLabel.AutoSize = True
        TotalFineLabel.Location = New System.Drawing.Point(129, 459)
        TotalFineLabel.Name = "TotalFineLabel"
        TotalFineLabel.Size = New System.Drawing.Size(57, 13)
        TotalFineLabel.TabIndex = 17
        TotalFineLabel.Text = "Total Fine:"
        '
        'MaxBooksLabel
        '
        MaxBooksLabel.AutoSize = True
        MaxBooksLabel.Location = New System.Drawing.Point(129, 537)
        MaxBooksLabel.Name = "MaxBooksLabel"
        MaxBooksLabel.Size = New System.Drawing.Size(63, 13)
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
        'UserIdTextBox
        '
        Me.UserIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "UserId", True))
        Me.UserIdTextBox.Location = New System.Drawing.Point(216, 244)
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UserIdTextBox.TabIndex = 2
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(216, 270)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UserNameTextBox.TabIndex = 4
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(216, 352)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(104, 20)
        Me.EmailTextBox.TabIndex = 10
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(216, 378)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PhoneNumberTextBox.TabIndex = 12
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(216, 404)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(104, 20)
        Me.DepartmentTextBox.TabIndex = 14
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Designation", True))
        Me.DesignationTextBox.Location = New System.Drawing.Point(216, 430)
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(104, 20)
        Me.DesignationTextBox.TabIndex = 16
        '
        'TotalFineTextBox
        '
        Me.TotalFineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "TotalFine", True))
        Me.TotalFineTextBox.Location = New System.Drawing.Point(216, 456)
        Me.TotalFineTextBox.Name = "TotalFineTextBox"
        Me.TotalFineTextBox.Size = New System.Drawing.Size(104, 20)
        Me.TotalFineTextBox.TabIndex = 18
        '
        'MaxBooksTextBox
        '
        Me.MaxBooksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "MaxBooks", True))
        Me.MaxBooksTextBox.Location = New System.Drawing.Point(216, 534)
        Me.MaxBooksTextBox.Name = "MaxBooksTextBox"
        Me.MaxBooksTextBox.Size = New System.Drawing.Size(104, 20)
        Me.MaxBooksTextBox.TabIndex = 24
        '
        'StudentProfile_UserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(UserIdLabel)
        Me.Controls.Add(Me.UserIdTextBox)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(DesignationLabel)
        Me.Controls.Add(Me.DesignationTextBox)
        Me.Controls.Add(TotalFineLabel)
        Me.Controls.Add(Me.TotalFineTextBox)
        Me.Controls.Add(MaxBooksLabel)
        Me.Controls.Add(Me.MaxBooksTextBox)
        Me.Name = "StudentProfile_UserControl"
        Me.Size = New System.Drawing.Size(1079, 681)
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As LibraryManagementSystem.DatabaseDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As LibraryManagementSystem.DatabaseDataSetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As LibraryManagementSystem.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DesignationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalFineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaxBooksTextBox As System.Windows.Forms.TextBox

End Class
