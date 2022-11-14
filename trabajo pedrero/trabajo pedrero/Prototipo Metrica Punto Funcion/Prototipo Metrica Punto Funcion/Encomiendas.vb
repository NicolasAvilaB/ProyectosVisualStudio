Public Class Encomiendas
    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        Close()
        Menu1.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles city.Click
        Hide()
        Ciudades.Show()
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
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
        Menu1.Show()
    End Sub
    Private Sub nuevo_MouseMove(sender As Object, e As MouseEventArgs) Handles nuevo.MouseMove
        nuevo.BackColor = Color.White
        nuevo.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub nuevo_MouseLeave(sender As Object, e As EventArgs) Handles nuevo.MouseLeave
        nuevo.BackColor = Color.FromArgb(0, 77, 64)
        nuevo.ForeColor = Color.White
    End Sub
    Private Sub nuevo2_MouseMove(sender As Object, e As MouseEventArgs) Handles nuevo2.MouseMove
        nuevo2.BackColor = Color.White
        nuevo2.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub nuevo2_MouseLeave(sender As Object, e As EventArgs) Handles nuevo2.MouseLeave
        nuevo2.BackColor = Color.FromArgb(0, 77, 64)
        nuevo2.ForeColor = Color.White
    End Sub
    Private Sub nuevo3_MouseMove(sender As Object, e As MouseEventArgs) Handles nuevo3.MouseMove
        nuevo3.BackColor = Color.White
        nuevo3.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub nuevo3_MouseLeave(sender As Object, e As EventArgs) Handles nuevo3.MouseLeave
        nuevo3.BackColor = Color.FromArgb(0, 77, 64)
        nuevo3.ForeColor = Color.White
    End Sub
    Private Sub modificar_MouseMove(sender As Object, e As MouseEventArgs) Handles modificar.MouseMove
        modificar.BackColor = Color.White
        modificar.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub modificar_MouseLeave(sender As Object, e As EventArgs) Handles modificar.MouseLeave
        modificar.BackColor = Color.FromArgb(0, 77, 64)
        modificar.ForeColor = Color.White
    End Sub
    Private Sub modificar2_MouseMove(sender As Object, e As MouseEventArgs) Handles modificar2.MouseMove
        modificar2.BackColor = Color.White
        modificar2.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub modificar2_MouseLeave(sender As Object, e As EventArgs) Handles modificar2.MouseLeave
        modificar2.BackColor = Color.FromArgb(0, 77, 64)
        modificar2.ForeColor = Color.White
    End Sub
    Private Sub modificar3_MouseMove(sender As Object, e As MouseEventArgs) Handles modificar3.MouseMove
        modificar3.BackColor = Color.White
        modificar3.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub modificar3_MouseLeave(sender As Object, e As EventArgs) Handles modificar3.MouseLeave
        modificar3.BackColor = Color.FromArgb(0, 77, 64)
        modificar3.ForeColor = Color.White
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
    Private Sub guardar2_MouseMove(sender As Object, e As MouseEventArgs) Handles guardar2.MouseMove
        guardar2.BackColor = Color.White
        guardar2.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub guardar2_MouseLeave(sender As Object, e As EventArgs) Handles guardar2.MouseLeave
        guardar2.BackColor = Color.FromArgb(0, 77, 64)
        guardar2.ForeColor = Color.White
    End Sub
    Private Sub guardar3_MouseMove(sender As Object, e As MouseEventArgs) Handles guardar3.MouseMove
        guardar3.BackColor = Color.White
        guardar3.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub guardar3_MouseLeave(sender As Object, e As EventArgs) Handles guardar3.MouseLeave
        guardar3.BackColor = Color.FromArgb(0, 77, 64)
        guardar3.ForeColor = Color.White
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
    Private Sub city_MouseMove(sender As Object, e As MouseEventArgs) Handles city.MouseMove
        city.BackColor = Color.White
        city.ForeColor = Color.FromArgb(0, 77, 64)
    End Sub
    Private Sub city_MouseLeave(sender As Object, e As EventArgs) Handles city.MouseLeave
        city.BackColor = Color.FromArgb(0, 77, 64)
        city.ForeColor = Color.White
    End Sub
End Class