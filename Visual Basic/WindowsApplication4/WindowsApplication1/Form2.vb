Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim I As Integer = 1
        txtSerie.Clear()

        While I <= txtNumero.Text
            txtSerie.Text = txtSerie.Text & " " & I
            I += 1
        End While

    End Sub
End Class