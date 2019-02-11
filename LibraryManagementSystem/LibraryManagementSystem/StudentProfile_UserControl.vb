Imports System.Data.OleDb


Public Class StudentProfile_UserControl

    ' Display all the details of user on page load
    Private Sub StudentProfile_UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Users WHERE UserName = '" & StudentLogin.UserName & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read Then
            lblWelcome2.Text = "Welcome, " & reader("ProfileName")
            Dim fullPath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & reader("ProfileImage")

            picBoxProfile.ImageLocation = fullPath
            lblUsername.Text = reader("UserName")
            lblEmail.Text = reader("Email")
            lblPhone.Text = reader("PhoneNumber")
            lblDepartment.Text = reader("Department")
            lblDesignation.Text = reader("Designation")
            lblFine.Text = reader("TotalFine")
            lblMaxBooks.Text = reader("MaxBooks")
            lblFine.Text = reader("TotalFine")
        End If
        cn.Close()
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
