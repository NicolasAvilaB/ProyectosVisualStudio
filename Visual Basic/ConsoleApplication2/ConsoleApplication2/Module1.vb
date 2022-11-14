Module Module1

    Sub Main()
        Console.WriteLine("Ingrese un Numero")
        Dim num1 As String = Console.ReadLine()
        Console.WriteLine("Ingrese un Numero")
        Dim num2 As String = Console.ReadLine()
        sumar(num1, num2)
        restar(num1, num2)
        multiplicaciones(num1, num2)
        divisiones(num1, num2)
        Console.ReadLine()
    End Sub

    Private Sub sumar(ByVal n1 As Integer, ByVal n2 As Integer)
        Dim sum As Integer = n1 + n2
        Console.WriteLine("El Resultado de la Suma es: {0} ", sum)
    End Sub

    Private Sub restar(ByVal n1 As Integer, ByVal n2 As Integer)
        Dim res As Integer = n1 - n2
        Console.WriteLine("El Resultado de la Resta es: {0} ", res)
    End Sub
    Private Sub multiplicaciones(ByVal n1 As Integer, ByVal n2 As Integer)
        Dim mult As Integer = n1 * n2
        Console.WriteLine("El Resultado de la Multiplicar es: {0} ", mult)
    End Sub
    Private Sub divisiones(ByVal n1 As Integer, ByVal n2 As Integer)
        Dim div As Integer = n1 / n2
        Console.WriteLine("El Resultado de la Division es: {0} ", div)
    End Sub
End Module
