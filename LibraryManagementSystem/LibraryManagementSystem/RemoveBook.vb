'Imports System.Data.OleDb
'Imports System.Text.RegularExpressions

'Public Class RemoveBook

'    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
'        If btnRemove.Text = "Search" Then
'            Dim regex As Regex = New Regex("^(97(8|9))?\d{9}(\d|X)$")

'            If regex.IsMatch(txtISBN.Text) AndAlso ValidateISBN(ISBNinput) Then
'                myfunction()
'            Else
'                MessageBox.Show("Invalid ISBN Number")
'            End If
'            Return
'        End If

'        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
'        Dim cmdString As String

'        If Not ValidateInput() Then
'            Return
'        End If
'        Dim imgLocation As String = ISBNTextBox1.Text
'        If PictureBox1.Image Is Nothing Then
'            imgLocation = "defaultBook"
'        End If

'        cn.Open()
'        TotalTextBox.Text = AddNumber.Value + Convert.ToInt64(TotalTextBox.Text)
'        If myButton.Text = "Add" Then
'            cmdString = "insert into Books values(" & ISBNinput & ", " & TotalTextBox.Text & "," & TotalTextBox.Text & "," & LocationTextBox.Text & ",'" & PublishYearDateTimePicker.Value.Date & "','" & TitleTextBox.Text & "','" & AuthorTextBox.Text & "','" & PublisherTextBox.Text & "','" & FieldTextBox.Text & "','" & imgLocation & ".JPG'," & PriceBox.Text & ")"
'            MessageBox.Show("book added succeffuly")
'        Else
'            MessageBox.Show("book modified succeffuly")
'            cmdString = "update Books set Total= " & TotalTextBox.Text & ",PublishYear='" & PublishYearDateTimePicker.Value & "',Location= '" & LocationTextBox.Text & "',Title='" & TitleTextBox.Text & "',Author='" & AuthorTextBox.Text & "',Field='" & FieldTextBox.Text & "' , Publisher='" & PublisherTextBox.Text & "' ,BookImage='" & imgLocation & ".JPG'where ISBN='" & ISBNinput & "'"
'        End If

'        If PictureBox1.Image IsNot Nothing Then
'            PictureBox1.Image.Save(System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & imgLocation & ".JPG")
'        End If


'        Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
'        Dim reader As OleDbDataReader = cmd.ExecuteReader
'        reader.Close()
'        Dim min, max As Integer
'        min = Integer.MaxValue
'        max = Integer.MinValue
'        cmd.CommandText = "insert into Borrowed (ISBN) values ('" & ISBNinput & "') "

'        For index As Integer = 1 To AddNumber.Value

'            Console.WriteLine(cmd.ExecuteScalar)
'            cmd.CommandText = "select @@identity"
'            Dim tmp As Integer = cmd.ExecuteScalar

'            If tmp > max Then
'                max = tmp
'            End If
'            If tmp < min Then
'                min = tmp
'            End If
'            cmd.CommandText = "insert into Borrowed (ISBN) values ('" & ISBNinput & "') "
'        Next
'        Console.WriteLine(min)
'        Console.WriteLine(max)
'        'print min and max on screen
'    End Sub
'End Class
