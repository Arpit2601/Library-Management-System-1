Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class ChangePassword

    ' Main function to change the password of user 
    ' Password will change only if you have entered your current password correctly and new password and confirm password matches
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim current As String = EncryptPassword(TextBox1.Text, StudentLogin.UserName)
        Dim newpass As String = TextBox2.Text
        Dim confirm As String = TextBox3.Text

        ' Boolean to check if password can be updated on the basis of values entered in text boxes
        Dim update As Boolean = True

        Dim selectString As String = "SELECT * FROM Users WHERE UserName = '" & StudentLogin.UserName & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read Then
            If current = "" Then
                MessageBox.Show("Please enter your current password", "Invalid password")
                update = False

            ElseIf current <> reader("Password") Then
                MessageBox.Show("Your current password doesnot match", "Wrong password")
                update = False

            ElseIf newpass = "" Then
                MessageBox.Show("Please enter your new password", "Invalid password")
                update = False

            ElseIf confirm = "" Then
                MessageBox.Show("Please confirm your new password", "Invalid password")
                update = False

            ElseIf newpass <> confirm Then
                MessageBox.Show("Password not confirmed correctly", "Invalid new password")
                update = False

            ElseIf newpass = current Then
                MessageBox.Show("Enter a new password", "Set Password")
                update = False
            End If

        End If

        ' If update is true then encrypt it and store in database
        If update Then
            Dim updateString As String = "UPDATE Users SET [Password]='" & EncryptPassword(newpass, StudentLogin.UserName) & "' WHERE UserName = '" & StudentLogin.UserName & "'"
            Dim cmd1 As OleDbCommand = New OleDbCommand(updateString, cn)
            If cmd1.ExecuteNonQuery() > 0 Then
                cmd1.Dispose()
                MessageBox.Show("Password successfully updated!", "Password Change")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
            End If
        End If
        cn.Close()
    End Sub

    ' Hide or show password through checkboxes
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub

    ' Show "password" written on text boxes initially then change the text to password entered by user and display in form of dots
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If CheckBox1.Checked Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = True
    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.UseSystemPasswordChar = True
    End Sub
End Class
