Imports System.Data.OleDb
Imports System.Text.RegularExpressions


Public Class addBook
    Dim ISBNinput As String = ""
    Private Sub ISBNTextBox1_TextChanged(sender As Object, e As KeyEventArgs) Handles ISBNTextBox1.KeyDown
        Dim regex As Regex = New Regex("^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$")
        Console.Write(e.KeyCode)
        If e.KeyCode = Keys.Enter Then
            Console.WriteLine()
            Console.WriteLine(ISBNinput)

            If regex.IsMatch(ISBNTextBox1.Text) AndAlso validateISBN(ISBNinput) Then
                myfunction()
            Else
                MessageBox.Show("Invalid ISBN Number")
            End If
        End If
    End Sub

    Private Sub ISBNTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ISBNTextBox1.KeyPress
        If ISBNinput.Length > 13 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) <= 57 Then
            ISBNinput += e.KeyChar
        ElseIf Asc(e.KeyChar) <> 45 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 AndAlso ISBNinput.Length > 0 Then
            ISBNinput = ISBNinput.Remove(ISBNinput.Length - 1)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles myButton.Click

        If myButton.Text = "Search" Then
            Dim regex As Regex = New Regex("^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$")

            If regex.IsMatch(ISBNTextBox1.Text) AndAlso validateISBN(ISBNinput) Then
                myfunction()
            Else
                MessageBox.Show("Invalid ISBN Number")
            End If
            Return
        End If

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        Dim cmdString As String

        'To do create a better function for checking price
        If Not IsNumeric(PriceBox.Text) Then
            MessageBox.Show("Enter a valid Price for the book")
        End If

        cn.Open()
        TotalTextBox.Text = AddNumber.Value + Convert.ToInt64(TotalTextBox.Text)
        If myButton.Text = "Add" Then
            cmdString = "insert into Books values(" & ISBNinput & ", " & TotalTextBox.Text & "," & TotalTextBox.Text & "," & LocationTextBox.Text & ",'" & PublishYearDateTimePicker.Value.Date & "','" & TitleTextBox.Text & "','" & AuthorTextBox.Text & "','" & PublisherTextBox.Text & "','" & FieldTextBox.Text & "','" & ISBNinput & ".JPG'," & PriceBox.Text & ")"
            PictureBox1.Image.Save(System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & ISBNTextBox1.Text & ".JPG")
        Else
            cmdString = "update Books set Total= " & TotalTextBox.Text & ",PublishYear='" & PublishYearDateTimePicker.Value & "',Location= '" & LocationTextBox.Text & "',Title='" & TitleTextBox.Text & "',Author='" & AuthorTextBox.Text & "',Field='" & FieldTextBox.Text & "' and Publisher='" & PublisherTextBox.Text & "' where ISBN='" & ISBNinput & "'"
            PictureBox1.Image.Save(System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & ISBNTextBox1.Text & ".JPG")
        End If
        Console.WriteLine(cmdString)

        Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader
        reader.Close()
        Dim min, max As Integer
        min = Integer.MaxValue
        max = Integer.MinValue
        cmd.CommandText = "insert into Borrowed (ISBN) values ('" & ISBNinput & "') "

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
            cmd.CommandText = "insert into Borrowed (ISBN) values ('" & ISBNinput & "') "
        Next
        Console.WriteLine(min)
        Console.WriteLine(max)
        'print min and max on screen

    End Sub

    Private Sub uploadButton_Click(sender As Object, e As EventArgs) Handles uploadButton.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName.ToString
    End Sub

    Function myfunction() As Boolean
        'User has entered isbn number
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        Dim cmdString = "select * from Books where ISBN = '" & ISBNinput & "'"
        cn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)

        Dim reader As OleDbDataReader = cmd.ExecuteReader
        myButton.Text = "Add"

        While reader.Read()
            Dim fullPath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & reader("BookImage")
            Try
                TitleTextBox.Text = reader("Title")
                TotalTextBox.Text = reader("Total")
                RemainingTextBox.Text = reader("Remaining")
                LocationTextBox.Text = reader("Location")
                PublisherTextBox.Text = reader("Publisher")
                AuthorTextBox.Text = reader("Author")
                FieldTextBox.Text = reader("Field")
                PublishYearDateTimePicker.Value = reader("PublishYear")
                PriceBox.Text = reader("Price")
                PictureBox1.ImageLocation = fullPath
                myButton.Text = "Modify"
            Catch ex As Exception

            End Try
        End While
        cn.Close()

        TitleLabel.Show()
        TitleTextBox.Show()
        TotalLabel.Show()
        TotalTextBox.Show()
        RemainingLabel.Show()
        RemainingTextBox.Show()
        LocationLabel.Show()
        LocationTextBox.Show()
        PublisherLabel.Show()
        PublisherTextBox.Show()
        AuthorLabel.Show()
        AuthorTextBox.Show()
        FieldLabel.Show()
        FieldTextBox.Show()
        PublishYearLabel.Show()
        PublishYearDateTimePicker.Show()
        PriceLabel.Show()
        PriceBox.Show()
        PictureBox1.Show()
        ImageLabel.Show()
        uploadButton.Show()
        Return True
    End Function

    Function validateISBN(ISBNnumber As String) As String
        'Complete this function
        Return True
    End Function
End Class
