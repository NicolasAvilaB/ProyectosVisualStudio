Public Class VentasDia
    Dim Vall1 As Integer
    Dim Fechini As String
    Dim Fechfin As String


    Private Sub VentasDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llena()
        Consulta("Call MostrarVentas('" & (Entrada.TxtUsuarios.Text) & "')")

        GrillaVentas.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
        Vall1 = 0
        Timer1.Enabled = True
        Timer1.Interval = 100


    End Sub
    Sub llena()
        Consulta("select * from usuarios")
        For Each fila As DataRow In DT.Rows
            Cajeros.Items.Add(fila("N_Cajero"))
        Next
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Usuarios9.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.GrillaVentas.Rows.Count = 0 Then
            MsgBox("Error: No Hay Datos, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
            Try
                Consulta("Delete from ventas")
                Suma1.Clear()

            Catch ex As Exception
                Consulta("Call MostrarVentas")
            End Try

        End If


        If DS.Tables(DT.TableName).Rows.Count > 0 Then

        Else

        End If

        GrillaVentas.DataSource = DS.Tables(DT.TableName)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Vall1 = Vall1 + 1


        Dim suma As Integer = 0.0

        For Each row As DataGridViewRow In GrillaVentas.Rows
            suma += Val(row.Cells(2).Value)

        Next

        Suma1.Text = Convert.ToInt32(suma)
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If (Cajeros.SelectedIndex = -1) Then
            Consulta("select * from ventas where   fecha between '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "' ")

            GrillaVentas.DataSource = DS.Tables(DT.TableName)

        ElseIf (Cajeros.SelectedIndex.ToString()) Then
            Consulta("select * from ventas where   fecha between '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "' and cajero = '" & (Cajeros.Text) & "' ")

            GrillaVentas.DataSource = DS.Tables(DT.TableName)

        Else
            Consulta("select * from ventas where   fecha between '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "' ")

            GrillaVentas.DataSource = DS.Tables(DT.TableName)
        End If
    End Sub


    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If (Cajeros.SelectedIndex = -1) Then
            Consulta("select * from ventas where   fecha between '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "' ")

            GrillaVentas.DataSource = DS.Tables(DT.TableName)

        ElseIf (Cajeros.SelectedIndex.ToString()) Then
            Consulta("select * from ventas where   fecha between '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "' and cajero = '" & (Cajeros.Text) & "' ")

            GrillaVentas.DataSource = DS.Tables(DT.TableName)

        Else
            Consulta("select * from ventas where   fecha between '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "' ")

            GrillaVentas.DataSource = DS.Tables(DT.TableName)
        End If
    End Sub

    Private Sub Cajeros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cajeros.SelectedIndexChanged
       If (Cajeros.SelectedIndex = -1) Then
            Consulta("select * from ventas where   fecha between '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "' ")

            GrillaVentas.DataSource = DS.Tables(DT.TableName)

        ElseIf (Cajeros.SelectedIndex.ToString()) Then
            Consulta("select * from ventas where   fecha between '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "' and cajero = '" & (Cajeros.Text) & "' ")

            GrillaVentas.DataSource = DS.Tables(DT.TableName)

        Else
            Consulta("select * from ventas where   fecha between '" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd/MM/yyyy") & "' ")

            GrillaVentas.DataSource = DS.Tables(DT.TableName)
        End If
    End Sub


    Private Sub GrillaVentas_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaVentas.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

End Class