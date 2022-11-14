Imports System.Deployment.Application
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InstallUpdateSyncWithInfo()
        Conexion.ConnectionString = "Database=libreria;DataSource=localhost;User Id=root;Password=root"
        Try
            Consulta("SELECT DISTINCT rut FROM usuario")
            Dim dt As DataTable = New DataTable("usuario")
            DA.Fill(dt)
            With Rutes
                .DataSource = dt
                .DisplayMember = "rut"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Rutes.SelectedIndex = -1

        Try
            Consulta("SELECT DISTINCT codigo FROM libros")
            Dim dt As DataTable = New DataTable("libros")
            DA.Fill(dt)
            With Codigo
                .DataSource = dt
                .DisplayMember = "codigo"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Codigo.SelectedIndex = -1


        Label6.Text = FormatDateTime(Now, DateFormat.ShortDate)

    End Sub
    Sub aCT()
        Consulta("select * from prestamos_devoluciones where rut_usuario='" & (Rutes.Text) & "'")

    End Sub
    Public Sub InstallUpdateSyncWithInfo()

        Dim info As UpdateCheckInfo = Nothing

        If (ApplicationDeployment.IsNetworkDeployed) Then

            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException

            Catch ioe As InvalidOperationException

            End Try

            If (info.UpdateAvailable) Then

                Try
                    AD.Update()

                    Application.Restart()
                Catch dde As DeploymentDownloadException

                End Try

            End If

        End If
    End Sub
    Sub grilla()
        DataGridView1.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub


    Private Sub Rutes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Rutes.SelectedIndexChanged
        If (Rutes.SelectedIndex = -1) Then
            Nomin.Text = Nothing

        Else
            Consulta("select usuario.nombre from usuario where rut = '" & (Rutes.Text) & "' ")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)

                Nomin.Text = CStr(row("nombre"))

            End If
        End If

        aCT()
        grilla()
    End Sub

    Private Sub Codigo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Codigo.SelectedIndexChanged
        If (Rutes.SelectedIndex = -1) Then
            NOmbreLibro.Text = Nothing
            Estado.Text = Nothing

        Else
            Consulta("select libros.nombre, libros.estado from libros where codigo = '" & (Codigo.Text) & "' ")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)


                NOmbreLibro.Text = CStr(row("nombre"))
                Estado.Text = CStr(row("estado"))

            End If
        End If
        DataGridView1.DataSource = Nothing
        aCT()
        grilla()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Consulta("delete from libros")
        Application.Restart()
    End Sub

    Private Sub Prestamo_Click(sender As Object, e As EventArgs) Handles Prestamo.Click
        Dim mifecha As Date = Label6.Text
        Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
        If (Estado.Text = "No Disponible") Then
            MsgBox("No se puede prestar el libro deseado, este ya a sido prestado", vbCritical, "Error")
        Else
            Consulta("INSERT INTO prestamos_devoluciones (codigo_libro,rut_usuario,fecha_prestamo,fecha_devolucion,estado) VALUES ('" & (Codigo.Text) & "','" & (Rutes.Text) & "','" & (mifecha2) & "','" & (mifecha2) & "','" & "Prestado" & "')")
            Consulta("UPDATE libros SET nombre='" & (NOmbreLibro.Text) & "', estado='" & "No Disponible" & "' where codigo=" & (Codigo.Text) & "")
            MsgBox("Prestado Correcto")
        End If
        If (Rutes.SelectedIndex = -1) Then
            NOmbreLibro.Text = Nothing
            Estado.Text = Nothing

        Else
            Consulta("select libros.nombre, libros.estado from libros where codigo = '" & (Codigo.Text) & "' ")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)


                NOmbreLibro.Text = CStr(row("nombre"))
                Estado.Text = CStr(row("estado"))

            End If
        End If
        aCT()
        grilla()
        aCT()
        grilla()
    End Sub

    Private Sub DevueltoLibro_Click(sender As Object, e As EventArgs) Handles DevueltoLibro.Click
        Dim mifecha As Date = Label6.Text
        Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
        Dim dato1 As String

        dato1 = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString


        Consulta("UPDATE prestamos_devoluciones SET rut_usuario='" & (Rutes.Text) & "', codigo_libro='" & (Codigo.Text) & "', fecha_prestamo='" & (mifecha2) & "', fecha_devolucion='" & (mifecha2) & "', estado='" & "Devuelto" & "' where codigo_prestamo=" & (dato1) & "")

        Consulta("UPDATE libros SET nombre='" & (NOmbreLibro.Text) & "', estado='" & "Disponible" & "' where codigo=" & (Codigo.Text) & "")

        MsgBox("Datos Modificados Correctamente", vbInformation, "Operacion Realizada Correctamente")

        aCT()
        grilla()
        If (Rutes.SelectedIndex = -1) Then
            NOmbreLibro.Text = Nothing
            Estado.Text = Nothing

        Else
            Consulta("select libros.nombre, libros.estado from libros where codigo = '" & (Codigo.Text) & "' ")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)


                NOmbreLibro.Text = CStr(row("nombre"))
                Estado.Text = CStr(row("estado"))

            End If
        End If
        aCT()
        grilla()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Consulta("delete from prestamos_devoluciones")
        Application.Restart()
    End Sub
End Class
