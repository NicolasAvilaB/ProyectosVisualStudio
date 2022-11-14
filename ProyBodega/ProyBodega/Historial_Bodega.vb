Public Class Historial_Bodega
    Dim Vall1 As Integer
    Private Sub Historial_Bodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Vall1 = 0
        Cantid.Enabled = True
        Cantid.Interval = 50
    End Sub
    Sub Actualizacion_Tabla()
        Consulta4("Call VisualizaGrillaHistorialStock")
    End Sub
    Sub Mostrar_Grilla()
        Grilla_History.DataSource = DS4.Tables(DT4.TableName)
        Conexion.Close()
    End Sub
    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
    End Sub
    Private Sub filtro_Click(sender As Object, e As EventArgs) Handles filtro.Click
        Consulta4("Call Filtro_Fecha ('" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "') ")
        Grilla_History.DataSource = DS4.Tables(DT4.TableName)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Grilla_History_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_History.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub busqueda_productos_TextChanged(sender As Object, e As EventArgs) Handles busqueda_history.TextChanged
        If (busqueda_history.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
        Else
            Consulta4("Call Busqueda_Codigo ('" & (busqueda_history.Text) & "')")
            If DS4.Tables(DT4.TableName).Rows.Count > 0 Then
                Grilla_History.DataSource = DS4.Tables(DT4.TableName)
            Else
                Grilla_History.DataSource = Nothing
            End If
        End If
    End Sub
    Private Sub Cantid_Tick(sender As Object, e As EventArgs) Handles Cantid.Tick
        If Me.Grilla_History.Rows.Count = 0 Then
            cant.Text = "0"
        Else
            Vall1 = Vall1 + 1
            Dim suma As Integer = 0.0
            For Each row As DataGridViewRow In Grilla_History.Rows
                suma += Val(row.Cells(3).Value)
            Next
            cant.Text = Convert.ToInt64(suma)
        End If
    End Sub
End Class