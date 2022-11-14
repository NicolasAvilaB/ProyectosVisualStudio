Public Class Lista_Conexiones

    Private Sub Conexion_Mysql_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Conexion_Postgresql_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Conexion_Oracle_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Lista_Conexiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Conexion_Sqlserver_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Conexion_Sqlite_Click(sender As Object, e As EventArgs) Handles Conexion_Sqlite.Click
        Acceso_Sqlite.Show()
        Me.Hide()
    End Sub
End Class