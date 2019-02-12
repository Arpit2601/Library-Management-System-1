Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

' This form will show all the recommendations that this student has received from all the proffessors over time
Public Class StaffRecommend
    Dim field As String

    ' On loading the form show all the recommendations present
    Private Sub StaffRecommend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()

        Dim selectString2 As String = "SELECT * FROM Recommendations WHERE Field = 'Staff'"
        Dim cmd2 As OleDbCommand = New OleDbCommand(selectString2, cn)
        Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()

        ' Dynamically add all the recommendations
        Dim boxWidth As Integer = (Panel1.Width / 2) - 50
        Dim boxHeight As Integer = 100
        Dim nextX As Integer = 0
        Dim nextY As Integer = 0
        Dim countX As Integer = 0
        Dim countY As Integer = 0

        Dim counter = 1

        While reader2.Read

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

            Dim backPicBox As New PictureBox

            
            Dim Titlelabel As New Label
            Dim lblprofName As New Label
            Dim lblMessage1 As New Label
            Dim lblMessage2 As New Label
            Dim lblDate As New Label

            Dim checkBox1 As New CheckBox
            checkBox1.Name = "Box_" & counter
            Titlelabel.Name = "Box_" & counter
            lblprofName.Name = "Box_" & counter
            lblMessage1.Name = "Box_" & counter
            lblMessage2.Name = "Box_" & counter
            lblDate.Name = "Box_" & counter

            Titlelabel.Size = New Size(300, 20)
            Titlelabel.Text = reader2("ISBN")

            lblprofName.Size = New Size(270, 20)
            lblprofName.Text = profFullName

            lblMessage1.Text = "The book with ISBN"
            lblMessage1.AutoSize = True

            lblMessage2.Text = "is recommended by Prof."
            lblMessage2.AutoSize = True

            lblDate.Size = New Size(400, 20)
            lblDate.Text = "on " & recDate

            Titlelabel.Location = New Point(nextX + 145, nextY + 10)
            lblprofName.Location = New Point(nextX + 175, nextY + 40)
            lblMessage1.Location = New Point(nextX + 20, nextY + 10)
            lblMessage2.Location = New Point(nextX + 20, nextY + 40)
            lblDate.Location = New Point(nextX + 20, nextY + 70)
            backPicBox.Location = New Point(nextX, nextY)
            checkBox1.Location = New Point(nextX, nextY)
            checkBox1.Size = New Size(20, 20)

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
                    checkBox1.BackColor = Color.Salmon
                Else
                    backPicBox.BackColor = Color.SandyBrown
                    Titlelabel.BackColor = Color.SandyBrown
                    lblprofName.BackColor = Color.SandyBrown
                    lblMessage1.BackColor = Color.SandyBrown
                    lblDate.BackColor = Color.SandyBrown
                    lblMessage2.BackColor = Color.SandyBrown
                    checkBox1.BackColor = Color.SandyBrown
                End If
            Else
                If countY Mod 2 = 0 Then
                    backPicBox.BackColor = Color.DarkKhaki
                    Titlelabel.BackColor = Color.DarkKhaki
                    lblprofName.BackColor = Color.DarkKhaki
                    lblMessage1.BackColor = Color.DarkKhaki
                    lblDate.BackColor = Color.DarkKhaki
                    lblMessage2.BackColor = Color.DarkKhaki
                    checkBox1.BackColor = Color.DarkKhaki
                Else
                    backPicBox.BackColor = Color.LightSteelBlue
                    Titlelabel.BackColor = Color.LightSteelBlue
                    lblprofName.BackColor = Color.LightSteelBlue
                    lblMessage1.BackColor = Color.LightSteelBlue
                    lblDate.BackColor = Color.LightSteelBlue
                    lblMessage2.BackColor = Color.LightSteelBlue
                    checkBox1.BackColor = Color.LightSteelBlue
                End If
            End If

            Titlelabel.Font = New Font("Times New Roman", 11, FontStyle.Regular)
            lblprofName.Font = New Font("Times New Roman", 11, FontStyle.Bold)
            lblMessage1.Font = New Font("Times New Roman", 11, FontStyle.Regular)
            lblMessage2.Font = New Font("Times New Roman", 11, FontStyle.Regular)
            lblDate.Font = New Font("Times New Roman", 11, FontStyle.Regular)

            Titlelabel.AutoEllipsis = True
            lblprofName.AutoEllipsis = True
            lblMessage1.AutoEllipsis = True
            lblMessage2.AutoEllipsis = True
            lblDate.AutoEllipsis = True

            backPicBox.SendToBack()

            Me.Panel1.Controls.Add(Titlelabel)
            Me.Panel1.Controls.Add(lblprofName)
            Me.Panel1.Controls.Add(lblMessage1)
            Me.Panel1.Controls.Add(lblMessage2)
            Me.Panel1.Controls.Add(lblDate)
            Me.Panel1.Controls.Add(checkBox1)
            Me.Panel1.Controls.Add(backPicBox)



            nextX += boxWidth
            countY = 1
            If nextX > Panel1.Width / 2 Then
                nextX = 0
                nextY += boxHeight + 10
                countX += 1
                countY = 0
            End If

            counter += 1

        End While

        cn.Close()
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message As Boolean = False

        For Each cntrl As Control In Panel1.Controls
            If TypeOf cntrl Is CheckBox Then
                If DirectCast(cntrl, CheckBox).Checked = True Then



                    Dim str As String = cntrl.Name
                    Dim arr = Me.Controls.Find(str, True)

                    Dim i As Integer = 0
                    Dim title As Control = cntrl
                    Dim bookField As Control = cntrl
                    For Each c In arr
                        'MessageBox.Show(c.Text)
                        i += 1
                        If i = 1 Then
                            title = c
                        End If
                        If i = 3 Then
                            bookField = c
                        End If
                    Next

                    Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
                    cn.Open()

                    'MessageBox.Show(bookField.Text)

                    Dim deleteString As String = " DELETE FROM Recommendations WHERE ISBN = '" & title.Text & "' and Field='Staff'"
                    Dim cmd As OleDbCommand = New OleDbCommand(deleteString, cn)

                    'MessageBox.Show(deleteString)

                    'cmd.ExecuteNonQuery()
                    'cmd.Dispose()

                    message = True

                    Try
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        ' MessageBox.Show("Successfully Deleted")
                    Catch ex As Exception

                    End Try

                    cn.Close()
                End If
            End If
        Next

        If message Then
            MessageBox.Show("Successfully deleted")
        End If

        StaffLogin.refreshStaffRecommend()
    End Sub

End Class
