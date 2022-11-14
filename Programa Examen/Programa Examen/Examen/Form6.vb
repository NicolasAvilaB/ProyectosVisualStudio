Public Class administrador
    Dim varseleccion As Integer
    Sub controles_usuarios()
        btn_buscar_usuario.Enabled = True
        btn_crear_usuario.Enabled = True

        txt_busqueda_usuario.Enabled = False

        txt_rut.Enabled = False
        txt_nombre.Enabled = False
        txt_apellidos.Enabled = False
        cbx_privilegio.Enabled = False
        txt_clave.Enabled = False

        btn_guardar.Enabled = False
        btn_editar_usuario.Enabled = False
    End Sub
    Private Sub administrador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        controles_usuarios()
        controles_profesionales()
    End Sub
    Sub mostrar(ByVal i As Integer)
        If ds.Tables(dt.TableName).Rows.Count > 0 Then
            txt_rut.Text = ds.Tables(dt.TableName).Rows(i).Item("rut")
            txt_nombre.Text = ds.Tables(dt.TableName).Rows(i).Item("nombres")
            txt_apellidos.Text = ds.Tables(dt.TableName).Rows(i).Item("apellidos")
            cbx_privilegio.Text = ds.Tables(dt.TableName).Rows(i).Item("privilegio")
            txt_clave.Text = ds.Tables(dt.TableName).Rows(i).Item("clave")
        End If
    End Sub
    Sub no_formulario_datos()
        txt_rut.Enabled = False
        txt_nombre.Enabled = False
        txt_apellidos.Enabled = False
        cbx_privilegio.Enabled = False
        txt_clave.Enabled = False
    End Sub
    Sub si_formulario_datos()
        txt_rut.Enabled = True
        txt_nombre.Enabled = True
        txt_apellidos.Enabled = True
        cbx_privilegio.Enabled = True
        txt_clave.Enabled = True
    End Sub
    Sub buscar()
        miconsulta("exec verif_rut_usuario '" & (txt_busqueda_usuario.Text) & "'")
    End Sub

    Private Sub btn_buscar_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar_usuario.Click
        controles_usuarios()
        limpiar()
        btn_buscar_usuario.Enabled = False
        txt_busqueda_usuario.Enabled = True
        btn_buscar_x_rut.Enabled = True
        varseleccion = 1
        btn_cancelar.Enabled = False
    End Sub
    Sub limpiar()
        txt_busqueda_usuario.Clear()
        txt_rut.Clear()
        txt_nombre.Clear()
        txt_apellidos.Clear()
        txt_clave.Clear()
    End Sub
    Private Sub btn_buscar_x_rut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar_x_rut.Click

        If txt_busqueda_usuario.Text = "" Then
            MessageBox.Show("Complete el campo de busqueda")
        ElseIf txt_busqueda_usuario.Text <> "" Then
            buscar()
            limpiar()
            mostrar(0)
            If ds.Tables(dt.TableName).Rows.Count = 0 Then
                MessageBox.Show("El rut no pertenece a ningun usuario")
                btn_editar_usuario.Enabled = False
            Else 
            btn_editar_usuario.Enabled = True
            End If
        End If
    End Sub

    Private Sub btn_editar_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar_usuario.Click
        txt_nombre.Enabled = True
        txt_apellidos.Enabled = True
        cbx_privilegio.Enabled = True
        txt_clave.Enabled = True
        btn_buscar_x_rut.Enabled = False
        txt_busqueda_usuario.Enabled = False
        btn_guardar.Enabled = True
        btn_cancelar.Enabled = True
        btn_editar_usuario.Enabled = False
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If varseleccion = 2 And txt_apellidos.Text <> "" And txt_clave.Text <> "" And txt_nombre.Text <> "" And txt_rut.Text <> "" And cbx_privilegio.Text <> "" Then
            miconsulta2("exec verif_rut_usuario'" & (txt_rut.Text) & "' ")
            If ds2.Tables(dt2.TableName).Rows.Count = 1 Then
                MessageBox.Show("El usuario existe")
                btn_cancelar.Enabled = True
            ElseIf ds2.Tables(dt2.TableName).Rows.Count = 0 Then
                miconsulta("exec crear_usuario '" & (txt_nombre.Text) & "','" & (txt_apellidos.Text) & "','" & (txt_rut.Text) & "','" & (cbx_privilegio.Text) & "','" & (txt_clave.Text) & "'")
                btn_cancelar.Enabled = False
                limpiar()
                si_formulario_datos()
                MessageBox.Show("Usuario guardado exitosamente")
            End If
        ElseIf varseleccion = 1 And txt_apellidos.Text <> "" And txt_clave.Text <> "" And txt_nombre.Text <> "" And txt_rut.Text <> "" And cbx_privilegio.Text <> "" Then
            miconsulta("exec editar_usuario'" & (txt_nombre.Text) & "','" & (txt_apellidos.Text) & "','" & (cbx_privilegio.Text) & "','" & (txt_clave.Text) & "','" & (txt_rut.Text) & "'")
            btn_buscar_x_rut.Enabled = True
            txt_busqueda_usuario.Enabled = True
            btn_guardar.Enabled = False
            btn_cancelar.Enabled = False
            limpiar()
            no_formulario_datos()
            MessageBox.Show("Usuario editado exitosamente")
        Else
            MessageBox.Show("Complete los campos antes de guardar")
        End If
    End Sub

    Private Sub btn_crear_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear_usuario.Click
        varseleccion = 2
        controles_usuarios()
        limpiar()
        btn_buscar_usuario.Enabled = True
        btn_crear_usuario.Enabled = False
        btn_buscar_x_rut.Enabled = False
        si_formulario_datos()
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        If varseleccion = 2 Then
            btn_guardar.Enabled = True
            limpiar()
        ElseIf varseleccion = 1 Then
            btn_buscar_x_rut.Enabled = True
            txt_busqueda_usuario.Enabled = True
            btn_guardar.Enabled = False
            btn_cancelar.Enabled = False
            limpiar()
            no_formulario_datos()
            mostrar(0)
            btn_editar_usuario.Enabled = True
        End If
    End Sub
    Sub controles_profesionales()
        calendario.Enabled = False
        txt_busqueda_profesional.Enabled = True
        btn_buscar_profesional.Enabled = True
        txt_hora.Enabled = False
        txt_minutos.Enabled = False
    End Sub

    Sub buscar_2()
        miconsulta2("exec verificarprofesional '" & (txt_busqueda_profesional.Text) & "'")
    End Sub

    Sub buscar_3()
        miconsulta3("exec mostar_horas_disponinbles_por_prof '" & (txt_rut_profesional.Text) & "'")
        DataGridView1.DataSource = ds3.Tables(dt3.TableName)
    End Sub
    Sub mostrar_2(ByVal i As Integer)
        If ds2.Tables(dt2.TableName).Rows.Count > 0 Then
            txt_rut_profesional.Text = ds2.Tables(dt2.TableName).Rows(i).Item("rut")
            txt_nombres_profesional.Text = ds2.Tables(dt2.TableName).Rows(i).Item("nombres")
            txt_apellidos_profesional.Text = ds2.Tables(dt2.TableName).Rows(i).Item("apellidos")
            txt_agenda_a_cargo__profesional.Text = ds2.Tables(dt2.TableName).Rows(i).Item("especialidad")
            txt_id_pro.Text = ds2.Tables(dt2.TableName).Rows(i).Item("id_profesional")
        End If
    End Sub

    Private Sub btn_buscar_profesional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar_profesional.Click
        If txt_busqueda_profesional.Text = "" Then
            MessageBox.Show("Complete el campo de busqueda")
        ElseIf txt_busqueda_profesional.Text <> "" Then
            miconsulta("exec verificarprofesional '" & (txt_busqueda_profesional.Text) & "'")
            If ds.Tables(dt.TableName).Rows.Count = 0 Then
                MessageBox.Show("El usuario no existe")
            ElseIf ds.Tables(dt.TableName).Rows.Count > 0 Then
                buscar_2()
                mostrar_2(0)
                calendario.Enabled = True
                txt_hora.Enabled = True
                txt_minutos.Enabled = True
                btn_agregar.Enabled = True
                buscar_3()
            End If
        End If
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        If txt_hora.Text = "" Or txt_minutos.Text = "" Then
            MessageBox.Show("Complete los campos de hora y minutos")
        ElseIf txt_hora.Text <> "" And txt_minutos.Text <> "" And txt_hora.Text >= 0 And txt_hora.Text <= 23 And txt_minutos.Text >= 0 And txt_minutos.Text < 60 Then
            Dim mifecha As Date
            Dim mifechaOK As String
            mifecha = calendario.Text
            mifechaOK = mifecha.ToString("yyyy-MM-dd")
            miconsulta2("exec verificarhora '" & (txt_hora.Text) & "','" & (txt_minutos.Text) & "','" & (mifechaOK) & "'," & (txt_id_pro.Text) & "")
            If ds2.Tables(dt2.TableName).Rows.Count = 1 Then
                MessageBox.Show("La fecha ya fue asignada")
            ElseIf ds2.Tables(dt2.TableName).Rows.Count = 0 Then
                miconsulta2("exec insertar_hora_disponible " & (txt_id_pro.Text) & ",'" & (mifechaOK) & "','" & (txt_hora.Text) & "','" & (txt_minutos.Text) & "'")
                MessageBox.Show("Hora guardada satisfactoriamente")
                txt_hora.Clear()
                txt_minutos.Clear()
                buscar_3()
            End If
        Else
            MessageBox.Show("La hora no es valida")
        End If
    End Sub

    Private Sub AdministraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministraToolStripMenuItem.Click
        MessageBox.Show("Usted ya esta aqui")
    End Sub

    Private Sub PACIENTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PACIENTESToolStripMenuItem.Click
        Adm_pacientes.Show()
        Me.Close()
    End Sub

    Private Sub AnularCitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularCitaToolStripMenuItem.Click
        Anular_cita.Show()
        Me.Close()
    End Sub

    Private Sub CitacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CitacionToolStripMenuItem.Click
        Citar_paciente.Show()
        Me.Close()
    End Sub

    Private Sub CERRARSESIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CERRARSESIONToolStripMenuItem.Click
        Login.MenuStrip1.Visible = False
        Login.lbl_info.Visible = False

        Login.lbl_clave.Visible = True
        Login.lbl_usuario.Visible = True
        Login.txt_clave.Visible = True
        Login.txt_usuario.Visible = True
        Login.btn_acceder.Visible = True

        Login.MenuStrip2.Visible = False

        Login.txtprivilegio.Clear()
        Login.txt_rut.Clear()
        Citar_paciente.Close()
        Me.Close()
        Adm_pacientes.Close()
        Adm_citas.Close()
        Carpeta_clinica.Close()
        Anular_cita.Close()
    End Sub
End Class