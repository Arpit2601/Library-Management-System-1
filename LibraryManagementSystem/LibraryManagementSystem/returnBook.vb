Imports System.Data.OleDb

Public Class returnBook

    Private Sub issueButton_Click(sender As Object, e As EventArgs) Handles issueButton.Click
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

        'Todo :Check if the book is already issued to that person only
        'get input from user and 

        cmdString = "update Borrowed set IsIssued=False where AccNo = " & AccNoTextBox.Text & ""
        cmd = New OleDbCommand(cmdString, cn)
        Console.WriteLine(cmdString)

        reader = cmd.ExecuteReader
        MessageBox.Show("Book Issued")

    End Sub
End Class
