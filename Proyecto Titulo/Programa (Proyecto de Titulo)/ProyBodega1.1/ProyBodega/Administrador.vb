Imports System.Text.RegularExpressions
Public Class Administrador
    Dim VarSeleccion As Integer
    Dim Dato1, Dato2, Dato3, Dato4 As String
    Dim nom As String
    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        busque_admin.Clear()
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Productos.Owner = Me
        Productos.ShowDialog()
    End Sub
    Sub Actualizacion_Tabla()
        Consulta("Call Grilla_Admin")
    End Sub
    Sub Mostrar()
        If (DS.Tables(DT.TableName).Rows.Count > 0) Then
            Dato1 = Grilla_Administrador.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato2 = Grilla_Administrador.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato3 = Grilla_Administrador.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato4 = Grilla_Administrador.CurrentRow.Cells(3).EditedFormattedValue.ToString
            nombr.Text = Dato1
            cla.Text = Dato2
            Label6.Text = Dato3
            Email.Text = Dato4
        Else
            nombr.Clear()
            cla.Clear()
            Email.Clear()
            Label6.Text = "0"
        End If
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Administrador.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        busque_admin.Clear()
        Me.Close()
        Secciones1.Show()
    End Sub
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Bienvenido Señor Administrador", vbInformation, "Municipalidad de Peralillo")
        nuevo.Focus()
        nuevo.Select()
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
        If Me.Grilla_Administrador.Rows.Count = 0 Then
            eliminar.Enabled = False
        Else
            eliminar.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles acces.Click
        busque_admin.Clear()
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Seccion_Acceso.Owner = Me
        Seccion_Acceso.ShowDialog()
    End Sub
    Private Sub admini_TextChanged(sender As Object, e As EventArgs) Handles busque_admin.TextChanged
        If (busque_admin.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
        Else
            Consulta("Call Buscar_Admin('" & (busque_admin.Text & "%") & "')")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Grilla_Administrador.DataSource = DS.Tables(DT.TableName)
                Mostrar()
            Else
                nombr.Clear()
                cla.Clear()
                Email.Clear()
            End If
        End If
    End Sub
    Private Sub Grilla_Usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Administrador.CellContentClick
        Grilla_Administrador.ReadOnly = True
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        SolicitudContraseña_Admin1.Owner = Me
        SolicitudContraseña_Admin1.ShowDialog()
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        busque_admin.Clear()
        VarSeleccion = 1
        nombr.Enabled = True
        cla.Enabled = True
        nombr.ReadOnly = False
        cla.ReadOnly = False
        busque_admin.Enabled = False
        busque_admin.ReadOnly = True
        guardar.Enabled = True
        nuevo.Enabled = False
        Email.Clear()
        eliminar.Enabled = False
        Email.Enabled = True
        Email.ReadOnly = False
        Grilla_Administrador.Enabled = False
        Grilla_Administrador.ReadOnly = True
        nombr.Clear()
        cla.Clear()
        nombr.Focus()
        nombr.Select()
        cancelar.Enabled = True
        SendKeys.Send("{BACKSPACE}")
        nuevo.Focus()
        nuevo.Select()
        Consulta("Call GeneradorIDautomatico")
        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("ID")) Is DBNull Then
            Label6.Text = 1
        Else
            Label6.Text = DS.Tables(DT.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
    End Sub
    Public Function validar_mail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        busque_admin.Clear()
        If (nombr.Text = "") Then
            MsgBox("Error: No se ha Describido un Nombre de Admin. Valido", vbCritical, "¡Error, Admin no Especificado!")
            nombr.Focus()
            nombr.Select()
        ElseIf (cla.Text = "") Then
            MsgBox("Error: No se ha Describido una Clave de Admin. Valido", vbCritical, "¡Error, Clave de Admin. no Describida!")
            cla.Focus()
            cla.Select()
        ElseIf (Email.Text = "") Then
            MsgBox("Error: No se ha Describido un Email de Admin. Valido", vbCritical, "¡Error, Email de Admin. no Describido!")
            Email.Focus()
            Email.Select()
        ElseIf validar_mail(LCase(Email.Text)) = False Then
            MsgBox("Error: Formato de Correo Electronico Incorrecto, El Formato Aceptable es el Siguiente: nombre@dominio.cl o .com", vbCritical, "Error Fatal, Formato Email Incorrecto")
            Email.Clear()
            Email.Focus()
            Email.Select()
        Else
            If (Me.Grilla_Administrador.Rows.Count = 0) Then
                Dato1 = Nothing
            Else
                Dato1 = Grilla_Administrador.CurrentRow.Cells(1).EditedFormattedValue.ToString
            End If
            For Each row As DataGridViewRow In Grilla_Administrador.Rows
                nom = row.Cells(1).Value
            Next
            If (nom = nombr.Text) Then
                MsgBox("El Nombre: " + nombr.Text + " Ya Existe En El Registro.", vbCritical, "Error Nombre Ya Existente")
                nombr.Clear()
                nombr.Focus()
                nombr.Select()
            ElseIf (Dato1 = nombr.Text) Then
                MsgBox("El Nombre: " + nombr.Text + " Ya Existe En El Registro.", vbCritical, "Error Nombre Ya Existente")
                nombr.Clear()
                nombr.Focus()
                nombr.Select()
            ElseIf VarSeleccion = 1 Then
                Try
                    Consulta("Call Ingreso_Admin ('" & (Label6.Text) & "','" & (nombr.Text) & "','" & (cla.Text) & "','" & (Email.Text) & "')")
                    MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                    nombr.Enabled = False
                    cla.Enabled = False
                    nombr.ReadOnly = True
                    cla.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    Email.Enabled = False
                    Email.ReadOnly = True
                    busque_admin.Enabled = True
                    busque_admin.ReadOnly = False
                    Grilla_Administrador.Enabled = True
                    cancelar.Enabled = False
                    nombr.Enabled = False
                    cla.Enabled = False
                    nombr.ReadOnly = True
                    cla.ReadOnly = True
                    nuevo.Focus()
                    nuevo.Select()
                    cla.PasswordChar = "*"
                    Grilla_Administrador.ReadOnly = True
                Catch ex As Exception
                    DA.SelectCommand = SC
                    DA.Fill(DT)
                End Try
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
            End If
        End If
    End Sub
    Private Sub nombr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombr.KeyPress
        nombr.CharacterCasing = CharacterCasing.Upper
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            cla.Focus()
            cla.Select()
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub Grilla_Administrador_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Administrador.CellClick
        Mostrar()
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Me.Refresh()
        busque_admin.Clear()
        nombr.Enabled = False
        cla.Enabled = False
        nombr.ReadOnly = True
        cla.ReadOnly = True
        busque_admin.Enabled = True
        busque_admin.ReadOnly = False
        Email.Enabled = False
        Email.ReadOnly = True
        guardar.Enabled = False
        nuevo.Enabled = True
        eliminar.Enabled = True
        Grilla_Administrador.Enabled = True
        Grilla_Administrador.ReadOnly = True
        cancelar.Enabled = False
        nuevo.Focus()
        nuevo.Select()
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
    End Sub
    Private Sub busque_admin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busque_admin.KeyPress
        busque_admin.CharacterCasing = CharacterCasing.Upper
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub Grilla_Administrador_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Administrador.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Secciones1.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub nombr_TextChanged(sender As Object, e As EventArgs) Handles nombr.TextChanged

    End Sub

    Private Sub cla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cla.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            guardar.Focus()
            guardar.Select()
            SendKeys.Send("{ENTER}")
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub Grilla_Administrador_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Grilla_Administrador.CellFormatting
        If e.ColumnIndex = 2 Then
            On Error Resume Next
            e.Value = New String("*"c, e.Value.ToString.Length)
        End If
    End Sub
    Private Sub Email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Email.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
End Class