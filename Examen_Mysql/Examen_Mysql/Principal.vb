Public Class Principal

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Bienvenido a los Examenes Mantenedor de Base de Datos", vbInformation, "Examen Mantenedor")
        MsgBox("En los Siguientes Programas, Se Vera las Conexiones a Distintas Base de Datos, Gracias Por su Atencion", vbInformation, "Examen Mantenedor")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
        Ingreso.Show()
        Me.Hide()
    End Sub
End Class