Public Class SolicitudContraseña_Admin3
    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged
        Consulta02("select sublogin.Alias from sublogin where Alias =  '" & (nombre.Text) & "'")
        If DS02.Tables(DT02.TableName).Rows.Count = 0 Then
            contra.Enabled = False
            Ver2.Enabled = False
        Else
            contra.Enabled = True
            contra.ReadOnly = False
            Ver2.Enabled = True
            contra.Focus()
            contra.Select()
        End If
    End Sub
    Private Sub ingreso_Click(sender As Object, e As EventArgs) Handles ingreso.Click
        If Bodega_User.Grilla_Bodega.Rows.Count = 0 Then
            MsgBox("Error: No hay Articulos existentes a Modificar", vbCritical, "Error, No hay Articulos")
            Me.Close()
        Else
            Bodega_User.VarSeleccion = 2
            Bodega_User.hc.Enabled = False
            Bodega_User.rutees.Enabled = True
            Bodega_User.code.Enabled = True
            Bodega_User.cantied.Enabled = True
            Bodega_User.estad.Enabled = True
            Bodega_User.rutees.ReadOnly = False
            Bodega_User.code.ReadOnly = False
            Bodega_User.cantied.ReadOnly = False
            Bodega_User.guardar.Enabled = True
            Bodega_User.busqueda_rut.Enabled = False
            Bodega_User.busqueda_rut.ReadOnly = True
            Bodega_User.guardar.Enabled = True
            Bodega_User.nuevo.Enabled = False
            Bodega_User.eliminar.Enabled = False
            Bodega_User.modificar.Enabled = False
            Bodega_User.Grilla_Bodega.Enabled = False
            Bodega_User.Grilla_Bodega.ReadOnly = True
            Bodega_User.cancelar.Enabled = True
            Bodega_User.nuevo.Focus()
            Bodega_User.nuevo.Select()
            Me.Close()
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub cierre_Click(sender As Object, e As EventArgs) Handles cierre.Click
        Me.Close()
    End Sub
    Private Sub Ver2_Click(sender As Object, e As EventArgs) Handles Ver2.Click
        If contra.Text = "" Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Clave", vbCritical, "¡Error, Campo Clave Vacio!")
            contra.Focus()
            contra.Select()
        ElseIf Ver2.Text = "Mostrar" Then
            contra.PasswordChar = ""
            Ver2.Text = "Ocultar"
        Else
            contra.PasswordChar = "*"
            Ver2.Text = "Mostrar"
        End If
    End Sub
    Private Sub nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombre.KeyPress
        nombre.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub SolicitudContraseña_Admin3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombre.Focus()
        nombre.Select()
    End Sub
    Private Sub SolicitudContraseña_Admin3_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SendKeys.Send("{BACKSPACE}")
        nombre.Clear()
        contra.PasswordChar = "*"
        Ver2.Text = "Mostrar"
        ingreso.Enabled = False
        contra.Clear()
    End Sub
    Private Sub contra_TextChanged(sender As Object, e As EventArgs) Handles contra.TextChanged
        Consulta02("Call Login_Acceso4('" & (nombre.Text) & "','" & (contra.Text) & "')")
        If DS02.Tables(DT02.TableName).Rows.Count = 0 Then
            ingreso.Enabled = False
        Else
            ingreso.Enabled = True
        End If
    End Sub
    Private Sub contra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            ingreso.Focus()
            ingreso.Select()
            SendKeys.Send("{ENTER}")
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class