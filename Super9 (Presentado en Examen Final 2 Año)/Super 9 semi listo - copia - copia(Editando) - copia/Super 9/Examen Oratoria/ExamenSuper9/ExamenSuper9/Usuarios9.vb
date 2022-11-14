Public Class Usuarios9
    Dim VarSeleccion As Integer

    Dim Dato1, Dato2 As String
    Sub limpiar()
        TxtCajero.Clear()
        TxtClave.Clear()
    End Sub
    Sub HabilitaDesabilita1(ByVal A As Boolean, ByVal B As Boolean)
        Volver.Enabled = A
        Admin.Enabled = A
        C_SA.Enabled = A

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
        Consulta("select admin.N_Admin, admin.Clave from admin")
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


    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Dim esult As String
        esult = MsgBox("Cerraras el Modo Administrador, ¿Cancelas?", vbOKCancel + vbQuestion, "Cierre Modo Administracion")
        If esult = vbOK Then
            
            Conexion.Close()
            TxtCajero.Clear()
            TxtClave.Clear()
            Ver2.Enabled = False
            MSupervisor.Enabled = False
            Cierres.Enabled = False
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
            Admin.Focus()
            Admin.Select()
            Ver2.Text = "Ver"
            C_SA.PasswordChar = "*"
        Else
        End If



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


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Cajeros.Click
        Agre_Usuarios.Enabled = True
        Modificar.Enabled = True
        Eliminar.Enabled = True
        Label3.Enabled = True
        Terminar.Enabled = True
        Cierres.Enabled = False
        Ventas.Enabled = False
        Cajeros.Enabled = False
        Cancelar.Enabled = False
        Nuevos_Administradores.Enabled = False
        P_Exteriores.Enabled = False
        Productos.Enabled = False
        Busqueda.Enabled = True
        Agre_Usuarios.Focus()
        Agre_Usuarios.Select()

        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar(0)
    End Sub


    Private Sub Productos_Click(sender As Object, e As EventArgs)
       
        Cajeros.Enabled = False

        Cancelar.Enabled = True
        
       
    End Sub


    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles P_Exteriores.Click
        Me.Hide()
        Personas_Exteriores.Agre_Usuarios.Focus()
        Personas_Exteriores.Agre_Usuarios.Select()
        Personas_Exteriores.Show()

    End Sub

    Private Sub MAdministrador_Click(sender As Object, e As EventArgs) Handles MSupervisor.Click

        If (Admin.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Admin Para Continuar", vbCritical, "Error")
            Admin.Focus()
        ElseIf (C_SA.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Clave Para Continuar", vbCritical, "Error")
            C_SA.Focus()
        Else
            Consulta("Call AccedeSupervisor ('" & (Admin.Text) & "','" & (C_SA.Text) & "')")

            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                MsgBox("Bienvenido/a Administrador/a: " + Admin.Text, vbInformation, "Seccion Administrador")


                HabilitaDesabilita(True, False)
                Cierres.Enabled = True
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
                Ver2.Enabled = False

                Admin.Clear()
                C_SA.Clear()
                Conexion.Close()
                Ver2.Text = "Ver"
                C_SA.PasswordChar = "*"

                Cierres.Focus()
                Cierres.Select()
            Else
                MsgBox("Nombre Admin. y Clave Incorrectos", vbCritical, "Error")
                Admin.Clear()
                C_SA.Clear()
                Admin.Focus()
                Ver2.Text = "Ver"
                C_SA.PasswordChar = "*"
            End If
            Conexion.Close()
        End If
        Cierres.Enabled = True
    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Entrada.Ver.Text = "Ver"
        Entrada.TxtClave.PasswordChar = "*"
        Me.Close()
        Entrada.Show()

    End Sub

    Private Sub Agre_Usuarios_Click_1(sender As Object, e As EventArgs) Handles Agre_Usuarios.Click
        limpiar()
        VarSeleccion = 1
        TxtCajero.Enabled = True
        TxtClave.Enabled = False
        Agre_Usuarios.Enabled = False
        Modificar.Enabled = False
        Eliminar.Enabled = False
        Busqueda.Enabled = False
        GrillaUsuarios.Enabled = False
        Guardar.Enabled = True
        Busqueda.Clear()
    End Sub

    Private Sub Modificar_Click_1(sender As Object, e As EventArgs) Handles Modificar.Click
        VarSeleccion = 2
        TxtCajero.Enabled = True
        TxtClave.Enabled = True
        Agre_Usuarios.Enabled = False
        Guardar.Enabled = True
        Busqueda.Enabled = False
        GrillaUsuarios.Enabled = False
        Eliminar.Enabled = False
        Busqueda.Clear()
    End Sub

    Private Sub Guardar_Click_1(sender As Object, e As EventArgs) Handles Guardar.Click
        Consulta("Call VerificaCajero ('" & (TxtCajero.Text) & "')")
        If (TxtCajero.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Cajero Para Continuar", vbCritical, "Error")
            TxtCajero.Focus()
        ElseIf (TxtClave.Text = "") Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Clave Para Continuar", vbCritical, "Error")
            TxtClave.Focus()
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
                Busqueda.Enabled = True
                GrillaUsuarios.Enabled = True
                Busqueda.Clear()
            Catch ex As Exception


                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try

        ElseIf VarSeleccion = 2 Then
            Try
                Consulta("Call ModificarCajeros('" & (TxtCajero.Text) & "'," & (TxtClave.Text) & ")")
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
            Busqueda.Enabled = True
            GrillaUsuarios.Enabled = True
            Busqueda.Clear()
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
        Busqueda.Clear()
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
        Cierres.Enabled = True
        Label3.Enabled = False
        Busqueda.Enabled = False
        Agre_Usuarios.Enabled = False
        Modificar.Enabled = False
        Eliminar.Enabled = False
        Terminar.Enabled = False
        Ventas.Enabled = True
        Cajeros.Enabled = True
        Cancelar.Enabled = True
        Ver3.Enabled = False
        Nuevos_Administradores.Enabled = True
        P_Exteriores.Enabled = True
        Productos.Enabled = True


        TxtCajero.Clear()
        TxtClave.Clear()
        Borrar_Grilla()
        Guardar.Enabled = False

       

        Ver3.Text = "Ver"
        TxtClave.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles Nuevos_Administradores.Click
        Me.Hide()
        Nuevos_Admins.Agre_Usuarios.Focus()
        Nuevos_Admins.Agre_Usuarios.Select()
        Nuevos_Admins.Show()

    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Productos.Click

        Me.Hide()
        Producto1s.Nuevo.Focus()
        Producto1s.Nuevo.Select()
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
        'If (Admin.Text = "") Then
        '
        'C_SA.Enabled = False
        'Else

        'C_SA.Enabled = True
        'End If

        Consulta("select admin.N_Admin from admin where N_Admin ='" & (Admin.Text) & "'")

        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            C_SA.Enabled = False
            Ver2.Enabled = False
        Else
            C_SA.Enabled = True
            Ver2.Enabled = True

            C_SA.Focus()
            C_SA.Select()

        End If
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



        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            If (Admin.Text = "") Then
                MsgBox("Error Fatal: Porfavor Rellene El Campo Admin Para Continuar", vbCritical, "Error")
                Admin.Focus()
            ElseIf (C_SA.Text = "") Then
                MsgBox("Error Fatal: Porfavor Rellene El Campo Clave Para Continuar", vbCritical, "Error")
                C_SA.Focus()
            Else
                Consulta("Call AccedeSupervisor ('" & (Admin.Text) & "','" & (C_SA.Text) & "')")

                If DS.Tables(DT.TableName).Rows.Count = 1 Then
                    MsgBox("Bienvenido/a Administrador/a: " + Admin.Text, vbInformation, "Seccion Administrador")


                    HabilitaDesabilita(True, False)
                    Cierres.Enabled = True
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
                    Ver2.Enabled = False
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

        End If


    End Sub

    Private Sub C_SA_TextChanged_1(sender As Object, e As EventArgs) Handles C_SA.TextChanged
        If (C_SA.Text = "") Then
            Ver2.Enabled = False
            MSupervisor.Enabled = False
        Else
            Ver2.Enabled = True
            MSupervisor.Enabled = True

        End If
    End Sub


    Private Sub Ventas_Click(sender As Object, e As EventArgs) Handles Ventas.Click
        Me.Hide()
        VentasDia.Show()


    End Sub

    Private Sub TxtClave_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles TxtClave.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub TxtClave_TextChanged_1(sender As Object, e As EventArgs) Handles TxtClave.TextChanged
        If (TxtClave.Text = "") Then
            Ver3.Enabled = False
        Else
            Ver3.Enabled = True
        End If
    End Sub

    Private Sub TxtCajero_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles TxtCajero.KeyPress
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


    Private Sub Ver2_Click(sender As Object, e As EventArgs) Handles Ver2.Click
        If (C_SA.Text = "") Then
            MsgBox("Error: No Hay Nada Escrito, Por favor Escriba Su Contraseña", vbCritical, "Error Fatal")

        ElseIf (Ver2.Text = "Ver") Then
            Ver2.Text = "Ocultar"
            C_SA.PasswordChar = ""
            C_SA.Focus()
        Else
            Ver2.Text = "Ver"
            C_SA.PasswordChar = "*"
            C_SA.Focus()
        End If
    End Sub


    Private Sub Ver3_Click(sender As Object, e As EventArgs) Handles Ver3.Click
        If (TxtClave.Text = "") Then
            MsgBox("Error: No Hay Nada Escrito, Por favor Escriba Su Contraseña", vbCritical, "Error Fatal")

        ElseIf (Ver3.Text = "Ver") Then
            Ver3.Text = "Ocultar"
            TxtClave.PasswordChar = ""
            TxtClave.Focus()
        Else
            Ver3.Text = "Ver"
            TxtClave.PasswordChar = "*"
            TxtClave.Focus()
        End If
    End Sub


    Private Sub GrillaUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaUsuarios.CellClick
        Dato1 = GrillaUsuarios.CurrentRow.Cells(0).EditedFormattedValue.ToString
        Dato2 = GrillaUsuarios.CurrentRow.Cells(1).EditedFormattedValue.ToString

        TxtCajero.Text = Dato1
        TxtClave.Text = Dato2
    End Sub


    Private Sub GrillaUsuarios_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaUsuarios.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Cierres_Click(sender As Object, e As EventArgs) Handles Cierres.Click
        Me.Close()
        CierresCaja.Show()
    End Sub


    Private Sub Busqueda_TextChanged(sender As Object, e As EventArgs) Handles Busqueda.TextChanged
        If (Busqueda.Text = "") Then
            Actualizacion_Tabla()
            Mostrar(0)
            Mostrar_Grilla()

        Else
            Consulta("select * from usuarios where N_Cajero Like '" & (Busqueda.Text & "%") & "' ")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                GrillaUsuarios.DataSource = DS.Tables(DT.TableName)
                Mostrar(0)
            End If
        End If
    End Sub

End Class