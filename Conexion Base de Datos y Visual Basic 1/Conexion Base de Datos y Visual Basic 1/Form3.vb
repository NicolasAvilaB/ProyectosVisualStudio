Public Class Form3
    Dim MiPos As Integer
    Dim VarSeleccion As Integer
    Sub limpiar()
        txtRUT.Clear()
        txtNOMBRE.Clear()
        txtDIRECCION.Clear()
        txtTELEFONO.Clear()
    End Sub
    Sub controles(ByVal a As Boolean, ByVal b As Boolean)
        BTNuevo.Enabled = b
        BTEliminar.Enabled = b
        BTModificar.Enabled = b
        BTImprimir.Enabled = b
        BTGuardar.Enabled = a
        BTCancelar.Enabled = a

        txtRUT.ReadOnly = b
        txtNOMBRE.ReadOnly = b
        txtDIRECCION.ReadOnly = b
        txtTELEFONO.ReadOnly = b

        BTPrimero.Enabled = b
        BTUltimo.Enabled = b
        BTAnterior.Enabled = b
        BTSiguiente.Enabled = b

    End Sub

    Private Sub BTNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNuevo.Click
        limpiar()
        controles(True, False)
        VarSeleccion = 1

    End Sub

    Private Sub BTModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTModificar.Click
        controles(True, False)
        VarSeleccion = 2 'Modificar'
    End Sub

    Private Sub BTCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCancelar.Click
        controles(False, True) 'Cancelar'
    End Sub
    Sub VerificarTabla()
        MiConsulta("select * From Clientes")

    End Sub
    Sub Mostrar(ByVal i As Integer)
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            txtRUT.Text = DS.Tables(DT.TableName).Rows(i).Item("Rut")
            txtNOMBRE.Text = DS.Tables(DT.TableName).Rows(i).Item("Nombre")
            txtDIRECCION.Text = DS.Tables(DT.TableName).Rows(i).Item("Direccion")
            txtTELEFONO.Text = DS.Tables(DT.TableName).Rows(i).Item("Telefono")
        End If
    End Sub
    Sub MostrarDataGrid()
        DataGridView2.DataSource = DS.Tables(DT.TableName)
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VerificarTabla()
        Mostrar(0)
        MostrarDataGrid()
    End Sub

    Private Sub BTPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPrimero.Click
        Mostrar(0)
    End Sub

    Private Sub BTAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAnterior.Click
        If MiPos > 0 Then
            MiPos -= 1
            Mostrar(MiPos)
        End If
    End Sub

    Private Sub BTSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSiguiente.Click
        If MiPos < DT.Rows.Count - 1 Then
            MiPos += 1
            Mostrar(MiPos)

        End If
    End Sub

    Private Sub BTUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTUltimo.Click
        MiPos = DT.Rows.Count - 1
        Mostrar(MiPos)

    End Sub
    Sub BUSCAR()
        MiConsulta2(" select * from clientes where " & (cbBUSCAR.Text) & " LIKE '" & (txtBUSCAR.Text & "%") & "' ")
        DataGridView1.DataSource = DS2.Tables(DT2.TableName)
    End Sub

    Private Sub cbBUSCAR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBUSCAR.SelectedIndexChanged
        If cbBUSCAR.Text <> "" Then
            BUSCAR() 'buscar desde combobox'
        End If
    End Sub

    Private Sub txtBUSCAR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBUSCAR.TextChanged
        If cbBUSCAR.Text <> "" Then
            BUSCAR() 'buscar desde text'
        End If
    End Sub

    Private Sub BTGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTGuardar.Click
        If VarSeleccion = 1 Then
            MiConsulta("Exec SpIngreseCliente '" & (txtRUT.Text) & "', '" & (txtNOMBRE.Text) & "', '" & (txtDIRECCION.Text) & "', " & (txtTELEFONO.Text) & "")
            MsgBox("Datos Ingresados Correctamente")
            'Modificar'
        ElseIf VarSeleccion = 2 Then
            MiConsulta("Update clientes SET Nombre='" & (txtNOMBRE.Text) & "', DIRECCION='" & (txtDIRECCION.Text) & "', TELEFONO=" & (txtTELEFONO.Text) & " Where RUT='" & (txtRUT.Text) & "'")
            MsgBox("Datos MOdificados Correctamente")

        End If
    End Sub

    Private Sub BTSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSalir.Click
        Application.Exit()
    End Sub

    Private Sub BTEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTEliminar.Click
        Dim valormensaje As Integer 'Eliminar'
        valormensaje = MsgBox("¿DESEA ELIMINAR?", vbYesNo + vbQuestion, "ELIMINACION PERSUACION")
        If valormensaje = vbYes Then
            MiConsulta("Delete From clientes where rut ='" & (txtRUT.Text) & "' ")

        End If

        VerificarTabla()
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Mostrar(0)
        Else
            limpiar()
        End If
        MostrarDataGrid()
    End Sub
End Class