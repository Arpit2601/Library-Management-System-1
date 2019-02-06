Imports System.Data.OleDb

Public Class StudentProfile_UserControl

    Private Sub StudentProfile_UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Users WHERE Userid = " & StudentLogin.UserID
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read Then
            Dim fullPath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & reader("ProfileImage")
            picBoxProfile.ImageLocation = fullPath

            UserIdTextBox.Text = reader("UserId")
            UserNameTextBox.Text = reader("UserName")
            EmailTextBox.Text = reader("Email")
            PhoneNumberTextBox.Text = reader("PhoneNumber")
            DepartmentTextBox.Text = reader("Department")
            DesignationTextBox.Text = reader("Designation")
            TotalFineTextBox.Text = reader("TotalFine")
            MaxBooksTextBox.Text = reader("MaxBooks")
        End If
        cn.Close()
    End Sub

End Class
