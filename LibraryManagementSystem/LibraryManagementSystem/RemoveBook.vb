'Imports System.Data.OleDb
'Imports System.Text.RegularExpressions



'Public Class RemoveBook

'    ' Min function to return book via its accession number
'    ' First search for accession number in Borrowed table. If found then set issued to false there and reduce book count by one in users table for that table
'    Private Sub issueButton_Click(sender As Object, e As EventArgs) Handles issueButton.Click
'        If AccNoTextBox.Text = "" Then
'            MessageBox.Show("Enter correct credentials")
'        ElseIf Not Regex.IsMatch(AccNoTextBox.Text, "^[0-9]+$") Then
'            MessageBox.Show("Enter correct Book id")
'        Else
'            Dim connectionString = MainPage.connectionString
'            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
'            Dim cmdString = "select * from Borrowed where AccNo = " & AccNoTextBox.Text & ""
'            Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
'            cn.Open()
'            Dim reader As OleDbDataReader = cmd.ExecuteReader
'            reader.Read()
'            Dim ISBN As String = ""
'            If Not reader.HasRows Then
'                MessageBox.Show("Book does not exist")
'                Return
'            ElseIf reader("IsIssued") Then
'                MessageBox.Show("This Book is issued to someone")
'                AccNoTextBox.Text = ""
'                Return
'            End If

'            Dim cmdString4 As String = "select * from Books where ISBN='" & reader("ISBN") & "'"

'            Dim cmd4 As OleDbCommand = New OleDbCommand(cmdString4, cn)
'            Dim reader4 As OleDbDataReader = cmd4.ExecuteReader
'            reader4.Read()
'            cmdString = "update Books set Remaining=" & reader4("Remaining") - 1 & ", Total = " & reader4("Total") - 1 & " where ISBN='" & reader("ISBN") & "'"
'            Dim cmd3 As OleDbCommand = New OleDbCommand(cmdString, cn)
'            cmd3.CommandText = cmdString
'            cmd3.ExecuteScalar()
'            reader4.Close()
'            reader.Close()

'            cmd.CommandText = "delete * from Borrowed where AccNo = " & AccNoTextBox.Text & ""
'            cmd.ExecuteScalar()

'            AccNoTextBox.Text = ""
'            MessageBox.Show("Book Deleted")
'            cn.Close()
'        End If

'    End Sub
'End Class
