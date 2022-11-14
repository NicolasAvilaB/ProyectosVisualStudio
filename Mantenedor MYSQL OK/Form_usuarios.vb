Public Class Form_Usuarios
    Dim VarSeleccion As Integer
    Dim MiPos As Integer

    Sub limpiar()
        txtUsuario.Clear()
        txtClave.Clear()
       
    End Sub

    Sub controles(ByVal a As Boolean, ByVal b As Boolean)
        btnNuevo.Enabled = b
        btnEliminar.Enabled = b
        btnModificar.Enabled = b
        btnImprimir.Enabled = b
        btnGuardar.Enabled = a
        btnCancelar.Enabled = a

        txtUsuario.ReadOnly = b
        txtClave.ReadOnly = b
       

        btnPrimero.Enabled = b
        btnUltimo.Enabled = b
        btnAnterior.Enabled = b
        btnSiguiente.Enabled = b
    End Sub

    Sub actualizar_tabla_clientes()

        MiConsulta("select * from usuarios")

    End Sub

    Sub mostrar_grilla()
        grilla.DataSource = DS.Tables(DT.TableName)
        conexion.Close()
    End Sub

    Sub mostrar(ByVal i As Integer)

        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            txtUsuario.Text = DS.Tables(DT.TableName).Rows(i).Item("usuario")
            txtClave.Text = DS.Tables(DT.TableName).Rows(i).Item("clave")
            
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

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If VarSeleccion = 1 Then
            MiConsulta("INSERT INTO usuarios (USUARIO,CLAVE) VALUES ('" & (txtUsuario.Text) & "'," & (txtClave.Text) & ")")
            DA.SelectCommand = SC
            DA.Fill(DT)
            MsgBox("Datos Ingresados Correctamente")

        ElseIf VarSeleccion = 2 Then
            MiConsulta("UPDATE usuarios SET USUARIO='" & (txtUsuario.Text) & " where CLAVE='" & (txtClave.Text) & "'")

        End If

        actualizar_tabla_clientes()
        controles(False, True)
        mostrar_grilla()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        controles(False, True)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿desea eliminar?", vbYesNo + vbQuestion, "Eliminar")
        If valormensaje = vbYes Then
            MiConsulta("delete from usuarios where usuario ='" & (txtUsuario.Text) & "'")

        End If

        actualizar_tabla_clientes()
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            mostrar(0)
        Else
            limpiar()
        End If
        mostrar_grilla()
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        MiPos = 0
        mostrar(MiPos)
    End Sub
    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If MiPos < DT.Rows.Count - 1 Then
            MiPos += 1
            mostrar(MiPos)
        End If
    End Sub
    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If MiPos > 0 Then
            MiPos -= 1
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

    Private Sub txtClave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress
        If Not IsNumeric(e.KeyChar) Then e.Handled = True

        If Char.IsControl(e.KeyChar) = True Then e.Handled = False

    End Sub




    Private Sub grilla_busqueda_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grilla.CellClick

        MiConsulta("select * from usuarios where usuario='" & (txtUsuario.Text) & "'")

        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            mostrar(0)
        End If
        actualizar_tabla_clientes()

    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If IsNumeric(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub Form_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar_tabla_clientes()
        mostrar(0)
        mostrar_grilla()
    End Sub
End Class