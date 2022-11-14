Public Class Login
    Sub controles(ByVal a As Boolean, ByVal b As Boolean)
        MenuStrip1.Visible = a
        lbl_info.Visible = a
        lbl_clave.Visible = b
        lbl_usuario.Visible = b
        txt_clave.Visible = b
        txt_usuario.Visible = b
        btn_acceder.Visible = b
    End Sub
    Sub controles_b(ByVal a As Boolean, ByVal b As Boolean)
        MenuStrip2.Visible = a
        lbl_info.Visible = a
        lbl_clave.Visible = b
        lbl_usuario.Visible = b
        txt_clave.Visible = b
        txt_usuario.Visible = b
        btn_acceder.Visible = b
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Data Source=(local);Initial Catalog=baseclinica;user Id=sa;Password=aiep123+*;"
    End Sub
    Sub mostrar(ByVal i As Integer)
        If ds.Tables(dt.TableName).Rows.Count > 0 Then
            txtprivilegio.Text = ds.Tables(dt.TableName).Rows(i).Item("privilegio")
            txt_rut.Text = ds.Tables(dt.TableName).Rows(i).Item("rut")

        End If
    End Sub

    Private Sub btn_acceder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_acceder.Click
        miconsulta("EXEC verificarusuario '" & (txt_usuario.Text) & "','" & (txt_clave.Text) & "'")
        If ds.Tables(dt.TableName).Rows.Count = 1 Then
            mostrar(0)
        Else
            MessageBox.Show("CLAVE O USUARIO ERRONEO")
            txt_clave.Clear()
            txt_usuario.Clear()
        End If
        If txtprivilegio.Text = "Administrador" Then
            controles(True, False)
        ElseIf txtprivilegio.Text = "Profesional" Then
            controles_b(True, False)
        End If
    End Sub

    Private Sub CitacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CitacionToolStripMenuItem.Click
        Citar_paciente.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Adm_citas.Show()
    End Sub

    Private Sub AnularCitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularCitaToolStripMenuItem.Click
        Anular_cita.Show()
    End Sub

    Private Sub PACIENTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PACIENTESToolStripMenuItem.Click
        Adm_pacientes.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Adm_citas.Show()
    End Sub

    Private Sub AdministraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministraToolStripMenuItem.Click
        administrador.Show()
    End Sub

    Private Sub CERRARSESIONToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CERRARSESIONToolStripMenuItem1.Click
        MenuStrip1.Visible = False
        lbl_info.Visible = False

        lbl_clave.Visible = True
        lbl_usuario.Visible = True
        txt_clave.Visible = True
        txt_usuario.Visible = True
        btn_acceder.Visible = True

        MenuStrip2.Visible = False

        txtprivilegio.Clear()
        txt_rut.Clear()

        Citar_paciente.Close()
        Adm_pacientes.Close()
        Adm_citas.Close()
        Carpeta_clinica.Close()
        administrador.Close()
        Anular_cita.Close()
    End Sub
End Class
