Imports System.Data.OleDb

Public Class returnBook

    Private Sub issueButton_Click(sender As Object, e As EventArgs) Handles issueButton.Click

        Dim connectionString = MainPage.connectionString
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        Dim cmdString = "select * from Borrowed where AccNo = " & AccNoTextBox.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
        cn.Open()
        Dim reader As OleDbDataReader = cmd.ExecuteReader

        If Not reader.Read() Then
            MessageBox.Show("Book does not exist.Please add a book first")
            Return
        End If

        Dim UserID As String = reader("BorrowerId")
        reader.Close()

        cmd.CommandText = "update Borrowed set IsIssued=False where AccNo = " & AccNoTextBox.Text & ""
        cmd.ExecuteScalar()
        cmd.CommandText = "select * from Users where UserName='" & UserID & "'"
        reader = cmd.ExecuteReader
        reader.Read()
        Dim newCount As Integer = reader("BooksIssued") - 1
        cmd.CommandText = "update Users set BooksIssued=" & newCount & " where UserName='" & UserID & "'"
        reader.Close()
        cmd.ExecuteReader()
        MessageBox.Show("Book Returned")

    End Sub

End Class
