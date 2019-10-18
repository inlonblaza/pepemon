Imports System.Data.OleDb
Public Class RegisterForm

    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Table1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub RegisterForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database1DataSet.Table1)
        Table1BindingNavigator.Hide()
        BindingNavigatorAddNewItem.PerformClick()
        Table1BindingSource.AddNew()
        NameTextBox.Clear()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        AddressTextBox.Clear()
        BirthdayDateTimePicker.Refresh()
        EmailTextBox.Text = "@gmail.com"

    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Form1.txtUsername.Text = ""
        Form1.txtPassword.Text = ""
        Form1.rbtnACT.Checked = False
        Form1.rbtnBSIT.Checked = False
        Form1.chkShow.Checked = False
        Try
            'incomplete info code section in tagalog kulang kulang ka.'
            If NameTextBox.Text = "" Then
                MsgBox("Incomplete Details", MsgBoxStyle.Information, "SVS")
            ElseIf AddressTextBox.Text = "" Then
                MsgBox("Incomplete Details", MsgBoxStyle.Information, "SVS")
            ElseIf School_CampusComboBox.Text = "" Then
                MsgBox("Incomplete Details", MsgBoxStyle.Information, "SVS")
            ElseIf GenderComboBox.Text = "" Then
                MsgBox("Incomplete Details", MsgBoxStyle.Information, "SVS")
            ElseIf EmailTextBox.Text = "" Then
                MsgBox("Incomplete Details", MsgBoxStyle.Information, "SVS")
            ElseIf UsernameTextBox.Text = "" Then
                Label1.Text = "Please Create your Username and Password"
                Label1.ForeColor = Color.Red
            ElseIf PasswordTextBox.Text = "" Then
                Label1.Text = " Please Create your Username and Password"
                Label1.ForeColor = Color.Red

            Else
                Table1BindingNavigatorSaveItem.PerformClick()
                Table1BindingSource.EndEdit()
                Table1TableAdapter.Update(Database1DataSet.Table1)
                MsgBox("You are now Registered")
                MsgBox("Please Sign-in Your Account")
                Form1.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Register Failed")
        End Try


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
        Form1.Show()
        Form1.txtUsername.Text = ""
        Form1.txtPassword.Text = ""
        Form1.rbtnACT.Checked = False
        Form1.rbtnBSIT.Checked = False
        Form1.chkShow.Checked = False
    End Sub
    'deleting all the text in the textboxes in tagalog mag move ka na!'
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If MessageBox.Show("Clear all the information?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            NameTextBox.Clear()
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            AddressTextBox.Clear()
            BirthdayDateTimePicker.ResetText()
            EmailTextBox.ResetText()
            GenderComboBox.ResetText()
            School_CampusComboBox.ResetText()

        End If
    End Sub
End Class