Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = True
        Panel1.Location = New Point(-1, -1)
        Do Until Panel1.Location.X = -170 'Velocidad de Transicion
            Panel1.Location = New Point(Panel1.Location.X - 1, -1) 'Velocidad de Transicion
            Refresh()
        Loop
        Do Until Panel1.Location.X = -170
            Panel1.Location = New Point(Panel1.Location.X - 2, -1) 'Velocidad de Transicion
            Refresh()
            System.Threading.Thread.Sleep(20)
        Loop
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Button1.Enabled = True
        Panel1.Location = New Point(-168, -1)
        Do Until Panel1.Location.X = -10 'Velocidad de Transicion
            Panel1.Location = New Point(Panel1.Location.X + 2, -1) 'Velocidad de Transicion
            Refresh()
        Loop
        Do Until Panel1.Location.X = -1 'Velocidad de Transicion
            Panel1.Location = New Point(Panel1.Location.X + 1, -1) 'Velocidad de Transicion
            Refresh()
            System.Threading.Thread.Sleep(20)
        Loop
    End Sub
End Class
