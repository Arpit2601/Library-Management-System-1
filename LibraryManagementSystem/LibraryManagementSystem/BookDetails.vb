Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class BookDetails
    Public Property passISBN As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Books WHERE ISBN = '" & passISBN & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Thumbnails(reader)
        cn.Close()

        cn.Open()
        Dim borrowerstring As String = "SELECT * FROM Borrowed WHERE ISBN = '" & passISBN & "' AND IsIssued=True"
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

    Public Sub Borrowers(reader1 As OleDbDataReader)
        Panel2.Controls.Clear()
        Dim x, y, count As Integer
        count = 0
        x = Panel2.Width
        y = -1.05 * Panel2.Location.Y + 2 * Panel2.Height
        Dim nextx As Integer = Panel2.Location.X - 10
        Dim nexty As Integer = 0
        'MessageBox.Show(nextx)
        While reader1.Read()
            Dim userid As String = reader1("BorrowerId")
            'MessageBox.Show(reader1("BorrowerId"))
            Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
            cn.Open()
            Dim selectString As String = "SELECT * FROM Users WHERE UserName = '" & userid & "'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim Namelabel As New Label
                Dim Departmentlabel As New Label
                Dim PhoneNumber As New Label
                Dim Email As New Label

                Namelabel.Size = New Size(150, 25)
                Departmentlabel.Size = New Size(150, 25)
                PhoneNumber.Size = New Size(150, 25)
                Email.Size = New Size(150, 25)
                Namelabel.Text = reader("ProfileName")
                Departmentlabel.Text = reader("Department")
                PhoneNumber.Text = reader("PhoneNumber")
                Email.Text = reader("Email")

                Namelabel.Location = New Point(nextx, y)
                Departmentlabel.Location = New Point(nextx + 170, y)
                PhoneNumber.Location = New Point(nextx + 320, y)
                Email.Location = New Point(nextx + 490, y)

                Namelabel.Font = New System.Drawing.Font("Comic Sans MS", 9, FontStyle.Italic)
                Departmentlabel.Font = New System.Drawing.Font("Comic Sans MS", 9, FontStyle.Italic)
                PhoneNumber.Font = New System.Drawing.Font("Comic Sans MS", 9, FontStyle.Italic)
                Email.Font = New System.Drawing.Font("Comic Sans MS", 9, FontStyle.Italic)

                Namelabel.ForeColor = Color.White
                Departmentlabel.ForeColor = Color.White
                PhoneNumber.ForeColor = Color.White
                Email.ForeColor = Color.White

                Namelabel.AutoEllipsis = True
                Departmentlabel.AutoEllipsis = True
                PhoneNumber.AutoEllipsis = True
                Email.AutoEllipsis = True

                y += 35

                Me.Panel2.Controls.Add(Namelabel)
                Me.Panel2.Controls.Add(Departmentlabel)
                Me.Panel2.Controls.Add(PhoneNumber)
                Me.Panel2.Controls.Add(Email)
            End While
            cn.Close()
        End While
    End Sub
End Class