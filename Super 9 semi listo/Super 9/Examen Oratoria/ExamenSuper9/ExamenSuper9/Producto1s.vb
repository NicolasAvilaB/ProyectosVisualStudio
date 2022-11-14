﻿Public Class Producto1s
    Dim VarSeleccion As Integer
    Dim MiPos As Integer
    Dim veri As Boolean
    Dim Cantidad1 As String
    Dim Noe As String
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Sub limpiar()
        Codigo.Clear()
        Nombre.Clear()
        Precio.Clear()


    End Sub
    Sub llenarcombo()

        For Each fila As DataRow In DT.Rows

            Proveedores.Items.Add(fila("nombre") & " , " & fila("empresa"))
        Next

    End Sub
    Sub Mostrar2(ByVal i As Integer)
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Try
                Codigo.Text = DS.Tables(DT.TableName).Rows(i).Item("codigo")
                Nombre.Text = DS.Tables(DT.TableName).Rows(i).Item("nombre")
                Precio.Text = DS.Tables(DT.TableName).Rows(i).Item("precio")
                Proveedores.Text = DS.Tables(DT.TableName).Rows(i).Item("proveedores")
                Categoria.Text = DS.Tables(DT.TableName).Rows(i).Item("categorias")

            Catch ex As Exception
            End Try
        End If

    End Sub
    Sub Actualizacion_Tabla()

        Consulta("Call MostrarProductos")

    End Sub
    Sub Mostrar_Grilla()
        GrillaProductos.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub

    Private Sub Ultimo_Click(sender As Object, e As EventArgs) Handles Ultimo.Click
        MiPos = DT.Rows.Count - 1
        Mostrar2(MiPos)
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub Primero_Click(sender As Object, e As EventArgs) Handles Primero.Click
        MiPos = 0
        Mostrar2(MiPos)
    End Sub
    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles Anterior.Click
        If MiPos > 0 Then
            MiPos -= 1
            Mostrar2(MiPos)
        End If
    End Sub
    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
        If MiPos < DT.Rows.Count - 1 Then
            MiPos += 1
            Mostrar2(MiPos)
        End If
    End Sub
    Private Sub Grilla_Empresarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaProductos.CellContentClick

    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Consulta("SELECT DISTINCT empresa FROM empresarios")
            Proveedores.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("empresarios")
            DA.Fill(dt)
            With Proveedores
                .DataSource = dt
                .DisplayMember = "empresa"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Proveedores.SelectedIndex = -1
        Mostrar_Grilla()
        Actualizacion_Tabla()
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        VarSeleccion = 1
        Nuevo.Enabled = False
        Modificar.Enabled = False
        Eliminar.Enabled = False
        Codigo.Enabled = True
        Nombre.Enabled = True
        Precio.Enabled = True
        Proveedores.Enabled = True
        Categoria.Enabled = True
        AgregaStock.Enabled = False
        Guardar.Enabled = True
        Codigo.Clear()
        Nombre.Clear()
        Precio.Clear()
        Proveedores.SelectedIndex = -1
        Categoria.SelectedIndex = -1
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click

        VarSeleccion = 2
        Codigo.Enabled = True
        Nombre.Enabled = True
        Precio.Enabled = True
        Proveedores.Enabled = True
        Categoria.Enabled = True

        Nuevo.Enabled = False
        Guardar.Enabled = True
        Eliminar.Enabled = False
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        Modulo_Consulte.Consulta("Call VerificaProductos ('" & (Codigo.Text) & "')")
        If (Codigo.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Codigo Para Continuar", vbCritical, "Error")

        ElseIf (Nombre.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Nombre Para Continuar", vbCritical, "Error")
        ElseIf (Precio.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Precio Para Continuar", vbCritical, "Error")
        ElseIf (Proveedores.Text = "") Then
            MsgBox("Error Fatal: Porfavor Seleccione Algun Proveedor", vbCritical, "Error")
        ElseIf (Categoria.Text = "") Then
            MsgBox("Error Fatal: Porfavor Seleccione Alguna Categoria", vbCritical, "Error")
        ElseIf DS.Tables(DT.TableName).Rows.Count > 0 Then

            MsgBox("El Codigo: " + Codigo.Text + " Ya Existe En El Registro", vbCritical, "Error Fatal")

        ElseIf VarSeleccion = 1 Then

            Try
                Consulta("Call InsertarProductos ('" & (Codigo.Text) & "','" & (Nombre.Text) & "','" & (Precio.Text) & "','" & (Proveedores.Text) & "','" & (Categoria.Text) & "','" & "1" & "')")
                MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")
                Guardar.Enabled = False
                Nuevo.Enabled = True
                Codigo.Enabled = False
                Nombre.Enabled = False
                Precio.Enabled = False
                Proveedores.Enabled = False
                Categoria.Enabled = False
                AgregaStock.Enabled = True
                Eliminar.Enabled = True
                Modificar.Enabled = True
            Catch ex As Exception


                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try

            Actualizacion_Tabla()
            Mostrar_Grilla()
        ElseIf VarSeleccion = 2 Then
            Try
                Consulta("Call ModificarProductos('" & (Nombre.Text) & "','" & (Precio.Text) & "','" & (Proveedores.Text) & "','" & (Categoria.Text) & "','" & (Codigo.Text) & "')")
                MsgBox("Datos Modificados Correctamente", vbInformation, "Felicidades")
            Catch ex As Exception
                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try
            Guardar.Enabled = False
            Nuevo.Enabled = True
            Codigo.Enabled = False
            Nombre.Enabled = False
            Precio.Enabled = False
            AgregaStock.Enabled = True
            Proveedores.Enabled = False
            Categoria.Enabled = False
            Eliminar.Enabled = True
            Modificar.Enabled = True
        End If

        Mostrar_Grilla()
        Actualizacion_Tabla()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim valormensaje As Integer
        If (Codigo.Text = "") Then
            MsgBox("Lo Siento No Hay Codigo De Producto Que Eliminar", vbCritical, "Error")
            Proveedores.SelectedIndex = -1
            Categoria.SelectedIndex = -1

        Else
            valormensaje = MsgBox("¿Desea Eliminar del Registro El Siguiente Codigo: " + Codigo.Text + " ?", vbYesNo + vbQuestion, "Eliminar")
            If valormensaje = vbYes Then
                Consulta("Call EliminarProductos ('" & (Codigo.Text) & "')")
                MsgBox("Has Eliminado Con Exito El Codigo: " + Codigo.Text, vbInformation, "Eliminado")
                
            Else
                MsgBox("Has Cancelado la Operacion", vbCritical, "Cancelado")
            End If

            Actualizacion_Tabla()
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Mostrar2(0)
            Else
                limpiar()
            End If
        End If
        Mostrar_Grilla()
        Mostrar2(0)

    End Sub

    Private Sub Terminar_Click(sender As Object, e As EventArgs) Handles Terminar.Click
        For Each row As DataGridViewRow In GrillaProductos.Rows
            Cantidad1 = row.Cells(5).Value
            Noe = row.Cells(1).Value
        Next


        If (Cantidad1 = "1") Then
            MsgBox("Error: Se Ha Encontrado el Producto = " & Noe.ToString() & " = Con Stock de 1, Modificalo Este¨Producto desde el Boton Compra Stock y Busca el Articulo ", vbCritical, "Error Fatal")

        Else
            Me.Close()
            Usuarios9.Show()

            Mostrar2(0)
            Guardar.Enabled = False
            Codigo.Enabled = False
            Nombre.Enabled = False
            Precio.Enabled = False
            Proveedores.Enabled = False
            Nuevo.Enabled = True
            Modificar.Enabled = True
            Eliminar.Enabled = True
            Categoria.Enabled = False
            Actualizacion_Tabla()
            Mostrar2(0)
            Mostrar_Grilla()
        End If
    End Sub

    Private Sub Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nombre.KeyPress
        
    End Sub

    Private Sub Nombre_TextChanged(sender As Object, e As EventArgs) Handles Nombre.TextChanged

    End Sub

    Private Sub Precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Precio_TextChanged(sender As Object, e As EventArgs) Handles Precio.TextChanged

    End Sub

    Private Sub Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Codigo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Codigo_TextChanged(sender As Object, e As EventArgs) Handles Codigo.TextChanged

    End Sub

    Private Sub Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Categoria.SelectedIndexChanged

    End Sub

    Private Sub Proveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Proveedores.SelectedIndexChanged
      
    End Sub

    Private Sub Acept_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub AgregaStock_Click(sender As Object, e As EventArgs) Handles AgregaStock.Click
        Me.Close()
        CompraProductos.Show()
        CompraProductos.Buscar.Focus()
    End Sub

    Private Sub GrillaProductos_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaProductos.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
End Class