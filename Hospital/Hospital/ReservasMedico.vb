Public Class ReservasMedico
    Dim varseleccion As Integer
    Private Sub ReservasMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Codigo_Reserva()
        carga_bloques()
        actualizartabla()

        mostrar(0)

    End Sub

    Sub carga_bloques()
        dg.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    Sub mostrar(ByVal i As Integer)

        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Label7.Text = DS.Tables(DT.TableName).Rows(i).Item("rut_cliente")
            Label4.Text = DS.Tables(DT.TableName).Rows(i).Item("nombre")
            Label6.Text = DS.Tables(DT.TableName).Rows(i).Item("codigo")
            Horare.Text = DS.Tables(DT.TableName).Rows(i).Item("hora")
            Diad.Text = DS.Tables(DT.TableName).Rows(i).Item("dia")
            diad2.Text = DS.Tables(DT.TableName).Rows(i).Item("modalidad")
            Label4.Visible = True
            Label7.Visible = True
        Else
            Label4.Visible = False
            Label7.Visible = False
        End If
    End Sub
    Sub Codigo_Reserva()
        Consulta("select max(codigo) as codigo from reservasdoctor")

        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("codigo")) Is DBNull Then
            mi_Codigo2 = 1
            Label6.Text = mi_Codigo2
        Else
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                mi_Codigo2 = CInt(DS.Tables(DT.TableName).Rows(0).Item("codigo")) + 1
                Label6.Text = mi_Codigo2
            End If
        End If
        Conexion.Close()
    End Sub
    Sub actualizartabla()
        Consulta("select * from reservasdoctor")
    End Sub

    Private Sub dg_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick

    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        Dim row As DataGridViewRow = dg.Rows(e.RowIndex)
        Diad.Text = CStr(row.Cells("modalidad").Value)
        Horare.Text = CStr(row.Cells("hora").Value)
        Label6.Text = Val(row.Cells(0).Value)
        Label7.Text = CStr(row.Cells("rut_cliente").Value)
        Label4.Text = CStr(row.Cells("nombre").Value)
        diad2.Text = CStr(row.Cells("dia").Value)
    End Sub

    Private Sub ReservasMedico_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Reservas1.Enabled = True
    End Sub

    Private Sub dg_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles dg.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        Menu2.Show()
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        varseleccion = 1
        Diad.Enabled = True
        Doctor.Enabled = True
        Doctor.ReadOnly = False
        Horare.ReadOnly = False
        Horare.Enabled = True
        Guardar.Enabled = True
        Horare.Clear()
        Horare.Text = "08:00"
        Doctor.Clear()
        Diad.SelectedIndex = -1
        dg.Enabled = False
        Label4.Visible = False
        Label7.Visible = False
        diad2.Enabled = True
        Buscar.Clear()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        If (Diad.SelectedIndex = -1) Then
            MsgBox("Seleccione una Modalidad (Temprano o Tarde) de la Semana", vbCritical, "Error")
            Diad.Focus()
            Diad.Select()
        ElseIf (diad2.SelectedIndex = -1) Then
            MsgBox("Seleccione un Dia de la Semana", vbCritical, "Error")
            diad2.Focus()
            diad2.Select()
        ElseIf (Label7.Visible = False Or Label4.Visible = False) Then
            MsgBox("Verifique Que Haya Escrito Bien El Nombre Del Doctor", vbCritical, "Error")
            Doctor.Clear()
            Doctor.Focus()
            Doctor.Select()
        ElseIf (Horare.Text = "") Then
            MsgBox("Escriba La Hora para el Doctor, No puede estar Vacio", vbCritical, "Error")
            Horare.Clear()
            Horare.Focus()
            Horare.Select()
            Horare.Text = "08:00"
        ElseIf (Horare.Text < "08:00") Then
            MsgBox("Escriba una Hora Correspondiente para el Doctor", vbCritical, "Error")
            Horare.Clear()
            Horare.Focus()
            Horare.Select()
        ElseIf (Horare.Text > "18:00") Then
            MsgBox("Escriba una Hora Correspondiente para el Doctor", vbCritical, "Error")
            Horare.Clear()
            Horare.Focus()
            Horare.Select()
            Horare.Text = "08:00"

        ElseIf varseleccion = 1 Then

            Consulta("insert into reservasdoctor (codigo, hora, dia,modalidad, rut_cliente,nombre) values ('" & (Label6.Text) & "','" & (Horare.Text) & "','" & (diad2.Text) & "','" & (Diad.Text) & "','" & (Label7.Text) & "','" & (Label4.Text) & "')")
            MsgBox("Datos Ingresados Correctamente", vbInformation, "Ingreso Correcto")
            Codigo_Reserva()
            actualizartabla()
            carga_bloques()
            Diad.Enabled = False
            Doctor.Enabled = False
            Doctor.ReadOnly = True
            Horare.ReadOnly = True
            Horare.Enabled = False
            Guardar.Enabled = False
            Nuevo.Enabled = True
            dg.Enabled = True
            mostrar(0)
            Label4.Visible = True
            Label7.Visible = True
            diad2.Enabled = False
        ElseIf varseleccion = 2 Then
            Consulta("UPDATE reservasdoctor SET nombre='" & (Label4.Text) & "', dia='" & (diad2.Text) & "', modalidad='" & (Diad.Text) & "',hora ='" & (Horare.Text) & "',rut_cliente ='" & (Label7.Text) & "' where codigo=" & (Label6.Text) & "")
            MsgBox("Datos Modificados Correctamente", vbInformation, "Ingreso Correcto")
            Codigo_Reserva()
            actualizartabla()
            carga_bloques()
            Diad.Enabled = False
            Doctor.Enabled = False
            Doctor.ReadOnly = True
            Horare.ReadOnly = True
            Horare.Enabled = False
            Guardar.Enabled = False
            Nuevo.Enabled = True
            dg.Enabled = True
            diad2.Enabled = False
            mostrar(0)
        End If
        Codigo_Reserva()
        actualizartabla()
        carga_bloques()
    End Sub

    Private Sub Doctor_TextChanged(sender As Object, e As EventArgs) Handles Doctor.TextChanged

        Consulta("select usuarios.rut, usuarios.nomb from usuarios where id = '" & (Doctor.Text) & "' ")
        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            Label4.Text = Nothing
            Label7.Text = Nothing
            Codigo_Reserva()
            actualizartabla()
            carga_bloques()

            Label4.Visible = False
            Label7.Visible = False
        Else



            Dim row As DataRow = DT.Rows(0)

            Label7.Text = CStr(row("rut"))
            Label4.Text = CStr(row("nomb"))

            Label4.Visible = True
            Label7.Visible = True
        End If
        Codigo_Reserva()
        actualizartabla()

        carga_bloques()


    End Sub

    Private Sub dg_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellDoubleClick
        Dim respuesta As Integer
        If dg.Item(2, mi_Fila2).Value <> "" Then

            respuesta = MsgBox("Ya Existe una Reserva, ¿Desea Quitarla?", vbYesNo + vbQuestion, "Quitar Reserva")
            If respuesta = vbYes Then
                Dim row As DataGridViewRow = dg.Rows(e.RowIndex)
                Consulta("delete from reservasdoctor where codigo=(" & Val(row.Cells(0).Value) & ")")

                Codigo_Reserva()
                actualizartabla()
                carga_bloques()
                MsgBox("Datos Borrados Exitosamente", vbInformation, "Borrado Exitoso")
                mostrar(0)
            End If
        End If

    End Sub

    Private Sub dg_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellEnter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        varseleccion = 2
        Diad.Enabled = True
        Doctor.Enabled = True
        Doctor.ReadOnly = False
        Horare.ReadOnly = False
        Horare.Enabled = True
        Guardar.Enabled = True
        diad2.Enabled = True

        Nuevo.Enabled = False

        dg.Enabled = False
        Buscar.Clear()
    End Sub

    Private Sub diad2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles diad2.SelectedIndexChanged

    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        Consulta("delete from reservasdoctor")
        MsgBox("Datos Borrados Exitosamente", vbInformation, "Limpieza Exitosa")
        Me.Close()
        Menu2.Show()
    End Sub

    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs) Handles Buscar.TextChanged
        If (Buscar.Text = "") Then
            actualizartabla()
            carga_bloques()
            mostrar(0)
        Else
            Consulta("select * from reservasdoctor where rut_cliente='" & (Buscar.Text) & "' ")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                dg.DataSource = DS.Tables(DT.TableName)

            End If
        End If
    End Sub
End Class