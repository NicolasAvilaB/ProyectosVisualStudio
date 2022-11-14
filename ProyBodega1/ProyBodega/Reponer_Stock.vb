Public Class Reponer_Stock
    Dim Dato1, Dato2 As String
    Dim Dato3, Dato4 As String
    Dim dato5 As String
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Buscar.TextChanged
        If (Buscar.Text = "") Then
            Borrar_Grilla()
            Cantidad.Enabled = False
            Guardar.Enabled = False
            Codigo.Clear()
            nomb.Clear()
            Cantidad.Clear()
        Else
            Consulta7("Call Buscar_Reponer_Stock ('" & (Buscar.Text) & "') ")
            If DS7.Tables(DT7.TableName).Rows.Count > 0 Then
                Grilla_Stock.DataSource = DS7.Tables(DT7.TableName)
                Cantidad.Enabled = True
                Guardar.Enabled = True
                Cantidad.ReadOnly = False
                Dim Dato1, Dato2 As String
                Dato1 = Grilla_Stock.CurrentRow.Cells(0).EditedFormattedValue.ToString
                Dato2 = Grilla_Stock.CurrentRow.Cells(3).EditedFormattedValue.ToString
                dato5 = Grilla_Stock.CurrentRow.Cells(1).EditedFormattedValue.ToString
                Codigo.Text = Dato1
                Cantidad.Text = Dato2
                nomb.Text = dato5
            Else
                Cantidad.Enabled = False
                Guardar.Enabled = False
                Codigo.Clear()
                nomb.Clear()
                Cantidad.Clear()
            End If
        End If
    End Sub
    Sub Borrar_Grilla()
        Grilla_Stock.DataSource = Nothing
        Conexion.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Grilla_Stock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Stock.CellClick
        Dato1 = Grilla_Stock.CurrentRow.Cells(0).EditedFormattedValue.ToString
        Dato2 = Grilla_Stock.CurrentRow.Cells(3).EditedFormattedValue.ToString
        dato5 = Grilla_Stock.CurrentRow.Cells(1).EditedFormattedValue.ToString
        Codigo.Text = Dato1
        Cantidad.Text = Dato2
        nomb.Text = dato5
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dato3 = Grilla_Stock.CurrentRow.Cells(0).EditedFormattedValue.ToString
        Dato4 = Grilla_Stock.CurrentRow.Cells(3).EditedFormattedValue.ToString
        If (Cantidad.Text = "") Then
            MsgBox("Error: Indica Una Cantidad de Abastecimiento", vbCritical, "Error de Cantidad")
            Cantidad.Focus()
        ElseIf (Dato3 = Codigo.Text And Dato4 = Cantidad.Text) Then
            MsgBox("¡Advertencia!: No Se Hicieron Modificaciones", vbExclamation, "Datos No Modificados")
            Buscar.Clear()
        Else
            MsgBox("Cantidad Modificada Correctamente", vbInformation, "Ingreso de Stock Exitoso")
            For Each row As DataGridViewRow In Grilla_Stock.Rows
                Consulta7("Call Reponer_Stock ('" & (Cantidad.Text) & "','" & (Codigo.Text) & "')")
            Next
            Consulta7("Call Visualiza_Grilla_Stock ('" & (Buscar.Text) & "') ")
            If DS7.Tables(DT7.TableName).Rows.Count > 0 Then
                Grilla_Stock.DataSource = DS7.Tables(DT7.TableName)
                Cantidad.Enabled = True
                Guardar.Enabled = True
            End If
        End If
        Buscar.Clear()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Grilla_Stock_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Stock.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
    End Sub
    Private Sub Buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Buscar.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
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
    Private Sub Cantidad_TextChanged(sender As Object, e As EventArgs) Handles Cantidad.TextChanged
        If (Cantidad.Text = "0") Then
            SendKeys.Send("{BACKSPACE}")
        End If
    End Sub
    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Reponer_Stock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Buscar.Clear()
        Productos.codigo.Enabled = False
        Productos.preci.Enabled = False
        Productos.cantidad.Enabled = False
        Productos.categoria.Enabled = False
        Productos.codigo.ReadOnly = True
        Productos.Nombre.Enabled = False
        Productos.Nombre.ReadOnly = True
        Productos.Marca.Enabled = False
        Productos.Marca.ReadOnly = True
        Productos.preci.ReadOnly = True
        Productos.cantidad.ReadOnly = True
        Productos.categoria.ReadOnly = True
        Productos.guardar.Enabled = False
        Productos.nuevo.Enabled = True
        Productos.eliminar.Enabled = True
        Productos.modificar.Enabled = True
        Productos.busqueda_productos.Enabled = True
        Productos.busqueda_productos.ReadOnly = True
        Productos.Grilla_Productos.Enabled = True
        Productos.Grilla_Productos.ReadOnly = True
        Productos.cancelar.Enabled = False
        Productos.codigo.Enabled = False
        Productos.preci.Enabled = False
        Productos.cantidad.Enabled = False
        Productos.categoria.Enabled = False
        Productos.codigo.ReadOnly = True
        Productos.preci.ReadOnly = True
        Productos.cantidad.ReadOnly = True
        Productos.categoria.ReadOnly = True
        Productos.nuevo.Focus()
        Productos.nuevo.Select()
        Productos.Actualizacion_Tabla()
        Productos.Mostrar_Grilla()
        Productos.Mostrar()
        If (Productos.Grilla_Productos.Rows.Count = 0) Then
            Productos.codigo.Clear()
            Productos.preci.Clear()
            Productos.cantidad.Clear()
            Productos.categoria.Clear()
        End If
    End Sub
End Class