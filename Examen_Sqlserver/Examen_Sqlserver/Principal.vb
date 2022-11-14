Public Class Principal

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
        Bienvenido.Show()
        Me.Hide()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
End Class