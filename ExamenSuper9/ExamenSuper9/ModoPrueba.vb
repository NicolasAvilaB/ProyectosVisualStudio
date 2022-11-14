Public Class ModoPrueba
    Dim Vall1 As Integer
    Dim Aceso As Integer
    Dim mult As Integer

    Private Sub Volver_Click(sender As Object, e As EventArgs)
     
    End Sub

    Private Sub ModoPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Procede Con Cuidado", vbInformation, "Modo Cajero Experimental")

        Vall1 = 0
        Timer1.Enabled = True
        Timer1.Interval = 100
        Agregue_Productos2.Focus()

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
            DA.Fill(dt)
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

    Private Sub Volver_Click_1(sender As Object, e As EventArgs)
        Dim esult As String
        esult = MsgBox("Cerraras el Modo de Cajeros Experimental, ¿Deseas Continuar?", vbOKCancel, "Modo Prueba Experimental")
        If esult = vbOK Then
            MsgBox("Se Ha Cerrado El Modo Prueba Experimental, Gracias Por Trabajar Con Nosotros", vbExclamation, "Cierre Experimental")
            Conexion.Close()
            Me.Close()
            Entrada.Show()
        Else
            MsgBox("A Cancelado La Operacion")
        End If
    End Sub

    Private Sub Efectivo_Click(sender As Object, e As EventArgs) Handles Efectivo2.Click
        Modulo_Traspaso_Valores_Formulario.totalpagar = Total_Pagar2.Text
        Modulo_Traspaso_Valores_Formulario.subto = Subtotal2.Text
        Efectivo22.Show()
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

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar2.Click
        If (Agregue_Productos2.Text = "") Then
            MsgBox("Error Fatal: El Campo Para Agregar los Productos Esta Vacio", vbCritical, "Error")
            Agregue_Productos2.Focus()
        Else
            Modulo_Consulte.Consulta("Call ConsultaProducto ('" & (Agregue_Productos2.Text) & "')")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"))
                Agregue_Productos2.Clear()
                Agregue_Productos2.Focus()

            Else
                MsgBox("Codigo de Producto Incorrecto, Porfavor Verifique", vbCritical, "Error")
                Agregue_Productos2.Clear()
                Agregue_Productos2.Focus()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Vall1 = Vall1 + 1


        Dim suma As Integer = 0.0

        For Each row As DataGridViewRow In Productos_Pasados.Rows
            suma += Val(row.Cells(2).Value)

        Next

        Subtotal2.Text = Convert.ToInt32(suma)
        hora.Text = Now.ToLongTimeString
    End Sub

    Private Sub Agregue_Productos2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Agregue_Productos2.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Agregue_Productos2_TextChanged(sender As Object, e As EventArgs) Handles Agregue_Productos2.TextChanged

    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Consulta2.Clear()
        Producto.Text = Nothing
        Codigo.Text = Nothing
        Categoria.Text = Nothing
        Precio.Text = Nothing
    End Sub

    Private Sub Consulte_Click(sender As Object, e As EventArgs) Handles Consulte.Click
        If (Consulta2.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Consulta Para Continuar", vbCritical, "Error")
            Consulta2.Focus()
        Else
            Modulo_Consulte.Consulta("Call ConsultaProducto ('" & (Consulta2.Text) & "')")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)
                Codigo.Text = CStr(row("codigo"))
                Producto.Text = CStr(row("nombre"))
                Categoria.Text = CStr(row("categorias"))
                Precio.Text = CStr(row("precio"))
            Else
                MsgBox("Codigo de Producto Incorrecto Porfavor Verifique", vbCritical, "Error")
                Consulta2.Clear()
                Producto.Text = Nothing
                Codigo.Text = Nothing
                Categoria.Text = Nothing
                Precio.Text = Nothing
                Consulta2.Focus()
            End If
        End If
    End Sub

    Private Sub Eliminar_Transaccion2_Click(sender As Object, e As EventArgs) Handles Eliminar_Transaccion2.Click
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

    Private Sub Total2_Click(sender As Object, e As EventArgs) Handles Total2.Click
        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
            Volver2.Enabled = False
            Eliminar_Transaccion2.Enabled = False

            Anular2.Enabled = False
            Aceptar2.Enabled = False

            Descuento2.Enabled = True
            Efectivo2.Enabled = True
            Abortar_Tarea2.Enabled = True

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
            Total2.Enabled = False
            Agregue_Productos2.Focus()
        End If
    End Sub

    Private Sub Abortar_Tarea2_Click(sender As Object, e As EventArgs) Handles Abortar_Tarea2.Click
        Volver2.Enabled = True
        Eliminar_Transaccion2.Enabled = True
        Agregue_Productos2.Enabled = True
        Anular2.Enabled = True
        Aceptar2.Enabled = True

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
        Total2.Enabled = True
        Descuento2.Enabled = False
        Efectivo2.Enabled = False
        Abortar_Tarea2.Enabled = False
        Total_Pagar2.Clear()
    End Sub

    Private Sub Anular2_Click(sender As Object, e As EventArgs) Handles Anular2.Click
        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
        End If
    End Sub

    Private Sub Descuento2_Click(sender As Object, e As EventArgs) Handles Descuento2.Click
        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
            Agregue_Productos2.Focus()
        ElseIf (Agregue_Productos2.Text = "") Then
            MsgBox("Error: Escriba El Numero Para Hacer el Descuento", vbCritical, "Error")
            Agregue_Productos2.Focus()
        ElseIf (Agregue_Productos2.Text = "5") Then

            mult = Convert.ToInt32(Subtotal2.Text) * 0.95
            Total_Pagar2.Text = mult
            MsgBox("Descuento Realizado Con Exito", vbInformation, "Felicidades")
            Agregue_Productos2.Clear()
            Agregue_Productos2.Focus()
            Descuento2.Enabled = False

        Else
            MsgBox("Error: Numero Incorrecto, Porfavor Revise", vbCritical, "Error")
            Agregue_Productos2.Clear()
            Agregue_Productos2.Focus()
        End If
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

    Private Sub Consulta2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Consulta2.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Consulta2_TextChanged(sender As Object, e As EventArgs) Handles Consulta2.TextChanged

    End Sub
End Class