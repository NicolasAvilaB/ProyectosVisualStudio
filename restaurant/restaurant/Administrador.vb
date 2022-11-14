Public Class Administrador
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Dim run As String
    Dim VarSeleccion As Integer
    Dim Dato1, Dato2, Dato3, Dato4, Dato5, Dato6 As String
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        While (GroupBox2.Width < 194)
            While (Panel1.Width < 217)
                Panel1.Width += 2
            End While
            GroupBox2.Width += 2
        End While
    End Sub
    Private Sub Grilla_Administrador_MouseMove(sender As Object, e As MouseEventArgs) Handles Grilla_Administrador.MouseMove
        While (GroupBox2.Width > 20)
            GroupBox2.Width -= 3
        End While
        While (Panel1.Width > 22)
            Panel1.Width -= 7
        End While
    End Sub
    Private Sub GroupBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles GroupBox1.MouseMove
        While (GroupBox2.Width > 20)
            GroupBox2.Width -= 3
        End While
        While (Panel1.Width > 22)
            Panel1.Width -= 7
        End While
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
    Private Sub trabajadores_Click(sender As Object, e As EventArgs) Handles trabajadores.Click
        While (GroupBox2.Width > 20)
            GroupBox2.Width -= 3
        End While
        While (Panel1.Width > 22)
            Panel1.Width -= 7
        End While
        MantenedorTrabajadores.Owner = Me
        MantenedorTrabajadores.ShowDialog()
    End Sub
    Private Sub mesasrest_Click(sender As Object, e As EventArgs) Handles mesasrest.Click
        While (GroupBox2.Width > 20)
            GroupBox2.Width -= 3
        End While
        While (Panel1.Width > 22)
            Panel1.Width -= 7
        End While
        MantenedorMesas.Owner = Me
        MantenedorMesas.ShowDialog()
    End Sub
    Private Sub platosdispo_Click(sender As Object, e As EventArgs) Handles platosdispo.Click
        While (GroupBox2.Width > 20)
            GroupBox2.Width -= 3
        End While
        While (Panel1.Width > 22)
            Panel1.Width -= 7
        End While
        MantenedorPlatos.Owner = Me
        MantenedorPlatos.ShowDialog()
    End Sub
    Private Sub regresar_Click(sender As Object, e As EventArgs) Handles regresar.Click
        Me.Close()
        MenuMesas.Close()
        MenuMesas.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        MenuMesas.Close()
        MenuMesas.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
    End Sub
    Sub Actualizacion_Tabla()
        Consulta4("Call MostrarAdmin")
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
    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged
        Dim i As Integer
        nombre.Text = StrConv(nombre.Text, VbStrConv.ProperCase)
        i = Len(nombre.Text)
        nombre.SelectionStart = i
    End Sub
    Private Sub labor_TextChanged(sender As Object, e As EventArgs) Handles labor.TextChanged
        Dim i As Integer
        labor.Text = StrConv(labor.Text, VbStrConv.ProperCase)
        i = Len(labor.Text)
        labor.SelectionStart = i
    End Sub
    Private Sub busc_nom_TextChanged(sender As Object, e As EventArgs) Handles busc_nom.TextChanged
        Dim i As Integer
        busc_nom.Text = StrConv(busc_nom.Text, VbStrConv.ProperCase)
        i = Len(busc_nom.Text)
        busc_nom.SelectionStart = i
        If (busc_nom.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
            modificar.Enabled = True
        Else
            Consulta4("Call Buscar_Admin('" & (busc_nom.Text & "%") & "')")
            If DS4.Tables(DT4.TableName).Rows.Count > 0 Then
                Grilla_Administrador.DataSource = DS4.Tables(DT4.TableName)
                Mostrar()
                modificar.Enabled = False
            Else
                rut.Clear()
                nombre.Clear()
                clave.Clear()
                labor.Clear()
                modificar.Enabled = False
                genero.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub Grilla_Administrador_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Administrador.CellContentClick
        Grilla_Administrador.ReadOnly = True
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        busc_nom.Clear()
        VarSeleccion = 1
        rut.Enabled = True
        nombre.Enabled = True
        clave.Enabled = True
        labor.Enabled = True
        genero.Enabled = True
        rut.ReadOnly = False
        nombre.ReadOnly = False
        clave.ReadOnly = False
        labor.ReadOnly = False
        busc_nom.Enabled = False
        busc_nom.ReadOnly = True
        busc_nom.Clear()
        guardar.Enabled = True
        genero.SelectedIndex = -1
        nuevo.Enabled = False
        eliminar.Enabled = False
        modificar.Enabled = False
        Grilla_Administrador.Enabled = False
        Grilla_Administrador.ReadOnly = True
        rut.Clear()
        nombre.Clear()
        clave.Clear()
        labor.Clear()
        rut.Focus()
        rut.Select()
        SendKeys.Send("{BACKSPACE}")
        cancelar.Enabled = True
        nuevo.Focus()
        nuevo.Select()
        Consulta4("Call GeneradorIDautomatico2")
        If TypeOf (DS4.Tables(DT4.TableName).Rows(0).Item("ID")) Is DBNull Then
            id.Text = 1
        Else
            id.Text = DS4.Tables(DT4.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Me.Refresh()
        busc_nom.Clear()
        Mostrar_Grilla()
        Actualizacion_Tabla()
        Mostrar()
        guardar.Enabled = False
        nuevo.Enabled = True
        genero.Enabled = False
        eliminar.Enabled = True
        modificar.Enabled = True
        busc_nom.Enabled = True
        busc_nom.ReadOnly = False
        Grilla_Administrador.Enabled = True
        Grilla_Administrador.ReadOnly = False
        cancelar.Enabled = False
        rut.Enabled = False
        nombre.Enabled = False
        clave.Enabled = False
        labor.Enabled = False
        genero.Enabled = False
        rut.ReadOnly = True
        nombre.ReadOnly = True
        clave.ReadOnly = True
        labor.ReadOnly = True
        If (Me.Grilla_Administrador.Rows.Count = 0) Then
            rut.Clear()
            nombre.Clear()
            clave.Clear()
            labor.Clear()
            genero.SelectedIndex = -1
        End If
        Me.Refresh()
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If Me.Grilla_Administrador.Rows.Count = 0 Then
            MsgBox("Error: No Existe Usuarios Registrados, Para Eliminar se Necesita Agente Inscrito", vbCritical, "Error, Operación Incorrecta")
            nuevo.Focus()
            nuevo.Select()
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro El Siguiente Rut: " + rut.Text + " ?", vbYesNo + vbQuestion, "¿Eliminar Usuario?")
            If valormensaje = vbYes Then
                Consulta4("Call EliminarAdministrador ('" & (rut.Text) & "')")
                MsgBox("El Usuario: '" + nombre.Text + "' Con el Rut: '" + rut.Text + "' Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                busc_nom.Clear()
                nuevo.Focus()
                nuevo.Select()
                genero.SelectedIndex = -1
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                nuevo.Focus()
                nuevo.Select()
            End If
            Actualizacion_Tabla()
            If DS4.Tables(DT4.TableName).Rows.Count > 0 Then
                Mostrar()
            Else
                rut.Clear()
                nombre.Clear()
                clave.Clear()
                labor.Clear()
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
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        busc_nom.Clear()
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
        ElseIf (clave.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo clave", vbCritical, "¡Error, Campo clave Vacio!")
            clave.Focus()
            clave.Select()
        ElseIf (labor.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo labor", vbCritical, "¡Error, Campo labor Vacio!")
            labor.Focus()
            labor.Select()
        ElseIf (genero.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo genero", vbCritical, "¡Error, Campo genero Vacio!")
            genero.Focus()
            genero.Select()
        Else
            If (Me.Grilla_Administrador.Rows.Count = 0) Then
                Dato2 = Nothing
            Else
                Dato2 = Grilla_Administrador.CurrentRow.Cells(1).EditedFormattedValue.ToString
            End If
            For Each row As DataGridViewRow In Grilla_Administrador.Rows
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
                    Consulta4("Call Guardar_Admin ('" & (id.Text) & "','" & (rut.Text) & "','" & (nombre.Text) & "','" & (clave.Text) & "','" & (labor.Text) & "','" & (genero.Text) & "')")
                    MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                    rut.Enabled = False
                    nombre.Enabled = False
                    clave.Enabled = False
                    labor.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    clave.ReadOnly = True
                    labor.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    modificar.Enabled = True
                    busc_nom.Enabled = True
                    busc_nom.ReadOnly = False
                    genero.Enabled = False
                    Grilla_Administrador.Enabled = True
                    Grilla_Administrador.ReadOnly = True
                    cancelar.Enabled = False
                    rut.Enabled = False
                    nombre.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    nuevo.Focus()
                    nuevo.Select()
                Catch ex As Exception
                    DA4.SelectCommand = SC4
                    DA4.Fill(DT4)
                End Try
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
            ElseIf VarSeleccion = 2 Then
                Try
                    Consulta4("Call Modificar_Admin('" & (nombre.Text) & "','" & (rut.Text) & "','" & (clave.Text) & "','" & (labor.Text) & "','" & (genero.Text) & "'," & (id.Text) & ")")
                    MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                    rut.Enabled = False
                    nombre.Enabled = False
                    clave.Enabled = False
                    labor.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    clave.ReadOnly = True
                    labor.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    modificar.Enabled = True
                    busc_nom.Enabled = True
                    busc_nom.ReadOnly = False
                    genero.Enabled = False
                    Grilla_Administrador.Enabled = True
                    Grilla_Administrador.ReadOnly = True
                    cancelar.Enabled = False
                    rut.Enabled = False
                    nombre.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    nuevo.Focus()
                    nuevo.Select()
                Catch ex As Exception
                    DA4.SelectCommand = SC4
                    DA4.Fill(DT4)
                End Try
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
            End If
        End If
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        If Me.Grilla_Administrador.Rows.Count = 0 Then
            MsgBox("Error: No hay Usuarios Registrados a Modificar", vbCritical, "Error, No hay Usuarios")
            nuevo.Focus()
            nuevo.Select()
        Else
            VarSeleccion = 2
            rut.Enabled = True
            nombre.Enabled = True
            clave.Enabled = True
            labor.Enabled = True
            rut.ReadOnly = False
            nombre.ReadOnly = False
            clave.ReadOnly = False
            labor.ReadOnly = False
            genero.Enabled = True
            busc_nom.Enabled = False
            busc_nom.ReadOnly = True
            busc_nom.Clear()
            guardar.Enabled = True
            genero.SelectedIndex = -1
            nuevo.Enabled = False
            eliminar.Enabled = False
            modificar.Enabled = False
            Grilla_Administrador.Enabled = False
            Grilla_Administrador.ReadOnly = True
            rut.Focus()
            rut.Select()
            cancelar.Enabled = True
            Grilla_Administrador.Rows.RemoveAt(Grilla_Administrador.CurrentRow.Index)
        End If
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Administrador.DataSource = DS4.Tables(DT4.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar()
        If (DS4.Tables(DT4.TableName).Rows.Count > 0) Then
            Dato1 = Grilla_Administrador.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato2 = Grilla_Administrador.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato3 = Grilla_Administrador.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato4 = Grilla_Administrador.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Dato5 = Grilla_Administrador.CurrentRow.Cells(4).EditedFormattedValue.ToString
            Dato6 = Grilla_Administrador.CurrentRow.Cells(5).EditedFormattedValue.ToString
            id.Text = Dato1
            rut.Text = Dato2
            nombre.Text = Dato3
            clave.Text = Dato4
            labor.Text = Dato5
            genero.Text = Dato6
        Else
            id.Text = "0"
            rut.Clear()
            nombre.Clear()
            clave.Clear()
            labor.Clear()
            genero.SelectedIndex = -1
        End If
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
    Private Sub rut_KeyDown(sender As Object, e As KeyEventArgs) Handles rut.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub rut_Click(sender As Object, e As EventArgs) Handles rut.Click
        rut.SelectionLength = rut.Text.Length
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        While (GroupBox2.Width > 20)
            GroupBox2.Width -= 3
        End While
        While (Panel1.Width > 22)
            Panel1.Width -= 7
        End While
        MantenedorBebestibles.Owner = Me
        MantenedorBebestibles.ShowDialog()
    End Sub
    Private Sub hito_Click(sender As Object, e As EventArgs) Handles hito.Click
        While (GroupBox2.Width > 20)
            GroupBox2.Width -= 3
        End While
        While (Panel1.Width > 22)
            Panel1.Width -= 7
        End While
        Historial_Pedidos.Owner = Me
        Historial_Pedidos.ShowDialog()
    End Sub
    Private Sub Grilla_Administrador_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Administrador.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Grilla_Administrador_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Administrador.CellClick
        If Me.Grilla_Administrador.Rows.Count = 0 Then
        Else
            Dato1 = Grilla_Administrador.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato2 = Grilla_Administrador.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato3 = Grilla_Administrador.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato4 = Grilla_Administrador.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Dato5 = Grilla_Administrador.CurrentRow.Cells(4).EditedFormattedValue.ToString
            Dato6 = Grilla_Administrador.CurrentRow.Cells(5).EditedFormattedValue.ToString
            id.Text = Dato1
            rut.Text = Dato2
            nombre.Text = Dato3
            clave.Text = Dato4
            labor.Text = Dato5
            genero.Text = Dato6
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
    Private Sub labor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles labor.KeyPress
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
    Private Sub busc_nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busc_nom.KeyPress
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