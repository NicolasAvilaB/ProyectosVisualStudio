Public Class Entrada

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cONECTAR.Click

            Consulta("Call habilita2 ('" & (Usua.Text) & "','" & (Contraseña.Text) & "')")

            If DS.Tables(DT.TableName).Rows.Count = 1 Then
            MsgBox("Bienvenido/a Señor/a: " + Usua.Text, vbInformation, "Hospital Ferreteria")
            Me.Hide()

        End If

        Menu2.Show()
    End Sub

    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.ConnectionString = "Database=hospital;DataSource=localhost;User Id=root;Password=root"
        Consulta("select usuarios.id, usuarios.passwor from usuarios")
        MsgBox("Bienvenido al Hospital ''Ferreteria''", vbInformation, "Bienvenido")
        Usua.Focus()
        Usua.Select()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Vero.Click
        If (Vero.Text = "Ver") Then
            Contraseña.PasswordChar = ""
            Vero.Text = "Ocultar"
        ElseIf (Vero.Text = "Ocultar") Then
            Contraseña.PasswordChar = "*"
            Vero.Text = "Ver"
        End If
    End Sub

    Private Sub Usua_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Usua.KeyPress
        
    End Sub

    Private Sub Usua_TextChanged(sender As Object, e As EventArgs) Handles Usua.TextChanged
        ' If (Len(Usua.Text) <= 3) Then

        'Contraseña.Enabled = False
        'Else
        'Contraseña.Enabled = True

        'End If

        Consulta("Call habilita ('" & (Usua.Text) & "')")

        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            Contraseña.Enabled = False
            Vero.Enabled = False
        Else
            Contraseña.Enabled = True
            Vero.Enabled = True
        End If
    End Sub

    Private Sub cANCELAR_Click(sender As Object, e As EventArgs) Handles cANCELAR.Click

        Application.Exit()
    End Sub

    Private Sub Contraseña_TextChanged(sender As Object, e As EventArgs) Handles Contraseña.TextChanged

        Consulta("Call habilita2 ('" & (Usua.Text) & "','" & (Contraseña.Text) & "')")
        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            cONECTAR.Enabled = False
        Else
            cONECTAR.Enabled = True
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
