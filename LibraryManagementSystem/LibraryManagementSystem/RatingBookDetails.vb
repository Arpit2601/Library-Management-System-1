Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class RatingBookDetails

    ' passISBN has the ISBN of book to be rated
    ' str has the username of user who has rated the book
    ' prev contains the previous star count given to this book by this user
    Public Property passISBN As String
    Public Property prev As Integer
    Dim str As String = StudentLogin.UserName
    Public Property ct As Integer = 0

    ' To show book details
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

            Titlelabel.Size = New Size(250, 40)
            Remaininglabel.Size = New Size(200, 40)
            Totallabel.Size = New Size(200, 40)
            ISBNlabel.Size = New Size(300, 40)
            Authorlabel.Size = New Size(250, 40)
            Publisherlabel.Size = New Size(250, 40)
            PublishYearlabel.Size = New Size(200, 40)
            Locationlabel.Size = New Size(250, 40)
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

            pictureBox.Location = New Point(x, y + 10)
            Titlelabel.Location = New Point(x + 250, y)
            Authorlabel.Location = New Point(x + 250, y + 40)
            Publisherlabel.Location = New Point(x + 250, y + 80)
            PublishYearlabel.Location = New Point(x + 250, y + 120)
            ISBNlabel.Location = New Point(x + 250, y + 160)
            Totallabel.Location = New Point(x + 250, y + 200)
            Remaininglabel.Location = New Point(x + 250, y + 240)
            Locationlabel.Location = New Point(x + 250, y + 280)

            Titlelabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Authorlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Publisherlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            PublishYearlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            ISBNlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Totallabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Remaininglabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)
            Locationlabel.Font = New Font("Comic Sans MS", 11, FontStyle.Regular)

            Titlelabel.ForeColor = Color.White
            Authorlabel.ForeColor = Color.White
            Publisherlabel.ForeColor = Color.White
            PublishYearlabel.ForeColor = Color.White
            ISBNlabel.ForeColor = Color.White
            Totallabel.ForeColor = Color.White
            Remaininglabel.ForeColor = Color.White
            Locationlabel.ForeColor = Color.White

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
        End While
    End Sub

    ' On opening the page load all the information of book
    Private Sub RatingBookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Thumbnails(reader)
        cn.Close()
        cn.Open()
        Dim selectString1 As String = "SELECT * FROM RatingList WHERE ISBN = '" & passISBN & "' "
        cmd = New OleDbCommand(selectString1, cn)
        Dim reader1 As OleDbDataReader = cmd.ExecuteReader()

        ' Store previous star set by this user for this book in prev
        ' If ct =0 then user has yet not rated this book
        ' Else if ct=1 then this user has rated the book previously
        While reader1.Read()
            If reader1("UserName") = str Then
                prev = reader1("Starcount")
                ct += 1
            End If
        End While
        cn.Close()

        ' Display the stars according to prev value
        If ct = 0 Then
            PictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
            PictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
            PictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
            PictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
            PictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
        End If

        If ct = 1 Then
            If prev = 1 Then
                PictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                PictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                PictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                PictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
            End If

            If prev = 2 Then
                PictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                PictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                PictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
            End If

            If prev = 3 Then
                PictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
                PictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
            End If

            If prev = 4 Then
                PictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
            End If

            If prev = 5 Then
                PictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
                PictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
            End If
        End If

    End Sub

    ' On clicking on any star change the rating accordingly and set all the stars previous to it to yellow
    ' Store this data in the Rating table accordingly
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
        PictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
        PictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
        PictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        ct = 0
        Dim selectString1 As String = "SELECT * FROM RatingList WHERE ISBN = '" & passISBN & "' "
        Dim cmd As OleDbCommand = New OleDbCommand(selectString1, cn)
        Dim reader1 As OleDbDataReader = cmd.ExecuteReader()
        While reader1.Read()
            If reader1("UserName") = str Then
                prev = Convert.ToInt32(reader1("Starcount"))
                ct += 1
            End If
        End While
        cn.Close()
        Dim temp As Integer = 1
        Dim people As Integer = 1

        ' If user is rating this book for first time then make a new entry in Rating table and update star count and users count in books table
        If ct = 0 Then
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
            cmd = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                temp = Convert.ToInt32(reader("StarsNumber"))
                people = Convert.ToInt32(reader("Raters"))
                temp += 1
                people += 1
                Dim tempstr As String = "1"
                Dim cmdString As String = "insert into RatingList (ISBN, UserName, Starcount) values('" & passISBN & "', '" & str & "', ' " & tempstr & " ')"
                Dim cmd1 As OleDbCommand = New OleDbCommand(cmdString, cn)
                Dim r1 As OleDbDataReader = cmd1.ExecuteReader
                Dim updateString As String = "UPDATE Books SET StarsNumber='" & temp.ToString & "', Raters = '" & people.ToString & "' WHERE ISBN = '" & passISBN & "'"
                cmd1 = New OleDbCommand(updateString, cn)
                r1 = cmd1.ExecuteReader
                MessageBox.Show("Your rating has been submitted succesfully", "Success")
                r1.Close()
            End While
            cn.Close()

            ' If user has previously rated the book then simply update data in both Rating table and Books Table
        Else
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
            cmd = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                temp = Convert.ToInt32(reader("StarsNumber"))
                people = Convert.ToInt32(reader("Raters"))
                temp += 1
                temp -= prev
                'people += 1
                Dim tempstr As String = "1"
                Dim cmdString As String = "UPDATE RatingList SET Starcount='" & tempstr & "' WHERE ISBN = '" & passISBN & "' AND Username = '" & str & "'"
                Dim cmd1 As OleDbCommand = New OleDbCommand(cmdString, cn)
                Dim r1 As OleDbDataReader = cmd1.ExecuteReader
                Dim updateString As String = "UPDATE Books SET StarsNumber='" & temp.ToString & "', Raters = '" & people.ToString & "' WHERE ISBN = '" & passISBN & "'"
                cmd1 = New OleDbCommand(updateString, cn)
                r1 = cmd1.ExecuteReader
                MessageBox.Show("Your rating has been updated succesfully", "Success")
                r1.Close()
            End While
        End If
    End Sub


    ' Same as above. Only Difference is that here we set 2 stars for this book
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
        PictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
        PictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        ct = 0
        Dim selectString1 As String = "SELECT * FROM RatingList WHERE ISBN = '" & passISBN & "' "
        Dim cmd As OleDbCommand = New OleDbCommand(selectString1, cn)
        Dim reader1 As OleDbDataReader = cmd.ExecuteReader()
        While reader1.Read()
            If reader1("UserName") = str Then
                prev = Convert.ToInt32(reader1("Starcount"))
                ct += 1
            End If
        End While
        cn.Close()
        Dim temp As Integer = 1
        Dim people As Integer = 1
        If ct = 0 Then
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
            cmd = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                temp = Convert.ToInt32(reader("StarsNumber"))
                people = Convert.ToInt32(reader("Raters"))
                temp += 2
                people += 1
                Dim tempstr As String = "2"
                Dim cmdString As String = "insert into RatingList (ISBN, UserName, Starcount) values('" & passISBN & "', '" & str & "', ' " & tempstr & " ')"
                Dim cmd1 As OleDbCommand = New OleDbCommand(cmdString, cn)
                Dim r1 As OleDbDataReader = cmd1.ExecuteReader
                Dim updateString As String = "UPDATE Books SET StarsNumber='" & temp.ToString & "', Raters = '" & people.ToString & "' WHERE ISBN = '" & passISBN & "'"
                cmd1 = New OleDbCommand(updateString, cn)
                r1 = cmd1.ExecuteReader
                MessageBox.Show("Your rating has been submitted succesfully", "Success")
                r1.Close()
            End While
            cn.Close()
        Else
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
            cmd = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                temp = Convert.ToInt32(reader("StarsNumber"))
                people = Convert.ToInt32(reader("Raters"))
                temp += 2
                temp -= prev
                'people += 1
                Dim tempstr As String = "2"
                Dim cmdString As String = "UPDATE RatingList SET Starcount='" & tempstr & "' WHERE ISBN = '" & passISBN & "' AND Username = '" & str & "'"
                Dim cmd1 As OleDbCommand = New OleDbCommand(cmdString, cn)
                Dim r1 As OleDbDataReader = cmd1.ExecuteReader
                Dim updateString As String = "UPDATE Books SET StarsNumber='" & temp.ToString & "', Raters = '" & people.ToString & "' WHERE ISBN = '" & passISBN & "'"
                cmd1 = New OleDbCommand(updateString, cn)
                r1 = cmd1.ExecuteReader
                MessageBox.Show("Your rating has been updated succesfully", "Success")
                r1.Close()
            End While
        End If
    End Sub

    ' Same as above. Only Difference is that here we set 3 stars for this book
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
        PictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        ct = 0
        Dim selectString1 As String = "SELECT * FROM RatingList WHERE ISBN = '" & passISBN & "' "
        Dim cmd As OleDbCommand = New OleDbCommand(selectString1, cn)
        Dim reader1 As OleDbDataReader = cmd.ExecuteReader()
        While reader1.Read()
            If reader1("UserName") = str Then
                prev = Convert.ToInt32(reader1("Starcount"))
                ct += 1
            End If
        End While
        cn.Close()
        Dim temp As Integer = 1
        Dim people As Integer = 1
        If ct = 0 Then
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
            cmd = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                temp = Convert.ToInt32(reader("StarsNumber"))
                people = Convert.ToInt32(reader("Raters"))
                temp += 3
                people += 1
                Dim tempstr As String = "3"
                Dim cmdString As String = "insert into RatingList (ISBN, UserName, Starcount) values('" & passISBN & "', '" & str & "', ' " & tempstr & " ')"
                Dim cmd1 As OleDbCommand = New OleDbCommand(cmdString, cn)
                Dim r1 As OleDbDataReader = cmd1.ExecuteReader
                Dim updateString As String = "UPDATE Books SET StarsNumber='" & temp.ToString & "', Raters = '" & people.ToString & "' WHERE ISBN = '" & passISBN & "'"
                cmd1 = New OleDbCommand(updateString, cn)
                r1 = cmd1.ExecuteReader
                MessageBox.Show("Your rating has been submitted succesfully", "Success")
                r1.Close()
            End While
            cn.Close()
        Else
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
            cmd = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                temp = Convert.ToInt32(reader("StarsNumber"))
                people = Convert.ToInt32(reader("Raters"))
                temp += 3
                temp -= prev
                'people += 1
                Dim tempstr As String = "3"
                Dim cmdString As String = "UPDATE RatingList SET Starcount='" & tempstr & "' WHERE ISBN = '" & passISBN & "' AND Username = '" & str & "'"
                Dim cmd1 As OleDbCommand = New OleDbCommand(cmdString, cn)
                Dim r1 As OleDbDataReader = cmd1.ExecuteReader
                Dim updateString As String = "UPDATE Books SET StarsNumber='" & temp.ToString & "', Raters = '" & people.ToString & "' WHERE ISBN = '" & passISBN & "'"
                cmd1 = New OleDbCommand(updateString, cn)
                r1 = cmd1.ExecuteReader
                MessageBox.Show("Your rating has been updated succesfully", "Success")
                r1.Close()
            End While
        End If
    End Sub

    ' Same as above. Only Difference is that here we set 4 stars for this book
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\blank.png"
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        ct = 0
        Dim selectString1 As String = "SELECT * FROM RatingList WHERE ISBN = '" & passISBN & "' "
        Dim cmd As OleDbCommand = New OleDbCommand(selectString1, cn)
        Dim reader1 As OleDbDataReader = cmd.ExecuteReader()
        While reader1.Read()
            If reader1("UserName") = str Then
                prev = Convert.ToInt32(reader1("Starcount"))
                ct += 1
            End If
        End While
        cn.Close()
        Dim temp As Integer = 1
        Dim people As Integer = 1
        If ct = 0 Then
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
            cmd = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                temp = Convert.ToInt32(reader("StarsNumber"))
                people = Convert.ToInt32(reader("Raters"))
                temp += 4
                people += 1
                Dim tempstr As String = "4"
                Dim cmdString As String = "insert into RatingList (ISBN, UserName, Starcount) values('" & passISBN & "', '" & str & "', ' " & tempstr & " ')"
                Dim cmd1 As OleDbCommand = New OleDbCommand(cmdString, cn)
                Dim r1 As OleDbDataReader = cmd1.ExecuteReader
                Dim updateString As String = "UPDATE Books SET StarsNumber='" & temp.ToString & "', Raters = '" & people.ToString & "' WHERE ISBN = '" & passISBN & "'"
                cmd1 = New OleDbCommand(updateString, cn)
                r1 = cmd1.ExecuteReader
                MessageBox.Show("Your rating has been submitted succesfully", "Success")
                r1.Close()
            End While
            cn.Close()
        Else
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
            cmd = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                temp = Convert.ToInt32(reader("StarsNumber"))
                people = Convert.ToInt32(reader("Raters"))
                temp += 4
                temp -= prev
                'people += 1
                Dim tempstr As String = "4"
                Dim cmdString As String = "UPDATE RatingList SET Starcount='" & tempstr & "' WHERE ISBN = '" & passISBN & "' AND Username = '" & str & "'"
                Dim cmd1 As OleDbCommand = New OleDbCommand(cmdString, cn)
                Dim r1 As OleDbDataReader = cmd1.ExecuteReader
                Dim updateString As String = "UPDATE Books SET StarsNumber='" & temp.ToString & "', Raters = '" & people.ToString & "' WHERE ISBN = '" & passISBN & "'"
                cmd1 = New OleDbCommand(updateString, cn)
                r1 = cmd1.ExecuteReader
                MessageBox.Show("Your rating has been updated succesfully", "Success")
                r1.Close()
            End While
        End If
    End Sub

    ' Same as above. Only Difference is that here we set 5 stars for this book
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox1.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox2.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox3.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox4.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        PictureBox5.ImageLocation = Application.StartupPath & "\..\..\image\yellow.png"
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        ct = 0
        Dim selectString1 As String = "SELECT * FROM RatingList WHERE ISBN = '" & passISBN & "' "
        Dim cmd As OleDbCommand = New OleDbCommand(selectString1, cn)
        Dim reader1 As OleDbDataReader = cmd.ExecuteReader()
        While reader1.Read()
            If reader1("UserName") = str Then
                prev = Convert.ToInt32(reader1("Starcount"))
                ct += 1
            End If
        End While
        cn.Close()
        Dim temp As Integer = 1
        Dim people As Integer = 1
        If ct = 0 Then
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
            cmd = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                temp = Convert.ToInt32(reader("StarsNumber"))
                people = Convert.ToInt32(reader("Raters"))
                temp += 5
                people += 1
                Dim tempstr As String = "5"
                Dim cmdString As String = "insert into RatingList (ISBN, UserName, Starcount) values('" & passISBN & "', '" & str & "', ' " & tempstr & " ')"
                Dim cmd1 As OleDbCommand = New OleDbCommand(cmdString, cn)
                Dim r1 As OleDbDataReader = cmd1.ExecuteReader
                Dim updateString As String = "UPDATE Books SET StarsNumber='" & temp.ToString & "', Raters = '" & people.ToString & "' WHERE ISBN = '" & passISBN & "'"
                cmd1 = New OleDbCommand(updateString, cn)
                r1 = cmd1.ExecuteReader
                MessageBox.Show("Your rating has been submitted succesfully", "Success")
                r1.Close()
            End While
            cn.Close()
        Else
            cn.Open()
            Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
            cmd = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                temp = Convert.ToInt32(reader("StarsNumber"))
                people = Convert.ToInt32(reader("Raters"))
                temp += 5
                temp -= prev
                'people += 1
                Dim tempstr As String = "5"
                Dim cmdString As String = "UPDATE RatingList SET Starcount='" & tempstr & "' WHERE ISBN = '" & passISBN & "' AND Username = '" & str & "'"
                Dim cmd1 As OleDbCommand = New OleDbCommand(cmdString, cn)
                Dim r1 As OleDbDataReader = cmd1.ExecuteReader
                Dim updateString As String = "UPDATE Books SET StarsNumber='" & temp.ToString & "', Raters = '" & people.ToString & "' WHERE ISBN = '" & passISBN & "'"
                cmd1 = New OleDbCommand(updateString, cn)
                r1 = cmd1.ExecuteReader
                MessageBox.Show("Your rating has been updated succesfully", "Success")
                r1.Close()
            End While
        End If
    End Sub
End Class