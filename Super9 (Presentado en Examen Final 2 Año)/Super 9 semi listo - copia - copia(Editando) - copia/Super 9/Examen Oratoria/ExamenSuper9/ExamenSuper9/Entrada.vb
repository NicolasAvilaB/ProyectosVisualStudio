'Imports System.Deployment.Application'
Public Class Entrada
    Sub HabilitaDesabilita(ByVal A As Boolean, ByVal B As Boolean)

        Ventas.Enabled = A

        Administracion.Enabled = A
        Salir.Enabled = A
        TxtUsuarios.Enabled = B



        Cancelar.Enabled = B


    End Sub
    'Public Sub InstallUpdateSyncWithInfo()

    'Dim info As UpdateCheckInfo = Nothing

    'If (ApplicationDeployment.IsNetworkDeployed) Then

    'Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

    'Try
    '           info = AD.CheckForDetailedUpdate()
    'Catch dde As DeploymentDownloadException
    '
    '    Catch ioe As InvalidOperationException

    'End Try

    'If (info.UpdateAvailable) Then

    'Try
    '               AD.Update()

    '              Application.Restart()
    'Catch dde As DeploymentDownloadException

    'End Try

    'End If

    'End If
    'End Sub
    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'InstallUpdateSyncWithInfo()
        Conexion.ConnectionString = "Database=super9;Data Source=localhost;User Id=root;Password=root"
        ' Conexion.ConnectionString = "Database=u946226876_super;Data Source=mysql.hostinger.es;User Id=u946226876_root;Password=super9"
        Consulta("select usuarios.N_Cajero, usuarios.Clave from usuarios")
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
        Ver.Enabled = False
        Ver.Text = "Ver"
        TxtClave.PasswordChar = "*"
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
        Usuarios9.Admin.Focus()
    End Sub

    Private Sub Secciones_Enter(sender As Object, e As EventArgs) Handles Secciones.Enter

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
        'If (TxtUsuarios.Text = "") Then
        'TxtClave.Enabled = False
        'Else
        'TxtClave.Enabled = True

        'End If

        Consulta("select usuarios.N_Cajero from usuarios where N_Cajero ='" & (TxtUsuarios.Text) & "'")

        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            TxtClave.Enabled = False
            Ver.Enabled = False
        Else
            TxtClave.Enabled = True
            Ver.Enabled = True

            SendKeys.Send("{TAB}")

        End If

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

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            Aceptar.Focus()
            Aceptar.Select()
            SendKeys.Send("{ENTER}")

        End If

    End Sub

    Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs) Handles TxtClave.TextChanged
        If (TxtClave.Text = "") Then
            Ver.Enabled = False
            Aceptar.Enabled = False
        Else
            Ver.Enabled = True
            Aceptar.Enabled = True
        End If


    End Sub

    Private Sub Ver_Click(sender As Object, e As EventArgs) Handles Ver.Click
        If (TxtClave.Text = "") Then
            MsgBox("Error: No Hay Nada Escrito, Por favor Escriba Su Contraseña", vbCritical, "Error Fatal")

        ElseIf (Ver.Text = "Ver") Then
            Ver.Text = "Ocultar"
            TxtClave.PasswordChar = ""
            TxtClave.Focus()
        Else
            Ver.Text = "Ver"
            TxtClave.PasswordChar = "*"
            Ver.Enabled = True
            TxtClave.Focus()

        End If
    End Sub
End Class
