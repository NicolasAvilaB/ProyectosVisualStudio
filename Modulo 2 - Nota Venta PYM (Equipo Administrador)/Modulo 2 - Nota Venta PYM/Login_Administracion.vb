Public Class Login_Administracion
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
    Private Sub Login_Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuario.Focus()
        usuario.Select()
    End Sub
    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        Close()
    End Sub
    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        If (usuario.Text = "") Then
            MsgBox("El campo usuario esta vacio", vbExclamation, "Advertencia, Campo Vacio")
            usuario.Focus()
            usuario.Select()
        ElseIf (clave.Text = "")
            MsgBox("El campo clave esta vacio", vbExclamation, "Advertencia, Campo Vacio")
            clave.Focus()
            clave.Select()
        Else
            Consulta00("Call Consulta_Login_Admin ('" & (usuario.Text) & "','" & (clave.Text) & "')")
            If (DS00.Tables(DT00.TableName).Rows.Count > 0) Then
                Administracion.Show()
                Menus.Close()
                Close()
            Else
                MsgBox("Error: Usuario o Clave Incorrectos", vbCritical, "Error, Datos No Existentes")
                usuario.Clear()
                clave.Clear()
                usuario.Focus()
                usuario.Select()
            End If
        End If
    End Sub
    Private Sub aceptar_MouseMove(sender As Object, e As MouseEventArgs) Handles aceptar.MouseMove
        aceptar.BackColor = Color.White
        aceptar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub aceptar_MouseLeave(sender As Object, e As EventArgs) Handles aceptar.MouseLeave
        aceptar.BackColor = Color.FromArgb(27, 94, 32)
        aceptar.ForeColor = Color.White
    End Sub
    Private Sub volver_MouseMove(sender As Object, e As MouseEventArgs) Handles volver.MouseMove
        volver.BackColor = Color.White
        volver.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub volver_MouseLeave(sender As Object, e As EventArgs) Handles volver.MouseLeave
        volver.BackColor = Color.FromArgb(27, 94, 32)
        volver.ForeColor = Color.White
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
    Private Sub ver_MouseMove(sender As Object, e As MouseEventArgs) Handles ver.MouseMove
        ver.BackColor = Color.White
        ver.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub ver_MouseLeave(sender As Object, e As EventArgs) Handles ver.MouseLeave
        ver.BackColor = Color.FromArgb(27, 94, 32)
        ver.ForeColor = Color.White
    End Sub
    Private Sub ver_Click(sender As Object, e As EventArgs) Handles ver.Click
        If (clave.Text = "") Then
            MsgBox("No has ingresado su clave", vbExclamation, "Error Clave Vacia")
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
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class