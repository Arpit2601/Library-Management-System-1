Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class BookDetails
    Public Property passISBN As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Books WHERE ISBN like '%" & passISBN & "%'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Thumbnails(reader)
        cn.Close()

        cn.Open()
        Dim borrowerstring As String = "SELECT * FROM Borrowed WHERE ISBN like '%" & passISBN & "%'"
        Dim cmd1 As OleDbCommand = New OleDbCommand(borrowerstring, cn)
        Dim reader1 As OleDbDataReader = cmd1.ExecuteReader()
        Borrowers(reader1)
        cn.Close()
    End Sub

    Public Sub Thumbnails(reader As OleDbDataReader)

        Panel1.Controls.Clear()
        Dim x, y, count As Integer
        count = 0
        x = Panel1.Location.X
        y = Panel1.Location.Y
        While reader.Read()
            Dim Titlelabel As New Label
            Dim Authorlabel As New Label
            Dim Publisherlabel As New Label
            Dim ISBNlabel As New Label
            Dim Totallabel As New Label
            Dim PublishYearlabel As New Label
            Dim Locationlabel As New Label
            Dim Remaininglabel As New Label
            Dim pictureBox As New PictureBox

            Titlelabel.Size = New Size(250, 40)
            Remaininglabel.Size = New Size(200, 40)
            Totallabel.Size = New Size(200, 40)
            ISBNlabel.Size = New Size(300, 40)
            Authorlabel.Size = New Size(250, 40)
            Publisherlabel.Size = New Size(250, 40)
            PublishYearlabel.Size = New Size(200, 40)
            Locationlabel.Size = New Size(250, 40)
            pictureBox.Size = New Size(200, 200)
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            'Titlelabel.Tag = reader("ISBN")
            pictureBox.Tag = reader("Image").ToString
            pictureBox.ImageLocation = reader("Image").ToString
            Titlelabel.Text = "Title: " & reader("Title")
            PublishYearlabel.Text = "Published on: " & reader("PublishYear")
            Remaininglabel.Text = "Remaining: " & reader("Remaining")
            Authorlabel.Text = "Author: " & reader("Author")
            Publisherlabel.Text = "Publisher: " & reader("Publisher")
            Locationlabel.Text = "Location: " & reader("Location")
            Totallabel.Text = "Total number: " & reader("Total")
            ISBNlabel.Text = "ISBN: " & reader("ISBN")

            pictureBox.Location = New Point(x, y)
            Titlelabel.Location = New Point(x + 350, y)
            Authorlabel.Location = New Point(x + 350, y + 50)
            Publisherlabel.Location = New Point(x + 350, y + 100)
            PublishYearlabel.Location = New Point(x + 350, y + 150)
            ISBNlabel.Location = New Point(x + 350, y + 200)
            Totallabel.Location = New Point(x + 350, y + 250)
            Remaininglabel.Location = New Point(x + 350, y + 300)
            Locationlabel.Location = New Point(x + 350, y + 350)

            x += 430
            count += 1
            If x > Panel1.Width Then
                x = Panel1.Location.X
                count = 0
                y += 250
            End If

            Me.Panel1.Controls.Add(Titlelabel)
            Me.Panel1.Controls.Add(PublishYearlabel)
            Me.Panel1.Controls.Add(pictureBox)
            Me.Panel1.Controls.Add(Authorlabel)
            Me.Panel1.Controls.Add(Publisherlabel)
            Me.Panel1.Controls.Add(Locationlabel)
            Me.Panel1.Controls.Add(Totallabel)
            Me.Panel1.Controls.Add(Remaininglabel)
            Me.Panel1.Controls.Add(ISBNlabel)
            'AddHandler pictureBox.Click, AddressOf pictureBox_click
            'AddHandler Titlelabel.Click, AddressOf Titlelabel_click
        End While
    End Sub

    Public Sub Borrowers(reader1 As OleDbDataReader)
        Panel2.Controls.Clear()
        Dim x, y, count As Integer
        count = 0
        x = Panel2.Location.X
        y = Panel2.Location.Y - 2 * Panel2.Height


        While reader1.Read()
            Dim userid As String = reader1("BorrowerId")
            Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Users WHERE UserId like '%" & userid & "%'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim Rolllabel As New Label
                Dim Emaillabel As New Label

                Rolllabel.Size = New Size(100, 20)
                Emaillabel.Size = New Size(200, 20)

                Rolllabel.Text = reader("Password")
                Emaillabel.Text = reader("Email")

                Rolllabel.Location = New Point(x, y)
                Emaillabel.Location = New Point(x + 100, y)
                y += 40

                Me.Panel2.Controls.Add(Rolllabel)
                Me.Panel2.Controls.Add(Emaillabel)
            End While
            cn.Close()
        End While
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class