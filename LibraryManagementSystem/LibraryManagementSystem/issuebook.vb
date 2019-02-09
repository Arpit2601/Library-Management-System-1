Imports System.Data.OleDb
Public Class issuebook
    Private Sub issueButton_Click_1(sender As Object, e As EventArgs) Handles issueButton.Click
        Dim connectionString = MainPage.connectionString
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)

        Dim cmdString = "select * from Borrowed where AccNo = " & AccNoTextBox.Text & ""

        Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
        cn.Open()
        Dim reader As OleDbDataReader = cmd.ExecuteReader

        If Not reader.HasRows() Then
            'book does not exist
            MessageBox.Show("Book does not exist.Please add a book first")
            Return
        ElseIf reader.Read() AndAlso reader("IsIssued") Then
            'book is already issued to someone 
            MessageBox.Show("Book is already issued.Kindly reissue or return the book and issue it to another person")
            Return
        End If

        cmdString = "select * FROM Users where UserName = '" & BorrowerIdTextBox.Text & "'"

        Dim cmd2 As OleDbCommand = New OleDbCommand(cmdString, cn)
        Dim reader2 As OleDbDataReader = cmd2.ExecuteReader



        If Not reader2.HasRows Then
            MessageBox.Show("User does not exist.Please add user first")
            Return
        ElseIf reader2.Read() AndAlso reader2("MaxBooks") = reader2("BooksIssued") Then
            MessageBox.Show("User has already issued max number of books")
            Return
        End If

        Dim rtime = 60
        If reader2("Designation") = "Student" Then
            rtime = 45
        End If

        cmdString = "update Borrowed set IsIssued=True,IssueDate=Date(),Issuecount=1,BorrowerId='" & BorrowerIdTextBox.Text & "', ReturnDate=DateAdd(""d""," & rtime & ",Date()) where AccNo = " & AccNoTextBox.Text & ""
        cmd.CommandText = cmdString

        reader.Close()
        reader = cmd.ExecuteReader()
        Dim currCount As Integer = reader2("BooksIssued") + 1
        reader2.Close()
        cmd2.CommandText = "UPDATE Users SET BooksIssued=" & currCount & " where UserName = '" & BorrowerIdTextBox.Text & "'"
        cmd2.ExecuteReader()
        MessageBox.Show("Book Issued")

    End Sub

    Private Sub AccNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles AccNoTextBox.TextChanged

    End Sub

End Class
