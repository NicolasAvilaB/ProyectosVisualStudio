Public Class Ingreso

    Private Sub Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Usuario.Focus()
        Usuario.Focus()
        Usuario.Focus()
        Conexion_Mysql.ConnectionString = "Database=examen_profesor_pedrero;Data Source=localhost;User Id=root;Password=root"
        Usuario.Focus()
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        If (Usuario.Text = "") Then

            MsgBox("Error Fatal: Campo Usuario Esta Vacio", vbCritical, "Error")

        ElseIf (Clave.Text = "") Then

            MsgBox("Error Fatal: Campo Clave Esta Vacio", vbCritical, "Error")

        Else

            Consulta_Mysql("Call SP_Ingreso_Usuario('" & (Usuario.Text) & "','" & (Clave.Text) & "')")

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                MsgBox("Bienvenido Señor: " + Usuario.Text, vbInformation, "Bienvenido")
                Usuario.Clear()
                Clave.Clear()
                Acceso.Show()
                Me.Visible = False

            Else

                MsgBox("Usuario y Clave incorrectos", vbCritical, "Error")
                Usuario.Clear()
                Clave.Clear()
                Usuario.Focus()
            End If
        End If
    End Sub

    Private Sub Clave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Clave.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Clave_TextChanged(sender As Object, e As EventArgs) Handles Clave.TextChanged
        
    End Sub

    Private Sub Usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Usuario.KeyPress
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

    Private Sub Usuario_TextChanged(sender As Object, e As EventArgs) Handles Usuario.TextChanged

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class
