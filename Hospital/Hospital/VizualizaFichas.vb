Public Class VizualizaFichas
    Private Sub R_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Sub actualizartabla()
        Consulta("select * from fichas where nombre_paciente='" & (TextBox1.Text) & "'")
    End Sub
    Sub mostrargrilla()
        DetalleFicha.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub

    Private Sub VizualizaFichas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        actualizartabla()
        mostrargrilla()
        actualizartabla()


    End Sub

    Private Sub Volvere_Click(sender As Object, e As EventArgs) Handles Volvere.Click
        Me.Close()
        Menu2.Show()
    End Sub

    Private Sub R_TextChanged(sender As Object, e As EventArgs) Handles R.TextChanged


        Consulta("select * from fichas where rut='" & (R.Text) & "'")

        If DS.Tables(DT.TableName).Rows.Count = 0 Then

        Else
            Dim row As DataRow = DT.Rows(0)
            TextBox1.Text = CStr(row("nombre_paciente"))
            TextBox2.Text = CStr(row("enfermedad"))

            actualizartabla()

            mostrargrilla()
        End If



        actualizartabla()

        mostrargrilla()
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Consulta("Delete from fichas where rut='" & (R.Text) & "'")
        Conexion.Close()
        Me.Close()
        Menu2.Show()
    End Sub
End Class