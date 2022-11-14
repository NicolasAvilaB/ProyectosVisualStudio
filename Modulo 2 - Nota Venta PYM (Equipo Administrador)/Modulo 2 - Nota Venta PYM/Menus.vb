Public Class Menus
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' habilitar el flag  
            mover = True
            ' guardar las coordenadas  
            x = e.X
            y = e.Y
            ' cambiar el cursor del mouse  
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub
    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' habilitar el flag  
            mover = True
            ' guardar las coordenadas  
            x = e.X
            y = e.Y
            ' cambiar el cursor del mouse  
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub nota_venta_Click(sender As Object, e As EventArgs) Handles nota_venta.Click
        NotaVenta.Show()
        Close()
    End Sub
    Private Sub cotizacion_Click(sender As Object, e As EventArgs) Handles cotizacion.Click
        Cotizaciones.Show()
        Close()
    End Sub
    Private Sub Menus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consulta("show tables;")
        calculo_escala1()
        calculo_escala2()
        calculo_escala1_cotizaciones()
        calculo_escala2_cotizaciones()
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.White
        cerrar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(27, 94, 32)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.White
        minimizar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(27, 94, 32)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub nota_venta_MouseMove(sender As Object, e As MouseEventArgs) Handles nota_venta.MouseMove
        nota_venta.BackColor = Color.White
        nota_venta.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub nota_venta_MouseLeave(sender As Object, e As EventArgs) Handles nota_venta.MouseLeave
        nota_venta.BackColor = Color.FromArgb(27, 94, 32)
        nota_venta.ForeColor = Color.White
    End Sub
    Private Sub cotizacion_MouseMove(sender As Object, e As MouseEventArgs) Handles cotizacion.MouseMove
        cotizacion.BackColor = Color.White
        cotizacion.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub cotizacion_MouseLeave(sender As Object, e As EventArgs) Handles cotizacion.MouseLeave
        cotizacion.BackColor = Color.FromArgb(27, 94, 32)
        cotizacion.ForeColor = Color.White
    End Sub
    Private Sub admin_Click(sender As Object, e As EventArgs) Handles admin.Click
        Login_Administracion.Owner = Me
        Login_Administracion.ShowDialog()
    End Sub
    Private Sub admin_MouseMove(sender As Object, e As MouseEventArgs) Handles admin.MouseMove
        admin.BackColor = Color.White
        admin.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub admin_MouseLeave(sender As Object, e As EventArgs) Handles admin.MouseLeave
        admin.BackColor = Color.FromArgb(27, 94, 32)
        admin.ForeColor = Color.White
    End Sub
End Class