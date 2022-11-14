Imports System.Drawing.Printing
Public Class Form1
    Declare Function SetDefaultPrinter Lib "winspool.drv" Alias "SetDefaultPrinterA" (ByVal pszPrinter As String) As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call obtener_impresoras(visual)
        visual.SelectedIndex = -1
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
        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            'Por todas las impresoras instaladas ir agregandolas al objeto sender
            sender.Items.Add(PrinterSettings.InstalledPrinters.Item(i).ToString)
        Next
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If visual.SelectedItem.ToString <> "" Then
            SetDefaultPrinter(visual.SelectedItem.ToString)
            Dim ConfiguracionesDeImpresion As New PrinterSettings
            preder.Text = ConfiguracionesDeImpresion.PrinterName
        End If
    End Sub
End Class
