Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class AddExpenses

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hpsin\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"

    Private Sub addExpensesExitbtn_Click(sender As Object, e As EventArgs) Handles addExpensesExitbtn.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles expaddbtn.Click
        Dim amount As Integer = expfield.Text
        If (expremark.Text = "Type here") Then
            expremark.Text = ""
        End If
        Dim exp_remark As String = expremark.Text
        Dim category As String = categoriescbox.Text
        Dim user As String = LoginPage.user
        DateTimePicker1.Value = DateTime.Now
        Dim expdate As String = DateTimePicker1.Value.ToString("dd-MM-yyyy")
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO [dbo].[expense] ([username],[amount],[category],[exp_remark],[date] ) VALUES (@username, @amount, @category, @exp_remark, @date)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", user)
                    command.Parameters.AddWithValue("@amount", amount)
                    command.Parameters.AddWithValue("@category", category)
                    command.Parameters.AddWithValue("@exp_remark", exp_remark)
                    command.Parameters.AddWithValue("@date", expdate)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("amount successfully added to the database.")
                        Me.Close()
                        Dashboard.Show()
                    Else
                        MessageBox.Show("Failed to add amount to the database.")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub expfield_Click(sender As Object, e As EventArgs) Handles expfield.Click
        expfield.Clear()
    End Sub

    Private Sub expremark_Click(sender As Object, e As EventArgs) Handles expremark.Click
        expremark.Clear()
    End Sub

    Private Sub expfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles expfield.KeyPress
        ' Check if the entered key is not a digit and not a control key
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Suppress the key press
            MsgBox("Ony Numbers")
            e.Handled = True
        End If
    End Sub
End Class