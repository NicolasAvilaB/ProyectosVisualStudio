Imports Microsoft.Reporting.WinForms
Public Class RegistrosFichas
    Dim fuente As New ReportDataSource
    Dim ita As Integer
    Dim varseleccion As Integer = 0
    Dim rune As String
    Dim dato As String
    Dim Dato0, Dato1, Dato2, Dato3, Dato4, Dato5, Dato6, Dato7, Dato8, Dato9, Dato10, Dato11 As String
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Desea Cerrar tu Sesion Actual: " + InicioSesion.nombre.Text + " ?", vbYesNo + vbQuestion, "Consulta Cierre Sesion")
        If valormensaje = vbYes Then
            CierreSesion.descr.Focus()
            CierreSesion.descr.Select()
            CierreSesion.Owner = Me
            CierreSesion.ShowDialog()
        Else
            MsgBox("Cancelaste la Operacion", vbExclamation, "Operacion Cancelada")
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Desea Cerrar tu Sesion Actual: " + InicioSesion.nombre.Text + " ?", vbYesNo + vbQuestion, "Consulta Cierre Sesion")
        If valormensaje = vbYes Then
            CierreSesion.descr.Focus()
            CierreSesion.descr.Select()
            CierreSesion.Owner = Me
            CierreSesion.ShowDialog()
        Else
            MsgBox("Cancelaste la Operacion", vbExclamation, "Operacion Cancelada")
        End If
    End Sub
    Sub Actualizacion_Tabla()
        Consulta3("Call MostrarGrillaRegistrosFichas")
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Fichas.DataSource = DS3.Tables(DT3.TableName)
        Conexion.Close()
    End Sub
    Private Sub rut_TextChanged(sender As Object, e As EventArgs) Handles rut.TextChanged
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
            edad.Focus()
            edad.Select()
        End If
    End Sub
    Sub Mostrar()
        If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
            Dato0 = Grilla_Fichas.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato1 = Grilla_Fichas.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato2 = Grilla_Fichas.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato3 = Grilla_Fichas.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Dato4 = Grilla_Fichas.CurrentRow.Cells(4).EditedFormattedValue.ToString
            Dato5 = Grilla_Fichas.CurrentRow.Cells(5).EditedFormattedValue.ToString
            Dato6 = Grilla_Fichas.CurrentRow.Cells(6).EditedFormattedValue.ToString
            Dato7 = Grilla_Fichas.CurrentRow.Cells(7).EditedFormattedValue.ToString
            Dato8 = Grilla_Fichas.CurrentRow.Cells(8).EditedFormattedValue.ToString
            Dato9 = Grilla_Fichas.CurrentRow.Cells(9).EditedFormattedValue.ToString
            Dato10 = Grilla_Fichas.CurrentRow.Cells(10).EditedFormattedValue.ToString
            Dato11 = Grilla_Fichas.CurrentRow.Cells(11).EditedFormattedValue.ToString
            id.Text = Dato0
            numeroficha.Text = Dato1
            unidad.Text = Dato2
            juntas.Text = Dato3
            sector.Text = Dato4
            direccion.Text = Dato5
            familia.Text = Dato6
            nombre.Text = Dato7
            rut.Text = Dato8
            edad.Text = Dato9
            sexo.Text = Dato10
            listaestado.Text = Dato11
        Else
            id.Text = "0"
            numeroficha.Clear()
            unidad.Clear()
            juntas.Clear()
            sector.Clear()
            direccion.Clear()
            familia.Clear()
            nombre.Clear()
            rut.Clear()
            edad.Text = "0"
            sexo.SelectedIndex = -1
            listaestado.SelectedIndex = -1
        End If
        If Grilla_Fichas.CurrentRow.Cells(11).EditedFormattedValue.ToString = "" Then
            listaestado.SelectedIndex = -1
        End If
    End Sub
    Private Sub RegistrosFichas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
        ita = 0
        SumaRegistros.Enabled = True
        SumaRegistros.Interval = 50
        Try
            Consulta8("SELECT DISTINCT Juntas_Vecinos_Org_Comun FROM registrosfichas")
            filtrojuntas.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("registrosfichas")
            DA8.Fill(dt)
            With filtrojuntas
                .DataSource = dt
                .DisplayMember = "Juntas_Vecinos_Org_Comun"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        filtrojuntas.SelectedIndex = -1
    End Sub
    Private Sub Grilla_Fichas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Fichas.CellContentClick
        Grilla_Fichas.ReadOnly = True
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If Me.Grilla_Fichas.Rows.Count = 0 Then
            MsgBox("Error: No Existe Registros Asociados, Para Eliminar se Necesita Registros en la Base de Datos", vbCritical, "Error, Operación Incorrecta")
            nuevo.Focus()
            nuevo.Select()
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro El Siguiente Rut: " + rut.Text + " ?", vbYesNo + vbQuestion, "¿Eliminar Niño/a?")
            If valormensaje = vbYes Then
                Consulta3("Call Modifica_EstadoEliminado_Historial_Transaccion('" & "Eliminado" & "','" & (rut.Text) & "')")
                Consulta3("Call Eliminar_Registro_Rut ('" & (rut.Text) & "')")
                MsgBox("El Niño/a: '" + nombre.Text + "' Con el Rut: '" + rut.Text + "' Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                busqueda.Clear()
                nuevo.Focus()
                nuevo.Select()
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                nuevo.Focus()
                nuevo.Select()
            End If
            Actualizacion_Tabla()
            If DS3.Tables(DT3.TableName).Rows.Count > 0 Then
                Mostrar()
            Else
                id.Text = "0"
                numeroficha.Clear()
                unidad.Clear()
                juntas.Clear()
                sector.Clear()
                direccion.Clear()
                familia.Clear()
                nombre.Clear()
                rut.Clear()
                edad.Text = "0"
                sexo.SelectedIndex = -1
            End If
            Mostrar()
            Actualizacion_Tabla()
            Mostrar_Grilla()
            nuevo.Focus()
            nuevo.Select()
        End If
        nuevo.Focus()
        nuevo.Select()
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        busqueda.Clear()
        If (numeroficha.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Numero de Ficha", vbCritical, "¡Error, Campo Numero de Ficha Vacio!")
            numeroficha.Focus()
            numeroficha.Select()
        ElseIf (unidad.Text = "")
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Unidad", vbCritical, "¡Error, Campo Unidad Vacio!")
            unidad.Focus()
            unidad.Select()
        ElseIf (juntas.Text = "")
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Juntas de Vecinos u Org. Comunitaria", vbCritical, "¡Error, Campo Juntas de Vecinos u Org. Comunitaria Vacio!")
            juntas.Focus()
            juntas.Select()
        ElseIf (sector.Text = "")
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Sector", vbCritical, "¡Error, Campo Sector Vacio!")
            sector.Focus()
            sector.Select()
        ElseIf (direccion.Text = "")
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Direccion", vbCritical, "¡Error, Campo Direccion Vacio!")
            direccion.Focus()
            direccion.Select()
        ElseIf (familia.Text = "")
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Familia", vbCritical, "¡Error, Campo Familia Vacio!")
            familia.Focus()
            familia.Select()
        ElseIf (nombre.Text = "")
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Nombre", vbCritical, "¡Error, Campo Nombre Vacio!")
            nombre.Focus()
            nombre.Select()
        ElseIf Len(rut.Text) < 12 Then
            MsgBox("Error: Estructura de Rut No Valido", vbCritical, "Error, Rut Invalido")
            rut.Focus()
            rut.Select()
            rut.Clear()
        ElseIf (rut.Text = "") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Rut", vbCritical, "¡Error, Campo Rut Vacio!")
            rut.Focus()
            rut.Select()
        ElseIf (edad.Text = "" Or edad.Text = "0") Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Nombre", vbCritical, "¡Error, Campo Nombre Vacio!")
            edad.Focus()
            edad.Select()
        ElseIf (sexo.SelectedIndex = -1) Then
            MsgBox("Error: No Existe un Ingreso de Datos en la Lista Desplegable Sexo", vbCritical, "¡Error, Lista Sexo Vacia!")
            sexo.Focus()
            sexo.Select()
        Else
            If varseleccion = 1 Then
                Consulta7("select * from registrosfichas where Rut ='" & (rut.Text) & "'")
                If DS7.Tables(DT7.TableName).Rows.Count > 0 Then
                    MsgBox("Error: Ya existe El Rut: " + rut.Text + " En el Registro", vbCritical, "¡Error, Rut ya Existente!")
                    rut.Focus()
                    rut.Select()
                Else
                    Try
                        Dim mifecha1 As Date = Format(Now, "dd/MM/yyyy")
                        Dim mifecha2 As String = mifecha1.ToString("yyyy-MM-dd")
                        Consulta3("Call Ingreso_Registros_Fichas ('" & (id.Text) & "','" & (numeroficha.Text) & "','" & (unidad.Text) & "','" & (juntas.Text) & "','" & (sector.Text) & "','" & (direccion.Text) & "','" & (familia.Text) & "','" & (nombre.Text) & "','" & (rut.Text) & "','" & (edad.Text) & "','" & (sexo.Text) & "','" & (listaestado.Text) & "')")
                        Consulta3("Call Ingreso_Historial_Transacciones ('" & (id.Text) & "','" & (numeroficha.Text) & "','" & (unidad.Text) & "','" & (juntas.Text) & "','" & (sector.Text) & "','" & (direccion.Text) & "','" & (familia.Text) & "','" & (nombre.Text) & "','" & (rut.Text) & "','" & (edad.Text) & "','" & (sexo.Text) & "','" & (Now.ToLongTimeString) & "','" & (mifecha2) & "','" & "Registrado" & "','" & (Label2.Text) & "','" & (listaestado.Text) & "')")
                        MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                        numeroficha.Enabled = False
                        unidad.Enabled = False
                        juntas.Enabled = False
                        sector.Enabled = False
                        direccion.Enabled = False
                        familia.Enabled = False
                        nombre.Enabled = False
                        rut.Enabled = False
                        edad.Enabled = False
                        sexo.Enabled = False
                        listaestado.Enabled = False
                        numeroficha.ReadOnly = True
                        unidad.ReadOnly = True
                        juntas.ReadOnly = True
                        sector.ReadOnly = True
                        direccion.ReadOnly = True
                        familia.ReadOnly = True
                        nombre.ReadOnly = True
                        rut.ReadOnly = True
                        edad.ReadOnly = True
                        nuevo.Enabled = True
                        modificar.Enabled = True
                        eliminar.Enabled = True
                        guardar.Enabled = False
                        cancelar.Enabled = False
                        historial_transaccion.Enabled = True
                        Grilla_Fichas.Enabled = True
                        Grilla_Fichas.ReadOnly = True
                        busqueda.Enabled = True
                        busqueda.ReadOnly = False
                    Catch ex As Exception
                        DA.SelectCommand = SC
                        DA.Fill(DT)
                    End Try
                    Actualizacion_Tabla()
                    Mostrar_Grilla()
                    Mostrar()
                End If
            ElseIf varseleccion = 2 Then
                Dim a As Boolean = False
                For Each row As DataGridViewRow In Grilla_Fichas.Rows
                    rune = CStr(row.Cells(8).Value)
                    If (rut.Text = rune) Then
                        MsgBox("Error: Ya existe El Rut: " + rut.Text + " En el Registro", vbCritical, "¡Error, Rut ya Existente!")
                        rut.Focus()
                        a = True
                        rut.Select()
                        Exit For
                    End If
                Next
                If (a = True) Then
                ElseIf (a = False) Then
                    Dim mifecha3 As Date = Format(Now, "dd/MM/yyyy")
                    Dim mifecha4 As String = mifecha3.ToString("yyyy-MM-dd")
                    Consulta3("Call Modificar_Usuarios (" & (numeroficha.Text) & ",'" & (unidad.Text) & "','" & (juntas.Text) & "','" & (sector.Text) & "','" & (direccion.Text) & "','" & (familia.Text) & "','" & (nombre.Text) & "','" & (rut.Text) & "'," & (edad.Text) & ",'" & (sexo.Text) & "','" & (listaestado.Text) & "'," & (id.Text) & ")")
                    Consulta3("Call Ingreso_Historial_Modificaciones ('" & (id.Text) & "','" & (numeroficha.Text) & "','" & (unidad.Text) & "','" & (juntas.Text) & "','" & (sector.Text) & "','" & (direccion.Text) & "','" & (familia.Text) & "','" & (nombre.Text) & "','" & (rut.Text) & "','" & (edad.Text) & "','" & (sexo.Text) & "','" & (Now.ToLongTimeString) & "','" & (mifecha4) & "','" & "Modificado" & "','" & (Label2.Text) & "','" & (listaestado.Text) & "')")
                    MsgBox("Datos Modificados Exitosamente", vbInformation, "Modificacion de Datos Exitosa")
                    Actualizacion_Tabla()
                    Mostrar_Grilla()
                    numeroficha.Enabled = False
                    unidad.Enabled = False
                    juntas.Enabled = False
                    sector.Enabled = False
                    direccion.Enabled = False
                    familia.Enabled = False
                    nombre.Enabled = False
                    rut.Enabled = False
                    edad.Enabled = False
                    sexo.Enabled = False
                    listaestado.Enabled = False
                    numeroficha.ReadOnly = True
                    unidad.ReadOnly = True
                    juntas.ReadOnly = True
                    sector.ReadOnly = True
                    direccion.ReadOnly = True
                    familia.ReadOnly = True
                    nombre.ReadOnly = True
                    rut.ReadOnly = True
                    edad.ReadOnly = True
                    nuevo.Enabled = True
                    modificar.Enabled = True
                    eliminar.Enabled = True
                    guardar.Enabled = False
                    cancelar.Enabled = False
                    historial_transaccion.Enabled = True
                    Grilla_Fichas.Enabled = True
                    Grilla_Fichas.ReadOnly = True
                    busqueda.Enabled = True
                    busqueda.ReadOnly = False
                    Mostrar()
                End If
            End If
        End If
    End Sub
    Private Sub edad_ValueChanged(sender As Object, e As EventArgs) Handles edad.ValueChanged
        If edad.Text > 100 Then
            MsgBox("Error: Te has Sobrepasado la Edad Permitida", vbCritical, "Error, Edad Sobrexcedida")
            edad.Text = "0"
            edad.Focus()
            edad.Select()
        End If
    End Sub
    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged
        Dim i As Integer
        nombre.Text = StrConv(nombre.Text, VbStrConv.ProperCase)
        i = Len(nombre.Text)
        nombre.SelectionStart = i
    End Sub
    Private Sub familia_TextChanged(sender As Object, e As EventArgs) Handles familia.TextChanged
        Dim i As Integer
        familia.Text = StrConv(familia.Text, VbStrConv.ProperCase)
        i = Len(familia.Text)
        familia.SelectionStart = i
    End Sub
    Private Sub direccion_TextChanged(sender As Object, e As EventArgs) Handles direccion.TextChanged
        Dim i As Integer
        direccion.Text = StrConv(direccion.Text, VbStrConv.ProperCase)
        i = Len(direccion.Text)
        direccion.SelectionStart = i
    End Sub
    Private Sub sector_TextChanged(sender As Object, e As EventArgs) Handles sector.TextChanged
        Dim i As Integer
        sector.Text = StrConv(sector.Text, VbStrConv.ProperCase)
        i = Len(sector.Text)
        sector.SelectionStart = i
    End Sub
    Private Sub juntas_TextChanged(sender As Object, e As EventArgs) Handles juntas.TextChanged
        Dim i As Integer
        juntas.Text = StrConv(juntas.Text, VbStrConv.ProperCase)
        i = Len(juntas.Text)
        juntas.SelectionStart = i
    End Sub
    Private Sub unidad_TextChanged(sender As Object, e As EventArgs) Handles unidad.TextChanged
        Dim i As Integer
        unidad.Text = StrConv(unidad.Text, VbStrConv.ProperCase)
        i = Len(unidad.Text)
        unidad.SelectionStart = i
    End Sub
    Private Sub Grilla_Fichas_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Fichas.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub SumaRegistros_Tick(sender As Object, e As EventArgs) Handles SumaRegistros.Tick
        If Me.Grilla_Fichas.Rows.Count = 0 Then
            numero.Text = "0"
        Else
            ita = ita + 1
            Dim cantidad1 As Integer = 0.0
            For i = 1 To Grilla_Fichas.Rows.Count
                cantidad1 = i
            Next
            numero.Text = Convert.ToInt64(cantidad1)
        End If
    End Sub
    Private Sub busqueda_TextChanged(sender As Object, e As EventArgs) Handles busqueda.TextChanged
        Dim i As Integer
        busqueda.Text = StrConv(busqueda.Text, VbStrConv.ProperCase)
        i = Len(busqueda.Text)
        busqueda.SelectionStart = i
        If (busqueda.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
            modificar.Enabled = True
        Else
            Consulta3("Call Busqueda_NombreNiño_a_Familia('" & (busqueda.Text & "%") & "')")
            If DS3.Tables(DT3.TableName).Rows.Count > 0 Then
                Grilla_Fichas.DataSource = DS3.Tables(DT3.TableName)
                Mostrar()
                modificar.Enabled = False
            Else
                modificar.Enabled = False
                id.Text = "0"
                numeroficha.Clear()
                unidad.Clear()
                juntas.Clear()
                sector.Clear()
                direccion.Clear()
                familia.Clear()
                nombre.Clear()
                rut.Clear()
                edad.Text = "0"
                sexo.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        Consulta3("Call GeneradorIDautomaticoRegistrosFichas")
        If TypeOf (DS3.Tables(DT3.TableName).Rows(0).Item("ID")) Is DBNull Then
            id.Text = 1
        Else
            id.Text = DS3.Tables(DT3.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
        varseleccion = 1
        numeroficha.Enabled = True
        unidad.Enabled = True
        juntas.Enabled = True
        sector.Enabled = True
        direccion.Enabled = True
        familia.Enabled = True
        nombre.Enabled = True
        rut.Enabled = True
        edad.Enabled = True
        sexo.Enabled = True
        listaestado.Enabled = True
        numeroficha.ReadOnly = False
        unidad.ReadOnly = False
        juntas.ReadOnly = False
        sector.ReadOnly = False
        direccion.ReadOnly = False
        familia.ReadOnly = False
        nombre.ReadOnly = False
        rut.ReadOnly = False
        edad.ReadOnly = False
        nuevo.Enabled = False
        modificar.Enabled = False
        eliminar.Enabled = False
        guardar.Enabled = True
        cancelar.Enabled = True
        historial_transaccion.Enabled = False
        Grilla_Fichas.Enabled = False
        Grilla_Fichas.ReadOnly = True
        busqueda.Enabled = False
        busqueda.ReadOnly = True
        busqueda.Clear()
        numeroficha.Clear()
        unidad.Clear()
        juntas.Clear()
        sector.Clear()
        direccion.Clear()
        familia.Clear()
        nombre.Clear()
        rut.Clear()
        edad.Text = "0"
        sexo.SelectedIndex = -1
    End Sub
    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        If Me.Grilla_Fichas.Rows.Count = 0 Then
            MsgBox("Error: No hay Registros Asociados a Modificar", vbCritical, "Error, No hay Registros")
            nuevo.Focus()
            nuevo.Select()
        Else
            varseleccion = 2
            numeroficha.Enabled = True
            unidad.Enabled = True
            juntas.Enabled = True
            sector.Enabled = True
            direccion.Enabled = True
            familia.Enabled = True
            nombre.Enabled = True
            rut.Enabled = True
            edad.Enabled = True
            sexo.Enabled = True
            listaestado.Enabled = True
            numeroficha.ReadOnly = False
            unidad.ReadOnly = False
            juntas.ReadOnly = False
            sector.ReadOnly = False
            direccion.ReadOnly = False
            familia.ReadOnly = False
            nombre.ReadOnly = False
            rut.ReadOnly = False
            edad.ReadOnly = False
            nuevo.Enabled = False
            modificar.Enabled = False
            eliminar.Enabled = False
            guardar.Enabled = True
            cancelar.Enabled = True
            historial_transaccion.Enabled = False
            Grilla_Fichas.Enabled = False
            Grilla_Fichas.ReadOnly = True
            busqueda.Enabled = False
            busqueda.ReadOnly = True
            busqueda.Clear()
            Grilla_Fichas.Rows.RemoveAt(Grilla_Fichas.CurrentRow.Index)
        End If
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        numeroficha.Enabled = False
        unidad.Enabled = False
        juntas.Enabled = False
        sector.Enabled = False
        direccion.Enabled = False
        familia.Enabled = False
        nombre.Enabled = False
        rut.Enabled = False
        edad.Enabled = False
        sexo.Enabled = False
        listaestado.Enabled = False
        numeroficha.ReadOnly = True
        unidad.ReadOnly = True
        juntas.ReadOnly = True
        sector.ReadOnly = True
        direccion.ReadOnly = True
        familia.ReadOnly = True
        nombre.ReadOnly = True
        rut.ReadOnly = True
        edad.ReadOnly = True
        nuevo.Enabled = True
        modificar.Enabled = True
        eliminar.Enabled = True
        guardar.Enabled = False
        cancelar.Enabled = False
        historial_transaccion.Enabled = True
        Grilla_Fichas.Enabled = True
        Grilla_Fichas.ReadOnly = True
        busqueda.Enabled = True
        busqueda.ReadOnly = False
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
    End Sub
    Private Sub Grilla_Fichas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Fichas.CellClick
        Mostrar()
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
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub rut_KeyDown(sender As Object, e As KeyEventArgs) Handles rut.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub listaestado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaestado.SelectedIndexChanged
        If (listaestado.Text = "---Vacio---") Then
            listaestado.SelectedIndex = -1
        End If
    End Sub
    Private Sub imprimir_Click_1(sender As Object, e As EventArgs) Handles imprimir.Click
        Try
            Dim ds As New DsFichas
            Dim dtw As DataRow
            For i As Integer = 0 To Grilla_Fichas.Rows.Count - 1
                dtw = ds.DtFichas.NewRow()
                dtw("ID") = Grilla_Fichas.Item(0, i).Value
                dtw("Numero_Ficha") = Grilla_Fichas.Item(1, i).Value
                dtw("Unidad_Vecinal") = Grilla_Fichas.Item(2, i).Value ' formato de punto para datatable
                dtw("Juntas_Vecinos_Org_Comun") = Grilla_Fichas.Item(3, i).Value
                dtw("Sector") = Grilla_Fichas.Item(4, i).Value
                dtw("Direccion") = Grilla_Fichas.Item(5, i).Value
                dtw("Familia") = Grilla_Fichas.Item(6, i).Value ' formato de punto para datatable
                dtw("Ninoa") = Grilla_Fichas.Item(7, i).Value
                dtw("Rut") = Grilla_Fichas.Item(8, i).Value
                dtw("Edad") = Grilla_Fichas.Item(9, i).Value
                dtw("Sexo") = Grilla_Fichas.Item(10, i).Value ' formato de punto para datatable
                dtw("Estado") = Grilla_Fichas.Item(11, i).Value
                ds.DtFichas.Rows.Add(dtw)
            Next
            ''---------------------PREPARAR REPORTE--------------------
            fuente.Name = "DatosFichas" ' Nombre identico al que le di al dataset del report en tiempo de diseño
            fuente.Value = ds.Tables(0)
            ''---------------------PREPARAR REPORTE------------------
        Catch ex As Exception
        End Try
        ImprimirFichas.ReportViewer1.LocalReport.DataSources.Clear()
        ImprimirFichas.ReportViewer1.LocalReport.DataSources.Add(fuente)
        ImprimirFichas.ReportViewer1.LocalReport.ReportEmbeddedResource = "RegistroNiñosJuguetesNavidad.Report1.rdlc" 'exactamente como se llaman el proyecto y reporte
        ImprimirFichas.Show()
    End Sub
    Private Sub filtrojuntas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtrojuntas.SelectedIndexChanged
        If (filtrojuntas.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
            modificar.Enabled = True
        ElseIf (filtrojuntas.Text = "--- SIN FILTRO ---")
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
            modificar.Enabled = True
            filtrojuntas.SelectedIndex = -1
        Else
            Consulta3("Call FiltroJuntasLista('" & (filtrojuntas.Text) & "')")
            If DS3.Tables(DT3.TableName).Rows.Count > 0 Then
                Grilla_Fichas.DataSource = DS3.Tables(DT3.TableName)
                Mostrar()
                modificar.Enabled = False
            Else
                modificar.Enabled = False
                id.Text = "0"
                numeroficha.Clear()
                unidad.Clear()
                juntas.Clear()
                sector.Clear()
                direccion.Clear()
                familia.Clear()
                nombre.Clear()
                rut.Clear()
                edad.Text = "0"
                sexo.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
        modificar.Enabled = True
        filtrojuntas.SelectedIndex = -1
    End Sub
    Private Sub historial_transaccion_Click(sender As Object, e As EventArgs) Handles historial_transaccion.Click
        Historial_Transacciones.Owner = Me
        Historial_Transacciones.ShowDialog()
    End Sub
    Private Sub rut_Click(sender As Object, e As EventArgs) Handles rut.Click
        rut.SelectionLength = rut.Text.Length
    End Sub
    Private Sub numeroficha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numeroficha.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub familia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles familia.KeyPress
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
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
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
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub edad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub busqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda.KeyPress
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
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub sector_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sector.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub juntas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles juntas.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub unidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles unidad.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles direccion.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
End Class