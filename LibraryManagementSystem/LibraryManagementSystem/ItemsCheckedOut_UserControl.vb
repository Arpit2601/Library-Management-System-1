Imports System.Data.OleDb

Public Class ItemsCheckedOut_UserControl

    Private Sub ItemsCheckedOut_UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()

        Dim selectString As String = "SELECT * FROM Borrowed WHERE BorrowerId = " & StudentLogin.UserID
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While reader.Read
            Dim selectString2 As String = "SELECT * FROM Books WHERE ISBN = '" & reader("ISBN") & "'"
            Dim cmd2 As OleDbCommand = New OleDbCommand(selectString2, cn)
            Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()

            If reader2.Read Then
                Dim title As String = reader2("Title")
                Dim author As String = reader2("Author")
                Dim field As String = reader2("Field")
                Dim publisher As String = reader2("Publisher")
                MessageBox.Show(title)
            End If

            ' Display data

        End While

        cn.Close()
    End Sub
End Class