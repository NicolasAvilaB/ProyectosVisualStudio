Public Class VentasDia
    Dim Vall1 As Integer
    Private Sub VentasDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Consulta("Call MostrarVentas('" & (Entrada.TxtUsuarios.Text) & "')")

        GrillaVentas.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
        Suma1.Text = 0
        For i = 0 To GrillaVentas.Rows.Count - 1
            Suma1.Text += GrillaVentas.Item(2, i).Value
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Usuarios9.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.GrillaVentas.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
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
End Class