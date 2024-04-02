Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Dashboard

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hpsin\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        LoginPage.Close()
    End Sub

    Private Sub amtTxtbox_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles addincbtn.Click
        Me.Close()
        AddIncome.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles addexpbtn.Click
        Me.Close()
        AddExpenses.Show()
    End Sub

    Private Sub seeAllbtn_Click(sender As Object, e As EventArgs) Handles seeAllbtn.Click
        Me.Close()
        Overview.Show()
    End Sub

    'To get the name in username lable
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim totalincome As Decimal = 0.00
        Dim totalexpense As Decimal = 0.00
        Dim count = LoginPage.counter

        ' Set the font for DataGridView column headers and cells
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("segeo ui", 12)
        DataGridView1.DefaultCellStyle.Font = New Font("segeo ui", 10)

        'adject size of cells
        If (count > 0) Then
            Dim query As String = "SELECT name FROM userbase WHERE username = @username"
            Try
                Dim name As String = sendQuery(query, "name", LoginPage.user)
                UsernameLbl.Text = name
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        ' Load expense data into DataGridView
        Try
            Dim expenseQuery As String = "SELECT amount, category, exp_remark, date FROM expense WHERE username = @username"
            DataGridView1.DataSource = getDataTable(expenseQuery, LoginPage.user)

            ' Adjust the width of columns to fit their content
            For Each column As DataGridViewColumn In DataGridView1.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        Catch ex As Exception
            MsgBox("Error loading expense data: " & ex.Message)
        End Try

        ' Calculate total income
        Try
            Dim query As String = "SELECT SUM(amount) FROM income WHERE username = @username"
            totalincome = getScalar(query, LoginPage.user)
            totalIncLbl.Text = totalincome
        Catch ex As Exception
            MsgBox("Error calculating total income: " & ex.Message)
        End Try

        ' Calculate total expense
        Try
            Dim query As String = "SELECT SUM(amount) FROM expense WHERE username = @username"
            totalexpense = getScalar(query, LoginPage.user)
            totalExpLbl.Text = totalexpense
        Catch ex As Exception
            MsgBox("Error calculating total expense: " & ex.Message)
        End Try

        ' Calculate total balance
        Dim balance As Decimal = totalincome - totalexpense
        balanceLbl.Text = balance
    End Sub







    ' Function to send queries and get required values for user details
    Public Function sendQuery(query As String, attrib As String, username As String) As String
        Dim value As String = ""
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    While reader.Read()
                        value = Convert.ToString(reader(attrib))
                        Return value
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return value
    End Function

    ' function to return integer values
    Public Function getScalar(query As String, user As String) As Decimal
        Dim count As Decimal = 0.00
        'connection logic
        'direct communication without function
        Try
            Using connection As New SqlConnection(connectionString)
                Try
                    connection.Open()
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Username", user)
                        If IsDBNull(command.ExecuteScalar()) Then
                            count = 0.00
                        Else
                            count = Convert.ToDecimal(command.ExecuteScalar())
                        End If
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return count

    End Function

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

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Close()
        LoginPage.Show()
    End Sub
End Class