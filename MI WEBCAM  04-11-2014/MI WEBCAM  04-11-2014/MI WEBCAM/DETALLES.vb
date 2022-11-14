Public Class DETALLES

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.WriteAllText("C:\MI WEBCAM\CARPETAS DETECCION\INFORME DETECCION.txt", TextBox1.Text, True)
        MsgBox("INFORME GUARDADO")
        Me.Close()
    End Sub
End Class