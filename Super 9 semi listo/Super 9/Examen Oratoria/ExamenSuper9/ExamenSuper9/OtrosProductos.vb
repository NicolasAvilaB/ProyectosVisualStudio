Public Class OtrosProductos
    Dim u As String
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Sub Borrar_Grilla()
        GrillaOtros.DataSource = Nothing
        Conexion.Close()
    End Sub
    Private Sub OtrosProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buscar.Focus()
        Buscar.Select()
    End Sub

    Private Sub GrillaOtros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaOtros.CellClick
        
      


    End Sub

    Private Sub GrillaOtros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaOtros.CellContentClick
       
      
    End Sub

    Private Sub Buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Buscar.KeyPress



    End Sub

    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs) Handles Buscar.TextChanged
        If (Buscar.Text = "") Then
            Borrar_Grilla()

        Else
            Consulta("select * from productos where categorias = 'Otros' and nombre Like '" & (Buscar.Text & "%") & "' ")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                GrillaOtros.DataSource = DS.Tables(DT.TableName)
            
            End If
        End If
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
    End Sub

    Private Sub GrillaOtros_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaOtros.CellDoubleClick


        If (Buscar.Text = "") Then
            MsgBox("Error: Primero Escribe el Nombre del Producto a Buscar", vbCritical, "Error Fatal")
            Buscar.Focus()
        Else

            Dim row As DataGridViewRow = GrillaOtros.Rows(e.RowIndex)

            EmitirBoletas.Productos_Pasados.Rows.Add(Val(row.Cells(0).Value), CStr(row.Cells("nombre").Value), Val(row.Cells(2).Value), "1")
            EmitirBoletas.Productos_Pasados.CurrentCell = EmitirBoletas.Productos_Pasados.Rows(EmitirBoletas.Productos_Pasados.RowCount - 1).Cells(0)
            EmitirBoletas.Productos_Pasados.Refresh()
            Buscar.Clear()
            EmitirBoletas.Agregue_Productos.Focus()
            EmitirBoletas.Agregue_Productos.Select()
            Me.Close()



        End If
        EmitirBoletas.Agregue_Productos.Focus()
    End Sub

    Private Sub GrillaOtros_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaOtros.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class