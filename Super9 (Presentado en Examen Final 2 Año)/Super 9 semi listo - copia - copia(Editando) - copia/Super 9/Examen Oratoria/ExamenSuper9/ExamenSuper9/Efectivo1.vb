Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Public Class Efectivo1
    Dim resta As Integer
    Dim resta2 As Integer
    Dim total As Double = 0
    Dim orpt As New Boletas
    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
        EmitirBoletas.Show()
        EmitirBoletas.Agregue_Productos.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
    End Sub
    Private Sub Efectivo1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (EmitirBoletas.Total_Pagar.Text = "") Then
            TotalVenta.Text = Modulo_Traspaso_Valores_Formulario.subto
        Else
            TotalVenta.Text = Modulo_Traspaso_Valores_Formulario.totalpagar
        End If
        Muestre.Text = Letras(TotalVenta.Text)
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        If (Pago.Text = "") Then
            MsgBox("Error: Escriba el Valor de dinero al Cual el Cliente Pagara su Compra", vbCritical, "Error Fatal")
        ElseIf (Convert.ToInt64(Pago.Text) < Convert.ToInt64(TotalVenta.Text)) Then
            resta2 = Convert.ToInt64(Pago.Text) - Convert.ToInt64(TotalVenta.Text)

            MsgBox("Al Cliente le Falta: " & resta2 & " Para Concretar la Venta", vbCritical, "Error Fatal")
            Pago.Clear()
            Pago.Focus()
            Aceptar.Enabled = False
        ElseIf (Convert.ToInt64(Pago.Text) = Convert.ToInt64(TotalVenta.Text)) Then
            resta = Convert.ToInt64(Pago.Text) - Convert.ToInt64(TotalVenta.Text)

            MsgBox("No hay Vuelto, Gracias Por Su Compra", vbInformation, "Vuelto del Cliente")
            Consulta("Call GrabarVenta ('" & (EmitirBoletas.N_Boleta.Text) & "','" & (EmitirBoletas.Fecha.Text) & "','" & (TotalVenta.Text) & "','" & (Entrada.TxtUsuarios.Text) & "','" & (Now.ToLongTimeString) & "')")
            For Each row As DataGridViewRow In EmitirBoletas.Productos_Pasados.Rows


                Consulta("UPDATE productos SET cantidad = cantidad - '" & Val(row.Cells(3).Value) & "' WHERE codigo ='" & Val(row.Cells(0).Value) & "'")
            Next

            orpt.Load("Boletas.rpt")

            Dim NumeroDeboleta As String = EmitirBoletas.N_Boleta.Text
            Dim Subtotales As String = EmitirBoletas.Subtotal.Text
            Dim numerodedescuento As String = EmitirBoletas.NUm.Text
            Dim Too As String = TotalVenta.Text
            Dim Pagando As String = Pago.Text
            Dim nombrecajerante As String = Entrada.TxtUsuarios.Text

            orpt.ParameterFields("N_BOLETA").CurrentValues.Clear()

            orpt.SetParameterValue("N_BOLETA", NumeroDeboleta)

            orpt.ParameterFields("SUBTOTAL").CurrentValues.Clear()

            orpt.SetParameterValue("SUBTOTAL", Subtotales)

            orpt.ParameterFields("DESCUENTO").CurrentValues.Clear()

            orpt.SetParameterValue("DESCUENTO", numerodedescuento)

            orpt.ParameterFields("TOTAL").CurrentValues.Clear()

            orpt.SetParameterValue("TOTAL", Too)

            orpt.ParameterFields("PAGO_CLIENTE").CurrentValues.Clear()

            orpt.SetParameterValue("PAGO_CLIENTE", Pagando)

            orpt.ParameterFields("NOMBRE_CAJERO").CurrentValues.Clear()

            orpt.SetParameterValue("NOMBRE_CAJERO", nombrecajerante)





            For Each row As DataGridViewRow In EmitirBoletas.Productos_Pasados.Rows

                Consulta("select * from productos where nombre='" & Val(row.Cells(1).Value) & "'")

            Next
            orpt.SetDataSource(DS.Tables(DT.TableName))




            'orpt.PrintToPrinter(1, False, 0, 0)



            TotalVenta.Clear()
            Pago.Clear()
            Aceptar.Enabled = False
            Me.Close()
            EmitirBoletas.Close()
            EmitirBoletas.Show()
            EmitirBoletas.Agregue_Productos.Focus()
        ElseIf (Convert.ToInt64(Pago.Text) > Convert.ToInt64(TotalVenta.Text)) Then
                resta = Convert.ToInt64(Pago.Text) - Convert.ToInt64(TotalVenta.Text)

                MsgBox("El Vuelto al Cliente Es: " & resta, vbInformation, "Vuelto del Cliente")

                Consulta("Call GrabarVenta ('" & (EmitirBoletas.N_Boleta.Text) & "','" & (EmitirBoletas.Fecha.Text) & "','" & (TotalVenta.Text) & "','" & (Entrada.TxtUsuarios.Text) & "','" & (Now.ToLongTimeString) & "')")
                For Each row As DataGridViewRow In EmitirBoletas.Productos_Pasados.Rows

                    Consulta("UPDATE productos SET cantidad = cantidad - '" & Val(row.Cells(3).Value) & "' WHERE codigo ='" & Val(row.Cells(0).Value) & "'")
                Next

                orpt.Load("Boletas.rpt")

                Dim NumeroDeboleta As String = EmitirBoletas.N_Boleta.Text
                Dim Subtotales As String = EmitirBoletas.Subtotal.Text
                Dim numerodedescuento As String = EmitirBoletas.NUm.Text
                Dim Too As String = TotalVenta.Text
                Dim Pagando As String = Pago.Text
                Dim nombrecajerante As String = Entrada.TxtUsuarios.Text

                orpt.ParameterFields("N_BOLETA").CurrentValues.Clear()

                orpt.SetParameterValue("N_BOLETA", NumeroDeboleta)

                orpt.ParameterFields("SUBTOTAL").CurrentValues.Clear()

                orpt.SetParameterValue("SUBTOTAL", Subtotales)

                orpt.ParameterFields("DESCUENTO").CurrentValues.Clear()

                orpt.SetParameterValue("DESCUENTO", numerodedescuento)

                orpt.ParameterFields("TOTAL").CurrentValues.Clear()

                orpt.SetParameterValue("TOTAL", Too)

                orpt.ParameterFields("PAGO_CLIENTE").CurrentValues.Clear()

                orpt.SetParameterValue("PAGO_CLIENTE", Pagando)

                orpt.ParameterFields("NOMBRE_CAJERO").CurrentValues.Clear()

                orpt.SetParameterValue("NOMBRE_CAJERO", nombrecajerante)



            '   orpt.PrintToPrinter(1, False, 0, 0)

            TotalVenta.Clear()
                Pago.Clear()
                Aceptar.Enabled = False
                Me.Close()
                EmitirBoletas.Close()
                EmitirBoletas.Show()
                EmitirBoletas.Agregue_Productos.Focus()
        End If
    End Sub

    Private Sub Pago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Pago.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            Aceptar.Focus()
            Aceptar.Select()
            SendKeys.Send("{ENTER}")
        End If
    End Sub

    Private Sub Pago_TextChanged(sender As Object, e As EventArgs) Handles Pago.TextChanged
        If (Pago.Text = "") Then
            Aceptar.Enabled = False
        Else
            Aceptar.Enabled = True
        End If
    End Sub
End Class