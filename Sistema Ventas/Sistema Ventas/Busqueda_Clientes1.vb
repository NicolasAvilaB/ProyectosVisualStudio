Public Class Busqueda_Clientes1

    Sub BUSCAR()

        Consulta("SELECT * from clientes WHERE " & (B_Clientes.Text) & " LIKE '" & (F_Busc.Text & "%") & "' ")
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Visual.DataSource = DS.Tables(DT.TableName)

        End If
    End Sub
    Private Sub B_Clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles B_Clientes.SelectedIndexChanged
        If B_Clientes.Text <> "" Then
            BUSCAR()
        End If
    End Sub

    Private Sub F_Busc_TextChanged(sender As Object, e As EventArgs) Handles F_Busc.TextChanged
        If B_Clientes.Text <> "" Then
            BUSCAR()
            
        End If
    End Sub

    Private Sub Visual_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Visual.CellContentClick
        
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Busqueda_Clientes1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Visual_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Visual.CellDoubleClick

        If DS.Tables(DT.TableName).Rows.Count = 1 Then
            Dim row As DataRow = DT.Rows(0)
            Ventas1.Rut.Text = CStr(row("rut"))
        End If
        F_Busc.Clear()
        Me.Close()

    End Sub
End Class