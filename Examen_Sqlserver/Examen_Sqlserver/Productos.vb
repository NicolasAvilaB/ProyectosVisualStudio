Public Class Productos
    Dim VarSeleccion As Integer
    Dim MiPos As Integer

    Sub limpiar()
        Nombre.Clear()
        Precio.Clear()
        Cantidad.Clear()
    End Sub

    Sub controles(ByVal a As Boolean, ByVal b As Boolean)
        Nuevo.Enabled = b
        Eliminar.Enabled = b
        Modificar.Enabled = b

        Guardar.Enabled = a
        Cancelar.Enabled = a


        Nombre.ReadOnly = b
        Precio.ReadOnly = b
        Cantidad.ReadOnly = b

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
            Codigo.Text = DS9.Tables(DT9.TableName).Rows(i).Item("Codigo")
            Nombre.Text = DS9.Tables(DT9.TableName).Rows(i).Item("Nombre")
            Precio.Text = DS9.Tables(DT9.TableName).Rows(i).Item("Precio")
            Cantidad.Text = DS9.Tables(DT9.TableName).Rows(i).Item("Cantidad")
        End If
    End Sub
    Sub mostrar_grilla()
        Grilla1.DataSource = DS9.Tables(DT9.TableName)
        Conexion_Sqlserver.Close()
    End Sub
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar_tabla_productos()
        mostrar(0)
        mostrar_grilla()
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        limpiar()
        controles(True, False)
        Nombre.Enabled = True
        Precio.Enabled = True
        Cantidad.Enabled = True
        VarSeleccion = 1
        Consulta_Sqlserver("select max(Codigo)as Codigo from Productos")
        If TypeOf (DS9.Tables(DT9.TableName).Rows(0).Item("Codigo")) Is DBNull Then
            Codigo.Text = 1

        Else
            Codigo.Text = DS9.Tables(DT9.TableName).Rows(0).Item("Codigo") + 1
            Conexion_Sqlserver.Close()
        End If
        
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If (Nombre.Text = "") Then
            MsgBox("Error Fatality: El Campo Nombre esta Vacio", vbCritical, "Error")
        ElseIf (Precio.Text = "") Then
            MsgBox("Error Fatality: El Campo Precio esta Vacio", vbCritical, "Error")
        ElseIf (Cantidad.Text = "") Then
            MsgBox("Error Fatality: El Campo Cantidad esta Vacio", vbCritical, "Error")
        Else
            If VarSeleccion = 1 Then


                Consulta_Sqlserver("EXEC SP_Ingreso_Producto '" & (Codigo.Text) & "', '" & (Nombre.Text) & "', '" & (Precio.Text) & "', " & (Cantidad.Text) & "")

                MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")

                actualizar_tabla_productos()
                controles(False, True)
                mostrar_grilla()
                Cancelar.Enabled = True
            ElseIf VarSeleccion = 2 Then

                Consulta_Sqlserver("EXEC SP_Modificar_Productos '" & (Codigo.Text) & "', '" & (Nombre.Text) & "', '" & (Precio.Text) & "', '" & (Cantidad.Text) & "'")

                MsgBox("Datos Modificados Correctamente", vbInformation, "Felicidades")
                actualizar_tabla_productos()
                controles(False, True)
                mostrar_grilla()
                Cancelar.Enabled = True
            End If
        End If

        
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim valormensaje As Integer
        If Me.Grilla1.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
            valormensaje = MsgBox("¿Desea Eliminar el Codigo = " + Codigo.Text + " y sus Derivados del Registro?", vbYesNo + vbQuestion, "Eliminar")
            If valormensaje = vbYes Then
                Consulta_Sqlserver("EXEC SP_Eliminar_Prod '" & (Codigo.Text) & "' ")

            End If

            actualizar_tabla_productos()
            If DS9.Tables(DT9.TableName).Rows.Count > 0 Then
                mostrar(0)
            Else
                limpiar()
            End If
        End If
        mostrar_grilla()
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        MiPos = 0
        mostrar(MiPos)
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If MiPos < DT9.Rows.Count - 1 Then
            MiPos += 1
            mostrar(MiPos)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If MiPos > 0 Then
            MiPos -= 1
            mostrar(MiPos)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        MiPos = DT9.Rows.Count - 1
        mostrar(MiPos)
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
        Bienvenido.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Nombre_TextChanged(sender As Object, e As EventArgs) Handles Nombre.TextChanged

    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        controles(True, False)
        VarSeleccion = 2
        Codigo.Enabled = True
        Nombre.Enabled = True
        Precio.Enabled = True
        Cantidad.Enabled = True
    End Sub
End Class