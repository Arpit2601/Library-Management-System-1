Imports System.Data.OleDb
Public Class reissuebook
    Private Sub issueButton_Click(sender As Object, e As EventArgs) Handles issueButton.Click
        Dim connectionString = MainPage.connectionString
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        Dim cmdString = "select * from Borrowed where AccNo = " & AccNoTextBox.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
        cn.Open()
        Dim reader As OleDbDataReader = cmd.ExecuteReader

        If Not reader.Read() Then
            MessageBox.Show("Book does not exist.Please add a book first")
        End If

        cmdString = "select * FROM Users where UserName = '" & BorrowerIdTextBox.Text & "'"

        Dim cmd2 As OleDbCommand = New OleDbCommand(cmdString, cn)
        Dim reader2 As OleDbDataReader = cmd2.ExecuteReader



        If Not reader2.Read() Then
            MessageBox.Show("User does not exist.Please add user first")
        End If

        'Todo :Check if the user can borrow more books
        'Todo :Check if the book is already issued to someone
        'get input from user and 

        cmdString = "update Borrowed set IsIssued=True,IssueDate=Date() and BorrowerId='" & BorrowerIdTextBox.Text & "' where AccNo = " & AccNoTextBox.Text & ""
        cmd = New OleDbCommand(cmdString, cn)

        reader = cmd.ExecuteReader
        MessageBox.Show("Book Issued")

    End Sub

End Class
