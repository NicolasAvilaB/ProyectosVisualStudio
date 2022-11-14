Imports System.IO
Public Class Form2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim swEscritor As StreamWriter
        If txtNOta.Text <> "" Then
            swEscritor = New StreamWriter("c:/Archivos/Notas2", True)
            swEscritor.WriteLine(txtNOta.Text)
            swEscritor.Flush()
            swEscritor.Close()

            txtNOta.Clear()
            txtNOta.Focus()

        Else
            MsgBox("Ingrese Nota")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim srLector As StreamReader = New StreamReader("c:/Archivos/Notas2")
        Dim linea As Integer
        Dim Texto2 As String
        Dim suma As Integer

        Texto2 = srLector.ReadLine()

        Do While Not (Texto2 Is Nothing)
            ListBox1.Items.Add(Texto2)
            suma += Texto2
            linea += 1
            Texto2 = srLector.ReadLine()
        Loop
        txtPromedio.Text = suma / linea
        srLector.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim swEscritor As StreamWriter
        txtPromedio.Clear()

        ListBox1.Items.Clear()
        swEscritor = New StreamWriter("c:/Archivos/Notas2", False)
        swEscritor.Close()
        MsgBox("Texto Eliminado Correctamente")
    End Sub

    Private Sub txtPromedio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPromedio.TextChanged

    End Sub
End Class