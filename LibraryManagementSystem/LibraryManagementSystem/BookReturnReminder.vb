﻿Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Collections.Generic
Imports System


Module BookReturnReminder
    Dim connectionString = MainPage.connectionString

    'must provide new generated random password as string,useremailid as string,username as string
    Sub sendForgotPassword(ByVal userName As String, ByVal mailId As String, ByVal password As String)
        Dim subject = "IITG Library Account Password"
        Dim message = "Hello " & userName & "" & vbCrLf & ""
        message += "Your new Password is " & password & ""
        SendEmail(mailId, message, subject)
    End Sub

    Sub sendReminders()
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        Dim cmdString As String
        Dim todaysdate As String = String.Format("{0:dd-MM-yyyy}", DateTime.Now.AddDays(5))

        cmdString = "SELECT BorrowerId,ISBN FROM Borrowed where ReturnDate like '" & todaysdate & "' and IsIssued like True order by BorrowerId"

        'Dim dictionary As New Dictionary(Of String, String())

        cn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader
        Dim cmd2 As OleDbCommand = New OleDbCommand(cmdString, cn)
        Dim reader2 As OleDbDataReader
        Dim prevUser = ""
        Dim isbnList As New List(Of String)()
        Dim subject, message, mailId As String

        While reader.Read()

            If reader("BorrowerId") = prevUser Then
                cmd2.CommandText = "Select Title from Books where ISBN like '" & reader("ISBN") & "'"
                reader2 = cmd2.ExecuteReader
                reader2.Read()
                isbnList.Add(reader2("Title"))
                reader2.Close()

            ElseIf prevUser <> "" Then
                cmd2.CommandText = "Select * from Users where UserName like '" & prevUser & "'"
                reader2 = cmd2.ExecuteReader()
                reader2.Read()
                mailId = reader2("Email")
                reader2.Close()
                subject = "Reminder to return Books"
                message = "Your lease of Books is ending shortly.Please Take note of the Books you have to return to the library:" & vbCrLf & ""
                For i As Integer = 0 To isbnList.Count - 1
                    message += "" & vbTab & "" & i & ") " & isbnList(i) & " " & vbCrLf & ""
                Next

                SendEmail(mailId, message, subject)
                Console.WriteLine("Message Sent")
                isbnList.Clear()
                prevUser = reader("BorrowerId")

                cmd2.CommandText = "Select Title from Books where ISBN like '" & reader("ISBN") & "'"
                reader2 = cmd2.ExecuteReader
                reader2.Read()
                isbnList.Add(reader2("Title"))
                reader2.Close()

            Else
                prevUser = reader("BorrowerId")
                cmd2.CommandText = "Select Title from Books where ISBN like '" & reader("ISBN") & "'"
                reader2 = cmd2.ExecuteReader
                reader2.Read()
                isbnList.Add(reader2("Title"))
                reader2.Close()
            End If
        End While

        Console.WriteLine(prevUser)
        cmd2.CommandText = "Select * from Users where UserName like '" & prevUser & "'"
        reader2 = cmd2.ExecuteReader()
        If Not reader2.HasRows Then
            Return
        End If
        reader2.Read()
        mailId = reader2("Email")
        reader2.Close()
        subject = "Reminder to return Books"
        message = "Your lease of Books is ending shortly.Please Take note of the Books you have to return to the library:" & vbCrLf & ""
        For i As Integer = 0 To isbnList.Count - 1
            message += "" & vbTab & "" & i & ") " & isbnList(i) & " " & vbCrLf & ""
        Next

        message += "The last date to return the book is " & todaysdate & " beyond which a fine per day will be applicable."
        SendEmail(mailId, message, subject)
        Console.Write(mailId, message)
    End Sub

    Function SendEmail(ByVal sendto As String, ByVal message As String, ByVal subject As String)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("iitglibrarymanagement@gmail.com", "Group0015")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("iitglibrarymanagement@gmail.com")
            e_mail.To.Add(sendto)
            e_mail.Subject = subject
            e_mail.IsBodyHtml = False
            e_mail.Body = message
            Smtp_Server.Send(e_mail)
            'MsgBox("Mail Sent")
            Return 1
        Catch error_t As Exception
            'MsgBox(error_t.Message)
            Return 0
        End Try
    End Function

    Sub fineCalculator()
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)

        Dim cmdString = "SELECT BorrowerId FROM Borrowed WHERE isIssued=True and Date()>returnDate"
        cn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader
        Dim cmd2 As OleDbCommand = New OleDbCommand(cmdString, cn)
        Dim reader2 As OleDbDataReader

        While (reader.Read())
            Dim userName = reader("BorrowerId")
            cmd2.CommandText = "SELECT * from Users where UserName = '" & userName & "'"
            reader2 = cmd2.ExecuteReader()
            Console.WriteLine(reader2.HasRows)

            reader2.Read()
            Dim ct = reader2("TotalFine") + 1
            cmd2.CommandText = "UPDATE Users SET TotalFine = " & ct & " WHERE userName = '" & userName & "'"
            reader2.Close()

            cmd2.ExecuteScalar()
        End While

    End Sub
End Module