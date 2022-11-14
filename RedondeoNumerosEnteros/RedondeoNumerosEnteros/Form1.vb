Public Class Form1
    Dim d1, d2, d3, d4, d5, d6, d7, d8

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        redondeo1_ancho_crece_con_medidas_bajo_1000()
    End Sub
    Sub redondeo1_ancho_crece_con_medidas_bajo_1000()
        d1 = Val(Mid(TextBox2.Text, 1, 1))
        d2 = Val(Mid(TextBox2.Text, 2, 1))
        d3 = Val(Mid(TextBox2.Text, 3, 1))
        If (d2 = 0 And d3 >= 1) Then
            TextBox2.Text = d1 & d2 + 6 & d3
        ElseIf (d2 = 1)
            TextBox2.Text = d1 & d2 + 5 & d3
        ElseIf (d2 = 2)
            TextBox2.Text = d1 & d2 + 4 & d3
        ElseIf (d2 = 3)
            TextBox2.Text = d1 & d2 + 3 & d3
        ElseIf (d2 = 4)
            TextBox2.Text = d1 & d2 + 2 & d3
        ElseIf (d2 = 5)
            TextBox2.Text = d1 & d2 + 1 & d3
        End If
        Dim numeroARedondear As Integer = TextBox2.Text
        Dim resultado As String = Val(Math.Round(numeroARedondear / 100) * 100)
        Label4.Text = resultado
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        d1 = Val(Mid(TextBox1.Text, 1, 1))
        d2 = Val(Mid(TextBox1.Text, 2, 1))
        d3 = Val(Mid(TextBox1.Text, 3, 1))
        d4 = Val(Mid(TextBox1.Text, 4, 1))
        If (d3 = 0 And d4 >= 1) Then
            TextBox1.Text = d1 & d2 & d3 + 6 & d4
        ElseIf (d3 = 1)
            TextBox1.Text = d1 & d2 & d3 + 5 & d4
        ElseIf (d3 = 2)
            TextBox1.Text = d1 & d2 & d3 + 4 & d4
        ElseIf (d3 = 3)
            TextBox1.Text = d1 & d2 & d3 + 3 & d4
        ElseIf (d3 = 4)
            TextBox1.Text = d1 & d2 & d3 + 2 & d4
        ElseIf (d3 = 5)
            TextBox1.Text = d1 & d2 & d3 + 1 & d4
        End If
        Dim numeroARedondear As Integer = TextBox1.Text
        Dim resultado As String = Val(Math.Round(numeroARedondear / 100) * 100)
        Label1.Text = resultado


    End Sub
End Class
