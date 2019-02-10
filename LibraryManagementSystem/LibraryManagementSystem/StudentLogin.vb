Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class StudentLogin
    Public UserName As String
    Dim desig As String

    Private Sub btnMyProfile_Click(sender As Object, e As EventArgs) Handles btnMyProfile.Click
        btnMyProfile.BackColor = Color.MediumSeaGreen
        btnItemsCheckedout.BackColor = Color.MidnightBlue
        btnEditProfile.BackColor = Color.MidnightBlue
        btnLogout.BackColor = Color.MidnightBlue
        Button2.BackColor = Color.MidnightBlue
        btnRecommend.BackColor = Color.MidnightBlue

        contentPanel.Controls.Clear()
        Dim instance As New StudentProfile_UserControl
        contentPanel.Controls.Add(instance)
    End Sub

    Private Sub btnItemsCheckedout_Click(sender As Object, e As EventArgs) Handles btnItemsCheckedout.Click
        btnMyProfile.BackColor = Color.MidnightBlue
        btnItemsCheckedout.BackColor = Color.MediumSeaGreen
        btnEditProfile.BackColor = Color.MidnightBlue
        btnLogout.BackColor = Color.MidnightBlue
        Button2.BackColor = Color.MidnightBlue
        btnRecommend.BackColor = Color.MidnightBlue

        contentPanel.Controls.Clear()
        contentPanel.Controls.Add(New ItemsCheckedOut_UserControl)
    End Sub

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        btnMyProfile.BackColor = Color.MidnightBlue
        btnItemsCheckedout.BackColor = Color.MidnightBlue
        btnEditProfile.BackColor = Color.MediumSeaGreen
        btnLogout.BackColor = Color.MidnightBlue
        Button2.BackColor = Color.MidnightBlue
        btnRecommend.BackColor = Color.MidnightBlue

        contentPanel.Controls.Clear()
        contentPanel.Controls.Add(New EditStudentProfile_UserControl)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        btnMyProfile.BackColor = Color.MidnightBlue
        btnItemsCheckedout.BackColor = Color.MidnightBlue
        btnEditProfile.BackColor = Color.MidnightBlue
        Button2.BackColor = Color.MidnightBlue
        btnLogout.BackColor = Color.MediumSeaGreen
        btnRecommend.BackColor = Color.MidnightBlue

        Dim result = MessageBox.Show("Do you want to logout?", "Confirm logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            MainPage.Show()
        Else
            btnLogout.BackColor = Color.MidnightBlue
            btnMyProfile.BackColor = Color.MediumSeaGreen
            contentPanel.Controls.Clear()
            Dim instance As New StudentProfile_UserControl
            contentPanel.Controls.Add(instance)
        End If
    End Sub

    Private Sub StudentLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRecommend.BackColor = Color.MidnightBlue
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Users WHERE UserName = '" & UserName & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            Desig = reader("Designation")
        End While
        If Desig = "Professor" Then
            btnRecommend.Text = "Recommend a Book"
        Else
            btnRecommend.Text = "Your Recommendations"
        End If

        btnMyProfile.BackColor = Color.MediumSeaGreen
        btnItemsCheckedout.BackColor = Color.MidnightBlue
        btnEditProfile.BackColor = Color.MidnightBlue
        Button2.BackColor = Color.MidnightBlue
        btnLogout.BackColor = Color.MidnightBlue
        btnRecommend.BackColor = Color.MidnightBlue

        contentPanel.Controls.Clear()
        Dim instance As New StudentProfile_UserControl
        contentPanel.Controls.Add(instance)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        btnMyProfile.BackColor = Color.MidnightBlue
        btnItemsCheckedout.BackColor = Color.MidnightBlue
        btnEditProfile.BackColor = Color.MidnightBlue
        btnLogout.BackColor = Color.MidnightBlue
        Button2.BackColor = Color.MediumSeaGreen
        btnRecommend.BackColor = Color.MidnightBlue

        contentPanel.Controls.Clear()
        contentPanel.Controls.Add(New ChangePassword)
    End Sub

    Private Sub btnRecommend_Click(sender As Object, e As EventArgs) Handles btnRecommend.Click
        btnMyProfile.BackColor = Color.MidnightBlue
        btnItemsCheckedout.BackColor = Color.MidnightBlue
        btnEditProfile.BackColor = Color.MidnightBlue
        btnLogout.BackColor = Color.MidnightBlue
        btnRecommend.BackColor = Color.MediumSeaGreen

        contentPanel.Controls.Clear()
        If desig = "Professor" Then
            contentPanel.Controls.Add(New Prof_UserControl)
        Else
            contentPanel.Controls.Add(New Stud_UserControl)
        End If
    End Sub
End Class