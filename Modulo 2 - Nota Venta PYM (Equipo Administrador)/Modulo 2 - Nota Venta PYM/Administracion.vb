Public Class Administracion
    Dim valor As Integer = 0
    Dim suma As Long
    Dim resta As Long
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
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Menus.Show()
        Close()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Sub consulta_escalas()
        If (tipo_prod.Text = "LAMA 45, BLANCO, BRONCE, PLATA") Then
            Consulta9("Call Mostrar_Escala1")
            Tabla_DD.DataSource = DS9.Tables(DT9.TableName)
            valor = 0
        ElseIf (tipo_prod.Text = "LAMA 45, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
            Consulta9("Call Mostrar_Escala2")
            Tabla_DD.DataSource = DS9.Tables(DT9.TableName)
            valor = 0
        ElseIf (tipo_prod.Text = "LAMA 55, BLANCO, BRONCE, PLATA")
            Consulta9("Call Mostrar_Escala3")
            Tabla_DD.DataSource = DS9.Tables(DT9.TableName)
            valor = 0
        ElseIf (tipo_prod.Text = "LAMA 55, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
            Consulta9("Call Mostrar_Escala4")
            Tabla_DD.DataSource = DS9.Tables(DT9.TableName)
            valor = 0
        Else
            Consulta9("Call Consulta_Accionamientos ('" & (tipo_prod.Text) & "')")
            Tabla_DD.DataSource = DS9.Tables(DT9.TableName)
            valor = 8
        End If
    End Sub
    Private Sub tipo_escala_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipo_prod.SelectedIndexChanged
        consulta_escalas()
    End Sub
    Private Sub Tabla_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_DD.CellEnter
        If (Tabla_DD.CurrentRow.Cells(2).EditedFormattedValue.ToString() = "") Then
            desglose.Text = "..."
        Else
            desglose.Text = Letras(Tabla_DD.CurrentRow.Cells(2).EditedFormattedValue.ToString())
        End If
    End Sub
    Private Sub Tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_DD.CellClick
        If (Tabla_DD.CurrentRow.Cells(2).EditedFormattedValue.ToString() = "") Then
            desglose.Text = "..."
        Else
            desglose.Text = Letras(Tabla_DD.CurrentRow.Cells(2).EditedFormattedValue.ToString())
        End If
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
    Private Sub eliminar_fila_Click(sender As Object, e As EventArgs) Handles eliminar_fila.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Deseas aplicar el porcentaje de " & porc.Text & " a toda la escala seleccionada?", vbYesNo + vbQuestion, "Confirma la Operacion")
        If valormensaje = vbYes Then
            If (acc.Text = "SUMA" And tipo_prod.Text = "LAMA 45, BLANCO, BRONCE, PLATA") Then
                Dim uno As String = "1." & porc.Text
                Dim b As Decimal = Convert.ToDecimal(uno)
                For Each rowsss As DataGridViewRow In Tabla_DD.Rows
                    Consulta0("Call Modificar_Escala1(" & (Val(rowsss.Cells(2).Value) * b) & ",'" & (CStr(rowsss.Cells(0).Value)) & "','" & (CStr(rowsss.Cells(1).Value)) & "')")
                Next
                consulta_escalas()
                MsgBox("Datos modificados correctamente", vbInformation, "Operacion Exitosa")
            ElseIf (acc.Text = "RESTA" And tipo_prod.Text = "LAMA 45, BLANCO, BRONCE, PLATA")
                Dim uno As String = "1." & porc.Text
                Dim b As Decimal = Convert.ToDecimal(uno)
                For Each rows2 As DataGridViewRow In Tabla_DD.Rows
                    Consulta0("Call Modificar_Escala1(" & (Val(rows2.Cells(2).Value) / b) & ",'" & (CStr(rows2.Cells(0).Value)) & "','" & (CStr(rows2.Cells(1).Value)) & "')")
                Next
                consulta_escalas()
                MsgBox("Datos modificados correctamente", vbInformation, "Operacion Exitosa")
            ElseIf (acc.Text = "SUMA" And tipo_prod.Text = "LAMA 45, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA") Then
                Dim uno As String = "1." & porc.Text
                Dim b As Decimal = Convert.ToDecimal(uno)
                For Each rowsss As DataGridViewRow In Tabla_DD.Rows
                    Consulta0("Call Modificar_Escala2(" & (Val(rowsss.Cells(2).Value) * b) & ",'" & (CStr(rowsss.Cells(0).Value)) & "','" & (CStr(rowsss.Cells(1).Value)) & "')")
                Next
                consulta_escalas()
                MsgBox("Datos modificados correctamente", vbInformation, "Operacion Exitosa")
            ElseIf (acc.Text = "RESTA" And tipo_prod.Text = "LAMA 45, PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
                Dim uno As String = "1." & porc.Text
                Dim b As Decimal = Convert.ToDecimal(uno)
                For Each rows2 As DataGridViewRow In Tabla_DD.Rows
                    Consulta0("Call Modificar_Escala2(" & (Val(rows2.Cells(2).Value) / b) & ",'" & (CStr(rows2.Cells(0).Value)) & "','" & (CStr(rows2.Cells(1).Value)) & "')")
                Next
                consulta_escalas()
                MsgBox("Datos modificados correctamente", vbInformation, "Operacion Exitosa")
            ElseIf (valor = 8 And acc.Text = "SUMA")
                Dim uno As String = "1." & porc.Text
                Dim b As Decimal = Convert.ToDecimal(uno)
                Consulta0("Call Modificar_Accionamientos('" & (Tabla_DD.CurrentRow.Cells(2).EditedFormattedValue.ToString() * b) & "','" & (tipo_prod.Text) & "')")
                consulta_escalas()
                MsgBox("Datos modificados correctamente", vbInformation, "Operacion Exitosa")
            ElseIf (valor = 8 And acc.Text = "RESTA")
                Dim uno As String = "1." & porc.Text
                Dim b As Decimal = Convert.ToDecimal(uno)
                Consulta0("Call Modificar_Accionamientos('" & (Tabla_DD.CurrentRow.Cells(2).EditedFormattedValue.ToString() / b) & "','" & (tipo_prod.Text) & "')")
                consulta_escalas()
                MsgBox("Datos modificados correctamente", vbInformation, "Operacion Exitosa")
            End If
        Else
            MsgBox("Operacion Cancelada", vbExclamation, "Mensaje")
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

    Private Sub Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class