Module Module1

    Sub Main()
        Console.WriteLine("Primer Numero")
        Dim n1 As String = Console.ReadLine()
        Console.WriteLine("Primer Numero")
        Dim n2 As String = Console.ReadLine()
        Console.WriteLine("Resultado suma")
        sum(n1, n2)
        Console.WriteLine("Resultado resta")
        resta(n1, n2)
        Console.WriteLine("Resultado multiplicacion")
        multiplicacion(n1, n2)
        Console.WriteLine("Resultado division")
        division(n1, n2)
        Console.ReadLine()
    End Sub

    Private Sub sum(ByVal n1 As String, ByVal n2 As String)
        Dim suma As Integer = Int(n1) + Int(n2)
        Console.WriteLine(suma)
    End Sub
    Private Sub resta(ByVal n1 As String, ByVal n2 As String)
        Dim res As Integer = Int(n1) - Int(n2)
        Console.WriteLine(res)
    End Sub
    Private Sub multiplicacion(ByVal n1 As String, ByVal n2 As String)
        Dim mult As Integer = Int(n1) * Int(n2)
        Console.WriteLine(mult)
    End Sub
    Private Sub division(ByVal n1 As String, ByVal n2 As String)
        Dim div As Integer = Int(n1) / Int(n2)
        Console.WriteLine(div)
    End Sub
End Module
