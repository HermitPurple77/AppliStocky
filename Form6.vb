Imports System.Data.SqlClient

Public Class form6

    Dim con As New SqlConnection("Data Source=DIYA_S\SQLEXPRESS;Initial Catalog=AMDB;Integrated Security=True")

    ' Load Supplier data on form load
    Private Sub formSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSuppliers()


    End Sub

    ' Load suppliers from database
    Private Sub LoadSuppliers()

        Try
            ' Automatically opens and closes the connection
            Using con As New SqlConnection("Data Source=DIYA_S\SQLEXPRESS;Initial Catalog=AMDB;Integrated Security=True")
                Dim da As New SqlDataAdapter("SELECT * FROM Supplierss", con)
                Dim dt As New DataTable()
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading suppliers: " & ex.Message)
        End Try
    End Sub


    ' Add new supplier
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Please enter required fields: Name and Email.")
            Exit Sub
        End If

        Try
            Using con As New SqlConnection("Data Source=DIYA_S\SQLEXPRESS;Initial Catalog=AMDB;Integrated Security=True")
                con.Open()
                Dim cmd As New SqlCommand("INSERT INTO Supplierss (SupplierName, ContactNumber, Email, Address) 
                                       VALUES (@SupplierName, @ContactNumber, @Email, @Address)", con)
                cmd.Parameters.AddWithValue("@SupplierName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@ContactNumber", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Email", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Address", TextBox5.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Supplier added successfully!")
            LoadSuppliers()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error adding supplier: " & ex.Message)
        End Try
    End Sub


    ' Update existing supplier
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please select a supplier to update.")
            Exit Sub
        End If

        Try
            con.Open()
            Dim cmd As New SqlCommand("UPDATE Supplierss SET SupplierName=@SupplierName, 
                                       ContactNumber=@ContactNumber, Email=@Email, Address=@Address 
                                       WHERE SupplierID=@SupplierID", con)
            cmd.Parameters.AddWithValue("@SupplierID", TextBox1.Text)
            cmd.Parameters.AddWithValue("@SupplierName", TextBox2.Text)
            cmd.Parameters.AddWithValue("@ContactNumber", TextBox3.Text)
            cmd.Parameters.AddWithValue("@Email", TextBox4.Text)
            cmd.Parameters.AddWithValue("@Address", TextBox5.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Supplier updated successfully!")

            LoadSuppliers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating supplier: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Clear all input fields
    Private Sub button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearFields()
    End Sub


    ' Populate fields when a row is selected from DataGridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("SupplierID").Value.ToString()
            TextBox2.Text = row.Cells("SupplierName").Value.ToString()
            TextBox3.Text = row.Cells("ContactNumber").Value.ToString()
            TextBox4.Text = row.Cells("Email").Value.ToString()
            TextBox5.Text = row.Cells("Address").Value.ToString()
        End If
    End Sub

End Class
