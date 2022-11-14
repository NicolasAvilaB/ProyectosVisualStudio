Public Class Form2

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSALIR.Click
        Application.Exit()
    End Sub

    Private Sub BTUSUARIOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTUSUARIOS.Click
        Form3.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form6.Show()
    End Sub
End Class