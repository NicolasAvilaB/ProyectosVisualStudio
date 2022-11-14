Public Class Form1
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.Visible = False
        Conexion.ConnectionString = "Database=marioluigi;Data Source=localhost;User Id=root;Password=root"
        Consulta("Call NombreyClaveInicioSesion")
        nombre.Focus()
        nombre.Select()
        Dim fadein As Double
        For fadein = 0.0 To 1.1 Step 0.27
            Me.Opacity = fadein
            Me.Refresh()
        Next
        Button3.Focus()
        Button3.Select()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        While (GroupBox1.Height > 479)
            GroupBox1.Height -= 5
        End While
        While (Me.Height > 419)
            Me.Height -= 5
        End While
        login.Visible = True
        nombre.Focus()
        nombre.Select()
        SendKeys.Send("{BACKSPACE}")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        While (GroupBox1.Height < 479)
            GroupBox1.Height += 5
        End While
        While (Me.Height < 508)
            Me.Height += 5
        End While
        login.Visible = False
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
    Private Sub mostrar_Click(sender As Object, e As EventArgs) Handles mostrar.Click
        If clave.Text = "" Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Clave", vbCritical, "¡Error, Campo Clave Vacio!")
            clave.Focus()
            clave.Select()
        ElseIf mostrar.Text = "•" Then
            clave.PasswordChar = ""
            mostrar.Text = "ø"
        Else
            clave.PasswordChar = "*"
            mostrar.Text = "•"
        End If
    End Sub
    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged
        Consulta("Call NombreInicioSesion ('" & (nombre.Text) & "')")
        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            clave.Enabled = False
            clave.ReadOnly = True
            clave.Clear()
            mostrar.Enabled = False
        Else
            clave.Enabled = True
            clave.ReadOnly = False
            mostrar.Enabled = True
            clave.Focus()
            clave.Select()
        End If
    End Sub
    Private Sub clave_TextChanged(sender As Object, e As EventArgs) Handles clave.TextChanged
        Consulta("Call CompruebaNombreyClave ('" & (nombre.Text) & "','" & (clave.Text) & "')")
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
    Private Sub nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombre.KeyPress
        nombre.CharacterCasing = CharacterCasing.Upper
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            clave.Focus()
            clave.Select()
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Focus()
        Me.Select()
    End Sub
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        MsgBox("Bienvenido/a :" + nombre.Text, vbInformation, "Local Gustos Pasteleria y Cafeteria: Control Trans.")
        Me.Hide()
        MenuMesas.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
