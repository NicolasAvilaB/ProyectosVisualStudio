Public Class Admisn
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Public val As Integer = 0
    Private Sub aceptar_MouseMove(sender As Object, e As MouseEventArgs) Handles aceptar.MouseMove
        aceptar.BackColor = Color.FromArgb(0, 105, 120)
        aceptar.ForeColor = Color.White
    End Sub
    Private Sub aceptar_MouseLeave(sender As Object, e As EventArgs) Handles aceptar.MouseLeave
        aceptar.BackColor = Color.White
        aceptar.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub volver_MouseMove(sender As Object, e As MouseEventArgs) Handles volver.MouseMove
        volver.BackColor = Color.FromArgb(0, 105, 120)
        volver.ForeColor = Color.White
    End Sub
    Private Sub volver_MouseLeave(sender As Object, e As EventArgs) Handles volver.MouseLeave
        volver.BackColor = Color.White
        volver.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.White
        cerrar.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(0, 105, 120)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.White
        minimizar.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(0, 105, 120)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub ver_MouseMove(sender As Object, e As MouseEventArgs) Handles ver.MouseMove
        ver.BackColor = Color.White
        ver.ForeColor = Color.Teal
    End Sub
    Private Sub ver_MouseLeave(sender As Object, e As EventArgs) Handles ver.MouseLeave
        ver.BackColor = Color.Teal
        ver.ForeColor = Color.White
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
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
        Menus.Show()
    End Sub
    Private Sub filtrar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        If (usuario.Text = "") Then
            Advertencia.texto.Text = "El campo usuario esta vacio"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            usuario.Focus()
            usuario.Select()
        ElseIf (clave.Text = "")
            Advertencia.texto.Text = "El campo clave esta vacio"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            clave.Focus()
            clave.Select()
        Else
            If (val = 0) Then
                Busq.Show()
                Consulta("Call Consulta_Login_Admin ('" & (usuario.Text) & "','" & (clave.Text) & "')")
                If (DS.Tables(DT.TableName).Rows.Count > 0) Then
                    Busq.Close()
                    Escalas_Precios.Show()
                    Menus.Close()
                    Close()
                Else
                    Busq.Close()
                    Advertencia.texto.Text = "Usuario y/o clave son incorrectos"
                    Advertencia.Owner = Me
                    Advertencia.ShowDialog()
                    usuario.Clear()
                    clave.Clear()
                    usuario.Focus()
                    usuario.Select()
                End If
            ElseIf (val = 1)
                Consulta4("Call Modificar_Admin('" & (usuario.Text) & "','" & (clave.Text) & "')")
                Advertencia.texto.Text = "Usuario y/o contraseña modificados"
                Advertencia.Owner = Me
                Advertencia.ShowDialog()
                usuario.Clear()
                clave.Clear()
                Close()
            End If
        End If
    End Sub
    Private Sub ver_Click(sender As Object, e As EventArgs) Handles ver.Click
        If (clave.Text = "") Then
            Advertencia.texto.Text = "No hay clave escrita aun"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            clave.Focus()
            clave.Select()
        ElseIf (ver.Text = "●") Then
            clave.PasswordChar = ""
            ver.Text = "Ø"
        Else
            clave.PasswordChar = "●"
            ver.Text = "●"
        End If
    End Sub
    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        Close()
        Menus.Show()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Admisn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuario.Focus()
        usuario.Select()
    End Sub
    Private Sub usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles usuario.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            Advertencia.texto.Text = "Solo se admite Letras y Numeros"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub clave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles clave.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            Advertencia.texto.Text = "Solo se admite Letras y Numeros"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
End Class