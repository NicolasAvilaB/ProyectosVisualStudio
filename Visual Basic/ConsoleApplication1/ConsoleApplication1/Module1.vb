Module Module1

    Sub Main()
        mensaje()
        Console.ReadLine()
    End Sub

    Private Sub mensaje()
        Console.WriteLine("hOLA, iNGRESE NOMBRE")
        Dim nombre As String = Console.ReadLine()
        tunombre(nombre)
    End Sub

    Private Sub tunombre(ByVal minombre As String)
        Console.WriteLine(minombre)
    End Sub


End Module
