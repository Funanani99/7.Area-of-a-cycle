Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Double
        Dim pi As Double = 3.14
        Dim r As Double


        r = Val(TextBox1.Text)
        A = pi * r ^ 2

        TextBox2.Text = A
    End Sub
End Class
