Public Class Anular_cita
    Dim MiPos As Integer

    Sub limpiar()
        txt_agenda.Clear()
        txt_fecha.Clear()
        txt_hora.Clear()
        txt_id.Clear()
        txt_profesional.Clear()
        txt_rut.Clear()
    End Sub
    Private Sub AnularCitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularCitaToolStripMenuItem.Click
        MessageBox.Show("Usted ya se encuentra en este item")
    End Sub
    Private Sub CitacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CitacionToolStripMenuItem.Click
        Citar_paciente.Show()
        Me.Close()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Adm_pacientes.Show()
        Me.Close()
    End Sub
    Sub mostrar(ByVal i As Integer)
        If ds.Tables(dt.TableName).Rows.Count > 0 Then
            txt_rut.Text = ds.Tables(dt.TableName).Rows(i).Item("rut_paciente")
            txt_id.Text = ds.Tables(dt.TableName).Rows(i).Item("id_profesional")
            txt_agenda.Text = ds.Tables(dt.TableName).Rows(i).Item("agenda")
            txt_profesional.Text = ds.Tables(dt.TableName).Rows(i).Item("id_profesional")
            txt_fecha.Text = ds.Tables(dt.TableName).Rows(i).Item("fecha")
            txt_hora.Text = ds.Tables(dt.TableName).Rows(i).Item("hora")
        End If
    End Sub
    Sub buscar()
        miconsulta("exec mostrar_data_grid_anular_consultar '" & (txt_rut_busqueda.Text) & "'")
        DataGridView1.DataSource = ds.Tables(dt.TableName)
    End Sub

        


    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click

        If txt_rut_busqueda.Text = "" Then
            MessageBox.Show("Complete el campo de busqueda")
        ElseIf txt_rut_busqueda.Text <> "" Then
            miconsulta2("exec consultar_si_pac_tiene_citas '" & (txt_rut_busqueda.Text) & "'")
            If ds2.Tables(dt2.TableName).Rows.Count > 0 Then
                buscar()
                mostrar(0)
                txt_rut_busqueda.Clear()
                btn_anterior.Enabled = True
                btn_primero.Enabled = True
                btn_siguiente.Enabled = True
                btn_ultimo.Enabled = True
                btn_anular.Enabled = True
            Else
                MessageBox.Show("Paciente no tiene citas pendientes")

                DataGridView1.DataSource = Nothing
                btn_anterior.Enabled = False
                btn_primero.Enabled = False
                btn_siguiente.Enabled = False
                btn_ultimo.Enabled = False
                btn_anular.Enabled = False
            End If
        End If

    End Sub

    Private Sub PACIENTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PACIENTESToolStripMenuItem.Click
        Adm_pacientes.Show()
        Me.Close()
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

    Private Sub btn_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_anular.Click
        Dim mifecha As Date
        Dim mifechaOK As String
        mifecha = txt_fecha.Text
        mifechaOK = mifecha.ToString("yyyy-MM-dd")
        miconsulta("exec anular_citas_1 " & (txt_id.Text) & ",'" & (txt_hora.Text) & "','" & (mifechaOK) & "'")
        miconsulta("exec anular_citas_2 '" & (txt_rut.Text) & "','" & (txt_hora.Text) & "' ,'" & (mifechaOK) & "'")
        MessageBox.Show("Consulta anulada exitosamente")
        miconsulta("exec mostrar_data_grid_anular_consultar '" & (txt_rut.Text) & "'")
        DataGridView1.DataSource = ds.Tables(dt.TableName)
    End Sub

    Private Sub Anular_cita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        btn_anterior.Enabled = False
        btn_primero.Enabled = False
        btn_siguiente.Enabled = False
        btn_ultimo.Enabled = False
        btn_anular.Enabled = False
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
        Adm_pacientes.Close()
        Adm_citas.Close()
        Carpeta_clinica.Close()
        administrador.Close()
    End Sub
End Class