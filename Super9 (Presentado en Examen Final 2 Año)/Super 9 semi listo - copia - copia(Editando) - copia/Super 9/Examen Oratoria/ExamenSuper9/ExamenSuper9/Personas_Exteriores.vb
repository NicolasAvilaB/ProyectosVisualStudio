Public Class Personas_Exteriores
    Dim VarSeleccion As Integer
    Dim Dato1, Dato2, Dato3, Dato4, Dato5 As String
    Dim veri As Boolean

    Sub limpiar()
        Rut.Clear()
        Nombre.Clear()
        Direccion.Clear()
        Telefono.Clear()

    End Sub
    Sub Mostrar(ByVal i As Integer)

        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Try
                Rut.Text = DS.Tables(DT.TableName).Rows(i).Item("Rut")
                Nombre.Text = DS.Tables(DT.TableName).Rows(i).Item("Nombre")
                Direccion.Text = DS.Tables(DT.TableName).Rows(i).Item("Direccion")
                Telefono.Text = DS.Tables(DT.TableName).Rows(i).Item("Telefono")
                Empresa.Text = DS.Tables(DT.TableName).Rows(i).Item("Empresa")
                catch es As Exception
            End Try
            End If

    End Sub
    Sub Actualizacion_Tabla()

        Consulta("Call Mostrar_Empresarios")

    End Sub
    Sub Mostrar_Grilla()
        Grilla_Empresarios.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    Sub Borrar_Grilla()
        Grilla_Empresarios.DataSource = Nothing
        Conexion.Close()
    End Sub

    Private Sub Agre_Usuarios_Click(sender As Object, e As EventArgs) Handles Agre_Usuarios.Click
        VarSeleccion = 1
        Agre_Usuarios.Enabled = False
        Modificar.Enabled = False
        Eliminar.Enabled = False
        Rut.Enabled = True
        Nombre.Enabled = True
        Direccion.Enabled = True
        Telefono.Enabled = True
        Empresa.Enabled = True
        Guardar.Enabled = True
        Rut.Clear()
        Nombre.Clear()
        Direccion.Clear()
        Telefono.Clear()
        Empresa.Clear()
        Grilla_Empresarios.Enabled = False
        Busqueda.Enabled = False
        Busqueda.Clear()
    End Sub

    Private Sub Terminar_Click(sender As Object, e As EventArgs) Handles Terminar.Click
        Me.Close()
        Usuarios9.Show()

        Mostrar(0)
        Guardar.Enabled = False
        Rut.Enabled = False
        Nombre.Enabled = False
        Direccion.Enabled = False
        Telefono.Enabled = False
        Agre_Usuarios.Enabled = True
        Modificar.Enabled = True
        Eliminar.Enabled = True
        Empresa.Enabled = False

        Grilla_Empresarios.Enabled = False
        Busqueda.Enabled = False
        Busqueda.Clear()
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Consulta("Call VerificaRut ('" & (Rut.Text) & "')")
        'Consulta("Call VerificaEmpresa ('" & (Empresa.Text) & "')")
        If (Rut.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Rut Para Continuar", vbCritical, "Error")
        ElseIf (Nombre.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Nombre Para Continuar", vbCritical, "Error")
        ElseIf (Direccion.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Direccion Para Continuar", vbCritical, "Error")
        ElseIf (Telefono.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Telefono Para Continuar", vbCritical, "Error")
        ElseIf (Empresa.Text = "") Then
            MsgBox("Error Fatal: Porfavor Seleccione Alguna Empresa", vbCritical, "Error")
        ElseIf DS.Tables(DT.TableName).Rows.Count > 0 Then

            MsgBox("Ya Hay un Rut Existente a la " + Empresa.Text + ", Ya Esta En El Registro", vbCritical, "Error Fatal")

        ElseIf VarSeleccion = 1 Then

            Try
                Consulta("Call InsertarEmpresario ('" & (Rut.Text) & "','" & (Nombre.Text) & "','" & (Direccion.Text) & "','" & (Telefono.Text) & "','" & (Label5.Text & " " & Empresa.Text) & "')")
                MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")
                
                Guardar.Enabled = False
                Agre_Usuarios.Enabled = True
                Rut.Enabled = False
                Nombre.Enabled = False
                Direccion.Enabled = False
                Telefono.Enabled = False
                Empresa.Enabled = False
                Eliminar.Enabled = True
                Modificar.Enabled = True
                Grilla_Empresarios.Enabled = True
                Busqueda.Enabled = True
                Busqueda.Clear()
            Catch ex As Exception


                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try
           
            Actualizacion_Tabla()
            Mostrar_Grilla()
        ElseIf VarSeleccion = 2 Then
            Try
                Consulta("UPDATE empresarios SET nombre='" & (Nombre.Text) & "', direccion='" & (Direccion.Text) & "', telefono='" & (Telefono.Text) & "',empresa ='" & (Empresa.Text) & "' where rut=" & (Rut.Text) & "")
                MsgBox("Datos Modificados Correctamente", vbInformation, "Felicidades")
            Catch ex As Exception
                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try
            Guardar.Enabled = False
            Agre_Usuarios.Enabled = True
            Nombre.Enabled = False
            Direccion.Enabled = False
            Telefono.Enabled = False
            Empresa.Enabled = False
            Eliminar.Enabled = True
            Modificar.Enabled = True
            Grilla_Empresarios.Enabled = True
            Busqueda.Enabled = True
            Busqueda.Clear()
        End If

        Mostrar_Grilla()
        Actualizacion_Tabla()

    End Sub

    Private Sub Personas_Exteriores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Grilla()
        Actualizacion_Tabla()
        Mostrar(0)
    End Sub

    Private Sub Rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Rut.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Rut_TextChanged(sender As Object, e As EventArgs) Handles Rut.TextChanged

    End Sub

    Private Sub Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nombre.KeyPress
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


    Private Sub Direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Direccion.KeyPress
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


    Private Sub Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Telefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub


    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Desea Eliminar del Registro El siguiente Rut: " + Rut.Text + " ?", vbYesNo + vbQuestion, "Eliminar")
        If valormensaje = vbYes Then
            Consulta("Call EliminarEmpresarios ('" & (Rut.Text) & "')")
            MsgBox("Has Eliminado Con Exito El Rut: " + Rut.Text, vbInformation, "Eliminado")
            Busqueda.Clear()

        Else
            MsgBox("Has Cancelado la Operacion", vbCritical, "Cancelado")
        End If

        Actualizacion_Tabla()
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Mostrar(0)
        Else
            limpiar()
        End If
        Mostrar_Grilla()
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        VarSeleccion = 2
        Rut.Enabled = True
        Nombre.Enabled = True
        Direccion.Enabled = True
        Telefono.Enabled = True
        Empresa.Enabled = True
        Agre_Usuarios.Enabled = False
        Guardar.Enabled = True
        Eliminar.Enabled = False
        Grilla_Empresarios.Enabled = False
        Busqueda.Enabled = False
        Busqueda.Clear()
    End Sub


    Private Sub Busqueda_TextChanged(sender As Object, e As EventArgs) Handles Busqueda.TextChanged
        If (Busqueda.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar(0)
        Else
            Consulta("select * from empresarios where nombre Like '" & (Busqueda.Text & "%") & "' ")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Grilla_Empresarios.DataSource = DS.Tables(DT.TableName)
                Mostrar(0)
            End If
        End If
    End Sub

    Private Sub Grilla_Empresarios_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Empresarios.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Grilla_Empresarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Empresarios.CellClick
        Dato1 = Grilla_Empresarios.CurrentRow.Cells(0).EditedFormattedValue.ToString
        Dato2 = Grilla_Empresarios.CurrentRow.Cells(1).EditedFormattedValue.ToString
        Dato3 = Grilla_Empresarios.CurrentRow.Cells(2).EditedFormattedValue.ToString
        Dato4 = Grilla_Empresarios.CurrentRow.Cells(3).EditedFormattedValue.ToString
        Dato5 = Grilla_Empresarios.CurrentRow.Cells(4).EditedFormattedValue.ToString

        Rut.Text = Dato1
        Nombre.Text = Dato2
        Direccion.Text = Dato3
        Telefono.Text = Dato4
        Empresa.Text = Dato5
    End Sub
End Class