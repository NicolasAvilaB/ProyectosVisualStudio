Public Class Acceso_Sqlite

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Clientes.Click
        Clientes_Sqlite.Show()
        Me.Hide()
    End Sub

    Private Sub Acceso_Sqlite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion_Sqlite.ConnectionString = "Data Source=C:\Users\Nicolas Avila B\Documents\Base_Examen_Pedrero_Clientes;Version=3;"
    End Sub
End Class