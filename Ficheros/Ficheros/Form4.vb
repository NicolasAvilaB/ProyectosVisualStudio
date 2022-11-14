Imports System.IO
Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim swEscritor As StreamWriter
        If txtTexto.Text <> "" Then
            swEscritor = New StreamWriter("c:/Archivos/Notas3", True)
            swEscritor.WriteLine(txtTexto.Text)
            swEscritor.Flush()
            swEscritor.Close()

            txtTexto.Clear()
            txtTexto.Focus()

        Else
            MsgBox("Ingrese Nota")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim srLector3 As StreamReader = New StreamReader("c:/Archivos/Notas3")
        Dim Texto4 As String
        Texto4 = srLector3.ReadToEnd()
        ListBox1.Items.Add(Texto4)
        srLector3.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class