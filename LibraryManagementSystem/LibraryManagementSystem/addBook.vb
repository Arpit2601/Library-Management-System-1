Imports System.Data.OleDb
Imports System.Text.RegularExpressions


Public Class addBook
    'Global variables 
    Dim connectionString = MainPage.connectionString
    Dim ISBNinput As String = ""


    Private Sub ISBNTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ISBNTextBox1.KeyDown
        Dim regex As Regex = New Regex("^(97(8|9))?\d{9}(\d|X)$")
        Console.Write(e.KeyCode)
        If e.KeyCode = Keys.Enter Then
            If regex.IsMatch(ISBNTextBox1.Text) AndAlso ValidateISBN(ISBNinput) Then
                myfunction()
            Else
                MessageBox.Show("Invalid ISBN Number")
            End If
        End If
    End Sub

    Private Sub ISBNTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ISBNTextBox1.KeyPress
        If ISBNinput.Length > 13 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) >= 48 AndAlso Asc(e.KeyChar) <= 57 Or e.KeyChar = "X" Or e.KeyChar = "x" Then
            ISBNinput = ISBNinput + e.KeyChar
        ElseIf Asc(e.KeyChar) <> 45 AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 AndAlso ISBNinput.Length > 0 Then
            ISBNinput = ISBNinput.Remove(ISBNinput.Length - 1)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles myButton.Click

        If myButton.Text = "Search" Then
            Dim regex As Regex = New Regex("^(97(8|9))?\d{9}(\d|X)$")

            If regex.IsMatch(ISBNTextBox1.Text) AndAlso ValidateISBN(ISBNinput) Then
                myfunction()
            Else
                MessageBox.Show("Invalid ISBN Number")
            End If
            Return
        End If

        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        Dim cmdString As String

        If Not ValidateInput() Then
            Return
        End If
        Dim imgLocation As String = ISBNTextBox1.Text
        If PictureBox1.Image Is Nothing Then
            imgLocation = "defaultBook"
        End If

        cn.Open()
        TotalTextBox.Text = AddNumber.Value + Convert.ToInt64(TotalTextBox.Text)
        If myButton.Text = "Add" Then
            cmdString = "insert into Books values(" & ISBNinput & ", " & TotalTextBox.Text & "," & TotalTextBox.Text & "," & LocationTextBox.Text & ",'" & PublishYearDateTimePicker.Value.Date & "','" & TitleTextBox.Text & "','" & AuthorTextBox.Text & "','" & PublisherTextBox.Text & "','" & FieldTextBox.Text & "','" & imgLocation & ".JPG'," & PriceBox.Text & ")"
            MessageBox.Show("book added succeffuly")
        Else
            MessageBox.Show("book modified succeffuly")
            cmdString = "update Books set Total= " & TotalTextBox.Text & ",PublishYear='" & PublishYearDateTimePicker.Value & "',Location= '" & LocationTextBox.Text & "',Title='" & TitleTextBox.Text & "',Author='" & AuthorTextBox.Text & "',Field='" & FieldTextBox.Text & "' , Publisher='" & PublisherTextBox.Text & "' ,BookImage='" & imgLocation & ".JPG'where ISBN='" & ISBNinput & "'"
        End If

        If PictureBox1.Image IsNot Nothing Then
            PictureBox1.Image.Save(System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & imgLocation & ".JPG")
        End If


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

        For Each Control In Me.Controls
            Control.visible = True
        Next


        ISBNTextBox1.Enabled = False
        Return True
    End Function

    Friend Function ValidateInput() As Boolean
        If LocationTextBox.Text = "" Then
            MessageBox.Show("Please enter shelf location of the book")
            Return False
        ElseIf TitleTextBox.Text = "" Then
            MessageBox.Show("Please Enter Title of the Book")
            Return False
        ElseIf AuthorTextBox.Text = "" Then
            MessageBox.Show("Please Enter Author of the Book")

        ElseIf PublisherTextBox.Text = "" Then
            MessageBox.Show("Please Enter Publisher of the Book")
            Return False
        ElseIf FieldTextBox.Text = "" Then
            MessageBox.Show("Please Enter Field of the Book")
            Return False
        ElseIf PriceBox.Text = "" Then
            MessageBox.Show("Please Enter Price of the Book")
            Return False
        End If

        Dim countDot As Integer = 0
        For i As Integer = 0 To PriceBox.Text.Length - 1
            If PriceBox.Text(i) = "." Then
                countDot += 1
            ElseIf PriceBox.Text(i) <= "0" Or PriceBox.Text(i) >= "9" Then
                MessageBox.Show("Invalid Price Entered.Please Enter a valid Price for the book")
                Return False
            End If
        Next

        If countDot > 1 Or PriceBox.Text.Length - countDot < 1 Or PriceBox.Text(0) = "." Or PriceBox.Text(PriceBox.Text.Length - 1) = "." Then
            Return False
        End If

        Return True
    End Function


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textBoxes = Me.Controls.OfType(Of TextBox)()

        For Each txt In textBoxes
            AddHandler txt.KeyDown, AddressOf ReturnHandler
        Next
    End Sub
    Public Sub ReturnHandler(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

End Class
