Public Class Form3
    Dim VarSeleccion As Integer
    Dim MiPos As Integer

    Sub limpiar()
        txt_rut.Clear()
        txt_nombre.Clear()
        txt_direccion.Clear()
        txt_telefono.Clear()
    End Sub

    Sub controles(ByVal a As Boolean, ByVal b As Boolean)
        btnNuevo.Enabled = b
        btnEliminar.Enabled = b
        btnModificar.Enabled = b
        btnImprimir.Enabled = b
        btnGuardar.Enabled = a
        btnCancelar.Enabled = a

        txt_rut.ReadOnly = b
        txt_nombre.ReadOnly = b
        txt_direccion.ReadOnly = b
        txt_telefono.ReadOnly = b

        btnPrimero.Enabled = b
        btnUltimo.Enabled = b
        btnAnterior.Enabled = b
        btnSiguiente.Enabled = b
    End Sub

    Sub actualizar_tabla_clientes()

        MiConsulta("select * from clientes")

    End Sub

    Sub mostrar_grilla()
        grilla.DataSource = DS.Tables(DT.TableName)
        conexion.Close()
    End Sub

    Sub BUSCAR()

        MiConsulta("SELECT * from clientes WHERE " & (cmb_buscar.Text) & " LIKE '" & (txt_buscar.Text & "%") & "' ")

    End Sub

    Sub mostrar(ByVal i As Integer)

        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            txt_rut.Text = DS.Tables(DT.TableName).Rows(i).Item("rut")
            txt_nombre.Text = DS.Tables(DT.TableName).Rows(i).Item("nombre")
            txt_direccion.Text = DS.Tables(DT.TableName).Rows(i).Item("direccion")
            txt_telefono.Text = DS.Tables(DT.TableName).Rows(i).Item("telefono")
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
        controles(True, False)
        VarSeleccion = 1
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        controles(True, False)
        VarSeleccion = 2
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If VarSeleccion = 1 Then
            MiConsulta("Begin SP_INSERTINTOCLIENTES ('" & (txt_rut.Text) & "','" & (txt_nombre.Text) & "','" & (txt_direccion.Text) & "','" & (txt_telefono.Text) & "'); end;")
            DA.SelectCommand = SC
            DA.Fill(DT)
            MsgBox("Datos Ingresados Correctamente")

        ElseIf VarSeleccion = 2 Then
            MiConsulta("Begin MODIFICAICHON ('" & (txt_rut.Text) & "','" & (txt_nombre.Text) & "','" & (txt_direccion.Text) & "','" & (txt_telefono.Text) & "'); end;")

        End If

        actualizar_tabla_clientes()
        controles(False, True)
        mostrar_grilla()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        controles(False, True)
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        MiPos = 0
        mostrar(MiPos)
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If MiPos > 0 Then
            MiPos -= 1
            mostrar(MiPos)
        End If
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If MiPos < DT.Rows.Count - 1 Then
            MiPos += 1
            mostrar(MiPos)
        End If
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        MiPos = DT.Rows.Count - 1
        mostrar(MiPos)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub txt_telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono.KeyPress
        If Not IsNumeric(e.KeyChar) Then e.Handled = True

        If Char.IsControl(e.KeyChar) = True Then e.Handled = False

    End Sub

    Private Sub cmb_buscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_buscar.SelectedIndexChanged
        If cmb_buscar.Text <> "" Then
            BUSCAR()
        End If
    End Sub

    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        If cmb_buscar.Text <> "" Then
            BUSCAR()
        End If
    End Sub

    Private Sub grilla_busqueda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grilla_busqueda.CellContentClick
        txt_rut.Text = grilla_busqueda.Item(0, grilla_busqueda.CurrentCell.RowIndex).Value
        MiConsulta("select * from clientes where rut='" & (txt_rut.Text) & "'")

        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            mostrar(0)
        End If
        actualizar_tabla_clientes()

    End Sub


    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If IsNumeric(e.KeyChar) Then e.Handled = True

    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar_tabla_clientes()
        mostrar(0)
        mostrar_grilla()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Deseas Eliminar el Registro?", vbYesNo + vbQuestion, "Eliminaichon")
        If valormensaje = vbYes Then
            MiConsulta("Begin ELIMINAICHON('" & (txt_rut.Text) & "'); end;")
        End If

        actualizar_tabla_clientes()
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            mostrar(0)
        Else
            limpiar()
        End If

    End Sub
End Class