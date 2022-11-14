Public Class Bienvenido

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion_Oracle.ConnectionString = "Data Source=127.0.0.1;User Id=nicolas;Password=1234"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Clientes.Click
        Clientes1.Show()
        Me.Hide()
    End Sub

    Private Sub Productos_Click(sender As Object, e As EventArgs) Handles Productos.Click
        Me.Close()
        Productos1.Show()
    End Sub
End Class
