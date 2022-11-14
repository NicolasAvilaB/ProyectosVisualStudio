Public Class Menu
    Private Sub suc_Click(sender As Object, e As EventArgs) Handles suc.Click
        Hide()
        Sucursales.Show()
    End Sub
    Private Sub cli_Click(sender As Object, e As EventArgs) Handles cli.Click
        Hide()
        Clientes.Show()
    End Sub
    Private Sub ord_Click(sender As Object, e As EventArgs) Handles ord.Click
        Hide()
        Orden_Trabajo.Show()
    End Sub
End Class
