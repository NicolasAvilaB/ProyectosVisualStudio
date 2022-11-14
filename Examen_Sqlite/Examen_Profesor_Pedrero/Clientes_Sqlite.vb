Public Class Clientes_Sqlite
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

        Consulta_Sqlite("select * from clientes")

    End Sub

    Sub mostrar_grilla()
        grilla.DataSource = DS5.Tables(DT5.TableName)
        Conexion_Sqlite.Close()
    End Sub

    Sub BUSCAR()

        Consulta_Sqlite("SELECT * from clientes WHERE " & (cmb_buscar.Text) & " LIKE '" & (txt_buscar.Text & "%") & "' ")

    End Sub

    Sub mostrar(ByVal i As Integer)

        If DS5.Tables(DT5.TableName).Rows.Count > 0 Then
            Rut.Text = DS5.Tables(DT5.TableName).Rows(i).Item("Rut")
            Nombre.Text = DS5.Tables(DT5.TableName).Rows(i).Item("Nombre")
            Direccion.Text = DS5.Tables(DT5.TableName).Rows(i).Item("Direccion")
            Telefono.Text = DS5.Tables(DT5.TableName).Rows(i).Item("Telefono")
        End If
    End Sub

    Private Sub Form_clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        actualizar_tabla_clientes()
        mostrar(0)
        mostrar_grilla()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
        controles(True, False)
        Rut.Enabled = True
        Nombre.Enabled = True
        Direccion.Enabled = True
        Telefono.Enabled = True
        VarSeleccion = 1
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        controles(True, False)
        Rut.Enabled = True
        Nombre.Enabled = True
        Direccion.Enabled = True
        Telefono.Enabled = True
        VarSeleccion = 2
        
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click


        Consulta_Sqlite("select * from clientes where rut = '" & (Rut.Text) & "' ")
        If (Rut.Text = "") Then
            MsgBox("El Campo Rut Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Nombre.Text = "") Then
            MsgBox("El Campo Nombre Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Direccion.Text = "") Then
            MsgBox("El Campo Direccion Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Telefono.Text = "") Then
            MsgBox("El Campo Telefono Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf DS5.Tables(DT5.TableName).Rows.Count > 0 Then

            MsgBox("El Rut: " + Rut.Text + " Ya Existe en el Registro", vbCritical, "Error Fatal")

        ElseIf VarSeleccion = 1 Then
            Try

                Consulta_Sqlite("INSERT INTO clientes (RUT,NOMBRE,DIRECCION,TELEFONO) VALUES ('" & (Rut.Text) & "','" & (Nombre.Text) & "','" & (Direccion.Text) & "'," & (Telefono.Text) & ")")
                MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")
            Catch ex As Exception
                DA5.SelectCommand = SC5

                DA5.Fill(DT5)


            End Try
            actualizar_tabla_clientes()
            controles(False, True)
            Rut.Enabled = False
            Nombre.Enabled = False
            Direccion.Enabled = False
            Telefono.Enabled = False
            mostrar_grilla()
        ElseIf VarSeleccion = 2 Then

            Consulta_Sqlite("UPDATE clientes SET NOMBRE='" & (Nombre.Text) & "', DIRECCION='" & (Direccion.Text) & "',TELEFONO =" & (Telefono.Text) & " where RUT='" & (Rut.Text) & "'")

            MsgBox("Datos Modificados Correctamente")
            actualizar_tabla_clientes()
            controles(False, True)
            Rut.Enabled = False
            Nombre.Enabled = False
            Direccion.Enabled = False
            Telefono.Enabled = False
            mostrar_grilla()
        End If
        

       

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        controles(False, True)
        Rut.Enabled = False
        Nombre.Enabled = False
        Direccion.Enabled = False
        Telefono.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim valormensaje As Integer
        If Me.grilla.Rows.Count = 0 Then
            MsgBox("Error Fatal: No Hay Clientes Agregados, Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
            valormensaje = MsgBox("¿desea eliminar?", vbYesNo + vbQuestion, "Eliminar")
            If valormensaje = vbYes Then
                Consulta_Sqlite("delete from clientes where rut ='" & (Rut.Text) & "' ")

            End If

            actualizar_tabla_clientes()
            If DS5.Tables(DT5.TableName).Rows.Count > 0 Then
                mostrar(0)
            Else
                limpiar()
            End If
        End If
        mostrar_grilla()
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        MiPos = 0
        mostrar(MiPos)
    End Sub
    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If MiPos < DT5.Rows.Count - 1 Then
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
        MiPos = DT5.Rows.Count - 1
        mostrar(MiPos)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub txt_telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Telefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
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

    Private Sub grilla_busqueda_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grilla_busqueda.CellClick

    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nombre.KeyPress
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Clientes_Sqlite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar_tabla_clientes()
        mostrar(0)
        mostrar_grilla()
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

    Private Sub Telefono_TextChanged(sender As Object, e As EventArgs) Handles Telefono.TextChanged

    End Sub

    Private Sub Direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Direccion.KeyPress
       
    End Sub

    Private Sub Direccion_TextChanged(sender As Object, e As EventArgs) Handles Direccion.TextChanged

    End Sub

    Private Sub Nombre_TextChanged(sender As Object, e As EventArgs) Handles Nombre.TextChanged

    End Sub
End Class