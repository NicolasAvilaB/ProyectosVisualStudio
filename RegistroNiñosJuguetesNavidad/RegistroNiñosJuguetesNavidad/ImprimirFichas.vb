Imports System.Drawing.Printing
Public Class ImprimirFichas
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Declare Function SetDefaultPrinter Lib "winspool.drv" Alias "SetDefaultPrinterA" (ByVal pszPrinter As String) As Boolean
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub regresar_Click(sender As Object, e As EventArgs) Handles regresar.Click
        Me.Close()
    End Sub
    Private Sub ImprimirFichas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call obtener_impresoras(visual)
        visual.SelectedIndex = -1
        Me.ReportViewer1.RefreshReport()
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
End Class