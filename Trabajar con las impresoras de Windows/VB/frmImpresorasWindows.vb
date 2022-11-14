Imports System.Drawing.Printing

Public Class frmImpresorasWindows

    Declare Function SetDefaultPrinter Lib "winspool.drv" Alias "SetDefaultPrinterA" (ByVal pszPrinter As String) As Boolean

    Private Sub btnObtenerImpresorasInstaladas_Click(sender As Object, e As EventArgs) Handles btnObtenerImpresorasInstaladas.Click

        Try
            lstImpresorasInstaladas.Items.Clear()
            For Each Impresora As String In PrinterSettings.InstalledPrinters
                lstImpresorasInstaladas.Items.Add(Impresora)
            Next
            ObtenerImpresoraPredeterminada()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnPredeterminarImpresora_Click(sender As Object, e As EventArgs) Handles btnPredeterminarImpresora.Click

        Try
            If lstImpresorasInstaladas.SelectedItem.ToString <> "" Then
                SetDefaultPrinter(lstImpresorasInstaladas.SelectedItem.ToString)
                ObtenerImpresoraPredeterminada()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ObtenerImpresoraPredeterminada()
        Dim ConfiguracionesDeImpresion As New PrinterSettings

        Try
            txtImpresoraPredeterminada.Text = ConfiguracionesDeImpresion.PrinterName
        Catch ex As Exception

        End Try

    End Sub

End Class
