Public Class Usuarios
    Dim VarSeleccion As Integer
    Dim MiPos As Integer
    Sub limpiar()
        txtUsuario.Clear()
        Nombre.Clear()
        txtClave.Clear()
    End Sub

    Sub controles(ByVal a As Boolean, ByVal b As Boolean)
        btnNuevo.Enabled = b
        btnEliminar.Enabled = b
        btnModificar.Enabled = b

        btnGuardar.Enabled = a
        btnCancelar.Enabled = a

        txtUsuario.ReadOnly = b
        Nombre.ReadOnly = b
        txtClave.ReadOnly = b

        btnPrimero.Enabled = b
        btnUltimo.Enabled = b
        btnAnterior.Enabled = b
        btnSiguiente.Enabled = b
    End Sub
    Sub actualizar_tabla_clientes()

        Consulta_Mysql("Call SP_Actualiza_tabla_Usuarios")

    End Sub
    Sub mostrar_grilla()
        grilla.DataSource = DS.Tables(DT.TableName)
        Conexion_Mysql.Close()
    End Sub
    Sub BUSCAR()

        Consulta_Mysql("SELECT * from usuarios WHERE " & (cmb_buscar.Text) & " LIKE '" & (txt_buscar.Text & "%") & "' ")

    End Sub
    Sub mostrar(ByVal i As Integer)

        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            txtUsuario.Text = DS.Tables(DT.TableName).Rows(i).Item("usuario")

            txtClave.Text = DS.Tables(DT.TableName).Rows(i).Item("clave")
            Nombre.Text = DS.Tables(DT.TableName).Rows(i).Item("nombre")
        End If
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        controles(True, False)
        VarSeleccion = 1
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        controles(True, False)
        VarSeleccion = 2
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Consulta_Mysql("Call VerificaUsuario ('" & (txtUsuario.Text) & "')")

        If (txtUsuario.Text = "") Then
            MsgBox("El Campo Usuario Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (txtClave.Text = "") Then
            MsgBox("El Campo Clave Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Nombre.Text = "") Then
            MsgBox("El Campo Nombre Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf DS.Tables(DT.TableName).Rows.Count > 0 Then

            MsgBox("El Usuario: " + txtUsuario.Text + " Ya Existe en el Registro", vbCritical, "Error Fatal")

        ElseIf VarSeleccion = 1 Then



            Try
                Consulta_Mysql("Call SP_Inserto_Usuarios ('" & (txtUsuario.Text) & "','" & (txtClave.Text) & "','" & (Nombre.Text) & "')")
                MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")
            Catch ex As Exception
                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try
            actualizar_tabla_clientes()
            mostrar_grilla()
            controles(False, True)
        ElseIf VarSeleccion = 2 Then
            Consulta_Mysql("Call SP_Modificar_Usuarios('" & (txtClave.Text) & "','" & (Nombre.Text) & "','" & (txtUsuario.Text) & "')")
            MsgBox("Datos Modificados Correctamente", vbInformation, "Felicidades")
            actualizar_tabla_clientes()
            mostrar_grilla()
            controles(False, True)
        End If

        actualizar_tabla_clientes()

        mostrar_grilla()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Desea Eliminar El Registro?", vbYesNo + vbQuestion, "Eliminar")
        If valormensaje = vbYes Then
            Consulta_Mysql("Call SP_Borra_Registro_Tabla_Usuarios ('" & (txtUsuario.Text) & "')")

        End If

        actualizar_tabla_clientes()
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            mostrar(0)
        Else
            limpiar()
        End If
        mostrar_grilla()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        controles(False, True)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Acceso.Show()
        Me.Hide()
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        MiPos = 0
        mostrar(MiPos)
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If MiPos > 0 Then
            MiPos -= 1
            mostrar(MiPos)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If MiPos < DT.Rows.Count - 1 Then
            MiPos += 1
            mostrar(MiPos)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        MiPos = DT.Rows.Count - 1
        mostrar(MiPos)
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar_tabla_clientes()
        mostrar(0)
        mostrar_grilla()
    End Sub

    Private Sub grilla_busqueda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla_busqueda.CellContentClick
        txtUsuario.Text = grilla_busqueda.Item(0, grilla_busqueda.CurrentCell.RowIndex).Value
        Consulta_Mysql("Call SP_Actualiza_Grilla_Usuarios('" & (txtUsuario.Text) & "')")


        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            mostrar(0)
        End If
        actualizar_tabla_clientes()
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

    Private Sub txtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClave.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged

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
End Class