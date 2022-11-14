Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms
Public Class Sacar_Reporte_Nota_Venta
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Dim allowResize As Boolean
    Declare Function SetDefaultPrinter Lib "winspool.drv" Alias "SetDefaultPrinterA" (ByVal pszPrinter As String) As Boolean
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
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        confirmar_operacion_salir_ventana()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Public Sub obtener_impresoras(ByVal sender As Object)
        'Sender es el objeto donde se veran las impresoras
        'en este caso yo utilizo un ListBox pero podria tambien ser un ComboBox
        'un List, entre otros que sean de tipo collections
        Dim pd As New PrintDocument
        'Se define el print Document.
        Dim impresora_predeterminada As String = pd.PrinterSettings.PrinterName
        'Todo muy claro pero en ingles, se asigna en una variable el nombre
        'de la impresora predeterminada.
        Try
            For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
                'Por todas las impresoras instaladas ir agregandolas al objeto sender
                sender.Items.Add(PrinterSettings.InstalledPrinters.Item(i).ToString)
            Next
        Catch ex As Exception
        End Try
        For i = 0 To sender.Items.Count - 1
            If sender.Items.Item(i).ToString = impresora_predeterminada Then
                'La impresora de la lista que posea el nombre de la predeterminada
                'sera la seleccionada
                sender.SelectedIndex = i
            End If
        Next
        Dim ConfiguracionesDeImpresion As New PrinterSettings
        preder.Text = ConfiguracionesDeImpresion.PrinterName
    End Sub
    Private Sub Sacar_Reporte_Nota_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reporte.ProcessingMode = ProcessingMode.Local
        Call obtener_impresoras(visual)
        visual.SelectedIndex = -1
        Me.reporte.RefreshReport()
        NotaVenta.limpieza()
        NotaVenta.valor_orden_venta()
        NotaVenta.crear_16_filas()
    End Sub
    Private Sub sel_Click(sender As Object, e As EventArgs) Handles sel.Click
        If (visual.SelectedIndex = -1) Then
            MsgBox("Error: Seleccione por lo menos una Impresora a imprimir el reporte e intentelo denuevo", vbCritical, "Error de Seleccion de Impresora")
            visual.Focus()
            visual.Select()
        ElseIf visual.SelectedItem.ToString <> "" Then
            SetDefaultPrinter(visual.SelectedItem.ToString)
            Dim ConfiguracionesDeImpresion As New PrinterSettings
            preder.Text = ConfiguracionesDeImpresion.PrinterName
        End If
    End Sub
    Private Sub sel_MouseMove(sender As Object, e As MouseEventArgs) Handles sel.MouseMove
        sel.BackColor = Color.White
        sel.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub sel_MouseLeave(sender As Object, e As EventArgs) Handles sel.MouseLeave
        sel.BackColor = Color.FromArgb(27, 94, 32)
        sel.ForeColor = Color.White
    End Sub
    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        confirmar_operacion_salir_ventana()
    End Sub
    Sub confirmar_operacion_salir_ventana()
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Estas seguro de salir de la ventana de impresion?", vbYesNo + vbQuestion, "Confirma la Operacion")
        If valormensaje = vbYes Then
            Close()
        Else
            MsgBox("Has Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
        End If
    End Sub
    Private Sub volver_MouseMove(sender As Object, e As MouseEventArgs) Handles volver.MouseMove
        volver.BackColor = Color.White
        volver.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub volver_MouseLeave(sender As Object, e As EventArgs) Handles volver.MouseLeave
        volver.BackColor = Color.FromArgb(27, 94, 32)
        volver.ForeColor = Color.White
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.White
        cerrar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(27, 94, 32)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.White
        minimizar.ForeColor = Color.FromArgb(27, 94, 32)
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(27, 94, 32)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub Sacar_Reporte_Nota_Venta_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If allowResize Then
            If e.X >= (Me.Right - Me.Left) - 1 And e.Y >= (Me.Bottom - Me.Top) - 1 Then
                'Cambio el Ancho y el Alto con este calculo, crece
                'Esto funciona pero si quieren que lo explique a mayor profundidad, poner mensaje
                Me.Width = Me.Right - Me.Left + 10
                Me.Height = Me.Bottom - Me.Top + 10
                Me.Refresh()
                'Si el raton se mueve hacia la derecha, crece
            ElseIf e.X >= (Me.Right - Me.Left) - 1 Then
                Me.Width = Me.Right - Me.Left + 10
                Me.Refresh()
                'Si el raton se mueve hacia abajo, crece
            ElseIf e.Y >= (Me.Bottom - Me.Top) - 1 Then
                Me.Height = Me.Bottom - Me.Top + 10
                Me.Refresh()
                'Si el raton se mueve hacia la izquierda y hacia arriba, decrece
            ElseIf e.X < (Me.Right - Me.Left) - 6 And e.Y < (Me.Bottom - Me.Top) - 6 Then
                Me.Width = Me.Right - Me.Left - 7
                Me.Height = Me.Bottom - Me.Top - 7
                Me.Refresh() 'Si el raton se mueve hacia la izquierda, decrece
            ElseIf e.X < (Me.Right - Me.Left) - 5 Then
                Me.Width = Me.Right - Me.Left - 7
                Me.Refresh() 'Si el raton se mueve hacia arriba, decrece
            ElseIf e.Y < (Me.Bottom - Me.Top) - 5 Then
                Me.Height = Me.Bottom - Me.Top - 7
                Me.Refresh()
            End If
        Else
        End If
    End Sub
    Private Sub Sacar_Reporte_Nota_Venta_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        allowResize = True
        Me.Cursor = Cursors.SizeNWSE
    End Sub
    Private Sub Sacar_Reporte_Nota_Venta_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        allowResize = False
        Me.Cursor = Cursors.Default
    End Sub
End Class