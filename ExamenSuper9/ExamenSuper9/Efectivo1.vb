Public Class Efectivo1
    Dim resta As Integer
    Dim resta2 As Integer


    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
        EmitirBoletas.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Efectivo1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (EmitirBoletas.Total_Pagar.Text = "") Then
            TotalVenta.Text = Modulo_Traspaso_Valores_Formulario.subto
        Else
            TotalVenta.Text = Modulo_Traspaso_Valores_Formulario.totalpagar
        End If
        
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        If (Pago.Text = "") Then
            MsgBox("Error: Escriba el Valor de dinero al Cual el Cliente Pagara su Compra", vbCritical, "Error Fatal")
        ElseIf (Convert.ToInt32(Pago.Text) < Convert.ToInt32(TotalVenta.Text)) Then
            resta2 = Convert.ToInt32(Pago.Text) - Convert.ToInt32(TotalVenta.Text)

            MsgBox("Al Cliente le Falta: " & resta2 & " Para Concretar la Venta", vbCritical, "Error Fatal")

        ElseIf (Convert.ToInt32(Pago.Text) > Convert.ToInt32(TotalVenta.Text)) Then
            resta = Convert.ToInt32(Pago.Text) - Convert.ToInt32(TotalVenta.Text)

            MsgBox("El Vuelto al Cliente Es: " & resta, vbInformation, "Vuelto del Cliente")
           
            Consulta("Call GrabarVenta ('" & (EmitirBoletas.N_Boleta.Text) & "','" & (EmitirBoletas.Fecha.Text) & "','" & (TotalVenta.Text) & "','" & (Entrada.TxtUsuarios.Text) & "','" & (EmitirBoletas.hora.Text) & "')")
            TotalVenta.Clear()
            Pago.Clear()
            Me.Close()
            EmitirBoletas.Close()
            EmitirBoletas.Show()
        End If
    End Sub
End Class