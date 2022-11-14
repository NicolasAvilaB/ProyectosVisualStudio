Public Class Devo_Stock
    Dim Dato1, Dato2 As String

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        EmitirBoletas.Show()
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
                Dim Dato1 As String
                Dato1 = GrillaCantidad.CurrentRow.Cells(0).EditedFormattedValue.ToString


                Nombre.Text = Dato1

            Else
                Cantidad.Enabled = False
                Guardar.Enabled = False
                Nombre.Clear()
                Cantidad.Clear()
            End If
        End If
    End Sub
    Private Sub GrillaCantidad_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCantidad.CellClick
        Dato1 = GrillaCantidad.CurrentRow.Cells(0).EditedFormattedValue.ToString


        Nombre.Text = Dato1
        Cantidad.Focus()
        Cantidad.Select()

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If (Cantidad.Text = "") Then
            MsgBox("Error: Indica Una Cantidad a Devolver", vbCritical, "Error Fatal")
            Cantidad.Focus()
        ElseIf (Cantidad.Text = "0") Then
            MsgBox("Error: No Puedes Indicar una Cantidad 0, Indica Otra Cantidad", vbCritical, "Error Fatal")
            Cantidad.Clear()
            Cantidad.Focus()
        Else
            MsgBox("Cantidad Modificada Correctamente", vbInformation, "Devuelto a Stock")
            For Each row As DataGridViewRow In GrillaCantidad.Rows
                Consulta("UPDATE productos SET cantidad = cantidad + '" & (Cantidad.Text) & "' WHERE nombre ='" & (Nombre.Text) & "'")
            Next

            Consulta("select productos.nombre, productos.categorias, productos.cantidad from productos where nombre Like '" & (Buscar.Text & "%") & "' ")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                GrillaCantidad.DataSource = DS.Tables(DT.TableName)
                Cantidad.Enabled = True
                Guardar.Enabled = True
            End If
            Buscar.Clear()
            Cantidad.Clear()
            Buscar.Focus()
            Buscar.Select()
        End If
    End Sub

    Private Sub Devo_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


        If e.KeyChar = ChrW(Keys.Enter) Then 'Boton Enter
            e.Handled = True

            If (Cantidad.Text = "") Then
                MsgBox("Error: Indica Una Cantidad a Devolver", vbCritical, "Error Fatal")
                Cantidad.Focus()
            ElseIf (Cantidad.Text = "0") Then
                MsgBox("Error: No Puedes Indicar una Cantidad 0, Indica Otra Cantidad", vbCritical, "Error Fatal")
                Cantidad.Clear()
                Cantidad.Focus()
            Else
                MsgBox("Cantidad Modificada Correctamente", vbInformation, "Devuelto a Stock")
                For Each row As DataGridViewRow In GrillaCantidad.Rows
                    Consulta("UPDATE productos SET cantidad = cantidad + '" & (Cantidad.Text) & "' WHERE nombre ='" & (Nombre.Text) & "'")
                Next

                Consulta("select productos.nombre, productos.categorias, productos.cantidad from productos where nombre Like '" & (Buscar.Text & "%") & "' ")
                If DS.Tables(DT.TableName).Rows.Count > 0 Then
                    GrillaCantidad.DataSource = DS.Tables(DT.TableName)
                    Cantidad.Enabled = True
                    Guardar.Enabled = True
                End If
                Buscar.Clear()
                Cantidad.Clear()
                Buscar.Focus()
                Buscar.Select()
            End If
        End If
    End Sub
End Class