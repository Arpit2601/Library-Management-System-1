Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class MainPage
    ' Connection string for accessing database
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb"

    ' Main function to dynamically create thumbnails while books are searched
    ' It has a parameter of reader which reads the books from Books table
    Public Sub Thumbnails(reader As OleDbDataReader)


        Panel2.Controls.Clear()
        ' In one row we are showing three thumbnails
        ' boxWidth, boxHeight are the width and height of one thumbnail
        ' nextX and nextY are the x and y coordinates of next thumbnail
        Dim boxWidth As Integer = Panel2.Width / 3
        Dim boxHeight As Integer = 220
        Dim nextX As Integer = 0
        Dim nextY As Integer = 0

        While reader.Read()
            ' FullPath has the relative path of book image
            Dim fullPath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & reader("BookImage")

            ' Titlelabel has the title of book
            ' Authorlabel has the name of author
            ' Publisherlabel has name of publisher
            ' Locationlabel has location of book
            ' pictureBox has the image of book
            ' border is also a picture box. All the above items are placed on it so it looks like a border 
            Dim Titlelabel As New LinkLabel
            Dim Authorlabel As New Label
            Dim Publisherlabel As New Label
            Dim Locationlabel As New Label
            Dim pictureBox As New PictureBox
            Dim border As New PictureBox

            ' Specifying the sizes of all the above mentioned controls
            border.Size = New Size(390, 210)
            Titlelabel.Size = New Size(170, 20)
            Authorlabel.Size = New Size(170, 20)
            Publisherlabel.Size = New Size(170, 20)
            Locationlabel.Size = New Size(170, 20)
            pictureBox.Size = New Size(200, 200)

            ' Specifying the sizemode of picture box and text of labels of all the controls
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Titlelabel.Tag = reader("ISBN")
            pictureBox.Tag = reader("ISBN")
            pictureBox.ImageLocation = fullPath
            Titlelabel.Text = "Title: " & reader("Title")
            Authorlabel.Text = "Author: " & reader("Author")
            Publisherlabel.Text = "Publisher: " & reader("Publisher")
            Locationlabel.Text = "Location: " & reader("Location")

            ' Specifying the font colors of all the labels
            Titlelabel.VisitedLinkColor = Color.Black
            Titlelabel.LinkColor = Color.Black
            Titlelabel.ForeColor = Color.Black
            pictureBox.ForeColor = Color.Black
            Titlelabel.ForeColor = Color.Black
            Authorlabel.ForeColor = Color.Black
            Publisherlabel.ForeColor = Color.Black
            Locationlabel.ForeColor = Color.Black

            ' Specifying the back colors of all the controls
            Titlelabel.BackColor = Color.LightGray
            pictureBox.BackColor = Color.LightGray
            Titlelabel.BackColor = Color.LightGray
            Authorlabel.BackColor = Color.LightGray
            Publisherlabel.BackColor = Color.LightGray
            Locationlabel.BackColor = Color.LightGray
            border.BackColor = Color.LightGray

            ' Specifying the locations of all the controls
            border.Location = New Point(nextX + 5, nextY + 5)
            pictureBox.Location = New Point(nextX + 10, nextY + 10)
            Titlelabel.Location = New Point(nextX + 220, nextY + 10)
            Authorlabel.Location = New Point(nextX + 220, nextY + 30)
            Publisherlabel.Location = New Point(nextX + 220, nextY + 60)
            Locationlabel.Location = New Point(nextX + 220, nextY + 90)

            ' Setting AutoEllipsis to true so ... appears after size of lable is crossed
            Authorlabel.AutoEllipsis = True
            Locationlabel.AutoEllipsis = True
            Publisherlabel.AutoEllipsis = True
            Titlelabel.AutoEllipsis = True

            ' Sending the border back of all the above controls
            border.SendToBack()

            ' Setting font properties
            Titlelabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Authorlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Publisherlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Locationlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)

            ' Adding controls to panel
            Me.Panel2.Controls.Add(Titlelabel)
            Me.Panel2.Controls.Add(pictureBox)
            Me.Panel2.Controls.Add(Authorlabel)
            Me.Panel2.Controls.Add(Publisherlabel)
            Me.Panel2.Controls.Add(Locationlabel)
            Me.Panel2.Controls.Add(border)

            ' Adding handlers to open book detail page by clicking on title label and picture box
            AddHandler pictureBox.Click, AddressOf pictureBox_click
            AddHandler pictureBox.MouseEnter, AddressOf pictureBox_MouseEnter
            AddHandler Titlelabel.Click, AddressOf Titlelabel_click

            ' Setting position for next thumbnail
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


    ' Show book detail view on clicking on image
    ' Tag has the ISBN of book to be displayed
    Private Sub pictureBox_click(ByVal sender As Object, ByVal e As EventArgs)
        Dim frm As New BookDetails
        frm.passISBN = sender.tag
        frm.ShowDialog()
    End Sub


    ' Show book detail view on clicking on title label
    ' Tag has the ISBN of book to be displayed
    Private Sub Titlelabel_click(ByVal sender As Object, ByVal e As EventArgs)
        Dim frm As New BookDetails
        frm.passISBN = sender.tag
        frm.ShowDialog()
    End Sub


    ' Main function to show all the books in the library by clicking on browse button
    ' It searches for all the books in the library then calls Thumbnails function to display them
    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Books "
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Thumbnails(reader)
        cn.Close()
    End Sub


    ' To show login form
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Login.Show()
    End Sub


    ' Funciton for searching books based on particular criteria
    ' Search button will work only of one of the radio button is checked else it will display message to seect a field
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' If title radio is checked show all the books whose title mathes to that given in test box
        ' It will also do substring searching
        If TitleRadioButton.Checked = True Then
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            Dim selectString As String = "SELECT * FROM Books WHERE Title like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            cn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()

            ' If title radio is checked show all the books whose ISBN mathes to that given in test box
            ' It will also do substring searching
        ElseIf ISBNRadioButton.Checked = True Then
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()

            ' If title radio is checked show all the books whose Field mathes to that given in test box
            ' It will also do substring searching
        ElseIf FieldRadioButton1.Checked = True Then
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE Field like '%" & SearchTextBox.Text & "%'"

            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()

            ' If title radio is checked show all the books whose Publisher mathes to that given in test box
            ' It will also do substring searching
        ElseIf PublisherRadioButton.Checked = True Then
            Dim cn As OleDbConnection = New OleDbConnection(connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE Publisher like '%" & SearchTextBox.Text & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Thumbnails(reader)
            cn.Close()

            ' If title radio is checked show all the books whose author mathes to that given in test box
            ' It will also do substring searching
        ElseIf AuthorRadioButton.Checked = True Then
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

    ' Exit Button
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

    ' Timer is enabled on form load
    ' It will be used in email notifications
    Private Sub MainPage_load() Handles MyBase.Load
        Timer2.Enabled = True
    End Sub

    ' sendReminders is used to send emails if last date of book returning is coming close
    Private Sub timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim time As Date = Date.Now
        Dim ReportHour As Integer = 16
        Dim currhour As Integer = time.Hour

        If currhour = ReportHour Then
            sendReminders()
        End If
    End Sub
End Class
