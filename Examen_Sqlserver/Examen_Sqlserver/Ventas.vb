Public Class Ventas
    Dim VarSeleccion As Integer
    Dim MiPos As Integer

    Sub limpiar()
        Rut.Clear()
        Neto.Clear()
        Iva.Clear()
        Total.Clear()
    End Sub

    Sub controles(ByVal a As Boolean, ByVal b As Boolean)
        Nuevo.Enabled = b
        Eliminar.Enabled = b
        Modificar.Enabled = b

        Guardar.Enabled = a
        Cancelar.Enabled = a


        Rut.ReadOnly = b
        Neto.ReadOnly = b
        Iva.ReadOnly = b
        Total.ReadOnly = b
        btnPrimero.Enabled = b
        btnUltimo.Enabled = b
        btnAnterior.Enabled = b
        btnSiguiente.Enabled = b
    End Sub

    Sub actualizar_tabla_productos()

        Consulta_Sqlserver("EXEC SP_Vizualiza_Productos")

    End Sub
    Sub mostrar(ByVal i As Integer)

        If DS9.Tables(DT9.TableName).Rows.Count > 0 Then
            N_Venta.Text = DS9.Tables(DT9.TableName).Rows(i).Item("N_venta")
            Rut.Text = DS9.Tables(DT9.TableName).Rows(i).Item("Rut_Cliente")
            Fecha_Venta.Text = DS9.Tables(DT9.TableName).Rows(i).Item("Fecha")
            Neto.Text = DS9.Tables(DT9.TableName).Rows(i).Item("neto")
            Iva.Text = DS9.Tables(DT9.TableName).Rows(i).Item("iva")
            Total.Text = DS9.Tables(DT9.TableName).Rows(i).Item("total")
        End If
    End Sub
    Sub mostrar_grilla()
        Ventajas.DataSource = DS9.Tables(DT9.TableName)
        Conexion_Sqlserver.Close()
    End Sub
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fecha_Venta.Text = Format(Now, "yyyy-MM-dd")
        
    End Sub

    Private Sub Producto_SelectedIndexChanged(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If (Rut.Text = "") Then
            MsgBox("Error Fatality: El Campo Nombre esta Vacio", vbCritical, "Error")
        
        Else
            If VarSeleccion = 1 Then


                Consulta_Sqlserver("EXEC SP_Ingreso_Ventass '" & (N_Venta.Text) & "', '" & (Rut.Text) & "', '" & (Fecha_Venta.Text) & "', '" & (Neto.Text) & "', '" & (Iva.Text) & "', " & (Total.Text) & "")

                MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")

                actualizar_tabla_productos()
                controles(False, True)
                mostrar_grilla()
                Cancelar.Enabled = True
            End If
        End If
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        limpiar()
        controles(True, False)
        Rut.Enabled = True
        Neto.Enabled = True
        Iva.Enabled = True
        Total.Enabled = True

        VarSeleccion = 1
        Consulta_Sqlserver("select max(N_venta)as N_venta from Ventas")
        If TypeOf (DS9.Tables(DT9.TableName).Rows(0).Item("N_venta")) Is DBNull Then
            N_Venta.Text = 1

        Else
            N_Venta.Text = DS9.Tables(DT9.TableName).Rows(0).Item("N_venta") + 1
            Conexion_Sqlserver.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Modificar.Click

    End Sub
End Class