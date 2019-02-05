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

End Class