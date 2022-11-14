Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Conexion.ConnectionString = "Database=Taller1;Data Source=localhost;User Id=root;Password=root"
        Form1.Show()
    End Sub
End Class