Imports System.Data.SqlClient
Public Class AddIncome

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hpsin\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"
    Private Sub AddIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addIncomeExitbtn.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub incfield_Click(sender As Object, e As EventArgs) Handles incfield.Click
        incfield.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles incaddbtn.Click
        Dim income As Decimal = incfield.Text
        If (addincremark.Text = "Type here") Then
            addincremark.Text = ""
        End If
        Dim remark As String = addincremark.Text
        Dim username As String = LoginPage.user
        DateTimePicker1.Value = DateTime.Now
        Dim incdate As String = DateTimePicker1.Value.ToString("dd-MM-yyyy")
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO [dbo].[income] ([username],[amount],[inc_remark],[date] ) VALUES (@username, @amount, @inc_remark, @date)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@amount", income)
                    command.Parameters.AddWithValue("@inc_remark", remark)
                    command.Parameters.AddWithValue("@date", incdate)

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

    Private Sub addincremark_Click(sender As Object, e As EventArgs) Handles addincremark.Click
        addincremark.Clear()
    End Sub

    Private Sub incfield_KeyPress(sender As Object, e As KeyPressEventArgs) Handles incfield.KeyPress
        ' Check if the entered key is not a digit and not a control key
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Ony Numbers")
            ' Suppress the key press
            e.Handled = True
        End If
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