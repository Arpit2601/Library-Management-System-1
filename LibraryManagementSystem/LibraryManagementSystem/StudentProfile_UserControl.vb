Imports System.Data.OleDb

Public Class StudentProfile_UserControl

    Private Sub StudentProfile_UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Users WHERE Userid = " & StudentLogin.UserID
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read Then
            lblWelcome2.Text = "Welcome, " & reader("ProfileName")

            Dim fullPath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & reader("ProfileImage")
            picBoxProfile.ImageLocation = fullPath

            lblUsername.Text = reader("UserName")
            lblName.Text = reader("ProfileName")
            lblEmail.Text = reader("Email")
            lblPhone.Text = reader("PhoneNumber")
            lblDepartment.Text = reader("Department")
            lblDesignation.Text = reader("Designation")
            lblFine.Text = reader("TotalFine")
            lblMaxBooks.Text = reader("MaxBooks")

        End If

        cn.Close()
    End Sub


End Class
