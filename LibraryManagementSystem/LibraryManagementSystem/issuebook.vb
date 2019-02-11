Imports System.Data.OleDb
Imports System.Text.RegularExpressions


Public Class issuebook

    ' Main function to issue book with accession number to a user
    Private Sub issueButton_Click_1(sender As Object, e As EventArgs) Handles issueButton.Click

        ' Checking for correct accession number
        If AccNoTextBox.Text = "" Or BorrowerIdTextBox.Text = "" Then
            MessageBox.Show("Enter correct credentials")
        ElseIf Not Regex.IsMatch(AccNoTextBox.Text, "^[0-9]+$") Then
            MessageBox.Show("Enter correct Book id")
        Else
            Dim connectionString = MainPage.connectionString
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim cmdString = "select * from Borrowed where AccNo = " & AccNoTextBox.Text & ""
            Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            ' If accession number does not exist
            If Not reader.HasRows Then
                'book does not exist
                MessageBox.Show("Book does not exist.Please add a book first")
                Return

                ' If this book is already issued to someone
            ElseIf reader.Read() AndAlso reader("IsIssued") Then
                'book is already issued to someone 
                MessageBox.Show("Book is already issued.Kindly reissue or return the book and issue it to another person")
                Return
            End If

            Dim ISBN As String = reader("ISBN")

            cmdString = "select * FROM Users where UserName = '" & BorrowerIdTextBox.Text & "'"
            Dim cmd2 As OleDbCommand = New OleDbCommand(cmdString, cn)
            Dim reader2 As OleDbDataReader = cmd2.ExecuteReader
            If Not reader2.HasRows Then
                MessageBox.Show("User does not exist.Please add user first")
                Return

                ' If user has already issued the maximum number of books he can issue
            ElseIf reader2.Read() AndAlso reader2("MaxBooks") = reader2("BooksIssued") Then
                MessageBox.Show("User has already issued max number of books")
                AccNoTextBox.Text = ""
                BorrowerIdTextBox.Text = ""
                Return
            End If

            ' Setting the issue date and return date
            Dim issue_date As String = DateTime.Now.ToString("dd-MM-yyyy")
            Dim return_date As String = DateTime.Now.AddDays(60).ToString("dd-MM-yyyy")
            If reader2("Designation") = "Student" Then
                return_date = DateTime.Now.AddDays(45).ToString("dd-MM-yyyy")
            End If

            ' update in borrowed table
            Dim cmdString4 As String = "select * from Books where ISBN='" & ISBN & "'"
            Dim cmd4 As OleDbCommand = New OleDbCommand(cmdString4, cn)
            cmd4.CommandText = cmdString4
            Dim reader4 As OleDbDataReader = cmd4.ExecuteReader
            reader4.Read()
            Dim remaining As Integer = reader4("Remaining")
            reader4.Close()

            If remaining <= 0 Then
                MessageBox.Show("This book is not available")
                Return
            End If

            cmdString = "update Borrowed set IsIssued=True,IssueDate='" & issue_date & "',Issuecount=1,BorrowerId='" & BorrowerIdTextBox.Text & "', ReturnDate='" & return_date & "' where AccNo = " & AccNoTextBox.Text & ""
            cmd.CommandText = cmdString
            reader.Close()
            reader = cmd.ExecuteReader()
            Dim currCount As Integer = reader2("BooksIssued") + 1
            reader2.Close()

            remaining -= 1

            Dim cmdString3 As String = "update Books set Remaining=" & remaining & " where ISBN='" & ISBN & "'"
            Dim cmd3 As OleDbCommand = New OleDbCommand(cmdString3, cn)
            cmd3.CommandText = cmdString3
            cmd3.ExecuteNonQuery()

            ' Increase book issued count by 1 in users table
            cmd2.CommandText = "UPDATE Users SET BooksIssued=" & currCount & " where UserName = '" & BorrowerIdTextBox.Text & "'"
            cmd2.ExecuteReader()
            AccNoTextBox.Text = ""
            BorrowerIdTextBox.Text = ""
            MessageBox.Show("Book Issued")
        End If


    End Sub

    Private Sub AccNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles AccNoTextBox.TextChanged

    End Sub

    Private Sub issuebook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
