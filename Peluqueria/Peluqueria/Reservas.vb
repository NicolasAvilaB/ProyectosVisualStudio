Public Class Reservas
    Sub carga_bloques()
        dg.Rows.Clear()

        For i = 9 To 20
            dg.Rows.Add(i & ":00")
        Next

    End Sub
    Sub Mostrar_Reservas()
        Dim total_registros As String
        Dim fecha As Date
        Dim fecha2 As String
        Dim horagrilla As String

        fecha = FormatDateTime(dtFecha.Value.Date, DateFormat.ShortDate)
        fecha2 = fecha.ToString("yyyy-MM-dd")
        Consulta("select codigo, hora, fecha_reserva, rut_cliente, total,nombre from reservas inner join clientes on reservas.rut_cliente = clientes.rut where reservas.fecha_reserva='" & (fecha2) & "' ")

        total_registros = DS.Tables(DT.TableName).Rows.Count

        If total_registros > 0 Then

            For i = 0 To total_registros - 1
                hora_Reserva = DS.Tables(DT.TableName).Rows(i).Item("hora")

                For j = 0 To dg.Rows.Count - 1
                    horagrilla = dg.Item(0, j).Value

                    If hora_Reserva = horagrilla Then
                        dg.Item(1, j).Value = DS.Tables(DT.TableName).Rows(i).Item("codigo")
                        dg.Item(2, j).Value = DS.Tables(DT.TableName).Rows(i).Item("rut_cliente")
                        dg.Item(3, j).Value = DS.Tables(DT.TableName).Rows(i).Item("nombre")
                        dg.Item(4, j).Value = DS.Tables(DT.TableName).Rows(i).Item("total")
                        Exit For
                    End If
                Next
            Next
        End If

    End Sub
    Sub Mostrar_Documentos()
        Dim total As Integer
        dg2.Rows.Clear()
        Consulta2("select codigo, nombre, descripcion, precio from corte_tratamiento")
        total = DS2.Tables(DT2.TableName).Rows.Count
        If total > 0 Then
            For i = 0 To total - 1
                dg2.Rows.Add(False, DS2.Tables(DT.TableName).Rows(i).Item("codigo"), DS2.Tables(DT2.TableName).Rows(i).Item("nombre"), DS2.Tables(DT2.TableName).Rows(i).Item("precio"))
            Next
        End If
    End Sub
    Sub Grabar_Detalle_Reserva()
        Dim codigo_grilla As String
        Dim codigo_tratamiento As Integer
        Dim precio_tratamiento As Integer
        Dim valor_act As Boolean

        codigo_grilla = dg.Item(1, mi_Fila).Value
        codigo_tratamiento = dg2.Item(1, dg2.CurrentCell.RowIndex).Value
        precio_tratamiento = dg2.Item(3, dg2.CurrentCell.RowIndex).Value

        If codigo_grilla <> "" Then
            Consulta("delete from detalle_reserva where codigo_reserva= " & (codigo_grilla) & " and codigo_tratamiento= " & (codigo_tratamiento) & " ")
            valor_act = dg.Item(0, dg.CurrentCell.RowIndex).Value

            If valor_act = True Then

                Consulta2("insert into detalle_reserva(codigo_reserva, codigo_tratamiento,precio) values (" & (codigo_grilla) & "," & (codigo_tratamiento) & "," & (precio_tratamiento) & ")")

            End If
        End If


    End Sub

    Private Sub Reservas_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        carga_bloques()
        Mostrar_Reservas()
    End Sub
    Private Sub Reservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_bloques()

    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        mi_Fila = dg.CurrentCell.RowIndex
        hora_Reserva = dg.Item(0, dg.CurrentCell.RowIndex).Value

        If dg.Item(2, mi_Fila).Value = "" Then

            Me.Enabled = False
            SeleccionCliente.Show()
        Else
            Mostrar_Documentos()
            'mostrar_documentos_reserva()
        End If


    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub Limpiar_Reservas_Click(sender As Object, e As EventArgs) Handles Limpiar_Reservas.Click
        Consulta("delete from reservas")
        MsgBox("Limpieza Completada", vbInformation, "Exito")
        Conexion.Close()
    End Sub

    Private Sub dg_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellDoubleClick

    End Sub

    Private Sub dg_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg.CellMouseDoubleClick

    End Sub

    Private Sub dg_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles dg.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg2.CellContentClick

    End Sub

    Private Sub DataGridView2_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles dg2.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub dtFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtFecha.ValueChanged

        Mostrar_Reservas()

    End Sub

    Private Sub dg_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick
        Dim respuesta As Integer
        If dg.Item(2, mi_Fila).Value <> "" Then

            respuesta = MsgBox("Ya Existe una Reserva, ¿Desea Quitarla?", vbYesNo + vbQuestion, "Pregunta")
            If respuesta = vbYes Then

                Consulta("delete from reservas where codigo=(" & (dg.Item(1, mi_Fila).Value) & ")")
                carga_bloques()
                Mostrar_Reservas()
            End If
        End If
    End Sub
End Class