Module Modulo_ValidaRut
    Public Function valida_rut(ByVal ci As String) As Boolean
        Dim cont, i, sum As Integer
        Dim car, digito, dig, rut As String
        Dim largo As Integer
        largo = Len(ci)
        cont = 2
        rut = Mid(ci, 1, largo - 2)
        digito = Mid(ci, largo, 1)

        For i = Len(rut) To 1 Step -1
            car = Mid(rut, i, 1)
            sum = sum + CInt(car) * cont
            cont = cont + 1
            If cont = 8 Then
                cont = 2
            End If
        Next
        dig = 11 - (sum Mod 11)
        If dig = 10 And UCase(digito) = "K" Then
            valida_rut = True
        ElseIf dig = 11 And digito = 0 Then
            valida_rut = True
        ElseIf CStr(dig) = digito Then
            valida_rut = True
        Else
            valida_rut = False
        End If
    End Function
End Module
