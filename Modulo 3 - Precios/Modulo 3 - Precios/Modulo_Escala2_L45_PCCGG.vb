Module Modulo_Escala2_L45_PCCGG
    Dim valorprecio As Long
    Sub calculo_escala2()
        'escala 2
        For Each row As DataGridViewRow In Cotizador.Tabla_Nota.Rows
            'primera fila
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "0001" And CStr(row.Cells(4).Value) <= "1000") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("0001") & "','" & ("1000") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'segunda fila
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1001" And CStr(row.Cells(4).Value) <= "1100") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1001") & "','" & ("1100") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'tercera fila
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1101" And CStr(row.Cells(4).Value) <= "1200") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1101") & "','" & ("1200") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If


            'cuarta fila
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1201" And CStr(row.Cells(4).Value) <= "1300") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1201") & "','" & ("1300") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'quinta fila
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1301" And CStr(row.Cells(4).Value) <= "1400") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1301") & "','" & ("1400") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'sexta fila
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1401" And CStr(row.Cells(4).Value) <= "1500") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1401") & "','" & ("1500") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'septima fila
            'septima fila
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1501" And CStr(row.Cells(4).Value) <= "1600") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1501") & "','" & ("1600") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'octava fila
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1601" And CStr(row.Cells(4).Value) <= "1700") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1601") & "','" & ("1700") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'novena fila
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1701" And CStr(row.Cells(4).Value) <= "1800") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1701") & "','" & ("1800") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'decima fila
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1801" And CStr(row.Cells(4).Value) <= "1900") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1801") & "','" & ("1900") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'decima una fila
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "1901" And CStr(row.Cells(4).Value) <= "2000") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("1901") & "','" & ("2000") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If


            'decima dos fila
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2001" And CStr(row.Cells(4).Value) <= "2100") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2001") & "','" & ("2100") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'decima tres fila
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2101" And CStr(row.Cells(4).Value) <= "2200") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2101") & "','" & ("2200") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If


            'decima cuarta fila
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2201" And CStr(row.Cells(4).Value) <= "2300") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2201") & "','" & ("2300") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'decima quinta fila
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2301" And CStr(row.Cells(4).Value) <= "2400") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2301") & "','" & ("2400") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'decima sexta fila
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2401" And CStr(row.Cells(4).Value) <= "2500") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2401") & "','" & ("2500") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'decima septima fila
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2501" And CStr(row.Cells(4).Value) <= "2600") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2501") & "','" & ("2600") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

            'decima octava fila
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If
            If (CStr(row.Cells(4).Value) >= "2601" And CStr(row.Cells(4).Value) <= "2700") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "45 MM") And (CStr(row.Cells(7).Value) = "PIRITA" Or CStr(row.Cells(7).Value) = "CAFE MORO" Or CStr(row.Cells(7).Value) = "CASCARA DE HUEVO" Or CStr(row.Cells(7).Value) = "GOLDEN" Or CStr(row.Cells(7).Value) = "NOGAL" Or CStr(row.Cells(7).Value) = "GRIS ANTRAFITA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala2 ('" & ("2601") & "','" & ("2700") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0)
                valorprecio = Val(row1("Precio"))
                row.Cells.Item("VALOR").Value = valorprecio : End If

        Next
    End Sub
End Module
