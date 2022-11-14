Imports System.Net.Mail
Public Class Cambio_Contraseña
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub Salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Principal.Show()
        Principal.nombre.Clear()
        Principal.nombre.Focus()
        Principal.nombre.Select()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
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
    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'habilitar el flag  
            mover = True
            'guardar las coordenadas  
            x = e.X
            y = e.Y
            'cambiar el cursor del mouse  
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub
    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Salir_Click_1(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
        Principal.Show()
        Principal.nombre.Clear()
        Principal.nombre.Focus()
        Principal.nombre.Select()
    End Sub
    Private Sub envio_Click_1(sender As Object, e As EventArgs) Handles envio.Click
        While (Me.Height < 355)
            Me.Height += 2
        End While
        If My.Computer.Network.IsAvailable() Then
            Try
                If My.Computer.Network.Ping("www.google.cl", 1000) Then
                    Dim email As String
                    Consulta07("Call Buscar_Correo('" & (Principal.nombre.Text) & "')")
                    If DS07.Tables(DT07.TableName).Rows.Count = 1 Then
                        Dim row As DataRow = DT07.Rows(0)
                        email = CStr(row("Correo_Electronico"))
                    End If
                    ProcesoEmail.Value = 10
                    Dim rand As New Random
                    Dim letter As String
                    Dim x As Integer
                    Dim codigo As String
                    Randomize()
                    For x = 1 To 20
                        codigo = codigo & (Int(Rnd() * 10))
                        letter = ChrW(rand.Next(65, 90))
                        codigo = codigo & letter
                    Next
                    ProcesoEmail.Value = 20
                    Dim mail As New MailMessage
                    Dim i As Integer
                    Consulta07("Call GeneradorIDautomatico5")
                    If TypeOf (DS07.Tables(DT07.TableName).Rows(0).Item("ID")) Is DBNull Then
                        i = 1
                    Else
                        i = DS07.Tables(DT07.TableName).Rows(0).Item("ID") + 1
                        Conexion.Close()
                    End If
                    ProcesoEmail.Value = 30
                    ProcesoEmail.Value = 40
                    Consulta07("Call Inserto_CodigoVerificacion('" & (i) & "','" & (codigo) & "')")
                    Try
                        mail.From = New MailAddress("softwarebodegamuniperalillo@gmail.com")
                        mail.To.Add(email)
                        mail.Subject = "Codigo de Verificación (Restaurar Contraseña)"
                        mail.Body = "Estimado Usuario: Se le ha enviado el siguiente Codigo de Verificación: " & codigo & " Si usted no ha solicitado este codigo para restaurar su contraseña, porfavor contactese con el administrador o el encargado de informatica lo antes posible Atte: Software Bodega Municipalidad de Peralillo"
                        mail.Priority = MailPriority.Normal
                        ProcesoEmail.Value = 50
                        Dim servidor As New SmtpClient("smtp.gmail.com")
                        servidor.Port = 587
                        ProcesoEmail.Value = 70
                        servidor.EnableSsl = True
                        servidor.Credentials = New System.Net.NetworkCredential("softwarebodegamuniperalillo@gmail.com", "SMtp11223344")
                        servidor.Send(mail)
                        ProcesoEmail.Value = 90
                        ProcesoEmail.Value = 100
                        MsgBox("El Codigo de Verificación ha sido Enviado Exitosamente, Porfavor Revise su Correo Electronico", vbInformation, "Codigo Enviado Exitosamente")
                        Me.Height = 322
                        ProcesoEmail.Value = 0
                        While (Panel1.Height > 20)
                            Panel1.Height -= 2
                        End While
                        busqueda_clavee.Focus()
                        busqueda_clavee.Select()
                        SendKeys.Send("{BACKSPACE}")
                    Catch ex As Exception
                    End Try
                Else
                    MsgBox("Error: No se pudo enviar el Correo Electronico, verifique si esta realmente conectado a Internet", vbCritical, "Error, al Enviar Correo")
                    ProcesoEmail.Value = 0
                    While (Me.Height > 320)
                        Me.Height -= 2
                    End While
                End If
            Catch ex As Exception
                MsgBox("Error: No se pudo enviar el Correo Electronico, verifique si esta realmente conectado a Internet", vbCritical, "Error, al Enviar Correo")
                ProcesoEmail.Value = 0
                While (Me.Height > 320)
                    Me.Height -= 2
                End While
            End Try
        Else
            MsgBox("Error: No se pudo enviar el Correo Electronico, verifique si esta realmente conectado a Internet", vbCritical, "Error, al Enviar Correo")
            ProcesoEmail.Value = 0
            While (Me.Height > 320)
                Me.Height -= 2
            End While
        End If
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        While (Panel1.Height > 20)
            Panel1.Height -= 2
        End While
    End Sub
    Private Sub confirmar_Click_1(sender As Object, e As EventArgs) Handles confirmar.Click
        Consulta07("Call Borrar_Clave_Verificacion ('" & (busqueda_clavee.Text) & "')")
        While (Panel3.Height > 20)
            Panel3.Height -= 2
        End While
        Nueva_Cont.Focus()
        Nueva_Cont.Select()
    End Sub
    Private Sub busqueda_clavee_TextChanged_1(sender As Object, e As EventArgs) Handles busqueda_clavee.TextChanged
        Consulta07("Call Buscar_Cla ('" & (busqueda_clavee.Text) & "')")
        If DS07.Tables(DT07.TableName).Rows.Count = 0 Then
            confirmar.Enabled = False
        Else
            confirmar.Enabled = True
        End If
    End Sub
    Private Sub busqueda_clavee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda_clavee.KeyPress
        busqueda_clavee.CharacterCasing = CharacterCasing.Upper
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub muestre_Click_1(sender As Object, e As EventArgs) Handles muestre.Click
        If Nueva_Cont.Text = "" Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Nueva Contraseña", vbCritical, "¡Error, Campo Nueva Contraseña Vacio!")
            Nueva_Cont.Focus()
            Nueva_Cont.Select()
        ElseIf muestre.Text = "Mostrar" Then
            Nueva_Cont.PasswordChar = ""
            muestre.Text = "Ocultar"
        Else
            Nueva_Cont.PasswordChar = "•"
            muestre.Text = "Mostrar"
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If (Nueva_Cont.Text = "") Then
            MsgBox("Error: Campo Nueva Contraseña Vacio, Verifique antes de Continuar", vbCritical, "Error, Campo Vacio")
            Nueva_Cont.Focus()
            Nueva_Cont.Select()
        Else
            muestre.Enabled = False
            Nueva_Cont.PasswordChar = "•"
            muestre1.Enabled = True
            muestre.Text = "Mostrar"
            muestre1.Text = "Mostrar"
            LinkLabel1.Enabled = False
            Con_Contr.Enabled = True
            Con_Contr.ReadOnly = False
            Nueva_Cont.Enabled = False
            Nueva_Cont.ReadOnly = True
            cancel.Enabled = True
            Con_Contr.Focus()
            Con_Contr.Select()
        End If
    End Sub
    Private Sub Con_Contr_TextChanged_1(sender As Object, e As EventArgs) Handles Con_Contr.TextChanged
        If (Nueva_Cont.Text = Con_Contr.Text) Then
            Aceptar.Enabled = True
        Else
            Aceptar.Enabled = False
        End If
    End Sub
    Private Sub muestre1_Click_1(sender As Object, e As EventArgs) Handles muestre1.Click
        If Con_Contr.Text = "" Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Confirmacion Contraseña", vbCritical, "¡Error, Campo Confirmacion Contraseña Vacio!")
            Con_Contr.Focus()
            Con_Contr.Select()
        ElseIf muestre1.Text = "Mostrar" Then
            Con_Contr.PasswordChar = ""
            muestre1.Text = "Ocultar"
        Else
            Con_Contr.PasswordChar = "•"
            muestre1.Text = "Mostrar"
        End If
    End Sub
    Private Sub cancel_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cancel.LinkClicked
        Con_Contr.Enabled = False
        Con_Contr.ReadOnly = True
        Con_Contr.PasswordChar = "•"
        Con_Contr.Clear()
        muestre.Text = "Mostrar"
        muestre1.Text = "Mostrar"
        Nueva_Cont.Clear()
        Nueva_Cont.Enabled = True
        Nueva_Cont.ReadOnly = False
        cancel.Enabled = False
        Aceptar.Enabled = False
        muestre1.Enabled = False
        muestre.Enabled = True
        LinkLabel1.Enabled = True
        Nueva_Cont.Focus()
        Nueva_Cont.Select()
    End Sub
    Private Sub Aceptar_Click_1(sender As Object, e As EventArgs) Handles Aceptar.Click
        Consulta07("Call Modificar_Contraseña ('" & (Con_Contr.Text) & "','" & (Principal.nombre.Text) & "')")
        MsgBox("Contraseña Modificada Correctamente", vbInformation, "Contraseña Cambiada Exitosamente")
        MsgBox("Gracias Por Confiar y Utilizar Nuestros Servicios", vbInformation, "Confirmacion")
        Application.Restart()
    End Sub
    Private Sub Cambio_Contraseña_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Height = 322
    End Sub
    Private Sub Nueva_Cont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nueva_Cont.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub Con_Contr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Con_Contr.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
End Class