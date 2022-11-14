Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim I As Integer
        txtSerie.Clear()

        For I = 1 To txtInicio.Text Step txtTermino.Text
            txtSerie.Text = txtSerie.Text & " " & I
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim I As Integer = txtTermino.Text

        txtSerie.Clear()

        While I <= txtInicio.Text
            txtSerie.Text = txtSerie.Text & " " & I
            I += 1
        End While
    End Sub
End Class