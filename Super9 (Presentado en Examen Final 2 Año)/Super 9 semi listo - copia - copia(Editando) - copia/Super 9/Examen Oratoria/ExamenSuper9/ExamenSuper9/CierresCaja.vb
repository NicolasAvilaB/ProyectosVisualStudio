Public Class CierresCaja

    Private Sub CierresCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llena()
        Consulta("Call MostrarCierres('" & (Entrada.TxtUsuarios.Text) & "')")

        GrillaCierres.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    Sub llena()
        Consulta("select * from usuarios")
        For Each fila As DataRow In DT.Rows
            Cajeros.Items.Add(fila("N_Cajero"))
        Next
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        If (Cajeros.SelectedIndex = -1) Then
            Consulta("select * from cierrecaja where   fecha >= '" & Format(DateTimePicker1.Value.Date.ToString) & _
           "' and fecha <= '" & Format(DateTimePicker2.Value.Date.ToString) & "' ")

            GrillaCierres.DataSource = DS.Tables(DT.TableName)

        ElseIf (Cajeros.SelectedIndex.ToString()) Then
            Consulta("select * from cierrecaja where   fecha >= '" & Format(DateTimePicker1.Value.Date.ToString) & _
            "' and fecha <= '" & Format(DateTimePicker2.Value.Date.ToString) & "' and cajero = '" & (Cajeros.Text) & "' ")

            GrillaCierres.DataSource = DS.Tables(DT.TableName)

        Else
            Consulta("select * from cierrecaja where   fecha >= '" & Format(DateTimePicker1.Value.Date.ToString) & _
            "' and fecha <= '" & Format(DateTimePicker2.Value.Date.ToString) & "' ")

            GrillaCierres.DataSource = DS.Tables(DT.TableName)
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If (Cajeros.SelectedIndex = -1) Then
            Consulta("select * from cierrecaja where   fecha >= '" & Format(DateTimePicker1.Value.Date.ToString) & _
           "' and fecha <= '" & Format(DateTimePicker2.Value.Date.ToString) & "' ")

            GrillaCierres.DataSource = DS.Tables(DT.TableName)

        ElseIf (Cajeros.SelectedIndex.ToString()) Then
            Consulta("select * from cierrecaja where   fecha >= '" & Format(DateTimePicker1.Value.Date.ToString) & _
            "' and fecha <= '" & Format(DateTimePicker2.Value.Date.ToString) & "' and cajero = '" & (Cajeros.Text) & "' ")

            GrillaCierres.DataSource = DS.Tables(DT.TableName)

        Else
            Consulta("select * from cierrecaja where   fecha >= '" & Format(DateTimePicker1.Value.Date.ToString) & _
            "' and fecha <= '" & Format(DateTimePicker2.Value.Date.ToString) & "' ")

            GrillaCierres.DataSource = DS.Tables(DT.TableName)
        End If
    End Sub

    Private Sub Cajeros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cajeros.SelectedIndexChanged
        If (Cajeros.SelectedIndex = -1) Then
            Consulta("select * from cierrecaja where   fecha >= '" & Format(DateTimePicker1.Value.Date.ToString) & _
           "' and fecha <= '" & Format(DateTimePicker2.Value.Date.ToString) & "' ")

            GrillaCierres.DataSource = DS.Tables(DT.TableName)

        ElseIf (Cajeros.SelectedIndex.ToString()) Then
            Consulta("select * from cierrecaja where   fecha >= '" & Format(DateTimePicker1.Value.Date.ToString) & _
            "' and fecha <= '" & Format(DateTimePicker2.Value.Date.ToString) & "' and cajero = '" & (Cajeros.Text) & "' ")

            GrillaCierres.DataSource = DS.Tables(DT.TableName)

        Else
            Consulta("select * from cierrecaja where   fecha >= '" & Format(DateTimePicker1.Value.Date.ToString) & _
            "' and fecha <= '" & Format(DateTimePicker2.Value.Date.ToString) & "' ")

            GrillaCierres.DataSource = DS.Tables(DT.TableName)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.GrillaCierres.Rows.Count = 0 Then
            MsgBox("Error: No Hay Datos, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
            Try
                Consulta("Delete from cierrecaja")


            Catch ex As Exception
                Consulta("Call MostrarCierres")
            End Try

        End If


        If DS.Tables(DT.TableName).Rows.Count > 0 Then

        Else

        End If

        GrillaCierres.DataSource = DS.Tables(DT.TableName)
    End Sub
    Private Sub GrillaCierres_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaCierres.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Usuarios9.Admin.Focus()
        Usuarios9.Show()
    End Sub
End Class