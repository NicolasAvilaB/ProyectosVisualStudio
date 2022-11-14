Public Class Form3
    Private Sub v_Click(sender As Object, e As EventArgs) Handles v.Click
        Dim mifecha As Date = FormatDateTime(fe.Value.Date, DateFormat.ShortDate)
        Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
        Consulta("select codigo,pregunta from encuesta where fecha='" & (mifecha2) & "'")
        DataGridView1.DataSource = DS.Tables(DT.TableName)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim micod As Integer
        micod = DataGridView1.Item(DataGridView1.CurrentCell.RowIndex, 0).Value
        Consulta2("select opcion from opciones_encuestas where codigoencuesta= '" & (micod) & "'")
        DataGridView2.DataSource = DS2.Tables(DT2.TableName)
    End Sub
End Class