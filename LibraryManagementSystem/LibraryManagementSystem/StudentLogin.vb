Public Class StudentLogin
    Public UserID As Integer

    Private Sub btnMyProfile_Click(sender As Object, e As EventArgs) Handles btnMyProfile.Click
        contentPanel.Controls.Clear()
        Dim instance As New StudentProfile_UserControl
        contentPanel.Controls.Add(instance)
    End Sub

    Private Sub btnItemsCheckedout_Click(sender As Object, e As EventArgs) Handles btnItemsCheckedout.Click
        contentPanel.Controls.Clear()
        contentPanel.Controls.Add(New ItemsCheckedOut_UserControl)
    End Sub

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        contentPanel.Controls.Clear()
        contentPanel.Controls.Add(New EditStudentProfile_UserControl)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Do you want to logout?", "Confirm logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            MainPage.Show()
        Else
            contentPanel.Controls.Clear()
            Dim instance As New StudentProfile_UserControl
            contentPanel.Controls.Add(instance)
        End If
    End Sub

    Private Sub StudentLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contentPanel.Controls.Clear()
        Dim instance As New StudentProfile_UserControl
        contentPanel.Controls.Add(instance)
    End Sub
End Class