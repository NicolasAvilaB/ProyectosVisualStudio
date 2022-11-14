Public Class Form2
    Private Declare Function AnimateWindow Lib "user32" (
    ByVal hwnd As Long,
    ByVal dwTime As Long,
    ByVal dwFlags As Long) As Long
    Private Const AW_ACTIVATE = &H20000 'Activa la ventana cuando finaliza el efecto  
    Private Const AW_BLEND = &H80000
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rets As Long
        rets = AnimateWindow(Me.Handle, 150, AW_BLEND Or AW_ACTIVATE)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Const AW_HIDE = &H10000
        Const AW_BLEND = &H80000
        AnimateWindow(Me.Handle, 150, AW_HIDE Or AW_BLEND)
        Me.Close()
        Dim ret As Long
        ret = AnimateWindow(InicioSesion.Handle, 150, AW_BLEND Or AW_ACTIVATE)
        InicioSesion.nombre.Focus()
        InicioSesion.nombre.Select()
    End Sub
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
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button6_MouseMove(sender As Object, e As MouseEventArgs) Handles Button6.MouseMove
        Button6.BackColor = Color.FromArgb(237, 237, 237)
        Button6.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.BackColor = Color.FromArgb(9, 29, 54)
        Button6.ForeColor = Color.White
    End Sub
    Private Sub Button5_MouseMove(sender As Object, e As MouseEventArgs) Handles Button5.MouseMove
        Button5.BackColor = Color.FromArgb(237, 237, 237)
        Button5.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.FromArgb(9, 29, 54)
        Button5.ForeColor = Color.White
    End Sub
End Class