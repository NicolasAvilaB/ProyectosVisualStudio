Public Class Historial_Stock
    Dim Vall1 As Integer
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Bodega_User.Actualizacion_Tabla()
        Bodega_User.Mostrar_Grilla()
    End Sub
    Sub Actualizacion_Tabla()
        Consulta8("Call Grilla_Historial_Entrada")
    End Sub
    Sub Mostrar_Grilla()
        Grilla_History.DataSource = DS8.Tables(DT8.TableName)
        Conexion.Close()
    End Sub
    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        busqueda_history.Clear()
        bscn.Clear()
        Me.Close()
        Reponer_Stock.Buscar_Articulo_Nom.Focus()
        Reponer_Stock.Buscar_Articulo_Nom.Select()
    End Sub
    Private Sub filtro_Click(sender As Object, e As EventArgs) Handles filtro.Click
        Consulta8("Call FiltraFecha_Entrada ('" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "') ")
        Grilla_History.DataSource = DS8.Tables(DT8.TableName)
    End Sub
    Private Sub Grilla_History_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_History.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Sub Actualizacion_Tabla2()
        Consulta13("Call Grilla_Historial_Mod")
    End Sub
    Sub Mostrar_Grilla2()
        grll.DataSource = DS13.Tables(DT13.TableName)
        Conexion.Close()
    End Sub
    Private Sub History_Compr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        busqueda_history.Focus()
        busqueda_history.Select()
        Actualizacion_Tabla()
        Actualizacion_Tabla2()
        Mostrar_Grilla()
        Mostrar_Grilla2()
        Vall1 = 0
        Precio.Enabled = True
        Precio.Interval = 50
    End Sub
    Private Sub Precio_Tick(sender As Object, e As EventArgs) Handles Precio.Tick
        If Me.Grilla_History.Rows.Count = 0 Then
            cant.Text = "0"
        Else
            Vall1 = Vall1 + 1
            Dim suma As Integer = 0.0
            Dim suma2 As Integer = 0.0
            For Each row As DataGridViewRow In Grilla_History.Rows
                suma2 += Val(row.Cells(6).Value)
            Next
            cant.Text = Convert.ToInt64(suma2)
        End If
        If Me.grll.Rows.Count = 0 Then
            cntt.Text = "0"
        Else
            Vall1 = Vall1 + 1
            Dim suma As Integer = 0.0
            Dim suma3 As Integer = 0.0
            For Each row As DataGridViewRow In grll.Rows
                suma3 += Val(row.Cells(5).Value)
            Next
            cntt.Text = Convert.ToInt64(suma3)
        End If
    End Sub
    Private Sub busqueda_history_TextChanged_1(sender As Object, e As EventArgs) Handles busqueda_history.TextChanged
        Dim i As Integer
        busqueda_history.Text = StrConv(busqueda_history.Text, VbStrConv.ProperCase)
        i = Len(busqueda_history.Text)
        busqueda_history.SelectionStart = i
        If (busqueda_history.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
        Else
            Consulta8("Call Buscar_Entrada ('" & (busqueda_history.Text & "%") & "')")
            If DS8.Tables(DT8.TableName).Rows.Count > 0 Then
                Grilla_History.DataSource = DS8.Tables(DT8.TableName)
            Else
                Grilla_History.DataSource = Nothing
            End If
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
    Private Sub Label8_MouseMove(sender As Object, e As MouseEventArgs) Handles Label8.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Label8_MouseUp(sender As Object, e As MouseEventArgs) Handles Label8.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Label8_MouseDown(sender As Object, e As MouseEventArgs) Handles Label8.MouseDown
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
    Private Sub History_Compr_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        busqueda_history.Clear()
    End Sub
    Private Sub vl_Click(sender As Object, e As EventArgs) Handles vl.Click
        busqueda_history.Clear()
        bscn.Clear()
        Me.Close()
        Reponer_Stock.Buscar_Articulo_Nom.Focus()
        Reponer_Stock.Buscar_Articulo_Nom.Select()
    End Sub
    Private Sub fl_Click(sender As Object, e As EventArgs) Handles fl.Click
        Consulta13("Call FiltrarFecha_Comp_Mod_Stock ('" & dt11.Value.ToString("yyyy-MM-dd") & "','" & dt22.Value.ToString("yyyy-MM-dd") & "') ")
        grll.DataSource = DS13.Tables(DT13.TableName)
    End Sub
    Private Sub bscn_TextChanged(sender As Object, e As EventArgs) Handles bscn.TextChanged
        If (bscn.Text = "") Then
            Actualizacion_Tabla2()
            Mostrar_Grilla2()
        Else
            Consulta13("Call Buscar_Mod_Comp_Stock ('" & (bscn.Text & "%") & "')")
            If DS13.Tables(DT13.TableName).Rows.Count > 0 Then
                grll.DataSource = DS13.Tables(DT13.TableName)
            Else
                grll.DataSource = Nothing
            End If
        End If
    End Sub
    Private Sub bscn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bscn.KeyPress
        bscn.CharacterCasing = CharacterCasing.Upper
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub busqueda_history_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda_history.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub grll_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles grll.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Impresion_HistorialInsertoArticulos.Owner = Me
        Impresion_HistorialInsertoArticulos.ShowDialog()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Impresion_HistorialModArticulos.Owner = Me
        Impresion_HistorialModArticulos.ShowDialog()
    End Sub
End Class