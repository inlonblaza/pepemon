<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbtnBSIT = New System.Windows.Forms.RadioButton()
        Me.rbtnACT = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSignin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New huta.Database1DataSet()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Table1TableAdapter = New huta.Database1DataSetTableAdapters.Table1TableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.huta.My.Resources.Resources.icct_logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(287, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Not yet Registered?"
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.BackColor = System.Drawing.Color.Transparent
        Me.chkShow.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkShow.Location = New System.Drawing.Point(437, 272)
        Me.chkShow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(61, 23)
        Me.chkShow.TabIndex = 22
        Me.chkShow.Text = "Show"
        Me.chkShow.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(238, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Select Your Course"
        '
        'rbtnBSIT
        '
        Me.rbtnBSIT.AutoSize = True
        Me.rbtnBSIT.BackColor = System.Drawing.Color.Transparent
        Me.rbtnBSIT.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnBSIT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbtnBSIT.Location = New System.Drawing.Point(272, 373)
        Me.rbtnBSIT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbtnBSIT.Name = "rbtnBSIT"
        Me.rbtnBSIT.Size = New System.Drawing.Size(60, 23)
        Me.rbtnBSIT.TabIndex = 20
        Me.rbtnBSIT.TabStop = True
        Me.rbtnBSIT.Text = "BSIT"
        Me.rbtnBSIT.UseVisualStyleBackColor = False
        '
        'rbtnACT
        '
        Me.rbtnACT.AutoSize = True
        Me.rbtnACT.BackColor = System.Drawing.Color.Transparent
        Me.rbtnACT.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnACT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbtnACT.Location = New System.Drawing.Point(272, 345)
        Me.rbtnACT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbtnACT.Name = "rbtnACT"
        Me.rbtnACT.Size = New System.Drawing.Size(54, 23)
        Me.rbtnACT.TabIndex = 19
        Me.rbtnACT.TabStop = True
        Me.rbtnACT.Text = "ACT"
        Me.rbtnACT.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Location = New System.Drawing.Point(473, 538)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 41)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSignup
        '
        Me.btnSignup.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSignup.Location = New System.Drawing.Point(431, 91)
        Me.btnSignup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(138, 41)
        Me.btnSignup.TabIndex = 17
        Me.btnSignup.Text = "Sign-up"
        Me.btnSignup.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(84, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Enter Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(80, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Enter Username"
        '
        'btnSignin
        '
        Me.btnSignin.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSignin.Location = New System.Drawing.Point(234, 426)
        Me.btnSignin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(138, 41)
        Me.btnSignin.TabIndex = 14
        Me.btnSignin.Text = "Sign-in"
        Me.btnSignin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Password", True))
        Me.txtPassword.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPassword.Location = New System.Drawing.Point(192, 269)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(243, 26)
        Me.txtPassword.TabIndex = 13
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Username", True))
        Me.txtUsername.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtUsername.Location = New System.Drawing.Point(192, 212)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(243, 26)
        Me.txtUsername.TabIndex = 12
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(142, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(367, 38)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Subject Validation System"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 563)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(461, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Subject Validation System or SVS  is a system that validate your subjects. "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.huta.My.Resources.Resources.bg1
        Me.ClientSize = New System.Drawing.Size(581, 588)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkShow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbtnBSIT)
        Me.Controls.Add(Me.rbtnACT)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSignin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkShow As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbtnBSIT As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnACT As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSignup As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSignin As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Database1DataSet As huta.Database1DataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As huta.Database1DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
