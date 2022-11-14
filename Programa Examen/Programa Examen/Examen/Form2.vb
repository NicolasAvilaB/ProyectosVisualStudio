Public Class Citar_paciente
    Dim MiPos As Integer
    Dim sexo As String
    Sub controles_a(ByVal a As Boolean, ByVal b As Boolean)
        cbx_agenda.Enabled = b
        cbx_hora.Enabled = b
        cbx_profesional.Enabled = b
        cbxfecha.Enabled = b
        txt_folio.Enabled = b

        txt_rut_busqueda.Enabled = a
        btn_citar.Enabled = a

        txt_apellido_pat.Enabled = b
        txt_apellido_mat.Enabled = b
        txt_domicilio.Enabled = b
        txt_fono.Enabled = b
        txt_nombre.Enabled = b
        txt_prevision.Enabled = b
        txt_rut.Enabled = b

        btn_editar_paciente.Enabled = b
        btn_guardar.Enabled = b
        btn_grabar.Enabled = b

        btn_ok_agenda.Enabled = b
        btn_ok_fecha.Enabled = b
        btn_ok_hora.Enabled = b
        btn_ok_profesional.Enabled = b
        btn_limpiar.Enabled = b

        rbHombre.Enabled = b
        rbMujer.Enabled = b
    End Sub

    Sub limpiar_todo()
        txt_folio.Clear()
        txt_rut_busqueda.Clear()
        txt_apellido_pat.Clear()
        txt_apellido_mat.Clear()
        txt_domicilio.Clear()
        txt_fono.Clear()
        txt_nombre.Clear()
        txt_prevision.Clear()
        txt_rut.Clear()
    End Sub

    Sub mostrar(ByVal i As Integer)
        If ds.Tables(dt.TableName).Rows.Count > 0 Then
            txt_rut.Text = ds.Tables(dt.TableName).Rows(i).Item("rut_paciente")
            txt_nombre.Text = ds.Tables(dt.TableName).Rows(i).Item("nombres")
            txt_apellido_pat.Text = ds.Tables(dt.TableName).Rows(i).Item("apellido_paterno")
            txt_apellido_mat.Text = ds.Tables(dt.TableName).Rows(i).Item("apellido_materno")
            txt_domicilio.Text = ds.Tables(dt.TableName).Rows(i).Item("domicilio")
            txt_prevision.Text = ds.Tables(dt.TableName).Rows(i).Item("prevision")
            txt_fono.Text = ds.Tables(dt.TableName).Rows(i).Item("fono")
            sexo = ds.Tables(dt.TableName).Rows(i).Item("sexo")
            If sexo = "Hombre" Then
                rbHombre.Checked = True
            Else
                rbMujer.Checked = True
            End If
        End If
    End Sub

    Sub llenarcombobox_agenda()
        miconsulta("exec llenar_combo_agenda")
        Dim totalregistros As Integer = ds.Tables(dt.TableName).Rows.Count
        If totalregistros > 0 Then
            For i = 0 To totalregistros - 1
                cbx_agenda.Items.Add(ds.Tables(dt.TableName).Rows(i).Item("especialidad"))
            Next
        End If
    End Sub
    Sub llenarcombobox_profesionales()
        miconsulta("exec llenar_combo_profesionales'" & (cbx_agenda.Text) & "'")
        Dim totalregistros As Integer = ds.Tables(dt.TableName).Rows.Count
        If totalregistros > 0 Then
            For i = 0 To totalregistros - 1
                cbx_profesional.Items.Add(ds.Tables(dt.TableName).Rows(i).Item("nombres_apellidos"))
            Next
        End If
    End Sub

    Sub llenarcombobox_hora()
        Dim mifecha As Date
        Dim mifechaOK As String
        mifecha = cbxfecha.Text
        mifechaOK = mifecha.ToString("yyyy-MM-dd")

        miconsulta("exec llenarcombobox_hora '" & (txt_rut_prof.Text) & "','" & (mifechaOK) & "'")
        Dim totalregistros As Integer = ds.Tables(dt.TableName).Rows.Count
        If totalregistros > 0 Then
            For i = 0 To totalregistros - 1
                cbx_hora.Items.Add(ds.Tables(dt.TableName).Rows(i).Item("hora"))
            Next
        End If
    End Sub
    Sub llenarcombobox_fecha()
        miconsulta("exec llenarcombobox_fecha '" & (txt_rut_prof.Text) & "'")
        Dim totalregistros As Integer = ds.Tables(dt.TableName).Rows.Count
        If totalregistros > 0 Then
            For i = 0 To totalregistros - 1
                cbxfecha.Items.Add(ds.Tables(dt.TableName).Rows(i).Item("fecha"))
            Next
        End If
    End Sub
    Sub mostrar_rut_pro(ByVal i As Integer)
        miconsulta("exec mostrar_rut_profesional'" & (cbx_profesional.Text) & "'")
        If ds.Tables(dt.TableName).Rows.Count > 0 Then
            txt_rut_prof.Text = ds.Tables(dt.TableName).Rows(i).Item("rut")
        End If
    End Sub
    Sub mostrar_id_pro(ByVal i As Integer)
        miconsulta("exec mostrar_id_profesional'" & (txt_rut_prof.Text) & "'")
        If ds.Tables(dt.TableName).Rows.Count > 0 Then
            txt_id.Text = ds.Tables(dt.TableName).Rows(i).Item("id_profesional")
        End If
    End Sub
    Sub limpiar_combos()
        cbx_agenda.Items.Clear()
        cbx_hora.Items.Clear()
        cbx_profesional.Items.Clear()
        cbxfecha.Items.Clear()
        txt_rut_prof.Clear()
        txt_id.Clear()
    End Sub

    Private Sub CitacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CitacionToolStripMenuItem.Click
        MessageBox.Show("Usted ya se encuentra en este item")
    End Sub

    Private Sub btn_editar_paciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar_paciente.Click
        txt_apellido_mat.Enabled = True
        txt_apellido_pat.Enabled = True
        txt_domicilio.Enabled = True
        txt_fono.Enabled = True
        txt_nombre.Enabled = True
        txt_prevision.Enabled = True
        btn_guardar.Enabled = True
        btn_editar_paciente.Enabled = False
        btn_grabar.Enabled = False
        rbMujer.Enabled = True
        rbHombre.Enabled = True
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If txt_rut.Text <> "" And txt_nombre.Text <> "" And txt_domicilio.Text <> "" And txt_apellido_pat.Text <> "" And txt_apellido_mat.Text <> "" And txt_domicilio.Text <> "" And txt_fono.Text <> "" And txt_prevision.Text <> "" Then
            If rbMujer.Checked = True Then
                miconsulta("exec editar_paciente '" & (txt_nombre.Text) & "','" & (txt_apellido_pat.Text) & "','" & (txt_apellido_mat.Text) & "','" & (txt_domicilio.Text) & "','" & (txt_prevision.Text) & "','" & (txt_fono.Text) & "','Mujer','" & (Login.txt_usuario.Text) & "','" & (txt_rut.Text) & "'")
                MsgBox("Datos ingresados correctamente")
            End If
            If rbHombre.Checked = True Then
                miconsulta("exec editar_paciente '" & (txt_nombre.Text) & "','" & (txt_apellido_pat.Text) & "','" & (txt_apellido_mat.Text) & "','" & (txt_domicilio.Text) & "','" & (txt_prevision.Text) & "','" & (txt_fono.Text) & "','Hombre','" & (Login.txt_usuario.Text) & "','" & (txt_rut.Text) & "'")
                MsgBox("Datos ingresados correctamente")
            End If
            txt_apellido_mat.Enabled = False
            txt_apellido_pat.Enabled = False
            txt_domicilio.Enabled = False
            txt_fono.Enabled = False
            txt_nombre.Enabled = False
            txt_prevision.Enabled = False
            btn_guardar.Enabled = False
            btn_editar_paciente.Enabled = True
            rbMujer.Enabled = False
            rbHombre.Enabled = False
            If cbx_hora.Text <> "" Then
                btn_grabar.Enabled = True
            End If
        Else
            MessageBox.Show("Complete todos los campos del formulario")
        End If
    End Sub


    Private Sub btn_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        If cbx_agenda.Text <> "" And cbx_hora.Text <> "" And cbx_profesional.Text <> "" And cbxfecha.Text <> "" Then

            Dim mifecha As Date
            Dim mifechaOK As String
            mifecha = cbxfecha.Text
            mifechaOK = mifecha.ToString("yyyy-MM-dd")

            miconsulta("exec citar_1 '" & (txt_rut_busqueda.Text) & "','" & (cbx_agenda.Text) & "'," & (txt_id.Text) & ",'" & (mifechaOK) & "','" & (cbx_hora.Text) & "'")
            miconsulta("exec citar_2 '" & (mifechaOK) & "','" & (cbx_hora.Text) & "'")
            MessageBox.Show("Citacion grabada con exito")
            limpiar_todo()
            limpiar_combos()
            controles_a(True, False)
        Else
            MessageBox.Show("Complete todos los campos de cita")
        End If
    End Sub
    Sub crear_nueva_cita()
        miconsulta("exec asignar_folio")

        If TypeOf (ds.Tables(dt.TableName).Rows(0).Item("n_folio")) Is DBNull Then
            txt_folio.Text = 1
        Else
            txt_folio.Text = ds.Tables(dt.TableName).Rows(0).Item("n_folio") + 1
        End If
        conexion.Close()


    End Sub
    Private Sub btn_citar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_citar.Click
        If txt_rut_busqueda.Text = "" Then
            MessageBox.Show("Complete el campo de busqueda")
        ElseIf txt_rut_busqueda.Text <> "" Then
            miconsulta("exec verificarpaciente '" & (txt_rut_busqueda.Text) & "'")
            If ds.Tables(dt.TableName).Rows.Count = 1 Then
                mostrar(0)
                llenarcombobox_agenda()
                crear_nueva_cita()
                cbx_agenda.Enabled = True
                btn_ok_agenda.Enabled = True
                btn_limpiar.Enabled = True
                btn_editar_paciente.Enabled = True
                txt_rut_busqueda.Enabled = False
                btn_citar.Enabled = False
            Else
                MessageBox.Show("Paciente no existe")
            End If
        End If
    End Sub

    Private Sub Citar_paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        controles_a(True, False)
    End Sub

    Private Sub btn_ok_agenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok_agenda.Click
        If cbx_agenda.Text <> "" Then
            cbx_profesional.Enabled = True
            btn_ok_profesional.Enabled = True
            cbx_agenda.Enabled = False
            btn_ok_agenda.Enabled = False
            llenarcombobox_profesionales()
        Else
            MessageBox.Show("Seleccione tipo de agenda")
        End If
    End Sub

    Private Sub btn_ok_profesional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok_profesional.Click
        If cbx_profesional.Text <> "" Then
            mostrar_rut_pro(0)
            mostrar_id_pro(0)
            cbxfecha.Enabled = True
            btn_ok_fecha.Enabled = True
            cbx_profesional.Enabled = False
            btn_ok_profesional.Enabled = False
            llenarcombobox_fecha()
        Else
            MessageBox.Show("Seleccione el profesional")
        End If
        If cbxfecha.Items.Count = 0 Then
            MessageBox.Show("El funcionario no tiene fechas disponibles")
            cbx_profesional.Enabled = True

            btn_ok_profesional.Enabled = True

            btn_ok_fecha.Enabled = False
            cbxfecha.Enabled = False
        End If

    End Sub

    Private Sub btn_ok_fecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok_fecha.Click
        If cbxfecha.Text <> "" Then
            cbx_hora.Enabled = True
            btn_ok_hora.Enabled = True
            cbxfecha.Enabled = False
            btn_ok_fecha.Enabled = False
            llenarcombobox_hora()
        Else
            MessageBox.Show("Seleccione la fecha de la citacion")
        End If
    End Sub

    Private Sub btn_ok_hora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok_hora.Click
        If cbx_hora.Text <> "" Then
            cbx_hora.Enabled = False
            btn_ok_hora.Enabled = False
            btn_grabar.Enabled = True
        Else
            MessageBox.Show("Seleccione la fecha de la citacion")
        End If
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        controles_a(True, False)
        limpiar_combos()
        limpiar_todo()
    End Sub

    Private Sub AnularCitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularCitaToolStripMenuItem.Click
        Anular_cita.Show()
        Me.Close()
    End Sub

    Private Sub PACIENTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PACIENTESToolStripMenuItem.Click
        Adm_pacientes.Show()
        Me.Close()
    End Sub

    Private Sub AdministraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministraToolStripMenuItem.Click
        administrador.Show()
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
        Me.Close()
        Adm_pacientes.Close()
        Adm_citas.Close()
        Carpeta_clinica.Close()
        administrador.Close()
        Anular_cita.Close()
    End Sub
End Class