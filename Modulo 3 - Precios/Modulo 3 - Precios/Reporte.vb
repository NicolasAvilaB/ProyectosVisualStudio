Imports System.Drawing.Printing
Imports System.IO
Imports Microsoft.Reporting.WinForms
Public Class Reporte
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
    Private Sub sel_MouseMove(sender As Object, e As MouseEventArgs) Handles sel.MouseMove
        sel.BackColor = Color.FromArgb(0, 105, 120)
        sel.ForeColor = Color.White
    End Sub
    Private Sub sel_MouseLeave(sender As Object, e As EventArgs) Handles sel.MouseLeave
        sel.BackColor = Color.White
        sel.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub volver_MouseMove(sender As Object, e As MouseEventArgs) Handles volver.MouseMove
        volver.BackColor = Color.FromArgb(0, 105, 120)
        volver.ForeColor = Color.White
    End Sub
    Private Sub volver_MouseLeave(sender As Object, e As EventArgs) Handles volver.MouseLeave
        volver.BackColor = Color.White
        volver.ForeColor = Color.FromArgb(0, 105, 120)
    End Sub
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reportes.ProcessingMode = ProcessingMode.Local
        Call obtener_impresoras(visual)
        visual.SelectedIndex = -1
        reportes.RefreshReport()
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
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub sel_Click(sender As Object, e As EventArgs) Handles sel.Click
        If (visual.SelectedIndex = -1) Then
            Advertencia.texto.Text = "Para imprimir seleccione una impresora"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            visual.Focus()
            visual.Select()
        ElseIf visual.SelectedItem.ToString <> "" Then
            SetDefaultPrinter(visual.SelectedItem.ToString)
            Dim ConfiguracionesDeImpresion As New PrinterSettings
            preder.Text = ConfiguracionesDeImpresion.PrinterName
        End If
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
    End Sub
    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        Close()
    End Sub
End Class