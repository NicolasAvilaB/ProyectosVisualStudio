Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fila As New TableRow()
        Dim Celda1 As New TableCell()
        Celda1.Font.Bold = True
        Celda1.Text = "Tabla 1"
        Dim Celda2 As New TableCell()
        Celda2.BackColor = Drawing.Color.Green
        Celda2.Text = "Tabla2"
        fila.Cells.Add(Celda1)
        fila.Cells.Add(Celda2)
        Table1.Rows.Add(fila)
        Table1.GridLines = GridLines.Both
    End Sub
End Class