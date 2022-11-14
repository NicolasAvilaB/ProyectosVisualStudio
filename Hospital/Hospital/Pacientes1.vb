Imports System.Text.RegularExpressions
Public Class Pacientes1
    Dim varseleccion As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        Menu2.Show()
    End Sub


    Sub actualizartabla()
        Consulta("select * from pacientes")
    End Sub
    Sub mostrargrilla()
        Pac_1.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SistSaliud.SelectedIndexChanged

    End Sub
    Sub mostrar(ByVal i As Integer)

        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            rut.Text = DS.Tables(DT.TableName).Rows(i).Item("rut")
            nombre.Text = DS.Tables(DT.TableName).Rows(i).Item("nombre")
            direccion.Text = DS.Tables(DT.TableName).Rows(i).Item("direccion")
            telefono.Text = DS.Tables(DT.TableName).Rows(i).Item("telefono")
            Ciudad.Text = DS.Tables(DT.TableName).Rows(i).Item("ciudad")
            genero.Text = DS.Tables(DT.TableName).Rows(i).Item("genero")
            NumeroHiji.Text = DS.Tables(DT.TableName).Rows(i).Item("nhijos")
            Email.Text = DS.Tables(DT.TableName).Rows(i).Item("email")
            Edades.Text = DS.Tables(DT.TableName).Rows(i).Item("edad")
            SistSaliud.Text = DS.Tables(DT.TableName).Rows(i).Item("sistemasalud")
            Medico.Text = DS.Tables(DT.TableName).Rows(i).Item("medico")
        End If
    End Sub



    Private Sub Pacientes1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Consulta("SELECT DISTINCT nomb FROM usuarios")
            Medico.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("usuarios")
            DA.Fill(dt)
            With Medico
                .DataSource = dt
                .DisplayMember = "nomb"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Medico.SelectedIndex = -1
        mostrargrilla()
        actualizartabla()
        mostrar(0)
        Pac_1.ReadOnly = True
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        varseleccion = 1
        rut.Enabled = True
        nombre.Enabled = True
        direccion.Enabled = True
        telefono.Enabled = True
        Ciudad.Enabled = True
        genero.Enabled = True
        NumeroHiji.Enabled = True
        Email.Enabled = True
        Edades.Enabled = True
        SistSaliud.Enabled = True

        rut.ReadOnly = False
        nombre.ReadOnly = False
        direccion.ReadOnly = False
        telefono.ReadOnly = False
        Ciudad.ReadOnly = False
        NumeroHiji.ReadOnly = False
        Email.ReadOnly = False
        Edades.ReadOnly = False

        Nuevo.Enabled = False
        Eliminar.Enabled = False
        Modificar.Enabled = False
        Guardar.Enabled = True

        rut.Clear()
        nombre.Clear()
        direccion.Clear()
        telefono.Clear()
        Ciudad.Clear()

        NumeroHiji.Clear()
        Email.Clear()
        Edades.Clear()
        SistSaliud.SelectedIndex = -1
        genero.SelectedIndex = -1
        Medico.Enabled = True
        Medico.SelectedIndex = -1
        Pac_1.Enabled = False
        Pac_1.ReadOnly = False

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Consulta("select * from pacientes where rut = '" & (rut.Text) & "' ")

        If (rut.Text = "") Then
            MsgBox("El Campo Rut Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (nombre.Text = "") Then
            MsgBox("El Campo Nombre Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (direccion.Text = "") Then
            MsgBox("El Campo Direccion Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (telefono.Text = "") Then
            MsgBox("El Campo Telefono Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Ciudad.Text = "") Then
            MsgBox("El Campo Ciudad Esta Vacio, Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf validar_mail(LCase(Email.Text)) = False Then
            MsgBox("Direccion de Correo no valida, El Formato Aceptable es: nombre@dominio.cl o .com", vbCritical, "Error Fatal")
            Email.Clear()
            Email.Focus()
            Email.Select()
        ElseIf (genero.Text = "") Then
            MsgBox("No ha Seleccionado el Genero de la Persona, Seleccionela para Continuar", vbCritical, "Error Fatal")
        ElseIf (NumeroHiji.Text = "") Then
            MsgBox("El Campo Numero de Hijos Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Email.Text = "") Then
            MsgBox("El Campo Email Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Edades.Text = "") Then
            MsgBox("El Campo Edad Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (SistSaliud.Text = "") Then
            MsgBox("El Sistema de Salud no esta Seleccionado, Porfavor Seleccione Uno Valido", vbCritical, "Error Fatal")
        ElseIf (Medico.SelectedIndex = -1) Then
            MsgBox("El Medico no ha sido Seleccionado, Porfavor Seleccione Uno Valido", vbCritical, "Error Fatal")
        ElseIf DS.Tables(DT.TableName).Rows.Count > 0 Then

            MsgBox("El Rut: " + rut.Text + " Ya Existe en el Registro", vbCritical, "Error Fatal")


        ElseIf varseleccion = 1 Then



            Try
                Consulta("insert into pacientes (rut,nombre,direccion,telefono,ciudad,genero,nhijos,email,edad,sistemasalud, medico) values ('" & (rut.Text) & "','" & (nombre.Text) & "','" & (direccion.Text) & "','" & (telefono.Text) & "','" & (Ciudad.Text) & "','" & (genero.Text) & "','" & (NumeroHiji.Text) & "','" & (Email.Text) & "','" & (Edades.Text) & "','" & (SistSaliud.Text) & "','" & (Medico.Text) & "')")
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
            Ciudad.Enabled = False
            Medico.Enabled = False
            genero.Enabled = False
            NumeroHiji.Enabled = False
            Email.Enabled = False
            Edades.Enabled = False
            SistSaliud.Enabled = False

            rut.ReadOnly = True
            nombre.ReadOnly = True
            direccion.ReadOnly = True
            telefono.ReadOnly = True
            Ciudad.ReadOnly = True
            NumeroHiji.ReadOnly = True
            Email.ReadOnly = True
            Edades.ReadOnly = True

            Nuevo.Enabled = True
            Eliminar.Enabled = True
            Modificar.Enabled = True
            Guardar.Enabled = False
            Pac_1.Enabled = True
            Pac_1.ReadOnly = True
        ElseIf varseleccion = 2 Then

            MsgBox("Datos Modificados Correctamente", vbInformation, "Felicidades")

            actualizartabla()
            mostrargrilla()



        End If

        actualizartabla()
        mostrargrilla()
    End Sub

    Private Sub Pac_1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Pac_1.CellClick

        Dim row1 As DataGridViewRow = Pac_1.Rows(e.RowIndex)

        rut.Text = Val(row1.Cells(0).Value)
        nombre.Text = (CStr(row1.Cells("nombre").Value))
        direccion.Text = (CStr(row1.Cells("direccion").Value))
        telefono.Text = Val(row1.Cells(3).Value)
        Ciudad.Text = (CStr(row1.Cells(4).Value))
        genero.Text = (CStr(row1.Cells("genero").Value))
        NumeroHiji.Text = (CStr(row1.Cells("nhijos").Value))
        Email.Text = (CStr(row1.Cells("email").Value))
        Edades.Text = (CStr(row1.Cells("edad").Value))
        SistSaliud.Text = (CStr(row1.Cells("sistemasalud").Value))
        Medico.Text = (CStr(row1.Cells("medico").Value))
    End Sub

    Private Sub Pac_1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Pac_1.CellContentClick

    End Sub

    Private Sub Pac_1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Pac_1.CellEnter

        
    End Sub

    Private Sub Pac_1_CellStyleChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Pac_1.CellStyleChanged

    End Sub

    Private Sub Pac_1_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Pac_1.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rut.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub rut_TextChanged(sender As Object, e As EventArgs) Handles rut.TextChanged

    End Sub

    Private Sub nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombre.KeyPress
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

    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged

    End Sub

    Private Sub Ciudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ciudad.KeyPress
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

    Private Sub Ciudad_TextChanged(sender As Object, e As EventArgs) Handles Ciudad.TextChanged
        Me.Ciudad.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub telefono_TextChanged(sender As Object, e As EventArgs) Handles telefono.TextChanged

    End Sub

    Private Sub NumeroHiji_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumeroHiji.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub NumeroHiji_TextChanged(sender As Object, e As EventArgs) Handles NumeroHiji.TextChanged

    End Sub

    Private Sub Edades_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Edades.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Edades_TextChanged(sender As Object, e As EventArgs) Handles Edades.TextChanged

    End Sub
    Public Function validar_mail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub Email_Leave(sender As Object, e As EventArgs) Handles Email.Leave
        
    End Sub

    Private Sub Email_TextChanged(sender As Object, e As EventArgs) Handles Email.TextChanged

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Desea Eliminar El Registro?", vbYesNo + vbQuestion, "Eliminar")
        If valormensaje = vbYes Then
            Consulta("delete from pacientes where rut='" & (rut.Text) & "'")


        
        End If
        actualizartabla()
        rut.Clear()
        nombre.Clear()
        direccion.Clear()
        telefono.Clear()
        Ciudad.Clear()

        NumeroHiji.Clear()
        Email.Clear()
        Edades.Clear()
        SistSaliud.SelectedIndex = -1
        genero.SelectedIndex = -1
        Medico.SelectedIndex = -1
        mostrar(0)
        mostrargrilla()
    End Sub

    Private Sub Medico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Medico.SelectedIndexChanged
        If (Medico.SelectedIndex = -1) Then
            Label12.Text = Nothing

        Else
            Consulta("select * from usuarios where nomb = '" & (Medico.Text) & "' ")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)

                Label12.Text = CStr(row("especialidad"))

                mostrargrilla()
                actualizartabla()
            End If
        End If

    End Sub
End Class