Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient


' auto scroll of form and panel 2 to true and auto scale mode to  false
' dynamic connection strinng not working
Public Class MainPage
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb"

    Public Sub Thumbnails(reader As OleDbDataReader)

        Panel2.Controls.Clear()

        Dim boxWidth As Integer = Panel2.Width / 3
        Dim boxHeight As Integer = 220
        Dim nextX As Integer = 0
        Dim nextY As Integer = 0
      
        While reader.Read()
            Dim fullPath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & reader("BookImage")

            Dim Titlelabel As New LinkLabel
            Dim Authorlabel As New Label
            Dim Publisherlabel As New Label

            Dim Locationlabel As New Label
            Dim Remaininglabel As New Label
            Dim pictureBox As New PictureBox

            Titlelabel.Size = New Size(170, 20)
            Authorlabel.Size = New Size(170, 20)
            Publisherlabel.Size = New Size(170, 20)
            Locationlabel.Size = New Size(170, 20)
            pictureBox.Size = New Size(200, 200)
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Titlelabel.Tag = reader("ISBN")
            pictureBox.Tag = reader("ISBN")
            pictureBox.ImageLocation = fullPath
            Titlelabel.Text = "Title: " & reader("Title")
            Authorlabel.Text = "Author: " & reader("Author")
            Publisherlabel.Text = "Publisher: " & reader("Publisher")
            Locationlabel.Text = "Location: " & reader("Location")

            Titlelabel.VisitedLinkColor = Color.White
            Titlelabel.LinkColor = Color.White
            Titlelabel.ForeColor = Color.White
            pictureBox.ForeColor = Color.White
            Titlelabel.ForeColor = Color.White
            Authorlabel.ForeColor = Color.White
            Publisherlabel.ForeColor = Color.White
            Locationlabel.ForeColor = Color.White

            pictureBox.Location = New Point(nextX + 10, nextY + 10)
            Titlelabel.Location = New Point(nextX + 220, nextY + 10)
            Authorlabel.Location = New Point(nextX + 220, nextY + 30)
            Publisherlabel.Location = New Point(nextX + 220, nextY + 60)
            Locationlabel.Location = New Point(nextX + 220, nextY + 90)

            Authorlabel.AutoEllipsis = True
            Locationlabel.AutoEllipsis = True
            Publisherlabel.AutoEllipsis = True
            Titlelabel.AutoEllipsis = True

            Titlelabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Authorlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Publisherlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Locationlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)

            Me.Panel2.Controls.Add(Titlelabel)
            Me.Panel2.Controls.Add(pictureBox)
            Me.Panel2.Controls.Add(Authorlabel)
            Me.Panel2.Controls.Add(Publisherlabel)
            Me.Panel2.Controls.Add(Locationlabel)
            AddHandler pictureBox.Click, AddressOf pictureBox_click
            AddHandler pictureBox.MouseEnter, AddressOf pictureBox_MouseEnter
            AddHandler Titlelabel.Click, AddressOf Titlelabel_click

            nextX += boxWidth
            If nextX = Panel2.Width Then
                nextX = 0
                nextY += boxHeight
            End If
        End While
    End Sub

    Private Sub pictureBox_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
        sender.cursor = Cursors.Hand
    End Sub

    ' make a new form with name Information and show all the information of book on it 
    ' new form will be opened by clicking on the image or on the title of book
    Private Sub pictureBox_click(ByVal sender As Object, ByVal e As EventArgs)
        Dim frm As New BookDetails
        frm.passISBN = sender.tag
        frm.Show()
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

        ElseIf ISBNRadioButton.Checked = True Then
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()

        ElseIf FieldRadioButton1.Checked = True Then
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE Field like '%" & SearchTextBox.Text & "%'"

            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()

        ElseIf PublisherRadioButton.Checked = True Then
            ' Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE Publisher like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()

        ElseIf AuthorRadioButton.Checked = True Then
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;data Source=C:\Users\ARPIT\Desktop\project 2\Library-Management-System\LibraryManagementSystem\Database.accdb"
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE Author like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)

            cn.Close()
        Else
            MessageBox.Show("Please choose a search criteria", "No radio buttons checked")
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub SearchTextBox_Enter(sender As Object, e As EventArgs) Handles SearchTextBox.Enter
        If SearchTextBox.Text = "Enter Book Details" Then
            SearchTextBox.Text = ""
            Dim objFont As System.Drawing.Font

            objFont = New System.Drawing.Font("Comic Sans MS", 12, FontStyle.Regular)


            SearchTextBox.Font = objFont
            SearchTextBox.ForeColor = Color.Black
        End If
    End Sub


    Private Sub SearchTextBox_Leave(sender As Object, e As EventArgs) Handles SearchTextBox.Leave
        If SearchTextBox.Text = "" Then
            Dim objfont As System.Drawing.Font
            objfont = New System.Drawing.Font("Comic Sans MS", 12, FontStyle.Italic)
            SearchTextBox.Font = objfont
            SearchTextBox.ForeColor = Color.Gray
            SearchTextBox.Text = "Enter Book Details"
        End If
    End Sub


    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
