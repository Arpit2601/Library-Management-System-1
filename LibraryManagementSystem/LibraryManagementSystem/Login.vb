Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class Login

    ' Main function to login a user on clickiing on login button 
    ' User will be sent to staff page or student/proffessor page based on his designation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username As String = txtUsername.Text
        Dim pre_password As String = txtPassword.Text

        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)

        ' Password is passed in Encrypted form
        Dim selectString As String = "SELECT * FROM Users WHERE UserName = '" & username & "' AND Password = '" & EncryptPassword(pre_password, username) & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        cn.Open()
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If txtPassword.Text.Trim = pre_password And txtUsername.Text.Trim = username Then
            If reader.Read Then
                If reader("Designation") = "Staff" Then
                    StaffLogin.UserName = reader("UserName")
                    StaffLogin.Show()
                    Me.Close()
                    MainPage.Hide()
                Else
                    StudentLogin.UserName = reader("UserName")
                    StudentLogin.Show()
                    Me.Close()
                    MainPage.Hide()
                End If
            Else
                MessageBox.Show("Incorrect username or password")
            End If
        Else
            MessageBox.Show("Incorrect username or password")

        End If
        cn.Close()
    End Sub

    ' Functions to make "username" and "password" appear in test boxes even after cursor leaves and they are empty
    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            Dim objFont As System.Drawing.Font
            objFont = New System.Drawing.Font("Comic Sans MS", 12, FontStyle.Regular)
            txtUsername.Font = objFont
            txtUsername.ForeColor = Color.Black
        End If
    End Sub


    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "" Then
            Dim objfont As System.Drawing.Font
            objfont = New System.Drawing.Font("Comic Sans MS", 12, FontStyle.Italic)
            txtUsername.Font = objfont
            txtUsername.ForeColor = Color.DarkGray
            txtUsername.Text = "Username"
        End If
    End Sub


    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.UseSystemPasswordChar = True
            txtPassword.Text = ""
            Dim objFont As System.Drawing.Font
            objFont = New System.Drawing.Font("Comic Sans MS", 12, FontStyle.Regular)
            txtPassword.Font = objFont
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    ' Checkbox to hide or see the password
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textBoxes = Me.Controls.OfType(Of TextBox)()
        For Each txt In textBoxes
            AddHandler txt.KeyDown, AddressOf ReturnHandler
        Next
    End Sub

    ' On pressing Enter you can reach new tab
    Public Sub ReturnHandler(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

End Class