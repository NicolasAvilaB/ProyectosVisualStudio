Public Class Escalas_Precios
    Dim valor As Integer = 0
    Dim suma As Long
    Dim resta As Long
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Public conf_mens As Integer
    Public ass As String
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
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.White
        cerrar.ForeColor = Color.FromArgb(98, 117, 127)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(98, 117, 127)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.White
        minimizar.ForeColor = Color.FromArgb(98, 117, 127)
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(98, 117, 127)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub aceptar_MouseMove(sender As Object, e As MouseEventArgs) Handles aceptar.MouseMove
        aceptar.BackColor = Color.FromArgb(0, 105, 120)
        aceptar.ForeColor = Color.White
    End Sub
    Private Sub aceptar_MouseLeave(sender As Object, e As EventArgs) Handles aceptar.MouseLeave
        aceptar.BackColor = Color.White
        aceptar.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub volver_MouseMove(sender As Object, e As MouseEventArgs) Handles volver.MouseMove
        volver.BackColor = Color.FromArgb(0, 105, 120)
        volver.ForeColor = Color.White
    End Sub
    Private Sub volver_MouseLeave(sender As Object, e As EventArgs) Handles volver.MouseLeave
        volver.BackColor = Color.White
        volver.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Menus.Show()
        Close()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Sub consulta_escalas()
        If (tipo_prod.Text = "LAMA 45, BLANCO, BRONCE, PLATA") Then
            Consulta2("Call Mostrar_Escala1")
            Tabla_DD.DataSource = DS2.Tables(DT2.TableName)
            valor = 0
            Tabla_DD.CurrentRow.Cells(0).ReadOnly = False
            Tabla_DD.CurrentRow.Cells(1).ReadOnly = False
            Tabla_DD.CurrentRow.Cells(2).ReadOnly = False
        ElseIf (tipo_prod.Text = "LAMA 45, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
            Consulta2("Call Mostrar_Escala2")
            Tabla_DD.DataSource = DS2.Tables(DT2.TableName)
            valor = 0
            Tabla_DD.CurrentRow.Cells(0).ReadOnly = False
            Tabla_DD.CurrentRow.Cells(1).ReadOnly = False
            Tabla_DD.CurrentRow.Cells(2).ReadOnly = False
        ElseIf (tipo_prod.Text = "LAMA 55, BLANCO, BRONCE, PLATA")
            Consulta2("Call Mostrar_Escala3")
            Tabla_DD.DataSource = DS2.Tables(DT2.TableName)
            valor = 0
            Tabla_DD.CurrentRow.Cells(0).ReadOnly = False
            Tabla_DD.CurrentRow.Cells(1).ReadOnly = False
            Tabla_DD.CurrentRow.Cells(2).ReadOnly = False
        ElseIf (tipo_prod.Text = "LAMA 55, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
            Consulta2("Call Mostrar_Escala4")
            Tabla_DD.DataSource = DS2.Tables(DT2.TableName)
            valor = 0
            Tabla_DD.CurrentRow.Cells(0).ReadOnly = False
            Tabla_DD.CurrentRow.Cells(1).ReadOnly = False
            Tabla_DD.CurrentRow.Cells(2).ReadOnly = False
        Else
            Consulta2("Call Consulta_Accionamientos ('" & (tipo_prod.Text) & "')")
            Tabla_DD.DataSource = DS2.Tables(DT2.TableName)
            valor = 8
        End If
    End Sub
    Sub suma_resta_escala()
        Confirmacion_Mensaje.texto.Text = "¿Desea aplicar el porcentaje de " & porc.Text & " a"
        Confirmacion_Mensaje.texto2.Text = "toda la escala seleccionada?"
        Confirmacion_Mensaje.Owner = Me
        Confirmacion_Mensaje.ShowDialog()
        If conf_mens = 1 Then
            If (acc.Text = "SUMA" And tipo_prod.Text = "LAMA 45, BLANCO, BRONCE, PLATA") Then
                Consulta5("Call Sumar_Porcetaje_Actual_LM45_1('" & (porc.Text) & "')")
            ElseIf (acc.Text = "SUMA" And tipo_prod.Text = "LAMA 45, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
                Consulta5("Call Sumar_Porcetaje_Actual_LM45_2('" & (porc.Text) & "')")
            ElseIf (acc.Text = "SUMA" And tipo_prod.Text = "LAMA 55, BLANCO, BRONCE, PLATA")
                Consulta5("Call Sumar_Porcetaje_Actual_LM55_3('" & (porc.Text) & "')")
            ElseIf (acc.Text = "SUMA" And tipo_prod.Text = "LAMA 55, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
                Consulta5("Call Sumar_Porcetaje_Actual_LM55_4('" & (porc.Text) & "')")
            ElseIf (acc.Text = "RESTA" And tipo_prod.Text = "LAMA 45, BLANCO, BRONCE, PLATA") Then
                Consulta5("Call Resta_Porcetaje_Actual_LM45_1('" & (porc.Text) & "')")
            ElseIf (acc.Text = "RESTA" And tipo_prod.Text = "LAMA 45, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
                Consulta5("Call Resta_Porcetaje_Actual_LM45_2('" & (porc.Text) & "')")
            ElseIf (acc.Text = "RESTA" And tipo_prod.Text = "LAMA 55, BLANCO, BRONCE, PLATA")
                Consulta5("Call Resta_Porcetaje_Actual_LM55_3('" & (porc.Text) & "')")
            ElseIf (acc.Text = "RESTA" And tipo_prod.Text = "LAMA 55, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
                Consulta5("Call Resta_Porcetaje_Actual_LM55_4('" & (porc.Text) & "')")
            End If
            Consulta2("Call Ingreso_Historial_Porcentajes ('" & (porc.Text) & "','" & (acc.Text) & "','" & (Format(Now, "yyyy-MM-dd")) & "','" & (Now.ToLongTimeString) & "')")
            Cargar.Show()
            If (acc.Text = "SUMA" And tipo_prod.Text = "LAMA 45, BLANCO, BRONCE, PLATA") Then
                Dim uno As String = "1." & porc.Text
                ' Dim b As Decimal = Convert.ToDecimal(uno)
                Consulta4("Call Modificar_Escala1_Suma('" & (uno) & "')")
                consulta_escalas()
                Cargar.Close()
                Advertencia.texto.Text = "Datos modificados correctamente"
                Advertencia.Owner = Me
                Advertencia.ShowDialog()
                porc.Clear()
                acc.SelectedIndex = -1
            ElseIf (acc.Text = "RESTA" And tipo_prod.Text = "LAMA 45, BLANCO, BRONCE, PLATA") Then
                Dim uno As String = "1." & porc.Text
                ' Dim b As Decimal = Convert.ToDecimal(uno)
                Consulta4("Call Modificar_Escala1_Resta('" & (uno) & "')")
                consulta_escalas()
                Cargar.Close()
                Advertencia.texto.Text = "Datos modificados correctamente"
                Advertencia.Owner = Me
                Advertencia.ShowDialog()
                porc.Clear()
                acc.SelectedIndex = -1
            ElseIf (acc.Text = "SUMA" And tipo_prod.Text = "LAMA 45, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA") Then
                Dim uno As String = "1." & porc.Text
                ' Dim b As Decimal = Convert.ToDecimal(uno)
                Consulta4("Call Modificar_Escala2_Suma('" & (uno) & "')")
                consulta_escalas()
                Cargar.Close()
                Advertencia.texto.Text = "Datos modificados correctamente"
                Advertencia.Owner = Me
                Advertencia.ShowDialog()
                porc.Clear()
                acc.SelectedIndex = -1
            ElseIf (acc.Text = "RESTA" And tipo_prod.Text = "LAMA 45, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA") Then
                Dim uno As String = "1." & porc.Text
                'Dim b As Decimal = Convert.ToDecimal(uno)
                Consulta4("Call Modificar_Escala2_Resta('" & (uno) & "')")
                consulta_escalas()
                Cargar.Close()
                Advertencia.texto.Text = "Datos modificados correctamente"
                Advertencia.Owner = Me
                Advertencia.ShowDialog()
                porc.Clear()
                acc.SelectedIndex = -1
            ElseIf (acc.Text = "SUMA" And tipo_prod.Text = "LAMA 55, BLANCO, BRONCE, PLATA") Then
                Dim uno As String = "1." & porc.Text
                ' Dim b As Decimal = Convert.ToDecimal(uno)
                Consulta4("Call Modificar_Escala3_Suma('" & (uno) & "')")
                consulta_escalas()
                Cargar.Close()
                Advertencia.texto.Text = "Datos modificados correctamente"
                Advertencia.Owner = Me
                Advertencia.ShowDialog()
                porc.Clear()
                acc.SelectedIndex = -1
            ElseIf (acc.Text = "RESTA" And tipo_prod.Text = "LAMA 55, BLANCO, BRONCE, PLATA") Then
                Dim uno As String = "1." & porc.Text
                ' Dim b As Decimal = Convert.ToDecimal(uno)
                Consulta4("Call Modificar_Escala3_Resta('" & (uno) & "')")
                consulta_escalas()
                Cargar.Close()
                Advertencia.texto.Text = "Datos modificados correctamente"
                Advertencia.Owner = Me
                Advertencia.ShowDialog()
                porc.Clear()
                acc.SelectedIndex = -1
            ElseIf (acc.Text = "SUMA" And tipo_prod.Text = "LAMA 55, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA") Then
                Dim uno As String = "1." & porc.Text
                'Dim b As Decimal = Convert.ToDecimal(uno)
                Consulta4("Call Modificar_Escala4_Suma('" & (uno) & "')")
                consulta_escalas()
                Cargar.Close()
                Advertencia.texto.Text = "Datos modificados correctamente"
                Advertencia.Owner = Me
                Advertencia.ShowDialog()
                porc.Clear()
                acc.SelectedIndex = -1
            ElseIf (acc.Text = "RESTA" And tipo_prod.Text = "LAMA 55, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA") Then
                Dim uno As String = "1." & porc.Text
                'Dim b As Decimal = Convert.ToDecimal(uno)
                Consulta4("Call Modificar_Escala4_Resta('" & (uno) & "')")
                consulta_escalas()
                Cargar.Close()
                Advertencia.texto.Text = "Datos modificados correctamente"
                Advertencia.Owner = Me
                Advertencia.ShowDialog()
                porc.Clear()
                acc.SelectedIndex = -1
            ElseIf (valor = 8 And acc.Text = "SUMA") Then
                Dim uno As String = "1." & porc.Text
                Dim b As Decimal = Convert.ToDecimal(uno)
                Consulta("Call Modificar_Accionamientos('" & (Tabla_DD.CurrentRow.Cells(2).EditedFormattedValue.ToString() * b) & "','" & (tipo_prod.Text) & "')")
                consulta_escalas()
                Cargar.Close()
                Advertencia.texto.Text = "Datos modificados correctamente"
                Advertencia.Owner = Me
                Advertencia.ShowDialog()
                porc.Clear()
                acc.SelectedIndex = -1
            ElseIf (valor = 8 And acc.Text = "RESTA") Then
                Dim uno As String = "1." & porc.Text
                Dim b As Decimal = Convert.ToDecimal(uno)
                Consulta("Call Modificar_Accionamientos('" & (Tabla_DD.CurrentRow.Cells(2).EditedFormattedValue.ToString() / b) & "','" & (tipo_prod.Text) & "')")
                consulta_escalas()
                Cargar.Close()
                Advertencia.texto.Text = "Datos modificados correctamente"
                Advertencia.Owner = Me
                Advertencia.ShowDialog()
                porc.Clear()
                acc.SelectedIndex = -1
            End If
        ElseIf (conf_mens = 0)
            Advertencia.texto.Text = "Operacion Cancelada"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
        End If
        consulta_porcentaje()
    End Sub
    Private Sub Tabla_DD_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_DD.CellEnter
        If (Tabla_DD.CurrentRow.Cells(2).EditedFormattedValue.ToString() = "") Then
            desglose.Text = "..."
        Else
            desglose.Text = Letras(Tabla_DD.CurrentRow.Cells(2).EditedFormattedValue.ToString())
        End If
    End Sub
    Private Sub Tabla_DD_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_DD.CellClick
        If (Tabla_DD.CurrentRow.Cells(2).EditedFormattedValue.ToString() = "") Then
            desglose.Text = "..."
        Else
            desglose.Text = Letras(Tabla_DD.CurrentRow.Cells(2).EditedFormattedValue.ToString())
        End If
    End Sub
    Private Sub tipo_prod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipo_prod.SelectedIndexChanged
        consulta_escalas()
        consulta_porcentaje()
    End Sub
    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        If (tipo_prod.Text = "") Then
            Advertencia.texto.Text = "Producto no seleccionado"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
        ElseIf (acc.Text = "") Then
            Advertencia.texto.Text = "Accion aritmetica no seleccionada"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
        ElseIf (porc.Text = "") Then
            Advertencia.texto.Text = "Porcentaje a aplicar en escala no especificado"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
        Else
            suma_resta_escala()
        End If
    End Sub
    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        Menus.Show()
        Close()
    End Sub
    Private Sub porc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles porc.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            Advertencia.texto.Text = "Solo se admite numeros no letras ni espacios"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Admin_Mod.Owner = Me
        Admin_Mod.ShowDialog()
    End Sub
    Sub consulta_porcentaje()
        If (tipo_prod.Text = "LAMA 45, BLANCO, BRONCE, PLATA") Then
            Consulta6("Call Consulta_Porc1")
            Dim row As DataRow = DT6.Rows(0)
            p.Text = CStr(row("Porcentaje"))
        ElseIf (tipo_prod.Text = "LAMA 45, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
            Consulta6("Call Consulta_Porc2")
            Dim row As DataRow = DT6.Rows(0)
            p.Text = CStr(row("Porcentaje"))
        ElseIf (tipo_prod.Text = "LAMA 55, BLANCO, BRONCE, PLATA") Then
            Consulta6("Call Consulta_Porc3")
            Dim row As DataRow = DT6.Rows(0)
            p.Text = CStr(row("Porcentaje"))
        ElseIf (tipo_prod.Text = "LAMA 55, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
            Consulta6("Call Consulta_Porc4")
            Dim row As DataRow = DT6.Rows(0)
            p.Text = CStr(row("Porcentaje"))
        End If
    End Sub
    Private Sub Escalas_Precios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub porc_TextChanged(sender As Object, e As EventArgs) Handles porc.TextChanged

    End Sub
End Class