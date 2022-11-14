Public Class Admin_Mod
    Private Sub Admin_Mod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuario.Focus()
        usuario.Select()
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
    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
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
            Consulta4("Call Modificar_Admin('" & (usuario.Text) & "','" & (clave.Text) & "')")
            Advertencia.texto.Text = "Usuario y/o contraseña modificados"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            usuario.Clear()
            clave.Clear()
            Close()
        End If
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