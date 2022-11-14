Public Class Productos
    Dim Dato0, Dato1, Dato2, Dato3, Dato4, Dato5, Dato6 As String
    Dim VarSeleccion As Integer
    Dim cod As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles regresar.Click
        busqueda_productos.Clear()
        codigo.Enabled = False
        codigo.ReadOnly = True
        guardar.Enabled = False
        nuevo.Enabled = True
        compra_stock.Enabled = True
        Marca.Enabled = False
        Marca.ReadOnly = True
        eliminar.Enabled = True
        modificar.Enabled = True
        busqueda_productos.Enabled = True
        busqueda_productos.ReadOnly = False
        busqueda_productos.Clear()
        Grilla_Productos.Enabled = True
        Grilla_Productos.ReadOnly = True
        cancelar.Enabled = False
        codigo.Enabled = False
        codigo.ReadOnly = True
        Nombre.Enabled = False
        Nombre.ReadOnly = True
        nuevo.Focus()
        nuevo.Select()
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
        If (Me.Grilla_Productos.Rows.Count = 0) Then
            codigo.Clear()
            Nombre.Clear()
            Marca.Clear()
        End If
        Me.Close()
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        busqueda_productos.Clear()
        VarSeleccion = 1
        codigo.Enabled = True
        compra_stock.Enabled = False
        codigo.ReadOnly = False
        guardar.Enabled = True
        busqueda_productos.Enabled = False
        busqueda_productos.ReadOnly = True
        busqueda_productos.Clear()
        guardar.Enabled = True
        nuevo.Enabled = False
        Nombre.Enabled = True
        Nombre.ReadOnly = False
        Nombre.Clear()
        Marca.Clear()
        eliminar.Enabled = False
        modificar.Enabled = False
        Grilla_Productos.Enabled = False
        Grilla_Productos.ReadOnly = True
        Marca.Enabled = True
        Marca.ReadOnly = False
        codigo.Clear()
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
            Dato5 = Grilla_Productos.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato6 = Grilla_Productos.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Label8.Text = Dato0
            codigo.Text = Dato1
            Nombre.Text = Dato5
            Marca.Text = Dato6
        Else
            Label8.Text = "0"
            codigo.Clear()
            Nombre.Clear()
            Marca.Clear()
        End If
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Productos.DataSource = DS2.Tables(DT2.TableName)
        Conexion.Close()
    End Sub
    Private Sub busqueda_productos_TextChanged(sender As Object, e As EventArgs) Handles busqueda_productos.TextChanged
        Dim i As Integer
        busqueda_productos.Text = StrConv(busqueda_productos.Text, VbStrConv.ProperCase)
        i = Len(busqueda_productos.Text)
        busqueda_productos.SelectionStart = i
        If (busqueda_productos.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
            modificar.Enabled = True
        Else
            Consulta2("Call Busqueda_Nom ('" & (busqueda_productos.Text & "%") & "')")
            If DS2.Tables(DT2.TableName).Rows.Count > 0 Then
                Grilla_Productos.DataSource = DS2.Tables(DT2.TableName)
                Mostrar()
                modificar.Enabled = False
            Else
                Label8.Text = "0"
                codigo.Clear()
                Nombre.Clear()
                Marca.Clear()
                modificar.Enabled = False
                Grilla_Productos.DataSource = DS2.Tables(DT2.TableName)
            End If
        End If
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        busqueda_productos.Clear()
        If (codigo.Text = "") Then
            MsgBox("Error: No se ha Describido un Codigo Valido", vbCritical, "¡Error, Codigo no Descrito!")
            codigo.Focus()
            codigo.Select()
        ElseIf (Nombre.Text = "") Then
            MsgBox("Error: No se ha Describido un Nombre de Articulos Validos", vbCritical, "¡Error, Nombre no Descrito!")
            Nombre.Focus()
            Nombre.Select()
        ElseIf (Marca.Text = "") Then
            MsgBox("Error: No se ha Describido una Marca de Articulos Validos", vbCritical, "¡Error, Marca no Descrito!")
            Marca.Focus()
            Marca.Select()
        Else
            If (Me.Grilla_Productos.Rows.Count = 0) Then
                Dato1 = Nothing
            Else
                Dato1 = Grilla_Productos.CurrentRow.Cells(1).EditedFormattedValue.ToString
            End If
            For Each row As DataGridViewRow In Grilla_Productos.Rows
                cod = row.Cells(1).Value
            Next
            If (cod = codigo.Text) Then
                MsgBox("El Codigo: " + codigo.Text + " o Nombre Ya Existe En El Registro con el Articulo Especificado.", vbCritical, "Error, Codigo Ya Existente")
                codigo.Focus()
                codigo.Select()
                codigo.Clear()
            ElseIf (Dato1 = codigo.Text) Then
                MsgBox("El Codigo: " + codigo.Text + " o Nombre Ya Existe En El Registro con el Articulo Especificado.", vbCritical, "Error, Codigo Ya Existente")
                codigo.Focus()
                codigo.Select()
                codigo.Clear()
            ElseIf VarSeleccion = 1 Then
                Try
                    Consulta2("Call Ingreso_Articulo ('" & (Label8.Text) & "','" & (codigo.Text) & "','" & (Nombre.Text) & "','" & (Marca.Text) & "')")
                    MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                    codigo.Enabled = False
                    codigo.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    compra_stock.Enabled = True
                    modificar.Enabled = True
                    busqueda_productos.Enabled = True
                    busqueda_productos.ReadOnly = False
                    Grilla_Productos.Enabled = True
                    Grilla_Productos.ReadOnly = True
                    cancelar.Enabled = False
                    codigo.Enabled = False
                    Marca.Enabled = False
                    Marca.ReadOnly = True
                    Nombre.Enabled = False
                    Nombre.ReadOnly = True
                    codigo.ReadOnly = True
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
                    Consulta2("Call ModificaArticulos ('" & (codigo.Text) & "','" & (Nombre.Text) & "','" & (Marca.Text) & "'," & (Label8.Text) & ")")
                    MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                    codigo.Enabled = False
                    codigo.ReadOnly = True
                    guardar.Enabled = False
                    compra_stock.Enabled = True
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    modificar.Enabled = True
                    busqueda_productos.Enabled = True
                    busqueda_productos.ReadOnly = False
                    Grilla_Productos.Enabled = True
                    Grilla_Productos.ReadOnly = True
                    cancelar.Enabled = False
                    codigo.Enabled = False
                    Nombre.Enabled = False
                    Nombre.ReadOnly = True
                    Marca.Enabled = False
                    Marca.ReadOnly = True
                    codigo.ReadOnly = True
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
        Consulta11("Call Validar_Codigo_Nombre_Producto('" & (codigo.Text) & "','" & (Nombre.Text) & "')")
        If DS11.Tables(DT11.TableName).Rows.Count > 0 Then
            MsgBox("Error: No Podras Modificar el Codigo, Ya que el Codigo Anterior " + codigo.Text + " Ligado a Un Producto, Ya A Sido Creado En Stock, Para Modificarlo Puedes Eliminarlo Primero", vbCritical, "Error de Codigo o Producto en Stock")
        ElseIf Me.Grilla_Productos.Rows.Count = 0 Then
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
                Nombre.Clear()
                Marca.Clear()
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
    Private Sub cantidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Grilla_Productos_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Productos.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        busqueda_productos.Clear()
        codigo.Enabled = False
        compra_stock.Enabled = True
        compra_stock.Enabled = True
        codigo.ReadOnly = True
        guardar.Enabled = False
        nuevo.Enabled = True
        Marca.Enabled = False
        Marca.ReadOnly = True
        eliminar.Enabled = True
        modificar.Enabled = True
        busqueda_productos.Enabled = True
        busqueda_productos.ReadOnly = False
        Grilla_Productos.Enabled = True
        Grilla_Productos.ReadOnly = True
        cancelar.Enabled = False
        codigo.Enabled = False
        codigo.ReadOnly = True
        Nombre.Enabled = False
        Nombre.ReadOnly = True
        nuevo.Focus()
        nuevo.Select()
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
        If (Me.Grilla_Productos.Rows.Count = 0) Then
            codigo.Clear()
            Nombre.Clear()
            Marca.Clear()
        End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
        Me.Refresh()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        codigo.Enabled = False
        compra_stock.Enabled = True
        codigo.ReadOnly = True
        guardar.Enabled = False
        nuevo.Enabled = True
        Marca.Enabled = False
        Marca.ReadOnly = True
        eliminar.Enabled = True
        modificar.Enabled = True
        busqueda_productos.Enabled = True
        busqueda_productos.ReadOnly = False
        busqueda_productos.Clear()
        Grilla_Productos.Enabled = True
        Grilla_Productos.ReadOnly = True
        cancelar.Enabled = False
        codigo.Enabled = False
        codigo.ReadOnly = True
        Nombre.Enabled = False
        Nombre.ReadOnly = True
        nuevo.Focus()
        nuevo.Select()
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
        If (Me.Grilla_Productos.Rows.Count = 0) Then
            codigo.Clear()
            Nombre.Clear()
            Marca.Clear()
        End If
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles compra_stock.Click
        If (Reponer_Stock.Buscar_Articulo_Nom.Text = "") Then
            Reponer_Stock.Guardar.Enabled = False
        End If
        busqueda_productos.Clear()
        Reponer_Stock.Owner = Me
        Reponer_Stock.ShowDialog()
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Consulta12("Call Validar_Codigo_Nombre_Producto('" & (codigo.Text) & "','" & (Nombre.Text) & "')")
        If DS12.Tables(DT12.TableName).Rows.Count > 0 Then
            MsgBox("Error: No Podras Modificar el Codigo, Ya que el Codigo Anterior " + codigo.Text + " Ligado a Un Producto, Ya A Sido Creado En Stock, Para Modificarlo Puedes Eliminarlo Primero", vbCritical, "Error de Codigo o Producto en Stock")
            busqueda_productos.Clear()
        ElseIf Me.Grilla_Productos.Rows.Count = 0 Then
            MsgBox("Error: No hay Articulos existentes a Modificar", vbCritical, "Error, No hay Articulos")
            nuevo.Focus()
            nuevo.Select()
        Else
            VarSeleccion = 2
            codigo.Enabled = True
            compra_stock.Enabled = False
            codigo.ReadOnly = False
            Grilla_Productos.Rows.RemoveAt(Grilla_Productos.CurrentRow.Index)
            guardar.Enabled = True
            busqueda_productos.Enabled = False
            busqueda_productos.ReadOnly = True
            guardar.Enabled = True
            nuevo.Enabled = False
            Nombre.Enabled = True
            Nombre.ReadOnly = False
            Marca.Enabled = True
            Marca.ReadOnly = False
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
    Private Sub Nombre_TextChanged(sender As Object, e As EventArgs) Handles Nombre.TextChanged
        Dim i As Integer
        Nombre.Text = StrConv(Nombre.Text, VbStrConv.ProperCase)
        i = Len(Nombre.Text)
        Nombre.SelectionStart = i
    End Sub
    Private Sub Marca_TextChanged(sender As Object, e As EventArgs) Handles Marca.TextChanged
        Dim i As Integer
        Marca.Text = StrConv(Marca.Text, VbStrConv.ProperCase)
        i = Len(Marca.Text)
        Marca.SelectionStart = i
    End Sub
    Private Sub codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codigo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
    End Sub
    Private Sub categoria_KeyPress(sender As Object, e As KeyPressEventArgs)
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
    Private Sub preci_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
    End Sub
    Private Sub Productos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Administrador.nombr.Enabled = False
        Administrador.cla.Enabled = False
        Administrador.nombr.ReadOnly = True
        Administrador.cla.ReadOnly = True
        Administrador.busque_admin.Enabled = True
        Administrador.busque_admin.ReadOnly = False
        Administrador.guardar.Enabled = False
        Administrador.nuevo.Enabled = True
        Administrador.eliminar.Enabled = True
        Administrador.Grilla_Administrador.Enabled = True
        Administrador.Grilla_Administrador.ReadOnly = True
        Administrador.cancelar.Enabled = False
        Administrador.nuevo.Focus()
        Administrador.nuevo.Select()
        Administrador.Actualizacion_Tabla()
        Administrador.Mostrar_Grilla()
        Administrador.Mostrar()
    End Sub
    Private Sub Marca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Marca.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nombre.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub busqueda_productos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda_productos.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
End Class