Public Class SeleccionMedico

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.hide()
        Ficha_Atencion.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Menu2.Show()
    End Sub

    Private Sub SeleccionMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Medico.Focus()
        Medico.Select()
    End Sub

    Private Sub Medico_SelectedIndexChanged(sender As Object, e As EventArgs)

        
    End Sub

    Private Sub Medico_TextChanged(sender As Object, e As EventArgs) Handles Medico.TextChanged
        Consulta("select * from usuarios where id = '" & (Medico.Text) & "' ")
        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            Especialidad.Text = Nothing
            Label3.Text = Nothing
        Else



            Dim row As DataRow = DT.Rows(0)

            Especialidad.Text = CStr(row("especialidad"))
            Label3.Text = CStr(row("nomb"))

        End If

    End Sub

    Private Sub Especialidad_TextChanged(sender As Object, e As EventArgs) Handles Especialidad.TextChanged
        If (Especialidad.Text = "") Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub
End Class