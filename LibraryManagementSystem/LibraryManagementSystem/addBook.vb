Imports System.Data.OleDb

Public Class addBook

    Private Sub ISBNTextBox1_TextChanged(sender As Object, e As KeyEventArgs) Handles ISBNTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            'User has entered isbn number
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            Dim cmdString = "select * from Books where ISBN = '" & ISBNTextBox1.Text & "'"
            cn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)

            Dim reader As OleDbDataReader = cmd.ExecuteReader
            myButton.Text = "Add"


            While reader.Read()
                TitleTextBox.Text = reader("Title")
                TotalTextBox.Text = reader("Total")
                RemainingTextBox.Text = reader("Remaining")
                LocationTextBox.Text = reader("Location")
                PublisherTextBox.Text = reader("Publisher")
                AuthorTextBox.Text = reader("Author")
                FieldTextBox.Text = reader("Field")
                PublishYearDateTimePicker.Value = reader("PublishYear")
                'ImageTextBox.Text = reader("Image")
                myButton.Text = "Modify"
            End While
            cn.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles myButton.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        Dim cmdString As String

        'Todo : make sure add number is greater than 0

        cn.Open()
        TotalTextBox.Text = AddNumber.Value + Convert.ToInt64(TotalTextBox.Text)
        If myButton.Text = "Add" Then
            cmdString = "insert into Books values(" & ISBNTextBox1.Text & ", " & TotalTextBox.Text & "," & TotalTextBox.Text & "," & LocationTextBox.Text & "," & PublishYearDateTimePicker.Value & ",'" & TitleTextBox.Text & "','" & AuthorTextBox.Text & "','" & PublisherTextBox.Text & "','" & FieldTextBox.Text & "','" & ImageTextBox.Text & "')"
        Else
            cmdString = "update Books set Total= " & TotalTextBox.Text & ",PublishYear='" & PublishYearDateTimePicker.Value & "',Location= '" & LocationTextBox.Text & "',Title='" & TitleTextBox.Text & "',Author='" & AuthorTextBox.Text & "',Field='" & FieldTextBox.Text & "' and Publisher='" & PublisherTextBox.Text & "' where ISBN='" & ISBNTextBox1.Text & "'"
        End If
        Console.WriteLine(cmdString)

        Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader
        reader.Close()
        Dim min, max As Integer
        min = Integer.MaxValue
        max = Integer.MinValue
        cmd.CommandText = "insert into Borrowed (ISBN) values ('" & ISBNTextBox1.Text & "') "

        For index As Integer = 1 To AddNumber.Value

            Console.WriteLine(cmd.ExecuteScalar)
            cmd.CommandText = "select @@identity"
            Dim tmp As Integer = cmd.ExecuteScalar

            If tmp > max Then
                max = tmp
            End If
            If tmp < min Then
                min = tmp
            End If
            cmd.CommandText = "insert into Borrowed (ISBN) values ('" & ISBNTextBox1.Text & "') "
        Next
        Console.WriteLine(min)
        Console.WriteLine(max)
        'print min and max on screen


    End Sub

    Private Sub ISBNTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
',Author='" & AuthorTextBox.Text & "',Field='" & FieldTextBox.Text & "',Image='" & ImageTextBox.Text & "'
