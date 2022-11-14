Public Class SeleccionCliente
    Sub Codigo_Reserva()
        Consulta("select max(codigo) as codigo from reservas")

        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("codigo")) Is DBNull Then
            mi_Codigo = 1
            Reserv.Text = mi_Codigo
        Else
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                mi_Codigo = CInt(DS.Tables(DT.TableName).Rows(0).Item("codigo")) + 1
                Reserv.Text = mi_Codigo
            End If
        End If
        Conexion.Close()
    End Sub
    Sub Actualizacion_Tabla()

        Consulta("select * from clientes")

    End Sub
    Sub Mostrar_Grilla()
        GrillaBusca.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    Sub BUSCAR()
        Consulta("select * from clientes where " & (Modo.Text) & " LIKE '" & (Valor_Busqueda.Text & "%") & "' ")
        GrillaBusca.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub

    Private Sub SeleccionCliente_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles Me.ChangeUICues

    End Sub

    Private Sub SeleccionCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Reservas.Enabled = True
    End Sub
    Private Sub SeleccionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Codigo_Reserva()
        Actualizacion_Tabla()
        Mostrar_Grilla()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mi_Codigo = "0"
        Me.Close()

    End Sub

    Private Sub Valor_Busqueda_TextChanged(sender As Object, e As EventArgs) Handles Valor_Busqueda.TextChanged
        If Modo.Text <> "" Then
            BUSCAR()
        End If
    End Sub
    Sub Grabar_Reserva()

        If mi_Codigo <> "0" And rut_Seleccion <> "" Then
            Dim fecha As Date
            Dim fecha2 As String
            fecha = FormatDateTime(Reservas.dtFecha.Value.Date, DateFormat.ShortDate)
            fecha2 = fecha.ToString("yyyy-MM-dd")

            Consulta("insert into reservas (codigo,fecha_reserva,hora,rut_cliente,total) values (" & (mi_Codigo) & ",'" & (fecha2) & "','" & (hora_Reserva) & "','" & (rut_Seleccion) & "','0')")

        End If

    End Sub

    Private Sub Modo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Modo.SelectedIndexChanged
        If Modo.Text <> "" Then
            BUSCAR()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Seleccionar.Click
        If GrillaBusca.Rows.Count > 0 Then
            rut_Seleccion = GrillaBusca.Item(0, GrillaBusca.CurrentCell.RowIndex).Value
            If rut_Seleccion <> "" Then
                Grabar_Reserva()
                Me.Close()
            Else
                MsgBox("Seleccione un Cliente de la Lista", vbCritical, "ERROR")
            End If
        End If
    End Sub

    Private Sub GrillaBusca_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaBusca.CellContentClick

    End Sub

    Private Sub GrillaBusca_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaBusca.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
End Class