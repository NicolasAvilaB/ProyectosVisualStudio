Public Class Usuarios9
    Dim VarSeleccion As Integer
    Dim MiPos As Integer
    Sub limpiar()
        TxtCajero.Clear()
        TxtClave.Clear()
    End Sub
    Sub HabilitaDesabilita1(ByVal A As Boolean, ByVal B As Boolean)
        Volver.Enabled = A
        Admin.Enabled = A
        C_SA.Enabled = A
        MSupervisor.Enabled = A
        Cajeros.Enabled = B


    End Sub
    Sub Actualizacion_Tabla()

        Consulta("Call MostrarTabla")

    End Sub
    Sub Mostrar_Grilla()
        GrillaUsuarios.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    
    Sub Borrar_Grilla()
        GrillaUsuarios.DataSource = Nothing
        Conexion.Close()
    End Sub
    
    Sub HabilitaDesabilita(ByVal A As Boolean, ByVal B As Boolean)



        TxtClave.Enabled = B
        TxtCajero.Enabled = B

        Agre_Usuarios.Enabled = B
        Modificar.Enabled = B
       
        Eliminar.Enabled = B


        Cancelar.Enabled = B

    End Sub
    Sub Mostrar(ByVal i As Integer)

        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            TxtCajero.Text = DS.Tables(DT.TableName).Rows(i).Item("N_Cajero")
            TxtClave.Text = DS.Tables(DT.TableName).Rows(i).Item("Clave")
        End If
    End Sub
    
    Private Sub Usuarios9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Conexion.Close()
        Me.Close()
        Entrada.Show()
    End Sub

    Private Sub Admin_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub Admin_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Dim esult As String
        esult = MsgBox("Cerraras el Modo Administrador, ¿Cancelas?", vbOKCancel, "Cierre Modo Administracion")
        If esult = vbOK Then
            Conexion.Close()
            TxtCajero.Clear()
            TxtClave.Clear()
            

            Terminar.Enabled = False

            P_Exteriores.Enabled = False
            Productos.Enabled = False
            Nuevos_Administradores.Enabled = False
            Volver.Enabled = True
            HabilitaDesabilita(True, False)
            HabilitaDesabilita1(True, False)
            TxtCajero.Clear()
            TxtClave.Clear()
            Borrar_Grilla()
            Ventas.Enabled = False
        Else
        End If



    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub C_SA_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub C_SA_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtCajero_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub TxtCajero_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtClave_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCodigo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Cajeros.Click
        Agre_Usuarios.Enabled = True
        Modificar.Enabled = True
        Eliminar.Enabled = True
        Terminar.Enabled = True
        Ventas.Enabled = False
        Cajeros.Enabled = False
        Cancelar.Enabled = False
        Nuevos_Administradores.Enabled = False
        P_Exteriores.Enabled = False
        Productos.Enabled = False
        Primero.Enabled = True
        Anterior.Enabled = True
        Siguiente.Enabled = True
        Ultimo.Enabled = True

        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar(0)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub Productos_Click(sender As Object, e As EventArgs)
       
        Cajeros.Enabled = False

        Cancelar.Enabled = True
        
       
    End Sub

    Private Sub Terminar2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles P_Exteriores.Click
        Me.Hide()
        Personas_Exteriores.Show()

    End Sub
    Private Sub Primero_Click(sender As Object, e As EventArgs)
        MiPos = 0
        Mostrar(MiPos)
    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs)
        If MiPos > 0 Then
            MiPos -= 1
            Mostrar(MiPos)
        End If
    End Sub

    Private Sub Ultimo_Click(sender As Object, e As EventArgs)
        MiPos = DT.Rows.Count - 1
        Mostrar(MiPos)
    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs)
        If MiPos < DT.Rows.Count - 1 Then
            MiPos += 1
            Mostrar(MiPos)
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub MAdministrador_Click(sender As Object, e As EventArgs) Handles MSupervisor.Click

        If (Admin.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Admin Para Continuar", vbCritical, "Error")
        ElseIf (C_SA.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Clave Para Continuar", vbCritical, "Error")
        Else
            Consulta("Call AccedeSupervisor ('" & (Admin.Text) & "','" & (C_SA.Text) & "')")

            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                MsgBox("Bienvenido/a Administrador/a: " + Admin.Text, vbInformation, "Seccion Administrador")


                HabilitaDesabilita(True, False)
               
                P_Exteriores.Enabled = True
                Ventas.Enabled = True
                Cajeros.Enabled = True
                Productos.Enabled = True
                Nuevos_Administradores.Enabled = True
                Admin.Enabled = False
                C_SA.Enabled = False
                MSupervisor.Enabled = False
                Volver.Enabled = False
                Cancelar.Enabled = True
                Admin.Clear()
                C_SA.Clear()
                Conexion.Close()
            Else
                MsgBox("Nombre Admin. y Clave Incorrectos", vbCritical, "Error")
                Admin.Clear()
                C_SA.Clear()
                Admin.Focus()
            End If
            Conexion.Close()
        End If
    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        Entrada.Show()

    End Sub

    Private Sub Agre_Usuarios_Click_1(sender As Object, e As EventArgs) Handles Agre_Usuarios.Click
        limpiar()
        VarSeleccion = 1
        TxtCajero.Enabled = True
        TxtClave.Enabled = True
        Agre_Usuarios.Enabled = False
        Modificar.Enabled = False
        Eliminar.Enabled = False
        Guardar.Enabled = True
    End Sub

    Private Sub Modificar_Click_1(sender As Object, e As EventArgs) Handles Modificar.Click
        VarSeleccion = 2
        TxtCajero.Enabled = True
        TxtClave.Enabled = True
        Agre_Usuarios.Enabled = False
        Guardar.Enabled = True
        Eliminar.Enabled = False
    End Sub

    Private Sub Guardar_Click_1(sender As Object, e As EventArgs) Handles Guardar.Click
        Consulta("Call VerificaCajero ('" & (TxtCajero.Text) & "')")
        If (TxtCajero.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Cajero Para Continuar", vbCritical, "Error")
        ElseIf (TxtClave.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Clave Para Continuar", vbCritical, "Error")
        ElseIf DS.Tables(DT.TableName).Rows.Count > 0 Then

            MsgBox("El Rut: " + TxtCajero.Text + " Ya Existe En El Registro", vbCritical, "Error Fatal")

        ElseIf VarSeleccion = 1 Then
            Try
                Consulta("Call InsertarCajeros ('" & (TxtCajero.Text) & "','" & (TxtClave.Text) & "')")
                MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")
                Guardar.Enabled = False
                Agre_Usuarios.Enabled = True
                TxtCajero.Enabled = False
                TxtClave.Enabled = False
                Eliminar.Enabled = True
                Modificar.Enabled = True
            Catch ex As Exception


                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try

        ElseIf VarSeleccion = 2 Then
            Try
                Consulta("Call ModificarCajeros('" & (TxtCajero.Text) & "','" & (TxtClave.Text) & "')")
                MsgBox("Datos Modificados Correctamente", vbInformation, "Felicidades")
            Catch ex As Exception
                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try
            Guardar.Enabled = False
            Agre_Usuarios.Enabled = True
            TxtCajero.Enabled = False
            TxtClave.Enabled = False
            Eliminar.Enabled = True
            Modificar.Enabled = True
        End If
        Mostrar_Grilla()
        Actualizacion_Tabla()
    End Sub

    Private Sub Eliminar_Click_1(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Desea Eliminar El Registro?", vbYesNo + vbQuestion, "Eliminar")
        If valormensaje = vbYes Then
            Consulta("Call EliminarCajero ('" & (TxtCajero.Text) & "')")

        End If

        Actualizacion_Tabla()
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Mostrar(0)
        Else
            limpiar()
        End If
        Mostrar_Grilla()
    End Sub

    Private Sub Terminar_Click(sender As Object, e As EventArgs) Handles Terminar.Click
        TxtCajero.Enabled = False
        TxtClave.Enabled = False
        Agre_Usuarios.Enabled = False
        Modificar.Enabled = False
        Eliminar.Enabled = False
        Terminar.Enabled = False
        Ventas.Enabled = True
        Cajeros.Enabled = True
        Cancelar.Enabled = True

        Nuevos_Administradores.Enabled = True
        P_Exteriores.Enabled = True
        Productos.Enabled = True


        TxtCajero.Clear()
        TxtClave.Clear()
        Borrar_Grilla()
        Guardar.Enabled = False

        Primero.Enabled = False
        Anterior.Enabled = False
        Siguiente.Enabled = False
        Ultimo.Enabled = False
    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles Nuevos_Administradores.Click
        Me.Hide()
        Nuevos_Admins.Show()

    End Sub

    Private Sub Nue_Producto_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guardar2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Modificar2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub PersonasExToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DsvToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Productos.Click

        Me.Hide()
        Producto1s.Show()

    End Sub

    Private Sub Admin_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles Admin.KeyPress
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

    Private Sub Admin_TextChanged_1(sender As Object, e As EventArgs) Handles Admin.TextChanged

    End Sub

    Private Sub C_SA_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles C_SA.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub C_SA_TextChanged_1(sender As Object, e As EventArgs) Handles C_SA.TextChanged

    End Sub

    Private Sub Primero_Click_1(sender As Object, e As EventArgs) Handles Primero.Click
        MiPos = 0
        Mostrar(MiPos)
    End Sub

    Private Sub Anterior_Click_1(sender As Object, e As EventArgs) Handles Anterior.Click
        If MiPos > 0 Then
            MiPos -= 1
            Mostrar(MiPos)
        End If
    End Sub

    Private Sub Siguiente_Click_1(sender As Object, e As EventArgs) Handles Siguiente.Click
        If MiPos < DT.Rows.Count - 1 Then
            MiPos += 1
            Mostrar(MiPos)
        End If
    End Sub

    Private Sub Ultimo_Click_1(sender As Object, e As EventArgs) Handles Ultimo.Click
        MiPos = DT.Rows.Count - 1
        Mostrar(MiPos)
    End Sub

    Private Sub Ventas_Click(sender As Object, e As EventArgs) Handles Ventas.Click
        Me.Hide()
        VentasDia.Show()


    End Sub
End Class