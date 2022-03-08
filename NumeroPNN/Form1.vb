Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        a = TextBox1.Text
        If (a < 0) Then
            TextBox2.Text = "Negativo"
        End If

        If (a > 0) Then
            TextBox2.Text = "Positivo"
        End If

        If (a = 0) Then
            TextBox2.Text = "Nulo"
        End If

    End Sub
End Class
