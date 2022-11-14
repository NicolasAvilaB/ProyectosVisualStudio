Public Class Carpeta_clinica
    Dim MiPos As Integer

    Sub buscar()
        miconsulta("exec mostar_cont_ficha_clinica '" & (Adm_citas.txt_rut.Text) & "'," & (Adm_citas.txt_id_medico.Text) & "")
            DataGridView1.DataSource = ds.Tables(dt.TableName)
    End Sub
    Sub mostrar(ByVal i As Integer)
        If ds.Tables(dt.TableName).Rows.Count > 0 Then
            txt_fecha.Text = ds.Tables(dt.TableName).Rows(i).Item("fecha")
            txt_hora.Text = ds.Tables(dt.TableName).Rows(i).Item("hora")
            txt_observaciones.Text = ds.Tables(dt.TableName).Rows(i).Item("observaciones_generales")
            txt_obs_examenes.Text = ds.Tables(dt.TableName).Rows(i).Item("observaciones_examenes")
            txt_diagnostico.Text = ds.Tables(dt.TableName).Rows(i).Item("diagnostico")
            txt_derivacion.Text = ds.Tables(dt.TableName).Rows(i).Item("derivacion")
        End If
    End Sub
    Sub controles_a(ByVal a As Boolean, ByVal b As Boolean)
        btn_primero.Enabled = a
        btn_anterior.Enabled = a
        btn_guardar.Enabled = b
        btn_nueva_hoja.Enabled = a
        btn_siguiente.Enabled = a
        btn_ultimo.Enabled = a
        txt_derivacion.Enabled = b
        txt_diagnostico.Enabled = b
        txt_obs_examenes.Enabled = b
        txt_observaciones.Enabled = b
    End Sub

    Sub controles_b(ByVal a As Boolean, ByVal b As Boolean)
        btn_primero.Enabled = b
        btn_anterior.Enabled = b
        btn_nueva_hoja.Enabled = b
        btn_siguiente.Enabled = b
        btn_ultimo.Enabled = b

        btn_guardar.Enabled = a
        txt_derivacion.Enabled = a
        txt_diagnostico.Enabled = a
        txt_obs_examenes.Enabled = a
        txt_observaciones.Enabled = a
    End Sub
    Sub limpieza()
        txt_derivacion.Clear()
        txt_diagnostico.Clear()
        txt_obs_examenes.Clear()
        txt_observaciones.Clear()
    End Sub
    Private Sub btn_nueva_hoja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nueva_hoja.Click
        btn_si_ex.Enabled = True
        btn_si_der.Enabled = True
        btn_no_ex.Enabled = False
        btn_no_der.Enabled = False
        controles_b(True, False)
        Label1.Visible = False
        Label3.Visible = False
        txt_fecha.Visible = False
        txt_hora.Visible = False
        txt_obs_examenes.Clear()
        txt_observaciones.Clear()
        txt_derivacion.Clear()
        txt_diagnostico.Clear()
        txt_derivacion.Enabled = False
        txt_derivacion.Text = "No"
        txt_obs_examenes.Enabled = False
        txt_obs_examenes.Text = "No"

    End Sub

    Private Sub Carpeta_clinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Adm_citas.rb_anteriores.Checked = True Then
            btn_nueva_hoja.Enabled = False
            btn_anterior.Enabled = True
            btn_primero.Enabled = True
            btn_siguiente.Enabled = True
            btn_ultimo.Enabled = True
        ElseIf Adm_citas.rb_pendientes.Checked = True Then
            controles_a(True, False)
        End If
        buscar()
        mostrar(0)
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If txt_derivacion.Text <> "" And txt_diagnostico.Text <> "" And txt_obs_examenes.Text <> "" And txt_observaciones.Text <> "" Then
            controles_a(True, False)
            Label1.Visible = True
            Label3.Visible = True
            btn_nueva_hoja.Enabled = False
            btn_no_ex.Enabled = False
            btn_si_ex.Enabled = False
            btn_no_der.Enabled = False
            btn_si_der.Enabled = False
            miconsulta("exec llenar_ficha_clinica '" & (txt_observaciones.Text) & "' ,'" & (txt_obs_examenes.Text) & "' ,'" & (txt_diagnostico.Text) & "' ,'" & (txt_derivacion.Text) & "','" & (Adm_citas.txt_rut.Text) & "' ,'" & (Adm_citas.cbx_busqueda.Text) & "' ,'" & (Adm_citas.txt_hora.Text) & "' ," & (Adm_citas.txt_id_medico.Text) & "")
            MessageBox.Show("La hoja ha sido anexada a la carpeta clinica de su paciente")
            limpieza()
            buscar()
            mostrar(0)
            txt_fecha.Visible = True
            txt_hora.Visible = True
        Else
            MessageBox.Show("Complete todos los campos de la ficha clinica")
        End If
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

    Private Sub Carpeta_clinica_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If MsgBox("¿Esta seguro que desea cerrar la ficha clinica de su paciente?", MsgBoxStyle.YesNo, "Cerrando ficha clinica...") = MsgBoxResult.Yes Then
            Adm_citas.Show()


            If Adm_citas.cbx_busqueda.Text = "" Then
                MessageBox.Show("Complete todos los campos de busqueda")
            ElseIf Adm_citas.cbx_busqueda.Text <> "" And Adm_citas.rb_pendientes.Checked = True Then
                miconsulta2("exec salir_ficha_clinica_1 '" & (Adm_citas.cbx_busqueda.Text) & "'," & (Adm_citas.txt_id_medico.Text) & "")
                If ds2.Tables(dt2.TableName).Rows.Count >= 1 Then
                    DataGridView1.DataSource = Nothing
                    Adm_citas.rb_anteriores.Enabled = False
                    Adm_citas.rb_pendientes.Enabled = False
                    Adm_citas.BTN_OK.Enabled = False
                    Adm_citas.btn_abrir_ficha.Enabled = True
                    Adm_citas.controles_avanzar(True, False)
                    Adm_citas.limpieza()
                    Adm_citas.controles_avanzar(True, False)
                    Adm_citas.buscar()
                    Adm_citas.mostrar(0)
                    Adm_citas.btn_abrir_ficha.Enabled = True
               

                    else If Adm_citas.cbx_busqueda.Items.Count = 0 Then
                    MessageBox.Show("No hay mas fechas para mostrar")
                    Adm_citas.cbx_busqueda.Enabled = False
                    Adm_citas.btn_buscar.Enabled = False

                    Adm_citas.btn_abrir_ficha.Enabled = False
                    Adm_citas.btn_anterior.Enabled = False
                    Adm_citas.btn_ultimo.Enabled = False
                    Adm_citas.btn_siguiente.Enabled = False
                    Adm_citas.btn_primero.Enabled = False
                Else
                    MessageBox.Show("Esta fecha ya no tiene mas pacientes que mostrar")
                    Adm_citas.cbx_busqueda.Items.Clear()
                    Adm_citas.llenarcombobox_busqueda()
                    Adm_citas.limpieza()

                    Adm_citas.btn_abrir_ficha.Enabled = False
                    Adm_citas.btn_anterior.Enabled = False
                    Adm_citas.btn_ultimo.Enabled = False
                    Adm_citas.btn_siguiente.Enabled = False
                    Adm_citas.btn_primero.Enabled = False
                End If

            ElseIf Adm_citas.cbx_busqueda.Text <> "" And Adm_citas.rb_anteriores.Checked = True Then
                miconsulta2("exec salir_ficha_clinica_2 '" & (Adm_citas.cbx_busqueda.Text) & "'," & (Adm_citas.txt_id_medico.Text) & "")
                If ds2.Tables(dt2.TableName).Rows.Count >= 1 Then
                    DataGridView1.DataSource = Nothing
                    Adm_citas.rb_anteriores.Enabled = False
                    Adm_citas.rb_pendientes.Enabled = False
                    Adm_citas.BTN_OK.Enabled = False
                    Adm_citas.btn_abrir_ficha.Enabled = True
                    Adm_citas.controles_avanzar(True, False)
                    Adm_citas.limpieza()
                    Adm_citas.controles_avanzar(True, False)
                    Adm_citas.buscar()
                    Adm_citas.mostrar(0)
                    Adm_citas.btn_abrir_ficha.Enabled = True
                ElseIf Adm_citas.cbx_busqueda.Items.Count = 0 Then
                    MessageBox.Show("No hay mas fechas para mostrar")
                    Adm_citas.cbx_busqueda.Enabled = False
                    Adm_citas.btn_buscar.Enabled = False

                    Adm_citas.btn_abrir_ficha.Enabled = False
                    Adm_citas.btn_anterior.Enabled = False
                    Adm_citas.btn_ultimo.Enabled = False
                    Adm_citas.btn_siguiente.Enabled = False
                    Adm_citas.btn_primero.Enabled = False
                Else
                    MessageBox.Show("Esta fecha ya no tiene mas pacientes que mostrar")
                    Adm_citas.cbx_busqueda.Items.Clear()
                    Adm_citas.llenarcombobox_busqueda()
                    Adm_citas.limpieza()

                    Adm_citas.btn_abrir_ficha.Enabled = False
                    Adm_citas.btn_anterior.Enabled = False
                    Adm_citas.btn_ultimo.Enabled = False
                    Adm_citas.btn_siguiente.Enabled = False
                    Adm_citas.btn_primero.Enabled = False

                End If
                End If
            Me.Hide()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_si_ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_si_ex.Click
        txt_obs_examenes.Clear()
        txt_obs_examenes.Enabled = True
        btn_si_ex.Enabled = False
        btn_no_ex.Enabled = True
    End Sub

    Private Sub btn_no_ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_no_ex.Click
        txt_obs_examenes.Clear()
        txt_obs_examenes.Text = "No"
        txt_obs_examenes.Enabled = False
        btn_si_ex.Enabled = True
        btn_no_ex.Enabled = False
    End Sub

    Private Sub btn_si_der_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_si_der.Click
        txt_derivacion.Clear()
        txt_derivacion.Enabled = True
        btn_si_der.Enabled = False
        btn_no_der.Enabled = True
    End Sub

    Private Sub btn_no_der_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_no_der.Click
        txt_derivacion.Clear()
        txt_derivacion.Text = "No"
        txt_derivacion.Enabled = False
        btn_si_der.Enabled = True
        btn_no_der.Enabled = False
    End Sub
End Class