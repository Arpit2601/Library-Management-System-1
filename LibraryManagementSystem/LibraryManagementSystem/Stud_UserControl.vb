Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class Stud_UserControl
    Dim field As String

    Private Sub Stud_UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()

        Dim selectString As String = "SELECT * FROM Users WHERE UserName = '" & StudentLogin.UserName & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read Then
            field = reader("Field")
        End If

        Dim selectString2 As String = "SELECT * FROM Recommendations WHERE Field = '" & field & "'"
        Dim cmd2 As OleDbCommand = New OleDbCommand(selectString2, cn)
        Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()

        Dim boxWidth As Integer = (Panel1.Width / 2) - 10
        Dim boxHeight As Integer = 150
        Dim nextX As Integer = 0
        Dim nextY As Integer = 0

        While reader2.Read

            Dim selectString3 As String = "SELECT * FROM Books WHERE ISBN = '" & reader2("ISBN") & "'"
            Dim cmd3 As OleDbCommand = New OleDbCommand(selectString3, cn)
            Dim reader3 As OleDbDataReader = cmd3.ExecuteReader()

            Dim profName As String = reader2("ProfName")
            Dim recDate As String = reader2("RecDate")

            If reader3.Read Then


                Dim Titlelabel As New LinkLabel
                Dim lblprofName As New Label
                Dim lblMessage1 As New Label
                Dim lblMEssage2 As New Label
                Dim lblDate As New Label

                Titlelabel.Size = New Size(140, 20)
                Titlelabel.Tag = reader2("ISBN")
                Titlelabel.Text = "Title: " & reader2("Title")

                lblprofName.Size = New Size(140, 20)
                lblprofName.Text = profName

                lblMessage1.Size = New Size(140, 20)
                lblMessage1.Text = "The book named"

                lblMEssage2.Size = New Size(140, 20)
                lblMEssage2.Text = "is recommended by the professor"

                lblDate.Size = New Size(140, 20)
                lblDate.Text = "on " & recDate

                Titlelabel.Location = New Point(nextX, nextY + 10)   ' Set location
                lblprofName.Location = New Point(nextX, nextY + 40)
                lblMessage1.Location = New Point(nextX, nextY + 70)
                lblMEssage2.Location = New Point(nextX, nextY + 100)
                lblDate.Location = New Point(nextX, nextY + 130)

                Titlelabel.Font = New Font("Times New Roman", 11, FontStyle.Regular)
                lblprofName.Font = New Font("Times New Roman", 11, FontStyle.Regular)
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

                AddHandler Titlelabel.Click, AddressOf Titlelabel_click

                nextX += boxWidth
                If nextX > Panel1.Width Then
                    nextX = 0
                    nextY += boxHeight
                End If

            End If

        End While

        cn.Close()
    End Sub

    Private Sub Titlelabel_click(ByVal sender As Object, ByVal e As EventArgs)
        Dim frm As New BookDetails
        frm.passISBN = sender.tag
        frm.Show()
    End Sub

End Class
