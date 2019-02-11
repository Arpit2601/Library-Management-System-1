Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class returnBook

    ' Min function to return book via its accession number
    ' First search for accession number in Borrowed table. If found then set issued to false there and reduce book count by one in users table for that table
    Private Sub issueButton_Click(sender As Object, e As EventArgs) Handles issueButton.Click
        If AccNoTextBox.Text = "" Then
            MessageBox.Show("Enter correct credentials")
        ElseIf Not Regex.IsMatch(AccNoTextBox.Text, "^[0-9]+$") Then
            MessageBox.Show("Enter correct Book id")
        Else
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
            Dim issue_date As String = ""
            cmd.CommandText = "update Borrowed set IsIssued=False where AccNo = " & AccNoTextBox.Text & ""
            cmd.ExecuteScalar()
            cmd.CommandText = "select * from Users where UserName='" & UserID & "'"
            reader = cmd.ExecuteReader
            reader.Read()
            Dim newCount As Integer = reader("BooksIssued") - 1
            cmd.CommandText = "update Users set BooksIssued=" & newCount & " where UserName='" & UserID & "'"
            reader.Close()
            cmd.ExecuteReader()
            AccNoTextBox.Text = ""
            MessageBox.Show("Book Returned")
        End If
    End Sub

End Class
