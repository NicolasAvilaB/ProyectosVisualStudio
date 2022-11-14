Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.ConnectionString = "Database=bodega;Data Source=localhost;User Id=root;Password=root"
        Consulta("Call ConsultaNombreyClave")
        nombre.Select()
        nombre.Focus()
        Dim fadein As Double
        For fadein = 0.0 To 1.1 Step 0.27
            Me.Opacity = fadein
            Me.Refresh()
        Next
        Me.Height = 607
    End Sub
    Private Sub Ver_Click(sender As Object, e As EventArgs) Handles Ver.Click
        If clave.Text = "" Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Clave", vbCritical, "¡Error, Campo Clave Vacio!")
            clave.Focus()
            clave.Select()
        ElseIf Ver.Text = "Mostrar" Then
            clave.PasswordChar = ""
            Ver.Text = "Ocultar"
        Else
            clave.PasswordChar = "*"
            Ver.Text = "Mostrar"
        End If
    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Application.Exit()
    End Sub
    Private Sub clave_TextChanged(sender As Object, e As EventArgs) Handles clave.TextChanged
        Consulta("Call Verifica_Usuario_Clave ('" & (nombre.Text) & "','" & (clave.Text) & "')")
        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            Aceptar.Enabled = False
        Else
            Aceptar.Enabled = True
        End If
    End Sub
    Private Sub clave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles clave.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Aceptar.Focus()
            Aceptar.Select()
            SendKeys.Send("{ENTER}")
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged
        Consulta("Call ConsultaNombre ('" & (nombre.Text) & "')")
        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            clave.Enabled = False
            clave.Clear()
            Ver.Enabled = False
            While (Me.Height > 607)
                Me.Height -= 1
            End While
        Else
            clave.Enabled = True
            Ver.Enabled = True
            clave.Focus()
            clave.Select()
            While (Me.Height < 630)
                Me.Height += 1
            End While
        End If
    End Sub
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Consulta("Call Login ('" & (nombre.Text) & "','" & (clave.Text) & "')")
        If DS.Tables(DT.TableName).Rows.Count = 1 Then
            MsgBox("Bienvenido/a :" + nombre.Text, vbInformation, "Municipalidad de Peralillo: Control de Bodega")
            Me.Hide()
            Secciones1.Show()
        End If
    End Sub
    Private Sub nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombre.KeyPress
        nombre.CharacterCasing = CharacterCasing.Upper
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub Principal_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Focus()
        Me.Select()
        SendKeys.Send("{BACKSPACE}")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Cambio_Contraseña.Show()
    End Sub
End Class
