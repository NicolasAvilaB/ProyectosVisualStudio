Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Data Source=NICO-PC;Initial Catalog=midatos;user Id=sa; Password =aiep123+*;"

    End Sub

    Private Sub BTACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTACEPTAR.Click
        MiConsulta("select * from Usuarios  where Usuario = '" & (TextBox1.Text) & "'  and Clave = '" & (TextBox2.Text) & "' ")

        If DS.Tables(DT.TableName).Rows.Count = 1 Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Usuario y Clave Incorrectos")
        End If
    End Sub
End Class
