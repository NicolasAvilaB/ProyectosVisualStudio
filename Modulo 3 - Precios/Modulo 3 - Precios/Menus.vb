Public Class Menus
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.White
        cerrar.ForeColor = Color.FromArgb(98, 117, 127)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(98, 117, 127)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.White
        minimizar.ForeColor = Color.FromArgb(98, 117, 127)
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(98, 117, 127)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub precios_Click(sender As Object, e As EventArgs) Handles precios.Click
        Cargar.Show()
        calculo_escala1()
        calculo_escala1_parte2()
        calculo_escala2()
        calculo_escala2_parte2()
        calculo_escala3()
        calculo_escala3_parte2()
        calculo_escala4()
        calculo_escala4_parte2()
        Close()
        Cotizador.Show()
    End Sub
    Private Sub admin_Click(sender As Object, e As EventArgs) Handles admin.Click
        Hide()
        Admisn.Show()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
    End Sub
    Private Sub admin_MouseMove(sender As Object, e As MouseEventArgs) Handles admin.MouseMove
        admin.BackColor = Color.FromArgb(0, 105, 120)
        admin.ForeColor = Color.White
    End Sub
    Private Sub admin_MouseLeave(sender As Object, e As EventArgs) Handles admin.MouseLeave
        admin.BackColor = Color.White
        admin.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub precios_MouseMove(sender As Object, e As MouseEventArgs) Handles precios.MouseMove
        precios.BackColor = Color.FromArgb(0, 105, 120)
        precios.ForeColor = Color.White
    End Sub
    Private Sub precios_MouseLeave(sender As Object, e As EventArgs) Handles precios.MouseLeave
        precios.BackColor = Color.White
        precios.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub

    Private Sub Menus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class