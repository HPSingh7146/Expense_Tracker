Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Overview

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hpsin\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"

    Private Sub overviewExitbtn_Click(sender As Object, e As EventArgs) Handles overviewExitbtn.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub Overview_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim totalincome As Decimal = 0.00
        Dim totalexpense As Decimal = 0.00

        ' Calculate total income
        Try
            Dim query As String = "SELECT SUM(amount) FROM income WHERE username = @username"
            totalincome = getScalar(query, LoginPage.user)
            inctotal.Text = totalincome
        Catch ex As Exception
            MsgBox("Error calculating total income: " & ex.Message)
        End Try

        ' Calculate total expense
        Try
            Dim query As String = "SELECT SUM(amount) FROM expense WHERE username = @username"
            totalexpense = getScalar(query, LoginPage.user)
            exptotal.Text = totalexpense
        Catch ex As Exception
            MsgBox("Error calculating total expense: " & ex.Message)
        End Try

        ' Set the font for DataGridView column headers and cells
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("segeo ui", 12)
        DataGridView1.DefaultCellStyle.Font = New Font("segeo ui", 10)
        DataGridView2.ColumnHeadersDefaultCellStyle.Font = New Font("segeo ui", 12)
        DataGridView2.DefaultCellStyle.Font = New Font("segeo ui", 10)

        ' Load expense data into DataGridView
        Try
            Dim expenseQuery As String = "SELECT amount, category, exp_remark, date FROM expense WHERE username = @username"
            DataGridView1.DataSource = getDataTable(expenseQuery, LoginPage.user)

            'load income
            Dim incomeQuery As String = "SELECT amount, inc_remark, date FROM income WHERE username = @username"
            DataGridView2.DataSource = getDataTable(incomeQuery, LoginPage.user)

            ' Adjust the width of columns to fit their content
            For Each column As DataGridViewColumn In DataGridView1.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            For Each column As DataGridViewColumn In DataGridView2.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

        Catch ex As Exception
            MsgBox("Error loading expense or income data: " & ex.Message)
        End Try

    End Sub

    'to return tabel data
    Private Function getDataTable(query As String, username As String) As DataTable
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

    'Filter Expense

    Private Sub FilterAndDisplayExpenses(startDate As Date, endDate As Date)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Assuming date is stored as char in the format 'dd-mm-yyyy'
                Dim query As String = "SELECT amount, category, exp_remark, date FROM expense WHERE CONVERT(date, date, 105) BETWEEN CONVERT(date, @startDate, 105) AND CONVERT(date, @endDate, 105) AND username = @username"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@startDate", startDate.ToString("dd-MM-yyyy"))
                    command.Parameters.AddWithValue("@endDate", endDate.ToString("dd-MM-yyyy"))
                    command.Parameters.AddWithValue("@username", LoginPage.user)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error filtering and displaying expenses: " & ex.Message)
        End Try
    End Sub

    Private Sub expFilter_Click(sender As Object, e As EventArgs) Handles expFilter.Click
        Dim startDate As Date = startDateexp.Value
        Dim endDate As Date = EndDateexp.Value
        FilterAndDisplayExpenses(startDate, endDate)
    End Sub


    'Filter Income

    Private Sub FilterAndDisplayIncome(startDate As Date, endDate As Date)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Assuming date is stored as char in the format 'dd-mm-yyyy'
                Dim query As String = "SELECT amount, inc_remark, date FROM income WHERE CONVERT(date, date, 105) BETWEEN CONVERT(date, @startDate, 105) AND CONVERT(date, @endDate, 105) AND username = @username"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@startDate", startDate.ToString("dd-MM-yyyy"))
                    command.Parameters.AddWithValue("@endDate", endDate.ToString("dd-MM-yyyy"))
                    command.Parameters.AddWithValue("@username", LoginPage.user)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        DataGridView2.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error filtering and displaying Income: " & ex.Message)
        End Try
    End Sub

    'Filter expense by category

    Private Sub FilterAndDisplayCategory(category As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Assuming date is stored as char in the format 'dd-mm-yyyy'
                Dim query As String = "SELECT amount, category, exp_remark, date FROM expense WHERE category = @category AND username = @username"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@category", category)
                    command.Parameters.AddWithValue("@username", LoginPage.user)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error filtering and displaying expense: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim category As String = ComboBox1.Text
        FilterAndDisplayCategory(category)
    End Sub

    Private Sub increset_Click(sender As Object, e As EventArgs) Handles increset.Click
        Try
            Dim expenseQuery As String = "SELECT amount, inc_remark, date FROM income WHERE username = @username"
            DataGridView2.DataSource = getDataTable(expenseQuery, LoginPage.user)
        Catch ex As Exception
            MsgBox("Error loading income data: " & ex.Message)
        End Try
    End Sub

    Private Sub expreset_Click(sender As Object, e As EventArgs) Handles expreset.Click
        Try
            Dim expenseQuery As String = "SELECT amount, category, exp_remark, date FROM expense WHERE username = @username"
            DataGridView1.DataSource = getDataTable(expenseQuery, LoginPage.user)
        Catch ex As Exception
            MsgBox("Error loading expense data: " & ex.Message)
        End Try
    End Sub
End Class