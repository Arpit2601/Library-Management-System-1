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

End Class