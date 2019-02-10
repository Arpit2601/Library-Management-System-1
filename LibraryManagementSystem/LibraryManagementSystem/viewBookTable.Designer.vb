<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewBookTable
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
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim BorrowerIdLabel As System.Windows.Forms.Label
        Dim IssueDateLabel As System.Windows.Forms.Label
        Dim ReturnDateLabel As System.Windows.Forms.Label
        Dim IsIssuedLabel As System.Windows.Forms.Label
        Dim FineLabel As System.Windows.Forms.Label
        Dim IssueCountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewBookTable))
        Me.DatabaseDataSet1 = New LibraryManagementSystem.DatabaseDataSet1()
        Me.BorrowedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BorrowedTableAdapter = New LibraryManagementSystem.DatabaseDataSet1TableAdapters.BorrowedTableAdapter()
        Me.TableAdapterManager = New LibraryManagementSystem.DatabaseDataSet1TableAdapters.TableAdapterManager()
        Me.BorrowedBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerIdTextBox = New System.Windows.Forms.TextBox()
        Me.IssueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReturnDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IsIssuedCheckBox = New System.Windows.Forms.CheckBox()
        Me.FineTextBox = New System.Windows.Forms.TextBox()
        Me.IssueCountTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BorrowedBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BorrowedDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        AccNoLabel = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        BorrowerIdLabel = New System.Windows.Forms.Label()
        IssueDateLabel = New System.Windows.Forms.Label()
        ReturnDateLabel = New System.Windows.Forms.Label()
        IsIssuedLabel = New System.Windows.Forms.Label()
        FineLabel = New System.Windows.Forms.Label()
        IssueCountLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowedBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BorrowedBindingNavigator.SuspendLayout()
        CType(Me.BorrowedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "DatabaseDataSet1"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BorrowedBindingSource
        '
        Me.BorrowedBindingSource.DataMember = "Borrowed"
        Me.BorrowedBindingSource.DataSource = Me.DatabaseDataSet1
        '
        'BorrowedTableAdapter
        '
        Me.BorrowedTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Nothing
        Me.TableAdapterManager.BorrowedTableAdapter = Me.BorrowedTableAdapter
        Me.TableAdapterManager.UpdateOrder = LibraryManagementSystem.DatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'BorrowedBindingNavigator
        '
        Me.BorrowedBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BorrowedBindingNavigator.BindingSource = Me.BorrowedBindingSource
        Me.BorrowedBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BorrowedBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BorrowedBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BorrowedBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BorrowedBindingNavigatorSaveItem})
        Me.BorrowedBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BorrowedBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BorrowedBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BorrowedBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BorrowedBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BorrowedBindingNavigator.Name = "BorrowedBindingNavigator"
        Me.BorrowedBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BorrowedBindingNavigator.Size = New System.Drawing.Size(1356, 27)
        Me.BorrowedBindingNavigator.TabIndex = 0
        Me.BorrowedBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'AccNoLabel
        '
        AccNoLabel.AutoSize = True
        AccNoLabel.Location = New System.Drawing.Point(60, 221)
        AccNoLabel.Name = "AccNoLabel"
        AccNoLabel.Size = New System.Drawing.Size(57, 17)
        AccNoLabel.TabIndex = 1
        AccNoLabel.Text = "Acc No:"
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowedBindingSource, "AccNo", True))
        Me.AccNoTextBox.Location = New System.Drawing.Point(155, 218)
        Me.AccNoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(150, 22)
        Me.AccNoTextBox.TabIndex = 2
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(60, 249)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(43, 17)
        ISBNLabel.TabIndex = 3
        ISBNLabel.Text = "ISBN:"
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowedBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(155, 246)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(150, 22)
        Me.ISBNTextBox.TabIndex = 4
        '
        'BorrowerIdLabel
        '
        BorrowerIdLabel.AutoSize = True
        BorrowerIdLabel.Location = New System.Drawing.Point(60, 277)
        BorrowerIdLabel.Name = "BorrowerIdLabel"
        BorrowerIdLabel.Size = New System.Drawing.Size(84, 17)
        BorrowerIdLabel.TabIndex = 5
        BorrowerIdLabel.Text = "Borrower Id:"
        '
        'BorrowerIdTextBox
        '
        Me.BorrowerIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowedBindingSource, "BorrowerId", True))
        Me.BorrowerIdTextBox.Location = New System.Drawing.Point(155, 274)
        Me.BorrowerIdTextBox.Name = "BorrowerIdTextBox"
        Me.BorrowerIdTextBox.Size = New System.Drawing.Size(150, 22)
        Me.BorrowerIdTextBox.TabIndex = 6
        '
        'IssueDateLabel
        '
        IssueDateLabel.AutoSize = True
        IssueDateLabel.Location = New System.Drawing.Point(60, 306)
        IssueDateLabel.Name = "IssueDateLabel"
        IssueDateLabel.Size = New System.Drawing.Size(79, 17)
        IssueDateLabel.TabIndex = 7
        IssueDateLabel.Text = "Issue Date:"
        '
        'IssueDateDateTimePicker
        '
        Me.IssueDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BorrowedBindingSource, "IssueDate", True))
        Me.IssueDateDateTimePicker.Location = New System.Drawing.Point(155, 306)
        Me.IssueDateDateTimePicker.Name = "IssueDateDateTimePicker"
        Me.IssueDateDateTimePicker.Size = New System.Drawing.Size(150, 22)
        Me.IssueDateDateTimePicker.TabIndex = 8
        '
        'ReturnDateLabel
        '
        ReturnDateLabel.AutoSize = True
        ReturnDateLabel.Location = New System.Drawing.Point(60, 334)
        ReturnDateLabel.Name = "ReturnDateLabel"
        ReturnDateLabel.Size = New System.Drawing.Size(89, 17)
        ReturnDateLabel.TabIndex = 9
        ReturnDateLabel.Text = "Return Date:"
        '
        'ReturnDateDateTimePicker
        '
        Me.ReturnDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BorrowedBindingSource, "ReturnDate", True))
        Me.ReturnDateDateTimePicker.Location = New System.Drawing.Point(155, 352)
        Me.ReturnDateDateTimePicker.Name = "ReturnDateDateTimePicker"
        Me.ReturnDateDateTimePicker.Size = New System.Drawing.Size(150, 22)
        Me.ReturnDateDateTimePicker.TabIndex = 10
        '
        'IsIssuedLabel
        '
        IsIssuedLabel.AutoSize = True
        IsIssuedLabel.Location = New System.Drawing.Point(60, 382)
        IsIssuedLabel.Name = "IsIssuedLabel"
        IsIssuedLabel.Size = New System.Drawing.Size(67, 17)
        IsIssuedLabel.TabIndex = 11
        IsIssuedLabel.Text = "Is Issued:"
        '
        'IsIssuedCheckBox
        '
        Me.IsIssuedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BorrowedBindingSource, "IsIssued", True))
        Me.IsIssuedCheckBox.Location = New System.Drawing.Point(152, 380)
        Me.IsIssuedCheckBox.Name = "IsIssuedCheckBox"
        Me.IsIssuedCheckBox.Size = New System.Drawing.Size(153, 22)
        Me.IsIssuedCheckBox.TabIndex = 12
        Me.IsIssuedCheckBox.Text = "CheckBox1"
        Me.IsIssuedCheckBox.UseVisualStyleBackColor = True
        '
        'FineLabel
        '
        FineLabel.AutoSize = True
        FineLabel.Location = New System.Drawing.Point(64, 412)
        FineLabel.Name = "FineLabel"
        FineLabel.Size = New System.Drawing.Size(39, 17)
        FineLabel.TabIndex = 13
        FineLabel.Text = "Fine:"
        '
        'FineTextBox
        '
        Me.FineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowedBindingSource, "Fine", True))
        Me.FineTextBox.Location = New System.Drawing.Point(152, 412)
        Me.FineTextBox.Name = "FineTextBox"
        Me.FineTextBox.Size = New System.Drawing.Size(150, 22)
        Me.FineTextBox.TabIndex = 14
        '
        'IssueCountLabel
        '
        IssueCountLabel.AutoSize = True
        IssueCountLabel.Location = New System.Drawing.Point(60, 440)
        IssueCountLabel.Name = "IssueCountLabel"
        IssueCountLabel.Size = New System.Drawing.Size(86, 17)
        IssueCountLabel.TabIndex = 15
        IssueCountLabel.Text = "Issue Count:"
        '
        'IssueCountTextBox
        '
        Me.IssueCountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowedBindingSource, "IssueCount", True))
        Me.IssueCountTextBox.Location = New System.Drawing.Point(155, 440)
        Me.IssueCountTextBox.Name = "IssueCountTextBox"
        Me.IssueCountTextBox.Size = New System.Drawing.Size(150, 22)
        Me.IssueCountTextBox.TabIndex = 16
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BorrowedBindingNavigatorSaveItem
        '
        Me.BorrowedBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BorrowedBindingNavigatorSaveItem.Image = CType(resources.GetObject("BorrowedBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BorrowedBindingNavigatorSaveItem.Name = "BorrowedBindingNavigatorSaveItem"
        Me.BorrowedBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.BorrowedBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BorrowedDataGridView
        '
        Me.BorrowedDataGridView.AutoGenerateColumns = False
        Me.BorrowedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.BorrowedDataGridView.DataSource = Me.BorrowedBindingSource
        Me.BorrowedDataGridView.Location = New System.Drawing.Point(388, 115)
        Me.BorrowedDataGridView.Name = "BorrowedDataGridView"
        Me.BorrowedDataGridView.RowTemplate.Height = 24
        Me.BorrowedDataGridView.Size = New System.Drawing.Size(842, 605)
        Me.BorrowedDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AccNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AccNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ISBN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ISBN"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BorrowerId"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BorrowerId"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IssueDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IssueDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ReturnDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ReturnDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "IsIssued"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "IsIssued"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Fine"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fine"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IssueCount"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IssueCount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'viewBookTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BorrowedDataGridView)
        Me.Controls.Add(AccNoLabel)
        Me.Controls.Add(Me.AccNoTextBox)
        Me.Controls.Add(ISBNLabel)
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(BorrowerIdLabel)
        Me.Controls.Add(Me.BorrowerIdTextBox)
        Me.Controls.Add(IssueDateLabel)
        Me.Controls.Add(Me.IssueDateDateTimePicker)
        Me.Controls.Add(ReturnDateLabel)
        Me.Controls.Add(Me.ReturnDateDateTimePicker)
        Me.Controls.Add(IsIssuedLabel)
        Me.Controls.Add(Me.IsIssuedCheckBox)
        Me.Controls.Add(FineLabel)
        Me.Controls.Add(Me.FineTextBox)
        Me.Controls.Add(IssueCountLabel)
        Me.Controls.Add(Me.IssueCountTextBox)
        Me.Controls.Add(Me.BorrowedBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "viewBookTable"
        Me.Size = New System.Drawing.Size(1356, 838)
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowedBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BorrowedBindingNavigator.ResumeLayout(False)
        Me.BorrowedBindingNavigator.PerformLayout()
        CType(Me.BorrowedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet1 As LibraryManagementSystem.DatabaseDataSet1
    Friend WithEvents BorrowedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BorrowedTableAdapter As LibraryManagementSystem.DatabaseDataSet1TableAdapters.BorrowedTableAdapter
    Friend WithEvents TableAdapterManager As LibraryManagementSystem.DatabaseDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents BorrowedBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BorrowedBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ISBNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BorrowerIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IssueDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReturnDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IsIssuedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IssueCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BorrowedDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
