Public Class Nuevos_Admins
    Dim VarSeleccion As Integer
    Dim MiPos As Integer
    Dim veri As Boolean
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub
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
        Terminar.Enabled = False
        Primero.Enabled = False
        Anterior.Enabled = False
        Siguiente.Enabled = False
        Ultimo.Enabled = False
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
                Primero.Enabled = True
                Anterior.Enabled = True
                Siguiente.Enabled = True
                Ultimo.Enabled = True
            Catch ex As Exception


                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try

            Actualizacion_Tabla()
            Mostrar_Grilla()
        ElseIf VarSeleccion = 2 Then
            Try
                Consulta("Call ModificarAdmin('" & (Administradores.Text) & "','" & (Clave.Text) & "')")
                MsgBox("Datos Modificados Correctamente", vbInformation, "Felicidades")
                Terminar.Enabled = True
                Primero.Enabled = True
                Anterior.Enabled = True
                Siguiente.Enabled = True
                Ultimo.Enabled = True
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
            
        End If

        Mostrar_Grilla()
        Actualizacion_Tabla()
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

    Private Sub Clave_TextChanged(sender As Object, e As EventArgs) Handles Clave.TextChanged

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

    Private Sub Administradores_TextChanged(sender As Object, e As EventArgs) Handles Administradores.TextChanged

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Desea Eliminar del Registro El siguiente Admin: " + Administradores.Text + " ?", vbYesNo + vbQuestion, "Eliminar")
        If valormensaje = vbYes Then
            Consulta("Call EliminarAdmin ('" & (Administradores.Text) & "')")
            MsgBox("Has Eliminado Con Exito El Admin: " + Administradores.Text, vbInformation, "Eliminado")
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
    End Sub

    Private Sub Primero_Click(sender As Object, e As EventArgs) Handles Primero.Click
        MiPos = 0
        Mostrar(MiPos)
    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles Anterior.Click
        If MiPos > 0 Then
            MiPos -= 1
            Mostrar(MiPos)
        End If
    End Sub

    Private Sub Ultimo_Click(sender As Object, e As EventArgs) Handles Ultimo.Click
        MiPos = DT.Rows.Count - 1
        Mostrar(MiPos)
    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
        If MiPos < DT.Rows.Count - 1 Then
            MiPos += 1
            Mostrar(MiPos)
        End If
    End Sub
End Class