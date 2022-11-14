Module Module1
    Sub Main()
        NumMayor()
        COndicionLogico()
        Console.ReadLine()
    End Sub
    Private Sub NumMayor()

        Console.WriteLine("Ingrese Numeros")
        Dim num1 As Integer = Console.ReadLine
        Dim num2 As Integer = Console.ReadLine

        If num1 < num2 Then
            Console.WriteLine("El Numero 1 es Menor al NUmero 2")
        ElseIf num2 < num1 Then
            Console.WriteLine("El Numero 2 es Mayor al NUmero 1")
        Else
            Console.WriteLine("Hay Igualdad")
        End If

    End Sub
    Sub CondicionLogico()

        Console.Write("Ingrese Numero = ")
        Dim num As Integer = Console.ReadLine

        If num > 0 And num < 50 Then
            Console.WriteLine("El Numero es Mayor que 0 y Menor que 50")
        ElseIf num >= 50 Or num <= 100 Then
            Console.WriteLine("El Numero es Mayor o igual que 50 y Menor o igual que 100")
        End If

    End Sub
End Module
