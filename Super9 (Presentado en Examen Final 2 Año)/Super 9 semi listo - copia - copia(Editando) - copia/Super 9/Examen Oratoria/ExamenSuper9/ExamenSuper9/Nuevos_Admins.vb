Public Class Nuevos_Admins
    Dim VarSeleccion As Integer

    Dim veri As Boolean
    Dim Dato1, Dato2 As String
  
    Sub limpiar()
        Administradores.Clear()
        Clave.Clear()
    End Sub
    Sub Mostrar(ByVal i As Integer)

        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Administradores.Text = DS.Tables(DT.TableName).Rows(i).Item("N_Admin")
            Clave.Text = DS.Tables(DT.TableName).Rows(i).Item("Clave")
           
        End If
    End Sub
    Sub Actualizacion_Tabla()

        Consulta("Call MostrarAdmins")

    End Sub
    Sub Mostrar_Grilla()
        GrillaAdmins.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    Sub Borrar_Grilla()
        GrillaAdmins.DataSource = Nothing
        Conexion.Close()
    End Sub
    Private Sub Terminar_Click(sender As Object, e As EventArgs) Handles Terminar.Click
        Me.Close()
        Usuarios9.Show()

        Mostrar(0)
    End Sub

    Private Sub Agre_Usuarios_Click(sender As Object, e As EventArgs) Handles Agre_Usuarios.Click
        VarSeleccion = 1
        Agre_Usuarios.Enabled = False
        Modificar.Enabled = False
        Eliminar.Enabled = False
        Administradores.Enabled = True
        Clave.Enabled = True
        Guardar.Enabled = True
        GrillaAdmins.Enabled = False
        Busqueda.Enabled = False
        Busqueda.Clear()
        Administradores.Clear()
        Clave.Clear()

    End Sub

    Private Sub Nuevos_Admins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Grilla()
        Actualizacion_Tabla()
        Mostrar(0)
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Consulta("Call VerificaAdmin ('" & (Administradores.Text) & "')")
        If (Administradores.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Admin Para Continuar", vbCritical, "Error")
        ElseIf (Clave.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Clave Para Continuar", vbCritical, "Error")
        ElseIf DS.Tables(DT.TableName).Rows.Count > 0 Then

            MsgBox("El Admin: " + Administradores.Text + " Ya Existe En El Registro", vbCritical, "Error Fatal")
        ElseIf VarSeleccion = 1 Then

            Try
                Consulta("Call InsertarAdmin ('" & (Administradores.Text) & "','" & (Clave.Text) & "')")
                MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")
                Guardar.Enabled = False
                Agre_Usuarios.Enabled = True
                Administradores.Enabled = False
                Clave.Enabled = False
                Eliminar.Enabled = True
                Modificar.Enabled = True
                Terminar.Enabled = True
                GrillaAdmins.Enabled = True
                Busqueda.Enabled = True
                Busqueda.Clear()
            Catch ex As Exception


                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try

            Actualizacion_Tabla()
            Mostrar_Grilla()
            GrillaAdmins.Enabled = True
        ElseIf VarSeleccion = 2 Then
            Try
                Consulta("UPDATE admin SET Clave=" & (Clave.Text) & "' where N_Admin='" & (Administradores.Text) & "")
                MsgBox("Datos Modificados Correctamente", vbInformation, "Felicidades")
                Terminar.Enabled = True

            Catch ex As Exception
                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try
            Guardar.Enabled = False
            Agre_Usuarios.Enabled = True
            Administradores.Enabled = False
            Clave.Enabled = False
            Eliminar.Enabled = True
            Modificar.Enabled = True
            GrillaAdmins.Enabled = True
            Busqueda.Enabled = True
            Busqueda.Clear()
        End If

        Mostrar_Grilla()
        Actualizacion_Tabla()
        GrillaAdmins.Enabled = True
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


    Private Sub Administradores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Administradores.KeyPress
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

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Desea Eliminar del Registro El siguiente Admin: " + Administradores.Text + " ?", vbYesNo + vbQuestion, "Eliminar")
        If valormensaje = vbYes Then
            Consulta("Call EliminarAdmin ('" & (Administradores.Text) & "')")
            MsgBox("Has Eliminado Con Exito El Admin: " + Administradores.Text, vbInformation, "Eliminado")
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
        Administradores.Enabled = True
        Clave.Enabled = True
       
        Agre_Usuarios.Enabled = False
        Guardar.Enabled = True
        Eliminar.Enabled = False

        GrillaAdmins.Enabled = False
        Busqueda.Enabled = False
        Busqueda.Clear()
    End Sub



    Private Sub Ver4_Click(sender As Object, e As EventArgs) Handles Ver4.Click
        If (Clave.Text = "") Then
            MsgBox("Error: No Hay Nada Escrito, Por favor Escriba Su Contraseña", vbCritical, "Error Fatal")

        ElseIf (Ver4.Text = "Ver") Then
            Ver4.Text = "Ocultar"
            Clave.PasswordChar = ""
            Clave.Focus()
        Else
            Ver4.Text = "Ver"
            Clave.PasswordChar = "*"
            Ver4.Enabled = True
            Clave.Focus()

        End If
    End Sub

    Private Sub GrillaAdmins_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaAdmins.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Busqueda_TextChanged(sender As Object, e As EventArgs) Handles Busqueda.TextChanged
        If (Busqueda.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar(0)
        Else
            Consulta("select * from admin where N_Admin Like '" & (Busqueda.Text & "%") & "' ")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                GrillaAdmins.DataSource = DS.Tables(DT.TableName)
                Mostrar(0)
            End If
        End If
    End Sub

    Private Sub GrillaAdmins_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaAdmins.CellClick

        Dato1 = GrillaAdmins.CurrentRow.Cells(0).EditedFormattedValue.ToString
        Dato2 = GrillaAdmins.CurrentRow.Cells(1).EditedFormattedValue.ToString

        Administradores.Text = Dato1
        Clave.Text = Dato2

    End Sub
End Class