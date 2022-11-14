Public Class Historial_Bodega
    Dim Vall1 As Integer
    Dim Vall2 As Integer
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub Historial_Bodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Actualizacion_Tabla_Prestamos()
        Mostrar_Grilla()
        Mostrar_Grilla_Prestamos()
        Vall1 = 0
        Vall2 = 0
        Cantid.Enabled = True
        Cantid.Interval = 50
        Cantid1.Enabled = True
        Cantid1.Interval = 50
    End Sub
    Sub Actualizacion_Tabla()
        Consulta4("Call VisualizaGrillaHistorialStock")
    End Sub
    Sub Actualizacion_Tabla_Prestamos()
        Consulta5("Call VisualizaGrillaPrestados")
    End Sub
    Sub Mostrar_Grilla()
        Grilla_History.DataSource = DS4.Tables(DT4.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar_Grilla_Prestamos()
        Grilla_History_Prestamos.DataSource = DS5.Tables(DT5.TableName)
        Conexion.Close()
    End Sub
    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
    End Sub
    Private Sub filtro_Click(sender As Object, e As EventArgs) Handles filtro.Click
        Consulta4("Call Filtro_Fecha ('" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "') ")
        Grilla_History.DataSource = DS4.Tables(DT4.TableName)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Grilla_History_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_History.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub busqueda_productos_TextChanged(sender As Object, e As EventArgs) Handles busqueda_history.TextChanged
        If (busqueda_history.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
        Else
            Consulta4("Call Busqueda_Codigo ('" & (busqueda_history.Text) & "')")
            If DS4.Tables(DT4.TableName).Rows.Count > 0 Then
                Grilla_History.DataSource = DS4.Tables(DT4.TableName)
            Else
                Grilla_History.DataSource = Nothing
            End If
        End If
    End Sub
    Private Sub Cantid_Tick(sender As Object, e As EventArgs) Handles Cantid.Tick
        If Me.Grilla_History.Rows.Count = 0 Then
            cant.Text = "0"
        Else
            Vall1 = Vall1 + 1
            Dim suma As Integer = 0.0

            For Each row As DataGridViewRow In Grilla_History.Rows
                suma += Val(row.Cells(3).Value)
            Next
            cant.Text = Convert.ToInt64(suma)
        End If
    End Sub
    Private Sub Grilla_History_Prestamos_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_History_Prestamos.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Filtro1.Click
        Consulta5("Call Filtro_Fecha_Prestamos ('" & DateTimePicker4.Value.ToString("yyyy-MM-dd") & "','" & DateTimePicker3.Value.ToString("yyyy-MM-dd") & "') ")
        Grilla_History_Prestamos.DataSource = DS5.Tables(DT5.TableName)
    End Sub
    Private Sub busqueda_prestados_TextChanged(sender As Object, e As EventArgs) Handles busqueda_prestados.TextChanged
        If (busqueda_prestados.Text = "") Then
            Actualizacion_Tabla_Prestamos()
            Mostrar_Grilla_Prestamos()
        Else
            Consulta5("Call Busque_Codigo_Prestamos ('" & (busqueda_prestados.Text) & "')")
            If DS5.Tables(DT5.TableName).Rows.Count > 0 Then
                Grilla_History_Prestamos.DataSource = DS5.Tables(DT5.TableName)
            Else
                Grilla_History_Prestamos.DataSource = Nothing
            End If
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Cantid1_Tick(sender As Object, e As EventArgs) Handles Cantid1.Tick
        If Me.Grilla_History_Prestamos.Rows.Count = 0 Then
            cant2.Text = "0"
        Else
            Vall2 = Vall2 + 1
            Dim suma2 As Integer = 0.0
            For Each row1 As DataGridViewRow In Grilla_History_Prestamos.Rows
                suma2 += Val(row1.Cells(3).Value)
            Next
            cant2.Text = Convert.ToInt64(suma2)
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
    Private Sub busqueda_prestados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda_prestados.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub
    Private Sub busqueda_history_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda_history.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub
    Private Sub Historial_Bodega_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        busqueda_history.Clear()
        busqueda_prestados.Clear()
    End Sub
End Class