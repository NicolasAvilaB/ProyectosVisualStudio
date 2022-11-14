Public Class Nuevos_Vendedores
    Private x As Integer
    Dim valor_id As Integer
    Private y As Integer
    Private mover As Boolean
    Dim dato As String
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
    Private Sub Nuevos_Vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Lista_Vendedores_Tabla()
        nombre_vendedor.Focus()
        nombre_vendedor.Select()
        Clave_Modificar.status.Visible = False
    End Sub
    Sub Mostrar_Lista_Vendedores_Tabla()
        Consulta5("Call Mostrar_Lista_Vendedores")
        Tabla_Vend.DataSource = DS5.Tables(DT5.TableName)
        Conexion.Close()
    End Sub
    Private Sub aceptar_MouseLeave(sender As Object, e As EventArgs) Handles aceptar.MouseLeave
        aceptar.BackColor = Color.FromArgb(9, 29, 54)
        aceptar.ForeColor = Color.White
    End Sub
    Private Sub aceptar_MouseMove(sender As Object, e As MouseEventArgs) Handles aceptar.MouseMove
        aceptar.BackColor = Color.FromArgb(237, 237, 237)
        aceptar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub cancelar_MouseLeave(sender As Object, e As EventArgs) Handles cancelar.MouseLeave
        cancelar.BackColor = Color.FromArgb(9, 29, 54)
        cancelar.ForeColor = Color.White
    End Sub
    Private Sub cancelar_MouseMove(sender As Object, e As MouseEventArgs) Handles cancelar.MouseMove
        cancelar.BackColor = Color.FromArgb(237, 237, 237)
        cancelar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        nombre_vendedor.Clear()
        Me.Close()
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        nombre_vendedor.Clear()
        Me.Close()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub nombre_vendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombre_vendedor.KeyPress
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
    Sub valor_Iddd()
        Consulta5("Call GeneradorID_ListaVendedores")
        If TypeOf (DS5.Tables(DT5.TableName).Rows(0).Item("ID")) Is DBNull Then
            valor_id = 1
        Else
            valor_id = DS5.Tables(DT5.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
    End Sub
    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        If (nombre_vendedor.Text = "") Then
            MsgBox("Error: El campo del vendedor se encuentra vacio", vbCritical, "Error: Campo Vacio")
        Else
            Try
                valor_Iddd()
                Comprobador_Guardado.Show()
                Consulta5("Call Insertar_Nuevo_Vendedor_a (" & (valor_id) & ",'" & (nombre_vendedor.Text) & "')")
                Comprobador_Guardado.Close()
                MsgBox("Datos Guardados Correctamente", vbInformation, "Ingreso de Datos Exitoso")
                Mostrar_Lista_Vendedores_Tabla()
                nombre_vendedor.Clear()
                nombre_vendedor.Focus()
                nombre_vendedor.Select()
            Catch ex As Exception
                Dim a As String = Convert.ToString(ex)
                MsgBox(a, vbExclamation, "Advertencia, Posible Error")
            End Try
        End If
    End Sub
    Private Sub nombre_vendedor_TextChanged(sender As Object, e As EventArgs) Handles nombre_vendedor.TextChanged
        Dim i As Integer
        nombre_vendedor.Text = StrConv(nombre_vendedor.Text, VbStrConv.ProperCase)
        i = Len(nombre_vendedor.Text)
        nombre_vendedor.SelectionStart = i
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.FromArgb(237, 237, 237)
        cerrar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(29, 49, 74)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(29, 49, 74)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.FromArgb(237, 237, 237)
        minimizar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Private Sub Tabla_Vend_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Tabla_Vend.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If (Tabla_Vend.Rows.Count = 0) Then
            MsgBox("Advertencia: No existen vendedores a eliminar", vbExclamation, "Advertencia, No hay Vendedores")
        Else
            Try
                dato = Tabla_Vend.CurrentRow.Cells(0).EditedFormattedValue.ToString
                Comprobador_Modificador.Show()
                Consulta5("Call Eliminar_Vendedor_a ('" & (dato) & "')")
                Comprobador_Modificador.Close()
                MsgBox("Datos Eliminado Correctamente", vbInformation, "Eliminacion Exitosa")
                Mostrar_Lista_Vendedores_Tabla()
                nombre_vendedor.Focus()
                nombre_vendedor.Select()
            Catch ex As Exception
                Dim a As String = Convert.ToString(ex)
                MsgBox(a, vbExclamation, "Advertencia, Posible Error")
            End Try
        End If
    End Sub
    Private Sub eliminar_MouseMove(sender As Object, e As MouseEventArgs) Handles eliminar.MouseMove
        eliminar.BackColor = Color.FromArgb(237, 237, 237)
        eliminar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub eliminar_MouseLeave(sender As Object, e As EventArgs) Handles eliminar.MouseLeave
        eliminar.BackColor = Color.FromArgb(9, 29, 54)
        eliminar.ForeColor = Color.White
    End Sub
End Class