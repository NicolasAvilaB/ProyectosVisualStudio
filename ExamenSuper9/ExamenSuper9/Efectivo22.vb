Public Class Efectivo22
    Dim resta As Integer
    Dim resta2 As Integer
    Private Sub Efectivo22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalVenta2.Text = Modulo_Traspaso_Valores_Formulario.totalpagar
        TotalVenta2.Text = Modulo_Traspaso_Valores_Formulario.subto
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
        EmitirBoletas.Show()
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        If (Pago2.Text = "") Then
            MsgBox("Error: Escriba el Valor de dinero al Cual el Cliente Pagara su Compra", vbCritical, "Error Fatal")
        ElseIf (Convert.ToInt32(Pago2.Text) < Convert.ToInt32(TotalVenta2.Text)) Then
            resta2 = Convert.ToInt32(Pago2.Text) - Convert.ToInt32(TotalVenta2.Text)

            MsgBox("Al Cliente le Falta: " & resta2 & " Para Concretar la Venta", vbCritical, "Error Fatal")

        ElseIf (Convert.ToInt32(Pago2.Text) > Convert.ToInt32(TotalVenta2.Text)) Then
            resta = Convert.ToInt32(Pago2.Text) - Convert.ToInt32(TotalVenta2.Text)

            MsgBox("El Vuelto al Cliente Es: " & resta, vbInformation, "Vuelto del Cliente")
            Me.Close()
            TotalVenta2.Clear()
            Pago2.Clear()
            ModoPrueba.Close()
            ModoPrueba.Show()
        End If
    End Sub
End Class