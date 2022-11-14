Public Class Form_Entrar

    Sub Control(ByVal a As Boolean, ByVal b As Boolean)
        N_Usuario.Enabled = b
        Clave_Entrada.Enabled = b
        Aceptar.Enabled = b
        Cancelar.Enabled = b
    End Sub
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Ventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ventas.Click
        Control(False, True)
    End Sub

    Private Sub Form_Entrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Database=basedatos1;Data Source=localhost;User Id=root;Password=aiep"
    End Sub

    Private Sub ProInformes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProInformes.Click

    End Sub
    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        If MsgBox("Realmente deseas salir?", vbInformation Or vbYesNo) = vbNo Then

        End If
        Me.Close()

    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        MiConsulta("select * from usuarios where usuario = '" & (N_Usuario.Text) & "' and clave = '" & (Clave_Entrada.Text) & "' ")

        If DS.Tables(DT.TableName).Rows.Count = 1 Then
            MsgBox("Bienvenido Usuario: " & (N_Usuario.Text))

            Form_menu.Show()
            Me.Visible = False
        Else
            MsgBox("Error: Usuario y Clave Ingresados son Incorrectos")
            N_Usuario.Clear()
            Clave_Entrada.Clear()
            N_Usuario.Focus()




        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Control(True, False)
        N_Usuario.Clear()
        Clave_Entrada.Clear()



    End Sub
End Class