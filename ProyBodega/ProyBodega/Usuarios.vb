Public Class Usuarios
    Dim VarSeleccion As Integer
    Dim Dato1, Dato2, Dato3, Dato4 As String
    Private Sub rut_Click(sender As Object, e As EventArgs) Handles rut.Click
        rut.SelectionLength = rut.Text.Length
    End Sub
    Sub Actualizacion_Tabla()
        Consulta("Call ConsultaUsuario")
    End Sub
    Sub Mostrar(ByVal i As Integer)
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Label7.Text = DS.Tables(DT.TableName).Rows(i).Item("ID")
            rut.Text = DS.Tables(DT.TableName).Rows(i).Item("Rut")
            nombre.Text = DS.Tables(DT.TableName).Rows(i).Item("Nombre")
            departamento.Text = DS.Tables(DT.TableName).Rows(i).Item("Departamento")
        End If
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Usuarios.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles rut.TextChanged
        If Len(rut.Text) = 2 Then
            rut.Text = rut.Text & "."
            rut.SelectionStart = rut.Text.Length
        ElseIf Len(rut.Text) = 6 Then
            rut.Text = rut.Text & "."
            rut.SelectionStart = rut.Text.Length
        ElseIf Len(rut.Text) = 10 Then
            rut.Text = rut.Text & "-"
            rut.SelectionStart = rut.Text.Length
        ElseIf Len(rut.Text) = 12 Then
            nombre.Focus()
            nombre.Select()
        End If
    End Sub
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar(0)
        If Me.Grilla_Usuarios.Rows.Count = 0 Then
            eliminar.Enabled = False
        Else
            eliminar.Enabled = True
        End If
    End Sub
    Private Sub Grilla_Usuarios_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Usuarios.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        VarSeleccion = 1
        rut.Enabled = True
        nombre.Enabled = True
        departamento.Enabled = True
        rut.ReadOnly = False
        nombre.ReadOnly = False
        departamento.ReadOnly = False
        buscar.Enabled = False
        buscar.ReadOnly = True
        guardar.Enabled = True
        nuevo.Enabled = False
        eliminar.Enabled = False
        modificar.Enabled = False
        Grilla_Usuarios.Enabled = False
        Grilla_Usuarios.ReadOnly = True
        rut.Clear()
        nombre.Clear()
        departamento.Clear()
        rut.Focus()
        rut.Select()
        SendKeys.Send("{BACKSPACE}")
        cancelar.Enabled = True
        nuevo.Focus()
        nuevo.Select()
        Consulta("Call GeneradorIDautomatico3")
        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("ID")) Is DBNull Then
            Label7.Text = 1
        Else
            Label7.Text = DS.Tables(DT.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        If Len(rut.Text) < 12 Then
            MsgBox("Error: Estructura de Rut No Valido", vbCritical, "Error, Rut Invalido")
            rut.Focus()
            rut.Select()
            rut.Clear()
        ElseIf (rut.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Rut", vbCritical, "¡Error, Campo Rut Vacio!")
            rut.Focus()
            rut.Select()
        ElseIf (nombre.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Nombre", vbCritical, "¡Error, Campo Nombre Vacio!")
            nombre.Focus()
            nombre.Select()
        ElseIf (departamento.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Departamento", vbCritical, "¡Error, Campo Departamento Vacio!")
            departamento.Focus()
            departamento.Select()
        Else
            Consulta("Call ConsultaRutValido ('" & (Label7.Text) & "','" & (rut.Text) & "','" & (nombre.Text) & "')")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                MsgBox("El Rut: " + rut.Text + " o Nombre Ya Existe En El Registro con el Rut Especificado y Departamento.", vbCritical, "Error, Rut Ya Existente")
                Actualizacion_Tabla()
                Mostrar_Grilla()
                rut.Clear()
                nombre.Clear()
                departamento.Clear()
                rut.Focus()
                rut.Select()
            ElseIf VarSeleccion = 1 Then
                Try
                    Consulta("Call Inserto_Usuarios ('" & (Label7.Text) & "','" & (rut.Text) & "','" & (nombre.Text) & "','" & (departamento.Text) & "')")
                    MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                    rut.Enabled = False
                    nombre.Enabled = False
                    departamento.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    departamento.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    modificar.Enabled = True
                    buscar.Enabled = True
                    buscar.ReadOnly = False
                    Grilla_Usuarios.Enabled = True
                    Grilla_Usuarios.ReadOnly = True
                    cancelar.Enabled = False
                    rut.Enabled = False
                    nombre.Enabled = False
                    departamento.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    departamento.ReadOnly = True
                    nuevo.Focus()
                    nuevo.Select()
                Catch ex As Exception
                    DA.SelectCommand = SC
                    DA.Fill(DT)
                End Try
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar(0)
            ElseIf VarSeleccion = 2 Then
                Try
                    Consulta("Call Modifica_Usuarios('" & (nombre.Text) & "','" & (rut.Text) & "','" & (departamento.Text) & "'," & (Label7.Text) & ")")
                    MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                    rut.Enabled = False
                    departamento.Enabled = False
                    nombre.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    departamento.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    modificar.Enabled = True
                    buscar.Enabled = True
                    buscar.ReadOnly = False
                    Grilla_Usuarios.Enabled = True
                    Grilla_Usuarios.ReadOnly = True
                    cancelar.Enabled = False
                    rut.Enabled = False
                    nombre.Enabled = False
                    departamento.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    departamento.ReadOnly = True
                    nuevo.Focus()
                    nuevo.Select()
                Catch ex As Exception
                    DA.SelectCommand = SC
                    DA.Fill(DT)
                End Try
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar(0)
            End If
        End If
    End Sub
    Private Sub rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rut.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub
    Private Sub nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Letras", vbCritical, "Error, Admición de Solo Letras")
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            departamento.Focus()
            departamento.Select()
        End If
    End Sub
    Private Sub buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged
        Dim i As Integer
        buscar.Text = StrConv(buscar.Text, VbStrConv.ProperCase)
        i = Len(buscar.Text)
        buscar.SelectionStart = i
        If (buscar.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar(0)
        Else
            Consulta("Call Busqueda_Usuarios('" & (buscar.Text & "%") & "')")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Grilla_Usuarios.DataSource = DS.Tables(DT.TableName)
                Mostrar(0)
            Else
                rut.Clear()
                nombre.Clear()
                departamento.Clear()
            End If
        End If
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Consulta03("Call Verifica_Prestado('" & (rut.Text) & "')")
        If DS03.Tables(DT03.TableName).Rows.Count > 0 Then
            MsgBox("Error: No Podras Eliminar al Rut: " + rut.Text + " Ya que el Usuario no ha Devuelto el Articulo Prestado, Asegurese de Haberlo hecho e Intentelo Denuevo", vbCritical, "Error de Rut Usuario")
        ElseIf Me.Grilla_Usuarios.Rows.Count = 0 Then
            MsgBox("Error: No Existe Usuarios Registrados, Para Eliminar se Necesita Personal Inscrito", vbCritical, "Error, Operación Incorrecta")
            nuevo.Focus()
            nuevo.Select()
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro El Siguiente Rut: " + rut.Text + " ?", vbYesNo + vbQuestion, "¿Eliminar Usuario?")
            If valormensaje = vbYes Then
                Consulta("Call Eliminarusuario ('" & (rut.Text) & "')")
                Consulta("Call Rest1")
                MsgBox("El Usuario: '" + nombre.Text + "' Con el Rut: '" + rut.Text + "' Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                Consulta("Call Rest2")
                Consulta("Call Rest3")
                buscar.Clear()
                nuevo.Focus()
                nuevo.Select()
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                nuevo.Focus()
                nuevo.Select()
            End If
            Actualizacion_Tabla()
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Mostrar(0)
            Else
                rut.Clear()
                nombre.Clear()
                departamento.Clear()
            End If
            Mostrar(0)
            Actualizacion_Tabla()
            Mostrar_Grilla()
            nuevo.Focus()
            nuevo.Select()
        End If
        nuevo.Focus()
        nuevo.Select()
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Mostrar(0)
        Mostrar_Grilla()
        Actualizacion_Tabla()
        guardar.Enabled = False
        nuevo.Enabled = True
        eliminar.Enabled = True
        modificar.Enabled = True
        buscar.Enabled = True
        buscar.ReadOnly = False
        Grilla_Usuarios.Enabled = True
        Grilla_Usuarios.ReadOnly = False
        cancelar.Enabled = False
        rut.Enabled = False
        nombre.Enabled = False
        departamento.Enabled = False
        rut.ReadOnly = True
        nombre.ReadOnly = True
        departamento.ReadOnly = True
    End Sub
    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
        Secciones1.Show()
    End Sub
    Private Sub departamento_TextChanged(sender As Object, e As EventArgs) Handles departamento.TextChanged
        Dim i As Integer
        departamento.Text = StrConv(departamento.Text, VbStrConv.ProperCase)
        i = Len(departamento.Text)
        departamento.SelectionStart = i
    End Sub
    Private Sub Grilla_Usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Usuarios.CellClick
        If Me.Grilla_Usuarios.Rows.Count = 0 Then
        Else
            Dato1 = Grilla_Usuarios.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato2 = Grilla_Usuarios.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato3 = Grilla_Usuarios.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Dato4 = Grilla_Usuarios.CurrentRow.Cells(0).EditedFormattedValue.ToString
            rut.Text = Dato1
            nombre.Text = Dato2
            departamento.Text = Dato3
            Label7.Text = Dato4
        End If
    End Sub
    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged
        Dim i As Integer
        nombre.Text = StrConv(nombre.Text, VbStrConv.ProperCase)
        i = Len(nombre.Text)
        nombre.SelectionStart = i
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        If Me.Grilla_Usuarios.Rows.Count = 0 Then
            MsgBox("Error: No hay Usuarios Registrados a Modificar", vbCritical, "Error, No hay Usuarios")
            nuevo.Focus()
            nuevo.Select()
        Else
            VarSeleccion = 2
            rut.Enabled = True
            nombre.Enabled = True
            departamento.Enabled = True
            rut.ReadOnly = False
            nombre.ReadOnly = False
            departamento.ReadOnly = False
            buscar.Enabled = False
            buscar.ReadOnly = True
            guardar.Enabled = True
            nuevo.Enabled = False
            eliminar.Enabled = False
            modificar.Enabled = False
            Grilla_Usuarios.Enabled = False
            Grilla_Usuarios.ReadOnly = True
            rut.Focus()
            rut.Select()
            cancelar.Enabled = True
            nuevo.Focus()
            nuevo.Select()
        End If
    End Sub
    Private Sub Grilla_Usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Usuarios.CellContentClick
        Grilla_Usuarios.ReadOnly = True
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Grilla_Usuarios_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Usuarios.CellEnter
        'Dim row1 As DataGridViewRow = Grilla_Usuarios.Rows(e.RowIndex)
        'rut.Text = (CStr(row1.Cells("Rut").Value))
        'nombre.Text = (CStr(row1.Cells("Nombre").Value))
        'departamento.Text = (CStr(row1.Cells("Departamento").Value))
    End Sub
    Private Sub departamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles departamento.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Letras", vbCritical, "Error, Admición de Solo Letras")
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            guardar.Focus()
            guardar.Select()
            SendKeys.Send("{ENTER}")
        End If
    End Sub
    Private Sub buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles buscar.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Letras", vbCritical, "Error, Admición de Solo Letras")
            e.Handled = True
        End If
    End Sub
End Class