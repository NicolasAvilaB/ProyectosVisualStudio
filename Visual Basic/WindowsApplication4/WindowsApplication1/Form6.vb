Public Class Form6

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim I As Integer
        ListBox1.Items.Clear()

        For I = 1 To txtTermino.Text Step txtInicio.Text
            ListBox1.Items.Add(I)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim I As Integer = txtInicio.Text

        ListBox1.Items.Clear()

        While I <= txtTermino.Text
            ListBox2.Items.Add(I)
            I += 1

        End While
    End Sub
End Class