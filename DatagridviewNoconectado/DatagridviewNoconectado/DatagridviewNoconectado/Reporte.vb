Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class Reporte

	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.ReportViewer1.RefreshReport()
		Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
		Me.ReportViewer1.ZoomMode = ZoomMode.Percent
		Me.ReportViewer1.ZoomPercent = 100
	End Sub
End Class
