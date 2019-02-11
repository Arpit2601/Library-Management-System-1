Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports System.Globalization


Public Class reissuebook

    ' Main function to reissue book. We reissue the book only if it is issued by that user.
    Private Sub issueButton_Click(sender As Object, e As EventArgs) Handles issueButton.Click
        ' First check for correct accession number
        If AccNoTextBox.Text = "" Or BorrowerIdTextBox.Text = "" Then
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

            ' If accession number does not exist
            If Not reader.Read() Then
                MessageBox.Show("Book does not exist.Please add a book first")
            Else
                cmdString = "select * FROM Users where UserName = '" & BorrowerIdTextBox.Text & "'"

                Dim cmd2 As OleDbCommand = New OleDbCommand(cmdString, cn)
                Dim reader2 As OleDbDataReader = cmd2.ExecuteReader

                ' If user does not exist
                If Not reader2.Read() Then
                    MessageBox.Show("User does not exist.Please add user first")
                Else
                    Dim cmdString2 As String = "select * FROM Borrowed where Borrowerid = '" & BorrowerIdTextBox.Text & "' AND AccNo=" & AccNoTextBox.Text & " AND IsIssued=True"

                    Dim cmd3 As OleDbCommand = New OleDbCommand(cmdString2, cn)
                    Dim reader3 As OleDbDataReader = cmd3.ExecuteReader

                    ' Set issue_date to present date
                    ' If student then reissue for 45 days 
                    ' If proffessor then reissue for 60 days
                    Dim issue_date As String = DateTime.Now.ToString("dd-MM-yyyy")
                    Dim return_date As String = DateTime.Now.AddDays(60).ToString("dd-MM-yyyy")
                    If reader2("Designation") = "Student" Then
                        return_date = DateTime.Now.AddDays(45).ToString("dd-MM-yyyy")
                    End If
                    Console.WriteLine(issue_date)
                    Console.WriteLine(return_date)

                    ' If accession number and username are correct but this book is not issued to this particular user then show error 
                    If Not reader3.Read() Then
                        MessageBox.Show("This book is not issued to this particular user")
                    Else
                        cmdString = "update Borrowed set IsIssued=True,IssueDate='" & issue_date & "',ReturnDate='" & return_date & "', BorrowerId='" & BorrowerIdTextBox.Text & "' where AccNo = " & AccNoTextBox.Text & ""
                        cmd = New OleDbCommand(cmdString, cn)
                        reader = cmd.ExecuteReader
                        AccNoTextBox.Text = ""
                        BorrowerIdTextBox.Text = ""
                        MessageBox.Show("Book ReIssued")
                    End If
                    cn.Close()
                End If
            End If
        End If
    End Sub
End Class
