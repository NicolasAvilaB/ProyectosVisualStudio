Imports Microsoft.Reporting.WinForms
Imports System.Text.RegularExpressions
Imports System.Reflection
Public Class Cotizaciones
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Dim valor_id As Long = 0
    Dim valor_id_c As Long = 0
    Dim valor_orden As Long = 0
    Dim valormaximizado As Boolean = True
    Dim mult1, mult2 As Integer
    'variable de rut
    Dim valor_rut, aux, DV As String
    Dim vrut, paso, suma, resto As Integer
    Dim divi As Double
    Dim d1, d2, d3, d4, d5, d6, d7, d8
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
    Sub verifica_valor_nada_columna_numero()
        For Each row As DataGridViewRow In Tabla_Nota.Rows
            If (row.Cells(0).Value = "") Then
                row.Cells(0).Value = "1"
            Else
            End If
        Next
    End Sub
    Sub limpieza()
        señor_es.Clear()
        rut.Clear()
        ciudad.Clear()
        direccion.Clear()
        comuna.Clear()
        email.Clear()
        cond_venta.SelectedIndex = -1
        fono.Clear()
        Tabla_Nota.Rows.Clear()
        instalacion.Text = "0"
        fondos.Text = "0"
        diferencia.Text = "0"
        traslado.Text = "0"
        otros.Text = "0"
        desc.Text = "0"
    End Sub
    Private Sub maximizar_Click(sender As Object, e As EventArgs) Handles maximizar.Click
        maximizar_minimizar()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Menus.Show()
        Close()
    End Sub
    Sub valor_orden_venta()
        Consulta("Call GeneradorOrden_Venta_automatico_Cotizaciones")
        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("Orden_Venta")) Is DBNull Then
            valor_orden = 9
            orden_venta.Text = valor_orden
        Else
            valor_orden = DS.Tables(DT.TableName).Rows(0).Item("Orden_Venta") + 9
            orden_venta.Text = valor_orden
            Conexion.Close()
        End If
    End Sub
    Sub crear_16_filas()
        For i = 0 To 15
            Tabla_Nota.Rows.Add("1", "", "", "", "", "", "")
        Next
    End Sub
    Sub rellenar_accionamiento()
        Try
            Consulta7("Call Rellena_Lista_Accionamientos")
            Dim datitos As DataTable = New DataTable("accionamientos")
            DA7.Fill(datitos)
            With accionamiento
                .DataSource = datitos
                .DisplayMember = "Accionamientos"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub NotaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        señor_es.Focus()
        señor_es.Select()
        valor_orden_venta()
        Timer1.Start()
        Timer1.Interval = 1
        verifica_botones_desabilitados()
        crear_16_filas()
        rellenar_accionamiento()
    End Sub
    Sub sacar_informe()
        Dim Año As Integer = fecha.Value.Year
        Dim Mes As Integer = fecha.Value.Month
        Dim Dia As Integer = fecha.Value.Day
        Dim fuente As New ReportDataSource
        Dim parametros As ReportParameter() = New ReportParameter(24) {}
        parametros(0) = New ReportParameter("dia", Dia)
        parametros(1) = New ReportParameter("mes", Mes)
        parametros(2) = New ReportParameter("año", Año)
        'parametros(3) = New ReportParameter("n_orden", orden_venta.Text)
        parametros(3) = New ReportParameter("cliente", señor_es.Text)
        parametros(4) = New ReportParameter("rut", rut.Text)
        parametros(5) = New ReportParameter("direccion", direccion.Text)
        parametros(6) = New ReportParameter("comuna", comuna.Text)
        parametros(7) = New ReportParameter("ciudad", ciudad.Text)
        parametros(8) = New ReportParameter("condicion_de_venta", cond_venta.Text)
        parametros(9) = New ReportParameter("telefono", fono.Text)
        parametros(10) = New ReportParameter("correo", email.Text)
        parametros(11) = New ReportParameter("subtotal", subtotal.Text)
        parametros(12) = New ReportParameter("instalar", instalacion.Text)
        parametros(13) = New ReportParameter("motor_tir", motor_tirantes.Text)
        parametros(14) = New ReportParameter("motor_mani", motor_manivela.Text)
        parametros(15) = New ReportParameter("puls_conm", puls_conmutador.Text)
        Dim suma, v1, v2, v3 As Long
            v1 = chapa_muelle.Text
            v2 = chapa_muelle_10.Text
            v3 = chapa_muelle_24.Text
            suma += v1 + v2 + v3
            parametros(16) = New ReportParameter("chap_muelle", suma)
        parametros(17) = New ReportParameter("cn_rem", central_control.Text)
        parametros(18) = New ReportParameter("traslado", traslado.Text)
        parametros(19) = New ReportParameter("otro", otros.Text)
        parametros(20) = New ReportParameter("net", neto.Text)
        parametros(21) = New ReportParameter("iv", iva.Text)
        If (cuenta_total.Text = "0") Then
            parametros(22) = New ReportParameter("tot", total.Text)
        Else
            parametros(22) = New ReportParameter("tot", cuenta_total.Text)
        End If
        parametros(23) = New ReportParameter("mo_remo", motor_remoto.Text)
        parametros(24) = New ReportParameter("mo_a_bl_cr", motor_autobl_crto.Text)
        Try
            Dim ds As New DsCotizaciones
            Dim dtw As DataRow
            For i As Integer = 0 To Tabla_Nota.Rows.Count - 1
                dtw = ds.Tabla_Ventas.NewRow()
                dtw("Numero") = Tabla_Nota.Item(0, i).Value
                dtw("Ancho") = Tabla_Nota.Item(1, i).Value ' formato de punto para datatable
                dtw("Alto") = Tabla_Nota.Item(2, i).Value
                dtw("Lama") = Tabla_Nota.Item(3, i).Value
                dtw("Color") = Tabla_Nota.Item(4, i).Value
                dtw("Accionamiento") = Tabla_Nota.Item(5, i).Value ' formato de punto para datatable
                dtw("ValorUnitario") = Tabla_Nota.Item(6, i).Value
                ds.Tabla_Ventas.Rows.Add(dtw)
            Next
            ''---------------------PREPARAR REPORTE--------------------
            fuente.Name = "DatosCotizaciones" ' Nombre identico al que le di al dataset del report en tiempo de diseño
            fuente.Value = ds.Tables(0)
            ''---------------------PREPARAR REPORTE------------------
        Catch ex As Exception
        End Try
        Sacar_Reporte_Cotizaciones.reporte.LocalReport.DataSources.Clear()
        Sacar_Reporte_Cotizaciones.reporte.LocalReport.DataSources.Add(fuente)
        Sacar_Reporte_Cotizaciones.reporte.LocalReport.SetParameters(parametros)
        'Sacar_Reporte_Nota_Venta.reporte.LocalReport.ReportEmbeddedResource = "Modulo 2 - Nota Venta PYM.Report1.rdlc" 'exactamente como se llaman el proyecto y reporte
        Comprobante_Creacion_Informe.Hide()
        procedimiento_luego_de_modificar()
        Sacar_Reporte_Cotizaciones.Owner = Me
        Sacar_Reporte_Cotizaciones.ShowDialog()
    End Sub
    Public Function validar_mail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Sub valorid()
        Consulta("Call GeneradorIDautomatico_Cotizacion")
        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("ID")) Is DBNull Then
            valor_id = 1
        Else
            valor_id = DS.Tables(DT.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
    End Sub
    Sub valorid_detallecotizacion()
        Consulta("Call GeneradorIDautomatico_Detalle_Cotizacion")
        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("ID")) Is DBNull Then
            valor_id_c = 1
        Else
            valor_id_c = DS.Tables(DT.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        If (señor_es.Text = "") Then
            MsgBox("Error: No se ha especificado el cliente", vbCritical, "Error, Cliente no Especificado")
            señor_es.Focus()
            señor_es.Select()
        ElseIf (direccion.Text = "") Then
            MsgBox("Error: La direccion no a sido dictada", vbCritical, "Error, Direccion no Especificada")
            direccion.Focus()
            direccion.Select()
        ElseIf Len(rut.Text) < 12 Then
            MsgBox("Error: La estructura del rut no es valida", vbCritical, "Error, Estructura Invalida")
            rut.Focus()
            rut.Select()
        ElseIf (comuna.Text = "") Then
            MsgBox("Error: No se ha especificado la comuna", vbCritical, "Error, Comuna no dictada")
            comuna.Focus()
            comuna.Select()
        ElseIf (ciudad.Text = "") Then
            MsgBox("Error: La ciudad no esta especificada", vbCritical, "Error, Ciudad no dictada")
            ciudad.Focus()
            ciudad.Select()
        ElseIf (cond_venta.Text = "") Then
            MsgBox("Error: No existe una condicion de venta", vbCritical, "Error, Cond. de Venta no Especificada")
            cond_venta.Select()
        ElseIf (fono.Text = "") Then
            MsgBox("Error: Telefono no Dictado", vbCritical, "Error, Telefono Vacio")
            fono.Focus()
            fono.Select()
        ElseIf (email.Text = "") Then
            MsgBox("Error: No existe una direccion de email", vbCritical, "Error, Direccion de Correo Vacio")
            email.Focus()
            email.Select()
        ElseIf (validar_mail(LCase(email.Text)) = False) Then
            MsgBox("Advertencia: El formato del email es incorrecto", vbCritical, "Advertencia, Email no correcto")
            email.Clear()
            email.Focus()
            email.Select()
        Else
            If (rut.Text = "00.000.000-0") Then
                MsgBox("Error: El rut es incorrecto, verifiquelo e intentelo denuevo", vbCritical, "Error, Rut Incorrecto")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf (rut.Text = "11.111.111-1") Then
                MsgBox("Error: El rut es incorrecto, verifiquelo e intentelo denuevo", vbCritical, "Error, Rut Incorrecto")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf (rut.Text = "22.222.222-2") Then
                MsgBox("Error: El rut es incorrecto, verifiquelo e intentelo denuevo", vbCritical, "Error, Rut Incorrecto")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf (rut.Text = "33.333.333-3") Then
                MsgBox("Error: El rut es incorrecto, verifiquelo e intentelo denuevo", vbCritical, "Error, Rut Incorrecto")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf (rut.Text = "44.444.444-4") Then
                MsgBox("Error: El rut es incorrecto, verifiquelo e intentelo denuevo", vbCritical, "Error, Rut Incorrecto")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf (rut.Text = "55.555.555-5") Then
                MsgBox("Error: El rut es incorrecto, verifiquelo e intentelo denuevo", vbCritical, "Error, Rut Incorrecto")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf (rut.Text = "66.666.666-6") Then
                MsgBox("Error: El rut es incorrecto, verifiquelo e intentelo denuevo", vbCritical, "Error, Rut Incorrecto")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf (rut.Text = "77.777.777-7") Then
                MsgBox("Error: El rut es incorrecto, verifiquelo e intentelo denuevo", vbCritical, "Error, Rut Incorrecto")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf (rut.Text = "88.888.888-8") Then
                MsgBox("Error: El rut es incorrecto, verifiquelo e intentelo denuevo", vbCritical, "Error, Rut Incorrecto")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf (rut.Text = "99.999.999-9") Then
                MsgBox("Error: El rut es incorrecto, verifiquelo e intentelo denuevo", vbCritical, "Error, Rut Incorrecto")
                rut.Clear()
                rut.Focus()
                rut.Select()
            Else
                valor_rut = rut.Text
                d1 = Val(Mid(valor_rut, 1, 1)) * 3
                d2 = Val(Mid(valor_rut, 2, 1)) * 2
                d3 = Val(Mid(valor_rut, 4, 1)) * 7
                d4 = Val(Mid(valor_rut, 5, 1)) * 6
                d5 = Val(Mid(valor_rut, 6, 1)) * 5
                d6 = Val(Mid(valor_rut, 8, 1)) * 4
                d7 = Val(Mid(valor_rut, 9, 1)) * 3
                d8 = Val(Mid(valor_rut, 10, 1)) * 2
                DV = Mid(valor_rut, 12, 1)
                suma = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8
                divi = Int(suma / 11)
                resto = suma - (divi * 11)
                aux = LTrim(Str(11 - resto))
                If (aux = 11) Then
                    aux = "0"
                End If
                If (aux = 10) Then
                    aux = "K"
                End If
                If (DV = aux) Or (DV = "k") Then
                    If (guardar.Text = "GUARDAR E IMPRIMIR") Or (guardar.Text = "GUARDAR E IMPRIMIR" And valor_cancelar_busqueda = 0) Then
                        Try
                            Panel3.Visible = True
                            valorid()
                            valorid_detallecotizacion()
                            Dim mifecha1 As Date = fecha.Value
                            Dim mifecha2 As String = mifecha1.ToString("yyyy-MM-dd")
                            Consulta("Call Insertar_Clientes_Cotizados(" & (valor_id) & ",'" & (mifecha2) & "'," & (orden_venta.Text) & ",'" & (rut.Text) & "','" & (señor_es.Text) & "','" & (direccion.Text) & "','" & (fono.Text) & "','" & (email.Text) & "','" & (ciudad.Text) & "','" & (comuna.Text) & "','" & (cond_venta.Text) & "')")
                            Consulta("Call Insertar_Detalle_Cotizaciones(" & (valor_id_c) & "," & (orden_venta.Text) & "," & (subtotal.Text) & "," & (instalacion.Text) & "," & (motor_tirantes.Text) & "," & (motor_manivela.Text) & "," & (motor.Text) & "," & (puls_conmutador.Text) & "," & (chapa_muelle.Text) & "," & (chapa_muelle_10.Text) & "," & (chapa_muelle_24.Text) & "," & (central_control.Text) & "," & (traslado.Text) & "," & (otros.Text) & "," & (neto.Text) & "," & (iva.Text) & "," & (total.Text) & "," & (desc.Text) & "," & (cuenta_total.Text) & "," & (fondos.Text) & "," & (diferencia.Text) & "," & (motor_remoto.Text) & "," & (motor_autobl_crto.Text) & ")")
                            Dim valor1, valor2, valor3, valor4, valor5 As String
                            Dim valor0, valor6 As Integer
                            For Each row As DataGridViewRow In Tabla_Nota.Rows
                                valor0 = Val(row.Cells(0).Value)
                                valor1 = CStr(row.Cells(1).Value)
                                valor2 = CStr(row.Cells(2).Value)
                                valor3 = CStr(row.Cells(3).Value)
                                valor4 = CStr(row.Cells(4).Value)
                                valor5 = CStr(row.Cells(5).Value)
                                valor6 = Val(row.Cells(6).Value)
                                If (valor0 = Nothing) Then
                                    valor0 = 0
                                Else
                                End If
                                If (valor1 = "") Then
                                    valor1 = "---"
                                Else
                                End If
                                If (valor2 = "") Then
                                    valor2 = "---"
                                Else
                                End If
                                If (valor3 = "") Then
                                    valor3 = "---"
                                Else
                                End If
                                If (valor4 = "") Then
                                    valor4 = "---"
                                Else
                                End If
                                If (valor5 = "") Then
                                    valor5 = "---"
                                Else
                                End If
                                If (valor6 = Nothing) Then
                                    valor6 = 0
                                Else
                                End If
                                Consulta("Call Insertar_Grilla_Cotizaciones(" & (orden_venta.Text) & "," & (valor0) & ",'" & (valor1) & "','" & (valor2) & "','" & (valor3) & "','" & (valor4) & "','" & (valor5) & "'," & (valor6) & ")")
                            Next
                            Panel3.Visible = False
                            MsgBox("Datos ingresados correctamente", vbInformation, "Datos correctamente ingresados")
                            señor_es.Focus()
                            señor_es.Select()
                            Dim valormensaje As Integer
                            valormensaje = MsgBox("¿Deseas traspasar los datos a una nueva nota de venta?", vbYesNo + vbQuestion, "Confirma la Operacion")
                            If valormensaje = vbYes Then
                                Comprobante_Creacion_Informe.Show()
                                traspaso_nota_venta()
                                sacar_informe()
                            Else
                                Comprobante_Creacion_Informe.Show()
                                sacar_informe()
                            End If
                        Catch ex As Exception
                            Dim ass As String
                            ass = Convert.ToString(ex)
                            MsgBox("" + ass, vbCritical, "Advertencia, Posible Error")
                        End Try
                    ElseIf (guardar.Text = "GUARDAR MODIFICACION" And valor_cancelar_busqueda = 1)
                        Try
                            Panel3.Visible = True
                            Dim mifecha77 As Date = fecha.Value
                            Dim mifecha88 As String = mifecha77.ToString("yyyy-MM-dd")
                            valor_ventana = 2
                            Consulta5("Call Modificar_Clientes_Nota_Cotizaciones (" & (valor_ventana) & ",'" & (mifecha88) & "','" & (rut.Text) & "','" & (señor_es.Text) & "','" & (direccion.Text) & "','" & (fono.Text) & "','" & (email.Text) & "','" & (ciudad.Text) & "','" & (comuna.Text) & "','" & (cond_venta.Text) & "'," & (orden_venta.Text) & ")")
                            Consulta5("Call Modificar_Detalle_Nota_Cotizaciones (" & (valor_ventana) & "," & (subtotal.Text) & "," & (instalacion.Text) & "," & (motor_tirantes.Text) & "," & (motor_manivela.Text) & "," & (motor.Text) & "," & (puls_conmutador.Text) & "," & (chapa_muelle.Text) & "," & (chapa_muelle_10.Text) & "," & (chapa_muelle_24.Text) & "," & (central_control.Text) & "," & (traslado.Text) & "," & (otros.Text) & "," & (neto.Text) & "," & (iva.Text) & "," & (total.Text) & "," & (desc.Text) & "," & (cuenta_total.Text) & "," & (fondos.Text) & "," & (diferencia.Text) & "," & (motor_remoto.Text) & "," & (motor_autobl_crto.Text) & "," & (orden_venta.Text) & ")")
                            Dim valor1, valor2, valor3, valor4, valor5 As String
                            Dim valor0, valor6 As Integer
                            Consulta5("Call Eliminar_Nota_Cotizacion (" & (valor_ventana) & "," & (orden_venta.Text) & ")")
                            For Each row As DataGridViewRow In Tabla_Nota.Rows
                                valor0 = Val(row.Cells(0).Value)
                                valor1 = CStr(row.Cells(1).Value)
                                valor2 = CStr(row.Cells(2).Value)
                                valor3 = CStr(row.Cells(3).Value)
                                valor4 = CStr(row.Cells(4).Value)
                                valor5 = CStr(row.Cells(5).Value)
                                valor6 = Val(row.Cells(6).Value)
                                If (valor0 = Nothing) Then
                                    valor0 = 0
                                Else
                                End If
                                If (valor1 = "") Then
                                    valor1 = "---"
                                Else
                                End If
                                If (valor2 = "") Then
                                    valor2 = "---"
                                Else
                                End If
                                If (valor3 = "") Then
                                    valor3 = "---"
                                Else
                                End If
                                If (valor4 = "") Then
                                    valor4 = "---"
                                Else
                                End If
                                If (valor5 = "") Then
                                    valor5 = "---"
                                Else
                                End If
                                If (valor6 = Nothing) Then
                                    valor6 = 0
                                Else
                                End If
                                Consulta("Call Insertar_Grilla_Cotizaciones(" & (orden_venta.Text) & "," & (valor0) & ",'" & (valor1) & "','" & (valor2) & "','" & (valor3) & "','" & (valor4) & "','" & (valor5) & "'," & (valor6) & ")")
                            Next
                            Panel3.Visible = False
                            MsgBox("Datos modificados correctamente", vbInformation, "Datos modificados exitosamente")
                            señor_es.Focus()
                            señor_es.Select()
                            Dim valormensaje As Integer
                            valormensaje = MsgBox("¿Deseas traspasar los datos modificados a una nueva nota de venta?", vbYesNo + vbQuestion, "Confirma la Operacion")
                            If valormensaje = vbYes Then
                                Comprobante_Creacion_Informe.Show()
                                eliminar_fila.Enabled = True
                                verifica_botones_desabilitados()
                                valor_ventana = 0
                                traspaso_nota_venta()
                                sacar_informe()
                            Else
                                Comprobante_Creacion_Informe.Show()
                                eliminar_fila.Enabled = True
                                verifica_botones_desabilitados()
                                valor_ventana = 0
                                sacar_informe()
                                'Tabla_Nota.AllowUserToAddRows = True
                            End If
                        Catch ex As Exception
                            Dim ass As String = Convert.ToString(ex)
                            MsgBox("" + ass, vbCritical, "Advertencia, Posible Error")
                        End Try
                    End If
                Else
                    MsgBox("Error: El rut es incorrecto, verifiquelo e intentelo denuevo", vbCritical, "Error, Rut Incorrecto")
                    rut.Clear()
                    rut.Focus()
                    rut.Select()
                End If
            End If
        End If
    End Sub
    Sub calculo_descuento()
        If (desc.Text = "") Then
            cuenta_total.Text = "0"
        Else
            Dim valor_total As Long = total.Text
            Dim mult As Long
            Dim valor_desc As Long = desc.Text
            Dim cuentatotal As Long = cuenta_total.Text
            mult = valor_total - valor_desc
            cuenta_total.Text = mult
        End If
        If (desc.Text = "0") Then
            cuenta_total.Text = "0"
        End If
    End Sub
    Private Sub desc_TextChanged(sender As Object, e As EventArgs) Handles desc.TextChanged
        If (total.Text = "") Then
            total.Text = "0"
        End If
        calculo_descuento()
    End Sub
    Sub suma_total()
        Dim subt, ins, mot_autobloq, mot_manivela, mot, mot_remoteado, puls_conm, chap_muel, chap_muel10, chap_muel24, mot_autobl_remoteado, central_cont, trasl, otr, mul, netos, ivas, totales As Long
        subt = subtotal.Text
        ins = instalacion.Text
        mot_autobloq = motor_tirantes.Text
        mot_manivela = motor_manivela.Text
        mot = motor.Text
        puls_conm = puls_conmutador.Text
        chap_muel = chapa_muelle.Text
        chap_muel10 = chapa_muelle_10.Text
        chap_muel24 = chapa_muelle_24.Text
        central_cont = central_control.Text
        mot_remoteado = motor_remoto.Text
        mot_autobl_remoteado = motor_autobl_crto.Text
        If (traslado.Text = "") Then
        Else
            trasl = traslado.Text
        End If
        If (otros.Text = "") Then
        Else
            otr = otros.Text
        End If
        mul = subt + ins + mot_autobloq + mot_manivela + mot + puls_conm + chap_muel + chap_muel10 + chap_muel24 + central_cont + trasl + otr + mot_autobl_remoteado + mot_remoteado
        netos = mul / 1.19
        ivas = mul - netos
        totales = ivas + mul
        neto.Text = netos
        iva.Text = ivas
        total.Text = totales
    End Sub
    Sub valores_accionamiento()
        Dim suma_valores_de_escalas As Long
        Dim sumamotor As Long
        Dim sumamotormanivela As Long
        Dim sumamotorautoblo As Long
        Dim sumamotorchapa, sumamotorchapa10, sumamotorchapa24 As Long
        Dim sumarcentralcontrol As Long
        Dim sumapulsconm As Long
        Dim sumamotorremoto As Long
        Dim sumamotorautoblcrto As Long
        Dim valorlama As Long
        For Each row As DataGridViewRow In Tabla_Nota.Rows
            If (CStr(row.Cells(5).Value) = "MOTOR") Then
                Consulta8("Call Consulta_Accionamientos_y_Precios('" & (CStr(row.Cells(5).Value)) & "')")
                Dim rows As DataRow = DT8.Rows(0)
                sumamotor += Val(row.Cells(0).Value) * Val(rows("Precios"))
            Else
            End If
            If (CStr(row.Cells(5).Value) = "M. CHAPA Y MUELLE 10K") Then
                Consulta8("Call Consulta_Accionamientos_y_Precios('" & (CStr(row.Cells(5).Value)) & "')")
                Dim rows As DataRow = DT8.Rows(0)
                sumamotorchapa10 += Val(row.Cells(0).Value) * Val(rows("Precios"))
            Else
            End If
            If (CStr(row.Cells(5).Value) = "M. CHAPA Y MUELLE 4K") Then
                Consulta8("Call Consulta_Accionamientos_y_Precios('" & (CStr(row.Cells(5).Value)) & "')")
                Dim rows As DataRow = DT8.Rows(0)
                sumamotorchapa += Val(row.Cells(0).Value) * Val(rows("Precios"))
            Else
            End If
            If (CStr(row.Cells(5).Value) = "M. CHAPA Y MUELLE 24K") Then
                Consulta8("Call Consulta_Accionamientos_y_Precios('" & (CStr(row.Cells(5).Value)) & "')")
                Dim rows As DataRow = DT8.Rows(0)
                sumamotorchapa24 += Val(row.Cells(0).Value) * Val(rows("Precios"))
            Else
            End If
            If (CStr(row.Cells(5).Value) = "MOTOR AUTO-BL") Then
                Consulta8("Call Consulta_Accionamientos_y_Precios('" & (CStr(row.Cells(5).Value)) & "')")
                Dim rows As DataRow = DT8.Rows(0)
                sumamotorautoblo += Val(row.Cells(0).Value) * Val(rows("Precios"))
            Else
            End If
            If (CStr(row.Cells(5).Value) = "MOTOR MANIVELA") Then
                Consulta8("Call Consulta_Accionamientos_y_Precios('" & (CStr(row.Cells(5).Value)) & "')")
                Dim rows As DataRow = DT8.Rows(0)
                sumamotormanivela += Val(row.Cells(0).Value) * Val(rows("Precios"))
            Else
            End If
            If (CStr(row.Cells(5).Value) = "CENTRAL CONTROL") Then
                Consulta8("Call Consulta_Accionamientos_y_Precios('" & (CStr(row.Cells(5).Value)) & "')")
                Dim rows As DataRow = DT8.Rows(0)
                sumarcentralcontrol += Val(row.Cells(0).Value) * Val(rows("Precios"))
            Else
            End If
            If (CStr(row.Cells(5).Value) = "PULS. CONMUTADOR") Then
                Consulta8("Call Consulta_Accionamientos_y_Precios('" & (CStr(row.Cells(5).Value)) & "')")
                Dim rows As DataRow = DT8.Rows(0)
                sumapulsconm += Val(row.Cells(0).Value) * Val(rows("Precios"))
            Else
            End If
            If (CStr(row.Cells(5).Value) = "MOTOR REMOTO") Then
                Consulta8("Call Consulta_Accionamientos_y_Precios('" & (CStr(row.Cells(5).Value)) & "')")
                Dim rows As DataRow = DT8.Rows(0)
                sumamotorremoto += Val(row.Cells(0).Value) * Val(rows("Precios"))
            Else
            End If
            If (CStr(row.Cells(5).Value) = "MOTOR /AUTO-BL/ CRTO") Then
                Consulta8("Call Consulta_Accionamientos_y_Precios('" & (CStr(row.Cells(5).Value)) & "')")
                Dim rows As DataRow = DT8.Rows(0)
                sumamotorautoblcrto += Val(row.Cells(0).Value) * Val(rows("Precios"))
            Else
            End If
            suma_valores_de_escalas += Val(row.Cells(6).Value)
        Next
        motor.Text = sumamotor
        motor_autobl_crto.Text = sumamotorautoblcrto
        motor_remoto.Text = sumamotorremoto
        puls_conmutador.Text = sumapulsconm
        chapa_muelle.Text = sumamotorchapa
        chapa_muelle_10.Text = sumamotorchapa10
        chapa_muelle_24.Text = sumamotorchapa24
        motor_tirantes.Text = sumamotorautoblo
        motor_manivela.Text = sumamotormanivela
        central_control.Text = sumarcentralcontrol
        subtotal.Text = suma_valores_de_escalas
        suma_total()
    End Sub
    Private Sub otros_LostFocus(sender As Object, e As EventArgs) Handles otros.LostFocus
        If (otros.Text = "") Then
            otros.Text = "0"
        End If
    End Sub
    Private Sub desc_LostFocus(sender As Object, e As EventArgs) Handles desc.LostFocus
        If (desc.Text = "") Then
            desc.Text = "0"
            cuenta_total.Text = "0"
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        valores_accionamiento()
        calculo_escala1_cotizaciones()
        calculo_escala2_cotizaciones()
        calculo_descuento()
        verifica_valor_nada_columna_numero()
        calculo_instalacion_motor_manual()
    End Sub
    Private Sub guardar_MouseMove(sender As Object, e As MouseEventArgs) Handles guardar.MouseMove
        guardar.BackColor = Color.White
        guardar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub guardar_MouseLeave(sender As Object, e As EventArgs) Handles guardar.MouseLeave
        guardar.BackColor = Color.FromArgb(27, 94, 32)
        guardar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(27, 94, 32)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.White
        minimizar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.White
        cerrar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(27, 94, 32)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub maximizar_MouseMove(sender As Object, e As MouseEventArgs) Handles maximizar.MouseMove
        maximizar.BackColor = Color.White
        maximizar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub maximizar_MouseLeave(sender As Object, e As EventArgs) Handles maximizar.MouseLeave
        maximizar.BackColor = Color.FromArgb(27, 94, 32)
        maximizar.ForeColor = Color.White
    End Sub
    Private Sub Tabla_Nota_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_Nota.CellClick
        If (Tabla_Nota.CurrentRow.Cells(6).EditedFormattedValue.ToString() = "") Then
            desglose.Text = "..."
        Else
            desglose.Text = Letras(Tabla_Nota.CurrentRow.Cells(6).EditedFormattedValue.ToString())
        End If
    End Sub
    Private Sub rut_TextChanged(sender As Object, e As EventArgs) Handles rut.TextChanged
        If Len(rut.Text) = 2 Then
            rut.Text = rut.Text & "."
            rut.SelectionStart = rut.Text.Length
        ElseIf Len(rut.Text) = 6 Then
            rut.Text = rut.Text & "."
            rut.SelectionStart = rut.Text.Length
        ElseIf Len(rut.Text) = 10 Then
            rut.Text = rut.Text & "-"
            rut.SelectionStart = rut.Text.Length
        ElseIf Len(rut.Text) = 12 Then
        End If
    End Sub
    Private Sub rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rut.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Len(rut.Text) = 11 And InStr(1, "k" & Chr(75), e.KeyChar) = 1 Or Len(rut.Text) = 11 And InStr(1, "K" & Chr(75), e.KeyChar) = 1 Then
            e.KeyChar = UCase("K")
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error Numerico")
            e.Handled = True
        End If
    End Sub
    Private Sub rut_Click(sender As Object, e As EventArgs) Handles rut.Click
        rut.SelectionLength = rut.Text.Length
    End Sub
    Private Sub rut_KeyDown(sender As Object, e As KeyEventArgs) Handles rut.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub señor_es_TextChanged(sender As Object, e As EventArgs) Handles señor_es.TextChanged
        Dim i As Integer
        señor_es.Text = StrConv(señor_es.Text, VbStrConv.ProperCase)
        i = Len(señor_es.Text)
        señor_es.SelectionStart = i
    End Sub
    Private Sub direccion_TextChanged(sender As Object, e As EventArgs) Handles direccion.TextChanged
        Dim i As Integer
        direccion.Text = StrConv(direccion.Text, VbStrConv.ProperCase)
        i = Len(direccion.Text)
        direccion.SelectionStart = i
    End Sub
    Private Sub ciudad_TextChanged(sender As Object, e As EventArgs) Handles ciudad.TextChanged
        Dim i As Integer
        ciudad.Text = StrConv(ciudad.Text, VbStrConv.ProperCase)
        i = Len(ciudad.Text)
        ciudad.SelectionStart = i
    End Sub
    Private Sub comuna_TextChanged(sender As Object, e As EventArgs) Handles comuna.TextChanged
        Dim i As Integer
        comuna.Text = StrConv(comuna.Text, VbStrConv.ProperCase)
        i = Len(comuna.Text)
        comuna.SelectionStart = i
    End Sub
    Sub verifica_botones_desabilitados()
        If (buscar.Enabled = True) Then
            buscar.BackColor = Color.FromArgb(27, 94, 32)
        ElseIf (buscar.Enabled = False)
            buscar.BackColor = Color.White
        End If
        If (guardar.Enabled = True) Then
            guardar.BackColor = Color.FromArgb(27, 94, 32)
        ElseIf (guardar.Enabled = False)
            guardar.BackColor = Color.White
        End If
        If (eliminar_fila.Enabled = True) Then
            eliminar_fila.BackColor = Color.FromArgb(27, 94, 32)
        ElseIf (eliminar_fila.Enabled = False)
            eliminar_fila.BackColor = Color.White
        End If
    End Sub
    Sub procedimiento_luego_de_modificar()
        valor_cancelar_busqueda = 0
        valor_ventana = 0
        limpieza()
        buscar.Text = "BUSCAR"
        guardar.Text = "GUARDAR E IMPRIMIR"
        eliminar_fila.Enabled = True
        verifica_botones_desabilitados()
        señor_es.Focus()
        señor_es.Select()
        crear_16_filas()
    End Sub
    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        If (valor_cancelar_busqueda = 1 And buscar.Text = "CANCELAR") Then
            procedimiento_luego_de_modificar()
        ElseIf (buscar.Text = "BUSCAR")
            valor_ventana = 2
            Buscar_Nota_Cotizacion.Owner = Me
            Buscar_Nota_Cotizacion.ShowDialog()
        End If
    End Sub
    Private Sub buscar_MouseMove(sender As Object, e As MouseEventArgs) Handles buscar.MouseMove
        buscar.BackColor = Color.White
        buscar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub buscar_MouseLeave(sender As Object, e As EventArgs) Handles buscar.MouseLeave
        buscar.BackColor = Color.FromArgb(27, 94, 32)
        buscar.ForeColor = Color.White
    End Sub
    Private Sub fono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fono.KeyPress
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
    Private Sub señor_es_KeyPress(sender As Object, e As KeyPressEventArgs) Handles señor_es.KeyPress
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
    Private Sub comuna_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comuna.KeyPress
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
    Private Sub ciudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ciudad.KeyPress
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
    Private Sub otros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otros.KeyPress
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
    Private Sub desc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles desc.KeyPress
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
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fondos.KeyPress
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
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles diferencia.KeyPress
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
    Private Sub Tabla_Nota_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Tabla_Nota.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub eliminar_fila_Click(sender As Object, e As EventArgs) Handles eliminar_fila.Click
        If Tabla_Nota.Rows.Count = 0 Then
            MsgBox("Error: No hay datos agregados a la grilla", vbCritical, "Error, Grilla vacia")
        Else
            Try
                Dim loFila As DataGridViewRow = Tabla_Nota.CurrentRow()
                Tabla_Nota.Rows.Remove(loFila)
                Tabla_Nota.Rows.Add("1", "", "", "", "", "", "")
            Catch ex As Exception
                MsgBox("Error: No tienes una fila seleccionada o tu fila no contiene datos a ser borrados", vbCritical, "Error, de Fila")
            End Try
        End If
    End Sub
    Private Sub eliminar_fila_MouseMove(sender As Object, e As MouseEventArgs) Handles eliminar_fila.MouseMove
        eliminar_fila.BackColor = Color.White
        eliminar_fila.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub eliminar_fila_MouseLeave(sender As Object, e As EventArgs) Handles eliminar_fila.MouseLeave
        eliminar_fila.BackColor = Color.FromArgb(27, 94, 32)
        eliminar_fila.ForeColor = Color.White
    End Sub
    Private Sub traslado_LostFocus(sender As Object, e As EventArgs) Handles traslado.LostFocus
        If (traslado.Text = "") Then
            traslado.Text = "0"
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
    Private Sub subtotal_MouseMove(sender As Object, e As MouseEventArgs) Handles subtotal.MouseMove
        desglose.Text = Letras(subtotal.Text)
    End Sub
    Private Sub subtotal_MouseLeave(sender As Object, e As EventArgs) Handles subtotal.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub instalacion_MouseMove(sender As Object, e As MouseEventArgs) Handles instalacion.MouseMove
        desglose.Text = Letras(instalacion.Text)
    End Sub
    Private Sub instalacion_MouseLeave(sender As Object, e As EventArgs) Handles instalacion.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub motor_tirantes_MouseMove(sender As Object, e As MouseEventArgs) Handles motor_tirantes.MouseMove
        desglose.Text = Letras(motor_tirantes.Text)
    End Sub
    Private Sub motor_tirantes_MouseLeave(sender As Object, e As EventArgs) Handles motor_tirantes.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub motor_manivela_MouseMove(sender As Object, e As MouseEventArgs) Handles motor_manivela.MouseMove
        desglose.Text = Letras(motor_manivela.Text)
    End Sub
    Private Sub motor_manivela_MouseLeave(sender As Object, e As EventArgs) Handles motor_manivela.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub motor_MouseMove(sender As Object, e As MouseEventArgs) Handles motor.MouseMove
        desglose.Text = Letras(motor.Text)
    End Sub
    Private Sub motor_MouseLeave(sender As Object, e As EventArgs) Handles motor.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub puls_conmutador_MouseMove(sender As Object, e As MouseEventArgs) Handles puls_conmutador.MouseMove
        desglose.Text = Letras(puls_conmutador.Text)
    End Sub
    Private Sub puls_conmutador_MouseLeave(sender As Object, e As EventArgs) Handles puls_conmutador.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub chapa_muelle_MouseMove(sender As Object, e As MouseEventArgs) Handles chapa_muelle.MouseMove
        desglose.Text = Letras(chapa_muelle.Text)
    End Sub
    Private Sub chapa_muelle_MouseLeave(sender As Object, e As EventArgs) Handles chapa_muelle.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub chapa_muelle_10_MouseMove(sender As Object, e As MouseEventArgs) Handles chapa_muelle_10.MouseMove
        desglose.Text = Letras(chapa_muelle_10.Text)
    End Sub
    Private Sub chapa_muelle_10_MouseLeave(sender As Object, e As EventArgs) Handles chapa_muelle_10.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub chapa_muelle_24_MouseMove(sender As Object, e As MouseEventArgs) Handles chapa_muelle_24.MouseMove
        desglose.Text = Letras(chapa_muelle_24.Text)
    End Sub
    Private Sub chapa_muelle_24_MouseLeave(sender As Object, e As EventArgs) Handles chapa_muelle_24.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub central_control_MouseMove(sender As Object, e As MouseEventArgs) Handles central_control.MouseMove
        desglose.Text = Letras(central_control.Text)
    End Sub
    Private Sub central_control_MouseLeave(sender As Object, e As EventArgs) Handles central_control.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub traslado_MouseMove(sender As Object, e As MouseEventArgs) Handles traslado.MouseMove
        desglose.Text = Letras(traslado.Text)
    End Sub
    Private Sub traslado_MouseLeave(sender As Object, e As EventArgs) Handles traslado.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub otros_MouseMove(sender As Object, e As MouseEventArgs) Handles otros.MouseMove
        desglose.Text = Letras(otros.Text)
    End Sub
    Private Sub otros_MouseLeave(sender As Object, e As EventArgs) Handles otros.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub neto_MouseMove(sender As Object, e As MouseEventArgs) Handles neto.MouseMove
        desglose.Text = Letras(neto.Text)
    End Sub
    Private Sub neto_MouseLeave(sender As Object, e As EventArgs) Handles neto.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub iva_MouseMove(sender As Object, e As MouseEventArgs) Handles iva.MouseMove
        desglose.Text = Letras(iva.Text)
    End Sub
    Private Sub iva_MouseLeave(sender As Object, e As EventArgs) Handles iva.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub total_MouseMove(sender As Object, e As MouseEventArgs) Handles total.MouseMove
        desglose.Text = Letras(total.Text)
    End Sub
    Private Sub total_MouseLeave(sender As Object, e As EventArgs) Handles total.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub desc_MouseMove(sender As Object, e As MouseEventArgs) Handles desc.MouseMove
        desglose.Text = Letras(desc.Text)
    End Sub
    Private Sub desc_MouseLeave(sender As Object, e As EventArgs) Handles desc.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub cuenta_total_MouseMove(sender As Object, e As MouseEventArgs) Handles cuenta_total.MouseMove
        desglose.Text = Letras(cuenta_total.Text)
    End Sub
    Private Sub cuenta_total_MouseLeave(sender As Object, e As EventArgs) Handles cuenta_total.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub fondos_MouseMove(sender As Object, e As MouseEventArgs) Handles fondos.MouseMove
        desglose.Text = Letras(fondos.Text)
    End Sub
    Private Sub fondos_MouseLeave(sender As Object, e As EventArgs) Handles fondos.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub diferencia_MouseMove(sender As Object, e As MouseEventArgs) Handles diferencia.MouseMove
        desglose.Text = Letras(diferencia.Text)
    End Sub
    Private Sub diferencia_MouseLeave(sender As Object, e As EventArgs) Handles diferencia.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub Tabla_Nota_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_Nota.CellEnter
        If (Tabla_Nota.CurrentRow.Cells(6).EditedFormattedValue.ToString() = "") Then
            desglose.Text = "..."
        Else
            desglose.Text = Letras(Tabla_Nota.CurrentRow.Cells(6).EditedFormattedValue.ToString())
        End If
    End Sub
    Private Sub valida_dato_celda0_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim columna As Integer = Tabla_Nota.CurrentCell.ColumnIndex
        If (columna = 0) Then
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub valida_dato_celda1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim columna As Integer = Tabla_Nota.CurrentCell.ColumnIndex
        If (columna = 1) Then
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Len(Tabla_Nota.CurrentRow.Cells(1).EditedFormattedValue.ToString()) = 1 And InStr(1, "." & Chr(46), e.KeyChar) = 1 Or Len(Tabla_Nota.CurrentRow.Cells(1).EditedFormattedValue.ToString()) = 1 And InStr(1, ":" & Chr(46), e.KeyChar) = 1 Then
                e.KeyChar = "."
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub valida_dato_celda2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim columna As Integer = Tabla_Nota.CurrentCell.ColumnIndex
        If (columna = 2) Then
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Len(Tabla_Nota.CurrentRow.Cells(2).EditedFormattedValue.ToString()) = 1 And InStr(1, "." & Chr(46), e.KeyChar) = 1 Or Len(Tabla_Nota.CurrentRow.Cells(2).EditedFormattedValue.ToString()) = 1 And InStr(1, ":" & Chr(46), e.KeyChar) = 1 Then
                e.KeyChar = "."
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Tabla_Nota_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tabla_Nota.EditingControlShowing
        Dim columna As Integer = Tabla_Nota.CurrentCell.ColumnIndex
        If (columna = 0) Then
            Dim validar As TextBox = CType(e.Control, TextBox)
            AddHandler validar.KeyPress, AddressOf valida_dato_celda0_KeyPress
        ElseIf (columna = 1) Then
            Dim validar As TextBox = CType(e.Control, TextBox)
            AddHandler validar.KeyPress, AddressOf valida_dato_celda1_KeyPress
        ElseIf (columna = 2)
            Dim validar2 As TextBox = CType(e.Control, TextBox)
            AddHandler validar2.KeyPress, AddressOf valida_dato_celda2_KeyPress
        End If
    End Sub

    Private Sub Tabla_Nota_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_Nota.CellContentClick

    End Sub

    Private Sub Tabla_Nota_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_Nota.CellEndEdit
        If (e.ColumnIndex = 1) Then
            Dim celda = Tabla_Nota(e.ColumnIndex, e.RowIndex)
            If (CStr(celda.Value) > "4.500") Then
                celda.Value = "4.500"
            End If
        ElseIf (e.ColumnIndex = 2)
            Dim celda2 = Tabla_Nota(e.ColumnIndex, e.RowIndex)
            If (CStr(celda2.Value) > "4.500") Then
                celda2.Value = "4.500"
            End If
        End If
    End Sub
    Private Sub motor_autobl_crto_MouseMove(sender As Object, e As MouseEventArgs) Handles motor_autobl_crto.MouseMove
        desglose.Text = Letras(motor_autobl_crto.Text)
    End Sub
    Private Sub motor_autobl_crto_MouseLeave(sender As Object, e As EventArgs) Handles motor_autobl_crto.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub motor_remoto_MouseMove(sender As Object, e As MouseEventArgs) Handles motor_remoto.MouseMove
        desglose.Text = Letras(motor_remoto.Text)
    End Sub
    Private Sub motor_remoto_MouseLeave(sender As Object, e As EventArgs) Handles motor_remoto.MouseLeave
        desglose.Text = "..."
    End Sub
    Sub traspaso_nota_venta()
        valor_ventana = 2
        NotaVenta.Panel3.Visible = True
        NotaVenta.Show()
        NotaVenta.Tabla_Nota.Rows.Clear()
        NotaVenta.fecha.Value = fecha.Value
        NotaVenta.rut.Text = rut.Text
        NotaVenta.señor_es.Text = señor_es.Text
        NotaVenta.direccion.Text = direccion.Text
        NotaVenta.fono.Text = fono.Text
        NotaVenta.email.Text = email.Text
        NotaVenta.ciudad.Text = ciudad.Text
        NotaVenta.comuna.Text = comuna.Text
        NotaVenta.cond_venta.Text = cond_venta.Text
        Consulta6("Call Buscar_Nota_Ventas('" & (orden_venta.Text) & "','" & (valor_ventana) & "')")
        For Each row As DataRow In DT6.Rows
            NotaVenta.Tabla_Nota.Rows.Add("1", "---", row("Ancho"), row("Alto"), row("Lama"), row("Color"), row("Accionamiento"))
            NotaVenta.Tabla_Nota.CurrentCell = NotaVenta.Tabla_Nota.Rows(NotaVenta.Tabla_Nota.RowCount - 1).Cells(0)
            NotaVenta.Tabla_Nota.Refresh()
        Next
        Consulta6("Call Buscar_Detalle_Nota_Cotizaciones('" & (orden_venta.Text) & "','" & (valor_ventana) & "')")
        Dim row2 As DataRow = DT6.Rows(0)
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
        NotaVenta.verifica_botones_desabilitados()
        Hide()
    End Sub
    Private Sub Tabla_Nota_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tabla_Nota.DataError
        If (valordgv = 2) Then
            Try
                For Each row As DataGridViewRow In Tabla_Nota.Rows
                    If (row.Cells(3).Value = "") Then
                        lama.DisplayIndex = -1
                    End If
                    If (row.Cells(4).Value = "") Then
                        colores.DisplayIndex = -1
                    End If
                    If (row.Cells(5).Value = "") Then
                        accionamiento.DisplayIndex = -1
                    End If
                Next
            Catch ex As Exception
            End Try
        End If
    End Sub
    Sub maximizar_minimizar()
        If (valormaximizado = True) Then
            WindowState = FormWindowState.Maximized
            valormaximizado = False
        ElseIf (valormaximizado = False) Then
            WindowState = FormWindowState.Normal
            valormaximizado = True
        End If
    End Sub
    Private Sub Panel2_DoubleClick(sender As Object, e As EventArgs) Handles Panel2.DoubleClick
        maximizar_minimizar()
    End Sub
    Sub calculo_instalacion_motor_manual()
        Dim cant_motor As Integer
        Dim cant_manual As Integer
        For Each row As DataGridViewRow In Tabla_Nota.Rows
            If (Val(row.Cells(0).Value) >= 1 And CStr(row.Cells(5).Value) = "MOTOR") Then
                cant_motor += (Val(row.Cells(0).Value))
            End If
            If (Val(row.Cells(0).Value) >= 1 And CStr(row.Cells(5).Value) = "MANUAL") Then
                cant_manual += (Val(row.Cells(0).Value))
            End If
            If (cant_motor = 1) Then
                mult2 = "50000"
            ElseIf (cant_motor = 2) Then
                mult2 = "85000"
            ElseIf (cant_motor = 3) Then
                mult2 = "115000"
            ElseIf (cant_motor = 4) Then
                mult2 = "140000"
            ElseIf (cant_motor = 5) Then
                mult2 = cant_motor * 35000
            End If
            If (cant_motor + cant_manual >= 5) Then
                mult2 = cant_motor * 35000
                mult1 = cant_manual * 35000
            End If
            If (cant_manual = 1) Then
                mult1 = "50000"
            ElseIf (cant_manual = 2) Then
                mult1 = "85000"
            ElseIf (cant_manual = 3) Then
                mult1 = "115000"
            ElseIf (cant_manual = 4) Then
                mult1 = "140000"
            ElseIf (cant_manual = 5) Then
                mult1 = cant_manual * 35000
            End If
            If (cant_motor + cant_manual >= 5) Then
                mult2 = cant_motor * 35000
                mult1 = cant_manual * 35000
            End If
            Dim suma, sumamanual, sumamotor As Long
            sumamanual = mult1
            sumamotor = mult2
            suma = sumamanual + sumamotor
            instalacion.Text = suma
        Next
    End Sub
    Private Sub direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles direccion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Letras y Numeros", vbCritical, "Error, Admición de Solo Letras y Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub fondos_LostFocus(sender As Object, e As EventArgs) Handles fondos.LostFocus
        If (fondos.Text = "") Then
            fondos.Text = "0"
        End If
    End Sub
    Private Sub diferencia_LostFocus(sender As Object, e As EventArgs) Handles diferencia.LostFocus
        If (diferencia.Text = "") Then
            diferencia.Text = "0"
        End If
    End Sub
End Class