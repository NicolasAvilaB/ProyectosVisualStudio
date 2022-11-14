Public Class Form_ingreso

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        MiConsulta("select * from usuarios where usuario = '" & (txt_usuario.Text) & "' and clave = '" & (txt_clave.Text) & "' ")

        If DS.Tables(DT.TableName).Rows.Count = 1 Then
            Form_menu.Show()
            Me.Visible = False
        Else
            MsgBox("Usuario y Clave incorrectos")
        End If

    End Sub

    Private Sub Form_ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Database=BaseDatos1;Data Source=localhost;User Id=nicolas;Password=1234"

    End Sub
End Class