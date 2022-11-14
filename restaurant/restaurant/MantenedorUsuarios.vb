Public Class MantenedorUsuarios
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Dim run As String
    Dim VarSeleccion As Integer
    Dim Dato1, Dato2, Dato3, Dato4 As String
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
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
    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
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
    Private Sub MantenedorUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
    End Sub
    Private Sub regresar_Click(sender As Object, e As EventArgs) Handles regresar.Click
        Me.Close()
        Me.Refresh()
        buscar.Clear()
        Mostrar_Grilla()
        Actualizacion_Tabla()
        Mostrar()
        guardar.Enabled = False
        nuevo.Enabled = True
        genero.Enabled = False
        eliminar.Enabled = True
        modificar.Enabled = True
        buscar.Enabled = True
        buscar.ReadOnly = False
        Grilla_Usuarios.Enabled = True
        Grilla_Usuarios.ReadOnly = False
        cancelar.Enabled = False
        rut.Enabled = False
        nombre.Enabled = False
        genero.Enabled = False
        rut.ReadOnly = True
        nombre.ReadOnly = True
        If (Me.Grilla_Usuarios.Rows.Count = 0) Then
            rut.Clear()
            genero.SelectedIndex = -1
            nombre.Clear()
        End If
        Me.Refresh()
    End Sub
    Private Sub Grilla_Usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Usuarios.CellContentClick
        Grilla_Usuarios.ReadOnly = True
    End Sub
    Sub Actualizacion_Tabla()
        Consulta3("Call MostrarUsuarios")
    End Sub
    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged
        Dim i As Integer
        nombre.Text = StrConv(nombre.Text, VbStrConv.ProperCase)
        i = Len(nombre.Text)
        nombre.SelectionStart = i
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
            nombre.Focus()
            nombre.Select()
        End If
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Usuarios.DataSource = DS3.Tables(DT3.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar()
        If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
            Dato1 = Grilla_Usuarios.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato2 = Grilla_Usuarios.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato3 = Grilla_Usuarios.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato4 = Grilla_Usuarios.CurrentRow.Cells(3).EditedFormattedValue.ToString
            id.Text = Dato1
            rut.Text = Dato2
            nombre.Text = Dato3
            genero.Text = Dato4
        Else
            id.Text = "0"
            rut.Clear()
            nombre.Clear()
            genero.SelectedIndex = -1
        End If
    End Sub
    Private Sub Grilla_Usuarios_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Usuarios.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        buscar.Clear()
        VarSeleccion = 1
        rut.Enabled = True
        nombre.Enabled = True
        genero.Enabled = True
        rut.ReadOnly = False
        nombre.ReadOnly = False
        buscar.Enabled = False
        buscar.ReadOnly = True
        buscar.Clear()
        guardar.Enabled = True
        genero.SelectedIndex = -1
        nuevo.Enabled = False
        eliminar.Enabled = False
        modificar.Enabled = False
        Grilla_Usuarios.Enabled = False
        Grilla_Usuarios.ReadOnly = True
        rut.Clear()
        nombre.Clear()
        rut.Focus()
        rut.Select()
        SendKeys.Send("{BACKSPACE}")
        cancelar.Enabled = True
        nuevo.Focus()
        nuevo.Select()
        Consulta3("Call GeneradorIDautomatico1")
        If TypeOf (DS3.Tables(DT3.TableName).Rows(0).Item("ID")) Is DBNull Then
            id.Text = 1
        Else
            id.Text = DS3.Tables(DT3.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Me.Refresh()
        buscar.Clear()
        Mostrar_Grilla()
        Actualizacion_Tabla()
        Mostrar()
        guardar.Enabled = False
        nuevo.Enabled = True
        genero.Enabled = False
        eliminar.Enabled = True
        modificar.Enabled = True
        buscar.Enabled = True
        buscar.ReadOnly = False
        Grilla_Usuarios.Enabled = True
        Grilla_Usuarios.ReadOnly = False
        cancelar.Enabled = False
        rut.Enabled = False
        nombre.Enabled = False
        genero.Enabled = False
        rut.ReadOnly = True
        nombre.ReadOnly = True
        If (Me.Grilla_Usuarios.Rows.Count = 0) Then
            rut.Clear()
            genero.SelectedIndex = -1
            nombre.Clear()
        End If
        Me.Refresh()
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
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        If Me.Grilla_Usuarios.Rows.Count = 0 Then
            MsgBox("Error: No hay Usuarios Registrados a Modificar", vbCritical, "Error, No hay Usuarios")
            nuevo.Focus()
            nuevo.Select()
        Else
            VarSeleccion = 2
            rut.Enabled = True
            nombre.Enabled = True
            genero.Enabled = True
            rut.ReadOnly = False
            nombre.ReadOnly = False
            buscar.Enabled = False
            buscar.ReadOnly = True
            buscar.Clear()
            guardar.Enabled = True
            genero.SelectedIndex = -1
            nuevo.Enabled = False
            eliminar.Enabled = False
            modificar.Enabled = False
            Grilla_Usuarios.Enabled = False
            Grilla_Usuarios.ReadOnly = True
            rut.Clear()
            nombre.Clear()
            rut.Focus()
            rut.Select()
            cancelar.Enabled = True
            Grilla_Usuarios.Rows.RemoveAt(Grilla_Usuarios.CurrentRow.Index)
        End If
    End Sub
    Private Sub rut_KeyDown(sender As Object, e As KeyEventArgs) Handles rut.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If Me.Grilla_Usuarios.Rows.Count = 0 Then
            MsgBox("Error: No Existe Usuarios Registrados, Para Eliminar se Necesita Agente Inscrito", vbCritical, "Error, Operación Incorrecta")
            nuevo.Focus()
            nuevo.Select()
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro El Siguiente Rut: " + rut.Text + " ?", vbYesNo + vbQuestion, "¿Eliminar Usuario?")
            If valormensaje = vbYes Then
                Consulta3("Call EliminarUsuario ('" & (rut.Text) & "')")
                MsgBox("El Usuario: '" + nombre.Text + "' Con el Rut: '" + rut.Text + "' Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                buscar.Clear()
                nuevo.Focus()
                nuevo.Select()
                genero.SelectedIndex = -1
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                nuevo.Focus()
                nuevo.Select()
            End If
            Actualizacion_Tabla()
            If DS3.Tables(DT3.TableName).Rows.Count > 0 Then
                Mostrar()
            Else
                rut.Clear()
                nombre.Clear()
                genero.SelectedIndex = -1
            End If
            Mostrar()
            Actualizacion_Tabla()
            Mostrar_Grilla()
            nuevo.Focus()
            nuevo.Select()
        End If
        nuevo.Focus()
        nuevo.Select()
    End Sub
    Private Sub buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged
        Dim i As Integer
        buscar.Text = StrConv(buscar.Text, VbStrConv.ProperCase)
        i = Len(buscar.Text)
        buscar.SelectionStart = i
        If (buscar.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
            modificar.Enabled = True
        Else
            Consulta3("Call Buscar_Usuario('" & (buscar.Text & "%") & "')")
            If DS3.Tables(DT3.TableName).Rows.Count > 0 Then
                Grilla_Usuarios.DataSource = DS3.Tables(DT3.TableName)
                Mostrar()
                modificar.Enabled = False
            Else
                rut.Clear()
                nombre.Clear()
                modificar.Enabled = False
                genero.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        buscar.Clear()
        If Len(rut.Text) < 12 Then
            MsgBox("Error: Estructura de Rut No Valido", vbCritical, "Error, Rut Invalido")
            rut.Focus()
            rut.Select()
            rut.Clear()
        ElseIf (rut.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Rut", vbCritical, "¡Error, Campo Rut Vacio!")
            rut.Focus()
            rut.Select()
        ElseIf (nombre.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Nombre", vbCritical, "¡Error, Campo Nombre Vacio!")
            nombre.Focus()
            nombre.Select()
        ElseIf (genero.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Cargo", vbCritical, "¡Error, Campo Cargo Vacio!")
            genero.Focus()
            genero.Select()
        Else
            If (Me.Grilla_Usuarios.Rows.Count = 0) Then
                Dato2 = Nothing
            Else
                Dato2 = Grilla_Usuarios.CurrentRow.Cells(1).EditedFormattedValue.ToString
            End If
            For Each row As DataGridViewRow In Grilla_Usuarios.Rows
                run = row.Cells(1).Value
            Next
            If (run = rut.Text) Then
                MsgBox("El Rut: " + rut.Text + " o Nombre Ya Existe En El Registro con el Rut Especificado y Departamento.", vbCritical, "Error, Rut Ya Existente")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf (Dato2 = rut.Text) Then
                MsgBox("El Rut: " + rut.Text + " o Nombre Ya Existe En El Registro con el Rut Especificado y Departamento.", vbCritical, "Error, Rut Ya Existente")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf VarSeleccion = 1 Then
                Try
                    Consulta3("Call Guardar_Usuarios ('" & (id.Text) & "','" & (rut.Text) & "','" & (nombre.Text) & "','" & (genero.Text) & "')")
                    MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                    rut.Enabled = False
                    nombre.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    modificar.Enabled = True
                    buscar.Enabled = True
                    buscar.ReadOnly = False
                    genero.Enabled = False
                    Grilla_Usuarios.Enabled = True
                    Grilla_Usuarios.ReadOnly = True
                    cancelar.Enabled = False
                    rut.Enabled = False
                    nombre.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    nuevo.Focus()
                    nuevo.Select()
                Catch ex As Exception
                    DA3.SelectCommand = SC3
                    DA3.Fill(DT3)
                End Try
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
            ElseIf VarSeleccion = 2 Then
                Try
                    Consulta3("Call Modificar_Usuario('" & (nombre.Text) & "','" & (rut.Text) & "','" & (genero.Text) & "'," & (id.Text) & ")")
                    MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                    rut.Enabled = False
                    nombre.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    modificar.Enabled = True
                    buscar.Enabled = True
                    buscar.ReadOnly = False
                    genero.Enabled = False
                    Grilla_Usuarios.Enabled = True
                    Grilla_Usuarios.ReadOnly = True
                    cancelar.Enabled = False
                    rut.Enabled = False
                    nombre.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    nuevo.Focus()
                    nuevo.Select()
                Catch ex As Exception
                    DA3.SelectCommand = SC3
                    DA3.Fill(DT3)
                End Try
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
            End If
        End If
    End Sub
    Private Sub rut_Click(sender As Object, e As EventArgs) Handles rut.Click
        rut.SelectionLength = rut.Text.Length
    End Sub
    Private Sub Grilla_Usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Usuarios.CellClick
        If Me.Grilla_Usuarios.Rows.Count = 0 Then
        Else
            Dato1 = Grilla_Usuarios.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato2 = Grilla_Usuarios.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato3 = Grilla_Usuarios.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato4 = Grilla_Usuarios.CurrentRow.Cells(3).EditedFormattedValue.ToString
            id.Text = Dato1
            rut.Text = Dato2
            nombre.Text = Dato3
            genero.Text = Dato4
        End If
    End Sub
    Private Sub buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles buscar.KeyPress
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
    End Sub
End Class