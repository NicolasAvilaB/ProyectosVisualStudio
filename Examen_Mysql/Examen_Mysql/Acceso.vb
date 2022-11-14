Public Class Acceso

    Private Sub ClientesMysql_Click(sender As Object, e As EventArgs) Handles ClientesMysql.Click
        Clientes.Show()
        Me.Hide()
    End Sub

    Private Sub UsuariosMysql_Click(sender As Object, e As EventArgs) Handles UsuariosMysql.Click
        Usuarios.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class