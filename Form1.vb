Imports System.Data.SqlClient

Public Class Form1

    ' Connection to your SQL Server
    Dim con As New SqlConnection("Data Source=DIYA_S\SQLEXPRESS;Initial Catalog=AMDB;Integrated Security=True")



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if username and password are filled
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please enter both username and password.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            con.Open()
            Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username=@username AND PasswordHash=@password"

            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", TextBox1.Text)
            cmd.Parameters.AddWithValue("@password", TextBox2.Text)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Optional: Go to Home Page (Form2)
                form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

End Class

