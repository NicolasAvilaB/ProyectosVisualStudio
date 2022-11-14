Public Class Entrada
    Sub HabilitaDesabilita(ByVal A As Boolean, ByVal B As Boolean)

        Ventas.Enabled = A
        ProInformes.Enabled = A
        Administracion.Enabled = A
        Salir.Enabled = A
        TxtUsuarios.Enabled = B
        TxtClave.Enabled = B
        Aceptar.Enabled = B
        Cancelar.Enabled = B


    End Sub
    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.ConnectionString = "Database=super9;Data Source=localhost;User Id=root;Password=root"
    End Sub

    Private Sub Ventas_Click(sender As Object, e As EventArgs) Handles Ventas.Click

        HabilitaDesabilita(False, True)
        TxtUsuarios.Focus()
        TxtUsuarios.Clear()
        TxtClave.Clear()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        HabilitaDesabilita(True, False)
        TxtUsuarios.Clear()
        TxtClave.Clear()
        Conexion.Close()
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        

        If (TxtUsuarios.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Usuario Para Continuar", vbCritical, "Error")
        ElseIf (TxtClave.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Clave Para Continuar", vbCritical, "Error")
        Else

            Consulta("Call ConsultaCajeros ('" & (TxtUsuarios.Text) & "','" & (TxtClave.Text) & "')")

            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                MsgBox("Bienvenido/a Cajero/a: " + TxtUsuarios.Text, vbInformation, "Bienvenido Al Supermercado El 9")
                Me.Hide()
                Bienvenido9.Show()

                HabilitaDesabilita(True, False)
                



            Else
                MsgBox("Cajero y Clave incorrectos", vbCritical, "Error")
                TxtUsuarios.Clear()
                TxtClave.Clear()
                TxtUsuarios.Focus()
            End If

        End If



    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Conexion.Close()
        Me.Close()

    End Sub

    Private Sub Cajeros_Click(sender As Object, e As EventArgs) Handles Administracion.Click
        Usuarios9.Show()
        Me.Hide()
    End Sub

    Private Sub Secciones_Enter(sender As Object, e As EventArgs) Handles Secciones.Enter

    End Sub

    Private Sub ProInformes_Click(sender As Object, e As EventArgs) Handles ProInformes.Click
        Informes.Show()


    End Sub

    Private Sub TxtUsuarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuarios.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Letras", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub
    Private Sub TxtUsuarios_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuarios.TextChanged



    End Sub

    Private Sub TxtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClave.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs) Handles TxtClave.TextChanged

    End Sub
End Class
