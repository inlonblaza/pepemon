<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.components = New System.ComponentModel.Container()
        Dim NameLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim BirthdayLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Dim GenderLabel As System.Windows.Forms.Label
        Dim School_CampusLabel As System.Windows.Forms.Label
        Me.Database1DataSet = New huta.Database1DataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New huta.Database1DataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New huta.Database1DataSetTableAdapters.TableAdapterManager()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Table1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Table1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.School_CampusComboBox = New System.Windows.Forms.ComboBox()
        NameLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        BirthdayLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        School_CampusLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Table1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.Color.Transparent
        NameLabel.Location = New System.Drawing.Point(176, 146)
        NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(50, 19)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = System.Drawing.Color.Transparent
        UsernameLabel.Location = New System.Drawing.Point(160, 416)
        UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(75, 19)
        UsernameLabel.TabIndex = 5
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = System.Drawing.Color.Transparent
        PasswordLabel.Location = New System.Drawing.Point(160, 462)
        PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(71, 19)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "Password:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.Transparent
        AddressLabel.Location = New System.Drawing.Point(160, 182)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(66, 19)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'BirthdayLabel
        '
        BirthdayLabel.AutoSize = True
        BirthdayLabel.BackColor = System.Drawing.Color.Transparent
        BirthdayLabel.Location = New System.Drawing.Point(160, 222)
        BirthdayLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BirthdayLabel.Name = "BirthdayLabel"
        BirthdayLabel.Size = New System.Drawing.Size(69, 19)
        BirthdayLabel.TabIndex = 11
        BirthdayLabel.Text = "Birthday:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Location = New System.Drawing.Point(178, 333)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(48, 19)
        EmailLabel.TabIndex = 17
        EmailLabel.Text = "Email:"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Database1DataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = huta.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(237, 143)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(265, 26)
        Me.NameTextBox.TabIndex = 4
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(237, 412)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(265, 26)
        Me.UsernameTextBox.TabIndex = 6
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(237, 458)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(265, 26)
        Me.PasswordTextBox.TabIndex = 8
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(237, 178)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(265, 26)
        Me.AddressTextBox.TabIndex = 10
        '
        'BirthdayDateTimePicker
        '
        Me.BirthdayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table1BindingSource, "Birthday", True))
        Me.BirthdayDateTimePicker.Location = New System.Drawing.Point(237, 216)
        Me.BirthdayDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker"
        Me.BirthdayDateTimePicker.Size = New System.Drawing.Size(265, 26)
        Me.BirthdayDateTimePicker.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(237, 330)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(265, 26)
        Me.EmailTextBox.TabIndex = 18
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(547, 13)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 34)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(360, 538)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 34)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRegister.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(203, 538)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(100, 34)
        Me.btnRegister.TabIndex = 24
        Me.btnRegister.Text = "Submit"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(246, 388)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Create your Username and Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 30)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "REGISTERATION FORM"
        '
        'Table1BindingNavigator
        '
        Me.Table1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Table1BindingNavigator.BindingSource = Me.Table1BindingSource
        Me.Table1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Table1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Table1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Table1BindingNavigatorSaveItem})
        Me.Table1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Table1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Table1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Table1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Table1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Table1BindingNavigator.Name = "Table1BindingNavigator"
        Me.Table1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Table1BindingNavigator.Size = New System.Drawing.Size(667, 25)
        Me.Table1BindingNavigator.TabIndex = 29
        Me.Table1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Table1BindingNavigatorSaveItem
        '
        Me.Table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Table1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Table1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Table1BindingNavigatorSaveItem.Name = "Table1BindingNavigatorSaveItem"
        Me.Table1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Table1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.Transparent
        GenderLabel.Location = New System.Drawing.Point(167, 261)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(59, 19)
        GenderLabel.TabIndex = 29
        GenderLabel.Text = "Gender:"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.GenderComboBox.Location = New System.Drawing.Point(237, 253)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 27)
        Me.GenderComboBox.TabIndex = 30
        '
        'School_CampusLabel
        '
        School_CampusLabel.AutoSize = True
        School_CampusLabel.BackColor = System.Drawing.Color.Transparent
        School_CampusLabel.Location = New System.Drawing.Point(118, 296)
        School_CampusLabel.Name = "School_CampusLabel"
        School_CampusLabel.Size = New System.Drawing.Size(108, 19)
        School_CampusLabel.TabIndex = 30
        School_CampusLabel.Text = "School Campus:"
        '
        'School_CampusComboBox
        '
        Me.School_CampusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "School Campus", True))
        Me.School_CampusComboBox.FormattingEnabled = True
        Me.School_CampusComboBox.Items.AddRange(New Object() {"Cainta Main Campus", "Sumulong Campus", "San Mateo Campus", "Cogeo Campus", "Antipolo Campus", "Taytay Campus", "Angono Campus", "Binangonan Campus"})
        Me.School_CampusComboBox.Location = New System.Drawing.Point(237, 293)
        Me.School_CampusComboBox.Name = "School_CampusComboBox"
        Me.School_CampusComboBox.Size = New System.Drawing.Size(265, 27)
        Me.School_CampusComboBox.TabIndex = 31
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.huta.My.Resources.Resources.bg1
        Me.ClientSize = New System.Drawing.Size(667, 644)
        Me.Controls.Add(School_CampusLabel)
        Me.Controls.Add(Me.School_CampusComboBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.Table1BindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(BirthdayLabel)
        Me.Controls.Add(Me.BirthdayDateTimePicker)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegisterForm"
        Me.Text = "Registerform"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Table1BindingNavigator.ResumeLayout(False)
        Me.Table1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As huta.Database1DataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As huta.Database1DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As huta.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthdayDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Table1BindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Table1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents School_CampusComboBox As System.Windows.Forms.ComboBox
End Class
