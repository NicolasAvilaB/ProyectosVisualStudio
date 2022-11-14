Public Class MantenedorBebestibles
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Dim run As String
    Dim VarSeleccion As Integer
    Dim Dato1, Dato2, Dato3, Dato4, Dato5, Dato6, Dato7 As String
    Private Sub MantenedorBebestibles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Sub Actualizacion_Tabla()
        Consulta7("Call MostrarBebestibles")
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Bebestibles.DataSource = DS7.Tables(DT7.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar()
        If (DS7.Tables(DT7.TableName).Rows.Count > 0) Then
            Dato1 = Grilla_Bebestibles.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato2 = Grilla_Bebestibles.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato3 = Grilla_Bebestibles.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato4 = Grilla_Bebestibles.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Dato5 = Grilla_Bebestibles.CurrentRow.Cells(4).EditedFormattedValue.ToString
            Dato6 = Grilla_Bebestibles.CurrentRow.Cells(5).EditedFormattedValue.ToString
            Dato7 = Grilla_Bebestibles.CurrentRow.Cells(6).EditedFormattedValue.ToString
            id.Text = Dato1
            codigo.Text = Dato2
            nombre.Text = Dato3
            marca.Text = Dato4
            tipo.Text = Dato5
            cantidad.Text = Dato6
            precio.Text = Dato7
        Else
            id.Text = "0"
            codigo.Clear()
            nombre.Clear()
            marca.Clear()
            tipo.SelectedIndex = -1
            cantidad.Text = "0"
            precio.Clear()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Me.Close()
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        buscar.Clear()
        VarSeleccion = 1
        codigo.Enabled = True
        nombre.Enabled = True
        marca.Enabled = True
        tipo.Enabled = True
        cantidad.Enabled = True
        precio.Enabled = True
        codigo.ReadOnly = False
        nombre.ReadOnly = False
        marca.ReadOnly = False
        cantidad.ReadOnly = False
        precio.ReadOnly = False
        buscar.Enabled = False
        buscar.ReadOnly = True
        buscar.Clear()
        guardar.Enabled = True
        tipo.SelectedIndex = -1
        nuevo.Enabled = False
        eliminar.Enabled = False
        modificar.Enabled = False
        Grilla_Bebestibles.Enabled = False
        Grilla_Bebestibles.ReadOnly = True
        codigo.Clear()
        nombre.Clear()
        marca.Clear()
        cantidad.Text = "0"
        precio.Clear()
        codigo.Focus()
        codigo.Select()
        SendKeys.Send("{BACKSPACE}")
        cancelar.Enabled = True
        nuevo.Focus()
        nuevo.Select()
        Consulta7("Call GeneradorIDautomatico5")
        If TypeOf (DS7.Tables(DT7.TableName).Rows(0).Item("ID")) Is DBNull Then
            id.Text = 1
        Else
            id.Text = DS7.Tables(DT7.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        If Me.Grilla_Bebestibles.Rows.Count = 0 Then
            MsgBox("Error: No hay Usuarios Registrados a Modificar", vbCritical, "Error, No hay Usuarios")
            nuevo.Focus()
            nuevo.Select()
        Else
            VarSeleccion = 2
            codigo.Enabled = True
            nombre.Enabled = True
            marca.Enabled = True
            tipo.Enabled = True
            cantidad.Enabled = True
            precio.Enabled = True
            codigo.ReadOnly = False
            nombre.ReadOnly = False
            marca.ReadOnly = False
            cantidad.ReadOnly = False
            precio.ReadOnly = False
            buscar.Enabled = False
            buscar.ReadOnly = True
            buscar.Clear()
            guardar.Enabled = True
            tipo.SelectedIndex = -1
            nuevo.Enabled = False
            eliminar.Enabled = False
            modificar.Enabled = False
            Grilla_Bebestibles.Enabled = False
            Grilla_Bebestibles.ReadOnly = True
            buscar.Clear()
            guardar.Enabled = True
            nuevo.Enabled = False
            eliminar.Enabled = False
            modificar.Enabled = False
            codigo.Focus()
            codigo.Select()
            cancelar.Enabled = True
            Grilla_Bebestibles.Rows.RemoveAt(Grilla_Bebestibles.CurrentRow.Index)
        End If
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        buscar.Clear()
        If (codigo.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Codigo", vbCritical, "¡Error, Campo Codigo Vacio!")
            codigo.Focus()
            codigo.Select()
        ElseIf (nombre.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Nombre", vbCritical, "¡Error, Campo Nombre Vacio!")
            nombre.Focus()
            nombre.Select()
        ElseIf (marca.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Materia", vbCritical, "¡Error, Campo Materia Vacio!")
            marca.Focus()
            marca.Select()
        ElseIf (tipo.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Tipo", vbCritical, "¡Error, Campo Tipo Vacio!")
            tipo.Focus()
            tipo.Select()
        ElseIf (cantidad.Text = "" Or cantidad.Text = "0") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Cantidad o su Ingreso es 0", vbCritical, "¡Error, Campo Cantidad Vacio!")
            cantidad.Focus()
            cantidad.Select()
        ElseIf (precio.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Precio", vbCritical, "¡Error, Campo Precio Vacio!")
            precio.Focus()
            precio.Select()
        Else
            If (Me.Grilla_Bebestibles.Rows.Count = 0) Then
                Dato2 = Nothing
            Else
                Dato2 = Grilla_Bebestibles.CurrentRow.Cells(1).EditedFormattedValue.ToString
            End If
            For Each row As DataGridViewRow In Grilla_Bebestibles.Rows
                run = row.Cells(1).Value
            Next
            If (run = codigo.Text) Then
                MsgBox("El Codigo: " + codigo.Text + " o Nombre Ya Existe En El Registro con el Codigo Especificado", vbCritical, "Error, Codigo Ya Existente")
                codigo.Clear()
                codigo.Focus()
                codigo.Select()
            ElseIf (Dato2 = codigo.Text) Then
                MsgBox("El Codigo: " + codigo.Text + " o Nombre Ya Existe En El Registro con el Codigo Especificado", vbCritical, "Error, Codigo Ya Existente")
                codigo.Clear()
                codigo.Focus()
                codigo.Select()
            ElseIf VarSeleccion = 1 Then
                Try
                    Consulta7("Call Guardar_Bebestibles ('" & (id.Text) & "','" & (codigo.Text) & "','" & (nombre.Text) & "','" & (marca.Text) & "','" & (tipo.Text) & "','" & (cantidad.Text) & "','" & (precio.Text) & "')")
                    MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                    codigo.Enabled = False
                    nombre.Enabled = False
                    marca.Enabled = False
                    tipo.Enabled = False
                    cantidad.Enabled = False
                    precio.Enabled = False
                    codigo.ReadOnly = True
                    nombre.ReadOnly = True
                    marca.ReadOnly = True
                    cantidad.ReadOnly = True
                    precio.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    modificar.Enabled = True
                    buscar.Enabled = True
                    buscar.ReadOnly = False
                    Grilla_Bebestibles.Enabled = True
                    Grilla_Bebestibles.ReadOnly = True
                    cancelar.Enabled = False
                    codigo.Enabled = False
                    nombre.Enabled = False
                    codigo.ReadOnly = True
                    nombre.ReadOnly = True
                    nuevo.Focus()
                    nuevo.Select()
                Catch ex As Exception
                    DA7.SelectCommand = SC7
                    DA7.Fill(DT7)
                End Try
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
            ElseIf VarSeleccion = 2 Then
                Try
                    Consulta7("Call Modificar_Bebestibles('" & (nombre.Text) & "','" & (codigo.Text) & "','" & (marca.Text) & "'," & (precio.Text) & "," & (cantidad.Text) & ",'" & (tipo.Text) & "'," & (id.Text) & ")")
                    MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                    codigo.Enabled = False
                    nombre.Enabled = False
                    marca.Enabled = False
                    tipo.Enabled = False
                    cantidad.Enabled = False
                    precio.Enabled = False
                    codigo.ReadOnly = True
                    nombre.ReadOnly = True
                    marca.ReadOnly = True
                    cantidad.ReadOnly = True
                    precio.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    modificar.Enabled = True
                    buscar.Enabled = True
                    buscar.ReadOnly = False
                    Grilla_Bebestibles.Enabled = True
                    Grilla_Bebestibles.ReadOnly = True
                    cancelar.Enabled = False
                    codigo.Enabled = False
                    nombre.Enabled = False
                    codigo.ReadOnly = True
                    nombre.ReadOnly = True
                    nuevo.Focus()
                    nuevo.Select()
                Catch ex As Exception
                    DA7.SelectCommand = SC7
                    DA7.Fill(DT7)
                End Try
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
            End If
        End If
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If Me.Grilla_Bebestibles.Rows.Count = 0 Then
            MsgBox("Error: No Existe Bebestibles Registrados, Para Eliminar se Necesita Agentes Inscrito", vbCritical, "Error, Operación Incorrecta")
            nuevo.Focus()
            nuevo.Select()
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro El Siguiente Codigo: " + codigo.Text + " ?", vbYesNo + vbQuestion, "¿Eliminar Codigo?")
            If valormensaje = vbYes Then
                Consulta7("Call Eliminar_Bebestibles ('" & (codigo.Text) & "')")
                MsgBox("El Bebestible: '" + nombre.Text + "' Con el Codigo: '" + codigo.Text + "' Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                buscar.Clear()
                nuevo.Focus()
                nuevo.Select()
                tipo.SelectedIndex = -1
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                nuevo.Focus()
                nuevo.Select()
            End If
            Actualizacion_Tabla()
            If DS7.Tables(DT7.TableName).Rows.Count > 0 Then
                Mostrar()
            Else
                id.Text = "0"
                codigo.Clear()
                nombre.Clear()
                marca.Clear()
                tipo.SelectedIndex = -1
                cantidad.Text = "0"
                precio.Clear()
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
    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged
        Dim i As Integer
        nombre.Text = StrConv(nombre.Text, VbStrConv.ProperCase)
        i = Len(nombre.Text)
        nombre.SelectionStart = i
    End Sub
    Private Sub marca_TextChanged(sender As Object, e As EventArgs) Handles marca.TextChanged
        marca.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        codigo.Enabled = False
        nombre.Enabled = False
        marca.Enabled = False
        tipo.Enabled = False
        cantidad.Enabled = False
        precio.Enabled = False
        codigo.ReadOnly = True
        nombre.ReadOnly = True
        marca.ReadOnly = True
        cantidad.ReadOnly = True
        precio.ReadOnly = True
        guardar.Enabled = False
        nuevo.Enabled = True
        eliminar.Enabled = True
        modificar.Enabled = True
        buscar.Enabled = True
        buscar.ReadOnly = False
        Grilla_Bebestibles.Enabled = True
        Grilla_Bebestibles.ReadOnly = True
        cancelar.Enabled = False
        codigo.Enabled = False
        nombre.Enabled = False
        codigo.ReadOnly = True
        nombre.ReadOnly = True
        nuevo.Focus()
        nuevo.Select()
        If (Me.Grilla_Bebestibles.Rows.Count = 0) Then
            id.Text = "0"
            codigo.Clear()
            nombre.Clear()
            marca.Clear()
            tipo.SelectedIndex = -1
            cantidad.Text = "0"
            precio.Clear()
        End If
        Me.Refresh()
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
            Consulta7("Call Buscar_Bebestible('" & (buscar.Text & "%") & "')")
            If DS7.Tables(DT7.TableName).Rows.Count > 0 Then
                Grilla_Bebestibles.DataSource = DS7.Tables(DT7.TableName)
                Mostrar()
                modificar.Enabled = False
            Else
                id.Text = "0"
                codigo.Clear()
                nombre.Clear()
                marca.Clear()
                tipo.SelectedIndex = -1
                cantidad.Text = "0"
                precio.Clear()
                modificar.Enabled = False
            End If
        End If
    End Sub
    Private Sub Grilla_Bebestibles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Bebestibles.CellContentClick
        Grilla_Bebestibles.ReadOnly = True
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
    Private Sub Grilla_Bebestibles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Bebestibles.CellClick
        If Me.Grilla_Bebestibles.Rows.Count = 0 Then
        Else
            Dato1 = Grilla_Bebestibles.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato2 = Grilla_Bebestibles.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato3 = Grilla_Bebestibles.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato4 = Grilla_Bebestibles.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Dato5 = Grilla_Bebestibles.CurrentRow.Cells(4).EditedFormattedValue.ToString
            Dato6 = Grilla_Bebestibles.CurrentRow.Cells(5).EditedFormattedValue.ToString
            Dato7 = Grilla_Bebestibles.CurrentRow.Cells(6).EditedFormattedValue.ToString
            id.Text = Dato1
            codigo.Text = Dato2
            nombre.Text = Dato3
            marca.Text = Dato4
            tipo.Text = Dato5
            cantidad.Text = Dato6
            precio.Text = Dato7
        End If
    End Sub
    Private Sub Grilla_Bebestibles_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Bebestibles.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
End Class