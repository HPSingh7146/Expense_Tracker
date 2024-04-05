Imports System.Data.SqlClient

Public Class Admin

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hpsin\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"

    Private Sub DeleteUsr_Click(sender As Object, e As EventArgs) Handles Deleteusr.Click
        Dim usernameToDelete As String = Username.Text

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Check if the username exists in the userbase table
                Dim userExistsQuery As String = "SELECT COUNT(*) FROM userbase WHERE Username = @Username"
                Using command As New SqlCommand(userExistsQuery, connection)
                    command.Parameters.AddWithValue("@Username", usernameToDelete)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If count > 0 Then
                        ' Ask for confirmation before deletion
                        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the user '" & usernameToDelete & "' and all related data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If result = DialogResult.Yes Then
                            ' Delete related records from the income table
                            Dim deleteIncomeQuery As String = "DELETE FROM income WHERE username = @Username"
                            Using deleteIncomeCommand As New SqlCommand(deleteIncomeQuery, connection)
                                deleteIncomeCommand.Parameters.AddWithValue("@Username", usernameToDelete)
                                deleteIncomeCommand.ExecuteNonQuery()
                            End Using

                            ' Delete related records from the expense table
                            Dim deleteExpenseQuery As String = "DELETE FROM expense WHERE username = @Username"
                            Using deleteExpenseCommand As New SqlCommand(deleteExpenseQuery, connection)
                                deleteExpenseCommand.Parameters.AddWithValue("@Username", usernameToDelete)
                                deleteExpenseCommand.ExecuteNonQuery()
                            End Using

                            ' Now that related records are deleted, delete the user from the userbase table
                            Dim deleteUserQuery As String = "DELETE FROM userbase WHERE Username = @Username"
                            Using deleteUserCommand As New SqlCommand(deleteUserQuery, connection)
                                deleteUserCommand.Parameters.AddWithValue("@Username", usernameToDelete)
                                deleteUserCommand.ExecuteNonQuery()

                                MessageBox.Show("User '" & usernameToDelete & "' and related data deleted successfully.")

                                ' Update DataGridView
                                Dim expenseQuery As String = "SELECT * FROM userbase"
                                DataGridView1.DataSource = getDataTable(expenseQuery, LoginPage.user)
                            End Using
                        End If
                    Else
                        MessageBox.Show("User '" & usernameToDelete & "' does not exist.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub




    'to return tabel data
    Public Function getDataTable(query As String, username As String) As DataTable
        Dim dataTable As New DataTable()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error retrieving data: " & ex.Message)
        End Try

        Return dataTable
    End Function

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set the font for DataGridView column headers and cells
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("segeo ui", 12)
        DataGridView1.DefaultCellStyle.Font = New Font("segeo ui", 10)

        ' Load expense data into DataGridView
        Try
            Dim expenseQuery As String = "SELECT * FROM userbase"
            DataGridView1.DataSource = getDataTable(expenseQuery, LoginPage.user)

            ' Adjust the width of columns to fit their content
            For Each column As DataGridViewColumn In DataGridView1.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        Catch ex As Exception
            MsgBox("Error loading expense data: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        LoginPage.Close()
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Close()
        LoginPage.Show()
    End Sub

    'Code to make window Dragable
    ' Define variables to keep track of mouse movement
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    ' MouseDown event handler for panel1
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ' Set the flag to indicate mouse down
        isMouseDown = True

        ' Store the current mouse cursor position
        mouseOffset = e.Location
    End Sub

    ' MouseMove event handler for panel1
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ' Check if the mouse button is down (dragging)
        If isMouseDown Then
            ' Get the current mouse position relative to the form
            Dim mousePos As Point = Me.PointToScreen(e.Location)

            ' Calculate the new form position by offsetting with the mouse offset
            Dim newFormPos As Point = mousePos - mouseOffset

            ' Set the new form position
            Me.Location = newFormPos
        End If
    End Sub

    ' MouseUp event handler for panel1
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        ' Reset the mouse down flag
        isMouseDown = False
    End Sub
End Class
