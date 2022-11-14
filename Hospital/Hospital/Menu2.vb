Public Class Menu2

    Private Sub Pacientes_Click(sender As Object, e As EventArgs) Handles Pacientes.Click

        Me.Close()
        Pacientes1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Doctores.Click
        Me.Close()
        Doctores1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Reservas.Click
        Me.Close()
        Reservas1.Show()
    End Sub

    Private Sub Horario_Click(sender As Object, e As EventArgs) Handles Horario.Click
        Me.Close()
        VizualizaFichas.Show()

        VizualizaFichas.R.Focus()
        VizualizaFichas.R.Select()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        SeleccionMedico.Show()
    End Sub

    Private Sub Doctor_Click(sender As Object, e As EventArgs) Handles Doctor.Click
        Me.Close()
        ReservasMedico.Show()
    End Sub
End Class