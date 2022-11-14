Public Class Form1
    Dim valor_rut, aux, DV As String
    Dim vrut, paso, suma, resto As Integer
    Dim divi As Double
    Dim d1, d2, d3, d4, d5, d6, d7, d8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (rut.Text = "00.000.000-0") Then
            MsgBox("Rut incorrecto", vbCritical, "error")
        Else
            valor_rut = rut.Text
            Label1.Text = valor_rut
            d1 = Val(Mid(valor_rut, 1, 1)) * 3
            d2 = Val(Mid(valor_rut, 2, 1)) * 2
            d3 = Val(Mid(valor_rut, 4, 1)) * 7
            d4 = Val(Mid(valor_rut, 5, 1)) * 6
            d5 = Val(Mid(valor_rut, 6, 1)) * 5
            d6 = Val(Mid(valor_rut, 8, 1)) * 4
            d7 = Val(Mid(valor_rut, 9, 1)) * 3
            d8 = Val(Mid(valor_rut, 10, 1)) * 2
            DV = Mid(valor_rut, 12, 1)
            suma = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8
            divi = Int(suma / 11)
            resto = suma - (divi * 11)
            aux = LTrim(Str(11 - resto))
            If (aux = 11) Then
                aux = "0"
            End If
            If (aux = 10) Then
                aux = "K"
            End If
            If (DV = aux) Or (DV = "k") Then
                MsgBox("Rut correcto", vbInformation, "error")
            Else
                MsgBox("Rut incorrecto", vbCritical, "error")
            End If
        End If

    End Sub
End Class
