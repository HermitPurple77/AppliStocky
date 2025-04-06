Imports System.Data.SqlClient

Public Class form5

    Dim con As New SqlConnection("Data Source=DIYA_S\SQLEXPRESS;Initial Catalog=AMDB;Integrated Security=True")

    Private Sub ManageCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    Private Sub LoadCustomers()
        Try
            Using con As New SqlConnection("Data Source=DIYA_S\SQLEXPRESS;Initial Catalog=AMDB;Integrated Security=True")
                con.Open()
                Dim query As String = "SELECT * FROM Customerss"
                Dim cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DataGridView1.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading customers: " & ex.Message)
        End Try
    End Sub


    Private Sub ClearFields()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Please fill all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            con.Open()
            Dim query As String = "INSERT INTO Customerss (CustomerName, ContactNumber, Email, Address) 
                                   VALUES (@name, @contact, @email, @address)"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@contact", TextBox3.Text)
            cmd.Parameters.AddWithValue("@email", TextBox4.Text)
            cmd.Parameters.AddWithValue("@address", TextBox5.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Customer Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error adding customer: " & ex.Message)
        Finally
            con.Close()

        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("CustomerID").Value.ToString()
            TextBox2.Text = row.Cells("CustomerName").Value.ToString()
            TextBox3.Text = row.Cells("ContactNumber").Value.ToString()
            TextBox4.Text = row.Cells("Email").Value.ToString()
            TextBox5.Text = row.Cells("Address").Value.ToString()
        End If
    End Sub

    Private Sub BUTTON2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please select a customer to update.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            con.Open()
            Dim query As String = "UPDATE Customerss SET CustomerName=@name, ContactNumber=@contact, Email=@email, Address=@address WHERE CustomerID=@id"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox1.Text))
            cmd.Parameters.AddWithValue("@name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@contact", TextBox3.Text)
            cmd.Parameters.AddWithValue("@email", TextBox4.Text)
            cmd.Parameters.AddWithValue("@address", TextBox5.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Customer Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating customer: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please select a customer to delete.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            con.Open()
            Dim query As String = "DELETE FROM Customerss WHERE CustomerID=@id"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox1.Text))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Customer Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error deleting customer: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            con.Open()
            Dim query As String = "SELECT * FROM Customerss WHERE CustomerName LIKE @search OR ContactNumber LIKE @search"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@search", "%" & TextBox6.Text & "%")
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error searching customer: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearFields()
        LoadCustomers()


    End Sub

End Class
