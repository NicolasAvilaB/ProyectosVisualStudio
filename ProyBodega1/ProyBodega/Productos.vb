Public Class Productos
    Dim Dato0, Dato1, Dato2, Dato3, Dato4, Dato5, Dato6 As String
    Dim VarSeleccion As Integer
    Dim cod As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles regresar.Click
        Me.Close()
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
            Dato2 = Grilla_Productos.CurrentRow.Cells(4).EditedFormattedValue.ToString
            Dato3 = Grilla_Productos.CurrentRow.Cells(5).EditedFormattedValue.ToString
            Dato4 = Grilla_Productos.CurrentRow.Cells(6).EditedFormattedValue.ToString
            Dato5 = Grilla_Productos.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato6 = Grilla_Productos.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Label8.Text = Dato0
            codigo.Text = Dato1
            Nombre.Text = Dato5
            Marca.Text = Dato6
            preci.Text = Dato2
            cantidad.Text = Dato3
            categoria.Text = Dato4
        Else
            Label8.Text = "0"
            codigo.Clear()
            Nombre.Clear()
            Marca.Clear()
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
        Dim i As Integer
        busqueda_productos.Text = StrConv(busqueda_productos.Text, VbStrConv.ProperCase)
        i = Len(busqueda_productos.Text)
        busqueda_productos.SelectionStart = i
        If (busqueda_productos.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
        Else
            Consulta2("Call Busqueda_Nom ('" & (busqueda_productos.Text & "%") & "')")
            If DS2.Tables(DT2.TableName).Rows.Count > 0 Then
                Grilla_Productos.DataSource = DS2.Tables(DT2.TableName)
                Mostrar()
            Else
                Label8.Text = "0"
                codigo.Clear()
                Nombre.Clear()
                Marca.Clear()
                preci.Clear()
                categoria.Clear()
                cantidad.Clear()
                Grilla_Productos.DataSource = DS2.Tables(DT2.TableName)
            End If
        End If
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
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
        ElseIf (preci.Text = "") Then
            MsgBox("Error: No se ha Describido un Precio de Articulos Validos", vbCritical, "¡Error, Precio no Descrito!")
            preci.Focus()
            preci.Select()
        ElseIf (cantidad.Text = "") Then
            MsgBox("Error: No se ha Describido una Cantidad de Articulos Validos", vbCritical, "¡Error, Cantidad no Descrita!")
            cantidad.Focus()
            cantidad.Select()
        ElseIf (categoria.Text = "") Then
            MsgBox("Error: No existe una Categoria Escrita aun", vbCritical, "¡Error, Categoria no Especificada!")
            categoria.Focus()
            categoria.Select()
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
                MsgBox("El Rut: " + codigo.Text + " o Nombre Ya Existe En El Registro con el Rut Especificado y Departamento.", vbCritical, "Error, Rut Ya Existente")
                codigo.Focus()
                codigo.Select()
                codigo.Clear()
            ElseIf (Dato1 = codigo.Text) Then
                MsgBox("El Rut: " + codigo.Text + " o Nombre Ya Existe En El Registro con el Rut Especificado y Departamento.", vbCritical, "Error, Rut Ya Existente")
                codigo.Focus()
                codigo.Select()
                codigo.Clear()
            ElseIf VarSeleccion = 1 Then
                Try
                    Consulta2("Call Ingreso_Articulo ('" & (Label8.Text) & "','" & (codigo.Text) & "','" & (Nombre.Text) & "','" & (Marca.Text) & "','" & (preci.Text) & "','" & (cantidad.Text) & "','" & (categoria.Text) & "')")
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
                    Grilla_Productos.ReadOnly = True
                    cancelar.Enabled = False
                    codigo.Enabled = False
                    preci.Enabled = False
                    cantidad.Enabled = False
                    Marca.Enabled = False
                    Marca.ReadOnly = True
                    Nombre.Enabled = False
                    Nombre.ReadOnly = True
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
                    Grilla_Productos.ReadOnly = True
                    cancelar.Enabled = False
                    codigo.Enabled = False
                    preci.Enabled = False
                    Nombre.Enabled = False
                    Nombre.ReadOnly = True
                    Marca.Enabled = False
                    Marca.ReadOnly = True
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
                Nombre.Clear()
                Marca.Clear()
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
    Private Sub cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cantidad.KeyPress
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
        Marca.Enabled = False
        Marca.ReadOnly = True
        eliminar.Enabled = True
        modificar.Enabled = True
        busqueda_productos.Enabled = True
        busqueda_productos.ReadOnly = True
        Grilla_Productos.Enabled = True
        Grilla_Productos.ReadOnly = True
        cancelar.Enabled = False
        codigo.Enabled = False
        preci.Enabled = False
        cantidad.Enabled = False
        categoria.Enabled = False
        codigo.ReadOnly = True
        preci.ReadOnly = True
        Nombre.Enabled = False
        Nombre.ReadOnly = True
        cantidad.ReadOnly = True
        categoria.ReadOnly = True
        nuevo.Focus()
        nuevo.Select()
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
        If (Me.Grilla_Productos.Rows.Count = 0) Then
            codigo.Clear()
            preci.Clear()
            cantidad.Clear()
            categoria.Clear()
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
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
            Grilla_Productos.Rows.RemoveAt(Grilla_Productos.CurrentRow.Index)
            categoria.ReadOnly = False
            preci.ReadOnly = False
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
    Private Sub preci_TextChanged(sender As Object, e As EventArgs) Handles preci.TextChanged
        If (preci.Text = "0") Then
            SendKeys.Send("{BACKSPACE}")
        End If
    End Sub
    Private Sub cantidad_TextChanged(sender As Object, e As EventArgs) Handles cantidad.TextChanged
        If (cantidad.Text = "0") Then
            SendKeys.Send("{BACKSPACE}")
        End If
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
End Class