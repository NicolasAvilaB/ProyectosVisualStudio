Public Class Grilla_Ventas
    Private x, y As Integer
    Private mover As Boolean
    Dim allowResize As Boolean
    Dim valormaximizado As Boolean = True
    Dim Dato1, Dato2, Dato3, Dato4, Dato5, Dato6, Dato7, Dato8, Dato9, Dato10, Dato11, Dato12, Dato13, Dato14, Dato15, Dato16, Dato17, Dato18, Dato19 As String
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        filtro_buscar.SelectedIndex = -1
        vend.SelectedIndex = -1
        buscar.Enabled = False
        buscar.ReadOnly = True
        buscar.Clear()
        boton_buscar.Enabled = False
        filtro_fecha.Enabled = False
        vend.Enabled = False
        totventas.Text = "0"
        totmanual.Text = "0"
        totmotor.Text = "0"
        totmanual2.Text = "0"
        totmotor2.Text = "0"
        tottraslado.Text = "0"
        totinst.Text = "0"
        totganancia.Text = "0"
        totcostos.Text = "0"
        totrepman.Text = "0"
        valor_obtenido.Text = "0"
        Comprobador_Busqueda.Close()
        Me.Close()
    End Sub
    Sub Mostrar()
        If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
            Dato1 = Tabla_Ventas.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato2 = Tabla_Ventas.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato3 = Tabla_Ventas.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato4 = Tabla_Ventas.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Dato5 = Tabla_Ventas.CurrentRow.Cells(4).EditedFormattedValue.ToString
            Dato6 = Tabla_Ventas.CurrentRow.Cells(5).EditedFormattedValue.ToString
            Dato7 = Tabla_Ventas.CurrentRow.Cells(6).EditedFormattedValue.ToString
            Dato9 = Tabla_Ventas.CurrentRow.Cells(7).EditedFormattedValue.ToString
            Dato10 = Tabla_Ventas.CurrentRow.Cells(8).EditedFormattedValue.ToString
            Dato11 = Tabla_Ventas.CurrentRow.Cells(9).EditedFormattedValue.ToString
            Dato12 = Tabla_Ventas.CurrentRow.Cells(11).EditedFormattedValue.ToString
            Dato13 = Tabla_Ventas.CurrentRow.Cells(12).EditedFormattedValue.ToString
            Dato14 = Tabla_Ventas.CurrentRow.Cells(13).EditedFormattedValue.ToString
            Dato15 = Tabla_Ventas.CurrentRow.Cells(14).EditedFormattedValue.ToString
            Dato16 = Tabla_Ventas.CurrentRow.Cells(15).EditedFormattedValue.ToString
            Dato17 = Tabla_Ventas.CurrentRow.Cells(16).EditedFormattedValue.ToString
            Dato18 = Tabla_Ventas.CurrentRow.Cells(17).EditedFormattedValue.ToString
            Dato19 = Tabla_Ventas.CurrentRow.Cells(20).EditedFormattedValue.ToString
            Ventas.id.Text = Dato1
            Ventas.fecha.Value = Dato2
            Ventas.cliente.Text = Dato3
            Ventas.orden_venta.Text = Dato4
            Ventas.venta_total.Text = Dato5
            Ventas.motor.Text = Dato6
            Ventas.manual.Text = Dato7
            Ventas.motor2.Text = Dato9
            Ventas.manual2.Text = Dato10
            Ventas.traslado.Text = Dato11
            Ventas.n_factura.Text = Dato12
            Ventas.n_factura2.Text = Dato13
            Ventas.n_factura3.Text = Dato14
            Ventas.valor_fact1.Text = Dato15
            Ventas.valor_fact2.Text = Dato16
            Ventas.valor_fact3.Text = Dato17
            Ventas.man_rep.Text = Dato18
            Ventas.consulta_lista_desplegable()
            Ventas.vende_a.Text = Dato19
            vend_selec.Text = Dato19
        Else
            Ventas.id.Text = 0
            Ventas.fecha.Value = Format(Now, "dd-MM-yyyy")
            Ventas.cliente.Clear()
            Ventas.orden_venta.Text = 0
            Ventas.venta_total.Text = 0
            Ventas.motor.Text = 0
            Ventas.manual.Text = 0
            Ventas.motor2.Text = 0
            Ventas.manual2.Text = 0
            Ventas.traslado.Text = 0
            Ventas.n_factura.Text = 0
            Ventas.n_factura2.Text = 0
            Ventas.n_factura3.Text = 0
            Ventas.valor_fact1.Text = 0
            Ventas.valor_fact2.Text = 0
            Ventas.valor_fact3.Text = 0
            Ventas.man_rep.Text = 0
            Ventas.vende_a.Text = 0
            vend_selec.Text = "- - -"
        End If
    End Sub
    Sub Mostrar_Nota_Ventas_Tabla()
        Consulta3("Call Mostrar_NotaVentas")
        Tabla_Ventas.DataSource = DS3.Tables(DT3.TableName)
        Conexion.Close()
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
    Sub verifica_boton_buscar()
        If (boton_buscar.Enabled = True) Then
            boton_buscar.BackColor = Color.FromArgb(9, 29, 54)
        ElseIf (boton_buscar.Enabled = False) Then
            boton_buscar.BackColor = Color.White
        End If
    End Sub
    Private Sub Grilla_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Nota_Ventas_Tabla()
        verifica_boton_buscar()
        Ventas.status.Visible = False
        consulta_lista_desplegable()
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(29, 49, 74)
        cerrar.ForeColor = Color.White
    End Sub
    Sub consulta_lista_desplegable()
        Try
            Consulta4("Call Relleno_lista_Vendedor_a")
            vend.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("lista_vendedores")
            DA4.Fill(dt)
            With vend
                .DataSource = dt
                .DisplayMember = "Vendedor_as"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        vend.SelectedIndex = -1
    End Sub
    Private Sub filtro_buscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtro_buscar.SelectedIndexChanged
        If (filtro_buscar.Text = "MES") Then
            buscar.Enabled = False
            buscar.ReadOnly = True
            buscar.Clear()
            totventas.Text = "0"
            totmanual.Text = "0"
            totmotor.Text = "0"
            totmanual2.Text = "0"
            totmotor2.Text = "0"
            tottraslado.Text = "0"
            totinst.Text = "0"
            totrepman.Text = "0"
            totcostos.Text = "0"
            totganancia.Text = "0"
            valor_obtenido.Text = "0"
            boton_buscar.Enabled = True
            filtro_fecha.Enabled = True
            vend.SelectedIndex = -1
            vend.Enabled = True
        ElseIf (filtro_buscar.Text = "AÑO") Then
            buscar.Enabled = False
            buscar.ReadOnly = True
            buscar.Clear()
            totventas.Text = "0"
            totmanual.Text = "0"
            totmotor.Text = "0"
            totmanual2.Text = "0"
            totmotor2.Text = "0"
            tottraslado.Text = "0"
            totinst.Text = "0"
            totrepman.Text = "0"
            totcostos.Text = "0"
            totganancia.Text = "0"
            valor_obtenido.Text = "0"
            boton_buscar.Enabled = True
            filtro_fecha.Enabled = True
            vend.SelectedIndex = -1
            vend.Enabled = True
        ElseIf (filtro_buscar.Text = "CLIENTE") Then
            buscar.Enabled = True
            buscar.ReadOnly = False
            buscar.Clear()
            buscar.Focus()
            buscar.Select()
            totventas.Text = "0"
            totmanual.Text = "0"
            totmotor.Text = "0"
            totmanual2.Text = "0"
            totmotor2.Text = "0"
            tottraslado.Text = "0"
            totinst.Text = "0"
            totrepman.Text = "0"
            totcostos.Text = "0"
            totganancia.Text = "0"
            valor_obtenido.Text = "0"
            boton_buscar.Enabled = True
            filtro_fecha.Enabled = True
            vend.SelectedIndex = -1
            vend.Enabled = True
        ElseIf (filtro_buscar.Text = "ORDEN DE VENTA") Then
            buscar.Enabled = True
            buscar.ReadOnly = False
            buscar.Clear()
            buscar.Focus()
            buscar.Select()
            totventas.Text = "0"
            totmanual.Text = "0"
            totmotor.Text = "0"
            totmanual2.Text = "0"
            totmotor2.Text = "0"
            tottraslado.Text = "0"
            totinst.Text = "0"
            totrepman.Text = "0"
            totcostos.Text = "0"
            totganancia.Text = "0"
            valor_obtenido.Text = "0"
            boton_buscar.Enabled = True
            filtro_fecha.Enabled = True
            vend.SelectedIndex = -1
            vend.Enabled = False
        ElseIf (filtro_buscar.Text = "VENDEDOR/A") Then
            buscar.Clear()
            buscar.Focus()
            buscar.Select()
            totventas.Text = "0"
            totmanual.Text = "0"
            totmotor.Text = "0"
            totmanual2.Text = "0"
            totmotor2.Text = "0"
            tottraslado.Text = "0"
            totinst.Text = "0"
            totrepman.Text = "0"
            totcostos.Text = "0"
            totganancia.Text = "0"
            valor_obtenido.Text = "0"
            boton_buscar.Enabled = True
            filtro_fecha.Enabled = True
            vend.SelectedIndex = -1
            vend.Enabled = True
        ElseIf (filtro_buscar.Text = "CANCELAR FILTRO") Then
            boton_buscar.Enabled = False
            verifica_boton_buscar()
            filtro_fecha.Enabled = False
            totventas.Text = "0"
            totmanual.Text = "0"
            totmotor.Text = "0"
            totmanual2.Text = "0"
            totmotor2.Text = "0"
            tottraslado.Text = "0"
            totinst.Text = "0"
            totrepman.Text = "0"
            totcostos.Text = "0"
            totganancia.Text = "0"
            valor_obtenido.Text = "0"
            buscar.Enabled = False
            buscar.ReadOnly = True
            buscar.Clear()
            Comprobador_Grilla_Datos.Show()
            Mostrar_Nota_Ventas_Tabla()
            Comprobador_Grilla_Datos.Close()
            vend.SelectedIndex = -1
            vend.Enabled = False
            filtro_buscar.SelectedIndex = -1
        End If
        verifica_boton_buscar()
    End Sub
    Private Sub boton_buscar_Click(sender As Object, e As EventArgs) Handles boton_buscar.Click
        'Dim mifecha1 As Date = filtro_fecha.Value
        'Dim mifecha2 As String = mifecha1.ToString("yyyy-MM-dd")
        Dim Año As Integer = filtro_fecha.Value.Year
        Dim Mes As Integer = filtro_fecha.Value.Month
        If (filtro_buscar.Text = "CLIENTE") Then
            If (vend.Text = "") Then
                Comprobador_Busqueda.Show()
                Consulta3("Call Buscar_por_Cliente('" & (buscar.Text & "%") & "')")
                If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
                    Comprobador_Busqueda.Hide()
                Else
                    Comprobador_Busqueda.Hide()
                    MsgBox("Advertencia: No existen datos con la busqueda realizada", vbExclamation, "Advertencia, sin datos")
                End If
            Else
                Comprobador_Busqueda.Show()
                Consulta3("Call Buscar_por_Cliente_Vendedor_a('" & (buscar.Text & "%") & "','" & (vend.Text & "%") & "')")
                If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
                    Comprobador_Busqueda.Hide()
                Else
                    Comprobador_Busqueda.Hide()
                    MsgBox("Advertencia: No existen datos con la busqueda realizada", vbExclamation, "Advertencia, sin datos")
                End If
            End If
        ElseIf (filtro_buscar.Text = "VENDEDOR/A") Then
            If (vend.Text = "") Then
                Comprobador_Grilla_Datos.Show()
                Mostrar_Nota_Ventas_Tabla()
                Comprobador_Grilla_Datos.Close()
            Else
                Comprobador_Busqueda.Show()
                Consulta3("Call Buscar_por_Vendedor_a('" & (vend.Text) & "'," & (Año) & "," & (Mes) & ")")
                If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
                    Comprobador_Busqueda.Hide()
                Else
                    Comprobador_Busqueda.Hide()
                    MsgBox("Advertencia: No existen datos con la busqueda realizada", vbExclamation, "Advertencia, sin datos")
                End If
            End If
        ElseIf (filtro_buscar.Text = "MES") Then
            If (vend.Text = "") Then
                Comprobador_Busqueda.Show()
                Consulta3("Call Buscar_por_Mes(" & (Año) & "," & (Mes) & ")")
                If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
                    Comprobador_Busqueda.Hide()
                Else
                    Comprobador_Busqueda.Hide()
                    MsgBox("Advertencia: No existen datos con la busqueda realizada", vbExclamation, "Advertencia, sin datos")
                End If
                suma_de_valores_totales_venta()
            Else
                Comprobador_Busqueda.Show()
                Consulta3("Call Buscar_por_Vendedor_a('" & (vend.Text) & "'," & (Año) & "," & (Mes) & ")")
                If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
                    Comprobador_Busqueda.Hide()
                Else
                    Comprobador_Busqueda.Hide()
                    MsgBox("Advertencia: No existen datos con la busqueda realizada", vbExclamation, "Advertencia, sin datos")
                End If
                suma_de_valores_totales_venta()
                suma_de_valores_totales_venta_2()
            End If
        ElseIf (filtro_buscar.Text = "AÑO") Then
            If (vend.Text = "") Then
                Comprobador_Busqueda.Show()
                Consulta3("Call Buscar_por_Año(" & (Año) & ")")
                If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
                    Comprobador_Busqueda.Hide()
                Else
                    Comprobador_Busqueda.Hide()
                    MsgBox("Advertencia: No existen datos con la busqueda realizada", vbExclamation, "Advertencia, sin datos")
                End If
                suma_de_valores_totales_venta()
            Else
                Comprobador_Busqueda.Show()
                Consulta3("Call Buscar_por_Vendedor_a_anual('" & (vend.Text) & "'," & (Año) & ")")
                If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
                    Comprobador_Busqueda.Hide()
                Else
                    Comprobador_Busqueda.Hide()
                    MsgBox("Advertencia: No existen datos con la busqueda realizada", vbExclamation, "Advertencia, sin datos")
                End If
                suma_de_valores_totales_venta()
                suma_de_valores_totales_venta_2()
            End If
        ElseIf (filtro_buscar.Text = "ORDEN DE VENTA") Then
            If (buscar.Text = "") Then
                Comprobador_Grilla_Datos.Show()
                Mostrar_Nota_Ventas_Tabla()
                Comprobador_Grilla_Datos.Close()
            Else
                Comprobador_Busqueda.Show()
                Consulta3("Call Buscar_por_ordenventa('" & (buscar.Text) & "'," & (Año) & "," & (Mes) & ")")
                If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
                    Comprobador_Busqueda.Hide()
                Else
                    Comprobador_Busqueda.Hide()
                    MsgBox("Advertencia: No existen datos con la busqueda realizada", vbExclamation, "Advertencia, sin datos")
                End If
            End If
        End If
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.FromArgb(237, 237, 237)
        cerrar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged
        If (filtro_buscar.Text = "CLIENTE") Then
            Dim i As Integer
            buscar.Text = StrConv(buscar.Text, VbStrConv.ProperCase)
            i = Len(buscar.Text)
            buscar.SelectionStart = i
        End If
        'If (buscar.Text = "") Then
        'buscar.Clear()
        'Comprobador_Grilla_Datos.Show()
        'Mostrar_Nota_Ventas_Tabla()
        'Comprobador_Grilla_Datos.Close()
        'End If
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.FromArgb(237, 237, 237)
        minimizar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Sub suma_de_valores_totales_venta()
        Dim sumaventas As Long = 0.0
        Dim sumatraslado As Long = 0.0
        Dim sumamanual As Long = 0.0
        Dim sumamotor As Long = 0.0
        Dim sumamanual2 As Long = 0.0
        Dim sumamotor2 As Long = 0.0
        Dim sumarepmanints As Long = 0.0
        Dim sumarepman As Long = 0.0
        Dim sumacostos As Long = 0.0
        Dim sumaganancia As Long = 0.0
        If (Tabla_Ventas.Rows.Count = 0) Then
            totventas.Text = "0"
            tottraslado.Text = "0"
            totganancia.Text = "0"
            totcostos.Text = "0"
            totmanual.Text = "0"
            totmotor.Text = "0"
            totmanual2.Text = "0"
            totmotor2.Text = "0"
            totinst.Text = "0"
            totrepman.Text = "0"
        Else
            If (filtro_buscar.Text = "") Then
            Else
                For Each row As DataGridViewRow In Tabla_Ventas.Rows
                    sumaventas += Val(row.Cells(4).Value)
                    sumatraslado += Val(row.Cells(9).Value)
                    sumamanual += Val(row.Cells(6).Value)
                    sumamotor += Val(row.Cells(5).Value)
                    sumamanual2 += Val(row.Cells(8).Value)
                    sumamotor2 += Val(row.Cells(7).Value)
                    sumarepmanints += Val(row.Cells(10).Value)
                    sumarepman += Val(row.Cells(17).Value)
                    sumacostos += Val(row.Cells(18).Value)
                    sumaganancia += Val(row.Cells(19).Value)
                Next
                totventas.Text = sumaventas
                tottraslado.Text = sumatraslado
                totmanual.Text = sumamanual
                totmotor.Text = sumamotor
                totmanual2.Text = sumamanual2
                totmotor2.Text = sumamotor2
                totinst.Text = sumarepmanints
                totrepman.Text = sumarepman
                totcostos.Text = sumacostos
                totganancia.Text = sumaganancia
            End If
        End If
    End Sub
    Sub suma_de_valores_totales_venta_2()
        Dim sumaventas As Long = 0.0
        Dim a As String
        Dim mult As Long
        If (Tabla_Ventas.Rows.Count = 0) Then
            valor_obtenido.Text = "0"
        Else
            If (vend.Text = "") Then
                valor_obtenido.Text = "0"
            Else
                For Each row As DataGridViewRow In Tabla_Ventas.Rows
                    If (CStr(row.Cells(20).Value) = vend.Text) Then
                        sumaventas += Val(row.Cells(4).Value)
                    End If
                Next
                valor_obtenido.Text = sumaventas
                'Dim valores As Long = valor_obtenido.Text
                'If (valores <= 5000000) Then
                '    primeracomision.Text = "0"
                '    segundacomision.Text = "0"
                '    terceracomision.Text = "0"
                '    cuartacomision.Text = "0"
                '    quintacomision.Text = "0"
                '    mult = valores * 0.85 / 100
                '    primeracomision.Text = mult
                'ElseIf (valores >= 5000001 And valores <= 9000000) Then
                '    primeracomision.Text = "0"
                '    segundacomision.Text = "0"
                '    terceracomision.Text = "0"
                '    cuartacomision.Text = "0"
                '    quintacomision.Text = "0"
                '    mult = valores * 1.7 / 100
                '    segundacomision.Text = mult
                'ElseIf (valores >= 9000001 And valores <= 12000000) Then
                '    primeracomision.Text = "0"
                '    segundacomision.Text = "0"
                '    terceracomision.Text = "0"
                '    cuartacomision.Text = "0"
                '    quintacomision.Text = "0"
                '    mult = valores * 1.275 / 100
                '    terceracomision.Text = mult
                'ElseIf (valores >= 12000001 And valores <= 15000000) Then
                '    primeracomision.Text = "0"
                '    segundacomision.Text = "0"
                '    terceracomision.Text = "0"
                '    cuartacomision.Text = "0"
                '    quintacomision.Text = "0"
                '    mult = valores * 1.25 / 100
                '    cuartacomision.Text = mult
                'ElseIf (valores >= 15000001) Then
                '    primeracomision.Text = "0"
                '    segundacomision.Text = "0"
                '    terceracomision.Text = "0"
                '    cuartacomision.Text = "0"
                '    quintacomision.Text = "0"
                '    mult = valores * 2.55 / 100
                '    quintacomision.Text = mult
                'End If
            End If
        End If
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(29, 49, 74)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub Grilla_Ventas_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        allowResize = True
        Me.Cursor = Cursors.SizeNWSE
    End Sub
    Private Sub Grilla_Ventas_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If allowResize Then
            If e.X >= (Me.Right - Me.Left) - 1 And e.Y >= (Me.Bottom - Me.Top) - 1 Then
                'Cambio el Ancho y el Alto con este calculo, crece
                'Esto funciona pero si quieren que lo explique a mayor profundidad, poner mensaje
                Me.Width = Me.Right - Me.Left + 10
                Me.Height = Me.Bottom - Me.Top + 10
                Me.Refresh()
                'Si el raton se mueve hacia la derecha, crece
            ElseIf e.X >= (Me.Right - Me.Left) - 1 Then
                Me.Width = Me.Right - Me.Left + 10
                Me.Refresh()
                'Si el raton se mueve hacia abajo, crece
            ElseIf e.Y >= (Me.Bottom - Me.Top) - 1 Then
                Me.Height = Me.Bottom - Me.Top + 10
                Me.Refresh()
                'Si el raton se mueve hacia la izquierda y hacia arriba, decrece
            ElseIf e.X < (Me.Right - Me.Left) - 6 And e.Y < (Me.Bottom - Me.Top) - 6 Then
                Me.Width = Me.Right - Me.Left - 7
                Me.Height = Me.Bottom - Me.Top - 7
                Me.Refresh() 'Si el raton se mueve hacia la izquierda, decrece
            ElseIf e.X < (Me.Right - Me.Left) - 5 Then
                Me.Width = Me.Right - Me.Left - 7
                Me.Refresh() 'Si el raton se mueve hacia arriba, decrece
            ElseIf e.Y < (Me.Bottom - Me.Top) - 5 Then
                Me.Height = Me.Bottom - Me.Top - 7
                Me.Refresh()
            End If
        Else
        End If
    End Sub
    Private Sub Grilla_Ventas_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        allowResize = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Tabla_Ventas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Tabla_Ventas.ReadOnly = True
    End Sub
    Private Sub Tabla_Ventas_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs)
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Sub maximizar_minimizar()
        If (valormaximizado = True) Then
            Me.WindowState = FormWindowState.Maximized
            valormaximizado = False
        ElseIf (valormaximizado = False) Then
            Me.WindowState = FormWindowState.Normal
            valormaximizado = True
        End If
    End Sub
    Private Sub Panel2_DoubleClick(sender As Object, e As EventArgs) Handles Panel2.DoubleClick
        maximizar_minimizar()
    End Sub
    Private Sub maximizar_Click(sender As Object, e As EventArgs) Handles maximizar.Click
        maximizar_minimizar()
    End Sub
    Private Sub maximizar_MouseMove(sender As Object, e As MouseEventArgs) Handles maximizar.MouseMove
        maximizar.BackColor = Color.FromArgb(237, 237, 237)
        maximizar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Private Sub maximizar_MouseLeave(sender As Object, e As EventArgs) Handles maximizar.MouseLeave
        maximizar.BackColor = Color.FromArgb(29, 49, 74)
        maximizar.ForeColor = Color.White
    End Sub
    Private Sub boton_buscar_MouseMove(sender As Object, e As MouseEventArgs) Handles boton_buscar.MouseMove
        boton_buscar.BackColor = Color.White
        boton_buscar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub boton_buscar_MouseLeave(sender As Object, e As EventArgs) Handles boton_buscar.MouseLeave
        boton_buscar.BackColor = Color.FromArgb(9, 29, 54)
        boton_buscar.ForeColor = Color.White
    End Sub

    Private Sub totrepman_Click(sender As Object, e As EventArgs) Handles totrepman.Click

    End Sub

    Private Sub buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles buscar.KeyPress
        If (filtro_buscar.Text = "CLIENTE") Then
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
        ElseIf (filtro_buscar.Text = "ORDEN DE VENTA") Then

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
        ElseIf (filtro_buscar.Text = "VENDEDOR/A") Then

            If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
                e.KeyChar = ""
            End If
        End If
    End Sub
    Private Sub totventas_MouseMove(sender As Object, e As MouseEventArgs) Handles totventas.MouseMove
        desglose.Text = Letras(totventas.Text)
    End Sub
    Private Sub totventas_MouseLeave(sender As Object, e As EventArgs) Handles totventas.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub totrepmaninst_MouseMove(sender As Object, e As MouseEventArgs) Handles totinst.MouseMove
        desglose.Text = Letras(totinst.Text)
    End Sub
    Private Sub totrepmaninst_MouseLeave(sender As Object, e As EventArgs) Handles totinst.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub tottraslado_MouseMove(sender As Object, e As MouseEventArgs) Handles tottraslado.MouseMove
        desglose.Text = Letras(tottraslado.Text)
    End Sub
    Private Sub tottraslado_MouseLeave(sender As Object, e As EventArgs) Handles tottraslado.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub valor_obtenido_MouseMove(sender As Object, e As MouseEventArgs) Handles valor_obtenido.MouseMove
        desglose.Text = Letras(valor_obtenido.Text)
    End Sub
    Private Sub valor_obtenido_MouseLeave(sender As Object, e As EventArgs) Handles valor_obtenido.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub primeracomision_MouseMove(sender As Object, e As MouseEventArgs) Handles primeracomision.MouseMove
        desglose.Text = Letras(primeracomision.Text)
    End Sub
    Private Sub primeracomision_MouseLeave(sender As Object, e As EventArgs) Handles primeracomision.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub segundacomision_MouseMove(sender As Object, e As MouseEventArgs) Handles segundacomision.MouseMove
        desglose.Text = Letras(segundacomision.Text)
    End Sub
    Private Sub segundacomision_MouseLeave(sender As Object, e As EventArgs) Handles segundacomision.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub terceracomision_MouseMove(sender As Object, e As MouseEventArgs) Handles terceracomision.MouseMove
        desglose.Text = Letras(terceracomision.Text)
    End Sub
    Private Sub terceracomision_MouseLeave(sender As Object, e As EventArgs) Handles terceracomision.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub cuartacomision_MouseMove(sender As Object, e As MouseEventArgs) Handles cuartacomision.MouseMove
        desglose.Text = Letras(cuartacomision.Text)
    End Sub
    Private Sub cuartacomision_MouseLeave(sender As Object, e As EventArgs) Handles cuartacomision.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub quintacomision_MouseMove(sender As Object, e As MouseEventArgs) Handles quintacomision.MouseMove
        desglose.Text = Letras(quintacomision.Text)
    End Sub
    Private Sub quintacomision_MouseLeave(sender As Object, e As EventArgs) Handles quintacomision.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub totrepman_MouseMove(sender As Object, e As MouseEventArgs) Handles totrepman.MouseMove
        desglose.Text = Letras(totrepman.Text)
    End Sub
    Private Sub totrepman_MouseLeave(sender As Object, e As EventArgs) Handles totrepman.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub totganancia_MouseMove(sender As Object, e As MouseEventArgs) Handles totganancia.MouseMove
        desglose.Text = Letras(totganancia.Text)
    End Sub
    Private Sub totganancia_MouseLeave(sender As Object, e As EventArgs) Handles totganancia.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub totcostos_MouseMove(sender As Object, e As MouseEventArgs) Handles totcostos.MouseMove
        desglose.Text = Letras(totcostos.Text)
    End Sub
    Private Sub totcostos_MouseLeave(sender As Object, e As EventArgs) Handles totcostos.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub Tabla_Ventas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_Ventas.CellClick
        Mostrar()
    End Sub
End Class