Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim neto1 As Integer
    Dim iva1 As Integer
    Dim total1 As Integer
    Dim desc1 As Integer


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        If (Desc.Text = "8") Then

            neto1 = Convert.ToInt64(Neto.Text) / 1.1899999999999999
            iva1 = Neto.Text - neto1
            total1 = iva1 + neto1
            desc1 = total1 * 0.080000000000000002


            Neto.Text = neto1
            Iva.Text = iva1
            Total.Text = desc1

        ElseIf (Desc.Text = "10") Then

            neto1 = Convert.ToInt64(Neto.Text) / 1.1899999999999999
            iva1 = Neto.Text - neto1
            total1 = iva1 + neto1
            desc1 = total1 * 0.10000000000000001


            Neto.Text = neto1
            Iva.Text = iva1
            Total.Text = desc1

        ElseIf (Desc.Text = "12") Then

            neto1 = Convert.ToInt64(Neto.Text) / 1.1899999999999999
            iva1 = Neto.Text - neto1
            total1 = iva1 + neto1
            desc1 = total1 * 0.12


            Neto.Text = neto1
            Iva.Text = iva1
            Total.Text = desc1


        End If
    End Sub
End Class