Public Class Form1
    Dim xR As Integer
    Dim yR As Integer
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        xR = e.X
        yR = e.Y
    End Sub

    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Button1.Location = New Point(Button1.Left + e.X - xR, Button1.Top + e.Y - yR)
        End If
    End Sub
End Class
