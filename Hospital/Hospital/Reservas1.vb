Public Class Reservas1
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
    Sub carga_bloques()
        dg.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()

    End Sub
    Sub Mostrar_Reservas()
        Dim total_registros As String

        Dim horagrilla As String

        Consulta("select reservas.codigo, reservas.hora, reservas.fecha_reserva, reservas.rut_cliente, reservas.total,reservas.nombre from reservas inner join pacientes on reservas.rut_cliente = pacientes.rut where reservas.fecha_reserva='" & (Dias.Text) & "' ")

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
    Private Sub Reservas1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_bloques()
        actualizartabla()



    End Sub

    Sub actualizartabla()
        Consulta("select reservasdoctor.hora,reservasdoctor.dia from reservasdoctor where nombre ='" & (Nombre.Text) & "' and dia='" & (Dias.Text) & "'")
    End Sub
    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        carga_bloques()
        actualizartabla()

    End Sub


    Private Sub dg_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellDoubleClick
        Dim respuesta As Integer
        If dg.Item(2, mi_Fila).Value <> "" Then

            respuesta = MsgBox("Ya Existe una Reserva, ¿Desea Quitarla?", vbYesNo + vbQuestion, "Quitar Reserva")
            If respuesta = vbYes Then
                Dim row As DataGridViewRow = dg.Rows(e.RowIndex)
                Consulta("delete from reservas where codigo=(" & Val(row.Cells(0).Value) & ")")

                carga_bloques()


            End If
        End If

    End Sub

    Private Sub dg_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles dg.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick

    End Sub

    Private Sub Limpiar_Reservas_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        Menu2.Show()
    End Sub

    Private Sub Dias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dias.SelectedIndexChanged
        carga_bloques()
        actualizartabla()
    End Sub
    Sub muestre()
        Consulta("select pacientes.rut, pacientes.nombre from pacientes where medico = '" & (Nombre.Text) & "' ")
        If DS.Tables(DT.TableName).Rows.Count = 1 Then
            Dim row As DataRow = DT.Rows(0)

            rutis.Text = CStr(row("rut"))
            Nomi.Text = CStr(row("nombre"))
            carga_bloques()
            actualizartabla()
        End If

    End Sub

    Private Sub Doctor_TextChanged(sender As Object, e As EventArgs) Handles Doctor.TextChanged

        Consulta("select usuarios.rut, usuarios.nomb from usuarios where id = '" & (Doctor.Text) & "' ")
        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            Nombre.Text = Nothing

            actualizartabla()
            carga_bloques()

            Nombre.Visible = False
        Else



            Dim row As DataRow = DT.Rows(0)


            Nombre.Text = CStr(row("nomb"))

            Nombre.Visible = True

            Try
                Consulta("SELECT DISTINCT rut FROM pacientes where medico ='" & (Nombre.Text) & "'")
                rutis.SelectedIndex = -1
                Dim dt As DataTable = New DataTable("pacientes")
                DA.Fill(dt)
                With rutis
                    .DataSource = dt
                    .DisplayMember = "rut"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            rutis.SelectedIndex = -1

            Try
                Consulta("SELECT DISTINCT nombre FROM pacientes where medico ='" & (Nombre.Text) & "'")
                Nomi.SelectedIndex = -1
                Dim dt As DataTable = New DataTable("pacientes")
                DA.Fill(dt)
                With Nomi
                    .DataSource = dt
                    .DisplayMember = "nombre"
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Nomi.SelectedIndex = -1


            actualizartabla()

            carga_bloques()

        End If

        actualizartabla()

        carga_bloques()

    End Sub
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Acep.Click
        Dim row As DataGridViewRow = Me.dg.CurrentRow()
        Dim canti As Integer
        row.Cells(1).Value = rutis.Text
        row.Cells(2).Value = Nomi.Text
        row.Cells(3).Value = Totales.Text
        row.Cells(0).Value = TextBox1.Text

        For i = 1 To dg.Rows.Count
            canti = i

        Next

        TextBox1.Text = canti

        Button1.Enabled = True
        rutis.SelectedIndex = -1
        Nomi.SelectedIndex = -1
        Totales.Clear()
        Totales.Text = "0"
    End Sub

    Private Sub Totales_TextChanged(sender As Object, e As EventArgs) Handles Totales.TextChanged
        If (Len(Totales.Text) > 3) Then
            Acep.Enabled = True
        Else
            Acep.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        For Each row As DataGridViewRow In dg.Rows


            Consulta("insert into reservas (codigo,fecha_reserva,hora,rut_cliente,total,nombre) values (" & Val(row.Cells(0).Value) & ",'" & CStr(row.Cells(5).Value) & "','" & CStr(row.Cells(4).Value) & "','" & CStr(row.Cells(1).Value) & "','" & (Totales.Text) & "','" & CStr(row.Cells(2).Value) & "')")
        Next

        Button1.Enabled = False
        Acep.Enabled = True
        rutis.SelectedIndex = -1
        Nomi.SelectedIndex = -1

    End Sub

    Private Sub Reservas1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub limpio_Click(sender As Object, e As EventArgs) Handles limpio.Click
        Consulta("delete from reservas")
        Me.Close()
        Menu2.Show()
    End Sub
End Class