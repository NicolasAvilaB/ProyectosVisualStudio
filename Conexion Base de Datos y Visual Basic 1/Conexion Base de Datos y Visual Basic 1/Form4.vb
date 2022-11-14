Public Class Form4
    Sub llenarCombobox()
        MiConsulta("select * from clientes")
        Dim totalrEGISTROS As Integer = DS.Tables(DT.TableName).Rows.Count
        If totalrEGISTROS > 0 Then
            For i = 0 To totalrEGISTROS - 1
                CBRUT.Items.Add(DS.Tables(DT.TableName).Rows(i).Item("Rut"))
            Next
        End If

    End Sub
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombobox()

    End Sub

    Private Sub CBRUT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBRUT.SelectedIndexChanged
        MiConsulta("select * from clientes where rut ='" & (CBRUT.Text) & "'")
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            txtNOMBRE.Text = DS.Tables(DT.TableName).Rows(0).Item("Nombre")
            txtDireccion.Text = DS.Tables(DT.TableName).Rows(0).Item("Direccion")
            txtTELEFONO.Text = DS.Tables(DT.TableName).Rows(0).Item("Telefono")

        End If




    End Sub
End Class