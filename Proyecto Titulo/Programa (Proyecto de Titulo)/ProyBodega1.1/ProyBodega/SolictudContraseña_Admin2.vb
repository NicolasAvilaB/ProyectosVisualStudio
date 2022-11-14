Public Class SolictudContraseña_Admin2
    Dim Dato0 As String
    Private Sub ingreso_Click(sender As Object, e As EventArgs) Handles ingreso.Click
        If Administrador.Grilla_Administrador.Rows.Count = 0 Then
            MsgBox("Error: No hay Admins Existentes a Eliminar", vbCritical, "Error, No hay Articulos")
            Me.Close()
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro al Alias: " + Seccion_Acceso.nomali.Text + " ?", vbYesNo + vbQuestion, "¿Eliminar Alias?")
            If valormensaje = vbYes Then
                Consulta05("Call Eliminar_Alias ('" & (Seccion_Acceso.nomali.Text) & "')")
                MsgBox("El Nombre: '" + Seccion_Acceso.nomali.Text + "' Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                Seccion_Acceso.busque_alias.Clear()
                Seccion_Acceso.nuevo.Focus()
                Seccion_Acceso.nuevo.Select()
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                Seccion_Acceso.nuevo.Focus()
                Seccion_Acceso.nuevo.Select()
            End If
            Seccion_Acceso.Actualizacion_Tabla()
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Seccion_Acceso.Mostrar()
            Else
                Seccion_Acceso.nomali.Clear()
                Seccion_Acceso.clav.Clear()
            End If
            If Seccion_Acceso.Grilla_Acceso.Rows.Count = 0 Then
                Seccion_Acceso.eliminar.Enabled = False
            Else
                Seccion_Acceso.eliminar.Enabled = True
            End If
            Seccion_Acceso.Mostrar()
            Seccion_Acceso.Actualizacion_Tabla()
            Seccion_Acceso.Mostrar_Grilla()
            Seccion_Acceso.nuevo.Focus()
            Seccion_Acceso.nuevo.Select()
            Seccion_Acceso.nuevo.Focus()
            Seccion_Acceso.nuevo.Select()
            Me.Close()
        End If
    End Sub
    Private Sub SolictudContraseña_Admin2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dato0 = Seccion_Acceso.Grilla_Acceso.CurrentRow.Cells(1).EditedFormattedValue.ToString
        Nom.Text = Dato0
        contra.Enabled = True
        contra.ReadOnly = False
        Ver2.Enabled = True
        contra.Focus()
        contra.Select()
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
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub cierre_Click(sender As Object, e As EventArgs) Handles cierre.Click
        Me.Close()
    End Sub
    Private Sub contra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            ingreso.Focus()
            ingreso.Select()
            SendKeys.Send("{ENTER}")
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub SolictudContraseña_Admin2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SendKeys.Send("{BACKSPACE}")
        contra.PasswordChar = "*"
        Ver2.Text = "Mostrar"
        ingreso.Enabled = False
        contra.Clear()
    End Sub
    Private Sub contra_TextChanged(sender As Object, e As EventArgs) Handles contra.TextChanged
        Consulta05("Call Login_Eliminator('" & (Nom.Text) & "','" & (contra.Text) & "')")
        If DS05.Tables(DT05.TableName).Rows.Count = 0 Then
            ingreso.Enabled = False
        Else
            ingreso.Enabled = True
        End If
    End Sub
End Class