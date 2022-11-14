Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim I As Integer
        txtSerie.Clear()

        For I = 1 To txtInicio.Text Step txtSaltos.Text()
            txtSerie.Text = txtSerie.Text & " " & I
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim I As Integer = txtInicio.Text

        txtSerie.Clear()

        While I <= txtTermino.Text
            txtSerie.Text = txtSerie.Text & " " & I
            I += txtSaltos.Text


        End While
    End Sub
End Class