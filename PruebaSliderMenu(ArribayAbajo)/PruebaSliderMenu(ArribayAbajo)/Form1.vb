Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Hide()
        While (Panel1.Height < 420)
            Panel1.Height += 1
        End While
        Label2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Hide()
        While (Panel1.Height > 5)
            Panel1.Height -= 1
        End While
        Label1.Show()
    End Sub
End Class
