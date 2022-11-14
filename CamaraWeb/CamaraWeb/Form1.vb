Public Class Form1
    Dim webcam As New Class1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        webcam.timer_tick(PictureBox1)
    End Sub

    Private Sub Inicio_Click(sender As Object, e As EventArgs) Handles Inicio.Click
        webcam.Iniciar(Timer1, Me)
    End Sub

    Private Sub Terminar_Click(sender As Object, e As EventArgs) Handles Terminar.Click
        webcam.Detener(Timer1)
    End Sub

    Private Sub Capturar_Click(sender As Object, e As EventArgs) Handles Capturar.Click
        webcam.Capturar(PictureBox1)
    End Sub
End Class
