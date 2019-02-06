Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient


' auto scroll of form and panel 2 to true and auto scale mode to  false
' dynamic connection strinng not working
Public Class MainPage
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb"
    'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\LibraryManagementSystem\Database.accdb"

    Private Sub TitleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TitleRadioButton.CheckedChanged
        AuthorRadioButton.Checked = False
        FieldRadioButton1.Checked = False
        PublisherRadioButton.Checked = False
        If TitleRadioButton.Checked = True Then
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            Dim selectString As String = "SELECT * FROM Books WHERE Title like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            cn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()
        End If
    End Sub

    Private Sub AuthorRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AuthorRadioButton.CheckedChanged
        TitleRadioButton.Checked = False
        FieldRadioButton1.Checked = False
        PublisherRadioButton.Checked = False
        ISBNRadioButton.Checked = False
        If AuthorRadioButton.Checked = True Then
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE Author like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)

            cn.Close()
        End If
    End Sub

    Private Sub FieldRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles FieldRadioButton1.CheckedChanged
        AuthorRadioButton.Checked = False
        PublisherRadioButton.Checked = False
        TitleRadioButton.Checked = False
        ISBNRadioButton.Checked = False
        If FieldRadioButton1.Checked = True Then
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE Field like '%" & SearchTextBox.Text & "%'"

            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()
        End If
    End Sub

    Private Sub PublisherRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PublisherRadioButton.CheckedChanged
        AuthorRadioButton.Checked = False
        FieldRadioButton1.Checked = False
        TitleRadioButton.Checked = False
        ISBNRadioButton.Checked = False
        If PublisherRadioButton.Checked = True Then
            ' Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE Publisher like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()
        End If
    End Sub

    Private Sub ISBNRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ISBNRadioButton.CheckedChanged
        AuthorRadioButton.Checked = False
        FieldRadioButton1.Checked = False
        TitleRadioButton.Checked = False
        PublisherRadioButton.Checked = False
        If ISBNRadioButton.Checked = True Then
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()
        End If
    End Sub

    Public Sub Thumbnails(reader As OleDbDataReader)

        Panel2.Controls.Clear()
        Dim x, y, count As Integer
        count = 0
        x = Panel2.Location.X
        y = -Panel2.Location.Y + Panel2.Height
        While reader.Read()
            Dim Titlelabel As New LinkLabel
            Dim Authorlabel As New Label
            Dim Publisherlabel As New Label

            Dim Locationlabel As New Label
            Dim Remaininglabel As New Label
            Dim pictureBox As New PictureBox

            Titlelabel.Size = New Size(150, 20)
            Authorlabel.Size = New Size(150, 20)
            Publisherlabel.Size = New Size(150, 20)
            Locationlabel.Size = New Size(150, 20)
            pictureBox.Size = New Size(200, 200)
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Titlelabel.Tag = reader("ISBN")
            pictureBox.Tag = reader("Image").ToString
            pictureBox.ImageLocation = reader("Image").ToString
            Titlelabel.Text = "Title: " & reader("Title")
            Authorlabel.Text = "Author: " & reader("Author")
            Publisherlabel.Text = "Publisher: " & reader("Publisher")
            Locationlabel.Text = "Location: " & reader("Location")

            pictureBox.Location = New Point(x, y)
            Titlelabel.Location = New Point(x + 220, y)
            Authorlabel.Location = New Point(x + 220, y + 30)
            Publisherlabel.Location = New Point(x + 220, y + 60)
            Locationlabel.Location = New Point(x + 220, y + 90)

            x += 430
            count += 1
            If x > Panel2.Width Then
                x = Panel2.Location.X
                count = 0
                y += 250
            End If

            Me.Panel2.Controls.Add(Titlelabel)
            Me.Panel2.Controls.Add(pictureBox)
            Me.Panel2.Controls.Add(Authorlabel)
            Me.Panel2.Controls.Add(Publisherlabel)
            Me.Panel2.Controls.Add(Locationlabel)
            AddHandler pictureBox.Click, AddressOf pictureBox_click
            AddHandler Titlelabel.Click, AddressOf Titlelabel_click
        End While
    End Sub


    ' make a new form with name Information and show all the information of book on it 
    ' new form will be opened by clicking on the image or on the title of book
    Private Sub pictureBox_click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim Form2Caller As New Information
        'Form2Caller.SetInformation(sender.Tag)
    End Sub


    Private Sub Titlelabel_click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim Form2Caller As New Information
        Dim frm As New BookDetails
        frm.passISBN = sender.tag
        frm.Show()
        'Form2Caller.SetInformation(sender.Text)
    End Sub



    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Books "
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Thumbnails(reader)
        cn.Close()
    End Sub



   
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TitleRadioButton.Checked = True Then
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            Dim selectString As String = "SELECT * FROM Books WHERE Title like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            cn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()
        End If

        If ISBNRadioButton.Checked = True Then
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()
        End If

        If FieldRadioButton1.Checked = True Then
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE Field like '%" & SearchTextBox.Text & "%'"

            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()
        End If

        If PublisherRadioButton.Checked = True Then
            ' Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE Publisher like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()
        End If

        If AuthorRadioButton.Checked = True Then
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE Author like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)

            cn.Close()
        End If
    End Sub
End Class
