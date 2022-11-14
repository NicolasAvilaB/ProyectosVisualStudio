Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim i As Integer

        For i = txtInicio.Text To txtTermino.Text

            If txtInicio.Text Mod 2 = 0 Then
                ListBox1.Items.Add(i)
            Else
                ListBox2.Items.Add(i)

            End If
        Next


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim i As Integer = txtInicio.Text

        While i <= txtTermino.Text
            If txtInicio.Text Mod 2 = 0 Then
                ListBox1.Items.Add(i)
            Else
                ListBox2.Items.Add(i)

            End If
            i += 1
        End While
    End Sub
End Class
