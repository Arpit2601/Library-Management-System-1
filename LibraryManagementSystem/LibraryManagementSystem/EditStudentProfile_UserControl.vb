Imports System.Data.OleDb

Public Class EditStudentProfile_UserControl

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()

        Dim username As String = UserNameTextBox.Text
        Dim email As String = EmailTextBox.Text
        Dim phonenumber As String = PhoneNumberTextBox.Text
        Dim department As String = DepartmentTextBox.Text

        Dim updateString As String = "UPDATE Users SET UserName='" & username & "', Email='" & email & "',  PhoneNumber='" & phonenumber & "', Department='" & department & "', ProfileImage='" & StudentLogin.UserID & ".JPG' WHERE Userid = " & StudentLogin.UserID
        picBoxPic.Image.Save(System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & StudentLogin.UserID & ".JPG")
        Dim cmd As OleDbCommand = New OleDbCommand(updateString, cn)
        If cmd.ExecuteNonQuery() > 0 Then
            cmd.Dispose()
            MessageBox.Show("Profile updated!")
        End If

        cn.Close()
    End Sub

    Private Sub btnChangePic_Click(sender As Object, e As EventArgs) Handles btnChangePic.Click
        OpenFileDialog1.ShowDialog()
        picBoxPic.ImageLocation = OpenFileDialog1.FileName.ToString
    End Sub
End Class