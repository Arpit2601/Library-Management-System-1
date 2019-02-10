Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class AddUser

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        ' Data Validation

        If btnAddUser.Text = "Search" Then
            searchUsername(txtUsername.Text)
            Return
        End If


        Dim name As String = txtName.Text
        Dim username As String = txtUsername.Text
        Dim email As String = txtEmail.Text
        Dim phonenumber As String = txtPhone.Text
        Dim department As String = ComboBox1.SelectedItem
        Dim password As String = txtPassword.Text
        Dim update As Boolean = True



        If name = "" Then
            MessageBox.Show("Please enter your name", "Invalid name")
            update = False
        End If

        For Each c In name
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

        If btnAddUser.Text = "ADD" Then
            For Each c In password
                If c = " " Then
                    update = False
                    MessageBox.Show("Password should not contain blanks")
                End If
            Next

            If password = "" Then
                MessageBox.Show("Please enter the user's password")
            End If
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

        If btnAddUser.Text = "ADD" Then
            cmdString = "insert into Users (UserName, [Password]) values('" & txtUsername.Text & "', '" & EncryptPassword(txtPassword.Text, txtUsername.Text) & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(cmdString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            reader.Close()
        End If

        Dim cmdString2 As String = "update Users Set ProfileName='" & txtName.Text & "', Email='" & txtEmail.Text & "', PhoneNumber='" & txtPhone.Text & "', Department='" & ComboBox1.SelectedItem & "', Designation='" & ComboBox2.SelectedItem & "', ProfileImage='" & profileImage & "', MaxBooks='" & maxBooks & "' WHERE UserName='" & txtUsername.Text & "'"

        Dim cmd2 As OleDbCommand = New OleDbCommand(cmdString2, cn)
        Dim reader2 As OleDbDataReader = cmd2.ExecuteReader
        MessageBox.Show("Success")
        reader2.Close()
        cn.Close()
        StaffLogin.refreshModifyStudent()

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
        cn.Open()
        Dim strcheck As String = "SELECT * FROM Users WHERE UserName like '" & username & "'"
        Dim cmd1 As OleDbCommand = New OleDbCommand(strcheck, cn)
        Dim readcheck As OleDbDataReader = cmd1.ExecuteReader()

        btnAddUser.Text = "ADD"
        If readcheck.HasRows Then
            btnAddUser.Text = "MODIFY"
            readcheck.Read()
            txtName.Text = readcheck("ProfileName")
            txtEmail.Text = readcheck("Email")
            txtPhone.Text = readcheck("PhoneNumber")
            ComboBox1.Text = readcheck("Department")
            ComboBox2.Text = readcheck("Designation")
            txtPassword.Enabled = False
        End If

        txtUsername.Enabled = False

        For Each Control In Me.Controls
            Control.visible = True
        Next

        cn.Close()
        Return True
    End Function

End Class
