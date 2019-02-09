Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class EditStudentProfile_UserControl

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()

        Dim name As String = txtName.Text
        Dim email As String = EmailTextBox.Text
        Dim phonenumber As String = PhoneNumberTextBox.Text
        Dim department As String = ComboBox1.SelectedItem

        ' Data validation
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

        Dim extension As String = picBoxProfile.ImageLocation
        Dim n As Integer = extension.Length
        extension = extension.Substring(n - 4)
        If Not extension = ".jpg" And Not extension = ".jpeg" And Not extension = ".png" And Not extension = ".JPG" And Not extension = ".JPEG" Then
            update = False
            MessageBox.Show("Please upload a valid image")
        End If

        


        If update Then
            Dim updateString As String = "UPDATE Users SET ProfileName='" & name & "', Email='" & email & "',  PhoneNumber='" & phonenumber & "', Department='" & department & "', ProfileImage='" & StudentLogin.UserName & ".JPG' WHERE UserName = '" & StudentLogin.UserName & "'"
            picBoxProfile.Image.Save(System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & StudentLogin.UserName & ".JPG")
            Dim cmd As OleDbCommand = New OleDbCommand(updateString, cn)
            If cmd.ExecuteNonQuery() > 0 Then
                cmd.Dispose()
                MessageBox.Show("Profile successfully updated!", "Profile updated")
            End If
        End If

        cn.Close()
    End Sub

    Private Sub btnChangePic_Click(sender As Object, e As EventArgs) Handles btnChangePic.Click
        OpenFileDialog1.ShowDialog()
        picBoxProfile.ImageLocation = OpenFileDialog1.FileName.ToString
    End Sub

 
   

    Private Sub EditStudentProfile_UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Users WHERE UserName = '" & StudentLogin.UserName & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read Then
            Dim fullPath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & reader("ProfileImage")
            picBoxProfile.ImageLocation = fullPath

            txtName.Text = reader("ProfileName")
            EmailTextBox.Text = reader("Email")
            PhoneNumberTextBox.Text = reader("PhoneNumber")
            ComboBox1.Text = reader("Department")
        End If

        cn.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub DepartmentLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UserNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PhoneNumberLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmailLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class