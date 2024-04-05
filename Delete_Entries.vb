Imports System.Data.SqlClient

Public Class Delete_Entries

    ' Connection string to your SQL Server
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hpsin\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"
    Dim tablename As String

    Private Sub DeleteInc_Click(sender As Object, e As EventArgs) Handles DeleteInc.Click
        tablename = "income"
        Dim inc_Id As Integer
        If Integer.TryParse(IncId.Text, inc_Id) Then
            Dim isDeleted As Boolean = DeleteRecordByID(tablename, inc_Id)
            If isDeleted Then
                MessageBox.Show("Record with ID " & inc_Id & " was successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record with ID " & inc_Id & " does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid value for Inc_Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DeleteExp_Click(sender As Object, e As EventArgs) Handles DeleteExp.Click
        tablename = "expense"
        Dim exp_Id As Integer
        If Integer.TryParse(ExpId.Text, exp_Id) Then
            Dim isDeleted As Boolean = DeleteRecordByID(tablename, exp_Id)
            If isDeleted Then
                MessageBox.Show("Record with ID " & exp_Id & " was successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record with ID " & exp_Id & " does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid value for Inc_Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Function to delete the data
    Public Function DeleteRecordByID(ByVal tableName As String, ByVal idToDelete As Integer) As Boolean


        ' SQL query to check if the ID exists
        Dim query As String = "SELECT COUNT(*) FROM " & tableName & " WHERE id = @ID"

        ' SQL query to delete the record
        Dim deleteQuery As String = "DELETE FROM " & tableName & " WHERE id = @ID"

        ' Flag to indicate if deletion was successful
        Dim isDeleted As Boolean = False

        Try
            ' Show confirmation dialog
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the record?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            ' If user clicked OK in the confirmation dialog
            If result = DialogResult.OK Then
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using cmd As New SqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@ID", idToDelete)
                        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                        If count > 0 Then
                            Using deleteCmd As New SqlCommand(deleteQuery, connection)
                                deleteCmd.Parameters.AddWithValue("@ID", idToDelete)
                                deleteCmd.ExecuteNonQuery()
                                isDeleted = True
                            End Using
                        End If
                    End Using
                End Using
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return isDeleted
    End Function

    Private Sub overviewExitbtn_Click(sender As Object, e As EventArgs) Handles overviewExitbtn.Click
        Me.Close()
        Overview.Show()
    End Sub
    Private Sub IncId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IncId.KeyPress
        ' Check if the entered key is not a digit and not a control key
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Suppress the key press
            MsgBox("Ony Numbers")
            e.Handled = True
        End If
    End Sub

    Private Sub ExpId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ExpId.KeyPress
        ' Check if the entered key is not a digit and not a control key
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Suppress the key press
            MsgBox("Ony Numbers")
            e.Handled = True
        End If
    End Sub
End Class
