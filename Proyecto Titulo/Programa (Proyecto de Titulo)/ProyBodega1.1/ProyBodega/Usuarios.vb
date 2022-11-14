Public Class Usuarios
    Dim VarSeleccion As Integer
    Dim Dato1, Dato2, Dato3, Dato4 As String
    Dim run As String
    Dim dat1, dat2, dat3, dat4 As String
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
            cargo.Text = DS.Tables(DT.TableName).Rows(i).Item("Cargo")
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
        buscar.Clear()
        VarSeleccion = 1
        rut.Enabled = True
        nombre.Enabled = True
        departamento.Enabled = True
        rut.ReadOnly = False
        nombre.ReadOnly = False
        buscar.Enabled = False
        buscar.ReadOnly = True
        cargo.Enabled = True
        cargo.ReadOnly = False
        imp.Enabled = False
        buscar.Clear()
        guardar.Enabled = True
        cargo.Clear()
        nuevo.Enabled = False
        eliminar.Enabled = False
        modificar.Enabled = False
        Grilla_Usuarios.Enabled = False
        Grilla_Usuarios.ReadOnly = True
        rut.Clear()
        nombre.Clear()
        departamento.SelectedIndex = -1
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
        buscar.Clear()
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
        ElseIf (cargo.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Cargo", vbCritical, "¡Error, Campo Cargo Vacio!")
            cargo.Focus()
            cargo.Select()
        ElseIf (departamento.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Departamento", vbCritical, "¡Error, Campo Departamento Vacio!")
            departamento.Focus()
            departamento.Select()
        Else
            If (Me.Grilla_Usuarios.Rows.Count = 0) Then
                Dato1 = Nothing
            Else
                Dato1 = Grilla_Usuarios.CurrentRow.Cells(1).EditedFormattedValue.ToString
            End If
            For Each row As DataGridViewRow In Grilla_Usuarios.Rows
                run = row.Cells(1).Value
            Next
            If (run = rut.Text) Then
                MsgBox("El Rut: " + rut.Text + " o Nombre Ya Existe En El Registro con el Rut Especificado y Departamento.", vbCritical, "Error, Rut Ya Existente")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf (Dato1 = rut.Text) Then
                MsgBox("El Rut: " + rut.Text + " o Nombre Ya Existe En El Registro con el Rut Especificado y Departamento.", vbCritical, "Error, Rut Ya Existente")
                rut.Clear()
                rut.Focus()
                rut.Select()
            ElseIf VarSeleccion = 1 Then
                Try
                    Consulta("Call Inserto_Usuarios ('" & (Label7.Text) & "','" & (rut.Text) & "','" & (nombre.Text) & "','" & (cargo.Text) & "','" & (departamento.Text) & "')")
                    MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                    rut.Enabled = False
                    nombre.Enabled = False
                    departamento.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    cargo.Enabled = False
                    cargo.ReadOnly = True
                    eliminar.Enabled = True
                    modificar.Enabled = True
                    buscar.Enabled = True
                    imp.Enabled = True
                    buscar.ReadOnly = False
                    Grilla_Usuarios.Enabled = True
                    Grilla_Usuarios.ReadOnly = True
                    cancelar.Enabled = False
                    rut.Enabled = False
                    nombre.Enabled = False
                    departamento.Enabled = False
                    rut.ReadOnly = True
                    nombre.ReadOnly = True
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
                    Consulta("Call Modifica_Usuarios('" & (nombre.Text) & "','" & (rut.Text) & "','" & (cargo.Text) & "','" & (departamento.Text) & "'," & (Label7.Text) & ")")
                    MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                        rut.Enabled = False
                        departamento.Enabled = False
                        nombre.Enabled = False
                        rut.ReadOnly = True
                        nombre.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                        eliminar.Enabled = True
                        modificar.Enabled = True
                        buscar.Enabled = True
                    buscar.ReadOnly = False
                    cargo.Enabled = False
                    cargo.ReadOnly = True
                    Grilla_Usuarios.Enabled = True
                        Grilla_Usuarios.ReadOnly = True
                    cancelar.Enabled = False
                    imp.Enabled = True
                    rut.Enabled = False
                        nombre.Enabled = False
                        departamento.Enabled = False
                        rut.ReadOnly = True
                        nombre.ReadOnly = True
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
        ElseIf Len(rut.Text) = 11 And InStr(1, "k" & Chr(75), e.KeyChar) = 1 Or Len(rut.Text) = 11 And InStr(1, "K" & Chr(75), e.KeyChar) = 1 Then
            e.KeyChar = UCase("K")
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error Numerico")
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
            modificar.Enabled = True
        Else
            Consulta("Call Busqueda_Usuarios('" & (buscar.Text & "%") & "')")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Grilla_Usuarios.DataSource = DS.Tables(DT.TableName)
                Mostrar(0)
                modificar.Enabled = False
            Else
                rut.Clear()
                nombre.Clear()
                modificar.Enabled = False
                departamento.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If Me.Grilla_Usuarios.Rows.Count = 0 Then
            MsgBox("Error: No Existe Usuarios Registrados, Para Eliminar se Necesita Personal Inscrito", vbCritical, "Error, Operación Incorrecta")
            nuevo.Focus()
            nuevo.Select()
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro El Siguiente Rut: " + rut.Text + " ?", vbYesNo + vbQuestion, "¿Eliminar Usuario?")
            If valormensaje = vbYes Then
                Consulta("Call Eliminarusuario ('" & (rut.Text) & "')")
                MsgBox("El Usuario: '" + nombre.Text + "' Con el Rut: '" + rut.Text + "' Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                buscar.Clear()
                nuevo.Focus()
                nuevo.Select()
                cargo.Clear()
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
                departamento.SelectedIndex = -1
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
        Me.Refresh()
        buscar.Clear()
        Mostrar_Grilla()
        Actualizacion_Tabla()
        Mostrar(0)
        guardar.Enabled = False
        nuevo.Enabled = True
        cargo.Enabled = False
        cargo.ReadOnly = True
        eliminar.Enabled = True
        modificar.Enabled = True
        imp.Enabled = True
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
        If (Me.Grilla_Usuarios.Rows.Count = 0) Then
            rut.Clear()
            departamento.SelectedIndex = -1
            nombre.Clear()
        End If
        Me.Refresh()
    End Sub
    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        buscar.Clear()
        Me.Close()
        Secciones1.Show()
    End Sub
    Private Sub departamento_TextChanged(sender As Object, e As EventArgs)
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
            buscar.Enabled = False
            buscar.ReadOnly = True
            cargo.Enabled = True
            imp.Enabled = False
            cargo.ReadOnly = False
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
            Grilla_Usuarios.Rows.RemoveAt(Grilla_Usuarios.CurrentRow.Index)
        End If
    End Sub
    Private Sub Grilla_Usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Usuarios.CellContentClick
        Grilla_Usuarios.ReadOnly = True
    End Sub
    Private Sub cargo_TextChanged(sender As Object, e As EventArgs) Handles cargo.TextChanged
        Dim i As Integer
        cargo.Text = StrConv(cargo.Text, VbStrConv.ProperCase)
        i = Len(cargo.Text)
        cargo.SelectionStart = i
    End Sub
    Private Sub imp_Click(sender As Object, e As EventArgs) Handles imp.Click
        Impresion_Usuarios.Owner = Me
        Impresion_Usuarios.ShowDialog()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Secciones1.Show()
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
    Private Sub departamento_KeyPress(sender As Object, e As KeyPressEventArgs)
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
    Private Sub rut_KeyDown(sender As Object, e As KeyEventArgs) Handles rut.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class