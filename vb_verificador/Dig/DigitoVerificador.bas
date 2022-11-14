Attribute VB_Name = "DigitoVerificador"
'Permite ingresar los valores con comillas de miles y guion o sin ellos el digito
'tambien puede ser "k" o "K".
'Por ejemplo 11.111.111-0 o 111111110, 11111111k o 11111111K, reconoce cualquiera
'de estos formatos este es el sistema de verificación de rut para el país de Chile, no se
'si servirá para otros paises.
'Alexis email: alexis_marchant@yahoo.com

Option Explicit
Public I As Byte
Public Z As Byte
Public CadenaLimpiA As String
Public DiG As String
Public XXXX As Byte

Function RuT(CadenA As String) As Boolean

If CadenA <> Empty And Val(CadenA) <> 0 Then
    'Limpia Cadena
    For I = 1 To Len(CadenA)
        If (Mid(CadenA, I, 1)) = "-" Or (Mid(CadenA, I, 1)) = "." Then
            'pasa al siguiente espacio
        Else
            CadenaLimpiA = CadenaLimpiA + Mid(CadenA, I, 1)
        End If
    Next
    
    'Prepara Variables
    CadenA = CadenaLimpiA
    DiG = (Mid(CadenaLimpiA, (Len(CadenaLimpiA)), 1))
    If Asc(DiG) <= 47 Or Asc(DiG) >= 58 Then
        If DiG = "K" Or DiG = "k" Then
            DiG = "10"
        Else
           DiG = "12"
        End If
    End If
    
    CadenaLimpiA = Empty
    
    For I = 1 To (Len(CadenA) - 1)
        CadenaLimpiA = CadenaLimpiA + (Mid(CadenA, I, 1))
    Next
    
    CadenA = Empty
    I = Empty
    I = (Len(CadenaLimpiA))
    Z = 2
    While I <> 0
        If Z <> 8 Then
            CadenA = Val(CadenA) + (Val((Mid(CadenaLimpiA, I, 1))) * Z)
            Z = Z + 1
        Else
            Z = 2
            CadenA = Val(CadenA) + (Val((Mid(CadenaLimpiA, I, 1))) * Z)
            Z = Z + 1
        End If
        I = I - 1
    Wend
    
    
    Z = 11 - (Val(CadenA) - Int((Val(CadenA)) / 11) * 11)
    
    XXXX = Asc(DiG)
        If DiG = 0 And Z = 11 Then
            RuT = True
        Else
                If Z = DiG Then
                    RuT = True
                Else
                    RuT = False
                End If
        End If
Else
    RuT = False
End If
CadenA = Empty
CadenaLimpiA = Empty

End Function

