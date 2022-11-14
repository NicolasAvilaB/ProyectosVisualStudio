Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Public Class Bodega_User
    Public VarSeleccion As Integer
    Dim Vall1 As Integer
    Dim orpt As New BoletaValidador
    Dim mifecha As Date = Format(Now, "dd/MM/yyyy")
    Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
    Dim Dato0, Dato1, Dato2, Dato3, Dato4, Dato5, Dato6 As String
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
            Dato6 = Grilla_Bodega.CurrentRow.Cells(8).EditedFormattedValue.ToString
            rutees.Text = Dato1
            depart.Text = Dato2
            code.Text = Dato3
            cantied.Text = Dato4
            estad.Text = Dato5
            Label9.Text = Dato6
        Else
            rutees.Clear()
            depart.Clear()
            code.Clear()
            cantied.Clear()
            estad.Clear()
            Label9.Text = Nothing
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
        cantied.Enabled = True
        estad.Enabled = True
        rutees.ReadOnly = False
        code.ReadOnly = False
        cantied.ReadOnly = False
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
            MsgBox("Error: No puedes digitar cantidad 0 o menor a esta ", vbCritical, "¡Error, Cantidad Incorrecta")
            cantied.Focus()
            cantied.Select()
            cantied.Clear()
        ElseIf cantied.ForeColor = Color.Red Then
            MsgBox("Error: La Cantidad " & cantied.Text & " del Codigo: " & code.Text & " Esta SobrePasada a la Actual Guardada en el Registro, Porfavor Verfique Bien la Cantidad del Articulo e Intentelo denuevo", vbCritical, "Error, Cantidad SobrePasada")
            cantied.Clear()
            cantied.Focus()
            cantied.Select()
        Else
            For Each row As DataGridViewRow In Grilla_Bodega.Rows
                Consulta("select * from pedidos_bodega where Rut = '" & (rutees.Text) & "' and Codigo = '" & (code.Text) & "' and Estado = 'Prestado'")
            Next
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                MsgBox("Ya Existe un Rut, al cual se le Realizo el Prestamo al Codigo Escrito", vbCritical, "Error de Codigo o Estado")
                rutees.Clear()
                estad.Clear()
                rutees.Focus()
                rutees.Select()
            ElseIf VarSeleccion = 1 Then
                If (estad.Text = "Comprado") Then
                    Try
                        Consulta("Call Resta_Cantidad ('" & (cantied.Text) & "','" & (code.Text) & "')")
                        Consulta("Call Inserto_Bodega ('" & (code.Text) & "','" & (rutees.Text) & "','" & (depart.Text) & "','" & (cantied.Text) & "','" & (Now.ToLongTimeString) & "','" & (mifecha2) & "','" & (estad.Text) & "','" & (Label9.Text) & "')")
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
                    TextBox1.Clear()
                    Dim rand As New Random
                    Dim letter As String
                    Dim x As Integer
                    Randomize()
                    For x = 1 To 20
                        TextBox1.Text = TextBox1.Text & (Int(Rnd() * 10))
                        letter = ChrW(rand.Next(65, 90))
                        TextBox1.Text = TextBox1.Text & letter
                    Next
                    If (TextBox1.Text = "'") Then
                        TextBox1.Focus()
                        TextBox1.Select()
                        SendKeys.Send("{BACKSPACE}")
                    End If
                    Try
                        Consulta("Call Resta_Cantidad ('" & (cantied.Text) & "','" & (code.Text) & "')")
                        Consulta("Call Inserto_Bodega ('" & (code.Text) & "','" & (rutees.Text) & "','" & (depart.Text) & "','" & (cantied.Text) & "','" & (Now.ToLongTimeString) & "','" & (mifecha2) & "','" & (estad.Text) & "','" & "0" & "')")
                        Consulta("Call Ingreso_Codigo ('" & (TextBox1.Text) & "','" & (code.Text) & "','" & (rutees.Text) & "')")
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
                    orpt.Load("Validador_Prestamo.rpt")
                    orpt.ParameterFields("Codigo_Articulo").CurrentValues.Clear()
                    orpt.SetParameterValue("Codigo_Articulo", code.Text)
                    orpt.ParameterFields("Codigo").CurrentValues.Clear()
                    orpt.SetParameterValue("Codigo", TextBox1.Text)
                    orpt.ParameterFields("Rut").CurrentValues.Clear()
                    orpt.SetParameterValue("Rut", rutees.Text)
                    orpt.PrintToPrinter(1, False, 0, 0)
                End If
                ElseIf VarSeleccion = 2 Then
                Try
                    Consulta("Call Modifica_Bodega ('" & (code.Text) & "','" & (rutees.Text) & "','" & (depart.Text) & "'," & (cantied.Text) & ",'" & (Label9.Text) & "','" & (Now.ToLongTimeString) & "','" & (mifecha2) & "','" & (estad.Text) & "','" & (Dato0) & "')")
                    MsgBox("Datos Modificados Exitosamente", vbInformation, "Datos Modificados")
                    rutees.Enabled = False
                    depart.Enabled = False
                    code.Enabled = False
                    cantied.Enabled = False
                    estad.Enabled = False
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
                    Grilla_Bodega.ReadOnly = False
                    cancelar.Enabled = False
                    devolucion_articulos.Enabled = True
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
        Actualizacion_Tabla()
        Mostrar_Grilla()
    End Sub
    Private Sub Bodega_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Grilla()
        Actualizacion_Tabla()
        Mostrar()
        Vall1 = 0
        Preciocompra.Enabled = True
        Preciocompra.Interval = 50
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        guardar.Enabled = False
        nuevo.Enabled = True
        eliminar.Enabled = True
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
        cantied.Enabled = False
        estad.Enabled = False
        Devolver_Articulo.Enabled = True
        depart.ReadOnly = True
        code.ReadOnly = True
        cantied.ReadOnly = True
        Mostrar()
        Mostrar_Grilla()
        Actualizacion_Tabla()
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
                Label7.Text = "Codigo Comprobado"
            ElseIf DS01.Tables(DT01.TableName).Rows.Count = 1 And estad.Text = "Comprado" Then
                Dim row As DataRow = DT01.Rows(0)
                Label9.Text = CStr(row("Precio"))
                Label7.Text = "Codigo Comprobado"
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
    End Sub
    Private Sub rutees_Click(sender As Object, e As EventArgs) Handles rutees.Click
        rutees.SelectionLength = rutees.Text.Length
    End Sub
    Private Sub busqueda_rut_Click(sender As Object, e As EventArgs) Handles busqueda_rut.Click
        busqueda_rut.SelectionLength = busqueda_rut.Text.Length
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
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
    Private Sub Preciocompra_Tick(sender As Object, e As EventArgs) Handles Preciocompra.Tick
        If Me.Grilla_Bodega.Rows.Count = 0 Then
            precc.Text = "$0"
            cantidaDESSSS.Text = "0"
        Else
            Vall1 = Vall1 + 1
            Dim suma As Integer = 0.0
            Dim suma2 As Integer = 0.0
            For Each row As DataGridViewRow In Grilla_Bodega.Rows
                suma += Val(row.Cells(8).Value)
                suma2 += Val(row.Cells(4).Value)
            Next
            precc.Text = "$ " & Convert.ToInt64(suma)
            cantidaDESSSS.Text = Convert.ToInt64(suma2)
        End If
    End Sub
    Private Sub estad_TextChanged(sender As Object, e As EventArgs) Handles estad.TextChanged
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
    Private Sub estad_KeyPress(sender As Object, e As KeyPressEventArgs)
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
            MsgBox("Error Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
    End Sub
End Class