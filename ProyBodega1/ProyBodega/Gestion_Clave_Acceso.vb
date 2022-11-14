Public Class Gestion_Clave_Acceso
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Ver2.Click
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
    Private Sub Gestion_Clave_Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombre.Focus()
        nombre.Select()
    End Sub
    Private Sub nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombre.KeyPress
        nombre.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged
        Consulta("Call Acceso_Administrador ('" & (nombre.Text) & "')")
        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            contra.Enabled = False
            Ver2.Enabled = False
            contra.Clear()
        Else
            contra.Enabled = True
            contra.ReadOnly = False
            Ver2.Enabled = True
            contra.Focus()
            contra.Select()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cierre.Click
        Me.Close()
        nombre.Clear()
        contra.PasswordChar = "*"
        Ver2.Text = "Mostrar"
        ingreso.Enabled = False
        contra.Clear()
    End Sub
    Private Sub contra_TextChanged(sender As Object, e As EventArgs) Handles contra.TextChanged
        Consulta("Call Login_Acceso2('" & (nombre.Text) & "','" & (contra.Text) & "')")
        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            ingreso.Enabled = False
        Else
            ingreso.Enabled = True
        End If
    End Sub
    Private Sub ingreso_Click(sender As Object, e As EventArgs) Handles ingreso.Click
        Administrador.Show()
        Me.Close()
        Secciones1.Hide()
    End Sub
    Private Sub Gestion_Clave_Acceso_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SendKeys.Send("{BACKSPACE}")
        nombre.Clear()
        contra.PasswordChar = "*"
        Ver2.Text = "Mostrar"
        ingreso.Enabled = False
        contra.Clear()
    End Sub
    Private Sub contra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            ingreso.Focus()
            ingreso.Select()
            SendKeys.Send("{ENTER}")
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class