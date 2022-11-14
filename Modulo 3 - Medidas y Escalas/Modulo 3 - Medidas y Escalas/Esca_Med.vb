Public Class Esca_Med
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
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
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
    End Sub
    Private Sub filtrar_MouseMove(sender As Object, e As MouseEventArgs) Handles filtrar.MouseMove
        filtrar.BackColor = Color.FromArgb(0, 118, 108)
        filtrar.ForeColor = Color.White
    End Sub
    Private Sub filtrar_MouseLeave(sender As Object, e As EventArgs) Handles filtrar.MouseLeave
        filtrar.BackColor = Color.White
        filtrar.ForeColor = Color.FromArgb(0, 118, 108)
    End Sub
    Private Sub filtrar_Click(sender As Object, e As EventArgs) Handles filtrar.Click
        If (tipo_lama.Text = "" And tipo_lama.Enabled = True) Then
            Advertencia.texto.Text = "Seleccione un tipo de lama"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
        ElseIf (tipo_colores.Text = "" And tipo_colores.Enabled = True) Then
            Advertencia.texto.Text = "Seleccione un color en base a la lama"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
        ElseIf (filtros.Text = "" And tipo_colores.Enabled = False And tipo_lama.Enabled = False And producto.Enabled = False)
            Advertencia.texto.Text = "Para buscar, seleccione el filtro adecuado"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
        ElseIf (producto.Enabled = True And producto.Text = "")
            Advertencia.texto.Text = "Seleccione un producto a buscar"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
        ElseIf (producto.Enabled = True)
            Info.Show()
            Tabla.Columns.Clear()
            Try
                If (producto.Text = "TODOS LOS PRODUCTOS") Then
                    Consulta("Call Consulta_Todos_Accionamientos_y_Precios")
                    Tabla.DataSource = DS.Tables(DT.TableName)
                    Info.Close()
                Else
                    Consulta("Call Consulta_Accionamientos_y_Precios ('" & (producto.Text) & "')")
                    Tabla.DataSource = DS.Tables(DT.TableName)
                    Info.Close()
                End If
            Catch ex As Exception
                Info.Close()
                ass = Convert.ToString(ex)
                Ven_Err.texto.Text = "Posible error de operación en el programa"
                Ven_Err.texto2.Text = "para ver el error haz click en el siguiente botón"
                Ven_Err.Owner = Me
                Ven_Err.ShowDialog()
            End Try
        Else
            Tabla.Columns.Clear()
            consulta_escalas()
        End If
    End Sub
    Sub consulta_escalas()
        Info.Show()
        If (tipo_lama.Text = "LAMA 45" And tipo_colores.Text = "BLANCO, BRONCE, PLATA" And ancho.Enabled = False) Then
            Try
                Consulta("Call Mostrar_Escala1")
                Tabla.DataSource = DS.Tables(DT.TableName)
                Info.Close()
            Catch ex As Exception
                Info.Close()
                ass = Convert.ToString(ex)
                Ven_Err.texto.Text = "Posible error de operación en el programa"
                Ven_Err.texto2.Text = "para ver el error haz click en el siguiente botón"
                Ven_Err.Owner = Me
                Ven_Err.ShowDialog()
            End Try
        ElseIf (tipo_lama.Text = "LAMA 45" And tipo_colores.Text = "PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA" And ancho.Enabled = False)
            Try
                Consulta("Call Mostrar_Escala2")
                Tabla.DataSource = DS.Tables(DT.TableName)
                Info.Close()
            Catch ex As Exception
                Info.Close()
                ass = Convert.ToString(ex)
                Ven_Err.texto.Text = "Posible error de operación en el programa"
                Ven_Err.texto2.Text = "para ver el error haz click en el siguiente botón"
                Ven_Err.Owner = Me
                Ven_Err.ShowDialog()
            End Try
        ElseIf (tipo_lama.Text = "LAMA 55" And tipo_colores.Text = "BLANCO, BRONCE, PLATA" And ancho.Enabled = False)
            Try
                Consulta("Call Mostrar_Escala3")
                Tabla.DataSource = DS.Tables(DT.TableName)
                Info.Close()
            Catch ex As Exception
                Info.Close()
                ass = Convert.ToString(ex)
                Ven_Err.texto.Text = "Posible error de operación en el programa"
                Ven_Err.texto2.Text = "para ver el error haz click en el siguiente botón"
                Ven_Err.Owner = Me
                Ven_Err.ShowDialog()
            End Try
        ElseIf (tipo_lama.Text = "LAMA 55" And tipo_colores.Text = "PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA" And ancho.Enabled = False)
            Try
                Consulta("Call Mostrar_Escala4")
                Tabla.DataSource = DS.Tables(DT.TableName)
                Info.Close()
            Catch ex As Exception
                Info.Close()
                ass = Convert.ToString(ex)
                Ven_Err.texto.Text = "Posible error de operación en el programa"
                Ven_Err.texto2.Text = "para ver el error haz click en el siguiente botón"
                Ven_Err.Owner = Me
                Ven_Err.ShowDialog()
            End Try
        ElseIf (filtros.Text = "Escala Definida (ANCHO, ALTO)" And ancho.Enabled = True And tipo_lama.Text = "LAMA 45" And tipo_colores.Text = "BLANCO, BRONCE, PLATA")
            calculo_escala1_lama45_bbp()
            Info.Close()
        ElseIf (filtros.Text = "Escala Definida (ANCHO, ALTO)" And ancho.Enabled = True And tipo_lama.Text = "LAMA 45" And tipo_colores.Text = "PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
            calculo_escala2_lama45_pccgg()
            Info.Close()
        ElseIf (filtros.Text = "Escala Definida (ANCHO, ALTO)" And ancho.Enabled = True And tipo_lama.Text = "LAMA 55" And tipo_colores.Text = "BLANCO, BRONCE, PLATA")
            calculo_escala3_lama55_bbp()
            Info.Close()
        ElseIf (filtros.Text = "Escala Definida (ANCHO, ALTO)" And ancho.Enabled = True And tipo_lama.Text = "LAMA 55" And tipo_colores.Text = "PIRITA, CAFE MORO, CASCARA DE HUEVO, GOLDEN, NOGAL, GRIS ANTRAFITA")
            calculo_escala4_lama55_pccgg()
            Info.Close()
        End If
    End Sub
    Private Sub Tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellClick
        If (filtros.Text = "Escala Completa" Or filtros.Text = "Escala Definida (ANCHO, ALTO)") Then
            Try
                If (Tabla.CurrentRow.Cells(2).EditedFormattedValue.ToString() = "") Then
                    desglose.Text = "..."
                Else
                    desglose.Text = Letras(Tabla.CurrentRow.Cells(2).EditedFormattedValue.ToString())
                End If
            Catch ex As Exception
                desglose.Text = "..."
            End Try
        ElseIf (filtros.Text = "Solo Productos/Accionamientos") Then
            Try
                If (Tabla.CurrentRow.Cells(1).EditedFormattedValue.ToString() = "") Then
                    desglose.Text = "..."
                Else
                    desglose.Text = Letras(Tabla.CurrentRow.Cells(1).EditedFormattedValue.ToString())
                End If
            Catch ex As Exception
                desglose.Text = "..."
            End Try
        End If
    End Sub
    Private Sub Tabla_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Tabla.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Tabla_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellEnter
        If (filtros.Text = "Escala Completa" Or filtros.Text = "Escala Definida (ANCHO, ALTO)") Then
            Try
                If (Tabla.CurrentRow.Cells(2).EditedFormattedValue.ToString() = "") Then
                    desglose.Text = "..."
                Else
                    desglose.Text = Letras(Tabla.CurrentRow.Cells(2).EditedFormattedValue.ToString())
                End If
            Catch ex As Exception
                desglose.Text = "..."
            End Try
        ElseIf (filtros.Text = "Solo Productos/Accionamientos") Then
            Try
                If (Tabla.CurrentRow.Cells(1).EditedFormattedValue.ToString() = "") Then
                    desglose.Text = "..."
                Else
                    desglose.Text = Letras(Tabla.CurrentRow.Cells(1).EditedFormattedValue.ToString())
                End If
            Catch ex As Exception
                desglose.Text = "..."
            End Try
        End If
    End Sub
    Private Sub ancho_LostFocus(sender As Object, e As EventArgs) Handles ancho.LostFocus
        If (ancho.Text = "") Then
            ancho.Text = "0001"
        End If
        If (Len(ancho.Text) < 4) Then
            ancho.Text = "0001"
        End If
        If (ancho.Text = "0000") Then
            ancho.Text = "0001"
        End If
    End Sub
    Private Sub alto_LostFocus(sender As Object, e As EventArgs) Handles alto.LostFocus
        If (alto.Text = "") Then
            alto.Text = "0001"
        End If
        If (Len(alto.Text) < 4) Then
            alto.Text = "0001"
        End If
        If (alto.Text = "0000") Then
            alto.Text = "0001"
        End If
    End Sub
    Private Sub ancho_TextChanged(sender As Object, e As EventArgs) Handles ancho.TextChanged
        If (ancho.Text > "4500" And tipo_lama.Text = "LAMA 45") Then
            ancho.Text = "4500"
        ElseIf (ancho.Text > "5800" And tipo_lama.Text = "LAMA 55") Then
            ancho.Text = "5800"
        End If
        If (alto.Text > "4500" And tipo_lama.Text = "LAMA 45") Then
            alto.Text = "4500"
        ElseIf (alto.Text > "5800" And tipo_lama.Text = "LAMA 55") Then
            alto.Text = "5800"
        End If
    End Sub
    Private Sub tipo_lama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipo_lama.SelectedIndexChanged
        If (ancho.Text > "4500" And tipo_lama.Text = "LAMA 45") Then
            ancho.Text = "4500"
        ElseIf (ancho.Text > "5800" And tipo_lama.Text = "LAMA 55") Then
            ancho.Text = "5800"
        End If
        If (alto.Text > "4500" And tipo_lama.Text = "LAMA 45") Then
            alto.Text = "4500"
        ElseIf (alto.Text > "5800" And tipo_lama.Text = "LAMA 55") Then
            alto.Text = "5800"
        End If
    End Sub
    Private Sub filtros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtros.SelectedIndexChanged
        If (filtros.Text = "Escala Definida (ANCHO, ALTO)") Then
            ancho.Enabled = True
            alto.Enabled = True
            ancho.ReadOnly = False
            alto.ReadOnly = False
            tipo_lama.Enabled = True
            tipo_colores.Enabled = True
            producto.Enabled = False
            tipo_colores.SelectedIndex = -1
            tipo_lama.SelectedIndex = -1
            producto.SelectedIndex = -1
            ancho.Text = "0001"
            alto.Text = "0001"
            Tabla.Columns.Clear()
            Tabla.Columns.Add("Resultados de Busqueda...", Nothing)
            Tabla.DataSource = Nothing
        ElseIf (filtros.Text = "Escala Completa")
            ancho.Enabled = False
            alto.Enabled = False
            ancho.ReadOnly = True
            alto.ReadOnly = True
            ancho.Text = "0001"
            alto.Text = "0001"
            tipo_lama.Enabled = True
            tipo_colores.Enabled = True
            producto.Enabled = False
            tipo_colores.SelectedIndex = -1
            tipo_lama.SelectedIndex = -1
            producto.SelectedIndex = -1
            Tabla.Columns.Clear()
            Tabla.Columns.Add("Resultados de Busqueda...", Nothing)
            Tabla.DataSource = Nothing
        ElseIf (filtros.Text = "Solo Productos/Accionamientos")
            ancho.Enabled = False
            alto.Enabled = False
            ancho.ReadOnly = True
            alto.ReadOnly = True
            ancho.Text = "0001"
            alto.Text = "0001"
            tipo_lama.Enabled = False
            tipo_colores.Enabled = False
            producto.Enabled = True
            tipo_colores.SelectedIndex = -1
            tipo_lama.SelectedIndex = -1
            producto.SelectedIndex = -1
            Tabla.Columns.Clear()
            Tabla.Columns.Add("Resultados de Busqueda...", Nothing)
            Tabla.DataSource = Nothing
        End If
    End Sub

    Private Sub Tabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellContentClick

    End Sub
End Class
