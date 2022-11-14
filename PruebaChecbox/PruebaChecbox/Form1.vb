Public Class Form1
    Dim VarSeleccion As Integer
    Dim MiPos As Integer


    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.ConnectionString = "Database=pruebachec;DataSource=localhost;User Id=root;Password=root"

        actualizar_tabla_clientes()
        mostrar(0)
    End Sub
    Sub mostrar(ByVal i As Integer)

        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Rut.Text = DS.Tables(DT.TableName).Rows(i).Item("rut")
            Nombre.Text = DS.Tables(DT.TableName).Rows(i).Item("nombre")
            Direccion.Text = DS.Tables(DT.TableName).Rows(i).Item("direccion")
            Telefono.Text = DS.Tables(DT.TableName).Rows(i).Item("telefono")
            GroupBox2.Text = DS.Tables(DT.TableName).Rows(i).Item("sexo")
            CheckBox1.Text = DS.Tables(DT.TableName).Rows(i).Item("estado")
        End If
    End Sub
    Sub actualizar_tabla_clientes()

        Consulta("select * from personal")

    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        Rut.Clear()
        Nombre.Clear()
        Direccion.Clear()
        Telefono.Clear()

        Rut.Enabled = True
        Nombre.Enabled = True
        Direccion.Enabled = True
        Telefono.Enabled = True

        Rut.ReadOnly = False
        Nombre.ReadOnly = False
        Direccion.ReadOnly = False
        Telefono.ReadOnly = False

        GroupBox2.Enabled = True
        GroupBox4.Enabled = True

        Primero.Enabled = True
        Siguiente.Enabled = True
        Ultimo.Enabled = True
        Anterior.Enabled = True

        Aceptar.Enabled = True
        Cancelar.Enabled = True
        VarSeleccion = 1
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Consulta("select * from personal where rut = '" & (Rut.Text) & "' ")
        If (Rut.Text = "") Then
            MsgBox("El Campo Rut Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Nombre.Text = "") Then
            MsgBox("El Campo Nombre Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Direccion.Text = "") Then
            MsgBox("El Campo Direccion Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf (Telefono.Text = "") Then
            MsgBox("El Campo Telefono Esta Vacio Porfavor Rellene", vbCritical, "Error Fatal")
        ElseIf DS.Tables(DT.TableName).Rows.Count > 0 Then

            MsgBox("El Rut: " + Rut.Text + " Ya Existe en el Registro", vbCritical, "Error Fatal")

        ElseIf VarSeleccion = 1 Then
            If (RadioButton1.Checked = True) Then
                Try

                    Consulta("INSERT INTO personal (RUT,NOMBRE,DIRECCION,SEXO,ESTADO,TELEFONO) VALUES ('" & (Rut.Text) & "','" & (Nombre.Text) & "','" & (Direccion.Text) & "','" & "Hombre" & "','" & CheckBox1.Text & "'," & (Telefono.Text) & ")")
                    MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")
                Catch ex As Exception
                    DA.SelectCommand = SC

                    DA.Fill(DT)

                    Rut.Enabled = False
                    Nombre.Enabled = False
                    Direccion.Enabled = False
                    Telefono.Enabled = False

                    GroupBox2.Enabled = False
                    GroupBox4.Enabled = False
                  


                End Try
            ElseIf (RadioButton2.Checked = True) Then
                Try

                    Consulta("INSERT INTO personal (RUT,NOMBRE,DIRECCION,SEXO,ESTADO,TELEFONO) VALUES ('" & (Rut.Text) & "','" & (Nombre.Text) & "','" & (Direccion.Text) & "','" & "Mujer" & "','" & CheckBox1.Text & "'," & (Telefono.Text) & ")")
                    MsgBox("Datos Ingresados Correctamente", vbInformation, "Felicidades")
                Catch ex As Exception
                    DA.SelectCommand = SC

                    DA.Fill(DT)

                    Rut.Enabled = False
                    Nombre.Enabled = False
                    Direccion.Enabled = False
                    Telefono.Enabled = False

                    GroupBox2.Enabled = False
                    GroupBox4.Enabled = False
                    

                End Try
                Rut.Enabled = False
                Nombre.Enabled = False
                Direccion.Enabled = False
                Telefono.Enabled = False

                GroupBox2.Enabled = False
                GroupBox4.Enabled = False
               
              
                End If
        End If
        Rut.Enabled = False
        Nombre.Enabled = False
        Direccion.Enabled = False
        Telefono.Enabled = False

        GroupBox2.Enabled = False
        GroupBox4.Enabled = False

    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click

        Rut.Enabled = True
        Nombre.Enabled = True
        Direccion.Enabled = True
        Telefono.Enabled = True

        Rut.ReadOnly = False
        Nombre.ReadOnly = False
        Direccion.ReadOnly = False
        Telefono.ReadOnly = False

        GroupBox2.Enabled = True
        GroupBox4.Enabled = True

        Primero.Enabled = True
        Siguiente.Enabled = True
        Ultimo.Enabled = True
        Anterior.Enabled = True

        Aceptar.Enabled = True
        Cancelar.Enabled = True
        VarSeleccion = 2
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿desea eliminar?", vbYesNo + vbQuestion, "Eliminar")
        If valormensaje = vbYes Then
            Consulta("delete from personal where rut ='" & (Rut.Text) & "' ")

        End If

        actualizar_tabla_clientes()
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            mostrar(0)
        Else
            Rut.Clear()
            Nombre.Clear()
            Direccion.Clear()
            Telefono.Clear()
        End If

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

    Private Sub Nombre_TextChanged(sender As Object, e As EventArgs) Handles Nombre.TextChanged

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
    Sub seleccion()
        If (RadioButton1.Checked = True) Then
            RadioButton2.Checked = False
        ElseIf RadioButton2.Checked = True Then
            RadioButton1.Checked = False


        End If
    End Sub

    Private Sub Telefono_TextChanged(sender As Object, e As EventArgs) Handles Telefono.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Rut.Enabled = False
        Nombre.Enabled = False
        Direccion.Enabled = False
        Telefono.Enabled = False

        GroupBox2.Enabled = False
        GroupBox4.Enabled = False
        Primero.Enabled = False
        Ultimo.Enabled = False
        Siguiente.Enabled = False
        Anterior.Enabled = False


    End Sub

    Private Sub Primero_Click(sender As Object, e As EventArgs) Handles Primero.Click
        MiPos = 0
        mostrar(MiPos)
    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
        If MiPos < DT.Rows.Count - 1 Then
            MiPos += 1
            mostrar(MiPos)
        End If
    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles Anterior.Click
        If MiPos > 0 Then
            MiPos -= 1
            mostrar(MiPos)
        End If
    End Sub

    Private Sub Ultimo_Click(sender As Object, e As EventArgs) Handles Ultimo.Click
        MiPos = DT.Rows.Count - 1
        mostrar(MiPos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If VarSeleccion = 2 Then

        End If

        If (RadioButton1.Checked = True) Then
            Consulta("UPDATE personal SET NOMBRE='" & (Nombre.Text) & "', DIRECCION='" & (Direccion.Text) & "', SEXO= 'Mujer'" & "', ESTADO=" & (CheckBox1.Text) & "',TELEFONO ='" & (Telefono.Text) & "' where RUT=" & (Rut.Text) & "")


            MsgBox("Datos Modificados Correctamente", vbInformation, "Congratulations")
            actualizar_tabla_clientes()

            Rut.Enabled = False
            Nombre.Enabled = False
            Direccion.Enabled = False
            Telefono.Enabled = False

            GroupBox2.Enabled = False
            GroupBox4.Enabled = False


        ElseIf (RadioButton2.Checked = True) Then
            Consulta("UPDATE personal SET NOMBRE='" & (Nombre.Text) & "', DIRECCION='" & (Direccion.Text) & "', SEXO= 'Mujer'" & "', ESTADO='" & (CheckBox1.Text) & "',TELEFONO =" & (Telefono.Text) & "' where RUT='" & (Rut.Text) & "")

            MsgBox("Datos Modificados Correctamente", vbInformation, "Congratulations")
            actualizar_tabla_clientes()

            Rut.Enabled = False
            Nombre.Enabled = False
            Direccion.Enabled = False
            Telefono.Enabled = False

            GroupBox2.Enabled = False
            GroupBox4.Enabled = False


            Rut.Enabled = False
            Nombre.Enabled = False
            Direccion.Enabled = False
            Telefono.Enabled = False

            GroupBox2.Enabled = False
            GroupBox4.Enabled = False

        End If
    End Sub
End Class
