Public Class Busca_Productos
    Dim mul As Integer
    Dim neto As Integer
    Dim iva As Integer
    Dim total As Integer
    Sub BUSCAR()

        Consulta("SELECT * from productos WHERE " & (B_Pro.Text) & " LIKE '" & (F_Bus_Pro.Text & "%") & "' ")
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Vissual.DataSource = DS.Tables(DT.TableName)

        End If


    End Sub
    Private Sub Busca_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub B_Pro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles B_Pro.SelectedIndexChanged
        If B_Pro.Text <> "" Then
            BUSCAR()
        End If
    End Sub

    Private Sub F_Bus_Pro_TextChanged(sender As Object, e As EventArgs) Handles F_Bus_Pro.TextChanged
        If B_Pro.Text <> "" Then
            BUSCAR()
        End If
    End Sub

    Private Sub Vissual_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vissual.CellContentClick

    End Sub

    Private Sub Vissual_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vissual.CellDoubleClick

        Dim row As DataGridViewRow = Vissual.Rows(e.RowIndex)
        mul = Val(row.Cells(4).Value) * 1
        neto = mul / 1.19
        iva = mul - neto
        total = iva + mul
        Ventas1.DProd.Rows.Add(Val(row.Cells(0).Value), CStr(row.Cells("nombre").Value), Val(row.Cells(4).Value), "1", neto, iva, total)
        Ventas1.DProd.CurrentCell = Ventas1.DProd.Rows(Ventas1.DProd.RowCount - 1).Cells(0)
        Ventas1.DProd.Refresh()
        F_Bus_Pro.Clear()
        Me.Close()




    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class