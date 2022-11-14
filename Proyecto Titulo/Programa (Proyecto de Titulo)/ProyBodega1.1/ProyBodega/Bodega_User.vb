Public Class Bodega_User
    Public VarSeleccion As Integer
    Dim Vall1 As Integer
    Dim ita As Integer
    Dim mifecha As Date = Format(Now, "dd/MM/yyyy")
    Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
    Dim Dato0, Dato1, Dato2, Dato3, Dato4, Dato5, Dato6, Dato7 As String
    Dim dat1, dat2, dat3, dat4, dat5, dat6, dat7 As String
    Dim run As String
    Dim run2 As String
    Dim cddd As String
    Dim estado1 As String
    Dim i As Integer
    Dim i2 As Integer
    Sub Actualizacion_Tabla()
        Consulta("Call GrillaVi")
    End Sub
    Sub Mostrar()
        If (DS.Tables(DT.TableName).Rows.Count > 0) Then
            Dato0 = Grilla_Bodega.CurrentRow.Cells(0).EditedFormattedValue.ToString
            dat1 = Grilla_Bodega.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Dato1 = Grilla_Bodega.CurrentRow.Cells(4).EditedFormattedValue.ToString
            Dato7 = Grilla_Bodega.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato2 = Grilla_Bodega.CurrentRow.Cells(5).EditedFormattedValue.ToString
            Dato3 = Grilla_Bodega.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato4 = Grilla_Bodega.CurrentRow.Cells(6).EditedFormattedValue.ToString
            Dato5 = Grilla_Bodega.CurrentRow.Cells(10).EditedFormattedValue.ToString
            nomb.Text = Dato1
            ruteeees.Text = dat1
            code.Text = Dato7
            depart.Text = Dato2
            Label7.Text = Dato3
            cantied.Text = Dato4
            descr.Text = Dato5
            If (Label7.Text = "") Then
                code.Text = Nothing
                cantied.Enabled = False
                cantied.ReadOnly = True
            Else
                Consulta06("Call Codigo_Multiuso ('" & (Label7.Text) & "')")
                If DS06.Tables(DT06.TableName).Rows.Count = 1 Then
                    Dim row As DataRow = DT06.Rows(0)
                    code.Text = CStr(row("Nombre"))
                    cantied.Enabled = False
                    cantied.ReadOnly = True
                Else
                    code.Text = Nothing
                    cantied.Enabled = False
                    cantied.ReadOnly = True
                End If
            End If
        Else
            nomb.Clear()
            depart.Clear()
            code.Clear()
            cantied.Clear()
            descr.Clear()
            Label7.Text = ""
            ruteeees.Text = ""
        End If
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Bodega.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        modet.Enabled = False
        busqueda_nombr.Clear()
        VarSeleccion = 1
        nomb.Enabled = True
        code.Enabled = True
        orig.Enabled = True
        descr.Enabled = True
        nomb.ReadOnly = False
        code.ReadOnly = False
        devolucion_articulos.Enabled = False
        guardar.Enabled = True
        busqueda_nombr.Enabled = False
        busqueda_nombr.ReadOnly = True
        busqueda_nombr.Clear()
        guardar.Enabled = True
        nuevo.Enabled = False
        Grilla_Bodega.Enabled = False
        Grilla_Bodega.ReadOnly = True
        nomb.Clear()
        depart.Clear()
        code.Clear()
        descr.ReadOnly = False
        eliminar.Enabled = False
        Label7.Text = ""
        cantied.Clear()
        descr.Clear()
        nomb.Focus()
        nomb.Select()
        cancelar.Enabled = True
        Consulta("Call GeneradorIDautomatico6")
        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("Id")) Is DBNull Then
            i = 1
        Else
            i = DS.Tables(DT.TableName).Rows(0).Item("Id") + 1
            Conexion.Close()
        End If
        Consulta08("Call GeneradorIDautomatico8")
        If TypeOf (DS08.Tables(DT08.TableName).Rows(0).Item("ID")) Is DBNull Then
            i2 = 1
        Else
            i2 = DS08.Tables(DT08.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
        SendKeys.Send("{BACKSPACE}")
        nuevo.Focus()
        nuevo.Select()
        If (cantied.Text = "") Then
            ErrorProvider1.SetError(cantied, Nothing)
        End If
    End Sub
    Private Sub busqueda_rut_TextChanged(sender As Object, e As EventArgs) Handles busqueda_nombr.TextChanged
        Dim i As Integer
        busqueda_nombr.Text = StrConv(busqueda_nombr.Text, VbStrConv.ProperCase)
        i = Len(busqueda_nombr.Text)
        busqueda_nombr.SelectionStart = i
        If (busqueda_nombr.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
        Else
            Consulta("Call Buscar_Nomb('" & (busqueda_nombr.Text & "%") & "')")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Grilla_Bodega.DataSource = DS.Tables(DT.TableName)
                Mostrar()
            Else
                nomb.Clear()
                depart.Clear()
                cantied.Clear()
                code.Clear()
                descr.Clear()
                Label7.Text = ""
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Secciones1.Show()
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        busqueda_nombr.Clear()
        If (nomb.Text = "") Then
            MsgBox("Error: No se ha Describido un Rut Valido", vbCritical, "¡Error, Rut no Descrito!")
            nomb.Focus()
            nomb.Select()
            nomb.Clear()
        ElseIf (depart.Text = "") Then
            MsgBox("Error: No se ha Describido un Departamento Valido, o El Formato del Rut No es El Correcto", vbCritical, "¡Error de Departamento!")
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
        ElseIf (descr.Text = "")
            MsgBox("Error: No existe una Descripcion Clara Hacia al Producto", vbCritical, "¡Error, Descripcion no Especificada!")
            descr.Focus()
            descr.Select()
            descr.Clear()
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
            descr.Clear()
        Else
            If VarSeleccion = 1 Then
                Dim mifecha3 As Date = Format(Now, "dd/MM/yyyy")
                Dim mifecha4 As String = mifecha3.ToString("yyyy-MM-dd")
                Try
                    Consulta("Call Resta_Cantidad ('" & (cantied.Text) & "','" & (Label7.Text) & "')")
                    Consulta("Call Inserto_Bodega ('" & (i) & "','" & (Label7.Text) & "','" & (code.Text) & "','" & (ruteeees.Text) & "','" & (nomb.Text) & "','" & (depart.Text) & "','" & (cantied.Text) & "','" & (Now.ToLongTimeString) & "','" & (mifecha2) & "','" & (orig.Text) & "','" & (descr.Text) & "')")
                    Consulta("Call Inserto_Salida('" & (i2) & "','" & (Label7.Text) & "','" & (code.Text) & "','" & (ruteeees.Text) & "','" & (nomb.Text) & "','" & (depart.Text) & "','" & (cantied.Text) & "','" & (Now.ToLongTimeString) & "','" & (mifecha4) & "','" & (orig.Text) & "','" & (descr.Text) & "')")
                    MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                    nomb.Enabled = False
                    depart.Enabled = False
                    code.Enabled = False
                    cantied.Enabled = False
                    orig.Enabled = False
                    descr.Enabled = False
                    depart.ReadOnly = True
                    code.ReadOnly = True
                    descr.ReadOnly = True
                    cantied.ReadOnly = True
                    devolucion_articulos.Enabled = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    busqueda_nombr.Enabled = True
                    busqueda_nombr.ReadOnly = False
                    Grilla_Bodega.Enabled = True
                    Grilla_Bodega.ReadOnly = True
                    cancelar.Enabled = False
                    nomb.Enabled = False
                    modet.Enabled = True
                    depart.Enabled = False
                    eliminar.Enabled = True
                    code.Enabled = False
                    cantied.Enabled = False
                    orig.Enabled = False
                    descr.Enabled = False
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
        ita = 0
        Items.Enabled = True
        Items.Interval = 50
        Cantidades.Enabled = True
        Cantidades.Interval = 50
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Me.Refresh()
        busqueda_nombr.Clear()
        Me.Refresh()
        guardar.Enabled = False
        eliminar.Enabled = True
        nuevo.Enabled = True
        busqueda_nombr.Enabled = True
        modet.Enabled = True
        descr.ReadOnly = True
        busqueda_nombr.ReadOnly = False
        Grilla_Bodega.Enabled = True
        Grilla_Bodega.ReadOnly = False
        cancelar.Enabled = False
        nomb.Enabled = False
        depart.Enabled = False
        code.Enabled = False
        cantied.Enabled = False
        orig.Enabled = False
        descr.Enabled = False
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
            nomb.Clear()
            code.Clear()
            cantied.Clear()
            descr.Clear()
        End If
    End Sub
    Private Sub rutees_TextChanged(sender As Object, e As EventArgs) Handles nomb.TextChanged
        Dim i As Integer
        nomb.Text = StrConv(nomb.Text, VbStrConv.ProperCase)
        i = Len(nomb.Text)
        nomb.SelectionStart = i
        If (nomb.Text = "") Then
            ruteeees.Text = Nothing
            depart.Text = Nothing
        Else
            Consulta01("Call Despliegue_Desdenombre('" & (nomb.Text) & "')")
            If DS01.Tables(DT01.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT01.Rows(0)
                ruteeees.Text = CStr(row("Rut"))
                depart.Text = CStr(row("Departamento"))
            Else
                ruteeees.Text = Nothing
                depart.Text = Nothing
            End If
        End If
    End Sub
    Private Sub Grilla_Bodega_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Bodega.CellContentClick
        Grilla_Bodega.ReadOnly = True
    End Sub
    Private Sub code_TextChanged_1(sender As Object, e As EventArgs) Handles code.TextChanged
        Dim i As Integer
        code.Text = StrConv(code.Text, VbStrConv.ProperCase)
        i = Len(code.Text)
        code.SelectionStart = i
        If (code.Text = "") Then
            Label7.Text = Nothing
        Else
            Consulta01("Call Nombre_Buscar ('" & (code.Text) & "')")
            If DS01.Tables(DT01.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT01.Rows(0)
                Label7.Text = CStr(row("Codigo"))
            Else
                Label7.Text = "Codigo no Existente"
            End If
        End If
        If (Label7.Text = "Codigo no Existente" Or code.Text = "") Then
            cantied.Enabled = False
            cantied.ReadOnly = True
        Else
            cantied.Enabled = True
            cantied.ReadOnly = False
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If Me.Grilla_Bodega.Rows.Count = 0 Then
            MsgBox("Error: No Podras Eliminar Ya Que No Existe Datos Ingresado en la Grilla", vbCritical, "Error, No existen Datos en la Grilla")
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro El Siguiente Usuario: " + nomb.Text + " ?", vbYesNo + vbQuestion, "¿Eliminar Usuario?")
            If valormensaje = vbYes Then
                Dato0 = Grilla_Bodega.CurrentRow.Cells(0).EditedFormattedValue.ToString
                Consulta("Call Eliminar_Usuario_Bodega ('" & (nomb.Text) & "','" & (Dato0) & "')")
                MsgBox("El Usuario: " + nomb.Text + " Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                busqueda_nombr.Clear()
                nuevo.Focus()
                nuevo.Select()
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                nuevo.Focus()
                nuevo.Select()
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
            End If
        End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
    End Sub
    Private Sub cantied_TextChanged(sender As Object, e As EventArgs) Handles cantied.TextChanged
        If cantied.Text = "" Then
            Consulta01("Call Verifica_Cantidad('" & (Label7.Text) & "','" & "0" & "')")
        Else
            Consulta01("Call Verifica_Cantidad('" & (Label7.Text) & "','" & (cantied.Text) & "')")
            If DS01.Tables(DT01.TableName).Rows.Count = 0 Then
                cantied.ForeColor = Color.Black
            Else
                cantied.ForeColor = Color.Red
            End If
        End If
        If (cantied.Text = "0") Then
            SendKeys.Send("{BACKSPACE}")
        End If
        If (cantied.ForeColor = Color.Red) Then
            ErrorProvider1.SetError(cantied, "Error: Cantidad Sobrepasada a la Actual, El Articulo se quedo sin Stock y/o se esta quedando sin stock")
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
    Private Sub modet_Click(sender As Object, e As EventArgs) Handles modet.Click
        Me.Close()
        Bodega_User_Modo_Detallado.Show()
    End Sub
    Private Sub descr_TextChanged(sender As Object, e As EventArgs) Handles descr.TextChanged
        Dim i As Integer
        descr.Text = StrConv(descr.Text, VbStrConv.ProperCase)
        i = Len(descr.Text)
        descr.SelectionStart = i
    End Sub
    Private Sub Grilla_Bodega_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Bodega.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles devolucion_articulos.Click
        busqueda_nombr.Clear()
        Historial_Bodega.Owner = Me
        Historial_Bodega.ShowDialog()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Secciones1.Show()
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
            orig.Focus()
            orig.Select()
        End If
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
    Private Sub Preciocompra_Tick(sender As Object, e As EventArgs) Handles Cantidades.Tick
        If Me.Grilla_Bodega.Rows.Count = 0 Then
            cantidaDESSSS.Text = "0"
        Else
            Vall1 = Vall1 + 1
            Dim suma2 As Integer = 0.0
            For Each row As DataGridViewRow In Grilla_Bodega.Rows
                suma2 += Val(row.Cells(5).Value)
            Next
            cantidaDESSSS.Text = Convert.ToInt64(suma2)
        End If
    End Sub
    Private Sub Grilla_Bodega_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Bodega.CellClick
        Mostrar()
    End Sub
    Private Sub rutees_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nomb.KeyPress
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
            code.Focus()
            code.Select()
        End If
    End Sub
    Private Sub code_KeyPress(sender As Object, e As KeyPressEventArgs) Handles code.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub busqueda_nombr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda_nombr.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
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
    Private Sub descr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles descr.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
End Class