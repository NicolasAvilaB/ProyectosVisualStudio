Public Class Reponer_Stock
    Dim Dato1, Dato2 As String
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Buscar.TextChanged
        If (Buscar.Text = "") Then
            Borrar_Grilla()
            Cantidad.Enabled = False
            Guardar.Enabled = False
            Nombre.Clear()
            Cantidad.Clear()
        Else
            Consulta7("select articulos.Codigo, articulos.Categoria, articulos.Cantidad from articulos where Codigo ='" & (Buscar.Text) & "' ")
            If DS7.Tables(DT7.TableName).Rows.Count > 0 Then
                Grilla_Stock.DataSource = DS7.Tables(DT7.TableName)
                Cantidad.Enabled = True
                Guardar.Enabled = True
                Cantidad.ReadOnly = False
                Dim Dato1, Dato2 As String
                Dato1 = Grilla_Stock.CurrentRow.Cells(0).EditedFormattedValue.ToString
                Dato2 = Grilla_Stock.CurrentRow.Cells(2).EditedFormattedValue.ToString
                Nombre.Text = Dato1
                Cantidad.Text = Dato2
            Else
                Cantidad.Enabled = False
                Guardar.Enabled = False
                Nombre.Clear()
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
        Buscar.Clear()
        Productos.Actualizacion_Tabla()
        Productos.Mostrar_Grilla()
        Productos.Mostrar()
    End Sub
    Private Sub Grilla_Stock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Stock.CellClick
        Dato1 = Grilla_Stock.CurrentRow.Cells(0).EditedFormattedValue.ToString
        Dato2 = Grilla_Stock.CurrentRow.Cells(2).EditedFormattedValue.ToString
        Nombre.Text = Dato1
        Cantidad.Text = Dato2
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If (Cantidad.Text = "") Then
            MsgBox("Error: Indica Una Cantidad de Abastecimiento", vbCritical, "Error de Cantidad")
            Cantidad.Focus()
        ElseIf (Cantidad.Text = "0") Then
            MsgBox("Error: No Puedes Indicar una Cantidad 0, Indica Otra Cantidad", vbCritical, "Error de Cantidad")
            Cantidad.Clear()
            Cantidad.Focus()
        ElseIf (Cantidad.Text <= 10) Then
            MsgBox("Error: Indica un Valor Mayor a 10 Para Stock", vbCritical, "Error de Cantidad")
        Else
            MsgBox("Cantidad Modificada Correctamente", vbInformation, "Stock Ingresado")
            For Each row As DataGridViewRow In Grilla_Stock.Rows
                Consulta7("Call Reponer_Stock ('" & (Cantidad.Text) & "','" & (Nombre.Text) & "')")
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
        Buscar.Clear()
        Productos.Actualizacion_Tabla()
        Productos.Mostrar_Grilla()
        Productos.Mostrar()
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
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    End Sub
    Private Sub Buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Buscar.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
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
    Private Sub Reponer_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
End Class