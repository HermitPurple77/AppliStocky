Imports System.Data.SqlClient

Public Class form4

    Dim con As New SqlConnection("Data Source=DIYA_S\SQLEXPRESS;Initial Catalog=AMDB;Integrated Security=True")

    Private Sub form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
        LoadProducts()
        LoadOrders()
        ComboBox3.Items.AddRange(New String() {"Pending", "Completed", "Cancelled"})
        ComboBox4.Items.AddRange(New String() {"Paid", "Unpaid"})
    End Sub

    Private Sub LoadCustomers()
        ComboBox1.Items.Clear()
        Try
            con.Open()
            Dim cmd As New SqlCommand("SELECT CustomerID, CustomerName FROM Customerss", con)
            Dim reader = cmd.ExecuteReader()
            While reader.Read()
                ComboBox1.Items.Add(New KeyValuePair(Of Integer, String)(reader("CustomerID"), reader("CustomerName").ToString()))
            End While
            ComboBox1.DisplayMember = "Value"
            ComboBox1.ValueMember = "Key"
        Catch ex As Exception
            MessageBox.Show("Error loading customers: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadProducts()
        ComboBox2.Items.Clear()
        Try
            con.Open()
            Dim cmd As New SqlCommand("SELECT ProductID, ProductName FROM Products", con)
            Dim reader = cmd.ExecuteReader()
            While reader.Read()
                ComboBox2.Items.Add(New KeyValuePair(Of Integer, String)(reader("ProductID"), reader("ProductName").ToString()))
            End While
            ComboBox2.DisplayMember = "Value"
            ComboBox2.ValueMember = "Key"
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadOrders()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("SELECT * FROM Orderss", con)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading orders: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem Is Nothing Or ComboBox2.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a customer and product.")
            Exit Sub
        End If

        If Not Integer.TryParse(TextBox2.Text, Nothing) Then
            MessageBox.Show("Enter a valid quantity.")
            Exit Sub
        End If

        If Not Decimal.TryParse(TextBox3.Text, Nothing) Then
            MessageBox.Show("Enter a valid total price.")
            Exit Sub
        End If

        Dim customerID = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim productID = DirectCast(ComboBox2.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim quantity = Integer.Parse(TextBox2.Text)
        Dim totalPrice = Decimal.Parse(TextBox3.Text)

        Try
            con.Open()

            ' Insert into Orderss and get OrderID
            Dim insertOrder As New SqlCommand("INSERT INTO Orderss (CustomerID, OrderDate, OrderStatus, PaymentStatus, TotalPrice) OUTPUT INSERTED.OrderID VALUES (@CustomerID, @OrderDate, @OrderStatus, @PaymentStatus, @TotalPrice)", con)
            insertOrder.Parameters.AddWithValue("@CustomerID", customerID)
            insertOrder.Parameters.AddWithValue("@OrderDate", DateTimePicker1.Value)
            insertOrder.Parameters.AddWithValue("@OrderStatus", ComboBox3.Text)
            insertOrder.Parameters.AddWithValue("@PaymentStatus", ComboBox4.Text)
            insertOrder.Parameters.AddWithValue("@TotalPrice", totalPrice)

            Dim newOrderID = CInt(insertOrder.ExecuteScalar())

            ' Insert into OrderDetailss
            Dim insertDetail As New SqlCommand("INSERT INTO OrderDetailss (OrderID, ProductID, Quantity, Subtotal) VALUES (@OrderID, @ProductID, @Quantity, @Subtotal)", con)
            insertDetail.Parameters.AddWithValue("@OrderID", newOrderID)
            insertDetail.Parameters.AddWithValue("@ProductID", productID)
            insertDetail.Parameters.AddWithValue("@Quantity", quantity)
            insertDetail.Parameters.AddWithValue("@Subtotal", totalPrice)
            insertDetail.ExecuteNonQuery()

            MessageBox.Show("Order added successfully!")
            LoadOrders()
            Button4.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error adding order: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter the Order ID to delete.")
            Exit Sub
        End If

        Try
            con.Open()

            ' Delete child records first
            Dim delDetails As New SqlCommand("DELETE FROM OrderDetailss WHERE OrderID = @OrderID", con)
            delDetails.Parameters.AddWithValue("@OrderID", TextBox1.Text)
            delDetails.ExecuteNonQuery()

            ' Delete parent record
            Dim delOrder As New SqlCommand("DELETE FROM Orderss WHERE OrderID = @OrderID", con)
            delOrder.Parameters.AddWithValue("@OrderID", TextBox1.Text)
            delOrder.ExecuteNonQuery()

            MessageBox.Show("Order deleted successfully.")
            LoadOrders()
            Button4.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error deleting order: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter Order ID to update.")
            Exit Sub
        End If

        Try
            Dim customerID = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of Integer, String)).Key
            Dim productID = DirectCast(ComboBox2.SelectedItem, KeyValuePair(Of Integer, String)).Key
            Dim quantity = Integer.Parse(TextBox2.Text)
            Dim totalPrice = Decimal.Parse(TextBox3.Text)

            con.Open()

            Dim updateOrder As New SqlCommand("UPDATE Orderss SET CustomerID=@CustomerID, OrderDate=@OrderDate, OrderStatus=@OrderStatus, PaymentStatus=@PaymentStatus, TotalPrice=@TotalPrice WHERE OrderID=@OrderID", con)
            updateOrder.Parameters.AddWithValue("@CustomerID", customerID)
            updateOrder.Parameters.AddWithValue("@OrderDate", DateTimePicker1.Value)
            updateOrder.Parameters.AddWithValue("@OrderStatus", ComboBox3.Text)
            updateOrder.Parameters.AddWithValue("@PaymentStatus", ComboBox4.Text)
            updateOrder.Parameters.AddWithValue("@TotalPrice", totalPrice)
            updateOrder.Parameters.AddWithValue("@OrderID", TextBox1.Text)
            updateOrder.ExecuteNonQuery()

            Dim updateDetails As New SqlCommand("UPDATE OrderDetailss SET ProductID=@ProductID, Quantity=@Quantity, Subtotal=@Subtotal WHERE OrderID=@OrderID", con)
            updateDetails.Parameters.AddWithValue("@ProductID", productID)
            updateDetails.Parameters.AddWithValue("@Quantity", quantity)
            updateDetails.Parameters.AddWithValue("@Subtotal", totalPrice)
            updateDetails.Parameters.AddWithValue("@OrderID", TextBox1.Text)
            updateDetails.ExecuteNonQuery()

            MessageBox.Show("Order updated successfully!")
            LoadOrders()
            Button4.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error updating order: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Now
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            con.Open()
            Dim da As New SqlDataAdapter("SELECT * FROM Orderss WHERE OrderID LIKE @search", con)
            da.SelectCommand.Parameters.AddWithValue("@search", "%" & TextBox4.Text & "%")
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class
