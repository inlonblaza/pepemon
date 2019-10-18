Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Dim attemps As Integer = 0
    Private Sub btnSignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignup.Click
        'register form display or in tagalog magpapakilala ka tapos lolokohin ka lang..'
        Me.Hide()
        RegisterForm.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database1DataSet.Table1)
        'TODO: This line of code loads data into the 'Database1DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database1DataSet.Table1)
        txtPassword.Text = ""
        txtUsername.Text = ""
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnSignin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignin.Click
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb")
        Dim command As New OleDbCommand("SELECT [Username] FROM [Table1] WHERE [UsernameField] = Username AND [PasswordField] = Password", connection)

        Dim usernameParam As New OleDbParameter("username", Me.txtUsername.Text)
        Dim passwordParam As New OleDbParameter("password", Me.txtPassword.Text)

        command.Parameters.Add(usernameParam)
        command.Parameters.Add(passwordParam)
        command.Connection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()

        'sign-in code section or in tagalog kumanta ang code seksyon'
        If reader.HasRows And rbtnACT.Checked = True Then
            MsgBox("Signing-in", MsgBoxStyle.Information, "WELCOME")
            Me.Hide()
            ACTForm1.Show()
        ElseIf reader.HasRows And rbtnBSIT.Checked = True Then
            MsgBox("Signing-in", MsgBoxStyle.Information, "WELCOME")
            Me.Hide()
            BSITform1.Show()
        ElseIf txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("No Username or Password found!", MsgBoxStyle.Critical, "ERROR")
        ElseIf rbtnACT.Checked = False Then
            MsgBox("Select Your Course", MsgBoxStyle.Critical, "ERROR")
        ElseIf reader.HasRows = False Then
            txtUsername.Text = ""
            txtPassword.Text = ""

            If attemps = 3 Then
                btnSignin.Enabled = False
                MsgBox("taenamoo hula pa")
            End If
            MsgBox("Invalid Username or Password!", MsgBoxStyle.Critical, "ERROR")
            chkShow.Checked = False

            attemps += 1
        End If

        command.Connection.Close()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'closing the program in tagalog hindi pa kayo close iniwan ka na nya..'
        If MessageBox.Show("Close the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShow.CheckedChanged
        'option for actform and bsitform code section in tagalog si gerald anderson ka ba?'
        If chkShow.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = False
        End If
        If chkShow.CheckState = CheckState.Unchecked Then
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
