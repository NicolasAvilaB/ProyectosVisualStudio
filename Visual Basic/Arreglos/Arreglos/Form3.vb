Public Class Form3

    Private Sub BtnArreglo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArreglo.Click
        Dim i As Integer
        Dim Arreglo1(txtCantidad.Text) As Integer
        Dim Valor As Integer
        Dim suma As Integer = 0
        For i = 0 To txtCantidad.Text - 1
            Valor = InputBox("Valor Para Posicion:  " & i)
            Arreglo1(i) = i

        Next
        
        For i = 0 To txtCantidad.Text - 1

            LtbNumeros.Items.Add(Arreglo1(i))
            suma += Arreglo1(i)
        Next
        txtSuma.Text = suma
    End Sub
End Class