Public Class Form_menu


    Private Sub Btn_clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clientes.Click

        Form_clientes.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Usuarios.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_ingreso.Show()

    End Sub
End Class