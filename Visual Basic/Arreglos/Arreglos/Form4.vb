Public Class Form4
    Dim Arreglo1(100) As Integer
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub BtnArreglo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArreglo.Click
        Dim Valor As Integer
        For i = 0 To txtCantidad.Text - 1
            Valor = InputBox("Valor Para Posicion:  " & i)
            Arreglo1(i) = i
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim suma As Integer
        For i = 0 To txtCantidad.Text - 1
            If Arreglo1(i) Mod 2 = 0 Then
                LtbNumeros.Items.Add(Arreglo1(i))
                suma += Arreglo1(i)
            End If
        Next
        txtSuma.Text = suma
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim suma2 As Integer
        For i = 0 To txtCantidad.Text - 1
            If Arreglo1(i) Mod 2 <> 0 Then
                ListBox1.Items.Add(Arreglo1(i))
                suma2 += Arreglo1(i)
            End If
            txtSuma2.Text = suma2
        Next
    End Sub
End Class






