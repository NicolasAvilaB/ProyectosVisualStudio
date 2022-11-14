Imports Microsoft.Reporting.WinForms
Public Class Historial_Transacciones
    Dim fuente As New ReportDataSource
    Dim ita As Integer
    Dim ita2 As Integer
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' habilitar el flag  
            mover = True
            ' guardar las coordenadas  
            x = e.X
            y = e.Y
            ' cambiar el cursor del mouse  
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub
    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' habilitar el flag  
            mover = True
            ' guardar las coordenadas  
            x = e.X
            y = e.Y
            ' cambiar el cursor del mouse  
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub
    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sexo.SelectedIndex = -1
        inicio.Value = "01-01-2017"
        fin.Value = "31-12-2017"
        desdeedad.Text = "0"
        hastaedad.Text = "0"
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Sub Actualizacion_Tabla()
        Consulta4("Call MostrarGrillaHistorialTransacciones")
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Historial_Transacciones.DataSource = DS4.Tables(DT4.TableName)
        Conexion.Close()
    End Sub
    Sub Actualizacion_Tabla2()
        Consulta6("Call MostrarGrillaHistorialModificaciones")
    End Sub
    Sub Mostrar_Grilla2()
        Grilla_Historial_Modificaciones.DataSource = DS6.Tables(DT6.TableName)
        Conexion.Close()
    End Sub
    Private Sub vuo_Click(sender As Object, e As EventArgs) Handles vuo.Click
        Me.Close()
    End Sub
    Private Sub Filtro1_Click(sender As Object, e As EventArgs) Handles Filtro1.Click
        If sexo.Text = "No Especificar (Filtro Solo Fechas)" Or sexo.SelectedIndex = -1 Then
            Consulta4("Call FiltroFechas_Historial_Transaccion ('" & inicio.Value.ToString("yyyy-MM-dd") & "','" & fin.Value.ToString("yyyy-MM-dd") & "')")
            Grilla_Historial_Transacciones.DataSource = DS4.Tables(DT4.TableName)
        ElseIf desdeedad.Text = "0" And hastaedad.Text = "0"
            Consulta4("Call FiltroFechaGenero_Historial_Transaccion ('" & inicio.Value.ToString("yyyy-MM-dd") & "','" & fin.Value.ToString("yyyy-MM-dd") & "','" & (sexo.Text) & "')")
            Grilla_Historial_Transacciones.DataSource = DS4.Tables(DT4.TableName)
        Else
            Consulta4("Call FiltroFechaGeneroEdad_Historial_Transaccion ('" & inicio.Value.ToString("yyyy-MM-dd") & "','" & fin.Value.ToString("yyyy-MM-dd") & "','" & (sexo.Text) & "','" & (desdeedad.Text) & "','" & (hastaedad.Text) & "')")
            Grilla_Historial_Transacciones.DataSource = DS4.Tables(DT4.TableName)
        End If
    End Sub
    Private Sub Historial_Transacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Actualizacion_Tabla2()
        Mostrar_Grilla2()
        ita = 0
        SumaRegistros2.Enabled = True
        SumaRegistros2.Interval = 50
        ita2 = 0
        SumarRegistro3.Enabled = True
        SumarRegistro3.Interval = 50
    End Sub
    Private Sub Grilla_Transacciones_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Historial_Transacciones.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Grilla_Transacciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Historial_Transacciones.CellContentClick
        Grilla_Historial_Transacciones.ReadOnly = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Filtro2.Click
        If desdeedad.Text = "0" And hastaedad.Text = "0" Then
            Consulta4("Call FiltroFechas_Historial_Transaccion ('" & inicio.Value.ToString("yyyy-MM-dd") & "','" & fin.Value.ToString("yyyy-MM-dd") & "')")
            Grilla_Historial_Transacciones.DataSource = DS4.Tables(DT4.TableName)
        Else
            Consulta4("Call FiltroFechaEdad_Historial_Transaccion ('" & inicio.Value.ToString("yyyy-MM-dd") & "','" & fin.Value.ToString("yyyy-MM-dd") & "','" & (desdeedad.Text) & "','" & (hastaedad.Text) & "')")
            Grilla_Historial_Transacciones.DataSource = DS4.Tables(DT4.TableName)
        End If
    End Sub
    Private Sub SumaRegistros2_Tick(sender As Object, e As EventArgs) Handles SumaRegistros2.Tick
        If Me.Grilla_Historial_Transacciones.Rows.Count = 0 Then
            numero.Text = "0"
        Else
            ita = ita + 1
            Dim cantidad1 As Integer = 0.0
            For i = 1 To Grilla_Historial_Transacciones.Rows.Count
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
            Filtro1.Enabled = True
            sexo.Enabled = True
            Filtro2.Enabled = True
            desdeedad.Enabled = True
            hastaedad.Enabled = True
            desdeedad.ReadOnly = False
            hastaedad.ReadOnly = False
            Actualizacion_Tabla()
            Mostrar_Grilla()
        Else
            desdeedad.Text = "0"
            hastaedad.Text = "0"
            Filtro1.Enabled = False
            sexo.Enabled = False
            Filtro2.Enabled = False
            sexo.SelectedIndex = -1
            desdeedad.Enabled = False
            hastaedad.Enabled = False
            desdeedad.ReadOnly = True
            hastaedad.ReadOnly = True
            Consulta5("Call FiltroFechaNombre_Historial_Transacciones ('" & inicio.Value.ToString("yyyy-MM-dd") & "','" & fin.Value.ToString("yyyy-MM-dd") & "','" & (busqueda.Text & "%") & "')")
            Grilla_Historial_Transacciones.DataSource = DS5.Tables(DT5.TableName)
        End If
    End Sub
    Private Sub volver2_Click(sender As Object, e As EventArgs) Handles volver2.Click
        Me.Close()
    End Sub
    Private Sub Filtro3_Click(sender As Object, e As EventArgs) Handles Filtro3.Click
        If generito.Text = "No Especificar (Filtro Solo Fechas)" Or generito.SelectedIndex = -1 Then
            Consulta6("Call FiltroFechas_Historial_Modificaciones ('" & fechadesde2.Value.ToString("yyyy-MM-dd") & "','" & fechahasta2.Value.ToString("yyyy-MM-dd") & "')")
            Grilla_Historial_Modificaciones.DataSource = DS6.Tables(DT6.TableName)
        ElseIf desdeedad.Text = "0" And hastaedad.Text = "0"
            Consulta6("Call FiltroFechaGenero_Historial_Modificaciones ('" & fechadesde2.Value.ToString("yyyy-MM-dd") & "','" & fechahasta2.Value.ToString("yyyy-MM-dd") & "','" & (generito.Text) & "')")
            Grilla_Historial_Modificaciones.DataSource = DS6.Tables(DT6.TableName)
        Else
            Consulta6("Call FiltroFechaGeneroEdad_Historial_Modificaciones ('" & fechadesde2.Value.ToString("yyyy-MM-dd") & "','" & fechahasta2.Value.ToString("yyyy-MM-dd") & "','" & (generito.Text) & "','" & (edaddesde2.Text) & "','" & (edadhasta2.Text) & "')")
            Grilla_Historial_Modificaciones.DataSource = DS6.Tables(DT6.TableName)
        End If
    End Sub
    Private Sub Filtro4_Click(sender As Object, e As EventArgs) Handles Filtro4.Click
        If edaddesde2.Text = "0" And edadhasta2.Text = "0" Then
            Consulta6("Call FiltroFechas_Historial_Modificaciones ('" & fechadesde2.Value.ToString("yyyy-MM-dd") & "','" & fechahasta2.Value.ToString("yyyy-MM-dd") & "')")
            Grilla_Historial_Modificaciones.DataSource = DS6.Tables(DT6.TableName)
        Else
            Consulta6("Call FiltroFechaEdad_Historial_Modificaciones ('" & fechadesde2.Value.ToString("yyyy-MM-dd") & "','" & fechahasta2.Value.ToString("yyyy-MM-dd") & "','" & (edaddesde2.Text) & "','" & (edadhasta2.Text) & "')")
            Grilla_Historial_Modificaciones.DataSource = DS6.Tables(DT6.TableName)
        End If
    End Sub
    Private Sub busqueda2_TextChanged(sender As Object, e As EventArgs) Handles busqueda2.TextChanged
        Dim i As Integer
        busqueda2.Text = StrConv(busqueda2.Text, VbStrConv.ProperCase)
        i = Len(busqueda2.Text)
        busqueda2.SelectionStart = i
        If (busqueda2.Text = "") Then
            Filtro3.Enabled = True
            generito.Enabled = True
            Filtro4.Enabled = True
            edaddesde2.Enabled = True
            edadhasta2.Enabled = True
            edaddesde2.ReadOnly = False
            edadhasta2.ReadOnly = False
            Actualizacion_Tabla()
            Mostrar_Grilla()
        Else
            edaddesde2.Text = "0"
            edadhasta2.Text = "0"
            Filtro3.Enabled = False
            generito.Enabled = False
            Filtro4.Enabled = False
            generito.SelectedIndex = -1
            edaddesde2.Enabled = False
            edadhasta2.Enabled = False
            edaddesde2.ReadOnly = True
            edadhasta2.ReadOnly = True
            Consulta6("Call FiltroFechaNombre_Historial_Modificaciones ('" & fechadesde2.Value.ToString("yyyy-MM-dd") & "','" & fechahasta2.Value.ToString("yyyy-MM-dd") & "','" & (busqueda2.Text & "%") & "')")
            Grilla_Historial_Modificaciones.DataSource = DS6.Tables(DT6.TableName)
        End If
    End Sub
    Private Sub Grilla_Historial_Modificaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Historial_Modificaciones.CellContentClick
        Grilla_Historial_Transacciones.ReadOnly = True
    End Sub
    Private Sub Grilla_Historial_Modificaciones_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Historial_Modificaciones.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Historial_Transacciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        busqueda.Clear()
        busqueda2.Clear()
        generito.SelectedIndex = -1
        sexo.SelectedIndex = -1
        fechadesde2.Value = "01-01-2017"
        fechahasta2.Value = "31-12-2017"
        inicio.Value = "01-01-2017"
        fin.Value = "31-12-2017"
        desdeedad.Text = "0"
        hastaedad.Text = "0"
        edaddesde2.Text = "0"
        edadhasta2.Text = "0"
    End Sub
    Private Sub SumarRegistro3_Tick(sender As Object, e As EventArgs) Handles SumarRegistro3.Tick
        If Me.Grilla_Historial_Modificaciones.Rows.Count = 0 Then
            numero2.Text = "0"
        Else
            ita2 = ita2 + 1
            Dim cantidad1 As Integer = 0.0
            For i = 1 To Grilla_Historial_Modificaciones.Rows.Count
                cantidad1 = i
            Next
            numero2.Text = Convert.ToInt64(cantidad1)
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
    Private Sub busqueda2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busqueda2.KeyPress
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
    Private Sub imprimir_Click(sender As Object, e As EventArgs) Handles imprimir.Click
        Try
            Dim ds As New DsHistorial
            Dim dtw As DataRow
            For i As Integer = 0 To Grilla_Historial_Transacciones.Rows.Count - 1
                dtw = ds.DtHistorial.NewRow()
                dtw("ID") = Grilla_Historial_Transacciones.Item(0, i).Value
                dtw("Numero_Ficha") = Grilla_Historial_Transacciones.Item(1, i).Value
                dtw("Unidad_Vecinal") = Grilla_Historial_Transacciones.Item(2, i).Value ' formato de punto para datatable
                dtw("Juntas_Vecinos_Org_Comun") = Grilla_Historial_Transacciones.Item(3, i).Value
                dtw("Sector") = Grilla_Historial_Transacciones.Item(4, i).Value
                dtw("Direccion") = Grilla_Historial_Transacciones.Item(5, i).Value
                dtw("Familia") = Grilla_Historial_Transacciones.Item(6, i).Value ' formato de punto para datatable
                dtw("Nombre_Niño_a") = Grilla_Historial_Transacciones.Item(7, i).Value
                dtw("Rut") = Grilla_Historial_Transacciones.Item(8, i).Value
                dtw("Edad") = Grilla_Historial_Transacciones.Item(9, i).Value
                dtw("Sexo") = Grilla_Historial_Transacciones.Item(10, i).Value ' formato de punto para datatable
                dtw("Hora") = Grilla_Historial_Transacciones.Item(11, i).Value
                dtw("Fecha") = Grilla_Historial_Transacciones.Item(12, i).Value
                dtw("Estado") = Grilla_Historial_Transacciones.Item(13, i).Value
                dtw("Usuario") = Grilla_Historial_Transacciones.Item(14, i).Value
                dtw("EstadoUser") = Grilla_Historial_Transacciones.Item(15, i).Value
                ds.DtHistorial.Rows.Add(dtw)
            Next
            ''---------------------PREPARAR REPORTE--------------------
            fuente.Name = "DatosHistorial" ' Nombre identico al que le di al dataset del report en tiempo de diseño
            fuente.Value = ds.Tables(0)
            ''---------------------PREPARAR REPORTE------------------
        Catch ex As Exception
        End Try
        ImprimirHistorial.ReportViewer1.LocalReport.DataSources.Clear()
        ImprimirHistorial.ReportViewer1.LocalReport.DataSources.Add(fuente)
        ImprimirHistorial.ReportViewer1.LocalReport.ReportEmbeddedResource = "RegistroNiñosJuguetesNavidad.Report2.rdlc" 'exactamente como se llaman el proyecto y reporte
        ImprimirHistorial.Show()
    End Sub
End Class