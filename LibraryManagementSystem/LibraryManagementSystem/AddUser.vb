Imports System.Data.OleDb

Public Class AddUser

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        ' Data Validation

        Dim connectionString As String = MainPage.connectionString
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        Dim cmdString As String

        cn.Open()

        Dim maxBooks As Integer
        If lblDesignation.Text = "User" Then
            maxBooks = 7
        Else
            maxBooks = 10
        End If

        Dim profileImage As String = "defaultProfilePic.JPG"

        cmdString = "insert into Users (UserName, [Password]) values('" & txtUsername.Text & "', '" & txtPassword.Text & "')"
        Dim cmdString2 As String = "update Users Set ProfileName='" & txtName.Text & "', Email='" & txtEmail.Text & "', PhoneNumber='" & txtPhone.Text & "', Department='" & lblDepartment.Text & "', Designation='" & lblDesignation.Text & "', ProfileImage='" & profileImage & "', MaxBooks='" & maxBooks & "' WHERE UserName='" & txtUsername.Text & "'"
        Console.WriteLine(cmdString2)

        Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader
        reader.Close()

        Dim cmd2 As OleDbCommand = New OleDbCommand(cmdString2, cn)
        Dim reader2 As OleDbDataReader = cmd2.ExecuteReader
        reader2.Close()

        cn.Close()

    End Sub
End Class
