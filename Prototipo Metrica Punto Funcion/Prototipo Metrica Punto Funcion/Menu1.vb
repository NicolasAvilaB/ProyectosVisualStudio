Public Class Menu1
    Private Sub camionsitos_Click(sender As Object, e As EventArgs) Handles camionsitos.Click
        Hide()
        Camioneros.Show()
    End Sub
    Private Sub encomienas_Click(sender As Object, e As EventArgs) Handles encomienas.Click
        Hide()
        Encomiendas.Show()
    End Sub

    Private Sub clientela_Click(sender As Object, e As EventArgs) Handles clientela.Click
        Hide()
        Clientes.Show()
    End Sub
    Private Sub camionsitos_MouseMove(sender As Object, e As MouseEventArgs) Handles camionsitos.MouseMove
        camionsitos.BackColor = Color.White
        camionsitos.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub camionsitos_MouseLeave(sender As Object, e As EventArgs) Handles camionsitos.MouseLeave
        camionsitos.BackColor = Color.FromArgb(0, 77, 64)
        camionsitos.ForeColor = Color.White
    End Sub
    Private Sub encomienas_MouseMove(sender As Object, e As MouseEventArgs) Handles encomienas.MouseMove
        encomienas.BackColor = Color.White
        encomienas.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub encomienas_MouseLeave(sender As Object, e As EventArgs) Handles encomienas.MouseLeave
        encomienas.BackColor = Color.FromArgb(0, 77, 64)
        encomienas.ForeColor = Color.White
    End Sub
    Private Sub clientela_MouseMove(sender As Object, e As MouseEventArgs) Handles clientela.MouseMove
        clientela.BackColor = Color.White
        clientela.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub clientela_MouseLeave(sender As Object, e As EventArgs) Handles clientela.MouseLeave
        clientela.BackColor = Color.FromArgb(0, 77, 64)
        clientela.ForeColor = Color.White

    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.White
        cerrar.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(0, 77, 64)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.White
        minimizar.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(0, 77, 64)
        minimizar.ForeColor = Color.White
    End Sub
End Class