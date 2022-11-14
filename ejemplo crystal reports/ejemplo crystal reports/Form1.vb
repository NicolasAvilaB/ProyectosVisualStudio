Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO

Public Class Form1
    Dim orpt As New CrystalReport1
    Dim orp1 As New ReportDocument
            

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        orp1.Load("C:\Users\Nicolas Avila B\Documents\Visual Studio 2013\Projects\ejemplo crystal reports\ejemplo crystal reports\CrystalReport1.rpt")

        ' Form2.ShowDialog()


        ' Form2.CrystalReportViewer1.ReportSource = orpt
        Dim ce As String = TextBox1.Text
        Dim ce1 As String



        ' ce1 = Convert.ToString(DataGridView1.CurrentRow.Cells("Column1").Value)
        'ce2 = Convert.ToString(DataGridView1.CurrentRow.Cells("Column2").Value)

        orpt.ParameterFields("para").CurrentValues.Clear()
        orpt.SetParameterValue("para", ce)




        'orpt.PrintToPrinter( (Numero de Copias) = 1, (Mostrar dialogo) = False, Imprimir de Primera pag= 0, hasta la ultima pagina = 0)

        ' orpt.PrintToPrinter(1, False, 0, 0)

        orpt.ParameterFields("d").CurrentValues.Clear()
        For Each row As DataGridViewRow In Me.DataGridView1.Rows


            orpt.SetParameterValue("d", row.Cells(0).Value.ToString)
            'GR.DataTable1.AddDataTable1Row(, row.Cells(3).Value.ToString, row.Cells(2).Value.ToString)

        Next
        ' Try
        'Dim CrExportOptions As ExportOptions
        ' Dim CrDiskFileDestinationOptions As New  _
        ' DiskFileDestinationOptions()
        ' Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        ' CrDiskFileDestinationOptions.DiskFileName = "Documentos\crystalExport.pdf"
        ' CrExportOptions = orp1.ExportOptions
        'With CrExportOptions
        '.ExportDestinationType = ExportDestinationType.DiskFile
        '.ExportFormatType = ExportFormatType.PortableDocFormat
        '.DestinationOptions = CrDiskFileDestinationOptions
        ' .FormatOptions = CrFormatTypeOptions
        ' End With
        'orp1.Export()
        'Catch ex As Exception
        'MsgBox(ex.ToString)
        ' End Try

        Dim oReporte As New CrystalReport1
        Form2.CrystalReportViewer1.ReportSource = oReporte
        Form2.Show()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles DataGridView1.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
