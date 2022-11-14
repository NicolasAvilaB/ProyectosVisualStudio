Public Class Advertencia
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
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
    End Sub
    Private Sub aceptar_MouseMove(sender As Object, e As MouseEventArgs) Handles aceptar.MouseMove
        aceptar.BackColor = Color.FromArgb(188, 81, 0)
        aceptar.ForeColor = Color.White
    End Sub
    Private Sub aceptar_MouseLeave(sender As Object, e As EventArgs) Handles aceptar.MouseLeave
        aceptar.BackColor = Color.White
        aceptar.ForeColor = Color.FromArgb(188, 81, 0)
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.White
        cerrar.ForeColor = Color.FromArgb(193, 121, 0)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(193, 121, 0)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        Close()
    End Sub

    Private Sub Advertencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class