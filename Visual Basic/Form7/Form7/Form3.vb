Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim i As Integer
        Dim sumaimpares As Integer = 0
        Dim sumapares As Integer = 0

        For i = txtInicio.Text To txtTermino.Text Step txtSaltos.Text

            If i Mod 2 = 0 Then
                sumapares += i
                txtSumaPares.Text = sumapares
            Else
                sumaimpares += i
                txtSumaImpares.Text = sumaimpares

            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer = txtInicio.Text
        Dim sumaimpares As Integer = 0
        Dim sumapares As Integer = 0

        While i = txtTermino.Text

            If i Mod 2 = 0 Then
                sumapares += i
                txtSumaPares.Text = sumapares
            Else
                sumaimpares += i
                txtSumaImpares.Text = sumaimpares

            End If
        End While
    End Sub
End Class
