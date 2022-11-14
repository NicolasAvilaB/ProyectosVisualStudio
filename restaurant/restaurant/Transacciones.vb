Public Class Transacciones
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Dim ita As Integer
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each row As DataGridViewRow In Grilla_Transaccion.Rows
            Consulta21("Call SumaCantidadSegunTabla('" & (CStr(row.Cells(1).Value)) & "')")
        Next
        Me.Close()
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In Grilla_Transaccion.Rows
            Consulta21("Call SumaCantidadSegunTabla('" & (CStr(row.Cells(1).Value)) & "')")
        Next
        Me.Close()
    End Sub
    Private Sub Transacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nomesa.Text = mesaseleccionada
        fecha.Text = FormatDateTime(Now, DateFormat.ShortDate)
        Dim estado As String
        Consulta0("Call CambiarColor ('" & (nomesa.Text) & "')")
        If DS0.Tables(DT0.TableName).Rows.Count > 0 Then
            estado = DS0.Tables(DT0.TableName).Rows(0).Item("Estado")
        End If
        If estado = "Disponible" Then
            canc_pedido.Visible = False
            usuario.Enabled = False
            plato_bebesti.Enabled = False
            usuario.ReadOnly = True
            plato_bebesti.ReadOnly = True
            fabrica_transaccion.Focus()
            fabrica_transaccion.Select()
            cantidad.Enabled = False
            cam.Enabled = False
            aceptar.Enabled = False
            Grilla_Transaccion.Enabled = False
            Grilla_Amigos.Enabled = False
            Label6.Text = "PLATO:"
            cam.Text = "BEBESTIBLE"
            bor_selec.Enabled = False
            concretar.Enabled = False
            ayuda.Enabled = False
            cambio.Enabled = False
            cambio.Text = "CAMBIAR"
            nomesa.Enabled = False
            nomesa.ReadOnly = True
        End If
        If estado = "Ocupado" Then
            fabrica_transaccion.Visible = False
            usuario.Enabled = True
            plato_bebesti.Enabled = True
            usuario.ReadOnly = False
            plato_bebesti.ReadOnly = False
            usuario.Focus()
            usuario.Select()
            cantidad.Enabled = True
            cam.Enabled = True
            aceptar.Enabled = True
            Grilla_Transaccion.Enabled = True
            Grilla_Amigos.Enabled = True
            Label6.Text = "PLATO:"
            cam.Text = "BEBESTIBLE"
            bor_selec.Enabled = True
            concretar.Enabled = True
            cambio.Enabled = True
            cambio.Text = "CAMBIAR"
            nomesa.Enabled = False
            nomesa.ReadOnly = True
        End If
        If (nomesa.Text = "") Then
            sillas.Text = Nothing
        Else
        End If
        Consulta11("Call ConsultaSilla ('" & (nomesa.Text) & "')")
        If DS11.Tables(DT11.TableName).Rows.Count = 1 Then
            Dim row As DataRow = DT11.Rows(0)
            sillas.Text = CStr(row("CantidadSillas"))
        Else
            sillas.Text = Nothing
        End If
        Grilla_Transaccion.Rows.Clear()
        Timer1.Enabled = True
        Timer1.Interval = 100
        Timer2.Interval = 100
        Timer2.Enabled = True
        ita = 0
        If Me.Grilla_Amigos.Rows.Count = 0 Then
            elimineusuario.Enabled = False
        Else
            elimineusuario.Enabled = True
        End If
        Consulta19("Call GeneradorIDBoletaAutomatico")
        If TypeOf (DS19.Tables(DT19.TableName).Rows(0).Item("ID")) Is DBNull Then
            boleteichon.Text = 1
        Else
            boleteichon.Text = DS19.Tables(DT19.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
    End Sub
    Private Sub fabrica_transaccion_Click(sender As Object, e As EventArgs) Handles fabrica_transaccion.Click
        Consulta8("Call ActualizaOcupado ('" & (nomesa.Text) & "')")
        MenuMesas.mesas_dispo_ocup()
        MenuMesas.Close()
        MenuMesas.Show()
        Me.Focus()
        Me.Select()
        fabrica_transaccion.Visible = False
        canc_pedido.Visible = True
        usuario.Enabled = True
        plato_bebesti.Enabled = True
        usuario.ReadOnly = False
        plato_bebesti.ReadOnly = False
        usuario.Clear()
        plato_bebesti.Clear()
        usuario.Focus()
        usuario.Select()
        Grilla_Transaccion.ReadOnly = True
        cantidad.Enabled = True
        cam.Enabled = True
        aceptar.Enabled = True
        Grilla_Transaccion.Enabled = True
        Grilla_Amigos.Enabled = True
        Label6.Text = "PLATO:"
        cam.Text = "BEBESTIBLE"
        bor_selec.Enabled = True
        concretar.Enabled = True
        agregue.Enabled = False
        cambio.Enabled = True
        cambio.Text = "CAMBIAR"
        nomesa.Enabled = False
        nomesa.ReadOnly = True
    End Sub
    Private Sub canc_pedido_Click(sender As Object, e As EventArgs) Handles canc_pedido.Click
        Consulta8("Call ActualizaDisponible ('" & (nomesa.Text) & "')")
        MenuMesas.mesas_dispo_ocup()
        MenuMesas.Close()
        MenuMesas.Show()
        Me.Focus()
        Me.Select()
        canc_pedido.Visible = False
        fabrica_transaccion.Visible = True
        usuario.Enabled = False
        plato_bebesti.Enabled = False
        usuario.ReadOnly = True
        plato_bebesti.ReadOnly = True
        usuario.Clear()
        plato_bebesti.Clear()
        fabrica_transaccion.Focus()
        fabrica_transaccion.Select()
        Grilla_Transaccion.ReadOnly = True
        cantidad.Enabled = False
        cam.Enabled = False
        aceptar.Enabled = False
        Grilla_Amigos.Enabled = False
        Grilla_Transaccion.Enabled = False
        Label6.Text = "PLATO:"
        cam.Text = "BEBESTIBLE"
        bor_selec.Enabled = False
        concretar.Enabled = False
        ayuda.Enabled = False
        agregue.Enabled = False
        cambio.Enabled = False
        cambio.Text = "CAMBIAR"
        nomesa.Enabled = False
        nomesa.ReadOnly = True
        Grilla_Amigos.Rows.Clear()
        Grilla_Transaccion.Rows.Clear()
        Consulta8("Call ConsultaSilla ('" & (nomesa.Text) & "')")
        If DS8.Tables(DT8.TableName).Rows.Count = 1 Then
            Dim row As DataRow = DT8.Rows(0)
            sillas.Text = CStr(row("CantidadSillas"))
        Else
            sillas.Text = Nothing
        End If
        elimineusuario.Enabled = False
    End Sub
    Private Sub usuario_TextChanged(sender As Object, e As EventArgs) Handles usuario.TextChanged
        Dim i As Integer
        usuario.Text = StrConv(usuario.Text, VbStrConv.ProperCase)
        i = Len(usuario.Text)
        usuario.SelectionStart = i
        If (usuario.Text = "") Then
            rut.Text = Nothing
            genero.Text = Nothing
        Else
        End If
        Consulta10("Call ConsultaUsuario ('" & (usuario.Text) & "')")
        If DS10.Tables(DT10.TableName).Rows.Count = 1 Then
            Dim row As DataRow = DT10.Rows(0)
            rut.Text = CStr(row("Rut"))
            genero.Text = CStr(row("Genero"))
            agregue.Enabled = True
        Else
            rut.Text = Nothing
            genero.Text = Nothing
            agregue.Enabled = False
        End If
    End Sub
    Private Sub Grilla_Transaccion_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Transaccion.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Grilla_Transaccion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Transaccion.CellContentClick
        Grilla_Transaccion.ReadOnly = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim suma As Integer = 0.0
        For Each row As DataGridViewRow In Grilla_Transaccion.Rows
            suma += Val(row.Cells(2).Value) * Val(row.Cells(3).Value)
        Next
        totales.Text = Convert.ToInt64(suma)
    End Sub
    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        If (Label6.Text = "PLATO:") Then
            If (Me.Grilla_Amigos.Rows.Count = 0) Then
                MsgBox("Error: La Grilla de Usuarios esta Vacia, Por Favor Asegurese de Poder Agregar un Usuario", vbCritical, "Error, Grilla de Usuario Vacia")
                usuario.Focus()
                usuario.Select()
            ElseIf (plato_bebesti.Text = "") Then
                MsgBox("Error: El Campo Para Agregar los Productos Esta Vacio", vbCritical, "Error, Campo de Productos Vacio")
                plato_bebesti.Focus()
                plato_bebesti.Select()
            Else
                If plato_bebesti.ForeColor = Color.Red Then
                    MsgBox("Error: El Producto " + plato_bebesti.Text + " Se ha Quedado sin Stock", vbCritical, "Error, No existe Stock Para el Producto")
                    plato_bebesti.Clear()
                    plato_bebesti.Focus()
                    plato_bebesti.Select()
                Else
                    Consulta12("Call ConsultaProducto ('" & (plato_bebesti.Text) & "')")
                    If DS12.Tables(DT12.TableName).Rows.Count = 1 Then
                        Dim row As DataRow = DT12.Rows(0)
                        Grilla_Transaccion.Rows.Add(Grilla_Amigos.CurrentRow.Cells(0).EditedFormattedValue.ToString, row("Nombre_Plato"), row("Precio"), "1", row("Tipo_Plato"))
                        Me.Grilla_Transaccion.CurrentCell = Me.Grilla_Transaccion.Rows(Me.Grilla_Transaccion.RowCount - 1).Cells(0)
                        Me.Grilla_Transaccion.Refresh()
                        plato_bebesti.Clear()
                        plato_bebesti.Focus()
                        plato_bebesti.Select()
                    Else
                        MsgBox("Nombre de Producto Incorrecto, Porfavor Verifiquelo e Intentelo Denuevo", vbCritical, "Error, Producto Incorrecto o Inexistente")
                        plato_bebesti.Clear()
                        plato_bebesti.Focus()
                        plato_bebesti.Select()
                    End If
                End If
            End If
            plato_bebesti.Focus()
        ElseIf (Label6.Text = "BEBESTIBLE:")
            If (Me.Grilla_Amigos.Rows.Count = 0) Then
                MsgBox("Error: La Grilla de Usuarios esta Vacia, Por Favor Asegurese de Poder Agregar un Usuario", vbCritical, "Error, Grilla de Usuario Vacia")
                usuario.Focus()
                usuario.Select()
            ElseIf (plato_bebesti.Text = "") Then
                MsgBox("Error: El Campo Para Agregar los Productos Esta Vacio", vbCritical, "Error, Campo de Productos Vacio")
                plato_bebesti.Focus()
                plato_bebesti.Select()
            Else
                If plato_bebesti.ForeColor = Color.Red Then
                    MsgBox("Error: El Producto " + plato_bebesti.Text + " Se ha Quedado sin Stock", vbCritical, "Error, No existe Stock Para el Producto")
                    plato_bebesti.Clear()
                    plato_bebesti.Focus()
                    plato_bebesti.Select()
                Else
                    Consulta12("Call ConsultaBebestible ('" & (plato_bebesti.Text) & "')")
                    If DS12.Tables(DT12.TableName).Rows.Count = 1 Then
                        Dim row As DataRow = DT12.Rows(0)
                        Grilla_Transaccion.Rows.Add(Grilla_Amigos.CurrentRow.Cells(0).EditedFormattedValue.ToString, row("Nombre"), row("Precio"), "1", row("Tipo"))
                        Me.Grilla_Transaccion.CurrentCell = Me.Grilla_Transaccion.Rows(Me.Grilla_Transaccion.RowCount - 1).Cells(0)
                        Me.Grilla_Transaccion.Refresh()
                        Consulta12("Call RestaCantidadBebestible('" & "1" & "','" & (plato_bebesti.Text) & "')")
                        plato_bebesti.Clear()
                        plato_bebesti.Focus()
                        plato_bebesti.Select()
                    Else
                        MsgBox("Nombre de Producto Incorrecto, Porfavor Verifiquelo e Intentelo Denuevo", vbCritical, "Error, Producto Incorrecto o Inexistente")
                        plato_bebesti.Clear()
                        plato_bebesti.Focus()
                        plato_bebesti.Select()
                    End If
                End If
            End If
            plato_bebesti.Focus()
        ElseIf (Label6.Text = "CANTIDAD:")
            If (Me.Grilla_Amigos.Rows.Count = 0) Then
                MsgBox("Error: La Grilla de Usuarios esta Vacia, Por Favor Asegurese de Poder Agregar un Usuario", vbCritical, "Error, Grilla de Usuario Vacia")
                usuario.Focus()
                usuario.Select()
            ElseIf (plato_bebesti.Text = "" Or plato_bebesti.Text = "0") Then
                MsgBox("Error: El Campo Para Agregar la Cantidad Esta Vacio o Valor 0", vbCritical, "Error, Campo de Cantidad Vacio")
                plato_bebesti.Focus()
                plato_bebesti.Select()
            Else
                Consulta12("Call Verifica_Cantidad_Stock_0('" & (Grilla_Transaccion.CurrentRow.Cells(1).EditedFormattedValue.ToString) & "')")
                If (DS12.Tables(DT12.TableName).Rows.Count = 1) Then
                    MsgBox("Error: El Producto " + plato_bebesti.Text + " Se ha Quedado sin Stock", vbCritical, "Error, No existe Stock Para el Producto")
                    plato_bebesti.Clear()
                    plato_bebesti.Focus()
                    plato_bebesti.Select()
                Else
                    Dim row As DataGridViewRow = Me.Grilla_Transaccion.CurrentRow()
                    If Me.Grilla_Transaccion.Rows.Count = 0 Then
                        MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue Alguno Para Continuar", vbCritical, "Error, No Existen Productos en la Grilla")
                        plato_bebesti.Clear()
                        plato_bebesti.Focus()
                    ElseIf (Len(plato_bebesti.Text) >= 4) Then
                        MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 999", vbCritical, "Error, Cantidad SobreExcedida")
                        plato_bebesti.Clear()
                        plato_bebesti.Focus()
                    ElseIf (plato_bebesti.ForeColor = Color.red)
                        row.Cells(3).Value -= Convert.ToInt64(plato_bebesti.Text)
                        plato_bebesti.Clear()
                        plato_bebesti.Focus()
                    Else
                        row.Cells(3).Value += Convert.ToInt64(plato_bebesti.Text)
                        plato_bebesti.Clear()
                        plato_bebesti.Focus()
                    End If
                End If
            End If
        End If
        If Me.Grilla_Transaccion.Rows.Count = 0 Then
            plato_bebesti.Focus()
            plato_bebesti.Select()
        Else
            If (Grilla_Transaccion.CurrentRow.Cells(3).EditedFormattedValue.ToString < 1) Then
                plato_bebesti.Clear()
                plato_bebesti.Focus()
                Dim row1 As DataGridViewRow = Me.Grilla_Transaccion.CurrentRow()
                row1.Cells(3).Value = 1
                MsgBox("Error: No Puedes Resta Cantidad de 1 a 0 etc de Productos", vbCritical, "Error, Resto de Cantidad Equivoco")
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ita = ita + 1
        Dim cantidad1 As Integer = 0.0
        For i = 1 To Grilla_Transaccion.Rows.Count
            cantidad1 = i
        Next
        Items.Text = Convert.ToInt64(cantidad1)
    End Sub
    Private Sub cam_Click(sender As Object, e As EventArgs) Handles cam.Click
        If cam.Text = "BEBESTIBLE" Then
            cam.Text = "PLATO"
            Label6.Text = "BEBESTIBLE:"
            plato_bebesti.Clear()
            plato_bebesti.Width = 187
            plato_bebesti.Location = New Point(292, 239)
            plato_bebesti.ForeColor = Color.Black
            ErrorProvider1.SetError(plato_bebesti, Nothing)
            plato_bebesti.Focus()
            plato_bebesti.Select()
        Else
            cam.Text = "BEBESTIBLE"
            Label6.Text = "PLATO:"
            plato_bebesti.Clear()
            plato_bebesti.Width = 226
            plato_bebesti.Location = New Point(253, 239)
            plato_bebesti.ForeColor = Color.Black
            ErrorProvider1.SetError(plato_bebesti, Nothing)
            plato_bebesti.Focus()
            plato_bebesti.Select()
        End If
    End Sub
    Private Sub cantidad_Click(sender As Object, e As EventArgs) Handles cantidad.Click
        If Me.Grilla_Transaccion.Rows.Count = 0 Then
            MsgBox("Error: No Existe Productos Registrados, Para Efectuar Cantidades, Se Necesita Productos", vbCritical, "Error, Operación Incorrecta")
            plato_bebesti.Focus()
            plato_bebesti.Select()
        Else
            If cantidad.Text = "CANTIDAD" Then
                cantidad.Text = "CANCELAR"
                Label6.Text = "CANTIDAD:"
                plato_bebesti.Clear()
                plato_bebesti.Width = 204
                plato_bebesti.Location = New Point(275, 239)
                cam.Enabled = False
                cam.Text = "BEBESTIBLE"
                plato_bebesti.ForeColor = Color.Black
                ErrorProvider1.SetError(plato_bebesti, Nothing)
                plato_bebesti.Focus()
                plato_bebesti.Select()
            Else
                cantidad.Text = "CANTIDAD"
                plato_bebesti.ForeColor = Color.Black
                ErrorProvider1.SetError(plato_bebesti, Nothing)
                Label6.Text = "PLATO:"
                plato_bebesti.Clear()
                plato_bebesti.Width = 226
                plato_bebesti.Location = New Point(253, 239)
                cam.Enabled = True
                cam.Text = "BEBESTIBLE"
                plato_bebesti.Focus()
                plato_bebesti.Select()
            End If
        End If
    End Sub
    Private Sub plato_bebesti_TextChanged(sender As Object, e As EventArgs) Handles plato_bebesti.TextChanged
        Dim i As Integer
        plato_bebesti.Text = StrConv(plato_bebesti.Text, VbStrConv.ProperCase)
        i = Len(plato_bebesti.Text)
        plato_bebesti.SelectionStart = i
        If (Label6.Text = "BEBESTIBLE:") Then
            Consulta12("Call VerificaCantidadBebestibles0('" & (plato_bebesti.Text) & "')")
            If DS12.Tables(DT12.TableName).Rows.Count = 0 Then
                plato_bebesti.ForeColor = Color.Black
            Else
                plato_bebesti.ForeColor = Color.Red
            End If
        ElseIf (Label6.Text = "CANTIDAD:") Then
            If plato_bebesti.Text = "" Then
                Consulta13("Call Verificacion_Cantidad_Grilla('" & (Grilla_Transaccion.CurrentRow.Cells(1).EditedFormattedValue.ToString) & "','" & "0" & "')")
            Else
                Consulta13("Call Verificacion_Cantidad_Grilla('" & (Grilla_Transaccion.CurrentRow.Cells(1).EditedFormattedValue.ToString) & "','" & (Convert.ToInt64(Grilla_Transaccion.CurrentRow.Cells(3).EditedFormattedValue.ToString) + Convert.ToInt64(plato_bebesti.Text)) & "')")
                If DS13.Tables(DT13.TableName).Rows.Count = 0 Then
                    plato_bebesti.ForeColor = Color.Black
                Else
                    plato_bebesti.ForeColor = Color.Red
                End If
            End If
            If (plato_bebesti.Text = "0") Then
                SendKeys.Send("{BACKSPACE}")
            End If
            If (plato_bebesti.Text = "") Then
                ErrorProvider1.SetError(plato_bebesti, Nothing)
            ElseIf (plato_bebesti.ForeColor = Color.Red) Then
                ErrorProvider1.SetError(plato_bebesti, "Error: Cantidad Sobrepasada a la Actual, El Producto se quedo sin Stock, Se esta quedando sin stock o Puedes Restar su Cantidad")
            ElseIf (plato_bebesti.ForeColor = Color.Black) Then
                ErrorProvider1.SetError(plato_bebesti, Nothing)
            ElseIf Label6.Text = "PLATO:" Or Label6.Text = "BEBESTIBLE:"
                plato_bebesti.ForeColor = Color.Black
                ErrorProvider1.SetError(plato_bebesti, Nothing)
            End If
        End If
    End Sub
    Private Sub usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles usuario.KeyPress
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
    End Sub
    Private Sub plato_bebesti_KeyPress(sender As Object, e As KeyPressEventArgs) Handles plato_bebesti.KeyPress
        If Label6.Text = "CANTIDAD:" And cantidad.Text = "CANCELAR" Then
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
                e.Handled = True
            End If
        ElseIf Label6.Text = "PLATO:"
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
        ElseIf Label6.Text = "BEBESTIBLE:"
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
        End If
    End Sub
    Private Sub bor_selec_Click(sender As Object, e As EventArgs) Handles bor_selec.Click
        If Me.Grilla_Transaccion.Rows.Count = 0 Then
            MsgBox("Error: No Hay Producto Seleccionado a Eliminar", vbCritical, "Error Fatal")
            plato_bebesti.Focus()
            plato_bebesti.Select()
        Else
            Consulta21("Call SumaCantidadSegunTabla('" & (Grilla_Transaccion.CurrentRow.Cells(1).EditedFormattedValue.ToString) & "')")
            Dim loFila As DataGridViewRow = Me.Grilla_Transaccion.CurrentRow()
            Grilla_Transaccion.Rows.Remove(loFila)
        End If
    End Sub
    Private Sub elim_trans_Click(sender As Object, e As EventArgs)
        Dim esult As String
        If Me.Grilla_Transaccion.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
            plato_bebesti.Focus()
            plato_bebesti.Select()
            plato_bebesti.Clear()
        Else
            esult = MsgBox("¿Estas Seguro de Eliminar la Transaccion Hecha Hasta El Momento?", vbOKCancel + vbQuestion, "Eliminar Transaccion")
            If esult = vbOK Then
                Grilla_Transaccion.Rows.Clear()
                plato_bebesti.Focus()
                plato_bebesti.Select()
                plato_bebesti.Clear()
            Else
                MsgBox("Cancelaste la Operacion", vbExclamation, "Operacion Cancelada")
                plato_bebesti.Focus()
                plato_bebesti.Select()
                plato_bebesti.Clear()
            End If
        End If
        plato_bebesti.Focus()
        plato_bebesti.Select()
        plato_bebesti.Clear()
    End Sub
    Private Sub concretar_Click(sender As Object, e As EventArgs) Handles concretar.Click
        If Me.Grilla_Transaccion.Rows.Count = 0 Then
            MsgBox("Error: No Se Podra Concretar la Venta Porque No Existen Productos a Vender", vbCritical, "Error Fatal")
            plato_bebesti.Focus()
            plato_bebesti.Select()
        Else
            Concretar_Ventas.Owner = Me
            Concretar_Ventas.ShowDialog()
        End If
    End Sub
    Private Sub ayuda_Click(sender As Object, e As EventArgs) Handles ayuda.Click
        Ayuda_Dinamica.Owner = Me
        Ayuda_Dinamica.ShowDialog()
    End Sub
    Private Sub Grilla_Amigos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Amigos.CellContentClick
        Grilla_Amigos.ReadOnly = False
    End Sub
    Private Sub Grilla_Amigos_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Amigos.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub elimineusuario_Click(sender As Object, e As EventArgs) Handles elimineusuario.Click
        If Me.Grilla_Amigos.Rows.Count = 0 Then
            MsgBox("Error: No Existe Usuarios Registrados, Para Eliminar se Necesita Agente Inscrito", vbCritical, "Error, Operación Incorrecta")
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro al Siguiente Usuario : " + Grilla_Amigos.CurrentRow.Cells(0).EditedFormattedValue.ToString + " ?", vbYesNo + vbQuestion, "¿Eliminar Usuario?")
            If valormensaje = vbYes Then
                Dim loFila As DataGridViewRow = Me.Grilla_Amigos.CurrentRow()
                Grilla_Amigos.Rows.Remove(loFila)
                MsgBox("Usuario Eliminado de la Grilla", vbInformation, "Eliminacion Exitosa")
                usuario.Clear()
                usuario.Focus()
                usuario.Select()
                sillas.Text += 1
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                usuario.Clear()
                usuario.Focus()
                usuario.Select()
            End If
        End If
        If Me.Grilla_Amigos.Rows.Count = 0 Then
            elimineusuario.Enabled = False
            ayuda.Enabled = False
        Else
            elimineusuario.Enabled = True
            ayuda.Enabled = True
        End If
    End Sub
    Private Sub agregue_Click(sender As Object, e As EventArgs) Handles agregue.Click
        Dim run As String
        For Each row As DataGridViewRow In Grilla_Amigos.Rows
            run = row.Cells(0).Value
        Next
        If (Me.Grilla_Amigos.Rows.Count = 0) Then
            Grilla_Amigos.Rows.Add(usuario.Text)
            usuario.Clear()
            usuario.Focus()
            usuario.Select()
            ayuda.Enabled = True
            sillas.Text -= 1
        ElseIf (sillas.Text = "0")
            MsgBox("Error: No Podras Agregar mas Usuarios, Puesto que la Cantidad a Satisfacer de Sillas es Completamente Nula o No Cuenta con mas Sillas", vbCritical, "Error, Cantidad de Sillas Ya Ocupadas")
            MsgBox("Puedes Intentar Eliminar Usuarios de la Grilla", vbExclamation, "Posibilidad de Eliminar Usuarios")
            usuario.Clear()
            elimineusuario.Focus()
            elimineusuario.Select()
        ElseIf (Grilla_Amigos.CurrentRow.Cells(0).EditedFormattedValue.ToString = usuario.Text) Then
            MsgBox("Error: Ya Existe este Usuario en la Grilla", vbCritical, "Error, Usuario ya Existe")
            usuario.Clear()
            usuario.Focus()
            usuario.Select()
            ayuda.Enabled = True
        ElseIf (run = usuario.Text) Then
            MsgBox("Error: Ya Existe este Usuario en la Grilla", vbCritical, "Error, Usuario ya Existe")
            usuario.Clear()
            usuario.Focus()
            usuario.Select()
            ayuda.Enabled = True
        Else
            Grilla_Amigos.Rows.Add(usuario.Text)
            usuario.Clear()
            usuario.Focus()
            usuario.Select()
            ayuda.Enabled = True
            sillas.Text -= 1
        End If
        If Me.Grilla_Amigos.Rows.Count = 0 Then
            elimineusuario.Enabled = False
            ayuda.Enabled = False
        Else
            elimineusuario.Enabled = True
            ayuda.Enabled = True
        End If
    End Sub
    Private Sub cambio_Click(sender As Object, e As EventArgs) Handles cambio.Click
        If (cambio.Text = "CAMBIAR") Then
            cambio.Text = "ACEPTAR"
            nomesa.Enabled = True
            nomesa.ReadOnly = False
        Else
            Consulta20("Call VerificacionMesaExistente('" & (nomesa.Text) & "')")
            If (DS20.Tables(DT20.TableName).Rows.Count = 0) Then
                MsgBox("Error: Mesa no Existente, Procure de Digitar una Mesa Correspondiente", vbCritical, "Error, Mesa Inexistente")
            Else
                Consulta20("Call VerificaMesaOcupada('" & (nomesa.Text) & "')")
                If (DS20.Tables(DT20.TableName).Rows.Count = 1) Then
                    MsgBox("Error: No Podras Cambiar a esta Mesa Por estar Ocupada", vbCritical, "Error, Mesa Ocupada")
                Else
                    Consulta20("Call ActualizaOcupado ('" & (nomesa.Text) & "')")
                    Consulta20("Call ActualizaDisponible ('" & (mesaseleccionada) & "')")
                    MenuMesas.Close()
                    MenuMesas.Show()
                    nomesa.Enabled = False
                    nomesa.ReadOnly = True
                    cambio.Text = "CAMBIAR"
                    Me.Hide()
                    Me.Show()
                    mesaseleccionada = nomesa.Text
                    nomesa.Text = mesaseleccionada
                    Consulta20("Call ConsultaSilla ('" & (nomesa.Text) & "')")
                    If DS20.Tables(DT20.TableName).Rows.Count = 1 Then
                        Dim row As DataRow = DT20.Rows(0)
                        sillas.Text = CStr(row("CantidadSillas"))
                    Else
                        sillas.Text = Nothing
                    End If
                    For Each row As DataGridViewRow In Grilla_Transaccion.Rows
                        Consulta21("Call SumaCantidadSegunTabla('" & (CStr(row.Cells(1).Value)) & "')")
                    Next
                    Grilla_Amigos.Rows.Clear()
                    Grilla_Transaccion.Rows.Clear()
                End If
            End If
        End If
    End Sub
End Class