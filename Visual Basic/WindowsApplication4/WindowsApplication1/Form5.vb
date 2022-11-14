Public Class Form5

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim I As Integer
        txtSerie.Clear()

        For I = txtTermino.Text To txtInicio.Text Step -1
            txtSerie.Text = txtSerie.Text & " " & I
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim I As Integer = txtTermino.Text

        txtSerie.Clear()

        While I >= txtInicio.Text
            txtSerie.Text = txtSerie.Text & " " & I
            I -= 1
        End While
    End Sub
End Class