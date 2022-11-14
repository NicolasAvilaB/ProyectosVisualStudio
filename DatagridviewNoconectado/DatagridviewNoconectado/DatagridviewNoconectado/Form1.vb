Imports Microsoft.Reporting.WinForms
Public Class Form1
	Dim fuente As New ReportDataSource
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		rellenargrid()
	End Sub
	Sub rellenargrid()
		Try
			Dim filas As Integer = 1
			grid.Rows.Add(filas)
			Dim n As Integer = grid.Rows.Count
			For i As Integer = 0 To n - 1
				grid.Item(0, i).Value = i + 1
				grid.Item(1, i).Value = "PRODUCTO" & (i + 1)
				grid.Item(2, i).Value = Format((CDbl(CDbl((6.3 * Rnd()) + 1))), "0.00")
				grid.Item(3, i).Value = i + 2
				grid.Item(4, i).Value = Format((grid.Item(3, i).Value * grid.Item(2, i).Value), "0.00")
			Next
		Catch ex As Exception
		End Try
	End Sub
	Sub Almacenar() 'Almacena los datos presentados en el datagridview
        'instanciamos los objetos creados 
        Try
			Dim ds As New DataSet1
			Dim dtw As DataRow
			For i As Integer = 0 To grid.Rows.Count - 1
				dtw = ds.DataTable1.NewRow()
				dtw("n") = grid.Item(0, i).Value
				dtw("Descripcion") = grid.Item(1, i).Value
				dtw("Valor_Unitario") = Replace(CDbl(grid.Item(2, i).Value), ",", ".") ' formato de punto para datatable
				dtw("Cantidad") = grid.Item(3, i).Value
				dtw("Subtotal") = Replace(CDbl(grid.Item(4, i).Value), ",", ".") 'formato de punto para datatable
				ds.DataTable1.Rows.Add(dtw)
			Next
			''---------------------PREPARAR REPORTE--------------------
			fuente.Name = "Productos" ' Nombre identico al que le di al dataset del report en tiempo de diseño
			fuente.Value = ds.Tables(0)
			''---------------------PREPARAR REPORTE------------------
		Catch ex As Exception
		End Try
	End Sub
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Almacenar()
		LLamarReporte()
	End Sub
	Sub LLamarReporte()
		Reporte.ReportViewer1.LocalReport.DataSources.Clear()
		Reporte.ReportViewer1.LocalReport.DataSources.Add(fuente)
		Reporte.ReportViewer1.LocalReport.ReportEmbeddedResource = "DatagridviewNoconectado.Fact.rdlc" 'exactamente como se llaman el proyecto y reporte
        Reporte.Show()
	End Sub
End Class
