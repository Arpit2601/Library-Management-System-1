Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

' This form will show all the recommendations that this student has received from all the proffessors over time
Public Class Stud_UserControl
    Dim field As String

    ' On loading the form show all the recommendations present
    Private Sub Stud_UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()

        Dim selectString As String = "SELECT * FROM Users WHERE UserName = '" & StudentLogin.UserName & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read Then
            field = reader("Department")
        End If

        Dim selectString2 As String = "SELECT * FROM Recommendations WHERE Field = '" & field & "'"
        Dim cmd2 As OleDbCommand = New OleDbCommand(selectString2, cn)
        Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()

        ' Dynamically add all the recommendations
        Dim boxWidth As Integer = (Panel1.Width / 2) - 50
        Dim boxHeight As Integer = 100
        Dim nextX As Integer = 0
        Dim nextY As Integer = 0
        Dim countX As Integer = 0
        Dim countY As Integer = 0

        While reader2.Read

            Dim selectString3 As String = "SELECT * FROM Books WHERE ISBN = '" & reader2("ISBN") & "'"
            Dim cmd3 As OleDbCommand = New OleDbCommand(selectString3, cn)
            Dim reader3 As OleDbDataReader = cmd3.ExecuteReader()

            Dim profName As String = reader2("ProfName")

            Dim selectString4 As String = "SELECT * FROM Users WHERE UserName = '" & profName & "'"
            Dim cmd4 As OleDbCommand = New OleDbCommand(selectString4, cn)
            Dim reader4 As OleDbDataReader = cmd4.ExecuteReader()
            Dim profFullName As String = ""

            If reader4.Read Then
                profFullName = reader4("ProfileName")
            End If

            Dim recDate As String = Format(reader2("RecDate"), "dddd, MMM d yyyy")

            ' In a thumbnail show the title of book, Proffessor name who recommended it, and date of recommendation
            ' On clicking on the title the book detail page will open
            If reader3.Read Then

                Dim backPicBox As New PictureBox

                Dim Titlelabel As New LinkLabel
                Dim lblprofName As New Label
                Dim lblMessage1 As New Label
                Dim lblMessage2 As New Label
                Dim lblDate As New Label

                Titlelabel.Size = New Size(300, 20)
                Titlelabel.Tag = reader3("ISBN")
                Titlelabel.Text = reader3("Title")

                lblprofName.Size = New Size(290, 20)
                lblprofName.Text = profFullName

                lblMessage1.Text = "The book named"
                lblMessage1.AutoSize = True

                lblMessage2.Text = "is recommended by Prof."
                lblMessage2.AutoSize = True

                lblDate.Size = New Size(400, 20)
                lblDate.Text = "on " & recDate

                Titlelabel.Location = New Point(nextX + 115, nextY + 10)
                lblprofName.Location = New Point(nextX + 165, nextY + 40)
                lblMessage1.Location = New Point(nextX + 10, nextY + 10)
                lblMessage2.Location = New Point(nextX + 10, nextY + 40)
                lblDate.Location = New Point(nextX + 10, nextY + 70)
                backPicBox.Location = New Point(nextX, nextY)

                backPicBox.Size = New Size(boxWidth - 20, boxHeight)
                backPicBox.SendToBack()

                If countX Mod 2 = 0 Then
                    If countY Mod 2 = 0 Then
                        backPicBox.BackColor = Color.Salmon
                        Titlelabel.BackColor = Color.Salmon
                        lblprofName.BackColor = Color.Salmon
                        lblMessage1.BackColor = Color.Salmon
                        lblDate.BackColor = Color.Salmon
                        lblMessage2.BackColor = Color.Salmon
                    Else
                        backPicBox.BackColor = Color.SandyBrown
                        Titlelabel.BackColor = Color.SandyBrown
                        lblprofName.BackColor = Color.SandyBrown
                        lblMessage1.BackColor = Color.SandyBrown
                        lblDate.BackColor = Color.SandyBrown
                        lblMessage2.BackColor = Color.SandyBrown
                    End If
                Else
                    If countY Mod 2 = 0 Then
                        backPicBox.BackColor = Color.DarkKhaki
                        Titlelabel.BackColor = Color.DarkKhaki
                        lblprofName.BackColor = Color.DarkKhaki
                        lblMessage1.BackColor = Color.DarkKhaki
                        lblDate.BackColor = Color.DarkKhaki
                        lblMessage2.BackColor = Color.DarkKhaki
                    Else
                        backPicBox.BackColor = Color.LightSteelBlue
                        Titlelabel.BackColor = Color.LightSteelBlue
                        lblprofName.BackColor = Color.LightSteelBlue
                        lblMessage1.BackColor = Color.LightSteelBlue
                        lblDate.BackColor = Color.LightSteelBlue
                        lblMessage2.BackColor = Color.LightSteelBlue
                    End If
                End If

                Titlelabel.Font = New Font("Times New Roman", 11, FontStyle.Regular)
                lblprofName.Font = New Font("Times New Roman", 11, FontStyle.Bold)
                lblMessage1.Font = New Font("Times New Roman", 11, FontStyle.Regular)
                lblMEssage2.Font = New Font("Times New Roman", 11, FontStyle.Regular)
                lblDate.Font = New Font("Times New Roman", 11, FontStyle.Regular)

                Titlelabel.AutoEllipsis = True
                lblprofName.AutoEllipsis = True
                lblMessage1.AutoEllipsis = True
                lblMEssage2.AutoEllipsis = True
                lblDate.AutoEllipsis = True

                Me.Panel1.Controls.Add(Titlelabel)
                Me.Panel1.Controls.Add(lblprofName)
                Me.Panel1.Controls.Add(lblMessage1)
                Me.Panel1.Controls.Add(lblMEssage2)
                Me.Panel1.Controls.Add(lblDate)
                Me.Panel1.Controls.Add(backPicBox)

                AddHandler Titlelabel.Click, AddressOf Titlelabel_click

                nextX += boxWidth
                countY = 1
                If nextX > Panel1.Width / 2 Then
                    nextX = 0
                    nextY += boxHeight + 10
                    countX += 1
                    countY = 0
                End If

            End If

        End While

        cn.Close()
    End Sub

    ' On clicking title show book detail page
    Private Sub Titlelabel_click(ByVal sender As Object, ByVal e As EventArgs)
        Dim frm As New BookDetails
        frm.passISBN = sender.tag
        frm.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
