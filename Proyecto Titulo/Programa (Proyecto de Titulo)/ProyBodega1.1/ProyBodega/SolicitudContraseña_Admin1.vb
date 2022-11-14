Public Class SolicitudContraseña_Admin1
    Dim Dato1 As String
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
    Private Sub SolicitudContraseña_Admin1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dato1 = Administrador.Grilla_Administrador.CurrentRow.Cells(1).EditedFormattedValue.ToString
        Nom.Text = Dato1
        contra.Enabled = True
        contra.ReadOnly = False
        Ver2.Enabled = True
        contra.Focus()
        contra.Select()
    End Sub
    Private Sub SolicitudContraseña_Admin1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SendKeys.Send("{BACKSPACE}")
        contra.PasswordChar = "*"
        Ver2.Text = "Mostrar"
        ingreso.Enabled = False
        contra.Clear()
    End Sub
    Private Sub contra_TextChanged(sender As Object, e As EventArgs) Handles contra.TextChanged
        Consulta04("Call Login_Acceso3('" & (Nom.Text) & "','" & (contra.Text) & "')")
        If DS04.Tables(DT04.TableName).Rows.Count = 0 Then
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
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
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
    Private Sub ingreso_Click(sender As Object, e As EventArgs) Handles ingreso.Click
        If Administrador.Grilla_Administrador.Rows.Count = 0 Then
            MsgBox("Error: No hay Admins Existentes a Eliminar", vbCritical, "Error, No hay Articulos")
            Me.Close()
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro al Administrador: " + Administrador.nombr.Text + " ?", vbYesNo + vbQuestion, "¿Eliminar Administrador?")
            If valormensaje = vbYes Then
                Consulta2("Call Eliminar_Admin ('" & (Administrador.nombr.Text) & "')")
                MsgBox("El Nombre: '" + Administrador.nombr.Text + "' Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                Administrador.busque_admin.Clear()
                Administrador.nuevo.Focus()
                Administrador.nuevo.Select()
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                Administrador.nuevo.Focus()
                Administrador.nuevo.Select()
            End If
            Administrador.Actualizacion_Tabla()
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Administrador.Mostrar()
            Else
                Administrador.nombr.Clear()
                Administrador.cla.Clear()
            End If
            If Administrador.Grilla_Administrador.Rows.Count = 0 Then
                Administrador.eliminar.Enabled = False
            Else
                Administrador.eliminar.Enabled = True
            End If
            Administrador.Mostrar()
            Administrador.Actualizacion_Tabla()
            Administrador.Mostrar_Grilla()
            Administrador.nuevo.Focus()
            Administrador.nuevo.Select()
            Administrador.nuevo.Focus()
            Administrador.nuevo.Select()
            Me.Close()
        End If
    End Sub
End Class