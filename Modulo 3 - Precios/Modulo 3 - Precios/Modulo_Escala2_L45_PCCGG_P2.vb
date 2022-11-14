Module Modulo_Escala2_L45_PCCGG_P2
    Dim valorprecio As Long
    Sub calculo_escala2_parte2()
        'escala 2
        For Each row As DataGridViewRow In Cotizador.Tabla_Nota.Rows
            'primera fila
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'decima novena fila
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2701" And CStr(row.Cells(4).Value) <= "2800") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2701") & "','" & ("2800") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'vecina fila
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2801" And CStr(row.Cells(4).Value) <= "2900") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2801") & "','" & ("2900") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'vecina una fila
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2901" And CStr(row.Cells(4).Value) <= "3000") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2901") & "','" & ("3000") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'vecina dos fila
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3001" And CStr(row.Cells(4).Value) <= "3100") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3001") & "','" & ("3100") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'vecina tres fila
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3101" And CStr(row.Cells(4).Value) <= "3200") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3101") & "','" & ("3200") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'vecina cuarta fila
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3201" And CStr(row.Cells(4).Value) <= "3300") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3201") & "','" & ("3300") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'vecina quinta fila
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3301" And CStr(row.Cells(4).Value) <= "3400") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3301") & "','" & ("3400") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'vecina sexta fila
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("3500") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3401" And CStr(row.Cells(4).Value) <= "3500") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3401") & "','" & ("3500") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'vecina septima fila
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3501" And CStr(row.Cells(4).Value) <= "3600") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3501") & "','" & ("3600") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'vecina octava fila
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3601" And CStr(row.Cells(4).Value) <= "3700") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3601") & "','" & ("3700") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'vecina novena fila
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3701") & "','" & ("3800") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'treinta fila
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3801") & "','" & ("3900") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'treinta una fila
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("3901") & "','" & ("4000") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If


            'treinta dos fila
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4001") & "','" & ("4100") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'treinta tres fila
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4101") & "','" & ("4200") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'treinta cuarta fila
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4201") & "','" & ("4300") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'treinta quinta fila
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4301") & "','" & ("4400") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'treinta sexta fila
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("4401") & "','" & ("4500") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
        Next
    End Sub
End Module
