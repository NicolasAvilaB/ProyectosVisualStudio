VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "ClsMonedaALetras"
Attribute VB_GlobalNameSpace = True
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Private ooOOo As Double
Private ooOOoOUxxx As Boolean
Function olpol(OOOoooOOOooooOOOOOOOo) As String
  If OOOoooOOOooooOOOOOOOo >= 1000000000 Then   'CIFRA TOPE : 999999999.99
     Exit Function
  End If
  ooOOo = OOOoooOOOooooOOOOOOOo
  Select Case OOOoooOOOooooOOOOOOOo
    Case 1000000 To 999999999.99
         olpol = leemillon() & leecienmil() & leecien()
    Case 1000 To 999999.99
         olpol = leecienmil() & leecien()
    Case 1 To 999.99
         olpol = leecien()
    Case 0.01 To 0.99
         olpol = Str(OOOoooOOOooooOOOOOOOo * 100) & "/100"
  End Select
End Function
Private Function leemillon() As String
  Dim Vnum
  Select Case ooOOo
     Case 1000000 To 9999999.99
          Vnum = Left(Str(ooOOo), 2)
     Case 10000000 To 99999999.99
          Vnum = Left(Str(ooOOo), 3)
     Case 100000000 To 999999999.99
          Vnum = Left(Str(ooOOo), 4)
  End Select
  ooOOo = ooOOo - CDbl(Vnum & "000000")
  If Vnum = 1 Then
     leemillon = "un millón "
  Else
     leemillon = LeeCentena(CLng(Vnum)) & " Millones "
  End If
End Function
Private Function leecienmil() As String
  Dim Vnum
  Select Case ooOOo
     Case 1000 To 9999.99
          Vnum = Left(Str(ooOOo), 2)
     Case 10000 To 99999.99
          Vnum = Left(Str(ooOOo), 3)
     Case 100000 To 999999.99
          Vnum = Left(Str(ooOOo), 4)
  End Select
  ooOOo = ooOOo - CDbl(Vnum & "000")
  If Vnum > 0 Then
     leecienmil = LeeCentena(CLng(Vnum)) & " Mil "
  End If
End Function
Private Function leecien() As String
  Dim Vnum
  ooOOoOUxxx = True
  Select Case ooOOo
     Case 1 To 9.99
          Vnum = Left(Str(ooOOo), 2)
     Case 10 To 99.99
          Vnum = Left(Str(ooOOo), 3)
     Case 100 To 999.99
          Vnum = Left(Str(ooOOo), 4)
  End Select
  ooOOo = ooOOo - CDbl(Vnum)
  leecien = LeeCentena(CLng(Vnum)) + leecentavos()
  ooOOoOUxxx = False
End Function
Private Function LeeCentena(Vnumero) As String
  If Vnumero >= 100 Then
       Select Case Vnumero
         Case 900 To 999
            If Vnumero = 900 Then
               LeeCentena = "Novecientos "
            Else
               LeeCentena = "Novecientos " & lolololo(Vnumero - 900)
            End If
         Case 800 To 899
            If Vnumero = 800 Then
               LeeCentena = "Ochocientos "
            Else
               LeeCentena = "Ochocientos " & lolololo(Vnumero - 800)
            End If
         Case 700 To 799
            If Vnumero = 700 Then
               LeeCentena = "Setecientos "
            Else
               LeeCentena = "Setecientos " & lolololo(Vnumero - 700)
            End If
         Case 600 To 699
            If Vnumero = 600 Then
               LeeCentena = "seiscientos "
            Else
               LeeCentena = "Seiscientos " & lolololo(Vnumero - 600)
            End If
         Case 500 To 599
            If Vnumero = 500 Then
               LeeCentena = "Quinientos "
            Else
               LeeCentena = "Quinientos " & lolololo(Vnumero - 500)
            End If
         Case 400 To 499
            If Vnumero = 400 Then
               LeeCentena = "Cuatrocientos "
            Else
               LeeCentena = "Cuatrocientos " & lolololo(Vnumero - 400)
            End If
         Case 300 To 399
            If Vnumero = 300 Then
               LeeCentena = "trescientos "
            Else
               LeeCentena = "Trescientos " & lolololo(Vnumero - 300)
            End If
         Case 200 To 299
            If Vnumero = 200 Then
               LeeCentena = "Doscientos "
            Else
               LeeCentena = "Doscientos " & lolololo(Vnumero - 200)
            End If
         Case 100 To 199
            If Vnumero = 100 Then
               LeeCentena = "Cien "
            Else
               LeeCentena = "Ciento " & lolololo(Vnumero - 100)
            End If
         End Select
    Else
          LeeCentena = lolololo(Vnumero)
  End If
End Function
Private Function lolololo(Vnum) As String
  If Vnum >= 10 Then
     Select Case Vnum
        Case 90 To 99
            If Vnum = 90 Then
               lolololo = "Noventa "
            Else
               lolololo = "Noventa y " & OoOoOoooooOOOO(Vnum - 90)
            End If
         Case 80 To 89
            If Vnum = 80 Then
               lolololo = "Ochenta "
            Else
               lolololo = "Ochenta y " & OoOoOoooooOOOO(Vnum - 80)
            End If
         Case 70 To 79
            If Vnum = 70 Then
               lolololo = "Setenta "
            Else
               lolololo = "Setenta y " & OoOoOoooooOOOO(Vnum - 70)
            End If
         Case 60 To 69
            If Vnum = 60 Then
               lolololo = "Sesenta "
            Else
               lolololo = "Sesenta Y " & OoOoOoooooOOOO(Vnum - 60)
            End If
         Case 50 To 59
            If Vnum = 50 Then
               lolololo = "Cincuenta "
            Else
               lolololo = "Cincuenta Y " & OoOoOoooooOOOO(Vnum - 50)
            End If
         Case 40 To 49
            If Vnum = 40 Then
               lolololo = "Cuarenta "
            Else
               lolololo = "Cuarenta Y " & OoOoOoooooOOOO(Vnum - 40)
            End If
         Case 30 To 39
            If Vnum = 30 Then
               lolololo = "Treinta "
            Else
               lolololo = "Treinta Y " & OoOoOoooooOOOO(Vnum - 30)
            End If
         Case 20 To 29
            If Vnum = 20 Then
               lolololo = "Veinte "
            Else
               lolololo = "Veinti" & OoOoOoooooOOOO(Vnum - 20)
            End If
         Case 10 To 19
              Select Case Vnum
                    Case Is = 10
                        lolololo = "Diez "
                    Case Is = 11
                        lolololo = "Once "
                    Case Is = 12
                        lolololo = "Doce "
                    Case Is = 13
                        lolololo = "Trece "
                    Case Is = 14
                        lolololo = "Catorce "
                    Case Is = 15
                        lolololo = "Quince "
                    Case Is = 16
                        lolololo = "Dieciseis "
                    Case Is = 17
                        lolololo = "Diecisiete "
                    Case Is = 18
                        lolololo = "Dieciocho "
                    Case Is = 19
                        lolololo = "Diecinueve "
                End Select
          End Select
    Else
        lolololo = OoOoOoooooOOOO(Vnum)
  End If
End Function
Private Function OoOoOoooooOOOO(VNumUnidad) As String
  Select Case VNumUnidad
      Case Is = 9
         OoOoOoooooOOOO = "Nueve"
      Case Is = 8
         OoOoOoooooOOOO = "Ocho"
      Case Is = 7
         OoOoOoooooOOOO = "Siete"
      Case Is = 6
         OoOoOoooooOOOO = "Seis"
      Case Is = 5
         OoOoOoooooOOOO = "Cinco"
      Case Is = 4
         OoOoOoooooOOOO = "Cuatro"
      Case Is = 3
         OoOoOoooooOOOO = "Tres"
      Case Is = 2
         OoOoOoooooOOOO = "Dos"
      Case Is = 1
         If ooOOoOUxxx = False Then
           OoOoOoooooOOOO = "Un"
         Else
           OoOoOoooooOOOO = "Uno"
         End If
  End Select
End Function
Private Function leecentavos() As String
  Dim VDecimales As Long
  VDecimales = ooOOo * 100
  If VDecimales > 0 Then
      leecentavos = " Con " & Format$(VDecimales, "##0") & "/100"
  Else
      leecentavos = " Con " & "00/100"
  End If
End Function
