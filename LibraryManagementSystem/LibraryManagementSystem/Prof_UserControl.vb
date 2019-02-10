Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class Prof_UserControl

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Recommendations WHERE ISBN = '" & TextBox1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim ct As Integer = 0
        While reader.Read()
            'MessageBox.Show("Yo")
            If reader("Field") = ComboBox1.SelectedItem And reader("ProfName") = StudentLogin.UserName Then
                ct += 1
            End If
        End While
        cn.Close()
        'reader.Close()
        'MessageBox.Show(ct)
        If ct = 0 Then
            cn.Open()
            Dim cmdString As String = "insert into Recommendations (ISBN, Field, ProfName, RecDate) values('" & TextBox1.Text & "', '" & ComboBox1.SelectedItem & "', '" & StudentLogin.UserName & "', '" & DateTime.Now.ToString("dd-MM-yyyy") & "')"
            cmd = New OleDbCommand(cmdString, cn)
            If cmd.ExecuteNonQuery > 0 Then
                cmd.Dispose()
                MessageBox.Show("Inserted")
            End If
            reader.Close()
            cn.Close()
        Else
            MessageBox.Show("You Have already recommended this book for the selected field. Please try different ISBN or different Field")
        End If

        TextBox1.Clear()
        ComboBox1.SelectedIndex = -1
    End Sub


    Private Sub Prof_UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class