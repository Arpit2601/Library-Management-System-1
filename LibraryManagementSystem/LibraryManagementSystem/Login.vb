Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)

        Dim selectString As String = "SELECT * FROM Users WHERE UserName = '" & username & "' AND Password = '" & password & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        cn.Open()
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read Then
            If reader("Designation") = "Staff" Then
                StaffLogin.UserID = reader("UserId")    ' User ID in Staff Login form
                StaffLogin.Show()
                Me.Hide()
                MainPage.Hide()
            Else
                StudentLogin.UserID = reader("UserId")
                StudentLogin.Show()
                Me.Hide()
                MainPage.Hide()
            End If
        Else
            MessageBox.Show("Incorrect username or password")
        End If

        cn.Close()
    End Sub

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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class