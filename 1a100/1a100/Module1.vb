Module Module1
    Sub Main()
        Dim a As Integer
        Console.WriteLine("Ingresa tu Numero ANTONIA")
        a = UInt64.Parse(Console.ReadLine())
        Console.WriteLine("")
        For i = 1 To a
            Console.WriteLine(i)
        Next

        Console.ReadLine()
    End Sub
End Module
