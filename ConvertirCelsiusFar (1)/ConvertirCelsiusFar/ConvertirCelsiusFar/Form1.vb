Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim g As Double
        g = TextBox1.Text
        If (ComboBox1.SelectedIndex = 0) Then
            TextBox2.Text = Trim(g * (9 / 5) + 32) + "  ºF"
        Else
            TextBox2.Text = Trim((g - 32) * (5 / 9)) + "  ºC"
        End If
    End Sub
End Class
