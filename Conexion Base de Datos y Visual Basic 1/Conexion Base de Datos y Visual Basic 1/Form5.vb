Public Class Form5
    Sub llenarcombobox()
        MiConsulta("select * from clientes")
        Dim totalrEGISTROS As Integer = DS.Tables(DT.TableName).Rows.Count
        If totalrEGISTROS > 0 Then
            For i = 0 To totalrEGISTROS - 1
                CBrut.Items.Add(DS.Tables(DT.TableName).Rows(i).Item("Rut"))
            Next
        End If
    End Sub
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarcombobox()

    End Sub

    Private Sub CBrut_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBrut.SelectedIndexChanged
        MiConsulta("select * from clientes where rut ='" & (CBrut.Text) & "'")
        DataGridView1.DataSource = DS.Tables(DT.TableName)

    End Sub
End Class