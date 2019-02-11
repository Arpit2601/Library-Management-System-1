Imports System.Data.OleDb
Imports System.Text.RegularExpressions


Public Class addBook

    Dim connectionString = MainPage.connectionString
    Dim ISBNinput As String = ""


    Private Sub ISBNTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ISBNTextBox1.KeyDown

        ' First check if ISBN is correct
        ' It should contain only 10 or 13 digits with '-' in between
        Dim regex As Regex = New Regex("^(97(8|9))?\d{9}(\d|X)$")
        Console.Write(e.KeyCode)
        If e.KeyCode = Keys.Enter Then
            ISBNinput = ""
            Console.WriteLine(ISBNTextBox1.Text)
            For Each ch In ISBNTextBox1.Text
                If ch >= "0" AndAlso ch <= "9" Or ch = "x" Or ch = "X" Then
                    ISBNinput += ch
                ElseIf ch <> "-" Then
                    MessageBox.Show("Invalid ISBN Number")
                    Return
                End If
            Next
            Console.WriteLine(ISBNinput)
            If regex.IsMatch(ISBNinput) AndAlso ValidateISBN(ISBNinput) Then
                myfunction()
            Else
                MessageBox.Show("Invalid ISBN Number")
                Return
            End If
        End If
    End Sub


    ' Main function to add book in library
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles myButton.Click

        If myButton.Text = "Search" Then
            Dim regex As Regex = New Regex("^(97(8|9))?\d{9}(\d|X)$")
            ISBNinput = ""
            Console.WriteLine(ISBNTextBox1.Text)
            For Each ch In ISBNTextBox1.Text
                If ch >= "0" AndAlso ch <= "9" Or ch = "x" Or ch = "X" Then
                    ISBNinput += ch
                ElseIf ch <> "-" Then
                    MessageBox.Show("Invalid ISBN Number")
                    Return
                End If
            Next
            Console.WriteLine(ISBNinput)
            If regex.IsMatch(ISBNinput) AndAlso ValidateISBN(ISBNinput) Then
                myfunction()
            Else
                MessageBox.Show("Invalid ISBN Number")
                Return
            End If
            Return
        End If

        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        Dim cmdString As String

        ' Validation for all the fields of book
        If Not ValidateInput() Then
            Return
        End If
        ' If no image is selected then set image of book to default image
        Dim imgLocation As String = ISBNTextBox1.Text
        If PictureBox1.Image Is Nothing Then
            imgLocation = "defaultBook"
        End If
        cn.Open()
        TotalTextBox.Text = AddNumber.Value + Convert.ToInt64(TotalTextBox.Text)
        RemainingTextBox.Text = AddNumber.Value + Convert.ToInt64(RemainingTextBox.Text)
        ' If this book is not in the library then insert 
        If myButton.Text = "Add" Then
            cmdString = "insert into Books values('" & ISBNinput & "', " & TotalTextBox.Text & "," & TotalTextBox.Text & ",'" & LocationTextBox.Text & "','" & PublishYearDateTimePicker.Value.Date & "','" & TitleTextBox.Text & "','" & AuthorTextBox.Text & "','" & PublisherTextBox.Text & "','" & FieldTextBox.Text & "','" & imgLocation & ".JPG','" & PriceBox.Text & "', '0', '0')"

            ' Else update its information
        Else
            cmdString = "update Books set Total= " & TotalTextBox.Text & ",Remaining= " & RemainingTextBox.Text & ",PublishYear='" & PublishYearDateTimePicker.Value & "',Location= '" & LocationTextBox.Text & "',Title='" & TitleTextBox.Text & "',Author='" & AuthorTextBox.Text & "',Field='" & FieldTextBox.Text & "' , Publisher='" & PublisherTextBox.Text & "' ,BookImage='" & imgLocation & ".JPG' , Price='" & PriceBox.Text & "' where ISBN='" & ISBNinput & "'"
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

        ' Give new accession numbers to the books added and display in message box
        ' If no new books where added, only their information was modified then do not show new accession numbers
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

        If AddNumber.Value = 0 Then
            min = max = 0
            MessageBox.Show("The book is modified successfully")
        Else
            MessageBox.Show("Please mark the new books with accession numbers from " & min & " to " & max & ".", "Book Added Successfully")
        End If
        StaffLogin.refreshModifyBook()
        'print min and max on screen

    End Sub

    ' To upload the image of book
    Private Sub uploadButton_Click(sender As Object, e As EventArgs) Handles uploadButton.Click
        Dim fullPath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\defaultBook.jpg")
        If OpenFileDialog1.ShowDialog = DialogResult.Cancel Then
            PictureBox1.ImageLocation = fullPath
        Else
            PictureBox1.ImageLocation = OpenFileDialog1.FileName.ToString
        End If
    End Sub

    ' To prefill the information if book is being modified
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

    ' Function to validate all the information
    Friend Function ValidateInput() As Boolean
        If LocationTextBox.Text = "" Then
            MessageBox.Show("Please enter shelf location of the book")
            Return False
        ElseIf TitleTextBox.Text = "" Then
            MessageBox.Show("Please Enter Title of the Book")
            Return False
        ElseIf AuthorTextBox.Text = "" Then
            MessageBox.Show("Please Enter Author of the Book")
            Return False
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

        For Each c In AuthorTextBox.Text
            If Not Char.IsLower(c) And Not Char.IsUpper(c) And Not c = " " Then
                MessageBox.Show("Author name should contain only lowercase, uppercase or blankspace letters.", "Invalid author name")
                Return False
            End If
        Next

        ' Check all spaces in title
        Dim allSpaces As Boolean = True
        For Each c In TitleTextBox.Text
            If Not c = " " Then
                allSpaces = False
                Exit For
            End If
        Next

        If allSpaces Then
            MessageBox.Show("Please enter valid title", "Invalid Name")
            Return False
        End If

        ' Check all spaces in author
        allSpaces = True
        For Each c In AuthorTextBox.Text
            If Not c = " " Then
                allSpaces = False
                Exit For
            End If
        Next

        If allSpaces Then
            MessageBox.Show("Please enter valid author", "Invalid Name")
            Return False
        End If

        ' Check all spaces in publisher
        allSpaces = True
        For Each c In PublisherTextBox.Text
            If Not c = " " Then
                allSpaces = False
                Exit For
            End If
        Next

        If allSpaces Then
            MessageBox.Show("Please enter valid publisher", "Invalid Name")
            Return False
        End If


        For Each c In LocationTextBox.Text
            If Not c = "." And Not Char.IsNumber(c) Then
                MessageBox.Show("Enter valid shelf location", "Invalid location")
                Return False
            End If
        Next

        ' To check if price entered is number or not
        Dim countDot As Integer = 0
        For i As Integer = 0 To PriceBox.Text.Length - 1
            If PriceBox.Text(i) = "." Then
                countDot += 1
            ElseIf PriceBox.Text(i) < "0" Or PriceBox.Text(i) > "9" Then
                MessageBox.Show("Please Enter a valid Price for the book", "Invalid Price")
                Return False
            End If
        Next


        If countDot > 1 Or PriceBox.Text.Length - countDot < 1 Or PriceBox.Text(0) = "." Or PriceBox.Text(PriceBox.Text.Length - 1) = "." Then
            Return False
        End If

        If AddNumber.Value = 0 Then
            Dim result = MessageBox.Show("Are you sure you want to add no copies of this book?", "No copies added", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Return True
            Else
                Return False
            End If
        End If

        Return True
    End Function


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textBoxes = Me.Controls.OfType(Of TextBox)()
        Dim fullPath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\defaultBook.jpg")
        PictureBox1.ImageLocation = fullPath
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
