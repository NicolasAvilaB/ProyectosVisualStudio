Public Class Form1

    Private Sub BtnArreglo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArreglo.Click
        Dim i As Integer
        Dim Arreglo1(txtCantidad.Text) As Integer

        For i = 0 To txtCantidad.Text - 1
            Arreglo1(i) = i
        Next

        For i = 0 To txtCantidad.Text - 1
            LtbNumeros.Items.Add(Arreglo1(i))
        Next

    End Sub
End Class
