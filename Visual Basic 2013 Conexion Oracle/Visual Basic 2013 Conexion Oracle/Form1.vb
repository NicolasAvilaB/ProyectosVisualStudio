Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Data Source=127.0.0.1;User Id=nicolas;Password=1234"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MiConsulta("select * from USUARIOS where usuario = '" & (TextBox1.Text) & "' and clave = '" & (TextBox2.Text) & "' ")

        If DS.Tables(DT.TableName).Rows.Count = 1 Then
            Form2.Show()
            Me.Visible = False
        Else
            MsgBox("Usuario y Clave incorrectos")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
