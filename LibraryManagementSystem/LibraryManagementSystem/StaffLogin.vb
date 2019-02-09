Public Class StaffLogin
    Public UserName As String

    Private Sub IssueBook_Click(sender As Object, e As EventArgs) Handles IssueBook.Click
        IssueBook.BackColor = Color.MediumSeaGreen
        ReturnBook.BackColor = Color.MidnightBlue
        ReIssueBook.BackColor = Color.MidnightBlue
        BookButton.BackColor = Color.MidnightBlue
        StudentButton.BackColor = Color.MidnightBlue


        Action.Controls.Clear()


        Dim returnBookInstance = New returnBook
        returnBookInstance.Dock = DockStyle.Bottom
        Dim reIssueBookInstance = New reissuebook
        reIssueBookInstance.Location = New Point(0, 227)
        Dim issueBookInstance = New issuebook
        issueBookInstance.Dock = DockStyle.Top

        returnBookInstance.BackColor = Color.LightGray
        For Each Control In returnBookInstance.Controls
            Control.cursor = Cursors.No
            Control.Enabled = False
            Control.backcolor = Color.LightGray
            If Control.GetType Is GetType(TextBox) Then
                Control.borderstyle = BorderStyle.None
            End If
        Next

        reIssueBookInstance.BackColor = Color.LightGray
        For Each Control In reIssueBookInstance.Controls
            Control.cursor = Cursors.No
            Control.Enabled = False
            Control.backcolor = Color.LightGray
            If Control.GetType Is GetType(TextBox) Then
                Control.borderstyle = BorderStyle.None
            End If
        Next

        Action.Controls.Add(issueBookInstance)
        Action.Controls.Add(returnBookInstance)
        Action.Controls.Add(reIssueBookInstance)
    End Sub

    Private Sub ReturnBook_Click(sender As Object, e As EventArgs) Handles ReturnBook.Click
        IssueBook.BackColor = Color.MidnightBlue
        ReturnBook.BackColor = Color.MediumSeaGreen
        ReIssueBook.BackColor = Color.MidnightBlue
        BookButton.BackColor = Color.MidnightBlue
        StudentButton.BackColor = Color.MidnightBlue

        Action.Controls.Clear()

        Dim returnBookInstance = New returnBook
        returnBookInstance.Dock = DockStyle.Bottom
        Dim reIssueBookInstance = New reissuebook
        reIssueBookInstance.Location = New Point(0, 227)
        Dim issueBookInstance = New issuebook
        issueBookInstance.Dock = DockStyle.Top

        issueBookInstance.BackColor = Color.LightGray
        For Each Control In issueBookInstance.Controls
            Control.cursor = Cursors.No
            Control.Enabled = False
            Control.backcolor = Color.LightGray
            If Control.GetType Is GetType(TextBox) Then
                Control.borderstyle = BorderStyle.None
            End If
        Next

        reIssueBookInstance.BackColor = Color.LightGray
        For Each Control In reIssueBookInstance.Controls
            Control.cursor = Cursors.No
            Control.Enabled = False
            Control.backcolor = Color.LightGray
            If Control.GetType Is GetType(TextBox) Then
                Control.borderstyle = BorderStyle.None
            End If
        Next

        Action.Controls.Add(issueBookInstance)
        Action.Controls.Add(returnBookInstance)
        Action.Controls.Add(reIssueBookInstance)
    End Sub

    Private Sub ReIssueBook_Click(sender As Object, e As EventArgs) Handles ReIssueBook.Click
        IssueBook.BackColor = Color.MidnightBlue
        ReturnBook.BackColor = Color.MidnightBlue
        ReIssueBook.BackColor = Color.MediumSeaGreen
        BookButton.BackColor = Color.MidnightBlue
        StudentButton.BackColor = Color.MidnightBlue

        Action.Controls.Clear()


        Dim returnBookInstance = New returnBook
        returnBookInstance.Dock = DockStyle.Bottom
        Dim reIssueBookInstance = New reissuebook
        reIssueBookInstance.Location = New Point(0, 227)
        Dim issueBookInstance = New issuebook
        issueBookInstance.Dock = DockStyle.Top

        issueBookInstance.BackColor = Color.LightGray
        For Each Control In issueBookInstance.Controls
            Control.cursor = Cursors.No
            Control.Enabled = False
            Control.backcolor = Color.LightGray
            If Control.GetType Is GetType(TextBox) Then
                Control.borderstyle = BorderStyle.None
            End If
        Next

        returnBookInstance.BackColor = Color.LightGray
        For Each Control In returnBookInstance.Controls
            Control.cursor = Cursors.No
            Control.Enabled = False
            Control.backcolor = Color.LightGray
            If Control.GetType Is GetType(TextBox) Then
                Control.borderstyle = BorderStyle.None
            End If
        Next

        Action.Controls.Add(issueBookInstance)
        Action.Controls.Add(returnBookInstance)
        Action.Controls.Add(reIssueBookInstance)
    End Sub

    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.Click
        IssueBook.BackColor = Color.MidnightBlue
        ReturnBook.BackColor = Color.MidnightBlue
        ReIssueBook.BackColor = Color.MidnightBlue
        BookButton.BackColor = Color.MediumSeaGreen
        StudentButton.BackColor = Color.MidnightBlue

        Action.Controls.Clear()
        Action.Controls.Add(New addBook)
    End Sub

    Private Sub StudentButton_Click(sender As Object, e As EventArgs) Handles StudentButton.Click
        IssueBook.BackColor = Color.MidnightBlue
        ReturnBook.BackColor = Color.MidnightBlue
        ReIssueBook.BackColor = Color.MidnightBlue
        BookButton.BackColor = Color.MidnightBlue
        StudentButton.BackColor = Color.MediumSeaGreen

        Action.Controls.Clear()
        Action.Controls.Add(New AddUser)
    End Sub

    Private Sub StaffLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class