Imports System.Text.RegularExpressions
Public Class Doctores1
    Dim varseleccion As Integer

    Private Sub Doctores1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizartabla()
        mostrargrilla()
    End Sub
    Sub actualizartabla()
        Consulta("select * from usuarios")
    End Sub
    Sub mostrargrilla()
        Personal.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
   
    Public Function validar_mail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub Personal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Personal.CellClick
        Dim row As DataGridViewRow = Personal.Rows(e.RowIndex)

        rut.Text = Val(row.Cells(0).Value)
        nombre.Text = (CStr(row.Cells("nomb").Value))
        direccion.Text = (CStr(row.Cells("direccion").Value))
        telefono.Text = Val(row.Cells(3).Value)
        email.Text = (CStr(row.Cells("email").Value))
        especialidad.Text = (CStr(row.Cells("especialidad").Value))
        id.Text = (CStr(row.Cells("id").Value))
        pass.Text = (CStr(row.Cells("passwor").Value))
        nom.Text = (CStr(row.Cells("nombre").Value))
        ape.Text = (CStr(row.Cells("apellido").Value))



    End Sub

    Private Sub Personal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Personal.CellContentClick

    End Sub

    Private Sub Personal_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Personal.CellEnter
        Dim row As DataGridViewRow = Personal.Rows(e.RowIndex)

        rut.Text = Val(row.Cells(0).Value)
        nombre.Text = (CStr(row.Cells("nomb").Value))
        direccion.Text = (CStr(row.Cells("direccion").Value))
        telefono.Text = Val(row.Cells(3).Value)
        email.Text = (CStr(row.Cells("email").Value))
        especialidad.Text = (CStr(row.Cells("especialidad").Value))
        id.Text = (CStr(row.Cells("id").Value))
        pass.Text = (CStr(row.Cells("passwor").Value))
        nom.Text = (CStr(row.Cells("nombre").Value))
        ape.Text = (CStr(row.Cells("apellido").Value))
    End Sub

    Private Sub Personal_Click(sender As Object, e As EventArgs) Handles Personal.Click

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Consulta("select * from pacientes where rut = '" & (rut.Text) & "' ")

        If (rut.Text = "") Then
            MsgBox("El Campo Rut Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
            rut.Focus()
            rut.Select()
            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()
        ElseIf (nombre.Text = "") Then
            MsgBox("El Campo Nombre Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
            nombre.Focus()
            nombre.Select()
            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()
        ElseIf (direccion.Text = "") Then
            MsgBox("El Campo Direccion Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
            direccion.Focus()
            direccion.Select()
            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()
        ElseIf (telefono.Text = "") Then
            MsgBox("El Campo Telefono Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
            telefono.Focus()
            telefono.Select()
            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()
        ElseIf validar_mail(LCase(email.Text)) = False Then
            MsgBox("Direccion de Correo no valida, El Formato Aceptable es: nombre@dominio.cl o .com", vbCritical, "Error Fatal")
            email.Clear()
            email.Focus()
            email.Select()
            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()
        ElseIf (especialidad.Text = "") Then
            MsgBox("El Campo Especialidad Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
            especialidad.Focus()
            especialidad.Select()
            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()
        ElseIf (id.Text = "") Then
            MsgBox("El Campo ID Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
            id.Focus()
            id.Select()
            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()
        ElseIf (pass.Text = "") Then
            MsgBox("El Campo Password Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
            pass.Focus()
            pass.Select()
            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()
        ElseIf (nom.Text = "") Then
            MsgBox("El Campo Nombre Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
            nom.Focus()
            nom.Select()
            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()
        ElseIf (ape.Text = "") Then
            MsgBox("El Campo Apellido Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
            ape.Focus()
            ape.Select()
            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()
        ElseIf DS.Tables(DT.TableName).Rows.Count > 0 Then

            MsgBox("El Rut: " + rut.Text + " Ya Existe en el Registro", vbCritical, "Error Fatal")
            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()

            rut.Focus()
            rut.Select()
        ElseIf varseleccion = 1 Then



            Try
                Consulta("insert into usuarios (rut,nomb,direccion,telefono,email,especialidad,id,passwor,nombre,apellido) values ('" & (rut.Text) & "','" & (nombre.Text) & "','" & (direccion.Text) & "','" & (telefono.Text) & "','" & (email.Text) & "','" & (especialidad.Text) & "','" & (id.Text) & "','" & (pass.Text) & "','" & (nom.Text) & "','" & (ape.Text) & "')")
                MsgBox("Registro Completado Exitosamente", vbInformation, "Registro Completo")
            Catch ex As Exception
                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try
            actualizartabla()
            mostrargrilla()
            rut.Enabled = False
            nombre.Enabled = False
            direccion.Enabled = False
            telefono.Enabled = False
            email.Enabled = False
            especialidad.Enabled = False
            id.Enabled = False
            pass.Enabled = False
            nom.Enabled = False
            ape.Enabled = False

            rut.ReadOnly = True
            nombre.ReadOnly = True
            direccion.ReadOnly = True
            telefono.ReadOnly = True
            email.ReadOnly = True
            especialidad.ReadOnly = True
            id.ReadOnly = True
            pass.ReadOnly = True
            nom.ReadOnly = True
            ape.ReadOnly = True

            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()

            Nuevo.Enabled = True
            Guardar.Enabled = False
            Modificar.Enabled = True
            Eliminar.Enabled = True

            Personal.Enabled = True
            Personal.ReadOnly = False
            Vero.Enabled = False
        ElseIf varseleccion = 2 Then

            MsgBox("Datos Modificados Correctamente", vbInformation, "Felicidades")

            actualizartabla()
            mostrargrilla()



        End If

        actualizartabla()
        mostrargrilla()
        rut.Clear()
        nombre.Clear()
        direccion.Clear()
        telefono.Clear()
        email.Clear()
        especialidad.Clear()
        id.Clear()
        pass.Clear()
        nom.Clear()
        ape.Clear()
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        varseleccion = 1

        rut.Enabled = True
        nombre.Enabled = True
        direccion.Enabled = True
        telefono.Enabled = True
        email.Enabled = True
        especialidad.Enabled = True
        id.Enabled = True
        pass.Enabled = True
        nom.Enabled = True
        ape.Enabled = True

        rut.ReadOnly = False
        nombre.ReadOnly = False
        direccion.ReadOnly = False
        telefono.ReadOnly = False
        email.ReadOnly = False
        especialidad.ReadOnly = False
        id.ReadOnly = False
        pass.ReadOnly = False
        nom.ReadOnly = False
        ape.ReadOnly = False

        rut.Clear()
        nombre.Clear()
        direccion.Clear()
        telefono.Clear()
        email.Clear()
        especialidad.Clear()
        id.Clear()
        pass.Clear()
        nom.Clear()
        ape.Clear()

        Nuevo.Enabled = False
        Guardar.Enabled = True
        Modificar.Enabled = False
        Eliminar.Enabled = False

        Personal.Enabled = False
        Personal.ReadOnly = True
        Vero.Enabled = True

    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Personal.Enabled = False
        Personal.ReadOnly = True
    End Sub

    Private Sub especialidad_TextChanged(sender As Object, e As EventArgs) Handles especialidad.TextChanged
        Me.especialidad.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        Menu2.Show()
    End Sub

    Private Sub Personal_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Personal.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Vero_Click(sender As Object, e As EventArgs) Handles Vero.Click
        If (Vero.Text = "") Then
            MsgBox("Error: Campo Password o Contraseña Vacio, Porfavor Especifique",, "Error")
            pass.Focus()
            pass.Select()
        ElseIf (Vero.Text = "Ver") Then
            pass.PasswordChar = ""
            Vero.Text = "Ocultar"
        ElseIf (Vero.Text = "Ocultar") Then
            pass.PasswordChar = "*"
            Vero.Text = "Ver"
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Desea Eliminar El Registro?", vbYesNo + vbQuestion, "Eliminar")
        If valormensaje = vbYes Then
            Consulta("delete from usuarios where rut ='" & (rut.Text) & "'")

        End If
        actualizartabla()
        If DS.Tables(DT.TableName).Rows.Count > 0 Then

        Else
            rut.Clear()
            nombre.Clear()
            direccion.Clear()
            telefono.Clear()
            email.Clear()
            especialidad.Clear()
            id.Clear()
            pass.Clear()
            nom.Clear()
            ape.Clear()
        End If
        mostrargrilla()
    End Sub
End Class