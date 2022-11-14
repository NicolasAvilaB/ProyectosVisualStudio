Public Class Inicio

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.ConnectionString = "Database=venta;Data Source=localhost;User Id=root;Password=root"
    End Sub

    Private Sub Ingreso_Click(sender As Object, e As EventArgs) Handles Ingreso.Click
        If (Txtusuario.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Usuario Para Continuar", vbCritical, "Error")
        ElseIf (Txtclave.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Clave Para Continuar", vbCritical, "Error")
        Else

            Consulta("select * from usuarios where usuario ='" & (Txtusuario.Text) & "' and clave ='" & (Txtclave.Text) & "'")

            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                MsgBox("Bienvenido/a: " + Txtusuario.Text, vbInformation, "Bienvenido al Sistema Ventas")
                Me.Hide()
                Menu1.Show()



            Else
                MsgBox("Usuario y Clave incorrectos", vbCritical, "Error")
                Txtusuario.Clear()
                Txtclave.Clear()
                Txtusuario.Focus()
            End If

        End If
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub Ver_Click(sender As Object, e As EventArgs) Handles Ver.Click
        If (Txtclave.Text = "") Then
            MsgBox("Error: No Hay Nada Escrito, Por favor Escriba Su Contraseña", vbCritical, "Error Fatal")

        Else
            Txtclave.PasswordChar = ""
            Ver.Enabled = False
            Ocultar.Enabled = True
            Txtclave.Focus()
        End If
    End Sub

    Private Sub Ocultar_Click(sender As Object, e As EventArgs) Handles Ocultar.Click
        If (Txtclave.Text = "") Then
            MsgBox("Error: No Hay Nada Escrito, Por favor Escriba Su Contraseña", vbCritical, "Error Fatal")

        Else
            Txtclave.PasswordChar = "*"
            Ocultar.Enabled = False
            Ver.Enabled = True
            Txtclave.Focus()
        End If
    End Sub
End Class
