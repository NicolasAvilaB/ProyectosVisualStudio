Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Checked_todos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_Auto.CheckedChanged, Ch_Camion.CheckedChanged, Ch_Camioneta.CheckedChanged, Ch_Motocicleta.CheckedChanged

        ListBox1.Items.Clear()

        If Ch_Auto.Checked = True Then
            ListBox1.Items.Add("Automovil")
        End If

        If Ch_Camioneta.Checked = True Then
            ListBox1.Items.Add("Camioneta")
        End If

        If Ch_Camion.Checked = True Then
            ListBox1.Items.Add("Camion")
        End If

        If Ch_Motocicleta.Checked = True Then
            ListBox1.Items.Add("Motocicleta")
        End If

    End Sub
End Class
