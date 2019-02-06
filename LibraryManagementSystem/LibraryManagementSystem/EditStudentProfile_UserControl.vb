Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class EditStudentProfile_UserControl

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()

        Dim name As String = txtName.Text
        Dim email As String = EmailTextBox.Text
        Dim phonenumber As String = PhoneNumberTextBox.Text
        Dim department As String = lblDepartment.Text
        Dim password As String = txtPassword.Text

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

        ' Password Validation

        If update Then
            Dim updateString As String = "UPDATE Users SET ProfileName='" & name & "', [Password]='" & txtPassword.Text & "', Email='" & email & "',  PhoneNumber='" & phonenumber & "', Department='" & department & "', ProfileImage='" & StudentLogin.UserID & ".JPG' WHERE Userid = " & StudentLogin.UserID
            picBoxProfile.Image.Save(System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & StudentLogin.UserID & ".JPG")
            Dim cmd As OleDbCommand = New OleDbCommand(updateString, cn)
            If cmd.ExecuteNonQuery() > 0 Then
                cmd.Dispose()
                MessageBox.Show("Profile updated!")
            End If
        End If

        cn.Close()
    End Sub

    Private Sub btnChangePic_Click(sender As Object, e As EventArgs) Handles btnChangePic.Click
        OpenFileDialog1.ShowDialog()
        picBoxProfile.ImageLocation = OpenFileDialog1.FileName.ToString
    End Sub

 
    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        ContextMenuStrip1.Show(btnDepartment, 0, btnDepartment.Height)
    End Sub

    Private Sub BiosciencesAndBioengineeringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BiosciencesAndBioengineeringToolStripMenuItem.Click
        lblDepartment.Text = "Biosciences and Bioengineering"
    End Sub

    Private Sub ChemicalEngineeringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChemicalEngineeringToolStripMenuItem.Click
        lblDepartment.Text = "Chemical Engineering"
    End Sub

    Private Sub ChemistryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChemistryToolStripMenuItem.Click
        lblDepartment.Text = "Chemistry"
    End Sub

    Private Sub CivilEngineeringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CivilEngineeringToolStripMenuItem.Click
        lblDepartment.Text = "Civil Engineering"
    End Sub

    Private Sub ComputerScienceAndEnggToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComputerScienceAndEnggToolStripMenuItem.Click
        lblDepartment.Text = "Computer Science and Engg"
    End Sub

    Private Sub HumanitiesAndSocialSciencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HumanitiesAndSocialSciencesToolStripMenuItem.Click
        lblDepartment.Text = "Humanities and Social Sciences"
    End Sub

    Private Sub MathematicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MathematicsToolStripMenuItem.Click
        lblDepartment.Text = "Mathematics"
    End Sub

    Private Sub MechanicjalEngineeringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MechanicjalEngineeringToolStripMenuItem.Click
        lblDepartment.Text = "Mechanical Engineering"
    End Sub

    Private Sub PhysicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhysicsToolStripMenuItem.Click
        lblDepartment.Text = "Physics"
    End Sub

    Private Sub EditStudentProfile_UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Users WHERE Userid = " & StudentLogin.UserID
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read Then
            Dim fullPath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & reader("ProfileImage")
            picBoxProfile.ImageLocation = fullPath

            txtName.Text = reader("ProfileName")
            EmailTextBox.Text = reader("Email")
            PhoneNumberTextBox.Text = reader("PhoneNumber")
            lblDepartment.Text = reader("Department")
        End If

        cn.Close()
    End Sub
End Class