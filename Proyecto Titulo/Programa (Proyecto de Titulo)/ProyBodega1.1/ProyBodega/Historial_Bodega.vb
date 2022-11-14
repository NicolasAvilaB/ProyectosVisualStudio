Public Class Historial_Bodega
    Dim Vall1 As Integer
    Dim Vall2 As Integer
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Dim Dato0 As String
    Private Sub Historial_Bodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        busqueda_salida.Focus()
        busqueda_salida.select()
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
        Vall1 = 0
        Vall2 = 0
        Cantid1.Enabled = True
        Cantid1.Interval = 50
    End Sub
    Sub Actualizacion_Tabla()
        Consulta5("Call Grilla_Historial_Egreso")
    End Sub
    Sub Mostrar()
        If (Grilla_History.Rows.Count = 0) Then
            Descripcio.Text = Nothing
        Else
            Dato0 = Grilla_History.CurrentRow.Cells(10).EditedFormattedValue.ToString
            Descripcio.Text = Dato0
        End If
    End Sub
    Sub Mostrar_Grilla()
        Grilla_History.DataSource = DS5.Tables(DT5.TableName)
        Conexion.Close()
    End Sub
    Private Sub atras_Click(sender As Object, e As EventArgs)
        busqueda_salida.Clear()
        Me.Close()
    End Sub
    Private Sub filtro_Click(sender As Object, e As EventArgs)
        Consulta5("Call Filtro_Fecha_Salida ('" & DateTimePicker4.Value.ToString("yyyy-MM-dd") & "','" & DateTimePicker3.Value.ToString("yyyy-MM-dd") & "') ")
        Grilla_History.DataSource = DS5.Tables(DT5.TableName)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Cantid1_Tick(sender As Object, e As EventArgs) Handles Cantid1.Tick
        If Me.Grilla_History.Rows.Count = 0 Then
            cant2.Text = "0"
        Else
            Vall2 = Vall2 + 1
            Dim suma2 As Integer = 0.0
            For Each row1 As DataGridViewRow In Grilla_History.Rows
                suma2 += Val(row1.Cells(6).Value)
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
    Private Sub Historial_Bodega_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        busqueda_salida.Clear()
    End Sub

    Private Sub busqueda_prestados_TextChanged(sender As Object, e As EventArgs) Handles busqueda_salida.TextChanged
        Dim i As Integer
        busqueda_salida.Text = StrConv(busqueda_salida.Text, VbStrConv.ProperCase)
        i = Len(busqueda_salida.Text)
        busqueda_salida.SelectionStart = i
        If (busqueda_salida.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
        Else
            Consulta5("Call Busque_Nombre_Salida ('" & (busqueda_salida.Text & "%") & "')")
            If DS5.Tables(DT5.TableName).Rows.Count > 0 Then
                Grilla_History.DataSource = DS5.Tables(DT5.TableName)
            Else
                Descripcio.Text = Nothing
                Grilla_History.DataSource = Nothing
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        busqueda_salida.Clear()
        Bodega_User.busqueda_nombr.Clear()
    End Sub
    Private Sub busqueda_salida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda_salida.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
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
    Private Sub Grilla_History_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_History.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Grilla_History_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_History.CellClick
        Mostrar()
        If Me.Grilla_History.Rows.Count = 0 Then
            Descripcio.Clear()
        End If
    End Sub
    Private Sub Grilla_History_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_History.CellEnter
        Mostrar()
        If Me.Grilla_History.Rows.Count = 0 Then
            Descripcio.Clear()
        End If
    End Sub
    Private Sub Descripcio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Descripcio.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub impr_Click(sender As Object, e As EventArgs) Handles impr.Click
        Impresion_HistorialSalida.Owner = Me
        Impresion_HistorialSalida.ShowDialog()
    End Sub
End Class