Public Class StaffLogin
    Public UserId As String
    Private Sub IssueBook_Click(sender As Object, e As EventArgs) Handles IssueBook.Click
        Action.Controls.Clear()
        Action.Controls.Add(New issuebook)
    End Sub

    Private Sub ReturnBook_Click(sender As Object, e As EventArgs) Handles ReturnBook.Click
        Action.Controls.Clear()
        Action.Controls.Add(New returnBook)
    End Sub

    Private Sub RenewBook_Click(sender As Object, e As EventArgs) Handles ReIssueBook.Click
        Action.Controls.Clear()
        Action.Controls.Add(New reIssueBook)
    End Sub

    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.Click
        Action.Controls.Clear()
        Action.Controls.Add(New addBook)
    End Sub
End Class