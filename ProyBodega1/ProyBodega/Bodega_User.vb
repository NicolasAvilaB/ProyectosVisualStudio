Public Class Bodega_User
    Public VarSeleccion As Integer
    Dim Vall1 As Integer
    Dim ita As Integer
    Dim mifecha As Date = Format(Now, "dd/MM/yyyy")
    Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
    Dim Dato0, Dato1, Dato2, Dato3, Dato4, Dato5, Dato6 As String
    Dim dat1, dat2, dat3, dat4, dat5, dat6, dat7 As String
    Dim run As String
    Dim run2 As String
    Dim cddd As String
    Dim estado1 As String
    Sub Actualizacion_Tabla()
        Consulta("Call GrillaVi")
    End Sub
    Sub Mostrar()
        If (DS.Tables(DT.TableName).Rows.Count > 0) Then
            Dato0 = Grilla_Bodega.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato1 = Grilla_Bodega.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato2 = Grilla_Bodega.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Dato3 = Grilla_Bodega.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato4 = Grilla_Bodega.CurrentRow.Cells(4).EditedFormattedValue.ToString
            Dato5 = Grilla_Bodega.CurrentRow.Cells(7).EditedFormattedValue.ToString
            rutees.Text = Dato1
            depart.Text = Dato2
            code.Text = Dato3
            cantied.Text = Dato4
            estad.Text = Dato5
        Else
            rutees.Clear()
            depart.Clear()
            code.Clear()
            cantied.Clear()
            estad.Clear()
        End If
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Bodega.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        VarSeleccion = 1
        rutees.Enabled = True
        code.Enabled = True
        estad.Enabled = True
        rutees.ReadOnly = False
        code.ReadOnly = False
        devolucion_articulos.Enabled = False
        guardar.Enabled = True
        hc.Enabled = False
        busqueda_rut.Enabled = False
        busqueda_rut.ReadOnly = True
        guardar.Enabled = True
        nuevo.Enabled = False
        eliminar.Enabled = False
        modificar.Enabled = False
        Grilla_Bodega.Enabled = False
        Grilla_Bodega.ReadOnly = True
        rutees.Clear()
        depart.Clear()
        code.Clear()
        cantied.Clear()
        estad.Clear()
        rutees.Focus()
        rutees.Select()
        cancelar.Enabled = True
        SendKeys.Send("{BACKSPACE}")
        nuevo.Focus()
        nuevo.Select()
    End Sub
    Private Sub busqueda_rut_TextChanged(sender As Object, e As EventArgs) Handles busqueda_rut.TextChanged
        If Len(busqueda_rut.Text) = 2 Then
            busqueda_rut.Text = busqueda_rut.Text & "."
            busqueda_rut.SelectionStart = busqueda_rut.Text.Length
        ElseIf Len(busqueda_rut.Text) = 6 Then
            busqueda_rut.Text = busqueda_rut.Text & "."
            busqueda_rut.SelectionStart = busqueda_rut.Text.Length
        ElseIf Len(busqueda_rut.Text) = 10 Then
            busqueda_rut.Text = busqueda_rut.Text & "-"
            busqueda_rut.SelectionStart = busqueda_rut.Text.Length
        ElseIf Len(busqueda_rut.Text) = 12 Then
        End If
        If (busqueda_rut.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
        Else
            Consulta("Call Busqueda_Rutes('" & (busqueda_rut.Text) & "')")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Grilla_Bodega.DataSource = DS.Tables(DT.TableName)
                Mostrar()
            Else
                rutees.Clear()
                depart.Clear()
                cantied.Clear()
                code.Clear()
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Secciones1.Show()
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        If (estad.Text = "Comprado") Then
            ErrorProvider1.SetError(estad, Nothing)
        ElseIf (estad.Text = "Prestado") Then
            ErrorProvider1.SetError(estad, Nothing)
        Else
            ErrorProvider1.SetError(estad, "Error: Solo se Permite 'Comprado' y 'Prestado'")
            MsgBox("Error: No ha especificado Estado: Comprado y/o Prestado", vbCritical, "Error de Estado")
        End If
        If Len(rutees.Text) < 12 Then
            MsgBox("Error: Estructura de Rut No Valido", vbCritical, "Error, Rut Invalido")
            rutees.Focus()
            rutees.Select()
            rutees.Clear()
        ElseIf (rutees.Text = "") Then
            MsgBox("Error: No se ha Describido un Rut Valido", vbCritical, "¡Error, Rut no Descrito!")
            rutees.Focus()
            rutees.Select()
            rutees.Clear()
        ElseIf (depart.Text = "") Then
            MsgBox("Error: No se ha Describido un Departamento Valido", vbCritical, "¡Error de Departamento!")
            depart.Focus()
            depart.Select()
            depart.Clear()
        ElseIf (code.Text = "") Then
            MsgBox("Error: No existe un Codigo Escrito aun", vbCritical, "¡Error, Codigo no Especificado!")
            code.Focus()
            code.Select()
            code.Clear()
        ElseIf (cantied.Text = "") Then
            MsgBox("Error: No existe una Cantidad Especifica", vbCritical, "¡Error, Cantidad no Especificado!")
            cantied.Focus()
            cantied.Select()
            cantied.Clear()
        ElseIf (estad.Text = "") Then
            MsgBox("Error: No existe un Estado Descrito por el Codigo", vbCritical, "¡Error, Estado no Especificado!")
            estad.Focus()
            estad.Select()
            estad.Clear()
        ElseIf (cantied.Text <= 0) Then
            MsgBox("Error: No Puedes Digitar Cantidad 0 o Menor a Esta ", vbCritical, "¡Error, Cantidad Incorrecta")
            cantied.Focus()
            cantied.Select()
            cantied.Clear()
        ElseIf cantied.ForeColor = Color.Red Then
            MsgBox("Error: La Cantidad " & cantied.Text & " del Codigo: " & code.Text & " Esta SobrePasada a la Actual Guardada en el Registro, Porfavor Verfique Bien la Cantidad del Articulo e Intentelo denuevo", vbCritical, "Error, Cantidad SobrePasada")
            cantied.Clear()
            cantied.Focus()
            cantied.Select()
        ElseIf Label7.Text = "Codigo no Existente" Then
            MsgBox("Error: El Codigo Ingresado No Corresponde a Ningun Articulo", vbCritical, "Error Codigo de Ingreso")
            code.Focus()
            code.Select()
            cantied.Clear()
            estad.Clear()
        Else
            For Each row As DataGridViewRow In Grilla_Bodega.Rows
                cddd = row.Cells(1).Value
                run2 = row.Cells(2).Value
                estado1 = row.Cells(7).Value
            Next
            If (cddd = code.Text And run2 = rutees.Text And estado1 = "Prestado") Then
                MsgBox("El Rut: " + rutees.Text + " o Codigo Ya Existe En El Registro.", vbCritical, "Error, Rut Ya Existente")
                rutees.Clear()
                rutees.Focus()
                rutees.Select()
            ElseIf VarSeleccion = 1 Then
                If (estad.Text = "Comprado") Then
                    Try
                        Consulta("Call Resta_Cantidad ('" & (cantied.Text) & "','" & (code.Text) & "')")
                        Consulta("Call Inserto_Compr('" & (code.Text) & "','" & (rutees.Text) & "','" & (depart.Text) & "','" & (cantied.Text) & "','" & (Label9.Text) & "','" & (mifecha2) & "','" & (Now.ToLongTimeString) & "')")
                        MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                        rutees.Enabled = False
                        depart.Enabled = False
                        code.Enabled = False
                        cantied.Enabled = False
                        estad.Enabled = False
                        depart.ReadOnly = True
                        code.ReadOnly = True
                        cantied.ReadOnly = True
                        devolucion_articulos.Enabled = True
                        hc.Enabled = True
                        guardar.Enabled = False
                        nuevo.Enabled = True
                        eliminar.Enabled = True
                        modificar.Enabled = True
                        busqueda_rut.Enabled = True
                        busqueda_rut.ReadOnly = False
                        Grilla_Bodega.Enabled = True
                        Grilla_Bodega.ReadOnly = True
                        cancelar.Enabled = False
                        rutees.Enabled = False
                        depart.Enabled = False
                        code.Enabled = False
                        cantied.Enabled = False
                        estad.Enabled = False
                        depart.ReadOnly = True
                        code.ReadOnly = True
                        cantied.ReadOnly = True
                        nuevo.Focus()
                        nuevo.Select()
                    Catch ex As Exception
                        DA.SelectCommand = SC
                        DA.Fill(DT)
                    End Try
                    Actualizacion_Tabla()
                    Mostrar_Grilla()
                    Mostrar()
                ElseIf (estad.Text = "Prestado") Then
                    'TextBox1.Clear()
                    '  Dim rand As New Random
                    '  Dim letter As String
                    '  Dim x As Integer
                    '  Randomize()
                    '  For x = 1 To 20
                    '  TextBox1.Text = TextBox1.Text & (Int(Rnd() * 10))
                    '  letter = ChrW(rand.Next(65, 90))
                    '  TextBox1.Text = TextBox1.Text & letter
                    '  Next                                    <^--- Generar Aleotariamente Numeros y Letras
                    Try
                        Consulta("Call Resta_Cantidad ('" & (cantied.Text) & "','" & (code.Text) & "')")
                        Consulta("Call Inserto_Bodega ('" & (code.Text) & "','" & (rutees.Text) & "','" & (depart.Text) & "','" & (cantied.Text) & "','" & (Now.ToLongTimeString) & "','" & (mifecha2) & "','" & (estad.Text) & "')")
                        Consulta("Call Inserto_Prestamos ('" & (code.Text) & "','" & (rutees.Text) & "','" & (depart.Text) & "','" & (cantied.Text) & "','" & (mifecha2) & "','" & (Now.ToLongTimeString) & "')")
                        MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                        rutees.Enabled = False
                        depart.Enabled = False
                        code.Enabled = False
                        cantied.Enabled = False
                        estad.Enabled = False
                        depart.ReadOnly = True
                        code.ReadOnly = True
                        cantied.ReadOnly = True
                        hc.Enabled = True
                        devolucion_articulos.Enabled = True
                        guardar.Enabled = False
                        nuevo.Enabled = True
                        eliminar.Enabled = True
                        modificar.Enabled = True
                        busqueda_rut.Enabled = True
                        busqueda_rut.ReadOnly = False
                        Grilla_Bodega.Enabled = True
                        Grilla_Bodega.ReadOnly = True
                        cancelar.Enabled = False
                        rutees.Enabled = False
                        depart.Enabled = False
                        code.Enabled = False
                        cantied.Enabled = False
                        estad.Enabled = False
                        depart.ReadOnly = True
                        code.ReadOnly = True
                        cantied.ReadOnly = True
                        nuevo.Focus()
                        nuevo.Select()
                    Catch ex As Exception
                        DA.SelectCommand = SC
                        DA.Fill(DT)
                    End Try
                    Actualizacion_Tabla()
                    Mostrar_Grilla()
                    Mostrar()
                End If
            End If
        End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
    End Sub
    Private Sub Bodega_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Grilla()
        Actualizacion_Tabla()
        Mostrar()
        Vall1 = 0
        ita = 0
        Items.Enabled = True
        Items.Interval = 50
        Cantidades.Enabled = True
        Cantidades.Interval = 50
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        guardar.Enabled = False
        nuevo.Enabled = True
        eliminar.Enabled = True
        modcode.Enabled = False
        modcode.Visible = False
        modificar.Enabled = True
        hc.Enabled = True
        busqueda_rut.Enabled = True
        busqueda_rut.ReadOnly = False
        Grilla_Bodega.Enabled = True
        Grilla_Bodega.ReadOnly = False
        cancelar.Enabled = False
        rutees.Enabled = False
        depart.Enabled = False
        code.Enabled = False
        num1.Visible = False
        cantied.Enabled = False
        gur.Visible = False
        estad.Enabled = False
        devolucion_articulos.Enabled = True
        depart.ReadOnly = True
        code.ReadOnly = True
        cantied.Enabled = False
        cantied.ReadOnly = True
        cantied.ReadOnly = True
        Mostrar_Grilla()
        Actualizacion_Tabla()
        Mostrar()
        If (Me.Grilla_Bodega.Rows.Count = 0) Then
            rutees.Clear()
            code.Clear()
            cantied.Clear()
            estad.Clear()
        End If
    End Sub
    Private Sub rutees_TextChanged(sender As Object, e As EventArgs) Handles rutees.TextChanged
        If Len(rutees.Text) = 2 Then
            rutees.Text = rutees.Text & "."
            rutees.SelectionStart = rutees.Text.Length
        ElseIf Len(rutees.Text) = 6 Then
            rutees.Text = rutees.Text & "."
            rutees.SelectionStart = rutees.Text.Length
        ElseIf Len(rutees.Text) = 10 Then
            rutees.Text = rutees.Text & "-"
            rutees.SelectionStart = rutees.Text.Length
        ElseIf Len(rutees.Text) = 12 Then
        End If
        If (rutees.Text = "") Then
            nombre.Text = Nothing
        Else
            Consulta01("Call Despliegue_Desderut('" & (rutees.Text) & "')")
            If DS01.Tables(DT01.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT01.Rows(0)
                nombre.Text = CStr(row("Nombre"))
                depart.Text = CStr(row("Departamento"))
            Else
                nombre.Text = Nothing
            End If
        End If
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If Me.Grilla_Bodega.Rows.Count = 0 Then
            MsgBox("Error: No hay Articulos existentes Prestados o Comprados a Eliminar", vbCritical, "Error, No hay Articulos")
            nuevo.Focus()
            nuevo.Select()
        ElseIf (estad.Text = "Prestado") Then
            MsgBox("Error: No puedes Eliminar Articulos Prestados, Solo los Articulos Comprados, Pueden ser Eliminados", vbCritical, "Error de Estado de Articulos")
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro El Siguiente Rut: " + rutees.Text + " ?", vbYesNo + vbQuestion, "¿Eliminar Rut?")
            If valormensaje = vbYes Then
                Consulta("Call Eliminar_Usuario_Bodega ('" & (rutees.Text) & "','" & (Dato0) & "','" & (code.Text) & "')")
                MsgBox("El Rut: '" + rutees.Text + "' Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                busqueda_rut.Clear()
                nuevo.Focus()
                nuevo.Select()
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                nuevo.Focus()
                nuevo.Select()
            End If
            Actualizacion_Tabla()
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Mostrar()
            Else
                rutees.Clear()
                depart.Clear()
                code.Clear()
                cantied.Clear()
                estad.Clear()
            End If
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
            nuevo.Focus()
            nuevo.Select()
            nuevo.Focus()
            nuevo.Select()
        End If
    End Sub
    Private Sub Grilla_Bodega_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Bodega.CellContentClick
        Grilla_Bodega.ReadOnly = True
    End Sub
    Private Sub code_TextChanged_1(sender As Object, e As EventArgs) Handles code.TextChanged
        If (code.Text = "") Then
            Label7.Text = Nothing
            Label9.Text = Nothing
        Else
            Consulta01("Call Codigo_Multiuso ('" & (code.Text) & "')")
            If DS01.Tables(DT01.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT01.Rows(0)
                Label7.Text = CStr(row("Nombre"))
            ElseIf DS01.Tables(DT01.TableName).Rows.Count = 1 And estad.Text = "Comprado" Then
                Dim row As DataRow = DT01.Rows(0)
                Label9.Text = CStr(row("Precio"))
                Label7.Text = CStr(row("Nombre"))
            Else
                Label7.Text = "Codigo no Existente"
                Label9.Text = Nothing
            End If
        End If
        If (code.Text = "") Then
            estad.Clear()
        Else
            Consulta01("Call Codigo_Multiuso('" & (code.Text) & "')")
            If DS01.Tables(DT01.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT01.Rows(0)
                Label9.Text = CStr(row("Precio"))
            Else
                Label9.Text = Nothing
            End If
        End If
        If (Label7.Text = "Codigo no Existente" Or code.Text = "") Then
            cantied.Enabled = False
            cantied.ReadOnly = True
        Else
            cantied.Enabled = True
            cantied.ReadOnly = False
        End If
        If (gur.Visible = True And Label7.Text = Label7.Text) Then
            cantied.Enabled = False
            cantied.ReadOnly = True
            cantied2.Enabled = True
            cantied2.Visible = True
            cantied2.ReadOnly = False
            Label13.Visible = True
            num1.Visible = False
            num1.Text = ""
            num1.Text = "0"
        ElseIf (gur.Visible = True And Label7.Text = "Codigo no Existente") Then
            cantied2.Enabled = False
            cantied2.Visible = False
            cantied2.ReadOnly = True
            Label13.Visible = False
            num1.Visible = False
            num1.Text = ""
            num1.Text = "0"
        End If
    End Sub
    Private Sub cantied_TextChanged(sender As Object, e As EventArgs) Handles cantied.TextChanged
        Consulta01("select articulos.Codigo,articulos.Cantidad from articulos where Codigo = '" & (code.Text) & "'and Cantidad <'" & (cantied.Text) & "' ")
        If DS01.Tables(DT01.TableName).Rows.Count = 0 Then
            cantied.ForeColor = Color.Black
        Else
            cantied.ForeColor = Color.Red
        End If
        If (cantied.Text = "0") Then
            SendKeys.Send("{BACKSPACE}")
        End If
        If (cantied.ForeColor = Color.Red) Then
            ErrorProvider1.SetError(cantied, "Error: Cantidad Sobrepasada a la Actual y/o El Articulo se quedo sin Stock")
        ElseIf (cantied.Text = "") Then
            ErrorProvider1.SetError(cantied, Nothing)
        ElseIf (cantied.ForeColor = Color.Black) Then
            ErrorProvider1.SetError(cantied, Nothing)
        End If
        If nuevo.Enabled = True Then
            cantied.Enabled = False
            cantied.ReadOnly = True
        End If
    End Sub
    Private Sub rutees_Click(sender As Object, e As EventArgs) Handles rutees.Click
        rutees.SelectionLength = rutees.Text.Length
    End Sub
    Private Sub busqueda_rut_Click(sender As Object, e As EventArgs) Handles busqueda_rut.Click
        busqueda_rut.SelectionLength = busqueda_rut.Text.Length
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        VarSeleccion = 2
        SolicitudContraseña_Admin3.Owner = Me
        SolicitudContraseña_Admin3.ShowDialog()
    End Sub
    Private Sub Grilla_Bodega_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Bodega.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles devolucion_articulos.Click
        Devolver_Articulo.Owner = Me
        Devolver_Articulo.ShowDialog()
    End Sub
    Private Sub code_KeyPress(sender As Object, e As KeyPressEventArgs) Handles code.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles modcode.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Desea Modificar el Codigo de Articulo? ¡Advertencia!: La Cantidad del Articulo sera Repuesta al Stock", vbYesNo + vbQuestion, "¿Modificar Codigo?")
        If valormensaje = vbYes Then
            Consulta9("Call Sumar_Cantidad ('" & (cantied.Text) & "','" & (code.Text) & "')")
            code.Clear()
            code.Focus()
            modcode.Enabled = False
            code.Select()
            code.ReadOnly = False
            cancelar.Enabled = False
            Button1.Enabled = False
            Button3.Enabled = False
            num1.Visible = False
            num1.Text = ""
            num1.Text = "0"
        Else
            MsgBox("Se Cancelo la Operacion", vbExclamation, "Operacion Cancelada")
        End If
    End Sub

    Private Sub cantied2_TextChanged(sender As Object, e As EventArgs) Handles cantied2.TextChanged
        Consulta9("select articulos.Codigo,articulos.Cantidad from articulos where Codigo = '" & (code.Text) & "'and Cantidad <'" & (cantied2.Text) & "' ")
        If DS9.Tables(DT9.TableName).Rows.Count = 0 Then
            cantied2.ForeColor = Color.Black
        Else
            cantied2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub num1_ValueChanged_1(sender As Object, e As EventArgs) Handles num1.ValueChanged
        Consulta9("select articulos.Codigo,articulos.Cantidad from articulos where Codigo = '" & (code.Text) & "'and Cantidad <'" & (num1.Text) & "' ")
        If DS9.Tables(DT9.TableName).Rows.Count = 0 Then
            num1.ForeColor = Color.Black
        Else
            num1.ForeColor = Color.Red
        End If
    End Sub
    Private Sub cantied_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cantied.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            estad.Focus()
            estad.Select()
        End If
    End Sub
    Private Sub hc_Click(sender As Object, e As EventArgs) Handles hc.Click
        History_Compr.Owner = Me
        History_Compr.ShowDialog()
    End Sub
    Private Sub Items_Tick(sender As Object, e As EventArgs) Handles Items.Tick
        If Me.Grilla_Bodega.Rows.Count = 0 Then
            itemss.Text = "0"
        Else
            ita = ita + 1
            Dim cantidad1 As Integer = 0.0
            For i = 1 To Grilla_Bodega.Rows.Count
                cantidad1 = i
            Next
            itemss.Text = Convert.ToInt64(cantidad1)
        End If
    End Sub
    Private Sub gur_Click(sender As Object, e As EventArgs) Handles gur.Click
        If (estad.Text = "Comprado") Then
            ErrorProvider1.SetError(estad, Nothing)
        ElseIf (estad.Text = "Prestado") Then
            ErrorProvider1.SetError(estad, Nothing)
        Else
            ErrorProvider1.SetError(estad, "Error: Solo se Permite 'Comprado' y 'Prestado'")
            MsgBox("Error: No ha especificado Estado: Comprado y/o Prestado", vbCritical, "Error de Estado")
        End If
        If (Label7.Text = "Codigo no Existente" And cantied2.Enabled = False And cantied2.Visible = False) Then
            MsgBox("Error: El Codigo Ingresado No Corresponde a Ningun Articulo", vbCritical, "Error Codigo de Ingreso")
            code.Focus()
            code.Select()
            code.Clear()
            estad.Clear()
        ElseIf (cantied2.ForeColor = Color.Red And Label7.Text = "Codigo Comprobado" And Button1.Enabled = False) Then
            MsgBox("Error: La Cantidad Ingresada a Modificar del Codigo: " & code.Text & " Esta SobrePasada a la Actual Guardada en el Registro, Porfavor Verfique Bien la Cantidad del Articulo e Intentelo denuevo", vbCritical, "Error, Cantidad SobrePasada")
            cantied2.Clear()
            cantied2.Focus()
            cantied2.Select()
        ElseIf Len(rutees.Text) < 12 Then
            MsgBox("Error: Estructura de Rut No Valido", vbCritical, "Error, Rut Invalido")
            rutees.Focus()
            rutees.Select()
            rutees.Clear()
        ElseIf (rutees.Text = "") Then
            MsgBox("Error: No se ha Describido un Rut Valido", vbCritical, "¡Error, Rut no Descrito!")
            rutees.Focus()
            rutees.Select()
            rutees.Clear()
        ElseIf (depart.Text = "") Then
            MsgBox("Error: No se ha Describido un Departamento Valido", vbCritical, "¡Error de Departamento!")
            depart.Focus()
            depart.Select()
            depart.Clear()
        ElseIf (code.Text = "") Then
            MsgBox("Error: No existe un Codigo Escrito aun", vbCritical, "¡Error, Codigo no Especificado!")
            code.Focus()
            code.Select()
            code.Clear()
        ElseIf (num1.Text = "") Then
            MsgBox("Error: No existe una Cantidad Especifica", vbCritical, "¡Error, Cantidad no Especificado!")
            num1.Focus()
            num1.Select()
            num1.Text = ""
            num1.Text = "0"
        ElseIf (estad.Text = "") Then
            MsgBox("Error: No existe un Estado Descrito por el Codigo", vbCritical, "¡Error, Estado no Especificado!")
            estad.Focus()
            estad.Select()
            estad.Clear()
        ElseIf Label7.Text = "Codigo no Existente" Then
            MsgBox("Error: El Codigo Ingresado No Corresponde a Ningun Articulo", vbCritical, "Error Codigo de Ingreso")
            code.Focus()
            code.Select()
            num1.Text = ""
            num1.Text = "0"
            estad.Clear()
        Else
            If (Me.Grilla_Bodega.Rows.Count = 0) Then
                Dato1 = Nothing
            Else
                Dato1 = Grilla_Bodega.CurrentRow.Cells(2).EditedFormattedValue.ToString
            End If
            For Each row As DataGridViewRow In Grilla_Bodega.Rows
                run = row.Cells(2).Value
            Next
            If (run = rutees.Text) Then
                MsgBox("El Rut: " + rutees.Text + " o Nombre Ya Existe En El Registro con el Rut Especificado y Departamento.", vbCritical, "Error, Rut Ya Existente")
                rutees.Clear()
                rutees.Focus()
                rutees.Select()
            ElseIf (Dato1 = rutees.Text) Then
                MsgBox("El Rut: " + rutees.Text + " o Nombre Ya Existe En El Registro con el Rut Especificado y Departamento.", vbCritical, "Error, Rut Ya Existente")
                rutees.Clear()
                rutees.Focus()
                rutees.Select()
            ElseIf VarSeleccion = 2 Then
                Try
                    If num1.ForeColor = Color.Red Then
                        MsgBox("Error: La Cantidad Ingresada a Modificar del Codigo: " & code.Text & " Esta SobrePasada a la Actual Guardada en el Registro, Porfavor Verfique Bien la Cantidad del Articulo e Intentelo denuevo", vbCritical, "Error, Cantidad SobrePasada")
                        num1.Text = ""
                        num1.Text = "0"
                        num1.Focus()
                        num1.Select()
                    ElseIf (cantied2.Enabled = True And cantied2.ReadOnly = False And gur.Visible = True And num1.Visible = False And cantied2.Visible = True) Then
                        If (estad.Text = "Comprado") Then
                            Consulta9("Call Inserto_Compr('" & (code.Text) & "','" & (rutees.Text) & "','" & (depart.Text) & "','" & (cantied2.Text) & "','" & (Label9.Text) & "','" & (mifecha2) & "','" & (Now.ToLongTimeString) & "')")
                            Consulta9("Call Eliminar_Usuario_Bodega ('" & (rutees.Text) & "','" & (Dato0) & "','" & (code.Text) & "')")
                            Consulta9("Call Resta_Cantidad ('" & (cantied2.Text) & "','" & (code.Text) & "')")
                            MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                            rutees.Enabled = False
                            depart.Enabled = False
                            Button1.Enabled = True
                            Button3.Enabled = True
                            code.Enabled = False
                            cantied.Enabled = False
                            estad.Enabled = False
                            num1.Text = ""
                            num1.Text = "0"
                            modcode.Enabled = False
                            modcode.Visible = False
                            depart.ReadOnly = True
                            code.ReadOnly = True
                            cantied.ReadOnly = True
                            hc.Enabled = True
                            guardar.Enabled = False
                            nuevo.Enabled = True
                            eliminar.Enabled = True
                            modificar.Enabled = True
                            busqueda_rut.Enabled = True
                            busqueda_rut.ReadOnly = False
                            Grilla_Bodega.Enabled = True
                            Grilla_Bodega.ReadOnly = True
                            cancelar.Enabled = False
                            devolucion_articulos.Enabled = True
                            rutees.Enabled = False
                            depart.Enabled = False
                            code.Enabled = False
                            cantied.Enabled = False
                            estad.Enabled = False
                            depart.ReadOnly = True
                            num1.Visible = False
                            code.ReadOnly = True
                            gur.Visible = False
                            cantied.ReadOnly = True
                            cantied2.Enabled = False
                            cantied2.Visible = False
                            cantied2.ReadOnly = True
                            Label13.Visible = False
                            nuevo.Focus()
                            nuevo.Select()
                            Actualizacion_Tabla()
                            Mostrar_Grilla()
                            Mostrar()
                        ElseIf (estad.Text = "Prestado") Then
                            Consulta9("Call Modifica_Bodega ('" & (code.Text) & "','" & (rutees.Text) & "','" & (depart.Text) & "'," & (cantied2.Text) & ",'" & (Now.ToLongTimeString) & "','" & (mifecha2) & "','" & (estad.Text) & "','" & (Dato0) & "')")
                            Consulta9("Call Resta_Cantidad ('" & (cantied2.Text) & "','" & (code.Text) & "')")
                            MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                            rutees.Enabled = False
                            depart.Enabled = False
                            Button1.Enabled = True
                            Button3.Enabled = True
                            code.Enabled = False
                            cantied.Enabled = False
                            estad.Enabled = False
                            num1.Text = ""
                            num1.Text = "0"
                            depart.ReadOnly = True
                            code.ReadOnly = True
                            modcode.Enabled = False
                            modcode.Visible = False
                            cantied.ReadOnly = True
                            hc.Enabled = True
                            guardar.Enabled = False
                            nuevo.Enabled = True
                            eliminar.Enabled = True
                            modificar.Enabled = True
                            busqueda_rut.Enabled = True
                            busqueda_rut.ReadOnly = False
                            Grilla_Bodega.Enabled = True
                            Grilla_Bodega.ReadOnly = True
                            cancelar.Enabled = False
                            devolucion_articulos.Enabled = True
                            num1.Visible = False
                            rutees.Enabled = False
                            depart.Enabled = False
                            code.Enabled = False
                            cantied.Enabled = False
                            estad.Enabled = False
                            depart.ReadOnly = True
                            code.ReadOnly = True
                            gur.Visible = False
                            cantied.ReadOnly = True
                            cantied2.Enabled = False
                            cantied2.Visible = False
                            cantied2.ReadOnly = True
                            Label13.Visible = False
                            nuevo.Focus()
                            nuevo.Select()
                            Actualizacion_Tabla()
                            Mostrar_Grilla()
                            Mostrar()
                        End If
                    Else
                        If (estad.Text = "Comprado") Then
                            Consulta9("Call Inserto_Compr('" & (code.Text) & "','" & (rutees.Text) & "','" & (depart.Text) & "','" & (CInt(cantied.Text) + CInt(num1.Text)) & "','" & (Label9.Text) & "','" & (mifecha2) & "','" & (Now.ToLongTimeString) & "')")
                            Consulta9("Call Eliminar_Usuario_Bodega ('" & (rutees.Text) & "','" & (Dato0) & "','" & (code.Text) & "')")
                            Consulta9("Call Resta_Cantidad ('" & (num1.Text) & "','" & (code.Text) & "')")
                            MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                            rutees.Enabled = False
                            depart.Enabled = False
                            code.Enabled = False
                            cantied.Enabled = False
                            estad.Enabled = False
                            num1.Text = ""
                            num1.Text = "0"
                            depart.ReadOnly = True
                            code.ReadOnly = True
                            cantied.ReadOnly = True
                            hc.Enabled = True
                            guardar.Enabled = False
                            nuevo.Enabled = True
                            eliminar.Enabled = True
                            modificar.Enabled = True
                            busqueda_rut.Enabled = True
                            busqueda_rut.ReadOnly = False
                            Grilla_Bodega.Enabled = True
                            Grilla_Bodega.ReadOnly = True
                            modcode.Enabled = False
                            modcode.Visible = False
                            cancelar.Enabled = False
                            devolucion_articulos.Enabled = True
                            rutees.Enabled = False
                            depart.Enabled = False
                            code.Enabled = False
                            cantied.Enabled = False
                            estad.Enabled = False
                            depart.ReadOnly = True
                            num1.Visible = False
                            code.ReadOnly = True
                            gur.Visible = False
                            cantied.ReadOnly = True
                            cantied2.Enabled = False
                            cantied2.Visible = False
                            cantied2.ReadOnly = True
                            Label13.Visible = False
                            nuevo.Focus()
                            nuevo.Select()
                            Actualizacion_Tabla()
                            Mostrar_Grilla()
                            Mostrar()
                        ElseIf (estad.Text = "Prestado") Then
                            Consulta9("Call Modifica_Bodega ('" & (code.Text) & "','" & (rutees.Text) & "','" & (depart.Text) & "'," & (CInt(cantied.Text) + CInt(num1.Text)) & ",'" & (Now.ToLongTimeString) & "','" & (mifecha2) & "','" & (estad.Text) & "','" & (Dato0) & "')")
                            Consulta9("Call Resta_Cantidad ('" & (num1.Text) & "','" & (code.Text) & "')")
                            MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                            rutees.Enabled = False
                            depart.Enabled = False
                            code.Enabled = False
                            cantied.Enabled = False
                            estad.Enabled = False
                            num1.Text = ""
                            num1.Text = "0"
                            depart.ReadOnly = True
                            code.ReadOnly = True
                            cantied.ReadOnly = True
                            hc.Enabled = True
                            guardar.Enabled = False
                            nuevo.Enabled = True
                            eliminar.Enabled = True
                            modificar.Enabled = True
                            busqueda_rut.Enabled = True
                            busqueda_rut.ReadOnly = False
                            Grilla_Bodega.Enabled = True
                            Grilla_Bodega.ReadOnly = True
                            modcode.Enabled = False
                            modcode.Visible = False
                            cancelar.Enabled = False
                            devolucion_articulos.Enabled = True
                            num1.Visible = False
                            rutees.Enabled = False
                            depart.Enabled = False
                            code.Enabled = False
                            cantied.Enabled = False
                            estad.Enabled = False
                            depart.ReadOnly = True
                            code.ReadOnly = True
                            gur.Visible = False
                            cantied.ReadOnly = True
                            cantied2.Enabled = False
                            cantied2.Visible = False
                            cantied2.ReadOnly = True
                            Label13.Visible = False
                            nuevo.Focus()
                            nuevo.Select()
                            Actualizacion_Tabla()
                            Mostrar_Grilla()
                            Mostrar()
                        End If
                    End If
                Catch ex As Exception
                    DA9.SelectCommand = SC9
                    DA9.Fill(DT9)
                End Try
            End If
        End If
    End Sub
    Private Sub estad_TextChanged_1(sender As Object, e As EventArgs) Handles estad.TextChanged
        If (estad.Text = "Comprado") Then
            ErrorProvider1.SetError(estad, Nothing)
        ElseIf (estad.Text = "Prestado") Then
            ErrorProvider1.SetError(estad, Nothing)
        ElseIf (estad.Text = "") Then
            ErrorProvider1.SetError(estad, Nothing)
        Else
            ErrorProvider1.SetError(estad, "Error: Solo se Permite 'Comprado' y/o 'Prestado' Segun Corresponda")
        End If
        Dim i As Integer
        estad.Text = StrConv(estad.Text, VbStrConv.ProperCase)
        i = Len(estad.Text)
        estad.SelectionStart = i
    End Sub
    Private Sub Preciocompra_Tick(sender As Object, e As EventArgs) Handles Cantidades.Tick
        If Me.Grilla_Bodega.Rows.Count = 0 Then
            cantidaDESSSS.Text = "0"
        Else
            Vall1 = Vall1 + 1
            Dim suma2 As Integer = 0.0
            For Each row As DataGridViewRow In Grilla_Bodega.Rows
                suma2 += Val(row.Cells(4).Value)
            Next
            cantidaDESSSS.Text = Convert.ToInt64(suma2)
        End If
    End Sub
    Private Sub Grilla_Bodega_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Bodega.CellClick
        Mostrar()
    End Sub
    Private Sub rutees_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rutees.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            code.Focus()
            code.Select()
        End If
    End Sub
    Private Sub busqueda_rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda_rut.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
    End Sub
    Private Sub estad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles estad.KeyPress
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
    Private Sub num1_TextChanged(sender As Object, e As EventArgs) Handles num1.TextChanged
        Consulta9("select articulos.Codigo,articulos.Cantidad from articulos where Codigo = '" & (code.Text) & "'and Cantidad <'" & (num1.Text) & "' ")
        If DS9.Tables(DT9.TableName).Rows.Count = 0 Then
            num1.ForeColor = Color.Black
        Else
            num1.ForeColor = Color.Red
        End If
    End Sub
End Class