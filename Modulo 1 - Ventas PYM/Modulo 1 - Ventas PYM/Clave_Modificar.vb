Public Class Clave_Modificar
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
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
    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
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
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub aceptar_MouseLeave(sender As Object, e As EventArgs) Handles aceptar.MouseLeave
        aceptar.BackColor = Color.FromArgb(9, 29, 54)
        aceptar.ForeColor = Color.White
    End Sub
    Private Sub aceptar_MouseMove(sender As Object, e As MouseEventArgs) Handles aceptar.MouseMove
        aceptar.BackColor = Color.FromArgb(237, 237, 237)
        aceptar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub cancelar_MouseLeave(sender As Object, e As EventArgs) Handles cancelar.MouseLeave
        cancelar.BackColor = Color.FromArgb(9, 29, 54)
        cancelar.ForeColor = Color.White
    End Sub
    Private Sub cancelar_MouseMove(sender As Object, e As MouseEventArgs) Handles cancelar.MouseMove
        cancelar.BackColor = Color.FromArgb(237, 237, 237)
        cancelar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        contraseña.Clear()
        Me.Close()
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        contraseña.Clear()
        Me.Close()
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
                    contraseña.Clear()
                    contraseña.Focus()
                    contraseña.Select()
                    MsgBox("Su contraseña es valida, pero los datos a modificar no han sido seleccionados, ingreselos clickeandolo en la grilla e intentelo denuevo", vbExclamation, "Advertencia, Datos no seleccionados")
                Else
                    status.Visible = False
                    contraseña.Clear()
                    MsgBox("Contraseña valida", vbInformation, "Clave Correcta")
                    Ventas.varseleccion = 2
                    Ventas.Bloquear_Desbloquear_Controles(True, False)
                    Ventas.verifica_botones_desabilitados()
                    Ventas.nuevo.Text = "CANCELAR"
                    Dim valor As String
                    valor = Ventas.vende_a.Text
                    Ventas.consulta_lista_desplegable()
                    Ventas.vende_a.Text = valor
                    Me.Close()
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
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.FromArgb(237, 237, 237)
        cerrar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(29, 49, 74)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(29, 49, 74)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.FromArgb(237, 237, 237)
        minimizar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Private Sub Clave_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contraseña.Focus()
        contraseña.Select()
        desabilitar_ayuda.CheckState = My.Settings.ActDesAyuda
    End Sub
    Private Sub desabilitar_ayuda_CheckedChanged(sender As Object, e As EventArgs) Handles desabilitar_ayuda.CheckedChanged
        If (desabilitar_ayuda.Checked = True) Then
            desabilitar_ayuda.Text = "ACTIVAR TODOS LOS MENSAJES DE AYUDA"
            Ventas.Blabla.Active = False
            Grilla_Ventas.Blabla2.Active = False
            Blabla3.Active = False
            My.Settings.ActDesAyuda = 1
            My.Settings.TextoCheckbox = desabilitar_ayuda.Text
            My.Settings.ActDesAyudaVentas = Ventas.Blabla.Active
            My.Settings.ActDesAyudaGrilla = Grilla_Ventas.Blabla2.Active
            My.Settings.ActDesAyudaModificar = Blabla3.Active
            My.Settings.Save()
        ElseIf (desabilitar_ayuda.Checked = False) Then
            desabilitar_ayuda.Text = "DESABILITAR TODOS LOS MENSAJES DE AYUDA"
            Ventas.Blabla.Active = True
            Grilla_Ventas.Blabla2.Active = True
            Blabla3.Active = True
            My.Settings.ActDesAyuda = 0
            My.Settings.TextoCheckbox = desabilitar_ayuda.Text
            My.Settings.ActDesAyudaVentas = Ventas.Blabla.Active
            My.Settings.ActDesAyudaGrilla = Grilla_Ventas.Blabla2.Active
            My.Settings.ActDesAyudaModificar = Blabla3.Active
            My.Settings.Save()
        End If
    End Sub
    Private Sub agregar_nuevo_vend_Click(sender As Object, e As EventArgs) Handles agregar_nuevo_vend.Click
        If (contraseña.Text = "") Then
            MsgBox("Error: El campo de la contraseña esta vacio", vbCritical, "Error, Campo Vacio")
        Else
            Consulta2("Call Verificar_Contraseña_Modificacion_Datos ('" & (contraseña.Text) & "')")
            status.Visible = True
            If (DS2.Tables(DT2.TableName).Rows.Count > 0) Then
                status.Visible = False
                contraseña.Clear()
                Nuevos_Vendedores.Owner = Me
                MsgBox("Contraseña valida", vbInformation, "Clave Correcta")
                Nuevos_Vendedores.ShowDialog()
            Else
                status.Visible = False
                contraseña.Clear()
                contraseña.Focus()
                contraseña.Select()
                MsgBox("Error: La contraseña es incorrecta", vbCritical, "Error, Clave Incorrecta")
            End If
        End If
    End Sub
    Private Sub agregar_nuevo_vend_MouseMove(sender As Object, e As MouseEventArgs) Handles agregar_nuevo_vend.MouseMove
        agregar_nuevo_vend.BackColor = Color.FromArgb(237, 237, 237)
        agregar_nuevo_vend.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub agregar_nuevo_vend_MouseLeave(sender As Object, e As EventArgs) Handles agregar_nuevo_vend.MouseLeave
        agregar_nuevo_vend.BackColor = Color.FromArgb(9, 29, 54)
        agregar_nuevo_vend.ForeColor = Color.White
    End Sub
    Private Sub cambiar_clave_unica_Click(sender As Object, e As EventArgs) Handles cambiar_clave.Click
        status.Visible = True
        Cambiar_Clave_Unica.Owner = Me
        Cambiar_Clave_Unica.ShowDialog()
    End Sub
    Private Sub cambiar_clave_unica_MouseMove(sender As Object, e As MouseEventArgs) Handles cambiar_clave.MouseMove
        cambiar_clave.BackColor = Color.FromArgb(237, 237, 237)
        cambiar_clave.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub cambiar_clave_unica_MouseLeave(sender As Object, e As EventArgs) Handles cambiar_clave.MouseLeave
        cambiar_clave.BackColor = Color.FromArgb(9, 29, 54)
        cambiar_clave.ForeColor = Color.White
    End Sub
End Class