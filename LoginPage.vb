Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LoginPage

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hpsin\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"
    Public counter As Integer = 0
    Public user As String = ""
    'main form
    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        regpnl.Hide()

    End Sub

    'Exit Button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles logExit.Click
        Me.Close()
    End Sub

    'Login Button


    'Register Button
    Private Sub regbtn_Click(sender As Object, e As EventArgs) Handles regbtn.Click
        regpnl.Show()
        UsernameTxtbox.Text = ""
        PasswordTxtbox.Text = ""
    End Sub

    Private Sub logbtn_Click(sender As Object, e As EventArgs) Handles logbtn.Click
        Dim Username As String = UsernameTxtbox.Text
        Dim Password As String = PasswordTxtbox.Text

        'connection logic
        'direct communication without function
        Try
            Using connection As New SqlConnection(connectionString)
                Try
                    connection.Open()
                    ' Checking if the end user is authenticated
                    Dim query As String = "SELECT COUNT(*) FROM userbase WHERE Username = @Username AND Password = @Password"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Username", Username)
                        command.Parameters.AddWithValue("@Password", Password)

                        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                        If count > 0 Then
                            ' User exists with the provided username and password
                            ' Proceed with login
                            counter = 1
                            user = Username
                            MsgBox("Login successful")
                            Me.Hide()
                            UsernameTxtbox.Text = ""
                            PasswordTxtbox.Text = ""
                            Dashboard.Show()
                        Else
                            MsgBox("Incorrect Credentials" + vbCrLf + Username + vbCrLf + Password)
                            counter = 0
                        End If
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub loginnow_Click(sender As Object, e As EventArgs) Handles loginnow.Click
        regpnl.Hide()
        regnametxtbox.Text = ""
        regunametxtbox.Text = ""
        regpasstxtbox.Text = ""
    End Sub

    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click
        Dim name As String = regnametxtbox.Text
        Dim username As String = regunametxtbox.Text
        Dim password As String = regpasstxtbox.Text
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO [dbo].[userbase] ([name], [username], [password], [joindate]) VALUES (@name, @username, @password, @joindate)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@name", name)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)
                    command.Parameters.AddWithValue("@joindate", String.Format("{0:dd/MM/yyyy}", DateTime.Now))

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("User successfully added to the database.")
                        regnametxtbox.Text = ""
                        regunametxtbox.Text = ""
                        regpasstxtbox.Text = ""
                    Else
                        MessageBox.Show("Failed to add user to the database.")
                        regnametxtbox.Text = ""
                        regunametxtbox.Text = ""
                        regpasstxtbox.Text = ""
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class
