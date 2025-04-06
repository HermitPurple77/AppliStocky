
Public Class form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Hello"
        Label3.Text = DateTime.Now.ToString("MMMM dd, yyyy HH:mm")





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        form5.show

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        FORM6.SHOW

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form7.SHOW()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form8.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class