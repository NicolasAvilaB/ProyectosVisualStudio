Public Class Adm_citas
    Dim MiPos As Integer
    Sub limpieza()
        txt_apellido_mat.Clear()
        txt_apellido_pat.Clear()
        txt_domicilio.Clear()
        txt_fono.Clear()
        txt_hora.Clear()
        txt_nombre.Clear()
        txt_prevision.Clear()
        txt_rut.Clear()
        txt_sexo.Clear()
    End Sub
    Sub buscar()
        If rb_pendientes.Checked = True And cbx_busqueda.Text <> "" Then

            Dim mifecha As Date
            Dim mifechaOK As String
            mifecha = cbx_busqueda.Text
            mifechaOK = mifecha.ToString("yyyy-MM-dd")

            miconsulta("exec buscar_citas 'pendiente','" & (mifechaOK) & "'," & (txt_id_medico.Text) & "")
            DataGridView1.DataSource = ds.Tables(dt.TableName)
        End If
        If rb_anteriores.Checked = True And cbx_busqueda.Text <> "" Then

            Dim mifecha As Date
            Dim mifechaOK As String
            mifecha = cbx_busqueda.Text
            mifechaOK = mifecha.ToString("yyyy-MM-dd")

            miconsulta("exec buscar_citas 'realizada','" & (mifechaOK) & "'," & (txt_id_medico.Text) & "")
            DataGridView1.DataSource = ds.Tables(dt.TableName)
        End If
    End Sub
    Sub mostrar(ByVal i As Integer)
        If ds.Tables(dt.TableName).Rows.Count > 0 Then
            txt_sexo.Text = ds.Tables(dt.TableName).Rows(i).Item("sexo")
            txt_hora.Text = ds.Tables(dt.TableName).Rows(i).Item("hora")
            txt_rut.Text = ds.Tables(dt.TableName).Rows(i).Item("rut_paciente")
            txt_nombre.Text = ds.Tables(dt.TableName).Rows(i).Item("nombres")
            txt_apellido_pat.Text = ds.Tables(dt.TableName).Rows(i).Item("apellido_paterno")
            txt_apellido_mat.Text = ds.Tables(dt.TableName).Rows(i).Item("apellido_materno")
            txt_domicilio.Text = ds.Tables(dt.TableName).Rows(i).Item("domicilio")
            txt_prevision.Text = ds.Tables(dt.TableName).Rows(i).Item("prevision")
            txt_fono.Text = ds.Tables(dt.TableName).Rows(i).Item("fono")
        End If
    End Sub
    Sub controles_avanzar(ByVal a As Boolean, ByVal b As Boolean)
        btn_anterior.Enabled = a
        btn_ultimo.Enabled = a
        btn_siguiente.Enabled = a
        btn_primero.Enabled = a
    End Sub

    Sub llenarcombobox_busqueda()
        If rb_anteriores.Checked = True Then
            miconsulta("exec llenar_combo_fechas_de_citas 'realizada'," & (txt_id_medico.Text) & "")
            Dim totalregistros As Integer = ds.Tables(dt.TableName).Rows.Count
            If totalregistros > 0 Then
                For i = 0 To totalregistros - 1
                    cbx_busqueda.Items.Add(ds.Tables(dt.TableName).Rows(i).Item("fecha"))
                Next
            End If
        End If
        If rb_pendientes.Checked = True Then
            miconsulta("exec llenar_combo_fechas_de_citas 'pendiente'," & (txt_id_medico.Text) & "")
            Dim totalregistros As Integer = ds.Tables(dt.TableName).Rows.Count
            If totalregistros > 0 Then
                For i = 0 To totalregistros - 1
                    cbx_busqueda.Items.Add(ds.Tables(dt.TableName).Rows(i).Item("fecha"))
                Next
            End If
        End If

    End Sub
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If cbx_busqueda.Text = "" Then
            MessageBox.Show("Complete todos los campos de busqueda")
        ElseIf cbx_busqueda.Text <> "" And rb_pendientes.Checked = True Then

            Dim mifecha As Date
            Dim mifechaOK As String
            mifecha = cbx_busqueda.Text
            mifechaOK = mifecha.ToString("yyyy-MM-dd")

            miconsulta2("exec buscar_citas_pendientes'" & (mifechaOK) & "', " & (txt_id_medico.Text) & "")
            If ds2.Tables(dt2.TableName).Rows.Count >= 1 Then
                DataGridView1.DataSource = Nothing
                rb_anteriores.Enabled = False
                rb_pendientes.Enabled = False
                BTN_OK.Enabled = False
                btn_abrir_ficha.Enabled = True
                controles_avanzar(True, False)
                buscar()
                mostrar(0)
            Else
                MessageBox.Show("Esta fecha ya no tiene mas pacientes que mostrar")
            End If
        ElseIf cbx_busqueda.Text <> "" And rb_anteriores.Checked = True Then
            Dim mifecha As Date
            Dim mifechaOK As String
            mifecha = cbx_busqueda.Text
            mifechaOK = mifecha.ToString("yyyy-MM-dd")


            miconsulta2("exec buscar_citas_anteriores'" & (mifechaOK) & "', " & (txt_id_medico.Text) & "")
            If ds2.Tables(dt2.TableName).Rows.Count >= 1 Then
                DataGridView1.DataSource = Nothing
                rb_anteriores.Enabled = False
                rb_pendientes.Enabled = False
                BTN_OK.Enabled = False
                btn_abrir_ficha.Enabled = True
                controles_avanzar(True, False)
                buscar()
                mostrar(0)
            Else
                MessageBox.Show("Esta fecha ya no tiene mas pacientes que mostrar")
            End If
        End If
    End Sub

    Sub mostrar_id_pro(ByVal i As Integer)
        miconsulta("exec mostrar_id_profesional'" & (Login.txt_rut.Text) & "'")
        If ds.Tables(dt.TableName).Rows.Count > 0 Then
            txt_id_medico.Text = ds.Tables(dt.TableName).Rows(i).Item("id_profesional")
        End If
    End Sub
    Private Sub Citas_pendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BTN_OK.Enabled = True
        mostrar_id_pro(0)
        llenarcombobox_busqueda()
    End Sub

    Private Sub btn_primero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_primero.Click
        mostrar(0)
    End Sub

    Private Sub btn_anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_anterior.Click
        If MiPos > 0 Then
            MiPos -= 1
            mostrar(MiPos)
        End If
    End Sub

    Private Sub btn_siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_siguiente.Click
        If MiPos < dt.Rows.Count - 1 Then
            MiPos += 1
            mostrar(MiPos)
        End If
    End Sub

    Private Sub btn_ultimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ultimo.Click
        MiPos = dt.Rows.Count - 1
        mostrar(MiPos)
    End Sub

    Private Sub btn_abrir_ficha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_abrir_ficha.Click
        Me.Hide()
        Carpeta_clinica.Show()
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub BTN_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_OK.Click
        If rb_anteriores.Checked = True Or rb_pendientes.Checked = True Then
            cbx_busqueda.Enabled = True
            btn_buscar.Enabled = True
            BTN_OK.Enabled = False
            btn_cambiar_filtro.Enabled = True
            rb_anteriores.Enabled = False
            rb_pendientes.Enabled = False
            llenarcombobox_busqueda()
            If cbx_busqueda.Items.Count = 0 Then
                MessageBox.Show("No hay fechas para mostrar")
                cbx_busqueda.Enabled = False
                btn_buscar.Enabled = False
                btn_abrir_ficha.Enabled = False
                btn_anterior.Enabled = False
                btn_ultimo.Enabled = False
                btn_siguiente.Enabled = False
                btn_primero.Enabled = False
                limpieza()
            End If
        End If
    End Sub

    Private Sub btn_cambiar_filtro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cambiar_filtro.Click
        btn_cambiar_filtro.Enabled = False
        rb_anteriores.Enabled = True
        rb_pendientes.Enabled = True
        BTN_OK.Enabled = True
        cbx_busqueda.Enabled = False
        btn_buscar.Enabled = False
        cbx_busqueda.Items.Clear()
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MessageBox.Show("Usted ya esta aqui")
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
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
        Carpeta_clinica.Close()
        administrador.Close()
        Anular_cita.Close()
    End Sub
End Class