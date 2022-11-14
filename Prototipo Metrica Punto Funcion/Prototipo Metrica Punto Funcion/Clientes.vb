Public Class Clientes
    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        Close()
        Menu1.Show()
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
        Menu1.Show()
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
    Private Sub nuevo_MouseMove(sender As Object, e As MouseEventArgs) Handles nuevo.MouseMove
        nuevo.BackColor = Color.White
        nuevo.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub nuevo_MouseLeave(sender As Object, e As EventArgs) Handles nuevo.MouseLeave
        nuevo.BackColor = Color.FromArgb(0, 77, 64)
        nuevo.ForeColor = Color.White
    End Sub
    Private Sub modificar_MouseMove(sender As Object, e As MouseEventArgs) Handles modificar.MouseMove
        modificar.BackColor = Color.White
        modificar.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub modificar_MouseLeave(sender As Object, e As EventArgs) Handles modificar.MouseLeave
        modificar.BackColor = Color.FromArgb(0, 77, 64)
        modificar.ForeColor = Color.White
    End Sub
    Private Sub eliminar_MouseMove(sender As Object, e As MouseEventArgs) Handles eliminar.MouseMove
        eliminar.BackColor = Color.White
        eliminar.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub eliminar_MouseLeave(sender As Object, e As EventArgs) Handles eliminar.MouseLeave
        eliminar.BackColor = Color.FromArgb(0, 77, 64)
        eliminar.ForeColor = Color.White
    End Sub
    Private Sub guardar_MouseMove(sender As Object, e As MouseEventArgs) Handles guardar.MouseMove
        guardar.BackColor = Color.White
        guardar.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub guardar_MouseLeave(sender As Object, e As EventArgs) Handles guardar.MouseLeave
        guardar.BackColor = Color.FromArgb(0, 77, 64)
        guardar.ForeColor = Color.White
    End Sub
    Private Sub cancelar_MouseMove(sender As Object, e As MouseEventArgs) Handles cancelar.MouseMove
        cancelar.BackColor = Color.White
        cancelar.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub cancelar_MouseLeave(sender As Object, e As EventArgs) Handles cancelar.MouseLeave
        cancelar.BackColor = Color.FromArgb(0, 77, 64)
        cancelar.ForeColor = Color.White
    End Sub
    Private Sub volver_MouseMove(sender As Object, e As MouseEventArgs) Handles volver.MouseMove
        volver.BackColor = Color.White
        volver.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub volver_MouseLeave(sender As Object, e As EventArgs) Handles volver.MouseLeave
        volver.BackColor = Color.FromArgb(0, 77, 64)
        volver.ForeColor = Color.White
    End Sub
End Class