Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        fecha.Text = FormatDateTime(Now, DateFormat.ShortDate)
        RUT.SelectedIndex = -1
        Try
            Consulta("SELECT DISTINCT rut FROM clientes")
            RUT.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("clientes")
            DA.Fill(dt)
            With RUT
                .DataSource = dt
                .DisplayMember = "rut"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Consulta("SELECT DISTINCT patente FROM vehiculos")
            Patente_1.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("vehiculos")
            DA.Fill(dt)
            With Patente_1
                .DataSource = dt
                .DisplayMember = "patente"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub


    Sub Mostrar_Grilla()
        hist.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    'if ds.tables(dt.tablename).rows.count > 0 then
    'for i = 0 to ds.tables(dt.tablename).rows.count -1
    'combobox.item.add(ds.tables(dt.tablename).rows(i).item("rut"))
    Private Sub rut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RUT.SelectedIndexChanged
        Modulo_Consulta.Consulta("select * From clientes where rut = '" & (RUT.Text) & "'")

        If (RUT.SelectedIndex = -1) Then

        Else

            If DS.Tables(DT.TableName).Rows.Count = 1 Then

                Dim row As DataRow = DT.Rows(0)



                Mostrar_Grilla()

            End If
        End If
    End Sub
End Class
