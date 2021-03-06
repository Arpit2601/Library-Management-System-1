﻿Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient


Public Class BookDetails

    ' This passISBN is sent from main page
    ' First serach for a particular book with this ISBN in Books table
    ' Then call Thumbnails function to show all its details
    ' From Borrowed table select all the users who have issued this book to display their information below the books detail panel
    Public Property passISBN As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Thumbnails(reader)
        Dim borrowerstring As String = "SELECT * FROM Borrowed WHERE ISBN = '" & passISBN & "' AND IsIssued=True"
        Dim cmd1 As OleDbCommand = New OleDbCommand(borrowerstring, cn)
        Dim reader1 As OleDbDataReader = cmd1.ExecuteReader()
        Borrowers(reader1)
        cn.Close()
    End Sub


    ' Most part is same as in Main page 
    ' Rating part is added which will show the average rating of the book given all the users
    Public Sub Thumbnails(reader As OleDbDataReader)
        Panel1.Controls.Clear()
        Dim x, y, count As Integer
        count = 0
        x = Panel1.Location.X
        y = Panel1.Location.Y
        While reader.Read()
            Dim fullPath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & reader("BookImage")

            Dim Titlelabel As New Label
            Dim Authorlabel As New Label
            Dim Publisherlabel As New Label
            Dim ISBNlabel As New Label
            Dim Totallabel As New Label
            Dim PublishYearlabel As New Label
            Dim Locationlabel As New Label
            Dim Remaininglabel As New Label
            Dim pictureBox As New PictureBox
            Dim lblAvgRating As New Label

            Dim pictureBox1 As New PictureBox
            Dim pictureBox2 As New PictureBox
            Dim pictureBox3 As New PictureBox
            Dim pictureBox4 As New PictureBox
            Dim pictureBox5 As New PictureBox

            Titlelabel.Size = New Size(250, 40)
            Remaininglabel.Size = New Size(200, 40)
            Totallabel.Size = New Size(200, 40)
            ISBNlabel.Size = New Size(300, 40)
            Authorlabel.Size = New Size(250, 40)
            Publisherlabel.Size = New Size(250, 40)
            PublishYearlabel.Size = New Size(200, 40)
            Locationlabel.Size = New Size(250, 40)
            lblAvgRating.Size = New Size(250, 40)

            pictureBox.Size = New Size(200, 250)
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox.Tag = fullPath
            pictureBox.ImageLocation = fullPath
            Titlelabel.Text = "Title: " & reader("Title")
            PublishYearlabel.Text = "Published on: " & reader("PublishYear")
            Remaininglabel.Text = "Remaining: " & reader("Remaining")
            Authorlabel.Text = "Author: " & reader("Author")
            Publisherlabel.Text = "Publisher: " & reader("Publisher")
            Locationlabel.Text = "Location: " & reader("Location")
            Totallabel.Text = "Total number: " & reader("Total")
            ISBNlabel.Text = "ISBN: " & reader("ISBN")


            ' Rating display
            ' Stars are displayed via picture boxes
            pictureBox1.Size = New Size(40, 40)
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage

            pictureBox2.Size = New Size(40, 40)
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage

            pictureBox3.Size = New Size(40, 40)
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage

            pictureBox4.Size = New Size(40, 40)
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage

            pictureBox5.Size = New Size(40, 40)
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage

            ' Get the average rating from books table by getting total number of stars of the book and total number of users who have rated it 
            Dim totalStars As Integer = Convert.ToInt32(reader("StarsNumber"))
            Dim people As Integer = Convert.ToInt32(reader("Raters"))
            Dim avgRating As Double
            If people = 0 Then
                avgRating = 0
            Else
                avgRating = totalStars / people
            End If

            lblAvgRating.Text = "Book Rating: " & avgRating.ToString("0.0") & "/5.0"

            ' If average rating is less than 0.25 show 0 stars
            If avgRating <= 0.25 Then
                pictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"

                ' If average rating is between than 0.25 and 0.75 show half stars
            ElseIf avgRating <= 0.75 Then
                pictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\halfstar.png"
                pictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"

                ' If average rating is between than 0.75 and 1.25 show one stars
            ElseIf avgRating <= 1.25 Then
                pictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"

                ' If average rating is between than 1.25 and 1.75 show one and a half stars
            ElseIf avgRating <= 1.75 Then
                pictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\halfstar.png"
                pictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"

                ' If average rating is between than 1.75 and 2.25 show two stars
            ElseIf avgRating <= 2.25 Then
                pictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"

                ' If average rating is between than 2.25 and 2.75 show two and a half stars
            ElseIf avgRating <= 2.75 Then
                pictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\halfstar.png"
                pictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"

                ' If average rating is between than 2.75 and 3.25 show three stars
            ElseIf avgRating <= 3.25 Then
                pictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                pictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"

                ' If average rating is between than 3.25 and 3.75 show three and a half stars
            ElseIf avgRating <= 3.75 Then
                pictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\halfstar.png"
                pictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"

                ' If average rating is between than 3.75 and 4.25 show four stars
            ElseIf avgRating <= 4.25 Then
                pictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"

                ' If average rating is between than 4.25 and 4.75 show four and a half stars
            ElseIf avgRating <= 4.75 Then
                pictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\halfstar.png"

                ' If average rating is between than 4.75 and 5 show five stars
            Else
                pictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                pictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"

            End If

            ISBNlabel.AutoEllipsis = True
            Titlelabel.AutoEllipsis = True
            PublishYearlabel.AutoEllipsis = True
            Remaininglabel.AutoEllipsis = True
            Authorlabel.AutoEllipsis = True
            Publisherlabel.AutoEllipsis = True
            Locationlabel.AutoEllipsis = True
            Totallabel.AutoEllipsis = True
            ISBNlabel.Text = "ISBN: " & reader("ISBN")
            Locationlabel.AutoEllipsis = True

            pictureBox.Location = New Point(x, y)
            pictureBox1.Location = New Point(x - 20, y + 270)
            pictureBox2.Location = New Point(x + 50 - 20, y + 270)
            pictureBox3.Location = New Point(x + 100 - 20, y + 270)
            pictureBox4.Location = New Point(x + 150 - 20, y + 270)
            pictureBox5.Location = New Point(x + 200 - 20, y + 270)
            Titlelabel.Location = New Point(x + 250, y)
            Authorlabel.Location = New Point(x + 250, y + 40)
            Publisherlabel.Location = New Point(x + 250, y + 80)
            PublishYearlabel.Location = New Point(x + 250, y + 120)
            ISBNlabel.Location = New Point(x + 250, y + 160)
            Totallabel.Location = New Point(x + 250, y + 200)
            Remaininglabel.Location = New Point(x + 250, y + 240)
            Locationlabel.Location = New Point(x + 250, y + 280)
            lblAvgRating.Location = New Point(x + 20, y + 320)

            Titlelabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Authorlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Publisherlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            PublishYearlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            ISBNlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Totallabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Remaininglabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Locationlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            lblAvgRating.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)

            Titlelabel.ForeColor = Color.White
            Authorlabel.ForeColor = Color.White
            Publisherlabel.ForeColor = Color.White
            PublishYearlabel.ForeColor = Color.White
            ISBNlabel.ForeColor = Color.White
            Totallabel.ForeColor = Color.White
            Remaininglabel.ForeColor = Color.White
            Locationlabel.ForeColor = Color.White
            lblAvgRating.ForeColor = Color.White

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
            Me.Panel1.Controls.Add(pictureBox1)
            Me.Panel1.Controls.Add(pictureBox2)
            Me.Panel1.Controls.Add(pictureBox3)
            Me.Panel1.Controls.Add(pictureBox4)
            Me.Panel1.Controls.Add(pictureBox5)
            Me.Panel1.Controls.Add(Authorlabel)
            Me.Panel1.Controls.Add(Publisherlabel)
            Me.Panel1.Controls.Add(Locationlabel)
            Me.Panel1.Controls.Add(Totallabel)
            Me.Panel1.Controls.Add(Remaininglabel)
            Me.Panel1.Controls.Add(ISBNlabel)
            Me.Panel1.Controls.Add(lblAvgRating)
        End While
    End Sub


    ' Function to show all the users who have this book checked out
    ' We have dynamically made labels s=to show name, department, phonenumber and email of user in one row
    Public Sub Borrowers(reader1 As OleDbDataReader)
        Panel2.Controls.Clear()
        Dim x, y, count As Integer
        count = 0
        x = Panel2.Width
        y = -1.05 * Panel2.Location.Y + 2 * Panel2.Height
        Dim nextx As Integer = Panel2.Location.X - 10
        Dim nexty As Integer = 0
        While reader1.Read()
            Dim userid As String = reader1("BorrowerId")
            Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Users WHERE UserName = '" & userid & "'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim Namelabel As New Label
                Dim Departmentlabel As New Label
                ' Dim PhoneNumber As New Label
                Dim Email As New Label

                Namelabel.Size = New Size(150, 25)
                Departmentlabel.Size = New Size(200, 25)
                'PhoneNumber.Size = New Size(150, 25)
                Email.Size = New Size(200, 25)

                Namelabel.Text = reader("ProfileName")
                Departmentlabel.Text = reader("Department")
                ' PhoneNumber.Text = reader("PhoneNumber")
                Email.Text = reader("Email")

                Namelabel.Location = New Point(nextx, y)
                Departmentlabel.Location = New Point(nextx + 170, y)
                'PhoneNumber.Location = New Point(nextx + 320, y)
                Email.Location = New Point(nextx + 370, y)

                Namelabel.Font = New System.Drawing.Font("Comic Sans MS", 9, FontStyle.Italic)
                Departmentlabel.Font = New System.Drawing.Font("Comic Sans MS", 9, FontStyle.Italic)
                'PhoneNumber.Font = New System.Drawing.Font("Comic Sans MS", 9, FontStyle.Italic)
                Email.Font = New System.Drawing.Font("Comic Sans MS", 9, FontStyle.Italic)

                Namelabel.ForeColor = Color.White
                Departmentlabel.ForeColor = Color.White
                'PhoneNumber.ForeColor = Color.White
                Email.ForeColor = Color.White

                Namelabel.AutoEllipsis = True
                Departmentlabel.AutoEllipsis = True
                'PhoneNumber.AutoEllipsis = True
                Email.AutoEllipsis = True

                y += 35

                Me.Panel2.Controls.Add(Namelabel)
                Me.Panel2.Controls.Add(Departmentlabel)
                'Me.Panel2.Controls.Add(PhoneNumber)
                Me.Panel2.Controls.Add(Email)
            End While
            cn.Close()
        End While
    End Sub
End Class