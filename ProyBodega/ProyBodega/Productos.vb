Public Class Productos
    Dim Dato0, Dato1, Dato2, Dato3, Dato4 As String
    Dim VarSeleccion As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles regresar.Click
        Me.Close()
        Administrador.Mostrar_Grilla()
        Administrador.Actualizacion_Tabla()
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        VarSeleccion = 1
        codigo.Enabled = True
        preci.Enabled = True
        cantidad.Enabled = True
        categoria.Enabled = True
        codigo.ReadOnly = False
        preci.ReadOnly = False
        cantidad.ReadOnly = False
        categoria.ReadOnly = False
        guardar.Enabled = True
        busqueda_productos.Enabled = False
        busqueda_productos.ReadOnly = True
        guardar.Enabled = True
        nuevo.Enabled = False
        eliminar.Enabled = False
        modificar.Enabled = False
        Grilla_Productos.Enabled = False
        Grilla_Productos.ReadOnly = True
        codigo.Clear()
        cantidad.Clear()
        categoria.Clear()
        preci.Clear()
        codigo.Focus()
        codigo.Select()
        cancelar.Enabled = True
        SendKeys.Send("{BACKSPACE}")
        nuevo.Focus()
        nuevo.Select()
        Consulta2("Call GeneradorIDautomatico4")
        If TypeOf (DS2.Tables(DT2.TableName).Rows(0).Item("Id")) Is DBNull Then
            Label8.Text = 1
        Else
            Label8.Text = DS2.Tables(DT2.TableName).Rows(0).Item("Id") + 1
            Conexion.Close()
        End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
    End Sub
    Sub Actualizacion_Tabla()
        Consulta2("Call Grilla_Productos")
    End Sub
    Sub Mostrar()
        If (DS2.Tables(DT2.TableName).Rows.Count > 0) Then
            Dato0 = Grilla_Productos.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato1 = Grilla_Productos.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato2 = Grilla_Productos.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato3 = Grilla_Productos.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Dato4 = Grilla_Productos.CurrentRow.Cells(4).EditedFormattedValue.ToString
            Label8.Text = Dato0
            codigo.Text = Dato1
            preci.Text = Dato2
            cantidad.Text = Dato3
            categoria.Text = Dato4
        Else
            Label8.Text = "0"
            codigo.Clear()
            preci.Clear()
            cantidad.Clear()
            categoria.Clear()
        End If
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Productos.DataSource = DS2.Tables(DT2.TableName)
        Conexion.Close()
    End Sub
    Private Sub busqueda_productos_TextChanged(sender As Object, e As EventArgs) Handles busqueda_productos.TextChanged
        If (busqueda_productos.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
        Else
            Consulta2("Call Busqueda_Code ('" & (busqueda_productos.Text) & "')")
            If DS2.Tables(DT2.TableName).Rows.Count > 0 Then
                Grilla_Productos.DataSource = DS2.Tables(DT2.TableName)
                Mostrar()
            Else
                Label8.Text = "0"
                codigo.Clear()
                preci.Clear()
                categoria.Clear()
                cantidad.Clear()
            End If
        End If
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        If (codigo.Text = "") Then
            MsgBox("Error: No se ha Describido un Codigo Valido", vbCritical, "¡Error, Codigo no Descrito!")
            codigo.Focus()
            codigo.Select()
            'codigo.Clear()
            ' cantidad.Clear()
            'categoria.Clear()
        ElseIf (preci.Text = "") Then
            MsgBox("Error: No se ha Describido un Precio de Articulos Validos", vbCritical, "¡Error, Precio no Descrito!")
            preci.Focus()
            preci.Select()
        ElseIf (cantidad.Text = "") Then
            MsgBox("Error: No se ha Describido una Cantidad de Articulos Validos", vbCritical, "¡Error, Cantidad no Descrita!")
            cantidad.Focus()
            cantidad.Select()
            'codigo.Clear()
            'cantidad.Clear()
            'categoria.Clear()
        ElseIf (categoria.Text = "") Then
            MsgBox("Error: No existe una Categoria Escrita aun", vbCritical, "¡Error, Categoria no Especificada!")
            categoria.Focus()
            categoria.Select()
            'codigo.Clear()
            'cantidad.Clear()
            ' categoria.Clear()
        Else
            Consulta2("Call Valide_Arti ('" & (codigo.Text) & "')")
            If DS2.Tables(DT2.TableName).Rows.Count > 0 Then
                MsgBox("Error: El Codigo: " + codigo.Text + " Ya Pertenece a un Articulo", vbCritical, "Error de Codigo")
                Actualizacion_Tabla()
                Mostrar_Grilla()
                codigo.Focus()
                codigo.Select()
                codigo.Clear()
            ElseIf VarSeleccion = 1 Then
                Try
                    Consulta2("Call Ingreso_Articulo ('" & (Label8.Text) & "','" & (codigo.Text) & "','" & (preci.Text) & "','" & (cantidad.Text) & "','" & (categoria.Text) & "')")
                    MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                    codigo.Enabled = False
                    preci.Enabled = False
                    cantidad.Enabled = False
                    categoria.Enabled = False
                    codigo.ReadOnly = True
                    preci.ReadOnly = True
                    cantidad.ReadOnly = True
                    categoria.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    modificar.Enabled = True
                    busqueda_productos.Enabled = True
                    busqueda_productos.ReadOnly = False
                    Grilla_Productos.Enabled = True
                    Grilla_Productos.ReadOnly = False
                    cancelar.Enabled = False
                    codigo.Enabled = False
                    preci.Enabled = False
                    cantidad.Enabled = False
                    categoria.Enabled = False
                    codigo.ReadOnly = True
                    preci.ReadOnly = True
                    cantidad.ReadOnly = True
                    categoria.ReadOnly = True
                    nuevo.Focus()
                    nuevo.Select()
                Catch ex As Exception
                    DA2.SelectCommand = SC2
                    DA2.Fill(DT2)
                End Try
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
            ElseIf VarSeleccion = 2 Then
                Try
                    Consulta2("update articulos set Codigo='" & (codigo.Text) & "',Precio=" & (preci.Text) & ",Categoria='" & (categoria.Text) & "'where Id=" & (Dato0) & "")
                    MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                    codigo.Enabled = False
                    preci.Enabled = False
                    categoria.Enabled = False
                    codigo.ReadOnly = True
                    preci.ReadOnly = True
                    categoria.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    modificar.Enabled = True
                    busqueda_productos.Enabled = True
                    busqueda_productos.ReadOnly = False
                    Grilla_Productos.Enabled = True
                    Grilla_Productos.ReadOnly = False
                    cancelar.Enabled = False
                    codigo.Enabled = False
                    preci.Enabled = False
                    categoria.Enabled = False
                    codigo.ReadOnly = True
                    preci.ReadOnly = True
                    categoria.ReadOnly = True
                    nuevo.Focus()
                    nuevo.Select()
                Catch ex As Exception
                    DA2.SelectCommand = SC2
                    DA2.Fill(DT2)
                End Try
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
            End If
        End If
    End Sub
    Private Sub Grilla_Productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Productos.CellContentClick
        Grilla_Productos.ReadOnly = True
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If Me.Grilla_Productos.Rows.Count = 0 Then
            MsgBox("Error: No hay Articulos existentes a eliminar", vbCritical, "Error, No hay Articulos")
            codigo.Focus()
            codigo.Select()
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro El Siguiente Codigo: " + codigo.Text + " ?", vbYesNo + vbQuestion, "¿Eliminar Codigo?")
            If valormensaje = vbYes Then
                Consulta2("Call EliminarProducto ('" & (codigo.Text) & "')")
                MsgBox("El Codigo: '" + codigo.Text + "' Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                busqueda_productos.Clear()
                nuevo.Focus()
                nuevo.Select()
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                nuevo.Focus()
                nuevo.Select()
            End If
            Actualizacion_Tabla()
            If DS2.Tables(DT2.TableName).Rows.Count > 0 Then
                Mostrar()
            Else
                Label8.Text = "0"
                codigo.Clear()
                preci.Clear()
                cantidad.Clear()
                categoria.Clear()
            End If
            If Me.Grilla_Productos.Rows.Count = 0 Then
                eliminar.Enabled = False
            Else
                eliminar.Enabled = True
            End If
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
            nuevo.Focus()
            nuevo.Select()
            nuevo.Focus()
            nuevo.Select()
        End If
    End Sub
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
        If Me.Grilla_Productos.Rows.Count = 0 Then
            eliminar.Enabled = False
        Else
            eliminar.Enabled = True
        End If
    End Sub
    Private Sub Grilla_Productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Productos.CellClick
        If Me.Grilla_Productos.Rows.Count = 0 Then
        Else
            Mostrar()
        End If
    End Sub
    Private Sub categoria_TextChanged(sender As Object, e As EventArgs) Handles categoria.TextChanged
        Dim i As Integer
        categoria.Text = StrConv(categoria.Text, VbStrConv.ProperCase)
        i = Len(categoria.Text)
        categoria.SelectionStart = i
    End Sub
    Private Sub busqueda_productos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda_productos.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub
    Private Sub cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            categoria.Focus()
            categoria.Select()
        End If
    End Sub
    Private Sub Grilla_Productos_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Productos.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        codigo.Enabled = False
        preci.Enabled = False
        cantidad.Enabled = False
        categoria.Enabled = False
        codigo.ReadOnly = True
        preci.ReadOnly = True
        cantidad.ReadOnly = True
        categoria.ReadOnly = True
        guardar.Enabled = False
        nuevo.Enabled = True
        eliminar.Enabled = True
        modificar.Enabled = True
        busqueda_productos.Enabled = True
        busqueda_productos.ReadOnly = True
        Grilla_Productos.Enabled = True
        Grilla_Productos.ReadOnly = False
        cancelar.Enabled = False
        codigo.Enabled = False
        preci.Enabled = False
        cantidad.Enabled = False
        categoria.Enabled = False
        codigo.ReadOnly = True
        preci.ReadOnly = True
        cantidad.ReadOnly = True
        categoria.ReadOnly = True
        nuevo.Focus()
        nuevo.Select()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Administrador.Mostrar_Grilla()
        Administrador.Actualizacion_Tabla()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Reponer_Stock.Owner = Me
        Reponer_Stock.ShowDialog()
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        If Me.Grilla_Productos.Rows.Count = 0 Then
            MsgBox("Error: No hay Articulos existentes a Modificar", vbCritical, "Error, No hay Articulos")
            nuevo.Focus()
            nuevo.Select()
        Else
            VarSeleccion = 2
            codigo.Enabled = True
            categoria.Enabled = True
            preci.Enabled = True
            codigo.ReadOnly = False
            categoria.ReadOnly = False
            preci.ReadOnly = False
            guardar.Enabled = True
            busqueda_productos.Enabled = False
            busqueda_productos.ReadOnly = True
            guardar.Enabled = True
            nuevo.Enabled = False
            eliminar.Enabled = False
            modificar.Enabled = False
            Grilla_Productos.Enabled = False
            Grilla_Productos.ReadOnly = True
            codigo.Focus()
            codigo.Select()
            cancelar.Enabled = True
            nuevo.Focus()
            nuevo.Select()
        End If
    End Sub
    Private Sub codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codigo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            preci.Focus()
            preci.Select()
        End If
    End Sub
    Private Sub categoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles categoria.KeyPress
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
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            guardar.Focus()
            guardar.Select()
            SendKeys.Send("{ENTER}")
        End If
    End Sub

    Private Sub preci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles preci.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
    End Sub
    Private Sub Grilla_Productos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Productos.CellEndEdit
    End Sub
End Class