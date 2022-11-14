Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Data Source=localhost;User Id=nicolas;Password=1234"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MiConsulta("select * from usuarios where usuario = '" & (TextBox1.Text) & "' and clave = '" & (TextBox2.Text) & "' ")

        If DS.Tables(DT.TableName).Rows.Count = 1 Then
            Form2.Show()
            Me.Visible = False
        Else
            MsgBox("Usuario y Clave incorrectos")
        End If
    End Sub
End Class
