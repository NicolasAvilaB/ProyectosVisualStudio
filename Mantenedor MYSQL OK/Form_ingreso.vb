Public Class Form_ingreso

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        MiConsulta("Call ConsultaCajeros ('" & (txt_usuario.Text) & "','" & (txt_clave.Text) & "') ")

        If DS.Tables(DT.TableName).Rows.Count = 1 Then
            Form_menu.Show()
            Me.Visible = False
        Else
            MsgBox("Usuario y Clave incorrectos")
        End If

    End Sub

    Private Sub Form_ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Database=super9;Data Source=localhost;User Id=root;Password=root"

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
        conexion.Close()

    End Sub
End Class