Public Class EmitirBoletas
    Dim Vall1 As Integer
    Dim Aceso As Integer
    Dim mult As Integer

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Volver.Click

        Me.Close()
        Bienvenido9.Show()

    End Sub
    
    Sub llenarlacteos()
        
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub Efectivo_Click(sender As Object, e As EventArgs) Handles Efectivo.Click
        Modulo_Traspaso_Valores_Formulario.totalpagar = Total_Pagar.Text
        Modulo_Traspaso_Valores_Formulario.subto = Subtotal.Text
        Efectivo1.Show()
        



    End Sub

    Private Sub Lacteos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lacteos.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Lacteos.Text) & "')")
        If (Lacteos.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Lacteos.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        If (Agregue_Productos.Text = "") Then
            MsgBox("Error Fatal: El Campo Para Agregar los Productos Esta Vacio", vbCritical, "Error")
            Agregue_Productos.Focus()
        Else
            Modulo_Consulte.Consulta("Call ConsultaProducto ('" & (Agregue_Productos.Text) & "')")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()

            Else
                MsgBox("Codigo de Producto Incorrecto, Porfavor Verifique", vbCritical, "Error")
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()
            End If
        End If

    End Sub

    Private Sub Compruebe_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Productos_Pasados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Productos_Pasados.CellContentClick
       

    End Sub

    Private Sub Subtotal_TextChanged(sender As Object, e As EventArgs) Handles Subtotal.TextChanged

    End Sub

    Private Sub EmitirBoletas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Vall1 = 0
        Timer1.Enabled = True
        Timer1.Interval = 100
        Agregue_Productos.Focus()

        Fecha.Text = Format(Now, "yyyy-MM-dd")
        Try
            Consulta("SELECT DISTINCT nombre FROM productos where categorias = 'Lacteos'")
            Lacteos.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("productos")
            DA.Fill(dt)
            With Lacteos
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Consulta("SELECT DISTINCT nombre FROM productos where categorias = 'Abarrotes'")
            Abarrotes.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("productos")
            DA.Fill(DT)
            With Abarrotes
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Consulta("SELECT DISTINCT nombre FROM productos where categorias = 'Gaseosas y Otros'")
            Be_otros.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("productos")
            DA.Fill(dt)
            With Be_otros
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Consulta("SELECT DISTINCT nombre FROM productos where categorias = 'Carnes'")
            Carnes.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("productos")
            DA.Fill(dt)
            With Carnes
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Consulta("SELECT DISTINCT nombre FROM productos where categorias = 'Aseo'")
            Aseo.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("productos")
            DA.Fill(dt)
            With Aseo
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Consulta("SELECT DISTINCT nombre FROM productos where categorias = 'Rotiseria'")
            Rotiseria.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("productos")
            DA.Fill(dt)
            With Rotiseria
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Consulta("SELECT DISTINCT nombre FROM productos where categorias = 'Confites'")
            Confites.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("productos")
            DA.Fill(dt)
            With Confites
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Consulta("SELECT DISTINCT nombre FROM productos where categorias = 'Panaderia'")
            Panaderia.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("productos")
            DA.Fill(dt)
            With Panaderia
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Consulta("SELECT DISTINCT nombre FROM productos where categorias = 'Conservas y Otros'")
            Conservas.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("productos")
            DA.Fill(dt)
            With Conservas
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Consulta("SELECT DISTINCT nombre FROM productos where categorias = 'Coctel'")
            Coctel.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("productos")
            DA.Fill(dt)
            With Coctel
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Consulta("SELECT DISTINCT nombre FROM productos where categorias = 'Higiene'")
            Higiene.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("productos")
            DA.Fill(dt)
            With Higiene
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Consulta("SELECT DISTINCT nombre FROM productos where categorias = 'Tabaco'")
            Tabaco.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("productos")
            DA.Fill(dt)
            With Tabaco
                .DataSource = dt
                .DisplayMember = "nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Productos_Pasados.Rows.Clear()
        Consulta("select max(nventa)as nventa from ventas")
        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("nventa")) Is DBNull Then
            N_Boleta.Text = 1

        Else
            N_Boleta.Text = DS.Tables(DT.TableName).Rows(0).Item("nventa") + 1
            Conexion.Close()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Vall1 = Vall1 + 1


        Dim suma As Integer = 0.0

        For Each row As DataGridViewRow In Productos_Pasados.Rows
            suma += Val(row.Cells(2).Value)

        Next

        Subtotal.Text = Convert.ToInt32(suma)
        hora.Text = Now.ToLongTimeString
    End Sub

    Private Sub Agrega_Productos_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Agregue_Productos_SelectedIndexChanged(sender As Object, e As EventArgs)
        Productos_Pasados.Rows.Add(Agregue_Productos.Text)



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Consulta1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Consulta1.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Consulta_TextChanged(sender As Object, e As EventArgs) Handles Consulta1.TextChanged

       

    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Consulta1.Clear()
        Producto.Text = Nothing
        Codigo.Text = Nothing
        Categoria.Text = Nothing
        Precio.Text = Nothing
    End Sub

    Private Sub Consulte_Click(sender As Object, e As EventArgs) Handles Consulte.Click
        If (Consulta1.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Consulta Para Continuar", vbCritical, "Error")
            Consulta1.Focus()
        Else
            Modulo_Consulte.Consulta("Call ConsultaProducto ('" & (Consulta1.Text) & "')")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)
                Codigo.Text = CStr(row("codigo"))
                Producto.Text = CStr(row("nombre"))
                Categoria.Text = CStr(row("categorias"))
                Precio.Text = CStr(row("precio"))
            Else
                MsgBox("Codigo de Producto Incorrecto Porfavor Verifique", vbCritical, "Error")
                Consulta1.Clear()
                Producto.Text = Nothing
                Codigo.Text = Nothing
                Categoria.Text = Nothing
                Precio.Text = Nothing
                Consulta1.Focus()
            End If
        End If
    End Sub

    Private Sub Agregue_Productos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Agregue_Productos.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Agregue_Productos_TextChanged(sender As Object, e As EventArgs) Handles Agregue_Productos.TextChanged

    End Sub

    Private Sub Eliminar_Transaccion_Click(sender As Object, e As EventArgs) Handles Eliminar_Transaccion.Click
        Dim esult As String
        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
            esult = MsgBox("¿Estas Seguro de Eliminar la Transaccion Hecha Hasta El Momento?", vbOKCancel, "Eliminar Transaccion")
            If esult = vbOK Then
                Productos_Pasados.Rows.Clear()

            Else
                MsgBox("Cancelaste la Operacion", vbExclamation, "Operacion Cancelada")
            End If
        End If
    End Sub

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click
        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
            Volver.Enabled = False
            Eliminar_Transaccion.Enabled = False

            Anular.Enabled = False
            Aceptar.Enabled = False

            Descuento.Enabled = True
            Efectivo.Enabled = True
            Abortar_Tarea.Enabled = True

            Lacteos.Enabled = False
            Carnes.Enabled = False
            Rotiseria.Enabled = False
            Panaderia.Enabled = False
            Abarrotes.Enabled = False
            Be_otros.Enabled = False
            Aseo.Enabled = False
            Higiene.Enabled = False
            Coctel.Enabled = False
            Conservas.Enabled = False
            Confites.Enabled = False
            Total.Enabled = False
            Agregue_Productos.Focus()
        End If
    End Sub

    Private Sub Abortar_Tarea_Click(sender As Object, e As EventArgs) Handles Abortar_Tarea.Click
        Volver.Enabled = True
        Eliminar_Transaccion.Enabled = True
        Agregue_Productos.Enabled = True
        Anular.Enabled = True
        Aceptar.Enabled = True

        Lacteos.Enabled = True
        Carnes.Enabled = True
        Rotiseria.Enabled = True
        Panaderia.Enabled = True
        Abarrotes.Enabled = True
        Be_otros.Enabled = True
        Aseo.Enabled = True
        Higiene.Enabled = True
        Coctel.Enabled = True
        Conservas.Enabled = True
        Confites.Enabled = True
        Total.Enabled = True
        Descuento.Enabled = False
        Efectivo.Enabled = False
        Abortar_Tarea.Enabled = False
        Total_Pagar.Clear()

    End Sub

    Private Sub Anular_Click(sender As Object, e As EventArgs) Handles Anular.Click
        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
        End If
    End Sub

    Private Sub Descuento_Click(sender As Object, e As EventArgs) Handles Descuento.Click
        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
            Agregue_Productos.Focus()
        ElseIf (Agregue_Productos.Text = "") Then
            MsgBox("Error: Escriba El Numero Para Hacer el Descuento", vbCritical, "Error")
            Agregue_Productos.Focus()
        ElseIf (Agregue_Productos.Text = "5") Then

            mult = Convert.ToInt32(Subtotal.Text) * 0.95
            Total_Pagar.Text = mult
            MsgBox("Descuento Realizado Con Exito", vbInformation, "Felicidades")
            Agregue_Productos.Clear()
            Agregue_Productos.Focus()
            Descuento.Enabled = False

        Else
            MsgBox("Error: Numero Incorrecto, Porfavor Revise", vbCritical, "Error")
            Agregue_Productos.Clear()
            Agregue_Productos.Focus()
        End If
    End Sub

    Private Sub Lacteos_SelectedValueChanged(sender As Object, e As EventArgs) Handles Lacteos.SelectedValueChanged
        
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Be_otros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Be_otros.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Be_otros.Text) & "')")
        If (Be_otros.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Be_otros.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Carnes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Carnes.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Carnes.Text) & "')")
        If (Carnes.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Carnes.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Abarrotes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Abarrotes.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Abarrotes.Text) & "')")
        If (Abarrotes.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Abarrotes.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Aseo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Aseo.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Aseo.Text) & "')")
        If (Aseo.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Aseo.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Rotiseria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Rotiseria.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Rotiseria.Text) & "')")
        If (Rotiseria.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Rotiseria.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Confites_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Confites.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Confites.Text) & "')")
        If (Confites.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Confites.SelectedIndex = -1
            End If
        End If

    End Sub

    Private Sub Panaderia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Panaderia.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Panaderia.Text) & "')")
        If (Panaderia.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Panaderia.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Conservas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Conservas.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Conservas.Text) & "')")
        If (Conservas.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Conservas.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Coctel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Coctel.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Coctel.Text) & "')")
        If (Coctel.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Coctel.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Higiene_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Higiene.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Higiene.Text) & "')")
        If (Higiene.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Higiene.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Tabaco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tabaco.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Tabaco.Text) & "')")
        If (Tabaco.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Tabaco.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Total_Pagar_TextChanged(sender As Object, e As EventArgs) Handles Total_Pagar.TextChanged

    End Sub

    Private Sub hora_TextChanged(sender As Object, e As EventArgs) Handles hora.TextChanged

    End Sub
End Class