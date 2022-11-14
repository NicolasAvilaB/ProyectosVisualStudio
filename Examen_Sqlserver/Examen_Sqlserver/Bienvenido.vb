Public Class Bienvenido

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clientes.Show()
        Me.Hide()
    End Sub

    Private Sub Bienvenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion_Sqlserver.ConnectionString = "Data Source=NICOLAS-A-B-PC;Initial Catalog=Base_Examen_Pedrero;user Id=sa; Password =root;"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Ventas.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Productos.Show()
    End Sub
End Class
