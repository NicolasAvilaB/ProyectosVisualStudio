Public Class Buscar_Nota_Cotizacion
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
    Private Sub Buscar_Nota_Cotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Height = 267
        verifica_botones_desabilitados()
    End Sub
    Sub verifica_botones_desabilitados()
        If (buscar.Enabled = True) Then
            buscar.BackColor = Color.FromArgb(27, 94, 32)
        ElseIf (buscar.Enabled = False)
            buscar.BackColor = Color.White
        End If
    End Sub
    Private Sub filtro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtro.SelectedIndexChanged
        If (filtro.Text = "SEÑOR/ES" Or filtro.Text = "ORDEN VENTA") Then
            Resultados_Busqueda.DataSource = Nothing
            While (Height > 267)
                Height -= 16
            End While
            busqueda.Enabled = True
            busqueda.ReadOnly = False
            buscar.Enabled = True
            verifica_botones_desabilitados()
            busqueda.Clear()
            busqueda.Focus()
            busqueda.Select()
        End If
    End Sub
    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        If (busqueda.Text = "") Then
            MsgBox("Error: No hay dato que buscar, digite e intentelo nuevamente", vbCritical, "Error, Campo Vacio")
            busqueda.Clear()
            busqueda.Focus()
            busqueda.Select()
        Else
            Comprobante_Busqueda_Datos.Show()
            If (filtro.Text = "SEÑOR/ES") Then
                Consulta3("Call Buscar_NotaVenta_Cotizacion_Nombre('" & (busqueda.Text & "%") & "','" & (valor_ventana) & "')")
                If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
                    Resultados_Busqueda.DataSource = DS3.Tables(DT3.TableName)
                    Comprobante_Busqueda_Datos.Hide()
                    While (Height < 404)
                        Height += 16
                    End While
                    busqueda.Focus()
                    busqueda.Select()
                    verifica_botones_desabilitados()
                Else
                    Resultados_Busqueda.DataSource = Nothing
                    While (Height > 267)
                        Height -= 16
                    End While
                    Comprobante_Busqueda_Datos.Hide()
                    MsgBox("Advertencia: No se han encontrado datos", vbExclamation, "Datos no Encontrados")
                    busqueda.Clear()
                    busqueda.Focus()
                    busqueda.Select()
                    verifica_botones_desabilitados()
                End If
            ElseIf (filtro.Text = "ORDEN VENTA")
                Comprobante_Busqueda_Datos.Show()
                Consulta3("Call Buscar_NotaVenta_Cotizacion_Ordev_Venta('" & (busqueda.Text) & "','" & (valor_ventana) & "')")
                If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
                    Resultados_Busqueda.DataSource = DS3.Tables(DT3.TableName)
                    Comprobante_Busqueda_Datos.Hide()
                    While (Height < 404)
                        Height += 16
                    End While
                    busqueda.Focus()
                    busqueda.Select()
                    verifica_botones_desabilitados()
                Else
                    Resultados_Busqueda.DataSource = Nothing
                    While (Height > 267)
                        Height -= 16
                    End While
                    Comprobante_Busqueda_Datos.Hide()
                    MsgBox("Advertencia: No se han encontrado datos", vbExclamation, "Datos no Encontrados")
                    busqueda.Clear()
                    busqueda.Focus()
                    busqueda.Select()
                    verifica_botones_desabilitados()
                End If
            End If
        End If
    End Sub
    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        procedimiento_cerrar()
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        procedimiento_cerrar()
    End Sub
    Sub procedimiento_cerrar()
        Resultados_Busqueda.DataSource = Nothing
        buscar.Enabled = False
        busqueda.Enabled = False
        busqueda.ReadOnly = False
        verifica_botones_desabilitados()
        filtro.SelectedIndex = -1
        busqueda.Clear()
        valordgv = 0
        Close()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub buscar_MouseMove(sender As Object, e As MouseEventArgs) Handles buscar.MouseMove
        buscar.BackColor = Color.White
        buscar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub buscar_MouseLeave(sender As Object, e As EventArgs) Handles buscar.MouseLeave
        buscar.BackColor = Color.FromArgb(27, 94, 32)
        buscar.ForeColor = Color.White
    End Sub
    Private Sub volver_MouseMove(sender As Object, e As MouseEventArgs) Handles volver.MouseMove
        volver.BackColor = Color.White
        volver.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub volver_MouseLeave(sender As Object, e As EventArgs) Handles volver.MouseLeave
        volver.BackColor = Color.FromArgb(27, 94, 32)
        volver.ForeColor = Color.White
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.White
        cerrar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(27, 94, 32)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.White
        minimizar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(27, 94, 32)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub busqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda.KeyPress
        If (filtro.Text = "SEÑOR/ES") Then
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
        ElseIf (filtro.Text = "ORDEN VENTA")
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
        End If
    End Sub
    Private Sub busqueda_TextChanged(sender As Object, e As EventArgs) Handles busqueda.TextChanged
        If (filtro.Text = "SEÑOR/ES") Then
            Dim i As Integer
            busqueda.Text = StrConv(busqueda.Text, VbStrConv.ProperCase)
            i = Len(busqueda.Text)
            busqueda.SelectionStart = i
        Else
        End If
    End Sub
    Private Sub Resultados_Busqueda_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Resultados_Busqueda.CellDoubleClick
        If (valor_ventana = 1) Then
            Comprobante_Traspaso_Datos.Show()
            NotaVenta.limpieza()
            NotaVenta.fecha.Value = Resultados_Busqueda.CurrentRow.Cells(0).EditedFormattedValue.ToString()
            NotaVenta.orden_venta.Text = Resultados_Busqueda.CurrentRow.Cells(1).EditedFormattedValue.ToString()
            NotaVenta.rut.Text = Resultados_Busqueda.CurrentRow.Cells(2).EditedFormattedValue.ToString()
            NotaVenta.señor_es.Text = Resultados_Busqueda.CurrentRow.Cells(3).EditedFormattedValue.ToString()
            NotaVenta.direccion.Text = Resultados_Busqueda.CurrentRow.Cells(4).EditedFormattedValue.ToString()
            NotaVenta.fono.Text = Resultados_Busqueda.CurrentRow.Cells(5).EditedFormattedValue.ToString()
            NotaVenta.email.Text = Resultados_Busqueda.CurrentRow.Cells(6).EditedFormattedValue.ToString()
            NotaVenta.ciudad.Text = Resultados_Busqueda.CurrentRow.Cells(7).EditedFormattedValue.ToString()
            NotaVenta.comuna.Text = Resultados_Busqueda.CurrentRow.Cells(8).EditedFormattedValue.ToString()
            NotaVenta.cond_venta.Text = Resultados_Busqueda.CurrentRow.Cells(9).EditedFormattedValue.ToString()
            valordgv = 1
            Consulta4("Call Buscar_Nota_Ventas('" & (Resultados_Busqueda.CurrentRow.Cells(1).EditedFormattedValue.ToString()) & "','" & (valor_ventana) & "')")
            For Each row As DataRow In DT4.Rows
                NotaVenta.Tabla_Nota.Rows.Add("1", row("Ubicacion"), row("Ancho"), row("Alto"), row("Lama"), row("Color"), row("Accionamiento"))
                NotaVenta.Tabla_Nota.CurrentCell = NotaVenta.Tabla_Nota.Rows(NotaVenta.Tabla_Nota.RowCount - 1).Cells(0)
                NotaVenta.Tabla_Nota.Refresh()
            Next
            Consulta4("Call Buscar_Detalle_Nota_Cotizaciones('" & (Resultados_Busqueda.CurrentRow.Cells(1).EditedFormattedValue.ToString()) & "','" & (valor_ventana) & "')")
            Dim row2 As DataRow = DT4.Rows(0)
            Dim tras, ot, de, fon, dif, ttt As Integer
            tras = Val(row2("Traslado"))
            ot = Val(row2("Otros"))
            de = Val(row2("Descuento"))
            fon = Val(row2("Fondos"))
            dif = Val(row2("Diferencia"))
            ttt = Val(row2("Cuenta_Total"))
            NotaVenta.traslado.Text = tras
            NotaVenta.otros.Text = ot
            NotaVenta.desc.Text = de
            NotaVenta.fondos.Text = fon
            NotaVenta.diferencia.Text = dif
            NotaVenta.cuenta_total.Text = ttt
            NotaVenta.buscar.Text = "CANCELAR"
            NotaVenta.guardar.Text = "IMPRIMIR"
            NotaVenta.eliminar_fila.Enabled = False
            NotaVenta.verifica_botones_desabilitados()
            valor_cancelar_busqueda = 1
            Comprobante_Traspaso_Datos.Close()
            procedimiento_cerrar()
        ElseIf (valor_ventana = 2) Then
            Comprobante_Traspaso_Datos.Show()
            Cotizaciones.limpieza()
            Cotizaciones.fecha.Value = Resultados_Busqueda.CurrentRow.Cells(0).EditedFormattedValue.ToString()
            Cotizaciones.orden_venta.Text = Resultados_Busqueda.CurrentRow.Cells(1).EditedFormattedValue.ToString()
            Cotizaciones.rut.Text = Resultados_Busqueda.CurrentRow.Cells(2).EditedFormattedValue.ToString()
            Cotizaciones.señor_es.Text = Resultados_Busqueda.CurrentRow.Cells(3).EditedFormattedValue.ToString()
            Cotizaciones.direccion.Text = Resultados_Busqueda.CurrentRow.Cells(4).EditedFormattedValue.ToString()
            Cotizaciones.fono.Text = Resultados_Busqueda.CurrentRow.Cells(5).EditedFormattedValue.ToString()
            Cotizaciones.email.Text = Resultados_Busqueda.CurrentRow.Cells(6).EditedFormattedValue.ToString()
            Cotizaciones.ciudad.Text = Resultados_Busqueda.CurrentRow.Cells(7).EditedFormattedValue.ToString()
            Cotizaciones.comuna.Text = Resultados_Busqueda.CurrentRow.Cells(8).EditedFormattedValue.ToString()
            Cotizaciones.cond_venta.Text = Resultados_Busqueda.CurrentRow.Cells(9).EditedFormattedValue.ToString()
            valordgv = 2
            Consulta4("Call Buscar_Nota_Ventas('" & (Resultados_Busqueda.CurrentRow.Cells(1).EditedFormattedValue.ToString()) & "','" & (valor_ventana) & "')")
            For Each row As DataRow In DT4.Rows
                Cotizaciones.Tabla_Nota.Rows.Add("1", row("Ancho"), row("Alto"), row("Lama"), row("Color"), row("Accionamiento"))
                Cotizaciones.Tabla_Nota.CurrentCell = Cotizaciones.Tabla_Nota.Rows(Cotizaciones.Tabla_Nota.RowCount - 1).Cells(0)
                Cotizaciones.Tabla_Nota.Refresh()
            Next
            Consulta4("Call Buscar_Detalle_Nota_Cotizaciones('" & (Resultados_Busqueda.CurrentRow.Cells(1).EditedFormattedValue.ToString()) & "','" & (valor_ventana) & "')")
            Dim row2 As DataRow = DT4.Rows(0)
            Dim tras, ot, de, fon, dif, ttt As Integer
            tras = Val(row2("Traslado"))
            ot = Val(row2("Otros"))
            de = Val(row2("Descuento"))
            fon = Val(row2("Fondos"))
            dif = Val(row2("Diferencia"))
            ttt = Val(row2("Cuenta_Total"))
            Cotizaciones.traslado.Text = tras
            Cotizaciones.otros.Text = ot
            Cotizaciones.desc.Text = de
            Cotizaciones.fondos.Text = fon
            Cotizaciones.diferencia.Text = dif
            Cotizaciones.cuenta_total.Text = ttt
            Cotizaciones.buscar.Text = "CANCELAR"
            Cotizaciones.guardar.Text = "GUARDAR MODIFICACION"
            Cotizaciones.eliminar_fila.Enabled = False
            Cotizaciones.verifica_botones_desabilitados()
            valor_cancelar_busqueda = 1
            Comprobante_Traspaso_Datos.Close()
            procedimiento_cerrar()
        End If
    End Sub
End Class