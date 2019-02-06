Imports System.Data.OleDb
Public Class issuebook
    Private Sub issueButton_Click_1(sender As Object, e As EventArgs) Handles issueButton.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        Dim cmdString = "select * from Borrowed where AccNo = " & AccNoTextBox.Text & ""
        ' Dim cmdString = "select * from User where UserId = " & BorrowerIdTextBox.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
        cn.Open()
        Dim reader As OleDbDataReader = cmd.ExecuteReader
        If Not reader.Read() Then
            MessageBox.Show("Book does not exist.Please add a book first")
        End If

        cmdString = "select * FROM Users where UserId = '" & BorrowerIdTextBox.Text & "'"

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
        Console.WriteLine(cmdString)

        reader = cmd.ExecuteReader
        MessageBox.Show("Book Issued")
    End Sub


End Class
