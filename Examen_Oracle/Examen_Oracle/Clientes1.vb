Public Class Clientes1
    Dim VarSeleccion As Integer
    Dim MiPos As Integer

    Sub limpiar()
        Rut.Clear()
        Nombre.Clear()
        Direccion.Clear()
        Telefono.Clear()
    End Sub

    Sub controles(ByVal a As Boolean, ByVal b As Boolean)
        btnNuevo.Enabled = b
        btnEliminar.Enabled = b
        btnModificar.Enabled = b
        btnImprimir.Enabled = b
        btnGuardar.Enabled = a
        btnCancelar.Enabled = a

        Rut.ReadOnly = b
        Nombre.ReadOnly = b
        Direccion.ReadOnly = b
        Telefono.ReadOnly = b

        btnPrimero.Enabled = b
        btnUltimo.Enabled = b
        btnAnterior.Enabled = b
        btnSiguiente.Enabled = b
    End Sub

    Sub actualizar_tabla_clientes()

        Consulta_Oracle("select * from CLIENTES_EXAMEN")

    End Sub

    Sub mostrar_grilla()
        grilla.DataSource = DS7.Tables(DT7.TableName)
        Conexion_Oracle.Close()
    End Sub

    Sub BUSCAR()

        Consulta_Oracle("SELECT * from CLIENTES WHERE " & (cmb_buscar.Text) & " LIKE '" & (txt_buscar.Text & "%") & "' ")

    End Sub

    Sub mostrar(ByVal i As Integer)

        If DS7.Tables(DT7.TableName).Rows.Count > 0 Then
            Rut.Text = DS7.Tables(DT7.TableName).Rows(i).Item("Rut")
            Nombre.Text = DS7.Tables(DT7.TableName).Rows(i).Item("Nombre")
            Direccion.Text = DS7.Tables(DT7.TableName).Rows(i).Item("Direccion")
            Telefono.Text = DS7.Tables(DT7.TableName).Rows(i).Item("Telefono")
        End If
    End Sub
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar_tabla_clientes()
        mostrar(0)
        mostrar_grilla()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        controles(True, False)
        Rut.Enabled = True
        Nombre.Enabled = True
        Direccion.Enabled = True
        Telefono.Enabled = True
        VarSeleccion = 1
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        controles(True, False)
        Rut.Enabled = True
        Nombre.Enabled = True
        Direccion.Enabled = True
        Telefono.Enabled = True
        VarSeleccion = 2
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        VarSeleccion = 1

        Consulta_Oracle("select * from CLIENTES where Rut ='" & (Rut.Text) & "' ")

        If (Rut.Text = "") Then
            MsgBox("El Campo Rut Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Nombre.Text = "") Then
            MsgBox("El Campo Nombre Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Direccion.Text = "") Then
            MsgBox("El Campo Direccion Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Telefono.Text = "") Then
            MsgBox("El Campo Telefono Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf DS7.Tables(DT7.TableName).Rows.Count > 0 Then

            MsgBox("El Rut: " + Rut.Text + " Ya Existe en el Registro", vbCritical, "Error Fatal")

        ElseIf VarSeleccion = 1 Then


            Consulta_Oracle("Begin SP_INSERTINTOCLIENTES ('" & (Rut.Text) & "','" & (Nombre.Text) & "','" & (Direccion.Text) & "','" & (Telefono.Text) & "'); end;")
            Try
                DA7.SelectCommand = SC7

                DA7.Fill(DT7)
            Catch ex As Exception
                MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")

            End Try
            actualizar_tabla_clientes()
            controles(False, True)
            Rut.Enabled = False
            Nombre.Enabled = False
            Direccion.Enabled = False
            Telefono.Enabled = False
            mostrar_grilla()
        ElseIf VarSeleccion = 2 Then

            Consulta_Oracle("Begin MODIFICAICHON ('" & (Rut.Text) & "','" & (Nombre.Text) & "','" & (Direccion.Text) & "','" & (Telefono.Text) & "'); end;")

            MsgBox("Datos Modificados Correctamente", vbInformation, "Felicidades")
            actualizar_tabla_clientes()
            controles(False, True)
            Rut.Enabled = False
            Nombre.Enabled = False
            Direccion.Enabled = False
            Telefono.Enabled = False
            mostrar_grilla()
        End If
        mostrar_grilla()
        actualizar_tabla_clientes()
        
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        controles(False, True)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim valormensaje As Integer
        If Me.grilla.Rows.Count = 0 Then
            MsgBox("Error: No Hay Clientes Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
            valormensaje = MsgBox("¿Desea Eliminar el Rut: " + Rut.Text + " y sus derivados del registro?", vbYesNo + vbQuestion, "Eliminar")
            If valormensaje = vbYes Then
                Consulta_Oracle("Begin ELIMINAICHON('" & (Rut.Text) & "'); end;")

            End If

            actualizar_tabla_clientes()
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmb_buscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_buscar.SelectedIndexChanged
        If cmb_buscar.Text <> "" Then
            BUSCAR()
        End If
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        If cmb_buscar.Text <> "" Then
            BUSCAR()
        End If
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

    Private Sub Rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Rut.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Rut_TextChanged(sender As Object, e As EventArgs) Handles Rut.TextChanged

    End Sub

    Private Sub Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Telefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Telefono_TextChanged(sender As Object, e As EventArgs) Handles Telefono.TextChanged

    End Sub
End Class