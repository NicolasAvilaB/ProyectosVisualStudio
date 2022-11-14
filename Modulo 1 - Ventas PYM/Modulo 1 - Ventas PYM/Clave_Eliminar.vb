Public Class Clave_Eliminar
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        contraseña.Clear()
        Close()
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        contraseña.Clear()
        Close()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        If (contraseña.Text = "") Then
            MsgBox("Error: El campo de la contraseña esta vacio", vbCritical, "Error, Campo Vacio")
        Else
            Consulta2("Call Verificar_Contraseña_Modificacion_Datos ('" & (contraseña.Text) & "')")
            status.Visible = True
            If (DS2.Tables(DT2.TableName).Rows.Count > 0) Then
                If (Ventas.cliente.Text = "") Then
                    status.Visible = False
                    MsgBox("Advertencia: Busque los datos o seleccionelos para eliminar", vbExclamation, "Advertencia datos vacios")
                    contraseña.Clear()
                    contraseña.Focus()
                    contraseña.Select()
                Else
                    status.Visible = False
                    Dim valormensaje As Integer
                    valormensaje = MsgBox("¿Desea eliminar del registro la siguiente orden de venta: " + Ventas.orden_venta.Text + ", correspondiente al vendedor/a " + Ventas.vende_a.Text + "?", vbYesNo + vbQuestion, "¿Eliminar Registro?")
                    If valormensaje = vbYes Then
                        Consulta("Call Borrar_Dato_Nota_Venta(" & (Ventas.id.Text) & ")")
                        MsgBox("Datos eliminados correctamente", vbInformation, "Datos eliminados")
                        Ventas.limpiar_controles()
                        Close()
                        contraseña.Clear()
                    Else
                        contraseña.Clear()
                        contraseña.Focus()
                        contraseña.Select()
                    End If
                End If
            Else
                contraseña.Clear()
                contraseña.Focus()
                contraseña.Select()
                status.Visible = False
                MsgBox("Error: La contraseña es incorrecta", vbCritical, "Error, Clave Incorrecta")
            End If
        End If
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.FromArgb(237, 237, 237)
        cerrar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(29, 49, 74)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.FromArgb(237, 237, 237)
        minimizar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(29, 49, 74)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub aceptar_MouseMove(sender As Object, e As MouseEventArgs) Handles aceptar.MouseMove
        aceptar.BackColor = Color.White
        aceptar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub aceptar_MouseLeave(sender As Object, e As EventArgs) Handles aceptar.MouseLeave
        aceptar.BackColor = Color.FromArgb(9, 29, 54)
        aceptar.ForeColor = Color.White
    End Sub
    Private Sub cancelar_MouseMove(sender As Object, e As MouseEventArgs) Handles cancelar.MouseMove
        cancelar.BackColor = Color.White
        cancelar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub cancelar_MouseLeave(sender As Object, e As EventArgs) Handles cancelar.MouseLeave
        cancelar.BackColor = Color.FromArgb(9, 29, 54)
        cancelar.ForeColor = Color.White
    End Sub
    Private Sub Clave_Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contraseña.Focus()
        contraseña.Select()
    End Sub
End Class