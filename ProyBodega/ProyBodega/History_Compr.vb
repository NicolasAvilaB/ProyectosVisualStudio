Public Class History_Compr
    Dim Vall1 As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Bodega_User.Actualizacion_Tabla()
        Bodega_User.Mostrar_Grilla()
    End Sub
    Sub Actualizacion_Tabla()
        Consulta8("Call Historial_Compra")
    End Sub
    Sub Mostrar_Grilla()
        Grilla_History.DataSource = DS8.Tables(DT8.TableName)
        Conexion.Close()
    End Sub
    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
        Bodega_User.Actualizacion_Tabla()
        Bodega_User.Mostrar_Grilla()
    End Sub
    Private Sub filtro_Click(sender As Object, e As EventArgs) Handles filtro.Click
        Consulta8("Call FiltraFecha_Compra ('" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "') ")
        Grilla_History.DataSource = DS8.Tables(DT8.TableName)
    End Sub
    Private Sub Grilla_History_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_History.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub History_Compr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Vall1 = 0
        Precio.Enabled = True
        Precio.Interval = 50
    End Sub
    Private Sub Precio_Tick(sender As Object, e As EventArgs) Handles Precio.Tick
        If Me.Grilla_History.Rows.Count = 0 Then
            totales.Text = "$0"
            cant.Text = "0"
        Else
            Vall1 = Vall1 + 1
            Dim suma As Integer = 0.0
            Dim suma2 As Integer = 0.0
            For Each row As DataGridViewRow In Grilla_History.Rows
                suma += Val(row.Cells(4).Value)
                suma2 += Val(row.Cells(3).Value)
            Next
            totales.Text = "$ " & Convert.ToInt64(suma)
            cant.Text = Convert.ToInt64(suma2)
        End If
    End Sub
    Private Sub busqueda_history_TextChanged_1(sender As Object, e As EventArgs) Handles busqueda_history.TextChanged
        If (busqueda_history.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
        Else
            Consulta8("Call Buscar_Comprado ('" & (busqueda_history.Text) & "')")
            If DS8.Tables(DT8.TableName).Rows.Count > 0 Then
                Grilla_History.DataSource = DS8.Tables(DT8.TableName)
            Else
                Grilla_History.DataSource = Nothing
            End If
        End If
    End Sub
End Class