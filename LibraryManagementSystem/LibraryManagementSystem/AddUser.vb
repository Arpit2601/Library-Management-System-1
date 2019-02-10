Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class AddUser

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        ' Data Validation

        Dim name As String = txtName.Text
        Dim username As String = txtUsername.Text
        Dim email As String = txtEmail.Text
        Dim phonenumber As String = txtPhone.Text
        Dim department As String = ComboBox1.SelectedItem
        Dim password As String = txtPassword.Text
        Dim update As Boolean = True


        If Name = "" Then
            MessageBox.Show("Please enter your name", "Invalid name")
            update = False
        End If

        For Each c In Name
            If Not Char.IsLower(c) And Not Char.IsUpper(c) And Not c = " " Then
                MessageBox.Show("Your name should contain only lowercase, uppercase or blankspace letters.", "Invalid name")
                update = False
                Exit For
            End If
        Next

        If Not Regex.IsMatch(username, "^[a-zA-Z]+[0-9]+$") Then
            MessageBox.Show("Please enter a valid username", "Invalid email ID")
            update = False
        End If

        If Not Regex.IsMatch(email, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$") Then
            MessageBox.Show("Please enter a valid email ID", "Invalid email ID")
            update = False
        End If

        For Each c In phonenumber
            If Not Char.IsNumber(c) Then
                update = False
                MessageBox.Show("You should enter only numerical digits in your phone number", "Invalid phone number")
            End If
        Next

        If Not phonenumber.Length = 10 Then
            update = False
            MessageBox.Show("Your phone number should have 10 digits only", "Invalid phone number")
        End If

        For Each c In password
            If c = " " Then
                update = False
                MessageBox.Show("Password should not contain blanks")
            End If
        Next

        If password = "" Then
            MessageBox.Show("Please enter the user's password")
        End If

        Dim connectionString As String = MainPage.connectionString
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        Dim cmdString As String

        cn.Open()

        Dim maxBooks As Integer
        If ComboBox2.SelectedItem = "Student" Then
            maxBooks = 7
        Else
            maxBooks = 10
        End If

        Dim profileImage As String = "defaultProfilePic.JPG"

        If update Then
            Dim ct As Integer = 0
            Dim strcheck As String = "SELECT * FROM Users WHERE UserName like '" & username & "'"
            Dim cmd1 As OleDbCommand = New OleDbCommand(strcheck, cn)
            Dim readcheck As OleDbDataReader = cmd1.ExecuteReader()
            While readcheck.Read()
                ct += 1

            End While
            readcheck.Close()

            If ct > 0 Then
                MessageBox.Show("Username Already Exists", "Duplicate Username")
            Else
                cmdString = "insert into Users (UserName, [Password]) values('" & txtUsername.Text & "', '" & EncryptPassword(txtPassword.Text, txtUsername.Text) & "')"
                Dim cmdString2 As String = "update Users Set ProfileName='" & txtName.Text & "', Email='" & txtEmail.Text & "', PhoneNumber='" & txtPhone.Text & "', Department='" & ComboBox1.SelectedItem & "', Designation='" & ComboBox2.SelectedItem & "', ProfileImage='" & profileImage & "', MaxBooks='" & maxBooks & "' WHERE UserName='" & txtUsername.Text & "'"
                Console.WriteLine(cmdString2)

                Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
                Dim reader As OleDbDataReader = cmd.ExecuteReader
                reader.Close()

                Dim cmd2 As OleDbCommand = New OleDbCommand(cmdString2, cn)
                Dim reader2 As OleDbDataReader = cmd2.ExecuteReader
                MessageBox.Show("User added succesfully", "Success")
                reader2.Close()

            End If
        End If

        cn.Close()
    End Sub

    
    
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Function searchUsername(ByVal username As String) As Boolean
        If Not Regex.IsMatch(username, "^[a-zA-Z]+[0-9]+$") Then
            MessageBox.Show("Please enter a valid username", "Invalid email ID")
            Return False
        End If

        Dim connectionString As String = MainPage.connectionString
        Dim cn As OleDbConnection = New OleDbConnection(connectionString)
        Dim strcheck As String = "SELECT * FROM Users WHERE UserName like '" & username & "'"
        Dim cmd1 As OleDbCommand = New OleDbCommand(strcheck, cn)
        Dim readcheck As OleDbDataReader = cmd1.ExecuteReader()

        If readcheck.HasRows Then
            readcheck.Read()
            txtName = readcheck("Name")
            txtEmail = readcheck("Email")
            txtPhone = readcheck("Phone")
            ComboBox1.Text = readcheck("Department")
            ComboBox2.Text = readcheck("Designation")
        End If

        txtUsername.Enabled = False
        Return True
    End Function

End Class
