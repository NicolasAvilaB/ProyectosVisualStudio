Public Class Adm_pacientes
    Dim varseleccion As Integer
    Dim MiPos As Integer
    Dim sexo As String
    Sub controles_a(ByVal a As Boolean, ByVal b As Boolean)
        btn_busqueda.Enabled = a
        btn_nuevo.Enabled = a

        txt_busqueda.Enabled = b
        cbx_campos.Enabled = b
        btn_buscar.Enabled = b

        txt_apellido_mat.Enabled = b
        txt_apellido_pat.Enabled = b
        txt_domicilio.Enabled = b
        txt_fono.Enabled = b
        txt_nombre.Enabled = b
        txt_prevision.Enabled = b
        txt_rut.Enabled = b

        btn_cancelar.Enabled = b
        btn_editar_paciente.Enabled = b
        btn_guardar.Enabled = b

        rbHombre.Enabled = b
        rbMujer.Enabled = b
    End Sub
    Sub controles_b(ByVal a As Boolean, ByVal b As Boolean)
        btn_busqueda.Enabled = a
        btn_nuevo.Enabled = a

        txt_busqueda.Enabled = a
        cbx_campos.Enabled = a
        btn_buscar.Enabled = a

        txt_apellido_mat.Enabled = b
        txt_apellido_pat.Enabled = b
        txt_domicilio.Enabled = b
        txt_fono.Enabled = b
        txt_nombre.Enabled = b
        txt_prevision.Enabled = b
        txt_rut.Enabled = b


        btn_cancelar.Enabled = b
        btn_editar_paciente.Enabled = b
        btn_guardar.Enabled = b

        rbHombre.Enabled = b
        rbMujer.Enabled = b
    End Sub
    Sub controles_c(ByVal a As Boolean, ByVal b As Boolean)
        btn_busqueda.Enabled = a
        btn_nuevo.Enabled = a

        txt_busqueda.Enabled = b
        cbx_campos.Enabled = b
        btn_buscar.Enabled = b

        txt_apellido_pat.Enabled = a
        txt_apellido_mat.Enabled = a
        txt_domicilio.Enabled = a
        txt_fono.Enabled = a
        txt_nombre.Enabled = a
        txt_prevision.Enabled = a
        txt_rut.Enabled = b

        btn_cancelar.Enabled = a
        btn_editar_paciente.Enabled = b
        btn_guardar.Enabled = a

        rbHombre.Enabled = a
        rbMujer.Enabled = a
    End Sub
    Sub limpiar()
        txt_apellido_mat.Clear()
        txt_apellido_pat.Clear()
        txt_domicilio.Clear()
        txt_fono.Clear()
        txt_nombre.Clear()
        txt_prevision.Clear()
        txt_rut.Clear()
    End Sub

    Sub controles_d(ByVal a As Boolean, ByVal b As Boolean)
        btn_busqueda.Enabled = a
        btn_nuevo.Enabled = a

        txt_busqueda.Enabled = b
        cbx_campos.Enabled = b
        btn_buscar.Enabled = b

        txt_apellido_mat.Enabled = a
        txt_apellido_pat.Enabled = a
        txt_domicilio.Enabled = a
        txt_fono.Enabled = a
        txt_nombre.Enabled = a
        txt_prevision.Enabled = a
        txt_rut.Enabled = a

        btn_cancelar.Enabled = a
        btn_editar_paciente.Enabled = b
        btn_guardar.Enabled = a

        rbHombre.Enabled = a
        rbMujer.Enabled = a
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
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Usted ya se encuentra en este item")
    End Sub

    Private Sub CitacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CitacionToolStripMenuItem.Click
        Citar_paciente.Show()
        Me.Close()
    End Sub

    Private Sub btn_busqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_busqueda.Click
        controles_b(True, False)
        txt_busqueda.Clear()
        limpiar()
    End Sub
    Private Sub btn_editar_paciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar_paciente.Click
        controles_c(True, False)
        varseleccion = 1
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click

        If varseleccion = 1 And txt_rut.Text <> "" And txt_nombre.Text <> "" And txt_domicilio.Text <> "" And txt_apellido_pat.Text <> "" And txt_apellido_mat.Text <> "" And txt_domicilio.Text <> "" And txt_fono.Text <> "" And txt_prevision.Text <> "" Then
            If rbHombre.Checked = True Then
                controles_a(True, False)
                miconsulta("exec editar_paciente '" & (txt_nombre.Text) & "','" & (txt_apellido_pat.Text) & "','" & (txt_apellido_mat.Text) & "','" & (txt_domicilio.Text) & "','" & (txt_prevision.Text) & "','" & (txt_fono.Text) & "','Hombre','" & (Login.txt_usuario.Text) & "','" & (txt_rut.Text) & "'")
                MessageBox.Show("Datos actualizados")
                limpiar()
                buscar()
                mostrar(0)
                cbx_campos.Enabled = True
                txt_busqueda.Enabled = True
                btn_buscar.Enabled = True
                btn_editar_paciente.Enabled = True
            End If
            If rbMujer.Checked = True Then
                controles_a(True, False)
                miconsulta("exec editar_paciente '" & (txt_nombre.Text) & "','" & (txt_apellido_pat.Text) & "','" & (txt_apellido_mat.Text) & "','" & (txt_domicilio.Text) & "','" & (txt_prevision.Text) & "','" & (txt_fono.Text) & "','Mujer','" & (Login.txt_usuario.Text) & "','" & (txt_rut.Text) & "'")
                MessageBox.Show("Datos actualizados")
                limpiar()
                buscar()
                mostrar(0)
                cbx_campos.Enabled = True
                txt_busqueda.Enabled = True
                btn_buscar.Enabled = True
                btn_editar_paciente.Enabled = True
            End If

        ElseIf varseleccion = 2 And txt_rut.Text <> "" And txt_nombre.Text <> "" And txt_domicilio.Text <> "" And txt_apellido_pat.Text <> "" And txt_apellido_mat.Text <> "" And txt_domicilio.Text <> "" And txt_fono.Text <> "" And txt_prevision.Text <> "" Then
            If rbHombre.Checked = True Then
                miconsulta2("select * from pacientes where rut_paciente='" & (txt_rut.Text) & "'")
                If ds2.Tables(dt2.TableName).Rows.Count >= 1 Then
                    MessageBox.Show("Este paciente ya esta ingresado")
                ElseIf ds2.Tables(dt2.TableName).Rows.Count = 0 Then
                    miconsulta("exec nuevo_paciente '" & (txt_nombre.Text) & "' ,'" & (txt_apellido_pat.Text) & "' ,'" & (txt_apellido_mat.Text) & "' ,'" & (txt_rut.Text) & "' , '" & (txt_domicilio.Text) & "' ,'" & (txt_prevision.Text) & "' ,'" & (txt_fono.Text) & "' , '" & (Login.txt_usuario.Text) & "', 'Hombre'")
                    limpiar()
                    txt_busqueda.Clear()
                    MessageBox.Show("Paciente guardado exitosamente")
                End If
            ElseIf rbMujer.Checked = True Then
                miconsulta2("select * from pacientes where rut_paciente='" & (txt_rut.Text) & "'")
                If ds2.Tables(dt2.TableName).Rows.Count >= 1 Then
                    MessageBox.Show("Este paciente ya fue ingresado")
                ElseIf ds2.Tables(dt2.TableName).Rows.Count = 0 Then
                    miconsulta("exec nuevo_paciente '" & (txt_nombre.Text) & "' ,'" & (txt_apellido_pat.Text) & "' ,'" & (txt_apellido_mat.Text) & "' ,'" & (txt_rut.Text) & "' , '" & (txt_domicilio.Text) & "' ,'" & (txt_prevision.Text) & "' ,'" & (txt_fono.Text) & "' , '" & (Login.txt_usuario.Text) & "', 'Mujer'")
                    limpiar()
                    txt_busqueda.Clear()
                    MessageBox.Show("Paciente guardado exitosamente")
                End If
            Else
                MessageBox.Show("Complete los campos")
            End If
        Else
            MessageBox.Show("Complete los campos")
        End If
    End Sub
    Sub controles_avanzar(ByVal a As Boolean, ByVal b As Boolean)
        btn_anterior.Enabled = a
        btn_ultimo.Enabled = a
        btn_siguiente.Enabled = a
        btn_primero.Enabled = a
    End Sub
    
    Sub buscar()
        miconsulta("select * from pacientes where " & (cbx_campos.Text) & " = '" & (txt_busqueda.Text) & "' ")
        DataGridView1.DataSource = ds.Tables(dt.TableName)
    End Sub
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If txt_busqueda.Text = "" Then
            MessageBox.Show("Complete el texto para busqueda")
        ElseIf cbx_campos.Text = "" Then
            MessageBox.Show("Seleccione el campo de busqueda")
        ElseIf txt_busqueda.Text <> "" Then
            miconsulta2("select * from pacientes where " & (cbx_campos.Text) & " = '" & (txt_busqueda.Text) & "'")
            If ds2.Tables(dt2.TableName).Rows.Count >= 1 Then
                DataGridView1.DataSource = Nothing
                buscar()
                mostrar(0)
                btn_editar_paciente.Enabled = True
                controles_avanzar(True, False)
            Else
                DataGridView1.DataSource = Nothing
                MessageBox.Show("Paciente no existe")
            End If
        End If



    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        txt_busqueda.Clear()
        limpiar()
        controles_d(True, False)
        varseleccion = 2
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click

        If varseleccion = 1 Then
            mostrar(0)
            controles_a(True, False)
            btn_editar_paciente.Enabled = True
        ElseIf varseleccion = 2 Then
            limpiar()
        End If
    End Sub

    Private Sub Adm_pacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        controles_a(True, False)
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

    Private Sub AnularCitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularCitaToolStripMenuItem.Click
        Anular_cita.Show()
        Me.Close()
    End Sub

    Private Sub PACIENTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PACIENTESToolStripMenuItem.Click
        MessageBox.Show("Usted ya se encuentra en este item")
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
        Citar_paciente.Close()
        Me.Close()
        Adm_citas.Close()
        Carpeta_clinica.Close()
        administrador.Close()
        Anular_cita.Close()
    End Sub
End Class
'
