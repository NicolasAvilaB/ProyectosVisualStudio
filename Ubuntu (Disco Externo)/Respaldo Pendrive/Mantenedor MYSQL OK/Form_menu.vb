Public Class Form_menu


    Private Sub Btn_clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clientes.Click
        Form_clientes = Me.Owner
        Form_clientes.ShowDialog()
    End Sub

End Class