Public Class Administracion
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        MenuMesas.Show()
    End Sub
    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Me.Close()
        MenuMesas.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class