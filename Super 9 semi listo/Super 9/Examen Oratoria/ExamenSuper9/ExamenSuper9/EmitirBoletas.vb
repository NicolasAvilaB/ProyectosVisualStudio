﻿Public Class EmitirBoletas
    Dim Vall1 As Integer
    Dim Va2l2 As Integer
    Dim Aceso As Integer
    Dim mult As Integer
    Dim NDES As Integer
    Dim ita As Integer
   


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
        Efectivo1.Pago.Focus()
        Efectivo1.Pago.Select()
        Efectivo1.Owner = Me
        Efectivo1.ShowDialog()



    End Sub

    Private Sub Lacteos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Lacteos.KeyPress

    End Sub

    Private Sub Lacteos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lacteos.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Lacteos.Text) & "')")
        If (Lacteos.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Lacteos.SelectedIndex = -1
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
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
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()

            Else
                MsgBox("Codigo de Producto Incorrecto, Porfavor Verifique", vbCritical, "Error")
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()
            End If
        End If
        Agregue_Productos.Focus()
    End Sub

    Private Sub Compruebe_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Productos_Pasados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Productos_Pasados.CellContentClick
       
    End Sub

    Private Sub Subtotal_TextChanged(sender As Object, e As EventArgs) Handles Subtotal.TextChanged

    End Sub

    Private Sub EmitirBoletas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Agregue_Productos.Focus()
        Vall1 = 0
        ita = 0

        Timer1.Enabled = True
        Timer1.Interval = 100
        Timer2.Interval = 100
        Timer2.Enabled = True

        Fecha.Text = Format(Now, "dd/MM/yyyy")
        Agregue_Productos.Focus()
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
        Tabaco.Enabled = True

        Agregue_Productos.Select()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Vall1 = Vall1 + 1
        Va2l2 = Va2l2 + 1

        Dim suma As Integer = 0.0

        For Each row As DataGridViewRow In Productos_Pasados.Rows
            suma += Val(row.Cells(2).Value) * Val(row.Cells(3).Value)

        Next

        Subtotal.Text = Convert.ToInt32(suma)

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
        
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

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

        End If

    End Sub

    Private Sub Consulta_TextChanged(sender As Object, e As EventArgs) Handles Consulta1.TextChanged
        If (Consulta1.Text = "") Then
            Consulte.Enabled = False
            Cerrar.Enabled = False
            Producto.Text = Nothing
            Codigo.Text = Nothing
            Categoria.Text = Nothing
            Precio.Text = Nothing
            Agregue_Productos.Focus()
            Agregue_Productos.Select()
        Else
            Consulte.Enabled = True
            Cerrar.Enabled = True
        End If
       

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
        'Solo Numeros no letras
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
            If (Agregue_Productos.Text = "") Then
                MsgBox("Error Fatal: El Campo Para Agregar los Productos Esta Vacio", vbCritical, "Error")
                Agregue_Productos.Focus()
            Else
                Modulo_Consulte.Consulta("Call ConsultaProducto ('" & (Agregue_Productos.Text) & "')")
                If DS.Tables(DT.TableName).Rows.Count = 1 Then
                    Dim row As DataRow = DT.Rows(0)
                    Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                    Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                    Me.Productos_Pasados.Refresh()
                    Agregue_Productos.Clear()
                    Agregue_Productos.Focus()

                Else
                    MsgBox("Codigo de Producto Incorrecto, Porfavor Verifique", vbCritical, "Error")
                    Agregue_Productos.Clear()
                    Agregue_Productos.Focus()
                End If
            End If
            Agregue_Productos.Focus()
        End If
    End Sub

    Private Sub Agregue_Productos_TextChanged(sender As Object, e As EventArgs) Handles Agregue_Productos.TextChanged

    End Sub

    Private Sub Eliminar_Transaccion_Click(sender As Object, e As EventArgs) Handles Eliminar_Transaccion.Click
        Dim esult As String
        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
            Agregue_Productos.Focus()
            Agregue_Productos.Select()
        Else
            esult = MsgBox("¿Estas Seguro de Eliminar la Transaccion Hecha Hasta El Momento?", vbOKCancel + vbQuestion, "Eliminar Transaccion")
            If esult = vbOK Then
                Productos_Pasados.Rows.Clear()
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            Else
                MsgBox("Cancelaste la Operacion", vbExclamation, "Operacion Cancelada")
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            End If
        End If
        Agregue_Productos.Focus()
        Agregue_Productos.Select()
    End Sub

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click
        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
            Volver.Enabled = False
            Eliminar_Transaccion.Enabled = False
            Anular.Enabled = False
            Tabaco.Enabled = False
            Aceptar.Enabled = False
            Cantidad.Enabled = False
            Tabaco.Enabled = False
            Descuento.Enabled = True
            Efectivo.Enabled = True
            Abortar_Tarea.Enabled = True
            Tabaco.Enabled = False
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
            Tabaco.Enabled = False
            Total.Enabled = False
            Consulta1.Enabled = False
            Consulte.Enabled = False
            Cerrar.Enabled = False
            Otros.Enabled = False
            Productos_Pasados.Enabled = False
            Agregue_Productos.Focus()
            Agregue_Productos.Select()
        End If
        Tabaco.Enabled = False
        Agregue_Productos.Focus()
        Agregue_Productos.Select()
    End Sub

    Private Sub Abortar_Tarea_Click(sender As Object, e As EventArgs) Handles Abortar_Tarea.Click
        Volver.Enabled = True
        Eliminar_Transaccion.Enabled = True
        Agregue_Productos.Enabled = True
        Anular.Enabled = True
        Aceptar.Enabled = True
        Cantidad.Enabled = True
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
        Tabaco.Enabled = True
        Total.Enabled = True
        Consulta1.Enabled = True
        Consulte.Enabled = True
        Cerrar.Enabled = True
        Otros.Enabled = True
        Productos_Pasados.Enabled = True
        Descuento.Enabled = False
        Efectivo.Enabled = False
        Abortar_Tarea.Enabled = False
        NUm.Clear()
        NUm.Text = "0"
        Total_Pagar.Clear()
        Agregue_Productos.Clear()
        Agregue_Productos.Focus()
        Agregue_Productos.Select()
    End Sub

    Private Sub Anular_Click(sender As Object, e As EventArgs)
        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
        End If
    End Sub

    Private Sub Descuento_Click(sender As Object, e As EventArgs) Handles Descuento.Click
        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
            Agregue_Productos.Focus()
            Agregue_Productos.Select()
        ElseIf (Agregue_Productos.Text = "") Then
            MsgBox("Error: Escriba El Numero Para Hacer el Descuento", vbCritical, "Error")
            Agregue_Productos.Focus()
            Agregue_Productos.Select()
        ElseIf (Agregue_Productos.Text = "5") Then

            mult = Convert.ToInt32(Subtotal.Text) * 0.95
            NDES = Convert.ToInt32(Subtotal.Text) * 0.05
            Total_Pagar.Text = mult
            NUm.Text = NDES
            MsgBox("Descuento Realizado Con Exito", vbInformation, "Felicidades")
            Agregue_Productos.Clear()
            Agregue_Productos.Focus()
            Agregue_Productos.Select()
            Descuento.Enabled = False

        Else
            MsgBox("Error: Numero Incorrecto, Porfavor Revise", vbCritical, "Error")
            Agregue_Productos.Clear()
            Agregue_Productos.Focus()
            Agregue_Productos.Select()
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
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Be_otros.SelectedIndex = -1
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            End If
        End If
    End Sub

    Private Sub Carnes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Carnes.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Carnes.Text) & "')")
        If (Carnes.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Carnes.SelectedIndex = -1
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            End If
        End If
    End Sub

    Private Sub Abarrotes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Abarrotes.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Abarrotes.Text) & "')")
        If (Abarrotes.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Abarrotes.SelectedIndex = -1
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            End If
        End If
    End Sub

    Private Sub Aseo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Aseo.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Aseo.Text) & "')")
        If (Aseo.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Aseo.SelectedIndex = -1
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
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
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Rotiseria.SelectedIndex = -1
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            End If
        End If
    End Sub

    Private Sub Confites_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Confites.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Confites.Text) & "')")
        If (Confites.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Confites.SelectedIndex = -1
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            End If
        End If

    End Sub

    Private Sub Panaderia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Panaderia.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Panaderia.Text) & "')")
        If (Panaderia.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Panaderia.SelectedIndex = -1
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            End If
        End If
    End Sub

    Private Sub Conservas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Conservas.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Conservas.Text) & "')")
        If (Conservas.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Conservas.SelectedIndex = -1
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            End If
        End If
    End Sub

    Private Sub Coctel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Coctel.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Coctel.Text) & "')")
        If (Coctel.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Coctel.SelectedIndex = -1
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            End If
        End If
    End Sub

    Private Sub Higiene_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Higiene.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Higiene.Text) & "')")
        If (Higiene.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Higiene.SelectedIndex = -1
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            End If
        End If
    End Sub

    Private Sub Tabaco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tabaco.SelectedIndexChanged
        Modulo_Consulte.Consulta("Call RellenoCombo ('" & (Tabaco.Text) & "')")
        If (Tabaco.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)
                Productos_Pasados.Rows.Add(row("codigo"), row("nombre"), row("precio"), "1")
                Me.Productos_Pasados.CurrentCell = Me.Productos_Pasados.Rows(Me.Productos_Pasados.RowCount - 1).Cells(0)
                Me.Productos_Pasados.Refresh()
                Tabaco.SelectedIndex = -1
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            End If
        End If
    End Sub

    Private Sub Total_Pagar_TextChanged(sender As Object, e As EventArgs) Handles Total_Pagar.TextChanged

    End Sub

    Private Sub hora_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Anular.Click
        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Para Eliminar", vbCritical, "Error Fatal")
            Agregue_Productos.Focus()
            Agregue_Productos.Select()
        Else
            Dim loFila As DataGridViewRow = Me.Productos_Pasados.CurrentRow()

            Productos_Pasados.Rows.Remove(loFila)
        End If

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Cantidad_Click(sender As Object, e As EventArgs) Handles Cantidad.Click
        
        Dim row As DataGridViewRow = Me.Productos_Pasados.CurrentRow()

        If Me.Productos_Pasados.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue Alguno Para Continuar", vbCritical, "Error Fatal")
            Agregue_Productos.Clear()
            Agregue_Productos.Focus()
        ElseIf (Agregue_Productos.Text = "") Then
            MsgBox("Error: No Es Posible Agregar la Cantidad Si No La A Especificado", vbCritical, "Error Fatal")
            Agregue_Productos.Focus()
        ElseIf (Agregue_Productos.Text = "0") Then
            MsgBox("Error: No Puedes Agregar " + Agregue_Productos.Text + " Como Cantidad Para los Productos", vbCritical, "Error Fatal")
            Agregue_Productos.Clear()
            Agregue_Productos.Focus()


            ElseIf (Len(Agregue_Productos.Text) = 6) Then
                MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()
            ElseIf (Len(Agregue_Productos.Text) = 7) Then
                MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()
            ElseIf (Len(Agregue_Productos.Text) = 8) Then
                MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()
            ElseIf (Len(Agregue_Productos.Text) = 9) Then
                MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()
            ElseIf (Len(Agregue_Productos.Text) = 10) Then
                MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()
            ElseIf (Len(Agregue_Productos.Text) = 11) Then
                MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()
            ElseIf (Len(Agregue_Productos.Text) = 12) Then
                MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()
            ElseIf (Len(Agregue_Productos.Text) = 13) Then
                MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()
            ElseIf (Len(Agregue_Productos.Text) = 14) Then
                MsgBox("Error: No Puedes Exceder la Cantidad de Productos Mas alla de 99999", vbCritical, "Error Fatal")
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()
            Else
                row.Cells(3).Value = Agregue_Productos.Text
                Agregue_Productos.Clear()
                Agregue_Productos.Focus()
            End If




    End Sub

    Private Sub Fecha_TextChanged(sender As Object, e As EventArgs) Handles Fecha.TextChanged

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup
        ' Me.ToolTip1.IsBalloon = True
    End Sub

    Private Sub Otros_Click(sender As Object, e As EventArgs) Handles Otros.Click
        OtrosProductos.Owner = Me
        OtrosProductos.ShowDialog()
        Agregue_Productos.Select()
        OtrosProductos.Buscar.Focus()
    End Sub

    Private Sub Productos_Pasados_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Productos_Pasados.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        ita = ita + 1

        Dim cantidad1 As Integer = 0.0

        For i = 1 To Productos_Pasados.Rows.Count
            cantidad1 = i

        Next

        Items.Text = Convert.ToInt32(cantidad1)
    End Sub

    Private Sub Productos_Pasados_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles Productos_Pasados.RowsAdded

    End Sub

    Private Sub Devuelta_Click(sender As Object, e As EventArgs) Handles Devuelta.Click
        Devo_Stock.Owner = Me
        Devo_Stock.ShowDialog()
    End Sub
End Class