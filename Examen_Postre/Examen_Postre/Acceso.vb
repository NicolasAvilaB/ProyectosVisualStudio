Public Class Acceso

    Private Sub ClientesMysql_Click(sender As Object, e As EventArgs) Handles ClientesMysql.Click
        Clientes.Show()
        Me.Hide()
    End Sub

    Private Sub UsuariosMysql_Click(sender As Object, e As EventArgs) Handles UsuariosMysql.Click
        Me.Close()
        Usuarios.Show()
    End Sub
End Class