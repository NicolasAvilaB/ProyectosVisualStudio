Public Class Ventas1
    Dim div As Integer
    Dim ex As Integer
    Dim rest As Integer
    Dim sum As Integer
    Dim mult As Integer
    Dim Vall1 As Integer
    Dim Vall2 As Integer
    Dim Vall3 As Integer
    Dim vars As Integer

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
        Menu1.Show()
    End Sub

    Private Sub Busqueda_Clientes_Click(sender As Object, e As EventArgs) Handles Busqueda_Clientes.Click
        Busqueda_Clientes1.Owner = Me
        Busqueda_Clientes1.ShowDialog()
    End Sub

    Private Sub Busqueda_Productos_Click(sender As Object, e As EventArgs) Handles Busqueda_Productos.Click
        Busca_Productos.Owner = Me
        Busca_Productos.ShowDialog()
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Rut.Enabled = True
        Busqueda_Clientes.Enabled = True
        Categoria.Enabled = True
        Nombre_Producto.Enabled = True
        Agregar_Lista.Enabled = True
        Quitar_Lista.Enabled = True
        Busqueda_Productos.Enabled = True
        Modi.Enabled = True
        Condicion.Enabled = True
        DProd.Enabled = True
        Can2.ReadOnly = False
        Can2.Enabled = True
        ca.Enabled = True
        DProd.ReadOnly = False
        Nuevo.Enabled = False
        Grabar.Enabled = True
        Cancelar.Enabled = True

        Limpiar.Enabled = True

        vars = 1

    End Sub

    Private Sub Usuarios1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Vall1 = 0
        Timer1.Enabled = True
        Timer1.Interval = 100

        Vall2 = 0
        Timer2.Enabled = True
        Timer2.Interval = 100

        Vall3 = 0
        Timer3.Enabled = True
        Timer3.Interval = 100

        Label18.Text = FormatDateTime(Now, DateFormat.ShortDate)

        Try
            Consulta("SELECT DISTINCT rut FROM clientes")
            Dim dt As DataTable = New DataTable("clientes")
            DA.Fill(dt)
            With Rut
                .DataSource = dt
                .DisplayMember = "rut"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Rut.SelectedIndex = -1

        Try
            Consulta("SELECT DISTINCT Nombre FROM categorias")
            Dim dt As DataTable = New DataTable("categorias")
            DA.Fill(dt)
            With Categoria
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Nombre_Producto.SelectedIndex = -1
        Cod_Categoria.Clear()
        Cod_Categoria.Text = "2244"

        Consulta("select max(n_factura)as n_factura from venta")
        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("n_factura")) Is DBNull Then
            N_Factura.Text = 1

        Else
            N_Factura.Text = DS.Tables(DT.TableName).Rows(0).Item("n_factura") + 1
            Conexion.Close()
        End If
        Categoria.SelectedIndex = -1
        Cod_Categoria.Clear()
        Nombre_Producto.DataSource = Nothing
        Nombre_Producto.Items.Clear()
    End Sub

    Private Sub Rut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Rut.SelectedIndexChanged
        If (Rut.SelectedIndex = -1) Then
            Nombre.Text = Nothing
            Direccion.Text = Nothing
            Telefono.Text = Nothing
        Else
            Consulta("select clientes.nombre, clientes.direccion, clientes.telefono from clientes where rut = '" & (Rut.Text) & "' ")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)

                Nombre.Text = CStr(row("nombre"))
                Direccion.Text = CStr(row("direccion"))
                Telefono.Text = CStr(row("telefono"))

            End If
        End If
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Rut.Enabled = False
        Busqueda_Clientes.Enabled = False
        Categoria.Enabled = False
        Nombre_Producto.Enabled = False
        Cantidad.Enabled = False
        Busqueda_Productos.Enabled = False
        Agregar_Lista.Enabled = False
        Quitar_Lista.Enabled = False
        DProd.Enabled = False

        Nuevo.Enabled = True
        Grabar.Enabled = False
        Cancelar.Enabled = False
        Imprimir.Enabled = False
        Limpiar.Enabled = False
        Cantidad.ReadOnly = False
        Cantidad.Enabled = False

        Cod_Producto.Text = Nothing
        Marca.Text = Nothing
        Descripcion.Text = Nothing
        Precio.Text = Nothing

        Categoria.SelectedIndex = -1
        Nombre_Producto.Text = Nothing
        Nombre_Producto.DataSource = Nothing
        Nombre_Producto.Items.Clear()
        Cod_Categoria.Clear()
        Nombre_Producto.SelectedIndex = -1
        Rut.SelectedIndex = -1

        Condicion.SelectedIndex = -1
        Desglose.Clear()

        DProd.Rows.Clear()
        Conexion.Close()
    End Sub

    Private Sub Categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Categoria.SelectedIndexChanged


        If (Categoria.Text = "Abarrotes") Then

            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2255'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2255"

        ElseIf (Categoria.Text = "Aseo") Then

            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2243'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2243"

        ElseIf (Categoria.Text = "Gaseosas y Otros") Then

            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2254'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2254"

        ElseIf (Categoria.Text = "Coctel") Then

            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2253'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2253"

        ElseIf (Categoria.Text = "Confites") Then
            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2252'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2252"


        ElseIf (Categoria.Text = "Carnes") Then
            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2251'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2251"


        ElseIf (Categoria.Text = "Conservas y Otros") Then

            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2250'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2250"

        ElseIf (Categoria.Text = "Higiene") Then

            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2249'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2249"

        ElseIf (Categoria.Text = "Lacteos") Then

            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2248'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2248"

        ElseIf (Categoria.Text = "Panaderia") Then

            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2247'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2247"

        ElseIf (Categoria.Text = "Rotiseria") Then

            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2246'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2246"

        ElseIf (Categoria.Text = "Tabaco") Then
            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2245'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2245"


        ElseIf (Categoria.Text = "Otros") Then

            Try
                Consulta("SELECT DISTINCT nombre FROM productos where cod_categoria ='2244'")
                Dim dt As DataTable = New DataTable("productos")
                DA.Fill(dt)
                With Nombre_Producto
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nombre_Producto.SelectedIndex = -1
            Cod_Categoria.Clear()
            Cod_Categoria.Text = "2244"

        End If

    End Sub

    Private Sub Nombre_Producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Nombre_Producto.SelectedIndexChanged
        If (Nombre_Producto.SelectedIndex = -1) Then
            Cod_Producto.Text = Nothing
            Marca.Text = Nothing
            Descripcion.Text = Nothing
            Precio.Text = Nothing
            Cantidad.Clear()
            Cantidad.ReadOnly = True
            Cantidad.Enabled = False

        Else
            Consulta("select productos.cod_producto, productos.marca, productos.descripcion, productos.precio_compra, productos.cantidad from productos where nombre = '" & (Nombre_Producto.Text) & "' ")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)

                Cod_Producto.Text = CStr(row("cod_producto"))
                Marca.Text = CStr(row("marca"))
                Descripcion.Text = CStr(row("descripcion"))
                Precio.Text = CStr(row("precio_compra"))
                Cantidad.Text = CStr(row("cantidad"))

            End If
        End If
    End Sub

    Private Sub DProd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DProd.CellContentClick

    End Sub

    Private Sub DProd_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles DProd.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Cantidad_TextChanged(sender As Object, e As EventArgs) Handles Cantidad.TextChanged

    End Sub

    Private Sub Agregar_Lista_Click(sender As Object, e As EventArgs) Handles Agregar_Lista.Click
        Dim row1 As DataGridViewRow = Me.DProd.CurrentRow()

        If (Can2.Text = "") Then
            MsgBox("Error: No Es Posible Agregar la Cantidad Si No La A Especificado", vbCritical, "Error Fatal")
            Can2.Focus()
        ElseIf (Can2.Text = "0") Then
            MsgBox("Error: No Puedes Agregar " + Can2.Text + " Como Cantidad Para los Productos", vbCritical, "Error Fatal")
            Can2.Clear()
            Can2.Text = "1"
        ElseIf (Nombre_Producto.SelectedIndex = -1) Then
            MsgBox("Error Fatal: Debe Seleccionar un Producto Para Agregarlo a la Lista", vbCritical, "Error Fatality")

        Else

            mult = Convert.ToInt64(Can2.Text) * Convert.ToInt64(Precio.Text)
            div = mult / 1.19
            rest = mult - div
            sum = rest + mult
            DProd.Rows.Add(Cod_Producto.Text, Nombre_Producto.Text, Precio.Text, Can2.Text, div, rest, sum)
            Me.DProd.CurrentCell = Me.DProd.Rows(Me.DProd.RowCount - 1).Cells(0)
            Me.DProd.Refresh()
            Marca.Text = Nothing
            Cantidad.Text = Nothing
            Can2.Clear()
            Can2.Text = "1"
            Descripcion.Text = Nothing
            Precio.Text = Nothing
            Cod_Producto.Text = Nothing
            Nombre_Producto.SelectedIndex = -1



        End If




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Vall1 = Vall1 + 1


        Dim suma As Integer = 0.0

        For Each row As DataGridViewRow In DProd.Rows
            suma += Val(row.Cells(3).Value) * Val(row.Cells(2).Value)

        Next

        Total.Text = Convert.ToInt32(suma)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Vall2 = Vall2 + 1


        Dim suma2 As Integer = 0.0

        For Each row As DataGridViewRow In DProd.Rows
            suma2 += Val(row.Cells(4).Value)

        Next

        Neto.Text = Convert.ToInt32(suma2)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Vall3 = Vall3 + 1


        Dim suma3 As Integer = 0.0

        For Each row As DataGridViewRow In DProd.Rows
            suma3 += Val(row.Cells(5).Value)

        Next

        Iva.Text = Convert.ToInt32(suma3)
    End Sub

    Private Sub Quitar_Lista_Click(sender As Object, e As EventArgs) Handles Quitar_Lista.Click
        If Me.DProd.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Para Eliminar", vbCritical, "Error Fatal")

        Else
            Dim loFila As DataGridViewRow = Me.DProd.CurrentRow()

            DProd.Rows.Remove(loFila)

        End If

    End Sub

    Private Sub Grabar_Click(sender As Object, e As EventArgs) Handles Grabar.Click
        Dim mifecha As Date = Label18.Text
        Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
        If (Nombre.Text = "") Then
            MsgBox("Error Fatal: Primero seleccione Rut", vbCritical, "Error Fatal")
    
        ElseIf Me.DProd.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Para Eliminar", vbCritical, "Error Fatal")


        ElseIf (vars = 1) Then
            For Each row1 As DataGridViewRow In DProd.Rows
                Consulta("UPDATE productos SET cantidad = cantidad - " & Val(row1.Cells(3).Value) & " WHERE cod_producto =" & Val(row1.Cells(0).Value) & " ")

            Next
            Try
                Consulta("INSERT INTO venta (n_factura,rut,fecha_venta,neto,iva,total,desglose,condiciones) VALUES ('" & (N_Factura.Text) & "','" & (Rut.Text) & "','" & (mifecha2) & "','" & (Neto.Text) & "','" & (Iva.Text) & "','" & (Total.Text) & "','" & (Desglose.Text) & "','" & (Condicion.Text) & "')")
                MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")
            Catch ex As Exception
                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try

            For Each row As DataGridViewRow In DProd.Rows

                Try

                    Consulta("INSERT INTO detalle_venta (n_factura,cod_producto,valor_unitario,cantidad,neto,iva,total,cod_detalle) VALUES ('" & (N_Factura.Text) & "','" & (Val(row.Cells(0).Value)) & "','" & (Val(row.Cells(2).Value)) & "','" & (Val(row.Cells(3).Value)) & "','" & (Neto.Text) & "','" & (Iva.Text) & "','" & (Total.Text) & "','" & (Val(row.Cells(0).Value)) & "')")
                Catch ex As Exception

                    DA.SelectCommand = SC
                    DA.Fill(DT)

                End Try


            Next


        End If
        Imprimir.Enabled = True
        Me.Close()
        Menu1.Show()


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Condicion.SelectedIndexChanged

        If (Condicion.SelectedIndex = -1) Then


        ElseIf (Condicion.Text = "Aceptacion de Boleta") Then

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Modi.Click
        If (Desglose.Text = "") Then

        Else
            Desglose.ReadOnly = False
            Desglose.Enabled = True
        End If



    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Consulta("delete from venta")
        Consulta("delete from detalle_venta")
        MsgBox("Datos Borrados", vbInformation, "Listo")
        Conexion.Close()
        Me.Close()
        Menu1.Show()
    End Sub

    Private Sub Total_TextChanged(sender As Object, e As EventArgs) Handles Total.TextChanged
        Desglose.Text = Letras(Total.Text)
    End Sub

    Private Sub Desglose_TextChanged(sender As Object, e As EventArgs) Handles Desglose.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub ca_Click(sender As Object, e As EventArgs) Handles ca.Click
        Dim row As DataGridViewRow = Me.DProd.CurrentRow()
        If Me.DProd.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue Alguno Para Continuar", vbCritical, "Error Fatal")
            Can2.Clear()
            Can2.Focus()
        ElseIf (Can2.Text = "") Then
            MsgBox("Error: No Es Posible Agregar la Cantidad Si No La A Especificado", vbCritical, "Error Fatal")
            Can2.Focus()
        ElseIf (Can2.Text = "0") Then
            MsgBox("Error: No Puedes Agregar " + Can2.Text + " Como Cantidad Para los Productos", vbCritical, "Error Fatal")
            Can2.Clear()
            Can2.Focus()


        ElseIf (Len(Can2.Text) = 6) Then
            MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
            Can2.Clear()
            Can2.Focus()
        ElseIf (Len(Can2.Text) = 7) Then
            MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
            Can2.Clear()
            Can2.Focus()
        ElseIf (Len(Can2.Text) = 8) Then
            MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
            Can2.Clear()
            Can2.Focus()
        ElseIf (Len(Can2.Text) = 9) Then
            MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
            Can2.Clear()
            Can2.Focus()
        ElseIf (Len(Can2.Text) = 10) Then
            MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
            Can2.Clear()
            Can2.Focus()
        ElseIf (Len(Can2.Text) = 11) Then
            MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
            Can2.Clear()
            Can2.Focus()
        ElseIf (Len(Can2.Text) = 12) Then
            MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
            Can2.Clear()
            Can2.Focus()
        ElseIf (Len(Can2.Text) = 13) Then
            MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
            Can2.Clear()
            Can2.Focus()
        ElseIf (Len(Can2.Text) = 14) Then
            MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
            Can2.Clear()
            Can2.Focus()
        Else
            row.Cells(3).Value = Can2.Text
            Can2.Text = "1"
            Can2.Focus()
        End If

    End Sub

    Private Sub Cod_Categoria_TextChanged(sender As Object, e As EventArgs) Handles Cod_Categoria.TextChanged

    End Sub
End Class