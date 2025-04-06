Imports System.Data.SqlClient

Public Class Form3
    ' Connection String (update as needed)
    Private ReadOnly connectionString As String = "Data Source=DIYA_S\SQLEXPRESS;Initial Catalog=AMDB;Integrated Security=True"

    ' Load Products into DataGridView
    Private Sub LoadProducts()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Products"
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Add Product
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click


        If Not ValidateInputs() Then Exit Sub

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Products (ProductName, Category, Price, StockQuantity) VALUES (@name, @category, @price, @stock)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@name", SqlDbType.VarChar).Value = TxtProductName.Text
                    command.Parameters.Add("@category", SqlDbType.VarChar).Value = CmbCategory.Text
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(TxtPrice.Text)
                    command.Parameters.Add("@stock", SqlDbType.Int).Value = Convert.ToInt32(TxtStock.Text)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product Added Successfully!")
                LoadProducts()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Update Product
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If Not ValidateInputs() Then Exit Sub

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Products SET ProductName=@name, Category=@category, Price=@price, StockQuantity=@stock WHERE ProductID=@id"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(TxtProductID.Text)
                    command.Parameters.Add("@name", SqlDbType.VarChar).Value = TxtProductName.Text
                    command.Parameters.Add("@category", SqlDbType.VarChar).Value = CmbCategory.Text
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(TxtPrice.Text)
                    command.Parameters.Add("@stock", SqlDbType.Int).Value = Convert.ToInt32(TxtStock.Text)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product Updated Successfully!")
                LoadProducts()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Delete Product
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If String.IsNullOrWhiteSpace(TxtProductID.Text) Then
            MessageBox.Show("Please select a product to delete.")
            Exit Sub
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM Products WHERE ProductID=@id"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(TxtProductID.Text)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product Deleted Successfully!")
                LoadProducts()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    ' Load Data on Form Load
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        CmbCategory.Items.Add("Home Appliance")
        CmbCategory.Items.Add("Kitchen Appliance")
        CmbCategory.Items.Add("Electronics")

    End Sub

    ' Populate fields from DataGridView row click
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TxtProductID.Text = If(row.Cells("ProductID").Value IsNot DBNull.Value, row.Cells("ProductID").Value.ToString(), "")
            TxtProductName.Text = If(row.Cells("ProductName").Value IsNot DBNull.Value, row.Cells("ProductName").Value.ToString(), "")
            CmbCategory.Text = If(row.Cells("Category").Value IsNot DBNull.Value, row.Cells("Category").Value.ToString(), "")
            TxtPrice.Text = If(row.Cells("Price").Value IsNot DBNull.Value, row.Cells("Price").Value.ToString(), "")
            TxtStock.Text = If(row.Cells("StockQuantity").Value IsNot DBNull.Value, row.Cells("StockQuantity").Value.ToString(), "")
        End If
    End Sub

    ' Input Validation Helper
    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(TxtProductName.Text) OrElse
           String.IsNullOrWhiteSpace(CmbCategory.Text) OrElse
           Not Decimal.TryParse(TxtPrice.Text, Nothing) OrElse
           Not Integer.TryParse(TxtStock.Text, Nothing) Then
            MessageBox.Show("Please enter valid product details.")
            Return False
        End If
        Return True
    End Function
End Class
