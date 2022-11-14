Imports Microsoft.Reporting.WinForms
Public Class Cotizador
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Dim va As Integer = 0
    Dim va2 As Integer = 0
    Public ass As String
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
    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
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
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.White
        cerrar.ForeColor = Color.FromArgb(98, 117, 127)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(98, 117, 127)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.White
        minimizar.ForeColor = Color.FromArgb(98, 117, 127)
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(98, 117, 127)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub filtrar_MouseMove(sender As Object, e As MouseEventArgs) Handles filtrar.MouseMove
        filtrar.BackColor = Color.FromArgb(0, 105, 120)
        filtrar.ForeColor = Color.White
    End Sub
    Private Sub filtrar_MouseLeave(sender As Object, e As EventArgs) Handles filtrar.MouseLeave
        filtrar.BackColor = Color.White
        filtrar.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub eliminar_MouseMove(sender As Object, e As MouseEventArgs) Handles eliminar.MouseMove
        eliminar.BackColor = Color.FromArgb(0, 105, 120)
        eliminar.ForeColor = Color.White
    End Sub
    Private Sub eliminar_MouseLeave(sender As Object, e As EventArgs) Handles eliminar.MouseLeave
        eliminar.BackColor = Color.White
        eliminar.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub agregar_MouseMove(sender As Object, e As MouseEventArgs) Handles agregar.MouseMove
        agregar.BackColor = Color.FromArgb(0, 105, 120)
        agregar.ForeColor = Color.White
    End Sub
    Private Sub agregar_MouseLeave(sender As Object, e As EventArgs) Handles agregar.MouseLeave
        agregar.BackColor = Color.White
        agregar.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub Tabla_Nota_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_Nota.CellClick
        If (Tabla_Nota.CurrentRow.Cells(9).EditedFormattedValue.ToString() = "") Then
            desglose.Text = "..."
        Else
            desglose.Text = Letras(Tabla_Nota.CurrentRow.Cells(9).EditedFormattedValue.ToString())
        End If
    End Sub
    Private Sub Tabla_Nota_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_Nota.CellEnter
        If (Tabla_Nota.CurrentRow.Cells(9).EditedFormattedValue.ToString() = "") Then
            desglose.Text = "..."
        Else
            desglose.Text = Letras(Tabla_Nota.CurrentRow.Cells(9).EditedFormattedValue.ToString())
        End If
    End Sub
    Private Sub Tabla_Nota_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Tabla_Nota.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Cotizador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 10
        Cargar.Close()
        crear_16_filas()
    End Sub
    Sub crear_16_filas()
        For i = 0 To 15
            Tabla_Nota.Rows.Add("", "1", "", "", "", "", "", "")
        Next
    End Sub
    Private Sub Tabla_Nota_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tabla_Nota.DataError
        Try
            For Each row As DataGridViewRow In Tabla_Nota.Rows
                If (row.Cells(0).Value = "") Then
                    fc.DisplayIndex = -1
                End If
                If (row.Cells(4).Value = "") Then
                    lama.DisplayIndex = -1
                End If
                If (row.Cells(5).Value = "") Then
                    colores.DisplayIndex = -1
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Sub cantidad_x_precio()
        Dim row As DataGridViewRow = Tabla_Nota.CurrentRow()
        Try
            Dim a As Long = Convert.ToInt64(Tabla_Nota.CurrentRow.Cells(1).EditedFormattedValue.ToString())
            Dim b As Long = Convert.ToInt64(Tabla_Nota.CurrentRow.Cells(8).EditedFormattedValue.ToString())
            Dim su As Long = a * b
            row.Cells(9).Value = su
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Tabla_Nota_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_Nota.CellEndEdit

    End Sub
    Sub verifica_valor_nada_columna_numero()
        For Each row As DataGridViewRow In Tabla_Nota.Rows
            If (row.Cells(1).Value = "") Then
                row.Cells(1).Value = "1"
            Else
            End If
        Next
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If Tabla_Nota.Rows.Count = 0 Then
            Advertencia.texto.Text = "No hay cotizaciones agregadas a la tabla"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
        Else
            Try
                Dim loFila As DataGridViewRow = Tabla_Nota.CurrentRow()
                Tabla_Nota.Rows.Remove(loFila)
                'Tabla_Nota.Rows.Add("F", "1", "", "", "", "", "", "")
            Catch ex As Exception
                Advertencia.texto.Text = "Para eliminar una cotización primero debes seleccionarla"
                Advertencia.Owner = Me
                Advertencia.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub Tabla_Nota_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tabla_Nota.EditingControlShowing
        Dim columna As Integer = Tabla_Nota.CurrentCell.ColumnIndex
        If (columna = 1) Then
            Dim validar As TextBox = CType(e.Control, TextBox)
            AddHandler validar.KeyPress, AddressOf valida_dato_celda1_KeyPress
        ElseIf (columna = 2) Then
            Dim validar As TextBox = CType(e.Control, TextBox)
            AddHandler validar.KeyPress, AddressOf valida_dato_celda2_KeyPress
        ElseIf (columna = 3)
            Dim validar2 As TextBox = CType(e.Control, TextBox)
            AddHandler validar2.KeyPress, AddressOf valida_dato_celda3_KeyPress
        End If 'Validacion solo numeros keypress celda datagridview
    End Sub

    Private Sub valida_dato_celda1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim columna As Integer = Tabla_Nota.CurrentCell.ColumnIndex
        If (columna = 1) Then
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If 'Validacion solo numeros keypress celda datagridview
        End If
    End Sub
    Private Sub valida_dato_celda2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim columna As Integer = Tabla_Nota.CurrentCell.ColumnIndex
        If (columna = 2) Then
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Len(Tabla_Nota.CurrentRow.Cells(1).EditedFormattedValue.ToString()) = 1 And InStr(1, "." & Chr(46), e.KeyChar) = 1 Or Len(Tabla_Nota.CurrentRow.Cells(1).EditedFormattedValue.ToString()) = 1 And InStr(1, ":" & Chr(46), e.KeyChar) = 1 Then
                e.KeyChar = "."
            Else
                e.Handled = True
            End If 'Validacion solo numeros keypress celda datagridview
        End If
    End Sub
    Private Sub valida_dato_celda3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim columna As Integer = Tabla_Nota.CurrentCell.ColumnIndex
        If (columna = 3) Then
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Len(Tabla_Nota.CurrentRow.Cells(2).EditedFormattedValue.ToString()) = 1 And InStr(1, "." & Chr(46), e.KeyChar) = 1 Or Len(Tabla_Nota.CurrentRow.Cells(2).EditedFormattedValue.ToString()) = 1 And InStr(1, ":" & Chr(46), e.KeyChar) = 1 Then
                e.KeyChar = "."
            Else
                e.Handled = True
            End If 'Validacion solo numeros keypress celda datagridview
        End If
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Menus.Show()
        Close()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Sub sacar_informe()
        Comprobante_Creacion_Informe.Show()
        Dim fuente As New ReportDataSource
        Dim parametros As ReportParameter() = New ReportParameter(0) {}
        parametros(0) = New ReportParameter("subtotales", totaL.Text)
        Try
            Dim ds As New DsPrecios
            Dim dtw As DataRow
            For i As Integer = 0 To Tabla_Nota.Rows.Count - 1
                dtw = ds.Tabla_Co.NewRow()
                'Dim a As String = Tabla_Nota.Item(0, i).Value
                'Dim b As String = Tabla_Nota.Item(1, i).Value
                'Dim c As Integer = Tabla_Nota.Item(2, i).Value
                'Dim d As Integer = Tabla_Nota.Item(3, i).Value
                'Dim e As String = Tabla_Nota.Item(4, i).Value
                'Dim f As String = Tabla_Nota.Item(5, i).Value
                'Dim g As String =
                'Dim h As String =
                dtw("FC") = Tabla_Nota.Item(0, i).Value
                dtw("Numero") = Tabla_Nota.Item(1, i).Value ' formato de punto para datatable
                dtw("Ancho") = Tabla_Nota.Item(2, i).Value
                dtw("Alto") = Tabla_Nota.Item(3, i).Value
                dtw("Lama") = Tabla_Nota.Item(6, i).Value
                dtw("Color") = Tabla_Nota.Item(7, i).Value ' formato de punto para datatable
                dtw("Valor") = Tabla_Nota.Item(8, i).Value
                dtw("Total") = Tabla_Nota.Item(9, i).Value
                ds.Tabla_Co.Rows.Add(dtw)
            Next
            ''---------------------PREPARAR REPORTE--------------------
            fuente.Name = "DatosPre" ' Nombre identico al que le di al dataset del report en tiempo de diseño
            fuente.Value = ds.Tables(0)
            ''---------------------PREPARAR REPORTE------------------
        Catch ex As Exception
        End Try
        Reporte.reportes.LocalReport.DataSources.Clear()
        Reporte.reportes.LocalReport.DataSources.Add(fuente)
        Reporte.reportes.LocalReport.SetParameters(parametros)
        Comprobante_Creacion_Informe.Hide()
        Tabla_Nota.Rows.Clear()
        crear_16_filas()
        'Sacar_Reporte_Nota_Venta.reporte.LocalReport.ReportEmbeddedResource = "Modulo 2 - Nota Venta PYM.Report1.rdlc" 'exactamente como se llaman el proyecto y reporte
        Reporte.Owner = Me
        Reporte.ShowDialog()
    End Sub
    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        Menus.Show()
        Close()
    End Sub
    Private Sub volver_MouseMove(sender As Object, e As MouseEventArgs) Handles volver.MouseMove
        volver.BackColor = Color.FromArgb(0, 105, 120)
        volver.ForeColor = Color.White
    End Sub
    Private Sub volver_MouseLeave(sender As Object, e As EventArgs) Handles volver.MouseLeave
        volver.BackColor = Color.White
        volver.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub totaL_MouseMove(sender As Object, e As MouseEventArgs) Handles totaL.MouseMove
        If (totaL.Text = 0) Then
            desglose.Text = "cero"
        Else
            desglose.Text = Letras(totaL.Text)
        End If
    End Sub
    Private Sub totaL_MouseLeave(sender As Object, e As EventArgs) Handles totaL.MouseLeave
        desglose.Text = "..."
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim suma As Long = 0.0
        For Each row As DataGridViewRow In Tabla_Nota.Rows
            suma += Val(row.Cells(9).Value)
        Next
        totaL.Text = suma
        Dim cantidad1 As Integer = 0.0
        For i = 1 To Tabla_Nota.Rows.Count
            cantidad1 = i
        Next
        cant.Text = cantidad1
        If (Tabla_Nota.CurrentRow.Cells(2).EditedFormattedValue.ToString() = "" And Tabla_Nota.CurrentRow.Cells(3).EditedFormattedValue.ToString() = "" And Tabla_Nota.CurrentRow.Cells(4).EditedFormattedValue.ToString() = "" And Tabla_Nota.CurrentRow.Cells(5).EditedFormattedValue.ToString() = "") Then
        Else
            Dim row2 As DataGridViewRow = Tabla_Nota.CurrentRow()
            calculo_escala1()
            calculo_escala1_parte2()
            calculo_escala2()
            calculo_escala2_parte2()
            calculo_escala3()
            calculo_escala3_parte2()
            calculo_escala4()
            calculo_escala4_parte2()
            row2.Cells(9).Value = Tabla_Nota.CurrentRow.Cells(8).EditedFormattedValue.ToString()
        End If
        verifica_valor_nada_columna_numero()
    End Sub
    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        Tabla_Nota.Rows.Add("", "1", "", "", "", "", "", "")
    End Sub
    Private Sub filtrar_Click(sender As Object, e As EventArgs) Handles filtrar.Click
        sacar_informe()
    End Sub
    Private Sub Tabla_Nota_KeyDown(sender As Object, e As KeyEventArgs) Handles Tabla_Nota.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub Tabla_Nota_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_Nota.CellValueChanged
        cantidad_x_precio()
    End Sub
    Private Sub Tabla_Nota_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_Nota.CellDoubleClick
        Traspaso_Datos.Owner = Me
        Traspaso_Datos.ShowDialog()
    End Sub

    Private Sub Tabla_Nota_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla_Nota.CellContentClick

    End Sub
End Class