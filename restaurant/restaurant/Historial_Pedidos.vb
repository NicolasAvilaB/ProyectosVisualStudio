Public Class Historial_Pedidos
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Me.Close()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
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
    Private Sub filtro_Click(sender As Object, e As EventArgs) Handles filtro.Click
        Consulta22("Call FiltroFechaEntrada ('" & Inicio.Value.ToString("yyyy-MM-dd") & "','" & Termino.Value.ToString("yyyy-MM-dd") & "') ")
        Grilla_Historial.DataSource = DS22.Tables(DT22.TableName)
    End Sub
    Private Sub Historial_Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
    End Sub
    Sub Actualizacion_Tabla()
        Consulta22("Call MostrarHistorial")
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Historial.DataSource = DS22.Tables(DT22.TableName)
        Conexion.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Grilla_Historial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Historial.CellContentClick
        Grilla_Historial.ReadOnly = True
    End Sub
    Private Sub Grilla_Historial_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Historial.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub busqueda_history_TextChanged(sender As Object, e As EventArgs) Handles busqueda_history.TextChanged
        Dim i As Integer
        busqueda_history.Text = StrConv(busqueda_history.Text, VbStrConv.ProperCase)
        i = Len(busqueda_history.Text)
        busqueda_history.SelectionStart = i
        If (busqueda_history.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
        Else
            Consulta22("Call Buscar_Historial_Pedido ('" & (busqueda_history.Text & "%") & "')")
            If DS22.Tables(DT22.TableName).Rows.Count > 0 Then
                Grilla_Historial.DataSource = DS22.Tables(DT22.TableName)
            Else
                Grilla_Historial.DataSource = Nothing
            End If
        End If
    End Sub
    Private Sub busqueda_history_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda_history.KeyPress
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