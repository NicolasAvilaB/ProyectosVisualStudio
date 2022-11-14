Public Class Productos1
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

        Consulta_Oracle("select * from PRODUCTOS_EXAMEN")

    End Sub
    Sub mostrar(ByVal i As Integer)

        If DS7.Tables(DT7.TableName).Rows.Count > 0 Then
            Codigo.Text = DS7.Tables(DT7.TableName).Rows(i).Item("CODIGO")
            Nombre.Text = DS7.Tables(DT7.TableName).Rows(i).Item("NOMBRE")
            Precio.Text = DS7.Tables(DT7.TableName).Rows(i).Item("PRECIO")
            Cantidad.Text = DS7.Tables(DT7.TableName).Rows(i).Item("CANTIDAD")
        End If
    End Sub
    Sub mostrar_grilla()
        Grilla1.DataSource = DS7.Tables(DT7.TableName)
        Conexion_Oracle.Close()
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
        Consulta_Oracle("select max(CODIGO)as CODIGO from PRODUCTOS_EXAMEN")
        If TypeOf (DS7.Tables(DT7.TableName).Rows(0).Item("CODIGO")) Is DBNull Then
            Codigo.Text = 1

        Else
            Codigo.Text = DS7.Tables(DT7.TableName).Rows(0).Item("CODIGO") + 1
            Conexion_Oracle.Close()
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


                Consulta_Oracle("Begin SP_INGRESO ('" & (Codigo.Text) & "','" & (Nombre.Text) & "','" & (Precio.Text) & "','" & (Cantidad.Text) & "'); end;")

                MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")

                actualizar_tabla_productos()
                controles(False, True)
                Nombre.Enabled = False
                Precio.Enabled = False
                Cantidad.Enabled = False
                mostrar_grilla()
                Cancelar.Enabled = True
            ElseIf VarSeleccion = 2 Then

                Consulta_Oracle("Begin SP_PROD ('" & (Nombre.Text) & "','" & (Precio.Text) & "','" & (Cantidad.Text) & "','" & (Codigo.Text) & "'); end;")

                MsgBox("Datos Modificados Correctamente", vbInformation, "Felicidades")
                actualizar_tabla_productos()
                controles(False, True)
                Nombre.Enabled = False
                Precio.Enabled = False
                Cantidad.Enabled = False
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
                Consulta_Oracle("Begin SP_ELI ('" & (Codigo.Text) & "');end; ")

            End If

            actualizar_tabla_productos()
            If DS7.Tables(DT7.TableName).Rows.Count > 0 Then
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
        If MiPos < DT7.Rows.Count - 1 Then
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
        MiPos = DT7.Rows.Count - 1
        mostrar(MiPos)
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
        Bienvenido.Show()
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        controles(True, False)
        VarSeleccion = 2
        Codigo.Enabled = True
        Nombre.Enabled = True
        Precio.Enabled = True
        Cantidad.Enabled = True
    End Sub

    Private Sub Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Letras", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Nombre_TextChanged(sender As Object, e As EventArgs) Handles Nombre.TextChanged

    End Sub

    Private Sub Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Cantidad_TextChanged(sender As Object, e As EventArgs) Handles Cantidad.TextChanged

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
End Class