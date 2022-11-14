Public Class Form2
    Sub Limpia()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Limpia()
        Dim i As Integer = 0

        For i = txtInicio.Text To txtTermino.Text Step txtSaltos.Text
            If i Mod 2 = 0 Then
                ListBox1.Items.Add(i)
            End If
            If i Mod 3 = 0 Then
                ListBox2.Items.Add(i)
            End If
            If i Mod 5 = 0 Then
                ListBox3.Items.Add(i)
            End If
            If i Mod 7 = 0 Then
                ListBox4.Items.Add(i)
            End If

        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Limpia()
        Dim i As Integer = txtTermino.Text

        While i <= txtTermino.Text
            If i Mod 2 = 0 Then
                ListBox1.Items.Add(i)
            End If
            If i Mod 3 = 0 Then
                ListBox2.Items.Add(i)
            End If
            If i Mod 5 = 0 Then
                ListBox3.Items.Add(i)
            End If
            If i Mod 7 = 0 Then
                ListBox4.Items.Add(i)
            End If
            i += txtSaltos.Text
        End While
    End Sub
End Class