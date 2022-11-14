Module Modulo_Escala3_L55_BBP_P2
    Dim valorprecio As Long
    Sub calculo_escala3_parte2()
        For Each row As DataGridViewRow In Cotizador.Tabla_Nota.Rows

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3701" And CStr(row.Cells(4).Value) <= "3800") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3701") & "','" & ("3800") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If



            'treinta fila
            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3801" And CStr(row.Cells(4).Value) <= "3900") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3801") & "','" & ("3900") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            'treinta una fila
            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "3901" And CStr(row.Cells(4).Value) <= "4000") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("3901") & "','" & ("4000") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            'treinta dos fila
            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4001" And CStr(row.Cells(4).Value) <= "4100") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4001") & "','" & ("4100") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If



            'treinta tres fila
            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4101" And CStr(row.Cells(4).Value) <= "4200") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4101") & "','" & ("4200") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If



            'treinta cuarta fila
            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4201" And CStr(row.Cells(4).Value) <= "4300") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4201") & "','" & ("4300") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If



            'treinta quinta fila
            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4301" And CStr(row.Cells(4).Value) <= "4400") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4301") & "','" & ("4400") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            'treinta sexta fila

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4401" And CStr(row.Cells(4).Value) <= "4500") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4401") & "','" & ("4500") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4501" And CStr(row.Cells(4).Value) <= "4600") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4501") & "','" & ("4600") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4601" And CStr(row.Cells(4).Value) <= "4700") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4601") & "','" & ("4700") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4701" And CStr(row.Cells(4).Value) <= "4800") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4701") & "','" & ("4800") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4801" And CStr(row.Cells(4).Value) <= "4900") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4801") & "','" & ("4900") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "4901" And CStr(row.Cells(4).Value) <= "5000") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("4901") & "','" & ("5000") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5001" And CStr(row.Cells(4).Value) <= "5100") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5001") & "','" & ("5100") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5101" And CStr(row.Cells(4).Value) <= "5200") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5101") & "','" & ("5200") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5201" And CStr(row.Cells(4).Value) <= "5300") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5201") & "','" & ("5300") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5301" And CStr(row.Cells(4).Value) <= "5400") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5301") & "','" & ("5400") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5401" And CStr(row.Cells(4).Value) <= "5500") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5401") & "','" & ("5500") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5501" And CStr(row.Cells(4).Value) <= "5600") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5501") & "','" & ("5600") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5601" And CStr(row.Cells(4).Value) <= "5700") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5601") & "','" & ("5700") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "0001" And CStr(row.Cells(5).Value) <= "1000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("0001") & "','" & ("1000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "1001" And CStr(row.Cells(5).Value) <= "1100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("1001") & "','" & ("1100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "1101" And CStr(row.Cells(5).Value) <= "1200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("1101") & "','" & ("1200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "1201" And CStr(row.Cells(5).Value) <= "1300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("1201") & "','" & ("1300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "1301" And CStr(row.Cells(5).Value) <= "1400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("1301") & "','" & ("1400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "1401" And CStr(row.Cells(5).Value) <= "1500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("1401") & "','" & ("1500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "1501" And CStr(row.Cells(5).Value) <= "1600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("1501") & "','" & ("1600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "1601" And CStr(row.Cells(5).Value) <= "1700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("1601") & "','" & ("1700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "1701" And CStr(row.Cells(5).Value) <= "1800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("1701") & "','" & ("1800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "1801" And CStr(row.Cells(5).Value) <= "1900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("1801") & "','" & ("1900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "1901" And CStr(row.Cells(5).Value) <= "2000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("1901") & "','" & ("2000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "2001" And CStr(row.Cells(5).Value) <= "2100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("2001") & "','" & ("2100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "2101" And CStr(row.Cells(5).Value) <= "2200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("2101") & "','" & ("2200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "2201" And CStr(row.Cells(5).Value) <= "2300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("2201") & "','" & ("2300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "2301" And CStr(row.Cells(5).Value) <= "2400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("2301") & "','" & ("2400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "2401" And CStr(row.Cells(5).Value) <= "2500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("2401") & "','" & ("2500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "2501" And CStr(row.Cells(5).Value) <= "2600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("2501") & "','" & ("2600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "2601" And CStr(row.Cells(5).Value) <= "2700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("2601") & "','" & ("2700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "2701" And CStr(row.Cells(5).Value) <= "2800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("2701") & "','" & ("2800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "2801" And CStr(row.Cells(5).Value) <= "2900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("2801") & "','" & ("2900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "2901" And CStr(row.Cells(5).Value) <= "3000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("2901") & "','" & ("3000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "3001" And CStr(row.Cells(5).Value) <= "3100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("3001") & "','" & ("3100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "3101" And CStr(row.Cells(5).Value) <= "3200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("3101") & "','" & ("3200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "3201" And CStr(row.Cells(5).Value) <= "3300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("3201") & "','" & ("3300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "3301" And CStr(row.Cells(5).Value) <= "3400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("3301") & "','" & ("3400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "3401" And CStr(row.Cells(5).Value) <= "3500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("3401") & "','" & ("3500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "3501" And CStr(row.Cells(5).Value) <= "3600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("3501") & "','" & ("3600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "3601" And CStr(row.Cells(5).Value) <= "3700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("3601") & "','" & ("3700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "3701" And CStr(row.Cells(5).Value) <= "3800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("3701") & "','" & ("3800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "3801" And CStr(row.Cells(5).Value) <= "3900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("3801") & "','" & ("3900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "3901" And CStr(row.Cells(5).Value) <= "4000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("3901") & "','" & ("4000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "4001" And CStr(row.Cells(5).Value) <= "4100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("4001") & "','" & ("4100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "4101" And CStr(row.Cells(5).Value) <= "4200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("4101") & "','" & ("4200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "4201" And CStr(row.Cells(5).Value) <= "4300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("4201") & "','" & ("4300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "4301" And CStr(row.Cells(5).Value) <= "4400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("4301") & "','" & ("4400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If


            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "4401" And CStr(row.Cells(5).Value) <= "4500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("4401") & "','" & ("4500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "4501" And CStr(row.Cells(5).Value) <= "4600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("4501") & "','" & ("4600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "4601" And CStr(row.Cells(5).Value) <= "4700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("4601") & "','" & ("4700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "4701" And CStr(row.Cells(5).Value) <= "4800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("4701") & "','" & ("4800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "4801" And CStr(row.Cells(5).Value) <= "4900") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("4801") & "','" & ("4900") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "4901" And CStr(row.Cells(5).Value) <= "5000") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("4901") & "','" & ("5000") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "5001" And CStr(row.Cells(5).Value) <= "5100") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("5001") & "','" & ("5100") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "5101" And CStr(row.Cells(5).Value) <= "5200") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("5101") & "','" & ("5200") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "5201" And CStr(row.Cells(5).Value) <= "5300") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("5201") & "','" & ("5300") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "5301" And CStr(row.Cells(5).Value) <= "5400") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("5301") & "','" & ("5400") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "5401" And CStr(row.Cells(5).Value) <= "5500") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("5401") & "','" & ("5500") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "5501" And CStr(row.Cells(5).Value) <= "5600") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("5501") & "','" & ("5600") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "5601" And CStr(row.Cells(5).Value) <= "5700") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("5601") & "','" & ("5700") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

            If (CStr(row.Cells(4).Value) >= "5701" And CStr(row.Cells(4).Value) <= "5800") And (CStr(row.Cells(5).Value) >= "5701" And CStr(row.Cells(5).Value) <= "5800") And (CStr(row.Cells(6).Value) = "55 MM") And (CStr(row.Cells(7).Value) = "BLANCO" Or CStr(row.Cells(7).Value) = "BRONCE" Or CStr(row.Cells(7).Value) = "PLATA") Then
                Consulta2("Call Calculo_Ancho_Alto_Escala3 ('" & ("5701") & "','" & ("5800") & "','" & ("5701") & "','" & ("5800") & "')")
                Dim row1 As DataRow = DT2.Rows(0) : valorprecio = Val(row1("Precio")) : row.Cells.Item("VALOR").Value = valorprecio : End If

        Next
    End Sub
End Module