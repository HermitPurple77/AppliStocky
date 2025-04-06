Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Sales Reports Overview"
    End Sub

    Private Sub BUTTON1_Click(sender As Object, e As EventArgs) Handles BUTTON1.Click
        ' Logic to generate sales report
        MessageBox.Show("Sales report generated successfully.")
    End Sub

    Private Sub BUTTON2_Click(sender As Object, e As EventArgs) Handles BUTTON2.Click
        ' Logic to export report to PDF/Excel
        MessageBox.Show("Sales report exported successfully.")
    End Sub

    Private Sub BUTTON3_Click(sender As Object, e As EventArgs) Handles BUTTON3.Click
        ' Return to Dashboard

        Me.Close()
        form2.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class