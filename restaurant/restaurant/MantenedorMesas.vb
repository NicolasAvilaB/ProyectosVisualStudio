Public Class MantenedorMesas
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Dim run As String
    Dim VarSeleccion As Integer
    Dim Dato1, Dato2, Dato3 As String
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles regresar.Click
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
    Sub Actualizacion_Tabla()
        Consulta5("Call MostrarMesas")
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Mesas.DataSource = DS5.Tables(DT5.TableName)
        Conexion.Close()
    End Sub
    Private Sub busc_nom_TextChanged(sender As Object, e As EventArgs) Handles busc_nom.TextChanged
        If (busc_nom.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
            modificar.Enabled = True
        Else
            Consulta5("Call Buscar_Mesa('" & (busc_nom.Text & "%") & "')")
            If DS5.Tables(DT5.TableName).Rows.Count > 0 Then
                Grilla_Mesas.DataSource = DS5.Tables(DT5.TableName)
                Mostrar()
                modificar.Enabled = False
            Else
                mesa.Clear()
                cantsillas.Text = "0"
                modificar.Enabled = False
            End If
        End If
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If Me.Grilla_Mesas.Rows.Count = 0 Then
            MsgBox("Error: No Existe Usuarios Registrados, Para Eliminar se Necesita Agente Inscrito", vbCritical, "Error, Operación Incorrecta")
            nuevo.Focus()
            nuevo.Select()
        Else
            Consulta5("Call ConsultaMesaOcupada('" & (mesa.Text) & "')")
            If DS5.Tables(DT5.TableName).Rows.Count > 0 Then
                MsgBox("Error: Esta Mesa esta Ocupada no se Puede Eliminar", vbCritical, "Error, Mesa Ocupada")
                nuevo.Focus()
                nuevo.Select()
            Else
                Dim valormensaje As Integer
                valormensaje = MsgBox("¿Desea Eliminar del Registro La Siguiente Mesa: " + mesa.Text + " ?", vbYesNo + vbQuestion, "¿Eliminar Usuario?")
                If valormensaje = vbYes Then
                    Consulta5("Call EliminarMesa ('" & (mesa.Text) & "')")
                    MsgBox("La Mesa : '" + mesa.Text + "' Con la Cantidad de Silla: '" + cantsillas.Text + "' Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                    busc_nom.Clear()
                    nuevo.Focus()
                    nuevo.Select()
                    cantsillas.Enabled = False
                    cantsillas.ReadOnly = True
                Else
                    MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                    nuevo.Focus()
                    nuevo.Select()
                End If
            End If
            Actualizacion_Tabla()
            If DS5.Tables(DT5.TableName).Rows.Count > 0 Then
                Mostrar()
            Else
                mesa.Clear()
                cantsillas.Text = "0"
            End If
            Mostrar()
            Actualizacion_Tabla()
            Mostrar_Grilla()
            nuevo.Focus()
            nuevo.Select()
        End If
        cantsillas.Enabled = False
        cantsillas.ReadOnly = True
        nuevo.Focus()
        nuevo.Select()
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        busc_nom.Clear()
        If (cantsillas.Text = "" Or cantsillas.Text = "0") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Cantidad de Sillas o Su Ingreso de Datos Es 0 Sillas", vbCritical, "¡Error, Campo Cantidad de Sillas Vacio o Cantidad 0!")
            cantsillas.Focus()
            cantsillas.Select()
        ElseIf VarSeleccion = 1 Then
            Try
                Consulta5("Call Guardar_Mesa ('" & (id.Text) & "','" & (mesa.Text) & "','" & (cantsillas.Text) & "','" & "Disponible" & "','" & "-------" & "')")
                MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                mesa.Enabled = False
                cantsillas.Enabled = False
                mesa.ReadOnly = True
                cantsillas.ReadOnly = True
                guardar.Enabled = False
                nuevo.Enabled = True
                eliminar.Enabled = True
                modificar.Enabled = True
                busc_nom.Enabled = True
                busc_nom.ReadOnly = False
                Grilla_Mesas.Enabled = True
                Grilla_Mesas.ReadOnly = True
                cancelar.Enabled = False
                nuevo.Focus()
                nuevo.Select()
            Catch ex As Exception
                DA5.SelectCommand = SC5
                DA5.Fill(DT5)
            End Try
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
        ElseIf VarSeleccion = 2 Then
            Try
                Consulta5("Call Modificar_Mesas('" & (mesa.Text) & "'," & (cantsillas.Text) & ",'" & "Disponible" & "','" & "-------" & "'," & (id.Text) & ")")
                MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                mesa.Enabled = False
                cantsillas.Enabled = False
                mesa.ReadOnly = True
                cantsillas.ReadOnly = True
                guardar.Enabled = False
                nuevo.Enabled = True
                eliminar.Enabled = True
                modificar.Enabled = True
                busc_nom.Enabled = True
                busc_nom.ReadOnly = False
                Grilla_Mesas.Enabled = True
                Grilla_Mesas.ReadOnly = True
                cancelar.Enabled = False
                nuevo.Focus()
                nuevo.Select()
            Catch ex As Exception
                DA5.SelectCommand = SC5
                DA5.Fill(DT5)
            End Try
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
        End If
    End Sub
    Sub Mostrar()
        If (DS5.Tables(DT5.TableName).Rows.Count > 0) Then
            Dato1 = Grilla_Mesas.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato2 = Grilla_Mesas.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato3 = Grilla_Mesas.CurrentRow.Cells(2).EditedFormattedValue.ToString
            id.Text = Dato1
            mesa.Text = Dato2
            cantsillas.Text = Dato3
        Else
            id.Text = "0"
            mesa.Clear()
            cantsillas.Text = "0"
        End If
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        busc_nom.Clear()
        VarSeleccion = 1
        cantsillas.Enabled = True
        cantsillas.ReadOnly = False
        busc_nom.Enabled = False
        busc_nom.ReadOnly = True
        busc_nom.Clear()
        guardar.Enabled = True
        nuevo.Enabled = False
        eliminar.Enabled = False
        modificar.Enabled = False
        mesa.Clear()
        Grilla_Mesas.Enabled = False
        Grilla_Mesas.ReadOnly = True
        cantsillas.Text = "0"
        cantsillas.Focus()
        cantsillas.Select()
        SendKeys.Send("{BACKSPACE}")
        cancelar.Enabled = True
        nuevo.Focus()
        nuevo.Select()
        Consulta5("Call GeneradorIDautomatico3")
        If TypeOf (DS5.Tables(DT5.TableName).Rows(0).Item("ID")) Is DBNull Then
                id.Text = 1
            Else
                id.Text = DS5.Tables(DT5.TableName).Rows(0).Item("ID") + 1
                Conexion.Close()
            End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
        mesa.Clear()
        mesa.Enabled = True
        mesa.ReadOnly = False
        mesa.Text = "MESA"
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        If Me.Grilla_Mesas.Rows.Count = 0 Then
            MsgBox("Error: No hay Usuarios Registrados a Modificar", vbCritical, "Error, No hay Usuarios")
            nuevo.Focus()
            nuevo.Select()
        Else
            VarSeleccion = 2
            mesa.Enabled = True
            cantsillas.Enabled = True
            mesa.ReadOnly = False
            cantsillas.ReadOnly = False
            busc_nom.Enabled = False
            busc_nom.ReadOnly = True
            busc_nom.Clear()
            guardar.Enabled = True
            nuevo.Enabled = False
            eliminar.Enabled = False
            modificar.Enabled = False
            Grilla_Mesas.Enabled = False
            Grilla_Mesas.ReadOnly = True
            mesa.Focus()
            mesa.Select()
            cancelar.Enabled = True
            Grilla_Mesas.Rows.RemoveAt(Grilla_Mesas.CurrentRow.Index)
        End If
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Me.Refresh()
        busc_nom.Clear()
        Mostrar_Grilla()
        Actualizacion_Tabla()
        Mostrar()
        guardar.Enabled = False
        nuevo.Enabled = True
        eliminar.Enabled = True
        modificar.Enabled = True
        busc_nom.Enabled = True
        busc_nom.ReadOnly = False
        Grilla_Mesas.Enabled = True
        Grilla_Mesas.ReadOnly = False
        cancelar.Enabled = False
        mesa.Enabled = False
        cantsillas.Enabled = False
        mesa.ReadOnly = True
        cantsillas.ReadOnly = True
        If (Me.Grilla_Mesas.Rows.Count = 0) Then
            mesa.Clear()
            cantsillas.Text = "0"
        End If
        Me.Refresh()
    End Sub
    Private Sub Grilla_Mesas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Mesas.CellContentClick
        Grilla_Mesas.ReadOnly = True
    End Sub
    Private Sub MantenedorMesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
    End Sub
    Private Sub mesa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mesa.KeyPress
        mesa.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub mesa_TextChanged(sender As Object, e As EventArgs) Handles mesa.TextChanged
        mesa.SelectionStart = mesa.Text.Length
        If Len(mesa.Text) = 4 Then
            mesa.Text = mesa.Text & " "
            mesa.SelectionStart = mesa.Text.Length
        End If
    End Sub
    Private Sub Grilla_Mesas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Mesas.CellClick
        If Me.Grilla_Mesas.Rows.Count = 0 Then
        Else
            Dato1 = Grilla_Mesas.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato2 = Grilla_Mesas.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato3 = Grilla_Mesas.CurrentRow.Cells(2).EditedFormattedValue.ToString
            id.Text = Dato1
            mesa.Text = Dato2
            cantsillas.Text = Dato3
        End If
    End Sub
    Private Sub Grilla_Mesas_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Mesas.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub mesa_KeyDown(sender As Object, e As KeyEventArgs) Handles mesa.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class