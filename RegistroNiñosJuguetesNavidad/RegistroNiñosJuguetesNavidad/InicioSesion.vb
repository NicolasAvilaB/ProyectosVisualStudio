Imports System.Net
Public Class InicioSesion
    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 607
        Conexion.ConnectionString = "Database=cre37351_juguetes;Data Source=systemchile.com ;User Id=cre37351_root;Password=lacomunagana; port=3306"
        Consulta("Call ConsultaNombreyClave")
        nombre.Select()
        nombre.Focus()
        Dim fadein As Double
        For fadein = 0.0 To 1.1 Step 0.27
            Me.Opacity = fadein
            Me.Refresh()
        Next
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
        Beep()
        Application.Exit()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Beep()
        Application.Exit()
    End Sub
    Private Sub clave_TextChanged(sender As Object, e As EventArgs) Handles clave.TextChanged
        Consulta("Call Consulta_Nombre_Clave ('" & (nombre.Text) & "','" & (clave.Text) & "')")
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
        Consulta("Call Consulta_Nombre ('" & (nombre.Text) & "')")
        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            clave.Enabled = False
            clave.Clear()
            Ver.Enabled = False
        Else
            clave.Enabled = True
            Ver.Enabled = True
            clave.Focus()
            clave.Select()
        End If
    End Sub
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Consulta1("Call Consulta_Nombre_Clave ('" & (nombre.Text) & "','" & (clave.Text) & "')")
        If DS.Tables(DT.TableName).Rows.Count = 1 Then
            Dim mifecha As Date = Format(Now, "dd/MM/yyyy")
            Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
            Dim i2 As Integer
            Consulta1("Call GeneradorIDautomaticoLogin")
            If TypeOf (DS1.Tables(DT1.TableName).Rows(0).Item("ID")) Is DBNull Then
                i2 = 1
            Else
                i2 = DS1.Tables(DT1.TableName).Rows(0).Item("ID") + 1
                Conexion.Close()
            End If
            Dim valorIp As String
            valorIp = Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString()
            Consulta1("Call Ingreso_Inicio_Sesion ('" & (i2) & "','" & (nombre.Text) & "','" & (valorIp) & "','" & (My.Computer.Name.ToString) & "','" & (Now.ToLongTimeString) & "','" & (mifecha2) & "')")
            MsgBox("Bienvenido/a :" + nombre.Text, vbInformation, "Municipalidad de Peralillo: Control de Bodega")
            MsgBox("Advertencia: " + nombre.Text + ", Tu inicio de sesion se registraran siempre y estaran vigilados por el personal encargado", vbExclamation, "Municipalidad de Peralillo: Control de Bodega")
            Me.Hide()
            RegistrosFichas.Label2.Text = ""
            RegistrosFichas.Label2.Text = nombre.Text
            RegistrosFichas.Show()
        End If
    End Sub
    Private Sub nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Letras", vbCritical, "Error, Admición de Solo Letras")
            e.Handled = True
        End If
        nombre.CharacterCasing = CharacterCasing.Upper
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub InicioSesion_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Focus()
        Me.Select()
        SendKeys.Send("{BACKSPACE}")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
