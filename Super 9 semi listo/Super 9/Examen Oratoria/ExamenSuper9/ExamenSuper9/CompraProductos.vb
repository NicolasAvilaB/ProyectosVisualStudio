Public Class CompraProductos
    Dim Dato1, Dato2 As String
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        Producto1s.Show()
    End Sub
    Sub Borrar_Grilla()
        GrillaCantidad.DataSource = Nothing
        Conexion.Close()
    End Sub

    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs) Handles Buscar.TextChanged
        If (Buscar.Text = "") Then
            Borrar_Grilla()
            Cantidad.Enabled = False
            Guardar.Enabled = False
            Nombre.Clear()
            Cantidad.Clear()
        Else
            Consulta("select productos.nombre, productos.categorias, productos.cantidad from productos where nombre Like '" & (Buscar.Text & "%") & "' ")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                GrillaCantidad.DataSource = DS.Tables(DT.TableName)
                Cantidad.Enabled = True
                Guardar.Enabled = True
                Dim Dato1, Dato2 As String
                Dato1 = GrillaCantidad.CurrentRow.Cells(0).EditedFormattedValue.ToString
                Dato2 = GrillaCantidad.CurrentRow.Cells(2).EditedFormattedValue.ToString

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

    Private Sub CompraProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GrillaCantidad_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCantidad.CellClick

        Dato1 = GrillaCantidad.CurrentRow.Cells(0).EditedFormattedValue.ToString
        Dato2 = GrillaCantidad.CurrentRow.Cells(2).EditedFormattedValue.ToString

        Nombre.Text = Dato1
        Cantidad.Text = Dato2

    End Sub

    Private Sub GrillaCantidad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCantidad.CellContentClick
       
    End Sub

    Private Sub GrillaCantidad_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaCantidad.ColumnAdded
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

    Private Sub Cantidad_TextChanged(sender As Object, e As EventArgs) Handles Cantidad.TextChanged
       
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If (Cantidad.Text = "") Then
            MsgBox("Error: Indica Una Cantidad a Comprar", vbCritical, "Error Fatal")
            Cantidad.Focus()
        ElseIf (Cantidad.Text = "0") Then
            MsgBox("Error: No Puedes Indicar una Cantidad 0, Indica Otra Cantidad", vbCritical, "Error Fatal")
            Cantidad.Clear()
            Cantidad.Focus()
        ElseIf (Cantidad.Text <= 10) Then
            MsgBox("Error: Indica un Valor Mayor a 10 Para Stock", vbCritical, "Error Fatal")
        Else
            MsgBox("Cantidad Modificada Correctamente", vbInformation, "Guardado Stock")
            For Each row As DataGridViewRow In GrillaCantidad.Rows
                Consulta("UPDATE productos SET cantidad = '" & (Cantidad.Text) & "' WHERE nombre ='" & (Nombre.Text) & "'")
            Next
           
            Consulta("select productos.nombre, productos.categorias, productos.cantidad from productos where nombre Like '" & (Buscar.Text & "%") & "' ")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                GrillaCantidad.DataSource = DS.Tables(DT.TableName)
                Cantidad.Enabled = True
                Guardar.Enabled = True
            End If
        End If
    End Sub
End Class