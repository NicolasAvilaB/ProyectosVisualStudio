Imports System.IO
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim swEscritor As StreamWriter
        swEscritor = New StreamWriter("c:/Archivos/NOTAS.txt")

        swEscritor.WriteLine("Primera Linea del NUevo Comienzo")
        swEscritor.WriteLine("Segunda Linea de Escritura")

        swEscritor.Write("Juan y Maria")
        swEscritor.Write("Se van de Luna de Miel")
        swEscritor.Write(swEscritor.NewLine)
        swEscritor.WriteLine("Con esta Linea se Cierra el Block de Notas")

        swEscritor.Close()
        MsgBox("Datos Creados Exitosamente")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim swEscritor As StreamWriter
        swEscritor = New StreamWriter("c:/Archivos/NOTAS.txt", True)

        swEscritor.Write(swEscritor.NewLine)
        swEscritor.WriteLine("Nueva Linea")

        swEscritor.Flush()
        swEscritor.Close()

        MsgBox("Texto Agregado")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim srLector As StreamReader = New StreamReader("c:/Archivos/NOTAS.txt")
        Dim Linea As String
        Linea = srLector.ReadLine()
        TextBox1.Text = Linea
        srLector.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim srLector As StreamReader = New StreamReader("c:/Archivos/NOTAS.txt")
        Dim Linea As String
        Linea = srLector.ReadLine()
        Linea = srLector.ReadLine()
        TextBox1.Text = Linea
        srLector.Close()



    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim srLector As StreamReader = New StreamReader("c:/Archivos/NOTAS.txt")
        Dim Texto As String
        Texto = srLector.ReadToEnd()
        TextBox1.Text = Texto
        srLector.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim swEscritor As StreamWriter
        swEscritor = New StreamWriter("c:/Archivos/NOTAS.txt", False)
        swEscritor.Close()
        MsgBox("Texto Eliminado Correctamente")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Clear()

        Dim srLector As StreamReader = New StreamReader("c:/Archivos/NOTAS.txt")
        Dim Linea As String
        Dim ContadorLin As Integer = 1
        Linea = srLector.ReadLine()
        Do While Not (Linea Is Nothing)
            TextBox1.Text = TextBox1.Text & "Linea:" & ContadorLin & _
                "->" & Linea & vbCrLf
            ContadorLin += 1
            Linea = srLector.ReadLine()
        Loop
        srLector.Close()
    End Sub
End Class
