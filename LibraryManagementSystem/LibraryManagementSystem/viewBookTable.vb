Imports System.Data.OleDb


Public Class viewBookTable
    Private Sub viewBookTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString = MainPage.connectionString
        Dim cmd As OleDbCommand = New OleDbCommand
        Dim conn As New OleDbConnection(connectionString)
        cmd.Connection = conn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "myquery"
        Dim dataAdaptor As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet()
        conn.Open()
        dataAdaptor.Fill(ds, "MyTable")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "MyTable"
        conn.Close()
        RadioButton3.Checked = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton3.Checked Or TextBox1.Text = "" Then
            Dim connectionString = MainPage.connectionString
            Dim cmd As OleDbCommand = New OleDbCommand
            Dim conn As New OleDbConnection(connectionString)
            cmd.Connection = conn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "myquery"
            Dim dataAdaptor As New OleDbDataAdapter(cmd)
            Dim ds As New DataSet()
            conn.Open()
            dataAdaptor.Fill(ds, "MyTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "MyTable"
            conn.Close()
        ElseIf RadioButton2.Checked AndAlso TextBox1.Text <> "" Then
            Dim connectionString = MainPage.connectionString
            Dim commandString = "SELECT AccNo,ISBN,BorrowerId as UserID,ReturnDate,IsIssued FROM Borrowed where AccNo = " & TextBox1.Text
            Dim conn As New OleDbConnection(connectionString)
            Dim dataAdaptor As New OleDbDataAdapter(commandString, conn)
            Dim ds As New DataSet()
            conn.Open()
            dataAdaptor.Fill(ds, "Table")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Table"
            conn.Close()

        ElseIf RadioButton1.Checked AndAlso TextBox1.Text <> "" Then
            Dim connectionString = MainPage.connectionString
            Dim commandString = "SELECT AccNo,ISBN,BorrowerId as UserID,ReturnDate,IsIssued FROM Borrowed where ISBN = '" & TextBox1.Text & "'"
            Dim conn As New OleDbConnection(connectionString)
            Dim dataAdaptor As New OleDbDataAdapter(commandString, conn)
            Dim ds As New DataSet()
            conn.Open()
            dataAdaptor.Fill(ds, "Table")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Table"
            conn.Close()

        ElseIf RadioButton4.Checked AndAlso TextBox1.Text <> "" Then
            Dim connectionString = MainPage.connectionString
            Dim commandString = "SELECT AccNo,ISBN,BorrowerId as UserID,ReturnDate,IsIssued FROM Borrowed where BorrowerId like '%" & TextBox1.Text & "%' and IsIssued=True"
            Dim conn As New OleDbConnection(connectionString)
            Dim dataAdaptor As New OleDbDataAdapter(commandString, conn)
            Dim ds As New DataSet()
            conn.Open()
            dataAdaptor.Fill(ds, "Table")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Table"
            conn.Close()

        End If
    End Sub
End Class
