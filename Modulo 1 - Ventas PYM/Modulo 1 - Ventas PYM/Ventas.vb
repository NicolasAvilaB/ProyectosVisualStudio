Public Class Ventas
    Private x, y As Integer
    Private mover As Boolean
    Dim Vall1, valor_id As Integer
    Dim mult1, mult2 As Long
    Public varseleccion As Integer
    Dim i As Integer
    Sub Bloquear_Desbloquear_Controles(ByVal a As Boolean, ByVal b As Boolean)
        fecha.Enabled = a
        traslado.Enabled = a
        manual.Enabled = a
        cliente.Enabled = a
        man_rep.Enabled = a
        motor.Enabled = a
        n_factura.Enabled = a
        n_factura2.Enabled = a
        n_factura3.Enabled = a
        orden_venta.Enabled = a
        venta_total.Enabled = a
        vende_a.Enabled = a
        valor_fact1.Enabled = a
        valor_fact2.Enabled = a
        valor_fact3.Enabled = a
        motor2.Enabled = a
        manual2.Enabled = a
        traslado.ReadOnly = b
        manual.ReadOnly = b
        cliente.ReadOnly = b
        man_rep.ReadOnly = b
        motor.ReadOnly = b
        n_factura.ReadOnly = b
        n_factura2.ReadOnly = b
        n_factura3.ReadOnly = b
        orden_venta.ReadOnly = b
        venta_total.ReadOnly = b
        valor_fact1.ReadOnly = b
        valor_fact2.ReadOnly = b
        valor_fact3.ReadOnly = b
        motor2.ReadOnly = b
        manual2.ReadOnly = b
        guardar.Enabled = a
        boton_buscar.Enabled = b
        modificar.Enabled = b
        mostrar_grilla.Enabled = b
        eliminar.Enabled = b
    End Sub
    Sub limpiar_controles()
        id.Text = 0
        fecha.Value = Format(Now, "dd-MM-yyyy")
        cliente.Clear()
        orden_venta.Text = 0
        venta_total.Text = 0
        motor.Text = 0
        manual.Text = 0
        motor2.Text = 0
        manual2.Text = 0
        traslado.Text = 0
        n_factura.Text = 0
        n_factura2.Text = 0
        n_factura3.Text = 0
        valor_fact1.Text = 0
        valor_fact2.Text = 0
        valor_fact3.Text = 0
        man_rep.Text = 0
        vende_a.SelectedIndex = -1
    End Sub
    Sub limpiar_controles_buscar()
        id.Text = 0
        fecha.Value = Format(Now, "dd-MM-yyyy")
        cliente.Clear()
        venta_total.Text = 0
        motor.Text = 0
        manual.Text = 0
        motor2.Text = 0
        manual2.Text = 0
        traslado.Text = 0
        n_factura.Text = 0
        n_factura2.Text = 0
        n_factura3.Text = 0
        valor_fact1.Text = 0
        valor_fact2.Text = 0
        valor_fact3.Text = 0
        man_rep.Text = 0
        vende_a.SelectedIndex = -1
    End Sub
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
    Sub consulta_lista_desplegable()
        Try
            Consulta4("Call Relleno_lista_Vendedor_a")
            vende_a.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("lista_vendedores")
            DA4.Fill(dt)
            With vende_a
                .DataSource = dt
                .DisplayMember = "Vendedor_as"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        vende_a.SelectedIndex = -1
    End Sub
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Consulta("show tables;")
        status.Visible = False
        verifica_botones_desabilitados()
        SumaTotal.Enabled = True
        SumaTotal.Interval = 1
        Blabla.Active = My.Settings.ActDesAyudaVentas
        Grilla_Ventas.Blabla2.Active = My.Settings.ActDesAyudaGrilla
        Clave_Modificar.Blabla3.Active = My.Settings.ActDesAyudaModificar
    End Sub
    Private Sub mostrar_grilla_Click(sender As Object, e As EventArgs) Handles mostrar_grilla.Click
        status.Visible = True
        Grilla_Ventas.Owner = Me
        Grilla_Ventas.ShowDialog()
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(29, 49, 74)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(29, 49, 74)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.FromArgb(237, 237, 237)
        minimizar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.FromArgb(237, 237, 237)
        cerrar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Private Sub instalacion_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub traslado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles traslado.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Dim mifecha1 As Date = fecha.Value
        Dim mifecha2 As String = mifecha1.ToString("yyyy-MM-dd")
        If (cliente.Text = "") Then
            MsgBox("Error: El campo cliente se encuentra vacio", vbCritical, "Error: Campo Vacio")
        ElseIf (vende_a.Text = "") Then
            MsgBox("Error: No ha seleccionado a un vendedor/a", vbCritical, "Error: Vendedor/a no Identificado")
        ElseIf (orden_venta.Text = "0") Then
            MsgBox("Error: Numero de orden de venta no puede ser 0", vbCritical, "Error Numero de orden de venta")
            orden_venta.Clear()
            orden_venta.Focus()
            orden_venta.Select()
        ElseIf (varseleccion = 1) Then
            Consulta("Call Validar_Orden_Venta ('" & (orden_venta.Text) & "')")
            If (DS.Tables(DT.TableName).Rows.Count > 0) Then
                MsgBox("Error: La orden de venta ya existe en el registro", vbCritical, "Error de Orden de Venta")
                orden_venta.Clear()
                orden_venta.Focus()
                orden_venta.Select()
            Else
                Try
                    valor_Iddd()
                    Comprobador_Guardado.Show()
                    Consulta("Call Ingresar_Nota_Venta (" & (valor_id) & ",'" & (mifecha2) & "','" & (cliente.Text) & "','" & (orden_venta.Text) & "'," & (venta_total.Text) & "," & (motor.Text) & "," & (manual.Text) & "," & (motor2.Text) & "," & (manual2.Text) & "," & (traslado.Text) & "," & (total_instalacion.Text) & "," & (n_factura.Text) & "," & (n_factura2.Text) & "," & (n_factura3.Text) & "," & (valor_fact1.Text) & "," & (valor_fact2.Text) & "," & (valor_fact3.Text) & "," & (man_rep.Text) & "," & (costos.Text) & "," & (saldo.Text) & ",'" & (vende_a.Text) & "')")
                    Comprobador_Guardado.Close()
                    MsgBox("Datos Guardados Correctamente", vbInformation, "Ingreso de Datos Exitoso")
                    limpiar_controles()
                    verifica_botones_desabilitados()
                    Bloquear_Desbloquear_Controles(False, True)
                    nuevo.Text = "NUEVO"
                    verifica_botones_desabilitados()
                    varseleccion = 0
                    id.Text = "0"
                    vende_a.SelectedIndex = -1
                Catch ex As Exception
                    Dim a As String = Convert.ToString(ex)
                    MsgBox(a, vbExclamation, "Advertencia, Posible Error")
                End Try
            End If
        ElseIf (varseleccion = 2) Then
            Consulta("Call Validar_Orden_Venta ('" & (orden_venta.Text) & "')")
            If (DS.Tables(DT.TableName).Rows.Count > 0) Then
                Dim row As DataRow = DT.Rows(0)
                Dim ids As String = CStr(row("ID"))
                Dim ordens As String = CStr(row("Orden_Venta"))
                If (id.Text = ids And orden_venta.Text = ordens) Then
                    modificar_ventas()
                Else
                    MsgBox("Error: La orden de venta ya existe en el registro", vbCritical, "Error de Orden de Venta")
                    orden_venta.Clear()
                    orden_venta.Focus()
                    orden_venta.Select()
                End If
            Else
                modificar_ventas()
            End If
        End If
    End Sub
    Sub modificar_ventas()
        Dim mifecha1 As Date = fecha.Value
        Dim mifecha2 As String = mifecha1.ToString("yyyy-MM-dd")
        Try
            Comprobador_Modificador.Show()
            Consulta("Call Modificar_Nota_Venta ('" & (mifecha2) & "','" & (cliente.Text) & "','" & (orden_venta.Text) & "'," & (venta_total.Text) & "," & (motor.Text) & "," & (manual.Text) & "," & (motor2.Text) & "," & (manual2.Text) & "," & (traslado.Text) & "," & (total_instalacion.Text) & "," & (n_factura.Text) & "," & (n_factura2.Text) & "," & (n_factura3.Text) & "," & (valor_fact1.Text) & "," & (valor_fact2.Text) & "," & (valor_fact3.Text) & "," & (man_rep.Text) & "," & (costos.Text) & "," & (saldo.Text) & ",'" & (vende_a.Text) & "'," & (id.Text) & ")")
            Comprobador_Modificador.Close()
            MsgBox("Datos Modificados Correctamente", vbInformation, "Ingreso de Datos Exitoso")
            limpiar_controles()
            valor_Iddd()
            verifica_botones_desabilitados()
            Bloquear_Desbloquear_Controles(False, True)
            nuevo.Text = "NUEVO"
            verifica_botones_desabilitados()
            varseleccion = 0
            id.Text = "0"
            vende_a.SelectedIndex = -1
        Catch ex As Exception
            Dim a As String = Convert.ToString(ex)
            MsgBox(a, vbExclamation, "Advertencia, Posible Error")
        End Try
    End Sub
    Private Sub guardar_MouseLeave(sender As Object, e As EventArgs) Handles guardar.MouseLeave
        guardar.BackColor = Color.FromArgb(9, 29, 54)
        guardar.ForeColor = Color.White
    End Sub
    Private Sub guardar_MouseMove(sender As Object, e As MouseEventArgs) Handles guardar.MouseMove
        guardar.BackColor = Color.White
        guardar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Clave_Modificar.Owner = Me
        Clave_Modificar.ShowDialog()
    End Sub
    Private Sub modificar_MouseLeave(sender As Object, e As EventArgs) Handles modificar.MouseLeave
        modificar.BackColor = Color.FromArgb(9, 29, 54)
        modificar.ForeColor = Color.White
    End Sub
    Private Sub modificar_MouseMove(sender As Object, e As MouseEventArgs) Handles modificar.MouseMove
        modificar.BackColor = Color.White
        modificar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs)
        Bloquear_Desbloquear_Controles(False, True)
    End Sub
    Private Sub mostrar_grilla_MouseLeave(sender As Object, e As EventArgs) Handles mostrar_grilla.MouseLeave
        mostrar_grilla.BackColor = Color.FromArgb(9, 29, 54)
        mostrar_grilla.ForeColor = Color.White
    End Sub
    Private Sub mostrar_grilla_MouseMove(sender As Object, e As MouseEventArgs) Handles mostrar_grilla.MouseMove
        mostrar_grilla.BackColor = Color.White
        mostrar_grilla.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub motor_TextChanged(sender As Object, e As EventArgs) Handles motor.TextChanged
        mult_motor()
        suma_total_inst()
    End Sub
    Private Sub manual_TextChanged(sender As Object, e As EventArgs) Handles manual.TextChanged
        mult_manual()
        suma_total_inst()
    End Sub
    Sub mult_manual()
        Dim cant_manual As Long
        Dim cant_motor As Long
        If (manual.Text = "") Then
        ElseIf (manual.Text = 0) Then
            mult1 = 0
        Else
            cant_manual = Convert.ToInt32(manual.Text)
            cant_motor = Convert.ToInt32(motor.Text)
            If (cant_manual = 1) Then
                mult1 = "35000"
            ElseIf (cant_manual = 2) Then
                mult1 = "65000"
            ElseIf (cant_manual = 3) Then
                mult1 = cant_manual * 27000
            End If
            If (cant_manual + cant_motor >= 3) Then
                mult2 = cant_motor * 29000
                mult1 = cant_manual * 27000
            End If
        End If
    End Sub
    Sub mult_motor()
        Dim cant_motor As Long
        Dim cant_manual As Long
        If (motor.Text = "") Then
        ElseIf (motor.Text = 0) Then
            mult2 = 0
        Else
            cant_manual = Convert.ToInt32(manual.Text)
            cant_motor = Convert.ToInt32(motor.Text)
            If (cant_motor = 1) Then
                mult2 = "35000"
            ElseIf (cant_motor = 2) Then
                mult2 = "65000"
            ElseIf (cant_motor = 3) Then
                mult2 = cant_motor * 29000
            End If
            If (cant_manual + cant_motor >= 3) Then
                mult2 = cant_motor * 29000
                mult1 = cant_manual * 27000
            End If
        End If
    End Sub
    Sub suma_total_inst()
        Dim suma, sumamanual, sumamotor, mult As Long
        sumamanual = mult1
        sumamotor = mult2
        suma = sumamanual + sumamotor
        mult = suma * 1.19
        total_instalacion.Text = mult
    End Sub
    Sub valor_vcomision()
        Dim ventatotal, instal, trasl, resta As Long
        If (total_instalacion.Text = "") Then
        Else
            instal = Convert.ToInt64(total_instalacion.Text)
        End If
        If (traslado.Text = "") Then
        Else
            trasl = Convert.ToInt64(traslado.Text)
        End If
        If (venta_total.Text = "") Then
        Else
            ventatotal = Convert.ToInt64(venta_total.Text)
        End If
        resta = ventatotal - instal - trasl
        ' v_comision.Text = resta
    End Sub
    Sub valor_saldo()
        Dim resta, cost, totalventa As Long
        If (venta_total.Text = "") Then
        Else
            totalventa = Convert.ToInt64(venta_total.Text)
        End If
        If (costos.Text = "") Then
        Else
            cost = Convert.ToInt64(costos.Text)
        End If
        resta = totalventa - cost
        saldo.Text = resta
    End Sub
    Sub suma_costo()
        Dim fact1, fact2, fact3, trasl, totalinstalacion, mantencion_reparacion, suma As Long
        If (valor_fact1.Text = "") Then
        Else
            fact1 = Convert.ToInt64(valor_fact1.Text)
        End If
        If (valor_fact2.Text = "") Then
        Else
            fact2 = Convert.ToInt64(valor_fact2.Text)
        End If
        If (valor_fact3.Text = "") Then
        Else
            fact3 = Convert.ToInt64(valor_fact3.Text)
        End If

        If (traslado.Text = "") Then
        Else
            trasl = Convert.ToInt64(traslado.Text)
        End If

        If (man_rep.Text = "") Then
        Else
            mantencion_reparacion = Convert.ToInt64(man_rep.Text)
        End If

        If (total_instalacion.Text = "") Then
        Else
            totalinstalacion = Convert.ToInt64(total_instalacion.Text)
        End If
        suma = fact1 + fact2 + fact3 + trasl + totalinstalacion + mantencion_reparacion
        costos.Text = suma
    End Sub
    Sub valor_Iddd()
        Consulta("Call GeneradorID_NotaVentas")
        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("ID")) Is DBNull Then
            valor_id = 1
            id.Text = valor_id
        Else
            valor_id = DS.Tables(DT.TableName).Rows(0).Item("ID") + 1
            id.Text = valor_id
            Conexion.Close()
        End If
    End Sub
    Sub verifica_botones_desabilitados()
        If (modificar.Enabled = True) Then
            modificar.BackColor = Color.FromArgb(9, 29, 54)
        ElseIf (modificar.Enabled = False)
            modificar.BackColor = Color.White
        End If
        If (mostrar_grilla.Enabled = True) Then
            mostrar_grilla.BackColor = Color.FromArgb(9, 29, 54)
        ElseIf (mostrar_grilla.Enabled = False)
            mostrar_grilla.BackColor = Color.White
        End If
        If (guardar.Enabled = True) Then
            guardar.BackColor = Color.FromArgb(9, 29, 54)
        ElseIf (guardar.Enabled = False)
            guardar.BackColor = Color.White
        End If
        If (nuevo.Enabled = True) Then
            nuevo.BackColor = Color.FromArgb(9, 29, 54)
        ElseIf (nuevo.Enabled = False) Then
            nuevo.BackColor = Color.White
        End If
        If (boton_buscar.Enabled = True) Then
            boton_buscar.BackColor = Color.FromArgb(9, 29, 54)
        ElseIf (boton_buscar.Enabled = False) Then
            boton_buscar.BackColor = Color.White
        End If
        If (eliminar.Enabled = True) Then
            eliminar.BackColor = Color.FromArgb(9, 29, 54)
        ElseIf (eliminar.Enabled = False) Then
            eliminar.BackColor = Color.White
        End If
    End Sub
    Private Sub SumaTotal_Tick(sender As Object, e As EventArgs) Handles SumaTotal.Tick
        Vall1 = Vall1 + 1
        ' valor_vcomision()
        valor_saldo()
        suma_costo()
    End Sub
    Private Sub cliente_TextChanged(sender As Object, e As EventArgs) Handles cliente.TextChanged
        Dim i As Integer
        cliente.Text = StrConv(cliente.Text, VbStrConv.ProperCase)
        i = Len(cliente.Text)
        cliente.SelectionStart = i
    End Sub
    Private Sub cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cliente.KeyPress
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
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub n_factura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles n_factura.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub orden_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles orden_venta.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub venta_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles venta_total.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub costos_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub motor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles motor.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub manual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles manual.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub man_rep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles man_rep.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub valor_fact1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valor_fact1.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub valor_fact2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valor_fact2.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub valor_fact3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valor_fact3.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub n_factura2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles n_factura2.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub n_factura3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles n_factura3.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub vende_a_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub n_factura3_LostFocus(sender As Object, e As EventArgs) Handles n_factura3.LostFocus
        If (n_factura3.Text = "") Then
            n_factura3.Text = 0
        End If
    End Sub
    Private Sub orden_venta_LostFocus(sender As Object, e As EventArgs) Handles orden_venta.LostFocus
        If (orden_venta.Text = "") Then
            orden_venta.Text = 0
        End If
    End Sub
    Private Sub venta_total_LostFocus(sender As Object, e As EventArgs) Handles venta_total.LostFocus
        If (venta_total.Text = "") Then
            venta_total.Text = 0
        End If
    End Sub
    Private Sub n_factura_LostFocus(sender As Object, e As EventArgs) Handles n_factura.LostFocus
        If (n_factura.Text = "") Then
            n_factura.Text = 0
        End If
    End Sub
    Private Sub n_factura2_LostFocus(sender As Object, e As EventArgs) Handles n_factura2.LostFocus
        If (n_factura2.Text = "") Then
            n_factura2.Text = 0
        End If
    End Sub
    Private Sub traslado_LostFocus(sender As Object, e As EventArgs) Handles traslado.LostFocus
        If (traslado.Text = "") Then
            traslado.Text = 0
        End If
    End Sub
    Private Sub man_rep_LostFocus(sender As Object, e As EventArgs) Handles man_rep.LostFocus
        If (man_rep.Text = "") Then
            man_rep.Text = 0
        End If
    End Sub
    Private Sub vende_a_LostFocus(sender As Object, e As EventArgs)
        If (vende_a.Text = "") Then
            vende_a.Text = 0
        End If
    End Sub
    Private Sub valor_fact1_LostFocus(sender As Object, e As EventArgs) Handles valor_fact1.LostFocus
        If (valor_fact1.Text = "") Then
            valor_fact1.Text = 0
        End If
    End Sub
    Private Sub valor_fact2_LostFocus(sender As Object, e As EventArgs) Handles valor_fact2.LostFocus
        If (valor_fact2.Text = "") Then
            valor_fact2.Text = 0
        End If
    End Sub
    Private Sub valor_fact3_LostFocus(sender As Object, e As EventArgs) Handles valor_fact3.LostFocus
        If (valor_fact3.Text = "") Then
            valor_fact3.Text = 0
        End If
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        If (nuevo.Text = "NUEVO") Then
            varseleccion = 1
            limpiar_controles()
            status.Visible = True
            valor_Iddd()
            status.Visible = False
            Bloquear_Desbloquear_Controles(True, False)
            nuevo.Text = "CANCELAR"
            verifica_botones_desabilitados()
            cliente.Focus()
            cliente.Select()
            desglose.Text = "..."
            consulta_lista_desplegable()
        ElseIf (nuevo.Text = "CANCELAR")Then
            varseleccion = 0
            limpiar_controles()
            Bloquear_Desbloquear_Controles(False, True)
            nuevo.Text = "NUEVO"
            verifica_botones_desabilitados()
            id.Text = "0"
            desglose.Text = "..."
            status.Visible = False
        End If
    End Sub
    Private Sub nuevo_MouseMove(sender As Object, e As MouseEventArgs) Handles nuevo.MouseMove
        nuevo.BackColor = Color.White
        nuevo.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub venta_total_TextChanged(sender As Object, e As EventArgs) Handles venta_total.TextChanged
        desglose.Text = Letras(venta_total.Text)
    End Sub
    Private Sub nuevo_MouseLeave(sender As Object, e As EventArgs) Handles nuevo.MouseLeave
        nuevo.BackColor = Color.FromArgb(9, 29, 54)
        nuevo.ForeColor = Color.White
    End Sub
    Private Sub manual_KeyDown(sender As Object, e As KeyEventArgs) Handles manual.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub motor_KeyDown(sender As Object, e As KeyEventArgs) Handles motor.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub venta_total_MouseMove(sender As Object, e As MouseEventArgs) Handles venta_total.MouseMove
        desglose.Text = Letras(venta_total.Text)
    End Sub
    Private Sub venta_total_MouseLeave(sender As Object, e As EventArgs) Handles venta_total.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub traslado_TextChanged(sender As Object, e As EventArgs) Handles traslado.TextChanged
        desglose.Text = Letras(traslado.Text)
    End Sub
    Private Sub total_instalacion_TextChanged(sender As Object, e As EventArgs) Handles total_instalacion.TextChanged
        desglose.Text = Letras(total_instalacion.Text)
    End Sub
    Private Sub total_instalacion_MouseMove(sender As Object, e As MouseEventArgs) Handles total_instalacion.MouseMove
        desglose.Text = Letras(total_instalacion.Text)
    End Sub
    Private Sub man_rep_TextChanged(sender As Object, e As EventArgs) Handles man_rep.TextChanged
        desglose.Text = Letras(man_rep.Text)
    End Sub
    Private Sub total_instalacion_MouseLeave(sender As Object, e As EventArgs) Handles total_instalacion.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub traslado_MouseMove(sender As Object, e As MouseEventArgs) Handles traslado.MouseMove
        desglose.Text = Letras(traslado.Text)
    End Sub
    Private Sub valor_fact1_TextChanged(sender As Object, e As EventArgs) Handles valor_fact1.TextChanged
        desglose.Text = Letras(valor_fact1.Text)
    End Sub
    Private Sub valor_fact2_TextChanged(sender As Object, e As EventArgs) Handles valor_fact2.TextChanged
        desglose.Text = Letras(valor_fact2.Text)
    End Sub
    Private Sub valor_fact3_TextChanged(sender As Object, e As EventArgs) Handles valor_fact3.TextChanged
        desglose.Text = Letras(valor_fact3.Text)
    End Sub
    Private Sub traslado_MouseLeave(sender As Object, e As EventArgs) Handles traslado.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub man_rep_MouseMove(sender As Object, e As MouseEventArgs) Handles man_rep.MouseMove
        desglose.Text = Letras(man_rep.Text)
    End Sub
    Private Sub man_rep_MouseLeave(sender As Object, e As EventArgs) Handles man_rep.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub valor_fact1_MouseMove(sender As Object, e As MouseEventArgs) Handles valor_fact1.MouseMove
        desglose.Text = Letras(valor_fact1.Text)
    End Sub
    Private Sub valor_fact1_MouseLeave(sender As Object, e As EventArgs) Handles valor_fact1.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub valor_fact2_MouseMove(sender As Object, e As MouseEventArgs) Handles valor_fact2.MouseMove
        desglose.Text = Letras(valor_fact2.Text)
    End Sub
    Private Sub valor_fact2_MouseLeave(sender As Object, e As EventArgs) Handles valor_fact2.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub valor_fact3_MouseMove(sender As Object, e As MouseEventArgs) Handles valor_fact3.MouseMove
        desglose.Text = Letras(valor_fact3.Text)
    End Sub
    Private Sub valor_fact3_MouseLeave(sender As Object, e As EventArgs) Handles valor_fact3.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub costos_MouseLeave(sender As Object, e As EventArgs) Handles costos.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub costos_MouseMove(sender As Object, e As MouseEventArgs) Handles costos.MouseMove
        desglose.Text = Letras(costos.Text)
    End Sub
    Private Sub saldo_MouseMove(sender As Object, e As MouseEventArgs) Handles saldo.MouseMove
        desglose.Text = Letras(saldo.Text)
    End Sub
    Private Sub saldo_MouseLeave(sender As Object, e As EventArgs) Handles saldo.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub v_comision_MouseLeave(sender As Object, e As EventArgs)
        desglose.Text = "..."
    End Sub
    Private Sub motor_LostFocus(sender As Object, e As EventArgs) Handles motor.LostFocus
        If (motor.Text = "") Then
            motor.Text = 0
        End If
    End Sub
    Private Sub boton_buscar_Click(sender As Object, e As EventArgs) Handles boton_buscar.Click
        If (boton_buscar.Text = "BUSCAR") Then
            nuevo.Enabled = False
            modificar.Enabled = False
            guardar.Enabled = False
            eliminar.Enabled = False
            mostrar_grilla.Enabled = False
            verifica_botones_desabilitados()
            boton_buscar.Text = "CANCELAR"
            orden_venta.Enabled = True
            orden_venta.ReadOnly = False
            orden_venta.Clear()
            orden_venta.Focus()
            orden_venta.Select()
        ElseIf (boton_buscar.Text = "CANCELAR") Then
            nuevo.Enabled = True
            modificar.Enabled = True
            guardar.Enabled = False
            eliminar.Enabled = True
            mostrar_grilla.Enabled = True
            verifica_botones_desabilitados()
            boton_buscar.Text = "BUSCAR"
            orden_venta.Enabled = False
            orden_venta.ReadOnly = True
        End If
    End Sub
    Private Sub orden_venta_TextChanged(sender As Object, e As EventArgs) Handles orden_venta.TextChanged
        orden_venta.Text = UCase(orden_venta.Text)
        orden_venta.SelectionStart = orden_venta.TextLength + 1
        If (boton_buscar.Enabled = False) Then
        ElseIf (boton_buscar.Text = "CANCELAR") Then
            If (orden_venta.Text = "" Or orden_venta.Text = "0") Then
                limpiar_controles_buscar()
                fecha.Value = "01-01-2018"
            Else
                Consulta6("Call Buscar_por_ordenventa_ventana_ventas ('" & (orden_venta.Text) & "')")
                If (DS6.Tables(DT6.TableName).Rows.Count > 0) Then
                    Dim row As DataRow = DT6.Rows(0)
                    consulta_lista_desplegable()
                    id.Text = CStr(row("ID"))
                    fecha.Text = CStr(row("Fecha"))
                    cliente.Text = CStr(row("Cliente"))
                    venta_total.Text = CStr(row("Venta_Total"))
                    motor.Text = CStr(row("Motor"))
                    manual.Text = CStr(row("Manual"))
                    motor2.Text = CStr(row("Motor_SN"))
                    manual2.Text = CStr(row("Manual_SN"))
                    traslado.Text = CStr(row("Traslado"))
                    n_factura.Text = CStr(row("Fact1"))
                    n_factura2.Text = CStr(row("Fact2"))
                    n_factura3.Text = CStr(row("Fact3"))
                    valor_fact1.Text = CStr(row("Valor_Fact1"))
                    valor_fact2.Text = CStr(row("Valor_Fact2"))
                    valor_fact3.Text = CStr(row("Valor_Fact3"))
                    man_rep.Text = CStr(row("Rep_Mantencion"))
                    vende_a.Text = CStr(row("Vendedor_a"))
                Else
                    limpiar_controles_buscar()
                    fecha.Value = "01-01-2018"
                End If
            End If
        End If
    End Sub
    Private Sub motor2_ValueChanged(sender As Object, e As EventArgs) Handles motor2.ValueChanged
        If (motor2.Text = "") Then
            motor2.Text = 0
        End If
    End Sub
    Private Sub manual2_ValueChanged(sender As Object, e As EventArgs) Handles manual2.ValueChanged
        If (manual2.Text = "") Then
            manual2.Text = 0
        End If
    End Sub
    Private Sub manual_LostFocus(sender As Object, e As EventArgs) Handles manual.LostFocus
        If (manual.Text = "") Then
            manual.Text = 0
        End If
    End Sub
    Private Sub boton_buscar_MouseMove(sender As Object, e As MouseEventArgs) Handles boton_buscar.MouseMove
        boton_buscar.BackColor = Color.White
        boton_buscar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub boton_buscar_MouseLeave(sender As Object, e As EventArgs) Handles boton_buscar.MouseLeave
        boton_buscar.BackColor = Color.FromArgb(9, 29, 54)
        boton_buscar.ForeColor = Color.White
    End Sub
    Private Sub motor2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles motor2.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Clave_Eliminar.Owner = Me
        Clave_Eliminar.ShowDialog()
    End Sub
    Private Sub motor2_KeyDown(sender As Object, e As KeyEventArgs) Handles motor2.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub manual2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles manual2.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub manual2_KeyDown(sender As Object, e As KeyEventArgs) Handles manual2.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub eliminar_MouseMove(sender As Object, e As MouseEventArgs) Handles eliminar.MouseMove
        eliminar.BackColor = Color.White
        eliminar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub eliminar_MouseLeave(sender As Object, e As EventArgs) Handles eliminar.MouseLeave
        eliminar.BackColor = Color.FromArgb(9, 29, 54)
        eliminar.ForeColor = Color.White
    End Sub
End Class